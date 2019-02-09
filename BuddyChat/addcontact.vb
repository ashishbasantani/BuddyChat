Public Class addcontact
    Dim con As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Dim con1 As SqlClient.SqlConnection
    Dim mob As String
    Dim user As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'cmd = New SqlClient.SqlCommand("select mob from Register where username='" & login.loggeduser & "'", con)
        'dr = cmd.ExecuteReader
        mob = login.loggedmob
        con1 = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\BuddyChat\BuddyChat\Users\" & mob & ".mdf;Integrated Security=True;User Instance=True")
        'con1 = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\BuddyChat\BuddyChat\Prototype.mdf;Integrated Security=True;User Instance=True")
        con1.Open()
        cmd = New SqlClient.SqlCommand("select * from Register where mob='" & TextBox1.Text & "'", con)
        dr = cmd.ExecuteReader
        Try
            dr.Read()
            user = dr.Item("username")
            cmd = New SqlClient.SqlCommand("insert into friends values ('" & TextBox1.Text & "','" & user & "')", con1)
            cmd.ExecuteNonQuery()
            Try
                cmd = New SqlClient.SqlCommand("create table B" & TextBox1.Text & "(chat varchar(100))", con1)
                cmd.ExecuteNonQuery()
            Catch ex As Exception

            End Try
        Catch ex As Exception
            MsgBox("Contact cannot be added to your friend list (error: contact not using BuddyChat)")
        End Try
        dr.Close()
    End Sub

    Private Sub addcontact_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\BuddyChat\BuddyChat\BuddyChat.mdf;Integrated Security=True;User Instance=True")
        con.Open()
    End Sub
End Class