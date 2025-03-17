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
	
	dim xres,yres as integer
	dim rotd, rad As integer 
	dim prec As Double
	
	Dim bgcolor As color
	
	Dim brush As bitmap
	Dim brushfrompicture As bitmap = New Bitmap(201,201,PixelFormat.Format32bppRgb)
	dim g As Graphics
	dim b As Graphics
	
	Dim redbox As Graphics
	Dim greenbox As Graphics
	Dim bluebox As Graphics
	
	Dim redrectangle As Rectangle
	Dim greenrectangle As rectangle
	Dim bluerectangle As Rectangle
	
	Dim red_bitmap As Bitmap
	Dim green_bitmap As Bitmap
	Dim blue_bitmap As Bitmap
	
	Dim viewform As New View()
	Dim canvas As bitmap = New Bitmap(800,800,PixelFormat.Format32bppRgb)
	Dim brushpanel_bitmap As Bitmap = New Bitmap(201,201,PixelFormat.Format32bppRgb)
	
	Dim internalchange As Boolean = False
	Dim abort As Boolean = False
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		MakePicsDir(".\Pics")
		
		red_bitmap = New Bitmap(panel_red.Width, panel_red.Height)
		panel_red.BackgroundImage = red_bitmap
		redbox = Graphics.FromImage(red_bitmap)
		redrectangle.X = 0
		redrectangle.y = 0
		redrectangle.width = panel_red.Width
		redrectangle.height = panel_red.Height
		Dim redbrush As New LinearGradientBrush(redrectangle, Color.FromArgb(ud_rsf.Value,0,0), Color.FromArgb(ud_rst.Value,0,0), LinearGradientMode.Horizontal)		
		redbox.FillRectangle(redbrush, redrectangle)

		green_bitmap = New Bitmap(panel_green.Width, panel_green.Height)
		panel_green.BackgroundImage = green_bitmap
		greenbox = Graphics.FromImage(green_bitmap)
		greenrectangle.X = 0
		greenrectangle.y = 0
		greenrectangle.width = panel_green.Width
		greenrectangle.height = panel_green.Height
		Dim greenbrush As New LinearGradientBrush(greenrectangle, Color.FromArgb(0,ud_gsf.Value,0), Color.FromArgb(0,ud_gst.Value,0), LinearGradientMode.Horizontal)		
		greenbox.FillRectangle(greenbrush, greenrectangle)
		
		blue_bitmap = New Bitmap(panel_blue.Width, panel_blue.Height)
		panel_blue.BackgroundImage = blue_bitmap
		bluebox = Graphics.FromImage(blue_bitmap)
		bluerectangle.X = 0
		bluerectangle.y = 0
		bluerectangle.width = panel_blue.Width
		bluerectangle.height = panel_blue.Height
		Dim bluebrush As New LinearGradientBrush(bluerectangle, Color.FromArgb(0,0,ud_bsf.Value), Color.FromArgb(0,0,ud_bst.Value), LinearGradientMode.Horizontal)		
		bluebox.FillRectangle(bluebrush, bluerectangle)

		xres=800
		yres=800
		rotd = 0
		prec = prec1updown.Value*0.1+prec2updown.Value*0.01+prec3updown.Value*0.001+prec4updown.Value*0.0001+prec5updown.Value*0.00001
		bgcolor = Color.FromName("Black")
				
		viewform.imagepanel.BackgroundImage = canvas
		g = Graphics.FromImage(canvas)
		
		panel_brush.BackgroundImage = brushpanel_bitmap	
		b = Graphics.FromImage(brushpanel_bitmap)
		
		rad = radiusupdown.value
		brush = New Bitmap(rad*2+1,rad*2+1,PixelFormat.Format32bppRgb)
		generate_brush(brush,rad)
		
		viewform.Show
		Me.Show
	End Sub
		
	
	Sub MakePicsDir(path As string)
        ' Specify the directory you want to manipulate.

        Try
            ' Determine whether the directory exists.
            If Directory.Exists(path) Then
                Return
            End If

            ' Try to create the directory.
            Directory.CreateDirectory(path)

        Catch e As Exception
            Console.WriteLine("Pics directory creating failed: {0}.", e.ToString())
        End Try
    End Sub
	
	
	Sub Btn_generateClick(sender As Object, e As EventArgs)
		
		Dim filename As String
		Dim now As Date
		
		If Not viewform.Created Then
			viewform = New View
			viewform.imagepanel.BackgroundImage = canvas
			viewform.Show
		End If
		
		
		If cb_autclr.Checked Then 
			g.clear(bgcolor)
			viewform.imagepanel.Invalidate()
		End If
		
		wave_calculation()
		viewform.imagepanel.Invalidate()
		
		If cb_autosave.Checked Then
			
			filename = Convert.ToString(now.Now.Ticks)
			canvas.Save(".\Pics\" + filename + ".png", imageformat.png)
		End If
		
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
		
	End Sub
	
	
	Sub precudcalc()
		internalchange = True
		prec1updown.Value = Math.Truncate((prec * 10 ) Mod 10)
		prec2updown.Value = Math.Truncate((prec * 100 ) Mod 10)
		prec3updown.Value = Math.Truncate((prec * 1000 ) Mod 10)
		prec4updown.Value = Math.Truncate((prec * 10000 ) Mod 10)
		prec5updown.Value = Math.Truncate((prec * 100000 ) Mod 10)
		internalchange = false
	End Sub
	
	
	Sub wave_calculation()
		dim fact1 as Double
		dim rotr as Double
		Dim x, y As Integer
		Dim	s, t, z As Double
		Dim waves As Integer
	
		waves = waveupdown.value

		viewform.progressBar1.Maximum = (yres+1)
		viewform.progressBar1.visible = True
	
        fact1 = (xres/waves)/(2*Math.PI)
        rotr = Math.PI*rot_ud.value/180
        
        for y = -400 to yres-400
            for x = -400 to xres-400
                s = x*Math.Cos(rotr)+y*Math.sin(rotr)
                t = y*Math.cos(rotr)-x*Math.sin(rotr)
                z = ( Math.cos(s/fact1) + Math.cos(t/fact1) ) / 2
                if z < 0 then z = 0
                If z >= prec Then 
                	plot (x, y)
      	            viewform.progressBar1.Value = (y+400)
                End If
            Next x
        Next y 	
        If abort Then Exit Sub
		viewform.progressBar1.visible = False
	End Sub
	

	Sub plot(ByVal xpos As Integer, ypos As Integer)
		Dim x, y As Integer
		Dim pixelsize As Integer = 4
		Dim brush_pixel, canvas_pixel As Integer
		Dim result_pixel As Integer
		Dim canvas_x, canvas_y As integer
		Dim brush_bmd As BitmapData = brush.LockBits(new Rectangle(0, 0, 2*rad+1, 2*rad+1), System.Drawing.Imaging.ImageLockMode.ReadWrite, brush.PixelFormat)
		Dim canvas_bmd As BitmapData = canvas.LockBits(new Rectangle(0, 0, xres, yres), System.Drawing.Imaging.ImageLockMode.ReadWrite, canvas.PixelFormat)
				
		For x = 0 To brush_bmd.Width-1
			For y = 0 To brush_bmd.Height-1
				brush_pixel = Marshal.Readint32(brush_bmd.Scan0, (brush_bmd.Stride * y) + (pixelsize * x ))
				
				canvas_x = x+xpos+xres/2-rad
				canvas_y = y+ypos+yres/2-rad
				
	            If canvas_x >= 0 And canvas_x < xres And canvas_y >= 0 And canvas_y < yres Then 
					Canvas_pixel = Marshal.Readint32(canvas_bmd.Scan0, canvas_bmd.Stride * canvas_y + pixelsize * canvas_x )
					
					result_pixel = (brush_pixel + canvas_pixel)
					
					Marshal.Writeint32(canvas_bmd.Scan0, canvas_bmd.Stride * canvas_y + pixelsize * canvas_x , result_pixel)
				End if	
	        Next y
		Next x 
		canvas.UnlockBits(canvas_bmd)
		brush.UnlockBits(brush_bmd)
	End Sub
	
	
	Sub generate_brush(byval brush as bitmap, rad as integer)
		dim x, y, y2 as Integer
		Dim y1, z As Double
		Dim c1,c2,c3 As Integer
		Dim plotx, ploty As integer
		Dim col As Color

		For x = -rad To rad
			y1 = rad^2-x^2
			y2 = Math.Sqrt(y1)
			
	        for y = -y2 to y2
	           
	           z = y1-y^2
	           If z < 0 Then z = 0
	           z = (255/rad)*Math.sqrt(z)
	
	            c1 = Math.Round((ud_rsf.Value*(ud_rbt.Value-z)+ud_rst.Value*(z-ud_rbf.Value))/(ud_rbt.Value-ud_rbf.Value))
	            c2 = Math.Round((ud_gsf.Value*(ud_gbt.Value-z)+ud_gst.Value*(z-ud_gbf.Value))/(ud_gbt.Value-ud_gbf.Value))
	            c3 = Math.Round((ud_bsf.Value*(ud_bbt.Value-z)+ud_bst.Value*(z-ud_bbf.Value))/(ud_bbt.Value-ud_bbf.Value))
	            
	            if z < ud_rbf.Value or z > ud_rbt.Value then c1 = 0
	            if z < ud_gbf.Value or z > ud_gbt.Value then c2 = 0
	            If z < ud_bbf.Value Or z > ud_bbt.Value Then c3 = 0
	            
	            plotx = x+rad
	            ploty = y+rad
	            
	            If plotx >= 0 And plotx <= rad*2 And ploty >= 0 And ploty <= rad*2 Then 
	            	col = color.Fromargb (c1,c2,c3)
	            	brush.SetPixel(plotx,ploty, col)
	            End If
	        Next y
		Next x 	
		b.clear(Color.FromName("Black"))
		b.DrawImage(brush, Convert.ToByte(100-rad),Convert.ToByte(100-rad))
		panel_brush.Invalidate
	End Sub
	
		
	Sub WaveupdownValueChanged(sender As Object, e As EventArgs)
		wavebar.Value = waveupdown.Value
	End Sub
	
	
	Sub WavebarScroll(sender As Object, e As EventArgs)
		waveupdown.Value = 	wavebar.Value
	End Sub
	
	
	Sub Rot_udValueChanged(sender As Object, e As EventArgs)
		rotbar.Value = rot_ud.Value
	End Sub
	
	
	Sub RotbarScroll(sender As Object, e As EventArgs)
		rot_ud.Value = rotbar.Value	
	End Sub

	
	Sub RadiusupdownValueChanged(sender As Object, e As EventArgs)
		radiusbar.Value = radiusupdown.Value	
		rad = radiusupdown.value
		brush = New Bitmap(rad*2+1,rad*2+1,PixelFormat.Format32bppRgb)
		generate_brush(brush,rad)
	End Sub
	
	
	Sub RadiusbarScroll(sender As Object, e As EventArgs)
		radiusupdown.Value = radiusbar.Value	
		rad = radiusupdown.value
		brush = New Bitmap(rad*2+1,rad*2+1,PixelFormat.Format32bppRgb)
		generate_brush(brush,rad)
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
	
	
	Sub Ud_rbfValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			generate_brush(brush,rad)
		End If
	End Sub
	
	
	Sub Ud_rbtValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			generate_brush(brush,rad)
		End If
	End Sub
	
	
	Sub Ud_rsfValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			generate_brush(brush,rad)
			Dim redbrush As New LinearGradientBrush(redrectangle, Color.FromArgb(ud_rsf.Value,0,0), Color.FromArgb(ud_rst.Value,0,0), LinearGradientMode.Horizontal)		
			redbox.FillRectangle(redbrush, redrectangle)
			panel_red.Invalidate
		End If
	End Sub
	
	
	Sub Ud_rstValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			generate_brush(brush,rad)
			Dim redbrush As New LinearGradientBrush(redrectangle, Color.FromArgb(ud_rsf.Value,0,0), Color.FromArgb(ud_rst.Value,0,0), LinearGradientMode.Horizontal)		
			redbox.FillRectangle(redbrush, redrectangle)
			panel_red.Invalidate
		End If
	End Sub
	
	
	Sub Ud_gbfValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			generate_brush(brush,rad)
		End If
	End Sub
	
	
	Sub Ud_gbtValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			generate_brush(brush,rad)
		End If
	End Sub
	
	
	Sub Ud_gsfValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			generate_brush(brush,rad)
			Dim greenbrush As New LinearGradientBrush(greenrectangle, Color.FromArgb(0,ud_gsf.Value,0), Color.FromArgb(0,ud_gst.Value,0), LinearGradientMode.Horizontal)		
			greenbox.FillRectangle(greenbrush, greenrectangle)
			panel_green.Invalidate
		End If
	End Sub
	
	
	Sub Ud_gstValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			generate_brush(brush,rad)
			Dim greenbrush As New LinearGradientBrush(greenrectangle, Color.FromArgb(0,ud_gsf.Value,0), Color.FromArgb(0,ud_gst.Value,0), LinearGradientMode.Horizontal)		
			greenbox.FillRectangle(greenbrush, greenrectangle)
			panel_green.Invalidate
		End If
	End Sub
	
	
	Sub Ud_bbfValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			generate_brush(brush,rad)
		End If
	End Sub
	
	
	Sub Ud_bbtValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			generate_brush(brush,rad)
		End If
	End Sub
	
	
	Sub Ud_bsfValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			generate_brush(brush,rad)
			Dim bluebrush As New LinearGradientBrush(bluerectangle, Color.FromArgb(0,0,ud_bsf.Value), Color.FromArgb(0,0,ud_bst.Value), LinearGradientMode.Horizontal)		
			bluebox.FillRectangle(bluebrush, bluerectangle)
			panel_blue.Invalidate
		End If
	End Sub
	
	
	Sub Ud_bstValueChanged(sender As Object, e As EventArgs)
		If Not internalchange Then
			generate_brush(brush,rad)
			Dim bluebrush As New LinearGradientBrush(bluerectangle, Color.FromArgb(0,0,ud_bsf.Value), Color.FromArgb(0,0,ud_bst.Value), LinearGradientMode.Horizontal)		
			bluebox.FillRectangle(bluebrush, bluerectangle)
			panel_blue.Invalidate
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
					rad = (brush.Height-1)/2
					b.DrawImage(brush, Convert.ToByte(100-rad),Convert.ToByte(100-rad))
					panel_brush.Invalidate
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
		viewform.imagepanel.Invalidate()
	End Sub
	
	
	Sub btn_saveClick(sender As Object, e As EventArgs)
		Dim myStream As Stream
		Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "bitmap files (*.png)|*.png"
        saveFileDialog1.RestoreDirectory = True 

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            myStream = saveFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then 
            	brush.Save(myStream, imageformat.png)
                myStream.Close()
            End If 
        End If 
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
	
	
	Sub Panel_brushDoubleClick(sender As Object, e As EventArgs)
		Dim MyDialog As New ColorDialog()
		
	    If (MyDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
	    	bgcolor = MyDialog.Color
			g.clear(bgcolor)
			viewform.imagepanel.Invalidate()
	    End If 
	End Sub
	
	
	Sub Rb_sphereCheckedChanged(sender As Object, e As EventArgs)
		If rb_sphere.Checked Then
			btn_load.Enabled = False
			panel_sphere.Enabled = True
			b.clear(Color.FromName("Black"))
			rad = radiusupdown.value
			brush = New Bitmap(rad*2+1,rad*2+1,PixelFormat.Format32bppRgb)
			generate_brush(brush,rad)
		End If
	End Sub
	
	
	Sub Rb_brushCheckedChanged(sender As Object, e As EventArgs)
		If rb_brush.Checked Then
			panel_sphere.Enabled = false
			btn_load.Enabled = True
			brush = brushfrompicture
			rad = (brush.Height-1)/2
			b.DrawImage(brush, Convert.ToByte(100-rad),Convert.ToByte(100-rad))
			panel_brush.Invalidate

		End If
	End Sub
	
	
	Sub Btn_randomClick(sender As Object, e As EventArgs)
		Dim random As New Random()
		Dim waves As Integer
		Dim precision As Double
		Dim radius As Integer
		Dim rbl, rbh As Byte
		Dim rcl, rch As Byte
		Dim gbl, gbh As Byte
		Dim gcl, gch As Byte
		Dim bbl, bbh As Byte
		Dim bcl, bch As Byte
		Dim bgr, bgg, bgb As Byte
		
		radius = random.Next(30,100)
		waves = random.Next(100-radius+10,200-radius)
		precision = random.Next(0,299)
		rbl = random.Next(0,255)
		rbh = random.Next(rbl,255)
		gbl = random.Next(0,255)
		gbh = random.Next(gbl,255)
		bbl = random.Next(0,255)
		bbh = random.Next(bbl,255)
		
		rcl = random.Next(0,255)
		rch = random.Next(0,255)
		gcl = random.Next(0,255)
		gch = random.Next(0,255)
		bcl = random.Next(0,255)
		bch = random.Next(0,255)
		
		bgr = random.Next(0,100)
		bgg = random.Next(0,100)
		bgb = random.Next(0,100)
		
		waveupdown.Value = waves
		prec = 0.997 + precision/100000
		precisionbox.Text = CStr(prec)
		precudcalc()		
		radiusupdown.Value = radius
		
		internalchange = True
		ud_rbf.Value = rbl
		ud_rbt.Value = rbh
		ud_rsf.Value = rcl
		ud_rst.Value = rch
		ud_gbf.Value = gbl
		ud_gbt.Value = gbh
		ud_gsf.Value = gcl
		ud_gst.Value = gch
		ud_bbf.Value = bbl
		ud_bbt.Value = bbh
		ud_bsf.Value = bcl
		internalchange = False
		ud_bst.Value = bch
		
		bgcolor = Color.FromArgb(bgr,bgg,bgb)
		g.clear(bgcolor)
		viewform.imagepanel.Invalidate()
		
		rb_sphere.checked = True
 		
	End Sub
	
	
	Sub LinkLabel1LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
		Me.LinkLabel1.LinkVisited = True 
        System.Diagnostics.Process.Start("http://projectkaleidoscope.site11.com")
	End Sub
	
	
	Sub Saveparams()
		
		MakePicsDir(".\Params")
		
        Dim path As String = "c:\temp\MyTest.txt" 
        If File.Exists(path) = False Then 
            ' Create a file to write to. 
            Using sw As StreamWriter = File.CreateText(path)
                sw.WriteLine("Hello")
                sw.WriteLine("And")
                sw.WriteLine("Welcome")
                sw.Flush()
           End Using 
        End If 

		
		
	End Sub
	
	
	Sub LoadParams()
		
        Dim path As String = "c:\temp\MyTest.txt" 
		
        ' Open the file to read from. 
        Using sr As StreamReader = File.OpenText(path)
            Do While sr.Peek() >= 0
                Console.WriteLine(sr.ReadLine())
            Loop 
        End Using 
		
		
		
	End Sub
	
End Class


