Imports Microsoft.VisualBasic.Devices

Public Class Form1
    Public Property username As String
    Public Property admin_id As String
    Public Property Aname As String
    Public Property password As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles admin_buttom.Click
        Dim admin As New Form2()
        admin.username = username
        admin.admin_id = admin_id
        admin.Aname = Aname
        admin.password = password

        admin.Show()
        Me.Hide()
    End Sub



    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to close the app?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub



    Private Sub button_logout_Click_1(sender As Object, e As EventArgs) Handles button_logout.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to Log out?", "Log out", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then

        Else
            Form4.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub button_sale_Click(sender As Object, e As EventArgs) Handles button_sale.Click
        Dim admin As New Form3()
        admin.username = username
        admin.admin_id = admin_id
        admin.Aname = Aname
        admin.password = password
        admin.Show()
        Me.Hide()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim c As String
        c = "none"

        If supply.Checked Then
            c = "supply"
        ElseIf uniform_material.Checked Then
            c = "Material"
        ElseIf uniform.Checked Then
            c = "Uniform"
        ElseIf accesory.Checked Then
            c = "Accesory"
        ElseIf book.Checked Then
            c = "Books"
        End If
        Try
            create("INSERT INTO items (item_name,item_price,item_amount,item_year,category) VALUES('" & item_name.Text & "','" & item_price.Text & "','" & item_amount.Text & "','" & Item_year.Text & "','" & c & "')")
            Try
                reload("SELECT * FROM items", adminTable)
                c = ""
                item_name.Clear()
                item_price.Clear()
                item_amount.Clear()
                Item_year.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        searchSupply.Checked = False
        search_accesory.Checked = False
        search_books.Checked = False
        search_material.Checked = False
        search_uniform.Checked = False
        seachT.Clear()
        Try
            reload("SELECT * FROM items", adminTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub adminTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles adminTable.CellContentClick
        edit_id.Text = adminTable.CurrentRow.Cells(0).Value
        old_value.Text = adminTable.CurrentRow.Cells(3).Value
        edit_price.Text = adminTable.CurrentRow.Cells(2).Value
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        Dim old As Integer
        Dim add As Integer
        Dim total As Integer


        old = Val(old_value.Text)
        add = Val(edit_amount.Text)
        total = old + add


        Try
            updates("UPDATE items SET item_amount='" & total & "',item_price='" & edit_price.Text & "' WHERE item_id = '" & edit_id.Text & "'")
            Try
                reload("SELECT * FROM items", adminTable)
                total = 0
                add = 0
                old = 0
                edit_amount.Clear()
                edit_price.Clear()
                edit_id.Clear()
                old_value.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub edit_amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles edit_amount.KeyPress
        Dim allowedChars As String = "1234567890."

        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso
            Not e.KeyChar = ChrW(8) Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub edit_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles edit_price.KeyPress
        Dim allowedChars As String = "1234567890."

        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso
            Not e.KeyChar = ChrW(8) Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub item_amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles item_amount.KeyPress
        Dim allowedChars As String = "1234567890."

        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso
            Not e.KeyChar = ChrW(8) Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub item_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles item_price.KeyPress
        Dim allowedChars As String = "1234567890."

        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso
            Not e.KeyChar = ChrW(8) Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub Item_year_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Item_year.KeyPress
        Dim allowedChars As String = "1234567890."

        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso
            Not e.KeyChar = ChrW(8) Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub delete_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles delete_id.KeyPress
        Dim allowedChars As String = "1234567890."

        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso
            Not e.KeyChar = ChrW(8) Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            delete("DELETE FROM items WHERE item_id = '" & delete_id.Text & "'")
            delete_id.Clear()
            Try
                reload("SELECT * FROM items", adminTable)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub clear_add_Click(sender As Object, e As EventArgs) Handles clear_add.Click
        item_name.Clear()
        item_price.Clear()
        item_amount.Clear()
        Item_year.Clear()
        supply.Checked = False
        uniform_material.Checked = False
        book.Checked = False
        accesory.Checked = False
        uniform.Checked = False
    End Sub

    Private Sub edit_clear_Click(sender As Object, e As EventArgs) Handles edit_clear.Click
        edit_amount.Clear()
        edit_price.Clear()
        edit_id.Clear()
        old_value.Clear()

    End Sub

    Private Sub delete_clear_Click(sender As Object, e As EventArgs) Handles delete_clear.Click
        delete_id.Clear()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles seachT.TextChanged

    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click

        Try
            reload("SELECT * FROM items WHERE (`item_name` LIKE '" & seachT.Text & "') OR (`category` LIKE'" & seachT.Text & "') OR (`item_id` LIKE'" & seachT.Text & "') ", adminTable)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub searchSupply_CheckedChanged(sender As Object, e As EventArgs) Handles searchSupply.CheckedChanged
        Try
            reload("SELECT * FROM items WHERE  (`category` LIKE'" & "supply" & "')  ", adminTable)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub search_material_CheckedChanged(sender As Object, e As EventArgs) Handles search_material.CheckedChanged
        Try
            reload("SELECT * FROM items WHERE  (`category` LIKE'" & "Material" & "')  ", adminTable)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub search_uniform_CheckedChanged(sender As Object, e As EventArgs) Handles search_uniform.CheckedChanged
        Try
            reload("SELECT * FROM items WHERE  (`category` LIKE'" & "Uniform" & "')  ", adminTable)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub search_accesory_CheckedChanged(sender As Object, e As EventArgs) Handles search_accesory.CheckedChanged
        Try
            reload("SELECT * FROM items WHERE  (`category` LIKE'" & "Accesory" & "')  ", adminTable)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub search_books_CheckedChanged(sender As Object, e As EventArgs) Handles search_books.CheckedChanged
        Try
            reload("SELECT * FROM items WHERE  (`category` LIKE'" & "Books" & "')  ", adminTable)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user.Text = Aname

        Try
            reload("SELECT * FROM items", adminTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub item_price_TextChanged(sender As Object, e As EventArgs) Handles item_price.TextChanged

    End Sub
End Class
