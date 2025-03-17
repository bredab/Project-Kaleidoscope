﻿'
' Created by SharpDevelop.
' User: Blaster
' Date: 2013.01.17.
' Time: 21:53
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class FlowerShapeToolbox
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlowerShapeToolbox))
		Me.label2 = New System.Windows.Forms.Label()
		Me.numericUpDown_petals = New System.Windows.Forms.NumericUpDown()
		Me.label17 = New System.Windows.Forms.Label()
		Me.label15 = New System.Windows.Forms.Label()
		Me.numericUpDown_rotation = New System.Windows.Forms.NumericUpDown()
		Me.cb_mode1 = New System.Windows.Forms.ComboBox()
		Me.label22 = New System.Windows.Forms.Label()
		Me.cb_mode2 = New System.Windows.Forms.ComboBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.cb_mode3 = New System.Windows.Forms.ComboBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.numericUpDown_cring = New System.Windows.Forms.NumericUpDown()
		CType(Me.numericUpDown_petals,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.numericUpDown_rotation,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.numericUpDown_cring,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'label2
		'
		resources.ApplyResources(Me.label2, "label2")
		Me.label2.Name = "label2"
		'
		'numericUpDown_petals
		'
		resources.ApplyResources(Me.numericUpDown_petals, "numericUpDown_petals")
		Me.numericUpDown_petals.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.numericUpDown_petals.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numericUpDown_petals.Name = "numericUpDown_petals"
		Me.numericUpDown_petals.Value = New Decimal(New Integer() {2, 0, 0, 0})
		AddHandler Me.numericUpDown_petals.ValueChanged, AddressOf Me.NumericUpDown_petalsValueChanged
		'
		'label17
		'
		resources.ApplyResources(Me.label17, "label17")
		Me.label17.Name = "label17"
		'
		'label15
		'
		resources.ApplyResources(Me.label15, "label15")
		Me.label15.Name = "label15"
		'
		'numericUpDown_rotation
		'
		Me.numericUpDown_rotation.DecimalPlaces = 1
		Me.numericUpDown_rotation.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
		resources.ApplyResources(Me.numericUpDown_rotation, "numericUpDown_rotation")
		Me.numericUpDown_rotation.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
		Me.numericUpDown_rotation.Minimum = New Decimal(New Integer() {90, 0, 0, -2147483648})
		Me.numericUpDown_rotation.Name = "numericUpDown_rotation"
		AddHandler Me.numericUpDown_rotation.ValueChanged, AddressOf Me.NumericUpDown_rotationValueChanged
		'
		'cb_mode1
		'
		Me.cb_mode1.BackColor = System.Drawing.SystemColors.Window
		resources.ApplyResources(Me.cb_mode1, "cb_mode1")
		Me.cb_mode1.FormattingEnabled = true
		Me.cb_mode1.Items.AddRange(New Object() {resources.GetString("cb_mode1.Items"), resources.GetString("cb_mode1.Items1"), resources.GetString("cb_mode1.Items2"), resources.GetString("cb_mode1.Items3"), resources.GetString("cb_mode1.Items4")})
		Me.cb_mode1.Name = "cb_mode1"
		AddHandler Me.cb_mode1.SelectedIndexChanged, AddressOf Me.Cb_mode1SelectedIndexChanged
		'
		'label22
		'
		resources.ApplyResources(Me.label22, "label22")
		Me.label22.Name = "label22"
		'
		'cb_mode2
		'
		Me.cb_mode2.BackColor = System.Drawing.SystemColors.Window
		resources.ApplyResources(Me.cb_mode2, "cb_mode2")
		Me.cb_mode2.FormattingEnabled = true
		Me.cb_mode2.Items.AddRange(New Object() {resources.GetString("cb_mode2.Items"), resources.GetString("cb_mode2.Items1")})
		Me.cb_mode2.Name = "cb_mode2"
		AddHandler Me.cb_mode2.SelectedIndexChanged, AddressOf Me.Cb_mode2SelectedIndexChanged
		'
		'label1
		'
		resources.ApplyResources(Me.label1, "label1")
		Me.label1.Name = "label1"
		'
		'cb_mode3
		'
		Me.cb_mode3.BackColor = System.Drawing.SystemColors.Window
		resources.ApplyResources(Me.cb_mode3, "cb_mode3")
		Me.cb_mode3.FormattingEnabled = true
		Me.cb_mode3.Items.AddRange(New Object() {resources.GetString("cb_mode3.Items"), resources.GetString("cb_mode3.Items1"), resources.GetString("cb_mode3.Items2")})
		Me.cb_mode3.Name = "cb_mode3"
		AddHandler Me.cb_mode3.SelectedIndexChanged, AddressOf Me.Cb_mode3SelectedIndexChanged
		'
		'label3
		'
		resources.ApplyResources(Me.label3, "label3")
		Me.label3.Name = "label3"
		'
		'label4
		'
		resources.ApplyResources(Me.label4, "label4")
		Me.label4.Name = "label4"
		'
		'label5
		'
		resources.ApplyResources(Me.label5, "label5")
		Me.label5.Name = "label5"
		'
		'numericUpDown_cring
		'
		resources.ApplyResources(Me.numericUpDown_cring, "numericUpDown_cring")
		Me.numericUpDown_cring.Name = "numericUpDown_cring"
		AddHandler Me.numericUpDown_cring.ValueChanged, AddressOf Me.NumericUpDown_cringValueChanged
		'
		'FlowerShapeToolbox
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.numericUpDown_cring)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.cb_mode3)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.cb_mode2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.cb_mode1)
		Me.Controls.Add(Me.label22)
		Me.Controls.Add(Me.label17)
		Me.Controls.Add(Me.label15)
		Me.Controls.Add(Me.numericUpDown_rotation)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.numericUpDown_petals)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "FlowerShapeToolbox"
		Me.TopMost = true
		CType(Me.numericUpDown_petals,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.numericUpDown_rotation,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.numericUpDown_cring,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Public numericUpDown_cring As System.Windows.Forms.NumericUpDown
	Private label5 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Public cb_mode3 As System.Windows.Forms.ComboBox
	Private label1 As System.Windows.Forms.Label
	Public cb_mode2 As System.Windows.Forms.ComboBox
	Private label22 As System.Windows.Forms.Label
	Public cb_mode1 As System.Windows.Forms.ComboBox
	Public numericUpDown_rotation As System.Windows.Forms.NumericUpDown
	Private label15 As System.Windows.Forms.Label
	Private label17 As System.Windows.Forms.Label
	Public numericUpDown_petals As System.Windows.Forms.NumericUpDown
	Private label2 As System.Windows.Forms.Label
End Class
