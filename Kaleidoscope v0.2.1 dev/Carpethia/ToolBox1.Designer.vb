'
' Created by SharpDevelop.
' User: Blaster
' Date: 2012.12.01.
' Time: 16:09
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class Toolbox1
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Toolbox1))
		Me.label4 = New System.Windows.Forms.Label()
		Me.spin_ud = New System.Windows.Forms.NumericUpDown()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.phase_ud = New System.Windows.Forms.NumericUpDown()
		Me.label1 = New System.Windows.Forms.Label()
		Me.radial_ud = New System.Windows.Forms.NumericUpDown()
		CType(Me.spin_ud,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.phase_ud,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.radial_ud,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'label4
		'
		resources.ApplyResources(Me.label4, "label4")
		Me.label4.Name = "label4"
		'
		'spin_ud
		'
		resources.ApplyResources(Me.spin_ud, "spin_ud")
		Me.spin_ud.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
		Me.spin_ud.Minimum = New Decimal(New Integer() {180, 0, 0, -2147483648})
		Me.spin_ud.Name = "spin_ud"
		AddHandler Me.spin_ud.ValueChanged, AddressOf Me.Spin_udValueChanged
		'
		'label2
		'
		resources.ApplyResources(Me.label2, "label2")
		Me.label2.Name = "label2"
		'
		'label3
		'
		resources.ApplyResources(Me.label3, "label3")
		Me.label3.Name = "label3"
		'
		'phase_ud
		'
		resources.ApplyResources(Me.phase_ud, "phase_ud")
		Me.phase_ud.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
		Me.phase_ud.Name = "phase_ud"
		AddHandler Me.phase_ud.ValueChanged, AddressOf Me.Phase_udValueChanged
		'
		'label1
		'
		resources.ApplyResources(Me.label1, "label1")
		Me.label1.Name = "label1"
		'
		'radial_ud
		'
		resources.ApplyResources(Me.radial_ud, "radial_ud")
		Me.radial_ud.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
		Me.radial_ud.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
		Me.radial_ud.Name = "radial_ud"
		Me.radial_ud.Value = New Decimal(New Integer() {18, 0, 0, 0})
		AddHandler Me.radial_ud.ValueChanged, AddressOf Me.Radial_udValueChanged
		'
		'Toolbox1
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.spin_ud)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.phase_ud)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.radial_ud)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "Toolbox1"
		Me.ShowInTaskbar = false
		Me.TopMost = true
		AddHandler Load, AddressOf Me.Toolbox1Load
		CType(Me.spin_ud,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.phase_ud,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.radial_ud,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Public radial_ud As System.Windows.Forms.NumericUpDown
	Private label1 As System.Windows.Forms.Label
	Public phase_ud As System.Windows.Forms.NumericUpDown
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Public spin_ud As System.Windows.Forms.NumericUpDown
	Private label4 As System.Windows.Forms.Label
End Class
