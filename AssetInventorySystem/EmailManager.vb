Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports MailKit

Public Class EmailManager
    Private Shared UnreadEmails As New List(Of EmailMessage)()
    Public Property IsRead As Boolean

    ' Add a new email
    Public Shared Sub AddEmail(subject As String, sender As String, body As String)
        UnreadEmails.Add(New EmailMessage With {
            .Subject = subject,
            .Sender = sender,
            .DateReceived = DateTime.Now,
            .Body = body ' Add the body as well
        })
    End Sub

    ' Get unread emails
    Public Shared Function GetUnreadEmails() As List(Of EmailMessage)
        Return UnreadEmails
    End Function
End Class



Public Class EmailMessage
    Public Property Subject As String
    Public Property Sender As String
    Public Property DateReceived As DateTime
    Public Property Body As String ' ✅ Add this line to store the email body
    Public Property MessageID As UniqueId ' Required for marking as read
    Public Property IsRead As Boolean ' Optional, for UI logic
    Public Property UID As UniqueId 
End Class
