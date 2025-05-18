Imports System.Data.Odbc

Public Class frmTestConnection
    Private Sub frmTestConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Define the connection string
        Dim connString As String = "Driver={MySQL ODBC 9.3 Unicode Driver};Server=localhost;Database=assetinventorydb;User=root;Password=;"

        Try
            ' Create a new connection using the ODBC connection string
            Using conn As New OdbcConnection(connString)
                ' Open the connection
                conn.Open()
                ' If successful, show a message
                MessageBox.Show("Connection Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            ' If there's an error, show an error message
            MessageBox.Show("Connection Failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
