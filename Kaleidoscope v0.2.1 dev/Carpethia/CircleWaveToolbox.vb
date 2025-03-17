'
' Created by SharpDevelop.
' User: Blaster
' Date: 2012.12.26.
' Time: 17:55
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class CircleWaveToolbox
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub CircleWaveToolboxLoad(sender As Object, e As EventArgs)
		
		numericUpDown_peaks.Value = MainForm.peaks
		numericUpDown_radius.Value = MainForm.radius
		checkBox_innercircle.Checked = MainForm.innercircle
		
	End Sub

	Sub NumericUpDown_peaksValueChanged(sender As Object, e As EventArgs)
		MainForm.peaks = Convert.ToInt32(numericUpDown_peaks.Value)
	End Sub
	
	Sub NumericUpDown_radiusValueChanged(sender As Object, e As EventArgs)
		MainForm.radius	= Convert.ToInt32(numericUpDown_radius.Value)
	End Sub
	
	Sub CheckBox_innercircleCheckedChanged(sender As Object, e As EventArgs)
		MainForm.innercircle = checkBox_innercircle.Checked
	End Sub
End Class
