'
' Created by SharpDevelop.
' User: Blaster
' Date: 2013.01.17.
' Time: 21:53
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class PolygonShapeToolbox
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	Sub PolygonShapeToolboxLoad(sender As Object, e As EventArgs)
		numericUpDown_sides.Value = MainForm.numberofsides
		numericUpDown_rotation.Value = MainForm.rotation
	 	cb_mode1.SelectedIndex = MainForm.colormode1
	 	cb_mode2.SelectedIndex = MainForm.colormode2
	 	cb_mode3.SelectedIndex = MainForm.colormode3
	End Sub
	
	
	Sub NumericUpDown_sidesValueChanged(sender As Object, e As EventArgs)
		MainForm.numberofsides = Convert.ToByte(numericUpDown_sides.Value)
		Carpethia.my.Forms.MainForm.generate_polybrush(Carpethia.My.Forms.MainForm.brush,Carpethia.My.Forms.MainForm.rad)		
	End Sub
	
	
	Sub NumericUpDown_rotationValueChanged(sender As Object, e As EventArgs)
		MainForm.rotation = Convert.ToInt32(numericUpDown_rotation.Value)	
		Carpethia.my.Forms.MainForm.generate_polybrush(Carpethia.My.Forms.MainForm.brush,Carpethia.My.Forms.MainForm.rad)		
	End Sub
	
	
	Sub Cb_mode1SelectedIndexChanged(sender As Object, e As EventArgs)
		MainForm.colormode1 = Convert.ToByte(Cb_mode1.SelectedIndex)	
		Carpethia.my.Forms.MainForm.generate_polybrush(Carpethia.My.Forms.MainForm.brush,Carpethia.My.Forms.MainForm.rad)		
	End Sub
	
	
	Sub Cb_mode2SelectedIndexChanged(sender As Object, e As EventArgs)
		MainForm.colormode2 = Convert.ToByte(Cb_mode2.SelectedIndex)	
		If cb_mode2.SelectedIndex = 1 Then
			Cb_mode3.SelectedIndex = 0
			Cb_mode3.Enabled = False
		Else
			Cb_mode3.Enabled = True
		End If
		Carpethia.my.Forms.MainForm.generate_polybrush(Carpethia.My.Forms.MainForm.brush,Carpethia.My.Forms.MainForm.rad)		
	End Sub
	
	
	Sub Cb_mode3SelectedIndexChanged(sender As Object, e As EventArgs)
		MainForm.colormode3 = Convert.ToByte(Cb_mode3.SelectedIndex)	
		Carpethia.my.Forms.MainForm.generate_polybrush(Carpethia.My.Forms.MainForm.brush,Carpethia.My.Forms.MainForm.rad)		
	End Sub
	
	
End Class
