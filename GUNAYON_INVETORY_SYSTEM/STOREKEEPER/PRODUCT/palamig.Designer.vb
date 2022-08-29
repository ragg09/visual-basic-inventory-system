<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class palamig
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
        Me.btn = New System.Windows.Forms.Button()
        Me.btnmelon = New System.Windows.Forms.Button()
        Me.btnmango = New System.Windows.Forms.Button()
        Me.btnbuko = New System.Windows.Forms.Button()
        Me.btnlemon = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btncheck = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(12, 36)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(176, 50)
        Me.btn.TabIndex = 0
        Me.btn.Text = "CREATE WATER MELON"
        Me.btn.UseVisualStyleBackColor = True
        '
        'btnmelon
        '
        Me.btnmelon.Location = New System.Drawing.Point(12, 92)
        Me.btnmelon.Name = "btnmelon"
        Me.btnmelon.Size = New System.Drawing.Size(176, 50)
        Me.btnmelon.TabIndex = 1
        Me.btnmelon.Text = "CREATE MELON"
        Me.btnmelon.UseVisualStyleBackColor = True
        '
        'btnmango
        '
        Me.btnmango.Location = New System.Drawing.Point(12, 148)
        Me.btnmango.Name = "btnmango"
        Me.btnmango.Size = New System.Drawing.Size(176, 50)
        Me.btnmango.TabIndex = 2
        Me.btnmango.Text = "CREATE MANGO"
        Me.btnmango.UseVisualStyleBackColor = True
        '
        'btnbuko
        '
        Me.btnbuko.Location = New System.Drawing.Point(12, 260)
        Me.btnbuko.Name = "btnbuko"
        Me.btnbuko.Size = New System.Drawing.Size(176, 50)
        Me.btnbuko.TabIndex = 4
        Me.btnbuko.Text = "CREATE BUKO"
        Me.btnbuko.UseVisualStyleBackColor = True
        '
        'btnlemon
        '
        Me.btnlemon.Location = New System.Drawing.Point(12, 204)
        Me.btnlemon.Name = "btnlemon"
        Me.btnlemon.Size = New System.Drawing.Size(176, 50)
        Me.btnlemon.TabIndex = 3
        Me.btnlemon.Text = "CREATE LEMON"
        Me.btnlemon.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(197, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(589, 143)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ITEM USED"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Location = New System.Drawing.Point(198, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(589, 225)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ITEMS ON HAND"
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
        'btncheck
        '
        Me.btncheck.Location = New System.Drawing.Point(12, 336)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(176, 49)
        Me.btncheck.TabIndex = 8
        Me.btncheck.Text = "CHECK ITEMS ON HAND"
        Me.btncheck.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 10)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(176, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.TextBox1.Location = New System.Drawing.Point(793, 385)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(10, 3)
        Me.TextBox1.TabIndex = 10
        '
        'palamig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btncheck)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnbuko)
        Me.Controls.Add(Me.btnlemon)
        Me.Controls.Add(Me.btnmango)
        Me.Controls.Add(Me.btnmelon)
        Me.Name = "palamig"
        Me.Text = "palamig"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents btnmelon As System.Windows.Forms.Button
    Friend WithEvents btnmango As System.Windows.Forms.Button
    Friend WithEvents btnbuko As System.Windows.Forms.Button
    Friend WithEvents btnlemon As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btncheck As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
