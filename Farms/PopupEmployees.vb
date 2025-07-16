Public Class PopupEmployees




    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim addEmpForm As New frmAddEmployee()
        addEmpForm.ShowDialog()
    End Sub



    Private Sub btnEmployeeList_Click(sender As Object, e As EventArgs) Handles btnEmployeeList.Click
        Dim employeeListForm As New frmEmployeeList()
        employeeListForm.ShowDialog()
    End Sub

    ' زر الإغلاق

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class