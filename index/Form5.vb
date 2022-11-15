Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            reload("SELECT * FROM pos", DataGridView1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            reload("SELECT * FROM pos", DataGridView1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class