'
' Created by SharpDevelop.
' User: Blaster
' Date: 2012.12.08.
' Time: 19:11
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class Toolbox2
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	Sub Toolbox2Load(sender As Object, e As EventArgs)
		numericUpDown_peaks.Value = MainForm.peaks
		numericUp_radius.Value = MainForm.radius
		cb_innercircle.Checked = MainForm.innercircle
	End Sub
	
	Sub NumericUpDown_ringsValueChanged(sender As Object, e As EventArgs)
		MainForm.rings = Convert.ToByte(numericUpDown_peaks.Value)
	End Sub
	
	Sub NumericUpDown_minimumValueChanged(sender As Object, e As EventArgs)
		MainForm.minimum = Convert.ToByte(numericUp_radius.Value)
	End Sub
	
	Sub NumericUpDown_maximumValueChanged(sender As Object, e As EventArgs)
		MainForm.maximum = Convert.ToByte(NumericUpDown_maximum.Value)
	End Sub
	
End Class
