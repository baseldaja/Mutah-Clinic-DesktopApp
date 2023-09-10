<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class receiptForm
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
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.mednamsearchetb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.medsearchb = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.residtb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mednametb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.patnametb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.medamounttb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mednotetb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.meddailydosetb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.addrecb = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.meddosetb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.showrecb = New Guna.UI2.WinForms.Guna2CircleButton()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv1.Location = New System.Drawing.Point(0, 364)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(754, 166)
        Me.dgv1.TabIndex = 0
        '
        'mednamsearchetb
        '
        Me.mednamsearchetb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mednamsearchetb.DefaultText = ""
        Me.mednamsearchetb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.mednamsearchetb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.mednamsearchetb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mednamsearchetb.DisabledState.Parent = Me.mednamsearchetb
        Me.mednamsearchetb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mednamsearchetb.FillColor = System.Drawing.Color.Blue
        Me.mednamsearchetb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mednamsearchetb.FocusedState.Parent = Me.mednamsearchetb
        Me.mednamsearchetb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mednamsearchetb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mednamsearchetb.HoverState.Parent = Me.mednamsearchetb
        Me.mednamsearchetb.Location = New System.Drawing.Point(538, 35)
        Me.mednamsearchetb.Name = "mednamsearchetb"
        Me.mednamsearchetb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mednamsearchetb.PlaceholderText = ""
        Me.mednamsearchetb.SelectedText = ""
        Me.mednamsearchetb.ShadowDecoration.Parent = Me.mednamsearchetb
        Me.mednamsearchetb.Size = New System.Drawing.Size(195, 35)
        Me.mednamsearchetb.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(640, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "البحث عن الادوية"
        '
        'medsearchb
        '
        Me.medsearchb.CheckedState.Parent = Me.medsearchb
        Me.medsearchb.CustomImages.Parent = Me.medsearchb
        Me.medsearchb.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.medsearchb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.medsearchb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.medsearchb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.medsearchb.DisabledState.Parent = Me.medsearchb
        Me.medsearchb.FillColor = System.Drawing.Color.Blue
        Me.medsearchb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.medsearchb.ForeColor = System.Drawing.Color.White
        Me.medsearchb.HoverState.Parent = Me.medsearchb
        Me.medsearchb.Location = New System.Drawing.Point(446, 35)
        Me.medsearchb.Name = "medsearchb"
        Me.medsearchb.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.medsearchb.ShadowDecoration.Parent = Me.medsearchb
        Me.medsearchb.Size = New System.Drawing.Size(77, 35)
        Me.medsearchb.TabIndex = 3
        Me.medsearchb.Text = "بحث"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(670, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "رقم الوصفة"
        '
        'residtb
        '
        Me.residtb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.residtb.DefaultText = ""
        Me.residtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.residtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.residtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.residtb.DisabledState.Parent = Me.residtb
        Me.residtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.residtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.residtb.FocusedState.Parent = Me.residtb
        Me.residtb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.residtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.residtb.HoverState.Parent = Me.residtb
        Me.residtb.Location = New System.Drawing.Point(538, 117)
        Me.residtb.Name = "residtb"
        Me.residtb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.residtb.PlaceholderText = ""
        Me.residtb.SelectedText = ""
        Me.residtb.ShadowDecoration.Parent = Me.residtb
        Me.residtb.Size = New System.Drawing.Size(195, 35)
        Me.residtb.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(274, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "اسم الدواء"
        '
        'mednametb
        '
        Me.mednametb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mednametb.DefaultText = ""
        Me.mednametb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.mednametb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.mednametb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mednametb.DisabledState.Parent = Me.mednametb
        Me.mednametb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mednametb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mednametb.FocusedState.Parent = Me.mednametb
        Me.mednametb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mednametb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mednametb.HoverState.Parent = Me.mednametb
        Me.mednametb.Location = New System.Drawing.Point(136, 117)
        Me.mednametb.Name = "mednametb"
        Me.mednametb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mednametb.PlaceholderText = ""
        Me.mednametb.SelectedText = ""
        Me.mednametb.ShadowDecoration.Parent = Me.mednametb
        Me.mednametb.Size = New System.Drawing.Size(195, 35)
        Me.mednametb.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(465, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "اسم المريض"
        '
        'patnametb
        '
        Me.patnametb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.patnametb.DefaultText = ""
        Me.patnametb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.patnametb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.patnametb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.patnametb.DisabledState.Parent = Me.patnametb
        Me.patnametb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.patnametb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.patnametb.FocusedState.Parent = Me.patnametb
        Me.patnametb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.patnametb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.patnametb.HoverState.Parent = Me.patnametb
        Me.patnametb.Location = New System.Drawing.Point(337, 117)
        Me.patnametb.Name = "patnametb"
        Me.patnametb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.patnametb.PlaceholderText = ""
        Me.patnametb.SelectedText = ""
        Me.patnametb.ShadowDecoration.Parent = Me.patnametb
        Me.patnametb.Size = New System.Drawing.Size(195, 35)
        Me.patnametb.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(454, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "الكمية المعطاة"
        '
        'medamounttb
        '
        Me.medamounttb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.medamounttb.DefaultText = ""
        Me.medamounttb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.medamounttb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.medamounttb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.medamounttb.DisabledState.Parent = Me.medamounttb
        Me.medamounttb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.medamounttb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.medamounttb.FocusedState.Parent = Me.medamounttb
        Me.medamounttb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.medamounttb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.medamounttb.HoverState.Parent = Me.medamounttb
        Me.medamounttb.Location = New System.Drawing.Point(337, 185)
        Me.medamounttb.Name = "medamounttb"
        Me.medamounttb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.medamounttb.PlaceholderText = ""
        Me.medamounttb.SelectedText = ""
        Me.medamounttb.ShadowDecoration.Parent = Me.medamounttb
        Me.medamounttb.Size = New System.Drawing.Size(195, 35)
        Me.medamounttb.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(644, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "ملاحظات الطبيب"
        '
        'mednotetb
        '
        Me.mednotetb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mednotetb.DefaultText = ""
        Me.mednotetb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.mednotetb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.mednotetb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mednotetb.DisabledState.Parent = Me.mednotetb
        Me.mednotetb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mednotetb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mednotetb.FocusedState.Parent = Me.mednotetb
        Me.mednotetb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mednotetb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mednotetb.HoverState.Parent = Me.mednotetb
        Me.mednotetb.Location = New System.Drawing.Point(78, 263)
        Me.mednotetb.Name = "mednotetb"
        Me.mednotetb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mednotetb.PlaceholderText = ""
        Me.mednotetb.SelectedText = ""
        Me.mednotetb.ShadowDecoration.Parent = Me.mednotetb
        Me.mednotetb.Size = New System.Drawing.Size(655, 72)
        Me.mednotetb.TabIndex = 12
        Me.mednotetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(249, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "الجرعة اليومية"
        '
        'meddailydosetb
        '
        Me.meddailydosetb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.meddailydosetb.DefaultText = ""
        Me.meddailydosetb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.meddailydosetb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.meddailydosetb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.meddailydosetb.DisabledState.Parent = Me.meddailydosetb
        Me.meddailydosetb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.meddailydosetb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.meddailydosetb.FocusedState.Parent = Me.meddailydosetb
        Me.meddailydosetb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.meddailydosetb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.meddailydosetb.HoverState.Parent = Me.meddailydosetb
        Me.meddailydosetb.Location = New System.Drawing.Point(136, 185)
        Me.meddailydosetb.Name = "meddailydosetb"
        Me.meddailydosetb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.meddailydosetb.PlaceholderText = ""
        Me.meddailydosetb.SelectedText = ""
        Me.meddailydosetb.ShadowDecoration.Parent = Me.meddailydosetb
        Me.meddailydosetb.Size = New System.Drawing.Size(195, 35)
        Me.meddailydosetb.TabIndex = 14
        '
        'addrecb
        '
        Me.addrecb.CheckedState.Parent = Me.addrecb
        Me.addrecb.CustomImages.Parent = Me.addrecb
        Me.addrecb.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addrecb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addrecb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addrecb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addrecb.DisabledState.Parent = Me.addrecb
        Me.addrecb.FillColor = System.Drawing.Color.Maroon
        Me.addrecb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addrecb.ForeColor = System.Drawing.Color.White
        Me.addrecb.HoverState.Parent = Me.addrecb
        Me.addrecb.Location = New System.Drawing.Point(363, 35)
        Me.addrecb.Name = "addrecb"
        Me.addrecb.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.addrecb.ShadowDecoration.Parent = Me.addrecb
        Me.addrecb.Size = New System.Drawing.Size(77, 35)
        Me.addrecb.TabIndex = 16
        Me.addrecb.Text = "اضافة "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(664, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "جرعة الدواء"
        '
        'meddosetb
        '
        Me.meddosetb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.meddosetb.DefaultText = ""
        Me.meddosetb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.meddosetb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.meddosetb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.meddosetb.DisabledState.Parent = Me.meddosetb
        Me.meddosetb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.meddosetb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.meddosetb.FocusedState.Parent = Me.meddosetb
        Me.meddosetb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.meddosetb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.meddosetb.HoverState.Parent = Me.meddosetb
        Me.meddosetb.Location = New System.Drawing.Point(538, 185)
        Me.meddosetb.Name = "meddosetb"
        Me.meddosetb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.meddosetb.PlaceholderText = ""
        Me.meddosetb.SelectedText = ""
        Me.meddosetb.ShadowDecoration.Parent = Me.meddosetb
        Me.meddosetb.Size = New System.Drawing.Size(195, 35)
        Me.meddosetb.TabIndex = 17
        '
        'showrecb
        '
        Me.showrecb.CheckedState.Parent = Me.showrecb
        Me.showrecb.CustomImages.Parent = Me.showrecb
        Me.showrecb.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.showrecb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.showrecb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.showrecb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.showrecb.DisabledState.Parent = Me.showrecb
        Me.showrecb.FillColor = System.Drawing.Color.Maroon
        Me.showrecb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.showrecb.ForeColor = System.Drawing.Color.White
        Me.showrecb.HoverState.Parent = Me.showrecb
        Me.showrecb.Location = New System.Drawing.Point(280, 35)
        Me.showrecb.Name = "showrecb"
        Me.showrecb.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.showrecb.ShadowDecoration.Parent = Me.showrecb
        Me.showrecb.Size = New System.Drawing.Size(77, 35)
        Me.showrecb.TabIndex = 19
        Me.showrecb.Text = "عرض الوصفات"
        '
        'receiptForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(754, 530)
        Me.Controls.Add(Me.showrecb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.meddosetb)
        Me.Controls.Add(Me.addrecb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.meddailydosetb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mednotetb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.medamounttb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.patnametb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mednametb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.residtb)
        Me.Controls.Add(Me.medsearchb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mednamsearchetb)
        Me.Controls.Add(Me.dgv1)
        Me.Name = "receiptForm"
        Me.Text = "receiptForm"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents mednamsearchetb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents medsearchb As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents residtb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mednametb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents patnametb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents medamounttb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents mednotetb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents meddailydosetb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents addrecb As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Label8 As Label
    Friend WithEvents meddosetb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents showrecb As Guna.UI2.WinForms.Guna2CircleButton
End Class
