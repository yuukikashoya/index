Imports System.Reflection.Emit
Imports System.Security.Cryptography

Public Class Form2
    Public Property username As String
    Public Property admin_id As String
    Public Property Aname As String
    Public Property password As String
    Private Sub admin_buttom_Click(sender As Object, e As EventArgs) Handles admin_buttom.Click


    End Sub

    Private Sub table_buttom_Click(sender As Object, e As EventArgs) Handles table_buttom.Click
        Dim admin As New Form1()
        admin.username = username
        admin.admin_id = admin_id
        admin.Aname = Aname
        admin.password = password

        Me.Hide()
        admin.Show()



    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user.Text = Aname
        Try
            reload("SELECT * FROM admin", datatable)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to close the app?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub button_logout_Click(sender As Object, e As EventArgs) Handles button_logout.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to Log out?", "Log out", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then

        Else
            Form4.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub button_sale_Click(sender As Object, e As EventArgs) Handles button_sale.Click
        Dim admin As New Form3()
        admin.username = username
        admin.admin_id = admin_id
        admin.Aname = Aname
        admin.password = password
        Me.Hide()
        admin.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim c As String
        Dim pass As String
        c = ""
        pass = "1"

        If RadioButton1.Checked Then
            c = "Faculty"
        ElseIf RadioButton2.Checked Then
            c = "Student"

        End If
        Try
            create("INSERT INTO admin (admin_name,admin_rank,username,password) VALUES('" & TextBox3.Text & "','" & c & "','" & TextBox4.Text & "','" & pass & "')")
            Try
                reload("SELECT * FROM admin", datatable)
                c = ""

                TextBox3.Clear()
                TextBox4.Clear()
                RadioButton1.Checked = False
                RadioButton2.Checked = False

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox6.Text = admin_id Then
            MessageBox.Show("you cant delete your own account")
        Else
            Try
                delete("DELETE FROM admin WHERE admin_id = '" & TextBox6.Text & "'")
                TextBox6.Clear()
                Try
                    reload("SELECT * FROM admin", datatable)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pass As String
        pass = password

        If password = TextBox2.Text Then
            If TextBox5.Text = TextBox7.Text Then
                Try
                    updates("UPDATE admin SET password='" & TextBox7.Text & "' WHERE admin_id = '" & admin_id & "'")
                    Try

                        TextBox2.Clear()
                        TextBox5.Clear()
                        TextBox7.Clear()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("new password and retype dint match")

            End If

        Else
                MessageBox.Show("old password dint match")
        End If

    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        Try
            reload("SELECT * FROM admin WHERE (`admin_name` LIKE '" & TextBox1.Text & "') OR (`username` LIKE'" & TextBox1.Text & "') OR (`admin_id` LIKE'" & TextBox1.Text & "') OR (`admin_rank` LIKE'" & TextBox1.Text & "')", datatable)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        Dim allowedChars As String = "1234567890."

        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso
                Not e.KeyChar = ChrW(8) Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub
End Class