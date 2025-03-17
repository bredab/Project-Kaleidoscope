'
' Created by SharpDevelop.
' User: Blaster
' Date: 2013.01.17.
' Time: 21:25
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class CircleShapeToolbox
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CircleShapeToolbox))
		Me.cb_brushtype = New System.Windows.Forms.ComboBox()
		Me.label22 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.numericUpDown_rings = New System.Windows.Forms.NumericUpDown()
		CType(Me.numericUpDown_rings,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'cb_brushtype
		'
		resources.ApplyResources(Me.cb_brushtype, "cb_brushtype")
		Me.cb_brushtype.BackColor = System.Drawing.SystemColors.Window
		Me.cb_brushtype.FormattingEnabled = true
		Me.cb_brushtype.Items.AddRange(New Object() {resources.GetString("cb_brushtype.Items"), resources.GetString("cb_brushtype.Items1"), resources.GetString("cb_brushtype.Items2"), resources.GetString("cb_brushtype.Items3"), resources.GetString("cb_brushtype.Items4")})
		Me.cb_brushtype.Name = "cb_brushtype"
		AddHandler Me.cb_brushtype.SelectedIndexChanged, AddressOf Me.Cb_brushtypeSelectedIndexChanged
		'
		'label22
		'
		resources.ApplyResources(Me.label22, "label22")
		Me.label22.Name = "label22"
		'
		'label2
		'
		resources.ApplyResources(Me.label2, "label2")
		Me.label2.Name = "label2"
		'
		'numericUpDown_rings
		'
		resources.ApplyResources(Me.numericUpDown_rings, "numericUpDown_rings")
		Me.numericUpDown_rings.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.numericUpDown_rings.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numericUpDown_rings.Name = "numericUpDown_rings"
		Me.numericUpDown_rings.Value = New Decimal(New Integer() {3, 0, 0, 0})
		AddHandler Me.numericUpDown_rings.ValueChanged, AddressOf Me.NumericUpDown_ringsValueChanged
		'
		'CircleShapeToolbox
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.numericUpDown_rings)
		Me.Controls.Add(Me.cb_brushtype)
		Me.Controls.Add(Me.label22)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "CircleShapeToolbox"
		Me.TopMost = true
		AddHandler Load, AddressOf Me.CircleShapeToolboxLoad
		CType(Me.numericUpDown_rings,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private numericUpDown_rings As System.Windows.Forms.NumericUpDown
	Private label2 As System.Windows.Forms.Label
	Private label22 As System.Windows.Forms.Label
	Private cb_brushtype As System.Windows.Forms.ComboBox
End Class
