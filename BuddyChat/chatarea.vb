Public Class chatarea
    Dim con As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim cmd1 As SqlClient.SqlCommand
    Dim con1 As SqlClient.SqlConnection
    Dim dr As SqlClient.SqlDataReader
    Dim count As Integer
    Dim i As Integer
    Dim online As String

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\BuddyChat\BuddyChat\Users\" & login.loggedmob & ".mdf;Integrated Security=True;User Instance=True")
        con.Open()
        cmd = New SqlClient.SqlCommand("select count(*) from friends", con)
        count = cmd.ExecuteScalar
        cmd = New SqlClient.SqlCommand("select * from friends", con)
        dr = cmd.ExecuteReader
        i = 1
        While i <= count
            dr.Read()
            contacts.Items.Add(dr.Item("mobno"))
            i = i + 1
        End While
        dr.Close()

        refresh.Interval = 10000
    End Sub

    Private Sub contacts_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles contacts.MouseClick
        
    End Sub

    Private Sub contacts_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles contacts.MouseDoubleClick
        refresh.Enabled = True
        chaton()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd = New SqlClient.SqlCommand("insert into B" & login.loggedmob & " values ('Me:" & message.Text & "')", con1)
        cmd.ExecuteNonQuery()
        cmd = New SqlClient.SqlCommand("insert into B" & Label1.Text & " values ('" & Label1.Text & message.Text & "')", con)
        cmd.ExecuteNonQuery()
        chatting.Items.Add(message.Text)
        message.Clear()
    End Sub

    Private Sub refresh_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles refresh.Tick
        chaton()
    End Sub
    Public Sub chaton()
        i = 1
        Label1.Text = contacts.SelectedItem
        online = "B" & contacts.SelectedItem
        cmd1 = New SqlClient.SqlCommand("select count(*) from " & online, con)
        count = cmd1.ExecuteScalar
        cmd1 = New SqlClient.SqlCommand("select * from " & online, con)
        dr = cmd1.ExecuteReader
        chatting.Items.Clear()
        While i <= count
            dr.Read()
            chatting.Items.Add(dr.Item("chat"))
            i = i + 1
        End While
        chatting.TopIndex = chatting.Items.Count - 1
        dr.Close()
        con1 = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\BuddyChat\BuddyChat\Users\" & Label1.Text & ".mdf;Integrated Security=True;User Instance=True")
        con1.Open()
    End Sub
End Class