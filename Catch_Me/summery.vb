Public Class summery

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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        End
    End Sub

    Private Sub summery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        game.WindowState = FormWindowState.Normal
        lbl_score.Text = "Score: " & game.score
        lbl_misses.Text = "Misses: " & game.misses

        ToolTip1.SetToolTip(btn_menu, "Back to menu")
        ToolTip1.SetToolTip(btn_leaderboard, "Save Your Score And Name To The Online " & vbCrLf & "Leaderboard (Or To The Local Leaderboard)")
        ToolTip1.SetToolTip(btn_rematch, "Start A New Game")
    End Sub

    Private Sub btn_rematch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_rematch.Click
        Dim frm As Form = New game
        game.Show()
        Me.Close()
    End Sub

    Private Sub btn_leave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu.Click
        game.Close()
        save_record.Close()
        Me.Close()
        Process.Start(Application.ExecutablePath)
    End Sub

    Private Sub btn_leaderboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_leaderboard.Click
        save_record.Show()
    End Sub
End Class