Imports MySql.Data.MySqlClient

Module ModuleConnection
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;userid=root;password=;database=assetinventorydb;")
    End Function
End Module
