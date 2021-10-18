Imports System.IO

Public Class reset
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox1.SelectedIndex = 0 Then

            Dim files() As String = IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\catch_me\resources")

            For Each File As String In files
                If Not File.StartsWith("character") Then
                    My.Computer.FileSystem.DeleteFile(File)
                End If
            Next
            Me.Close()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            My.Computer.FileSystem.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\catch_me\leaderboard.leaders", "", False)
            Me.Close()
        Else
            MsgBox("Please Select An Option!", MsgBoxStyle.Critical)
        End If
    End Sub
End Class