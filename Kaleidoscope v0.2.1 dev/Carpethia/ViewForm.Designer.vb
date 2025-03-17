'
' Created by SharpDevelop.
' User: hu51023
' Date: 2012.10.01.
' Time: 16:20
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class View
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
		Me.imagepanel = New System.Windows.Forms.Panel()
		Me.progressBar1 = New System.Windows.Forms.ProgressBar()
		Me.imagepanel.SuspendLayout
		Me.SuspendLayout
		'
		'imagepanel
		'
		Me.imagepanel.BackColor = System.Drawing.Color.Black
		Me.imagepanel.Controls.Add(Me.progressBar1)
		Me.imagepanel.Dock = System.Windows.Forms.DockStyle.Fill
		Me.imagepanel.ForeColor = System.Drawing.Color.Black
		Me.imagepanel.Location = New System.Drawing.Point(0, 0)
		Me.imagepanel.Name = "imagepanel"
		Me.imagepanel.Size = New System.Drawing.Size(801, 801)
		Me.imagepanel.TabIndex = 0
		'
		'progressBar1
		'
		Me.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.progressBar1.Location = New System.Drawing.Point(123, 395)
		Me.progressBar1.Name = "progressBar1"
		Me.progressBar1.Size = New System.Drawing.Size(560, 42)
		Me.progressBar1.Step = 1
		Me.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.progressBar1.TabIndex = 0
		Me.progressBar1.Visible = false
		'
		'View
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = true
		Me.BackColor = System.Drawing.Color.Silver
		Me.ClientSize = New System.Drawing.Size(801, 801)
		Me.Controls.Add(Me.imagepanel)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.KeyPreview = true
		Me.Location = New System.Drawing.Point(475, 5)
		Me.MaximizeBox = false
		Me.Name = "View"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "View"
		Me.imagepanel.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Public progressBar1 As System.Windows.Forms.ProgressBar
	Public imagepanel As System.Windows.Forms.Panel
End Class
