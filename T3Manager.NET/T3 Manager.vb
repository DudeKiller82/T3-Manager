Option Strict Off
Option Explicit On
Friend Class T3_Manager
	Inherits System.Windows.Forms.Form
	Private Declare Sub InitCommonControls Lib "COMCTL32.DLL" ()
	
	Public cardList As cardListClass
	Public lineList As Collection
	
	Private Sub ALLUME_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ALLUME_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("ALLUME"))
	End Sub
	
	Private Sub APPRENDS_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles APPRENDS_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("APPRENDS"))
	End Sub
	
	Private Sub ARC_AVD_10_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARC_AVD_10_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("ARC_AVD_10"))
	End Sub
	
	Private Sub ARC_AVD_20_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARC_AVD_20_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("ARC_AVD_20"))
	End Sub
	
	Private Sub ARC_AVD_5_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARC_AVD_5_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("ARC_AVD_5"))
	End Sub
	
	Private Sub ARC_AVG_10_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARC_AVG_10_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("ARC_AVG_10"))
	End Sub
	
	Private Sub ARC_AVG_20_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARC_AVG_20_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("ARC_AVG_20"))
	End Sub
	
	Private Sub ARC_AVG_5_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARC_AVG_5_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("ARC_AVG_5"))
	End Sub
	
	Private Sub ARRET_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARRET_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("ARRET"))
	End Sub
	
	Private Sub AV_1_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AV_1_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("AV_1"))
	End Sub
	
	Private Sub AV_10_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AV_10_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("AV_10"))
	End Sub
	
	Private Sub AV_20_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AV_20_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("AV_20"))
	End Sub
	
	Private Sub B_C_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles B_C_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("B_C"))
	End Sub
	
	Private Sub C_EST_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles C_EST_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("C_EST"))
	End Sub
	
	Private Sub Calibrate_T3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Calibrate_T3.Click
		Calibration.Visible = True
	End Sub
	
	Private Sub ClearProgramCommandList_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ClearProgramCommandList.Click
		ProgramCommandList.Items.Clear()
	End Sub
	
	Private Sub CLIGNE_D_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CLIGNE_D_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("CLIGNE_D"))
	End Sub
	
	Private Sub CLIGNE_G_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CLIGNE_G_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("CLIGNE_G"))
	End Sub
	
	'UPGRADE_WARNING: Event Com_Number.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Com_Number_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Com_Number.TextChanged
		EcritDansFichierIni("com", "comNumber", (Com_Number.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
	End Sub
	
	'UPGRADE_WARNING: Event Combo_Com_Setting.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Combo_Com_Setting_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Combo_Com_Setting.SelectedIndexChanged
		EcritDansFichierIni("com", "comSetting", (Combo_Com_Setting.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
	End Sub
	
	Private Sub Scrolling_Mod_Button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Scrolling_Mod_Button.Click
		Scrolling_Mod.Visible = True
	End Sub
	
	Private Sub Show_Manual_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Show_Manual.Click
		Dim execID As Short
		execID = Shell("C:\WINDOWS\explorer.exe "".\Documentation Tortue T3.pdf""", 1)
	End Sub
	
	Private Sub DES_QUE_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DES_QUE_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("DES_QUE"))
	End Sub
	
	Private Sub EditImage_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles EditImage.Click
		Dim execID As Short
		If (imageEditorPath.Text = "") Then
			selectImageEditor()
		End If
		If (imagePath.Text = "") Then
			selectImage()
		End If
		If ((programEditorPath.Text <> "") And (programPath.Text <> "")) Then execID = Shell(imageEditorPath.Text & " """ & imagePath.Text & """", 3)
	End Sub
	
	Private Sub EditProgram_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles EditProgram.Click
		Dim execID As Short
		If (programEditorPath.Text = "") Then
			selectProgramEditor()
		End If
		If (programPath.Text = "") Then
			selectProgram()
		End If
		If ((programEditorPath.Text <> "") And (programPath.Text <> "")) Then execID = Shell("""" & programEditorPath.Text & """ """ & programPath.Text & """", 3)
	End Sub
	
	Private Sub ETEINS_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ETEINS_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("ETEINS"))
	End Sub
	
	Private Sub ETEINS_D_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ETEINS_D_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("ETEINS_D"))
	End Sub
	
	Private Sub ETEINS_G_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ETEINS_G_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("ETEINS_G"))
	End Sub
	
	Private Sub EXECUTE_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles EXECUTE_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("EXECUTE"))
	End Sub
	
	Private Sub EXECUTE_M_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles EXECUTE_M_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("EXECUTE_M"))
	End Sub
	
	Private Sub EXECUTE_P_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles EXECUTE_P_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("EXECUTE_P"))
	End Sub
	
	Private Sub FIN_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles FIN_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("FIN"))
	End Sub
	
	'UPGRADE_NOTE: Form_Initialize was upgraded to Form_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Form_Initialize_Renamed()
		InitCommonControls()
	End Sub
	
	Private Sub T3_Manager_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		imagePath.Text = LitDansFichierIni("path", "imagePath", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		imageEditorPath.Text = LitDansFichierIni("path", "imageEditorPath", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Size_Renamed.Text = LitDansFichierIni("transformation", "size", My.Application.Info.DirectoryPath & "\T3 Manager.ini", CStr(30))
		
		programPath.Text = LitDansFichierIni("path", "programPath", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		programEditorPath.Text = LitDansFichierIni("path", "programEditorPath", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		
		Combo_Com_Setting.Text = LitDansFichierIni("com", "comSetting", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "1200,N,8,2")
		Com_Number.Text = LitDansFichierIni("com", "comNumber", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "1")
		
		ToolTip1.SetToolTip(AV_1_button, LitDansFichierIni("text", "AV_1", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(AV_10_button, LitDansFichierIni("text", "AV_10", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(AV_20_button, LitDansFichierIni("text", "AV_20", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(RE_1_button, LitDansFichierIni("text", "RE_1", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(RE_10_button, LitDansFichierIni("text", "RE_10", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(RE_20_button, LitDansFichierIni("text", "RE_20", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TG_1_button, LitDansFichierIni("text", "TG_1", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TG_15_button, LitDansFichierIni("text", "TG_15", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TG_30_button, LitDansFichierIni("text", "TG_30", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TG_45_button, LitDansFichierIni("text", "TG_45", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TG_60_button, LitDansFichierIni("text", "TG_60", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TG_90_button, LitDansFichierIni("text", "TG_90", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TG_120_button, LitDansFichierIni("text", "TG_120", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TD_1_button, LitDansFichierIni("text", "TD_1", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TD_15_button, LitDansFichierIni("text", "TD_15", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TD_30_button, LitDansFichierIni("text", "TD_30", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TD_45_button, LitDansFichierIni("text", "TD_45", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TD_60_button, LitDansFichierIni("text", "TD_60", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TD_90_button, LitDansFichierIni("text", "TD_90", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TD_120_button, LitDansFichierIni("text", "TD_120", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		
		ToolTip1.SetToolTip(B_C_button, LitDansFichierIni("text", "B_C", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(L_C_button, LitDansFichierIni("text", "L_C", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(RALE_button, LitDansFichierIni("text", "RALE", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(SONNE_button, LitDansFichierIni("text", "SONNE", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(JOUE_AIR_button, LitDansFichierIni("text", "JOUE_AIR", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(ALLUME_button, LitDansFichierIni("text", "ALLUME", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(ETEINS_button, LitDansFichierIni("text", "ETEINS", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(ETEINS_G_button, LitDansFichierIni("text", "ETEINS_G", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(ETEINS_D_button, LitDansFichierIni("text", "ETEINS_D", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(CLIGNE_G_button, LitDansFichierIni("text", "CLIGNE_G", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(CLIGNE_D_button, LitDansFichierIni("text", "CLIGNE_D", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(ARC_AVG_5_button, LitDansFichierIni("text", "ARC_AVG_5", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(ARC_AVG_10_button, LitDansFichierIni("text", "ARC_AVG_10", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(ARC_AVG_20_button, LitDansFichierIni("text", "ARC_AVG_20", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(ARC_AVD_5_button, LitDansFichierIni("text", "ARC_AVD_5", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(ARC_AVD_10_button, LitDansFichierIni("text", "ARC_AVD_10", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(ARC_AVD_20_button, LitDansFichierIni("text", "ARC_AVD_20", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		
		ToolTip1.SetToolTip(REGLAGE_button, LitDansFichierIni("text", "REGLAGE", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TEST_button, LitDansFichierIni("text", "TEST", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TOUCHE_AVG_button, LitDansFichierIni("text", "TOUCHE_AVG", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TOUCHE_AVD_button, LitDansFichierIni("text", "TOUCHE_AVD", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TOUCHE_AR_button, LitDansFichierIni("text", "TOUCHE_AR", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TOUCHE_STOP_button, LitDansFichierIni("text", "TOUCHE_STOP", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(DES_QUE_button, LitDansFichierIni("text", "DES_QUE", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(C_EST_button, LitDansFichierIni("text", "C_EST", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(FIN_button, LitDansFichierIni("text", "FIN", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(SUPPRIME_button, LitDansFichierIni("text", "SUPPRIME", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(OUBLIE_button, LitDansFichierIni("text", "OUBLIE", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(APPRENDS_button, LitDansFichierIni("text", "APPRENDS", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(GOMME_button, LitDansFichierIni("text", "GOMME", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(EXECUTE_button, LitDansFichierIni("text", "EXECUTE", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(EXECUTE_P_button, LitDansFichierIni("text", "EXECUTE_P", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(EXECUTE_M_button, LitDansFichierIni("text", "EXECUTE_M", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(TOUT_button, LitDansFichierIni("text", "TOUT", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(ARRET_button, LitDansFichierIni("text", "ARRET", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		
		ToolTip1.SetToolTip(PROCEDURE_N1_button, LitDansFichierIni("text", "PROCEDURE_N1", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N2_button, LitDansFichierIni("text", "PROCEDURE_N2", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N3_button, LitDansFichierIni("text", "PROCEDURE_N3", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N4_button, LitDansFichierIni("text", "PROCEDURE_N4", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N5_button, LitDansFichierIni("text", "PROCEDURE_N5", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N6_button, LitDansFichierIni("text", "PROCEDURE_N6", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N7_button, LitDansFichierIni("text", "PROCEDURE_N7", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N8_button, LitDansFichierIni("text", "PROCEDURE_N8", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N9_button, LitDansFichierIni("text", "PROCEDURE_N9", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N10_button, LitDansFichierIni("text", "PROCEDURE_N10", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N11_button, LitDansFichierIni("text", "PROCEDURE_N11", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N12_button, LitDansFichierIni("text", "PROCEDURE_N12", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N13_button, LitDansFichierIni("text", "PROCEDURE_N13", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N14_button, LitDansFichierIni("text", "PROCEDURE_N14", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N15_button, LitDansFichierIni("text", "PROCEDURE_N15", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N16_button, LitDansFichierIni("text", "PROCEDURE_N16", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N17_button, LitDansFichierIni("text", "PROCEDURE_N17", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N18_button, LitDansFichierIni("text", "PROCEDURE_N18", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N19_button, LitDansFichierIni("text", "PROCEDURE_N19", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N20_button, LitDansFichierIni("text", "PROCEDURE_N20", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N21_button, LitDansFichierIni("text", "PROCEDURE_N21", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N22_button, LitDansFichierIni("text", "PROCEDURE_N22", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N23_button, LitDansFichierIni("text", "PROCEDURE_N23", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N24_button, LitDansFichierIni("text", "PROCEDURE_N24", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N25_button, LitDansFichierIni("text", "PROCEDURE_N25", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N26_button, LitDansFichierIni("text", "PROCEDURE_N26", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N27_button, LitDansFichierIni("text", "PROCEDURE_N27", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N28_button, LitDansFichierIni("text", "PROCEDURE_N28", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N29_button, LitDansFichierIni("text", "PROCEDURE_N29", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N30_button, LitDansFichierIni("text", "PROCEDURE_N30", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N31_button, LitDansFichierIni("text", "PROCEDURE_N31", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N32_button, LitDansFichierIni("text", "PROCEDURE_N32", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N33_button, LitDansFichierIni("text", "PROCEDURE_N33", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N34_button, LitDansFichierIni("text", "PROCEDURE_N34", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N35_button, LitDansFichierIni("text", "PROCEDURE_N35", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		ToolTip1.SetToolTip(PROCEDURE_N36_button, LitDansFichierIni("text", "PROCEDURE_N36", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		
		cardList = New cardListClass
	End Sub
	
	Private Sub Generate_Command_List_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Generate_Command_List.Click
		Dim nbComm As Short
		
		If (imagePath.Text = "") Then
			selectImage()
		End If
		If (imagePath.Text <> "") Then
			nbComm = Generate_Code(lineList, (cardList.listByName))
			Preview.Visible = True
			printAll(lineList)
		End If
	End Sub
	
	Private Sub GOMME_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles GOMME_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("GOMME"))
	End Sub
	
	Private Sub JOUE_AIR_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles JOUE_AIR_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("JOUE_AIR"))
	End Sub
	
	Private Sub L_C_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles L_C_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("L_C"))
	End Sub
	
	Private Sub LoadProgram_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles LoadProgram.Click
		'UPGRADE_NOTE: command was upgraded to command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim command_Renamed As String
		FileOpen(1, programPath.Text, OpenMode.Input)
		command_Renamed = ""
		On Error Resume Next
		Input(1, command_Renamed)
		On Error GoTo 0
		ProgramCommandList.Items.Clear()
		Do While command_Renamed <> ""
			ProgramCommandList.Items.Add((command_Renamed))
			command_Renamed = ""
			On Error Resume Next
			Input(1, command_Renamed)
			On Error GoTo 0
		Loop 
		FileClose(1)
	End Sub
	
	Private Sub MoveCommandDown_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MoveCommandDown.Click
		Dim index As Short
		Dim temp As String
		index = ProgramCommandList.SelectedIndex
		If (index > -1) And (index + 1 < ProgramCommandList.Items.Count) Then
			temp = VB6.GetItemString(ProgramCommandList, index)
			VB6.SetItemString(ProgramCommandList, index, VB6.GetItemString(ProgramCommandList, index + 1))
			VB6.SetItemString(ProgramCommandList, index + 1, temp)
			ProgramCommandList.SelectedIndex = index + 1
		End If
	End Sub
	
	Private Sub MoveCommandUp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MoveCommandUp.Click
		Dim index As Short
		Dim temp As String
		index = ProgramCommandList.SelectedIndex
		If (index > 0) And (index < ProgramCommandList.Items.Count) Then
			temp = VB6.GetItemString(ProgramCommandList, index)
			VB6.SetItemString(ProgramCommandList, index, VB6.GetItemString(ProgramCommandList, index - 1))
			VB6.SetItemString(ProgramCommandList, index - 1, temp)
			ProgramCommandList.SelectedIndex = index - 1
		End If
	End Sub
	
	Private Sub RemoveCommand_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RemoveCommand.Click
		Dim index As Short
		index = ProgramCommandList.SelectedIndex
		If index <> -1 Then
			ProgramCommandList.Items.RemoveAt((index))
			If ProgramCommandList.Items.Count = 0 Then ProgramCommandList.SelectedIndex = -1
			If (index = ProgramCommandList.Items.Count) Then
				ProgramCommandList.SelectedIndex = ProgramCommandList.Items.Count - 1
			Else
				ProgramCommandList.SelectedIndex = index
			End If
		End If
	End Sub
	
	Private Sub SaveProgram_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SaveProgram.Click
		Dim i As Short
		'UPGRADE_NOTE: command was upgraded to command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim command_Renamed As String
		FileOpen(1, programPath.Text, OpenMode.Output)
		For i = 0 To ProgramCommandList.Items.Count - 1
			PrintLine(1, VB6.GetItemString(ProgramCommandList, i))
		Next 
		FileClose(1)
		EcritDansFichierIni("path", "programPath", (programPath.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
	End Sub
	
	Private Sub selectImage_Button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles selectImage_Button.Click
		selectImage()
	End Sub
	
	Private Sub OUBLIE_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OUBLIE_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("OUBLIE"))
	End Sub
	
	Private Sub PROCEDURE_N1_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N1_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N1"))
	End Sub
	
	Private Sub PROCEDURE_N10_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N10_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N10"))
	End Sub
	
	Private Sub PROCEDURE_N11_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N11_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N11"))
	End Sub
	
	Private Sub PROCEDURE_N12_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N12_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N12"))
	End Sub
	
	Private Sub PROCEDURE_N13_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N13_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N13"))
	End Sub
	
	Private Sub PROCEDURE_N14_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N14_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N14"))
	End Sub
	
	Private Sub PROCEDURE_N15_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N15_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N15"))
	End Sub
	
	Private Sub PROCEDURE_N16_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N16_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N16"))
	End Sub
	
	Private Sub PROCEDURE_N17_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N17_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N17"))
	End Sub
	
	Private Sub PROCEDURE_N18_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N18_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N18"))
	End Sub
	
	Private Sub PROCEDURE_N19_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N19_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N19"))
	End Sub
	
	Private Sub PROCEDURE_N2_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N2_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N2"))
	End Sub
	
	Private Sub PROCEDURE_N20_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N20_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N20"))
	End Sub
	
	Private Sub PROCEDURE_N21_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N21_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N21"))
	End Sub
	
	Private Sub PROCEDURE_N22_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N22_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N22"))
	End Sub
	
	Private Sub PROCEDURE_N23_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N23_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N23"))
	End Sub
	
	Private Sub PROCEDURE_N24_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N24_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N24"))
	End Sub
	
	Private Sub PROCEDURE_N25_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N25_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N25"))
	End Sub
	
	Private Sub PROCEDURE_N26_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N26_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N26"))
	End Sub
	
	Private Sub PROCEDURE_N27_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N27_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N27"))
	End Sub
	
	Private Sub PROCEDURE_N28_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N28_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N28"))
	End Sub
	
	Private Sub PROCEDURE_N29_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N29_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N29"))
	End Sub
	
	Private Sub PROCEDURE_N3_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N3_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N3"))
	End Sub
	
	Private Sub PROCEDURE_N30_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N30_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N30"))
	End Sub
	
	Private Sub PROCEDURE_N31_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N31_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N31"))
	End Sub
	
	Private Sub PROCEDURE_N32_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N32_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N32"))
	End Sub
	
	Private Sub PROCEDURE_N33_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N33_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N33"))
	End Sub
	
	Private Sub PROCEDURE_N34_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N34_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N34"))
	End Sub
	
	Private Sub PROCEDURE_N35_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N35_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N35"))
	End Sub
	
	Private Sub PROCEDURE_N36_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N36_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N36"))
	End Sub
	
	Private Sub PROCEDURE_N4_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N4_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N4"))
	End Sub
	
	Private Sub PROCEDURE_N5_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N5_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N5"))
	End Sub
	
	Private Sub PROCEDURE_N6_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N6_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N6"))
	End Sub
	
	Private Sub PROCEDURE_N7_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N7_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N7"))
	End Sub
	
	Private Sub PROCEDURE_N8_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N8_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N8"))
	End Sub
	
	Private Sub PROCEDURE_N9_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N9_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("PROCEDURE_N9"))
	End Sub
	
	Private Sub RALE_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RALE_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("RALE"))
	End Sub
	
	Private Sub RE_1_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RE_1_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("RE_1"))
	End Sub
	
	Private Sub RE_10_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RE_10_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("RE_10"))
	End Sub
	
	Private Sub RE_20_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RE_20_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("RE_20"))
	End Sub
	
	Private Sub REGLAGE_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles REGLAGE_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("REGLAGE"))
	End Sub
	
	Private Sub SelectImageEditorButton_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SelectImageEditorButton.Click
		selectImageEditor()
	End Sub
	
	Private Sub selectProgram_Button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles selectProgram_Button.Click
		selectProgram()
	End Sub
	
	Private Sub SelectProgramEditorButton_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SelectProgramEditorButton.Click
		selectProgramEditor()
	End Sub
	
	Private Sub Send_Image_To_T3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Send_Image_To_T3.Click
		Dim nbComm As Short
		Dim lineList As Collection
		
		If (imagePath.Text = "") Then
			selectImage()
		End If
		If (imagePath.Text <> "") Then
			nbComm = Generate_Code(lineList, (cardList.listByName))
			Line_Send(lineList, nbComm)
		End If
	End Sub
	
	Private Sub Send_Program_Step_Backward_To_T3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Send_Program_Step_Backward_To_T3.Click
		Dim index As Short
		Dim revert As String
		index = ProgramCommandList.SelectedIndex
		If index > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName().revert. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			revert = cardList.listByName.Item(VB6.GetItemString(ProgramCommandList, index - 1)).revert
			'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If revert <> "" Then CommSendSingle(cardList.listByName.Item(revert))
			If index <> 0 Then ProgramCommandList.SelectedIndex = index - 1
		End If
	End Sub
	
	Private Sub Send_Program_Step_Forward_To_T3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Send_Program_Step_Forward_To_T3.Click
		Dim index As Short
		index = ProgramCommandList.SelectedIndex
		If index <> -1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CommSendSingle(cardList.listByName.Item(VB6.GetItemString(ProgramCommandList, index)))
			If index <> ProgramCommandList.Items.Count - 1 Then ProgramCommandList.SelectedIndex = index + 1
		End If
	End Sub
	
	Private Sub Send_Program_To_T3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Send_Program_To_T3.Click
		If ProgramCommandList.Items.Count <> 0 Then program_Send()
	End Sub
	
	'UPGRADE_WARNING: Event Size_Renamed.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Size_Renamed_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Size_Renamed.TextChanged
		EcritDansFichierIni("transformation", "size", (Size_Renamed.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
	End Sub
	
	Private Sub SONNE_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SONNE_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("SONNE"))
	End Sub
	
	Private Sub SUPPRIME_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SUPPRIME_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("SUPPRIME"))
	End Sub
	
	Private Sub TD_1_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_1_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TD_1"))
	End Sub
	
	Private Sub TD_120_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_120_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TD_120"))
	End Sub
	
	Private Sub TD_15_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_15_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TD_15"))
	End Sub
	
	Private Sub TD_30_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_30_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TD_30"))
	End Sub
	
	Private Sub TD_45_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_45_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TD_45"))
	End Sub
	
	Private Sub TD_60_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_60_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TD_60"))
	End Sub
	
	Private Sub TD_90_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_90_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TD_90"))
	End Sub
	
	Private Sub TEST_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TEST_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TEST"))
	End Sub
	
	Private Sub TG_1_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_1_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TG_1"))
	End Sub
	
	Private Sub TG_120_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_120_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TG_120"))
	End Sub
	
	Private Sub TG_15_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_15_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TG_15"))
	End Sub
	
	Private Sub TG_30_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_30_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TG_30"))
	End Sub
	
	Private Sub TG_45_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_45_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TG_45"))
	End Sub
	
	Private Sub TG_60_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_60_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TG_60"))
	End Sub
	
	Private Sub TG_90_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_90_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TG_90"))
	End Sub
	
	Private Sub TOUCHE_AR_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TOUCHE_AR_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TOUCHE_AR"))
	End Sub
	
	Private Sub TOUCHE_AVD_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TOUCHE_AVD_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TOUCHE_AVD"))
	End Sub
	
	Private Sub TOUCHE_AVG_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TOUCHE_AVG_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TOUCHE_AVG"))
	End Sub
	
	Private Sub TOUCHE_STOP_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TOUCHE_STOP_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TOUCHE_STOP"))
	End Sub
	
	Private Sub TOUT_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TOUT_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cardButtonPressed(cardList.listByName.Item("TOUT"))
	End Sub
	
	Public Function selectImageEditor() As Object
		Dim Path As String
		Path = OuvrirUnFichier(Me.Handle.ToInt32, "Select a SVG image editor", 1, "Executable Files", "exe")
		If Path <> "" Then
			imageEditorPath.Text = Path
			EcritDansFichierIni("path", "imageEditorPath", (imageEditorPath.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		End If
	End Function
	
	Public Function selectImage() As Object
		Dim Path As String
		Path = OuvrirUnFichier(Me.Handle.ToInt32, "Select a SVG image", 1, "SVG Files", "svg")
		If Path <> "" Then
			imagePath.Text = Path
			EcritDansFichierIni("path", "imagePath", (imagePath.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		End If
	End Function
	
	Public Function selectProgramEditor() As Object
		Dim Path As String
		Path = OuvrirUnFichier(Me.Handle.ToInt32, "Select a texte editor", 1, "Executable Files", "exe")
		If Path <> "" Then
			programEditorPath.Text = Path
			EcritDansFichierIni("path", "programEditorPath", (programEditorPath.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		End If
	End Function
	
	Public Function selectProgram() As Object
		Dim Path As String
		Path = OuvrirUnFichier(Me.Handle.ToInt32, "Select a program", 1, "T3 program", "t3p")
		If Path <> "" Then
			programPath.Text = Path
			EcritDansFichierIni("path", "programPath", (programPath.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		End If
	End Function
	
	
	Public Function cardButtonPressed(ByRef card As CardClass) As Object
		Dim index As Short
		If (programming.CheckState = 1) Then
			index = ProgramCommandList.SelectedIndex
			If Insert.CheckState = 1 Then
				If index <> -1 Then
					ProgramCommandList.Items.Insert(index, card.name)
				Else
					ProgramCommandList.Items.Add(card.name)
				End If
			Else
				ProgramCommandList.Items.Add(card.name)
			End If
		Else
			CommSendSingle(card)
		End If
	End Function
	
	'UPGRADE_WARNING: Event UseCorrections.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub UseCorrections_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles UseCorrections.CheckStateChanged
		Me.cardList.init()
	End Sub
End Class