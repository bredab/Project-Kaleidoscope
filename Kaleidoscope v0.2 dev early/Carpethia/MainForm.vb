'
' Created by SharpDevelop.
' User: hu51023
' Date: 2012.10.01.
' Time: 11:19
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices

Public Partial Class MainForm
	
	Dim xres As Integer = 800
	Dim yres As Integer = 800
	Dim xres2 as integer
	dim rotd As integer 
	public rad As integer
	Dim prec As Double
	Dim paramlist As New List(Of String)
	Dim param_array As Array = {"1:","2:","2:0:","2:0:5:","2:1:1:","2:1:2:","2:1:3:","2:1:4:","2:1:5:","3:","10:","11:","12:", _
		"13:","20:","21:","22:","23:","30:","31:","32:","33:","100:","101:","102:","103:","104:","105:","106:","107:", _
		"107:3:1:","107:3:2:","107:3:3:","107:6:1:","107:6:2:"}
	Dim paramstr As String
	
	Public radial As Integer = 18
	Public spin As integer = 0
	Public phase As Integer = 0
	
	Public rings As Byte = 3

	Public peaks As Integer = 4
	Public radius As Integer = 200
	Public innercircle As Boolean = False
	
	Public diskshademode As Byte = 0
	
	Public numberofsides As Byte = 4
	Public rotation As Integer = 0
	Public colormode1 As Byte = 0
	Public colormode2 As Byte = 0
	Public colormode3 As Byte = 0
	
	Dim bgcolor As color
	Dim pn_1up_bgcolor As Color = Color.Fromargb(0,0,0)
	Dim pn_2up_bgcolor As Color = Color.Fromargb(0,0,0)
	Dim pn_3up_bgcolor As Color = Color.Fromargb(0,0,0)
	Dim pn_1down_bgcolor As Color = Color.Fromargb(255,0,0)
	Dim pn_2down_bgcolor As Color = Color.Fromargb(0,255,0)
	Dim pn_3down_bgcolor As Color = Color.Fromargb(0,0,255)
	
	Public brush As bitmap
	Dim brushfrompicture As bitmap = New Bitmap(201,201,PixelFormat.Format32bppRgb)
	dim g As Graphics
	dim b As Graphics

	Dim range1 As Graphics
	Dim range2 As Graphics
	Dim range3 As Graphics
	
	Dim range1rectangle As Rectangle
	Dim range2rectangle As Rectangle
	Dim range3rectangle As Rectangle
	
	Dim range1bitmap As Bitmap
	Dim range2bitmap As Bitmap
	Dim range3bitmap As Bitmap
	
	Dim viewform As New View()
	Dim canvas As bitmap = New Bitmap(801,801,PixelFormat.Format32bppRgb)
	Dim brushpanel_bitmap As Bitmap = New Bitmap(201,201,PixelFormat.Format32bppRgb)
	
	Dim internalchange As Boolean = False
	
	Public Sub New()
		Me.InitializeComponent()
		MakePicsDir(".\Pics")
		
		range1bitmap = New Bitmap(pn_range1.Width, pn_range1.Height)
		pn_range1.BackgroundImage = range1bitmap
		range1 = Graphics.FromImage(range1bitmap)
		range1rectangle.X = 0
		range1rectangle.y = 0
		range1rectangle.width = pn_range1.Width
		range1rectangle.height = pn_range1.Height
		Dim range1brush As New LinearGradientBrush(range1rectangle, pn_1up.BackColor, pn_1down.BackColor, LinearGradientMode.vertical)		
		range1.FillRectangle(range1brush, range1rectangle)
	
		range2bitmap = New Bitmap(pn_range2.Width, pn_range2.Height)
		pn_range2.BackgroundImage = range2bitmap
		range2 = Graphics.FromImage(range2bitmap)
		range2rectangle.X = 0
		range2rectangle.y = 0
		range2rectangle.width = pn_range2.Width
		range2rectangle.height = pn_range2.Height
		Dim range2brush As New LinearGradientBrush(range2rectangle, pn_2up.BackColor, pn_2down.BackColor, LinearGradientMode.vertical)		
		range2.FillRectangle(range2brush, range2rectangle)
		
		range3bitmap = New Bitmap(pn_range1.Width, pn_range3.Height)
		pn_range3.BackgroundImage = range3bitmap
		range3 = Graphics.FromImage(range3bitmap)
		range3rectangle.X = 0
		range3rectangle.y = 0
		range3rectangle.width = pn_range3.Width
		range3rectangle.height = pn_range3.Height
		Dim range3brush As New LinearGradientBrush(range3rectangle, pn_3up.BackColor, pn_3down.BackColor, LinearGradientMode.vertical)		
		range3.FillRectangle(range3brush, range3rectangle)
		
		bar_red.BackColor = Color.FromArgb(tb_red.Value,0,0)	
		bar_green.BackColor = Color.FromArgb(0,tb_green.Value,0)
		bar_blue.BackColor = Color.FromArgb(0,0,tb_blue.Value)	
		
		rotd = 0
		prec = prec1updown.Value*0.1+prec2updown.Value*0.01+prec3updown.Value*0.001+prec4updown.Value*0.0001+prec5updown.Value*0.00001
		bgcolor = Color.FromName("Black")
		
		viewform.Show
		Me.Show
		
		viewform.imagepanel.BackgroundImage = canvas
		g = Graphics.FromImage(canvas)
		
		panel_brush.BackgroundImage = brushpanel_bitmap	
		b = Graphics.FromImage(brushpanel_bitmap)
		
		rad = Convert.ToInt32(radiusupdown.value)
		brush = New Bitmap(rad*2+1,rad*2+1,PixelFormat.Format32bppRgb)
		
		internalchange = True
		cb_brushbase.SelectedIndex = 0
		cb_gridtype.SelectedIndex = 0
		cb_mode.SelectedIndex = 0
		cb_gridmode.SelectedIndex = 0
		internalchange = False
		generate_diskbrush(brush,rad)
		xres2 = Convert.ToInt32(ud_resolution.Value)
	End Sub
		
		
	Sub Btn_generateClick(sender As Object, e As EventArgs)
		
		Dim filename As String
		Dim waves As Integer
		Dim framebarval As Integer
		Dim rad2 As Integer
		
		If cb_rad.Checked Then 
			If radinc_rb.Checked And radiusupdown.Value <= radiusupdown.Maximum - radstep_ud.Value then
				radiusupdown.value = radiusupdown.value + radstep_ud.Value
			End If
			If raddec_rb.Checked And radiusupdown.Value >= radiusupdown.Minimum + radstep_ud.Value then
				radiusupdown.value = radiusupdown.value - radstep_ud.Value
			End If
		End if
		
		If cb_wave.Checked Then 
			If waveinc_rb.Checked And waveupdown.Value <= waveupdown.Maximum - wavestep_ud.Value Then 
				waveupdown.value = waveupdown.value + wavestep_ud.Value
			End If
			If wavedec_rb.Checked And waveupdown.Value >= waveupdown.Minimum + wavestep_ud.Value Then
				waveupdown.value = waveupdown.value - wavestep_ud.Value
			End If
		End if
		
		If cb_rot.Checked Then
			If rotinc_rb.Checked And rot_ud.Value <= rot_ud.Maximum - rotstep_ud.Value Then
				rot_ud.Value = rot_ud.Value + rotstep_ud.Value
			End If
			If rotdec_rb.Checked And rot_ud.Value >= rot_ud.Minimum + rotstep_ud.Value Then
				rot_ud.Value = rot_ud.Value - rotstep_ud.Value
			End If
		End If
		
		If cb_prec.Checked Then
			If precinc_rb.Checked And Math.Round(prec,5) <= 0.99999 - precstep_ud.Value Then
				prec = prec + precstep_ud.Value
				precisionbox.Text = CStr(prec)
			End If
			If precdec_rb.Checked And Math.Round(prec,5) >= 0.99 + precstep_ud.Value Then
				prec = prec - precstep_ud.Value
				precisionbox.Text = CStr(prec)
			End If
			precudcalc()
		End If
		
		waves = Convert.ToInt32(waveupdown.value)
		framebarval = framebar.Value
		rad2 = rad
		
		If Not viewform.Created Then
			viewform = New View
			viewform.imagepanel.BackgroundImage = canvas
			viewform.Show
		End If
		
		If cb_autclr.Checked Then 
			g.clear(bgcolor)
			viewform.imagepanel.refresh
		End If
		
		If nud_zoom.Value > 1 Then
			rad2 = Convert.Toint32(rad * nud_zoom.Value)
			brush = New Bitmap(rad2*2+1,rad2*2+1,PixelFormat.Format32bppRgb)
			If cb_brushbase.SelectedIndex = 0 Then
				generate_diskbrush(brush,rad2)
			Else
				generate_polybrush(brush,rad2)
			End If
		End If
		
		Select Case cb_gridtype.SelectedIndex
			Case 0
				wave_calculation1(rad2)
			Case 1
				wave_calculation1(rad2)			
			Case 2
				wave_calculation2(rad2)			
			Case 3
				wave_calculation3(rad2)			
			Case 4
				wave_calculation3(rad2)			
			Case 5
				wave_calculation4(rad2)			
		End Select
		
		If nud_zoom.Value > 1 Then
			brush = New Bitmap(rad*2+1,rad*2+1,PixelFormat.Format32bppRgb)
			If cb_brushbase.SelectedIndex = 0 Then
				generate_diskbrush(brush,rad)
			Else
				generate_polybrush(brush,rad)
			End If
		End If
		
		viewform.imagepanel.refresh
		
		If cb_autosave.Checked Then
			filename = Convert.ToString(Now.Ticks)
			canvas.Save(".\Pics\" + filename + ".png", imageformat.png)
		End If
		
	End Sub	
		
		
	Sub WaveupdownValueChanged(sender As Object, e As EventArgs)
		wavebar.Value = convert.ToInt32(waveupdown.Value)
	End Sub
	
	
	Sub WavebarScroll(sender As Object, e As EventArgs)
		waveupdown.Value = 	wavebar.Value
	End Sub
	
	
	Sub FrameupdownValueChanged(sender As Object, e As EventArgs)
		framebar.Value = convert.ToInt32(frameupdown.Value)	
	End Sub


	Sub FramebarScroll(sender As Object, e As EventArgs)
		frameupdown.Value = framebar.Value	
	End Sub
	
		
	Sub Rot_udValueChanged(sender As Object, e As EventArgs)
		rotbar.Value = convert.ToInt32(rot_ud.Value)
	End Sub
	
	
	Sub RotbarScroll(sender As Object, e As EventArgs)
		rot_ud.Value = rotbar.Value	
	End Sub

	
	Sub RadiusupdownValueChanged(sender As Object, e As EventArgs)
		radiusbar.Value = convert.ToInt32(radiusupdown.Value)	
		rad = convert.ToInt32(radiusupdown.value)
		brush = New Bitmap(rad*2+1,rad*2+1,PixelFormat.Format32bppRgb)
		If cb_brushbase.SelectedIndex = 0 Then
			generate_diskbrush(brush,rad)
		Else
			generate_polybrush(brush,rad)
		End If
	End Sub
	
	
	Sub RadiusbarScroll(sender As Object, e As EventArgs)
		radiusupdown.Value = radiusbar.Value	
		rad = convert.ToInt32(radiusupdown.value)
		brush = New Bitmap(rad*2+1,rad*2+1,PixelFormat.Format32bppRgb)
		If cb_brushbase.SelectedIndex = 0 Then
			generate_diskbrush(brush,rad)
		Else
			generate_polybrush(brush,rad)
		End If
	End Sub
	
	
	Sub Prec1updownValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			prec = prec1updown.Value*0.1+prec2updown.Value*0.01+prec3updown.Value*0.001+prec4updown.Value*0.0001+prec5updown.Value*0.00001
			precisionbox.Text = cStr(prec)
		End If
	End Sub
	
	
	Sub Prec2updownValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			prec = prec1updown.Value*0.1+prec2updown.Value*0.01+prec3updown.Value*0.001+prec4updown.Value*0.0001+prec5updown.Value*0.00001
			precisionbox.Text = CStr(prec)
		End if
	End Sub
	
	
	Sub Prec3updownValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			prec = prec1updown.Value*0.1+prec2updown.Value*0.01+prec3updown.Value*0.001+prec4updown.Value*0.0001+prec5updown.Value*0.00001
			precisionbox.Text = cStr(prec)
		End If		
	End Sub
	
	
	Sub Prec4updownValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			prec = prec1updown.Value*0.1+prec2updown.Value*0.01+prec3updown.Value*0.001+prec4updown.Value*0.0001+prec5updown.Value*0.00001
			precisionbox.Text = cStr(prec)
		End If		
	End Sub
	
	
	Sub Prec5updownValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			prec = prec1updown.Value*0.1+prec2updown.Value*0.01+prec3updown.Value*0.001+prec4updown.Value*0.0001+prec5updown.Value*0.00001
			precisionbox.Text = cStr(prec)
		End If		
	End Sub
	
	
	Sub btnload_Click(sender As Object, e As EventArgs)
		Dim myStream As Stream = Nothing 
		Dim openFileDialog1 As New OpenFileDialog()
		Dim rectangle1 As Rectangle
		Dim b_buffer As Bitmap
		
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "bitmap files (*.png)|*.png"
        openFileDialog1.RestoreDirectory = True 

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then 
            Try
                myStream = openFileDialog1.OpenFile()
                If (myStream IsNot Nothing) Then 
                	b_buffer = New Bitmap(myStream,False) 
                	b.clear(Color.FromName("Black"))
                	rectangle1.X = 0
                	rectangle1.Y = 0
                	rectangle1.Width = b_buffer.Width
                	rectangle1.Height = b_buffer.Height
                	brushfrompicture = b_buffer.Clone(Rectangle1, PixelFormat.Format32bppRgb)
                	brush = b_buffer.Clone(Rectangle1, PixelFormat.Format32bppRgb)
					rad = convert.ToInt32((brush.Height-1)/2)
					b.DrawImage(brush, Convert.ToByte(100-rad),Convert.ToByte(100-rad))
					panel_brush.refresh
                End If 
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally 
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If 
            End Try 
        End If 
	End Sub
	
	
	Sub Btn_clearClick(sender As Object, e As EventArgs)
		g.clear(bgcolor)
		viewform.imagepanel.refresh
	End Sub
	
	
	Sub Cb_waveCheckedChanged(sender As Object, e As EventArgs)
		If cb_wave.Checked Then
			wavestep_ud.Enabled = True
			wavedec_rb.Enabled = True
			waveinc_rb.Enabled = True
		Else
			wavestep_ud.Enabled = False
			wavedec_rb.Enabled = False
			waveinc_rb.Enabled = False
		End If
	End Sub
	
	
	Sub Cb_rotCheckedChanged(sender As Object, e As EventArgs)
		If cb_rot.Checked Then
			rotstep_ud.Enabled = True
			rotdec_rb.Enabled = True
			rotinc_rb.Enabled = True
		Else
			rotstep_ud.Enabled = False
			rotdec_rb.Enabled = False
			rotinc_rb.Enabled = False
		End If
	End Sub
	
	
	Sub Cb_radCheckedChanged(sender As Object, e As EventArgs)
		If cb_rad.Checked Then
			radstep_ud.Enabled = True
			raddec_rb.Enabled = True
			radinc_rb.Enabled = True
		Else
			radstep_ud.Enabled = False
			raddec_rb.Enabled = False
			radinc_rb.Enabled = False
		End If
	End Sub
	
	
	Sub Cb_precCheckedChanged(sender As Object, e As EventArgs)
		If cb_prec.Checked Then
			precstep_ud.Enabled = True
			precdec_rb.Enabled = True
			precinc_rb.Enabled = True
		Else
			precstep_ud.Enabled = False
			precdec_rb.Enabled = False
			precinc_rb.Enabled = False
		End If
	End Sub
	
	
	Sub Panel_brushDoubleClick(sender As Object, e As EventArgs)
		Dim MyDialog As New ColorDialog()
		
	    If (MyDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
	    	bgcolor = MyDialog.Color
			g.clear(bgcolor)
			viewform.imagepanel.refresh
	    End If 
	End Sub
	
	
	Sub Rb_sphereCheckedChanged(sender As Object, e As EventArgs)
		If rb_sphere.Checked Then
			btn_load.Enabled = False
			panel_sphere.Enabled = True
			b.clear(Color.FromName("Black"))
			rad = convert.ToInt32(radiusupdown.value)
			brush = New Bitmap(rad*2+1,rad*2+1,PixelFormat.Format32bppRgb)
			If cb_brushbase.SelectedIndex = 0 Then
				generate_diskbrush(brush,rad)
			Else
				generate_polybrush(brush,rad)
			End If
		End If
	End Sub
	
	
	Sub Rb_brushCheckedChanged(sender As Object, e As EventArgs)
		If rb_brush.Checked Then
			panel_sphere.Enabled = false
			btn_load.Enabled = True
			brush = brushfrompicture
			rad = convert.ToInt32((brush.Height-1)/2)
			b.DrawImage(brush, Convert.ToByte(100-rad),Convert.ToByte(100-rad))
			panel_brush.refresh
		End If
	End Sub
	
	
	Sub Btn_randomClick(sender As Object, e As EventArgs)
		Dim random As New Random()
		Dim waves As Integer
		Dim precision As Double
		Dim radius As Integer
		Dim rbl, rbh As Byte
		Dim gbl, gbh As Byte
		Dim bbl, bbh As Byte
		Dim bgr, bgg, bgb As Byte
		
		radius = random.Next(30,100)
		waves = random.Next(100-radius+10,200-radius)
		precision = random.Next(0,299)
		
		rbl = Convert.ToByte(random.Next(0,100))
		rbh = Convert.ToByte(random.Next(rbl,100))
		gbl = Convert.ToByte(random.Next(0,100))
		gbh = Convert.ToByte(random.Next(gbl,100))
		bbl = Convert.ToByte(random.Next(0,100))
		bbh = Convert.ToByte(random.Next(bbl,100))
		
		bgr = Convert.ToByte(random.Next(0,100))
		bgg = Convert.ToByte(random.Next(0,100))
		bgb = Convert.ToByte(random.Next(0,100))
		
		waveupdown.Value = waves
		prec = 0.997 + precision/100000
		precisionbox.Text = CStr(prec)
		precudcalc()		
		radiusupdown.Value = radius
		
		internalchange = True
		
		ud_range1down.Value = rbl
		ud_range1up.Value = rbh
		ud_range2down.Value = gbl
		ud_range2up.Value = gbh
		ud_range3up.Value = bbl
		ud_range3up.Value = bbh
		
		pn_1up_bgcolor = Color.FromArgb(random.Next(0,255),random.Next(0,255),random.Next(0,255))
		pn_2up_bgcolor = Color.FromArgb(random.Next(0,255),random.Next(0,255),random.Next(0,255))
		pn_3up_bgcolor = Color.FromArgb(random.Next(0,255),random.Next(0,255),random.Next(0,255))
		pn_1down_bgcolor = Color.FromArgb(random.Next(0,255),random.Next(0,255),random.Next(0,255))
		pn_2down_bgcolor = Color.FromArgb(random.Next(0,255),random.Next(0,255),random.Next(0,255))
		pn_3down_bgcolor = Color.FromArgb(random.Next(0,255),random.Next(0,255),random.Next(0,255))
	
		internalchange = False
		
		Dim range1brush As New LinearGradientBrush(range1rectangle, pn_1up.BackColor, pn_1down.BackColor, LinearGradientMode.vertical)		
		range1.FillRectangle(range1brush, range1rectangle)
		pn_range1.Refresh

		Dim range2brush As New LinearGradientBrush(range2rectangle, pn_2up.BackColor, pn_2down.BackColor, LinearGradientMode.vertical)		
		range2.FillRectangle(range2brush, range2rectangle)
		pn_range2.Refresh

		Dim range3brush As New LinearGradientBrush(range3rectangle, pn_3up.BackColor, pn_3down.BackColor, LinearGradientMode.vertical)		
		range3.FillRectangle(range3brush, range3rectangle)
		pn_range3.Refresh

		bgcolor = Color.FromArgb(bgr,bgg,bgb)
		g.clear(bgcolor)
		viewform.imagepanel.refresh
		
		If cb_brushbase.SelectedIndex = 0 Then
			generate_diskbrush(brush,rad)
		Else
			generate_polybrush(brush,rad)
		End If
		
		rb_sphere.checked = True
 		
	End Sub
	
	
	Sub LinkLabel1LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
		Me.LinkLabel1.LinkVisited = True 
        System.Diagnostics.Process.Start("http://projectkaleidoscope.site11.com")
	End Sub
	
	
	Sub Cb_gridtypeSelectedIndexChanged(sender As Object, e As EventArgs)
		If cb_gridtype.SelectedIndex = 2 Then
			Carpethia.My.Forms.Toolbox1.Location = MousePosition
			Carpethia.My.Forms.Toolbox1.Show
		Else
			Carpethia.my.Forms.Toolbox1.Close
		End If
		If cb_gridtype.SelectedIndex = 5 Then
			Carpethia.My.Forms.circlewavetoolbox.Location = MousePosition
			Carpethia.My.Forms.circlewavetoolbox.Show
		Else
			Carpethia.my.Forms.circlewavetoolbox.Close
		End If

	End Sub
	
	
	Sub Tb_redScroll(sender As Object, e As EventArgs)
		ud_red.Value = tb_red.Value
		bar_red.BackColor = Color.FromArgb(tb_red.Value,0,0)	
	End Sub
	
	
	Sub Tb_greenScroll(sender As Object, e As EventArgs)
		ud_green.Value = tb_green.Value
		bar_green.BackColor = Color.FromArgb(0,tb_green.Value,0)
	End Sub
	
	
	Sub Tb_blueScroll(sender As Object, e As EventArgs)
		ud_blue.Value = tb_blue.Value
		bar_blue.BackColor = Color.FromArgb(0,0,tb_blue.Value)	
	End Sub
	
	
	Sub Ud_redValueChanged(sender As Object, e As EventArgs)
		tb_red.Value = Convert.Toint32(ud_red.Value)
		bar_red.BackColor = Color.FromArgb(tb_red.Value,0,0)	
	End Sub
	
	
	Sub Ud_greenValueChanged(sender As Object, e As EventArgs)
		tb_green.Value = Convert.Toint32(ud_green.Value)	
		bar_green.BackColor = Color.FromArgb(0,tb_green.Value,0)
	End Sub
	
	
	Sub Ud_blueValueChanged(sender As Object, e As EventArgs)
		tb_blue.Value = Convert.Toint32(ud_blue.Value)
		bar_blue.BackColor = Color.FromArgb(0,0,tb_blue.Value)	
	End Sub
	
	
	Sub Bar_redBackColorChanged(sender As Object, e As EventArgs)
		bar_color.BackColor = Color.FromArgb(Convert.Toint32(ud_red.Value),Convert.Toint32(ud_green.Value),Convert.Toint32(ud_blue.Value))
	End Sub
	
	
	Sub Bar_greenBackColorChanged(sender As Object, e As EventArgs)
		bar_color.BackColor = Color.FromArgb(Convert.Toint32(ud_red.Value),Convert.Toint32(ud_green.Value),Convert.Toint32(ud_blue.Value))
	End Sub
	
	
	Sub Bar_blueBackColorChanged(sender As Object, e As EventArgs)
		bar_color.BackColor = Color.FromArgb(Convert.Toint32(ud_red.Value),Convert.Toint32(ud_green.Value),Convert.Toint32(ud_blue.Value))
	End Sub
	
	
	Sub Pn_1upDoubleClick(sender As Object, e As EventArgs)
		pn_1up.BackColor = bar_color.BackColor
		pn_1up_bgcolor = bar_color.BackColor
	End Sub
	
	
	Sub Pn_1downDoubleClick(sender As Object, e As EventArgs)
		pn_1down.BackColor = bar_color.BackColor	
		pn_1down_bgcolor = bar_color.BackColor
	End Sub
	
	
	Sub Pn_2upDoubleClick(sender As Object, e As EventArgs)
		pn_2up.BackColor = bar_color.BackColor	
		pn_2up_bgcolor = bar_color.BackColor
	End Sub
	
	
	Sub Pn_2downDoubleClick(sender As Object, e As EventArgs)
		pn_2down.BackColor = bar_color.BackColor	
		pn_2down_bgcolor = bar_color.BackColor
	End Sub
	
	
	Sub Pn_3upDoubleClick(sender As Object, e As EventArgs)
		pn_3up.BackColor = bar_color.BackColor	
		pn_3up_bgcolor = bar_color.BackColor
	End Sub
	
	
	Sub Pn_3downDoubleClick(sender As Object, e As EventArgs)
		pn_3down.BackColor = bar_color.BackColor	
		pn_3down_bgcolor = bar_color.BackColor
	End Sub
	
	
	Sub Pn_1upBackColorChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			If cb_brushbase.SelectedIndex = 0 Then
				generate_diskbrush(brush,rad)
			Else
				generate_polybrush(brush,rad)
			End If
		End If
		Dim range1brush As New LinearGradientBrush(range1rectangle, pn_1up.BackColor, pn_1down.BackColor, LinearGradientMode.vertical)		
		range1.FillRectangle(range1brush, range1rectangle)
		pn_range1.Refresh
	End Sub
	
	
	Sub Pn_1downBackColorChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			If cb_brushbase.SelectedIndex = 0 Then
				generate_diskbrush(brush,rad)
			Else
				generate_polybrush(brush,rad)
			End If
		End If
		Dim range1brush As New LinearGradientBrush(range1rectangle, pn_1up.BackColor, pn_1down.BackColor, LinearGradientMode.vertical)		
		range1.FillRectangle(range1brush, range1rectangle)
		pn_range1.Refresh
	End Sub
	
	
	Sub Pn_2upBackColorChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			If cb_brushbase.SelectedIndex = 0 Then
				generate_diskbrush(brush,rad)
			Else
				generate_polybrush(brush,rad)
			End If
		End If
		Dim range2brush As New LinearGradientBrush(range2rectangle, pn_2up.BackColor, pn_2down.BackColor, LinearGradientMode.vertical)		
		range2.FillRectangle(range2brush, range2rectangle)
		pn_range2.Refresh
	End Sub
	
	
	Sub Pn_2downBackColorChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			If cb_brushbase.SelectedIndex = 0 Then
				generate_diskbrush(brush,rad)
			Else
				generate_polybrush(brush,rad)
			End If
		End If
		Dim range2brush As New LinearGradientBrush(range2rectangle, pn_2up.BackColor, pn_2down.BackColor, LinearGradientMode.vertical)		
		range2.FillRectangle(range2brush, range2rectangle)
		pn_range2.Refresh
	End Sub
	
	
	Sub Pn_3upBackColorChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			If cb_brushbase.SelectedIndex = 0 Then
				generate_diskbrush(brush,rad)
			Else
				generate_polybrush(brush,rad)
			End If
		End If
		Dim range3brush As New LinearGradientBrush(range3rectangle, pn_3up.BackColor, pn_3down.BackColor, LinearGradientMode.vertical)		
		range3.FillRectangle(range3brush, range3rectangle)
		pn_range3.Refresh
	End Sub
	
	
	Sub Pn_3downBackColorChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			If cb_brushbase.SelectedIndex = 0 Then
				generate_diskbrush(brush,rad)
			Else
				generate_polybrush(brush,rad)
			End If
		End If
		Dim range3brush As New LinearGradientBrush(range3rectangle, pn_3up.BackColor, pn_3down.BackColor, LinearGradientMode.vertical)		
		range3.FillRectangle(range3brush, range3rectangle)
		pn_range3.Refresh
	End Sub
	
	
	Sub Ud_range1upValueChanged(sender As Object, e As EventArgs)
		tb_range1up.Value = Convert.Toint32(ud_range1up.Value)	
		If Not internalchange Then 
			If cb_brushbase.SelectedIndex = 0 Then
				generate_diskbrush(brush,rad)
			Else
				generate_polybrush(brush,rad)
			End If
		End If
	End Sub
	
	
	Sub Ud_range1downValueChanged(sender As Object, e As EventArgs)
		tb_range1down.Value = Convert.Toint32(ud_range1down.Value)
		If Not internalchange Then 
			If cb_brushbase.SelectedIndex = 0 Then
				generate_diskbrush(brush,rad)
			Else
				generate_polybrush(brush,rad)
			End If
		End If
	End Sub
	
	
	Sub Ud_range2upValueChanged(sender As Object, e As EventArgs)
		tb_range2up.Value = Convert.Toint32(ud_range2up.Value)	
		If Not internalchange Then 
			If cb_brushbase.SelectedIndex = 0 Then
				generate_diskbrush(brush,rad)
			Else
				generate_polybrush(brush,rad)
			End If
		End If
	End Sub
	
	
	Sub Ud_range2downValueChanged(sender As Object, e As EventArgs)
		tb_range2down.Value = Convert.Toint32(ud_range2down.Value)	
		If Not internalchange Then 
			If cb_brushbase.SelectedIndex = 0 Then
				generate_diskbrush(brush,rad)
			Else
				generate_polybrush(brush,rad)
			End If
		End If
	End Sub
	
	
	Sub Ud_range3upValueChanged(sender As Object, e As EventArgs)
		tb_range3up.Value = Convert.Toint32(ud_range3up.Value)	
		If Not internalchange Then 
			If cb_brushbase.SelectedIndex = 0 Then
				generate_diskbrush(brush,rad)
			Else
				generate_polybrush(brush,rad)
			End If
		End If
	End Sub
	
	
	Sub Ud_range3downValueChanged(sender As Object, e As EventArgs)
		tb_range3down.Value = Convert.Toint32(ud_range3down.Value)	
		If Not internalchange Then 
			If cb_brushbase.SelectedIndex = 0 Then
				generate_diskbrush(brush,rad)
			Else
				generate_polybrush(brush,rad)
			End If
		End If
	End Sub
	
	
	Sub Tb_range1upScroll(sender As Object, e As EventArgs)		
		ud_range1up.Value = tb_range1up.Value
	End Sub
	
	
	Sub Tb_range1downScroll(sender As Object, e As EventArgs)
		ud_range1down.Value = tb_range1down.Value
	End Sub
	
	
	Sub Tb_range2upScroll(sender As Object, e As EventArgs)
		ud_range2up.Value = tb_range2up.Value
	End Sub
	
	
	Sub Tb_range2downScroll(sender As Object, e As EventArgs)
		ud_range2down.Value = tb_range2down.Value
	End Sub
	
	
	Sub Tb_range3upScroll(sender As Object, e As EventArgs)
		ud_range3up.Value = tb_range3up.Value
	End Sub
	
	
	Sub Tb_range3downScroll(sender As Object, e As EventArgs)
		ud_range3down.Value = tb_range3down.Value
	End Sub
	
	
	Sub Pn_1upMouseClick(sender As Object, e As MouseEventArgs)
		If e.Button = Windows.Forms.MouseButtons.Right Then
			ud_red.Value = pn_1up.BackColor.R
			ud_green.Value = pn_1up.BackColor.G
			ud_blue.Value = pn_1up.BackColor.B
		End If
	End Sub
	
	
	Sub Pn_2upMouseClick(sender As Object, e As MouseEventArgs)
		If e.Button = Windows.Forms.MouseButtons.Right Then
			ud_red.Value = pn_2up.BackColor.R
			ud_green.Value = pn_2up.BackColor.G
			ud_blue.Value = pn_2up.BackColor.B
		End If
	End Sub
	
	
	Sub Pn_3upMouseClick(sender As Object, e As MouseEventArgs)
		If e.Button = Windows.Forms.MouseButtons.Right Then
			ud_red.Value = pn_3up.BackColor.R
			ud_green.Value = pn_3up.BackColor.G
			ud_blue.Value = pn_3up.BackColor.B
		End If
	End Sub
	
	
	Sub Pn_1downMouseClick(sender As Object, e As MouseEventArgs)
		If e.Button = Windows.Forms.MouseButtons.Right Then
			ud_red.Value = pn_1down.BackColor.R
			ud_green.Value = pn_1down.BackColor.G
			ud_blue.Value = pn_1down.BackColor.B
		End If
	End Sub
	
	
	Sub Pn_2downMouseClick(sender As Object, e As MouseEventArgs)
		If e.Button = Windows.Forms.MouseButtons.Right Then
			ud_red.Value = pn_2down.BackColor.R
			ud_green.Value = pn_2down.BackColor.G
			ud_blue.Value = pn_2down.BackColor.B
		End If
	End Sub
	
	
	Sub Pn_3downMouseClick(sender As Object, e As MouseEventArgs)
		If e.Button = Windows.Forms.MouseButtons.Right Then
			ud_red.Value = pn_3down.BackColor.R
			ud_green.Value = pn_3down.BackColor.G
			ud_blue.Value = pn_3down.BackColor.B
		End If
	End Sub
	
	
	Sub Wavestep_udValueChanged(sender As Object, e As EventArgs)
		waveupdown.Increment = wavestep_ud.Value	
	End Sub
	
	
	Sub Rotstep_udValueChanged(sender As Object, e As EventArgs)
		rot_ud.Increment = rotstep_ud.Value	
	End Sub
	
	
	Sub Ud_resolutionValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then xres2 = Convert.Toint32(ud_resolution.Value)
	End Sub
	
	
	Sub Pict_saveClick(sender As Object, e As EventArgs)
		Dim myStream As Stream
		Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "bitmap files (*.png)|*.png"
        saveFileDialog1.RestoreDirectory = True 

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            myStream = saveFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then 
            	canvas.Save(myStream, imageformat.png)
                myStream.Close()
            End If 
        End If 
	End Sub

	
	Sub Btn_quicksaveClick(sender As Object, e As EventArgs)
		Dim filename As String
		
		filename = Convert.ToString(Now.Ticks)
		canvas.Save(".\Pics\" + filename + ".png", imageformat.png)
		If cb_autparsave.Checked Then
			Saveparams(".\Pics\" + filename + ".pcfg")
		End If
	End Sub
	
	
	Sub btn_saveClick(sender As Object, e As EventArgs)
		Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "Pattern config files (*.pcfg)|*.pcfg"
        saveFileDialog1.RestoreDirectory = True 

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sw As new StreamWriter(saveFileDialog1.OpenFile())
            sw.WriteLine("1:"+Convert.ToString(radiusupdown.Value))
            sw.WriteLine("2:"+Convert.ToString(cb_brushbase.SelectedIndex))
            sw.WriteLine("2:0:"+Convert.ToString(diskshademode))
            sw.WriteLine("2:0:5:"+Convert.ToString(rings))
            sw.WriteLine("2:1:1:"+Convert.ToString(numberofsides))
            sw.WriteLine("2:1:2:"+Convert.ToString(rotation))
            sw.WriteLine("2:1:3:"+Convert.ToString(colormode1))
            sw.WriteLine("2:1:4:"+Convert.ToString(colormode2))
            sw.WriteLine("2:1:5:"+Convert.ToString(colormode3))
            sw.WriteLine("3:"+Convert.ToString(cb_mode.SelectedIndex))
            sw.WriteLine("10:"+Convert.ToString(ud_range1up.Value))
            sw.WriteLine("11:"+Convert.ToString(ud_range1down.Value))
            sw.WriteLine("12:"+Convert.ToString(pn_1up.BackColor.toargb))
            sw.WriteLine("13:"+Convert.ToString(pn_1down.BackColor.toargb))
            sw.WriteLine("20:"+Convert.ToString(ud_range2up.Value))
            sw.WriteLine("21:"+Convert.ToString(ud_range2down.Value))
            sw.WriteLine("22:"+Convert.ToString(pn_2up.BackColor.toargb))
            sw.WriteLine("23:"+Convert.ToString(pn_2down.BackColor.toargb))
            sw.WriteLine("30:"+Convert.ToString(ud_range3up.Value))
            sw.WriteLine("31:"+Convert.ToString(ud_range3down.Value))
            sw.WriteLine("32:"+Convert.ToString(pn_3up.BackColor.toargb))
            sw.WriteLine("33:"+Convert.ToString(pn_3down.BackColor.toargb))
            sw.WriteLine("100:"+Convert.ToString(waveupdown.Value))
            sw.WriteLine("101:"+Convert.ToString(frameupdown.Value))
            sw.WriteLine("102:"+Convert.ToString(ud_resolution.Value))
            sw.WriteLine("103:"+Convert.ToString(nud_zoom.Value))
            sw.WriteLine("104:"+Convert.ToString(prec))
            sw.WriteLine("105:"+Convert.ToString(rot_ud.Value))
            sw.WriteLine("106:"+Convert.ToString(cb_gridmode.SelectedIndex))
            sw.WriteLine("107:"+Convert.ToString(cb_gridtype.SelectedIndex))
            sw.WriteLine("107:3:1:"+Convert.ToString(radial))
            sw.WriteLine("107:3:2:"+Convert.ToString(phase))
            sw.WriteLine("107:3:3:"+Convert.ToString(spin))
            sw.WriteLine("107:6:1:"+Convert.ToString(peaks))
            sw.WriteLine("107:6:2:"+Convert.ToString(radius))
            sw.Flush()
            sw.Close
        End If 
		       
	End Sub
	
	
	
	
	Sub Btn_brushloadClick(sender As Object, e As EventArgs)
		Dim openFileDialog1 As New OpenFileDialog()
		Dim line As String
		Dim x As Integer
		Dim result As string
		
        openFileDialog1.Filter = "Pattern config files (*.pcfg)|*.pcfg"
        openFileDialog1.RestoreDirectory = True 
        
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then 
            Try
            	paramlist.Clear()
            	Dim rw As New StreamReader(openFileDialog1.OpenFile())
		 	    line = rw.ReadLine
			    Do While (Not line Is Nothing)
					paramlist.Add(line)
					line = rw.ReadLine
			    Loop
			    rw.Close
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            End Try 
        End If 
        
  		internalchange = True

        For x = 0 To param_array.Length - 1
        	paramstr = Convert.Tostring(param_array.GetValue(x))
        	result = paramlist.Find(AddressOf FindParam)
        	If result IsNot Nothing Then
        		result = result.Substring(paramstr.Length)
        		Select Case x
	        		Case 0
	        			radiusupdown.Value = Convert.ToDecimal(result)
	        		Case 1
	        			cb_brushbase.SelectedIndex = Convert.ToInt32(result)
	        		Case 2
	        			diskshademode = Convert.ToByte(result)
	        		Case 3
	        			rings = Convert.ToByte(result)
	        		Case 4
	        			numberofsides = Convert.ToByte(result)
	        		Case 5
	        			rotation = Convert.ToInt32(result)
	        		Case 6
	        			colormode1 = Convert.ToByte(result)
	        		Case 7
	        			colormode2 = Convert.ToByte(result)
	        		Case 8
	        			colormode3 = Convert.ToByte(result)
	        		Case 9
	        			cb_mode.SelectedIndex = Convert.ToInt32(result)
	        		Case 10
	        			ud_range1up.Value = Convert.ToDecimal(result)
	        		Case 11
	        			ud_range1down.Value = Convert.ToDecimal(result)
	        		Case 12
	        			pn_1up.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 13
	        			pn_1down.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 14
	        			ud_range2up.Value = Convert.ToDecimal(result)
	        		Case 15
	        			ud_range2down.Value = Convert.ToDecimal(result)
	        		Case 16
	        			pn_2up.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 17
	        			pn_2down.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 18
	        			ud_range3up.Value = Convert.ToDecimal(result)
	        		Case 19
	        			ud_range3down.Value = Convert.ToDecimal(result)
	        		Case 20
	        			pn_3up.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 21
	        			pn_3down.BackColor = Color.fromargb(Convert.ToInt32(result))
	        	End Select
	        End If
        Next
  		internalchange = False
		If cb_brushbase.SelectedIndex = 0 Then
			generate_diskbrush(brush,rad)
		Else
			generate_polybrush(brush,rad)
		End If
        
	End Sub
	
	
	
	
	Sub Btn_paramloadClick(sender As Object, e As EventArgs)
		Dim openFileDialog1 As New OpenFileDialog()
		Dim line As String
		Dim x As Integer
		Dim result As string
		
        openFileDialog1.Filter = "Pattern config files (*.pcfg)|*.pcfg"
        openFileDialog1.RestoreDirectory = True 
        
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then 
            Try
            	paramlist.Clear()
            	Dim rw As New StreamReader(openFileDialog1.OpenFile())
		 	    line = rw.ReadLine
			    Do While (Not line Is Nothing)
					paramlist.Add(line)
					line = rw.ReadLine
			    Loop
			    rw.Close
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            End Try 
        End If 
        
  		internalchange = True

        For x = 0 To param_array.Length - 1
        	paramstr = Convert.Tostring(param_array.GetValue(x))
        	result = paramlist.Find(AddressOf FindParam)
        	If result IsNot Nothing Then
        		result = result.Substring(paramstr.Length)
        		Select Case x
	        		Case 0
	        			radiusupdown.Value = Convert.ToDecimal(result)
	        		Case 1
	        			cb_brushbase.SelectedIndex = Convert.ToInt32(result)
	        		Case 2
	        			diskshademode = Convert.ToByte(result)
	        		Case 3
	        			rings = Convert.ToByte(result)
	        		Case 4
	        			numberofsides = Convert.ToByte(result)
	        		Case 5
	        			rotation = Convert.ToInt32(result)
	        		Case 6
	        			colormode1 = Convert.ToByte(result)
	        		Case 7
	        			colormode2 = Convert.ToByte(result)
	        		Case 8
	        			colormode3 = Convert.ToByte(result)
	        		Case 9
	        			cb_mode.SelectedIndex = Convert.ToInt32(result)
	        		Case 10
	        			ud_range1up.Value = Convert.ToDecimal(result)
	        		Case 11
	        			ud_range1down.Value = Convert.ToDecimal(result)
	        		Case 12
	        			pn_1up.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 13
	        			pn_1down.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 14
	        			ud_range2up.Value = Convert.ToDecimal(result)
	        		Case 15
	        			ud_range2down.Value = Convert.ToDecimal(result)
	        		Case 16
	        			pn_2up.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 17
	        			pn_2down.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 18
	        			ud_range3up.Value = Convert.ToDecimal(result)
	        		Case 19
	        			ud_range3down.Value = Convert.ToDecimal(result)
	        		Case 20
	        			pn_3up.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 21
	        			pn_3down.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 22
	        			waveupdown.Value = Convert.ToDecimal(result)
	        		Case 23
	        			frameupdown.Value = Convert.ToDecimal(result)
	        		Case 24
	        			ud_resolution.Value = Convert.ToDecimal(result)
	        		Case 25
	        			nud_zoom.Value = Convert.ToDecimal(result)
	        		Case 26
	        			prec = Convert.ToDouble(result)
       					precisionbox.Text = CStr(prec)
						precudcalc()		
	        		Case 27
	        			rot_ud.Value = Convert.ToDecimal(result)
	        		Case 28
	        			cb_gridmode.SelectedIndex = Convert.ToInt32(result)
	        		Case 29
	        			cb_gridtype.SelectedIndex = Convert.ToInt32(result)
	        		Case 30
	        			radial = Convert.ToInt32(result)
	        		Case 31
	        			phase = Convert.ToInt32(result)
	        		Case 32
	        			spin = Convert.ToInt32(result)
	        		Case 33
	        			peaks = Convert.ToInt32(result)
	        		Case 34
	        			radius = Convert.ToInt32(result)
	        	End Select
	        End If
        Next
  		internalchange = False
		If cb_brushbase.SelectedIndex = 0 Then
			generate_diskbrush(brush,rad)
		Else
			generate_polybrush(brush,rad)
		End If
		
	End Sub
	
	
	
	Sub Cb_brushbaseSelectedIndexChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			If cb_brushbase.SelectedIndex = 0 Then
				Carpethia.My.Forms.PolygonShapeToolbox.Close
				Carpethia.My.Forms.CircleShapeToolbox.Location = MousePosition
				Carpethia.My.Forms.CircleShapeToolbox.Show
				generate_diskbrush(brush,rad)
			Else
				Carpethia.my.Forms.CircleShapeToolbox.Close
				Carpethia.My.Forms.PolygonShapeToolbox.Location = MousePosition
				Carpethia.My.Forms.PolygonShapeToolbox.Show
				generate_polybrush(brush,rad)
			End If
		End if
	End Sub
	
	
End Class


