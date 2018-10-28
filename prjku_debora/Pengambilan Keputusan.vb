Imports System.Data.OleDb
Public Class Pengambilan_Keputusan
    Dim PK1, PK2, PK3, PK4, PK5 As Double
    Sub DataPenilaian()
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
    Sub bobot_perbaikan()

        ListView2.Items.Clear()
        ListView2.Items.Add("K1")
        ListView2.Items.Add("K2")
        ListView2.Items.Add("K3")
        ListView2.Items.Add("K4")
        ListView2.Items.Add("K5")

        Dim K1, K2, K3, K4, K5 As Double
        Using Tampil As New OleDbCommand("Select * From tbl_preferensi", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                Dim c As Integer = 0
                While Data.Read
                    K1 = Data("Bobot_Penghasilan")
                    K2 = Data("Bobot_Tanggungan")
                    K3 = Data("Bobot_status")
                    K4 = Data("Bobot_Kondisi")
                    K5 = Data("Bobot_Pekerjaan")
                End While
            End Using
        End Using
        ListView2.Items(0).SubItems.Add(K1)
        ListView2.Items(1).SubItems.Add(K2)
        ListView2.Items(2).SubItems.Add(K3)
        ListView2.Items(3).SubItems.Add(K4)
        ListView2.Items(4).SubItems.Add(K5)

        PK1 = K1 / (K1 + K2 + K3 + K4 + K5)
        PK2 = K2 / (K1 + K2 + K3 + K4 + K5)
        PK3 = K3 / (K1 + K2 + K3 + K4 + K5)
        PK4 = K4 / (K1 + K2 + K3 + K4 + K5)
        PK5 = K5 / (K1 + K2 + K3 + K4 + K5)

        ListView2.Items(0).SubItems.Add(Microsoft.VisualBasic.Left(PK1, 6))
        ListView2.Items(1).SubItems.Add(Microsoft.VisualBasic.Left(PK2, 6))
        ListView2.Items(2).SubItems.Add(Microsoft.VisualBasic.Left(PK3, 6))
        ListView2.Items(3).SubItems.Add(Microsoft.VisualBasic.Left(PK4, 6))
        ListView2.Items(4).SubItems.Add(Microsoft.VisualBasic.Left(PK5, 6))

        For i = 1 To ListView2.Items.Count
            Dim NB As String = ""
            For j = 1 To Len(ListView2.Items(i - 1).SubItems(1).Text)
                If Microsoft.VisualBasic.Mid(ListView2.Items(i - 1).SubItems(1).Text, j, 1) = "," Then
                    NB = NB + "."
                Else
                    NB = NB + Microsoft.VisualBasic.Mid(ListView2.Items(i - 1).SubItems(1).Text, j, 1)
                End If
            Next j
            ListView2.Items(i - 1).SubItems(1).Text = NB
        Next i

        For i = 1 To ListView2.Items.Count
            Dim NB As String = ""
            For j = 1 To Len(ListView2.Items(i - 1).SubItems(1).Text)
                If Microsoft.VisualBasic.Mid(ListView2.Items(i - 1).SubItems(1).Text, j, 1) = "," Then
                    NB = NB + "."
                Else
                    NB = NB + Microsoft.VisualBasic.Mid(ListView2.Items(i - 1).SubItems(1).Text, j, 1)
                End If
            Next j
            ListView2.Items(i - 1).SubItems(1).Text = NB
        Next i
    End Sub

    Private Sub Pengambilan_Keputusan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call DataPenilaian()
        Call bobot_perbaikan()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    
        'MENCARI VEKTOR S
        Dim n = Lvnilaikriteria.Items.Count
        Dim Vektor_S(n) As Double
        Dim Total_Vektor_S As Double = 0

        For i = 1 To Lvnilaikriteria.Items.Count
            ListView3.Items.Add(Lvnilaikriteria.Items(i - 1).SubItems(0).Text)
            Vektor_S(i) = (Lvnilaikriteria.Items(i - 1).SubItems(2).Text ^ (PK1)) * (Lvnilaikriteria.Items(i - 1).SubItems(3).Text ^ (PK2)) * (Lvnilaikriteria.Items(i - 1).SubItems(4).Text ^ (PK3)) * (Lvnilaikriteria.Items(i - 1).SubItems(5).Text ^ (PK4)) * (Lvnilaikriteria.Items(i - 1).SubItems(6).Text ^ (PK5))
            Total_Vektor_S = Total_Vektor_S + Vektor_S(i)
            ListView3.Items(i - 1).SubItems.Add(Microsoft.VisualBasic.Left(Vektor_S(i), 6))
            Dim NB As String = ""
            For j = 1 To Len(ListView3.Items(i - 1).SubItems(1).Text)
                If Microsoft.VisualBasic.Mid(ListView3.Items(i - 1).SubItems(1).Text, j, 1) = "," Then
                    NB = NB + "."
                Else
                    NB = NB + Microsoft.VisualBasic.Mid(ListView3.Items(i - 1).SubItems(1).Text, j, 1)
                End If
            Next j
            ListView3.Items(i - 1).SubItems(1).Text = NB
        Next i

        'Nilai Vektor V
        Dim Vektor_V(n) As Double
        For i = 1 To Lvnilaikriteria.Items.Count
            ListView1.Items.Add(Lvnilaikriteria.Items(i - 1).SubItems(0).Text)
            ListView1.Items(i - 1).SubItems.Add(Lvnilaikriteria.Items(i - 1).SubItems(1).Text)
            Vektor_V(i) = Vektor_S(i) / Total_Vektor_S
            ListView1.Items(i - 1).SubItems.Add(Vektor_V(i))
            ListView1.Items(i - 1).SubItems.Add("-")
        Next i

        'PERANGKINGAN
        For i = 1 To Lvnilaikriteria.Items.Count
            Dim Max As Double = 0
            For j = 1 To Lvnilaikriteria.Items.Count
                If ListView1.Items(j - 1).SubItems(2).Text >= 0.06 Then
                    ListView1.Items(j - 1).SubItems(3).Text = "Layak"
                Else
                    ListView1.Items(j - 1).SubItems(3).Text = " Tidak Layak"
                End If
            Next j
        Next i

        'Pembulatan
        For i = 1 To Lvnilaikriteria.Items.Count
            Dim NB As String = ""
            For j = 1 To Len(ListView1.Items(i - 1).SubItems(2).Text)
                If Microsoft.VisualBasic.Mid(ListView1.Items(i - 1).SubItems(2).Text, j, 1) = "," Then
                    NB = NB + "."
                Else
                    NB = NB + Microsoft.VisualBasic.Mid(ListView1.Items(i - 1).SubItems(2).Text, j, 1)
                End If
            Next j
            ListView1.Items(i - 1).SubItems(2).Text = Microsoft.VisualBasic.Left(NB, 6)
        Next i

        'HAPUS DULU
        Using Hapus As New OleDbCommand("Delete From tbl_keputusan", Koneksikan.open)
            Hapus.CommandType = CommandType.Text
            Hapus.ExecuteNonQuery()
        End Using
        MsgBox("Analisa Selesai", MsgBoxStyle.Information, "Pemberitahuan")

        'BARU SIMPAN
        For i = 1 To ListView1.Items.Count
            Using Simpan As New OleDbCommand("Insert Into tbl_keputusan Values('" & ListView1.Items(i - 1).SubItems(0).Text & "','" & ListView1.Items(i - 1).SubItems(1).Text & "'," & ListView1.Items(i - 1).SubItems(2).Text & ",'" & ListView1.Items(i - 1).SubItems(3).Text & "')", Koneksikan.open)
                Simpan.CommandType = CommandType.Text
                Simpan.ExecuteNonQuery()
            End Using
        Next i
    End Sub
End Class