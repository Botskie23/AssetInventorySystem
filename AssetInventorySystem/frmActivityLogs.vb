Imports MySql.Data.MySqlClient

Public Class frmActivityLogs

    Private Sub InitializeGrid()
        With dgvLogs
            .ColumnCount = 3
            .Columns(0).Name = "Activity"
            .Columns(1).Name = "Performed By"
            .Columns(2).Name = "Log Date"
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(1).Width = 150
            .Columns(2).Width = 180
        End With
    End Sub


    Private Sub LoadLogs()
        dgvLogs.Rows.Clear()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim query As String = "SELECT Activity, PerformedBy, LogDate FROM activitylogs ORDER BY LogDate DESC"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        dgvLogs.Rows.Add(reader("Activity"), reader("PerformedBy"), reader("LogDate"))
                    End While
                End Using
            End Using
        End Using
    End Sub



    Private Sub LoadLogs(Optional keyword As String = "")
        dgvLogs.Rows.Clear()

        Dim query As String = "SELECT Activity, PerformedBy, LogDate FROM activitylogs"
        If keyword <> "" Then
            query &= " WHERE Activity LIKE @keyword OR PerformedBy LIKE @keyword"
        End If
        query &= " ORDER BY LogDate DESC"

        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                If keyword <> "" Then
                    cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        dgvLogs.Rows.Add(reader("Activity").ToString(), reader("PerformedBy").ToString(), reader("LogDate").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub frmActivityLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeGrid()
        LoadLogs()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadLogs(txtSearch.Text.Trim())
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadLogs(txtSearch.Text.Trim())
    End Sub

End Class