Imports System.IO
Imports System.Threading.Thread
Public Class main

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "/catch_me") Then
            Try
                Console.WriteLine("Creating App Folder")
                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "/catch_me")
                Console.WriteLine("App Folder Created Successfully")
                Sleep(1000)
                Console.WriteLine("Creating Sub Folders")
                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "/catch_me/resources")
                Console.WriteLine("Sub Folders Created Sucessfully")
                Sleep(1000)
                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "/catch_me")
                My.Computer.FileSystem.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "/catch_me/leaderboard.leaders", "", False)
                My.Computer.FileSystem.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "/catch_me/starting_state.txt", "", False)
            Catch ex As Exception
                MsgBox(ex)
            End Try

        End If

        Dim appdatapath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/catch_me"

        Dim files() As String = IO.Directory.GetFiles(appdatapath & "/resources")

        For Each File As String In files
            If Path.GetFileName(File).StartsWith("click") Then
                sound = File
            End If
        Next

    End Sub


    Private newpoint As System.Drawing.Point
    Private xpos1 As Integer
    Private ypos1 As Integer
    Dim sound As String

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

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        game.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        leaderboard.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        settings.Show()
    End Sub
End Class
