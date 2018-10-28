Imports System.Data.OleDb
Public Class Penerima
    Sub tampil()
        Using Tampil As New OleDbCommand("Select * From tbl_Penerima", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                LvPenerima.Items.Clear()
                Dim c As Integer = 0
                While Data.Read
                    LvPenerima.Items.Add(Data("Kode_Penerima"))
                    LvPenerima.Items(c).SubItems.Add(Data("Nama_Penerima"))
                    LvPenerima.Items(c).SubItems.Add(Data("Nik"))
                    LvPenerima.Items(c).SubItems.Add(Data("Alamat"))
                    c = c + 1
                End While
            End Using
        End Using
    End Sub
    Sub bersih()
        txtalamat.Clear()
        txtkodepenerima.Clear()
        txtnik.Clear()
        txtnamapenerima.Clear()
        txtkodepenerima.Focus()
    End Sub
    Sub kunci()
        txtalamat.Enabled = False
        txtkodepenerima.Enabled = False
        txtnik.Enabled = False
        txtnamapenerima.Enabled = False
    End Sub
    Sub buka()
        txtalamat.Enabled = True
        txtkodepenerima.Enabled = True
        txtnik.Enabled = True
        txtnamapenerima.Enabled = True
    End Sub
    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Call buka()
    End Sub

    Private Sub Penerima_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampil()
        Call kunci()
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    Private Sub btnubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnubah.Click
        If txtkodepenerima.Text <> "" Then
            Using Ubah As New OleDbCommand("Update Tbl_Penerima Set Nama_Penerima='" & txtnamapenerima.Text & _
                                           "',Nik='" & txtnik.Text & _
                                           "',Alamat='" & txtalamat.Text & _
                                           "' Where Kode_Penerima='" & txtkodepenerima.Text & "'", Koneksikan.open)
                Ubah.CommandType = CommandType.Text
                Ubah.ExecuteNonQuery()
                MsgBox("Berhasil Mengubah Data", MsgBoxStyle.Information, "Pemberitahuan")
                Call tampil()
                Call bersih()
                Call kunci()
            End Using
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If txtkodepenerima.Text <> "" Then
            Using Hapus As New OleDbCommand("Delete From Tbl_Penerima Where Kode_Penerima='" & txtkodepenerima.Text & "'", Koneksikan.open)
                Hapus.CommandType = CommandType.Text
                Hapus.ExecuteNonQuery()
                MsgBox("Berhasil Menghapus Data", MsgBoxStyle.Information, "Pemberitahuan")
                Call tampil()
                Call bersih()
            End Using
        End If
    End Sub

    Private Sub LvPenerima_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LvPenerima.Click
        Try
            txtkodepenerima.Text = LvPenerima.SelectedItems(0).SubItems(0).Text
            txtnamapenerima.Text = LvPenerima.SelectedItems(0).SubItems(1).Text
            txtnik.Text = LvPenerima.SelectedItems(0).SubItems(2).Text
            txtalamat.Text = LvPenerima.SelectedItems(0).SubItems(3).Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        Call bersih()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        Try
            Using Simpan As New OleDbCommand("Insert Into tbl_penerima Values('" & txtkodepenerima.Text & _
                                             "','" & txtnamapenerima.Text & _
                                             "','" & txtnik.Text & _
                                             "','" & txtalamat.Text & "')", Koneksikan.open)
                Simpan.CommandType = CommandType.Text
                Simpan.ExecuteNonQuery()
                MsgBox("Berhasil Menyimpan Data", MsgBoxStyle.Information, "Pemberitahuan")
                Call tampil()
                Call bersih()
            End Using
        Catch ex As Exception
            MsgBox("Gagal Menyimpan", MsgBoxStyle.Critical, "Peringatan")
        End Try
    End Sub
End Class