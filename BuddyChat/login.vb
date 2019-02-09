
Public Class login
    Dim con As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Dim dr1 As SqlClient.SqlDataReader
    Dim flag As Integer
    Public loggeduser As String
    Public loggedmob As String
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\BuddyChat\BuddyChat\BuddyChat.mdf;Integrated Security=True;User Instance=True")
        con.Open()
    End Sub



    Private Sub log_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles log.MouseHover
        log.BackColor = Color.White
    End Sub

    Private Sub log_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles log.MouseLeave
        log.BackColor = Color.Cyan
    End Sub

    Private Sub Label3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseHover
        log.BackColor = Color.White
    End Sub

    Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        log.BackColor = Color.Cyan
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        log_in()
    End Sub

    Private Sub log_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles log.MouseClick
        log_in()
    End Sub
    Public Sub log_in()
        If (username.Text = "" Or password.Text = "") Then
            MsgBox("Please enter username or password")
        Else
            cmd = New SqlClient.SqlCommand("select * from login where username='" & username.Text & "'", con)
            dr = cmd.ExecuteReader()
            flag = 1
        End If
        If flag = 1 Then
            Try
                dr.Read()
                If (password.Text = dr.Item("password")) Then
                    loggeduser = dr.Item("username")
                    dr.Close()
                    cmd = New SqlClient.SqlCommand("select * from Register where username='" & username.Text & "'", con)
                    dr1 = cmd.ExecuteReader()
                    dr1.Read()
                    loggedmob = dr1.Item("mob")
                    Chatting.Show()
                    Me.Hide()
                Else
                    MsgBox("Wrong Password")
                End If
                dr.Close()
            Catch ex As Exception
                MsgBox("Please enter correct username")
                dr.Close()
            End Try
        End If
    End Sub
End Class