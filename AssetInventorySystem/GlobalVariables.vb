Public Module GlobalVariables

    ' 🧑 User-related info
    Public LoggedInEmployeeID As Integer = 0
    Public LoggedInEmployeeName As String = ""
    Public LoggedInUserDesignation As String = ""
    Public LoggedInUserType As String = "" ' ✅ Add this if you use it for role-based logic (e.g., "Admin", "Employee")
    Public LoggedInProfilePicture As Byte() = Nothing

    ' 🔐 Roles
    Public LoggedInRoles As New List(Of Integer)()          ' Role IDs
    Public LoggedInRoleNames As New List(Of String)()       ' ✅ Role names (e.g., "Approver", "Technician")
    Public LoggedInPrimaryRole As String
    ' ⏰ For tracking activity/session timeout
    Public LastActivityTime As DateTime = DateTime.Now      ' ✅ Add this to track session activity

    ' 🧭 Flags
    Public IsAdmin As Boolean = False
    Public IsManager As Boolean = False
    Public IsApprover As Boolean = False

    ' 📍 Example use-case variables
    Public SelectedAssetCode As String = ""
    Public HasUnreadEmails As Boolean = False

End Module