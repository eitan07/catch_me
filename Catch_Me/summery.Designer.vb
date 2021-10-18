<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class summery
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_close = New System.Windows.Forms.Button
        Me.lbl_score = New System.Windows.Forms.Label
        Me.lbl_misses = New System.Windows.Forms.Label
        Me.btn_menu = New System.Windows.Forms.Button
        Me.btn_rematch = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btn_leaderboard = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlTopBorder.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTopBorder
        '
        Me.pnlTopBorder.BackColor = System.Drawing.Color.Gray
        Me.pnlTopBorder.Controls.Add(Me.Label2)
        Me.pnlTopBorder.Controls.Add(Me.btn_close)
        Me.pnlTopBorder.Location = New System.Drawing.Point(-2, -1)
        Me.pnlTopBorder.Name = "pnlTopBorder"
        Me.pnlTopBorder.Size = New System.Drawing.Size(427, 57)
        Me.pnlTopBorder.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Summery"
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Red
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(356, 13)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(59, 33)
        Me.btn_close.TabIndex = 6
        Me.btn_close.Text = "X"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'lbl_score
        '
        Me.lbl_score.AutoSize = True
        Me.lbl_score.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_score.Location = New System.Drawing.Point(12, 96)
        Me.lbl_score.Name = "lbl_score"
        Me.lbl_score.Size = New System.Drawing.Size(107, 31)
        Me.lbl_score.TabIndex = 1
        Me.lbl_score.Text = "Score: "
        '
        'lbl_misses
        '
        Me.lbl_misses.AutoSize = True
        Me.lbl_misses.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_misses.Location = New System.Drawing.Point(12, 163)
        Me.lbl_misses.Name = "lbl_misses"
        Me.lbl_misses.Size = New System.Drawing.Size(122, 31)
        Me.lbl_misses.TabIndex = 3
        Me.lbl_misses.Text = "Misses: "
        '
        'btn_menu
        '
        Me.btn_menu.BackgroundImage = Global.Catch_Me.My.Resources.Resources.menu
        Me.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_menu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_menu.FlatAppearance.BorderSize = 0
        Me.btn_menu.Location = New System.Drawing.Point(219, 243)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(115, 97)
        Me.btn_menu.TabIndex = 6
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'btn_rematch
        '
        Me.btn_rematch.BackgroundImage = Global.Catch_Me.My.Resources.Resources.circle_arrow1
        Me.btn_rematch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_rematch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_rematch.FlatAppearance.BorderSize = 0
        Me.btn_rematch.Location = New System.Drawing.Point(60, 243)
        Me.btn_rematch.Name = "btn_rematch"
        Me.btn_rematch.Size = New System.Drawing.Size(115, 97)
        Me.btn_rematch.TabIndex = 4
        Me.btn_rematch.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(1, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 336)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Location = New System.Drawing.Point(419, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 338)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Location = New System.Drawing.Point(5, 385)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(415, 5)
        Me.Panel3.TabIndex = 8
        '
        'btn_leaderboard
        '
        Me.btn_leaderboard.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_leaderboard.FlatAppearance.BorderSize = 2
        Me.btn_leaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_leaderboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_leaderboard.Location = New System.Drawing.Point(231, 84)
        Me.btn_leaderboard.Name = "btn_leaderboard"
        Me.btn_leaderboard.Size = New System.Drawing.Size(137, 121)
        Me.btn_leaderboard.TabIndex = 9
        Me.btn_leaderboard.Text = "Save The Record"
        Me.btn_leaderboard.UseVisualStyleBackColor = True
        '
        'summery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(425, 390)
        Me.Controls.Add(Me.btn_leaderboard)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.btn_rematch)
        Me.Controls.Add(Me.lbl_misses)
        Me.Controls.Add(Me.lbl_score)
        Me.Controls.Add(Me.pnlTopBorder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "summery"
        Me.Text = "summery"
        Me.pnlTopBorder.ResumeLayout(False)
        Me.pnlTopBorder.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTopBorder As System.Windows.Forms.Panel
    Friend WithEvents lbl_score As System.Windows.Forms.Label
    Friend WithEvents lbl_misses As System.Windows.Forms.Label
    Friend WithEvents btn_rematch As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_menu As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_leaderboard As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
