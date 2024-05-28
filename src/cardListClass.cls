VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "cardListClass"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit
Public listByName As Collection
Public listByCode As Collection


Private Sub Class_Initialize()
    init
End Sub

Private Function addCard(name As String)
    Dim card As CardClass
    
    Set card = New CardClass
    card.name = name
    card.code = CInt(LitDansFichierIni("code", name, App.Path & "\T3 Manager.ini", 0))
    card.revert = LitDansFichierIni("revert", name, App.Path & "\T3 Manager.ini", 0)
    card.text = LitDansFichierIni("text", name, App.Path & "\T3 Manager.ini", 0)
    card.runningTime = CLng(LitDansFichierIni("runningTime", name, App.Path & "\T3 Manager.ini", 0))
    If name = "AV_1" Or name = "AV_10" Or name = "AV_20" Or name = "RE_1" Or name = "RE_10" Or name = "RE_20" Then: card.isTranslation = True
    If name = "TG_1" Or name = "TG_15" Or name = "TG_30" Or name = "TG_45" Or name = "TG_60" Or name = "TG_90" Or name = "TG_120" Or name = "TD_1" Or name = "TD_15" Or name = "TD_30" Or name = "TD_45" Or name = "TD_60" Or name = "TD_90" Or name = "TD_120" Then: card.isRotation = True
    card.target = CDbl(Replace(LitDansFichierIni("target", name, App.Path & "\T3 Manager.ini", 0), ".", ","))
    card.result = CDbl(Replace(LitDansFichierIni("result", name, App.Path & "\T3 Manager.ini", 0), ".", ","))
    card.value = CInt(LitDansFichierIni("value", name, App.Path & "\T3 Manager.ini", 0))
    card.picture = App.Path & "\media\image\" & LitDansFichierIni("picture", name, App.Path & "\T3 Manager.ini", "") & ".bmp"
    card.sound = App.Path & "\media\son\" & LitDansFichierIni("sound", name, App.Path & "\T3 Manager.ini", "") & ".wav"
    card.scrolling = CInt(LitDansFichierIni("scrolling", name, App.Path & "\T3 Manager.ini", 0))
    card.scrollingCategory = LitDansFichierIni("category", name, App.Path & "\T3 Manager.ini", "")
    If T3_Manager.UseCorrections.value = 1 Then
        If card.value <> 0 And card.target <> 0 Then: card.trueValue = card.value + (card.result - card.target) / (card.target / card.value)
    Else
        card.trueValue = card.value
    End If
    listByName.Add Item:=card, Key:=card.name
    listByCode.Add Item:=card, Key:="" & card.code
End Function

Public Function init()
    Set listByName = New Collection
    Set listByCode = New Collection
    
    'white cards
    addCard "AV_1"
    addCard "AV_10"
    addCard "AV_20"
    addCard "RE_1"
    addCard "RE_10"
    addCard "RE_20"
    addCard "TG_1"
    addCard "TG_15"
    addCard "TG_30"
    addCard "TG_45"
    addCard "TG_60"
    addCard "TG_90"
    addCard "TG_120"
    addCard "TD_1"
    addCard "TD_15"
    addCard "TD_30"
    addCard "TD_45"
    addCard "TD_60"
    addCard "TD_90"
    addCard "TD_120"

    'green cards
    addCard "B_C"
    addCard "L_C"
    addCard "RALE"
    addCard "SONNE"
    addCard "JOUE_AIR"
    addCard "ALLUME"
    addCard "ETEINS"
    addCard "ETEINS_G"
    addCard "ETEINS_D"
    addCard "CLIGNE_G"
    addCard "CLIGNE_D"
    addCard "ARC_AVG_5"
    addCard "ARC_AVG_10"
    addCard "ARC_AVG_20"
    addCard "ARC_AVD_5"
    addCard "ARC_AVD_10"
    addCard "ARC_AVD_20"
    
    'red cards
    addCard "REGLAGE"
    addCard "TEST"
    addCard "TOUCHE_AVG"
    addCard "TOUCHE_AVD"
    addCard "TOUCHE_AR"
    addCard "TOUCHE_STOP"
    addCard "DES_QUE"
    addCard "C_EST"
    addCard "FIN"
    addCard "SUPPRIME"
    addCard "OUBLIE"
    addCard "APPRENDS"
    addCard "GOMME"
    addCard "EXECUTE"
    addCard "EXECUTE_P"
    addCard "EXECUTE_M"
    addCard "TOUT"
    addCard "ARRET"

    'blue Card
    addCard "PROCEDURE_N1"
    addCard "PROCEDURE_N2"
    addCard "PROCEDURE_N3"
    addCard "PROCEDURE_N4"
    addCard "PROCEDURE_N5"
    addCard "PROCEDURE_N6"
    addCard "PROCEDURE_N7"
    addCard "PROCEDURE_N8"
    addCard "PROCEDURE_N9"
    addCard "PROCEDURE_N10"
    addCard "PROCEDURE_N11"
    addCard "PROCEDURE_N12"
    addCard "PROCEDURE_N13"
    addCard "PROCEDURE_N14"
    addCard "PROCEDURE_N15"
    addCard "PROCEDURE_N16"
    addCard "PROCEDURE_N17"
    addCard "PROCEDURE_N18"
    addCard "PROCEDURE_N19"
    addCard "PROCEDURE_N20"
    addCard "PROCEDURE_N21"
    addCard "PROCEDURE_N22"
    addCard "PROCEDURE_N23"
    addCard "PROCEDURE_N24"
    addCard "PROCEDURE_N25"
    addCard "PROCEDURE_N26"
    addCard "PROCEDURE_N27"
    addCard "PROCEDURE_N28"
    addCard "PROCEDURE_N29"
    addCard "PROCEDURE_N30"
    addCard "PROCEDURE_N31"
    addCard "PROCEDURE_N32"
    addCard "PROCEDURE_N33"
    addCard "PROCEDURE_N34"
    addCard "PROCEDURE_N35"
    addCard "PROCEDURE_N36"
End Function
