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
	Dim param_array(41) As string
	Dim paramstr As String
	
	Public radial As Integer = 18
	Public spin As integer = 0
	Public phase As Integer = 0
	
	Public rings As Integer = 3

	Public peaks As Integer = 4
	Public radius As Integer = 200
	Public innercircle As Boolean = False
	
	Public diskshademode As Integer = 0
	
	Public numberofsides As Integer = 4
	Public rotation As Integer = 0
	Public colormode1 As Integer = 0
	Public colormode2 As Integer = 0
	Public colormode3 As Integer = 0
	
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
		loadparams("param.cfg")
		
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
		
		Grid1ToolBox.step_value = 1
		Grid1ToolBox.inc = True
		Grid1ToolBox.dec = False
		
		Grid2ToolBox.step_value = 1
		Grid2ToolBox.inc = True
		Grid2ToolBox.dec = False
		
		Grid3ToolBox.step_value = 1
		Grid3ToolBox.inc = False
		Grid3ToolBox.dec = True
		
		FlowerShapeToolbox.petals = 2
		FlowerShapeToolbox.centerRing = 0
		FlowerShapeToolbox.rotation = 0
		FlowerShapeToolbox.colorMode1 = 0
		FlowerShapeToolbox.colorMode2 = 0
		FlowerShapeToolbox.colorMode3 = 0

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
		
		If cb_wave1.Checked Then 
			If Grid1ToolBox.inc And waveupdown1.Value <= waveupdown1.Maximum - Grid1ToolBox.step_value Then 
				waveupdown1.value = Convert.ToDecimal(waveupdown1.value + Grid1ToolBox.step_value)
			End If
			If Grid1ToolBox.dec And waveupdown1.Value >= waveupdown1.Minimum + Grid1ToolBox.step_value Then
				waveupdown1.value = Convert.ToDecimal(waveupdown1.value - Grid1ToolBox.step_value)
			End If
		End if
		
		If cb_wave2.Checked Then 
			If Grid2ToolBox.inc And waveupdown2.Value <= waveupdown2.Maximum - Grid2ToolBox.step_value Then 
				waveupdown2.value = Convert.ToDecimal(waveupdown2.value + Grid2ToolBox.step_value)
			End If
			If Grid2ToolBox.dec And waveupdown2.Value >= waveupdown2.Minimum + Grid2ToolBox.step_value Then
				waveupdown2.value = Convert.ToDecimal(waveupdown2.value - Grid2ToolBox.step_value)
			End If
		End if
		
		If cb_grid.Checked Then 
			If Grid3ToolBox.inc And ud_resolution.Value <= ud_resolution.Maximum - Grid3ToolBox.step_value Then 
				ud_resolution.value = Convert.ToDecimal(ud_resolution.value + Grid3ToolBox.step_value)
			End If
			If Grid3ToolBox.dec And ud_resolution.Value >= ud_resolution.Minimum + Grid3ToolBox.step_value Then
				ud_resolution.value = Convert.ToDecimal(ud_resolution.value - Grid3ToolBox.step_value)
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
		
		waves = Convert.ToInt32(waveupdown1.value)
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
			Select Case cb_brushbase.SelectedIndex
				Case 0
					generate_diskbrush(brush,rad2)
				Case 1
					generate_polybrush(brush,rad2)
				Case 2
					generate_flowerbrush(brush,rad2)
			End Select
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
			Select Case cb_brushbase.SelectedIndex
				Case 0
					generate_diskbrush(brush,rad)
				Case 1
					generate_polybrush(brush,rad)
				Case 2
					generate_flowerbrush(brush,rad)
			End Select
		End If
		
		viewform.imagepanel.refresh
		
		If cb_autosave.Checked Then
			filename = Convert.ToString(Now.Ticks)
			canvas.Save(".\Pics\" + filename + ".png", imageformat.png)
		End If
		
	End Sub	
		
		
	Sub Waveupdown1ValueChanged(sender As Object, e As EventArgs)
		wavebar1.Value = convert.ToInt32(waveupdown1.Value)
		If cb_link.Checked Then 
			wavebar2.Value = convert.ToInt32(waveupdown1.Value)
			waveupdown2.Value = wavebar1.Value
		End If
	End Sub
	
	
	Sub Wavebar1Scroll(sender As Object, e As EventArgs)
		waveupdown1.Value = wavebar1.Value
		If cb_link.Checked Then waveupdown2.Value = wavebar1.Value
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
		Select Case cb_brushbase.SelectedIndex
			Case 0
				generate_diskbrush(brush,rad)
			Case 1
				generate_polybrush(brush,rad)
			Case 2
				generate_flowerbrush(brush,rad)
		End Select
	End Sub
	
	
	Sub RadiusbarScroll(sender As Object, e As EventArgs)
		radiusupdown.Value = radiusbar.Value	
		rad = convert.ToInt32(radiusupdown.value)
		brush = New Bitmap(rad*2+1,rad*2+1,PixelFormat.Format32bppRgb)
		Select Case cb_brushbase.SelectedIndex
			Case 0
				generate_diskbrush(brush,rad)
			Case 1
				generate_polybrush(brush,rad)
			Case 2
				generate_flowerbrush(brush,rad)
		End Select
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
			Select Case cb_brushbase.SelectedIndex
				Case 0
					generate_diskbrush(brush,rad)
				Case 1
					generate_polybrush(brush,rad)
				Case 2
					generate_flowerbrush(brush,rad)
			End Select
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
		Dim rbl, rbh As Integer
		Dim gbl, gbh As Integer
		Dim bbl, bbh As Integer
		Dim bgr, bgg, bgb As Integer
		
		radius = random.Next(30,100)
		waves = random.Next(100-radius+10,200-radius)
		precision = random.Next(0,299)
		
		rbl = Convert.Toint32(random.Next(0,100))
		rbh = Convert.Toint32(random.Next(rbl,100))
		gbl = Convert.Toint32(random.Next(0,100))
		gbh = Convert.Toint32(random.Next(gbl,100))
		bbl = Convert.Toint32(random.Next(0,100))
		bbh = Convert.Toint32(random.Next(bbl,100))
		
		bgr = Convert.Toint32(random.Next(0,100))
		bgg = Convert.Toint32(random.Next(0,100))
		bgb = Convert.Toint32(random.Next(0,100))
		
		waveupdown1.Value = waves
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
		
		Select Case cb_brushbase.SelectedIndex
			Case 0
				generate_diskbrush(brush,rad)
			Case 1
				generate_polybrush(brush,rad)
			Case 2
				generate_flowerbrush(brush,rad)
		End Select
		
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
			Select Case cb_brushbase.SelectedIndex
				Case 0
					generate_diskbrush(brush,rad)
				Case 1
					generate_polybrush(brush,rad)
				Case 2
					generate_flowerbrush(brush,rad)
			End Select
		End if
		Dim range1brush As New LinearGradientBrush(range1rectangle, pn_1up.BackColor, pn_1down.BackColor, LinearGradientMode.vertical)		
		range1.FillRectangle(range1brush, range1rectangle)
		pn_range1.Refresh
	End Sub
	
	
	Sub Pn_1downBackColorChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			Select Case cb_brushbase.SelectedIndex
				Case 0
					generate_diskbrush(brush,rad)
				Case 1
					generate_polybrush(brush,rad)
				Case 2
					generate_flowerbrush(brush,rad)
			End Select
		End If
		Dim range1brush As New LinearGradientBrush(range1rectangle, pn_1up.BackColor, pn_1down.BackColor, LinearGradientMode.vertical)		
		range1.FillRectangle(range1brush, range1rectangle)
		pn_range1.Refresh
	End Sub
	
	
	Sub Pn_2upBackColorChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			Select Case cb_brushbase.SelectedIndex
				Case 0
					generate_diskbrush(brush,rad)
				Case 1
					generate_polybrush(brush,rad)
				Case 2
					generate_flowerbrush(brush,rad)
			End Select
		End If
		Dim range2brush As New LinearGradientBrush(range2rectangle, pn_2up.BackColor, pn_2down.BackColor, LinearGradientMode.vertical)		
		range2.FillRectangle(range2brush, range2rectangle)
		pn_range2.Refresh
	End Sub
	
	
	Sub Pn_2downBackColorChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			Select Case cb_brushbase.SelectedIndex
				Case 0
					generate_diskbrush(brush,rad)
				Case 1
					generate_polybrush(brush,rad)
				Case 2
					generate_flowerbrush(brush,rad)
			End Select
		End If
		Dim range2brush As New LinearGradientBrush(range2rectangle, pn_2up.BackColor, pn_2down.BackColor, LinearGradientMode.vertical)		
		range2.FillRectangle(range2brush, range2rectangle)
		pn_range2.Refresh
	End Sub
	
	
	Sub Pn_3upBackColorChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			Select Case cb_brushbase.SelectedIndex
				Case 0
					generate_diskbrush(brush,rad)
				Case 1
					generate_polybrush(brush,rad)
				Case 2
					generate_flowerbrush(brush,rad)
			End Select
		End If
		Dim range3brush As New LinearGradientBrush(range3rectangle, pn_3up.BackColor, pn_3down.BackColor, LinearGradientMode.vertical)		
		range3.FillRectangle(range3brush, range3rectangle)
		pn_range3.Refresh
	End Sub
	
	
	Sub Pn_3downBackColorChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			Select Case cb_brushbase.SelectedIndex
				Case 0
					generate_diskbrush(brush,rad)
				Case 1
					generate_polybrush(brush,rad)
				Case 2
					generate_flowerbrush(brush,rad)
			End Select
		End If
		Dim range3brush As New LinearGradientBrush(range3rectangle, pn_3up.BackColor, pn_3down.BackColor, LinearGradientMode.vertical)		
		range3.FillRectangle(range3brush, range3rectangle)
		pn_range3.Refresh
	End Sub
	
	
	Sub Ud_range1upValueChanged(sender As Object, e As EventArgs)
		tb_range1up.Value = Convert.Toint32(ud_range1up.Value)	
		If Not internalchange Then 
			Select Case cb_brushbase.SelectedIndex
				Case 0
					generate_diskbrush(brush,rad)
				Case 1
					generate_polybrush(brush,rad)
				Case 2
					generate_flowerbrush(brush,rad)
			End Select
		End If
	End Sub
	
	
	Sub Ud_range1downValueChanged(sender As Object, e As EventArgs)
		tb_range1down.Value = Convert.Toint32(ud_range1down.Value)
		If Not internalchange Then 
			Select Case cb_brushbase.SelectedIndex
				Case 0
					generate_diskbrush(brush,rad)
				Case 1
					generate_polybrush(brush,rad)
				Case 2
					generate_flowerbrush(brush,rad)
			End Select
		End If
	End Sub
	
	
	Sub Ud_range2upValueChanged(sender As Object, e As EventArgs)
		tb_range2up.Value = Convert.Toint32(ud_range2up.Value)	
		If Not internalchange Then 
			Select Case cb_brushbase.SelectedIndex
				Case 0
					generate_diskbrush(brush,rad)
				Case 1
					generate_polybrush(brush,rad)
				Case 2
					generate_flowerbrush(brush,rad)
			End Select
		End If
	End Sub
	
	
	Sub Ud_range2downValueChanged(sender As Object, e As EventArgs)
		tb_range2down.Value = Convert.Toint32(ud_range2down.Value)	
		If Not internalchange Then 
			Select Case cb_brushbase.SelectedIndex
				Case 0
					generate_diskbrush(brush,rad)
				Case 1
					generate_polybrush(brush,rad)
				Case 2
					generate_flowerbrush(brush,rad)
			End Select
		End If
	End Sub
	
	
	Sub Ud_range3upValueChanged(sender As Object, e As EventArgs)
		tb_range3up.Value = Convert.Toint32(ud_range3up.Value)	
		If Not internalchange Then 
			Select Case cb_brushbase.SelectedIndex
				Case 0
					generate_diskbrush(brush,rad)
				Case 1
					generate_polybrush(brush,rad)
				Case 2
					generate_flowerbrush(brush,rad)
			End Select
		End If
	End Sub
	
	
	Sub Ud_range3downValueChanged(sender As Object, e As EventArgs)
		tb_range3down.Value = Convert.Toint32(ud_range3down.Value)	
		If Not internalchange Then 
			Select Case cb_brushbase.SelectedIndex
				Case 0
					generate_diskbrush(brush,rad)
				Case 1
					generate_polybrush(brush,rad)
				Case 2
					generate_flowerbrush(brush,rad)
			End Select
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
	
	
	Sub Rotstep_udValueChanged(sender As Object, e As EventArgs)
		rot_ud.Increment = rotstep_ud.Value	
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
			Saveparams(saveFileDialog1.filename)
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
	        			diskshademode = Convert.Toint32(result)
	        		Case 3
	        			rings = Convert.Toint32(result)
	        		Case 4
	        			numberofsides = Convert.Toint32(result)
	        		Case 5
	        			rotation = Convert.ToInt32(result)
	        		Case 6
	        			colormode1 = Convert.Toint32(result)
	        		Case 7
	        			colormode2 = Convert.Toint32(result)
					Case 8	        			
						FlowerShapeToolbox.petals = Convert.ToInt32(result)
					Case 9
						FlowerShapeToolbox.centerRing = Convert.ToInt32(result)
					Case 10
						FlowerShapeToolbox.rotation = Convert.ToDouble(result)
					Case 11
						FlowerShapeToolbox.colorMode1 = Convert.ToInt32(result)
					Case 12
						FlowerShapeToolbox.colorMode2 = Convert.ToInt32(result)
					Case 13
						FlowerShapeToolbox.colorMode3 = Convert.ToInt32(result)
	        		Case 14
	        			cb_mode.SelectedIndex = Convert.ToInt32(result)
	        		Case 15
	        			ud_range1up.Value = Convert.ToDecimal(result)
	        		Case 16
	        			ud_range1down.Value = Convert.ToDecimal(result)
	        		Case 17
	        			pn_1up.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 18
	        			pn_1down.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 19
	        			ud_range2up.Value = Convert.ToDecimal(result)
	        		Case 20
	        			ud_range2down.Value = Convert.ToDecimal(result)
	        		Case 21
	        			pn_2up.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 22
	        			pn_2down.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 23
	        			ud_range3up.Value = Convert.ToDecimal(result)
	        		Case 24
	        			ud_range3down.Value = Convert.ToDecimal(result)
	        		Case 25
	        			pn_3up.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 26
	        			pn_3down.BackColor = Color.fromargb(Convert.ToInt32(result))
	        	End Select
	        End If
        Next
  		internalchange = False
		Select Case cb_brushbase.SelectedIndex
			Case 0
				generate_diskbrush(brush,rad)
			Case 1
				generate_polybrush(brush,rad)
			Case 2
				generate_flowerbrush(brush,rad)
		End Select
        
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
	        			diskshademode = Convert.Toint32(result)
	        		Case 3
	        			rings = Convert.Toint32(result)
	        		Case 4
	        			numberofsides = Convert.Toint32(result)
	        		Case 5
	        			rotation = Convert.ToInt32(result)
	        		Case 6
	        			colormode1 = Convert.Toint32(result)
	        		Case 7
	        			colormode2 = Convert.Toint32(result)
					Case 8	        			
						FlowerShapeToolbox.petals = Convert.ToInt32(result)
					Case 9
						FlowerShapeToolbox.centerRing = Convert.ToInt32(result)
					Case 10
						FlowerShapeToolbox.rotation = Convert.ToDouble(result)
					Case 11
						FlowerShapeToolbox.colorMode1 = Convert.ToInt32(result)
					Case 12
						FlowerShapeToolbox.colorMode2 = Convert.ToInt32(result)
					Case 13
						FlowerShapeToolbox.colorMode3 = Convert.ToInt32(result)
	        		Case 14
	        			cb_mode.SelectedIndex = Convert.ToInt32(result)
	        		Case 15
	        			ud_range1up.Value = Convert.ToDecimal(result)
	        		Case 16
	        			ud_range1down.Value = Convert.ToDecimal(result)
	        		Case 17
	        			pn_1up.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 18
	        			pn_1down.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 19
	        			ud_range2up.Value = Convert.ToDecimal(result)
	        		Case 20
	        			ud_range2down.Value = Convert.ToDecimal(result)
	        		Case 21
	        			pn_2up.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 22
	        			pn_2down.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 23
	        			ud_range3up.Value = Convert.ToDecimal(result)
	        		Case 24
	        			ud_range3down.Value = Convert.ToDecimal(result)
	        		Case 25
	        			pn_3up.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 26
	        			pn_3down.BackColor = Color.fromargb(Convert.ToInt32(result))
	        		Case 27
	        			waveupdown1.Value = Convert.ToDecimal(result)
	        		Case 28
	        			frameupdown.Value = Convert.ToDecimal(result)
	        		Case 29
	        			ud_resolution.Value = Convert.ToDecimal(result)
	        		Case 30
	        			nud_zoom.Value = Convert.ToDecimal(result)
	        		Case 31
	        			prec = Convert.ToDouble(result)
       					precisionbox.Text = CStr(prec)
						precudcalc()		
	        		Case 32
	        			rot_ud.Value = Convert.ToDecimal(result)
	        		Case 33
	        			cb_gridmode.SelectedIndex = Convert.ToInt32(result)
	        		Case 34
	        			cb_gridtype.SelectedIndex = Convert.ToInt32(result)
	        		Case 35
	        			radial = Convert.ToInt32(result)
	        		Case 36
	        			phase = Convert.ToInt32(result)
	        		Case 37
	        			spin = Convert.ToInt32(result)
	        		Case 38
	        			peaks = Convert.ToInt32(result)
	        		Case 39
	        			radius = Convert.ToInt32(result)
	        		Case 40
	        			waveupdown2.Value = Convert.ToDecimal(result)
	        		Case 41
				    	bgcolor = Color.fromargb(Convert.ToInt32(result))
						g.clear(bgcolor)
						viewform.imagepanel.refresh
	        	End Select
	        End If
        Next
  		internalchange = False
		Select Case cb_brushbase.SelectedIndex
			Case 0
				generate_diskbrush(brush,rad)
			Case 1
				generate_polybrush(brush,rad)
			Case 2
				generate_flowerbrush(brush,rad)
		End Select
	End Sub
	
	
	Sub Cb_brushbaseSelectedIndexChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			Select Case cb_brushbase.SelectedIndex
				Case 0
					Carpethia.My.Forms.PolygonShapeToolbox.Close
					Carpethia.My.Forms.CircleShapeToolbox.Location = MousePosition
					Carpethia.My.Forms.CircleShapeToolbox.Show
					generate_diskbrush(brush,rad)
				Case 1
					Carpethia.my.Forms.CircleShapeToolbox.Close
					Carpethia.My.Forms.PolygonShapeToolbox.Location = MousePosition
					Carpethia.My.Forms.PolygonShapeToolbox.Show
					generate_polybrush(brush,rad)
				Case 2
					Carpethia.My.Forms.FlowerShapeToolbox.Location = MousePosition
					Carpethia.My.Forms.FlowerShapeToolbox.Show
					generate_flowerbrush(brush,rad)
			End Select
		End if
	End Sub
	
	
	Sub Btn_as1Click(sender As Object, e As EventArgs)
		Carpethia.My.Forms.grid1Toolbox.Location = MousePosition
		Carpethia.My.Forms.grid1Toolbox.Show
	End Sub
	
	
	Sub Btn_as2Click(sender As Object, e As EventArgs)
		Carpethia.My.Forms.grid2Toolbox.Location = MousePosition
		Carpethia.My.Forms.grid2Toolbox.Show
	End Sub
	
	Sub Btn_as3Click(sender As Object, e As EventArgs)
		Carpethia.My.Forms.grid3Toolbox.Location = MousePosition
		Carpethia.My.Forms.grid3Toolbox.Show
	End Sub

	
	Sub Waveupdown2ValueChanged(sender As Object, e As EventArgs)
		wavebar2.Value = convert.ToInt32(waveupdown2.Value)
	End Sub
	
	Sub Wavebar2Scroll(sender As Object, e As EventArgs)
		waveupdown2.Value =	wavebar2.Value
	End Sub
	
	Sub Cb_linkCheckedChanged(sender As Object, e As EventArgs)
		If cb_link.Checked Then
			waveupdown2.value = waveupdown1.Value
			cb_wave2.enabled = False
			cb_wave2.Checked = False
			wavebar2.Enabled = False
			waveupdown2.Enabled = False
		Else
			cb_wave2.enabled = True
			wavebar2.Enabled = True
			waveupdown2.Enabled = True
		End If
	End Sub
	
	
	Sub Ud_resolutionValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then xres2 = Convert.Toint32(ud_resolution.Value)
		gridbar.Value = Convert.ToInt32(ud_resolution.Value)
	End Sub
	
	
	Sub GridbarScroll(sender As Object, e As EventArgs)
		ud_resolution.Value = gridbar.Value	
	End Sub
End Class


