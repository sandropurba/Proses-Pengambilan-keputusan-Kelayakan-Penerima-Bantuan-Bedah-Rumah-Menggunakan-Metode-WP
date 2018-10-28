Public Class MenuUtama

    Private Sub LaporanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanToolStripMenuItem1.Click
        End
    End Sub

    Private Sub PenerimaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenerimaToolStripMenuItem.Click
        Dim anak As New Penerima
        anak.MdiParent = Me
        anak.Show()
    End Sub

    Private Sub NilaiPreferensiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NilaiPreferensiToolStripMenuItem.Click
        Dim anak As New Nilai_Bobot_Kriteria
        anak.MdiParent = Me
        anak.Show()
    End Sub

    Private Sub NilaiKriteriaPenerimaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NilaiKriteriaPenerimaToolStripMenuItem.Click
        Dim anak As New Nilai_Kriteria
        anak.MdiParent = Me
        anak.Show()
    End Sub

    Private Sub ProsesMetodeWPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProsesMetodeWPToolStripMenuItem.Click
        Dim anak As New Pengambilan_Keputusan
        anak.MdiParent = Me
        anak.Show()
    End Sub
End Class