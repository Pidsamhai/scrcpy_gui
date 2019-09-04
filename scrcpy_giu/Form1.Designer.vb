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
        Me.top_pa = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.lblStat = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbBitrate = New MetroFramework.Controls.MetroComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkScreen_Off = New MaterialSkin.Controls.MaterialCheckBox()
        Me.m_Wireless = New MaterialSkin.Controls.MaterialRadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.m_USB = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.grpbHome = New System.Windows.Forms.GroupBox()
        Me.cmbCrop = New MetroFramework.Controls.MetroComboBox()
        Me.chkCrop = New MaterialSkin.Controls.MaterialCheckBox()
        Me.chkOntop = New MaterialSkin.Controls.MaterialCheckBox()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.Setting = New MetroFramework.Controls.MetroTabPage()
        Me.btnKill = New System.Windows.Forms.Button()
        Me.Howto = New MetroFramework.Controls.MetroTabPage()
        Me.dgvShortCuts = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.About = New MetroFramework.Controls.MetroTabPage()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Lblmygit = New MaterialSkin.Controls.MaterialLabel()
        Me.Lblsource = New MaterialSkin.Controls.MaterialLabel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Scrcpy = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ctxTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnRec = New System.Windows.Forms.Button()
        Me.top_pa.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpbHome.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.Setting.SuspendLayout()
        Me.Howto.SuspendLayout()
        CType(Me.dgvShortCuts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.About.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxTray.SuspendLayout()
        Me.SuspendLayout()
        '
        'top_pa
        '
        Me.top_pa.BackColor = System.Drawing.Color.DodgerBlue
        Me.top_pa.Controls.Add(Me.btnMinimize)
        Me.top_pa.Controls.Add(Me.lblStat)
        Me.top_pa.Controls.Add(Me.Button1)
        Me.top_pa.Location = New System.Drawing.Point(0, 0)
        Me.top_pa.Name = "top_pa"
        Me.top_pa.Size = New System.Drawing.Size(545, 28)
        Me.top_pa.TabIndex = 0
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Yellow
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.ForeColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Location = New System.Drawing.Point(508, 8)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(11, 13)
        Me.btnMinimize.TabIndex = 3
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'lblStat
        '
        Me.lblStat.AutoSize = True
        Me.lblStat.Location = New System.Drawing.Point(172, 8)
        Me.lblStat.Name = "lblStat"
        Me.lblStat.Size = New System.Drawing.Size(0, 13)
        Me.lblStat.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(524, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(11, 13)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmbBitrate
        '
        Me.cmbBitrate.FormattingEnabled = True
        Me.cmbBitrate.ItemHeight = 23
        Me.cmbBitrate.Items.AddRange(New Object() {"1MB", "2MB", "4MB", "6MB", "8MB", "10MB"})
        Me.cmbBitrate.Location = New System.Drawing.Point(243, 35)
        Me.cmbBitrate.Name = "cmbBitrate"
        Me.cmbBitrate.Size = New System.Drawing.Size(121, 29)
        Me.cmbBitrate.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Bitrate"
        '
        'chkScreen_Off
        '
        Me.chkScreen_Off.AutoSize = True
        Me.chkScreen_Off.Depth = 0
        Me.chkScreen_Off.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkScreen_Off.Location = New System.Drawing.Point(153, 85)
        Me.chkScreen_Off.Margin = New System.Windows.Forms.Padding(0)
        Me.chkScreen_Off.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkScreen_Off.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkScreen_Off.Name = "chkScreen_Off"
        Me.chkScreen_Off.Ripple = True
        Me.chkScreen_Off.Size = New System.Drawing.Size(95, 30)
        Me.chkScreen_Off.TabIndex = 6
        Me.chkScreen_Off.Text = "Screen Off"
        Me.chkScreen_Off.UseVisualStyleBackColor = True
        '
        'm_Wireless
        '
        Me.m_Wireless.AutoSize = True
        Me.m_Wireless.Depth = 0
        Me.m_Wireless.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.m_Wireless.Location = New System.Drawing.Point(17, 59)
        Me.m_Wireless.Margin = New System.Windows.Forms.Padding(0)
        Me.m_Wireless.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.m_Wireless.MouseState = MaterialSkin.MouseState.HOVER
        Me.m_Wireless.Name = "m_Wireless"
        Me.m_Wireless.Ripple = True
        Me.m_Wireless.Size = New System.Drawing.Size(82, 30)
        Me.m_Wireless.TabIndex = 7
        Me.m_Wireless.TabStop = True
        Me.m_Wireless.Text = "Wireless"
        Me.m_Wireless.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.m_USB)
        Me.GroupBox1.Controls.Add(Me.m_Wireless)
        Me.GroupBox1.Location = New System.Drawing.Point(153, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mode"
        '
        'm_USB
        '
        Me.m_USB.AutoSize = True
        Me.m_USB.Depth = 0
        Me.m_USB.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.m_USB.Location = New System.Drawing.Point(17, 29)
        Me.m_USB.Margin = New System.Windows.Forms.Padding(0)
        Me.m_USB.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.m_USB.MouseState = MaterialSkin.MouseState.HOVER
        Me.m_USB.Name = "m_USB"
        Me.m_USB.Ripple = True
        Me.m_USB.Size = New System.Drawing.Size(55, 30)
        Me.m_USB.TabIndex = 9
        Me.m_USB.TabStop = True
        Me.m_USB.Text = "USB"
        Me.m_USB.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConnect.Location = New System.Drawing.Point(104, 314)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(147, 51)
        Me.btnConnect.TabIndex = 9
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'grpbHome
        '
        Me.grpbHome.BackColor = System.Drawing.Color.White
        Me.grpbHome.Controls.Add(Me.cmbCrop)
        Me.grpbHome.Controls.Add(Me.chkCrop)
        Me.grpbHome.Controls.Add(Me.chkOntop)
        Me.grpbHome.Controls.Add(Me.cmbBitrate)
        Me.grpbHome.Controls.Add(Me.Label1)
        Me.grpbHome.Controls.Add(Me.GroupBox1)
        Me.grpbHome.Controls.Add(Me.chkScreen_Off)
        Me.grpbHome.Location = New System.Drawing.Point(3, 3)
        Me.grpbHome.Name = "grpbHome"
        Me.grpbHome.Size = New System.Drawing.Size(500, 269)
        Me.grpbHome.TabIndex = 10
        Me.grpbHome.TabStop = False
        Me.grpbHome.Text = "Setting"
        '
        'cmbCrop
        '
        Me.cmbCrop.Enabled = False
        Me.cmbCrop.FormattingEnabled = True
        Me.cmbCrop.ItemHeight = 23
        Me.cmbCrop.Items.AddRange(New Object() {"480x800", "640x1136", "720x1280", "750x1334", "1080x1920", "1440x2560"})
        Me.cmbCrop.Location = New System.Drawing.Point(243, 128)
        Me.cmbCrop.Name = "cmbCrop"
        Me.cmbCrop.Size = New System.Drawing.Size(121, 29)
        Me.cmbCrop.TabIndex = 11
        '
        'chkCrop
        '
        Me.chkCrop.AutoSize = True
        Me.chkCrop.Depth = 0
        Me.chkCrop.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkCrop.Location = New System.Drawing.Point(153, 128)
        Me.chkCrop.Margin = New System.Windows.Forms.Padding(0)
        Me.chkCrop.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkCrop.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkCrop.Name = "chkCrop"
        Me.chkCrop.Ripple = True
        Me.chkCrop.Size = New System.Drawing.Size(59, 30)
        Me.chkCrop.TabIndex = 10
        Me.chkCrop.Text = "Crop"
        Me.chkCrop.UseVisualStyleBackColor = True
        '
        'chkOntop
        '
        Me.chkOntop.AutoSize = True
        Me.chkOntop.Depth = 0
        Me.chkOntop.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkOntop.Location = New System.Drawing.Point(269, 85)
        Me.chkOntop.Margin = New System.Windows.Forms.Padding(0)
        Me.chkOntop.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkOntop.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkOntop.Name = "chkOntop"
        Me.chkOntop.Ripple = True
        Me.chkOntop.Size = New System.Drawing.Size(108, 30)
        Me.chkOntop.TabIndex = 9
        Me.chkOntop.Text = "Alway Ontop"
        Me.chkOntop.UseVisualStyleBackColor = True
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.BackColor = System.Drawing.Color.White
        Me.VersionLabel.Enabled = False
        Me.VersionLabel.Location = New System.Drawing.Point(363, 383)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(39, 13)
        Me.VersionLabel.TabIndex = 11
        Me.VersionLabel.Text = "Label2"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.AllowDrop = True
        Me.MetroTabControl1.Controls.Add(Me.Setting)
        Me.MetroTabControl1.Controls.Add(Me.Howto)
        Me.MetroTabControl1.Controls.Add(Me.About)
        Me.MetroTabControl1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MetroTabControl1.Location = New System.Drawing.Point(12, 34)
        Me.MetroTabControl1.Multiline = True
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(520, 435)
        Me.MetroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Pink
        Me.MetroTabControl1.TabIndex = 2
        Me.MetroTabControl1.TabStop = False
        Me.MetroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Setting
        '
        Me.Setting.Controls.Add(Me.btnRec)
        Me.Setting.Controls.Add(Me.btnKill)
        Me.Setting.Controls.Add(Me.VersionLabel)
        Me.Setting.Controls.Add(Me.grpbHome)
        Me.Setting.Controls.Add(Me.btnConnect)
        Me.Setting.HorizontalScrollbarBarColor = True
        Me.Setting.Location = New System.Drawing.Point(4, 35)
        Me.Setting.Name = "Setting"
        Me.Setting.Size = New System.Drawing.Size(512, 396)
        Me.Setting.TabIndex = 0
        Me.Setting.Text = "Setting"
        Me.Setting.VerticalScrollbarBarColor = True
        '
        'btnKill
        '
        Me.btnKill.BackColor = System.Drawing.Color.Red
        Me.btnKill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnKill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKill.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKill.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnKill.Location = New System.Drawing.Point(272, 314)
        Me.btnKill.Name = "btnKill"
        Me.btnKill.Size = New System.Drawing.Size(147, 51)
        Me.btnKill.TabIndex = 12
        Me.btnKill.Text = "Kill adb"
        Me.btnKill.UseVisualStyleBackColor = False
        '
        'Howto
        '
        Me.Howto.Controls.Add(Me.dgvShortCuts)
        Me.Howto.HorizontalScrollbarBarColor = True
        Me.Howto.Location = New System.Drawing.Point(4, 35)
        Me.Howto.Name = "Howto"
        Me.Howto.Size = New System.Drawing.Size(512, 396)
        Me.Howto.TabIndex = 1
        Me.Howto.Text = "Shortcuts"
        Me.Howto.VerticalScrollbarBarColor = True
        '
        'dgvShortCuts
        '
        Me.dgvShortCuts.AllowUserToAddRows = False
        Me.dgvShortCuts.AllowUserToDeleteRows = False
        Me.dgvShortCuts.AllowUserToResizeColumns = False
        Me.dgvShortCuts.AllowUserToResizeRows = False
        Me.dgvShortCuts.BackgroundColor = System.Drawing.Color.White
        Me.dgvShortCuts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvShortCuts.ColumnHeadersHeight = 40
        Me.dgvShortCuts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvShortCuts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvShortCuts.Location = New System.Drawing.Point(2, 3)
        Me.dgvShortCuts.Name = "dgvShortCuts"
        Me.dgvShortCuts.ReadOnly = True
        Me.dgvShortCuts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvShortCuts.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvShortCuts.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvShortCuts.Size = New System.Drawing.Size(507, 397)
        Me.dgvShortCuts.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Action"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Shortcut"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'About
        '
        Me.About.Controls.Add(Me.MaterialLabel1)
        Me.About.Controls.Add(Me.Lblmygit)
        Me.About.Controls.Add(Me.Lblsource)
        Me.About.Controls.Add(Me.PictureBox4)
        Me.About.Controls.Add(Me.PictureBox3)
        Me.About.Controls.Add(Me.PictureBox2)
        Me.About.Controls.Add(Me.PictureBox1)
        Me.About.HorizontalScrollbarBarColor = True
        Me.About.Location = New System.Drawing.Point(4, 35)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(512, 396)
        Me.About.TabIndex = 2
        Me.About.Text = "About"
        Me.About.VerticalScrollbarBarColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.BackColor = System.Drawing.Color.White
        Me.MaterialLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(206, 212)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(151, 18)
        Me.MaterialLabel1.TabIndex = 10
        Me.MaterialLabel1.Text = "My facebook account"
        '
        'Lblmygit
        '
        Me.Lblmygit.AutoSize = True
        Me.Lblmygit.BackColor = System.Drawing.Color.White
        Me.Lblmygit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lblmygit.Depth = 0
        Me.Lblmygit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Lblmygit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblmygit.Location = New System.Drawing.Point(206, 146)
        Me.Lblmygit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Lblmygit.Name = "Lblmygit"
        Me.Lblmygit.Size = New System.Drawing.Size(71, 18)
        Me.Lblmygit.TabIndex = 9
        Me.Lblmygit.Text = "My github"
        '
        'Lblsource
        '
        Me.Lblsource.AutoSize = True
        Me.Lblsource.BackColor = System.Drawing.Color.White
        Me.Lblsource.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lblsource.Depth = 0
        Me.Lblsource.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Lblsource.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblsource.Location = New System.Drawing.Point(206, 275)
        Me.Lblsource.MouseState = MaterialSkin.MouseState.HOVER
        Me.Lblsource.Name = "Lblsource"
        Me.Lblsource.Size = New System.Drawing.Size(151, 18)
        Me.Lblsource.TabIndex = 8
        Me.Lblsource.Text = "Official scrcpy source"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.scrcpy_gui.My.Resources.Resources.github_logo_1_
        Me.PictureBox4.Location = New System.Drawing.Point(139, 257)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.scrcpy_gui.My.Resources.Resources.Inked36928228_LI
        Me.PictureBox3.Location = New System.Drawing.Point(139, 57)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.scrcpy_gui.My.Resources.Resources.facebook_logo_button_1_
        Me.PictureBox2.Location = New System.Drawing.Point(139, 195)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.scrcpy_gui.My.Resources.Resources.github_logo_1_
        Me.PictureBox1.Location = New System.Drawing.Point(139, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Scrcpy
        '
        Me.Scrcpy.ContextMenuStrip = Me.ctxTray
        Me.Scrcpy.Icon = CType(resources.GetObject("Scrcpy.Icon"), System.Drawing.Icon)
        Me.Scrcpy.Text = "Scrcpy"
        '
        'ctxTray
        '
        Me.ctxTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ctxTray.Name = "ctxTray"
        Me.ctxTray.Size = New System.Drawing.Size(94, 26)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BackgroundWorker1
        '
        '
        'btnRec
        '
        Me.btnRec.Location = New System.Drawing.Point(159, 278)
        Me.btnRec.Name = "btnRec"
        Me.btnRec.Size = New System.Drawing.Size(197, 23)
        Me.btnRec.TabIndex = 13
        Me.btnRec.Text = "Record"
        Me.btnRec.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(544, 481)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.top_pa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Scrcpy Gui"
        Me.top_pa.ResumeLayout(False)
        Me.top_pa.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpbHome.ResumeLayout(False)
        Me.grpbHome.PerformLayout()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.Setting.ResumeLayout(False)
        Me.Setting.PerformLayout()
        Me.Howto.ResumeLayout(False)
        CType(Me.dgvShortCuts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.About.ResumeLayout(False)
        Me.About.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxTray.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents top_pa As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbBitrate As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkScreen_Off As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents m_Wireless As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents m_USB As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btnConnect As Button
    Friend WithEvents grpbHome As GroupBox
    Friend WithEvents lblStat As Label
    Friend WithEvents VersionLabel As Label
    Friend WithEvents Setting As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Howto As MetroFramework.Controls.MetroTabPage
    Friend WithEvents About As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents chkOntop As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents chkCrop As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents cmbCrop As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dgvShortCuts As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents btnMinimize As Button
    Public WithEvents Scrcpy As NotifyIcon
    Friend WithEvents ctxTray As ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnKill As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Lblsource As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Lblmygit As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnRec As Button
End Class
