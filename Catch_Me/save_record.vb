Imports System.Net
Imports System.Collections.Specialized
Imports System.Text

Public Class save_record

    Private newpoint As System.Drawing.Point
    Private xpos1 As Integer
    Private ypos1 As Integer

    Private Sub pnlTopBorder_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTopBorder.MouseDown
        xpos1 = Control.MousePosition.X - Me.Location.X
        ypos1 = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub pnlTopBorder_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTopBorder.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (xpos1)
            newpoint.Y -= (ypos1)
            Me.Location = newpoint
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox1.SelectedIndex = 0 Then
            If TextBox1.Text = "" Then
                MsgBox("Where is the name?")
            Else
                Dim rec_save = save_record_to_online(TextBox1.Text, 10, 8)
                If rec_save = "Username already taken :(" Then
                    MsgBox("Username already taken :(")
                ElseIf rec_save = "Illegal Save Request!" Then
                    MsgBox("Something not right here, check if your name have , or ; or any spaces")
                ElseIf rec_save = "Record Saved Successfully" Then
                    MsgBox("Your Record Saved Successfully")
                    Me.Close()
                    summery.btn_leaderboard.Enabled = False
                End If
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Then
            save_record_to_offline(TextBox1.Text, 10, 8)
        End If
    End Sub

    Function save_record_to_online(ByVal name, ByVal score, ByVal misses) As String
        Dim values As NameValueCollection = New NameValueCollection
        values.Add("name", name)
        values.Add("score", score)
        values.Add("misses", misses)
        Dim webclient As WebClient = New WebClient
        Dim response_bytes() As Byte = webclient.UploadValues("https://catchmeleaderboard.eitan07.repl.co", values)
        Dim response As String = Encoding.UTF8.GetString(response_bytes)
        Console.WriteLine(response)
        Return response
    End Function

    Sub save_record_to_offline(ByVal name As String, ByVal score As String, ByVal misses As String)
        Dim datenow As DateTime = DateTime.Now
        Dim date_ As String = datenow.Day & "/" & datenow.Month & "/" & datenow.Year
        Dim text As String = name & "," & score & "," & misses & "," & date_ & ";"
        Try
            My.Computer.FileSystem.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "/catch_me/leaderboard.leaders", text, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error")
            Console.WriteLine(ex)
        End Try
        MsgBox("Your Record Saved Successfully")
        Me.Close()
        summery.btn_leaderboard.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        leaderboard.Show()
    End Sub
End Class