<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PenerimaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NilaiPreferensiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NilaiKriteriaPenerimaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProsesMetodeWPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanPenerimaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanKeputusanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.KeluarToolStripMenuItem, Me.LaporanToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(622, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenerimaToolStripMenuItem, Me.NilaiPreferensiToolStripMenuItem, Me.NilaiKriteriaPenerimaToolStripMenuItem})
        Me.DataToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(48, 22)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'PenerimaToolStripMenuItem
        '
        Me.PenerimaToolStripMenuItem.Name = "PenerimaToolStripMenuItem"
        Me.PenerimaToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.PenerimaToolStripMenuItem.Text = "Penerima"
        '
        'NilaiPreferensiToolStripMenuItem
        '
        Me.NilaiPreferensiToolStripMenuItem.Name = "NilaiPreferensiToolStripMenuItem"
        Me.NilaiPreferensiToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.NilaiPreferensiToolStripMenuItem.Text = "Nilai Preferensi"
        '
        'NilaiKriteriaPenerimaToolStripMenuItem
        '
        Me.NilaiKriteriaPenerimaToolStripMenuItem.Name = "NilaiKriteriaPenerimaToolStripMenuItem"
        Me.NilaiKriteriaPenerimaToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.NilaiKriteriaPenerimaToolStripMenuItem.Text = "Nilai Kriteria Penerima"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProsesMetodeWPToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(61, 22)
        Me.LaporanToolStripMenuItem.Text = "Proses"
        '
        'ProsesMetodeWPToolStripMenuItem
        '
        Me.ProsesMetodeWPToolStripMenuItem.Name = "ProsesMetodeWPToolStripMenuItem"
        Me.ProsesMetodeWPToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ProsesMetodeWPToolStripMenuItem.Text = "Proses Metode WP"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenerimaToolStripMenuItem, Me.LaporanKeputusanToolStripMenuItem})
        Me.KeluarToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(69, 22)
        Me.KeluarToolStripMenuItem.Text = "Laporan"
        '
        'LaporanPenerimaToolStripMenuItem
        '
        Me.LaporanPenerimaToolStripMenuItem.Name = "LaporanPenerimaToolStripMenuItem"
        Me.LaporanPenerimaToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.LaporanPenerimaToolStripMenuItem.Text = "Laporan Penerima"
        '
        'LaporanKeputusanToolStripMenuItem
        '
        Me.LaporanKeputusanToolStripMenuItem.Name = "LaporanKeputusanToolStripMenuItem"
        Me.LaporanKeputusanToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.LaporanKeputusanToolStripMenuItem.Text = "Laporan Keputusan"
        '
        'LaporanToolStripMenuItem1
        '
        Me.LaporanToolStripMenuItem1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaporanToolStripMenuItem1.Name = "LaporanToolStripMenuItem1"
        Me.LaporanToolStripMenuItem1.Size = New System.Drawing.Size(59, 22)
        Me.LaporanToolStripMenuItem1.Text = "keluar"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(622, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bedah Rumah"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenerimaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NilaiPreferensiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NilaiKriteriaPenerimaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesMetodeWPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenerimaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanKeputusanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
