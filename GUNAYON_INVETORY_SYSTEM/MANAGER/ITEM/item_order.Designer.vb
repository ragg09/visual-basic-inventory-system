<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class item_order
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtitemcost = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbitem = New System.Windows.Forms.ComboBox()
        Me.txtitemname = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cbmanid = New System.Windows.Forms.ComboBox()
        Me.cbsupid = New System.Windows.Forms.ComboBox()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnorder = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcurquantity = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sup ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Name"
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(81, 78)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(121, 20)
        Me.txtquantity.TabIndex = 5
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(81, 236)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(121, 20)
        Me.txttotal.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Man ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cost"
        '
        'txtitemcost
        '
        Me.txtitemcost.Enabled = False
        Me.txtitemcost.Location = New System.Drawing.Point(81, 158)
        Me.txtitemcost.Name = "txtitemcost"
        Me.txtitemcost.Size = New System.Drawing.Size(121, 20)
        Me.txtitemcost.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Item ID"
        '
        'cbitem
        '
        Me.cbitem.FormattingEnabled = True
        Me.cbitem.Location = New System.Drawing.Point(81, 104)
        Me.cbitem.Name = "cbitem"
        Me.cbitem.Size = New System.Drawing.Size(121, 21)
        Me.cbitem.TabIndex = 16
        '
        'txtitemname
        '
        Me.txtitemname.Enabled = False
        Me.txtitemname.Location = New System.Drawing.Point(81, 132)
        Me.txtitemname.Name = "txtitemname"
        Me.txtitemname.Size = New System.Drawing.Size(121, 20)
        Me.txtitemname.TabIndex = 17
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(225, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(562, 276)
        Me.DataGridView1.TabIndex = 18
        '
        'cbmanid
        '
        Me.cbmanid.FormattingEnabled = True
        Me.cbmanid.Location = New System.Drawing.Point(81, 25)
        Me.cbmanid.Name = "cbmanid"
        Me.cbmanid.Size = New System.Drawing.Size(121, 21)
        Me.cbmanid.TabIndex = 20
        '
        'cbsupid
        '
        Me.cbsupid.FormattingEnabled = True
        Me.cbsupid.Location = New System.Drawing.Point(81, 51)
        Me.cbsupid.Name = "cbsupid"
        Me.cbsupid.Size = New System.Drawing.Size(121, 21)
        Me.cbsupid.TabIndex = 21
        '
        'txtdate
        '
        Me.txtdate.Enabled = False
        Me.txtdate.Location = New System.Drawing.Point(81, 210)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(121, 20)
        Me.txtdate.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Date"
        '
        'btnorder
        '
        Me.btnorder.Location = New System.Drawing.Point(22, 301)
        Me.btnorder.Name = "btnorder"
        Me.btnorder.Size = New System.Drawing.Size(180, 27)
        Me.btnorder.TabIndex = 24
        Me.btnorder.Text = "ORDER"
        Me.btnorder.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Current Quantiy"
        '
        'txtcurquantity
        '
        Me.txtcurquantity.Enabled = False
        Me.txtcurquantity.Location = New System.Drawing.Point(103, 184)
        Me.txtcurquantity.Name = "txtcurquantity"
        Me.txtcurquantity.Size = New System.Drawing.Size(99, 20)
        Me.txtcurquantity.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(225, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 31)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "SHOW ITEMS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'item_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtcurquantity)
        Me.Controls.Add(Me.btnorder)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.cbsupid)
        Me.Controls.Add(Me.cbmanid)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtitemname)
        Me.Controls.Add(Me.cbitem)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtitemcost)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "item_order"
        Me.Text = "item_order"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtquantity As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtitemcost As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbitem As System.Windows.Forms.ComboBox
    Friend WithEvents txtitemname As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cbmanid As System.Windows.Forms.ComboBox
    Friend WithEvents cbsupid As System.Windows.Forms.ComboBox
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnorder As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtcurquantity As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
