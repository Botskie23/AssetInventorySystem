Imports System.IO
Imports System.Diagnostics
Imports MySql.Data.MySqlClient

Public Class frmSystemConfiguration

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        If Not IsCommandAvailable("mysqldump") Then
            MessageBox.Show("mysqldump is not found. Please ensure MySQL is installed and added to system PATH.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "SQL Files (*.sql)|*.sql"
            saveFileDialog.Title = "Save Backup File"
            saveFileDialog.FileName = "assetinventorydb_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".sql"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                BackupDatabase(saveFileDialog.FileName)
            End If
        End Using
        LogActivity("System Backup", LoggedInEmployeeName)
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        If Not IsCommandAvailable("mysql") Then
            MessageBox.Show("mysql command is not found. Please ensure MySQL is installed and added to system PATH.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "SQL Files (*.sql)|*.sql"
            openFileDialog.Title = "Select Backup File"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Confirm restore action
                Dim result = MessageBox.Show("This will overwrite the current database. Do you want to continue?", "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    ' Call RestoreDatabase method
                    RestoreDatabase(openFileDialog.FileName)
                End If
            End If
        End Using
        LogActivity("Restore Backup", LoggedInEmployeeName)
    End Sub

    Private Sub RestoreDatabase(backupFilePath As String)
        Try
            ' Specify your database credentials
            Dim mysqlUser As String = "root" ' Your MySQL username
            Dim mysqlPassword As String = "" ' Your MySQL password (empty if none)
            Dim mysqlHost As String = "localhost" ' Your MySQL server host
            Dim databaseName As String = "assetinventorydb" ' Your database name

            ' Command to restore the database
            Dim restoreCommand As String = $"mysql --user={mysqlUser} --password={mysqlPassword} --host={mysqlHost} {databaseName} < ""{backupFilePath}"""

            ' Run the restore command
            Dim processInfo As New ProcessStartInfo("cmd.exe", $"/c {restoreCommand}")
            processInfo.RedirectStandardOutput = True
            processInfo.UseShellExecute = False
            processInfo.CreateNoWindow = True

            Dim process As Process = Process.Start(processInfo)
            process.WaitForExit()

            ' Show success message
            MessageBox.Show("Database restore completed successfully.", "Restore Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error during database restore: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub BackupDatabase(backupFile As String)
        Try
            Dim backupCommand As String = $"mysqldump --user=root --password= --host=localhost assetinventorydb > ""{backupFile}"""

            Dim process As New Process()
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/C " & backupCommand
            process.StartInfo.RedirectStandardOutput = True
            process.StartInfo.RedirectStandardError = True
            process.StartInfo.UseShellExecute = False
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()

            If process.ExitCode = 0 Then
                MessageBox.Show("Backup completed successfully!" & vbCrLf & "Saved at: " & backupFile)
            Else
                Dim errorMsg = process.StandardError.ReadToEnd()
                MessageBox.Show("Backup failed!" & vbCrLf & errorMsg)
            End If
        Catch ex As Exception
            MessageBox.Show("Error during backup: " & ex.Message)
        End Try
    End Sub



    Private Function IsCommandAvailable(command As String) As Boolean
        Try
            Dim process As New Process()
            process.StartInfo.FileName = "cmd"
            process.StartInfo.Arguments = $"/C {command} --version"
            process.StartInfo.RedirectStandardOutput = True
            process.StartInfo.UseShellExecute = False
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            Return process.ExitCode = 0
        Catch
            Return False
        End Try
    End Function

    Private Sub btnGenerateBackupScript_Click(sender As Object, e As EventArgs) Handles btnGenerateBackupScript.Click
        CreateBackupBatFile()
    End Sub

    Private Sub CreateBackupBatFile()
        Try
            ' Custom backup folder
            Dim backupFolder As String = "D:\Backups AIS"
            Dim batFilePath As String = Path.Combine(backupFolder, "backup_assetinventorydb.bat")

            ' Siguraduhin na may folder
            If Not Directory.Exists(backupFolder) Then
                Directory.CreateDirectory(backupFolder)
            End If

            ' Generate .bat file content
            Dim batContent As String = "@echo off" & Environment.NewLine &
                "set TIMESTAMP=%DATE:~10,4%%DATE:~4,2%%DATE:~7,2%_%TIME:~0,2%%TIME:~3,2%%TIME:~6,2%" & Environment.NewLine &
                "set BACKUPFILE=" & Chr(34) & backupFolder & "\assetinventorydb_%TIMESTAMP%.sql" & Chr(34) & Environment.NewLine &
                "mysqldump --user=root --password= --host=localhost assetinventorydb > %BACKUPFILE%" & Environment.NewLine

            ' Save the .bat file
            File.WriteAllText(batFilePath, batContent)

            MessageBox.Show("Backup .bat file created successfully at: " & batFilePath)
        Catch ex As Exception
            MessageBox.Show("Error creating .bat file: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSetupAutoBackup_Click(sender As Object, e As EventArgs) Handles btnSetupAutoBackup.Click
        Try
            Dim taskName As String = "AIS_AutoBackup"
            Dim batFilePath As String = "D:\Backups AIS\backup_assetinventorydb.bat"

            If Not File.Exists(batFilePath) Then
                MessageBox.Show("Backup script not found. Please generate the .bat file first.")
                Return
            End If

            ' Schedule: Daily at 7:00 AM
            Dim arguments As String = $"/Create /SC DAILY /TN ""{taskName}"" /TR ""{batFilePath}"" /ST 07:00"

            Dim startInfo As New ProcessStartInfo("schtasks.exe", arguments)
            startInfo.RedirectStandardOutput = True
            startInfo.RedirectStandardError = True
            startInfo.UseShellExecute = False
            startInfo.CreateNoWindow = True
            startInfo.Verb = "runas" ' run as admin

            Using process As Process = Process.Start(startInfo)
                Dim output As String = process.StandardOutput.ReadToEnd()
                Dim errorOutput As String = process.StandardError.ReadToEnd()
                process.WaitForExit()

                If process.ExitCode = 0 Then
                    MessageBox.Show("Automated backup task created successfully.")
                Else
                    MessageBox.Show("Failed to create scheduled task:" & Environment.NewLine & errorOutput)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error setting up scheduled backup: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAccountManagement_Click(sender As Object, e As EventArgs)
        frmAddEditUser.Show()
    End Sub

    Private Sub btnShowActivityLog_Click(sender As Object, e As EventArgs) Handles btnShowActivityLog.Click
        frmActivityLogs.Show()

    End Sub

    Private Sub btnSystemReset_Click(sender As Object, e As EventArgs) Handles btnSystemReset.Click
        ' Step 1: Show the admin password confirmation form
        Dim confirmForm As New frmConfirmReset()
        confirmForm.ShowDialog()

        If Not confirmForm.IsAuthorized Then
            MessageBox.Show("System reset cancelled. Authorization failed.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Step 2: Ask final confirmation
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to reset the system? This will delete ALL data!",
            "Confirm System Reset",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If result <> DialogResult.Yes Then Exit Sub

        ' Step 3: Execute reset
        Try
            Using conn = GetConnection()
                conn.Open()

                ' Temporarily disable foreign key checks
                Dim disableCmd As New MySqlCommand("SET FOREIGN_KEY_CHECKS=0;", conn)
                disableCmd.ExecuteNonQuery()

                ' List of all tables to truncate (match exact table names in your DB)
                Dim tables As String() = {
                    "activitylogs", "assetassignments", "assetdisposaltable", "assetevaluationtable",
                    "assetrequesttable", "assetreturntable", "employeeprofile", "employeeroles",
                    "itassettable", "loginattempts", "maincategory", "mainclassificationtable",
                    "mainlocationtable", "notifications", "repairrequesttable", "roles",
                    "softwareassignmenttable", "softwarerequeststable", "softwaretable", "statustable",
                    "subcategory", "subclassificationtable", "sublocationtable", "suppliertable",
                    "view_assetrequests_with_employee"
                }

                ' Truncate each table in the list
                For Each tableName In tables
                    Dim cmd As New MySqlCommand($"TRUNCATE TABLE `{tableName}`;", conn)
                    cmd.ExecuteNonQuery()
                Next

                ' Reset employeeprofile table and add default admin
                Dim resetEmpCmd As New MySqlCommand("TRUNCATE TABLE employeeprofile;", conn)
                resetEmpCmd.ExecuteNonQuery()

                Dim insertAdminCmd As New MySqlCommand("
                INSERT INTO employeeprofile 
                (FullName, Username, Password, Role, ContactNumber, Department, Designation)
                VALUES 
                ('System Administrator', 'admin', 'admin123', 'Administrator', 'N/A', 'IT', 'Admin');
            ", conn)
                insertAdminCmd.ExecuteNonQuery()

                ' Re-enable foreign key checks
                Dim enableCmd As New MySqlCommand("SET FOREIGN_KEY_CHECKS=1;", conn)
                enableCmd.ExecuteNonQuery()

                MessageBox.Show("System reset complete. All data has been deleted and the default admin restored.", "Reset Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("System reset failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
