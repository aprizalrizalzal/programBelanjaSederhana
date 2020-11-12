<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.BtnUlang = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TBHargaSatuan = New System.Windows.Forms.TextBox()
        Me.TBJumlahBarang = New System.Windows.Forms.TextBox()
        Me.TBDiskon = New System.Windows.Forms.TextBox()
        Me.TBTotalHarga = New System.Windows.Forms.TextBox()
        Me.TBTotalBayar = New System.Windows.Forms.TextBox()
        Me.TBBonus = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Harga Satuan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Diskon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Bayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Bonus"
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(122, 136)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(75, 23)
        Me.BtnHitung.TabIndex = 7
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'BtnUlang
        '
        Me.BtnUlang.Location = New System.Drawing.Point(223, 136)
        Me.BtnUlang.Name = "BtnUlang"
        Me.BtnUlang.Size = New System.Drawing.Size(75, 23)
        Me.BtnUlang.TabIndex = 8
        Me.BtnUlang.Text = "Ulang"
        Me.BtnUlang.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(122, 358)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.BtnKeluar.TabIndex = 9
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(122, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 20)
        Me.TextBox1.TabIndex = 10
        '
        'TBHargaSatuan
        '
        Me.TBHargaSatuan.Location = New System.Drawing.Point(122, 48)
        Me.TBHargaSatuan.Name = "TBHargaSatuan"
        Me.TBHargaSatuan.Size = New System.Drawing.Size(100, 20)
        Me.TBHargaSatuan.TabIndex = 11
        '
        'TBJumlahBarang
        '
        Me.TBJumlahBarang.Location = New System.Drawing.Point(122, 86)
        Me.TBJumlahBarang.Name = "TBJumlahBarang"
        Me.TBJumlahBarang.Size = New System.Drawing.Size(100, 20)
        Me.TBJumlahBarang.TabIndex = 12
        '
        'TBDiskon
        '
        Me.TBDiskon.Location = New System.Drawing.Point(122, 241)
        Me.TBDiskon.Name = "TBDiskon"
        Me.TBDiskon.Size = New System.Drawing.Size(100, 20)
        Me.TBDiskon.TabIndex = 13
        '
        'TBTotalHarga
        '
        Me.TBTotalHarga.Location = New System.Drawing.Point(122, 203)
        Me.TBTotalHarga.Name = "TBTotalHarga"
        Me.TBTotalHarga.Size = New System.Drawing.Size(100, 20)
        Me.TBTotalHarga.TabIndex = 14
        '
        'TBTotalBayar
        '
        Me.TBTotalBayar.Location = New System.Drawing.Point(122, 277)
        Me.TBTotalBayar.Name = "TBTotalBayar"
        Me.TBTotalBayar.Size = New System.Drawing.Size(100, 20)
        Me.TBTotalBayar.TabIndex = 15
        '
        'TBBonus
        '
        Me.TBBonus.Location = New System.Drawing.Point(122, 315)
        Me.TBBonus.Name = "TBBonus"
        Me.TBBonus.Size = New System.Drawing.Size(176, 20)
        Me.TBBonus.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 450)
        Me.Controls.Add(Me.TBBonus)
        Me.Controls.Add(Me.TBTotalBayar)
        Me.Controls.Add(Me.TBTotalHarga)
        Me.Controls.Add(Me.TBDiskon)
        Me.Controls.Add(Me.TBJumlahBarang)
        Me.Controls.Add(Me.TBHargaSatuan)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnUlang)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Program Belanja Sederhana"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnHitung As Button
    Friend WithEvents BtnUlang As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TBHargaSatuan As TextBox
    Friend WithEvents TBJumlahBarang As TextBox
    Friend WithEvents TBDiskon As TextBox
    Friend WithEvents TBTotalHarga As TextBox
    Friend WithEvents TBTotalBayar As TextBox
    Friend WithEvents TBBonus As TextBox
End Class
