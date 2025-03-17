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
		Me.waveupdown1 = New System.Windows.Forms.NumericUpDown()
		Me.wavebar1 = New System.Windows.Forms.TrackBar()
		Me.label1 = New System.Windows.Forms.Label()
		Me.prec1updown = New System.Windows.Forms.NumericUpDown()
		Me.prec2updown = New System.Windows.Forms.NumericUpDown()
		Me.prec3updown = New System.Windows.Forms.NumericUpDown()
		Me.prec4updown = New System.Windows.Forms.NumericUpDown()
		Me.prec5updown = New System.Windows.Forms.NumericUpDown()
		Me.label3 = New System.Windows.Forms.Label()
		Me.btn_clear = New System.Windows.Forms.Button()
		Me.cb_autclr = New System.Windows.Forms.CheckBox()
		Me.cb_wave1 = New System.Windows.Forms.CheckBox()
		Me.panel_brush = New System.Windows.Forms.Panel()
		Me.brushpanel = New System.Windows.Forms.Panel()
		Me.btn_paramsave = New System.Windows.Forms.Button()
		Me.btn_paramload = New System.Windows.Forms.Button()
		Me.cb_autparsave = New System.Windows.Forms.CheckBox()
		Me.btn_brushload = New System.Windows.Forms.Button()
		Me.btn_quicksave = New System.Windows.Forms.Button()
		Me.pict_save = New System.Windows.Forms.Button()
		Me.btn_random = New System.Windows.Forms.Button()
		Me.rb_brush = New System.Windows.Forms.RadioButton()
		Me.cb_autosave = New System.Windows.Forms.CheckBox()
		Me.panel_sphere = New System.Windows.Forms.Panel()
		Me.cb_brushbase = New System.Windows.Forms.ComboBox()
		Me.label7 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.cb_mode = New System.Windows.Forms.ComboBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.ud_range3down = New System.Windows.Forms.NumericUpDown()
		Me.ud_range2down = New System.Windows.Forms.NumericUpDown()
		Me.ud_blue = New System.Windows.Forms.NumericUpDown()
		Me.radiusupdown = New System.Windows.Forms.NumericUpDown()
		Me.ud_range3up = New System.Windows.Forms.NumericUpDown()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.raddec_rb = New System.Windows.Forms.RadioButton()
		Me.label11 = New System.Windows.Forms.Label()
		Me.radstep_ud = New System.Windows.Forms.NumericUpDown()
		Me.radinc_rb = New System.Windows.Forms.RadioButton()
		Me.cb_rad = New System.Windows.Forms.CheckBox()
		Me.radiusbar = New System.Windows.Forms.TrackBar()
		Me.ud_range2up = New System.Windows.Forms.NumericUpDown()
		Me.ud_range1down = New System.Windows.Forms.NumericUpDown()
		Me.ud_green = New System.Windows.Forms.NumericUpDown()
		Me.ud_range1up = New System.Windows.Forms.NumericUpDown()
		Me.bar_color = New System.Windows.Forms.Panel()
		Me.pn_1up = New System.Windows.Forms.Panel()
		Me.pn_1down = New System.Windows.Forms.Panel()
		Me.pn_2up = New System.Windows.Forms.Panel()
		Me.ud_red = New System.Windows.Forms.NumericUpDown()
		Me.pn_2down = New System.Windows.Forms.Panel()
		Me.pn_3up = New System.Windows.Forms.Panel()
		Me.pn_3down = New System.Windows.Forms.Panel()
		Me.pn_range3 = New System.Windows.Forms.Panel()
		Me.bar_blue = New System.Windows.Forms.Panel()
		Me.tb_blue = New System.Windows.Forms.TrackBar()
		Me.pn_range1 = New System.Windows.Forms.Panel()
		Me.pn_range2 = New System.Windows.Forms.Panel()
		Me.tb_range1down = New System.Windows.Forms.TrackBar()
		Me.tb_range1up = New System.Windows.Forms.TrackBar()
		Me.tb_range2down = New System.Windows.Forms.TrackBar()
		Me.tb_range2up = New System.Windows.Forms.TrackBar()
		Me.bar_green = New System.Windows.Forms.Panel()
		Me.tb_green = New System.Windows.Forms.TrackBar()
		Me.tb_range3down = New System.Windows.Forms.TrackBar()
		Me.tb_range3up = New System.Windows.Forms.TrackBar()
		Me.bar_red = New System.Windows.Forms.Panel()
		Me.tb_red = New System.Windows.Forms.TrackBar()
		Me.rb_sphere = New System.Windows.Forms.RadioButton()
		Me.btn_load = New System.Windows.Forms.Button()
		Me.waveupdown2 = New System.Windows.Forms.NumericUpDown()
		Me.cb_gridmode = New System.Windows.Forms.ComboBox()
		Me.cb_gridtype = New System.Windows.Forms.ComboBox()
		Me.label18 = New System.Windows.Forms.Label()
		Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.precisionbox = New System.Windows.Forms.MaskedTextBox()
		Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.label14 = New System.Windows.Forms.Label()
		Me.precstep_ud = New System.Windows.Forms.NumericUpDown()
		Me.precdec_rb = New System.Windows.Forms.RadioButton()
		Me.precinc_rb = New System.Windows.Forms.RadioButton()
		Me.cb_prec = New System.Windows.Forms.CheckBox()
		Me.precisionpanel = New System.Windows.Forms.Panel()
		Me.wavepanel = New System.Windows.Forms.Panel()
		Me.cb_link = New System.Windows.Forms.CheckBox()
		Me.frameupdown = New System.Windows.Forms.NumericUpDown()
		Me.label5 = New System.Windows.Forms.Label()
		Me.framebar = New System.Windows.Forms.TrackBar()
		Me.btn_as3 = New System.Windows.Forms.Button()
		Me.cb_grid = New System.Windows.Forms.CheckBox()
		Me.label6 = New System.Windows.Forms.Label()
		Me.gridbar = New System.Windows.Forms.TrackBar()
		Me.btn_as2 = New System.Windows.Forms.Button()
		Me.cb_wave2 = New System.Windows.Forms.CheckBox()
		Me.btn_as1 = New System.Windows.Forms.Button()
		Me.label19 = New System.Windows.Forms.Label()
		Me.ud_resolution = New System.Windows.Forms.NumericUpDown()
		Me.label8 = New System.Windows.Forms.Label()
		Me.nud_zoom = New System.Windows.Forms.NumericUpDown()
		Me.label9 = New System.Windows.Forms.Label()
		Me.wavebar2 = New System.Windows.Forms.TrackBar()
		Me.rotationpanel = New System.Windows.Forms.Panel()
		Me.label17 = New System.Windows.Forms.Label()
		Me.label15 = New System.Windows.Forms.Label()
		Me.rot_ud = New System.Windows.Forms.NumericUpDown()
		Me.rotbar = New System.Windows.Forms.TrackBar()
		Me.panel8 = New System.Windows.Forms.Panel()
		Me.rotdec_rb = New System.Windows.Forms.RadioButton()
		Me.label16 = New System.Windows.Forms.Label()
		Me.rotstep_ud = New System.Windows.Forms.NumericUpDown()
		Me.rotinc_rb = New System.Windows.Forms.RadioButton()
		Me.cb_rot = New System.Windows.Forms.CheckBox()
		Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
		CType(Me.waveupdown1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.wavebar1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.prec1updown,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.prec2updown,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.prec3updown,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.prec4updown,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.prec5updown,System.ComponentModel.ISupportInitialize).BeginInit
		Me.brushpanel.SuspendLayout
		Me.panel_sphere.SuspendLayout
		CType(Me.ud_range3down,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_range2down,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_blue,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.radiusupdown,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_range3up,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel2.SuspendLayout
		CType(Me.radstep_ud,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.radiusbar,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_range2up,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_range1down,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_green,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_range1up,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_red,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tb_blue,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tb_range1down,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tb_range1up,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tb_range2down,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tb_range2up,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tb_green,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tb_range3down,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tb_range3up,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tb_red,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.waveupdown2,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel3.SuspendLayout
		CType(Me.precstep_ud,System.ComponentModel.ISupportInitialize).BeginInit
		Me.precisionpanel.SuspendLayout
		Me.wavepanel.SuspendLayout
		CType(Me.frameupdown,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.framebar,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.gridbar,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ud_resolution,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nud_zoom,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.wavebar2,System.ComponentModel.ISupportInitialize).BeginInit
		Me.rotationpanel.SuspendLayout
		CType(Me.rot_ud,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.rotbar,System.ComponentModel.ISupportInitialize).BeginInit
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
		'waveupdown1
		'
		Me.waveupdown1.DecimalPlaces = 2
		resources.ApplyResources(Me.waveupdown1, "waveupdown1")
		Me.waveupdown1.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
		Me.waveupdown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.waveupdown1.Name = "waveupdown1"
		Me.waveupdown1.Value = New Decimal(New Integer() {30, 0, 0, 0})
		AddHandler Me.waveupdown1.ValueChanged, AddressOf Me.Waveupdown1ValueChanged
		'
		'wavebar1
		'
		Me.wavebar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
		resources.ApplyResources(Me.wavebar1, "wavebar1")
		Me.wavebar1.Maximum = 400
		Me.wavebar1.Minimum = 1
		Me.wavebar1.Name = "wavebar1"
		Me.wavebar1.TickFrequency = 20
		Me.wavebar1.Value = 30
		AddHandler Me.wavebar1.Scroll, AddressOf Me.Wavebar1Scroll
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
		AddHandler Me.prec4updown.ValueChanged, AddressOf Me.Prec4updownValueChanged
		'
		'prec5updown
		'
		resources.ApplyResources(Me.prec5updown, "prec5updown")
		Me.prec5updown.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
		Me.prec5updown.Name = "prec5updown"
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
		'cb_wave1
		'
		resources.ApplyResources(Me.cb_wave1, "cb_wave1")
		Me.cb_wave1.Name = "cb_wave1"
		Me.cb_wave1.UseVisualStyleBackColor = true
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
		Me.brushpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(192,Byte),Integer))
		Me.brushpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.brushpanel.Controls.Add(Me.btn_paramsave)
		Me.brushpanel.Controls.Add(Me.btn_paramload)
		Me.brushpanel.Controls.Add(Me.cb_autparsave)
		Me.brushpanel.Controls.Add(Me.btn_brushload)
		Me.brushpanel.Controls.Add(Me.btn_quicksave)
		Me.brushpanel.Controls.Add(Me.pict_save)
		Me.brushpanel.Controls.Add(Me.btn_clear)
		Me.brushpanel.Controls.Add(Me.panel_brush)
		Me.brushpanel.Controls.Add(Me.btn_generate)
		Me.brushpanel.Controls.Add(Me.btn_random)
		Me.brushpanel.Controls.Add(Me.rb_brush)
		Me.brushpanel.Controls.Add(Me.cb_autosave)
		Me.brushpanel.Controls.Add(Me.panel_sphere)
		Me.brushpanel.Controls.Add(Me.cb_autclr)
		Me.brushpanel.Controls.Add(Me.rb_sphere)
		Me.brushpanel.Controls.Add(Me.btn_load)
		resources.ApplyResources(Me.brushpanel, "brushpanel")
		Me.brushpanel.Name = "brushpanel"
		'
		'btn_paramsave
		'
		resources.ApplyResources(Me.btn_paramsave, "btn_paramsave")
		Me.btn_paramsave.Name = "btn_paramsave"
		Me.btn_paramsave.UseVisualStyleBackColor = true
		AddHandler Me.btn_paramsave.Click, AddressOf Me.btn_saveClick
		'
		'btn_paramload
		'
		resources.ApplyResources(Me.btn_paramload, "btn_paramload")
		Me.btn_paramload.Name = "btn_paramload"
		Me.btn_paramload.UseVisualStyleBackColor = true
		AddHandler Me.btn_paramload.Click, AddressOf Me.Btn_paramloadClick
		'
		'cb_autparsave
		'
		resources.ApplyResources(Me.cb_autparsave, "cb_autparsave")
		Me.cb_autparsave.Checked = true
		Me.cb_autparsave.CheckState = System.Windows.Forms.CheckState.Checked
		Me.cb_autparsave.Name = "cb_autparsave"
		Me.cb_autparsave.UseVisualStyleBackColor = true
		'
		'btn_brushload
		'
		resources.ApplyResources(Me.btn_brushload, "btn_brushload")
		Me.btn_brushload.Name = "btn_brushload"
		Me.btn_brushload.UseVisualStyleBackColor = true
		AddHandler Me.btn_brushload.Click, AddressOf Me.Btn_brushloadClick
		'
		'btn_quicksave
		'
		resources.ApplyResources(Me.btn_quicksave, "btn_quicksave")
		Me.btn_quicksave.Name = "btn_quicksave"
		Me.btn_quicksave.UseVisualStyleBackColor = true
		AddHandler Me.btn_quicksave.Click, AddressOf Me.Btn_quicksaveClick
		'
		'pict_save
		'
		resources.ApplyResources(Me.pict_save, "pict_save")
		Me.pict_save.Name = "pict_save"
		Me.pict_save.UseVisualStyleBackColor = true
		AddHandler Me.pict_save.Click, AddressOf Me.Pict_saveClick
		'
		'btn_random
		'
		Me.btn_random.BackColor = System.Drawing.SystemColors.ButtonFace
		resources.ApplyResources(Me.btn_random, "btn_random")
		Me.btn_random.Name = "btn_random"
		Me.btn_random.UseVisualStyleBackColor = false
		AddHandler Me.btn_random.Click, AddressOf Me.Btn_randomClick
		'
		'rb_brush
		'
		resources.ApplyResources(Me.rb_brush, "rb_brush")
		Me.rb_brush.Name = "rb_brush"
		Me.rb_brush.UseVisualStyleBackColor = true
		AddHandler Me.rb_brush.CheckedChanged, AddressOf Me.Rb_brushCheckedChanged
		'
		'cb_autosave
		'
		resources.ApplyResources(Me.cb_autosave, "cb_autosave")
		Me.cb_autosave.Name = "cb_autosave"
		Me.cb_autosave.UseVisualStyleBackColor = true
		'
		'panel_sphere
		'
		Me.panel_sphere.Controls.Add(Me.cb_brushbase)
		Me.panel_sphere.Controls.Add(Me.label7)
		Me.panel_sphere.Controls.Add(Me.label4)
		Me.panel_sphere.Controls.Add(Me.cb_mode)
		Me.panel_sphere.Controls.Add(Me.label2)
		Me.panel_sphere.Controls.Add(Me.ud_range3down)
		Me.panel_sphere.Controls.Add(Me.ud_range2down)
		Me.panel_sphere.Controls.Add(Me.ud_blue)
		Me.panel_sphere.Controls.Add(Me.radiusupdown)
		Me.panel_sphere.Controls.Add(Me.ud_range3up)
		Me.panel_sphere.Controls.Add(Me.panel2)
		Me.panel_sphere.Controls.Add(Me.radiusbar)
		Me.panel_sphere.Controls.Add(Me.ud_range2up)
		Me.panel_sphere.Controls.Add(Me.ud_range1down)
		Me.panel_sphere.Controls.Add(Me.ud_green)
		Me.panel_sphere.Controls.Add(Me.ud_range1up)
		Me.panel_sphere.Controls.Add(Me.bar_color)
		Me.panel_sphere.Controls.Add(Me.pn_1up)
		Me.panel_sphere.Controls.Add(Me.pn_1down)
		Me.panel_sphere.Controls.Add(Me.pn_2up)
		Me.panel_sphere.Controls.Add(Me.ud_red)
		Me.panel_sphere.Controls.Add(Me.pn_2down)
		Me.panel_sphere.Controls.Add(Me.pn_3up)
		Me.panel_sphere.Controls.Add(Me.pn_3down)
		Me.panel_sphere.Controls.Add(Me.pn_range3)
		Me.panel_sphere.Controls.Add(Me.bar_blue)
		Me.panel_sphere.Controls.Add(Me.tb_blue)
		Me.panel_sphere.Controls.Add(Me.pn_range1)
		Me.panel_sphere.Controls.Add(Me.pn_range2)
		Me.panel_sphere.Controls.Add(Me.tb_range1down)
		Me.panel_sphere.Controls.Add(Me.tb_range1up)
		Me.panel_sphere.Controls.Add(Me.tb_range2down)
		Me.panel_sphere.Controls.Add(Me.tb_range2up)
		Me.panel_sphere.Controls.Add(Me.bar_green)
		Me.panel_sphere.Controls.Add(Me.tb_green)
		Me.panel_sphere.Controls.Add(Me.tb_range3down)
		Me.panel_sphere.Controls.Add(Me.tb_range3up)
		Me.panel_sphere.Controls.Add(Me.bar_red)
		Me.panel_sphere.Controls.Add(Me.tb_red)
		resources.ApplyResources(Me.panel_sphere, "panel_sphere")
		Me.panel_sphere.Name = "panel_sphere"
		'
		'cb_brushbase
		'
		Me.cb_brushbase.BackColor = System.Drawing.SystemColors.Window
		resources.ApplyResources(Me.cb_brushbase, "cb_brushbase")
		Me.cb_brushbase.FormattingEnabled = true
		Me.cb_brushbase.Items.AddRange(New Object() {resources.GetString("cb_brushbase.Items"), resources.GetString("cb_brushbase.Items1"), resources.GetString("cb_brushbase.Items2")})
		Me.cb_brushbase.Name = "cb_brushbase"
		AddHandler Me.cb_brushbase.SelectedIndexChanged, AddressOf Me.Cb_brushbaseSelectedIndexChanged
		'
		'label7
		'
		resources.ApplyResources(Me.label7, "label7")
		Me.label7.Name = "label7"
		'
		'label4
		'
		resources.ApplyResources(Me.label4, "label4")
		Me.label4.Name = "label4"
		'
		'cb_mode
		'
		Me.cb_mode.BackColor = System.Drawing.SystemColors.Window
		resources.ApplyResources(Me.cb_mode, "cb_mode")
		Me.cb_mode.FormattingEnabled = true
		Me.cb_mode.Items.AddRange(New Object() {resources.GetString("cb_mode.Items"), resources.GetString("cb_mode.Items1"), resources.GetString("cb_mode.Items2")})
		Me.cb_mode.Name = "cb_mode"
		'
		'label2
		'
		resources.ApplyResources(Me.label2, "label2")
		Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(192,Byte),Integer))
		Me.label2.Name = "label2"
		'
		'ud_range3down
		'
		resources.ApplyResources(Me.ud_range3down, "ud_range3down")
		Me.ud_range3down.Name = "ud_range3down"
		AddHandler Me.ud_range3down.ValueChanged, AddressOf Me.Ud_range3downValueChanged
		'
		'ud_range2down
		'
		resources.ApplyResources(Me.ud_range2down, "ud_range2down")
		Me.ud_range2down.Name = "ud_range2down"
		AddHandler Me.ud_range2down.ValueChanged, AddressOf Me.Ud_range2downValueChanged
		'
		'ud_blue
		'
		resources.ApplyResources(Me.ud_blue, "ud_blue")
		Me.ud_blue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.ud_blue.Name = "ud_blue"
		Me.ud_blue.Value = New Decimal(New Integer() {200, 0, 0, 0})
		AddHandler Me.ud_blue.ValueChanged, AddressOf Me.Ud_blueValueChanged
		'
		'radiusupdown
		'
		resources.ApplyResources(Me.radiusupdown, "radiusupdown")
		Me.radiusupdown.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
		Me.radiusupdown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.radiusupdown.Name = "radiusupdown"
		Me.radiusupdown.Value = New Decimal(New Integer() {50, 0, 0, 0})
		AddHandler Me.radiusupdown.ValueChanged, AddressOf Me.RadiusupdownValueChanged
		'
		'ud_range3up
		'
		resources.ApplyResources(Me.ud_range3up, "ud_range3up")
		Me.ud_range3up.Name = "ud_range3up"
		Me.ud_range3up.Value = New Decimal(New Integer() {100, 0, 0, 0})
		AddHandler Me.ud_range3up.ValueChanged, AddressOf Me.Ud_range3upValueChanged
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
		'cb_rad
		'
		resources.ApplyResources(Me.cb_rad, "cb_rad")
		Me.cb_rad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(192,Byte),Integer))
		Me.cb_rad.Name = "cb_rad"
		Me.cb_rad.UseVisualStyleBackColor = false
		AddHandler Me.cb_rad.CheckedChanged, AddressOf Me.Cb_radCheckedChanged
		'
		'radiusbar
		'
		Me.radiusbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(192,Byte),Integer))
		resources.ApplyResources(Me.radiusbar, "radiusbar")
		Me.radiusbar.Maximum = 400
		Me.radiusbar.Minimum = 1
		Me.radiusbar.Name = "radiusbar"
		Me.radiusbar.TickFrequency = 20
		Me.radiusbar.Value = 50
		AddHandler Me.radiusbar.Scroll, AddressOf Me.RadiusbarScroll
		'
		'ud_range2up
		'
		resources.ApplyResources(Me.ud_range2up, "ud_range2up")
		Me.ud_range2up.Name = "ud_range2up"
		Me.ud_range2up.Value = New Decimal(New Integer() {100, 0, 0, 0})
		AddHandler Me.ud_range2up.ValueChanged, AddressOf Me.Ud_range2upValueChanged
		'
		'ud_range1down
		'
		resources.ApplyResources(Me.ud_range1down, "ud_range1down")
		Me.ud_range1down.Name = "ud_range1down"
		AddHandler Me.ud_range1down.ValueChanged, AddressOf Me.Ud_range1downValueChanged
		'
		'ud_green
		'
		resources.ApplyResources(Me.ud_green, "ud_green")
		Me.ud_green.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.ud_green.Name = "ud_green"
		Me.ud_green.Value = New Decimal(New Integer() {200, 0, 0, 0})
		AddHandler Me.ud_green.ValueChanged, AddressOf Me.Ud_greenValueChanged
		'
		'ud_range1up
		'
		resources.ApplyResources(Me.ud_range1up, "ud_range1up")
		Me.ud_range1up.Name = "ud_range1up"
		Me.ud_range1up.Value = New Decimal(New Integer() {100, 0, 0, 0})
		AddHandler Me.ud_range1up.ValueChanged, AddressOf Me.Ud_range1upValueChanged
		'
		'bar_color
		'
		Me.bar_color.BackColor = System.Drawing.Color.Black
		Me.bar_color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.bar_color, "bar_color")
		Me.bar_color.Name = "bar_color"
		'
		'pn_1up
		'
		Me.pn_1up.BackColor = System.Drawing.Color.Black
		Me.pn_1up.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.pn_1up, "pn_1up")
		Me.pn_1up.Name = "pn_1up"
		AddHandler Me.pn_1up.BackColorChanged, AddressOf Me.Pn_1upBackColorChanged
		AddHandler Me.pn_1up.DoubleClick, AddressOf Me.Pn_1upDoubleClick
		AddHandler Me.pn_1up.MouseClick, AddressOf Me.Pn_1upMouseClick
		'
		'pn_1down
		'
		Me.pn_1down.BackColor = System.Drawing.Color.Red
		Me.pn_1down.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.pn_1down, "pn_1down")
		Me.pn_1down.Name = "pn_1down"
		AddHandler Me.pn_1down.BackColorChanged, AddressOf Me.Pn_1downBackColorChanged
		AddHandler Me.pn_1down.DoubleClick, AddressOf Me.Pn_1downDoubleClick
		AddHandler Me.pn_1down.MouseClick, AddressOf Me.Pn_1downMouseClick
		'
		'pn_2up
		'
		Me.pn_2up.BackColor = System.Drawing.Color.Black
		Me.pn_2up.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.pn_2up, "pn_2up")
		Me.pn_2up.Name = "pn_2up"
		AddHandler Me.pn_2up.BackColorChanged, AddressOf Me.Pn_2upBackColorChanged
		AddHandler Me.pn_2up.DoubleClick, AddressOf Me.Pn_2upDoubleClick
		AddHandler Me.pn_2up.MouseClick, AddressOf Me.Pn_2upMouseClick
		'
		'ud_red
		'
		resources.ApplyResources(Me.ud_red, "ud_red")
		Me.ud_red.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.ud_red.Name = "ud_red"
		Me.ud_red.Value = New Decimal(New Integer() {200, 0, 0, 0})
		AddHandler Me.ud_red.ValueChanged, AddressOf Me.Ud_redValueChanged
		'
		'pn_2down
		'
		Me.pn_2down.BackColor = System.Drawing.Color.Lime
		Me.pn_2down.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.pn_2down, "pn_2down")
		Me.pn_2down.Name = "pn_2down"
		AddHandler Me.pn_2down.BackColorChanged, AddressOf Me.Pn_2downBackColorChanged
		AddHandler Me.pn_2down.DoubleClick, AddressOf Me.Pn_2downDoubleClick
		AddHandler Me.pn_2down.MouseClick, AddressOf Me.Pn_2downMouseClick
		'
		'pn_3up
		'
		Me.pn_3up.BackColor = System.Drawing.Color.Black
		Me.pn_3up.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.pn_3up, "pn_3up")
		Me.pn_3up.Name = "pn_3up"
		AddHandler Me.pn_3up.BackColorChanged, AddressOf Me.Pn_3upBackColorChanged
		AddHandler Me.pn_3up.DoubleClick, AddressOf Me.Pn_3upDoubleClick
		AddHandler Me.pn_3up.MouseClick, AddressOf Me.Pn_3upMouseClick
		'
		'pn_3down
		'
		Me.pn_3down.BackColor = System.Drawing.Color.Blue
		Me.pn_3down.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.pn_3down, "pn_3down")
		Me.pn_3down.Name = "pn_3down"
		AddHandler Me.pn_3down.BackColorChanged, AddressOf Me.Pn_3downBackColorChanged
		AddHandler Me.pn_3down.DoubleClick, AddressOf Me.Pn_3downDoubleClick
		AddHandler Me.pn_3down.MouseClick, AddressOf Me.Pn_3downMouseClick
		'
		'pn_range3
		'
		Me.pn_range3.BackColor = System.Drawing.Color.Black
		Me.pn_range3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.pn_range3, "pn_range3")
		Me.pn_range3.Name = "pn_range3"
		'
		'bar_blue
		'
		Me.bar_blue.BackColor = System.Drawing.Color.Black
		Me.bar_blue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.bar_blue, "bar_blue")
		Me.bar_blue.Name = "bar_blue"
		AddHandler Me.bar_blue.BackColorChanged, AddressOf Me.Bar_blueBackColorChanged
		'
		'tb_blue
		'
		resources.ApplyResources(Me.tb_blue, "tb_blue")
		Me.tb_blue.Maximum = 255
		Me.tb_blue.Name = "tb_blue"
		Me.tb_blue.TickFrequency = 10
		Me.tb_blue.TickStyle = System.Windows.Forms.TickStyle.TopLeft
		Me.tb_blue.Value = 200
		AddHandler Me.tb_blue.Scroll, AddressOf Me.Tb_blueScroll
		'
		'pn_range1
		'
		Me.pn_range1.BackColor = System.Drawing.Color.Black
		Me.pn_range1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.pn_range1, "pn_range1")
		Me.pn_range1.Name = "pn_range1"
		'
		'pn_range2
		'
		Me.pn_range2.BackColor = System.Drawing.Color.Black
		Me.pn_range2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.pn_range2, "pn_range2")
		Me.pn_range2.Name = "pn_range2"
		'
		'tb_range1down
		'
		Me.tb_range1down.LargeChange = 1
		resources.ApplyResources(Me.tb_range1down, "tb_range1down")
		Me.tb_range1down.Maximum = 100
		Me.tb_range1down.Name = "tb_range1down"
		Me.tb_range1down.TickFrequency = 5
		AddHandler Me.tb_range1down.Scroll, AddressOf Me.Tb_range1downScroll
		'
		'tb_range1up
		'
		Me.tb_range1up.LargeChange = 1
		resources.ApplyResources(Me.tb_range1up, "tb_range1up")
		Me.tb_range1up.Maximum = 100
		Me.tb_range1up.Name = "tb_range1up"
		Me.tb_range1up.TickFrequency = 5
		Me.tb_range1up.Value = 100
		AddHandler Me.tb_range1up.Scroll, AddressOf Me.Tb_range1upScroll
		'
		'tb_range2down
		'
		Me.tb_range2down.LargeChange = 1
		resources.ApplyResources(Me.tb_range2down, "tb_range2down")
		Me.tb_range2down.Maximum = 100
		Me.tb_range2down.Name = "tb_range2down"
		Me.tb_range2down.TickFrequency = 5
		AddHandler Me.tb_range2down.Scroll, AddressOf Me.Tb_range2downScroll
		'
		'tb_range2up
		'
		Me.tb_range2up.LargeChange = 1
		resources.ApplyResources(Me.tb_range2up, "tb_range2up")
		Me.tb_range2up.Maximum = 100
		Me.tb_range2up.Name = "tb_range2up"
		Me.tb_range2up.TickFrequency = 5
		Me.tb_range2up.Value = 100
		AddHandler Me.tb_range2up.Scroll, AddressOf Me.Tb_range2upScroll
		'
		'bar_green
		'
		Me.bar_green.BackColor = System.Drawing.Color.Black
		Me.bar_green.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.bar_green, "bar_green")
		Me.bar_green.Name = "bar_green"
		AddHandler Me.bar_green.BackColorChanged, AddressOf Me.Bar_greenBackColorChanged
		'
		'tb_green
		'
		resources.ApplyResources(Me.tb_green, "tb_green")
		Me.tb_green.Maximum = 255
		Me.tb_green.Name = "tb_green"
		Me.tb_green.TickFrequency = 10
		Me.tb_green.TickStyle = System.Windows.Forms.TickStyle.TopLeft
		Me.tb_green.Value = 200
		AddHandler Me.tb_green.Scroll, AddressOf Me.Tb_greenScroll
		'
		'tb_range3down
		'
		Me.tb_range3down.LargeChange = 1
		resources.ApplyResources(Me.tb_range3down, "tb_range3down")
		Me.tb_range3down.Maximum = 100
		Me.tb_range3down.Name = "tb_range3down"
		Me.tb_range3down.TickFrequency = 5
		AddHandler Me.tb_range3down.Scroll, AddressOf Me.Tb_range3downScroll
		'
		'tb_range3up
		'
		Me.tb_range3up.LargeChange = 1
		resources.ApplyResources(Me.tb_range3up, "tb_range3up")
		Me.tb_range3up.Maximum = 100
		Me.tb_range3up.Name = "tb_range3up"
		Me.tb_range3up.TickFrequency = 5
		Me.tb_range3up.Value = 100
		AddHandler Me.tb_range3up.Scroll, AddressOf Me.Tb_range3upScroll
		'
		'bar_red
		'
		Me.bar_red.BackColor = System.Drawing.Color.Black
		Me.bar_red.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.bar_red, "bar_red")
		Me.bar_red.Name = "bar_red"
		AddHandler Me.bar_red.BackColorChanged, AddressOf Me.Bar_redBackColorChanged
		'
		'tb_red
		'
		resources.ApplyResources(Me.tb_red, "tb_red")
		Me.tb_red.Maximum = 255
		Me.tb_red.Name = "tb_red"
		Me.tb_red.TickFrequency = 10
		Me.tb_red.TickStyle = System.Windows.Forms.TickStyle.TopLeft
		Me.tb_red.Value = 200
		AddHandler Me.tb_red.Scroll, AddressOf Me.Tb_redScroll
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
		'btn_load
		'
		resources.ApplyResources(Me.btn_load, "btn_load")
		Me.btn_load.Name = "btn_load"
		Me.btn_load.UseVisualStyleBackColor = true
		AddHandler Me.btn_load.Click, AddressOf Me.btnload_Click
		'
		'waveupdown2
		'
		Me.waveupdown2.DecimalPlaces = 2
		resources.ApplyResources(Me.waveupdown2, "waveupdown2")
		Me.waveupdown2.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
		Me.waveupdown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.waveupdown2.Name = "waveupdown2"
		Me.waveupdown2.Value = New Decimal(New Integer() {30, 0, 0, 0})
		AddHandler Me.waveupdown2.ValueChanged, AddressOf Me.Waveupdown2ValueChanged
		'
		'cb_gridmode
		'
		resources.ApplyResources(Me.cb_gridmode, "cb_gridmode")
		Me.cb_gridmode.FormattingEnabled = true
		Me.cb_gridmode.Items.AddRange(New Object() {resources.GetString("cb_gridmode.Items"), resources.GetString("cb_gridmode.Items1"), resources.GetString("cb_gridmode.Items2"), resources.GetString("cb_gridmode.Items3"), resources.GetString("cb_gridmode.Items4"), resources.GetString("cb_gridmode.Items5"), resources.GetString("cb_gridmode.Items6"), resources.GetString("cb_gridmode.Items7"), resources.GetString("cb_gridmode.Items8"), resources.GetString("cb_gridmode.Items9"), resources.GetString("cb_gridmode.Items10")})
		Me.cb_gridmode.Name = "cb_gridmode"
		'
		'cb_gridtype
		'
		resources.ApplyResources(Me.cb_gridtype, "cb_gridtype")
		Me.cb_gridtype.FormattingEnabled = true
		Me.cb_gridtype.Items.AddRange(New Object() {resources.GetString("cb_gridtype.Items"), resources.GetString("cb_gridtype.Items1"), resources.GetString("cb_gridtype.Items2"), resources.GetString("cb_gridtype.Items3"), resources.GetString("cb_gridtype.Items4"), resources.GetString("cb_gridtype.Items5")})
		Me.cb_gridtype.Name = "cb_gridtype"
		AddHandler Me.cb_gridtype.SelectedIndexChanged, AddressOf Me.Cb_gridtypeSelectedIndexChanged
		'
		'label18
		'
		resources.ApplyResources(Me.label18, "label18")
		Me.label18.Name = "label18"
		'
		'precisionbox
		'
		Me.precisionbox.AsciiOnly = true
		Me.precisionbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		resources.ApplyResources(Me.precisionbox, "precisionbox")
		Me.precisionbox.Name = "precisionbox"
		Me.precisionbox.ReadOnly = true
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
		Me.wavepanel.Controls.Add(Me.waveupdown2)
		Me.wavepanel.Controls.Add(Me.waveupdown1)
		Me.wavepanel.Controls.Add(Me.cb_link)
		Me.wavepanel.Controls.Add(Me.frameupdown)
		Me.wavepanel.Controls.Add(Me.cb_gridmode)
		Me.wavepanel.Controls.Add(Me.label5)
		Me.wavepanel.Controls.Add(Me.cb_gridtype)
		Me.wavepanel.Controls.Add(Me.framebar)
		Me.wavepanel.Controls.Add(Me.btn_as3)
		Me.wavepanel.Controls.Add(Me.cb_grid)
		Me.wavepanel.Controls.Add(Me.label6)
		Me.wavepanel.Controls.Add(Me.gridbar)
		Me.wavepanel.Controls.Add(Me.btn_as2)
		Me.wavepanel.Controls.Add(Me.cb_wave2)
		Me.wavepanel.Controls.Add(Me.btn_as1)
		Me.wavepanel.Controls.Add(Me.label19)
		Me.wavepanel.Controls.Add(Me.ud_resolution)
		Me.wavepanel.Controls.Add(Me.label8)
		Me.wavepanel.Controls.Add(Me.nud_zoom)
		Me.wavepanel.Controls.Add(Me.cb_wave1)
		Me.wavepanel.Controls.Add(Me.label9)
		Me.wavepanel.Controls.Add(Me.wavebar2)
		Me.wavepanel.Controls.Add(Me.label1)
		Me.wavepanel.Controls.Add(Me.label18)
		Me.wavepanel.Controls.Add(Me.wavebar1)
		resources.ApplyResources(Me.wavepanel, "wavepanel")
		Me.wavepanel.Name = "wavepanel"
		'
		'cb_link
		'
		resources.ApplyResources(Me.cb_link, "cb_link")
		Me.cb_link.Checked = true
		Me.cb_link.CheckState = System.Windows.Forms.CheckState.Checked
		Me.cb_link.Name = "cb_link"
		Me.cb_link.UseVisualStyleBackColor = true
		AddHandler Me.cb_link.CheckedChanged, AddressOf Me.Cb_linkCheckedChanged
		'
		'frameupdown
		'
		resources.ApplyResources(Me.frameupdown, "frameupdown")
		Me.frameupdown.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
		Me.frameupdown.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
		Me.frameupdown.Name = "frameupdown"
		AddHandler Me.frameupdown.ValueChanged, AddressOf Me.FrameupdownValueChanged
		'
		'label5
		'
		resources.ApplyResources(Me.label5, "label5")
		Me.label5.Name = "label5"
		'
		'framebar
		'
		Me.framebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
		resources.ApplyResources(Me.framebar, "framebar")
		Me.framebar.Maximum = 400
		Me.framebar.Minimum = -100
		Me.framebar.Name = "framebar"
		Me.framebar.TickFrequency = 25
		AddHandler Me.framebar.Scroll, AddressOf Me.FramebarScroll
		'
		'btn_as3
		'
		resources.ApplyResources(Me.btn_as3, "btn_as3")
		Me.btn_as3.Name = "btn_as3"
		Me.btn_as3.UseVisualStyleBackColor = true
		AddHandler Me.btn_as3.Click, AddressOf Me.Btn_as3Click
		'
		'cb_grid
		'
		resources.ApplyResources(Me.cb_grid, "cb_grid")
		Me.cb_grid.Name = "cb_grid"
		Me.cb_grid.UseVisualStyleBackColor = true
		'
		'label6
		'
		resources.ApplyResources(Me.label6, "label6")
		Me.label6.Name = "label6"
		'
		'gridbar
		'
		Me.gridbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
		resources.ApplyResources(Me.gridbar, "gridbar")
		Me.gridbar.Maximum = 800
		Me.gridbar.Minimum = 1
		Me.gridbar.Name = "gridbar"
		Me.gridbar.TickFrequency = 25
		Me.gridbar.Value = 800
		AddHandler Me.gridbar.Scroll, AddressOf Me.GridbarScroll
		'
		'btn_as2
		'
		resources.ApplyResources(Me.btn_as2, "btn_as2")
		Me.btn_as2.Name = "btn_as2"
		Me.btn_as2.UseVisualStyleBackColor = true
		AddHandler Me.btn_as2.Click, AddressOf Me.Btn_as2Click
		'
		'cb_wave2
		'
		resources.ApplyResources(Me.cb_wave2, "cb_wave2")
		Me.cb_wave2.Name = "cb_wave2"
		Me.cb_wave2.UseVisualStyleBackColor = true
		'
		'btn_as1
		'
		resources.ApplyResources(Me.btn_as1, "btn_as1")
		Me.btn_as1.Name = "btn_as1"
		Me.btn_as1.UseVisualStyleBackColor = true
		AddHandler Me.btn_as1.Click, AddressOf Me.Btn_as1Click
		'
		'label19
		'
		resources.ApplyResources(Me.label19, "label19")
		Me.label19.Name = "label19"
		'
		'ud_resolution
		'
		resources.ApplyResources(Me.ud_resolution, "ud_resolution")
		Me.ud_resolution.Maximum = New Decimal(New Integer() {800, 0, 0, 0})
		Me.ud_resolution.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.ud_resolution.Name = "ud_resolution"
		Me.ud_resolution.Value = New Decimal(New Integer() {800, 0, 0, 0})
		AddHandler Me.ud_resolution.ValueChanged, AddressOf Me.Ud_resolutionValueChanged
		'
		'label8
		'
		resources.ApplyResources(Me.label8, "label8")
		Me.label8.Name = "label8"
		'
		'nud_zoom
		'
		resources.ApplyResources(Me.nud_zoom, "nud_zoom")
		Me.nud_zoom.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
		Me.nud_zoom.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nud_zoom.Name = "nud_zoom"
		Me.nud_zoom.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'label9
		'
		resources.ApplyResources(Me.label9, "label9")
		Me.label9.Name = "label9"
		'
		'wavebar2
		'
		Me.wavebar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
		resources.ApplyResources(Me.wavebar2, "wavebar2")
		Me.wavebar2.Maximum = 400
		Me.wavebar2.Minimum = 1
		Me.wavebar2.Name = "wavebar2"
		Me.wavebar2.TickFrequency = 20
		Me.wavebar2.Value = 30
		AddHandler Me.wavebar2.Scroll, AddressOf Me.Wavebar2Scroll
		'
		'rotationpanel
		'
		Me.rotationpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
		Me.rotationpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.rotationpanel.Controls.Add(Me.label17)
		Me.rotationpanel.Controls.Add(Me.label15)
		Me.rotationpanel.Controls.Add(Me.rot_ud)
		Me.rotationpanel.Controls.Add(Me.rotbar)
		Me.rotationpanel.Controls.Add(Me.panel8)
		resources.ApplyResources(Me.rotationpanel, "rotationpanel")
		Me.rotationpanel.Name = "rotationpanel"
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
		resources.ApplyResources(Me.rot_ud, "rot_ud")
		Me.rot_ud.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
		Me.rot_ud.Minimum = New Decimal(New Integer() {180, 0, 0, -2147483648})
		Me.rot_ud.Name = "rot_ud"
		AddHandler Me.rot_ud.ValueChanged, AddressOf Me.Rot_udValueChanged
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
		AddHandler Me.rotstep_ud.ValueChanged, AddressOf Me.Rotstep_udValueChanged
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
		Me.Controls.Add(Me.rotationpanel)
		Me.Controls.Add(Me.wavepanel)
		Me.Controls.Add(Me.precisionpanel)
		Me.Controls.Add(Me.brushpanel)
		Me.Name = "MainForm"
		CType(Me.waveupdown1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.wavebar1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.prec1updown,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.prec2updown,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.prec3updown,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.prec4updown,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.prec5updown,System.ComponentModel.ISupportInitialize).EndInit
		Me.brushpanel.ResumeLayout(false)
		Me.brushpanel.PerformLayout
		Me.panel_sphere.ResumeLayout(false)
		Me.panel_sphere.PerformLayout
		CType(Me.ud_range3down,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_range2down,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_blue,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.radiusupdown,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_range3up,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		CType(Me.radstep_ud,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.radiusbar,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_range2up,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_range1down,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_green,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_range1up,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_red,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tb_blue,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tb_range1down,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tb_range1up,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tb_range2down,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tb_range2up,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tb_green,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tb_range3down,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tb_range3up,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tb_red,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.waveupdown2,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel3.ResumeLayout(false)
		Me.panel3.PerformLayout
		CType(Me.precstep_ud,System.ComponentModel.ISupportInitialize).EndInit
		Me.precisionpanel.ResumeLayout(false)
		Me.precisionpanel.PerformLayout
		Me.wavepanel.ResumeLayout(false)
		Me.wavepanel.PerformLayout
		CType(Me.frameupdown,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.framebar,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.gridbar,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ud_resolution,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nud_zoom,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.wavebar2,System.ComponentModel.ISupportInitialize).EndInit
		Me.rotationpanel.ResumeLayout(false)
		Me.rotationpanel.PerformLayout
		CType(Me.rot_ud,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.rotbar,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel8.ResumeLayout(false)
		Me.panel8.PerformLayout
		CType(Me.rotstep_ud,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private cb_link As System.Windows.Forms.CheckBox
	Private cb_wave2 As System.Windows.Forms.CheckBox
	Private btn_as2 As System.Windows.Forms.Button
	Private gridbar As System.Windows.Forms.TrackBar
	Private cb_grid As System.Windows.Forms.CheckBox
	Private btn_as3 As System.Windows.Forms.Button
	Private btn_as1 As System.Windows.Forms.Button
	Private wavebar2 As System.Windows.Forms.TrackBar
	Private label9 As System.Windows.Forms.Label
	Public waveupdown2 As System.Windows.Forms.NumericUpDown
	Private cb_autparsave As System.Windows.Forms.CheckBox
	Private btn_paramload As System.Windows.Forms.Button
	Private btn_brushload As System.Windows.Forms.Button
	Private nud_zoom As System.Windows.Forms.NumericUpDown
	Private label8 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private cb_brushbase As System.Windows.Forms.ComboBox
	Public ud_resolution As System.Windows.Forms.NumericUpDown
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private cb_gridmode As System.Windows.Forms.ComboBox
	Private btn_quicksave As System.Windows.Forms.Button
	Private label4 As System.Windows.Forms.Label
	Private cb_mode As System.Windows.Forms.ComboBox
	Private ud_range1up As System.Windows.Forms.NumericUpDown
	Private ud_range1down As System.Windows.Forms.NumericUpDown
	Private ud_range2up As System.Windows.Forms.NumericUpDown
	Private ud_range3up As System.Windows.Forms.NumericUpDown
	Private ud_range2down As System.Windows.Forms.NumericUpDown
	Private ud_range3down As System.Windows.Forms.NumericUpDown
	Private ud_blue As System.Windows.Forms.NumericUpDown
	Private ud_green As System.Windows.Forms.NumericUpDown
	Private ud_red As System.Windows.Forms.NumericUpDown
	Private bar_color As System.Windows.Forms.Panel
	Private pn_3up As System.Windows.Forms.Panel
	Private pn_3down As System.Windows.Forms.Panel
	Private pn_2up As System.Windows.Forms.Panel
	Private pn_2down As System.Windows.Forms.Panel
	Private pn_1down As System.Windows.Forms.Panel
	Private pn_1up As System.Windows.Forms.Panel
	Private tb_blue As System.Windows.Forms.TrackBar
	Private bar_blue As System.Windows.Forms.Panel
	Private tb_green As System.Windows.Forms.TrackBar
	Private bar_green As System.Windows.Forms.Panel
	Private bar_red As System.Windows.Forms.Panel
	Private tb_red As System.Windows.Forms.TrackBar
	Private tb_range3down As System.Windows.Forms.TrackBar
	Private tb_range3up As System.Windows.Forms.TrackBar
	Private pn_range3 As System.Windows.Forms.Panel
	Private tb_range2down As System.Windows.Forms.TrackBar
	Private tb_range2up As System.Windows.Forms.TrackBar
	Private pn_range2 As System.Windows.Forms.Panel
	Private tb_range1down As System.Windows.Forms.TrackBar
	Private tb_range1up As System.Windows.Forms.TrackBar
	Private pn_range1 As System.Windows.Forms.Panel
	Private frameupdown As System.Windows.Forms.NumericUpDown
	Private label19 As System.Windows.Forms.Label
	Private framebar As System.Windows.Forms.TrackBar
	Private label18 As System.Windows.Forms.Label
	Private cb_gridtype As System.Windows.Forms.ComboBox
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
	Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private btn_load As System.Windows.Forms.Button
	Private btn_paramsave As System.Windows.Forms.Button
	Private cb_autosave As System.Windows.Forms.CheckBox
	Private brushpanel As System.Windows.Forms.Panel
	Private panel_brush As System.Windows.Forms.Panel
	Private cb_rad As System.Windows.Forms.CheckBox
	Private cb_wave1 As System.Windows.Forms.CheckBox
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
	Private wavebar1 As System.Windows.Forms.TrackBar
	Public waveupdown1 As System.Windows.Forms.NumericUpDown
	Private btn_generate As System.Windows.Forms.Button
	
	
End Class
