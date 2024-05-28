<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class T3_Manager
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		Form_Initialize_renamed()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Show_Manual As System.Windows.Forms.Button
	Public WithEvents Scrolling_Mod_Button As System.Windows.Forms.Button
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
	Public WithEvents programming As System.Windows.Forms.CheckBox
	Public WithEvents Picture11 As System.Windows.Forms.PictureBox
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Frame8 As System.Windows.Forms.GroupBox
	Public WithEvents Insert As System.Windows.Forms.CheckBox
	Public WithEvents Send_Program_Step_Backward_To_T3 As System.Windows.Forms.Button
	Public WithEvents Send_Program_Step_Forward_To_T3 As System.Windows.Forms.Button
	Public WithEvents ProgramCommandList As System.Windows.Forms.ListBox
	Public WithEvents MoveCommandDown As System.Windows.Forms.Button
	Public WithEvents MoveCommandUp As System.Windows.Forms.Button
	Public WithEvents RemoveCommand As System.Windows.Forms.Button
	Public WithEvents ClearProgramCommandList As System.Windows.Forms.Button
	Public WithEvents SaveProgram As System.Windows.Forms.Button
	Public WithEvents LoadProgram As System.Windows.Forms.Button
	Public WithEvents programEditorPath As System.Windows.Forms.TextBox
	Public WithEvents programPath As System.Windows.Forms.TextBox
	Public WithEvents EditProgram As System.Windows.Forms.Button
	Public WithEvents SelectProgramEditorButton As System.Windows.Forms.Button
	Public WithEvents Send_Program_To_T3 As System.Windows.Forms.Button
	Public WithEvents selectProgram_Button As System.Windows.Forms.Button
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents Com_Number As System.Windows.Forms.TextBox
	Public WithEvents Combo_Com_Setting As System.Windows.Forms.ComboBox
	Public WithEvents ProgressBarSend As System.Windows.Forms.ProgressBar
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents LabelProgress As System.Windows.Forms.Label
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents Picture2 As System.Windows.Forms.PictureBox
	Public WithEvents Picture6 As System.Windows.Forms.PictureBox
	Public WithEvents Picture4 As System.Windows.Forms.PictureBox
	Public WithEvents Picture1 As System.Windows.Forms.PictureBox
	Public WithEvents TD_120_button As System.Windows.Forms.Button
	Public WithEvents TD_90_button As System.Windows.Forms.Button
	Public WithEvents TD_60_button As System.Windows.Forms.Button
	Public WithEvents TD_45_button As System.Windows.Forms.Button
	Public WithEvents TD_30_button As System.Windows.Forms.Button
	Public WithEvents TD_15_button As System.Windows.Forms.Button
	Public WithEvents TD_1_button As System.Windows.Forms.Button
	Public WithEvents TG_120_button As System.Windows.Forms.Button
	Public WithEvents TG_90_button As System.Windows.Forms.Button
	Public WithEvents TG_60_button As System.Windows.Forms.Button
	Public WithEvents TG_45_button As System.Windows.Forms.Button
	Public WithEvents TG_30_button As System.Windows.Forms.Button
	Public WithEvents TG_15_button As System.Windows.Forms.Button
	Public WithEvents TG_1_button As System.Windows.Forms.Button
	Public WithEvents RE_20_button As System.Windows.Forms.Button
	Public WithEvents RE_10_button As System.Windows.Forms.Button
	Public WithEvents RE_1_button As System.Windows.Forms.Button
	Public WithEvents AV_20_button As System.Windows.Forms.Button
	Public WithEvents AV_10_button As System.Windows.Forms.Button
	Public WithEvents AV_1_button As System.Windows.Forms.Button
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Picture10 As System.Windows.Forms.PictureBox
	Public WithEvents Picture5 As System.Windows.Forms.PictureBox
	Public WithEvents Picture9 As System.Windows.Forms.PictureBox
	Public WithEvents Picture8 As System.Windows.Forms.PictureBox
	Public WithEvents Picture7 As System.Windows.Forms.PictureBox
	Public WithEvents Picture3 As System.Windows.Forms.PictureBox
	Public WithEvents B_C_button As System.Windows.Forms.Button
	Public WithEvents L_C_button As System.Windows.Forms.Button
	Public WithEvents RALE_button As System.Windows.Forms.Button
	Public WithEvents SONNE_button As System.Windows.Forms.Button
	Public WithEvents JOUE_AIR_button As System.Windows.Forms.Button
	Public WithEvents ALLUME_button As System.Windows.Forms.Button
	Public WithEvents ETEINS_button As System.Windows.Forms.Button
	Public WithEvents ETEINS_G_button As System.Windows.Forms.Button
	Public WithEvents ETEINS_D_button As System.Windows.Forms.Button
	Public WithEvents CLIGNE_G_button As System.Windows.Forms.Button
	Public WithEvents CLIGNE_D_button As System.Windows.Forms.Button
	Public WithEvents ARC_AVG_5_button As System.Windows.Forms.Button
	Public WithEvents ARC_AVG_10_button As System.Windows.Forms.Button
	Public WithEvents ARC_AVG_20_button As System.Windows.Forms.Button
	Public WithEvents ARC_AVD_5_button As System.Windows.Forms.Button
	Public WithEvents ARC_AVD_10_button As System.Windows.Forms.Button
	Public WithEvents ARC_AVD_20_button As System.Windows.Forms.Button
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents PROCEDURE_N1_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N2_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N3_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N4_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N5_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N6_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N7_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N8_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N9_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N10_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N11_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N12_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N13_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N14_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N15_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N16_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N17_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N18_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N19_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N20_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N21_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N22_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N23_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N24_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N26_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N27_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N28_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N29_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N30_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N31_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N32_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N33_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N34_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N36_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N25_button As System.Windows.Forms.Button
	Public WithEvents PROCEDURE_N35_button As System.Windows.Forms.Button
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents TOUCHE_STOP_button As System.Windows.Forms.Button
	Public WithEvents TOUCHE_AR_button As System.Windows.Forms.Button
	Public WithEvents TOUCHE_AVD_button As System.Windows.Forms.Button
	Public WithEvents TOUCHE_AVG_button As System.Windows.Forms.Button
	Public WithEvents TEST_button As System.Windows.Forms.Button
	Public WithEvents REGLAGE_button As System.Windows.Forms.Button
	Public WithEvents GOMME_button As System.Windows.Forms.Button
	Public WithEvents OUBLIE_button As System.Windows.Forms.Button
	Public WithEvents SUPPRIME_button As System.Windows.Forms.Button
	Public WithEvents FIN_button As System.Windows.Forms.Button
	Public WithEvents TOUT_button As System.Windows.Forms.Button
	Public WithEvents DES_QUE_button As System.Windows.Forms.Button
	Public WithEvents ARRET_button As System.Windows.Forms.Button
	Public WithEvents EXECUTE_M_button As System.Windows.Forms.Button
	Public WithEvents EXECUTE_P_button As System.Windows.Forms.Button
	Public WithEvents EXECUTE_button As System.Windows.Forms.Button
	Public WithEvents C_EST_button As System.Windows.Forms.Button
	Public WithEvents APPRENDS_button As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Cards_Treatment As System.Windows.Forms.GroupBox
	Public WithEvents Calibrate_T3 As System.Windows.Forms.Button
	Public WithEvents UseCorrections As System.Windows.Forms.CheckBox
	Public WithEvents selectImage_Button As System.Windows.Forms.Button
	Public WithEvents Generate_Command_List As System.Windows.Forms.Button
	Public WithEvents Send_Image_To_T3 As System.Windows.Forms.Button
	Public WithEvents imagePath As System.Windows.Forms.TextBox
	Public WithEvents imageEditorPath As System.Windows.Forms.TextBox
	Public WithEvents SelectImageEditorButton As System.Windows.Forms.Button
	Public WithEvents EditImage As System.Windows.Forms.Button
	Public WithEvents TextCommandList As System.Windows.Forms.TextBox
	Public WithEvents Size_Renamed As System.Windows.Forms.TextBox
	Public WithEvents MSComm1 As MSComm
	Public WithEvents LabelImage As System.Windows.Forms.Label
	Public WithEvents LabelEditor As System.Windows.Forms.Label
	Public WithEvents LabelCommandList As System.Windows.Forms.Label
	Public WithEvents LabelScale As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Image_Treatment As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(T3_Manager))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame9 = New System.Windows.Forms.GroupBox
		Me.Show_Manual = New System.Windows.Forms.Button
		Me.Scrolling_Mod_Button = New System.Windows.Forms.Button
		Me.Frame5 = New System.Windows.Forms.GroupBox
		Me.programming = New System.Windows.Forms.CheckBox
		Me.Frame8 = New System.Windows.Forms.GroupBox
		Me.Picture11 = New System.Windows.Forms.PictureBox
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Insert = New System.Windows.Forms.CheckBox
		Me.Send_Program_Step_Backward_To_T3 = New System.Windows.Forms.Button
		Me.Send_Program_Step_Forward_To_T3 = New System.Windows.Forms.Button
		Me.ProgramCommandList = New System.Windows.Forms.ListBox
		Me.MoveCommandDown = New System.Windows.Forms.Button
		Me.MoveCommandUp = New System.Windows.Forms.Button
		Me.RemoveCommand = New System.Windows.Forms.Button
		Me.ClearProgramCommandList = New System.Windows.Forms.Button
		Me.SaveProgram = New System.Windows.Forms.Button
		Me.LoadProgram = New System.Windows.Forms.Button
		Me.programEditorPath = New System.Windows.Forms.TextBox
		Me.programPath = New System.Windows.Forms.TextBox
		Me.EditProgram = New System.Windows.Forms.Button
		Me.SelectProgramEditorButton = New System.Windows.Forms.Button
		Me.Send_Program_To_T3 = New System.Windows.Forms.Button
		Me.selectProgram_Button = New System.Windows.Forms.Button
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Frame6 = New System.Windows.Forms.GroupBox
		Me.Com_Number = New System.Windows.Forms.TextBox
		Me.Combo_Com_Setting = New System.Windows.Forms.ComboBox
		Me.ProgressBarSend = New System.Windows.Forms.ProgressBar
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.LabelProgress = New System.Windows.Forms.Label
		Me.Cards_Treatment = New System.Windows.Forms.GroupBox
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.Picture2 = New System.Windows.Forms.PictureBox
		Me.Picture6 = New System.Windows.Forms.PictureBox
		Me.Picture4 = New System.Windows.Forms.PictureBox
		Me.Picture1 = New System.Windows.Forms.PictureBox
		Me.TD_120_button = New System.Windows.Forms.Button
		Me.TD_90_button = New System.Windows.Forms.Button
		Me.TD_60_button = New System.Windows.Forms.Button
		Me.TD_45_button = New System.Windows.Forms.Button
		Me.TD_30_button = New System.Windows.Forms.Button
		Me.TD_15_button = New System.Windows.Forms.Button
		Me.TD_1_button = New System.Windows.Forms.Button
		Me.TG_120_button = New System.Windows.Forms.Button
		Me.TG_90_button = New System.Windows.Forms.Button
		Me.TG_60_button = New System.Windows.Forms.Button
		Me.TG_45_button = New System.Windows.Forms.Button
		Me.TG_30_button = New System.Windows.Forms.Button
		Me.TG_15_button = New System.Windows.Forms.Button
		Me.TG_1_button = New System.Windows.Forms.Button
		Me.RE_20_button = New System.Windows.Forms.Button
		Me.RE_10_button = New System.Windows.Forms.Button
		Me.RE_1_button = New System.Windows.Forms.Button
		Me.AV_20_button = New System.Windows.Forms.Button
		Me.AV_10_button = New System.Windows.Forms.Button
		Me.AV_1_button = New System.Windows.Forms.Button
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.Picture10 = New System.Windows.Forms.PictureBox
		Me.Picture5 = New System.Windows.Forms.PictureBox
		Me.Picture9 = New System.Windows.Forms.PictureBox
		Me.Picture8 = New System.Windows.Forms.PictureBox
		Me.Picture7 = New System.Windows.Forms.PictureBox
		Me.Picture3 = New System.Windows.Forms.PictureBox
		Me.B_C_button = New System.Windows.Forms.Button
		Me.L_C_button = New System.Windows.Forms.Button
		Me.RALE_button = New System.Windows.Forms.Button
		Me.SONNE_button = New System.Windows.Forms.Button
		Me.JOUE_AIR_button = New System.Windows.Forms.Button
		Me.ALLUME_button = New System.Windows.Forms.Button
		Me.ETEINS_button = New System.Windows.Forms.Button
		Me.ETEINS_G_button = New System.Windows.Forms.Button
		Me.ETEINS_D_button = New System.Windows.Forms.Button
		Me.CLIGNE_G_button = New System.Windows.Forms.Button
		Me.CLIGNE_D_button = New System.Windows.Forms.Button
		Me.ARC_AVG_5_button = New System.Windows.Forms.Button
		Me.ARC_AVG_10_button = New System.Windows.Forms.Button
		Me.ARC_AVG_20_button = New System.Windows.Forms.Button
		Me.ARC_AVD_5_button = New System.Windows.Forms.Button
		Me.ARC_AVD_10_button = New System.Windows.Forms.Button
		Me.ARC_AVD_20_button = New System.Windows.Forms.Button
		Me.Frame4 = New System.Windows.Forms.GroupBox
		Me.PROCEDURE_N1_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N2_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N3_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N4_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N5_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N6_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N7_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N8_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N9_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N10_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N11_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N12_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N13_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N14_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N15_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N16_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N17_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N18_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N19_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N20_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N21_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N22_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N23_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N24_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N26_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N27_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N28_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N29_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N30_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N31_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N32_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N33_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N34_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N36_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N25_button = New System.Windows.Forms.Button
		Me.PROCEDURE_N35_button = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.TOUCHE_STOP_button = New System.Windows.Forms.Button
		Me.TOUCHE_AR_button = New System.Windows.Forms.Button
		Me.TOUCHE_AVD_button = New System.Windows.Forms.Button
		Me.TOUCHE_AVG_button = New System.Windows.Forms.Button
		Me.TEST_button = New System.Windows.Forms.Button
		Me.REGLAGE_button = New System.Windows.Forms.Button
		Me.GOMME_button = New System.Windows.Forms.Button
		Me.OUBLIE_button = New System.Windows.Forms.Button
		Me.SUPPRIME_button = New System.Windows.Forms.Button
		Me.FIN_button = New System.Windows.Forms.Button
		Me.TOUT_button = New System.Windows.Forms.Button
		Me.DES_QUE_button = New System.Windows.Forms.Button
		Me.ARRET_button = New System.Windows.Forms.Button
		Me.EXECUTE_M_button = New System.Windows.Forms.Button
		Me.EXECUTE_P_button = New System.Windows.Forms.Button
		Me.EXECUTE_button = New System.Windows.Forms.Button
		Me.C_EST_button = New System.Windows.Forms.Button
		Me.APPRENDS_button = New System.Windows.Forms.Button
		Me.Image_Treatment = New System.Windows.Forms.GroupBox
		Me.Calibrate_T3 = New System.Windows.Forms.Button
		Me.UseCorrections = New System.Windows.Forms.CheckBox
		Me.selectImage_Button = New System.Windows.Forms.Button
		Me.Generate_Command_List = New System.Windows.Forms.Button
		Me.Send_Image_To_T3 = New System.Windows.Forms.Button
		Me.imagePath = New System.Windows.Forms.TextBox
		Me.imageEditorPath = New System.Windows.Forms.TextBox
		Me.SelectImageEditorButton = New System.Windows.Forms.Button
		Me.EditImage = New System.Windows.Forms.Button
		Me.TextCommandList = New System.Windows.Forms.TextBox
		Me.Size_Renamed = New System.Windows.Forms.TextBox
		Me.MSComm1 = New MSComm
		Me.LabelImage = New System.Windows.Forms.Label
		Me.LabelEditor = New System.Windows.Forms.Label
		Me.LabelCommandList = New System.Windows.Forms.Label
		Me.LabelScale = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Frame9.SuspendLayout()
		Me.Frame5.SuspendLayout()
		Me.Frame8.SuspendLayout()
		Me.Frame6.SuspendLayout()
		Me.Cards_Treatment.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.Frame4.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.Image_Treatment.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "T3 Manager V3.6"
		Me.ClientSize = New System.Drawing.Size(942, 719)
		Me.Location = New System.Drawing.Point(3, 29)
		Me.Icon = CType(resources.GetObject("T3_Manager.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "T3_Manager"
		Me.Frame9.Text = "Extra"
		Me.Frame9.Size = New System.Drawing.Size(217, 65)
		Me.Frame9.Location = New System.Drawing.Point(720, 584)
		Me.Frame9.TabIndex = 153
		Me.Frame9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame9.BackColor = System.Drawing.SystemColors.Control
		Me.Frame9.Enabled = True
		Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame9.Visible = True
		Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame9.Name = "Frame9"
		Me.Show_Manual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Show_Manual.Text = "Ouvrir manuel T3"
		Me.Show_Manual.Size = New System.Drawing.Size(201, 17)
		Me.Show_Manual.Location = New System.Drawing.Point(8, 40)
		Me.Show_Manual.TabIndex = 158
		Me.ToolTip1.SetToolTip(Me.Show_Manual, "Open the T3 manual")
		Me.Show_Manual.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Show_Manual.BackColor = System.Drawing.SystemColors.Control
		Me.Show_Manual.CausesValidation = True
		Me.Show_Manual.Enabled = True
		Me.Show_Manual.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Show_Manual.Cursor = System.Windows.Forms.Cursors.Default
		Me.Show_Manual.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Show_Manual.TabStop = True
		Me.Show_Manual.Name = "Show_Manual"
		Me.Scrolling_Mod_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Scrolling_Mod_Button.Text = "Mode défilement"
		Me.Scrolling_Mod_Button.Size = New System.Drawing.Size(201, 17)
		Me.Scrolling_Mod_Button.Location = New System.Drawing.Point(8, 16)
		Me.Scrolling_Mod_Button.TabIndex = 154
		Me.ToolTip1.SetToolTip(Me.Scrolling_Mod_Button, "Select a SVG image")
		Me.Scrolling_Mod_Button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Scrolling_Mod_Button.BackColor = System.Drawing.SystemColors.Control
		Me.Scrolling_Mod_Button.CausesValidation = True
		Me.Scrolling_Mod_Button.Enabled = True
		Me.Scrolling_Mod_Button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Scrolling_Mod_Button.Cursor = System.Windows.Forms.Cursors.Default
		Me.Scrolling_Mod_Button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Scrolling_Mod_Button.TabStop = True
		Me.Scrolling_Mod_Button.Name = "Scrolling_Mod_Button"
		Me.Frame5.Text = "Programmes"
		Me.Frame5.Size = New System.Drawing.Size(217, 577)
		Me.Frame5.Location = New System.Drawing.Point(720, 0)
		Me.Frame5.TabIndex = 117
		Me.Frame5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame5.BackColor = System.Drawing.SystemColors.Control
		Me.Frame5.Enabled = True
		Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame5.Visible = True
		Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame5.Name = "Frame5"
		Me.programming.Text = "Programmer"
		Me.programming.Size = New System.Drawing.Size(81, 17)
		Me.programming.Location = New System.Drawing.Point(8, 16)
		Me.programming.TabIndex = 155
		Me.programming.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.programming.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.programming.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.programming.BackColor = System.Drawing.SystemColors.Control
		Me.programming.CausesValidation = True
		Me.programming.Enabled = True
		Me.programming.ForeColor = System.Drawing.SystemColors.ControlText
		Me.programming.Cursor = System.Windows.Forms.Cursors.Default
		Me.programming.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.programming.Appearance = System.Windows.Forms.Appearance.Normal
		Me.programming.TabStop = True
		Me.programming.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.programming.Visible = True
		Me.programming.Name = "programming"
		Me.Frame8.Size = New System.Drawing.Size(81, 113)
		Me.Frame8.Location = New System.Drawing.Point(128, 344)
		Me.Frame8.TabIndex = 147
		Me.Frame8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame8.BackColor = System.Drawing.SystemColors.Control
		Me.Frame8.Enabled = True
		Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame8.Visible = True
		Me.Frame8.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame8.Name = "Frame8"
		Me.Picture11.BackColor = System.Drawing.SystemColors.Window
		Me.Picture11.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Picture11.Size = New System.Drawing.Size(50, 50)
		Me.Picture11.Location = New System.Drawing.Point(16, 16)
		Me.Picture11.Image = CType(resources.GetObject("Picture11.Image"), System.Drawing.Image)
		Me.Picture11.TabIndex = 148
		Me.Picture11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture11.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture11.CausesValidation = True
		Me.Picture11.Enabled = True
		Me.Picture11.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture11.TabStop = True
		Me.Picture11.Visible = True
		Me.Picture11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.Picture11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Picture11.Name = "Picture11"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label8.Text = "2009"
		Me.Label8.Size = New System.Drawing.Size(49, 17)
		Me.Label8.Location = New System.Drawing.Point(16, 88)
		Me.Label8.TabIndex = 150
		Me.Label8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label7.Text = "P. LE BIHAN"
		Me.Label7.Size = New System.Drawing.Size(65, 17)
		Me.Label7.Location = New System.Drawing.Point(8, 72)
		Me.Label7.TabIndex = 149
		Me.Label7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Insert.Text = "Insèrer"
		Me.Insert.Size = New System.Drawing.Size(57, 17)
		Me.Insert.Location = New System.Drawing.Point(128, 288)
		Me.Insert.TabIndex = 146
		Me.ToolTip1.SetToolTip(Me.Insert, "Insert command before the selected command")
		Me.Insert.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Insert.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.Insert.BackColor = System.Drawing.SystemColors.Control
		Me.Insert.CausesValidation = True
		Me.Insert.Enabled = True
		Me.Insert.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Insert.Cursor = System.Windows.Forms.Cursors.Default
		Me.Insert.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Insert.Appearance = System.Windows.Forms.Appearance.Normal
		Me.Insert.TabStop = True
		Me.Insert.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.Insert.Visible = True
		Me.Insert.Name = "Insert"
		Me.Send_Program_Step_Backward_To_T3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Send_Program_Step_Backward_To_T3.Text = "Envoyer pas  -"
		Me.Send_Program_Step_Backward_To_T3.Size = New System.Drawing.Size(81, 17)
		Me.Send_Program_Step_Backward_To_T3.Location = New System.Drawing.Point(128, 528)
		Me.Send_Program_Step_Backward_To_T3.TabIndex = 145
		Me.ToolTip1.SetToolTip(Me.Send_Program_Step_Backward_To_T3, "Send the opposite of the selected command to the T3 and goes to the previous one")
		Me.Send_Program_Step_Backward_To_T3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Send_Program_Step_Backward_To_T3.BackColor = System.Drawing.SystemColors.Control
		Me.Send_Program_Step_Backward_To_T3.CausesValidation = True
		Me.Send_Program_Step_Backward_To_T3.Enabled = True
		Me.Send_Program_Step_Backward_To_T3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Send_Program_Step_Backward_To_T3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Send_Program_Step_Backward_To_T3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Send_Program_Step_Backward_To_T3.TabStop = True
		Me.Send_Program_Step_Backward_To_T3.Name = "Send_Program_Step_Backward_To_T3"
		Me.Send_Program_Step_Forward_To_T3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Send_Program_Step_Forward_To_T3.Text = "Envoyer pas  +"
		Me.Send_Program_Step_Forward_To_T3.Size = New System.Drawing.Size(81, 17)
		Me.Send_Program_Step_Forward_To_T3.Location = New System.Drawing.Point(128, 504)
		Me.Send_Program_Step_Forward_To_T3.TabIndex = 144
		Me.ToolTip1.SetToolTip(Me.Send_Program_Step_Forward_To_T3, "Send the selected command to the T3 and goes to the next command")
		Me.Send_Program_Step_Forward_To_T3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Send_Program_Step_Forward_To_T3.BackColor = System.Drawing.SystemColors.Control
		Me.Send_Program_Step_Forward_To_T3.CausesValidation = True
		Me.Send_Program_Step_Forward_To_T3.Enabled = True
		Me.Send_Program_Step_Forward_To_T3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Send_Program_Step_Forward_To_T3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Send_Program_Step_Forward_To_T3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Send_Program_Step_Forward_To_T3.TabStop = True
		Me.Send_Program_Step_Forward_To_T3.Name = "Send_Program_Step_Forward_To_T3"
		Me.ProgramCommandList.Size = New System.Drawing.Size(113, 436)
		Me.ProgramCommandList.Location = New System.Drawing.Point(8, 136)
		Me.ProgramCommandList.TabIndex = 137
		Me.ProgramCommandList.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ProgramCommandList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.ProgramCommandList.BackColor = System.Drawing.SystemColors.Window
		Me.ProgramCommandList.CausesValidation = True
		Me.ProgramCommandList.Enabled = True
		Me.ProgramCommandList.ForeColor = System.Drawing.SystemColors.WindowText
		Me.ProgramCommandList.IntegralHeight = True
		Me.ProgramCommandList.Cursor = System.Windows.Forms.Cursors.Default
		Me.ProgramCommandList.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.ProgramCommandList.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ProgramCommandList.Sorted = False
		Me.ProgramCommandList.TabStop = True
		Me.ProgramCommandList.Visible = True
		Me.ProgramCommandList.MultiColumn = False
		Me.ProgramCommandList.Name = "ProgramCommandList"
		Me.MoveCommandDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.MoveCommandDown.Text = "Glisser bas"
		Me.MoveCommandDown.Size = New System.Drawing.Size(81, 17)
		Me.MoveCommandDown.Location = New System.Drawing.Point(128, 264)
		Me.MoveCommandDown.TabIndex = 132
		Me.ToolTip1.SetToolTip(Me.MoveCommandDown, "Move a command down in the Program Command List")
		Me.MoveCommandDown.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MoveCommandDown.BackColor = System.Drawing.SystemColors.Control
		Me.MoveCommandDown.CausesValidation = True
		Me.MoveCommandDown.Enabled = True
		Me.MoveCommandDown.ForeColor = System.Drawing.SystemColors.ControlText
		Me.MoveCommandDown.Cursor = System.Windows.Forms.Cursors.Default
		Me.MoveCommandDown.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.MoveCommandDown.TabStop = True
		Me.MoveCommandDown.Name = "MoveCommandDown"
		Me.MoveCommandUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.MoveCommandUp.Text = "Glisser haut"
		Me.MoveCommandUp.Size = New System.Drawing.Size(81, 17)
		Me.MoveCommandUp.Location = New System.Drawing.Point(128, 240)
		Me.MoveCommandUp.TabIndex = 131
		Me.ToolTip1.SetToolTip(Me.MoveCommandUp, "Move a command up in the Program Command List")
		Me.MoveCommandUp.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MoveCommandUp.BackColor = System.Drawing.SystemColors.Control
		Me.MoveCommandUp.CausesValidation = True
		Me.MoveCommandUp.Enabled = True
		Me.MoveCommandUp.ForeColor = System.Drawing.SystemColors.ControlText
		Me.MoveCommandUp.Cursor = System.Windows.Forms.Cursors.Default
		Me.MoveCommandUp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.MoveCommandUp.TabStop = True
		Me.MoveCommandUp.Name = "MoveCommandUp"
		Me.RemoveCommand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.RemoveCommand.Text = "Effacer"
		Me.RemoveCommand.Size = New System.Drawing.Size(81, 17)
		Me.RemoveCommand.Location = New System.Drawing.Point(128, 216)
		Me.RemoveCommand.TabIndex = 130
		Me.ToolTip1.SetToolTip(Me.RemoveCommand, "remove a command from the Program Command List")
		Me.RemoveCommand.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RemoveCommand.BackColor = System.Drawing.SystemColors.Control
		Me.RemoveCommand.CausesValidation = True
		Me.RemoveCommand.Enabled = True
		Me.RemoveCommand.ForeColor = System.Drawing.SystemColors.ControlText
		Me.RemoveCommand.Cursor = System.Windows.Forms.Cursors.Default
		Me.RemoveCommand.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.RemoveCommand.TabStop = True
		Me.RemoveCommand.Name = "RemoveCommand"
		Me.ClearProgramCommandList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ClearProgramCommandList.Text = "Effacer tout"
		Me.ClearProgramCommandList.Size = New System.Drawing.Size(81, 17)
		Me.ClearProgramCommandList.Location = New System.Drawing.Point(128, 192)
		Me.ClearProgramCommandList.TabIndex = 129
		Me.ToolTip1.SetToolTip(Me.ClearProgramCommandList, "Clear the Program Command List")
		Me.ClearProgramCommandList.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ClearProgramCommandList.BackColor = System.Drawing.SystemColors.Control
		Me.ClearProgramCommandList.CausesValidation = True
		Me.ClearProgramCommandList.Enabled = True
		Me.ClearProgramCommandList.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ClearProgramCommandList.Cursor = System.Windows.Forms.Cursors.Default
		Me.ClearProgramCommandList.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ClearProgramCommandList.TabStop = True
		Me.ClearProgramCommandList.Name = "ClearProgramCommandList"
		Me.SaveProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.SaveProgram.Text = "Sauv. Program "
		Me.SaveProgram.Size = New System.Drawing.Size(81, 17)
		Me.SaveProgram.Location = New System.Drawing.Point(128, 168)
		Me.SaveProgram.TabIndex = 128
		Me.ToolTip1.SetToolTip(Me.SaveProgram, "Save the T3P program")
		Me.SaveProgram.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SaveProgram.BackColor = System.Drawing.SystemColors.Control
		Me.SaveProgram.CausesValidation = True
		Me.SaveProgram.Enabled = True
		Me.SaveProgram.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SaveProgram.Cursor = System.Windows.Forms.Cursors.Default
		Me.SaveProgram.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.SaveProgram.TabStop = True
		Me.SaveProgram.Name = "SaveProgram"
		Me.LoadProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.LoadProgram.Text = "Charg. Program"
		Me.LoadProgram.Size = New System.Drawing.Size(81, 17)
		Me.LoadProgram.Location = New System.Drawing.Point(128, 144)
		Me.LoadProgram.TabIndex = 127
		Me.ToolTip1.SetToolTip(Me.LoadProgram, "Load the T3P program")
		Me.LoadProgram.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LoadProgram.BackColor = System.Drawing.SystemColors.Control
		Me.LoadProgram.CausesValidation = True
		Me.LoadProgram.Enabled = True
		Me.LoadProgram.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LoadProgram.Cursor = System.Windows.Forms.Cursors.Default
		Me.LoadProgram.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.LoadProgram.TabStop = True
		Me.LoadProgram.Name = "LoadProgram"
		Me.programEditorPath.AutoSize = False
		Me.programEditorPath.Size = New System.Drawing.Size(113, 21)
		Me.programEditorPath.Location = New System.Drawing.Point(8, 56)
		Me.programEditorPath.TabIndex = 126
		Me.programEditorPath.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.programEditorPath.AcceptsReturn = True
		Me.programEditorPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.programEditorPath.BackColor = System.Drawing.SystemColors.Window
		Me.programEditorPath.CausesValidation = True
		Me.programEditorPath.Enabled = True
		Me.programEditorPath.ForeColor = System.Drawing.SystemColors.WindowText
		Me.programEditorPath.HideSelection = True
		Me.programEditorPath.ReadOnly = False
		Me.programEditorPath.Maxlength = 0
		Me.programEditorPath.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.programEditorPath.MultiLine = False
		Me.programEditorPath.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.programEditorPath.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.programEditorPath.TabStop = True
		Me.programEditorPath.Visible = True
		Me.programEditorPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.programEditorPath.Name = "programEditorPath"
		Me.programPath.AutoSize = False
		Me.programPath.Size = New System.Drawing.Size(113, 19)
		Me.programPath.Location = New System.Drawing.Point(8, 96)
		Me.programPath.TabIndex = 125
		Me.programPath.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.programPath.AcceptsReturn = True
		Me.programPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.programPath.BackColor = System.Drawing.SystemColors.Window
		Me.programPath.CausesValidation = True
		Me.programPath.Enabled = True
		Me.programPath.ForeColor = System.Drawing.SystemColors.WindowText
		Me.programPath.HideSelection = True
		Me.programPath.ReadOnly = False
		Me.programPath.Maxlength = 0
		Me.programPath.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.programPath.MultiLine = False
		Me.programPath.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.programPath.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.programPath.TabStop = True
		Me.programPath.Visible = True
		Me.programPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.programPath.Name = "programPath"
		Me.EditProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.EditProgram.Text = "Edit. Program."
		Me.EditProgram.Size = New System.Drawing.Size(81, 17)
		Me.EditProgram.Location = New System.Drawing.Point(128, 120)
		Me.EditProgram.TabIndex = 121
		Me.ToolTip1.SetToolTip(Me.EditProgram, "Edit T3P program in the external editor")
		Me.EditProgram.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.EditProgram.BackColor = System.Drawing.SystemColors.Control
		Me.EditProgram.CausesValidation = True
		Me.EditProgram.Enabled = True
		Me.EditProgram.ForeColor = System.Drawing.SystemColors.ControlText
		Me.EditProgram.Cursor = System.Windows.Forms.Cursors.Default
		Me.EditProgram.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.EditProgram.TabStop = True
		Me.EditProgram.Name = "EditProgram"
		Me.SelectProgramEditorButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.SelectProgramEditorButton.Text = "Select. Editeur"
		Me.SelectProgramEditorButton.Size = New System.Drawing.Size(81, 17)
		Me.SelectProgramEditorButton.Location = New System.Drawing.Point(128, 56)
		Me.SelectProgramEditorButton.TabIndex = 120
		Me.ToolTip1.SetToolTip(Me.SelectProgramEditorButton, "Select an external text file editor")
		Me.SelectProgramEditorButton.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SelectProgramEditorButton.BackColor = System.Drawing.SystemColors.Control
		Me.SelectProgramEditorButton.CausesValidation = True
		Me.SelectProgramEditorButton.Enabled = True
		Me.SelectProgramEditorButton.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SelectProgramEditorButton.Cursor = System.Windows.Forms.Cursors.Default
		Me.SelectProgramEditorButton.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.SelectProgramEditorButton.TabStop = True
		Me.SelectProgramEditorButton.Name = "SelectProgramEditorButton"
		Me.Send_Program_To_T3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Send_Program_To_T3.Text = "Envoy. vers T3"
		Me.Send_Program_To_T3.Size = New System.Drawing.Size(81, 17)
		Me.Send_Program_To_T3.Location = New System.Drawing.Point(128, 552)
		Me.Send_Program_To_T3.TabIndex = 119
		Me.ToolTip1.SetToolTip(Me.Send_Program_To_T3, "Send the Program Command List to the T3")
		Me.Send_Program_To_T3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Send_Program_To_T3.BackColor = System.Drawing.SystemColors.Control
		Me.Send_Program_To_T3.CausesValidation = True
		Me.Send_Program_To_T3.Enabled = True
		Me.Send_Program_To_T3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Send_Program_To_T3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Send_Program_To_T3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Send_Program_To_T3.TabStop = True
		Me.Send_Program_To_T3.Name = "Send_Program_To_T3"
		Me.selectProgram_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.selectProgram_Button.Text = "Select Program"
		Me.selectProgram_Button.Size = New System.Drawing.Size(81, 17)
		Me.selectProgram_Button.Location = New System.Drawing.Point(128, 96)
		Me.selectProgram_Button.TabIndex = 118
		Me.ToolTip1.SetToolTip(Me.selectProgram_Button, "Select a T3P program")
		Me.selectProgram_Button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.selectProgram_Button.BackColor = System.Drawing.SystemColors.Control
		Me.selectProgram_Button.CausesValidation = True
		Me.selectProgram_Button.Enabled = True
		Me.selectProgram_Button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.selectProgram_Button.Cursor = System.Windows.Forms.Cursors.Default
		Me.selectProgram_Button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.selectProgram_Button.TabStop = True
		Me.selectProgram_Button.Name = "selectProgram_Button"
		Me.Label6.Text = "Liste de commandes :"
		Me.Label6.Size = New System.Drawing.Size(113, 17)
		Me.Label6.Location = New System.Drawing.Point(8, 120)
		Me.Label6.TabIndex = 124
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label5.Text = "Chemin éditeur de texte :"
		Me.Label5.Size = New System.Drawing.Size(161, 17)
		Me.Label5.Location = New System.Drawing.Point(8, 40)
		Me.Label5.TabIndex = 123
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label4.Text = "Chemin du programme :"
		Me.Label4.Size = New System.Drawing.Size(161, 17)
		Me.Label4.Location = New System.Drawing.Point(8, 80)
		Me.Label4.TabIndex = 122
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Frame6.Text = "Communication port série"
		Me.Frame6.Size = New System.Drawing.Size(721, 57)
		Me.Frame6.Location = New System.Drawing.Point(216, 656)
		Me.Frame6.TabIndex = 36
		Me.Frame6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame6.BackColor = System.Drawing.SystemColors.Control
		Me.Frame6.Enabled = True
		Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame6.Visible = True
		Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame6.Name = "Frame6"
		Me.Com_Number.AutoSize = False
		Me.Com_Number.Size = New System.Drawing.Size(17, 19)
		Me.Com_Number.Location = New System.Drawing.Point(40, 24)
		Me.Com_Number.TabIndex = 152
		Me.ToolTip1.SetToolTip(Me.Com_Number, "Size of the image reproduction")
		Me.Com_Number.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Com_Number.AcceptsReturn = True
		Me.Com_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Com_Number.BackColor = System.Drawing.SystemColors.Window
		Me.Com_Number.CausesValidation = True
		Me.Com_Number.Enabled = True
		Me.Com_Number.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Com_Number.HideSelection = True
		Me.Com_Number.ReadOnly = False
		Me.Com_Number.Maxlength = 0
		Me.Com_Number.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Com_Number.MultiLine = False
		Me.Com_Number.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Com_Number.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Com_Number.TabStop = True
		Me.Com_Number.Visible = True
		Me.Com_Number.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Com_Number.Name = "Com_Number"
		Me.Combo_Com_Setting.Size = New System.Drawing.Size(81, 21)
		Me.Combo_Com_Setting.Location = New System.Drawing.Point(120, 24)
		Me.Combo_Com_Setting.Items.AddRange(New Object(){"1200,E,7,2", "1200,O,7,2", "1200,E,7,1", "1200,O,7,1", "1200,N,8,2", "1200,N,8,1", "1200,E,8,1", "1200,O,8,1"})
		Me.Combo_Com_Setting.TabIndex = 39
		Me.Combo_Com_Setting.Text = "1200,N,8,2"
		Me.ToolTip1.SetToolTip(Me.Combo_Com_Setting, "Serial Communication settings")
		Me.Combo_Com_Setting.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Combo_Com_Setting.BackColor = System.Drawing.SystemColors.Window
		Me.Combo_Com_Setting.CausesValidation = True
		Me.Combo_Com_Setting.Enabled = True
		Me.Combo_Com_Setting.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Combo_Com_Setting.IntegralHeight = True
		Me.Combo_Com_Setting.Cursor = System.Windows.Forms.Cursors.Default
		Me.Combo_Com_Setting.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Combo_Com_Setting.Sorted = False
		Me.Combo_Com_Setting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.Combo_Com_Setting.TabStop = True
		Me.Combo_Com_Setting.Visible = True
		Me.Combo_Com_Setting.Name = "Combo_Com_Setting"
		Me.ProgressBarSend.Size = New System.Drawing.Size(505, 25)
		Me.ProgressBarSend.Location = New System.Drawing.Point(208, 24)
		Me.ProgressBarSend.TabIndex = 37
		Me.ProgressBarSend.Visible = False
		Me.ProgressBarSend.Name = "ProgressBarSend"
		Me.Label9.Text = "Com:"
		Me.Label9.Size = New System.Drawing.Size(33, 17)
		Me.Label9.Location = New System.Drawing.Point(8, 24)
		Me.Label9.TabIndex = 151
		Me.Label9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label9.BackColor = System.Drawing.SystemColors.Control
		Me.Label9.Enabled = True
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.Label3.Text = "Réglages :"
		Me.Label3.Size = New System.Drawing.Size(57, 17)
		Me.Label3.Location = New System.Drawing.Point(64, 24)
		Me.Label3.TabIndex = 40
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.LabelProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.LabelProgress.Size = New System.Drawing.Size(505, 17)
		Me.LabelProgress.Location = New System.Drawing.Point(208, 8)
		Me.LabelProgress.TabIndex = 38
		Me.LabelProgress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelProgress.BackColor = System.Drawing.SystemColors.Control
		Me.LabelProgress.Enabled = True
		Me.LabelProgress.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LabelProgress.Cursor = System.Windows.Forms.Cursors.Default
		Me.LabelProgress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.LabelProgress.UseMnemonic = True
		Me.LabelProgress.Visible = True
		Me.LabelProgress.AutoSize = False
		Me.LabelProgress.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.LabelProgress.Name = "LabelProgress"
		Me.Cards_Treatment.Text = "Cartes"
		Me.Cards_Treatment.Size = New System.Drawing.Size(497, 649)
		Me.Cards_Treatment.Location = New System.Drawing.Point(216, 0)
		Me.Cards_Treatment.TabIndex = 16
		Me.Cards_Treatment.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Cards_Treatment.BackColor = System.Drawing.SystemColors.Control
		Me.Cards_Treatment.Enabled = True
		Me.Cards_Treatment.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Cards_Treatment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Cards_Treatment.Visible = True
		Me.Cards_Treatment.Padding = New System.Windows.Forms.Padding(0)
		Me.Cards_Treatment.Name = "Cards_Treatment"
		Me.Frame2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Frame2.Size = New System.Drawing.Size(129, 449)
		Me.Frame2.Location = New System.Drawing.Point(8, 16)
		Me.Frame2.TabIndex = 96
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.Picture2.BackColor = System.Drawing.SystemColors.Window
		Me.Picture2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Picture2.Size = New System.Drawing.Size(36, 36)
		Me.Picture2.Location = New System.Drawing.Point(48, 328)
		Me.Picture2.Image = CType(resources.GetObject("Picture2.Image"), System.Drawing.Image)
		Me.Picture2.TabIndex = 136
		Me.Picture2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture2.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture2.CausesValidation = True
		Me.Picture2.Enabled = True
		Me.Picture2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture2.TabStop = True
		Me.Picture2.Visible = True
		Me.Picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Picture2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Picture2.Name = "Picture2"
		Me.Picture6.BackColor = System.Drawing.SystemColors.Window
		Me.Picture6.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Picture6.Size = New System.Drawing.Size(36, 36)
		Me.Picture6.Location = New System.Drawing.Point(8, 120)
		Me.Picture6.Image = CType(resources.GetObject("Picture6.Image"), System.Drawing.Image)
		Me.Picture6.TabIndex = 135
		Me.Picture6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture6.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture6.CausesValidation = True
		Me.Picture6.Enabled = True
		Me.Picture6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture6.TabStop = True
		Me.Picture6.Visible = True
		Me.Picture6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Picture6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Picture6.Name = "Picture6"
		Me.Picture4.BackColor = System.Drawing.SystemColors.Window
		Me.Picture4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Picture4.Size = New System.Drawing.Size(36, 36)
		Me.Picture4.Location = New System.Drawing.Point(88, 120)
		Me.Picture4.Image = CType(resources.GetObject("Picture4.Image"), System.Drawing.Image)
		Me.Picture4.TabIndex = 134
		Me.Picture4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture4.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture4.CausesValidation = True
		Me.Picture4.Enabled = True
		Me.Picture4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture4.TabStop = True
		Me.Picture4.Visible = True
		Me.Picture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Picture4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Picture4.Name = "Picture4"
		Me.Picture1.BackColor = System.Drawing.SystemColors.Window
		Me.Picture1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Picture1.Size = New System.Drawing.Size(36, 36)
		Me.Picture1.Location = New System.Drawing.Point(48, 8)
		Me.Picture1.Image = CType(resources.GetObject("Picture1.Image"), System.Drawing.Image)
		Me.Picture1.TabIndex = 133
		Me.Picture1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture1.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture1.CausesValidation = True
		Me.Picture1.Enabled = True
		Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture1.TabStop = True
		Me.Picture1.Visible = True
		Me.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Picture1.Name = "Picture1"
		Me.TD_120_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TD_120_button.Text = "TD 120"
		Me.TD_120_button.Size = New System.Drawing.Size(49, 17)
		Me.TD_120_button.Location = New System.Drawing.Point(72, 304)
		Me.TD_120_button.TabIndex = 116
		Me.TD_120_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TD_120_button.BackColor = System.Drawing.SystemColors.Control
		Me.TD_120_button.CausesValidation = True
		Me.TD_120_button.Enabled = True
		Me.TD_120_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TD_120_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TD_120_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TD_120_button.TabStop = True
		Me.TD_120_button.Name = "TD_120_button"
		Me.TD_90_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TD_90_button.Text = "TD 90"
		Me.TD_90_button.Size = New System.Drawing.Size(49, 17)
		Me.TD_90_button.Location = New System.Drawing.Point(72, 280)
		Me.TD_90_button.TabIndex = 115
		Me.TD_90_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TD_90_button.BackColor = System.Drawing.SystemColors.Control
		Me.TD_90_button.CausesValidation = True
		Me.TD_90_button.Enabled = True
		Me.TD_90_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TD_90_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TD_90_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TD_90_button.TabStop = True
		Me.TD_90_button.Name = "TD_90_button"
		Me.TD_60_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TD_60_button.Text = "TD 60"
		Me.TD_60_button.Size = New System.Drawing.Size(49, 17)
		Me.TD_60_button.Location = New System.Drawing.Point(72, 256)
		Me.TD_60_button.TabIndex = 114
		Me.TD_60_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TD_60_button.BackColor = System.Drawing.SystemColors.Control
		Me.TD_60_button.CausesValidation = True
		Me.TD_60_button.Enabled = True
		Me.TD_60_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TD_60_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TD_60_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TD_60_button.TabStop = True
		Me.TD_60_button.Name = "TD_60_button"
		Me.TD_45_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TD_45_button.Text = "TD 45"
		Me.TD_45_button.Size = New System.Drawing.Size(49, 17)
		Me.TD_45_button.Location = New System.Drawing.Point(72, 232)
		Me.TD_45_button.TabIndex = 113
		Me.TD_45_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TD_45_button.BackColor = System.Drawing.SystemColors.Control
		Me.TD_45_button.CausesValidation = True
		Me.TD_45_button.Enabled = True
		Me.TD_45_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TD_45_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TD_45_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TD_45_button.TabStop = True
		Me.TD_45_button.Name = "TD_45_button"
		Me.TD_30_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TD_30_button.Text = "TD 30"
		Me.TD_30_button.Size = New System.Drawing.Size(49, 17)
		Me.TD_30_button.Location = New System.Drawing.Point(72, 208)
		Me.TD_30_button.TabIndex = 112
		Me.TD_30_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TD_30_button.BackColor = System.Drawing.SystemColors.Control
		Me.TD_30_button.CausesValidation = True
		Me.TD_30_button.Enabled = True
		Me.TD_30_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TD_30_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TD_30_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TD_30_button.TabStop = True
		Me.TD_30_button.Name = "TD_30_button"
		Me.TD_15_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TD_15_button.Text = "TD 15"
		Me.TD_15_button.Size = New System.Drawing.Size(49, 17)
		Me.TD_15_button.Location = New System.Drawing.Point(72, 184)
		Me.TD_15_button.TabIndex = 111
		Me.TD_15_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TD_15_button.BackColor = System.Drawing.SystemColors.Control
		Me.TD_15_button.CausesValidation = True
		Me.TD_15_button.Enabled = True
		Me.TD_15_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TD_15_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TD_15_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TD_15_button.TabStop = True
		Me.TD_15_button.Name = "TD_15_button"
		Me.TD_1_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TD_1_button.Text = "TD 1"
		Me.TD_1_button.Size = New System.Drawing.Size(49, 17)
		Me.TD_1_button.Location = New System.Drawing.Point(72, 160)
		Me.TD_1_button.TabIndex = 110
		Me.TD_1_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TD_1_button.BackColor = System.Drawing.SystemColors.Control
		Me.TD_1_button.CausesValidation = True
		Me.TD_1_button.Enabled = True
		Me.TD_1_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TD_1_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TD_1_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TD_1_button.TabStop = True
		Me.TD_1_button.Name = "TD_1_button"
		Me.TG_120_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TG_120_button.Text = "TG_ 120"
		Me.TG_120_button.Size = New System.Drawing.Size(57, 17)
		Me.TG_120_button.Location = New System.Drawing.Point(8, 304)
		Me.TG_120_button.TabIndex = 109
		Me.TG_120_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TG_120_button.BackColor = System.Drawing.SystemColors.Control
		Me.TG_120_button.CausesValidation = True
		Me.TG_120_button.Enabled = True
		Me.TG_120_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TG_120_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TG_120_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TG_120_button.TabStop = True
		Me.TG_120_button.Name = "TG_120_button"
		Me.TG_90_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TG_90_button.Text = "TG 90"
		Me.TG_90_button.Size = New System.Drawing.Size(57, 17)
		Me.TG_90_button.Location = New System.Drawing.Point(8, 280)
		Me.TG_90_button.TabIndex = 108
		Me.TG_90_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TG_90_button.BackColor = System.Drawing.SystemColors.Control
		Me.TG_90_button.CausesValidation = True
		Me.TG_90_button.Enabled = True
		Me.TG_90_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TG_90_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TG_90_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TG_90_button.TabStop = True
		Me.TG_90_button.Name = "TG_90_button"
		Me.TG_60_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TG_60_button.Text = "TG 60"
		Me.TG_60_button.Size = New System.Drawing.Size(57, 17)
		Me.TG_60_button.Location = New System.Drawing.Point(8, 256)
		Me.TG_60_button.TabIndex = 107
		Me.TG_60_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TG_60_button.BackColor = System.Drawing.SystemColors.Control
		Me.TG_60_button.CausesValidation = True
		Me.TG_60_button.Enabled = True
		Me.TG_60_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TG_60_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TG_60_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TG_60_button.TabStop = True
		Me.TG_60_button.Name = "TG_60_button"
		Me.TG_45_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TG_45_button.Text = "TG 45"
		Me.TG_45_button.Size = New System.Drawing.Size(57, 17)
		Me.TG_45_button.Location = New System.Drawing.Point(8, 232)
		Me.TG_45_button.TabIndex = 106
		Me.TG_45_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TG_45_button.BackColor = System.Drawing.SystemColors.Control
		Me.TG_45_button.CausesValidation = True
		Me.TG_45_button.Enabled = True
		Me.TG_45_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TG_45_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TG_45_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TG_45_button.TabStop = True
		Me.TG_45_button.Name = "TG_45_button"
		Me.TG_30_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TG_30_button.Text = "TG 30"
		Me.TG_30_button.Size = New System.Drawing.Size(57, 17)
		Me.TG_30_button.Location = New System.Drawing.Point(8, 208)
		Me.TG_30_button.TabIndex = 105
		Me.TG_30_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TG_30_button.BackColor = System.Drawing.SystemColors.Control
		Me.TG_30_button.CausesValidation = True
		Me.TG_30_button.Enabled = True
		Me.TG_30_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TG_30_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TG_30_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TG_30_button.TabStop = True
		Me.TG_30_button.Name = "TG_30_button"
		Me.TG_15_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TG_15_button.Text = "TG 15"
		Me.TG_15_button.Size = New System.Drawing.Size(57, 17)
		Me.TG_15_button.Location = New System.Drawing.Point(8, 184)
		Me.TG_15_button.TabIndex = 104
		Me.TG_15_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TG_15_button.BackColor = System.Drawing.SystemColors.Control
		Me.TG_15_button.CausesValidation = True
		Me.TG_15_button.Enabled = True
		Me.TG_15_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TG_15_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TG_15_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TG_15_button.TabStop = True
		Me.TG_15_button.Name = "TG_15_button"
		Me.TG_1_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TG_1_button.Text = "TG 1"
		Me.TG_1_button.Size = New System.Drawing.Size(57, 17)
		Me.TG_1_button.Location = New System.Drawing.Point(8, 160)
		Me.TG_1_button.TabIndex = 103
		Me.TG_1_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TG_1_button.BackColor = System.Drawing.SystemColors.Control
		Me.TG_1_button.CausesValidation = True
		Me.TG_1_button.Enabled = True
		Me.TG_1_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TG_1_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TG_1_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TG_1_button.TabStop = True
		Me.TG_1_button.Name = "TG_1_button"
		Me.RE_20_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.RE_20_button.Text = "RE 20"
		Me.RE_20_button.Size = New System.Drawing.Size(113, 17)
		Me.RE_20_button.Location = New System.Drawing.Point(8, 416)
		Me.RE_20_button.TabIndex = 102
		Me.RE_20_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RE_20_button.BackColor = System.Drawing.SystemColors.Control
		Me.RE_20_button.CausesValidation = True
		Me.RE_20_button.Enabled = True
		Me.RE_20_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.RE_20_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.RE_20_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.RE_20_button.TabStop = True
		Me.RE_20_button.Name = "RE_20_button"
		Me.RE_10_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.RE_10_button.Text = "RE 10"
		Me.RE_10_button.Size = New System.Drawing.Size(113, 17)
		Me.RE_10_button.Location = New System.Drawing.Point(8, 392)
		Me.RE_10_button.TabIndex = 101
		Me.RE_10_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RE_10_button.BackColor = System.Drawing.SystemColors.Control
		Me.RE_10_button.CausesValidation = True
		Me.RE_10_button.Enabled = True
		Me.RE_10_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.RE_10_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.RE_10_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.RE_10_button.TabStop = True
		Me.RE_10_button.Name = "RE_10_button"
		Me.RE_1_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.RE_1_button.Text = "RE 1"
		Me.RE_1_button.Size = New System.Drawing.Size(113, 17)
		Me.RE_1_button.Location = New System.Drawing.Point(8, 368)
		Me.RE_1_button.TabIndex = 100
		Me.RE_1_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RE_1_button.BackColor = System.Drawing.SystemColors.Control
		Me.RE_1_button.CausesValidation = True
		Me.RE_1_button.Enabled = True
		Me.RE_1_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.RE_1_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.RE_1_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.RE_1_button.TabStop = True
		Me.RE_1_button.Name = "RE_1_button"
		Me.AV_20_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.AV_20_button.Text = "AV 20"
		Me.AV_20_button.Size = New System.Drawing.Size(113, 17)
		Me.AV_20_button.Location = New System.Drawing.Point(8, 96)
		Me.AV_20_button.TabIndex = 99
		Me.AV_20_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AV_20_button.BackColor = System.Drawing.SystemColors.Control
		Me.AV_20_button.CausesValidation = True
		Me.AV_20_button.Enabled = True
		Me.AV_20_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.AV_20_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.AV_20_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.AV_20_button.TabStop = True
		Me.AV_20_button.Name = "AV_20_button"
		Me.AV_10_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.AV_10_button.Text = "AV 10"
		Me.AV_10_button.Size = New System.Drawing.Size(113, 17)
		Me.AV_10_button.Location = New System.Drawing.Point(8, 72)
		Me.AV_10_button.TabIndex = 98
		Me.AV_10_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AV_10_button.BackColor = System.Drawing.SystemColors.Control
		Me.AV_10_button.CausesValidation = True
		Me.AV_10_button.Enabled = True
		Me.AV_10_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.AV_10_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.AV_10_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.AV_10_button.TabStop = True
		Me.AV_10_button.Name = "AV_10_button"
		Me.AV_1_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.AV_1_button.Text = "AV 1"
		Me.AV_1_button.Size = New System.Drawing.Size(113, 17)
		Me.AV_1_button.Location = New System.Drawing.Point(8, 48)
		Me.AV_1_button.TabIndex = 97
		Me.AV_1_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AV_1_button.BackColor = System.Drawing.SystemColors.Control
		Me.AV_1_button.CausesValidation = True
		Me.AV_1_button.Enabled = True
		Me.AV_1_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.AV_1_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.AV_1_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.AV_1_button.TabStop = True
		Me.AV_1_button.Name = "AV_1_button"
		Me.Frame3.BackColor = System.Drawing.Color.Green
		Me.Frame3.Size = New System.Drawing.Size(481, 169)
		Me.Frame3.Location = New System.Drawing.Point(8, 472)
		Me.Frame3.TabIndex = 78
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me.Picture10.BackColor = System.Drawing.SystemColors.Window
		Me.Picture10.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Picture10.Size = New System.Drawing.Size(36, 36)
		Me.Picture10.Location = New System.Drawing.Point(184, 64)
		Me.Picture10.Image = CType(resources.GetObject("Picture10.Image"), System.Drawing.Image)
		Me.Picture10.TabIndex = 143
		Me.Picture10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture10.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture10.CausesValidation = True
		Me.Picture10.Enabled = True
		Me.Picture10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture10.TabStop = True
		Me.Picture10.Visible = True
		Me.Picture10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Picture10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Picture10.Name = "Picture10"
		Me.Picture5.BackColor = System.Drawing.SystemColors.Window
		Me.Picture5.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Picture5.Size = New System.Drawing.Size(36, 36)
		Me.Picture5.Location = New System.Drawing.Point(184, 16)
		Me.Picture5.Image = CType(resources.GetObject("Picture5.Image"), System.Drawing.Image)
		Me.Picture5.TabIndex = 142
		Me.Picture5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture5.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture5.CausesValidation = True
		Me.Picture5.Enabled = True
		Me.Picture5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture5.TabStop = True
		Me.Picture5.Visible = True
		Me.Picture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Picture5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Picture5.Name = "Picture5"
		Me.Picture9.BackColor = System.Drawing.SystemColors.Window
		Me.Picture9.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Picture9.Size = New System.Drawing.Size(36, 36)
		Me.Picture9.Location = New System.Drawing.Point(48, 128)
		Me.Picture9.Image = CType(resources.GetObject("Picture9.Image"), System.Drawing.Image)
		Me.Picture9.TabIndex = 141
		Me.Picture9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture9.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture9.CausesValidation = True
		Me.Picture9.Enabled = True
		Me.Picture9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture9.TabStop = True
		Me.Picture9.Visible = True
		Me.Picture9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Picture9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Picture9.Name = "Picture9"
		Me.Picture8.BackColor = System.Drawing.SystemColors.Window
		Me.Picture8.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Picture8.Size = New System.Drawing.Size(36, 36)
		Me.Picture8.Location = New System.Drawing.Point(48, 88)
		Me.Picture8.Image = CType(resources.GetObject("Picture8.Image"), System.Drawing.Image)
		Me.Picture8.TabIndex = 140
		Me.Picture8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture8.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture8.CausesValidation = True
		Me.Picture8.Enabled = True
		Me.Picture8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture8.TabStop = True
		Me.Picture8.Visible = True
		Me.Picture8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Picture8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Picture8.Name = "Picture8"
		Me.Picture7.BackColor = System.Drawing.SystemColors.Window
		Me.Picture7.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Picture7.Size = New System.Drawing.Size(36, 36)
		Me.Picture7.Location = New System.Drawing.Point(184, 112)
		Me.Picture7.Image = CType(resources.GetObject("Picture7.Image"), System.Drawing.Image)
		Me.Picture7.TabIndex = 139
		Me.Picture7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture7.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture7.CausesValidation = True
		Me.Picture7.Enabled = True
		Me.Picture7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture7.TabStop = True
		Me.Picture7.Visible = True
		Me.Picture7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Picture7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Picture7.Name = "Picture7"
		Me.Picture3.BackColor = System.Drawing.SystemColors.Window
		Me.Picture3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Picture3.Size = New System.Drawing.Size(36, 36)
		Me.Picture3.Location = New System.Drawing.Point(408, 16)
		Me.Picture3.Image = CType(resources.GetObject("Picture3.Image"), System.Drawing.Image)
		Me.Picture3.TabIndex = 138
		Me.Picture3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture3.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture3.CausesValidation = True
		Me.Picture3.Enabled = True
		Me.Picture3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture3.TabStop = True
		Me.Picture3.Visible = True
		Me.Picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Picture3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Picture3.Name = "Picture3"
		Me.B_C_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.B_C_button.Text = "B C"
		Me.B_C_button.Size = New System.Drawing.Size(41, 33)
		Me.B_C_button.Location = New System.Drawing.Point(88, 128)
		Me.B_C_button.TabIndex = 95
		Me.B_C_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.B_C_button.BackColor = System.Drawing.SystemColors.Control
		Me.B_C_button.CausesValidation = True
		Me.B_C_button.Enabled = True
		Me.B_C_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.B_C_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.B_C_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.B_C_button.TabStop = True
		Me.B_C_button.Name = "B_C_button"
		Me.L_C_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.L_C_button.Text = "L C"
		Me.L_C_button.Size = New System.Drawing.Size(41, 33)
		Me.L_C_button.Location = New System.Drawing.Point(88, 88)
		Me.L_C_button.TabIndex = 94
		Me.L_C_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.L_C_button.BackColor = System.Drawing.SystemColors.Control
		Me.L_C_button.CausesValidation = True
		Me.L_C_button.Enabled = True
		Me.L_C_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.L_C_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.L_C_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.L_C_button.TabStop = True
		Me.L_C_button.Name = "L_C_button"
		Me.RALE_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.RALE_button.Text = "RALE"
		Me.RALE_button.Size = New System.Drawing.Size(97, 17)
		Me.RALE_button.Location = New System.Drawing.Point(376, 80)
		Me.RALE_button.TabIndex = 93
		Me.RALE_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RALE_button.BackColor = System.Drawing.SystemColors.Control
		Me.RALE_button.CausesValidation = True
		Me.RALE_button.Enabled = True
		Me.RALE_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.RALE_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.RALE_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.RALE_button.TabStop = True
		Me.RALE_button.Name = "RALE_button"
		Me.SONNE_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.SONNE_button.Text = "SONNE"
		Me.SONNE_button.Size = New System.Drawing.Size(97, 17)
		Me.SONNE_button.Location = New System.Drawing.Point(376, 56)
		Me.SONNE_button.TabIndex = 92
		Me.SONNE_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SONNE_button.BackColor = System.Drawing.SystemColors.Control
		Me.SONNE_button.CausesValidation = True
		Me.SONNE_button.Enabled = True
		Me.SONNE_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SONNE_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.SONNE_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.SONNE_button.TabStop = True
		Me.SONNE_button.Name = "SONNE_button"
		Me.JOUE_AIR_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.JOUE_AIR_button.Text = "JOUE AIR"
		Me.JOUE_AIR_button.Size = New System.Drawing.Size(97, 17)
		Me.JOUE_AIR_button.Location = New System.Drawing.Point(376, 104)
		Me.JOUE_AIR_button.TabIndex = 91
		Me.JOUE_AIR_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.JOUE_AIR_button.BackColor = System.Drawing.SystemColors.Control
		Me.JOUE_AIR_button.CausesValidation = True
		Me.JOUE_AIR_button.Enabled = True
		Me.JOUE_AIR_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.JOUE_AIR_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.JOUE_AIR_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.JOUE_AIR_button.TabStop = True
		Me.JOUE_AIR_button.Name = "JOUE_AIR_button"
		Me.ALLUME_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ALLUME_button.Text = "ALLUME"
		Me.ALLUME_button.Size = New System.Drawing.Size(137, 17)
		Me.ALLUME_button.Location = New System.Drawing.Point(224, 24)
		Me.ALLUME_button.TabIndex = 90
		Me.ALLUME_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ALLUME_button.BackColor = System.Drawing.SystemColors.Control
		Me.ALLUME_button.CausesValidation = True
		Me.ALLUME_button.Enabled = True
		Me.ALLUME_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ALLUME_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.ALLUME_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ALLUME_button.TabStop = True
		Me.ALLUME_button.Name = "ALLUME_button"
		Me.ETEINS_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ETEINS_button.Text = "ETEINS"
		Me.ETEINS_button.Size = New System.Drawing.Size(137, 17)
		Me.ETEINS_button.Location = New System.Drawing.Point(224, 112)
		Me.ETEINS_button.TabIndex = 89
		Me.ETEINS_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ETEINS_button.BackColor = System.Drawing.SystemColors.Control
		Me.ETEINS_button.CausesValidation = True
		Me.ETEINS_button.Enabled = True
		Me.ETEINS_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ETEINS_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.ETEINS_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ETEINS_button.TabStop = True
		Me.ETEINS_button.Name = "ETEINS_button"
		Me.ETEINS_G_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ETEINS_G_button.Text = "ETEINS G"
		Me.ETEINS_G_button.Size = New System.Drawing.Size(65, 17)
		Me.ETEINS_G_button.Location = New System.Drawing.Point(224, 136)
		Me.ETEINS_G_button.TabIndex = 88
		Me.ETEINS_G_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ETEINS_G_button.BackColor = System.Drawing.SystemColors.Control
		Me.ETEINS_G_button.CausesValidation = True
		Me.ETEINS_G_button.Enabled = True
		Me.ETEINS_G_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ETEINS_G_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.ETEINS_G_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ETEINS_G_button.TabStop = True
		Me.ETEINS_G_button.Name = "ETEINS_G_button"
		Me.ETEINS_D_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ETEINS_D_button.Text = "ETEINS D"
		Me.ETEINS_D_button.Size = New System.Drawing.Size(65, 17)
		Me.ETEINS_D_button.Location = New System.Drawing.Point(296, 136)
		Me.ETEINS_D_button.TabIndex = 87
		Me.ETEINS_D_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ETEINS_D_button.BackColor = System.Drawing.SystemColors.Control
		Me.ETEINS_D_button.CausesValidation = True
		Me.ETEINS_D_button.Enabled = True
		Me.ETEINS_D_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ETEINS_D_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.ETEINS_D_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ETEINS_D_button.TabStop = True
		Me.ETEINS_D_button.Name = "ETEINS_D_button"
		Me.CLIGNE_G_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CLIGNE_G_button.Text = "CLIGNE G"
		Me.CLIGNE_G_button.Size = New System.Drawing.Size(65, 17)
		Me.CLIGNE_G_button.Location = New System.Drawing.Point(224, 72)
		Me.CLIGNE_G_button.TabIndex = 86
		Me.CLIGNE_G_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CLIGNE_G_button.BackColor = System.Drawing.SystemColors.Control
		Me.CLIGNE_G_button.CausesValidation = True
		Me.CLIGNE_G_button.Enabled = True
		Me.CLIGNE_G_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CLIGNE_G_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.CLIGNE_G_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CLIGNE_G_button.TabStop = True
		Me.CLIGNE_G_button.Name = "CLIGNE_G_button"
		Me.CLIGNE_D_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CLIGNE_D_button.Text = "CLIGNE D"
		Me.CLIGNE_D_button.Size = New System.Drawing.Size(65, 17)
		Me.CLIGNE_D_button.Location = New System.Drawing.Point(296, 72)
		Me.CLIGNE_D_button.TabIndex = 85
		Me.CLIGNE_D_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CLIGNE_D_button.BackColor = System.Drawing.SystemColors.Control
		Me.CLIGNE_D_button.CausesValidation = True
		Me.CLIGNE_D_button.Enabled = True
		Me.CLIGNE_D_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CLIGNE_D_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.CLIGNE_D_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CLIGNE_D_button.TabStop = True
		Me.CLIGNE_D_button.Name = "CLIGNE_D_button"
		Me.ARC_AVG_5_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ARC_AVG_5_button.Text = "ARC AVG 5"
		Me.ARC_AVG_5_button.Size = New System.Drawing.Size(81, 17)
		Me.ARC_AVG_5_button.Location = New System.Drawing.Point(8, 16)
		Me.ARC_AVG_5_button.TabIndex = 84
		Me.ARC_AVG_5_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ARC_AVG_5_button.BackColor = System.Drawing.SystemColors.Control
		Me.ARC_AVG_5_button.CausesValidation = True
		Me.ARC_AVG_5_button.Enabled = True
		Me.ARC_AVG_5_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ARC_AVG_5_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.ARC_AVG_5_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ARC_AVG_5_button.TabStop = True
		Me.ARC_AVG_5_button.Name = "ARC_AVG_5_button"
		Me.ARC_AVG_10_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ARC_AVG_10_button.Text = "ARC AVG 10"
		Me.ARC_AVG_10_button.Size = New System.Drawing.Size(81, 17)
		Me.ARC_AVG_10_button.Location = New System.Drawing.Point(8, 40)
		Me.ARC_AVG_10_button.TabIndex = 83
		Me.ARC_AVG_10_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ARC_AVG_10_button.BackColor = System.Drawing.SystemColors.Control
		Me.ARC_AVG_10_button.CausesValidation = True
		Me.ARC_AVG_10_button.Enabled = True
		Me.ARC_AVG_10_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ARC_AVG_10_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.ARC_AVG_10_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ARC_AVG_10_button.TabStop = True
		Me.ARC_AVG_10_button.Name = "ARC_AVG_10_button"
		Me.ARC_AVG_20_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ARC_AVG_20_button.Text = "ARC AVG 20"
		Me.ARC_AVG_20_button.Size = New System.Drawing.Size(81, 17)
		Me.ARC_AVG_20_button.Location = New System.Drawing.Point(8, 64)
		Me.ARC_AVG_20_button.TabIndex = 82
		Me.ARC_AVG_20_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ARC_AVG_20_button.BackColor = System.Drawing.SystemColors.Control
		Me.ARC_AVG_20_button.CausesValidation = True
		Me.ARC_AVG_20_button.Enabled = True
		Me.ARC_AVG_20_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ARC_AVG_20_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.ARC_AVG_20_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ARC_AVG_20_button.TabStop = True
		Me.ARC_AVG_20_button.Name = "ARC_AVG_20_button"
		Me.ARC_AVD_5_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ARC_AVD_5_button.Text = "ARC AVD 5"
		Me.ARC_AVD_5_button.Size = New System.Drawing.Size(73, 17)
		Me.ARC_AVD_5_button.Location = New System.Drawing.Point(96, 16)
		Me.ARC_AVD_5_button.TabIndex = 81
		Me.ARC_AVD_5_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ARC_AVD_5_button.BackColor = System.Drawing.SystemColors.Control
		Me.ARC_AVD_5_button.CausesValidation = True
		Me.ARC_AVD_5_button.Enabled = True
		Me.ARC_AVD_5_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ARC_AVD_5_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.ARC_AVD_5_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ARC_AVD_5_button.TabStop = True
		Me.ARC_AVD_5_button.Name = "ARC_AVD_5_button"
		Me.ARC_AVD_10_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ARC_AVD_10_button.Text = "ARC AVD 10"
		Me.ARC_AVD_10_button.Size = New System.Drawing.Size(73, 17)
		Me.ARC_AVD_10_button.Location = New System.Drawing.Point(96, 40)
		Me.ARC_AVD_10_button.TabIndex = 80
		Me.ARC_AVD_10_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ARC_AVD_10_button.BackColor = System.Drawing.SystemColors.Control
		Me.ARC_AVD_10_button.CausesValidation = True
		Me.ARC_AVD_10_button.Enabled = True
		Me.ARC_AVD_10_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ARC_AVD_10_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.ARC_AVD_10_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ARC_AVD_10_button.TabStop = True
		Me.ARC_AVD_10_button.Name = "ARC_AVD_10_button"
		Me.ARC_AVD_20_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ARC_AVD_20_button.Text = "ARC AVD 20"
		Me.ARC_AVD_20_button.Size = New System.Drawing.Size(73, 17)
		Me.ARC_AVD_20_button.Location = New System.Drawing.Point(96, 64)
		Me.ARC_AVD_20_button.TabIndex = 79
		Me.ARC_AVD_20_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ARC_AVD_20_button.BackColor = System.Drawing.SystemColors.Control
		Me.ARC_AVD_20_button.CausesValidation = True
		Me.ARC_AVD_20_button.Enabled = True
		Me.ARC_AVD_20_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ARC_AVD_20_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.ARC_AVD_20_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ARC_AVD_20_button.TabStop = True
		Me.ARC_AVD_20_button.Name = "ARC_AVD_20_button"
		Me.Frame4.BackColor = System.Drawing.Color.Blue
		Me.Frame4.ForeColor = System.Drawing.SystemColors.Control
		Me.Frame4.Size = New System.Drawing.Size(233, 449)
		Me.Frame4.Location = New System.Drawing.Point(256, 16)
		Me.Frame4.TabIndex = 41
		Me.Frame4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame4.Enabled = True
		Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame4.Visible = True
		Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame4.Name = "Frame4"
		Me.PROCEDURE_N1_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N1_button.Text = "PROCEDURE N°1"
		Me.PROCEDURE_N1_button.Size = New System.Drawing.Size(105, 21)
		Me.PROCEDURE_N1_button.Location = New System.Drawing.Point(8, 16)
		Me.PROCEDURE_N1_button.TabIndex = 77
		Me.PROCEDURE_N1_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N1_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N1_button.CausesValidation = True
		Me.PROCEDURE_N1_button.Enabled = True
		Me.PROCEDURE_N1_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N1_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N1_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N1_button.TabStop = True
		Me.PROCEDURE_N1_button.Name = "PROCEDURE_N1_button"
		Me.PROCEDURE_N2_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N2_button.Text = "PROCEDURE N°2"
		Me.PROCEDURE_N2_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N2_button.Location = New System.Drawing.Point(8, 40)
		Me.PROCEDURE_N2_button.TabIndex = 76
		Me.PROCEDURE_N2_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N2_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N2_button.CausesValidation = True
		Me.PROCEDURE_N2_button.Enabled = True
		Me.PROCEDURE_N2_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N2_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N2_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N2_button.TabStop = True
		Me.PROCEDURE_N2_button.Name = "PROCEDURE_N2_button"
		Me.PROCEDURE_N3_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N3_button.Text = "PROCEDURE N°3"
		Me.PROCEDURE_N3_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N3_button.Location = New System.Drawing.Point(8, 64)
		Me.PROCEDURE_N3_button.TabIndex = 75
		Me.PROCEDURE_N3_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N3_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N3_button.CausesValidation = True
		Me.PROCEDURE_N3_button.Enabled = True
		Me.PROCEDURE_N3_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N3_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N3_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N3_button.TabStop = True
		Me.PROCEDURE_N3_button.Name = "PROCEDURE_N3_button"
		Me.PROCEDURE_N4_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N4_button.Text = "PROCEDURE N°4"
		Me.PROCEDURE_N4_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N4_button.Location = New System.Drawing.Point(8, 88)
		Me.PROCEDURE_N4_button.TabIndex = 74
		Me.PROCEDURE_N4_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N4_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N4_button.CausesValidation = True
		Me.PROCEDURE_N4_button.Enabled = True
		Me.PROCEDURE_N4_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N4_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N4_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N4_button.TabStop = True
		Me.PROCEDURE_N4_button.Name = "PROCEDURE_N4_button"
		Me.PROCEDURE_N5_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N5_button.Text = "PROCEDURE N°5"
		Me.PROCEDURE_N5_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N5_button.Location = New System.Drawing.Point(8, 112)
		Me.PROCEDURE_N5_button.TabIndex = 73
		Me.PROCEDURE_N5_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N5_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N5_button.CausesValidation = True
		Me.PROCEDURE_N5_button.Enabled = True
		Me.PROCEDURE_N5_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N5_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N5_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N5_button.TabStop = True
		Me.PROCEDURE_N5_button.Name = "PROCEDURE_N5_button"
		Me.PROCEDURE_N6_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N6_button.Text = "PROCEDURE N°6"
		Me.PROCEDURE_N6_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N6_button.Location = New System.Drawing.Point(8, 136)
		Me.PROCEDURE_N6_button.TabIndex = 72
		Me.PROCEDURE_N6_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N6_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N6_button.CausesValidation = True
		Me.PROCEDURE_N6_button.Enabled = True
		Me.PROCEDURE_N6_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N6_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N6_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N6_button.TabStop = True
		Me.PROCEDURE_N6_button.Name = "PROCEDURE_N6_button"
		Me.PROCEDURE_N7_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N7_button.Text = "PROCEDURE N°7"
		Me.PROCEDURE_N7_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N7_button.Location = New System.Drawing.Point(8, 160)
		Me.PROCEDURE_N7_button.TabIndex = 71
		Me.PROCEDURE_N7_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N7_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N7_button.CausesValidation = True
		Me.PROCEDURE_N7_button.Enabled = True
		Me.PROCEDURE_N7_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N7_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N7_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N7_button.TabStop = True
		Me.PROCEDURE_N7_button.Name = "PROCEDURE_N7_button"
		Me.PROCEDURE_N8_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N8_button.Text = "PROCEDURE N°8"
		Me.PROCEDURE_N8_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N8_button.Location = New System.Drawing.Point(8, 184)
		Me.PROCEDURE_N8_button.TabIndex = 70
		Me.PROCEDURE_N8_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N8_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N8_button.CausesValidation = True
		Me.PROCEDURE_N8_button.Enabled = True
		Me.PROCEDURE_N8_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N8_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N8_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N8_button.TabStop = True
		Me.PROCEDURE_N8_button.Name = "PROCEDURE_N8_button"
		Me.PROCEDURE_N9_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N9_button.Text = "PROCEDURE N°9"
		Me.PROCEDURE_N9_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N9_button.Location = New System.Drawing.Point(8, 208)
		Me.PROCEDURE_N9_button.TabIndex = 69
		Me.PROCEDURE_N9_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N9_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N9_button.CausesValidation = True
		Me.PROCEDURE_N9_button.Enabled = True
		Me.PROCEDURE_N9_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N9_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N9_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N9_button.TabStop = True
		Me.PROCEDURE_N9_button.Name = "PROCEDURE_N9_button"
		Me.PROCEDURE_N10_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N10_button.Text = "PROCEDURE N°10"
		Me.PROCEDURE_N10_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N10_button.Location = New System.Drawing.Point(8, 232)
		Me.PROCEDURE_N10_button.TabIndex = 68
		Me.PROCEDURE_N10_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N10_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N10_button.CausesValidation = True
		Me.PROCEDURE_N10_button.Enabled = True
		Me.PROCEDURE_N10_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N10_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N10_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N10_button.TabStop = True
		Me.PROCEDURE_N10_button.Name = "PROCEDURE_N10_button"
		Me.PROCEDURE_N11_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N11_button.Text = "PROCEDURE N°11"
		Me.PROCEDURE_N11_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N11_button.Location = New System.Drawing.Point(8, 256)
		Me.PROCEDURE_N11_button.TabIndex = 67
		Me.PROCEDURE_N11_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N11_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N11_button.CausesValidation = True
		Me.PROCEDURE_N11_button.Enabled = True
		Me.PROCEDURE_N11_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N11_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N11_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N11_button.TabStop = True
		Me.PROCEDURE_N11_button.Name = "PROCEDURE_N11_button"
		Me.PROCEDURE_N12_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N12_button.Text = "PROCEDURE N°12"
		Me.PROCEDURE_N12_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N12_button.Location = New System.Drawing.Point(8, 280)
		Me.PROCEDURE_N12_button.TabIndex = 66
		Me.PROCEDURE_N12_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N12_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N12_button.CausesValidation = True
		Me.PROCEDURE_N12_button.Enabled = True
		Me.PROCEDURE_N12_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N12_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N12_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N12_button.TabStop = True
		Me.PROCEDURE_N12_button.Name = "PROCEDURE_N12_button"
		Me.PROCEDURE_N13_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N13_button.Text = "PROCEDURE N°13"
		Me.PROCEDURE_N13_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N13_button.Location = New System.Drawing.Point(8, 304)
		Me.PROCEDURE_N13_button.TabIndex = 65
		Me.PROCEDURE_N13_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N13_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N13_button.CausesValidation = True
		Me.PROCEDURE_N13_button.Enabled = True
		Me.PROCEDURE_N13_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N13_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N13_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N13_button.TabStop = True
		Me.PROCEDURE_N13_button.Name = "PROCEDURE_N13_button"
		Me.PROCEDURE_N14_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N14_button.Text = "PROCEDURE N°14"
		Me.PROCEDURE_N14_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N14_button.Location = New System.Drawing.Point(8, 328)
		Me.PROCEDURE_N14_button.TabIndex = 64
		Me.PROCEDURE_N14_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N14_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N14_button.CausesValidation = True
		Me.PROCEDURE_N14_button.Enabled = True
		Me.PROCEDURE_N14_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N14_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N14_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N14_button.TabStop = True
		Me.PROCEDURE_N14_button.Name = "PROCEDURE_N14_button"
		Me.PROCEDURE_N15_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N15_button.Text = "PROCEDURE N°15"
		Me.PROCEDURE_N15_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N15_button.Location = New System.Drawing.Point(8, 352)
		Me.PROCEDURE_N15_button.TabIndex = 63
		Me.PROCEDURE_N15_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N15_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N15_button.CausesValidation = True
		Me.PROCEDURE_N15_button.Enabled = True
		Me.PROCEDURE_N15_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N15_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N15_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N15_button.TabStop = True
		Me.PROCEDURE_N15_button.Name = "PROCEDURE_N15_button"
		Me.PROCEDURE_N16_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N16_button.Text = "PROCEDURE N°16"
		Me.PROCEDURE_N16_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N16_button.Location = New System.Drawing.Point(8, 376)
		Me.PROCEDURE_N16_button.TabIndex = 62
		Me.PROCEDURE_N16_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N16_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N16_button.CausesValidation = True
		Me.PROCEDURE_N16_button.Enabled = True
		Me.PROCEDURE_N16_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N16_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N16_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N16_button.TabStop = True
		Me.PROCEDURE_N16_button.Name = "PROCEDURE_N16_button"
		Me.PROCEDURE_N17_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N17_button.Text = "PROCEDURE N°17"
		Me.PROCEDURE_N17_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N17_button.Location = New System.Drawing.Point(8, 400)
		Me.PROCEDURE_N17_button.TabIndex = 61
		Me.PROCEDURE_N17_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N17_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N17_button.CausesValidation = True
		Me.PROCEDURE_N17_button.Enabled = True
		Me.PROCEDURE_N17_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N17_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N17_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N17_button.TabStop = True
		Me.PROCEDURE_N17_button.Name = "PROCEDURE_N17_button"
		Me.PROCEDURE_N18_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N18_button.Text = "PROCEDURE N°18"
		Me.PROCEDURE_N18_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N18_button.Location = New System.Drawing.Point(8, 424)
		Me.PROCEDURE_N18_button.TabIndex = 60
		Me.PROCEDURE_N18_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N18_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N18_button.CausesValidation = True
		Me.PROCEDURE_N18_button.Enabled = True
		Me.PROCEDURE_N18_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N18_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N18_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N18_button.TabStop = True
		Me.PROCEDURE_N18_button.Name = "PROCEDURE_N18_button"
		Me.PROCEDURE_N19_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N19_button.Text = "PROCEDURE N°19"
		Me.PROCEDURE_N19_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N19_button.Location = New System.Drawing.Point(120, 16)
		Me.PROCEDURE_N19_button.TabIndex = 59
		Me.PROCEDURE_N19_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N19_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N19_button.CausesValidation = True
		Me.PROCEDURE_N19_button.Enabled = True
		Me.PROCEDURE_N19_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N19_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N19_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N19_button.TabStop = True
		Me.PROCEDURE_N19_button.Name = "PROCEDURE_N19_button"
		Me.PROCEDURE_N20_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N20_button.Text = "PROCEDURE N°20"
		Me.PROCEDURE_N20_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N20_button.Location = New System.Drawing.Point(120, 40)
		Me.PROCEDURE_N20_button.TabIndex = 58
		Me.PROCEDURE_N20_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N20_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N20_button.CausesValidation = True
		Me.PROCEDURE_N20_button.Enabled = True
		Me.PROCEDURE_N20_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N20_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N20_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N20_button.TabStop = True
		Me.PROCEDURE_N20_button.Name = "PROCEDURE_N20_button"
		Me.PROCEDURE_N21_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N21_button.Text = "PROCEDURE N°21"
		Me.PROCEDURE_N21_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N21_button.Location = New System.Drawing.Point(120, 64)
		Me.PROCEDURE_N21_button.TabIndex = 57
		Me.PROCEDURE_N21_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N21_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N21_button.CausesValidation = True
		Me.PROCEDURE_N21_button.Enabled = True
		Me.PROCEDURE_N21_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N21_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N21_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N21_button.TabStop = True
		Me.PROCEDURE_N21_button.Name = "PROCEDURE_N21_button"
		Me.PROCEDURE_N22_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N22_button.Text = "PROCEDURE N°22"
		Me.PROCEDURE_N22_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N22_button.Location = New System.Drawing.Point(120, 88)
		Me.PROCEDURE_N22_button.TabIndex = 56
		Me.PROCEDURE_N22_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N22_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N22_button.CausesValidation = True
		Me.PROCEDURE_N22_button.Enabled = True
		Me.PROCEDURE_N22_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N22_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N22_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N22_button.TabStop = True
		Me.PROCEDURE_N22_button.Name = "PROCEDURE_N22_button"
		Me.PROCEDURE_N23_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N23_button.Text = "PROCEDURE N°23"
		Me.PROCEDURE_N23_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N23_button.Location = New System.Drawing.Point(120, 112)
		Me.PROCEDURE_N23_button.TabIndex = 55
		Me.PROCEDURE_N23_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N23_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N23_button.CausesValidation = True
		Me.PROCEDURE_N23_button.Enabled = True
		Me.PROCEDURE_N23_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N23_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N23_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N23_button.TabStop = True
		Me.PROCEDURE_N23_button.Name = "PROCEDURE_N23_button"
		Me.PROCEDURE_N24_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N24_button.Text = "PROCEDURE N°24"
		Me.PROCEDURE_N24_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N24_button.Location = New System.Drawing.Point(120, 136)
		Me.PROCEDURE_N24_button.TabIndex = 54
		Me.PROCEDURE_N24_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N24_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N24_button.CausesValidation = True
		Me.PROCEDURE_N24_button.Enabled = True
		Me.PROCEDURE_N24_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N24_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N24_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N24_button.TabStop = True
		Me.PROCEDURE_N24_button.Name = "PROCEDURE_N24_button"
		Me.PROCEDURE_N26_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N26_button.Text = "PROCEDURE N°26"
		Me.PROCEDURE_N26_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N26_button.Location = New System.Drawing.Point(120, 184)
		Me.PROCEDURE_N26_button.TabIndex = 53
		Me.PROCEDURE_N26_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N26_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N26_button.CausesValidation = True
		Me.PROCEDURE_N26_button.Enabled = True
		Me.PROCEDURE_N26_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N26_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N26_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N26_button.TabStop = True
		Me.PROCEDURE_N26_button.Name = "PROCEDURE_N26_button"
		Me.PROCEDURE_N27_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N27_button.Text = "PROCEDURE N°27"
		Me.PROCEDURE_N27_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N27_button.Location = New System.Drawing.Point(120, 208)
		Me.PROCEDURE_N27_button.TabIndex = 52
		Me.PROCEDURE_N27_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N27_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N27_button.CausesValidation = True
		Me.PROCEDURE_N27_button.Enabled = True
		Me.PROCEDURE_N27_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N27_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N27_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N27_button.TabStop = True
		Me.PROCEDURE_N27_button.Name = "PROCEDURE_N27_button"
		Me.PROCEDURE_N28_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N28_button.Text = "PROCEDURE N°28"
		Me.PROCEDURE_N28_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N28_button.Location = New System.Drawing.Point(120, 232)
		Me.PROCEDURE_N28_button.TabIndex = 51
		Me.PROCEDURE_N28_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N28_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N28_button.CausesValidation = True
		Me.PROCEDURE_N28_button.Enabled = True
		Me.PROCEDURE_N28_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N28_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N28_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N28_button.TabStop = True
		Me.PROCEDURE_N28_button.Name = "PROCEDURE_N28_button"
		Me.PROCEDURE_N29_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N29_button.Text = "PROCEDURE N°29"
		Me.PROCEDURE_N29_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N29_button.Location = New System.Drawing.Point(120, 256)
		Me.PROCEDURE_N29_button.TabIndex = 50
		Me.PROCEDURE_N29_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N29_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N29_button.CausesValidation = True
		Me.PROCEDURE_N29_button.Enabled = True
		Me.PROCEDURE_N29_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N29_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N29_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N29_button.TabStop = True
		Me.PROCEDURE_N29_button.Name = "PROCEDURE_N29_button"
		Me.PROCEDURE_N30_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N30_button.Text = "PROCEDURE N°30"
		Me.PROCEDURE_N30_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N30_button.Location = New System.Drawing.Point(120, 280)
		Me.PROCEDURE_N30_button.TabIndex = 49
		Me.PROCEDURE_N30_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N30_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N30_button.CausesValidation = True
		Me.PROCEDURE_N30_button.Enabled = True
		Me.PROCEDURE_N30_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N30_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N30_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N30_button.TabStop = True
		Me.PROCEDURE_N30_button.Name = "PROCEDURE_N30_button"
		Me.PROCEDURE_N31_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N31_button.Text = "PROCEDURE N°31"
		Me.PROCEDURE_N31_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N31_button.Location = New System.Drawing.Point(120, 304)
		Me.PROCEDURE_N31_button.TabIndex = 48
		Me.PROCEDURE_N31_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N31_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N31_button.CausesValidation = True
		Me.PROCEDURE_N31_button.Enabled = True
		Me.PROCEDURE_N31_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N31_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N31_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N31_button.TabStop = True
		Me.PROCEDURE_N31_button.Name = "PROCEDURE_N31_button"
		Me.PROCEDURE_N32_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N32_button.Text = "PROCEDURE N°32"
		Me.PROCEDURE_N32_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N32_button.Location = New System.Drawing.Point(120, 328)
		Me.PROCEDURE_N32_button.TabIndex = 47
		Me.PROCEDURE_N32_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N32_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N32_button.CausesValidation = True
		Me.PROCEDURE_N32_button.Enabled = True
		Me.PROCEDURE_N32_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N32_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N32_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N32_button.TabStop = True
		Me.PROCEDURE_N32_button.Name = "PROCEDURE_N32_button"
		Me.PROCEDURE_N33_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N33_button.Text = "PROCEDURE N°33"
		Me.PROCEDURE_N33_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N33_button.Location = New System.Drawing.Point(120, 352)
		Me.PROCEDURE_N33_button.TabIndex = 46
		Me.PROCEDURE_N33_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N33_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N33_button.CausesValidation = True
		Me.PROCEDURE_N33_button.Enabled = True
		Me.PROCEDURE_N33_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N33_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N33_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N33_button.TabStop = True
		Me.PROCEDURE_N33_button.Name = "PROCEDURE_N33_button"
		Me.PROCEDURE_N34_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N34_button.Text = "PROCEDURE N°34"
		Me.PROCEDURE_N34_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N34_button.Location = New System.Drawing.Point(120, 376)
		Me.PROCEDURE_N34_button.TabIndex = 45
		Me.PROCEDURE_N34_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N34_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N34_button.CausesValidation = True
		Me.PROCEDURE_N34_button.Enabled = True
		Me.PROCEDURE_N34_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N34_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N34_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N34_button.TabStop = True
		Me.PROCEDURE_N34_button.Name = "PROCEDURE_N34_button"
		Me.PROCEDURE_N36_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N36_button.Text = "PROCEDURE N°36"
		Me.PROCEDURE_N36_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N36_button.Location = New System.Drawing.Point(120, 424)
		Me.PROCEDURE_N36_button.TabIndex = 44
		Me.PROCEDURE_N36_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N36_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N36_button.CausesValidation = True
		Me.PROCEDURE_N36_button.Enabled = True
		Me.PROCEDURE_N36_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N36_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N36_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N36_button.TabStop = True
		Me.PROCEDURE_N36_button.Name = "PROCEDURE_N36_button"
		Me.PROCEDURE_N25_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N25_button.Text = "PROCEDURE N°25"
		Me.PROCEDURE_N25_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N25_button.Location = New System.Drawing.Point(120, 160)
		Me.PROCEDURE_N25_button.TabIndex = 43
		Me.PROCEDURE_N25_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N25_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N25_button.CausesValidation = True
		Me.PROCEDURE_N25_button.Enabled = True
		Me.PROCEDURE_N25_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N25_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N25_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N25_button.TabStop = True
		Me.PROCEDURE_N25_button.Name = "PROCEDURE_N25_button"
		Me.PROCEDURE_N35_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.PROCEDURE_N35_button.Text = "PROCEDURE N°35"
		Me.PROCEDURE_N35_button.Size = New System.Drawing.Size(105, 17)
		Me.PROCEDURE_N35_button.Location = New System.Drawing.Point(120, 400)
		Me.PROCEDURE_N35_button.TabIndex = 42
		Me.PROCEDURE_N35_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PROCEDURE_N35_button.BackColor = System.Drawing.SystemColors.Control
		Me.PROCEDURE_N35_button.CausesValidation = True
		Me.PROCEDURE_N35_button.Enabled = True
		Me.PROCEDURE_N35_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PROCEDURE_N35_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.PROCEDURE_N35_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PROCEDURE_N35_button.TabStop = True
		Me.PROCEDURE_N35_button.Name = "PROCEDURE_N35_button"
		Me.Frame1.BackColor = System.Drawing.Color.Red
		Me.Frame1.ForeColor = System.Drawing.SystemColors.Control
		Me.Frame1.Size = New System.Drawing.Size(105, 449)
		Me.Frame1.Location = New System.Drawing.Point(144, 16)
		Me.Frame1.TabIndex = 17
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Enabled = True
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.TOUCHE_STOP_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TOUCHE_STOP_button.Text = "TOUCHE STOP"
		Me.TOUCHE_STOP_button.Size = New System.Drawing.Size(89, 17)
		Me.TOUCHE_STOP_button.Location = New System.Drawing.Point(8, 424)
		Me.TOUCHE_STOP_button.TabIndex = 35
		Me.TOUCHE_STOP_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TOUCHE_STOP_button.BackColor = System.Drawing.SystemColors.Control
		Me.TOUCHE_STOP_button.CausesValidation = True
		Me.TOUCHE_STOP_button.Enabled = True
		Me.TOUCHE_STOP_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TOUCHE_STOP_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TOUCHE_STOP_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TOUCHE_STOP_button.TabStop = True
		Me.TOUCHE_STOP_button.Name = "TOUCHE_STOP_button"
		Me.TOUCHE_AR_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TOUCHE_AR_button.Text = "TOUCHE AR"
		Me.TOUCHE_AR_button.Size = New System.Drawing.Size(89, 17)
		Me.TOUCHE_AR_button.Location = New System.Drawing.Point(8, 376)
		Me.TOUCHE_AR_button.TabIndex = 34
		Me.TOUCHE_AR_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TOUCHE_AR_button.BackColor = System.Drawing.SystemColors.Control
		Me.TOUCHE_AR_button.CausesValidation = True
		Me.TOUCHE_AR_button.Enabled = True
		Me.TOUCHE_AR_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TOUCHE_AR_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TOUCHE_AR_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TOUCHE_AR_button.TabStop = True
		Me.TOUCHE_AR_button.Name = "TOUCHE_AR_button"
		Me.TOUCHE_AVD_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TOUCHE_AVD_button.Text = "TOUCHE AVD"
		Me.TOUCHE_AVD_button.Size = New System.Drawing.Size(89, 17)
		Me.TOUCHE_AVD_button.Location = New System.Drawing.Point(8, 352)
		Me.TOUCHE_AVD_button.TabIndex = 33
		Me.TOUCHE_AVD_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TOUCHE_AVD_button.BackColor = System.Drawing.SystemColors.Control
		Me.TOUCHE_AVD_button.CausesValidation = True
		Me.TOUCHE_AVD_button.Enabled = True
		Me.TOUCHE_AVD_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TOUCHE_AVD_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TOUCHE_AVD_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TOUCHE_AVD_button.TabStop = True
		Me.TOUCHE_AVD_button.Name = "TOUCHE_AVD_button"
		Me.TOUCHE_AVG_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TOUCHE_AVG_button.Text = "TOUCHE AVG"
		Me.TOUCHE_AVG_button.Size = New System.Drawing.Size(89, 17)
		Me.TOUCHE_AVG_button.Location = New System.Drawing.Point(8, 328)
		Me.TOUCHE_AVG_button.TabIndex = 32
		Me.TOUCHE_AVG_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TOUCHE_AVG_button.BackColor = System.Drawing.SystemColors.Control
		Me.TOUCHE_AVG_button.CausesValidation = True
		Me.TOUCHE_AVG_button.Enabled = True
		Me.TOUCHE_AVG_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TOUCHE_AVG_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TOUCHE_AVG_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TOUCHE_AVG_button.TabStop = True
		Me.TOUCHE_AVG_button.Name = "TOUCHE_AVG_button"
		Me.TEST_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TEST_button.Text = "TEST"
		Me.TEST_button.Size = New System.Drawing.Size(89, 17)
		Me.TEST_button.Location = New System.Drawing.Point(8, 184)
		Me.TEST_button.TabIndex = 31
		Me.TEST_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TEST_button.BackColor = System.Drawing.SystemColors.Control
		Me.TEST_button.CausesValidation = True
		Me.TEST_button.Enabled = True
		Me.TEST_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TEST_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TEST_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TEST_button.TabStop = True
		Me.TEST_button.Name = "TEST_button"
		Me.REGLAGE_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.REGLAGE_button.Text = "REGLAGE"
		Me.REGLAGE_button.Size = New System.Drawing.Size(89, 17)
		Me.REGLAGE_button.Location = New System.Drawing.Point(8, 280)
		Me.REGLAGE_button.TabIndex = 30
		Me.REGLAGE_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.REGLAGE_button.BackColor = System.Drawing.SystemColors.Control
		Me.REGLAGE_button.CausesValidation = True
		Me.REGLAGE_button.Enabled = True
		Me.REGLAGE_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.REGLAGE_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.REGLAGE_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.REGLAGE_button.TabStop = True
		Me.REGLAGE_button.Name = "REGLAGE_button"
		Me.GOMME_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.GOMME_button.Text = "GOMME"
		Me.GOMME_button.Size = New System.Drawing.Size(89, 17)
		Me.GOMME_button.Location = New System.Drawing.Point(8, 160)
		Me.GOMME_button.TabIndex = 29
		Me.GOMME_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GOMME_button.BackColor = System.Drawing.SystemColors.Control
		Me.GOMME_button.CausesValidation = True
		Me.GOMME_button.Enabled = True
		Me.GOMME_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.GOMME_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.GOMME_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.GOMME_button.TabStop = True
		Me.GOMME_button.Name = "GOMME_button"
		Me.OUBLIE_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.OUBLIE_button.Text = "OUBLIE"
		Me.OUBLIE_button.Size = New System.Drawing.Size(89, 17)
		Me.OUBLIE_button.Location = New System.Drawing.Point(8, 16)
		Me.OUBLIE_button.TabIndex = 28
		Me.OUBLIE_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.OUBLIE_button.BackColor = System.Drawing.SystemColors.Control
		Me.OUBLIE_button.CausesValidation = True
		Me.OUBLIE_button.Enabled = True
		Me.OUBLIE_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.OUBLIE_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.OUBLIE_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.OUBLIE_button.TabStop = True
		Me.OUBLIE_button.Name = "OUBLIE_button"
		Me.SUPPRIME_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.SUPPRIME_button.Text = "SUPPRIME"
		Me.SUPPRIME_button.Size = New System.Drawing.Size(89, 17)
		Me.SUPPRIME_button.Location = New System.Drawing.Point(8, 232)
		Me.SUPPRIME_button.TabIndex = 27
		Me.SUPPRIME_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SUPPRIME_button.BackColor = System.Drawing.SystemColors.Control
		Me.SUPPRIME_button.CausesValidation = True
		Me.SUPPRIME_button.Enabled = True
		Me.SUPPRIME_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SUPPRIME_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.SUPPRIME_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.SUPPRIME_button.TabStop = True
		Me.SUPPRIME_button.Name = "SUPPRIME_button"
		Me.FIN_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.FIN_button.Text = "FIN"
		Me.FIN_button.Size = New System.Drawing.Size(89, 17)
		Me.FIN_button.Location = New System.Drawing.Point(8, 400)
		Me.FIN_button.TabIndex = 26
		Me.FIN_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FIN_button.BackColor = System.Drawing.SystemColors.Control
		Me.FIN_button.CausesValidation = True
		Me.FIN_button.Enabled = True
		Me.FIN_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FIN_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.FIN_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FIN_button.TabStop = True
		Me.FIN_button.Name = "FIN_button"
		Me.TOUT_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.TOUT_button.Text = "TOUT"
		Me.TOUT_button.Size = New System.Drawing.Size(89, 17)
		Me.TOUT_button.Location = New System.Drawing.Point(8, 256)
		Me.TOUT_button.TabIndex = 25
		Me.TOUT_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TOUT_button.BackColor = System.Drawing.SystemColors.Control
		Me.TOUT_button.CausesValidation = True
		Me.TOUT_button.Enabled = True
		Me.TOUT_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.TOUT_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.TOUT_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TOUT_button.TabStop = True
		Me.TOUT_button.Name = "TOUT_button"
		Me.DES_QUE_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.DES_QUE_button.Text = "DES QUE"
		Me.DES_QUE_button.Size = New System.Drawing.Size(89, 17)
		Me.DES_QUE_button.Location = New System.Drawing.Point(8, 304)
		Me.DES_QUE_button.TabIndex = 24
		Me.DES_QUE_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DES_QUE_button.BackColor = System.Drawing.SystemColors.Control
		Me.DES_QUE_button.CausesValidation = True
		Me.DES_QUE_button.Enabled = True
		Me.DES_QUE_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.DES_QUE_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.DES_QUE_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.DES_QUE_button.TabStop = True
		Me.DES_QUE_button.Name = "DES_QUE_button"
		Me.ARRET_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ARRET_button.Text = "ARRET"
		Me.ARRET_button.Size = New System.Drawing.Size(89, 17)
		Me.ARRET_button.Location = New System.Drawing.Point(8, 208)
		Me.ARRET_button.TabIndex = 23
		Me.ARRET_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ARRET_button.BackColor = System.Drawing.SystemColors.Control
		Me.ARRET_button.CausesValidation = True
		Me.ARRET_button.Enabled = True
		Me.ARRET_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ARRET_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.ARRET_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ARRET_button.TabStop = True
		Me.ARRET_button.Name = "ARRET_button"
		Me.EXECUTE_M_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.EXECUTE_M_button.Text = "EXECUTE-"
		Me.EXECUTE_M_button.Size = New System.Drawing.Size(89, 17)
		Me.EXECUTE_M_button.Location = New System.Drawing.Point(8, 136)
		Me.EXECUTE_M_button.TabIndex = 22
		Me.EXECUTE_M_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.EXECUTE_M_button.BackColor = System.Drawing.SystemColors.Control
		Me.EXECUTE_M_button.CausesValidation = True
		Me.EXECUTE_M_button.Enabled = True
		Me.EXECUTE_M_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.EXECUTE_M_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.EXECUTE_M_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.EXECUTE_M_button.TabStop = True
		Me.EXECUTE_M_button.Name = "EXECUTE_M_button"
		Me.EXECUTE_P_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.EXECUTE_P_button.Text = "EXECUTE+"
		Me.EXECUTE_P_button.Size = New System.Drawing.Size(89, 17)
		Me.EXECUTE_P_button.Location = New System.Drawing.Point(8, 112)
		Me.EXECUTE_P_button.TabIndex = 21
		Me.EXECUTE_P_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.EXECUTE_P_button.BackColor = System.Drawing.SystemColors.Control
		Me.EXECUTE_P_button.CausesValidation = True
		Me.EXECUTE_P_button.Enabled = True
		Me.EXECUTE_P_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.EXECUTE_P_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.EXECUTE_P_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.EXECUTE_P_button.TabStop = True
		Me.EXECUTE_P_button.Name = "EXECUTE_P_button"
		Me.EXECUTE_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.EXECUTE_button.Text = "EXECUTE"
		Me.EXECUTE_button.Size = New System.Drawing.Size(89, 17)
		Me.EXECUTE_button.Location = New System.Drawing.Point(8, 88)
		Me.EXECUTE_button.TabIndex = 20
		Me.EXECUTE_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.EXECUTE_button.BackColor = System.Drawing.SystemColors.Control
		Me.EXECUTE_button.CausesValidation = True
		Me.EXECUTE_button.Enabled = True
		Me.EXECUTE_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.EXECUTE_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.EXECUTE_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.EXECUTE_button.TabStop = True
		Me.EXECUTE_button.Name = "EXECUTE_button"
		Me.C_EST_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.C_EST_button.Text = "C'EST"
		Me.C_EST_button.Size = New System.Drawing.Size(89, 17)
		Me.C_EST_button.Location = New System.Drawing.Point(8, 64)
		Me.C_EST_button.TabIndex = 19
		Me.C_EST_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.C_EST_button.BackColor = System.Drawing.SystemColors.Control
		Me.C_EST_button.CausesValidation = True
		Me.C_EST_button.Enabled = True
		Me.C_EST_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.C_EST_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.C_EST_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.C_EST_button.TabStop = True
		Me.C_EST_button.Name = "C_EST_button"
		Me.APPRENDS_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.APPRENDS_button.Text = "APPRENDS"
		Me.APPRENDS_button.Size = New System.Drawing.Size(89, 17)
		Me.APPRENDS_button.Location = New System.Drawing.Point(8, 40)
		Me.APPRENDS_button.TabIndex = 18
		Me.ToolTip1.SetToolTip(Me.APPRENDS_button, "blabla")
		Me.APPRENDS_button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.APPRENDS_button.BackColor = System.Drawing.SystemColors.Control
		Me.APPRENDS_button.CausesValidation = True
		Me.APPRENDS_button.Enabled = True
		Me.APPRENDS_button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.APPRENDS_button.Cursor = System.Windows.Forms.Cursors.Default
		Me.APPRENDS_button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.APPRENDS_button.TabStop = True
		Me.APPRENDS_button.Name = "APPRENDS_button"
		Me.Image_Treatment.Text = "Images"
		Me.Image_Treatment.Size = New System.Drawing.Size(201, 713)
		Me.Image_Treatment.Location = New System.Drawing.Point(8, 0)
		Me.Image_Treatment.TabIndex = 0
		Me.Image_Treatment.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Image_Treatment.BackColor = System.Drawing.SystemColors.Control
		Me.Image_Treatment.Enabled = True
		Me.Image_Treatment.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Image_Treatment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Image_Treatment.Visible = True
		Me.Image_Treatment.Padding = New System.Windows.Forms.Padding(0)
		Me.Image_Treatment.Name = "Image_Treatment"
		Me.Calibrate_T3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Calibrate_T3.Text = "Calibrer T3"
		Me.Calibrate_T3.Size = New System.Drawing.Size(73, 17)
		Me.Calibrate_T3.Location = New System.Drawing.Point(120, 688)
		Me.Calibrate_T3.TabIndex = 157
		Me.ToolTip1.SetToolTip(Me.Calibrate_T3, "Open the calibration window")
		Me.Calibrate_T3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Calibrate_T3.BackColor = System.Drawing.SystemColors.Control
		Me.Calibrate_T3.CausesValidation = True
		Me.Calibrate_T3.Enabled = True
		Me.Calibrate_T3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Calibrate_T3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Calibrate_T3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Calibrate_T3.TabStop = True
		Me.Calibrate_T3.Name = "Calibrate_T3"
		Me.UseCorrections.Text = "Utiliser corrections"
		Me.UseCorrections.Size = New System.Drawing.Size(113, 17)
		Me.UseCorrections.Location = New System.Drawing.Point(8, 688)
		Me.UseCorrections.TabIndex = 156
		Me.ToolTip1.SetToolTip(Me.UseCorrections, "Use corrections for image drawing")
		Me.UseCorrections.CheckState = System.Windows.Forms.CheckState.Checked
		Me.UseCorrections.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.UseCorrections.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.UseCorrections.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.UseCorrections.BackColor = System.Drawing.SystemColors.Control
		Me.UseCorrections.CausesValidation = True
		Me.UseCorrections.Enabled = True
		Me.UseCorrections.ForeColor = System.Drawing.SystemColors.ControlText
		Me.UseCorrections.Cursor = System.Windows.Forms.Cursors.Default
		Me.UseCorrections.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.UseCorrections.Appearance = System.Windows.Forms.Appearance.Normal
		Me.UseCorrections.TabStop = True
		Me.UseCorrections.Visible = True
		Me.UseCorrections.Name = "UseCorrections"
		Me.selectImage_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.selectImage_Button.Text = "Select. Image"
		Me.selectImage_Button.Size = New System.Drawing.Size(89, 17)
		Me.selectImage_Button.Location = New System.Drawing.Point(8, 120)
		Me.selectImage_Button.TabIndex = 9
		Me.ToolTip1.SetToolTip(Me.selectImage_Button, "Select a SVG image")
		Me.selectImage_Button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.selectImage_Button.BackColor = System.Drawing.SystemColors.Control
		Me.selectImage_Button.CausesValidation = True
		Me.selectImage_Button.Enabled = True
		Me.selectImage_Button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.selectImage_Button.Cursor = System.Windows.Forms.Cursors.Default
		Me.selectImage_Button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.selectImage_Button.TabStop = True
		Me.selectImage_Button.Name = "selectImage_Button"
		Me.Generate_Command_List.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Generate_Command_List.Text = "Generer commandes"
		Me.Generate_Command_List.Size = New System.Drawing.Size(121, 17)
		Me.Generate_Command_List.Location = New System.Drawing.Point(72, 640)
		Me.Generate_Command_List.TabIndex = 8
		Me.ToolTip1.SetToolTip(Me.Generate_Command_List, "Generate the list of card to draw the image and show a preview")
		Me.Generate_Command_List.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Generate_Command_List.BackColor = System.Drawing.SystemColors.Control
		Me.Generate_Command_List.CausesValidation = True
		Me.Generate_Command_List.Enabled = True
		Me.Generate_Command_List.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Generate_Command_List.Cursor = System.Windows.Forms.Cursors.Default
		Me.Generate_Command_List.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Generate_Command_List.TabStop = True
		Me.Generate_Command_List.Name = "Generate_Command_List"
		Me.Send_Image_To_T3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Send_Image_To_T3.Text = "Envoyer vers T3"
		Me.Send_Image_To_T3.Size = New System.Drawing.Size(121, 17)
		Me.Send_Image_To_T3.Location = New System.Drawing.Point(72, 664)
		Me.Send_Image_To_T3.TabIndex = 7
		Me.ToolTip1.SetToolTip(Me.Send_Image_To_T3, "Generate the list of card to draw the image and send it to the T3")
		Me.Send_Image_To_T3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Send_Image_To_T3.BackColor = System.Drawing.SystemColors.Control
		Me.Send_Image_To_T3.CausesValidation = True
		Me.Send_Image_To_T3.Enabled = True
		Me.Send_Image_To_T3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Send_Image_To_T3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Send_Image_To_T3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Send_Image_To_T3.TabStop = True
		Me.Send_Image_To_T3.Name = "Send_Image_To_T3"
		Me.imagePath.AutoSize = False
		Me.imagePath.Size = New System.Drawing.Size(185, 19)
		Me.imagePath.Location = New System.Drawing.Point(8, 96)
		Me.imagePath.TabIndex = 6
		Me.imagePath.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.imagePath.AcceptsReturn = True
		Me.imagePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.imagePath.BackColor = System.Drawing.SystemColors.Window
		Me.imagePath.CausesValidation = True
		Me.imagePath.Enabled = True
		Me.imagePath.ForeColor = System.Drawing.SystemColors.WindowText
		Me.imagePath.HideSelection = True
		Me.imagePath.ReadOnly = False
		Me.imagePath.Maxlength = 0
		Me.imagePath.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.imagePath.MultiLine = False
		Me.imagePath.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.imagePath.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.imagePath.TabStop = True
		Me.imagePath.Visible = True
		Me.imagePath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.imagePath.Name = "imagePath"
		Me.imageEditorPath.AutoSize = False
		Me.imageEditorPath.Size = New System.Drawing.Size(185, 21)
		Me.imageEditorPath.Location = New System.Drawing.Point(8, 32)
		Me.imageEditorPath.TabIndex = 5
		Me.imageEditorPath.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.imageEditorPath.AcceptsReturn = True
		Me.imageEditorPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.imageEditorPath.BackColor = System.Drawing.SystemColors.Window
		Me.imageEditorPath.CausesValidation = True
		Me.imageEditorPath.Enabled = True
		Me.imageEditorPath.ForeColor = System.Drawing.SystemColors.WindowText
		Me.imageEditorPath.HideSelection = True
		Me.imageEditorPath.ReadOnly = False
		Me.imageEditorPath.Maxlength = 0
		Me.imageEditorPath.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.imageEditorPath.MultiLine = False
		Me.imageEditorPath.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.imageEditorPath.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.imageEditorPath.TabStop = True
		Me.imageEditorPath.Visible = True
		Me.imageEditorPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.imageEditorPath.Name = "imageEditorPath"
		Me.SelectImageEditorButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.SelectImageEditorButton.Text = "Select. Editeur"
		Me.SelectImageEditorButton.Size = New System.Drawing.Size(97, 17)
		Me.SelectImageEditorButton.Location = New System.Drawing.Point(8, 56)
		Me.SelectImageEditorButton.TabIndex = 4
		Me.ToolTip1.SetToolTip(Me.SelectImageEditorButton, "Select an external  SVG image editor")
		Me.SelectImageEditorButton.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SelectImageEditorButton.BackColor = System.Drawing.SystemColors.Control
		Me.SelectImageEditorButton.CausesValidation = True
		Me.SelectImageEditorButton.Enabled = True
		Me.SelectImageEditorButton.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SelectImageEditorButton.Cursor = System.Windows.Forms.Cursors.Default
		Me.SelectImageEditorButton.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.SelectImageEditorButton.TabStop = True
		Me.SelectImageEditorButton.Name = "SelectImageEditorButton"
		Me.EditImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.EditImage.Text = "Editer Image"
		Me.EditImage.Size = New System.Drawing.Size(89, 17)
		Me.EditImage.Location = New System.Drawing.Point(104, 120)
		Me.EditImage.TabIndex = 3
		Me.ToolTip1.SetToolTip(Me.EditImage, "Edit SVG image in the external editor")
		Me.EditImage.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.EditImage.BackColor = System.Drawing.SystemColors.Control
		Me.EditImage.CausesValidation = True
		Me.EditImage.Enabled = True
		Me.EditImage.ForeColor = System.Drawing.SystemColors.ControlText
		Me.EditImage.Cursor = System.Windows.Forms.Cursors.Default
		Me.EditImage.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.EditImage.TabStop = True
		Me.EditImage.Name = "EditImage"
		Me.TextCommandList.AutoSize = False
		Me.TextCommandList.Size = New System.Drawing.Size(185, 473)
		Me.TextCommandList.Location = New System.Drawing.Point(8, 160)
		Me.TextCommandList.MultiLine = True
		Me.TextCommandList.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.TextCommandList.WordWrap = False
		Me.TextCommandList.TabIndex = 2
		Me.TextCommandList.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextCommandList.AcceptsReturn = True
		Me.TextCommandList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TextCommandList.BackColor = System.Drawing.SystemColors.Window
		Me.TextCommandList.CausesValidation = True
		Me.TextCommandList.Enabled = True
		Me.TextCommandList.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TextCommandList.HideSelection = True
		Me.TextCommandList.ReadOnly = False
		Me.TextCommandList.Maxlength = 0
		Me.TextCommandList.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TextCommandList.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TextCommandList.TabStop = True
		Me.TextCommandList.Visible = True
		Me.TextCommandList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TextCommandList.Name = "TextCommandList"
		Me.Size_Renamed.AutoSize = False
		Me.Size_Renamed.Size = New System.Drawing.Size(25, 19)
		Me.Size_Renamed.Location = New System.Drawing.Point(24, 656)
		Me.Size_Renamed.TabIndex = 1
		Me.ToolTip1.SetToolTip(Me.Size_Renamed, "Size of the image reproduction")
		Me.Size_Renamed.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Size_Renamed.AcceptsReturn = True
		Me.Size_Renamed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Size_Renamed.BackColor = System.Drawing.SystemColors.Window
		Me.Size_Renamed.CausesValidation = True
		Me.Size_Renamed.Enabled = True
		Me.Size_Renamed.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Size_Renamed.HideSelection = True
		Me.Size_Renamed.ReadOnly = False
		Me.Size_Renamed.Maxlength = 0
		Me.Size_Renamed.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Size_Renamed.MultiLine = False
		Me.Size_Renamed.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Size_Renamed.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Size_Renamed.TabStop = True
		Me.Size_Renamed.Visible = True
		Me.Size_Renamed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Size_Renamed.Name = "Size_Renamed"
		Me.MSComm1.Location = New System.Drawing.Point(128, 296)
		Me.MSComm1.DTREnable = -1
		Me.MSComm1.BaudRate = 1200
		Me.MSComm1.StopBits = 2
		Me.MSComm1.Name = "MSComm1"
		Me.LabelImage.Text = "Chemin de l'image :"
		Me.LabelImage.Size = New System.Drawing.Size(129, 17)
		Me.LabelImage.Location = New System.Drawing.Point(8, 80)
		Me.LabelImage.TabIndex = 15
		Me.LabelImage.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelImage.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.LabelImage.BackColor = System.Drawing.SystemColors.Control
		Me.LabelImage.Enabled = True
		Me.LabelImage.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LabelImage.Cursor = System.Windows.Forms.Cursors.Default
		Me.LabelImage.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.LabelImage.UseMnemonic = True
		Me.LabelImage.Visible = True
		Me.LabelImage.AutoSize = False
		Me.LabelImage.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.LabelImage.Name = "LabelImage"
		Me.LabelEditor.Text = "Chemin éditeur d'image :"
		Me.LabelEditor.Size = New System.Drawing.Size(137, 17)
		Me.LabelEditor.Location = New System.Drawing.Point(8, 16)
		Me.LabelEditor.TabIndex = 14
		Me.LabelEditor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelEditor.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.LabelEditor.BackColor = System.Drawing.SystemColors.Control
		Me.LabelEditor.Enabled = True
		Me.LabelEditor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LabelEditor.Cursor = System.Windows.Forms.Cursors.Default
		Me.LabelEditor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.LabelEditor.UseMnemonic = True
		Me.LabelEditor.Visible = True
		Me.LabelEditor.AutoSize = False
		Me.LabelEditor.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.LabelEditor.Name = "LabelEditor"
		Me.LabelCommandList.Text = "Liste de commandes :"
		Me.LabelCommandList.Size = New System.Drawing.Size(185, 17)
		Me.LabelCommandList.Location = New System.Drawing.Point(8, 144)
		Me.LabelCommandList.TabIndex = 13
		Me.LabelCommandList.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelCommandList.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.LabelCommandList.BackColor = System.Drawing.SystemColors.Control
		Me.LabelCommandList.Enabled = True
		Me.LabelCommandList.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LabelCommandList.Cursor = System.Windows.Forms.Cursors.Default
		Me.LabelCommandList.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.LabelCommandList.UseMnemonic = True
		Me.LabelCommandList.Visible = True
		Me.LabelCommandList.AutoSize = False
		Me.LabelCommandList.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.LabelCommandList.Name = "LabelCommandList"
		Me.LabelScale.Text = "Taille : TxT"
		Me.LabelScale.Size = New System.Drawing.Size(57, 17)
		Me.LabelScale.Location = New System.Drawing.Point(8, 640)
		Me.LabelScale.TabIndex = 12
		Me.LabelScale.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelScale.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.LabelScale.BackColor = System.Drawing.SystemColors.Control
		Me.LabelScale.Enabled = True
		Me.LabelScale.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LabelScale.Cursor = System.Windows.Forms.Cursors.Default
		Me.LabelScale.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.LabelScale.UseMnemonic = True
		Me.LabelScale.Visible = True
		Me.LabelScale.AutoSize = False
		Me.LabelScale.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.LabelScale.Name = "LabelScale"
		Me.Label1.Text = "T="
		Me.Label1.Size = New System.Drawing.Size(17, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 656)
		Me.Label1.TabIndex = 11
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Label2.Text = "cm"
		Me.Label2.Size = New System.Drawing.Size(17, 17)
		Me.Label2.Location = New System.Drawing.Point(48, 656)
		Me.Label2.TabIndex = 10
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Controls.Add(Frame9)
		Me.Controls.Add(Frame5)
		Me.Controls.Add(Frame6)
		Me.Controls.Add(Cards_Treatment)
		Me.Controls.Add(Image_Treatment)
		Me.Frame9.Controls.Add(Show_Manual)
		Me.Frame9.Controls.Add(Scrolling_Mod_Button)
		Me.Frame5.Controls.Add(programming)
		Me.Frame5.Controls.Add(Frame8)
		Me.Frame5.Controls.Add(Insert)
		Me.Frame5.Controls.Add(Send_Program_Step_Backward_To_T3)
		Me.Frame5.Controls.Add(Send_Program_Step_Forward_To_T3)
		Me.Frame5.Controls.Add(ProgramCommandList)
		Me.Frame5.Controls.Add(MoveCommandDown)
		Me.Frame5.Controls.Add(MoveCommandUp)
		Me.Frame5.Controls.Add(RemoveCommand)
		Me.Frame5.Controls.Add(ClearProgramCommandList)
		Me.Frame5.Controls.Add(SaveProgram)
		Me.Frame5.Controls.Add(LoadProgram)
		Me.Frame5.Controls.Add(programEditorPath)
		Me.Frame5.Controls.Add(programPath)
		Me.Frame5.Controls.Add(EditProgram)
		Me.Frame5.Controls.Add(SelectProgramEditorButton)
		Me.Frame5.Controls.Add(Send_Program_To_T3)
		Me.Frame5.Controls.Add(selectProgram_Button)
		Me.Frame5.Controls.Add(Label6)
		Me.Frame5.Controls.Add(Label5)
		Me.Frame5.Controls.Add(Label4)
		Me.Frame8.Controls.Add(Picture11)
		Me.Frame8.Controls.Add(Label8)
		Me.Frame8.Controls.Add(Label7)
		Me.Frame6.Controls.Add(Com_Number)
		Me.Frame6.Controls.Add(Combo_Com_Setting)
		Me.Frame6.Controls.Add(ProgressBarSend)
		Me.Frame6.Controls.Add(Label9)
		Me.Frame6.Controls.Add(Label3)
		Me.Frame6.Controls.Add(LabelProgress)
		Me.Cards_Treatment.Controls.Add(Frame2)
		Me.Cards_Treatment.Controls.Add(Frame3)
		Me.Cards_Treatment.Controls.Add(Frame4)
		Me.Cards_Treatment.Controls.Add(Frame1)
		Me.Frame2.Controls.Add(Picture2)
		Me.Frame2.Controls.Add(Picture6)
		Me.Frame2.Controls.Add(Picture4)
		Me.Frame2.Controls.Add(Picture1)
		Me.Frame2.Controls.Add(TD_120_button)
		Me.Frame2.Controls.Add(TD_90_button)
		Me.Frame2.Controls.Add(TD_60_button)
		Me.Frame2.Controls.Add(TD_45_button)
		Me.Frame2.Controls.Add(TD_30_button)
		Me.Frame2.Controls.Add(TD_15_button)
		Me.Frame2.Controls.Add(TD_1_button)
		Me.Frame2.Controls.Add(TG_120_button)
		Me.Frame2.Controls.Add(TG_90_button)
		Me.Frame2.Controls.Add(TG_60_button)
		Me.Frame2.Controls.Add(TG_45_button)
		Me.Frame2.Controls.Add(TG_30_button)
		Me.Frame2.Controls.Add(TG_15_button)
		Me.Frame2.Controls.Add(TG_1_button)
		Me.Frame2.Controls.Add(RE_20_button)
		Me.Frame2.Controls.Add(RE_10_button)
		Me.Frame2.Controls.Add(RE_1_button)
		Me.Frame2.Controls.Add(AV_20_button)
		Me.Frame2.Controls.Add(AV_10_button)
		Me.Frame2.Controls.Add(AV_1_button)
		Me.Frame3.Controls.Add(Picture10)
		Me.Frame3.Controls.Add(Picture5)
		Me.Frame3.Controls.Add(Picture9)
		Me.Frame3.Controls.Add(Picture8)
		Me.Frame3.Controls.Add(Picture7)
		Me.Frame3.Controls.Add(Picture3)
		Me.Frame3.Controls.Add(B_C_button)
		Me.Frame3.Controls.Add(L_C_button)
		Me.Frame3.Controls.Add(RALE_button)
		Me.Frame3.Controls.Add(SONNE_button)
		Me.Frame3.Controls.Add(JOUE_AIR_button)
		Me.Frame3.Controls.Add(ALLUME_button)
		Me.Frame3.Controls.Add(ETEINS_button)
		Me.Frame3.Controls.Add(ETEINS_G_button)
		Me.Frame3.Controls.Add(ETEINS_D_button)
		Me.Frame3.Controls.Add(CLIGNE_G_button)
		Me.Frame3.Controls.Add(CLIGNE_D_button)
		Me.Frame3.Controls.Add(ARC_AVG_5_button)
		Me.Frame3.Controls.Add(ARC_AVG_10_button)
		Me.Frame3.Controls.Add(ARC_AVG_20_button)
		Me.Frame3.Controls.Add(ARC_AVD_5_button)
		Me.Frame3.Controls.Add(ARC_AVD_10_button)
		Me.Frame3.Controls.Add(ARC_AVD_20_button)
		Me.Frame4.Controls.Add(PROCEDURE_N1_button)
		Me.Frame4.Controls.Add(PROCEDURE_N2_button)
		Me.Frame4.Controls.Add(PROCEDURE_N3_button)
		Me.Frame4.Controls.Add(PROCEDURE_N4_button)
		Me.Frame4.Controls.Add(PROCEDURE_N5_button)
		Me.Frame4.Controls.Add(PROCEDURE_N6_button)
		Me.Frame4.Controls.Add(PROCEDURE_N7_button)
		Me.Frame4.Controls.Add(PROCEDURE_N8_button)
		Me.Frame4.Controls.Add(PROCEDURE_N9_button)
		Me.Frame4.Controls.Add(PROCEDURE_N10_button)
		Me.Frame4.Controls.Add(PROCEDURE_N11_button)
		Me.Frame4.Controls.Add(PROCEDURE_N12_button)
		Me.Frame4.Controls.Add(PROCEDURE_N13_button)
		Me.Frame4.Controls.Add(PROCEDURE_N14_button)
		Me.Frame4.Controls.Add(PROCEDURE_N15_button)
		Me.Frame4.Controls.Add(PROCEDURE_N16_button)
		Me.Frame4.Controls.Add(PROCEDURE_N17_button)
		Me.Frame4.Controls.Add(PROCEDURE_N18_button)
		Me.Frame4.Controls.Add(PROCEDURE_N19_button)
		Me.Frame4.Controls.Add(PROCEDURE_N20_button)
		Me.Frame4.Controls.Add(PROCEDURE_N21_button)
		Me.Frame4.Controls.Add(PROCEDURE_N22_button)
		Me.Frame4.Controls.Add(PROCEDURE_N23_button)
		Me.Frame4.Controls.Add(PROCEDURE_N24_button)
		Me.Frame4.Controls.Add(PROCEDURE_N26_button)
		Me.Frame4.Controls.Add(PROCEDURE_N27_button)
		Me.Frame4.Controls.Add(PROCEDURE_N28_button)
		Me.Frame4.Controls.Add(PROCEDURE_N29_button)
		Me.Frame4.Controls.Add(PROCEDURE_N30_button)
		Me.Frame4.Controls.Add(PROCEDURE_N31_button)
		Me.Frame4.Controls.Add(PROCEDURE_N32_button)
		Me.Frame4.Controls.Add(PROCEDURE_N33_button)
		Me.Frame4.Controls.Add(PROCEDURE_N34_button)
		Me.Frame4.Controls.Add(PROCEDURE_N36_button)
		Me.Frame4.Controls.Add(PROCEDURE_N25_button)
		Me.Frame4.Controls.Add(PROCEDURE_N35_button)
		Me.Frame1.Controls.Add(TOUCHE_STOP_button)
		Me.Frame1.Controls.Add(TOUCHE_AR_button)
		Me.Frame1.Controls.Add(TOUCHE_AVD_button)
		Me.Frame1.Controls.Add(TOUCHE_AVG_button)
		Me.Frame1.Controls.Add(TEST_button)
		Me.Frame1.Controls.Add(REGLAGE_button)
		Me.Frame1.Controls.Add(GOMME_button)
		Me.Frame1.Controls.Add(OUBLIE_button)
		Me.Frame1.Controls.Add(SUPPRIME_button)
		Me.Frame1.Controls.Add(FIN_button)
		Me.Frame1.Controls.Add(TOUT_button)
		Me.Frame1.Controls.Add(DES_QUE_button)
		Me.Frame1.Controls.Add(ARRET_button)
		Me.Frame1.Controls.Add(EXECUTE_M_button)
		Me.Frame1.Controls.Add(EXECUTE_P_button)
		Me.Frame1.Controls.Add(EXECUTE_button)
		Me.Frame1.Controls.Add(C_EST_button)
		Me.Frame1.Controls.Add(APPRENDS_button)
		Me.Image_Treatment.Controls.Add(Calibrate_T3)
		Me.Image_Treatment.Controls.Add(UseCorrections)
		Me.Image_Treatment.Controls.Add(selectImage_Button)
		Me.Image_Treatment.Controls.Add(Generate_Command_List)
		Me.Image_Treatment.Controls.Add(Send_Image_To_T3)
		Me.Image_Treatment.Controls.Add(imagePath)
		Me.Image_Treatment.Controls.Add(imageEditorPath)
		Me.Image_Treatment.Controls.Add(SelectImageEditorButton)
		Me.Image_Treatment.Controls.Add(EditImage)
		Me.Image_Treatment.Controls.Add(TextCommandList)
		Me.Image_Treatment.Controls.Add(Size_Renamed)
		Me.Image_Treatment.Controls.Add(MSComm1)
		Me.Image_Treatment.Controls.Add(LabelImage)
		Me.Image_Treatment.Controls.Add(LabelEditor)
		Me.Image_Treatment.Controls.Add(LabelCommandList)
		Me.Image_Treatment.Controls.Add(LabelScale)
		Me.Image_Treatment.Controls.Add(Label1)
		Me.Image_Treatment.Controls.Add(Label2)
		Me.Frame9.ResumeLayout(False)
		Me.Frame5.ResumeLayout(False)
		Me.Frame8.ResumeLayout(False)
		Me.Frame6.ResumeLayout(False)
		Me.Cards_Treatment.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.Frame4.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.Image_Treatment.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class