Attribute VB_Name = "Com"
Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

Public Function Line_Send(lineList As Collection, nbCommand As Integer)
    Dim line As LineClass
    Dim card As CardClass
    Dim nbCommandSent As Integer
    
    T3_Manager.Enabled = False
    T3_Manager.ProgressBarSend.Max = nbCommand
    nbCommandSent = 0
    T3_Manager.ProgressBarSend.value = nbCommandSent
    T3_Manager.ProgressBarSend.Visible = True
    T3_Manager.LabelProgress.Visible = True
    
    T3_Manager.MSComm1.CommPort = T3_Manager.Com_Number.text
    T3_Manager.MSComm1.Settings = T3_Manager.Combo_Com_Setting.text
    T3_Manager.MSComm1.PortOpen = True
    CommSend T3_Manager.cardList.listByName.Item("OUBLIE")
    Sleep T3_Manager.cardList.listByName.Item("OUBLIE").runningTime
    CommSend T3_Manager.cardList.listByName.Item("APPRENDS")
    Sleep T3_Manager.cardList.listByName.Item("APPRENDS").runningTime
    CommSend T3_Manager.cardList.listByName.Item("L_C")
    For Each line In lineList
        If line.ignored <> True Then
            For Each card In line.command_card_list
                nbCommandSent = nbCommandSent + 1
                T3_Manager.LabelProgress.Caption = "Sending command " & nbCommandSent & "/" & nbCommand & " : " & card.text
                T3_Manager.Refresh
                T3_Manager.ProgressBarSend.value = nbCommandSent
                T3_Manager.Refresh
                CommSend card
            Next
        End If
    Next
    CommSend T3_Manager.cardList.listByName.Item("L_C")
    T3_Manager.MSComm1.PortOpen = False
    T3_Manager.ProgressBarSend.Visible = False
    T3_Manager.LabelProgress.Visible = False
    T3_Manager.Enabled = True
End Function

    
Public Function program_Send()
    Dim learning As Boolean
    Dim affecting As Boolean
    Dim deleting As Boolean
    Dim i As Integer
    Dim nbCommandSent As Integer
    Dim commandName As String
    
    T3_Manager.Enabled = False
    T3_Manager.ProgressBarSend.Max = T3_Manager.ProgramCommandList.ListCount
    nbCommandSent = 0
    T3_Manager.ProgressBarSend.value = nbCommandSent
    T3_Manager.ProgressBarSend.Visible = True
    T3_Manager.LabelProgress.Visible = True
    
    T3_Manager.MSComm1.CommPort = T3_Manager.Com_Number.text
    T3_Manager.MSComm1.Settings = T3_Manager.Combo_Com_Setting.text
    T3_Manager.MSComm1.PortOpen = True
    learning = False
    affecting = False
    deleting = False
    For i = 0 To T3_Manager.ProgramCommandList.ListCount - 1
        nbCommandSent = nbCommandSent + 1
        T3_Manager.ProgramCommandList.ListIndex = i
        commandName = T3_Manager.ProgramCommandList.list(i)
        T3_Manager.LabelProgress.Caption = "Sending command " & nbCommandSent & "/" & T3_Manager.ProgramCommandList.ListCount & " : " & T3_Manager.cardList.listByName(commandName).text
        T3_Manager.Refresh
        T3_Manager.ProgressBarSend.value = nbCommandSent
        T3_Manager.Refresh
        CommSend T3_Manager.cardList.listByName(commandName)
        If commandName = "APPRENDS" Then learning = True
        If commandName = "OUBLIE" Then learning = False
        If commandName = "SUPPRIME" Then deleting = True
        If commandName = "C_EST" Then
            affecting = True
            learning = False
        End If
        If commandName = "EXECUTE" Or commandName = "EXECUTE_P" Or commandName = "EXECUTE_M" Then
            MsgBox "Wait for the T3 to finish the ""EXECUTE"" command and then clic ""OK"""
        Else
            If learning = True Then
            Else
                If commandName = "PROCEDURE_N1" Or commandName = "PROCEDURE_N2" Or commandName = "PROCEDURE_N3" Or commandName = "PROCEDURE_N4" Or commandName = "PROCEDURE_N5" _
                Or commandName = "PROCEDURE_N6" Or commandName = "PROCEDURE_N7" Or commandName = "PROCEDURE_N8" Or commandName = "PROCEDURE_N9" Or commandName = "PROCEDURE_N10" _
                Or commandName = "PROCEDURE_N11" Or commandName = "PROCEDURE_N12" Or commandName = "PROCEDURE_N13" Or commandName = "PROCEDURE_N14" Or commandName = "PROCEDURE_N15" _
                Or commandName = "PROCEDURE_N16" Or commandName = "PROCEDURE_N17" Or commandName = "PROCEDURE_N18" Or commandName = "PROCEDURE_N19" Or commandName = "PROCEDURE_N20" _
                Or commandName = "PROCEDURE_N21" Or commandName = "PROCEDURE_N22" Or commandName = "PROCEDURE_N23" Or commandName = "PROCEDURE_N24" Or commandName = "PROCEDURE_N25" _
                Or commandName = "PROCEDURE_N26" Or commandName = "PROCEDURE_N27" Or commandName = "PROCEDURE_N28" Or commandName = "PROCEDURE_N29" Or commandName = "PROCEDURE_N30" _
                Or commandName = "PROCEDURE_N31" Or commandName = "PROCEDURE_N32" Or commandName = "PROCEDURE_N33" Or commandName = "PROCEDURE_N34" Or commandName = "PROCEDURE_N35" _
                Or commandName = "PROCEDURE_N36" Then
                    If deleting = True Then
                        deleting = False
                        Sleep T3_Manager.cardList.listByName(commandName).runningTime
                    Else
                        If affecting = True Then
                            affecting = False
                            Sleep T3_Manager.cardList.listByName(commandName).runningTime
                        Else
                            MsgBox "Wait for the T3 to finish the ""PROCEDURE_Nx"" command and then clic ""OK"""
                        End If
                    End If
                Else
                    If T3_Manager.cardList.listByName(commandName).runningTime <> -1 Then Sleep T3_Manager.cardList.listByName(commandName).runningTime
                End If
            End If
        End If
    Next
    T3_Manager.MSComm1.PortOpen = False
    T3_Manager.ProgressBarSend.Visible = False
    T3_Manager.LabelProgress.Visible = False
    T3_Manager.Enabled = True
