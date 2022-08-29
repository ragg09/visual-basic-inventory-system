<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class item_update
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
        Me.btn_update = New System.Windows.Forms.Button()
        Me.txtselling_cost = New System.Windows.Forms.TextBox()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.txtcost_per_pc = New System.Windows.Forms.TextBox()
        Me.txtpc_pe_pack = New System.Windows.Forms.TextBox()
        Me.txtcost_in_unit = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtitem_id = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_display = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(26, 251)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 35
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'txtselling_cost
        '
        Me.txtselling_cost.Location = New System.Drawing.Point(115, 208)
        Me.txtselling_cost.Name = "txtselling_cost"
        Me.txtselling_cost.Size = New System.Drawing.Size(100, 20)
        Me.txtselling_cost.TabIndex = 32
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(115, 182)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(100, 20)
        Me.txtquantity.TabIndex = 31
        '
        'txtcost_per_pc
        '
        Me.txtcost_per_pc.Location = New System.Drawing.Point(115, 156)
        Me.txtcost_per_pc.Name = "txtcost_per_pc"
        Me.txtcost_per_pc.Size = New System.Drawing.Size(100, 20)
        Me.txtcost_per_pc.TabIndex = 30
        '
        'txtpc_pe_pack
        '
        Me.txtpc_pe_pack.Location = New System.Drawing.Point(115, 130)
        Me.txtpc_pe_pack.Name = "txtpc_pe_pack"
        Me.txtpc_pe_pack.Size = New System.Drawing.Size(100, 20)
        Me.txtpc_pe_pack.TabIndex = 29
        '
        'txtcost_in_unit
        '
        Me.txtcost_in_unit.Location = New System.Drawing.Point(115, 104)
        Me.txtcost_in_unit.Name = "txtcost_in_unit"
        Me.txtcost_in_unit.Size = New System.Drawing.Size(100, 20)
        Me.txtcost_in_unit.TabIndex = 28
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(115, 78)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 20)
        Me.txtname.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Selling Cost"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "quantity"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Cost per pc"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Pc per pack"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Cost in Unit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Select ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(159, 51)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(56, 21)
        Me.ComboBox1.TabIndex = 37
        '
        'txtitem_id
        '
        Me.txtitem_id.Location = New System.Drawing.Point(115, 51)
        Me.txtitem_id.Name = "txtitem_id"
        Me.txtitem_id.Size = New System.Drawing.Size(38, 20)
        Me.txtitem_id.TabIndex = 38
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(234, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(553, 242)
        Me.DataGridView1.TabIndex = 40
        '
        'btn_display
        '
        Me.btn_display.Location = New System.Drawing.Point(123, 251)
        Me.btn_display.Name = "btn_display"
        Me.btn_display.Size = New System.Drawing.Size(75, 23)
        Me.btn_display.TabIndex = 39
        Me.btn_display.Text = "DISPLAY"
        Me.btn_display.UseVisualStyleBackColor = True
        '
        'item_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_display)
        Me.Controls.Add(Me.txtitem_id)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_update)
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
        Me.Controls.Add(Me.Label1)
        Me.Name = "item_update"
        Me.Text = "item_update"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents txtselling_cost As System.Windows.Forms.TextBox
    Friend WithEvents txtquantity As System.Windows.Forms.TextBox
    Friend WithEvents txtcost_per_pc As System.Windows.Forms.TextBox
    Friend WithEvents txtpc_pe_pack As System.Windows.Forms.TextBox
    Friend WithEvents txtcost_in_unit As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtitem_id As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_display As System.Windows.Forms.Button
End Class
