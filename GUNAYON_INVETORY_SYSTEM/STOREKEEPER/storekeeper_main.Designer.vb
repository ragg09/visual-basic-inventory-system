<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class storekeeper_main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ITEMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUCTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PALAMIGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PANCAKEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HAMBURGERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HOTDOGBANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ITEMStoSOLDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ORDERSTATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ITEMToolStripMenuItem, Me.PRODUCTToolStripMenuItem, Me.ORDERSTATIONToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(858, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ITEMToolStripMenuItem
        '
        Me.ITEMToolStripMenuItem.Name = "ITEMToolStripMenuItem"
        Me.ITEMToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ITEMToolStripMenuItem.Text = "ITEM"
        '
        'PRODUCTToolStripMenuItem
        '
        Me.PRODUCTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PALAMIGToolStripMenuItem, Me.PANCAKEToolStripMenuItem, Me.HAMBURGERToolStripMenuItem, Me.HOTDOGBANToolStripMenuItem, Me.ITEMStoSOLDToolStripMenuItem})
        Me.PRODUCTToolStripMenuItem.Name = "PRODUCTToolStripMenuItem"
        Me.PRODUCTToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.PRODUCTToolStripMenuItem.Text = "PRODUCT"
        '
        'PALAMIGToolStripMenuItem
        '
        Me.PALAMIGToolStripMenuItem.Name = "PALAMIGToolStripMenuItem"
        Me.PALAMIGToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PALAMIGToolStripMenuItem.Text = "PALAMIG"
        '
        'PANCAKEToolStripMenuItem
        '
        Me.PANCAKEToolStripMenuItem.Name = "PANCAKEToolStripMenuItem"
        Me.PANCAKEToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PANCAKEToolStripMenuItem.Text = "PANCAKE"
        '
        'HAMBURGERToolStripMenuItem
        '
        Me.HAMBURGERToolStripMenuItem.Name = "HAMBURGERToolStripMenuItem"
        Me.HAMBURGERToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.HAMBURGERToolStripMenuItem.Text = "HAMBURGER"
        '
        'HOTDOGBANToolStripMenuItem
        '
        Me.HOTDOGBANToolStripMenuItem.Name = "HOTDOGBANToolStripMenuItem"
        Me.HOTDOGBANToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.HOTDOGBANToolStripMenuItem.Text = "HOTDOG BUN"
        '
        'ITEMStoSOLDToolStripMenuItem
        '
        Me.ITEMStoSOLDToolStripMenuItem.Name = "ITEMStoSOLDToolStripMenuItem"
        Me.ITEMStoSOLDToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ITEMStoSOLDToolStripMenuItem.Text = "ITEMStoSOLD"
        '
        'ORDERSTATIONToolStripMenuItem
        '
        Me.ORDERSTATIONToolStripMenuItem.Name = "ORDERSTATIONToolStripMenuItem"
        Me.ORDERSTATIONToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.ORDERSTATIONToolStripMenuItem.Text = "ORDER STATION"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '
        'storekeeper_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 471)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "storekeeper_main"
        Me.Text = "storekeeper_main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PRODUCTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PALAMIGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ORDERSTATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PANCAKEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HAMBURGERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HOTDOGBANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ITEMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ITEMStoSOLDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
