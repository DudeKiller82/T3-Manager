Option Strict Off
Option Explicit On
Friend Class Calibration
	Inherits System.Windows.Forms.Form
	Private Sub AV_1_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AV_1_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("AV_1"), CShort(AV_1_Target.Text))
	End Sub
	
	Private Sub AV_10_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AV_10_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("AV_10"), CShort(AV_10_Target.Text))
	End Sub
	
	Private Sub AV_20_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AV_20_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("AV_20"), CShort(AV_20_Target.Text))
	End Sub
	
	Private Sub Calibration_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		AV_1_Target.Text = T3_Manager.cardList.listByName.Item("AV_1").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		AV_10_Target.Text = T3_Manager.cardList.listByName.Item("AV_10").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		AV_20_Target.Text = T3_Manager.cardList.listByName.Item("AV_20").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RE_1_Target.Text = T3_Manager.cardList.listByName.Item("RE_1").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RE_10_Target.Text = T3_Manager.cardList.listByName.Item("RE_10").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RE_20_Target.Text = T3_Manager.cardList.listByName.Item("RE_20").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TG_1_Target.Text = T3_Manager.cardList.listByName.Item("TG_1").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TG_15_Target.Text = T3_Manager.cardList.listByName.Item("TG_15").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TG_30_Target.Text = T3_Manager.cardList.listByName.Item("TG_30").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TG_45_Target.Text = T3_Manager.cardList.listByName.Item("TG_45").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TG_60_Target.Text = T3_Manager.cardList.listByName.Item("TG_60").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TG_90_Target.Text = T3_Manager.cardList.listByName.Item("TG_90").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TG_120_Target.Text = T3_Manager.cardList.listByName.Item("TG_120").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TD_1_Target.Text = T3_Manager.cardList.listByName.Item("TD_1").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TD_15_Target.Text = T3_Manager.cardList.listByName.Item("TD_15").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TD_30_Target.Text = T3_Manager.cardList.listByName.Item("TD_30").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TD_45_Target.Text = T3_Manager.cardList.listByName.Item("TD_45").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TD_60_Target.Text = T3_Manager.cardList.listByName.Item("TD_60").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TD_90_Target.Text = T3_Manager.cardList.listByName.Item("TD_90").target
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().target. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TD_120_Target.Text = T3_Manager.cardList.listByName.Item("TD_120").target
		
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		AV_1_Result.Text = T3_Manager.cardList.listByName.Item("AV_1").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		AV_10_Result.Text = T3_Manager.cardList.listByName.Item("AV_10").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		AV_20_Result.Text = T3_Manager.cardList.listByName.Item("AV_20").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RE_1_Result.Text = T3_Manager.cardList.listByName.Item("RE_1").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RE_10_Result.Text = T3_Manager.cardList.listByName.Item("RE_10").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RE_20_Result.Text = T3_Manager.cardList.listByName.Item("RE_20").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TG_1_Result.Text = T3_Manager.cardList.listByName.Item("TG_1").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TG_15_Result.Text = T3_Manager.cardList.listByName.Item("TG_15").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TG_30_Result.Text = T3_Manager.cardList.listByName.Item("TG_30").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TG_45_Result.Text = T3_Manager.cardList.listByName.Item("TG_45").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TG_60_Result.Text = T3_Manager.cardList.listByName.Item("TG_60").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TG_90_Result.Text = T3_Manager.cardList.listByName.Item("TG_90").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TG_120_Result.Text = T3_Manager.cardList.listByName.Item("TG_120").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TD_1_Result.Text = T3_Manager.cardList.listByName.Item("TD_1").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TD_15_Result.Text = T3_Manager.cardList.listByName.Item("TD_15").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TD_30_Result.Text = T3_Manager.cardList.listByName.Item("TD_30").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TD_45_Result.Text = T3_Manager.cardList.listByName.Item("TD_45").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TD_60_Result.Text = T3_Manager.cardList.listByName.Item("TD_60").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TD_90_Result.Text = T3_Manager.cardList.listByName.Item("TD_90").result
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TD_120_Result.Text = T3_Manager.cardList.listByName.Item("TD_120").result
		T3_Manager.cardList.init()
	End Sub
	
	Private Sub RE_1_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RE_1_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("RE_1"), CShort(RE_1_Target.Text))
	End Sub
	
	Private Sub RE_10_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RE_10_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("RE_10"), CShort(RE_10_Target.Text))
	End Sub
	
	Private Sub RE_20_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RE_20_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("RE_20"), CShort(RE_20_Target.Text))
	End Sub
	
	Private Sub save_Calibrate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles save_Calibrate.Click
		EcritDansFichierIni("target", "AV_1", (AV_1_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "AV_10", (AV_10_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "AV_20", (AV_20_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "RE_1", (RE_1_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "RE_10", (RE_10_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "RE_20", (RE_20_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "TG_1", (TG_1_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "TG_15", (TG_15_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "TG_30", (TG_30_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "TG_45", (TG_45_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "TG_60", (TG_60_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "TG_90", (TG_90_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "TG_120", (TG_120_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "TD_1", (TD_1_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "TD_15", (TD_15_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "TD_30", (TD_30_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "TD_45", (TD_45_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "TD_60", (TD_60_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "TD_90", (TD_90_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("target", "TD_120", (TD_120_Target.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "AV_1", (AV_1_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "AV_10", (AV_10_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "AV_20", (AV_20_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "RE_1", (RE_1_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "RE_10", (RE_10_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "RE_20", (RE_20_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "TG_1", (TG_1_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "TG_15", (TG_15_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "TG_30", (TG_30_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "TG_45", (TG_45_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "TG_60", (TG_60_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "TG_90", (TG_90_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "TG_120", (TG_120_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "TD_1", (TD_1_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "TD_15", (TD_15_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "TD_30", (TD_30_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "TD_45", (TD_45_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "TD_60", (TD_60_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "TD_90", (TD_90_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		EcritDansFichierIni("result", "TD_120", (TD_120_Result.Text), My.Application.Info.DirectoryPath & "\T3 Manager.ini")
		T3_Manager.cardList.init()
	End Sub
	
	Private Sub TD_1_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_1_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("TD_1"), CShort(TD_1_Target.Text))
	End Sub
	
	Private Sub TD_120_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_120_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("TD_120"), CShort(TD_120_Target.Text))
	End Sub
	
	Private Sub TD_15_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_15_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("TD_15"), CShort(TD_15_Target.Text))
	End Sub
	
	Private Sub TD_30_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_30_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("TD_30"), CShort(TD_30_Target.Text))
	End Sub
	
	Private Sub TD_45_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_45_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("TD_45"), CShort(TD_45_Target.Text))
	End Sub
	
	Private Sub TD_60_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_60_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("TD_60"), CShort(TD_60_Target.Text))
	End Sub
	
	Private Sub TD_90_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TD_90_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("TD_90"), CShort(TD_90_Target.Text))
	End Sub
	
	Private Sub TG_1_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_1_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("TG_1"), CShort(TG_1_Target.Text))
	End Sub
	
	Private Sub TG_120_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_120_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("TG_120"), CShort(TG_120_Target.Text))
	End Sub
	
	Private Sub TG_15_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_15_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("TG_15"), CShort(TG_15_Target.Text))
	End Sub
	
	Private Sub TG_30_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_30_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("TG_30"), CShort(TG_30_Target.Text))
	End Sub
	
	Private Sub TG_45_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_45_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("TG_45"), CShort(TG_45_Target.Text))
	End Sub
	
	Private Sub TG_60_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_60_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("TG_60"), CShort(TG_60_Target.Text))
	End Sub
	
	Private Sub TG_90_button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TG_90_button.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Test_Send(T3_Manager.cardList.listByName.Item("TG_90"), CShort(TG_90_Target.Text))
	End Sub
End Class