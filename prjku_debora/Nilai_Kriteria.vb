Imports System.Data.OleDb
Public Class Nilai_Kriteria
    Sub tampil()
        Using Tampil As New OleDbCommand("Select * From tbl_kriteria", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                Lvnilaikriteria.Items.Clear()
                Dim c As Integer = 0
                While Data.Read
                    Lvnilaikriteria.Items.Add(Data("Kode_Penerima"))
                    Lvnilaikriteria.Items(c).SubItems.Add(Data("Nama_Penerima"))
                    Lvnilaikriteria.Items(c).SubItems.Add(Data("penghasilan"))
                    Lvnilaikriteria.Items(c).SubItems.Add(Data("Tanggungan"))
                    Lvnilaikriteria.Items(c).SubItems.Add(Data("Status"))
                    Lvnilaikriteria.Items(c).SubItems.Add(Data("Kondisi"))
                    Lvnilaikriteria.Items(c).SubItems.Add(Data("Pekerjaan"))
                    c = c + 1
                End While
            End Using
        End Using
    End Sub
    Sub bersih()
        txtkodepenerima.Clear()
        txtnama.Clear()
        c1.Text = "--Pilih--"
        c2.Text = "--Pilih--"
        c3.Text = "--Pilih--"
        c4.Text = "--Pilih--"
        c5.Text = "--Pilih--"
    End Sub

    Sub kunci()
        txtkodepenerima.Enabled = False
        txtnama.Enabled = False
        c1.Enabled = False
        c2.Enabled = False
        c3.Enabled = False
        c4.Enabled = False
        c5.Enabled = False
        btnsimpan.Enabled = False
    End Sub

    Sub buka()
        txtkodepenerima.Enabled = True
        txtnama.Enabled = True
        c1.Enabled = True
        c2.Enabled = True
        c3.Enabled = True
        c4.Enabled = True
        c5.Enabled = True
        btnsimpan.Enabled = True

    End Sub
    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Call buka()
    End Sub

    Private Sub Nilai_Kriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampil()
        Call kunci()
        Call bersih()
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Dim v1, v2, v3, v4, v5 As String

        'PENGHASILAN
        If c1.Text = "<=1.000.000" Then
            v1 = 5
        ElseIf c1.Text = "1.000.000 – 1.200.000" Then
            v1 = 4
        ElseIf c1.Text = "1.200.000 – 1.800.000" Then
            v1 = 3
        ElseIf c1.Text = "1.800.000 – 2.400.000" Then
            v1 = 2
        Else
            v1 = 1
        End If

        'TANGGUNGAN
        If c2.Text = "> 6" Then
            v2 = 5
        ElseIf c2.Text = "4-5" Then
            v2 = 4
        ElseIf c2.Text = "3" Then
            v2 = 3
        ElseIf c2.Text = "2" Then
            v2 = 2
        Else
            v2 = 1
        End If

        'Status Kepemilikan Tanah
        If c3.Text = "Milik Pribadi (MPI)" Then
            v3 = 5
        ElseIf c3.Text = "Milik Pemerintah (MPH)" Then
            v3 = 4
        ElseIf c3.Text = "Milik Orang Lain (MOL)" Then
            v3 = 3
        ElseIf c3.Text = "Milik Dalam Sengketa (MDS)" Then
            v3 = 2
        Else
            v3 = 1
        End If

        'Kondisi Rumah
        If c4.Text = "Rumah Bambu" Then
            v4 = 4
        ElseIf c4.Text = "Rumah Kayu" Then
            v4 = 3
        Else
            v4 = 2
        End If

        'Pekerjaan
        If c5.Text = "Buruh Tani, Petani" Then
            v5 = 4
        ElseIf c5.Text = "Pedagang, Wiraswasta" Then
            v5 = 3
        Else
            v5 = 2
        End If

        'SIMPAN ke Database
        Try
            Using Simpan As New OleDbCommand("Insert Into tbl_kriteria Values('" & txtkodepenerima.Text & _
                                             "','" & txtnama.Text & _
                                             "','" & v1 & _
                                             "','" & v2 & _
                                             "','" & v3 & _
                                             "','" & v4 & _
                                             "','" & v5 & "')", Koneksikan.open)
                Simpan.CommandType = CommandType.Text
                Simpan.ExecuteNonQuery()
                MsgBox("Berhasil Menyimpan Data", MsgBoxStyle.Information, "Pemberitahuan")
                Call tampil()
                Call kunci()
                Call bersih()
            End Using
        Catch ex As Exception
            MsgBox("Gagal Menyimpan", MsgBoxStyle.Critical, "Peringatan")
        End Try
    End Sub

    Private Sub btnubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnubah.Click
        If txtkodepenerima.Text <> "" Then
            Using Ubah As New OleDbCommand("Update tbl_kriteria Set Nama_Penerima = '" & txtnama.Text & _
                                           "', Penghasilan='" & c1.Text & _
                                           "',Tanggungan='" & c2.Text & _
                                           "',Status='" & c3.Text & _
                                           "',Kondisi='" & c4.Text & _
                                           "',Pekerjaan='" & c5.Text & _
                                           "' Where Kode_Penerima='" & txtkodepenerima.Text & "'", Koneksikan.open)
                Ubah.CommandType = CommandType.Text
                Ubah.ExecuteNonQuery()
                MsgBox("Berhasil Mengubah Data", MsgBoxStyle.Information, "Pemberitahuan")
                Call tampil()
                Call bersih()
            End Using
        End If
    End Sub

    Private Sub Lvnilaikriteria_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lvnilaikriteria.Click
        Try
            txtkodepenerima.Text = Lvnilaikriteria.SelectedItems(0).SubItems(0).Text
            txtnama.Text = Lvnilaikriteria.SelectedItems(0).SubItems(1).Text

            'Jika Diklik Lisview pada cb penghasilan
            If Lvnilaikriteria.SelectedItems(0).SubItems(2).Text = 5 Then
                c1.Text = "<=1.000.000"
            ElseIf Lvnilaikriteria.SelectedItems(0).SubItems(2).Text = 4 Then
                c1.Text = "1.000.000 – 1.200.000"
            ElseIf Lvnilaikriteria.SelectedItems(0).SubItems(2).Text = 3 Then
                c1.Text = "1.200.000 – 1.800.000"
            ElseIf Lvnilaikriteria.SelectedItems(0).SubItems(2).Text = 2 Then
                c1.Text = "1.800.000 – 2.400.000"
            Else
                c1.Text = ">=2.400.000"
            End If

            'Jika Diklik Lisview pada cb Tanggungan
            If Lvnilaikriteria.SelectedItems(0).SubItems(3).Text = 5 Then
                c2.Text = "> 6"
            ElseIf Lvnilaikriteria.SelectedItems(0).SubItems(3).Text = 4 Then
                c2.Text = "4-5"
            ElseIf Lvnilaikriteria.SelectedItems(0).SubItems(3).Text = 3 Then
                c2.Text = "3"
            ElseIf Lvnilaikriteria.SelectedItems(0).SubItems(3).Text = 4 Then
                c2.Text = "2"
            Else
                c2.Text = "1"
            End If

            'Jika Diklik Lisview pada cb Status Kepemilikan Tanah
            If Lvnilaikriteria.SelectedItems(0).SubItems(4).Text = 5 Then
                c3.Text = "Milik Pribadi (MPI)"
            ElseIf Lvnilaikriteria.SelectedItems(0).SubItems(4).Text = 4 Then
                c3.Text = "Milik Pemerintah (MPH)"
            ElseIf Lvnilaikriteria.SelectedItems(0).SubItems(4).Text = 3 Then
                c3.Text = "Milik Orang Lain (MOL)"
            ElseIf Lvnilaikriteria.SelectedItems(0).SubItems(4).Text = 2 Then
                c3.Text = "Milik Dalam Sengketa (MDS)"
            Else
                c3.Text = "Milik Umum"
            End If


            'Jika Diklik Lisview pada cb Kondisi Rumah
            If Lvnilaikriteria.SelectedItems(0).SubItems(5).Text = 4 Then
                c4.Text = "Rumah Bambu"
            ElseIf Lvnilaikriteria.SelectedItems(0).SubItems(5).Text = 3 Then
                c4.Text = "Rumah Kayu"
            Else
                c4.Text = "Rumah Semen"
            End If


            'Jika Diklik Lisview pada cb Pekerjaan
            If Lvnilaikriteria.SelectedItems(0).SubItems(6).Text = 4 Then
                c5.Text = "Buruh Tani, Petani"
            ElseIf Lvnilaikriteria.SelectedItems(0).SubItems(6).Text = 3 Then
                c5.Text = "Pedagang, Wiraswasta"
            Else
                c5.Text = "Pegawai Negeri, Pegawai Swasta"
            End If


        Catch ex As Exception
        End Try
    End Sub

    Private Sub Lvnilaikriteria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lvnilaikriteria.SelectedIndexChanged

    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If txtkodepenerima.Text <> "" Then
            Using Hapus As New OleDbCommand("Delete From tbl_kriteria Where Kode_Penerima='" & txtkodepenerima.Text & "'", Koneksikan.open)
                Hapus.CommandType = CommandType.Text
                Hapus.ExecuteNonQuery()
                MsgBox("Berhasil Menghapus Data", MsgBoxStyle.Information, "Pemberitahuan")
                Call tampil()
                Call bersih()
            End Using
        End If
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        Call bersih()
    End Sub
End Class