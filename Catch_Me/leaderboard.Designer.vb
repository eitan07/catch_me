<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class leaderboard
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.pnlTopBorder = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.tbl_leaders = New System.Windows.Forms.DataGridView
        Me.col_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_score = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_misses = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btn_refresh = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlTopBorder.SuspendLayout()
        CType(Me.tbl_leaders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(517, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 36)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pnlTopBorder
        '
        Me.pnlTopBorder.BackColor = System.Drawing.Color.Gray
        Me.pnlTopBorder.Controls.Add(Me.Button2)
        Me.pnlTopBorder.Controls.Add(Me.Button1)
        Me.pnlTopBorder.Controls.Add(Me.Label2)
        Me.pnlTopBorder.Controls.Add(Me.Button3)
        Me.pnlTopBorder.Location = New System.Drawing.Point(2, 1)
        Me.pnlTopBorder.Name = "pnlTopBorder"
        Me.pnlTopBorder.Size = New System.Drawing.Size(574, 60)
        Me.pnlTopBorder.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1445, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "□"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(279, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Catch Me Leaderboard"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1524, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 39)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'tbl_leaders
        '
        Me.tbl_leaders.AllowUserToAddRows = False
        Me.tbl_leaders.AllowUserToDeleteRows = False
        Me.tbl_leaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tbl_leaders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_name, Me.col_score, Me.col_misses, Me.col_date})
        Me.tbl_leaders.Location = New System.Drawing.Point(25, 117)
        Me.tbl_leaders.Name = "tbl_leaders"
        Me.tbl_leaders.ReadOnly = True
        Me.tbl_leaders.Size = New System.Drawing.Size(510, 317)
        Me.tbl_leaders.TabIndex = 3
        '
        'col_name
        '
        Me.col_name.HeaderText = "Name"
        Me.col_name.Name = "col_name"
        Me.col_name.ReadOnly = True
        '
        'col_score
        '
        Me.col_score.HeaderText = "Score"
        Me.col_score.Name = "col_score"
        Me.col_score.ReadOnly = True
        '
        'col_misses
        '
        Me.col_misses.HeaderText = "Misses"
        Me.col_misses.Name = "col_misses"
        Me.col_misses.ReadOnly = True
        '
        'col_date
        '
        Me.col_date.HeaderText = "Date"
        Me.col_date.Name = "col_date"
        Me.col_date.ReadOnly = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(444, 73)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(71, 30)
        Me.btn_refresh.TabIndex = 4
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Online", "Local"})
        Me.ComboBox1.Location = New System.Drawing.Point(127, 79)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(157, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Leadeboard: "
        '
        'leaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(574, 481)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.tbl_leaders)
        Me.Controls.Add(Me.pnlTopBorder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "leaderboard"
        Me.Text = "leaderboardvb"
        Me.pnlTopBorder.ResumeLayout(False)
        Me.pnlTopBorder.PerformLayout()
        CType(Me.tbl_leaders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pnlTopBorder As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents tbl_leaders As System.Windows.Forms.DataGridView
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents col_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_score As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_misses As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
