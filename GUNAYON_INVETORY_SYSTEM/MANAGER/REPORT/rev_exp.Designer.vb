<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rev_exp
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
        Me.txtmonth = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OKAY = New System.Windows.Forms.Button()
        Me.dgvrevenue = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblmonth = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvrevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtmonth
        '
        Me.txtmonth.FormattingEnabled = True
        Me.txtmonth.Items.AddRange(New Object() {"JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"})
        Me.txtmonth.Location = New System.Drawing.Point(106, 21)
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.Size = New System.Drawing.Size(110, 21)
        Me.txtmonth.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "MONTH"
        '
        'OKAY
        '
        Me.OKAY.Location = New System.Drawing.Point(56, 48)
        Me.OKAY.Name = "OKAY"
        Me.OKAY.Size = New System.Drawing.Size(160, 30)
        Me.OKAY.TabIndex = 3
        Me.OKAY.Text = "OKAY"
        Me.OKAY.UseVisualStyleBackColor = True
        '
        'dgvrevenue
        '
        Me.dgvrevenue.AllowUserToAddRows = False
        Me.dgvrevenue.AllowUserToDeleteRows = False
        Me.dgvrevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvrevenue.Location = New System.Drawing.Point(20, 117)
        Me.dgvrevenue.Name = "dgvrevenue"
        Me.dgvrevenue.ReadOnly = True
        Me.dgvrevenue.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvrevenue.Size = New System.Drawing.Size(229, 79)
        Me.dgvrevenue.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "MONTH OF"
        '
        'lblmonth
        '
        Me.lblmonth.AutoSize = True
        Me.lblmonth.Location = New System.Drawing.Point(132, 101)
        Me.lblmonth.Name = "lblmonth"
        Me.lblmonth.Size = New System.Drawing.Size(0, 13)
        Me.lblmonth.TabIndex = 24
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(288, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(488, 354)
        Me.DataGridView1.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 87)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "DISPLAY MANAGER MONITORING"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rev_exp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblmonth)
        Me.Controls.Add(Me.dgvrevenue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OKAY)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmonth)
        Me.Name = "rev_exp"
        Me.Text = "datad"
        CType(Me.dgvrevenue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OKAY As System.Windows.Forms.Button
    Friend WithEvents dgvrevenue As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblmonth As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
