<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chatting
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
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditProfileToolStripMenuItem, Me.SearchProfileToolStripMenuItem, Me.DeleteChatToolStripMenuItem, Me.AddContactToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditProfileToolStripMenuItem
        '
        Me.EditProfileToolStripMenuItem.Name = "EditProfileToolStripMenuItem"
        Me.EditProfileToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.EditProfileToolStripMenuItem.Text = "Edit Profile"
        '
        'SearchProfileToolStripMenuItem
        '
        Me.SearchProfileToolStripMenuItem.Name = "SearchProfileToolStripMenuItem"
        Me.SearchProfileToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.SearchProfileToolStripMenuItem.Text = "Search Profile"
        '
        'DeleteChatToolStripMenuItem
        '
        Me.DeleteChatToolStripMenuItem.Name = "DeleteChatToolStripMenuItem"
        Me.DeleteChatToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.DeleteChatToolStripMenuItem.Text = "Delete Chat"
        '
        'AddContactToolStripMenuItem
        '
        Me.AddContactToolStripMenuItem.Name = "AddContactToolStripMenuItem"
        Me.AddContactToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.AddContactToolStripMenuItem.Text = "Add Contact"
        '
        'Chatting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Chatting"
        Me.Text = "Chatting"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteChatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
