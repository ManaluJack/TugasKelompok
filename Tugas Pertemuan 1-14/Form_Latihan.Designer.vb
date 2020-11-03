<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Latihan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.diskon = New System.Windows.Forms.TextBox()
        Me.pajak = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.bayar = New System.Windows.Forms.TextBox()
        Me.sisa = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Barang"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(77, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 14)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Diskon %"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 14)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Pajak %"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(62, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 14)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(62, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 14)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Uang Bayar"
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(180, 12)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(88, 20)
        Me.harga.TabIndex = 10
        '
        'jumlah
        '
        Me.jumlah.Location = New System.Drawing.Point(224, 199)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(50, 20)
        Me.jumlah.TabIndex = 11
        '
        'diskon
        '
        Me.diskon.Location = New System.Drawing.Point(180, 49)
        Me.diskon.Name = "diskon"
        Me.diskon.Size = New System.Drawing.Size(64, 20)
        Me.diskon.TabIndex = 12
        '
        'pajak
        '
        Me.pajak.Location = New System.Drawing.Point(180, 86)
        Me.pajak.Name = "pajak"
        Me.pajak.Size = New System.Drawing.Size(64, 20)
        Me.pajak.TabIndex = 13
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(224, 282)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 14
        '
        'bayar
        '
        Me.bayar.Location = New System.Drawing.Point(224, 319)
        Me.bayar.Name = "bayar"
        Me.bayar.Size = New System.Drawing.Size(100, 20)
        Me.bayar.TabIndex = 15
        '
        'sisa
        '
        Me.sisa.Location = New System.Drawing.Point(224, 367)
        Me.sisa.Name = "sisa"
        Me.sisa.Size = New System.Drawing.Size(142, 20)
        Me.sisa.TabIndex = 16
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Baskerville Old Face", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Shampo", "Sabun", "Rinso", "Gula", "Susu Kaleng"})
        Me.ComboBox1.Location = New System.Drawing.Point(224, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 22)
        Me.ComboBox1.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(120, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 22)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Contoh Program Kasir"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(77, 355)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 32)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Sisa Kembali"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.harga)
        Me.GroupBox1.Controls.Add(Me.diskon)
        Me.GroupBox1.Controls.Add(Me.pajak)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 115)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'Form_Latihan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 411)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.sisa)
        Me.Controls.Add(Me.bayar)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_Latihan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program Kasir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents harga As TextBox
    Friend WithEvents jumlah As TextBox
    Friend WithEvents diskon As TextBox
    Friend WithEvents pajak As TextBox
    Friend WithEvents total As TextBox
    Friend WithEvents bayar As TextBox
    Friend WithEvents sisa As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
