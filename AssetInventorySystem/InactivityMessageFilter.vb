Public Class InactivityMessageFilter
    Implements IMessageFilter

    Public Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
        Const WM_MOUSEMOVE As Integer = &H200
        Const WM_KEYDOWN As Integer = &H100

        If m.Msg = WM_MOUSEMOVE OrElse m.Msg = WM_KEYDOWN Then
            GlobalVariables.LastActivityTime = DateTime.Now
            Debug.WriteLine("Activity detected at: " & GlobalVariables.LastActivityTime)
            Console.WriteLine("Activity detected at " & DateTime.Now)
        End If

        Return False
    End Function
End Class
