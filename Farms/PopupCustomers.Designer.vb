<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopupCustomers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PopupCustomers))
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnCustomerReport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnArchivedSuppliers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnViewCustomers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Button5
        '
        Me.Guna2Button5.BorderColor = System.Drawing.Color.White
        Me.Guna2Button5.BorderRadius = 5
        Me.Guna2Button5.BorderThickness = 1
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.FillColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2Button5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.Location = New System.Drawing.Point(79, 49)
        Me.Guna2Button5.Margin = New System.Windows.Forms.Padding(10)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(142, 30)
        Me.Guna2Button5.TabIndex = 7
        Me.Guna2Button5.Text = "العملاء"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 15
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.btnCustomerReport)
        Me.Guna2Panel1.Controls.Add(Me.btnArchivedSuppliers)
        Me.Guna2Panel1.Controls.Add(Me.btnViewCustomers)
        Me.Guna2Panel1.Controls.Add(Me.btnAddCustomer)
        Me.Guna2Panel1.Location = New System.Drawing.Point(6, 102)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(215, 234)
        Me.Guna2Panel1.TabIndex = 6
        '
        'btnCustomerReport
        '
        Me.btnCustomerReport.BorderColor = System.Drawing.Color.White
        Me.btnCustomerReport.BorderRadius = 5
        Me.btnCustomerReport.BorderThickness = 1
        Me.btnCustomerReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCustomerReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCustomerReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCustomerReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCustomerReport.FillColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnCustomerReport.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerReport.ForeColor = System.Drawing.Color.White
        Me.btnCustomerReport.Location = New System.Drawing.Point(18, 175)
        Me.btnCustomerReport.Margin = New System.Windows.Forms.Padding(10)
        Me.btnCustomerReport.Name = "btnCustomerReport"
        Me.btnCustomerReport.Size = New System.Drawing.Size(180, 30)
        Me.btnCustomerReport.TabIndex = 3
        Me.btnCustomerReport.Text = "تقارير العملاء"
        '
        'btnArchivedSuppliers
        '
        Me.btnArchivedSuppliers.BorderColor = System.Drawing.Color.White
        Me.btnArchivedSuppliers.BorderRadius = 5
        Me.btnArchivedSuppliers.BorderThickness = 1
        Me.btnArchivedSuppliers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnArchivedSuppliers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnArchivedSuppliers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnArchivedSuppliers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnArchivedSuppliers.FillColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnArchivedSuppliers.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchivedSuppliers.ForeColor = System.Drawing.Color.White
        Me.btnArchivedSuppliers.Location = New System.Drawing.Point(18, 125)
        Me.btnArchivedSuppliers.Margin = New System.Windows.Forms.Padding(10)
        Me.btnArchivedSuppliers.Name = "btnArchivedSuppliers"
        Me.btnArchivedSuppliers.Size = New System.Drawing.Size(180, 30)
        Me.btnArchivedSuppliers.TabIndex = 2
        Me.btnArchivedSuppliers.Text = "أرشيف العملاء"
        '
        'btnViewCustomers
        '
        Me.btnViewCustomers.BorderColor = System.Drawing.Color.White
        Me.btnViewCustomers.BorderRadius = 5
        Me.btnViewCustomers.BorderThickness = 1
        Me.btnViewCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnViewCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnViewCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnViewCustomers.FillColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnViewCustomers.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewCustomers.ForeColor = System.Drawing.Color.White
        Me.btnViewCustomers.Location = New System.Drawing.Point(18, 75)
        Me.btnViewCustomers.Margin = New System.Windows.Forms.Padding(10)
        Me.btnViewCustomers.Name = "btnViewCustomers"
        Me.btnViewCustomers.Size = New System.Drawing.Size(180, 30)
        Me.btnViewCustomers.TabIndex = 1
        Me.btnViewCustomers.Text = "عرض العملاء"
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.BorderColor = System.Drawing.Color.White
        Me.btnAddCustomer.BorderRadius = 5
        Me.btnAddCustomer.BorderThickness = 1
        Me.btnAddCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddCustomer.FillColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnAddCustomer.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCustomer.ForeColor = System.Drawing.Color.White
        Me.btnAddCustomer.Location = New System.Drawing.Point(17, 25)
        Me.btnAddCustomer.Margin = New System.Windows.Forms.Padding(10)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(180, 30)
        Me.btnAddCustomer.TabIndex = 0
        Me.btnAddCustomer.Text = "أضافه عميل"
        '
        'btnClose
        '
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnClose.Location = New System.Drawing.Point(202, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 20)
        Me.btnClose.TabIndex = 14
        '
        'PopupCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(227, 342)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Guna2Button5)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PopupCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmPopupCustomers"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnCustomerReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnArchivedSuppliers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnViewCustomers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddCustomer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
End Class
