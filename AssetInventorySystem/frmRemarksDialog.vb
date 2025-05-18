Imports MySql.Data.MySqlClient

Public Class frmRemarksDialog
    Public Property RequestID As Integer
    Public Property ApproverStatus As String

    Dim con As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Validation
        If String.IsNullOrEmpty(txtRemarks.Text) Then
            MessageBox.Show("Please enter remarks.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(GlobalVariables.LoggedInEmployeeName) Then
            MessageBox.Show("Logged-in user is missing. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(lblStatus.Text) Then
            MessageBox.Show("Status is missing. Please ensure the status is set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If RequestID <= 0 Then
            MessageBox.Show("Invalid RequestID. Please select a valid request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Determine which approver is logged in
        Dim approverColumn As String = ""
        Dim statusColumn As String = ""
        Dim remarksColumn As String = ""

        If GlobalVariables.LoggedInRoleNames.Contains("Approver1") Then
            approverColumn = "Approver1"
            statusColumn = "Approver1Status"
            remarksColumn = "ApproverRemarks1"
        ElseIf GlobalVariables.LoggedInRoleNames.Contains("Approver2") Then
            approverColumn = "Approver2"
            statusColumn = "Approver2Status"
            remarksColumn = "ApproverRemarks2"
        ElseIf GlobalVariables.LoggedInRoleNames.Contains("Approver3") Then
            approverColumn = "Approver3"
            statusColumn = "Approver3Status"
            remarksColumn = "ApproverRemarks3"
        Else
            MessageBox.Show("You are not authorized to approve this request.", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Step 1: Update current approver's status and remarks
        Try
            Using con = GetConnection()
                con.Open()
                Dim updateQuery = $"UPDATE assetrequesttable SET {approverColumn} = @Approver, {statusColumn} = @Status, {remarksColumn} = @Remarks WHERE RequestID = @RequestID"

                Using cmd As New MySqlCommand(updateQuery, con)
                    cmd.Parameters.AddWithValue("@Approver", GlobalVariables.LoggedInEmployeeName)
                    cmd.Parameters.AddWithValue("@Status", lblStatus.Text)
                    cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)
                    cmd.Parameters.AddWithValue("@RequestID", RequestID)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving approver data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        ' Step 2: Re-fetch approver statuses after update
        Dim approver1Status As String = "", approver2Status As String = "", approver3Status As String = ""
        Try
            Using con = GetConnection()
                con.Open()
                Dim query As String = "SELECT Approver1Status, Approver2Status, Approver3Status FROM assetrequesttable WHERE RequestID = @RequestID"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@RequestID", RequestID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            approver1Status = reader("Approver1Status").ToString()
                            approver2Status = reader("Approver2Status").ToString()
                            approver3Status = reader("Approver3Status").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching updated statuses: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        ' Step 3: Determine final status and remarks
        Dim finalStatus As String = "", finalRemarks As String = ""
        If approver1Status = "Approved" AndAlso approver2Status = "Approved" AndAlso approver3Status = "Approved" Then
            finalStatus = "Approved"
            finalRemarks = "Your request has been approved by all approvers. Congratulations!"
        ElseIf approver1Status = "Denied" OrElse approver2Status = "Denied" OrElse approver3Status = "Denied" Then
            finalStatus = "Denied"
            finalRemarks = "Your request has been denied by one or more approvers."
        ElseIf approver1Status = "Pending" OrElse approver2Status = "Pending" OrElse approver3Status = "Pending" Then
            finalStatus = "Pending"
            finalRemarks = "Your request is still pending approval from one or more approvers."
        Else
            finalStatus = "May Mali sa Coding"
            finalRemarks = "May Mali sa Coding"
        End If

        ' Step 4: Update FinalStatus and FinalRemarks
        Try
            Using con = GetConnection()
                con.Open()
                Dim updateFinalQuery As String = "UPDATE assetrequesttable SET FinalStatus = @FinalStatus, FinalRemarks = @FinalRemarks WHERE RequestID = @RequestID"

                Using cmd As New MySqlCommand(updateFinalQuery, con)
                    cmd.Parameters.AddWithValue("@FinalStatus", finalStatus)
                    cmd.Parameters.AddWithValue("@FinalRemarks", finalRemarks)
                    cmd.Parameters.AddWithValue("@RequestID", RequestID)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating final status/remarks: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        MessageBox.Show("The request has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
