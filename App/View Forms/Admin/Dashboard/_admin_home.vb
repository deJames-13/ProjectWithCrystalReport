Public Class _admin_home

    Public role As String

    Private Sub _admin_home_closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub _admin_home_shown(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If MyBase.Visible = False Then Return

    End Sub

    Private Sub OnNavClick(sender As Object, e As EventArgs) Handles MyBase.Load, btnInventory.Click, btnReports.Click, btnSettings.Click, btnEmployees.Click, btnOrders.Click, btnPayroll.Click

        Reload()

        Select Case sender.name
            Case MyBase.Name
                If Not isConnected() Then Application.Exit()
                MakeHandlers()

                switchPanel(_inventory.windowWrapper, windowWrapper)
            Case "btnInventory"
                switchPanel(_inventory.windowWrapper, currentPage)
            Case "btnReports"
                switchPanel(_reports.windowWrapper, currentPage)
            Case "btnSettings"
                switchPanel(_settingspage.windowWrapper, currentPage)
            Case "btnEmployees"
                switchPanel(_employees.windowWrapper, currentPage)
            Case "btnPayroll"
                switchPanel(_payroll.windowWrapper, currentPage)
            Case "btnOrders"
                switchPanel(_manage_orderspage.windowWrapper, currentPage)
        End Select

    End Sub

    Private Sub Reload()

    End Sub

    Private Sub MakeHandlers()
        ButtonHoverEvents({btnInventory, btnReports, btnSettings, btnEmployees, btnPayroll, btnOrders})
    End Sub
End Class
