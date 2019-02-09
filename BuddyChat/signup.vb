Imports System.IO
Public Class SignUp

    Dim con As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim pass As String
    Dim flag As Integer
    Dim dr As SqlClient.SqlDataReader
    Dim pwd As String
    Dim n As Integer

    Private Sub sign_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles sign.MouseHover
        sign.BackColor = Color.White
    End Sub

    Private Sub sign_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles sign.MouseLeave
        sign.BackColor = Color.LimeGreen
    End Sub

    Private Sub reset_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles reset.MouseHover
        reset.BackColor = Color.White
    End Sub

    Private Sub reset_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles reset.MouseLeave
        reset.BackColor = Color.SteelBlue
    End Sub

    Private Sub Label10_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label10.MouseHover
        sign.BackColor = Color.White
    End Sub

    Private Sub Label10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label10.MouseLeave
        sign.BackColor = Color.LimeGreen
    End Sub

    Private Sub Label11_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label11.MouseHover
        reset.BackColor = Color.White
    End Sub

    Private Sub Label11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label11.MouseLeave
        reset.BackColor = Color.SteelBlue
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        signup()
    End Sub
    Private Sub sign_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sign.MouseClick
        signup()
    End Sub
    Public Sub signup()
        If (username.Text = "" Or first.Text = "" Or last.Text = "" Or mob.Text = "" Or email.Text = "") Then
            MsgBox("Please fill all required fields")
        ElseIf (flag = 0) Then
            MsgBox("Please validate username first")
        Else
            cmd = New SqlClient.SqlCommand("insert into Register values('" & username.Text & "','" & first.Text & "','" & middle.Text & "','" & last.Text & "'," & mob.Text & ",'" & email.Text & "')", con)
            cmd.ExecuteNonQuery()
            n = username.TextLength()
            pwd = "BuddyChat@#" & n & n + 20
            cmd = New SqlClient.SqlCommand("insert into login values('" & username.Text & "','" & pwd & "')", con)
            cmd.ExecuteNonQuery()
            My.Computer.FileSystem.CopyFile("C:\Users\Mohit\Documents\Visual Studio 2010\Projects\BuddyChat\BuddyChat\Users\Prototype.mdf", "C:\Users\Mohit\Documents\Visual Studio 2010\Projects\BuddyChat\BuddyChat\Users\" & mob.Text & ".mdf")
            My.Computer.FileSystem.CopyFile("C:\Users\Mohit\Documents\Visual Studio 2010\Projects\BuddyChat\BuddyChat\Users\Prototype_log.ldf", "C:\Users\Mohit\Documents\Visual Studio 2010\Projects\BuddyChat\BuddyChat\Users\" & mob.Text & "_log.ldf")
            con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\BuddyChat\BuddyChat\Users\" & mob.Text & ".mdf;Integrated Security=True;User Instance=True")
            con.Open()
            cmd = New SqlClient.SqlCommand("create table friends(mobno varchar(12),username varchar(20))", con)
            cmd.ExecuteNonQuery()
            MsgBox("Registration Successfully Completed. Please check your mail for Password")
            MsgBox(pwd)
        End If
    End Sub

    Private Sub SignUp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\BuddyChat\BuddyChat\BuddyChat.mdf;Integrated Security=True;User Instance=True")
        con.Open()
        flag = 0
    End Sub

    Private Sub username_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles username.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmd = New SqlClient.SqlCommand("select firstname from Register where username='" & username.Text & "'", con)
            dr = cmd.ExecuteReader()
            dr.Read()
            Try
                flag = 0
                pwd = dr.Item("firstname")
                MsgBox("This username is already in use. Please choose another username.")
            Catch ex As Exception
                MsgBox("Validated Please Continue...")
                flag = 1
            End Try
            dr.Close()
        End If

    End Sub
End Class
