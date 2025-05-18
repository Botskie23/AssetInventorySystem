Public Class frmEmailList
    Private printBody As String = ""

    ' Declare PrintPreviewDialog1 and PrintDocument1 at the class level


    Private Sub LoadUnreadEmails()
        dgvEmails.Rows.Clear()

        ' Load from source
        Dim emails = EmailHelper.GetUnreadEmailList()

        ' Only add emails that are not read
        For Each email In emails
            If Not email.IsRead Then
                Dim rowIndex As Integer = dgvEmails.Rows.Add(email.Subject, email.Sender, email.DateReceived)
                dgvEmails.Rows(rowIndex).Tag = email
                dgvEmails.Rows(rowIndex).DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            End If
        Next
    End Sub

    Private Sub dgvEmails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmails.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedEmail As EmailHelper.EmailMessage = CType(dgvEmails.Rows(e.RowIndex).Tag, EmailHelper.EmailMessage)

            ' Display email content
            lblSubject.Text = selectedEmail.Subject
            lblSender.Text = selectedEmail.Sender
            lblDateReceived.Text = selectedEmail.DateReceived.ToString("g")
            txtEmailBody.Text = selectedEmail.Body

            ' Mark as read
            selectedEmail.IsRead = True

            ' Optional: visually update row (e.g., change row color)
            dgvEmails.Rows(e.RowIndex).DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Regular)

            ' Optional: update your data source if you're saving this info
            UpdateEmailReadStatus(selectedEmail)
        End If
    End Sub

    Private Sub UpdateEmailReadStatus(email As EmailHelper.EmailMessage)
        EmailHelper.MarkAsRead(email.UID)
    End Sub

    Private Sub ShowEmailDetails(email As EmailHelper.EmailMessage)
        lblSubject.Text = email.Subject
        lblSender.Text = email.Sender
        lblDateReceived.Text = email.DateReceived.ToString("g")
        txtEmailBody.Text = email.Body ' Assuming Body is a property of EmailMessage
    End Sub

    Private Sub btnInbox_Click(sender As Object, e As EventArgs) Handles btnInbox.Click
        ' Fetch real unread emails from Gmail
        Dim unreadEmails = EmailHelper.GetUnreadEmailList()

        ' Clear existing rows before adding new ones
        dgvEmails.Rows.Clear()

        ' If there are no emails, show a message
        If unreadEmails.Count = 0 Then
            MessageBox.Show("No unread emails.")
        End If

        ' Set up the DataGridView columns if not already set
        If dgvEmails.Columns.Count = 0 Then
            dgvEmails.Columns.Add("Subject", "Subject")
            dgvEmails.Columns.Add("Sender", "Sender")
            dgvEmails.Columns.Add("Date", "Date Received")
        End If

        ' Loop through each email and add it to the DataGridView
        For Each email In unreadEmails
            Dim rowIndex As Integer = dgvEmails.Rows.Add(email.Subject, email.Sender, email.DateReceived)
            dgvEmails.Rows(rowIndex).Tag = email ' Store the email object in the Tag property for later access
        Next
    End Sub

    Private Sub btnRefresh_Click_1(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadUnreadEmails()
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ' Button click to print email
    Private Sub btnPrintEmail_Click(sender As Object, e As EventArgs) Handles btnPrintEmail.Click
        If txtEmailBody.Text.Trim() = "" Then
            MessageBox.Show("No email content to print.")
            Return
        End If

        ' Store the content to print
        printBody = "Subject: " & lblSubject.Text & vbCrLf &
                    "From: " & lblSender.Text & vbCrLf &
                    "Date: " & lblDateReceived.Text & vbCrLf & vbCrLf &
                    txtEmailBody.Text

        ' Set the document for the print preview
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    ' Event handler for printing the document
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Define the font to use for printing
        Dim font As New Font("Segoe UI", 10)

        ' Define the rectangle where the text will be printed
        Dim rect As New RectangleF(50, 50, e.MarginBounds.Width, e.MarginBounds.Height)

        ' Draw the content (email body) on the print document
        e.Graphics.DrawString(printBody, font, Brushes.Black, rect)
    End Sub

End Class
