Public Class PopupCustomers


    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Dim addForm As New frmAddCustomer()
        addForm.ShowDialog()
    End Sub
    Private Sub btnArchivedSuppliers_Click(sender As Object, e As EventArgs) Handles btnArchivedSuppliers.Click
        Dim archiveForm As New frmCustomerArchive()
        archiveForm.ShowDialog()
    End Sub

    Private Sub btnViewCustomers_Click(sender As Object, e As EventArgs) Handles btnViewCustomers.Click
        Dim viewForm As New frmViewCustomers()
        viewForm.ShowDialog()
    End Sub



    ' زر الإغلاق

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class