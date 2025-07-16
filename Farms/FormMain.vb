Public Class FormMain
    ' 📌 عند الضغط على بلاطة "المبيعات"
    ' يتم إنشاء نافذة جديدة من نوع PopupSales وفتحها كـ "نافذة منبثقة"
    Private Sub tileSales_Click(sender As Object, e As EventArgs) Handles tileSales.Click
        Dim frm As New PopupSales()
        frm.ShowDialog()
    End Sub

    ' 📌 عند الضغط على بلاطة "الموردين"
    ' يتم فتح بوبي الموردين
    Private Sub tileSuppliers_Click(sender As Object, e As EventArgs) Handles tileSuppliers.Click
        Dim frm As New PopupSuppliers()
        frm.ShowDialog()
    End Sub

    ' 📌 عند الضغط على بلاطة "التصنيع"
    ' يتم فتح بوبي التصنيع
    Private Sub tileManufacturing_Click(sender As Object, e As EventArgs) Handles tileManufacturing.Click
        Dim frm As New PopupManufacturing()
        frm.ShowDialog()
    End Sub

    ' 📌 عند الضغط على بلاطة "العملاء"
    ' يتم فتح بوبي العملاء
    Private Sub tileCustomers_Click(sender As Object, e As EventArgs) Handles tileCustomers.Click
        Dim frm As New PopupCustomers()
        frm.ShowDialog()
    End Sub

    ' 📌 عند الضغط على بلاطة "أوامر المبيعات"
    ' يتم فتح بوبي أوامر المبيعات
    Private Sub tileSalesOrders_Click(sender As Object, e As EventArgs) Handles tileSalesOrders.Click
        Dim frm As New PopupSalesOrders()
        frm.ShowDialog()
    End Sub

    ' 📌 عند الضغط على بلاطة "التحويلات المخزنية"
    ' يتم فتح بوبي التحويلات
    Private Sub tileStockTransfers_Click(sender As Object, e As EventArgs) Handles tileStockTransfers.Click
        Dim frm As New PopupStockTransfers()
        frm.ShowDialog()
    End Sub

    ' 📌 عند الضغط على بلاطة "شؤون الموظفين"
    ' يتم فتح بوبي الموظفين
    Private Sub tileEmployees_Click(sender As Object, e As EventArgs) Handles tileEmployees.Click
        Dim frm As New PopupEmployees()
        frm.ShowDialog()
    End Sub

    ' زر الإغلاق
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    ' زر الإصناف
    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        Dim frm As New frmItems()
        frm.ShowDialog()
    End Sub

    Private Sub CompanyInfoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ContactsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SalesmanToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SMSSettingToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SQLServerSettingToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EmailSettingToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub نسخاحتياطيToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub استرجاعنسخةاحتياطيةToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub المستخدمينToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NotepadToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub WordpadToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MSWordToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TaskManagerToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SystemInfoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tileSilos_Click(sender As Object, e As EventArgs) Handles tileSilos.Click
        PopupSilos.ShowDialog()
    End Sub
End Class
