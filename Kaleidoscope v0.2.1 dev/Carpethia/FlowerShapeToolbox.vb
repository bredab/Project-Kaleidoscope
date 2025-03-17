'
' Created by SharpDevelop.
' User: Blaster
' Date: 2013.01.17.
' Time: 21:53
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class FlowerShapeToolbox
	
	Public Shared petals As Integer
	Public Shared centerRing As Integer
	Public Shared rotation As Double
	Public Shared colorMode1 As Integer
	Public Shared colorMode2 As Integer
	Public Shared colorMode3 As Integer
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		numericUpDown_petals.Value = petals
		numericUpDown_cring.Value = centerRing
		numericUpDown_rotation.Value = Convert.ToDecimal(rotation)
		cb_mode1.SelectedIndex = colorMode1
		cb_mode2.SelectedIndex = colorMode2
		cb_mode3.SelectedIndex = colorMode3
		
	End Sub
	
	
	Sub NumericUpDown_petalsValueChanged(sender As Object, e As EventArgs)
		petals = Convert.ToInt32(numericUpDown_petals.Value)
		Carpethia.my.Forms.MainForm.generate_flowerbrush(Carpethia.My.Forms.MainForm.brush,Carpethia.My.Forms.MainForm.rad)		
	End Sub
	
	
	Sub NumericUpDown_rotationValueChanged(sender As Object, e As EventArgs)
		rotation = numericUpDown_rotation.Value
		Carpethia.my.Forms.MainForm.generate_flowerbrush(Carpethia.My.Forms.MainForm.brush,Carpethia.My.Forms.MainForm.rad)		
	End Sub
	
	
	Sub Cb_mode1SelectedIndexChanged(sender As Object, e As EventArgs)
		colorMode1 = cb_mode1.SelectedIndex
		Carpethia.my.Forms.MainForm.generate_flowerbrush(Carpethia.My.Forms.MainForm.brush,Carpethia.My.Forms.MainForm.rad)		
	End Sub
	
	
	Sub Cb_mode2SelectedIndexChanged(sender As Object, e As EventArgs)
		colorMode2 = cb_mode2.SelectedIndex
		Carpethia.my.Forms.MainForm.generate_flowerbrush(Carpethia.My.Forms.MainForm.brush,Carpethia.My.Forms.MainForm.rad)		
	End Sub
	
	
	Sub Cb_mode3SelectedIndexChanged(sender As Object, e As EventArgs)
		colorMode3 = cb_mode3.SelectedIndex
		Carpethia.my.Forms.MainForm.generate_flowerbrush(Carpethia.My.Forms.MainForm.brush,Carpethia.My.Forms.MainForm.rad)		
	End Sub
	
	
	
	Sub NumericUpDown_cringValueChanged(sender As Object, e As EventArgs)
		centerRing = Convert.ToInt32(NumericUpDown_cring.Value)
		Carpethia.my.Forms.MainForm.generate_flowerbrush(Carpethia.My.Forms.MainForm.brush,Carpethia.My.Forms.MainForm.rad)
	End Sub
End Class
