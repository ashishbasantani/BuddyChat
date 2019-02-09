<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class welcomepage
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
        Me.components = New System.ComponentModel.Container()
        Me.welcome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.wel = New System.Windows.Forms.Timer(Me.components)
        Me.slide = New System.Windows.Forms.Timer(Me.components)
        Me.slider = New System.Windows.Forms.PictureBox()
        Me.log = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sign = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.slider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.log.SuspendLayout()
        Me.sign.SuspendLayout()
        Me.SuspendLayout()
        '
        'welcome
        '
        Me.welcome.AutoSize = True
        Me.welcome.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcome.Location = New System.Drawing.Point(514, 9)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(254, 76)
        Me.welcome.TabIndex = 0
        Me.welcome.Text = "WELCOME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(553, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "to Buddy Chat"
        '
        'wel
        '
        '
        'slide
        '
        '
        'slider
        '
        Me.slider.Location = New System.Drawing.Point(35, 185)
        Me.slider.Name = "slider"
        Me.slider.Size = New System.Drawing.Size(1078, 507)
        Me.slider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.slider.TabIndex = 0
        Me.slider.TabStop = False
        '
        'log
        '
        Me.log.BackColor = System.Drawing.Color.SteelBlue
        Me.log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.log.Controls.Add(Me.Label2)
        Me.log.Location = New System.Drawing.Point(902, 21)
        Me.log.Name = "log"
        Me.log.Size = New System.Drawing.Size(135, 34)
        Me.log.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Log In"
        '
        'sign
        '
        Me.sign.BackColor = System.Drawing.Color.LimeGreen
        Me.sign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sign.Controls.Add(Me.Label3)
        Me.sign.Location = New System.Drawing.Point(1086, 21)
        Me.sign.Name = "sign"
        Me.sign.Size = New System.Drawing.Size(135, 34)
        Me.sign.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Sign Up"
        '
        'welcomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.sign)
        Me.Controls.Add(Me.log)
        Me.Controls.Add(Me.slider)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.welcome)
        Me.Name = "welcomepage"
        Me.Text = "Buddy Chat"
        CType(Me.slider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.log.ResumeLayout(False)
        Me.log.PerformLayout()
        Me.sign.ResumeLayout(False)
        Me.sign.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents welcome As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents wel As System.Windows.Forms.Timer
    Friend WithEvents slide As System.Windows.Forms.Timer
    Friend WithEvents slider As System.Windows.Forms.PictureBox
    Friend WithEvents log As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents sign As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
