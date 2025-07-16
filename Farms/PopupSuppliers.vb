Public Class PopupSuppliers


    Private Sub PopupSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click
        Dim addForm As New FrmAddSupplier()
        addForm.ShowDialog()
    End Sub

    Private Sub btnViewSuppliers_Click(sender As Object, e As EventArgs) Handles btnViewSuppliers.Click
        Dim viewForm As New FrmViewSuppliers()
        viewForm.ShowDialog()
    End Sub

    Private Sub btnSupplierArchive_Click(sender As Object, e As EventArgs) Handles btnSupplierArchive.Click
        Dim archiveForm As New FrmSupplierArchive()
        archiveForm.ShowDialog()
    End Sub



    ' زر الإغلاق

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class