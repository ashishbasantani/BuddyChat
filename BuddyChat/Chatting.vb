Public Class Chatting

    Private Sub Chatting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chatarea.MdiParent = Me
        chatarea.Show()
    End Sub

    Private Sub AddContactToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddContactToolStripMenuItem.Click
        addcontact.MdiParent = Me
        addcontact.Show()
    End Sub
End Class