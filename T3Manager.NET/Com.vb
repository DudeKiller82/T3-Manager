Option Strict Off
Option Explicit On
Module Com
	Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)
	
	Public Function Line_Send(ByRef lineList As Collection, ByRef nbCommand As Short) As Object
		Dim line As LineClass
		Dim card As CardClass
		Dim nbCommandSent As Short
		
		T3_Manager.Enabled = False
		T3_Manager.ProgressBarSend.Maximum = nbCommand
		nbCommandSent = 0
		T3_Manager.ProgressBarSend.Value = nbCommandSent
		T3_Manager.ProgressBarSend.Visible = True
		T3_Manager.LabelProgress.Visible = True
		
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.MSComm1.CommPort. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3_Manager.MSComm1.CommPort = T3_Manager.Com_Number.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.MSComm1.Settings. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3_Manager.MSComm1.Settings = T3_Manager.Combo_Com_Setting.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.MSComm1.PortOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3_Manager.MSComm1.PortOpen = True
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CommSend(T3_Manager.cardList.listByName.Item("OUBLIE"))
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().runningTime. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Sleep(T3_Manager.cardList.listByName.Item("OUBLIE").runningTime)
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CommSend(T3_Manager.cardList.listByName.Item("APPRENDS"))
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item().runningTime. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Sleep(T3_Manager.cardList.listByName.Item("APPRENDS").runningTime)
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CommSend(T3_Manager.cardList.listByName.Item("L_C"))
		For	Each line In lineList
			If line.ignored <> True Then
				For	Each card In line.command_card_list
					nbCommandSent = nbCommandSent + 1
					T3_Manager.LabelProgress.Text = "Sending command " & nbCommandSent & "/" & nbCommand & " : " & card.text
					T3_Manager.Refresh()
					T3_Manager.ProgressBarSend.Value = nbCommandSent
					T3_Manager.Refresh()
					CommSend(card)
				Next card
			End If
		Next line
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CommSend(T3_Manager.cardList.listByName.Item("L_C"))
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.MSComm1.PortOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3_Manager.MSComm1.PortOpen = False
		T3_Manager.ProgressBarSend.Visible = False
		T3_Manager.LabelProgress.Visible = False
		T3_Manager.Enabled = True
	End Function
	
	
	Public Function program_Send() As Object
		Dim learning As Boolean
		Dim affecting As Boolean
		Dim deleting As Boolean
		Dim i As Short
		Dim nbCommandSent As Short
		Dim commandName As String
		
		T3_Manager.Enabled = False
		T3_Manager.ProgressBarSend.Maximum = T3_Manager.ProgramCommandList.Items.Count
		nbCommandSent = 0
		T3_Manager.ProgressBarSend.Value = nbCommandSent
		T3_Manager.ProgressBarSend.Visible = True
		T3_Manager.LabelProgress.Visible = True
		
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.MSComm1.CommPort. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3_Manager.MSComm1.CommPort = T3_Manager.Com_Number.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.MSComm1.Settings. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3_Manager.MSComm1.Settings = T3_Manager.Combo_Com_Setting.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.MSComm1.PortOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3_Manager.MSComm1.PortOpen = True
		learning = False
		affecting = False
		deleting = False
		For i = 0 To T3_Manager.ProgramCommandList.Items.Count - 1
			nbCommandSent = nbCommandSent + 1
			T3_Manager.ProgramCommandList.SelectedIndex = i
			commandName = VB6.GetItemString(T3_Manager.ProgramCommandList, i)
			'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName().text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			T3_Manager.LabelProgress.Text = "Sending command " & nbCommandSent & "/" & T3_Manager.ProgramCommandList.Items.Count & " : " & T3_Manager.cardList.listByName.Item(commandName).text
			T3_Manager.Refresh()
			T3_Manager.ProgressBarSend.Value = nbCommandSent
			T3_Manager.Refresh()
			'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CommSend(T3_Manager.cardList.listByName.Item(commandName))
			If commandName = "APPRENDS" Then learning = True
			If commandName = "OUBLIE" Then learning = False
			If commandName = "SUPPRIME" Then deleting = True
			If commandName = "C_EST" Then
				affecting = True
				learning = False
			End If
			If commandName = "EXECUTE" Or commandName = "EXECUTE_P" Or commandName = "EXECUTE_M" Then
				MsgBox("Wait for the T3 to finish the ""EXECUTE"" command and then clic ""OK""")
			Else
				If learning = True Then
				Else
					If commandName = "PROCEDURE_N1" Or commandName = "PROCEDURE_N2" Or commandName = "PROCEDURE_N3" Or commandName = "PROCEDURE_N4" Or commandName = "PROCEDURE_N5" Or commandName = "PROCEDURE_N6" Or commandName = "PROCEDURE_N7" Or commandName = "PROCEDURE_N8" Or commandName = "PROCEDURE_N9" Or commandName = "PROCEDURE_N10" Or commandName = "PROCEDURE_N11" Or commandName = "PROCEDURE_N12" Or commandName = "PROCEDURE_N13" Or commandName = "PROCEDURE_N14" Or commandName = "PROCEDURE_N15" Or commandName = "PROCEDURE_N16" Or commandName = "PROCEDURE_N17" Or commandName = "PROCEDURE_N18" Or commandName = "PROCEDURE_N19" Or commandName = "PROCEDURE_N20" Or commandName = "PROCEDURE_N21" Or commandName = "PROCEDURE_N22" Or commandName = "PROCEDURE_N23" Or commandName = "PROCEDURE_N24" Or commandName = "PROCEDURE_N25" Or commandName = "PROCEDURE_N26" Or commandName = "PROCEDURE_N27" Or commandName = "PROCEDURE_N28" Or commandName = "PROCEDURE_N29" Or commandName = "PROCEDURE_N30" Or commandName = "PROCEDURE_N31" Or commandName = "PROCEDURE_N32" Or commandName = "PROCEDURE_N33" Or commandName = "PROCEDURE_N34" Or commandName = "PROCEDURE_N35" Or commandName = "PROCEDURE_N36" Then
						If deleting = True Then
							deleting = False
							'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName().runningTime. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							Sleep(T3_Manager.cardList.listByName.Item(commandName).runningTime)
						Else
							If affecting = True Then
								affecting = False
								'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName().runningTime. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
								Sleep(T3_Manager.cardList.listByName.Item(commandName).runningTime)
							Else
								MsgBox("Wait for the T3 to finish the ""PROCEDURE_Nx"" command and then clic ""OK""")
							End If
						End If
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName(commandName).runningTime. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName().runningTime. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If T3_Manager.cardList.listByName.Item(commandName).runningTime <> -1 Then Sleep(T3_Manager.cardList.listByName.Item(commandName).runningTime)
					End If
				End If
			End If
		Next 
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.MSComm1.PortOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3_Manager.MSComm1.PortOpen = False
		T3_Manager.ProgressBarSend.Visible = False
		T3_Manager.LabelProgress.Visible = False
		T3_Manager.Enabled = True
	End Function
	
	Public Function Test_Send(ByRef card As CardClass, ByRef target As Short) As Object
		Dim i As Object
		Dim nbCommandToSend As Short
		
		T3_Manager.Enabled = False
		Calibration.Enabled = False
		Calibration.ProgressBarSend.Visible = True
		Calibration.LabelProgress.Visible = True
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.MSComm1.CommPort. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3_Manager.MSComm1.CommPort = T3_Manager.Com_Number.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.MSComm1.Settings. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3_Manager.MSComm1.Settings = T3_Manager.Combo_Com_Setting.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.MSComm1.PortOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3_Manager.MSComm1.PortOpen = True
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CommSend(T3_Manager.cardList.listByName.Item("OUBLIE"))
		Sleep(500)
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CommSend(T3_Manager.cardList.listByName.Item("APPRENDS"))
		Sleep(500)
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CommSend(T3_Manager.cardList.listByName.Item("B_C"))
		If card.isRotation = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CommSend(T3_Manager.cardList.listByName.Item("RE_10"))
		End If
		If card.isTranslation = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CommSend(T3_Manager.cardList.listByName.Item("AV_1"))
			'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CommSend(T3_Manager.cardList.listByName.Item("L_C"))
		End If
		nbCommandToSend = target / card.value
		For i = 1 To nbCommandToSend
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Calibration.LabelProgress.Text = "Sending command " & i + 1 & "/" & nbCommandToSend & " : " & card.text
			Calibration.Refresh()
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Calibration.ProgressBarSend.Value = 100 * (i / nbCommandToSend)
			Calibration.Refresh()
			CommSend(card)
		Next 
		If card.isRotation = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CommSend(T3_Manager.cardList.listByName.Item("AV_20"))
		End If
		If card.isTranslation = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CommSend(T3_Manager.cardList.listByName.Item("B_C"))
			'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CommSend(T3_Manager.cardList.listByName.Item("AV_1"))
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CommSend(T3_Manager.cardList.listByName.Item("L_C"))
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.cardList.listByName.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CommSend(T3_Manager.cardList.listByName.Item("EXECUTE"))
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.MSComm1.PortOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3_Manager.MSComm1.PortOpen = False
		Calibration.ProgressBarSend.Visible = False
		Calibration.LabelProgress.Visible = False
		T3_Manager.Enabled = True
		Calibration.Enabled = True
	End Function
	
	Public Function CommSendSingle(ByRef card As CardClass) As Object
		T3_Manager.Enabled = False
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.MSComm1.PortOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3_Manager.MSComm1.PortOpen = True
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.MSComm1.output. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3_Manager.MSComm1.output = Chr(card.code)
		If card.runningTime > 0 Then
			Sleep(card.runningTime)
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.MSComm1.PortOpen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3_Manager.MSComm1.PortOpen = False
		T3_Manager.Enabled = True
	End Function
	
	Public Function CommSend(ByRef card As CardClass) As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object T3_Manager.MSComm1.output. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		T3_Manager.MSComm1.output = Chr(card.code)
		Sleep(100)
	End Function
End Module