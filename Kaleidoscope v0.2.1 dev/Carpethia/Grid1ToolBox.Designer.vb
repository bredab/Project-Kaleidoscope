'
' Created by SharpDevelop.
' User: Blaster
' Date: 2013.02.02.
' Time: 14:10
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class Grid1ToolBox
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grid1ToolBox))
		Me.rb_dec = New System.Windows.Forms.RadioButton()
		Me.label10 = New System.Windows.Forms.Label()
		Me.ud_step = New System.Windows.Forms.NumericUpDown()
		Me.rb_inc = New System.Windows.Forms.RadioButton()
		Me.panel1 = New System.Windows.Forms.Panel()
		CType(Me.ud_step,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'rb_dec
		'
		resources.ApplyResources(Me.rb_dec, "rb_dec")
		Me.rb_dec.Name = "rb_dec"
		Me.rb_dec.UseVisualStyleBackColor = true
		AddHandler Me.rb_dec.CheckedChanged, AddressOf Me.Rb_decCheckedChanged
		'
		'label10
		'
		resources.ApplyResources(Me.label10, "label10")
		Me.label10.Name = "label10"
		'
		'ud_step
		'
		resources.ApplyResources(Me.ud_step, "ud_step")
		Me.ud_step.DecimalPlaces = 2
		Me.ud_step.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.ud_step.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.ud_step.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.ud_step.Name = "ud_step"
		Me.ud_step.Value = New Decimal(New Integer() {1, 0, 0, 0})
		AddHandler Me.ud_step.ValueChanged, AddressOf Me.Ud_stepValueChanged
		'
		'rb_inc
		'
		resources.ApplyResources(Me.rb_inc, "rb_inc")
		Me.rb_inc.Checked = true
		Me.rb_inc.Name = "rb_inc"
		Me.rb_inc.TabStop = true
		Me.rb_inc.UseVisualStyleBackColor = true
		AddHandler Me.rb_inc.CheckedChanged, AddressOf Me.Rb_incCheckedChanged
		'
		'panel1
		'
		resources.ApplyResources(Me.panel1, "panel1")
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.panel1.Name = "panel1"
		'
		'Grid1ToolBox
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.rb_dec)
		Me.Controls.Add(Me.label10)
		Me.Controls.Add(Me.rb_inc)
		Me.Controls.Add(Me.ud_step)
		Me.Controls.Add(Me.panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "Grid1ToolBox"
		Me.TopMost = true
		CType(Me.ud_step,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private panel1 As System.Windows.Forms.Panel
	Public rb_inc As System.Windows.Forms.RadioButton
	Public ud_step As System.Windows.Forms.NumericUpDown
	Private label10 As System.Windows.Forms.Label
	Public rb_dec As System.Windows.Forms.RadioButton
End Class
