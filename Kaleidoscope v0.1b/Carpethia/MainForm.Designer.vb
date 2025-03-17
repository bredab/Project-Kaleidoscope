'
' Created by SharpDevelop.
' User: hu51023
' Date: 2012.10.01.
' Time: 11:19
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.btn_generate = New System.Windows.Forms.Button()
		Me.waveupdown = New System.Windows.Forms.NumericUpDown()
		Me.wavebar = New System.Windows.Forms.TrackBar()
		Me.label1 = New System.Windows.Forms.Label()
		Me.prec1updown = New System.Windows.Forms.NumericUpDown()
		Me.prec2updown = New System.Windows.Forms.NumericUpDown()
		Me.prec3updown = New System.Windows.Forms.NumericUpDown()
		Me.prec4updown = New System.Windows.Forms.NumericUpDown()
		Me.prec5updown = New System.Windows.Forms.NumericUpDown()
		Me.label3 = New System.Windows.Forms.Label()
		Me.btn_clear = New System.Windows.Forms.Button()
		Me.cb_autclr = New System.Windows.Forms.CheckBox()
		Me.cb_wave = New System.Windows.Forms.CheckBox()
		Me.cb_rad = New System.Windows.Forms.CheckBox()
		Me.panel_red = New System.Windows.Forms.Panel()
		Me.ud_rbf = New System.Windows.Forms.NumericUpDown()
		Me.ud_rbt = New System.Windows.Forms.NumericUpDown()
		Me.ud_rsf = New System.Windows.Forms.NumericUpDown()
		Me.ud_rst = New System.Windows.Forms.NumericUpDown()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label9 = New System.Windows.Forms.Label()
		Me.ud_gst = New System.Windows.Forms.NumericUpDown()
		Me.ud_gsf = New System.Windows.Forms.NumericUpDown()
		Me.ud_gbt = New System.Windows.Forms.NumericUpDown()
		Me.ud_gbf = New System.Windows.Forms.NumericUpDown()
		Me.panel_green = New System.Windows.Forms.Panel()
		Me.label12 = New System.Windows.Forms.Label()
		Me.label13 = New System.Windows.Forms.Label()
		Me.ud_bst = New System.Windows.Forms.NumericUpDown()
		Me.ud_bsf = New System.Windows.Forms.NumericUpDown()
		Me.ud_bbt = New System.Windows.Forms.NumericUpDown()
		Me.ud_bbf = New System.Windows.Forms.NumericUpDown()
		Me.panel_blue = New System.Windows.Forms.Panel()
		Me.panel_brush = New System.Windows.Forms.Panel()
		Me.brushpanel = New System.Windows.Forms.Panel()
		Me.panel_sphere = New System.Windows.Forms.Panel()
		Me.label2 = New System.Windows.Forms.Label()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.raddec_rb = New System.Windows.Forms.RadioButton()
		Me.label11 = New System.Windows.Forms.Label()
		Me.radstep_ud = New System.Windows.Forms.NumericUpDown()
		Me.radinc_rb = New System.Windows.Forms.RadioButton()
		Me.radiusupdown = New System.Windows.Forms.NumericUpDown()
		Me.radiusbar = New System.Windows.Forms.TrackBar()
		Me.rb_brush = New System.Windows.Forms.RadioButton()
		Me.rb_sphere = New System.Windows.Forms.RadioButton()
		Me.btn_save = New System.Windows.Forms.Button()
		Me.btn_load = New System.Windows.Forms.Button()
		Me.btn_random = New System.Windows.Forms.Button()
		Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.cb_autosave = New System.Windows.Forms.CheckBox()
		Me.precisionbox = New System.Windows.Forms.MaskedTextBox()
		Me.waveinc_rb = New System.Windows.Forms.RadioButton()
		Me.wavedec_rb = New System.Windows.Forms.RadioButton()
		Me.wavestep_ud = New System.Windows.Forms.NumericUpDown()
		Me.label10 = New System.Windows.Forms.Label()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.pict_save = New System.Windows.Forms.Button()
		Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.label14 = New System.Windows.Forms.Label()
		Me.precstep_ud = New System.Windows.Forms.NumericUpDown()
		Me.precdec_rb = New System.Windows.Forms.RadioButton()
		Me.precinc_rb = New System.Windows.Forms.RadioButton()
		Me.cb_prec = New System.Windows.Forms.CheckBox()
		Me.precisionpanel = New System.Windows.Forms.Panel()
		Me.wavepanel = New System.Windows.Forms.Panel()
		Me.rotationpanel = New System.Windows.Forms.Panel()
		Me.rotbar = New System.Windows.Forms.TrackBar()
		Me.label17 = New System.Windows.Forms.Label()
		Me.label15 = New System.Windows.Forms.Label()
		Me.rot_ud = New System.Windows.Forms.NumericUpDown()
		Me.panel8 = New System.Windows.Forms.Panel()
		Me.rotdec_rb = New System.Windows.Forms.RadioButton()
		Me.label16 = New System.Windows.Forms.Label()
		Me.rotstep_ud = New System.Windows.Forms.NumericUpDown()
		Me.rotinc_rb = New System.Windows.Forms.RadioButton()
		Me.cb_rot = New System.Windows.Forms.CheckBox()
		Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
		CType(Me.waveupdown,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.wavebar,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.prec1updown,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.prec2updown,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.prec3updown,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.prec4updown,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.prec5updown,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_rbf,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_rbt,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_rsf,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_rst,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_gst,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_gsf,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_gbt,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_gbf,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_bst,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_bsf,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_bbt,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_bbf,System.ComponentModel.ISupportInitialize).BeginInit
		Me.brushpanel.SuspendLayout
		Me.panel_sphere.SuspendLayout
		Me.panel2.SuspendLayout
		CType(Me.radstep_ud,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.radiusupdown,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.radiusbar,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.wavestep_ud,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel1.SuspendLayout
		Me.panel3.SuspendLayout
		CType(Me.precstep_ud,System.ComponentModel.ISupportInitialize).BeginInit
		Me.precisionpanel.SuspendLayout
		Me.wavepanel.SuspendLayout
		Me.rotationpanel.SuspendLayout
		CType(Me.rotbar,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.rot_ud,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel8.SuspendLayout
		CType(Me.rotstep_ud,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'btn_generate
		'
		Me.btn_generate.BackColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer))
		resources.ApplyResources(Me.btn_generate, "btn_generate")
		Me.btn_generate.Name = "btn_generate"
		Me.btn_generate.UseVisualStyleBackColor = false
		AddHandler Me.btn_generate.Click, AddressOf Me.Btn_generateClick
		'
		'waveupdown
		'
		resources.ApplyResources(Me.waveupdown, "waveupdown")
		Me.waveupdown.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
		Me.waveupdown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.waveupdown.Name = "waveupdown"
		Me.waveupdown.Value = New Decimal(New Integer() {10, 0, 0, 0})
		AddHandler Me.waveupdown.ValueChanged, AddressOf Me.WaveupdownValueChanged
		'
		'wavebar
		'
		Me.wavebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
		resources.ApplyResources(Me.wavebar, "wavebar")
		Me.wavebar.Maximum = 200
		Me.wavebar.Minimum = 1
		Me.wavebar.Name = "wavebar"
		Me.wavebar.TickFrequency = 10
		Me.wavebar.Value = 10
		AddHandler Me.wavebar.Scroll, AddressOf Me.WavebarScroll
		'
		'label1
		'
		resources.ApplyResources(Me.label1, "label1")
		Me.label1.Name = "label1"
		'
		'prec1updown
		'
		resources.ApplyResources(Me.prec1updown, "prec1updown")
		Me.prec1updown.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
		Me.prec1updown.Name = "prec1updown"
		Me.prec1updown.Value = New Decimal(New Integer() {9, 0, 0, 0})
		AddHandler Me.prec1updown.ValueChanged, AddressOf Me.Prec1updownValueChanged
		'
		'prec2updown
		'
		resources.ApplyResources(Me.prec2updown, "prec2updown")
		Me.prec2updown.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
		Me.prec2updown.Name = "prec2updown"
		Me.prec2updown.Value = New Decimal(New Integer() {9, 0, 0, 0})
		AddHandler Me.prec2updown.ValueChanged, AddressOf Me.Prec2updownValueChanged
		'
		'prec3updown
		'
		resources.ApplyResources(Me.prec3updown, "prec3updown")
		Me.prec3updown.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
		Me.prec3updown.Name = "prec3updown"
		Me.prec3updown.Value = New Decimal(New Integer() {9, 0, 0, 0})
		AddHandler Me.prec3updown.ValueChanged, AddressOf Me.Prec3updownValueChanged
		'
		'prec4updown
		'
		resources.ApplyResources(Me.prec4updown, "prec4updown")
		Me.prec4updown.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
		Me.prec4updown.Name = "prec4updown"
		Me.prec4updown.Value = New Decimal(New Integer() {9, 0, 0, 0})
		AddHandler Me.prec4updown.ValueChanged, AddressOf Me.Prec4updownValueChanged
		'
		'prec5updown
		'
		resources.ApplyResources(Me.prec5updown, "prec5updown")
		Me.prec5updown.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
		Me.prec5updown.Name = "prec5updown"
		Me.prec5updown.Value = New Decimal(New Integer() {9, 0, 0, 0})
		AddHandler Me.prec5updown.ValueChanged, AddressOf Me.Prec5updownValueChanged
		'
		'label3
		'
		resources.ApplyResources(Me.label3, "label3")
		Me.label3.Name = "label3"
		'
		'btn_clear
		'
		Me.btn_clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer))
		resources.ApplyResources(Me.btn_clear, "btn_clear")
		Me.btn_clear.Name = "btn_clear"
		Me.btn_clear.UseVisualStyleBackColor = false
		AddHandler Me.btn_clear.Click, AddressOf Me.Btn_clearClick
		'
		'cb_autclr
		'
		Me.cb_autclr.Checked = true
		Me.cb_autclr.CheckState = System.Windows.Forms.CheckState.Checked
		resources.ApplyResources(Me.cb_autclr, "cb_autclr")
		Me.cb_autclr.Name = "cb_autclr"
		Me.cb_autclr.UseVisualStyleBackColor = true
		'
		'cb_wave
		'
		resources.ApplyResources(Me.cb_wave, "cb_wave")
		Me.cb_wave.Name = "cb_wave"
		Me.cb_wave.UseVisualStyleBackColor = true
		AddHandler Me.cb_wave.CheckedChanged, AddressOf Me.Cb_waveCheckedChanged
		'
		'cb_rad
		'
		resources.ApplyResources(Me.cb_rad, "cb_rad")
		Me.cb_rad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
		Me.cb_rad.Name = "cb_rad"
		Me.cb_rad.UseVisualStyleBackColor = false
		AddHandler Me.cb_rad.CheckedChanged, AddressOf Me.Cb_radCheckedChanged
		'
		'panel_red
		'
		Me.panel_red.BackColor = System.Drawing.Color.Red
		Me.panel_red.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.panel_red, "panel_red")
		Me.panel_red.Name = "panel_red"
		'
		'ud_rbf
		'
		resources.ApplyResources(Me.ud_rbf, "ud_rbf")
		Me.ud_rbf.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.ud_rbf.Name = "ud_rbf"
		AddHandler Me.ud_rbf.ValueChanged, AddressOf Me.Ud_rbfValueChanged
		'
		'ud_rbt
		'
		resources.ApplyResources(Me.ud_rbt, "ud_rbt")
		Me.ud_rbt.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.ud_rbt.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.ud_rbt.Name = "ud_rbt"
		Me.ud_rbt.Value = New Decimal(New Integer() {255, 0, 0, 0})
		AddHandler Me.ud_rbt.ValueChanged, AddressOf Me.Ud_rbtValueChanged
		'
		'ud_rsf
		'
		resources.ApplyResources(Me.ud_rsf, "ud_rsf")
		Me.ud_rsf.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.ud_rsf.Name = "ud_rsf"
		AddHandler Me.ud_rsf.ValueChanged, AddressOf Me.Ud_rsfValueChanged
		'
		'ud_rst
		'
		resources.ApplyResources(Me.ud_rst, "ud_rst")
		Me.ud_rst.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.ud_rst.Name = "ud_rst"
		Me.ud_rst.Value = New Decimal(New Integer() {255, 0, 0, 0})
		AddHandler Me.ud_rst.ValueChanged, AddressOf Me.Ud_rstValueChanged
		'
		'label4
		'
		resources.ApplyResources(Me.label4, "label4")
		Me.label4.Name = "label4"
		'
		'label5
		'
		resources.ApplyResources(Me.label5, "label5")
		Me.label5.Name = "label5"
		'
		'label6
		'
		resources.ApplyResources(Me.label6, "label6")
		Me.label6.Name = "label6"
		'
		'label7
		'
		resources.ApplyResources(Me.label7, "label7")
		Me.label7.Name = "label7"
		'
		'label8
		'
		resources.ApplyResources(Me.label8, "label8")
		Me.label8.Name = "label8"
		'
		'label9
		'
		resources.ApplyResources(Me.label9, "label9")
		Me.label9.Name = "label9"
		'
		'ud_gst
		'
		resources.ApplyResources(Me.ud_gst, "ud_gst")
		Me.ud_gst.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.ud_gst.Name = "ud_gst"
		Me.ud_gst.Value = New Decimal(New Integer() {255, 0, 0, 0})
		AddHandler Me.ud_gst.ValueChanged, AddressOf Me.Ud_gstValueChanged
		'
		'ud_gsf
		'
		resources.ApplyResources(Me.ud_gsf, "ud_gsf")
		Me.ud_gsf.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.ud_gsf.Name = "ud_gsf"
		AddHandler Me.ud_gsf.ValueChanged, AddressOf Me.Ud_gsfValueChanged
		'
		'ud_gbt
		'
		resources.ApplyResources(Me.ud_gbt, "ud_gbt")
		Me.ud_gbt.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.ud_gbt.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.ud_gbt.Name = "ud_gbt"
		Me.ud_gbt.Value = New Decimal(New Integer() {255, 0, 0, 0})
		AddHandler Me.ud_gbt.ValueChanged, AddressOf Me.Ud_gbtValueChanged
		'
		'ud_gbf
		'
		resources.ApplyResources(Me.ud_gbf, "ud_gbf")
		Me.ud_gbf.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.ud_gbf.Name = "ud_gbf"
		AddHandler Me.ud_gbf.ValueChanged, AddressOf Me.Ud_gbfValueChanged
		'
		'panel_green
		'
		Me.panel_green.BackColor = System.Drawing.Color.Lime
		Me.panel_green.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.panel_green, "panel_green")
		Me.panel_green.Name = "panel_green"
		'
		'label12
		'
		resources.ApplyResources(Me.label12, "label12")
		Me.label12.Name = "label12"
		'
		'label13
		'
		resources.ApplyResources(Me.label13, "label13")
		Me.label13.Name = "label13"
		'
		'ud_bst
		'
		resources.ApplyResources(Me.ud_bst, "ud_bst")
		Me.ud_bst.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.ud_bst.Name = "ud_bst"
		Me.ud_bst.Value = New Decimal(New Integer() {255, 0, 0, 0})
		AddHandler Me.ud_bst.ValueChanged, AddressOf Me.Ud_bstValueChanged
		'
		'ud_bsf
		'
		resources.ApplyResources(Me.ud_bsf, "ud_bsf")
		Me.ud_bsf.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.ud_bsf.Name = "ud_bsf"
		AddHandler Me.ud_bsf.ValueChanged, AddressOf Me.Ud_bsfValueChanged
		'
		'ud_bbt
		'
		resources.ApplyResources(Me.ud_bbt, "ud_bbt")
		Me.ud_bbt.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.ud_bbt.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.ud_bbt.Name = "ud_bbt"
		Me.ud_bbt.Value = New Decimal(New Integer() {255, 0, 0, 0})
		AddHandler Me.ud_bbt.ValueChanged, AddressOf Me.Ud_bbtValueChanged
		'
		'ud_bbf
		'
		resources.ApplyResources(Me.ud_bbf, "ud_bbf")
		Me.ud_bbf.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.ud_bbf.Name = "ud_bbf"
		AddHandler Me.ud_bbf.ValueChanged, AddressOf Me.Ud_bbfValueChanged
		'
		'panel_blue
		'
		Me.panel_blue.BackColor = System.Drawing.Color.Blue
		Me.panel_blue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.panel_blue, "panel_blue")
		Me.panel_blue.Name = "panel_blue"
		'
		'panel_brush
		'
		Me.panel_brush.BackColor = System.Drawing.Color.Black
		resources.ApplyResources(Me.panel_brush, "panel_brush")
		Me.panel_brush.Name = "panel_brush"
		AddHandler Me.panel_brush.DoubleClick, AddressOf Me.Panel_brushDoubleClick
		'
		'brushpanel
		'
		Me.brushpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
		Me.brushpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.brushpanel.Controls.Add(Me.panel_sphere)
		Me.brushpanel.Controls.Add(Me.rb_brush)
		Me.brushpanel.Controls.Add(Me.rb_sphere)
		Me.brushpanel.Controls.Add(Me.btn_save)
		Me.brushpanel.Controls.Add(Me.btn_load)
		Me.brushpanel.Controls.Add(Me.panel_brush)
		resources.ApplyResources(Me.brushpanel, "brushpanel")
		Me.brushpanel.Name = "brushpanel"
		'
		'panel_sphere
		'
		Me.panel_sphere.Controls.Add(Me.ud_bst)
		Me.panel_sphere.Controls.Add(Me.label2)
		Me.panel_sphere.Controls.Add(Me.ud_bsf)
		Me.panel_sphere.Controls.Add(Me.panel2)
		Me.panel_sphere.Controls.Add(Me.radiusupdown)
		Me.panel_sphere.Controls.Add(Me.radiusbar)
		Me.panel_sphere.Controls.Add(Me.label12)
		Me.panel_sphere.Controls.Add(Me.label13)
		Me.panel_sphere.Controls.Add(Me.ud_bbt)
		Me.panel_sphere.Controls.Add(Me.ud_bbf)
		Me.panel_sphere.Controls.Add(Me.panel_blue)
		Me.panel_sphere.Controls.Add(Me.label8)
		Me.panel_sphere.Controls.Add(Me.label9)
		Me.panel_sphere.Controls.Add(Me.ud_gst)
		Me.panel_sphere.Controls.Add(Me.ud_gsf)
		Me.panel_sphere.Controls.Add(Me.ud_gbt)
		Me.panel_sphere.Controls.Add(Me.ud_gbf)
		Me.panel_sphere.Controls.Add(Me.panel_green)
		Me.panel_sphere.Controls.Add(Me.label7)
		Me.panel_sphere.Controls.Add(Me.label6)
		Me.panel_sphere.Controls.Add(Me.label5)
		Me.panel_sphere.Controls.Add(Me.label4)
		Me.panel_sphere.Controls.Add(Me.ud_rst)
		Me.panel_sphere.Controls.Add(Me.ud_rsf)
		Me.panel_sphere.Controls.Add(Me.ud_rbt)
		Me.panel_sphere.Controls.Add(Me.ud_rbf)
		Me.panel_sphere.Controls.Add(Me.panel_red)
		resources.ApplyResources(Me.panel_sphere, "panel_sphere")
		Me.panel_sphere.Name = "panel_sphere"
		'
		'label2
		'
		resources.ApplyResources(Me.label2, "label2")
		Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
		Me.label2.Name = "label2"
		'
		'panel2
		'
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.raddec_rb)
		Me.panel2.Controls.Add(Me.label11)
		Me.panel2.Controls.Add(Me.radstep_ud)
		Me.panel2.Controls.Add(Me.radinc_rb)
		Me.panel2.Controls.Add(Me.cb_rad)
		resources.ApplyResources(Me.panel2, "panel2")
		Me.panel2.Name = "panel2"
		'
		'raddec_rb
		'
		resources.ApplyResources(Me.raddec_rb, "raddec_rb")
		Me.raddec_rb.Name = "raddec_rb"
		Me.raddec_rb.UseVisualStyleBackColor = true
		'
		'label11
		'
		resources.ApplyResources(Me.label11, "label11")
		Me.label11.Name = "label11"
		'
		'radstep_ud
		'
		resources.ApplyResources(Me.radstep_ud, "radstep_ud")
		Me.radstep_ud.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.radstep_ud.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.radstep_ud.Name = "radstep_ud"
		Me.radstep_ud.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'radinc_rb
		'
		resources.ApplyResources(Me.radinc_rb, "radinc_rb")
		Me.radinc_rb.Checked = true
		Me.radinc_rb.Name = "radinc_rb"
		Me.radinc_rb.TabStop = true
		Me.radinc_rb.UseVisualStyleBackColor = true
		'
		'radiusupdown
		'
		resources.ApplyResources(Me.radiusupdown, "radiusupdown")
		Me.radiusupdown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.radiusupdown.Name = "radiusupdown"
		Me.radiusupdown.Value = New Decimal(New Integer() {50, 0, 0, 0})
		AddHandler Me.radiusupdown.ValueChanged, AddressOf Me.RadiusupdownValueChanged
		'
		'radiusbar
		'
		Me.radiusbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
		resources.ApplyResources(Me.radiusbar, "radiusbar")
		Me.radiusbar.Maximum = 100
		Me.radiusbar.Minimum = 1
		Me.radiusbar.Name = "radiusbar"
		Me.radiusbar.TickFrequency = 10
		Me.radiusbar.Value = 50
		AddHandler Me.radiusbar.Scroll, AddressOf Me.RadiusbarScroll
		'
		'rb_brush
		'
		resources.ApplyResources(Me.rb_brush, "rb_brush")
		Me.rb_brush.Name = "rb_brush"
		Me.rb_brush.UseVisualStyleBackColor = true
		AddHandler Me.rb_brush.CheckedChanged, AddressOf Me.Rb_brushCheckedChanged
		'
		'rb_sphere
		'
		resources.ApplyResources(Me.rb_sphere, "rb_sphere")
		Me.rb_sphere.Checked = true
		Me.rb_sphere.Name = "rb_sphere"
		Me.rb_sphere.TabStop = true
		Me.rb_sphere.UseVisualStyleBackColor = true
		AddHandler Me.rb_sphere.CheckedChanged, AddressOf Me.Rb_sphereCheckedChanged
		'
		'btn_save
		'
		resources.ApplyResources(Me.btn_save, "btn_save")
		Me.btn_save.Name = "btn_save"
		Me.btn_save.UseVisualStyleBackColor = true
		AddHandler Me.btn_save.Click, AddressOf Me.btn_saveClick
		'
		'btn_load
		'
		resources.ApplyResources(Me.btn_load, "btn_load")
		Me.btn_load.Name = "btn_load"
		Me.btn_load.UseVisualStyleBackColor = true
		AddHandler Me.btn_load.Click, AddressOf Me.btnload_Click
		'
		'btn_random
		'
		Me.btn_random.BackColor = System.Drawing.SystemColors.ButtonFace
		resources.ApplyResources(Me.btn_random, "btn_random")
		Me.btn_random.Name = "btn_random"
		Me.btn_random.UseVisualStyleBackColor = false
		AddHandler Me.btn_random.Click, AddressOf Me.Btn_randomClick
		'
		'openFileDialog1
		'
		Me.openFileDialog1.FileName = "openFileDialog1"
		'
		'cb_autosave
		'
		resources.ApplyResources(Me.cb_autosave, "cb_autosave")
		Me.cb_autosave.Name = "cb_autosave"
		Me.cb_autosave.UseVisualStyleBackColor = true
		'
		'precisionbox
		'
		Me.precisionbox.AsciiOnly = true
		Me.precisionbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		resources.ApplyResources(Me.precisionbox, "precisionbox")
		Me.precisionbox.Name = "precisionbox"
		Me.precisionbox.ReadOnly = true
		'
		'waveinc_rb
		'
		resources.ApplyResources(Me.waveinc_rb, "waveinc_rb")
		Me.waveinc_rb.Checked = true
		Me.waveinc_rb.Name = "waveinc_rb"
		Me.waveinc_rb.TabStop = true
		Me.waveinc_rb.UseVisualStyleBackColor = true
		'
		'wavedec_rb
		'
		resources.ApplyResources(Me.wavedec_rb, "wavedec_rb")
		Me.wavedec_rb.Name = "wavedec_rb"
		Me.wavedec_rb.UseVisualStyleBackColor = true
		'
		'wavestep_ud
		'
		resources.ApplyResources(Me.wavestep_ud, "wavestep_ud")
		Me.wavestep_ud.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.wavestep_ud.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.wavestep_ud.Name = "wavestep_ud"
		Me.wavestep_ud.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'label10
		'
		resources.ApplyResources(Me.label10, "label10")
		Me.label10.Name = "label10"
		'
		'panel1
		'
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.wavedec_rb)
		Me.panel1.Controls.Add(Me.label10)
		Me.panel1.Controls.Add(Me.wavestep_ud)
		Me.panel1.Controls.Add(Me.waveinc_rb)
		Me.panel1.Controls.Add(Me.cb_wave)
		resources.ApplyResources(Me.panel1, "panel1")
		Me.panel1.Name = "panel1"
		'
		'pict_save
		'
		resources.ApplyResources(Me.pict_save, "pict_save")
		Me.pict_save.Name = "pict_save"
		Me.pict_save.UseVisualStyleBackColor = true
		AddHandler Me.pict_save.Click, AddressOf Me.Pict_saveClick
		'
		'panel3
		'
		Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel3.Controls.Add(Me.label14)
		Me.panel3.Controls.Add(Me.precstep_ud)
		Me.panel3.Controls.Add(Me.precdec_rb)
		Me.panel3.Controls.Add(Me.precinc_rb)
		Me.panel3.Controls.Add(Me.cb_prec)
		resources.ApplyResources(Me.panel3, "panel3")
		Me.panel3.Name = "panel3"
		'
		'label14
		'
		resources.ApplyResources(Me.label14, "label14")
		Me.label14.Name = "label14"
		'
		'precstep_ud
		'
		resources.ApplyResources(Me.precstep_ud, "precstep_ud")
		Me.precstep_ud.DecimalPlaces = 5
		Me.precstep_ud.Increment = New Decimal(New Integer() {1, 0, 0, 327680})
		Me.precstep_ud.Maximum = New Decimal(New Integer() {1, 0, 0, 196608})
		Me.precstep_ud.Minimum = New Decimal(New Integer() {1, 0, 0, 327680})
		Me.precstep_ud.Name = "precstep_ud"
		Me.precstep_ud.Value = New Decimal(New Integer() {1, 0, 0, 327680})
		'
		'precdec_rb
		'
		resources.ApplyResources(Me.precdec_rb, "precdec_rb")
		Me.precdec_rb.Checked = true
		Me.precdec_rb.Name = "precdec_rb"
		Me.precdec_rb.TabStop = true
		Me.precdec_rb.UseVisualStyleBackColor = true
		'
		'precinc_rb
		'
		resources.ApplyResources(Me.precinc_rb, "precinc_rb")
		Me.precinc_rb.Name = "precinc_rb"
		Me.precinc_rb.UseVisualStyleBackColor = true
		'
		'cb_prec
		'
		resources.ApplyResources(Me.cb_prec, "cb_prec")
		Me.cb_prec.Name = "cb_prec"
		Me.cb_prec.UseVisualStyleBackColor = true
		AddHandler Me.cb_prec.CheckedChanged, AddressOf Me.Cb_precCheckedChanged
		'
		'precisionpanel
		'
		Me.precisionpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.precisionpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.precisionpanel.Controls.Add(Me.panel3)
		Me.precisionpanel.Controls.Add(Me.precisionbox)
		Me.precisionpanel.Controls.Add(Me.label3)
		Me.precisionpanel.Controls.Add(Me.prec5updown)
		Me.precisionpanel.Controls.Add(Me.prec4updown)
		Me.precisionpanel.Controls.Add(Me.prec3updown)
		Me.precisionpanel.Controls.Add(Me.prec2updown)
		Me.precisionpanel.Controls.Add(Me.prec1updown)
		resources.ApplyResources(Me.precisionpanel, "precisionpanel")
		Me.precisionpanel.Name = "precisionpanel"
		'
		'wavepanel
		'
		Me.wavepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
		Me.wavepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.wavepanel.Controls.Add(Me.wavebar)
		Me.wavepanel.Controls.Add(Me.label1)
		Me.wavepanel.Controls.Add(Me.waveupdown)
		Me.wavepanel.Controls.Add(Me.panel1)
		resources.ApplyResources(Me.wavepanel, "wavepanel")
		Me.wavepanel.Name = "wavepanel"
		'
		'rotationpanel
		'
		Me.rotationpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
		Me.rotationpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.rotationpanel.Controls.Add(Me.rotbar)
		Me.rotationpanel.Controls.Add(Me.label17)
		Me.rotationpanel.Controls.Add(Me.label15)
		Me.rotationpanel.Controls.Add(Me.rot_ud)
		Me.rotationpanel.Controls.Add(Me.panel8)
		resources.ApplyResources(Me.rotationpanel, "rotationpanel")
		Me.rotationpanel.Name = "rotationpanel"
		'
		'rotbar
		'
		Me.rotbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
		resources.ApplyResources(Me.rotbar, "rotbar")
		Me.rotbar.Maximum = 180
		Me.rotbar.Minimum = -180
		Me.rotbar.Name = "rotbar"
		Me.rotbar.TickFrequency = 15
		AddHandler Me.rotbar.Scroll, AddressOf Me.RotbarScroll
		'
		'label17
		'
		resources.ApplyResources(Me.label17, "label17")
		Me.label17.Name = "label17"
		'
		'label15
		'
		resources.ApplyResources(Me.label15, "label15")
		Me.label15.Name = "label15"
		'
		'rot_ud
		'
		Me.rot_ud.DecimalPlaces = 1
		Me.rot_ud.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
		resources.ApplyResources(Me.rot_ud, "rot_ud")
		Me.rot_ud.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
		Me.rot_ud.Minimum = New Decimal(New Integer() {180, 0, 0, -2147483648})
		Me.rot_ud.Name = "rot_ud"
		AddHandler Me.rot_ud.ValueChanged, AddressOf Me.Rot_udValueChanged
		'
		'panel8
		'
		Me.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel8.Controls.Add(Me.rotdec_rb)
		Me.panel8.Controls.Add(Me.label16)
		Me.panel8.Controls.Add(Me.rotstep_ud)
		Me.panel8.Controls.Add(Me.rotinc_rb)
		Me.panel8.Controls.Add(Me.cb_rot)
		resources.ApplyResources(Me.panel8, "panel8")
		Me.panel8.Name = "panel8"
		'
		'rotdec_rb
		'
		resources.ApplyResources(Me.rotdec_rb, "rotdec_rb")
		Me.rotdec_rb.Name = "rotdec_rb"
		Me.rotdec_rb.UseVisualStyleBackColor = true
		'
		'label16
		'
		resources.ApplyResources(Me.label16, "label16")
		Me.label16.Name = "label16"
		'
		'rotstep_ud
		'
		resources.ApplyResources(Me.rotstep_ud, "rotstep_ud")
		Me.rotstep_ud.DecimalPlaces = 1
		Me.rotstep_ud.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
		Me.rotstep_ud.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
		Me.rotstep_ud.Minimum = New Decimal(New Integer() {180, 0, 0, -2147483648})
		Me.rotstep_ud.Name = "rotstep_ud"
		Me.rotstep_ud.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'rotinc_rb
		'
		resources.ApplyResources(Me.rotinc_rb, "rotinc_rb")
		Me.rotinc_rb.Checked = true
		Me.rotinc_rb.Name = "rotinc_rb"
		Me.rotinc_rb.TabStop = true
		Me.rotinc_rb.UseVisualStyleBackColor = true
		'
		'cb_rot
		'
		resources.ApplyResources(Me.cb_rot, "cb_rot")
		Me.cb_rot.Name = "cb_rot"
		Me.cb_rot.UseVisualStyleBackColor = true
		AddHandler Me.cb_rot.CheckedChanged, AddressOf Me.Cb_rotCheckedChanged
		'
		'linkLabel1
		'
		resources.ApplyResources(Me.linkLabel1, "linkLabel1")
		Me.linkLabel1.Name = "linkLabel1"
		Me.linkLabel1.TabStop = true
		AddHandler Me.linkLabel1.LinkClicked, AddressOf Me.LinkLabel1LinkClicked
		'
		'MainForm
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.linkLabel1)
		Me.Controls.Add(Me.btn_random)
		Me.Controls.Add(Me.btn_generate)
		Me.Controls.Add(Me.rotationpanel)
		Me.Controls.Add(Me.wavepanel)
		Me.Controls.Add(Me.precisionpanel)
		Me.Controls.Add(Me.pict_save)
		Me.Controls.Add(Me.cb_autosave)
		Me.Controls.Add(Me.cb_autclr)
		Me.Controls.Add(Me.btn_clear)
		Me.Controls.Add(Me.brushpanel)
		Me.Name = "MainForm"
		CType(Me.waveupdown,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.wavebar,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.prec1updown,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.prec2updown,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.prec3updown,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.prec4updown,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.prec5updown,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_rbf,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_rbt,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_rsf,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_rst,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_gst,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_gsf,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_gbt,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_gbf,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_bst,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_bsf,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_bbt,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_bbf,System.ComponentModel.ISupportInitialize).EndInit
		Me.brushpanel.ResumeLayout(false)
		Me.brushpanel.PerformLayout
		Me.panel_sphere.ResumeLayout(false)
		Me.panel_sphere.PerformLayout
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		CType(Me.radstep_ud,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.radiusupdown,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.radiusbar,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.wavestep_ud,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		Me.panel3.ResumeLayout(false)
		Me.panel3.PerformLayout
		CType(Me.precstep_ud,System.ComponentModel.ISupportInitialize).EndInit
		Me.precisionpanel.ResumeLayout(false)
		Me.precisionpanel.PerformLayout
		Me.wavepanel.ResumeLayout(false)
		Me.wavepanel.PerformLayout
		Me.rotationpanel.ResumeLayout(false)
		Me.rotationpanel.PerformLayout
		CType(Me.rotbar,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.rot_ud,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel8.ResumeLayout(false)
		Me.panel8.PerformLayout
		CType(Me.rotstep_ud,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private linkLabel1 As System.Windows.Forms.LinkLabel
	Private panel_sphere As System.Windows.Forms.Panel
	Private rotbar As System.Windows.Forms.TrackBar
	Private btn_random As System.Windows.Forms.Button
	Private cb_rot As System.Windows.Forms.CheckBox
	Private rotinc_rb As System.Windows.Forms.RadioButton
	Private rotstep_ud As System.Windows.Forms.NumericUpDown
	Private label16 As System.Windows.Forms.Label
	Private rotdec_rb As System.Windows.Forms.RadioButton
	Private panel8 As System.Windows.Forms.Panel
	Private rot_ud As System.Windows.Forms.NumericUpDown
	Private label15 As System.Windows.Forms.Label
	Private label17 As System.Windows.Forms.Label
	Private rotationpanel As System.Windows.Forms.Panel
	Private rb_brush As System.Windows.Forms.RadioButton
	Private wavepanel As System.Windows.Forms.Panel
	Private precisionpanel As System.Windows.Forms.Panel
	Private label14 As System.Windows.Forms.Label
	Private rb_sphere As System.Windows.Forms.RadioButton
	Private precstep_ud As System.Windows.Forms.NumericUpDown
	Private cb_prec As System.Windows.Forms.CheckBox
	Private precinc_rb As System.Windows.Forms.RadioButton
	Private precdec_rb As System.Windows.Forms.RadioButton
	Private panel3 As System.Windows.Forms.Panel
	Private colorDialog1 As System.Windows.Forms.ColorDialog
	Private pict_save As System.Windows.Forms.Button
	Private radinc_rb As System.Windows.Forms.RadioButton
	Private radstep_ud As System.Windows.Forms.NumericUpDown
	Private label11 As System.Windows.Forms.Label
	Private raddec_rb As System.Windows.Forms.RadioButton
	Private panel2 As System.Windows.Forms.Panel
	Private panel1 As System.Windows.Forms.Panel
	Private label10 As System.Windows.Forms.Label
	Private wavestep_ud As System.Windows.Forms.NumericUpDown
	Private wavedec_rb As System.Windows.Forms.RadioButton
	Private waveinc_rb As System.Windows.Forms.RadioButton
	Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private btn_load As System.Windows.Forms.Button
	Private btn_save As System.Windows.Forms.Button
	Private cb_autosave As System.Windows.Forms.CheckBox
	Private brushpanel As System.Windows.Forms.Panel
	Private panel_brush As System.Windows.Forms.Panel
	Private panel_blue As System.Windows.Forms.Panel
	Private ud_bbf As System.Windows.Forms.NumericUpDown
	Private ud_bbt As System.Windows.Forms.NumericUpDown
	Private ud_bsf As System.Windows.Forms.NumericUpDown
	Private ud_bst As System.Windows.Forms.NumericUpDown
	Private label13 As System.Windows.Forms.Label
	Private label12 As System.Windows.Forms.Label
	Private panel_green As System.Windows.Forms.Panel
	Private ud_gbf As System.Windows.Forms.NumericUpDown
	Private ud_gbt As System.Windows.Forms.NumericUpDown
	Private ud_gsf As System.Windows.Forms.NumericUpDown
	Private ud_gst As System.Windows.Forms.NumericUpDown
	Private label9 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private ud_rst As System.Windows.Forms.NumericUpDown
	Private ud_rsf As System.Windows.Forms.NumericUpDown
	Private ud_rbt As System.Windows.Forms.NumericUpDown
	Private ud_rbf As System.Windows.Forms.NumericUpDown
	Private panel_red As System.Windows.Forms.Panel
	Private cb_rad As System.Windows.Forms.CheckBox
	Private cb_wave As System.Windows.Forms.CheckBox
	Private cb_autclr As System.Windows.Forms.CheckBox
	Private btn_clear As System.Windows.Forms.Button
	Private precisionbox As System.Windows.Forms.MaskedTextBox
	Private label3 As System.Windows.Forms.Label
	Private prec5updown As System.Windows.Forms.NumericUpDown
	Private prec4updown As System.Windows.Forms.NumericUpDown
	Private prec3updown As System.Windows.Forms.NumericUpDown
	Private prec2updown As System.Windows.Forms.NumericUpDown
	Private prec1updown As System.Windows.Forms.NumericUpDown
	Private radiusupdown As System.Windows.Forms.NumericUpDown
	Private radiusbar As System.Windows.Forms.TrackBar
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private wavebar As System.Windows.Forms.TrackBar
	Private waveupdown As System.Windows.Forms.NumericUpDown
	Private btn_generate As System.Windows.Forms.Button
	
End Class
