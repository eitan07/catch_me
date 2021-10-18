<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.pnlTopBorder = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.tmr_main = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_countdown = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_countdown_paused = New System.Windows.Forms.Label
        Me.tmr_start = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_score = New System.Windows.Forms.Label
        Me.lbl_time = New System.Windows.Forms.Label
        Me.lbl_misses = New System.Windows.Forms.Label
        Me.c_pb = New System.Windows.Forms.PictureBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.pnlTopBorder.SuspendLayout()
        CType(Me.c_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTopBorder
        '
        Me.pnlTopBorder.BackColor = System.Drawing.Color.Gray
        Me.pnlTopBorder.Controls.Add(Me.Button3)
        Me.pnlTopBorder.Controls.Add(Me.Button2)
        Me.pnlTopBorder.Controls.Add(Me.Label1)
        Me.pnlTopBorder.Controls.Add(Me.Button1)
        Me.pnlTopBorder.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBorder.Name = "pnlTopBorder"
        Me.pnlTopBorder.Size = New System.Drawing.Size(1602, 60)
        Me.pnlTopBorder.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Catch Me"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1536, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tmr_main
        '
        Me.tmr_main.Interval = 1000
        '
        'tmr_countdown
        '
        Me.tmr_countdown.Interval = 1000
        '
        'lbl_countdown_paused
        '
        Me.lbl_countdown_paused.AutoSize = True
        Me.lbl_countdown_paused.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_countdown_paused.Location = New System.Drawing.Point(915, 499)
        Me.lbl_countdown_paused.Name = "lbl_countdown_paused"
        Me.lbl_countdown_paused.Size = New System.Drawing.Size(84, 91)
        Me.lbl_countdown_paused.TabIndex = 3
        Me.lbl_countdown_paused.Text = "5"
        '
        'tmr_start
        '
        Me.tmr_start.Interval = 1000
        '
        'lbl_score
        '
        Me.lbl_score.AutoSize = True
        Me.lbl_score.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_score.Location = New System.Drawing.Point(8, 78)
        Me.lbl_score.Name = "lbl_score"
        Me.lbl_score.Size = New System.Drawing.Size(131, 31)
        Me.lbl_score.TabIndex = 4
        Me.lbl_score.Text = "Score:  0"
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(8, 185)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(135, 31)
        Me.lbl_time.TabIndex = 5
        Me.lbl_time.Text = "Time:  60"
        '
        'lbl_misses
        '
        Me.lbl_misses.AutoSize = True
        Me.lbl_misses.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_misses.Location = New System.Drawing.Point(8, 132)
        Me.lbl_misses.Name = "lbl_misses"
        Me.lbl_misses.Size = New System.Drawing.Size(138, 31)
        Me.lbl_misses.TabIndex = 6
        Me.lbl_misses.Text = "Misses: 0"
        '
        'c_pb
        '
        Me.c_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c_pb.Location = New System.Drawing.Point(873, 488)
        Me.c_pb.Name = "c_pb"
        Me.c_pb.Size = New System.Drawing.Size(162, 110)
        Me.c_pb.TabIndex = 2
        Me.c_pb.TabStop = False
        Me.c_pb.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.BackgroundImage = Global.Catch_Me.My.Resources.Resources.pause
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1402, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(52, 39)
        Me.Button3.TabIndex = 3
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.BackgroundImage = Global.Catch_Me.My.Resources.Resources.maximize
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1471, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1600, 870)
        Me.Controls.Add(Me.lbl_misses)
        Me.Controls.Add(Me.lbl_countdown_paused)
        Me.Controls.Add(Me.c_pb)
        Me.Controls.Add(Me.pnlTopBorder)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.lbl_score)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "game"
        Me.Text = "game"
        Me.pnlTopBorder.ResumeLayout(False)
        Me.pnlTopBorder.PerformLayout()
        CType(Me.c_pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTopBorder As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tmr_main As System.Windows.Forms.Timer
    Friend WithEvents c_pb As System.Windows.Forms.PictureBox
    Friend WithEvents tmr_countdown As System.Windows.Forms.Timer
    Friend WithEvents lbl_countdown_paused As System.Windows.Forms.Label
    Friend WithEvents tmr_start As System.Windows.Forms.Timer
    Friend WithEvents lbl_score As System.Windows.Forms.Label
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbl_misses As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
