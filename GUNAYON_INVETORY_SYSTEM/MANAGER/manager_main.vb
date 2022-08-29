Public Class manager_main

    Dim item_insert As New item_insert
    Dim display_all As New display_all
    Dim item_update As New item_update
    Dim item_order As New item_order

    Dim sup_create As New sup_create
    Dim sup_update As New sup_update

    Dim daily_revenue As New daily_revenue
    Dim daily_expense As New daily_expense
    Dim rev_exp As New rev_exp

    Dim sk_create As New sk_create
    Dim sk_update As New sk_update
    Dim sk_delet As New sk_delete

    Dim manager_settings As New manager_settings

    'Private Sub SIGNOUTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SIGNOUTToolStripMenuItem.Click
    '    Dim ask As MsgBoxResult = MsgBox("Do you want to sign out?", MsgBoxStyle.YesNo)
    '    If ask = MsgBoxResult.Yes Then
    '        Application.Restart()
    '    End If
    'End Sub

    Private Sub INSERTNEWToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles INSERTNEWToolStripMenuItem.Click
        item_insert.MdiParent = Me
        item_insert.Dock = DockStyle.Fill
        display_all.Hide()
        item_order.Hide()
        item_update.Hide()
        sup_create.Hide()
        sup_update.Hide()
        daily_revenue.Hide()
        daily_expense.Hide()
        rev_exp.Hide()
        sk_create.Hide()
        sk_update.Hide()
        manager_settings.Hide()
        sk_delete.Hide()
        manager_supplier_transaction.Hide()
        other_transactions.Hide()
        transaction_between_customer.Hide()
        item_insert.Show()
    End Sub

    Private Sub DISPLAYALLToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DISPLAYALLToolStripMenuItem.Click
        display_all.MdiParent = Me
        display_all.Dock = DockStyle.Fill
        item_insert.Hide()
        item_update.Hide()
        item_order.Hide()
        sup_create.Hide()
        sup_update.Hide()
        daily_revenue.Hide()
        daily_expense.Hide()
        rev_exp.Hide()
        sk_create.Hide()
        sk_update.Hide()
        manager_settings.Hide()
        sk_delete.Hide()
        manager_supplier_transaction.Hide()
        other_transactions.Hide()
        transaction_between_customer.Hide()
        display_all.Show()
    End Sub

    Private Sub UPDATEToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UPDATEToolStripMenuItem.Click
        item_update.MdiParent = Me
        item_update.Dock = DockStyle.Fill
        item_insert.Hide()
        display_all.Hide()
        item_order.Hide()
        sup_create.Hide()
        sup_update.Hide()
        daily_revenue.Hide()
        daily_expense.Hide()
        rev_exp.Hide()
        sk_create.Hide()
        sk_update.Hide()
        manager_settings.Hide()
        sk_delete.Hide()
        manager_supplier_transaction.Hide()
        other_transactions.Hide()
        transaction_between_customer.Hide()
        item_update.Show()
    End Sub

    Private Sub CREATEToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CREATEToolStripMenuItem.Click
        item_order.MdiParent = Me
        item_order.Dock = DockStyle.Fill
        item_insert.Hide()
        display_all.Hide()
        item_update.Hide()
        sup_create.Hide()
        sup_update.Hide()
        daily_revenue.Hide()
        daily_expense.Hide()
        rev_exp.Hide()
        sk_create.Hide()
        sk_update.Hide()
        manager_settings.Hide()
        sk_delete.Hide()
        manager_supplier_transaction.Hide()
        other_transactions.Hide()
        transaction_between_customer.Hide()
        item_order.Show()
    End Sub

    Private Sub CREATEToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles CREATEToolStripMenuItem1.Click
        sup_create.MdiParent = Me
        sup_create.Dock = DockStyle.Fill
        item_insert.Hide()
        display_all.Hide()
        item_update.Hide()
        item_order.Hide()
        sup_update.Hide()
        daily_revenue.Hide()
        daily_expense.Hide()
        rev_exp.Hide()
        sk_create.Hide()
        sk_update.Hide()
        manager_settings.Hide()
        sk_delete.Hide()
        manager_supplier_transaction.Hide()
        other_transactions.Hide()
        transaction_between_customer.Hide()
        sup_create.Show()
    End Sub

    Private Sub UPDATEToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles UPDATEToolStripMenuItem1.Click
        sup_update.MdiParent = Me
        sup_update.Dock = DockStyle.Fill
        item_insert.Hide()
        display_all.Hide()
        item_update.Hide()
        item_order.Hide()
        sup_create.Hide()
        daily_revenue.Hide()
        daily_expense.Hide()
        rev_exp.Hide()
        sk_create.Hide()
        sk_update.Hide()
        manager_settings.Hide()
        sk_delete.Hide()
        manager_supplier_transaction.Hide()
        other_transactions.Hide()
        transaction_between_customer.Hide()
        sup_update.Show()
    End Sub

    Private Sub DAILYREVENUEToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DAILYREVENUEToolStripMenuItem.Click
        daily_revenue.MdiParent = Me
        daily_revenue.Dock = DockStyle.Fill
        item_insert.Hide()
        display_all.Hide()
        item_update.Hide()
        item_order.Hide()
        sup_create.Hide()
        sup_update.Hide()
        daily_expense.Hide()
        rev_exp.Hide()
        sk_create.Hide()
        sk_update.Hide()
        manager_settings.Hide()
        sk_delete.Hide()
        manager_supplier_transaction.Hide()
        other_transactions.Hide()
        transaction_between_customer.Hide()
        daily_revenue.Show()
    End Sub

    Private Sub DAILYEXPENSEToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DAILYEXPENSEToolStripMenuItem.Click
        daily_expense.MdiParent = Me
        daily_expense.Dock = DockStyle.Fill
        item_insert.Hide()
        display_all.Hide()
        item_update.Hide()
        item_order.Hide()
        sup_create.Hide()
        sup_update.Hide()
        daily_revenue.Hide()
        rev_exp.Hide()
        sk_create.Hide()
        sk_update.Hide()
        manager_settings.Hide()
        sk_delete.Hide()
        manager_supplier_transaction.Hide()
        other_transactions.Hide()
        transaction_between_customer.Hide()
        daily_expense.Show()
    End Sub

    Private Sub MONTHLYREVENUEToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MONTHLYREVENUEToolStripMenuItem.Click
        rev_exp.MdiParent = Me
        rev_exp.Dock = DockStyle.Fill
        item_insert.Hide()
        display_all.Hide()
        item_update.Hide()
        item_order.Hide()
        sup_create.Hide()
        sup_update.Hide()
        daily_revenue.Hide()
        daily_expense.Hide()
        sk_create.Hide()
        sk_update.Hide()
        manager_settings.Hide()
        sk_delete.Hide()
        manager_supplier_transaction.Hide()
        other_transactions.Hide()
        transaction_between_customer.Hide()
        rev_exp.Show()
    End Sub

    'Private Sub CREATEToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles CREATEToolStripMenuItem2.Click
    '    sk_create.MdiParent = Me
    '    sk_create.Dock = DockStyle.Fill
    '    item_insert.Hide()
    '    display_all.Hide()
    '    item_update.Hide()
    '    item_order.Hide()
    '    sup_create.Hide()
    '    sup_update.Hide()
    '    daily_revenue.Hide()
    '    daily_expense.Hide()
    '    rev_exp.Hide()
    '    sk_update.Hide()
    '    sk_create.Show()
    'End Sub

    'Private Sub DELETEToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DELETEToolStripMenuItem.Click

    '    sk_update.MdiParent = Me
    '    sk_update.Dock = DockStyle.Fill
    '    item_insert.Hide()
    '    display_all.Hide()
    '    item_update.Hide()
    '    item_order.Hide()
    '    sup_create.Hide()
    '    sup_update.Hide()
    '    daily_revenue.Hide()
    '    daily_expense.Hide()
    '    rev_exp.Hide()
    '    sk_create.Hide()
    '    sk_update.Show()
    'End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Dim ask As MsgBoxResult = MsgBox("Do you want to sign out?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            Application.Restart()
        End If
    End Sub

    Private Sub MANAGERToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MANAGERToolStripMenuItem.Click
        manager_settings.MdiParent = Me
        manager_settings.Dock = DockStyle.Fill
        item_insert.Hide()
        display_all.Hide()
        item_update.Hide()
        item_order.Hide()
        sup_create.Hide()
        sup_update.Hide()
        daily_revenue.Hide()
        daily_expense.Hide()
        sk_create.Hide()
        sk_update.Hide()
        rev_exp.Hide()
        sk_delete.Hide()
        manager_supplier_transaction.Hide()
        other_transactions.Hide()
        transaction_between_customer.Hide()
        manager_settings.Show()
    End Sub

    Private Sub CREATEToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles CREATEToolStripMenuItem3.Click
        sk_create.MdiParent = Me
        sk_create.Dock = DockStyle.Fill
        item_insert.Hide()
        display_all.Hide()
        item_update.Hide()
        item_order.Hide()
        sup_create.Hide()
        sup_update.Hide()
        daily_revenue.Hide()
        daily_expense.Hide()
        sk_update.Hide()
        rev_exp.Hide()
        manager_settings.Hide()
        sk_delete.Hide()
        manager_supplier_transaction.Hide()
        other_transactions.Hide()
        transaction_between_customer.Hide()
        sk_create.Show()
    End Sub

    Private Sub UPDATEToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles UPDATEToolStripMenuItem2.Click
        sk_update.MdiParent = Me
        sk_update.Dock = DockStyle.Fill
        item_insert.Hide()
        display_all.Hide()
        item_update.Hide()
        item_order.Hide()
        sup_create.Hide()
        sup_update.Hide()
        daily_revenue.Hide()
        daily_expense.Hide()
        rev_exp.Hide()
        manager_settings.Hide()
        sk_create.Hide()
        sk_delete.Hide()
        transaction_between_customer.Hide()
        other_transactions.Hide()
        manager_supplier_transaction.Hide()
        sk_update.Show()
    End Sub

    Private Sub DELETEToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DELETEToolStripMenuItem1.Click
        sk_delete.MdiParent = Me
        sk_delete.Dock = DockStyle.Fill
        item_insert.Hide()
        display_all.Hide()
        item_update.Hide()
        item_order.Hide()
        sup_create.Hide()
        sup_update.Hide()
        daily_revenue.Hide()
        daily_expense.Hide()
        rev_exp.Hide()
        manager_settings.Hide()
        sk_create.Hide()
        sk_update.Hide()
        transaction_between_customer.Hide()
        other_transactions.Hide()
        manager_supplier_transaction.Hide()
        sk_delete.Show()
    End Sub

    Private Sub TRANSACTIONWITHSUPPLIERToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TRANSACTIONWITHSUPPLIERToolStripMenuItem.Click
        manager_supplier_transaction.MdiParent = Me
        manager_supplier_transaction.Dock = DockStyle.Fill
        item_insert.Hide()
        display_all.Hide()
        item_update.Hide()
        item_order.Hide()
        sup_create.Hide()
        sup_update.Hide()
        daily_revenue.Hide()
        daily_expense.Hide()
        rev_exp.Hide()
        manager_settings.Hide()
        sk_create.Hide()
        sk_update.Hide()
        sk_delete.Hide()
        transaction_between_customer.Hide()
        other_transactions.Hide()
        manager_supplier_transaction.Show()
    End Sub

    Private Sub TRANSACTIONBETWWENCUSTOMERToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TRANSACTIONBETWWENCUSTOMERToolStripMenuItem.Click
        transaction_between_customer.MdiParent = Me
        transaction_between_customer.Dock = DockStyle.Fill
        item_insert.Hide()
        display_all.Hide()
        item_update.Hide()
        item_order.Hide()
        sup_create.Hide()
        sup_update.Hide()
        daily_revenue.Hide()
        daily_expense.Hide()
        rev_exp.Hide()
        manager_settings.Hide()
        sk_create.Hide()
        sk_update.Hide()
        sk_delete.Hide()
        manager_supplier_transaction.Hide()
        other_transactions.Hide()
        transaction_between_customer.Show()
    End Sub

    Private Sub OTHERTRANSACTIONSToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OTHERTRANSACTIONSToolStripMenuItem.Click
        other_transactions.MdiParent = Me
        other_transactions.Dock = DockStyle.Fill
        item_insert.Hide()
        display_all.Hide()
        item_update.Hide()
        item_order.Hide()
        sup_create.Hide()
        sup_update.Hide()
        daily_revenue.Hide()
        daily_expense.Hide()
        rev_exp.Hide()
        manager_settings.Hide()
        sk_create.Hide()
        sk_update.Hide()
        sk_delete.Hide()
        manager_supplier_transaction.Hide()
        transaction_between_customer.Hide()
        other_transactions.Show()
    End Sub

    Private Sub manager_main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class