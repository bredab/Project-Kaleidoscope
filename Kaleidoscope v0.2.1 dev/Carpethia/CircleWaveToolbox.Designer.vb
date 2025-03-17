'
' Created by SharpDevelop.
' User: Blaster
' Date: 2012.12.26.
' Time: 17:55
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class CircleWaveToolbox
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CircleWaveToolbox))
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.checkBox_innercircle = New System.Windows.Forms.CheckBox()
		Me.numericUpDown_peaks = New System.Windows.Forms.NumericUpDown()
		Me.numericUpDown_radius = New System.Windows.Forms.NumericUpDown()
		CType(Me.numericUpDown_peaks,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.numericUpDown_radius,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'label1
		'
		resources.ApplyResources(Me.label1, "label1")
		Me.label1.Name = "label1"
		'
		'label2
		'
		resources.ApplyResources(Me.label2, "label2")
		Me.label2.Name = "label2"
		'
		'checkBox_innercircle
		'
		resources.ApplyResources(Me.checkBox_innercircle, "checkBox_innercircle")
		Me.checkBox_innercircle.Name = "checkBox_innercircle"
		Me.checkBox_innercircle.UseVisualStyleBackColor = true
		AddHandler Me.checkBox_innercircle.CheckedChanged, AddressOf Me.CheckBox_innercircleCheckedChanged
		'
		'numericUpDown_peaks
		'
		resources.ApplyResources(Me.numericUpDown_peaks, "numericUpDown_peaks")
		Me.numericUpDown_peaks.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.numericUpDown_peaks.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
		Me.numericUpDown_peaks.Name = "numericUpDown_peaks"
		Me.numericUpDown_peaks.Value = New Decimal(New Integer() {4, 0, 0, 0})
		AddHandler Me.numericUpDown_peaks.ValueChanged, AddressOf Me.NumericUpDown_peaksValueChanged
		'
		'numericUpDown_radius
		'
		resources.ApplyResources(Me.numericUpDown_radius, "numericUpDown_radius")
		Me.numericUpDown_radius.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
		Me.numericUpDown_radius.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
		Me.numericUpDown_radius.Name = "numericUpDown_radius"
		Me.numericUpDown_radius.Value = New Decimal(New Integer() {200, 0, 0, 0})
		AddHandler Me.numericUpDown_radius.ValueChanged, AddressOf Me.NumericUpDown_radiusValueChanged
		'
		'CircleWaveToolbox
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.numericUpDown_radius)
		Me.Controls.Add(Me.numericUpDown_peaks)
		Me.Controls.Add(Me.checkBox_innercircle)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "CircleWaveToolbox"
		Me.TopMost = true
		AddHandler Load, AddressOf Me.CircleWaveToolboxLoad
		CType(Me.numericUpDown_peaks,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.numericUpDown_radius,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private numericUpDown_radius As System.Windows.Forms.NumericUpDown
	Private numericUpDown_peaks As System.Windows.Forms.NumericUpDown
	Private checkBox_innercircle As System.Windows.Forms.CheckBox
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	
End Class