End Function

Public Function Test_Send(card As CardClass, target As Integer)
    Dim nbCommandToSend As Integer
    
    T3_Manager.Enabled = False
    Calibration.Enabled = False
    Calibration.ProgressBarSend.Visible = True
    Calibration.LabelProgress.Visible = True
    T3_Manager.MSComm1.CommPort = T3_Manager.Com_Number.text
    T3_Manager.MSComm1.Settings = T3_Manager.Combo_Com_Setting.text
    T3_Manager.MSComm1.PortOpen = True
    CommSend T3_Manager.cardList.listByName.Item("OUBLIE")
    Sleep 500
    CommSend T3_Manager.cardList.listByName.Item("APPRENDS")
    Sleep 500
    CommSend T3_Manager.cardList.listByName.Item("B_C")
    If card.isRotation = True Then
        CommSend T3_Manager.cardList.listByName.Item("RE_10")
    End If
    If card.isTranslation = True Then
        CommSend T3_Manager.cardList.listByName.Item("AV_1")
        CommSend T3_Manager.cardList.listByName.Item("L_C")
    End If
    nbCommandToSend = target / card.value
    For i = 1 To nbCommandToSend
        Calibration.LabelProgress.Caption = "Sending command " & i + 1 & "/" & nbCommandToSend & " : " & card.text
        Calibration.Refresh
        Calibration.ProgressBarSend.value = 100 * (i / nbCommandToSend)
        Calibration.Refresh
        CommSend card
    Next
    If card.isRotation = True Then
        CommSend T3_Manager.cardList.listByName.Item("AV_20")
    End If
    If card.isTranslation = True Then
        CommSend T3_Manager.cardList.listByName.Item("B_C")
        CommSend T3_Manager.cardList.listByName.Item("AV_1")
    End If
    CommSend T3_Manager.cardList.listByName.Item("L_C")
    CommSend T3_Manager.cardList.listByName.Item("EXECUTE")
    T3_Manager.MSComm1.PortOpen = False
    Calibration.ProgressBarSend.Visible = False
    Calibration.LabelProgress.Visible = False
    T3_Manager.Enabled = True
    Calibration.Enabled = True
End Function

Public Function CommSendSingle(card As CardClass)
    T3_Manager.Enabled = False
    T3_Manager.MSComm1.PortOpen = True
    T3_Manager.MSComm1.output = Chr$(card.code)
    If card.runningTime > 0 Then
        Sleep card.runningTime
    End If
    T3_Manager.MSComm1.PortOpen = False
    T3_Manager.Enabled = True
End Function

Public Function CommSend(card As CardClass)
    T3_Manager.MSComm1.output = Chr$(card.code)
    Sleep 100
End Function




