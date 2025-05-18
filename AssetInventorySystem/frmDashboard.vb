Imports MySql.Data.MySqlClient
Imports System.Speech.Synthesis
Imports System.Timers
Imports MimeKit
Imports MailKit.Net.Smtp
Imports MailKit.Security
Imports Guna.UI2.WinForms.Suite


Public Class frmDashboard
    Private connectionString As String = "server=localhost;userid=root;password=;database=assetinventorydb;"
    Private synth As New SpeechSynthesizer()
    Private refreshTimer As New Windows.Forms.Timer()
    Private emailTimer As New Windows.Forms.Timer()



    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        With dgvWarrantyDetails
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 12, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersHeight = 40
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing


            ' Center-align the second column (index 1)
            If .Columns.Count > 1 Then
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If
        End With
        With dgvAssignedAssetsPerBranch
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 12, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersHeight = 40
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing


            ' Center-align the second column (index 1)
            If .Columns.Count > 1 Then
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If
        End With
        If dgvWarrantyDetails.Columns.Count = 0 Then
            dgvWarrantyDetails.Columns.Add("AssetID", "Asset ID") ' Hidden column
            dgvWarrantyDetails.Columns("AssetID").Visible = False

            dgvWarrantyDetails.Columns.Add("AssetCode", "Asset Code")
            dgvWarrantyDetails.Columns.Add("AssetName", "Asset Name")
            dgvWarrantyDetails.Columns.Add("ExpiryPeriod", "Expiry Period")
        End If

        ' Start 1-minute timer
        refreshTimer.Interval = 10800000 ' 60,000 ms = 1 minute
        AddHandler refreshTimer.Tick, AddressOf RefreshDashboard
        refreshTimer.Start()
        ' Email notification timer
        emailTimer.Interval = 100 ' 5 minutes
        AddHandler emailTimer.Tick, AddressOf EmailTimer_Tick
        emailTimer.Start()




        ' Initial load
        CheckWarrantyExpiries()
        LoadAssignedAssetsPerBranch()
        LoadPendingEvaluations()

    End Sub
    Private Sub CheckForNewEmails(sender As Object, e As EventArgs)
        Try
            Dim unreadEmails = GetUnreadEmails() ' This should return a list or count of unread messages
            picEnvelopeIcon.Visible = (unreadEmails.Count > 0)
        Catch ex As Exception
            Console.WriteLine("Error checking emails: " & ex.Message)
        End Try
    End Sub

    Private Async Sub EmailTimer_Tick(sender As Object, e As EventArgs)
        emailTimer.Stop()

        Await Task.Run(Sub()
                           Dim unreadEmails = GetUnreadEmails()
                           Me.Invoke(Sub()
                                         picEnvelopeIcon.Visible = (unreadEmails.Count > 0)
                                         ' Show count in label
                                         lblEmailCount.Text = $"Emails {unreadEmails.Count}"
                                     End Sub)
                       End Sub)

        emailTimer.Start()
    End Sub




    Private Function GetUnreadEmails() As List(Of String)
        Dim unreadEmails As New List(Of String)

        Try
            Using client As New MailKit.Net.Imap.ImapClient()
                ' Connect to the mail server
                client.Connect("imap.gmail.com", 993, MailKit.Security.SecureSocketOptions.SslOnConnect)

                ' Authenticate with your email credentials
                client.Authenticate("balboaryanoliver@gmail.com", "percowsqptjarqno")

                ' Select the Inbox
                Dim inbox = client.Inbox
                inbox.Open(MailKit.FolderAccess.ReadOnly)

                ' Get unread messages
                For Each uid In inbox.Search(MailKit.Search.SearchQuery.NotSeen)
                    Dim message = inbox.GetMessage(uid)
                    unreadEmails.Add(message.Subject)
                Next

                client.Disconnect(True)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking unread emails: " & ex.Message)
        End Try

        Return unreadEmails
    End Function


    Private Sub picEnvelopeIcon_Click(sender As Object, e As EventArgs) Handles picEnvelopeIcon.Click
        Dim emailForm As New frmEmailList()
        emailForm.Show()
    End Sub


    Private Sub RefreshDashboard(sender As Object, e As EventArgs)
        CheckWarrantyExpiries()
    End Sub

    Private Sub CheckWarrantyExpiries()
        lblWarrantyNotification.Text = "You have 0 assets with expiring warranties."
        dgvWarrantyDetails.Rows.Clear()

        Dim query As String = "SELECT AssetID, AssetCode, AssetName, WarrantyEndDate FROM ITAssetTable WHERE WarrantyEndDate IS NOT NULL AND Notified = 0"

        Using conn As New MySqlConnection(connectionString),
          cmd As New MySqlCommand(query, conn)

            Try
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    Dim expiryCount As Integer = 0
                    While reader.Read()
                        Dim assetID As Integer = reader.GetInt32("AssetID")
                        Dim assetCode As String = reader.GetString("AssetCode")
                        Dim assetName As String = reader.GetString("AssetName")
                        Dim warrantyEndDate As Date = reader.GetDateTime("WarrantyEndDate")

                        Dim today As Date = DateTime.Now.Date
                        Dim daysToExpiry As Integer = (warrantyEndDate.Date - today).Days

                        If daysToExpiry <= 90 AndAlso daysToExpiry > 60 Then
                            AddWarrantyNotification(assetID, assetCode, assetName, "3 months")
                            expiryCount += 1
                        ElseIf daysToExpiry <= 60 AndAlso daysToExpiry > 30 Then
                            AddWarrantyNotification(assetID, assetCode, assetName, "2 months")
                            expiryCount += 1
                        ElseIf daysToExpiry <= 3 AndAlso daysToExpiry > 0 Then
                            AddWarrantyNotification(assetID, assetCode, assetName, "3 days")
                            expiryCount += 1
                        ElseIf daysToExpiry = 0 Then
                            AddWarrantyNotification(assetID, assetCode, assetName, "on expiry date")
                            expiryCount += 1
                        ElseIf daysToExpiry < 0 Then
                            AddWarrantyNotification(assetID, assetCode, assetName, $"{Math.Abs(daysToExpiry)} days overdue")
                            expiryCount += 1
                        End If
                    End While

                    lblWarrantyNotification.Text = $"You have {expiryCount} assets with expiring warranties."

                    If expiryCount > 0 Then
                        synth.SpeakAsync(lblWarrantyNotification.Text)
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error checking warranty expiry: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub AddWarrantyNotification(assetID As Integer, assetCode As String, assetName As String, expiryPeriod As String)
        Try
            dgvWarrantyDetails.Rows.Add(assetID, assetCode, assetName, expiryPeriod)
            dgvWarrantyDetails.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error adding row: " & ex.Message)
        End Try
    End Sub

    Private Sub MarkAsNotified(assetID As Integer)
        Dim query As String = "UPDATE ITAssetTable SET Notified = 1 WHERE AssetID = @AssetID"

        Using conn As New MySqlConnection(connectionString),
              cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@AssetID", assetID)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As MySqlException
                MessageBox.Show("Error marking asset as notified: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub





    Private Sub LoadAssignedAssetsPerBranch()
        Try
            Dim query As String = "
            SELECT 
                ml.MainLocationName AS 'Branch',
                COUNT(aa.AssetID) AS 'Assigned Assets'
            FROM 
                assetassignments aa
            JOIN 
                mainlocationtable ml ON aa.MainLocationID = ml.MainLocationID
            GROUP BY 
                ml.MainLocationName
            ORDER BY 
                COUNT(aa.AssetID) DESC;
        "

            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvAssignedAssetsPerBranch.DataSource = table
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading assigned asset counts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMarkAsNotified_Click(sender As Object, e As EventArgs) Handles btnMarkAsNotified.Click
        If dgvWarrantyDetails.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvWarrantyDetails.SelectedRows(0)
            Dim assetID As Integer = Convert.ToInt32(selectedRow.Cells("AssetID").Value)

            If MessageBox.Show("Are you sure you want to mark this asset as notified?", "Mark as Notified", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                MarkAsNotified(assetID)
                CheckWarrantyExpiries()
                MessageBox.Show("Asset marked as notified.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please select an asset to mark as notified.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnTestAddEmail_Click(sender As Object, e As EventArgs)
        ' Test adding an email with the required body text
        EmailManager.AddEmail("Test Subject", "testsender@example.com", "This is the body of the email.")

        ' Show a message box to confirm email was added
        MessageBox.Show("Email added!")
    End Sub

    Public Sub StopEmailTimer()
        If emailTimer IsNot Nothing Then
            emailTimer.Stop()
            emailTimer.Dispose()
        End If
    End Sub

    Private Sub LoadPendingEvaluations()
        Dim query As String = "
    SELECT ia.AssetCode, ia.AssetName, ar.ConditionOnReturn, ar.ReturnDate
    FROM assetreturntable ar
    JOIN itassettable ia ON ar.AssetCode = ia.AssetCode
    WHERE ar.ConditionOnReturn IN ('Damaged', 'Needs Repair')
    AND NOT EXISTS (
        SELECT 1 FROM assetevaluationtable ae
        WHERE ae.AssetCode = ia.AssetCode
    )"

        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvPendingEvaluations.DataSource = table
            End Using
        End Using
    End Sub

End Class
