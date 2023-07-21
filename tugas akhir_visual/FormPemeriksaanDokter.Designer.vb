<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPemeriksaanDokter
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
        Me.tKeluhan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tDiagnosa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.lpasien = New System.Windows.Forms.Label()
        Me.btnTambahObat = New System.Windows.Forms.Button()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tKeluhan
        '
        Me.tKeluhan.Location = New System.Drawing.Point(15, 91)
        Me.tKeluhan.Multiline = True
        Me.tKeluhan.Name = "tKeluhan"
        Me.tKeluhan.Size = New System.Drawing.Size(362, 67)
        Me.tKeluhan.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Keluhan :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nama :"
        '
        'tDiagnosa
        '
        Me.tDiagnosa.Location = New System.Drawing.Point(15, 193)
        Me.tDiagnosa.Multiline = True
        Me.tDiagnosa.Name = "tDiagnosa"
        Me.tDiagnosa.Size = New System.Drawing.Size(362, 67)
        Me.tDiagnosa.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Diagnosa :"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(453, 18)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(321, 355)
        Me.ListBox1.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Resep Obat :"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(15, 308)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(362, 121)
        Me.ListBox2.TabIndex = 24
        '
        'lpasien
        '
        Me.lpasien.AutoSize = True
        Me.lpasien.Location = New System.Drawing.Point(12, 39)
        Me.lpasien.Name = "lpasien"
        Me.lpasien.Size = New System.Drawing.Size(64, 13)
        Me.lpasien.TabIndex = 25
        Me.lpasien.Text = "namapasien"
        '
        'btnTambahObat
        '
        Me.btnTambahObat.BackColor = System.Drawing.Color.OrangeRed
        Me.btnTambahObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahObat.Location = New System.Drawing.Point(453, 387)
        Me.btnTambahObat.Name = "btnTambahObat"
        Me.btnTambahObat.Size = New System.Drawing.Size(321, 42)
        Me.btnTambahObat.TabIndex = 26
        Me.btnTambahObat.Text = "TAMBAH RESEP OBAT"
        Me.btnTambahObat.UseVisualStyleBackColor = False
        '
        'btnSelesai
        '
        Me.btnSelesai.BackColor = System.Drawing.Color.Green
        Me.btnSelesai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelesai.Location = New System.Drawing.Point(15, 471)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(759, 42)
        Me.btnSelesai.TabIndex = 27
        Me.btnSelesai.Text = "PERIKSA SELSESAI"
        Me.btnSelesai.UseVisualStyleBackColor = False
        '
        'FormPemeriksaanDokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(800, 529)
        Me.Controls.Add(Me.btnSelesai)
        Me.Controls.Add(Me.btnTambahObat)
        Me.Controls.Add(Me.lpasien)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.tDiagnosa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tKeluhan)
        Me.Controls.Add(Me.Label8)
        Me.Name = "FormPemeriksaanDokter"
        Me.Text = "FormPemeriksaanDokter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tKeluhan As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tDiagnosa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents lpasien As Label
    Friend WithEvents btnTambahObat As Button
    Friend WithEvents btnSelesai As Button
End Class
