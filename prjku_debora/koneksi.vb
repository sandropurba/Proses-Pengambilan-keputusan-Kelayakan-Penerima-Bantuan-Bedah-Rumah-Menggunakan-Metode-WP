Imports System.Data.OleDb
Module koneksi
   Public Koneksikan As New Koneksi.KoneksiDatabase
    Public Class KoneksiDatabase
        Public Function open() As OleDb.OleDbConnection
            Dim conect As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " & Application.StartupPath & "\db_bedahrumah.mdb")
            conect.Open()
            Return conect
        End Function
    End Class
End Module
