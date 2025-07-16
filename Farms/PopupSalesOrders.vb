Public Class PopupSalesOrders


    Private Sub btnSalesOrderRequest_Click(sender As Object, e As EventArgs) Handles btnSalesOrderRequest.Click
        Dim salesForm As New frmSalesOrder()
        salesForm.ShowDialog()
    End Sub



    ' زر الإغلاق

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnLoadPermission_Click(sender As Object, e As EventArgs) Handles btnLoadPermission.Click
        Dim salesForm As New frmLoadingPermit()
        salesForm.ShowDialog()
    End Sub

    Private Sub PopupSalesOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    ' زر الإغلاق

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCloseLoadingRequest_Click(sender As Object, e As EventArgs) Handles btnCloseLoadingRequest.Click
        Dim salesForm As New frmCloseSalesOrder()
        salesForm.ShowDialog()
    End Sub
End Class