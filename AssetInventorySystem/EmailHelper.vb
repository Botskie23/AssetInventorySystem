Imports MailKit.Net.Imap
Imports MailKit.Search
Imports MailKit
Imports MimeKit

Module EmailHelper
    Public Function GetUnreadEmailCount() As Integer
        Dim unreadCount As Integer = 0

        Try
            Using client As New ImapClient()
                client.Connect("imap.gmail.com", 993, True)
                client.Authenticate("balboaryanoliver@gmail.com", "percowsqptjarqno")

                Dim inbox = client.Inbox
                inbox.Open(FolderAccess.ReadOnly)

                Dim unreadMessages = inbox.Search(SearchQuery.NotSeen)
                unreadCount = unreadMessages.Count

                client.Disconnect(True)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking emails: " & ex.Message)
        End Try

        Return unreadCount
    End Function

    Public Function GetUnreadEmailList() As List(Of EmailMessage)
        Dim emails As New List(Of EmailMessage)()

        Try
            Using client As New ImapClient()
                client.Connect("imap.gmail.com", 993, True)
                client.Authenticate("balboaryanoliver@gmail.com", "percowsqptjarqno")

                Dim inbox = client.Inbox
                inbox.Open(FolderAccess.ReadOnly)

                Dim results = inbox.Search(SearchQuery.NotSeen)
                For Each uid In results
                    Dim message = inbox.GetMessage(uid)
                    emails.Add(New EmailMessage With {
                        .Subject = message.Subject,
                        .Sender = message.From.ToString(),
                        .DateReceived = message.Date.UtcDateTime,
                        .Body = message.TextBody,
                        .UID = uid
                    })
                Next

                client.Disconnect(True)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching emails: " & ex.Message)
        End Try

        Return emails
    End Function

    Public Class EmailMessage
        Public Property Subject As String
        Public Property Sender As String
        Public Property DateReceived As DateTime
        Public Property Body As String ' THIS MUST BE PRESENT
        Public Property MessageID As UniqueId ' Required for marking as read
        Public Property IsRead As Boolean ' Optional, for UI logic
        Public Property UID As UniqueId

    End Class

    Public Sub MarkAsRead(messageId As UniqueId)
        Try
            Using client As New ImapClient()
                client.Connect("imap.gmail.com", 993, True)
                client.Authenticate("balboaryanoliver@gmail.com", "percowsqptjarqno")

                Dim inbox = client.Inbox
                inbox.Open(FolderAccess.ReadWrite)

                inbox.AddFlags(messageId, MessageFlags.Seen, True)

                client.Disconnect(True)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error marking email as read: " & ex.Message)
        End Try
    End Sub

End Module
