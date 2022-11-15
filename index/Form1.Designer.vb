<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.table_buttom = New System.Windows.Forms.Button()
        Me.admin_buttom = New System.Windows.Forms.Button()
        Me.button_logout = New System.Windows.Forms.Button()
        Me.Nav = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.button_sale = New System.Windows.Forms.Button()
        Me.seachT = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Button()
        Me.header = New System.Windows.Forms.Panel()
        Me.main = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.search_books = New System.Windows.Forms.RadioButton()
        Me.search_accesory = New System.Windows.Forms.RadioButton()
        Me.search_uniform = New System.Windows.Forms.RadioButton()
        Me.search_material = New System.Windows.Forms.RadioButton()
        Me.searchSupply = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.adminTable = New System.Windows.Forms.DataGridView()
        Me.item_id_table = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name_table = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_price_table = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_amount_table = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_year_table = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_category_table = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.user = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.clear_add = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Item_year = New System.Windows.Forms.TextBox()
        Me.item_price = New System.Windows.Forms.TextBox()
        Me.item_amount = New System.Windows.Forms.TextBox()
        Me.item_name = New System.Windows.Forms.TextBox()
        Me.book = New System.Windows.Forms.RadioButton()
        Me.accesory = New System.Windows.Forms.RadioButton()
        Me.uniform = New System.Windows.Forms.RadioButton()
        Me.uniform_material = New System.Windows.Forms.RadioButton()
        Me.supply = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.edit_clear = New System.Windows.Forms.Button()
        Me.old_value = New System.Windows.Forms.TextBox()
        Me.asd = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.edit_price = New System.Windows.Forms.TextBox()
        Me.edit_amount = New System.Windows.Forms.TextBox()
        Me.edit_id = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.delete_clear = New System.Windows.Forms.Button()
        Me.delete_id = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Nav.SuspendLayout()
        Me.header.SuspendLayout()
        Me.main.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.adminTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'table_buttom
        '
        Me.table_buttom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.table_buttom.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.table_buttom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.table_buttom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table_buttom.ForeColor = System.Drawing.Color.White
        Me.table_buttom.Location = New System.Drawing.Point(3, 46)
        Me.table_buttom.Name = "table_buttom"
        Me.table_buttom.Size = New System.Drawing.Size(99, 35)
        Me.table_buttom.TabIndex = 0
        Me.table_buttom.Text = "Items"
        Me.table_buttom.UseVisualStyleBackColor = False
        '
        'admin_buttom
        '
        Me.admin_buttom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.admin_buttom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admin_buttom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_buttom.Location = New System.Drawing.Point(3, 87)
        Me.admin_buttom.Name = "admin_buttom"
        Me.admin_buttom.Size = New System.Drawing.Size(99, 35)
        Me.admin_buttom.TabIndex = 1
        Me.admin_buttom.Text = "Admin"
        Me.admin_buttom.UseVisualStyleBackColor = True
        '
        'button_logout
        '
        Me.button_logout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_logout.BackColor = System.Drawing.Color.Red
        Me.button_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_logout.ForeColor = System.Drawing.Color.White
        Me.button_logout.Location = New System.Drawing.Point(3, 439)
        Me.button_logout.Name = "button_logout"
        Me.button_logout.Size = New System.Drawing.Size(99, 35)
        Me.button_logout.TabIndex = 4
        Me.button_logout.Text = "Log out"
        Me.button_logout.UseVisualStyleBackColor = False
        '
        'Nav
        '
        Me.Nav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Nav.BackColor = System.Drawing.Color.SteelBlue
        Me.Nav.Controls.Add(Me.Label1)
        Me.Nav.Controls.Add(Me.button_logout)
        Me.Nav.Controls.Add(Me.button_sale)
        Me.Nav.Controls.Add(Me.admin_buttom)
        Me.Nav.Controls.Add(Me.table_buttom)
        Me.Nav.Dock = System.Windows.Forms.DockStyle.Left
        Me.Nav.Location = New System.Drawing.Point(0, 0)
        Me.Nav.Name = "Nav"
        Me.Nav.Size = New System.Drawing.Size(105, 486)
        Me.Nav.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 43)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Table"
        '
        'button_sale
        '
        Me.button_sale.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_sale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_sale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_sale.Location = New System.Drawing.Point(3, 128)
        Me.button_sale.Name = "button_sale"
        Me.button_sale.Size = New System.Drawing.Size(99, 35)
        Me.button_sale.TabIndex = 3
        Me.button_sale.Text = "Sale"
        Me.button_sale.UseVisualStyleBackColor = True
        '
        'seachT
        '
        Me.seachT.BackColor = System.Drawing.Color.White
        Me.seachT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.seachT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seachT.Location = New System.Drawing.Point(0, 0)
        Me.seachT.Name = "seachT"
        Me.seachT.Size = New System.Drawing.Size(394, 24)
        Me.seachT.TabIndex = 5
        '
        'search
        '
        Me.search.BackColor = System.Drawing.Color.BurlyWood
        Me.search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search.Dock = System.Windows.Forms.DockStyle.Right
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.search.Location = New System.Drawing.Point(394, 0)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(109, 26)
        Me.search.TabIndex = 5
        Me.search.Text = "Search"
        Me.search.UseVisualStyleBackColor = False
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.LightSkyBlue
        Me.header.Controls.Add(Me.seachT)
        Me.header.Controls.Add(Me.search)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(503, 26)
        Me.header.TabIndex = 6
        '
        'main
        '
        Me.main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.main.BackColor = System.Drawing.Color.Transparent
        Me.main.Controls.Add(Me.Panel7)
        Me.main.Controls.Add(Me.adminTable)
        Me.main.Controls.Add(Me.header)
        Me.main.Location = New System.Drawing.Point(105, 267)
        Me.main.Name = "main"
        Me.main.Size = New System.Drawing.Size(503, 219)
        Me.main.TabIndex = 7
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Button4)
        Me.Panel7.Controls.Add(Me.Panel6)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(394, 26)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(109, 193)
        Me.Panel7.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Silver
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(0, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 23)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "refresh"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.search_books)
        Me.Panel6.Controls.Add(Me.search_accesory)
        Me.Panel6.Controls.Add(Me.search_uniform)
        Me.Panel6.Controls.Add(Me.search_material)
        Me.Panel6.Controls.Add(Me.searchSupply)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(109, 193)
        Me.Panel6.TabIndex = 7
        '
        'search_books
        '
        Me.search_books.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_books.AutoSize = True
        Me.search_books.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search_books.Location = New System.Drawing.Point(6, 95)
        Me.search_books.Name = "search_books"
        Me.search_books.Size = New System.Drawing.Size(91, 17)
        Me.search_books.TabIndex = 23
        Me.search_books.TabStop = True
        Me.search_books.Text = "School Books"
        Me.search_books.UseVisualStyleBackColor = True
        '
        'search_accesory
        '
        Me.search_accesory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_accesory.AutoSize = True
        Me.search_accesory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search_accesory.Location = New System.Drawing.Point(6, 76)
        Me.search_accesory.Name = "search_accesory"
        Me.search_accesory.Size = New System.Drawing.Size(105, 17)
        Me.search_accesory.TabIndex = 22
        Me.search_accesory.TabStop = True
        Me.search_accesory.Text = "School Accesory"
        Me.search_accesory.UseVisualStyleBackColor = True
        '
        'search_uniform
        '
        Me.search_uniform.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_uniform.AutoSize = True
        Me.search_uniform.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search_uniform.Location = New System.Drawing.Point(6, 59)
        Me.search_uniform.Name = "search_uniform"
        Me.search_uniform.Size = New System.Drawing.Size(61, 17)
        Me.search_uniform.TabIndex = 21
        Me.search_uniform.TabStop = True
        Me.search_uniform.Text = "Uniform"
        Me.search_uniform.UseVisualStyleBackColor = True
        '
        'search_material
        '
        Me.search_material.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_material.AutoSize = True
        Me.search_material.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search_material.Location = New System.Drawing.Point(6, 44)
        Me.search_material.Name = "search_material"
        Me.search_material.Size = New System.Drawing.Size(101, 17)
        Me.search_material.TabIndex = 20
        Me.search_material.TabStop = True
        Me.search_material.Text = "Uniform Material"
        Me.search_material.UseVisualStyleBackColor = True
        '
        'searchSupply
        '
        Me.searchSupply.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchSupply.AutoSize = True
        Me.searchSupply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.searchSupply.Location = New System.Drawing.Point(6, 30)
        Me.searchSupply.Name = "searchSupply"
        Me.searchSupply.Size = New System.Drawing.Size(93, 17)
        Me.searchSupply.TabIndex = 19
        Me.searchSupply.TabStop = True
        Me.searchSupply.Text = "School Supply"
        Me.searchSupply.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Variable Display", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 20)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Category"
        '
        'adminTable
        '
        Me.adminTable.AllowUserToAddRows = False
        Me.adminTable.AllowUserToDeleteRows = False
        Me.adminTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.adminTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.adminTable.BackgroundColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.adminTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.adminTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.adminTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_id_table, Me.item_name_table, Me.item_price_table, Me.item_amount_table, Me.item_year_table, Me.item_category_table})
        Me.adminTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.adminTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.adminTable.Location = New System.Drawing.Point(0, 26)
        Me.adminTable.Name = "adminTable"
        Me.adminTable.ReadOnly = True
        Me.adminTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.adminTable.Size = New System.Drawing.Size(394, 193)
        Me.adminTable.TabIndex = 0
        '
        'item_id_table
        '
        Me.item_id_table.DataPropertyName = "item_id"
        Me.item_id_table.HeaderText = "Item ID"
        Me.item_id_table.Name = "item_id_table"
        Me.item_id_table.ReadOnly = True
        '
        'item_name_table
        '
        Me.item_name_table.DataPropertyName = "item_name"
        Me.item_name_table.HeaderText = "Item Name"
        Me.item_name_table.Name = "item_name_table"
        Me.item_name_table.ReadOnly = True
        '
        'item_price_table
        '
        Me.item_price_table.DataPropertyName = "item_price"
        Me.item_price_table.HeaderText = "Item Price"
        Me.item_price_table.Name = "item_price_table"
        Me.item_price_table.ReadOnly = True
        '
        'item_amount_table
        '
        Me.item_amount_table.DataPropertyName = "item_amount"
        Me.item_amount_table.HeaderText = "Item Amount"
        Me.item_amount_table.Name = "item_amount_table"
        Me.item_amount_table.ReadOnly = True
        '
        'item_year_table
        '
        Me.item_year_table.DataPropertyName = "item_year"
        Me.item_year_table.HeaderText = "Year"
        Me.item_year_table.Name = "item_year_table"
        Me.item_year_table.ReadOnly = True
        '
        'item_category_table
        '
        Me.item_category_table.DataPropertyName = "category"
        Me.item_category_table.HeaderText = "Category"
        Me.item_category_table.Name = "item_category_table"
        Me.item_category_table.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(105, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(815, 271)
        Me.Panel2.TabIndex = 8
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel8.Controls.Add(Me.PictureBox1)
        Me.Panel8.Controls.Add(Me.user)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(503, 25)
        Me.Panel8.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(5, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 20)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.Aqua
        Me.user.Location = New System.Drawing.Point(34, 4)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(66, 18)
        Me.user.TabIndex = 0
        Me.user.Text = "Label10"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.clear_add)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Item_year)
        Me.Panel3.Controls.Add(Me.item_price)
        Me.Panel3.Controls.Add(Me.item_amount)
        Me.Panel3.Controls.Add(Me.item_name)
        Me.Panel3.Controls.Add(Me.book)
        Me.Panel3.Controls.Add(Me.accesory)
        Me.Panel3.Controls.Add(Me.uniform)
        Me.Panel3.Controls.Add(Me.uniform_material)
        Me.Panel3.Controls.Add(Me.supply)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(3, 25)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(500, 246)
        Me.Panel3.TabIndex = 6
        Me.Panel3.Tag = "Type Here"
        '
        'clear_add
        '
        Me.clear_add.BackColor = System.Drawing.Color.Silver
        Me.clear_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_add.Location = New System.Drawing.Point(288, 209)
        Me.clear_add.Name = "clear_add"
        Me.clear_add.Size = New System.Drawing.Size(87, 23)
        Me.clear_add.TabIndex = 24
        Me.clear_add.Text = "Clear"
        Me.clear_add.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(160, 209)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Item_year
        '
        Me.Item_year.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Item_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item_year.Location = New System.Drawing.Point(119, 126)
        Me.Item_year.MaxLength = 4
        Me.Item_year.Name = "Item_year"
        Me.Item_year.Size = New System.Drawing.Size(138, 24)
        Me.Item_year.TabIndex = 21
        '
        'item_price
        '
        Me.item_price.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.item_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_price.Location = New System.Drawing.Point(119, 97)
        Me.item_price.Name = "item_price"
        Me.item_price.Size = New System.Drawing.Size(138, 24)
        Me.item_price.TabIndex = 20
        '
        'item_amount
        '
        Me.item_amount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.item_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_amount.Location = New System.Drawing.Point(119, 67)
        Me.item_amount.Name = "item_amount"
        Me.item_amount.Size = New System.Drawing.Size(138, 24)
        Me.item_amount.TabIndex = 19
        '
        'item_name
        '
        Me.item_name.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.item_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_name.Location = New System.Drawing.Point(119, 37)
        Me.item_name.Name = "item_name"
        Me.item_name.Size = New System.Drawing.Size(138, 24)
        Me.item_name.TabIndex = 18
        '
        'book
        '
        Me.book.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.book.AutoSize = True
        Me.book.Location = New System.Drawing.Point(314, 145)
        Me.book.Name = "book"
        Me.book.Size = New System.Drawing.Size(91, 17)
        Me.book.TabIndex = 17
        Me.book.TabStop = True
        Me.book.Text = "School Books"
        Me.book.UseVisualStyleBackColor = True
        '
        'accesory
        '
        Me.accesory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.accesory.AutoSize = True
        Me.accesory.Location = New System.Drawing.Point(314, 122)
        Me.accesory.Name = "accesory"
        Me.accesory.Size = New System.Drawing.Size(105, 17)
        Me.accesory.TabIndex = 16
        Me.accesory.TabStop = True
        Me.accesory.Text = "School Accesory"
        Me.accesory.UseVisualStyleBackColor = True
        '
        'uniform
        '
        Me.uniform.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uniform.AutoSize = True
        Me.uniform.Location = New System.Drawing.Point(314, 104)
        Me.uniform.Name = "uniform"
        Me.uniform.Size = New System.Drawing.Size(61, 17)
        Me.uniform.TabIndex = 15
        Me.uniform.TabStop = True
        Me.uniform.Text = "Uniform"
        Me.uniform.UseVisualStyleBackColor = True
        '
        'uniform_material
        '
        Me.uniform_material.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uniform_material.AutoSize = True
        Me.uniform_material.Location = New System.Drawing.Point(314, 86)
        Me.uniform_material.Name = "uniform_material"
        Me.uniform_material.Size = New System.Drawing.Size(101, 17)
        Me.uniform_material.TabIndex = 14
        Me.uniform_material.TabStop = True
        Me.uniform_material.Text = "Uniform Material"
        Me.uniform_material.UseVisualStyleBackColor = True
        '
        'supply
        '
        Me.supply.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.supply.AutoSize = True
        Me.supply.Location = New System.Drawing.Point(314, 67)
        Me.supply.Name = "supply"
        Me.supply.Size = New System.Drawing.Size(93, 17)
        Me.supply.TabIndex = 13
        Me.supply.TabStop = True
        Me.supply.Text = "School Supply"
        Me.supply.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Variable Display", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(310, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 20)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Category"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Variable Display", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 20)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Item Year:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Variable Display", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Item Price:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Variable Display", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Item Amount:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Variable Display", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 20)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Item Name:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Add Item"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.edit_clear)
        Me.Panel1.Controls.Add(Me.old_value)
        Me.Panel1.Controls.Add(Me.asd)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.edit_price)
        Me.Panel1.Controls.Add(Me.edit_amount)
        Me.Panel1.Controls.Add(Me.edit_id)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(503, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 271)
        Me.Panel1.TabIndex = 5
        '
        'edit_clear
        '
        Me.edit_clear.BackColor = System.Drawing.Color.Silver
        Me.edit_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.edit_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_clear.Location = New System.Drawing.Point(184, 209)
        Me.edit_clear.Name = "edit_clear"
        Me.edit_clear.Size = New System.Drawing.Size(87, 23)
        Me.edit_clear.TabIndex = 31
        Me.edit_clear.Text = "Clear"
        Me.edit_clear.UseVisualStyleBackColor = False
        '
        'old_value
        '
        Me.old_value.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.old_value.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.old_value.Location = New System.Drawing.Point(138, 140)
        Me.old_value.Name = "old_value"
        Me.old_value.ReadOnly = True
        Me.old_value.Size = New System.Drawing.Size(34, 24)
        Me.old_value.TabIndex = 30
        Me.old_value.Visible = False
        '
        'asd
        '
        Me.asd.AutoSize = True
        Me.asd.BackColor = System.Drawing.Color.Transparent
        Me.asd.Font = New System.Drawing.Font("Segoe UI Variable Display", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asd.Location = New System.Drawing.Point(5, 107)
        Me.asd.Name = "asd"
        Me.asd.Size = New System.Drawing.Size(85, 20)
        Me.asd.TabIndex = 24
        Me.asd.Text = "Item Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Variable Display", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Item Amount:"
        '
        'edit_price
        '
        Me.edit_price.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.edit_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_price.Location = New System.Drawing.Point(138, 105)
        Me.edit_price.Name = "edit_price"
        Me.edit_price.Size = New System.Drawing.Size(154, 24)
        Me.edit_price.TabIndex = 28
        '
        'edit_amount
        '
        Me.edit_amount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.edit_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_amount.Location = New System.Drawing.Point(138, 73)
        Me.edit_amount.Name = "edit_amount"
        Me.edit_amount.Size = New System.Drawing.Size(154, 24)
        Me.edit_amount.TabIndex = 27
        '
        'edit_id
        '
        Me.edit_id.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.edit_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_id.Location = New System.Drawing.Point(138, 43)
        Me.edit_id.Name = "edit_id"
        Me.edit_id.ReadOnly = True
        Me.edit_id.Size = New System.Drawing.Size(154, 24)
        Me.edit_id.TabIndex = 24
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(93, 209)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 23)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Variable Display", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Item ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Edit item"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.delete_clear)
        Me.Panel4.Controls.Add(Me.delete_id)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(312, 216)
        Me.Panel4.TabIndex = 6
        '
        'delete_clear
        '
        Me.delete_clear.BackColor = System.Drawing.Color.Silver
        Me.delete_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delete_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_clear.Location = New System.Drawing.Point(138, 111)
        Me.delete_clear.Name = "delete_clear"
        Me.delete_clear.Size = New System.Drawing.Size(119, 23)
        Me.delete_clear.TabIndex = 25
        Me.delete_clear.Text = "Clear"
        Me.delete_clear.UseVisualStyleBackColor = False
        '
        'delete_id
        '
        Me.delete_id.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.delete_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_id.Location = New System.Drawing.Point(66, 48)
        Me.delete_id.Name = "delete_id"
        Me.delete_id.Size = New System.Drawing.Size(241, 24)
        Me.delete_id.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Delete Item"
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(138, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Variable Display", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Item ID:"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Location = New System.Drawing.Point(608, 270)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(312, 216)
        Me.Panel5.TabIndex = 9
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.index.My.Resources.Resources._278929301_2139842302846049_5625667573508712500_n
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(920, 486)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.main)
        Me.Controls.Add(Me.Nav)
        Me.Name = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Nav.ResumeLayout(False)
        Me.Nav.PerformLayout()
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        Me.main.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.adminTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents table_buttom As Button
    Friend WithEvents admin_buttom As Button
    Friend WithEvents button_logout As Button
    Protected WithEvents Nav As Panel
    Friend WithEvents button_sale As Button
    Friend WithEvents seachT As TextBox
    Friend WithEvents search As Button
    Friend WithEvents header As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents main As Panel
    Friend WithEvents adminTable As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents delete_id As TextBox
    Friend WithEvents book As RadioButton
    Friend WithEvents accesory As RadioButton
    Friend WithEvents uniform As RadioButton
    Friend WithEvents uniform_material As RadioButton
    Friend WithEvents supply As RadioButton
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents item_name As TextBox
    Friend WithEvents Item_year As TextBox
    Friend WithEvents item_price As TextBox
    Friend WithEvents item_amount As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents edit_price As TextBox
    Friend WithEvents edit_amount As TextBox
    Friend WithEvents edit_id As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents asd As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents search_books As RadioButton
    Friend WithEvents search_accesory As RadioButton
    Friend WithEvents search_uniform As RadioButton
    Friend WithEvents search_material As RadioButton
    Friend WithEvents searchSupply As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents item_id_table As DataGridViewTextBoxColumn
    Friend WithEvents item_name_table As DataGridViewTextBoxColumn
    Friend WithEvents item_price_table As DataGridViewTextBoxColumn
    Friend WithEvents item_amount_table As DataGridViewTextBoxColumn
    Friend WithEvents item_year_table As DataGridViewTextBoxColumn
    Friend WithEvents item_category_table As DataGridViewTextBoxColumn
    Friend WithEvents old_value As TextBox
    Friend WithEvents clear_add As Button
    Friend WithEvents edit_clear As Button
    Friend WithEvents delete_clear As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents user As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents PictureBox1 As PictureBox
End Class
