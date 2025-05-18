' Module: modLogger.vb
Imports MySql.Data.MySqlClient

Module modLogger
    Public Sub LogActivity(activity As String, performedBy As String)
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim query As String = "INSERT INTO activitylogs (Activity, PerformedBy) VALUES (@activity, @performedBy)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@activity", activity)
                cmd.Parameters.AddWithValue("@performedBy", performedBy)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Module
