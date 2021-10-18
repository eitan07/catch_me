Imports System.IO

Public Class settings

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

    Private Sub btn_sel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sel.Click
        With OpenFileDialog1
            .Title = "Select Character Image File"
            .FileName = ""
            .Multiselect = False
            .Filter = "Image Files | *.jpg; *.jpeg; *.png"
            .ShowDialog()
        End With

        lbl_file.Text = IO.Path.GetFileName(OpenFileDialog1.FileName)

        Console.WriteLine(Path.GetFileName(OpenFileDialog1.FileName))

        Dim files() As String = IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\catch_me\resources")

        For Each File As String In files
            If Path.GetFileName(File).StartsWith("character") Then
                My.Computer.FileSystem.DeleteFile(File)
            End If
        Next
        If Not OpenFileDialog1.FileName = "" Then
            My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "/catch_me/resources/character" & Path.GetExtension(OpenFileDialog1.FileName))
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        With OpenFileDialog2
            .Title = "Select Character Image File"
            .FileName = ""
            .Multiselect = False
            .Filter = "Wave File | *.wav"
            .ShowDialog()
        End With

        lbl_file2.Text = IO.Path.GetFileName(OpenFileDialog2.FileName)

        Console.WriteLine(Path.GetFileName(OpenFileDialog2.FileName) & Path.GetExtension(OpenFileDialog2.FileName))


        Dim files() As String = IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\catch_me\resources")

        For Each File As String In files
            If Path.GetFileName(File) = "click.wav" Then
                My.Computer.FileSystem.DeleteFile(File)
            End If
        Next
        If Not OpenFileDialog2.FileName = "" Then
            My.Computer.FileSystem.CopyFile(OpenFileDialog2.FileName, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "/catch_me/resources/click.wav")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            My.Computer.FileSystem.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\catch_me\starting_state.txt", "mini", False)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            My.Computer.FileSystem.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\catch_me\starting_state.txt", "max", False)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        With OpenFileDialog3
            .Title = "Select Background Image File"
            .FileName = ""
            .Multiselect = False
            .Filter = "Image Files | *.jpg; *.jpeg; *.png"
            .ShowDialog()
        End With

        lbl_file.Text = IO.Path.GetFileName(OpenFileDialog3.FileName)

        Console.WriteLine(Path.GetFileName(OpenFileDialog3.FileName))

        Dim files() As String = IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\catch_me\resources")

        For Each File As String In files
            If Path.GetFileName(File).StartsWith("background") Then
                My.Computer.FileSystem.DeleteFile(File)
            End If
        Next
        If Not OpenFileDialog3.FileName = "" Then
            My.Computer.FileSystem.CopyFile(OpenFileDialog3.FileName, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "/catch_me/resources/background" & Path.GetExtension(OpenFileDialog3.FileName))
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        reset.Show()
    End Sub
End Class