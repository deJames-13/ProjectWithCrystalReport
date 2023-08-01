Public Class _manage_orderspage

    Dim form_table As New DataTable
    Dim selectedRow As DataRow
    '
    ' INFORMATIONS THAT WILL SHOW ON ORDERS PAGE
    '


    Private Sub OnPageSwitch(sender As Object, e As EventArgs) Handles windowWrapper.ForeColorChanged
        If windowWrapper.ForeColor <> activeForeColor Then Return
        Reload()
        ManageHandlers()

        cmbSorting.Items.Clear()
        cmbSorting.Items.Add("All")
        For Each col As DataGridViewColumn In ordGrid.Columns
            cmbSorting.Items.Add(col.HeaderText)
        Next


    End Sub
    '

    Private Sub ActionButtonClicked(sender As Object, e As EventArgs) Handles btnShip.Click, btnCancel.Click, btnDelivered.Click
        Select Case sender.name
            Case "btnShip"
                SetOrderStatus(selectedRow("id"), "shipping")
            Case "btnCancel"
                SetOrderStatus(selectedRow("id"), "cancelled")
            Case "btnDelivered"
                SetOrderStatus(selectedRow("id"), "delivered")
        End Select
        Reload()
    End Sub

    Private Sub Reload()
        ordGrid.Columns.Clear()
        ordGrid.Hide()
        ordGrid.DataSource = Nothing
        form_table = QueryToGrid(orders_query, ordGrid)
        rowCount.Text = form_table.Rows.Count
        ordGrid.Show()

    End Sub

    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ordGrid.CellClick
        If e.RowIndex < 0 Then Return

        selectedRow = ordGrid.Rows(e.RowIndex).DataBoundItem.Row
        labelSelected.Text = $"Order {selectedRow("id")}: [{selectedRow("Item Name")}] x{selectedRow("Quantity")}"
    End Sub

    Private Sub ManageHandlers()
        RemoveHandler ordGrid.CellClick, AddressOf SelectCellRow
        AddHandler ordGrid.CellClick, AddressOf SelectCellRow
    End Sub

End Class