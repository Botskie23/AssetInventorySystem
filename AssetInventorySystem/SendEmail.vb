
Imports System.Net
Imports System.Net.Mail

Module SendEmail
    Public Sub SendNotificationEmail(toEmail As String, subject As String, body As String)
        Try
            Dim fromAddress As New MailAddress("balboaryanoliver@gmail.com", "IT Asset Inventory System")
            Dim toAddress As New MailAddress(toEmail)
            Dim smtp As New SmtpClient With {
                .Host = "smtp.gmail.com",
                .Port = 587,
                .EnableSsl = True,
                .DeliveryMethod = SmtpDeliveryMethod.Network,
                .UseDefaultCredentials = False,
                .Credentials = New NetworkCredential(fromAddress.Address, "percowsqptjarqno") ' Use your App Password
            }

            Using message As New MailMessage(fromAddress, toAddress)
                message.Subject = subject
                message.Body = body
                smtp.Send(message)
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to send email notification: " & ex.Message)
        End Try
    End Sub
End Module
