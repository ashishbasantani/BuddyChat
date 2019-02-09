Public Class welcomepage
    Dim i As Integer
    Dim j As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        wel.Enabled = True
        wel.Interval = 100
        i = 0
        j = 0
        slide.Enabled = True
        slide.Interval = 1000
    End Sub

    Private Sub wel_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wel.Tick
        If (i < 5) Then
            welcome.ForeColor = Color.AliceBlue
        ElseIf (i > 5 And i < 10) Then
            welcome.ForeColor = Color.CornflowerBlue
        End If
        If (i > 11) Then
            i = 0
        End If
        i = i + 1

    End Sub

    Private Sub slide_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slide.Tick
        If (j < 5) Then
            slider.ImageLocation = "C:\Users\Mohit\Documents\Visual Studio 2010\Projects\BuddyChat\BuddyChat\Slider\1.jpg"
        ElseIf (j > 5 And j < 10) Then
            slider.ImageLocation = "C:\Users\Mohit\Documents\Visual Studio 2010\Projects\BuddyChat\BuddyChat\Slider\2.jpg"
        ElseIf (j > 10 And j < 15) Then
            slider.ImageLocation = "C:\Users\Mohit\Documents\Visual Studio 2010\Projects\BuddyChat\BuddyChat\Slider\4.jpg"
        ElseIf (j > 15 And j < 20) Then
            slider.ImageLocation = "C:\Users\Mohit\Documents\Visual Studio 2010\Projects\BuddyChat\BuddyChat\Slider\5.jpg"
        End If
        If (j > 20) Then
            j = 0
        End If
        j = j + 1
    End Sub

    

    Private Sub log_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles log.MouseHover
        log.BackColor = Color.White
    End Sub

   

    Private Sub sign_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles sign.MouseHover
        sign.BackColor = Color.White
    End Sub

    Private Sub log_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles log.MouseLeave
        log.BackColor = Color.SteelBlue
    End Sub

    Private Sub sign_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles sign.MouseLeave
        sign.BackColor = Color.LimeGreen
    End Sub

    Private Sub Label2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseHover
        log.BackColor = Color.White
    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave
        log.BackColor = Color.SteelBlue
    End Sub

    Private Sub Label3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseHover
        sign.BackColor = Color.White
    End Sub

    Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        sign.BackColor = Color.LimeGreen
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Hide()
        slide.Enabled = False
        wel.Enabled = False
        login.Show()
    End Sub
    Private Sub log_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles log.MouseClick
        Me.Hide()
        slide.Enabled = False
        wel.Enabled = False
        login.Show()
    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Hide()
        slide.Enabled = False
        wel.Enabled = False
        SignUp.Show()
    End Sub
    Private Sub sign_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sign.MouseClick
        Me.Hide()
        slide.Enabled = False
        wel.Enabled = False
        SignUp.Show()
    End Sub
End Class
