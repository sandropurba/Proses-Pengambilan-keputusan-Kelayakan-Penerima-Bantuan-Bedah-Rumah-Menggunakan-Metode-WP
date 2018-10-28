Imports System.Data.OleDb
Public Class Login
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using Login As New OleDbCommand("Select * From tbl_user Where Username='" & txtusername.Text & "'", Koneksikan.open)
            Using Data As OleDbDataReader = Login.ExecuteReader
                If Data.HasRows Then
                    While Data.Read
                        If Data("Password") = txtpassword.Text Then
                            MenuUtama.Show()
                            Me.Hide()
                        Else
                            MsgBox("Password Salah!", MsgBoxStyle.Critical, "Peringatan!")
                        End If
                    End While
                Else
                    MsgBox("Username Salah!", MsgBoxStyle.Critical, "Peringatan!")
                End If
            End Using
        End Using
    End Sub

    Private Sub txtpassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click, Label5.Click

    End Sub
End Class


