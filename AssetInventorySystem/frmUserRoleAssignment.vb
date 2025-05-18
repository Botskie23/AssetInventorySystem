Imports MySql.Data.MySqlClient

Public Class frmUserRoleAssignment

    ' Load employees and roles into the form
    Private Sub frmUserRoleAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployees()
        LoadRoles()
        cmbPrimaryRole.Enabled = False
    End Sub

    ' Load all employees into the combo box
    Private Sub LoadEmployees()
        cmbEmployee.Items.Clear()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim query As String = "SELECT EmployeeID, CONCAT(FirstName, ' ', LastName) AS FullName FROM employeeprofile"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbEmployee.Items.Add(New With {.ID = reader("EmployeeID"), .Name = reader("FullName").ToString()})
                    End While
                End Using
            End Using
        End Using
        cmbEmployee.DisplayMember = "Name"
        cmbEmployee.ValueMember = "ID"
    End Sub

    ' Load all roles into the CheckedListBox and combo box for primary role selection
    Private Sub LoadRoles()
        clbRoles.Items.Clear()
        cmbPrimaryRole.Items.Clear()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim query As String = "SELECT RoleID, RoleName FROM roles ORDER BY RoleName"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim roleItem = New With {.ID = reader("RoleID"), .Name = reader("RoleName").ToString()}
                        clbRoles.Items.Add(roleItem)
                        cmbPrimaryRole.Items.Add(roleItem)
                    End While
                End Using
            End Using
        End Using
        clbRoles.DisplayMember = "Name"
        cmbPrimaryRole.DisplayMember = "Name"
    End Sub

    ' Handle employee selection change
    Private Sub cmbEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmployee.SelectedIndexChanged
        If cmbEmployee.SelectedItem Is Nothing Then Exit Sub
        Dim selectedEmployeeID = CType(cmbEmployee.SelectedItem, Object).ID

        ' Clear selections
        For i As Integer = 0 To clbRoles.Items.Count - 1
            clbRoles.SetItemChecked(i, False)
        Next
        cmbPrimaryRole.SelectedIndex = -1
        cmbPrimaryRole.Enabled = False

        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim query As String = "SELECT RoleID, IsPrimary FROM employeeroles WHERE EmployeeID = @EmployeeID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EmployeeID", selectedEmployeeID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim roleID = Convert.ToInt32(reader("RoleID"))
                        Dim isPrimary = Convert.ToBoolean(reader("IsPrimary"))

                        ' Check roles
                        For i As Integer = 0 To clbRoles.Items.Count - 1
                            Dim roleItem = CType(clbRoles.Items(i), Object)
                            If roleItem.ID = roleID Then
                                clbRoles.SetItemChecked(i, True)
                            End If
                        Next

                        ' Set primary
                        If isPrimary Then
                            For i As Integer = 0 To cmbPrimaryRole.Items.Count - 1
                                Dim roleItem = CType(cmbPrimaryRole.Items(i), Object)
                                If roleItem.ID = roleID Then
                                    cmbPrimaryRole.SelectedIndex = i
                                    cmbPrimaryRole.Enabled = True
                                    Exit For
                                End If
                            Next
                        End If
                    End While
                End Using
            End Using
        End Using
    End Sub

    ' Handle item check/uncheck event in CheckedListBox
    Private Sub clbRoles_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbRoles.ItemCheck
        Me.BeginInvoke(Sub()
                           Dim hasChecked As Boolean = clbRoles.CheckedItems.Count > 0 OrElse e.NewValue = CheckState.Checked
                           cmbPrimaryRole.Enabled = hasChecked
                       End Sub)
    End Sub

    ' Save roles assigned to the selected employee
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbEmployee.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an employee.")
            Return
        End If

        Dim employeeID = CType(cmbEmployee.SelectedItem, Object).ID

        ' Get selected roles
        Dim selectedRoles As New List(Of Integer)
        For Each checkedItem In clbRoles.CheckedItems
            selectedRoles.Add(checkedItem.ID)
        Next

        If selectedRoles.Count = 0 Then
            MessageBox.Show("Please select at least one role.")
            Return
        End If

        If cmbPrimaryRole.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a primary role.")
            Return
        End If

        Dim primaryRoleID = CType(cmbPrimaryRole.SelectedItem, Object).ID
        If Not selectedRoles.Contains(primaryRoleID) Then
            MessageBox.Show("Primary role must be among the selected roles.")
            Return
        End If

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            ' Delete existing roles for employee
            Dim deleteQuery As String = "DELETE FROM employeeroles WHERE EmployeeID = @EmployeeID"
            Using deleteCmd As New MySqlCommand(deleteQuery, conn)
                deleteCmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                deleteCmd.ExecuteNonQuery()
            End Using

            ' Insert new roles
            For Each roleID In selectedRoles
                Dim insertQuery As String = "INSERT INTO employeeroles (EmployeeID, RoleID, IsPrimary) VALUES (@EmployeeID, @RoleID, @IsPrimary)"
                Using insertCmd As New MySqlCommand(insertQuery, conn)
                    insertCmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                    insertCmd.Parameters.AddWithValue("@RoleID", roleID)
                    insertCmd.Parameters.AddWithValue("@IsPrimary", If(roleID = primaryRoleID, 1, 0))
                    insertCmd.ExecuteNonQuery()
                End Using
            Next
        End Using

        MessageBox.Show("Roles updated successfully.")
    End Sub

End Class
