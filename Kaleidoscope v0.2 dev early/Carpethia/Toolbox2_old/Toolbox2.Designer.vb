'
' Created by SharpDevelop.
' User: Blaster
' Date: 2012.12.08.
' Time: 19:11
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class Toolbox2
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Toolbox2))
		Me.numericUpDown_peaks = New System.Windows.Forms.NumericUpDown()
		Me.label2 = New System.Windows.Forms.Label()
		Me.numericUp_radius = New System.Windows.Forms.NumericUpDown()
		Me.label3 = New System.Windows.Forms.Label()
		Me.cb_innercircle = New System.Windows.Forms.CheckBox()
		CType(Me.numericUpDown_peaks,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.numericUp_radius,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'numericUpDown_peaks
		'
		resources.ApplyResources(Me.numericUpDown_peaks, "numericUpDown_peaks")
		Me.numericUpDown_peaks.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
		Me.numericUpDown_peaks.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numericUpDown_peaks.Name = "numericUpDown_peaks"
		Me.numericUpDown_peaks.Value = New Decimal(New Integer() {4, 0, 0, 0})
		AddHandler Me.numericUpDown_peaks.ValueChanged, AddressOf Me.NumericUpDown_ringsValueChanged
		'
		'label2
		'
		resources.ApplyResources(Me.label2, "label2")
		Me.label2.Name = "label2"
		'
		'numericUp_radius
		'
		resources.ApplyResources(Me.numericUp_radius, "numericUp_radius")
		Me.numericUp_radius.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
		Me.numericUp_radius.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
		Me.numericUp_radius.Name = "numericUp_radius"
		Me.numericUp_radius.Value = New Decimal(New Integer() {200, 0, 0, 0})
		AddHandler Me.numericUp_radius.ValueChanged, AddressOf Me.NumericUpDown_minimumValueChanged
		'
		'label3
		'
		resources.ApplyResources(Me.label3, "label3")
		Me.label3.Name = "label3"
		'
		'cb_innercircle
		'
		resources.ApplyResources(Me.cb_innercircle, "cb_innercircle")
		Me.cb_innercircle.Name = "cb_innercircle"
		Me.cb_innercircle.UseVisualStyleBackColor = true
		'
		'Toolbox2
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.cb_innercircle)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.numericUp_radius)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.numericUpDown_peaks)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "Toolbox2"
		Me.ShowInTaskbar = false
		Me.TopMost = true
		AddHandler Load, AddressOf Me.Toolbox2Load
		CType(Me.numericUpDown_peaks,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.numericUp_radius,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private cb_innercircle As System.Windows.Forms.CheckBox
	Private label3 As System.Windows.Forms.Label
	Private numericUp_radius As System.Windows.Forms.NumericUpDown
	Private label2 As System.Windows.Forms.Label
	Private numericUpDown_peaks As System.Windows.Forms.NumericUpDown
End Class
