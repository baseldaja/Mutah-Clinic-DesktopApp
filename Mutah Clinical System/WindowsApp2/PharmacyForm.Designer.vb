<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PharmacyForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.addmedb = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.editmedb = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.showmedb = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.medidtb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.removemedb = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.meddosetb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.medamounttb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mednametb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'addmedb
        '
        Me.addmedb.BorderColor = System.Drawing.Color.White
        Me.addmedb.BorderRadius = 1
        Me.addmedb.BorderThickness = 1
        Me.addmedb.CheckedState.Parent = Me.addmedb
        Me.addmedb.CustomImages.Parent = Me.addmedb
        Me.addmedb.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addmedb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addmedb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addmedb.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addmedb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addmedb.DisabledState.Parent = Me.addmedb
        Me.addmedb.FillColor = System.Drawing.Color.Maroon
        Me.addmedb.FillColor2 = System.Drawing.Color.Black
        Me.addmedb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.addmedb.ForeColor = System.Drawing.Color.White
        Me.addmedb.HoverState.Parent = Me.addmedb
        Me.addmedb.Location = New System.Drawing.Point(222, 96)
        Me.addmedb.Name = "addmedb"
        Me.addmedb.ShadowDecoration.Parent = Me.addmedb
        Me.addmedb.Size = New System.Drawing.Size(163, 36)
        Me.addmedb.TabIndex = 1
        Me.addmedb.Text = "اضافة"
        '
        'editmedb
        '
        Me.editmedb.BorderColor = System.Drawing.Color.White
        Me.editmedb.BorderRadius = 1
        Me.editmedb.BorderThickness = 1
        Me.editmedb.CheckedState.Parent = Me.editmedb
        Me.editmedb.CustomImages.Parent = Me.editmedb
        Me.editmedb.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.editmedb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.editmedb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.editmedb.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.editmedb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.editmedb.DisabledState.Parent = Me.editmedb
        Me.editmedb.FillColor = System.Drawing.Color.Maroon
        Me.editmedb.FillColor2 = System.Drawing.Color.Black
        Me.editmedb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.editmedb.ForeColor = System.Drawing.Color.White
        Me.editmedb.HoverState.Parent = Me.editmedb
        Me.editmedb.Location = New System.Drawing.Point(53, 96)
        Me.editmedb.Name = "editmedb"
        Me.editmedb.ShadowDecoration.Parent = Me.editmedb
        Me.editmedb.Size = New System.Drawing.Size(163, 36)
        Me.editmedb.TabIndex = 2
        Me.editmedb.Text = "تعديل"
        '
        'showmedb
        '
        Me.showmedb.BorderColor = System.Drawing.Color.White
        Me.showmedb.BorderRadius = 1
        Me.showmedb.BorderThickness = 1
        Me.showmedb.CheckedState.Parent = Me.showmedb
        Me.showmedb.CustomImages.Parent = Me.showmedb
        Me.showmedb.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.showmedb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.showmedb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.showmedb.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.showmedb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.showmedb.DisabledState.Parent = Me.showmedb
        Me.showmedb.FillColor = System.Drawing.Color.Maroon
        Me.showmedb.FillColor2 = System.Drawing.Color.Black
        Me.showmedb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.showmedb.ForeColor = System.Drawing.Color.White
        Me.showmedb.HoverState.Parent = Me.showmedb
        Me.showmedb.Location = New System.Drawing.Point(53, 159)
        Me.showmedb.Name = "showmedb"
        Me.showmedb.ShadowDecoration.Parent = Me.showmedb
        Me.showmedb.Size = New System.Drawing.Size(163, 36)
        Me.showmedb.TabIndex = 3
        Me.showmedb.Text = "اظهار"
        '
        'medidtb
        '
        Me.medidtb.BorderColor = System.Drawing.Color.Transparent
        Me.medidtb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.medidtb.DefaultText = ""
        Me.medidtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.medidtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.medidtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.medidtb.DisabledState.Parent = Me.medidtb
        Me.medidtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.medidtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.medidtb.FocusedState.Parent = Me.medidtb
        Me.medidtb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.medidtb.ForeColor = System.Drawing.Color.Black
        Me.medidtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.medidtb.HoverState.Parent = Me.medidtb
        Me.medidtb.Location = New System.Drawing.Point(613, 96)
        Me.medidtb.Name = "medidtb"
        Me.medidtb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.medidtb.PlaceholderText = ""
        Me.medidtb.SelectedText = ""
        Me.medidtb.ShadowDecoration.Parent = Me.medidtb
        Me.medidtb.Size = New System.Drawing.Size(200, 36)
        Me.medidtb.TabIndex = 4
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Controls.Add(Me.removemedb)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.meddosetb)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.medamounttb)
        Me.Guna2GroupBox1.Controls.Add(Me.showmedb)
        Me.Guna2GroupBox1.Controls.Add(Me.editmedb)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.addmedb)
        Me.Guna2GroupBox1.Controls.Add(Me.mednametb)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.medidtb)
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.DimGray
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(843, 244)
        Me.Guna2GroupBox1.TabIndex = 5
        Me.Guna2GroupBox1.Text = "ادارة الادوية"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'removemedb
        '
        Me.removemedb.BorderColor = System.Drawing.Color.White
        Me.removemedb.BorderRadius = 1
        Me.removemedb.BorderThickness = 1
        Me.removemedb.CheckedState.Parent = Me.removemedb
        Me.removemedb.CustomImages.Parent = Me.removemedb
        Me.removemedb.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.removemedb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.removemedb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.removemedb.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.removemedb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.removemedb.DisabledState.Parent = Me.removemedb
        Me.removemedb.FillColor = System.Drawing.Color.Maroon
        Me.removemedb.FillColor2 = System.Drawing.Color.Black
        Me.removemedb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.removemedb.ForeColor = System.Drawing.Color.White
        Me.removemedb.HoverState.Parent = Me.removemedb
        Me.removemedb.Location = New System.Drawing.Point(222, 159)
        Me.removemedb.Name = "removemedb"
        Me.removemedb.ShadowDecoration.Parent = Me.removemedb
        Me.removemedb.Size = New System.Drawing.Size(163, 36)
        Me.removemedb.TabIndex = 12
        Me.removemedb.Text = "حذف"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(767, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "الجرعة "
        '
        'meddosetb
        '
        Me.meddosetb.BorderColor = System.Drawing.Color.Transparent
        Me.meddosetb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.meddosetb.DefaultText = ""
        Me.meddosetb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.meddosetb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.meddosetb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.meddosetb.DisabledState.Parent = Me.meddosetb
        Me.meddosetb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.meddosetb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.meddosetb.FocusedState.Parent = Me.meddosetb
        Me.meddosetb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.meddosetb.ForeColor = System.Drawing.Color.Black
        Me.meddosetb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.meddosetb.HoverState.Parent = Me.meddosetb
        Me.meddosetb.Location = New System.Drawing.Point(613, 159)
        Me.meddosetb.Name = "meddosetb"
        Me.meddosetb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.meddosetb.PlaceholderText = ""
        Me.meddosetb.SelectedText = ""
        Me.meddosetb.ShadowDecoration.Parent = Me.meddosetb
        Me.meddosetb.Size = New System.Drawing.Size(200, 36)
        Me.meddosetb.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(494, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "الكمية المتوفرة"
        '
        'medamounttb
        '
        Me.medamounttb.BorderColor = System.Drawing.Color.Transparent
        Me.medamounttb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.medamounttb.DefaultText = ""
        Me.medamounttb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.medamounttb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.medamounttb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.medamounttb.DisabledState.Parent = Me.medamounttb
        Me.medamounttb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.medamounttb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.medamounttb.FocusedState.Parent = Me.medamounttb
        Me.medamounttb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.medamounttb.ForeColor = System.Drawing.Color.Black
        Me.medamounttb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.medamounttb.HoverState.Parent = Me.medamounttb
        Me.medamounttb.Location = New System.Drawing.Point(391, 159)
        Me.medamounttb.Name = "medamounttb"
        Me.medamounttb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.medamounttb.PlaceholderText = ""
        Me.medamounttb.SelectedText = ""
        Me.medamounttb.ShadowDecoration.Parent = Me.medamounttb
        Me.medamounttb.Size = New System.Drawing.Size(200, 36)
        Me.medamounttb.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(521, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "اسم الدواء"
        '
        'mednametb
        '
        Me.mednametb.BorderColor = System.Drawing.Color.Transparent
        Me.mednametb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mednametb.DefaultText = ""
        Me.mednametb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.mednametb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.mednametb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mednametb.DisabledState.Parent = Me.mednametb
        Me.mednametb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mednametb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mednametb.FocusedState.Parent = Me.mednametb
        Me.mednametb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mednametb.ForeColor = System.Drawing.Color.Black
        Me.mednametb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mednametb.HoverState.Parent = Me.mednametb
        Me.mednametb.Location = New System.Drawing.Point(391, 96)
        Me.mednametb.Name = "mednametb"
        Me.mednametb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mednametb.PlaceholderText = ""
        Me.mednametb.SelectedText = ""
        Me.mednametb.ShadowDecoration.Parent = Me.mednametb
        Me.mednametb.Size = New System.Drawing.Size(200, 36)
        Me.mednametb.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(743, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "رقم الدواء"
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv1.Location = New System.Drawing.Point(0, 36)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.dgv1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv1.Size = New System.Drawing.Size(843, 254)
        Me.dgv1.TabIndex = 7
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.dgv1)
        Me.Guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.DarkRed
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(0, 250)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(843, 290)
        Me.Guna2GroupBox2.TabIndex = 13
        Me.Guna2GroupBox2.Text = "تفاصيل الادوية"
        Me.Guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PharmacyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(843, 540)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "PharmacyForm"
        Me.Text = "PharmacyForm"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents addmedb As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents editmedb As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents showmedb As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents medidtb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents medamounttb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mednametb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents meddosetb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents removemedb As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
End Class
