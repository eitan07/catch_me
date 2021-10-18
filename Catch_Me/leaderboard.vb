Imports System.Net
Imports System.IO
Imports System.Threading.Thread

Public Class leaderboard

    Private newpoint As Point
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

    Private Sub leaderboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getRecords()
    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        getRecords()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        getRecords()
    End Sub

    Sub getRecords()
        If ComboBox1.SelectedIndex = 0 Then
            tbl_leaders.Rows.Clear()
            Try
                Dim req As HttpWebRequest = HttpWebRequest.Create("https://catchmeleaderboard.eitan07.repl.co")
                Dim res As HttpWebResponse = req.GetResponse
                Dim stream As Stream = res.GetResponseStream
                Dim streamreader As StreamReader = New StreamReader(stream)
                Dim response As String = streamreader.ReadToEnd
                Dim leaders() As String = response.Split(";")
                For i = 0 To leaders.Count - 2
                    Dim leader_data() As String = leaders(i).Split(",")
                    tbl_leaders.Rows.Add(leader_data(0), leader_data(1), leader_data(2), leader_data(3))
                Next
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error!")
                Console.WriteLine("Error!" & vbNewLine & ex.Message)
            End Try
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Dim leaders() As String = My.Computer.FileSystem.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "/catch_me/leaderboard.leaders").Split(";")
            tbl_leaders.Rows.Clear()
            For i = 0 To leaders.Count - 2
                Dim leader_data() As String = leaders(i).Split(",")
                tbl_leaders.Rows.Add(leader_data(0), leader_data(1), leader_data(2), leader_data(3))
            Next
        End If
    End Sub
End Class