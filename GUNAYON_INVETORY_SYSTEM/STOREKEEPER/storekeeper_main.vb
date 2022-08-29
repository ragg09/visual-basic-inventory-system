Public Class storekeeper_main

    Dim palamig As New palamig
    Dim pancake As New pancake
    Dim hamburger As New hamburger
    Dim hotdog_ban As New hotdog_bun

    Dim order_station As New order_station

    Private Sub LOGOUTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Dim ask As MsgBoxResult = MsgBox("Do you want to sign out?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            Application.Restart()
        End If
    End Sub

    Private Sub PALAMIGToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PALAMIGToolStripMenuItem.Click
        palamig.MdiParent = Me
        palamig.Dock = DockStyle.Fill
        pancake.Hide()
        hamburger.Hide()
        hotdog_ban.Hide()
        order_station.Hide()
        items_to_be_sold.Hide()
        item_to_be_use.Hide()
        palamig.Show()
    End Sub

    Private Sub PANCAKEToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PANCAKEToolStripMenuItem.Click
        pancake.MdiParent = Me
        pancake.Dock = DockStyle.Fill
        palamig.Hide()
        hamburger.Hide()
        hotdog_ban.Hide()
        order_station.Hide()
        items_to_be_sold.Hide()
        item_to_be_use.Hide()
        pancake.Show()
    End Sub

    Private Sub HAMBURGERToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HAMBURGERToolStripMenuItem.Click
        hamburger.MdiParent = Me
        hamburger.Dock = DockStyle.Fill
        palamig.Hide()
        pancake.Hide()
        hotdog_ban.Hide()
        order_station.Hide()
        items_to_be_sold.Hide()
        item_to_be_use.Hide()
        hamburger.Show()
    End Sub

    Private Sub HOTDOGBANToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HOTDOGBANToolStripMenuItem.Click
        hotdog_ban.MdiParent = Me
        hotdog_ban.Dock = DockStyle.Fill
        palamig.Hide()
        pancake.Hide()
        hamburger.Hide()
        order_station.Hide()
        items_to_be_sold.Hide()
        item_to_be_use.Hide()
        hotdog_ban.Show()
    End Sub

    Private Sub ORDERSTATIONToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ORDERSTATIONToolStripMenuItem.Click
        order_station.MdiParent = Me
        order_station.Dock = DockStyle.Fill
        palamig.Hide()
        pancake.Hide()
        hamburger.Hide()
        hotdog_ban.Hide()
        items_to_be_sold.Hide()
        item_to_be_use.Hide()
        order_station.Show()
    End Sub

    Private Sub ITEMStoSOLDToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ITEMStoSOLDToolStripMenuItem.Click
        items_to_be_sold.MdiParent = Me
        items_to_be_sold.Dock = DockStyle.Fill
        palamig.Hide()
        pancake.Hide()
        hamburger.Hide()
        hotdog_ban.Hide()
        order_station.Hide()
        item_to_be_use.Hide()
        items_to_be_sold.Show()
    End Sub

    Private Sub ITEMToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ITEMToolStripMenuItem.Click
        item_to_be_use.MdiParent = Me
        item_to_be_use.Dock = DockStyle.Fill
        palamig.Hide()
        pancake.Hide()
        hamburger.Hide()
        hotdog_ban.Hide()
        order_station.Hide()
        items_to_be_sold.Hide()
        item_to_be_use.Show()
    End Sub
End Class