Imports CrystalDecisions.CrystalReports.Engine

Public Class _viewreceipt_dialog

    Dim receipt_query As String

    Public Sub New(id As String, product_id As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim report As New view_receipt
        Dim ds As New DataSet()

        Dim temp As DataTable
        Dim name As String = ""

        Dim tables As DataTable = ShowTables()
        For Each t In tables.Rows
            name = t(tables.Columns.Item(0).ColumnName)
            temp = SelectAllFrom(name)

            If name = "order_has_product" Then
                temp = SelectWhere(name, $"order_id={id} AND product_id={product_id}")
            End If
            Dim dt As New DataTable()
            dt = temp.Copy()
            dt.TableName = name
            ds.Tables.Add(dt)
        Next
        report.SetDataSource(ds)
        reportWizard1.ReportSource = report
        reportWizard1.Refresh()
    End Sub

    Private Sub _viewreceipt_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class