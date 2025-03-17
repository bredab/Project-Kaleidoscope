'
' Created by SharpDevelop.
' User: Blaster
' Date: 2012.12.01.
' Time: 16:09
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class Toolbox1
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	Sub Toolbox1Load(sender As Object, e As EventArgs)
		radial_ud.Value = MainForm.radial
		spin_ud.Value = MainForm.spin
		phase_ud.Value = MainForm.phase
	End Sub
	
	
	Sub Radial_udValueChanged(sender As Object, e As EventArgs)
		MainForm.radial = Convert.Toint32(radial_ud.Value)	
	End Sub
	
	
	Sub Phase_udValueChanged(sender As Object, e As EventArgs)
		MainForm.phase = Convert.Toint32(phase_ud.Value)		
	End Sub
	
	
	Sub Spin_udValueChanged(sender As Object, e As EventArgs)
		MainForm.spin = Convert.Toint32(spin_ud.Value)	
	End Sub
	
End Class
