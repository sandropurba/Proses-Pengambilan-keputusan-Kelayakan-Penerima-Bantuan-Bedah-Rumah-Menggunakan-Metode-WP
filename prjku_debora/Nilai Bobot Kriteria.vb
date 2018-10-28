Imports System.Data.OleDb
Public Class Nilai_Bobot_Kriteria
    Sub tampil()
        Using Tampil As New OleDbCommand("Select * From tbl_preferensi", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                Dim c As Integer = 0
                While Data.Read
                    txtbobotpenghasilan.Text = Data.Item("Bobot_Penghasilan")
                    txtbobottanggungan.Text = Data.Item("Bobot_Tanggungan")
                    txtbobotstatuskepemilikantanah.Text = Data.Item("Bobot_status")
                    txtkondisirumah.Text = Data.Item("Bobot_Kondisi")
                    txtbobotpekerjaan.Text = Data.Item("Bobot_Pekerjaan")
                    c = c + 1
                End While
            End Using
        End Using
    End Sub
    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Dispose()
    End Sub

    Private Sub Nilai_Bobot_Kriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampil()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Try
            Using Simpan As New OleDbCommand("Insert Into tbl_preferensi Values('" & txtbobotpenghasilan.Text & _
                                             "','" & txtbobottanggungan.Text & _
                                             "','" & txtbobotstatuskepemilikantanah.Text & _
                                             "','" & txtkondisirumah.Text & _
                                             "','" & txtbobotpekerjaan.Text & "')", Koneksikan.open)
                Simpan.CommandType = CommandType.Text
                Simpan.ExecuteNonQuery()
                MsgBox("Berhasil Menyimpan Data", MsgBoxStyle.Information, "Pemberitahuan")
                Call tampil()
            End Using
        Catch ex As Exception
            MsgBox("Gagal Menyimpan", MsgBoxStyle.Critical, "Peringatan")
        End Try
    End Sub
End Class