<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_storekeeper = New System.Windows.Forms.Button()
        Me.btn_manager = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_storekeeper
        '
        Me.btn_storekeeper.Location = New System.Drawing.Point(90, 202)
        Me.btn_storekeeper.Name = "btn_storekeeper"
        Me.btn_storekeeper.Size = New System.Drawing.Size(139, 36)
        Me.btn_storekeeper.TabIndex = 9
        Me.btn_storekeeper.Text = "STOREKEEPER"
        Me.btn_storekeeper.UseVisualStyleBackColor = True
        '
        'btn_manager
        '
        Me.btn_manager.Location = New System.Drawing.Point(90, 160)
        Me.btn_manager.Name = "btn_manager"
        Me.btn_manager.Size = New System.Drawing.Size(139, 36)
        Me.btn_manager.TabIndex = 8
        Me.btn_manager.Text = "MANAGER"
        Me.btn_manager.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(130, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "LOG IN AS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "LOGO HERE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GUNAYON_INVETORY_SYSTEM.My.Resources.Resources.LOGO_resized2
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 94)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(334, 255)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_storekeeper)
        Me.Controls.Add(Me.btn_manager)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Welcom To Gunayon Store"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_storekeeper As System.Windows.Forms.Button
    Friend WithEvents btn_manager As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
