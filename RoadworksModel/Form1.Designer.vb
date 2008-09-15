<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Tabs = New System.Windows.Forms.TabControl
        Me.TabRun = New System.Windows.Forms.TabPage
        Me.time = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.timetype = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.RunStp = New System.Windows.Forms.Button
        Me.RunRun = New System.Windows.Forms.Button
        Me.Label24 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CarsRight = New System.Windows.Forms.ProgressBar
        Me.Label25 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CarsLeft = New System.Windows.Forms.ProgressBar
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.RightGreen = New System.Windows.Forms.Label
        Me.RightRed = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.LeftGreen = New System.Windows.Forms.Label
        Me.LeftRed = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.SetTab = New System.Windows.Forms.TabPage
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.FrstCar = New System.Windows.Forms.NumericUpDown
        Me.RunTime = New System.Windows.Forms.NumericUpDown
        Me.ClearTime = New System.Windows.Forms.NumericUpDown
        Me.CarBox = New System.Windows.Forms.NumericUpDown
        Me.LFTTMR = New System.Windows.Forms.Timer(Me.components)
        Me.RGTTMR = New System.Windows.Forms.Timer(Me.components)
        Me.Tabs.SuspendLayout()
        Me.TabRun.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SetTab.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.FrstCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RunTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClearTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.TabRun)
        Me.Tabs.Controls.Add(Me.SetTab)
        Me.Tabs.Location = New System.Drawing.Point(12, 12)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(851, 274)
        Me.Tabs.TabIndex = 0
        '
        'TabRun
        '
        Me.TabRun.Controls.Add(Me.time)
        Me.TabRun.Controls.Add(Me.Label3)
        Me.TabRun.Controls.Add(Me.timetype)
        Me.TabRun.Controls.Add(Me.Label1)
        Me.TabRun.Controls.Add(Me.Button1)
        Me.TabRun.Controls.Add(Me.RunStp)
        Me.TabRun.Controls.Add(Me.RunRun)
        Me.TabRun.Controls.Add(Me.Label24)
        Me.TabRun.Controls.Add(Me.Panel1)
        Me.TabRun.Controls.Add(Me.Label17)
        Me.TabRun.Location = New System.Drawing.Point(4, 22)
        Me.TabRun.Name = "TabRun"
        Me.TabRun.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRun.Size = New System.Drawing.Size(843, 248)
        Me.TabRun.TabIndex = 0
        Me.TabRun.Text = "RUN"
        Me.TabRun.UseVisualStyleBackColor = True
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.Location = New System.Drawing.Point(312, 19)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(13, 13)
        Me.time.TabIndex = 28
        Me.time.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(272, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Time:"
        '
        'timetype
        '
        Me.timetype.AutoSize = True
        Me.timetype.Location = New System.Drawing.Point(331, 6)
        Me.timetype.Name = "timetype"
        Me.timetype.Size = New System.Drawing.Size(25, 13)
        Me.timetype.TabIndex = 26
        Me.timetype.Text = "rr(g)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Time type:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(362, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "RESET"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RunStp
        '
        Me.RunStp.Location = New System.Drawing.Point(362, 35)
        Me.RunStp.Name = "RunStp"
        Me.RunStp.Size = New System.Drawing.Size(76, 23)
        Me.RunStp.TabIndex = 23
        Me.RunStp.Text = "STOP"
        Me.RunStp.UseVisualStyleBackColor = True
        '
        'RunRun
        '
        Me.RunRun.Location = New System.Drawing.Point(362, 6)
        Me.RunRun.Name = "RunRun"
        Me.RunRun.Size = New System.Drawing.Size(76, 23)
        Me.RunRun.TabIndex = 22
        Me.RunRun.Text = "RUN"
        Me.RunRun.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(700, 6)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(137, 13)
        Me.Label24.TabIndex = 21
        Me.Label24.Text = "Random Number Generator"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.CarsRight)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.CarsLeft)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Location = New System.Drawing.Point(3, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(835, 151)
        Me.Panel1.TabIndex = 19
        '
        'CarsRight
        '
        Me.CarsRight.ForeColor = System.Drawing.Color.Red
        Me.CarsRight.Location = New System.Drawing.Point(572, 105)
        Me.CarsRight.Maximum = 18
        Me.CarsRight.Name = "CarsRight"
        Me.CarsRight.Size = New System.Drawing.Size(256, 22)
        Me.CarsRight.Step = 1
        Me.CarsRight.TabIndex = 25
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label25.ImageKey = "RoadworksaheadMedium.gif"
        Me.Label25.ImageList = Me.ImageList1
        Me.Label25.Location = New System.Drawing.Point(356, 79)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(79, 78)
        Me.Label25.TabIndex = 22
        Me.Label25.Text = "##----------####" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "RoadworksaheadMedium.gif")
        '
        'CarsLeft
        '
        Me.CarsLeft.ForeColor = System.Drawing.Color.Red
        Me.CarsLeft.Location = New System.Drawing.Point(13, 24)
        Me.CarsLeft.Maximum = 18
        Me.CarsLeft.Name = "CarsLeft"
        Me.CarsLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CarsLeft.RightToLeftLayout = True
        Me.CarsLeft.Size = New System.Drawing.Size(256, 22)
        Me.CarsLeft.Step = 1
        Me.CarsLeft.TabIndex = 24
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.RightGreen)
        Me.Panel5.Controls.Add(Me.RightRed)
        Me.Panel5.Location = New System.Drawing.Point(541, 117)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(21, 31)
        Me.Panel5.TabIndex = 25
        '
        'RightGreen
        '
        Me.RightGreen.AutoSize = True
        Me.RightGreen.BackColor = System.Drawing.Color.Green
        Me.RightGreen.Location = New System.Drawing.Point(3, 14)
        Me.RightGreen.Name = "RightGreen"
        Me.RightGreen.Size = New System.Drawing.Size(15, 13)
        Me.RightGreen.TabIndex = 23
        Me.RightGreen.Text = "G"
        Me.RightGreen.Visible = False
        '
        'RightRed
        '
        Me.RightRed.AutoSize = True
        Me.RightRed.BackColor = System.Drawing.Color.Red
        Me.RightRed.Location = New System.Drawing.Point(3, 0)
        Me.RightRed.Name = "RightRed"
        Me.RightRed.Size = New System.Drawing.Size(15, 13)
        Me.RightRed.TabIndex = 21
        Me.RightRed.Text = "R"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.LeftGreen)
        Me.Panel4.Controls.Add(Me.LeftRed)
        Me.Panel4.Location = New System.Drawing.Point(281, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(21, 31)
        Me.Panel4.TabIndex = 24
        '
        'LeftGreen
        '
        Me.LeftGreen.AutoSize = True
        Me.LeftGreen.BackColor = System.Drawing.Color.Green
        Me.LeftGreen.Location = New System.Drawing.Point(3, 14)
        Me.LeftGreen.Name = "LeftGreen"
        Me.LeftGreen.Size = New System.Drawing.Size(15, 13)
        Me.LeftGreen.TabIndex = 23
        Me.LeftGreen.Text = "G"
        Me.LeftGreen.Visible = False
        '
        'LeftRed
        '
        Me.LeftRed.AutoSize = True
        Me.LeftRed.BackColor = System.Drawing.Color.Red
        Me.LeftRed.Location = New System.Drawing.Point(3, 0)
        Me.LeftRed.Name = "LeftRed"
        Me.LeftRed.Size = New System.Drawing.Size(15, 13)
        Me.LeftRed.TabIndex = 21
        Me.LeftRed.Text = "R"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(137, 13)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Random Number Generator"
        '
        'SetTab
        '
        Me.SetTab.Controls.Add(Me.SplitContainer1)
        Me.SetTab.Location = New System.Drawing.Point(4, 22)
        Me.SetTab.Name = "SetTab"
        Me.SetTab.Padding = New System.Windows.Forms.Padding(3)
        Me.SetTab.Size = New System.Drawing.Size(843, 248)
        Me.SetTab.TabIndex = 1
        Me.SetTab.Text = "Setup"
        Me.SetTab.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(6, 6)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label26)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FrstCar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RunTime)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ClearTime)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CarBox)
        Me.SplitContainer1.Size = New System.Drawing.Size(831, 236)
        Me.SplitContainer1.SplitterDistance = 109
        Me.SplitContainer1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "First car set off time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Run Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Clear Time"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(3, 5)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 13)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Car Value"
        '
        'FrstCar
        '
        Me.FrstCar.Location = New System.Drawing.Point(3, 81)
        Me.FrstCar.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.FrstCar.Name = "FrstCar"
        Me.FrstCar.Size = New System.Drawing.Size(50, 20)
        Me.FrstCar.TabIndex = 4
        Me.FrstCar.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.FrstCar.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'RunTime
        '
        Me.RunTime.Location = New System.Drawing.Point(3, 55)
        Me.RunTime.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.RunTime.Name = "RunTime"
        Me.RunTime.Size = New System.Drawing.Size(50, 20)
        Me.RunTime.TabIndex = 3
        Me.RunTime.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.RunTime.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'ClearTime
        '
        Me.ClearTime.Location = New System.Drawing.Point(3, 29)
        Me.ClearTime.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.ClearTime.Name = "ClearTime"
        Me.ClearTime.Size = New System.Drawing.Size(50, 20)
        Me.ClearTime.TabIndex = 2
        Me.ClearTime.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.ClearTime.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'CarBox
        '
        Me.CarBox.Location = New System.Drawing.Point(3, 3)
        Me.CarBox.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.CarBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CarBox.Name = "CarBox"
        Me.CarBox.Size = New System.Drawing.Size(35, 20)
        Me.CarBox.TabIndex = 1
        Me.CarBox.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.CarBox.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'LFTTMR
        '
        Me.LFTTMR.Interval = 999
        '
        'RGTTMR
        '
        Me.RGTTMR.Interval = 999
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 298)
        Me.Controls.Add(Me.Tabs)
        Me.Name = "Form1"
        Me.Text = "Roadworks Queue generator"
        Me.Tabs.ResumeLayout(False)
        Me.TabRun.ResumeLayout(False)
        Me.TabRun.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.SetTab.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.FrstCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RunTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClearTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tabs As System.Windows.Forms.TabControl
    Friend WithEvents TabRun As System.Windows.Forms.TabPage
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LFTTMR As System.Windows.Forms.Timer
    Friend WithEvents RGTTMR As System.Windows.Forms.Timer
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SetTab As System.Windows.Forms.TabPage
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents CarBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents RunStp As System.Windows.Forms.Button
    Friend WithEvents RunRun As System.Windows.Forms.Button
    Friend WithEvents CarsLeft As System.Windows.Forms.ProgressBar
    Friend WithEvents CarsRight As System.Windows.Forms.ProgressBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents RightGreen As System.Windows.Forms.Label
    Friend WithEvents RightRed As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LeftGreen As System.Windows.Forms.Label
    Friend WithEvents LeftRed As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents timetype As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents time As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ClearTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RunTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FrstCar As System.Windows.Forms.NumericUpDown

End Class
