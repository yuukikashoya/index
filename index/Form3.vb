Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports MySql.Data.MySqlClient
Public Class Form3
    Dim connection As New MySqlConnection("datasource=localhost;port=3307;username=root;password=;database=supply_office")
    Public Property username As String
    Public Property admin_id As String
    Public Property Aname As String
    Public Property password As String
    Private Sub button_logout_Click(sender As Object, e As EventArgs) Handles button_logout.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to Log out?", "Log out", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then

        Else
            Form4.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to close the app?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub admin_Click(sender As Object, e As EventArgs) Handles admin.Click
        Dim admin As New Form2()
        admin.username = username
        admin.admin_id = admin_id
        admin.Aname = Aname
        admin.password = password
        Me.Hide()
        admin.Show()

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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user.Text = Aname
        q = 0
    End Sub
    Public Property t As Double
    Public Property q As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim check As String
        check = ""
        If TextBox1.Text = check Or TextBox2.Text = check Then
            MessageBox.Show("The input is emthy")
        Else
            Dim adapter As New MySqlDataAdapter("SELECT `item_name`, `item_price`, `item_amount`, `item_year`, `category` FROM items WHERE item_id=" & TextBox1.Text, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            Dim name As String
            Dim quan As Integer
            Dim price As Double
            Dim subtotal As Double
            Dim amount As Integer

            If table.Rows.Count = 0 Then

                MessageBox.Show("no Stock")
                TextBox1.Clear()
                TextBox2.Clear()

            Else
                If q = 0 Then
                    q = 1
                Else
                    Dim c As Double
                    c = 1
                    q = q + c
                End If
                name = table(0)(0)
                quan = TextBox2.Text
                price = table(0)(1)
                amount = table(0)(2)
                subtotal = quan * price

                DataGridView1.Rows.Add(name, quan, price, subtotal)
                TextBox1.Clear()
                TextBox2.Clear()
            End If


        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        Dim total As Double
        For i As Integer = 0 To DataGridView1.RowCount - 1
            total += DataGridView1.Rows(i).Cells(3).Value

        Next
        DataGridView1.Rows.Add(Nothing, Nothing, "total", total)
        t = total
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim allowedChars As String = "1234567890."

        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso
            Not e.KeyChar = ChrW(8) Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim allowedChars As String = "1234567890."

        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso
            Not e.KeyChar = ChrW(8) Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            create("INSERT INTO pos (quantity,total) VALUES('" & q & "','" & t & "')")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        t = 0
        q = 0


        DataGridView1.Rows.Clear()
        TextBox1.ReadOnly = False
        TextBox2.ReadOnly = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Clear()
        TextBox1.ReadOnly = False
        TextBox2.ReadOnly = False
        t = 0
        q = 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form5.Show()
    End Sub
End Class