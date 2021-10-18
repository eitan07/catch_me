Imports System.IO
Imports System.Threading.Thread

Public Class game



    Private newpoint As Point
    Private xpos1 As Integer
    Private ypos1 As Integer
    Dim start_countdown As Integer = 5
    Dim random As Random = New Random
    Public score As Integer = 0
    Dim time As Integer = 60
    Dim started As Boolean = False
    Public misses As Integer = 0
    Dim sound As String = ""
    Dim paused As Boolean = False
    Dim after_countdown As Boolean = False
    Dim a_paused As Boolean = False
    Dim p_text As String
    Dim start_state As String

    Private Sub pnlTopBorder_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTopBorder.MouseDown
        xpos1 = Control.MousePosition.X - Me.Location.X
        ypos1 = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub pnlTopBorder_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTopBorder.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then

            If Me.WindowState = FormWindowState.Maximized Then
                Me.WindowState = FormWindowState.Normal
            End If


            newpoint = Control.MousePosition
            newpoint.X -= (xpos1)
            newpoint.Y -= (ypos1)
            Me.Location = newpoint
        End If
    End Sub

    Private Sub game_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim appdatapath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/catch_me"
        Dim state As String = My.Computer.FileSystem.ReadAllText(appdatapath & "/starting_state.txt")

        If state = "mini" Then
            Me.WindowState = FormWindowState.Normal
        ElseIf state = "max" Then
            Me.WindowState = FormWindowState.Maximized
            Button1.Location = New Point(Button1.Location.X + 315, Button1.Location.Y)
            Button2.Location = New Point(Button2.Location.X + 315, Button1.Location.Y)
            Button3.Location = New Point(Button3.Location.X + 315, Button1.Location.Y)
            pnlTopBorder.Size = New Size(New Point(Me.Size.Width, pnlTopBorder.Size.Height))
        End If


        Try
            Dim files() As String = IO.Directory.GetFiles(appdatapath & "/resources")

            For Each File As String In files
                If Path.GetFileName(File).StartsWith("character") Then
                    c_pb.BackgroundImage = Image.FromFile(File)
                End If
            Next
            For Each File As String In files
                If Path.GetFileName(File).StartsWith("click") Then
                    sound = File
                End If
            Next
            For Each File As String In files
                If Path.GetFileName(File).StartsWith("background") Then
                    Me.BackgroundImage = Image.FromFile(File)
                End If
            Next

            If Not files.Contains("character") Then
                My.Computer.FileSystem.WriteAllBytes(appdatapath & "/resources/character.png", ConvertToByteArray(My.Resources.fish), False)
            End If

        Catch ex As Exception
        End Try
        lbl_countdown_paused.Text = start_countdown
        tmr_start.Start()
    End Sub

    Private Sub game_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        main.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        main.Close()
        summery.Close()
    End Sub

    Private Sub tmr_main_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_main.Tick
        Dim loc As Point = New Point(random.Next(100, Me.Size.Width - 100), random.Next(pnlTopBorder.Size.Height + 100, Me.Size.Height - 100))
        c_pb.Location = loc
    End Sub

    Private Sub tmr_countdown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_countdown.Tick
        time -= 1
        lbl_time.Text = "Time: " & time
        If time = 0 Then
            tmr_main.Stop()
            tmr_countdown.Stop()
            Me.Enabled = False
            summery.Show()
        End If
    End Sub

    Private Sub tmr_start_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_start.Tick
        start_countdown -= 1
        lbl_countdown_paused.Text = start_countdown
        If start_countdown = 0 Then
            With lbl_countdown_paused
                .Font = New Font("Arial", 1, FontStyle.Regular)
                .Location = New Point(0, 0)
                .Text = ""
                .SendToBack()
            End With
            tmr_main.Start()
            tmr_countdown.Start()
            tmr_start.Stop()
            started = True
            after_countdown = True
            c_pb.Visible = True
            c_pb.Enabled = True
        End If
    End Sub

    Private Sub c_pb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c_pb.Click
        score += 1
        lbl_score.Text = "Score: " & score
        tmr_main.Interval -= 20
        Dim loc As Point = New Point(random.Next(100, Me.Size.Width - 100), random.Next(pnlTopBorder.Size.Height + 100, Me.Size.Height - 100))
        c_pb.Location = loc

        If Not sound = "" Then
            My.Computer.Audio.Play(sound, AudioPlayMode.Background)
        Else
            My.Computer.Audio.Play(My.Resources.bloop, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            If Screen.PrimaryScreen.WorkingArea.Width = 1920 Then
                Button1.Location = New Point(Button1.Location.X - 315, Button1.Location.Y)
                Button2.Location = New Point(Button2.Location.X - 315, Button1.Location.Y)
                Button3.Location = New Point(Button3.Location.X - 315, Button1.Location.Y)
            End If
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            If Screen.PrimaryScreen.WorkingArea.Width = 1920 Then
                Button1.Location = New Point(Button1.Location.X + 315, Button1.Location.Y)
                Button2.Location = New Point(Button2.Location.X + 315, Button1.Location.Y)
                Button3.Location = New Point(Button3.Location.X + 315, Button1.Location.Y)
            End If

            
        End If
        pnlTopBorder.Size = New Size(New Point(Me.Size.Width, pnlTopBorder.Size.Height))

    End Sub

    Private Sub game_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        If started = True Then
            misses += 1
            lbl_misses.Text = "Misses: " & misses
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If after_countdown = False Then
            If a_paused = False Then
                tmr_start.Stop()
                p_text = lbl_countdown_paused.Text
                a_paused = True
                With lbl_countdown_paused
                    .Font = New Font("Microsoft Sans Serif", 60, FontStyle.Bold, GraphicsUnit.Pixel)
                    .Location = New Point(755, 499)
                    .Text = "Game Paused"
                    .BringToFront()
                End With
            Else
                tmr_start.Start()
                a_paused = False
                lbl_countdown_paused.Text = p_text
            End If
        Else
            If paused = False Then
                With lbl_countdown_paused
                    .Font = New Font("Microsoft Sans Serif", 60, FontStyle.Bold, GraphicsUnit.Pixel)
                    .Location = New Point(755, 499)
                    .Text = "Game Paused"
                    .BringToFront()
                End With
                tmr_main.Stop()
                tmr_countdown.Stop()
                c_pb.Visible = False
                c_pb.Enabled = False
                paused = True
                started = False
            ElseIf paused = True Then
                With lbl_countdown_paused
                    .Font = New Font("Microsoft Sans Serif", 1, FontStyle.Regular)
                    .Location = New Point(0, 0)
                    .Text = ""
                    .SendToBack()
                End With
                started = True
                tmr_main.Start()
                tmr_countdown.Start()
                c_pb.Visible = True
                c_pb.Enabled = True
                paused = False
            End If
        End If
    End Sub


    Public Shared Function ConvertToByteArray(ByVal value As Bitmap) As Byte()
        Dim bitmapBytes As Byte()

        Using stream As New System.IO.MemoryStream
            value.Save(stream, value.RawFormat)
            bitmapBytes = stream.ToArray
        End Using
        Return bitmapBytes
    End Function
End Class