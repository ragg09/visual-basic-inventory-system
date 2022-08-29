<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class items_to_be_sold
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btncheck = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnec = New System.Windows.Forms.Button()
        Me.btnclover = New System.Windows.Forms.Button()
        Me.btnnova = New System.Windows.Forms.Button()
        Me.btnpiatoss = New System.Windows.Forms.Button()
        Me.btnshanghai = New System.Windows.Forms.Button()
        Me.btntoge = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(577, 118)
        Me.DataGridView1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.TextBox1.Location = New System.Drawing.Point(793, 387)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(10, 3)
        Me.TextBox1.TabIndex = 20
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(12, 47)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(176, 27)
        Me.btn.TabIndex = 11
        Me.btn.Text = "PREPARE SIOMAI"
        Me.btn.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(577, 200)
        Me.DataGridView2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(176, 20)
        Me.DateTimePicker1.TabIndex = 19
        '
        'btncheck
        '
        Me.btncheck.Location = New System.Drawing.Point(12, 338)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(176, 49)
        Me.btncheck.TabIndex = 18
        Me.btncheck.Text = "CHECK ITEMS ON HAND"
        Me.btncheck.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Location = New System.Drawing.Point(198, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(589, 225)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ITEMS ON HAND"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(197, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(589, 143)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ITEM USED"
        '
        'btnec
        '
        Me.btnec.Location = New System.Drawing.Point(12, 177)
        Me.btnec.Name = "btnec"
        Me.btnec.Size = New System.Drawing.Size(176, 27)
        Me.btnec.TabIndex = 15
        Me.btnec.Text = "PREPARE EC CHOCO"
        Me.btnec.UseVisualStyleBackColor = True
        '
        'btnclover
        '
        Me.btnclover.Location = New System.Drawing.Point(12, 146)
        Me.btnclover.Name = "btnclover"
        Me.btnclover.Size = New System.Drawing.Size(176, 27)
        Me.btnclover.TabIndex = 14
        Me.btnclover.Text = "PREPARE CLOVER CHIPS"
        Me.btnclover.UseVisualStyleBackColor = True
        '
        'btnnova
        '
        Me.btnnova.Location = New System.Drawing.Point(12, 113)
        Me.btnnova.Name = "btnnova"
        Me.btnnova.Size = New System.Drawing.Size(176, 27)
        Me.btnnova.TabIndex = 13
        Me.btnnova.Text = "PREPARE NOVA"
        Me.btnnova.UseVisualStyleBackColor = True
        '
        'btnpiatoss
        '
        Me.btnpiatoss.Location = New System.Drawing.Point(12, 80)
        Me.btnpiatoss.Name = "btnpiatoss"
        Me.btnpiatoss.Size = New System.Drawing.Size(176, 27)
        Me.btnpiatoss.TabIndex = 12
        Me.btnpiatoss.Text = "PREPARE PIATOSS"
        Me.btnpiatoss.UseVisualStyleBackColor = True
        '
        'btnshanghai
        '
        Me.btnshanghai.Location = New System.Drawing.Point(12, 243)
        Me.btnshanghai.Name = "btnshanghai"
        Me.btnshanghai.Size = New System.Drawing.Size(176, 27)
        Me.btnshanghai.TabIndex = 22
        Me.btnshanghai.Text = "COOK LUMPIANG SHANGHAI"
        Me.btnshanghai.UseVisualStyleBackColor = True
        '
        'btntoge
        '
        Me.btntoge.Location = New System.Drawing.Point(12, 210)
        Me.btntoge.Name = "btntoge"
        Me.btntoge.Size = New System.Drawing.Size(176, 27)
        Me.btntoge.TabIndex = 21
        Me.btntoge.Text = "COOK LUMPIANG TOGE"
        Me.btntoge.UseVisualStyleBackColor = True
        '
        'items_to_be_sold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnshanghai)
        Me.Controls.Add(Me.btntoge)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btncheck)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnec)
        Me.Controls.Add(Me.btnclover)
        Me.Controls.Add(Me.btnnova)
        Me.Controls.Add(Me.btnpiatoss)
        Me.Name = "items_to_be_sold"
        Me.Text = "items_to_be_sold"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btncheck As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnec As System.Windows.Forms.Button
    Friend WithEvents btnclover As System.Windows.Forms.Button
    Friend WithEvents btnnova As System.Windows.Forms.Button
    Friend WithEvents btnpiatoss As System.Windows.Forms.Button
    Friend WithEvents btnshanghai As System.Windows.Forms.Button
    Friend WithEvents btntoge As System.Windows.Forms.Button
End Class
