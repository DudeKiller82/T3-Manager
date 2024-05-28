Option Strict Off
Option Explicit On
Friend Class Scrolling_Mod_Configuration
	Inherits System.Windows.Forms.Form
	'UPGRADE_WARNING: Event ALLUME_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ALLUME_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ALLUME_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ALLUME_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ALLUME_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ALLUME_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event APPRENDS_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub APPRENDS_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles APPRENDS_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event APPRENDS_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub APPRENDS_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles APPRENDS_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ARC_AVD_10_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ARC_AVD_10_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARC_AVD_10_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ARC_AVD_10_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ARC_AVD_10_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARC_AVD_10_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ARC_AVD_20_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ARC_AVD_20_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARC_AVD_20_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ARC_AVD_20_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ARC_AVD_20_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARC_AVD_20_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ARC_AVD_5_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ARC_AVD_5_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARC_AVD_5_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ARC_AVD_5_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ARC_AVD_5_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARC_AVD_5_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ARC_AVG_10_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ARC_AVG_10_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARC_AVG_10_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ARC_AVG_10_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ARC_AVG_10_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARC_AVG_10_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ARC_AVG_20_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ARC_AVG_20_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARC_AVG_20_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ARC_AVG_20_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ARC_AVG_20_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARC_AVG_20_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ARC_AVG_5_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ARC_AVG_5_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARC_AVG_5_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ARC_AVG_5_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ARC_AVG_5_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARC_AVG_5_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ARRET_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ARRET_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARRET_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ARRET_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ARRET_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ARRET_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event Auto_Return.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Auto_Return_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Auto_Return.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event AV_1_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub AV_1_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AV_1_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event AV_1_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub AV_1_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AV_1_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event AV_10_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub AV_10_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AV_10_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event AV_10_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub AV_10_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AV_10_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event AV_20_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub AV_20_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AV_20_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event AV_20_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub AV_20_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AV_20_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event B_C_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub B_C_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles B_C_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event B_C_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub B_C_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles B_C_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event C_EST_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub C_EST_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles C_EST_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	Private Sub CLIGN_D_check_Click()
		save_scrollConfiguration()
	End Sub
	
	Private Sub CLIGN_G_check_Click()
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event C_EST_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub C_EST_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles C_EST_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event CLIGNE_D_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub CLIGNE_D_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CLIGNE_D_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event CLIGNE_D_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub CLIGNE_D_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CLIGNE_D_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event CLIGNE_G_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub CLIGNE_G_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CLIGNE_G_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event CLIGNE_G_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub CLIGNE_G_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CLIGNE_G_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event confirm_mod.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub confirm_mod_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles confirm_mod.SelectedIndexChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event confirm_time.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub confirm_time_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles confirm_time.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event DES_QUE_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub DES_QUE_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DES_QUE_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event DES_QUE_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub DES_QUE_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DES_QUE_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ETEINS_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ETEINS_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ETEINS_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ETEINS_D_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ETEINS_D_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ETEINS_D_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ETEINS_D_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ETEINS_D_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ETEINS_D_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ETEINS_G_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ETEINS_G_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ETEINS_G_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ETEINS_G_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ETEINS_G_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ETEINS_G_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event ETEINS_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ETEINS_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ETEINS_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event EXECUTE_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub EXECUTE_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles EXECUTE_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event EXECUTE_M_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub EXECUTE_M_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles EXECUTE_M_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event EXECUTE_M_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub EXECUTE_M_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles EXECUTE_M_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event EXECUTE_P_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub EXECUTE_P_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles EXECUTE_P_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	Private Sub FINcheck_Click()
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event EXECUTE_P_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub EXECUTE_P_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles EXECUTE_P_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event EXECUTE_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub EXECUTE_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles EXECUTE_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event FIN_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub FIN_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles FIN_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event FIN_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub FIN_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles FIN_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	Private Sub Scrolling_Mod_Configuration_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Scrolling_Mod.load_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event GOMME_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub GOMME_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles GOMME_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event GOMME_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub GOMME_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles GOMME_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event JOUE_AIR_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub JOUE_AIR_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles JOUE_AIR_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event JOUE_AIR_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub JOUE_AIR_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles JOUE_AIR_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event L_C_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub L_C_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles L_C_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event L_C_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub L_C_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles L_C_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event OUBLIE_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub OUBLIE_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OUBLIE_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event OUBLIE_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub OUBLIE_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OUBLIE_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N1_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N1_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N1_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N1_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N1_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N1_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N10_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N10_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N10_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N10_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N10_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N10_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N11_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N11_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N11_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N11_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N11_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N11_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N12_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N12_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N12_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N12_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N12_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N12_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N13_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N13_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N13_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N13_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N13_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N13_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N14_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N14_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N14_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N14_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N14_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N14_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N15_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N15_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N15_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N15_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N15_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N15_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N16_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N16_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N16_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N16_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N16_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N16_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N17_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N17_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N17_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N17_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N17_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N17_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N18_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N18_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N18_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N18_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N18_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N18_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N19_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N19_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N19_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N19_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N19_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N19_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N2_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N2_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N2_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N2_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N2_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N2_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N20_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N20_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N20_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N20_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N20_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N20_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N21_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N21_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N21_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N21_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N21_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N21_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N22_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N22_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N22_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N22_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N22_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N22_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N23_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N23_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N23_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N23_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N23_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N23_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N24_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N24_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N24_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N24_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N24_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N24_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N25_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N25_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N25_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N25_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N25_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N25_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N26_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N26_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N26_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N26_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N26_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N26_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N27_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N27_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N27_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N27_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N27_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N27_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N28_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N28_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N28_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N28_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N28_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N28_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N29_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N29_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N29_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N29_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N29_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N29_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N3_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N3_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N3_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N3_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N3_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N3_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N30_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N30_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N30_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N30_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N30_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N30_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N31_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N31_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N31_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N31_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N31_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N31_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N32_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N32_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N32_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N32_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N32_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N32_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N33_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N33_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N33_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N33_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N33_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N33_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N34_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N34_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N34_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N34_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N34_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N34_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N35_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N35_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N35_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N35_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N35_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N35_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N36_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N36_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N36_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N36_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N36_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N36_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N4_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N4_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N4_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N4_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N4_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N4_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N5_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N5_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N5_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N5_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N5_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N5_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N6_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N6_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N6_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N6_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N6_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N6_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N7_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N7_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N7_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N7_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N7_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N7_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N8_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N8_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N8_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N8_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N8_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N8_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N9_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N9_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N9_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event PROCEDURE_N9_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub PROCEDURE_N9_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PROCEDURE_N9_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event RALE_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub RALE_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RALE_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event RALE_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub RALE_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RALE_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event RE_1_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub RE_1_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RE_1_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event RE_1_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub RE_1_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RE_1_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event RE_10_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub RE_10_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RE_10_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event RE_10_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub RE_10_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RE_10_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event RE_20_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub RE_20_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RE_20_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event RE_20_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub RE_20_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RE_20_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event REGLAGE_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub REGLAGE_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles REGLAGE_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event REGLAGE_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub REGLAGE_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles REGLAGE_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event scroll_time.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub scroll_time_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles scroll_time.TextChanged
		save_scrollConfiguration()
		If scroll_time.Text <> "" Then
			'UPGRADE_WARNING: Timer property Scroll_Timer.Interval cannot have a value of 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="169ECF4A-1968-402D-B243-16603CC08604"'
			Scrolling_Mod.Scroll_Timer.Interval = CShort(scroll_time.Text)
		End If
	End Sub
	
	Public Function save_scrollConfiguration() As Object
		If Not Scrolling_Mod.loading = 1 Then
			EcritDansFichierIni("scrolling", "AV_1", CStr(AV_1_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "AV_10", CStr(AV_10_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "AV_20", CStr(AV_20_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "RE_1", CStr(RE_1_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "RE_10", CStr(RE_10_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "RE_20", CStr(RE_20_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TG_1", CStr(TG_1_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TG_15", CStr(TG_15_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TG_30", CStr(TG_30_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TG_45", CStr(TG_45_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TG_60", CStr(TG_60_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TG_90", CStr(TG_90_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TG_120", CStr(TG_120_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TD_1", CStr(TD_1_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TD_15", CStr(TD_15_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TD_30", CStr(TD_30_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TD_45", CStr(TD_45_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TD_60", CStr(TD_60_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TD_90", CStr(TD_90_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TD_120", CStr(TD_120_Check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			
			EcritDansFichierIni("scrolling", "B_C", CStr(B_C_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "L_C", CStr(L_C_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "RALE", CStr(RALE_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "SONNE", CStr(SONNE_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "JOUE_AIR", CStr(JOUE_AIR_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "ALLUME", CStr(ALLUME_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "ETEINS", CStr(ETEINS_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "ETEINS_G", CStr(ETEINS_G_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "ETEINS_D", CStr(ETEINS_D_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "CLIGNE_G", CStr(CLIGNE_G_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "CLIGNE_D", CStr(CLIGNE_D_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "ARC_AVG_5", CStr(ARC_AVG_5_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "ARC_AVG_10", CStr(ARC_AVG_10_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "ARC_AVG_20", CStr(ARC_AVG_20_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "ARC_AVD_5", CStr(ARC_AVD_5_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "ARC_AVD_10", CStr(ARC_AVD_10_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "ARC_AVD_20", CStr(ARC_AVD_20_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			
			EcritDansFichierIni("scrolling", "REGLAGE", CStr(REGLAGE_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TEST", CStr(TEST_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TOUCHE_AVG", CStr(TOUCHE_AVG_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TOUCHE_AVD", CStr(TOUCHE_AVD_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TOUCHE_AR", CStr(TOUCHE_AR_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TOUCHE_STOP", CStr(TOUCHE_STOP_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "DES_QUE", CStr(DES_QUE_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "C_EST", CStr(C_EST_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "FIN", CStr(FIN_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "SUPPRIME", CStr(SUPPRIME_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "OUBLIE", CStr(OUBLIE_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "APPRENDS", CStr(APPRENDS_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "GOMME", CStr(GOMME_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "EXECUTE", CStr(EXECUTE_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "EXECUTE_P", CStr(EXECUTE_P_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "EXECUTE_M", CStr(EXECUTE_M_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "TOUT", CStr(TOUT_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "ARRET", CStr(ARRET_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			
			EcritDansFichierIni("scrolling", "PROCEDURE_N1", CStr(PROCEDURE_N1_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N2", CStr(PROCEDURE_N2_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N3", CStr(PROCEDURE_N3_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N4", CStr(PROCEDURE_N4_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N5", CStr(PROCEDURE_N5_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N6", CStr(PROCEDURE_N6_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N7", CStr(PROCEDURE_N7_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N8", CStr(PROCEDURE_N8_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N9", CStr(PROCEDURE_N9_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N10", CStr(PROCEDURE_N10_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N11", CStr(PROCEDURE_N11_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N12", CStr(PROCEDURE_N12_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N13", CStr(PROCEDURE_N13_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N14", CStr(PROCEDURE_N14_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N15", CStr(PROCEDURE_N15_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N16", CStr(PROCEDURE_N16_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N17", CStr(PROCEDURE_N17_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N18", CStr(PROCEDURE_N18_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N19", CStr(PROCEDURE_N19_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N20", CStr(PROCEDURE_N20_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N21", CStr(PROCEDURE_N21_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N22", CStr(PROCEDURE_N22_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N23", CStr(PROCEDURE_N23_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N24", CStr(PROCEDURE_N24_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N25", CStr(PROCEDURE_N25_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N26", CStr(PROCEDURE_N26_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N27", CStr(PROCEDURE_N27_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N28", CStr(PROCEDURE_N28_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N29", CStr(PROCEDURE_N29_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N30", CStr(PROCEDURE_N30_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N31", CStr(PROCEDURE_N31_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N32", CStr(PROCEDURE_N32_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N33", CStr(PROCEDURE_N33_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N34", CStr(PROCEDURE_N34_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N35", CStr(PROCEDURE_N35_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scrolling", "PROCEDURE_N36", CStr(PROCEDURE_N36_check.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			
			EcritDansFichierIni("category", "AV_1", (AV_1_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "AV_10", (AV_10_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "AV_20", (AV_20_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "RE_1", (RE_1_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "RE_10", (RE_10_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "RE_20", (RE_20_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TG_1", (TG_1_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TG_15", (TG_15_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TG_30", (TG_30_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TG_45", (TG_45_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TG_60", (TG_60_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TG_90", (TG_90_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TG_120", (TG_120_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TD_1", (TD_1_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TD_15", (TD_15_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TD_30", (TD_30_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TD_45", (TD_45_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TD_60", (TD_60_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TD_90", (TD_90_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TD_120", (TD_120_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			
			EcritDansFichierIni("category", "B_C", (B_C_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "L_C", (L_C_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "RALE", (RALE_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "SONNE", (SONNE_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "JOUE_AIR", (JOUE_AIR_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "ALLUME", (ALLUME_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "ETEINS", (ETEINS_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "ETEINS_G", (ETEINS_G_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "ETEINS_D", (ETEINS_D_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "CLIGNE_G", (CLIGNE_G_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "CLIGNE_D", (CLIGNE_D_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "ARC_AVG_5", (ARC_AVG_5_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "ARC_AVG_10", (ARC_AVG_10_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "ARC_AVG_20", (ARC_AVG_20_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "ARC_AVD_5", (ARC_AVD_5_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "ARC_AVD_10", (ARC_AVD_10_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "ARC_AVD_20", (ARC_AVD_20_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			
			EcritDansFichierIni("category", "REGLAGE", (REGLAGE_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TEST", (TEST_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TOUCHE_AVG", (TOUCHE_AVG_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TOUCHE_AVD", (TOUCHE_AVD_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TOUCHE_AR", (TOUCHE_AR_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TOUCHE_STOP", (TOUCHE_STOP_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "DES_QUE", (DES_QUE_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "C_EST", (C_EST_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "FIN", (FIN_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "SUPPRIME", (SUPPRIME_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "OUBLIE", (OUBLIE_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "APPRENDS", (APPRENDS_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "GOMME", (GOMME_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "EXECUTE", (EXECUTE_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "EXECUTE_P", (EXECUTE_P_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "EXECUTE_M", (EXECUTE_M_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "TOUT", (Tout_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "ARRET", (ARRET_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			
			EcritDansFichierIni("category", "PROCEDURE_N1", (PROCEDURE_N1_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N2", (PROCEDURE_N2_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N3", (PROCEDURE_N3_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N4", (PROCEDURE_N4_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N5", (PROCEDURE_N5_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N6", (PROCEDURE_N6_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N7", (PROCEDURE_N7_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N8", (PROCEDURE_N8_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N9", (PROCEDURE_N9_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N10", (PROCEDURE_N10_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N11", (PROCEDURE_N11_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N12", (PROCEDURE_N12_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N13", (PROCEDURE_N13_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N14", (PROCEDURE_N14_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N15", (PROCEDURE_N15_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N16", (PROCEDURE_N16_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N17", (PROCEDURE_N17_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N18", (PROCEDURE_N18_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N19", (PROCEDURE_N19_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N20", (PROCEDURE_N20_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N21", (PROCEDURE_N21_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N22", (PROCEDURE_N22_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N23", (PROCEDURE_N23_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N24", (PROCEDURE_N24_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N25", (PROCEDURE_N25_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N26", (PROCEDURE_N26_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N27", (PROCEDURE_N27_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N28", (PROCEDURE_N28_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N29", (PROCEDURE_N29_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N30", (PROCEDURE_N30_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N31", (PROCEDURE_N31_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N32", (PROCEDURE_N32_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N33", (PROCEDURE_N33_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N34", (PROCEDURE_N34_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N35", (PROCEDURE_N35_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("category", "PROCEDURE_N36", (PROCEDURE_N36_Text.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			
			EcritDansFichierIni("scroll", "useCategory", CStr(Use_Category.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scroll", "autoReturn", CStr(Auto_Return.CheckState), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scroll", "scrollingTime", (scroll_time.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scroll", "soundMod", (sound_mod.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scroll", "confirmTime", (confirm_time.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			EcritDansFichierIni("scroll", "confirmMod", (confirm_mod.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
			
			
			T3_Manager.cardList.init()
			Scrolling_Mod.load_scrollConfiguration()
		End If
	End Function
	
	'UPGRADE_WARNING: Event SONNE_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub SONNE_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SONNE_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	Private Sub SUPPRIME_P_check_Click()
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event SONNE_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub SONNE_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SONNE_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event sound_mod.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub sound_mod_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles sound_mod.SelectedIndexChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event SUPPRIME_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub SUPPRIME_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SUPPRIME_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TD_1_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TD_1_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_1_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TD_1_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TD_1_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_1_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TD_120_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TD_120_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_120_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TD_120_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TD_120_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_120_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TD_15_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TD_15_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_15_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TD_15_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TD_15_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_15_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TD_30_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TD_30_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_30_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TD_30_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TD_30_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_30_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TD_45_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TD_45_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_45_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TD_45_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TD_45_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_45_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TD_60_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TD_60_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_60_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TD_60_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TD_60_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_60_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TD_90_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TD_90_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_90_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TD_90_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TD_90_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_90_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TEST_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TEST_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TEST_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TEST_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TEST_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TEST_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TG_1_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TG_1_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_1_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TG_1_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TG_1_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_1_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TG_120_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TG_120_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_120_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TG_120_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TG_120_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_120_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TG_15_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TG_15_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_15_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TG_15_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TG_15_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_15_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TG_30_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TG_30_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_30_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TG_30_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TG_30_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_30_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TG_45_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TG_45_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_45_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TG_45_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TG_45_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_45_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TG_60_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TG_60_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_60_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TG_60_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TG_60_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_60_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TG_90_Check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TG_90_Check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_90_Check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TG_90_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TG_90_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_90_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TOUCHE_AR_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TOUCHE_AR_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TOUCHE_AR_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TOUCHE_AR_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TOUCHE_AR_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TOUCHE_AR_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TOUCHE_AVD_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TOUCHE_AVD_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TOUCHE_AVD_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TOUCHE_AVD_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TOUCHE_AVD_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TOUCHE_AVD_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TOUCHE_AVG_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TOUCHE_AVG_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TOUCHE_AVG_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TOUCHE_AVG_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TOUCHE_AVG_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TOUCHE_AVG_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TOUCHE_STOP_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TOUCHE_STOP_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TOUCHE_STOP_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TOUCHE_STOP_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TOUCHE_STOP_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TOUCHE_STOP_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event TOUT_check.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TOUT_check_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TOUT_check.CheckStateChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event Tout_Text.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Tout_Text_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Tout_Text.TextChanged
		save_scrollConfiguration()
	End Sub
	
	'UPGRADE_WARNING: Event Use_Category.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Use_Category_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Use_Category.CheckStateChanged
		save_scrollConfiguration()
	End Sub
End Class