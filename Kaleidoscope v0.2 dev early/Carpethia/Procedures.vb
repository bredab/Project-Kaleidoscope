'
' Created by SharpDevelop.
' User: Blaster
' Date: 2013.01.18.
' Time: 17:19
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices


Public Partial Class MainForm
	
	
	Sub MakePicsDir(path As string)
        Try
            If Directory.Exists(path) Then
                Return
            End If

            Directory.CreateDirectory(path)

        Catch e As Exception
            Console.WriteLine("Directory creating failed: {0}.", e.ToString())
        End Try
    End Sub
	
	
	Sub Saveparams(path As String)
		
            Using sw As StreamWriter = File.CreateText(path)
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
           	End Using 
	End Sub
	
	
    Private Function FindParam(ByVal paramline As String) As Boolean
        If paramline.StartsWith(paramstr) Then
            Return True
        Else
            Return False
        End If
    End Function
	
	
	Sub precudcalc()
		internalchange = True
		prec1updown.Value = Convert.ToDecimal(Math.Truncate((prec * 10 ) Mod 10))
		prec2updown.Value = Convert.ToDecimal(Math.Truncate((prec * 100 ) Mod 10))
		prec3updown.Value = Convert.ToDecimal(Math.Truncate((prec * 1000 ) Mod 10))
		prec4updown.Value = Convert.ToDecimal(Math.Truncate((prec * 10000 ) Mod 10))
		prec5updown.Value = Convert.ToDecimal(Math.Truncate((prec * 100000 ) Mod 10))
		internalchange = false
	End Sub
	
	
	Public sub wave_calculation1(rad As Integer)
		dim fact1,fact2 as Double
		dim rotr as Double
		Dim x, y As Integer
		Dim	s, t, z As Double
		Dim waves As Double
		Dim frame as Integer
		Dim rot2 As Double = 0
		Dim mode As Integer
		Dim zoom As Integer
		Dim phasex As Integer = 0
		Dim phasey As Integer = 0
		Dim wave1, wave2 As Double
		Dim wavex, wavey As Double
			
		zoom = Convert.Toint32(nud_zoom.Value)
		waves = waveupdown.value
		frame = Convert.Toint32(framebar.Value-xres/2)
		frame = -(-frame \ zoom) * zoom
		viewform.progressBar1.Maximum = (yres-2*framebar.Value+1)
		viewform.progressBar1.visible = True
		mode = Convert.ToByte(cb_gridmode.SelectedIndex)
		
		wave1 = waveupdown.value
		'wave2 = waveupdown2.value
		wave2 = wave1
		
		If (xres2 \ Convert.ToInt64(waves)) <= 20 And ((xres2*zoom) mod waves) = 0 Then 
			fact1 = (((xres2*zoom)-1)/waves)/(2*Math.PI)
		Else
			fact1 = ((xres2*zoom)/waves)/(2*Math.PI)
		End if
        rotr = Math.PI*rot_ud.value/180
        If cb_gridtype.SelectedIndex = 1 Then rot2 = Math.PI/6
        
        for y = frame to -frame Step zoom
            for x = frame to -frame Step zoom
                s = x*Math.Cos(rotr+rot2+rot2)+y*Math.sin(rotr+rot2+rot2)
                t = y*Math.cos(rotr+rot2)-x*Math.sin(rotr+rot2)
                wavex = Math.Abs(x)*(wave2-wave1)/400+wave1
                wavey = Math.Abs(y)*(wave2-wave1)/400+wave1
                fact1 = ((xres2*zoom)/wavex)/(2*Math.PI)
                fact2 = ((xres2*zoom)/wavey)/(2*Math.PI)
                Select Case mode
                	Case 0
	                	z = ( Math.cos((s+phasex)/(fact1)) + Math.cos((t+phasey)/(fact2)) ) / 2
                	Case 1
	                	z = Math.Abs( Math.cos(s/fact1) + Math.cos(t/fact1) ) / 2
                	Case 2
	                	z = ( Math.Abs(Math.cos(s/fact1)) + Math.Abs(Math.cos(t/fact1)) ) / 2
                	Case 3
	                	z = Math.Sqrt(Math.Abs( Math.cos(s/fact1) + Math.cos(t/fact1) ) / 2)
                	Case 4
	                	z = ( Math.Sqrt(Math.Abs(Math.cos(s/fact1))) + Math.Sqrt(Math.Abs(Math.cos(t/fact1))) ) / 2
                	Case 5
	                	z = ( Math.cos(s/fact1) - Math.cos(t/fact1) ) / 2
                	Case 6
	                	z = Math.Abs( Math.cos(s/fact1) - Math.cos(t/fact1) ) / 2
                	Case 7
	                	z = Math.Sqrt(Math.Abs( Math.cos(s/fact1) - Math.cos(t/fact1) ) / 2)
	                Case 8
	                	z = ( Math.cos(s/fact1) * Math.cos(t/fact1) )
                	Case 9
	                	z = Math.Abs( Math.cos(s/fact1) * Math.cos(t/fact1) )
            	End Select
                if z < 0 then z = 0
                If z >= prec Then 
                	plot (x, y, rad)
                	viewform.progressBar1.Value = (y-frame)
                End If
            Next x
        Next y 	
		viewform.progressBar1.visible = False
	End Sub
	
	
	Sub wave_calculation2(rad As Integer)
		dim fact1, rotr as Double
		Dim q, x, y As Integer
		Dim	fi, r, z As Double
		Dim waves As Integer
		Dim frame As Integer
	
		waves = Convert.Toint32(waveupdown.value)
		viewform.progressBar1.Maximum = radial
		viewform.progressBar1.visible = True
        fact1 = (xres2/waves)/(2*Math.PI)
        rotr = Math.PI*rot_ud.value/180
        frame = framebar.Value

        for q = 0 To radial-1
            for r = 0 to 500-frame
            	fi = q*Math.PI*2/radial + rotr + (r/500-frame)*(Math.PI*spin/180)         
                z =  Math.cos( (r + phase) / fact1)
                If z >= prec Then
                	x = Convert.Toint32((Convert.Toint32(r) + phase) * Math.Sin(fi))
                	y = Convert.Toint32((Convert.Toint32(r) + phase) * Math.Cos(fi))
                	plot (x, y, rad)
      	            viewform.progressBar1.Value = q
                End If
            Next 
        Next 	
		viewform.progressBar1.visible = False
	End Sub
	
	
	Public sub wave_calculation3(rad As Integer)
		dim fact1 as Double
		dim rotr as Double
		Dim x, y As Integer
		Dim	s, t, z As Double
		Dim waves As Double
		Dim frame as Integer
		Dim rot2 As Double = 0
		Dim mode As Integer
		Dim zoom As Integer
			
		zoom = Convert.Toint32(nud_zoom.Value)			
			
		waves = waveupdown.value
		frame = Convert.Toint32(framebar.Value-xres/2)
		frame = -(-frame \ zoom) * zoom
		viewform.progressBar1.Maximum = (yres-2*framebar.Value+1)
		viewform.progressBar1.visible = True
		mode = Convert.ToByte(cb_gridmode.SelectedIndex)
		
		fact1 = ((xres2*zoom)/waves)/(2*Math.PI)
        rotr = Math.PI*rot_ud.value/180
        If cb_gridtype.SelectedIndex = 1 Or cb_gridtype.SelectedIndex = 4 Then rot2 = Math.PI/6
        
        for y = frame to -frame
            for x = frame to -frame
                s = x*Math.Cos(rotr+rot2+rot2)+y*Math.sin(rotr+rot2+rot2)
                t = y*Math.cos(rotr+rot2)-x*Math.sin(rotr+rot2)
                Select Case mode
                	Case 0
                		If (y = 0) Or (x = 0) Then
                			z =  (Math.cos(s/fact1) + Math.cos(t/fact1)) / 2 
                		Else
                			z = ( Math.cos(s/fact1) + Math.cos(t/fact1) + Math.cos( Math.Sqrt(x^2 + y^2) / fact1) ) / 3
                		End If 
                	Case 1
                		If (y = 0) Or (x = 0) Then
                			z = Math.Abs( Math.cos(s/fact1) + Math.cos(t/fact1) ) / 2 
                		Else
                			z = Math.Abs( Math.cos(s/fact1) + Math.cos(t/fact1) + Math.cos( Math.Sqrt(x^2 + y^2) / fact1) ) / 3
                		End If 
                	Case 2
                		If (y = 0) Or (x = 0) Then
                			z = ( Math.Abs(Math.cos(s/fact1)) + Math.Abs(Math.cos(t/fact1)) ) / 2 
                		Else
                			z = (Math.Abs( Math.cos(s/fact1)) + Math.Abs(Math.cos(t/fact1)) + Math.Abs(Math.cos( Math.Sqrt(x^2 + y^2) / fact1)) ) / 3
                		End If 
                	Case 3
                		If (y = 0) Or (x = 0) Then
                			z = Math.Sqrt(Math.Abs( Math.cos(s/fact1) + Math.cos(t/fact1) ) / 2) 
                		Else
                			z = Math.Sqrt(Math.Abs( Math.cos(s/fact1) + Math.cos(t/fact1) + Math.cos( Math.Sqrt(x^2 + y^2) / fact1) ) / 3)
                		End If 
                	Case 4
                		If (y = 0) Or (x = 0) Then
                			z = ( Math.Sqrt(Math.Abs(Math.cos(s/fact1))) + Math.Sqrt(Math.Abs(Math.cos(t/fact1))) ) / 2 
                		Else
                			z = ( Math.Sqrt(Math.Abs(Math.cos(s/fact1))) + Math.Sqrt(Math.Abs(Math.cos(t/fact1))) + Math.Abs(Math.cos( Math.Sqrt(x^2 + y^2) / fact1))) / 3
                		End If 
                	Case 5
                		If (y = 0) Or (x = 0) Then
                			z =  (Math.cos(s/fact1) - Math.cos(t/fact1)) / 2 
                		Else
                			z = ( Math.cos(s/fact1) - Math.cos(t/fact1) - Math.cos( Math.Sqrt(x^2 + y^2) / fact1) ) / 3
                		End If 
                	Case 6
                		If (y = 0) Or (x = 0) Then
                			z = Math.Abs( Math.cos(s/fact1) - Math.cos(t/fact1) ) / 2 
                		Else
                			z = Math.Abs( Math.cos(s/fact1) - Math.cos(t/fact1) - Math.cos( Math.Sqrt(x^2 + y^2) / fact1) ) / 3
                		End If 
                	Case 7
                		If (y = 0) Or (x = 0) Then
                			z = Math.Sqrt(Math.Abs( Math.cos(s/fact1) - Math.cos(t/fact1) ) / 2) 
                		Else
                			z = Math.Sqrt(Math.Abs( Math.cos(s/fact1) - Math.cos(t/fact1) - Math.cos( Math.Sqrt(x^2 + y^2) / fact1) ) / 3)
                		End If 
	                Case 8
                		If (y = 0) Or (x = 0) Then
                			z =  (Math.cos(s/fact1) * Math.cos(t/fact1)) 
                		Else
                			z = ( Math.cos(s/fact1) * Math.cos(t/fact1) * Math.cos( Math.Sqrt(x^2 + y^2) / fact1) )
                		End If 
                	Case 9
                		If (y = 0) Or (x = 0) Then
                			z =  Math.Abs(Math.cos(s/fact1) * Math.cos(t/fact1)) 
                		Else
                			z = Math.Abs( Math.cos(s/fact1) * Math.cos(t/fact1) * Math.cos( Math.Sqrt(x^2 + y^2) / fact1) )
                		End If 
            	End Select
                if z < 0 then z = 0
                If z >= prec Then 
                	plot (x, y, rad)
                	viewform.progressBar1.Value = (y-frame)
                End If
            Next x
        Next y 	
		viewform.progressBar1.visible = False
	End Sub
	
	
	Public sub wave_calculation4(rad As Integer)
		dim fact1 as Double
		Dim rotr As Double
		Dim q As Integer
		Dim x, y As Integer
		Dim x1, y1 As Integer
		Dim	z As Double
		Dim waves As Double
		Dim frame as Integer
		Dim mode As Integer
		Dim zoom As Integer
			
		zoom = Convert.Toint32(nud_zoom.Value)			
			
		waves = waveupdown.value
		frame = Convert.Toint32(framebar.Value-xres/2)
		frame = -(-frame \ zoom) * zoom
		viewform.progressBar1.Maximum = (yres-2*framebar.Value+1)
		viewform.progressBar1.visible = True
		mode = Convert.ToByte(cb_gridmode.SelectedIndex)

		fact1 = ((xres2*zoom)/waves)/(2*Math.PI)
		rotr = Math.PI*rot_ud.value/180
        
        for y = frame to -frame
        	For x = frame To -frame
             Select Case mode
            	Case 0
	        		z = 0
	        		For q = 0 To peaks-1
	        			x1 = Convert.ToInt32(Math.Cos((q*Math.PI*2)/peaks + Math.PI/2 + rotr) * radius)
	        			y1 = Convert.ToInt32(Math.sin((q*Math.PI*2)/peaks + Math.PI/2 + rotr) * radius)
	        			z =  z + Math.cos(Math.Sqrt((x+x1)^2 + (y+y1)^2) / fact1)
	        		Next q
	        		z = z / peaks
            	Case 1
	        		z = 0
	        		For q = 0 To peaks-1
	        			x1 = Convert.ToInt32(Math.Cos((q*Math.PI*2)/peaks + Math.PI/2 + rotr) * radius)
	        			y1 = Convert.ToInt32(Math.sin((q*Math.PI*2)/peaks + Math.PI/2 + rotr) * radius)
	        			z =  z + Math.Abs(Math.cos(Math.Sqrt((x+x1)^2 + (y+y1)^2) / fact1))
	        		Next q
	        		z = z / peaks
            	Case 2
	        		z = 0
	        		For q = 0 To peaks-1
	        			x1 = Convert.ToInt32(Math.Cos((q*Math.PI*2)/peaks + Math.PI/2 + rotr) * radius)
	        			y1 = Convert.ToInt32(Math.sin((q*Math.PI*2)/peaks + Math.PI/2 + rotr) * radius)
	        			z =  z + Math.Sqrt(Math.Abs(Math.cos(Math.Sqrt((x+x1)^2 + (y+y1)^2) / fact1)))
	        		Next q
	        		z = z / peaks
            	Case 3
	        		z = 0
	        		For q = 0 To peaks-1
	        			x1 = Convert.ToInt32(Math.Cos((q*Math.PI*2)/peaks + Math.PI/2 + rotr) * radius)
	        			y1 = Convert.ToInt32(Math.sin((q*Math.PI*2)/peaks + Math.PI/2 + rotr) * radius)
	        			z =  z - Math.cos(Math.Sqrt((x+x1)^2 + (y+y1)^2) / fact1)
	        		Next q
	        		z = z / peaks
            	Case 4
	        		z = 0
	        		For q = 0 To peaks-1
	        			x1 = Convert.ToInt32(Math.Cos((q*Math.PI*2)/peaks + Math.PI/2 + rotr) * radius)
	        			y1 = Convert.ToInt32(Math.sin((q*Math.PI*2)/peaks + Math.PI/2 + rotr) * radius)
	        			z =  z - Math.cos(Math.Sqrt((x+x1)^2 + (y+y1)^2) / fact1)
	        		Next q
	        		z = Math.Abs(z) / peaks
            	Case 5
	        		z = 0
	        		For q = 0 To peaks-1
	        			x1 = Convert.ToInt32(Math.Cos((q*Math.PI*2)/peaks + Math.PI/2 + rotr) * radius)
	        			y1 = Convert.ToInt32(Math.sin((q*Math.PI*2)/peaks + Math.PI/2 + rotr) * radius)
	        			z =  z - Math.cos(Math.Sqrt((x+x1)^2 + (y+y1)^2) / fact1)
	        		Next q
	        		z = Math.Sqrt(Math.Abs(z) / peaks)
            	Case 6
	        		z = 1
	        		For q = 0 To peaks-1
	        			x1 = Convert.ToInt32(Math.Cos((q*Math.PI*2)/peaks + Math.PI/2 + rotr) * radius)
	        			y1 = Convert.ToInt32(Math.sin((q*Math.PI*2)/peaks + Math.PI/2 + rotr) * radius)
	        			z =  z * Math.cos(Math.Sqrt((x+x1)^2 + (y+y1)^2) / fact1)
	        		Next q
            	Case 7
	        		z = 1
	        		For q = 0 To peaks-1
	        			x1 = Convert.ToInt32(Math.Cos((q*Math.PI*2)/peaks + Math.PI/2 + rotr) * radius)
	        			y1 = Convert.ToInt32(Math.sin((q*Math.PI*2)/peaks + Math.PI/2 + rotr) * radius)
	        			z =  z * Math.Abs(Math.cos(Math.Sqrt((x+x1)^2 + (y+y1)^2) / fact1))
	        		Next q
            	Case 8
	        		z = 1
	        		For q = 0 To peaks-1
	        			x1 = Convert.ToInt32(Math.Cos((q*Math.PI*2)/peaks + Math.PI/2 + rotr) * radius)
	        			y1 = Convert.ToInt32(Math.sin((q*Math.PI*2)/peaks + Math.PI/2 + rotr) * radius)
	        			z =  z * Math.Sqrt(Math.Abs(Math.cos(Math.Sqrt((x+x1)^2 + (y+y1)^2) / fact1)))
	        		Next q
        	End Select
        		if z < 0 then z = 0
                If z >= prec Then 
                	plot (x, y, rad)
                	'plot_raw(x,y,z)
                	viewform.progressBar1.Value = (y-frame)
                End If
            Next x
        Next y 	
		viewform.progressBar1.visible = False
	End Sub
	
	
	Sub plot(ByVal xpos As Integer, ypos As Integer, rad As Integer)
		Dim x, y As Integer
		Dim pixelsize As Integer = 4
		Dim brush_pixel, canvas_pixel As Integer
		Dim result_pixel As Integer
		Dim canvas_x, canvas_y As integer
		Dim brush_bmd As BitmapData = brush.LockBits(new Rectangle(0, 0, 2*rad+1, 2*rad+1), System.Drawing.Imaging.ImageLockMode.ReadWrite, brush.PixelFormat)
		Dim canvas_bmd As BitmapData = canvas.LockBits(new Rectangle( Convert.ToInt32((800-xres)/2), Convert.ToInt32((800-yres)/2), xres, yres), System.Drawing.Imaging.ImageLockMode.ReadWrite, canvas.PixelFormat)
		Dim mode As Integer
		
		mode = Convert.ToByte(cb_mode.SelectedIndex)
		
		For x = 0 To brush_bmd.Width-1
			For y = 0 To brush_bmd.Height-1
				brush_pixel = Marshal.Readint32(brush_bmd.Scan0, (brush_bmd.Stride * y) + (pixelsize * x ))
				
				canvas_x = Convert.ToInt32(x+xpos+xres/2-rad)
				canvas_y = Convert.ToInt32(y+ypos+yres/2-rad)
				
	            If canvas_x >= 0 And canvas_x <= xres And canvas_y >= 0 And canvas_y <= yres Then 
					Canvas_pixel = Marshal.Readint32(canvas_bmd.Scan0, canvas_bmd.Stride * canvas_y + pixelsize * canvas_x )
					
					Select Case mode
						Case 0
							result_pixel = (brush_pixel + canvas_pixel)
						Case 1
							result_pixel = ( (Not brush_pixel) - ( Not canvas_pixel) )
						Case 2
							result_pixel = (brush_pixel Xor canvas_pixel)
					End Select
					
					Marshal.Writeint32(canvas_bmd.Scan0, canvas_bmd.Stride * canvas_y + pixelsize * canvas_x , result_pixel)
				End if	
			Next y
		Next x 
		canvas.UnlockBits(canvas_bmd)
		brush.UnlockBits(brush_bmd)
	End Sub
	
	
	Sub plot_raw(ByVal xpos As Integer, ypos As Integer, z As Double)
		Dim pixelsize As Integer = 4
		Dim result_pixel As Integer
		Dim canvas_x, canvas_y As integer
		Dim canvas_bmd As BitmapData = canvas.LockBits(new Rectangle( Convert.ToInt32((800-xres)/2), Convert.ToInt32((800-yres)/2), xres, yres), System.Drawing.Imaging.ImageLockMode.ReadWrite, canvas.PixelFormat)
		Dim z1 As Integer
		
		canvas_x = Convert.ToInt32(xpos+xres/2)
		canvas_y = Convert.ToInt32(ypos+yres/2)
		
		z1 = Convert.ToByte(z * 255)
		
		result_pixel = z1 + z1 * 256 + z1 * 256 * 256		
		
		Marshal.Writeint32(canvas_bmd.Scan0, canvas_bmd.Stride * canvas_y + pixelsize * canvas_x , result_pixel)
				
		canvas.UnlockBits(canvas_bmd)
	End Sub
	
	
	Sub generate_diskbrush(byval brush as bitmap, rad as integer)
		Dim x, y As Integer
		Dim r, z, z1, z2 As Double
		Dim c1,c2,c3 As Integer
		Dim r1_r, r1_g, r1_b As Integer
		Dim r2_r, r2_g, r2_b As Integer
		Dim r3_r, r3_g, r3_b As Integer
		Dim r1, r2 As Integer
		Dim g1, g2 As Integer
		Dim b1, b2 As Integer
		Dim plotx, ploty As Integer
		Dim range1up, range1down, range2up, range2down, range3up, range3down As Byte
		Dim pixelsize As Integer = 4
		Dim brush_pixel As Integer
		Dim brush_bmd As BitmapData = brush.LockBits(new Rectangle(0, 0, 2*rad+1, 2*rad+1), System.Drawing.Imaging.ImageLockMode.ReadWrite, brush.PixelFormat)
			
		range1up = Convert.ToByte(tb_range1up.Value)
		range1down = Convert.ToByte(tb_range1down.Value)
		range2up = Convert.ToByte(tb_range2up.Value)
		range2down = Convert.ToByte(tb_range2down.Value)
		range3up = Convert.ToByte(tb_range3up.Value)
		range3down = Convert.ToByte(tb_range3down.Value)
		
		
		Select Case diskshademode
			Case 0	'gömb
				For x = -rad To rad
					For y = -rad To rad
						r = Math.Sqrt(x*x + y*y)
		        		z = rad*rad-r*r
		        		If z < 0 Then z = 0
		        		z = (255*Math.Sqrt(z))/rad
						If r > (range1up*rad)/100 Or r < (range1down*rad)/100 Or range1up = range1down Then
			            	r1_r = 0
			            	r1_g = 0
			            	r1_b = 0
			            Else
			            	r1 = pn_1up.BackColor.R
			            	r2 = pn_1down.BackColor.R
			            	g1 = pn_1up.BackColor.G
			            	g2 = pn_1down.BackColor.G
			            	b1 = pn_1up.BackColor.B
			            	b2 = pn_1down.BackColor.B
			            	z1 = (255*Math.Sqrt(rad*rad-(range1up*rad)/100*(range1up*rad)/100))/rad
			            	z2 = (255*Math.Sqrt(rad*rad-(range1down*rad)/100*(range1down*rad)/100))/rad
			            	r1_r = Convert.ToInt32(((z-z1)*(r2-r1))/(z2-z1)+r1)
			            	r1_g = Convert.ToInt32(((z-z1)*(g2-g1))/(z2-z1)+g1)
			            	r1_b = Convert.ToInt32(((z-z1)*(b2-b1))/(z2-z1)+b1)
			            End If
			            If r > (range2up*rad)/100 Or r < (range2down*rad)/100 Or range2up = range2down Then
			            	r2_r = 0
			            	r2_g = 0
			            	r2_b = 0
			            Else
			            	r1 = pn_2up.BackColor.R
			            	r2 = pn_2down.BackColor.R
			            	g1 = pn_2up.BackColor.G
			            	g2 = pn_2down.BackColor.G
			            	b1 = pn_2up.BackColor.B
			            	b2 = pn_2down.BackColor.B
			            	z1 = (255*Math.Sqrt(rad*rad-(range2up*rad)/100*(range2up*rad)/100))/rad
			            	z2 = (255*Math.Sqrt(rad*rad-(range2down*rad)/100*(range2down*rad)/100))/rad
			            	r2_r = Convert.ToInt32(((z-z1)*(r2-r1))/(z2-z1)+r1)
			            	r2_g = Convert.ToInt32(((z-z1)*(g2-g1))/(z2-z1)+g1)
			            	r2_b = Convert.ToInt32(((z-z1)*(b2-b1))/(z2-z1)+b1)
			            End If
			            If r > (range3up*rad)/100 Or r < (range3down*rad)/100 Or range3up = range3down Then
			            	r3_r = 0
			            	r3_g = 0
			            	r3_b = 0
			            Else
			            	r1 = pn_3up.BackColor.R
			            	r2 = pn_3down.BackColor.R
			            	g1 = pn_3up.BackColor.G
			            	g2 = pn_3down.BackColor.G
			            	b1 = pn_3up.BackColor.B
			            	b2 = pn_3down.BackColor.B
			            	z1 = (255*Math.Sqrt(rad*rad-(range3up*rad)/100*(range3up*rad)/100))/rad
			            	z2 = (255*Math.Sqrt(rad*rad-(range3down*rad)/100*(range3down*rad)/100))/rad
			            	r3_r = Convert.ToInt32(((z-z1)*(r2-r1))/(z2-z1)+r1)
			            	r3_g = Convert.ToInt32(((z-z1)*(g2-g1))/(z2-z1)+g1)
			            	r3_b = Convert.ToInt32(((z-z1)*(b2-b1))/(z2-z1)+b1)
			            End If
			            c1 = r1_r + r2_r + r3_r
			            c2 = r1_g + r2_g + r3_g
			            c3 = r1_b + r2_b + r3_b
			            if c1 > 255 then c1 = 255
			            if c2 > 255 then c2 = 255
			            if c3 > 255 then c3 = 255
			            plotx = x+rad
			            ploty = y+rad
			            brush_pixel = c3 + 256*c2 + 256*256*c1
       					Marshal.Writeint32(brush_bmd.Scan0, brush_bmd.Stride * ploty + pixelsize * plotx , brush_pixel)
					Next
				Next
			Case 1	'parabola
				For x = -rad To rad
					For y = -rad To rad
						r = Math.Sqrt(x*x + y*y)
			           	z = (255*(rad*rad-r*r))/(rad*rad)
						If r > (range1up*rad)/100 Or r < (range1down*rad)/100 Or range1up = range1down Then
			            	r1_r = 0
			            	r1_g = 0
			            	r1_b = 0
			            Else
			            	r1 = pn_1up.BackColor.R
			            	r2 = pn_1down.BackColor.R
			            	g1 = pn_1up.BackColor.G
			            	g2 = pn_1down.BackColor.G
			            	b1 = pn_1up.BackColor.B
			            	b2 = pn_1down.BackColor.B
			            	z1 = (255*(rad*rad-(range1up*rad)/100*(range1up*rad)/100))/(rad*rad)
			            	z2 = (255*(rad*rad-(range1down*rad)/100*(range1down*rad)/100))/(rad*rad)
			            	r1_r = Convert.ToInt32(((z-z1)*(r2-r1))/(z2-z1)+r1)
			            	r1_g = Convert.ToInt32(((z-z1)*(g2-g1))/(z2-z1)+g1)
			            	r1_b = Convert.ToInt32(((z-z1)*(b2-b1))/(z2-z1)+b1)
			            End If
			            If r > (range2up*rad)/100 Or r < (range2down*rad)/100 Or range2up = range2down Then
			            	r2_r = 0
			            	r2_g = 0
			            	r2_b = 0
			            Else
			            	r1 = pn_2up.BackColor.R
			            	r2 = pn_2down.BackColor.R
			            	g1 = pn_2up.BackColor.G
			            	g2 = pn_2down.BackColor.G
			            	b1 = pn_2up.BackColor.B
			            	b2 = pn_2down.BackColor.B
			            	z1 = (255*(rad*rad-(range2up*rad)/100*(range2up*rad)/100))/(rad*rad)
			            	z2 = (255*(rad*rad-(range2down*rad)/100*(range2down*rad)/100))/(rad*rad)
			            	r2_r = Convert.ToInt32(((z-z1)*(r2-r1))/(z2-z1)+r1)
			            	r2_g = Convert.ToInt32(((z-z1)*(g2-g1))/(z2-z1)+g1)
			            	r2_b = Convert.ToInt32(((z-z1)*(b2-b1))/(z2-z1)+b1)
			            End If
			            If r > (range3up*rad)/100 Or r < (range3down*rad)/100 Or range3up = range3down Then
			            	r3_r = 0
			            	r3_g = 0
			            	r3_b = 0
			            Else
			            	r1 = pn_3up.BackColor.R
			            	r2 = pn_3down.BackColor.R
			            	g1 = pn_3up.BackColor.G
			            	g2 = pn_3down.BackColor.G
			            	b1 = pn_3up.BackColor.B
			            	b2 = pn_3down.BackColor.B
			            	z1 = (255*(rad*rad-(range3up*rad)/100*(range3up*rad)/100))/(rad*rad)
			            	z2 = (255*(rad*rad-(range3down*rad)/100*(range3down*rad)/100))/(rad*rad)
			            	r3_r = Convert.ToInt32(((z-z1)*(r2-r1))/(z2-z1)+r1)
			            	r3_g = Convert.ToInt32(((z-z1)*(g2-g1))/(z2-z1)+g1)
			            	r3_b = Convert.ToInt32(((z-z1)*(b2-b1))/(z2-z1)+b1)
			            End If
			            c1 = r1_r + r2_r + r3_r
			            c2 = r1_g + r2_g + r3_g
			            c3 = r1_b + r2_b + r3_b
			            if c1 > 255 then c1 = 255
			            if c2 > 255 then c2 = 255
			            if c3 > 255 then c3 = 255
			            plotx = x+rad
			            ploty = y+rad
			            brush_pixel = c3 + 256*c2 + 256*256*c1
       					Marshal.Writeint32(brush_bmd.Scan0, brush_bmd.Stride * ploty + pixelsize * plotx , brush_pixel)
					Next
				Next
			Case 2	'kúp
				For x = -rad To rad
					For y = -rad To rad
						r = Math.Sqrt(x*x + y*y)
						z = (-255*r)/rad+255
						If r > (range1up*rad)/100 Or r < (range1down*rad)/100 Or range1up = range1down Then
			            	r1_r = 0
			            	r1_g = 0
			            	r1_b = 0
			            Else
			            	r1 = pn_1up.BackColor.R
			            	r2 = pn_1down.BackColor.R
			            	g1 = pn_1up.BackColor.G
			            	g2 = pn_1down.BackColor.G
			            	b1 = pn_1up.BackColor.B
			            	b2 = pn_1down.BackColor.B
			            	z1 = (-255*range1up)/100+255
			            	z2 = (-255*range1down)/100+255
			            	r1_r = Convert.ToInt32(((z-z1)*(r2-r1))/(z2-z1)+r1)
			            	r1_g = Convert.ToInt32(((z-z1)*(g2-g1))/(z2-z1)+g1)
			            	r1_b = Convert.ToInt32(((z-z1)*(b2-b1))/(z2-z1)+b1)
			            End If
			            If r > (range2up*rad)/100 Or r < (range2down*rad)/100 Or range2up = range2down Then
			            	r2_r = 0
			            	r2_g = 0
			            	r2_b = 0
			            Else
			            	r1 = pn_2up.BackColor.R
			            	r2 = pn_2down.BackColor.R
			            	g1 = pn_2up.BackColor.G
			            	g2 = pn_2down.BackColor.G
			            	b1 = pn_2up.BackColor.B
			            	b2 = pn_2down.BackColor.B
			            	z1 = (-255*range2up)/100+255
			            	z2 = (-255*range2down)/100+255
			            	r2_r = Convert.ToInt32(((z-z1)*(r2-r1))/(z2-z1)+r1)
			            	r2_g = Convert.ToInt32(((z-z1)*(g2-g1))/(z2-z1)+g1)
			            	r2_b = Convert.ToInt32(((z-z1)*(b2-b1))/(z2-z1)+b1)
			            End If
			            If r > (range3up*rad)/100 Or r < (range3down*rad)/100 Or range3up = range3down Then
			            	r3_r = 0
			            	r3_g = 0
			            	r3_b = 0
			            Else
			            	r1 = pn_3up.BackColor.R
			            	r2 = pn_3down.BackColor.R
			            	g1 = pn_3up.BackColor.G
			            	g2 = pn_3down.BackColor.G
			            	b1 = pn_3up.BackColor.B
			            	b2 = pn_3down.BackColor.B
			            	z1 = (-255*range3up)/100+255
			            	z2 = (-255*range3down)/100+255
			            	r3_r = Convert.ToInt32(((z-z1)*(r2-r1))/(z2-z1)+r1)
			            	r3_g = Convert.ToInt32(((z-z1)*(g2-g1))/(z2-z1)+g1)
			            	r3_b = Convert.ToInt32(((z-z1)*(b2-b1))/(z2-z1)+b1)
			            End If
			            c1 = r1_r + r2_r + r3_r
			            c2 = r1_g + r2_g + r3_g
			            c3 = r1_b + r2_b + r3_b
			            if c1 > 255 then c1 = 255
			            if c2 > 255 then c2 = 255
			            if c3 > 255 then c3 = 255
			            plotx = x+rad
			            ploty = y+rad
			            brush_pixel = c3 + 256*c2 + 256*256*c1
       					Marshal.Writeint32(brush_bmd.Scan0, brush_bmd.Stride * ploty + pixelsize * plotx , brush_pixel)
					Next
				Next
			Case 3	'hiperbola
				For x = -rad To rad
					For y = -rad To rad
						r = Math.Sqrt(x*x + y*y)
		        		z = (255*((rad+1)/(r+1)-1))/rad
		        		z = (z + (-255/rad*r+255))/2
						If r > (range1up*rad)/100 Or r < (range1down*rad)/100 Or range1up = range1down Then
			            	r1_r = 0
			            	r1_g = 0
			            	r1_b = 0
			            Else
			            	r1 = pn_1up.BackColor.R
			            	r2 = pn_1down.BackColor.R
			            	g1 = pn_1up.BackColor.G
			            	g2 = pn_1down.BackColor.G
			            	b1 = pn_1up.BackColor.B
			            	b2 = pn_1down.BackColor.B
			            	z1 = (255*((rad+1)/((range1up*rad)/100+1)-1))/rad
			            	z1 = (z1 + (-255/rad*(range1up*rad)/100+255))/2
			            	z2 = (255*((rad+1)/((range1down*rad)/100+1)-1))/rad
			            	z2 = (z2 + (-255/rad*(range1down*rad)/100+255))/2
			            	r1_r = Convert.ToInt32(((z-z1)*(r2-r1))/(z2-z1)+r1)
			            	r1_g = Convert.ToInt32(((z-z1)*(g2-g1))/(z2-z1)+g1)
			            	r1_b = Convert.ToInt32(((z-z1)*(b2-b1))/(z2-z1)+b1)
			            End If
			            If r > (range2up*rad)/100 Or r < (range2down*rad)/100 Or range2up = range2down Then
			            	r2_r = 0
			            	r2_g = 0
			            	r2_b = 0
			            Else
			            	r1 = pn_2up.BackColor.R
			            	r2 = pn_2down.BackColor.R
			            	g1 = pn_2up.BackColor.G
			            	g2 = pn_2down.BackColor.G
			            	b1 = pn_2up.BackColor.B
			            	b2 = pn_2down.BackColor.B
			            	z1 = (255*((rad+1)/((range2up*rad)/100+1)-1))/rad
			            	z1 = (z1 + (-255/rad*(range2up*rad)/100+255))/2
			            	z2 = (255*((rad+1)/((range2down*rad)/100+1)-1))/rad
			            	z2 = (z2 + (-255/rad*(range2down*rad)/100+255))/2
			            	r2_r = Convert.ToInt32(((z-z1)*(r2-r1))/(z2-z1)+r1)
			            	r2_g = Convert.ToInt32(((z-z1)*(g2-g1))/(z2-z1)+g1)
			            	r2_b = Convert.ToInt32(((z-z1)*(b2-b1))/(z2-z1)+b1)
			            End If
			            If r > (range3up*rad)/100 Or r < (range3down*rad)/100 Or range3up = range3down Then
			            	r3_r = 0
			            	r3_g = 0
			            	r3_b = 0
			            Else
			            	r1 = pn_3up.BackColor.R
			            	r2 = pn_3down.BackColor.R
			            	g1 = pn_3up.BackColor.G
			            	g2 = pn_3down.BackColor.G
			            	b1 = pn_3up.BackColor.B
			            	b2 = pn_3down.BackColor.B
			            	z1 = (255*((rad+1)/((range3up*rad)/100+1)-1))/rad
			            	z1 = (z1 + (-255/rad*(range3up*rad)/100+255))/2
			            	z2 = (255*((rad+1)/((range3down*rad)/100+1)-1))/rad
			            	z2 = (z2 + (-255/rad*(range3down*rad)/100+255))/2
			            	r3_r = Convert.ToInt32(((z-z1)*(r2-r1))/(z2-z1)+r1)
			            	r3_g = Convert.ToInt32(((z-z1)*(g2-g1))/(z2-z1)+g1)
			            	r3_b = Convert.ToInt32(((z-z1)*(b2-b1))/(z2-z1)+b1)
			            End If
			            c1 = r1_r + r2_r + r3_r
			            c2 = r1_g + r2_g + r3_g
			            c3 = r1_b + r2_b + r3_b
			            if c1 > 255 then c1 = 255
			            if c2 > 255 then c2 = 255
			            if c3 > 255 then c3 = 255
			            plotx = x+rad
			            ploty = y+rad
			            brush_pixel = c3 + 256*c2 + 256*256*c1
       					Marshal.Writeint32(brush_bmd.Scan0, brush_bmd.Stride * ploty + pixelsize * plotx , brush_pixel)
					Next
				Next
			Case 4	'koszinusz
				For x = -rad To rad
					For y = -rad To rad
						r = Math.Sqrt(x*x + y*y)
						z = (255*(Math.cos(r*(2*rings+1)*Math.PI/rad)+1))/2
						If z < 0 Then z = 0
						If r > (range1up*rad)/100 Or r < (range1down*rad)/100 Or range1up = range1down Then
			            	r1_r = 0
			            	r1_g = 0
			            	r1_b = 0
			            Else
			            	r1 = pn_1up.BackColor.R
			            	r2 = pn_1down.BackColor.R
			            	g1 = pn_1up.BackColor.G
			            	g2 = pn_1down.BackColor.G
			            	b1 = pn_1up.BackColor.B
			            	b2 = pn_1down.BackColor.B
			            	z1 = 0
			            	z2 = 255
			            	r1_r = Convert.ToInt32(((z-z1)*(r2-r1))/(z2-z1)+r1)
			            	r1_g = Convert.ToInt32(((z-z1)*(g2-g1))/(z2-z1)+g1)
			            	r1_b = Convert.ToInt32(((z-z1)*(b2-b1))/(z2-z1)+b1)
			            End If
			            If r > (range2up*rad)/100 Or r < (range2down*rad)/100 Or range2up = range2down Then
			            	r2_r = 0
			            	r2_g = 0
			            	r2_b = 0
			            Else
			            	r1 = pn_2up.BackColor.R
			            	r2 = pn_2down.BackColor.R
			            	g1 = pn_2up.BackColor.G
			            	g2 = pn_2down.BackColor.G
			            	b1 = pn_2up.BackColor.B
			            	b2 = pn_2down.BackColor.B
			            	z1 = 0
			            	z2 = 255
			            	r2_r = Convert.ToInt32(((z-z1)*(r2-r1))/(z2-z1)+r1)
			            	r2_g = Convert.ToInt32(((z-z1)*(g2-g1))/(z2-z1)+g1)
			            	r2_b = Convert.ToInt32(((z-z1)*(b2-b1))/(z2-z1)+b1)
			            End If
			            If r > (range3up*rad)/100 Or r < (range3down*rad)/100 Or range3up = range3down Then
			            	r3_r = 0
			            	r3_g = 0
			            	r3_b = 0
			            Else
			            	r1 = pn_3up.BackColor.R
			            	r2 = pn_3down.BackColor.R
			            	g1 = pn_3up.BackColor.G
			            	g2 = pn_3down.BackColor.G
			            	b1 = pn_3up.BackColor.B
			            	b2 = pn_3down.BackColor.B
			            	z1 = 0
			            	z2 = 255
			            	r3_r = Convert.ToInt32(((z-z1)*(r2-r1))/(z2-z1)+r1)
			            	r3_g = Convert.ToInt32(((z-z1)*(g2-g1))/(z2-z1)+g1)
			            	r3_b = Convert.ToInt32(((z-z1)*(b2-b1))/(z2-z1)+b1)
			            End If
			            c1 = r1_r + r2_r + r3_r
			            c2 = r1_g + r2_g + r3_g
			            c3 = r1_b + r2_b + r3_b
			            if c1 > 255 then c1 = 255
			            if c2 > 255 then c2 = 255
			            if c3 > 255 then c3 = 255
			            plotx = x+rad
			            ploty = y+rad
			            brush_pixel = c3 + 256*c2 + 256*256*c1
       					Marshal.Writeint32(brush_bmd.Scan0, brush_bmd.Stride * ploty + pixelsize * plotx , brush_pixel)
					Next
				Next
		End Select				
		brush.UnlockBits(brush_bmd)
		If rad <= 100 Then
			b.clear(Color.FromName("Black"))
			b.DrawImage(brush, Convert.ToByte(100-rad),Convert.ToByte(100-rad))
			panel_brush.refresh
		End If
	End Sub
	
	
	Sub generate_polybrush(byval brush as bitmap, rad as integer)
		Dim x, y As Integer
		Dim r, z As Double
		Dim za1, zb1 As Double
		Dim za2, zb2 As Double
		Dim za3, zb3 As Double
		Dim rad2 As Double
		Dim alpha As Double
		Dim ra, rb As Double
		Dim c1,c2,c3 As Integer
		Dim r1_r, r1_g, r1_b As Integer
		Dim r2_r, r2_g, r2_b As Integer
		Dim r3_r, r3_g, r3_b As Integer
		Dim ra1, rb1 As Integer
		Dim ra2, rb2 As Integer
		Dim ra3, rb3 As Integer
		Dim ga1, gb1 As Integer
		Dim ga2, gb2 As Integer
		Dim ga3, gb3 As Integer
		Dim ba1, bb1 As Integer
		Dim ba2, bb2 As Integer
		Dim ba3, bb3 As Integer
		Dim plotx, ploty As Integer
		Dim range1up, range1down, range2up, range2down, range3up, range3down As Byte
		Dim pixelsize As Integer = 4
		Dim brush_pixel As Integer
		Dim brush_bmd As BitmapData = brush.LockBits(new Rectangle(0, 0, 2*rad+1, 2*rad+1), System.Drawing.Imaging.ImageLockMode.ReadWrite, brush.PixelFormat)
		
		range1up = Convert.ToByte(tb_range1up.Value)
		range1down = Convert.ToByte(tb_range1down.Value)
		range2up = Convert.ToByte(tb_range2up.Value)
		range2down = Convert.ToByte(tb_range2down.Value)
		range3up = Convert.ToByte(tb_range3up.Value)
		range3down = Convert.ToByte(tb_range3down.Value)
		
    	ra1 = pn_1up.BackColor.R
    	rb1 = pn_1down.BackColor.R
    	ga1 = pn_1up.BackColor.G
    	gb1 = pn_1down.BackColor.G
    	ba1 = pn_1up.BackColor.B
    	bb1 = pn_1down.BackColor.B

    	ra2 = pn_2up.BackColor.R
    	rb2 = pn_2down.BackColor.R
    	ga2 = pn_2up.BackColor.G
    	gb2 = pn_2down.BackColor.G
    	ba2 = pn_2up.BackColor.B
    	bb2 = pn_2down.BackColor.B
		
    	ra3 = pn_3up.BackColor.R
    	rb3 = pn_3down.BackColor.R
    	ga3 = pn_3up.BackColor.G
    	gb3 = pn_3down.BackColor.G
    	ba3 = pn_3up.BackColor.B
    	bb3 = pn_3down.BackColor.B
		
				For x = -rad To rad
					For y = -rad To rad
						r = Math.Sqrt(x*x + y*y)
						alpha = Math.Atan2(y,x) + (Math.PI * rotation)/180
						If alpha < 0 Then alpha = 2 * Math.PI - alpha
						alpha = alpha Mod Math.PI/(numberofsides/2) - Math.PI/numberofsides
						rad2 = r * Math.Cos(alpha)/Math.Cos(Math.PI/numberofsides)
						If rad2 > rad Then 
							z = 0
						Else
							z = 255 - ( 255 * rad2 / rad )	
						End If
						
						Select Case colormode1
							Case 0
				            	za1 = (255*Math.Sqrt(rad*rad-(range1up*rad)/100*(range1up*rad)/100))/rad
				            	zb1 = (255*Math.Sqrt(rad*rad-(range1down*rad)/100*(range1down*rad)/100))/rad
				            	za2 = (255*Math.Sqrt(rad*rad-(range2up*rad)/100*(range2up*rad)/100))/rad
				            	zb2 = (255*Math.Sqrt(rad*rad-(range2down*rad)/100*(range2down*rad)/100))/rad
				            	za3 = (255*Math.Sqrt(rad*rad-(range3up*rad)/100*(range3up*rad)/100))/rad
				            	zb3 = (255*Math.Sqrt(rad*rad-(range3down*rad)/100*(range3down*rad)/100))/rad
							Case 1
				            	za1 = (255*(rad*rad-(range1up*rad)/100*(range1up*rad)/100))/(rad*rad)
				            	zb1 = (255*(rad*rad-(range1down*rad)/100*(range1down*rad)/100))/(rad*rad)
				            	za2 = (255*(rad*rad-(range2up*rad)/100*(range2up*rad)/100))/(rad*rad)
				            	zb2 = (255*(rad*rad-(range2down*rad)/100*(range2down*rad)/100))/(rad*rad)
				            	za3 = (255*(rad*rad-(range3up*rad)/100*(range3up*rad)/100))/(rad*rad)
				            	zb3 = (255*(rad*rad-(range3down*rad)/100*(range3down*rad)/100))/(rad*rad)
							Case 2
				            	za1 = (-255*range1up)/100+255
				            	zb1 = (-255*range1down)/100+255
				            	za2 = (-255*range2up)/100+255
				            	zb2 = (-255*range2down)/100+255
				            	za3 = (-255*range3up)/100+255
				            	zb3 = (-255*range3down)/100+255
							Case 3
				            	za1 = (255*((rad+1)/((range1up*rad)/100+1)-1))/rad
				            	za1 = (za1 + (-255/rad*(range1up*rad)/100+255))/2
				            	zb1 = (255*((rad+1)/((range1down*rad)/100+1)-1))/rad
				            	zb1 = (zb1 + (-255/rad*(range1down*rad)/100+255))/2
				            	za2 = (255*((rad+1)/((range2up*rad)/100+1)-1))/rad
				            	za2 = (za2 + (-255/rad*(range2up*rad)/100+255))/2
				            	zb2 = (255*((rad+1)/((range2down*rad)/100+1)-1))/rad
				            	zb2 = (zb2 + (-255/rad*(range2down*rad)/100+255))/2
				            	za3 = (255*((rad+1)/((range3up*rad)/100+1)-1))/rad
				            	za3 = (za3 + (-255/rad*(range3up*rad)/100+255))/2
				            	zb3 = (255*((rad+1)/((range3down*rad)/100+1)-1))/rad
				            	zb3 = (zb3 + (-255/rad*(range3down*rad)/100+255))/2
							Case 4
				            	za1 = 0
				            	zb1 = 255
				            	za2 = 0
				            	zb2 = 255
				            	za3 = 0
				            	zb3 = 255
						End Select
						
						Select Case colormode2
							Case 0
								ra = r
							Case 1
								ra = rad2
						End Select
						
						Select Case colormode3
							Case 0
								rb = rad
							Case 1
								rb = rad2
						End Select
						
						If ra > (range1up*rb)/100 Or ra < (range1down*rb)/100 Or range1up = range1down Then
			            	r1_r = 0
			            	r1_g = 0
			            	r1_b = 0
			            Else
			            	r1_r = Convert.ToInt32(((z-za1)*(rb1-ra1))/(zb1-za1)+ra1)
			            	r1_g = Convert.ToInt32(((z-za1)*(gb1-ga1))/(zb1-za1)+ga1)
			            	r1_b = Convert.ToInt32(((z-za1)*(bb1-ba1))/(zb1-za1)+ba1)
			            End If
			            If ra > (range2up*rb)/100 Or ra < (range2down*rb)/100 Or range2up = range2down Then
			            	r2_r = 0
			            	r2_g = 0
			            	r2_b = 0
			            Else
			            	r2_r = Convert.ToInt32(((z-za2)*(rb2-ra2))/(zb2-za2)+ra2)
			            	r2_g = Convert.ToInt32(((z-za2)*(gb2-ga2))/(zb2-za2)+ga2)
			            	r2_b = Convert.ToInt32(((z-za2)*(bb2-ba2))/(zb2-za2)+ba2)
			            End If
			            If ra > (range3up*rb)/100 Or ra < (range3down*rb)/100 Or range3up = range3down Then
			            	r3_r = 0
			            	r3_g = 0
			            	r3_b = 0
			            Else
			            	r3_r = Convert.ToInt32(((z-za3)*(rb3-ra3))/(zb3-za3)+ra3)
			            	r3_g = Convert.ToInt32(((z-za3)*(gb3-ga3))/(zb3-za3)+ga3)
			            	r3_b = Convert.ToInt32(((z-za3)*(bb3-ba3))/(zb3-za3)+ba3)
			            End If
			            c1 = r1_r + r2_r + r3_r
			            c2 = r1_g + r2_g + r3_g
			            c3 = r1_b + r2_b + r3_b
			            if c1 > 255 then c1 = 255
			            if c2 > 255 then c2 = 255
			            if c3 > 255 then c3 = 255
			            plotx = x+rad
			            ploty = y+rad
			            brush_pixel = c3 + 256*c2 + 256*256*c1
       					Marshal.Writeint32(brush_bmd.Scan0, brush_bmd.Stride * ploty + pixelsize * plotx , brush_pixel)
					Next
				Next
		brush.UnlockBits(brush_bmd)
		If rad <= 100 Then
			b.clear(Color.FromName("Black"))
			b.DrawImage(brush, Convert.ToByte(100-rad),Convert.ToByte(100-rad))
			panel_brush.refresh
		End If
	End Sub

	
End Class
