<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Practice
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
        Me.absen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tugas = New System.Windows.Forms.TextBox()
        Me.uts = New System.Windows.Forms.TextBox()
        Me.uas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.habsen = New System.Windows.Forms.TextBox()
        Me.htugas = New System.Windows.Forms.TextBox()
        Me.huts = New System.Windows.Forms.TextBox()
        Me.huas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.TextBox()
        Me.grade = New System.Windows.Forms.TextBox()
        Me.keterangan = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'absen
        '
        Me.absen.Location = New System.Drawing.Point(147, 83)
        Me.absen.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.absen.Name = "absen"
        Me.absen.Size = New System.Drawing.Size(68, 22)
        Me.absen.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Menghitung Nilai Mahasiswa"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 227)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nilai Absen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nilai Tugas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 155)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 14)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nilai UTS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 190)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 14)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nilai UAS"
        '
        'tugas
        '
        Me.tugas.Location = New System.Drawing.Point(147, 118)
        Me.tugas.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tugas.Name = "tugas"
        Me.tugas.Size = New System.Drawing.Size(68, 22)
        Me.tugas.TabIndex = 7
        '
        'uts
        '
        Me.uts.Location = New System.Drawing.Point(147, 152)
        Me.uts.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.uts.Name = "uts"
        Me.uts.Size = New System.Drawing.Size(68, 22)
        Me.uts.TabIndex = 8
        '
        'uas
        '
        Me.uas.Location = New System.Drawing.Point(147, 186)
        Me.uas.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.uas.Name = "uas"
        Me.uas.Size = New System.Drawing.Size(68, 22)
        Me.uas.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(248, 86)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "10%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(248, 121)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 14)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "20%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(248, 155)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 14)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "30%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(248, 190)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 14)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "40%"
        '
        'habsen
        '
        Me.habsen.Location = New System.Drawing.Point(313, 83)
        Me.habsen.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.habsen.Name = "habsen"
        Me.habsen.Size = New System.Drawing.Size(65, 22)
        Me.habsen.TabIndex = 14
        '
        'htugas
        '
        Me.htugas.Location = New System.Drawing.Point(313, 118)
        Me.htugas.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.htugas.Name = "htugas"
        Me.htugas.Size = New System.Drawing.Size(65, 22)
        Me.htugas.TabIndex = 15
        '
        'huts
        '
        Me.huts.Location = New System.Drawing.Point(313, 152)
        Me.huts.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.huts.Name = "huts"
        Me.huts.Size = New System.Drawing.Size(65, 22)
        Me.huts.TabIndex = 16
        '
        'huas
        '
        Me.huas.Location = New System.Drawing.Point(313, 186)
        Me.huas.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.huas.Name = "huas"
        Me.huas.Size = New System.Drawing.Size(65, 22)
        Me.huas.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(159, 240)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 14)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Total Nilai"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(159, 272)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 14)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Grade"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(159, 304)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 14)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Keterangan"
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(273, 236)
        Me.total.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(65, 22)
        Me.total.TabIndex = 21
        '
        'grade
        '
        Me.grade.Location = New System.Drawing.Point(273, 269)
        Me.grade.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grade.Name = "grade"
        Me.grade.Size = New System.Drawing.Size(43, 22)
        Me.grade.TabIndex = 22
        '
        'keterangan
        '
        Me.keterangan.Location = New System.Drawing.Point(273, 301)
        Me.keterangan.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Size = New System.Drawing.Size(95, 22)
        Me.keterangan.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(34, 264)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 25)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Ulang"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(34, 301)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 25)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Keluar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form_Practice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 348)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.keterangan)
        Me.Controls.Add(Me.grade)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.huas)
        Me.Controls.Add(Me.huts)
        Me.Controls.Add(Me.htugas)
        Me.Controls.Add(Me.habsen)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.uas)
        Me.Controls.Add(Me.uts)
        Me.Controls.Add(Me.tugas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.absen)
        Me.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form_Practice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Latihan Pert 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents absen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tugas As TextBox
    Friend WithEvents uts As TextBox
    Friend WithEvents uas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents habsen As TextBox
    Friend WithEvents htugas As TextBox
    Friend WithEvents huts As TextBox
    Friend WithEvents huas As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents total As TextBox
    Friend WithEvents grade As TextBox
    Friend WithEvents keterangan As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
