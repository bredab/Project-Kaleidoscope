'
' Created by SharpDevelop.
' User: Blaster
' Date: 2012.12.11.
' Time: 23:14
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class Toolbox3
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.ud_range3down = New System.Windows.Forms.NumericUpDown()
		Me.ud_range2down = New System.Windows.Forms.NumericUpDown()
		Me.ud_blue = New System.Windows.Forms.NumericUpDown()
		Me.ud_range3up = New System.Windows.Forms.NumericUpDown()
		Me.ud_range2up = New System.Windows.Forms.NumericUpDown()
		Me.ud_range1down = New System.Windows.Forms.NumericUpDown()
		Me.ud_green = New System.Windows.Forms.NumericUpDown()
		Me.ud_range1up = New System.Windows.Forms.NumericUpDown()
		Me.bar_color = New System.Windows.Forms.Panel()
		Me.pn_1up = New System.Windows.Forms.Panel()
		Me.pn_1down = New System.Windows.Forms.Panel()
		Me.pn_2up = New System.Windows.Forms.Panel()
		Me.ud_red = New System.Windows.Forms.NumericUpDown()
		Me.pn_2down = New System.Windows.Forms.Panel()
		Me.pn_3up = New System.Windows.Forms.Panel()
		Me.pn_3down = New System.Windows.Forms.Panel()
		Me.pn_range3 = New System.Windows.Forms.Panel()
		Me.bar_blue = New System.Windows.Forms.Panel()
		Me.tb_blue = New System.Windows.Forms.TrackBar()
		Me.pn_range1 = New System.Windows.Forms.Panel()
		Me.pn_range2 = New System.Windows.Forms.Panel()
		Me.tb_range1down = New System.Windows.Forms.TrackBar()
		Me.tb_range1up = New System.Windows.Forms.TrackBar()
		Me.tb_range2down = New System.Windows.Forms.TrackBar()
		Me.tb_range2up = New System.Windows.Forms.TrackBar()
		Me.bar_green = New System.Windows.Forms.Panel()
		Me.tb_green = New System.Windows.Forms.TrackBar()
		Me.tb_range3down = New System.Windows.Forms.TrackBar()
		Me.tb_range3up = New System.Windows.Forms.TrackBar()
		Me.bar_red = New System.Windows.Forms.Panel()
		Me.tb_red = New System.Windows.Forms.TrackBar()
		CType(Me.ud_range3down,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_range2down,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_blue,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_range3up,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_range2up,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_range1down,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_green,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_range1up,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_red,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tb_blue,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tb_range1down,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tb_range1up,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tb_range2down,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tb_range2up,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tb_green,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tb_range3down,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tb_range3up,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tb_red,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'ud_range3down
		'
		Me.ud_range3down.Location = New System.Drawing.Point(177, 240)
		Me.ud_range3down.Name = "ud_range3down"
		Me.ud_range3down.Size = New System.Drawing.Size(42, 20)
		Me.ud_range3down.TabIndex = 116
		'
		'ud_range2down
		'
		Me.ud_range2down.Location = New System.Drawing.Point(100, 240)
		Me.ud_range2down.Name = "ud_range2down"
		Me.ud_range2down.Size = New System.Drawing.Size(43, 20)
		Me.ud_range2down.TabIndex = 117
		'
		'ud_blue
		'
		Me.ud_blue.Location = New System.Drawing.Point(360, 240)
		Me.ud_blue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.ud_blue.Name = "ud_blue"
		Me.ud_blue.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ud_blue.Size = New System.Drawing.Size(44, 20)
		Me.ud_blue.TabIndex = 114
		Me.ud_blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.ud_blue.Value = New Decimal(New Integer() {200, 0, 0, 0})
		'
		'ud_range3up
		'
		Me.ud_range3up.Location = New System.Drawing.Point(177, 6)
		Me.ud_range3up.Name = "ud_range3up"
		Me.ud_range3up.Size = New System.Drawing.Size(43, 20)
		Me.ud_range3up.TabIndex = 120
		Me.ud_range3up.Value = New Decimal(New Integer() {100, 0, 0, 0})
		'
		'ud_range2up
		'
		Me.ud_range2up.Location = New System.Drawing.Point(100, 6)
		Me.ud_range2up.Name = "ud_range2up"
		Me.ud_range2up.Size = New System.Drawing.Size(40, 20)
		Me.ud_range2up.TabIndex = 119
		Me.ud_range2up.Value = New Decimal(New Integer() {100, 0, 0, 0})
		'
		'ud_range1down
		'
		Me.ud_range1down.Location = New System.Drawing.Point(25, 240)
		Me.ud_range1down.Name = "ud_range1down"
		Me.ud_range1down.Size = New System.Drawing.Size(42, 20)
		Me.ud_range1down.TabIndex = 118
		'
		'ud_green
		'
		Me.ud_green.Location = New System.Drawing.Point(308, 240)
		Me.ud_green.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.ud_green.Name = "ud_green"
		Me.ud_green.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ud_green.Size = New System.Drawing.Size(44, 20)
		Me.ud_green.TabIndex = 113
		Me.ud_green.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.ud_green.Value = New Decimal(New Integer() {200, 0, 0, 0})
		'
		'ud_range1up
		'
		Me.ud_range1up.Location = New System.Drawing.Point(25, 6)
		Me.ud_range1up.Name = "ud_range1up"
		Me.ud_range1up.Size = New System.Drawing.Size(42, 20)
		Me.ud_range1up.TabIndex = 115
		Me.ud_range1up.Value = New Decimal(New Integer() {100, 0, 0, 0})
		'
		'bar_color
		'
		Me.bar_color.BackColor = System.Drawing.Color.Black
		Me.bar_color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.bar_color.Location = New System.Drawing.Point(256, 6)
		Me.bar_color.Name = "bar_color"
		Me.bar_color.Size = New System.Drawing.Size(148, 41)
		Me.bar_color.TabIndex = 111
		'
		'pn_1up
		'
		Me.pn_1up.BackColor = System.Drawing.Color.Black
		Me.pn_1up.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pn_1up.Location = New System.Drawing.Point(25, 30)
		Me.pn_1up.Name = "pn_1up"
		Me.pn_1up.Size = New System.Drawing.Size(42, 17)
		Me.pn_1up.TabIndex = 105
		'
		'pn_1down
		'
		Me.pn_1down.BackColor = System.Drawing.Color.Red
		Me.pn_1down.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pn_1down.Location = New System.Drawing.Point(25, 219)
		Me.pn_1down.Name = "pn_1down"
		Me.pn_1down.Size = New System.Drawing.Size(42, 17)
		Me.pn_1down.TabIndex = 106
		'
		'pn_2up
		'
		Me.pn_2up.BackColor = System.Drawing.Color.Black
		Me.pn_2up.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pn_2up.Location = New System.Drawing.Point(100, 30)
		Me.pn_2up.Name = "pn_2up"
		Me.pn_2up.Size = New System.Drawing.Size(42, 17)
		Me.pn_2up.TabIndex = 107
		'
		'ud_red
		'
		Me.ud_red.Location = New System.Drawing.Point(256, 240)
		Me.ud_red.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.ud_red.Name = "ud_red"
		Me.ud_red.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ud_red.Size = New System.Drawing.Size(44, 20)
		Me.ud_red.TabIndex = 112
		Me.ud_red.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.ud_red.Value = New Decimal(New Integer() {200, 0, 0, 0})
		'
		'pn_2down
		'
		Me.pn_2down.BackColor = System.Drawing.Color.Lime
		Me.pn_2down.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pn_2down.Location = New System.Drawing.Point(100, 219)
		Me.pn_2down.Name = "pn_2down"
		Me.pn_2down.Size = New System.Drawing.Size(42, 17)
		Me.pn_2down.TabIndex = 108
		'
		'pn_3up
		'
		Me.pn_3up.BackColor = System.Drawing.Color.Black
		Me.pn_3up.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pn_3up.Location = New System.Drawing.Point(177, 30)
		Me.pn_3up.Name = "pn_3up"
		Me.pn_3up.Size = New System.Drawing.Size(42, 17)
		Me.pn_3up.TabIndex = 109
		'
		'pn_3down
		'
		Me.pn_3down.BackColor = System.Drawing.Color.Blue
		Me.pn_3down.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pn_3down.Location = New System.Drawing.Point(177, 219)
		Me.pn_3down.Name = "pn_3down"
		Me.pn_3down.Size = New System.Drawing.Size(42, 17)
		Me.pn_3down.TabIndex = 110
		'
		'pn_range3
		'
		Me.pn_range3.BackColor = System.Drawing.Color.Black
		Me.pn_range3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pn_range3.Location = New System.Drawing.Point(190, 53)
		Me.pn_range3.Name = "pn_range3"
		Me.pn_range3.Size = New System.Drawing.Size(17, 160)
		Me.pn_range3.TabIndex = 96
		'
		'bar_blue
		'
		Me.bar_blue.BackColor = System.Drawing.Color.Black
		Me.bar_blue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.bar_blue.Location = New System.Drawing.Point(360, 219)
		Me.bar_blue.Name = "bar_blue"
		Me.bar_blue.Size = New System.Drawing.Size(44, 17)
		Me.bar_blue.TabIndex = 104
		'
		'tb_blue
		'
		Me.tb_blue.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.tb_blue.Location = New System.Drawing.Point(363, 41)
		Me.tb_blue.Maximum = 255
		Me.tb_blue.Name = "tb_blue"
		Me.tb_blue.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.tb_blue.Size = New System.Drawing.Size(45, 180)
		Me.tb_blue.TabIndex = 103
		Me.tb_blue.TickFrequency = 10
		Me.tb_blue.TickStyle = System.Windows.Forms.TickStyle.TopLeft
		Me.tb_blue.Value = 200
		'
		'pn_range1
		'
		Me.pn_range1.BackColor = System.Drawing.Color.Black
		Me.pn_range1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pn_range1.Location = New System.Drawing.Point(37, 53)
		Me.pn_range1.Name = "pn_range1"
		Me.pn_range1.Size = New System.Drawing.Size(17, 160)
		Me.pn_range1.TabIndex = 90
		'
		'pn_range2
		'
		Me.pn_range2.BackColor = System.Drawing.Color.Black
		Me.pn_range2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pn_range2.Location = New System.Drawing.Point(113, 53)
		Me.pn_range2.Name = "pn_range2"
		Me.pn_range2.Size = New System.Drawing.Size(17, 160)
		Me.pn_range2.TabIndex = 93
		'
		'tb_range1down
		'
		Me.tb_range1down.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.tb_range1down.LargeChange = 1
		Me.tb_range1down.Location = New System.Drawing.Point(39, 41)
		Me.tb_range1down.Maximum = 100
		Me.tb_range1down.Name = "tb_range1down"
		Me.tb_range1down.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.tb_range1down.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.tb_range1down.RightToLeftLayout = true
		Me.tb_range1down.Size = New System.Drawing.Size(45, 180)
		Me.tb_range1down.TabIndex = 92
		Me.tb_range1down.TickFrequency = 5
		'
		'tb_range1up
		'
		Me.tb_range1up.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.tb_range1up.LargeChange = 1
		Me.tb_range1up.Location = New System.Drawing.Point(6, 41)
		Me.tb_range1up.Maximum = 100
		Me.tb_range1up.Name = "tb_range1up"
		Me.tb_range1up.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.tb_range1up.Size = New System.Drawing.Size(45, 180)
		Me.tb_range1up.TabIndex = 91
		Me.tb_range1up.TickFrequency = 5
		Me.tb_range1up.Value = 100
		'
		'tb_range2down
		'
		Me.tb_range2down.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.tb_range2down.LargeChange = 1
		Me.tb_range2down.Location = New System.Drawing.Point(115, 41)
		Me.tb_range2down.Maximum = 100
		Me.tb_range2down.Name = "tb_range2down"
		Me.tb_range2down.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.tb_range2down.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.tb_range2down.RightToLeftLayout = true
		Me.tb_range2down.Size = New System.Drawing.Size(45, 180)
		Me.tb_range2down.TabIndex = 95
		Me.tb_range2down.TickFrequency = 5
		'
		'tb_range2up
		'
		Me.tb_range2up.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.tb_range2up.LargeChange = 1
		Me.tb_range2up.Location = New System.Drawing.Point(82, 41)
		Me.tb_range2up.Maximum = 100
		Me.tb_range2up.Name = "tb_range2up"
		Me.tb_range2up.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.tb_range2up.Size = New System.Drawing.Size(45, 180)
		Me.tb_range2up.TabIndex = 94
		Me.tb_range2up.TickFrequency = 5
		Me.tb_range2up.Value = 100
		'
		'bar_green
		'
		Me.bar_green.BackColor = System.Drawing.Color.Black
		Me.bar_green.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.bar_green.Location = New System.Drawing.Point(308, 219)
		Me.bar_green.Name = "bar_green"
		Me.bar_green.Size = New System.Drawing.Size(44, 17)
		Me.bar_green.TabIndex = 102
		'
		'tb_green
		'
		Me.tb_green.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.tb_green.Location = New System.Drawing.Point(311, 41)
		Me.tb_green.Maximum = 255
		Me.tb_green.Name = "tb_green"
		Me.tb_green.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.tb_green.Size = New System.Drawing.Size(45, 180)
		Me.tb_green.TabIndex = 101
		Me.tb_green.TickFrequency = 10
		Me.tb_green.TickStyle = System.Windows.Forms.TickStyle.TopLeft
		Me.tb_green.Value = 200
		'
		'tb_range3down
		'
		Me.tb_range3down.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.tb_range3down.LargeChange = 1
		Me.tb_range3down.Location = New System.Drawing.Point(192, 41)
		Me.tb_range3down.Maximum = 100
		Me.tb_range3down.Name = "tb_range3down"
		Me.tb_range3down.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.tb_range3down.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.tb_range3down.RightToLeftLayout = true
		Me.tb_range3down.Size = New System.Drawing.Size(45, 180)
		Me.tb_range3down.TabIndex = 98
		Me.tb_range3down.TickFrequency = 5
		'
		'tb_range3up
		'
		Me.tb_range3up.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.tb_range3up.LargeChange = 1
		Me.tb_range3up.Location = New System.Drawing.Point(159, 41)
		Me.tb_range3up.Maximum = 100
		Me.tb_range3up.Name = "tb_range3up"
		Me.tb_range3up.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.tb_range3up.Size = New System.Drawing.Size(45, 180)
		Me.tb_range3up.TabIndex = 97
		Me.tb_range3up.TickFrequency = 5
		Me.tb_range3up.Value = 100
		'
		'bar_red
		'
		Me.bar_red.BackColor = System.Drawing.Color.Black
		Me.bar_red.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.bar_red.Location = New System.Drawing.Point(256, 219)
		Me.bar_red.Name = "bar_red"
		Me.bar_red.Size = New System.Drawing.Size(44, 17)
		Me.bar_red.TabIndex = 100
		'
		'tb_red
		'
		Me.tb_red.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.tb_red.Location = New System.Drawing.Point(259, 41)
		Me.tb_red.Maximum = 255
		Me.tb_red.Name = "tb_red"
		Me.tb_red.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.tb_red.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.tb_red.Size = New System.Drawing.Size(45, 180)
		Me.tb_red.TabIndex = 99
		Me.tb_red.TickFrequency = 10
		Me.tb_red.TickStyle = System.Windows.Forms.TickStyle.TopLeft
		Me.tb_red.Value = 200
		'
		'Toolbox3
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(411, 267)
		Me.Controls.Add(Me.ud_range3down)
		Me.Controls.Add(Me.ud_range2down)
		Me.Controls.Add(Me.ud_blue)
		Me.Controls.Add(Me.ud_range3up)
		Me.Controls.Add(Me.ud_range2up)
		Me.Controls.Add(Me.ud_range1down)
		Me.Controls.Add(Me.ud_green)
		Me.Controls.Add(Me.ud_range1up)
		Me.Controls.Add(Me.bar_color)
		Me.Controls.Add(Me.pn_1up)
		Me.Controls.Add(Me.pn_1down)
		Me.Controls.Add(Me.pn_2up)
		Me.Controls.Add(Me.ud_red)
		Me.Controls.Add(Me.pn_2down)
		Me.Controls.Add(Me.pn_3up)
		Me.Controls.Add(Me.pn_3down)
		Me.Controls.Add(Me.pn_range3)
		Me.Controls.Add(Me.bar_blue)
		Me.Controls.Add(Me.tb_blue)
		Me.Controls.Add(Me.pn_range1)
		Me.Controls.Add(Me.pn_range2)
		Me.Controls.Add(Me.tb_range1down)
		Me.Controls.Add(Me.tb_range1up)
		Me.Controls.Add(Me.tb_range2down)
		Me.Controls.Add(Me.tb_range2up)
		Me.Controls.Add(Me.bar_green)
		Me.Controls.Add(Me.tb_green)
		Me.Controls.Add(Me.tb_range3down)
		Me.Controls.Add(Me.tb_range3up)
		Me.Controls.Add(Me.bar_red)
		Me.Controls.Add(Me.tb_red)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "Toolbox3"
		Me.Text = "Color Toolbox"
		CType(Me.ud_range3down,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_range2down,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_blue,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_range3up,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_range2up,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_range1down,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_green,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_range1up,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_red,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tb_blue,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tb_range1down,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tb_range1up,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tb_range2down,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tb_range2up,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tb_green,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tb_range3down,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tb_range3up,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tb_red,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private tb_red As System.Windows.Forms.TrackBar
	Private bar_red As System.Windows.Forms.Panel
	Private tb_range3up As System.Windows.Forms.TrackBar
	Private tb_range3down As System.Windows.Forms.TrackBar
	Private tb_green As System.Windows.Forms.TrackBar
	Private bar_green As System.Windows.Forms.Panel
	Private tb_range2up As System.Windows.Forms.TrackBar
	Private tb_range2down As System.Windows.Forms.TrackBar
	Private tb_range1up As System.Windows.Forms.TrackBar
	Private tb_range1down As System.Windows.Forms.TrackBar
	Private pn_range2 As System.Windows.Forms.Panel
	Private pn_range1 As System.Windows.Forms.Panel
	Private tb_blue As System.Windows.Forms.TrackBar
	Private bar_blue As System.Windows.Forms.Panel
	Private pn_range3 As System.Windows.Forms.Panel
	Private pn_3down As System.Windows.Forms.Panel
	Private pn_3up As System.Windows.Forms.Panel
	Private pn_2down As System.Windows.Forms.Panel
	Private ud_red As System.Windows.Forms.NumericUpDown
	Private pn_2up As System.Windows.Forms.Panel
	Private pn_1down As System.Windows.Forms.Panel
	Private pn_1up As System.Windows.Forms.Panel
	Private bar_color As System.Windows.Forms.Panel
	Private ud_range1up As System.Windows.Forms.NumericUpDown
	Private ud_green As System.Windows.Forms.NumericUpDown
	Private ud_range1down As System.Windows.Forms.NumericUpDown
	Private ud_range2up As System.Windows.Forms.NumericUpDown
	Private ud_range3up As System.Windows.Forms.NumericUpDown
	Private ud_blue As System.Windows.Forms.NumericUpDown
	Private ud_range2down As System.Windows.Forms.NumericUpDown
	Private ud_range3down As System.Windows.Forms.NumericUpDown
End Class
