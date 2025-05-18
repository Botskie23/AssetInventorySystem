Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Module ModuleCrystalConnection
    Public Sub ApplyMySqlLogin(report As ReportDocument)
        Dim connectionInfo As New ConnectionInfo With {
            .ServerName = "localhost",
            .DatabaseName = "assetinventorydb",
            .UserID = "root",
            .Password = "",
            .Type = ConnectionInfoType.CRQE
        }

        ' Apply login to main report tables
        For Each table As Table In report.Database.Tables
            Dim logonInfo As TableLogOnInfo = table.LogOnInfo
            logonInfo.ConnectionInfo = connectionInfo
            table.ApplyLogOnInfo(logonInfo)



            If table.Location.Contains(".") Then
                table.Location = table.Location.Substring(table.Location.LastIndexOf(".") + 1)
            End If

        Next

        ' Apply login to subreport tables
        For Each section As Section In report.ReportDefinition.Sections
            For Each obj As ReportObject In section.ReportObjects
                If TypeOf obj Is SubreportObject Then
                    Dim subReportObj As SubreportObject = CType(obj, SubreportObject)
                    Dim subReport As ReportDocument = subReportObj.OpenSubreport(subReportObj.SubreportName)

                    For Each subTable As Table In subReport.Database.Tables
                        Dim subLogonInfo As TableLogOnInfo = subTable.LogOnInfo
                        subLogonInfo.ConnectionInfo = connectionInfo
                        subTable.ApplyLogOnInfo(subLogonInfo)

                        If subTable.Location.Contains(".") Then
                            subTable.Location = subTable.Location.Substring(subTable.Location.IndexOf(".") + 1)
                        End If
                    Next
                End If
            Next
        Next
    End Sub
End Module
