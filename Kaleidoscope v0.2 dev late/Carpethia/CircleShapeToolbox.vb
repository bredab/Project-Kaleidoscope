'
' Created by SharpDevelop.
' User: Blaster
' Date: 2013.01.17.
' Time: 21:25
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class CircleShapeToolbox
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub CircleShapeToolboxLoad(sender As Object, e As EventArgs)
		cb_brushtype.SelectedIndex = MainForm.diskshademode
		numericUpDown_rings.Value = MainForm.rings
	End Sub
	
	Sub Cb_brushtypeSelectedIndexChanged(sender As Object, e As EventArgs)
		MainForm.diskshademode = Convert.ToByte(cb_brushtype.SelectedIndex)
		If cb_brushtype.SelectedIndex = 4 Then
			NumericUpDown_rings.Enabled = True
		Else 
			NumericUpDown_rings.Enabled = false
		End If
		Carpethia.my.Forms.MainForm.generate_diskbrush(Carpethia.My.Forms.MainForm.brush,Carpethia.My.Forms.MainForm.rad)		
	End Sub
	
	Sub NumericUpDown_ringsValueChanged(sender As Object, e As EventArgs)
		MainForm.rings = Convert.ToByte(numericUpDown_rings.Value)
		Carpethia.my.Forms.MainForm.generate_diskbrush(Carpethia.My.Forms.MainForm.brush,Carpethia.My.Forms.MainForm.rad)
	End Sub
End Class
