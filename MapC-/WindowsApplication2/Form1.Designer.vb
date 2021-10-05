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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.myMap = New GMap.NET.WindowsForms.GMapControl()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.clear_BTN = New System.Windows.Forms.Button()
        Me.Timer_LBL = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.COMport_LBL = New System.Windows.Forms.Label()
        Me.comPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.connect_BTN = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tracking = New System.Windows.Forms.Button()
        Me.TextLAT = New System.Windows.Forms.RichTextBox()
        Me.TextLON = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Checklast = New System.Windows.Forms.Button()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NgườiDùngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrạngTháiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VịTríToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocaationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'myMap
        '
        Me.myMap.Bearing = 0!
        Me.myMap.CanDragMap = True
        Me.myMap.EmptyTileColor = System.Drawing.Color.Navy
        Me.myMap.GrayScaleMode = False
        Me.myMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.myMap.LevelsKeepInMemmory = 5
        Me.myMap.Location = New System.Drawing.Point(32, 76)
        Me.myMap.MarkersEnabled = True
        Me.myMap.MaxZoom = 2
        Me.myMap.MinZoom = 2
        Me.myMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.myMap.Name = "myMap"
        Me.myMap.NegativeMode = False
        Me.myMap.PolygonsEnabled = True
        Me.myMap.RetryLoadTile = 0
        Me.myMap.RoutesEnabled = True
        Me.myMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.myMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.myMap.ShowTileGridLines = False
        Me.myMap.Size = New System.Drawing.Size(441, 398)
        Me.myMap.TabIndex = 1
        Me.myMap.Zoom = 0R
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(513, 538)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(75, 23)
        Me.btnMove.TabIndex = 2
        Me.btnMove.Text = "Button1"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'tmr1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.clear_BTN)
        Me.GroupBox1.Controls.Add(Me.Timer_LBL)
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.COMport_LBL)
        Me.GroupBox1.Controls.Add(Me.comPort_ComboBox)
        Me.GroupBox1.Controls.Add(Me.connect_BTN)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(330, 499)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Khối Connect"
        '
        'clear_BTN
        '
        Me.clear_BTN.Location = New System.Drawing.Point(9, 96)
        Me.clear_BTN.Name = "clear_BTN"
        Me.clear_BTN.Size = New System.Drawing.Size(75, 23)
        Me.clear_BTN.TabIndex = 28
        Me.clear_BTN.Text = "CLEAR"
        Me.clear_BTN.UseVisualStyleBackColor = True
        '
        'Timer_LBL
        '
        Me.Timer_LBL.AutoSize = True
        Me.Timer_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer_LBL.Location = New System.Drawing.Point(176, 20)
        Me.Timer_LBL.Name = "Timer_LBL"
        Me.Timer_LBL.Size = New System.Drawing.Size(88, 20)
        Me.Timer_LBL.TabIndex = 31
        Me.Timer_LBL.Text = "Timer: OFF"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.InfoText
        Me.RichTextBox1.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 128)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(322, 366)
        Me.RichTextBox1.TabIndex = 30
        Me.RichTextBox1.Text = ""
        '
        'COMport_LBL
        '
        Me.COMport_LBL.AutoSize = True
        Me.COMport_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMport_LBL.Location = New System.Drawing.Point(5, 24)
        Me.COMport_LBL.Name = "COMport_LBL"
        Me.COMport_LBL.Size = New System.Drawing.Size(92, 20)
        Me.COMport_LBL.TabIndex = 25
        Me.COMport_LBL.Text = "COM PORT"
        '
        'comPort_ComboBox
        '
        Me.comPort_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPort_ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comPort_ComboBox.FormattingEnabled = True
        Me.comPort_ComboBox.Location = New System.Drawing.Point(5, 48)
        Me.comPort_ComboBox.Name = "comPort_ComboBox"
        Me.comPort_ComboBox.Size = New System.Drawing.Size(161, 28)
        Me.comPort_ComboBox.TabIndex = 26
        '
        'connect_BTN
        '
        Me.connect_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect_BTN.Location = New System.Drawing.Point(171, 46)
        Me.connect_BTN.Name = "connect_BTN"
        Me.connect_BTN.Size = New System.Drawing.Size(144, 28)
        Me.connect_BTN.TabIndex = 27
        Me.connect_BTN.Text = "Connect"
        Me.connect_BTN.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Tracking
        '
        Me.Tracking.Location = New System.Drawing.Point(358, 20)
        Me.Tracking.Margin = New System.Windows.Forms.Padding(2)
        Me.Tracking.Name = "Tracking"
        Me.Tracking.Size = New System.Drawing.Size(115, 32)
        Me.Tracking.TabIndex = 7
        Me.Tracking.Text = "Tracking"
        Me.Tracking.UseVisualStyleBackColor = True
        '
        'TextLAT
        '
        Me.TextLAT.BackColor = System.Drawing.SystemColors.Info
        Me.TextLAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLAT.Location = New System.Drawing.Point(83, 18)
        Me.TextLAT.Name = "TextLAT"
        Me.TextLAT.Size = New System.Drawing.Size(132, 34)
        Me.TextLAT.TabIndex = 32
        Me.TextLAT.Text = ""
        '
        'TextLON
        '
        Me.TextLON.BackColor = System.Drawing.SystemColors.Info
        Me.TextLON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLON.Location = New System.Drawing.Point(221, 18)
        Me.TextLON.Name = "TextLON"
        Me.TextLON.Size = New System.Drawing.Size(132, 34)
        Me.TextLON.TabIndex = 33
        Me.TextLON.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.InfoText
        Me.RichTextBox2.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.Color.White
        Me.RichTextBox2.Location = New System.Drawing.Point(26, 44)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(189, 43)
        Me.RichTextBox2.TabIndex = 32
        Me.RichTextBox2.Text = ""
        '
        'Checklast
        '
        Me.Checklast.Location = New System.Drawing.Point(26, 15)
        Me.Checklast.Name = "Checklast"
        Me.Checklast.Size = New System.Drawing.Size(75, 23)
        Me.Checklast.TabIndex = 34
        Me.Checklast.Text = "KIỂM TRA"
        Me.Checklast.UseVisualStyleBackColor = True
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.SystemColors.InfoText
        Me.RichTextBox3.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.ForeColor = System.Drawing.Color.White
        Me.RichTextBox3.Location = New System.Drawing.Point(26, 93)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(189, 43)
        Me.RichTextBox3.TabIndex = 35
        Me.RichTextBox3.Text = ""
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BackColor = System.Drawing.SystemColors.InfoText
        Me.RichTextBox4.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox4.ForeColor = System.Drawing.Color.White
        Me.RichTextBox4.Location = New System.Drawing.Point(26, 142)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.Size = New System.Drawing.Size(189, 43)
        Me.RichTextBox4.TabIndex = 36
        Me.RichTextBox4.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "KIỂM TRA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MenuStrip1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(345, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 100)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Khối User"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NgườiDùngToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(223, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NgườiDùngToolStripMenuItem
        '
        Me.NgườiDùngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TênToolStripMenuItem, Me.TrạngTháiToolStripMenuItem, Me.VịTríToolStripMenuItem, Me.LocaationToolStripMenuItem})
        Me.NgườiDùngToolStripMenuItem.Name = "NgườiDùngToolStripMenuItem"
        Me.NgườiDùngToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.NgườiDùngToolStripMenuItem.Text = "Người dùng"
        '
        'TênToolStripMenuItem
        '
        Me.TênToolStripMenuItem.Image = CType(resources.GetObject("TênToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TênToolStripMenuItem.Name = "TênToolStripMenuItem"
        Me.TênToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TênToolStripMenuItem.Text = "New User "
        '
        'TrạngTháiToolStripMenuItem
        '
        Me.TrạngTháiToolStripMenuItem.Image = CType(resources.GetObject("TrạngTháiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TrạngTháiToolStripMenuItem.Name = "TrạngTháiToolStripMenuItem"
        Me.TrạngTháiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TrạngTháiToolStripMenuItem.Text = "Open User"
        '
        'VịTríToolStripMenuItem
        '
        Me.VịTríToolStripMenuItem.Image = CType(resources.GetObject("VịTríToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VịTríToolStripMenuItem.Name = "VịTríToolStripMenuItem"
        Me.VịTríToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VịTríToolStripMenuItem.Text = "Edit User"
        '
        'LocaationToolStripMenuItem
        '
        Me.LocaationToolStripMenuItem.Image = CType(resources.GetObject("LocaationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LocaationToolStripMenuItem.Name = "LocaationToolStripMenuItem"
        Me.LocaationToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LocaationToolStripMenuItem.Text = "Del User"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.myMap)
        Me.GroupBox3.Controls.Add(Me.Tracking)
        Me.GroupBox3.Controls.Add(Me.TextLAT)
        Me.GroupBox3.Controls.Add(Me.TextLON)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(603, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(492, 495)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Khối Map"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.RichTextBox2)
        Me.GroupBox4.Controls.Add(Me.Checklast)
        Me.GroupBox4.Controls.Add(Me.RichTextBox3)
        Me.GroupBox4.Controls.Add(Me.RichTextBox4)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(344, 270)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(230, 231)
        Me.GroupBox4.TabIndex = 40
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Khối kiểm tra"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1139, 587)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnMove)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Phần Mềm Theo Dõi Khách Du Lịch - Nguyễn Đức Bắc"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents myMap As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents btnMove As System.Windows.Forms.Button
    Friend WithEvents tmr1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer_LBL As Label
    Friend WithEvents comPort_ComboBox As ComboBox
    Friend WithEvents COMport_LBL As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents clear_BTN As Button
    Friend WithEvents connect_BTN As Button
    Friend WithEvents Tracking As Button
    Friend WithEvents TextLAT As RichTextBox
    Friend WithEvents TextLON As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Checklast As Button
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NgườiDùngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TênToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrạngTháiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VịTríToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocaationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
