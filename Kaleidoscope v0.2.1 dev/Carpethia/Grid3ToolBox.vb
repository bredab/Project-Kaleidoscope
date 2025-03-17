'
' Created by SharpDevelop.
' User: Blaster
' Date: 2013.02.02.
' Time: 14:10
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class Grid3ToolBox
	
	Public Shared step_value As Integer
	Public Shared inc As Boolean
	Public shared dec As Boolean
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		ud_step.Value = Convert.ToDecimal(step_value)
	End Sub
	
	
	Sub Ud_stepValueChanged(sender As Object, e As EventArgs)
		step_value = Convert.ToInt32(ud_step.Value)
		MainForm.ud_resolution.Increment = ud_step.Value
	End Sub
	
	Sub Rb_incCheckedChanged(sender As Object, e As EventArgs)
		If rb_inc.Checked Then
			inc = True
			dec = False
		End If
	End Sub
	
	Sub Rb_decCheckedChanged(sender As Object, e As EventArgs)
		If rb_dec.Checked Then
			inc = False
			dec = True
		End If
	End Sub
End Class
