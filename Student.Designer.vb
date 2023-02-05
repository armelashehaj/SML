<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SemCB = New System.Windows.Forms.ComboBox()
        Me.EmerSt = New System.Windows.Forms.TextBox()
        Me.DepSt = New System.Windows.Forms.TextBox()
        Me.NrTelSt = New System.Windows.Forms.TextBox()
        Me.Ruaj = New System.Windows.Forms.Button()
        Me.Ndrysho = New System.Windows.Forms.Button()
        Me.Fshi = New System.Windows.Forms.Button()
        Me.Rivendos = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.kthehu = New System.Windows.Forms.Button()
        Me.StudentGV = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.StudentGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(3, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1029, 66)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(70, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 37)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Student"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(982, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(62, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 34)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Emer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(229, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 34)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Departament"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(472, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 34)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Semester"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(682, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 34)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Nr. Telefoni"
        '
        'SemCB
        '
        Me.SemCB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SemCB.FormattingEnabled = True
        Me.SemCB.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.SemCB.Location = New System.Drawing.Point(474, 127)
        Me.SemCB.Name = "SemCB"
        Me.SemCB.Size = New System.Drawing.Size(182, 38)
        Me.SemCB.TabIndex = 16
        '
        'EmerSt
        '
        Me.EmerSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmerSt.ForeColor = System.Drawing.Color.Black
        Me.EmerSt.Location = New System.Drawing.Point(62, 127)
        Me.EmerSt.Name = "EmerSt"
        Me.EmerSt.Size = New System.Drawing.Size(137, 31)
        Me.EmerSt.TabIndex = 17
        '
        'DepSt
        '
        Me.DepSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DepSt.ForeColor = System.Drawing.Color.Black
        Me.DepSt.Location = New System.Drawing.Point(238, 127)
        Me.DepSt.Name = "DepSt"
        Me.DepSt.Size = New System.Drawing.Size(208, 31)
        Me.DepSt.TabIndex = 18
        '
        'NrTelSt
        '
        Me.NrTelSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NrTelSt.ForeColor = System.Drawing.Color.Black
        Me.NrTelSt.Location = New System.Drawing.Point(682, 127)
        Me.NrTelSt.Name = "NrTelSt"
        Me.NrTelSt.Size = New System.Drawing.Size(180, 31)
        Me.NrTelSt.TabIndex = 19
        '
        'Ruaj
        '
        Me.Ruaj.BackColor = System.Drawing.SystemColors.Highlight
        Me.Ruaj.FlatAppearance.BorderSize = 0
        Me.Ruaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ruaj.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Ruaj.ForeColor = System.Drawing.Color.White
        Me.Ruaj.Location = New System.Drawing.Point(136, 188)
        Me.Ruaj.Name = "Ruaj"
        Me.Ruaj.Size = New System.Drawing.Size(149, 46)
        Me.Ruaj.TabIndex = 20
        Me.Ruaj.Text = "Ruaj"
        Me.Ruaj.UseVisualStyleBackColor = False
        '
        'Ndrysho
        '
        Me.Ndrysho.BackColor = System.Drawing.SystemColors.Highlight
        Me.Ndrysho.FlatAppearance.BorderSize = 0
        Me.Ndrysho.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ndrysho.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Ndrysho.ForeColor = System.Drawing.Color.White
        Me.Ndrysho.Location = New System.Drawing.Point(308, 188)
        Me.Ndrysho.Name = "Ndrysho"
        Me.Ndrysho.Size = New System.Drawing.Size(160, 46)
        Me.Ndrysho.TabIndex = 21
        Me.Ndrysho.Text = "Ndrysho"
        Me.Ndrysho.UseVisualStyleBackColor = False
        '
        'Fshi
        '
        Me.Fshi.BackColor = System.Drawing.SystemColors.Highlight
        Me.Fshi.FlatAppearance.BorderSize = 0
        Me.Fshi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fshi.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Fshi.ForeColor = System.Drawing.Color.White
        Me.Fshi.Location = New System.Drawing.Point(487, 188)
        Me.Fshi.Name = "Fshi"
        Me.Fshi.Size = New System.Drawing.Size(140, 46)
        Me.Fshi.TabIndex = 22
        Me.Fshi.Text = "Fshi"
        Me.Fshi.UseVisualStyleBackColor = False
        '
        'Rivendos
        '
        Me.Rivendos.BackColor = System.Drawing.SystemColors.Highlight
        Me.Rivendos.FlatAppearance.BorderSize = 0
        Me.Rivendos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rivendos.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Rivendos.ForeColor = System.Drawing.Color.White
        Me.Rivendos.Location = New System.Drawing.Point(645, 188)
        Me.Rivendos.Name = "Rivendos"
        Me.Rivendos.Size = New System.Drawing.Size(158, 46)
        Me.Rivendos.TabIndex = 23
        Me.Rivendos.Text = "Rivendos"
        Me.Rivendos.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Rivendos)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Fshi)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Ndrysho)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Ruaj)
        Me.Panel2.Controls.Add(Me.SemCB)
        Me.Panel2.Controls.Add(Me.NrTelSt)
        Me.Panel2.Controls.Add(Me.EmerSt)
        Me.Panel2.Controls.Add(Me.DepSt)
        Me.Panel2.Location = New System.Drawing.Point(28, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(966, 264)
        Me.Panel2.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(308, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(302, 39)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Detaje te studentit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(353, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(297, 39)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Lista e studenteve"
        '
        'kthehu
        '
        Me.kthehu.BackColor = System.Drawing.SystemColors.Highlight
        Me.kthehu.FlatAppearance.BorderSize = 0
        Me.kthehu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.kthehu.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.kthehu.ForeColor = System.Drawing.Color.White
        Me.kthehu.Location = New System.Drawing.Point(435, 638)
        Me.kthehu.Name = "kthehu"
        Me.kthehu.Size = New System.Drawing.Size(140, 46)
        Me.kthehu.TabIndex = 27
        Me.kthehu.Text = "Ktheu"
        Me.kthehu.UseVisualStyleBackColor = False
        '
        'StudentGV
        '
        Me.StudentGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentGV.Location = New System.Drawing.Point(40, 407)
        Me.StudentGV.Name = "StudentGV"
        Me.StudentGV.RowHeadersWidth = 62
        Me.StudentGV.RowTemplate.Height = 33
        Me.StudentGV.Size = New System.Drawing.Size(875, 225)
        Me.StudentGV.TabIndex = 30
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1035, 705)
        Me.Controls.Add(Me.StudentGV)
        Me.Controls.Add(Me.kthehu)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.StudentGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SemCB As ComboBox
    Friend WithEvents EmerSt As TextBox
    Friend WithEvents DepSt As TextBox
    Friend WithEvents NrTelSt As TextBox
    Friend WithEvents Ruaj As Button
    Friend WithEvents Ndrysho As Button
    Friend WithEvents Fshi As Button
    Friend WithEvents Rivendos As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents kthehu As Button
    Friend WithEvents StudentGV As DataGridView
End Class
