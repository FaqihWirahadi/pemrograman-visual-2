<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeAdmin
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendaftaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemeriksaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengambilanObatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelesaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DokterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lHello = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lTanggal = New System.Windows.Forms.Label()
        Me.lWaktu = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(970, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PendaftaranToolStripMenuItem, Me.PemeriksaanToolStripMenuItem, Me.PengambilanObatToolStripMenuItem, Me.SelesaiToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PendaftaranToolStripMenuItem
        '
        Me.PendaftaranToolStripMenuItem.Name = "PendaftaranToolStripMenuItem"
        Me.PendaftaranToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.PendaftaranToolStripMenuItem.Text = "Pendaftaran"
        '
        'PemeriksaanToolStripMenuItem
        '
        Me.PemeriksaanToolStripMenuItem.Name = "PemeriksaanToolStripMenuItem"
        Me.PemeriksaanToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.PemeriksaanToolStripMenuItem.Text = "Pemeriksaan"
        '
        'PengambilanObatToolStripMenuItem
        '
        Me.PengambilanObatToolStripMenuItem.Name = "PengambilanObatToolStripMenuItem"
        Me.PengambilanObatToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.PengambilanObatToolStripMenuItem.Text = "Pengambilan Obat"
        '
        'SelesaiToolStripMenuItem
        '
        Me.SelesaiToolStripMenuItem.Name = "SelesaiToolStripMenuItem"
        Me.SelesaiToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.SelesaiToolStripMenuItem.Text = "Selesai"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.DokterToolStripMenuItem, Me.PasienToolStripMenuItem, Me.ObatToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'DokterToolStripMenuItem
        '
        Me.DokterToolStripMenuItem.Name = "DokterToolStripMenuItem"
        Me.DokterToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.DokterToolStripMenuItem.Text = "Dokter"
        '
        'PasienToolStripMenuItem
        '
        Me.PasienToolStripMenuItem.Name = "PasienToolStripMenuItem"
        Me.PasienToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.PasienToolStripMenuItem.Text = "Pasien"
        '
        'ObatToolStripMenuItem
        '
        Me.ObatToolStripMenuItem.Name = "ObatToolStripMenuItem"
        Me.ObatToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.ObatToolStripMenuItem.Text = "Obat"
        '
        'lHello
        '
        Me.lHello.AutoSize = True
        Me.lHello.Font = New System.Drawing.Font("Bookman Old Style", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lHello.ForeColor = System.Drawing.Color.Yellow
        Me.lHello.Location = New System.Drawing.Point(191, 105)
        Me.lHello.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lHello.Name = "lHello"
        Me.lHello.Size = New System.Drawing.Size(440, 78)
        Me.lHello.TabIndex = 1
        Me.lHello.Text = "Hello, User!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(24, 203)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(932, 41)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "dibuat oleh muhammad faqih wirahadi wijaya kusuma"
        '
        'Timer1
        '
        '
        'lTanggal
        '
        Me.lTanggal.AutoSize = True
        Me.lTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTanggal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lTanggal.Location = New System.Drawing.Point(369, 271)
        Me.lTanggal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lTanggal.Name = "lTanggal"
        Me.lTanggal.Size = New System.Drawing.Size(0, 39)
        Me.lTanggal.TabIndex = 3
        '
        'lWaktu
        '
        Me.lWaktu.AutoSize = True
        Me.lWaktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lWaktu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lWaktu.Location = New System.Drawing.Point(197, 271)
        Me.lWaktu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lWaktu.Name = "lWaktu"
        Me.lWaktu.Size = New System.Drawing.Size(0, 39)
        Me.lWaktu.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(781, 33)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "LOGOUT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'HomeAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(970, 407)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lWaktu)
        Me.Controls.Add(Me.lTanggal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lHello)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "HomeAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomeAdmin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PendaftaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemeriksaanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengambilanObatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelesaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DokterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasienToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ObatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lHello As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lTanggal As Label
    Friend WithEvents lWaktu As Label
    Friend WithEvents Button1 As Button
End Class
