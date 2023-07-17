<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.rb_telaga_biru = New System.Windows.Forms.RadioButton()
        Me.rb_waaduk_darma = New System.Windows.Forms.RadioButton()
        Me.rb_sukageuri_view = New System.Windows.Forms.RadioButton()
        Me.rb_situ_cicerem = New System.Windows.Forms.RadioButton()
        Me.cmb_d_a = New System.Windows.Forms.ComboBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rb_telaga_biru
        '
        Me.rb_telaga_biru.AutoSize = True
        Me.rb_telaga_biru.Location = New System.Drawing.Point(108, 117)
        Me.rb_telaga_biru.Name = "rb_telaga_biru"
        Me.rb_telaga_biru.Size = New System.Drawing.Size(173, 33)
        Me.rb_telaga_biru.TabIndex = 0
        Me.rb_telaga_biru.TabStop = True
        Me.rb_telaga_biru.Text = "Telaga Biru"
        Me.rb_telaga_biru.UseVisualStyleBackColor = True
        '
        'rb_waaduk_darma
        '
        Me.rb_waaduk_darma.AutoSize = True
        Me.rb_waaduk_darma.Location = New System.Drawing.Point(108, 166)
        Me.rb_waaduk_darma.Name = "rb_waaduk_darma"
        Me.rb_waaduk_darma.Size = New System.Drawing.Size(203, 33)
        Me.rb_waaduk_darma.TabIndex = 1
        Me.rb_waaduk_darma.TabStop = True
        Me.rb_waaduk_darma.Text = "Waduk Darma"
        Me.rb_waaduk_darma.UseVisualStyleBackColor = True
        '
        'rb_sukageuri_view
        '
        Me.rb_sukageuri_view.AutoSize = True
        Me.rb_sukageuri_view.Location = New System.Drawing.Point(108, 213)
        Me.rb_sukageuri_view.Name = "rb_sukageuri_view"
        Me.rb_sukageuri_view.Size = New System.Drawing.Size(217, 33)
        Me.rb_sukageuri_view.TabIndex = 2
        Me.rb_sukageuri_view.TabStop = True
        Me.rb_sukageuri_view.Text = "Sukageuri View"
        Me.rb_sukageuri_view.UseVisualStyleBackColor = True
        '
        'rb_situ_cicerem
        '
        Me.rb_situ_cicerem.AutoSize = True
        Me.rb_situ_cicerem.Location = New System.Drawing.Point(108, 260)
        Me.rb_situ_cicerem.Name = "rb_situ_cicerem"
        Me.rb_situ_cicerem.Size = New System.Drawing.Size(186, 33)
        Me.rb_situ_cicerem.TabIndex = 3
        Me.rb_situ_cicerem.TabStop = True
        Me.rb_situ_cicerem.Text = "Situ Cicerem"
        Me.rb_situ_cicerem.UseVisualStyleBackColor = True
        '
        'cmb_d_a
        '
        Me.cmb_d_a.FormattingEnabled = True
        Me.cmb_d_a.Items.AddRange(New Object() {"dewasa", "anak-anak"})
        Me.cmb_d_a.Location = New System.Drawing.Point(66, 78)
        Me.cmb_d_a.Name = "cmb_d_a"
        Me.cmb_d_a.Size = New System.Drawing.Size(233, 37)
        Me.cmb_d_a.TabIndex = 4
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(66, 379)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(233, 36)
        Me.txtHarga.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "harga tiket wisata"
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(117, 302)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(129, 38)
        Me.Submit.TabIndex = 7
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(395, 481)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.cmb_d_a)
        Me.Controls.Add(Me.rb_situ_cicerem)
        Me.Controls.Add(Me.rb_sukageuri_view)
        Me.Controls.Add(Me.rb_waaduk_darma)
        Me.Controls.Add(Me.rb_telaga_biru)
        Me.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rb_telaga_biru As RadioButton
    Friend WithEvents rb_waaduk_darma As RadioButton
    Friend WithEvents rb_sukageuri_view As RadioButton
    Friend WithEvents rb_situ_cicerem As RadioButton
    Friend WithEvents cmb_d_a As ComboBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Submit As Button
End Class
