<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class item_insert
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtpc_pe_pack = New System.Windows.Forms.TextBox()
        Me.txtcost_in_unit = New System.Windows.Forms.TextBox()
        Me.txtselling_cost = New System.Windows.Forms.TextBox()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.txtcost_per_pc = New System.Windows.Forms.TextBox()
        Me.txtunit = New System.Windows.Forms.ComboBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_display = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Unit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Pc per pack"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cost in Unit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Selling Cost"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "quantity"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Cost per pc"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(116, 44)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 20)
        Me.txtname.TabIndex = 8
        '
        'txtpc_pe_pack
        '
        Me.txtpc_pe_pack.Location = New System.Drawing.Point(116, 122)
        Me.txtpc_pe_pack.Name = "txtpc_pe_pack"
        Me.txtpc_pe_pack.Size = New System.Drawing.Size(100, 20)
        Me.txtpc_pe_pack.TabIndex = 11
        '
        'txtcost_in_unit
        '
        Me.txtcost_in_unit.Location = New System.Drawing.Point(116, 96)
        Me.txtcost_in_unit.Name = "txtcost_in_unit"
        Me.txtcost_in_unit.Size = New System.Drawing.Size(100, 20)
        Me.txtcost_in_unit.TabIndex = 10
        '
        'txtselling_cost
        '
        Me.txtselling_cost.Location = New System.Drawing.Point(116, 200)
        Me.txtselling_cost.Name = "txtselling_cost"
        Me.txtselling_cost.Size = New System.Drawing.Size(100, 20)
        Me.txtselling_cost.TabIndex = 14
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(116, 174)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(100, 20)
        Me.txtquantity.TabIndex = 13
        '
        'txtcost_per_pc
        '
        Me.txtcost_per_pc.Location = New System.Drawing.Point(116, 148)
        Me.txtcost_per_pc.Name = "txtcost_per_pc"
        Me.txtcost_per_pc.Size = New System.Drawing.Size(100, 20)
        Me.txtcost_per_pc.TabIndex = 12
        '
        'txtunit
        '
        Me.txtunit.FormattingEnabled = True
        Me.txtunit.Items.AddRange(New Object() {"can", "pc", "kls", "pckg", "bot"})
        Me.txtunit.Location = New System.Drawing.Point(116, 69)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Size = New System.Drawing.Size(100, 21)
        Me.txtunit.TabIndex = 16
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(25, 244)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(75, 23)
        Me.btn_insert.TabIndex = 17
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_display
        '
        Me.btn_display.Location = New System.Drawing.Point(116, 243)
        Me.btn_display.Name = "btn_display"
        Me.btn_display.Size = New System.Drawing.Size(75, 23)
        Me.btn_display.TabIndex = 18
        Me.btn_display.Text = "DISPLAY"
        Me.btn_display.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(227, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(553, 242)
        Me.DataGridView1.TabIndex = 19
        '
        'item_insert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_display)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.txtselling_cost)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.txtcost_per_pc)
        Me.Controls.Add(Me.txtpc_pe_pack)
        Me.Controls.Add(Me.txtcost_in_unit)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "item_insert"
        Me.Text = "item_insert"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtpc_pe_pack As System.Windows.Forms.TextBox
    Friend WithEvents txtcost_in_unit As System.Windows.Forms.TextBox
    Friend WithEvents txtselling_cost As System.Windows.Forms.TextBox
    Friend WithEvents txtquantity As System.Windows.Forms.TextBox
    Friend WithEvents txtcost_per_pc As System.Windows.Forms.TextBox
    Friend WithEvents txtunit As System.Windows.Forms.ComboBox
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents btn_display As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
