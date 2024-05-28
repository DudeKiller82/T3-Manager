VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form Calibration 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Calibration"
   ClientHeight    =   8895
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   4440
   Icon            =   "Calibration.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   8895
   ScaleWidth      =   4440
   StartUpPosition =   3  'Windows Default
   Visible         =   0   'False
   Begin VB.CommandButton save_Calibrate 
      Caption         =   "Sauver"
      Height          =   255
      Left            =   120
      TabIndex        =   85
      Top             =   7800
      Width           =   4215
   End
   Begin VB.Frame Frame3 
      Caption         =   "Objectifs"
      Height          =   7575
      Left            =   120
      TabIndex        =   40
      Top             =   120
      Width           =   1455
      Begin VB.TextBox TD_90_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   78
         Top             =   6720
         Width           =   855
      End
      Begin VB.TextBox TD_120_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   77
         Top             =   7080
         Width           =   615
      End
      Begin VB.TextBox AV_1_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   58
         Top             =   240
         Width           =   855
      End
      Begin VB.TextBox AV_10_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   57
         Top             =   600
         Width           =   855
      End
      Begin VB.TextBox AV_20_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   56
         Top             =   960
         Width           =   855
      End
      Begin VB.TextBox RE_1_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   55
         Top             =   1320
         Width           =   855
      End
      Begin VB.TextBox RE_10_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   54
         Top             =   1680
         Width           =   855
      End
      Begin VB.TextBox RE_20_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   53
         Top             =   2040
         Width           =   855
      End
      Begin VB.TextBox TG_1_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   52
         Top             =   2400
         Width           =   855
      End
      Begin VB.TextBox TG_15_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   51
         Top             =   2760
         Width           =   855
      End
      Begin VB.TextBox TG_30_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   50
         Top             =   3120
         Width           =   855
      End
      Begin VB.TextBox TG_45_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   49
         Top             =   3480
         Width           =   855
      End
      Begin VB.TextBox TG_60_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   48
         Top             =   3840
         Width           =   855
      End
      Begin VB.TextBox TG_90_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   47
         Top             =   4200
         Width           =   855
      End
      Begin VB.TextBox TG_120_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   46
         Top             =   4560
         Width           =   855
      End
      Begin VB.TextBox TD_1_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   45
         Top             =   4920
         Width           =   855
      End
      Begin VB.TextBox TD_15_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   44
         Top             =   5280
         Width           =   855
      End
      Begin VB.TextBox TD_30_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   43
         Top             =   5640
         Width           =   855
      End
      Begin VB.TextBox TD_45_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   42
         Top             =   6000
         Width           =   855
      End
      Begin VB.TextBox TD_60_Target 
         Height          =   285
         Left            =   120
         TabIndex        =   41
         Top             =   6360
         Width           =   855
      End
      Begin VB.Label Label20 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   80
         Top             =   7200
         Width           =   255
      End
      Begin VB.Label Label19 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   79
         Top             =   6840
         Width           =   255
      End
      Begin VB.Label Label18 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   76
         Top             =   6480
         Width           =   255
      End
      Begin VB.Label Label17 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   75
         Top             =   6120
         Width           =   255
      End
      Begin VB.Label Label16 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   74
         Top             =   5760
         Width           =   255
      End
      Begin VB.Label Label15 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   73
         Top             =   5400
         Width           =   255
      End
      Begin VB.Label Label14 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   72
         Top             =   5040
         Width           =   255
      End
      Begin VB.Label Label13 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   71
         Top             =   4680
         Width           =   255
      End
      Begin VB.Label Label12 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   70
         Top             =   4320
         Width           =   255
      End
      Begin VB.Label Label11 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   69
         Top             =   3960
         Width           =   255
      End
      Begin VB.Label Label10 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   68
         Top             =   3600
         Width           =   255
      End
      Begin VB.Label Label9 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   67
         Top             =   3240
         Width           =   255
      End
      Begin VB.Label Label8 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   66
         Top             =   2880
         Width           =   255
      End
      Begin VB.Label Label7 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   65
         Top             =   2520
         Width           =   255
      End
      Begin VB.Label Label6 
         Caption         =   "cm"
         Height          =   255
         Left            =   1080
         TabIndex        =   64
         Top             =   2160
         Width           =   255
      End
      Begin VB.Label Label5 
         Caption         =   "cm"
         Height          =   255
         Left            =   1080
         TabIndex        =   63
         Top             =   1800
         Width           =   255
      End
      Begin VB.Label Label4 
         Caption         =   "cm"
         Height          =   255
         Left            =   1080
         TabIndex        =   62
         Top             =   1440
         Width           =   255
      End
      Begin VB.Label Label3 
         Caption         =   "cm"
         Height          =   255
         Left            =   1080
         TabIndex        =   61
         Top             =   1080
         Width           =   255
      End
      Begin VB.Label Label2 
         Caption         =   "cm"
         Height          =   255
         Left            =   1080
         TabIndex        =   60
         Top             =   720
         Width           =   255
      End
      Begin VB.Label Label1 
         Caption         =   "cm"
         Height          =   255
         Left            =   1080
         TabIndex        =   59
         Top             =   360
         Width           =   255
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Resultats"
      Height          =   7575
      Left            =   2880
      TabIndex        =   21
      Top             =   120
      Width           =   1455
      Begin VB.TextBox TD_120_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   82
         Top             =   7080
         Width           =   855
      End
      Begin VB.TextBox TD_90_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   81
         Top             =   6720
         Width           =   855
      End
      Begin VB.TextBox TD_60_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   39
         Top             =   6360
         Width           =   855
      End
      Begin VB.TextBox TD_45_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   38
         Top             =   6000
         Width           =   855
      End
      Begin VB.TextBox TD_30_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   37
         Top             =   5640
         Width           =   855
      End
      Begin VB.TextBox TD_15_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   36
         Top             =   5280
         Width           =   855
      End
      Begin VB.TextBox TD_1_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   35
         Top             =   4920
         Width           =   855
      End
      Begin VB.TextBox TG_120_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   34
         Top             =   4560
         Width           =   855
      End
      Begin VB.TextBox TG_90_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   33
         Top             =   4200
         Width           =   855
      End
      Begin VB.TextBox TG_60_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   32
         Top             =   3840
         Width           =   855
      End
      Begin VB.TextBox TG_45_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   31
         Top             =   3480
         Width           =   855
      End
      Begin VB.TextBox TG_30_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   30
         Top             =   3120
         Width           =   855
      End
      Begin VB.TextBox TG_15_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   29
         Top             =   2760
         Width           =   855
      End
      Begin VB.TextBox TG_1_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   28
         Top             =   2400
         Width           =   855
      End
      Begin VB.TextBox RE_20_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   27
         Top             =   2040
         Width           =   855
      End
      Begin VB.TextBox RE_10_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   26
         Top             =   1680
         Width           =   855
      End
      Begin VB.TextBox RE_1_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   25
         Top             =   1320
         Width           =   855
      End
      Begin VB.TextBox AV_20_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   24
         Top             =   960
         Width           =   855
      End
      Begin VB.TextBox AV_10_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   23
         Top             =   600
         Width           =   855
      End
      Begin VB.TextBox AV_1_Result 
         Height          =   285
         Left            =   120
         TabIndex        =   22
         Top             =   240
         Width           =   855
      End
      Begin VB.Label Label40 
         Caption         =   "cm"
         Height          =   255
         Left            =   1080
         TabIndex        =   105
         Top             =   240
         Width           =   255
      End
      Begin VB.Label Label39 
         Caption         =   "cm"
         Height          =   255
         Left            =   1080
         TabIndex        =   104
         Top             =   600
         Width           =   255
      End
      Begin VB.Label Label38 
         Caption         =   "cm"
         Height          =   255
         Left            =   1080
         TabIndex        =   103
         Top             =   960
         Width           =   255
      End
      Begin VB.Label Label37 
         Caption         =   "cm"
         Height          =   255
         Left            =   1080
         TabIndex        =   102
         Top             =   1320
         Width           =   255
      End
      Begin VB.Label Label36 
         Caption         =   "cm"
         Height          =   255
         Left            =   1080
         TabIndex        =   101
         Top             =   1680
         Width           =   255
      End
      Begin VB.Label Label35 
         Caption         =   "cm"
         Height          =   255
         Left            =   1080
         TabIndex        =   100
         Top             =   2040
         Width           =   255
      End
      Begin VB.Label Label34 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   99
         Top             =   2400
         Width           =   255
      End
      Begin VB.Label Label33 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   98
         Top             =   2760
         Width           =   255
      End
      Begin VB.Label Label32 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   97
         Top             =   3120
         Width           =   255
      End
      Begin VB.Label Label31 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   96
         Top             =   3480
         Width           =   255
      End
      Begin VB.Label Label30 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   95
         Top             =   3840
         Width           =   255
      End
      Begin VB.Label Label29 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   94
         Top             =   4200
         Width           =   255
      End
      Begin VB.Label Label28 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   93
         Top             =   4560
         Width           =   255
      End
      Begin VB.Label Label27 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   92
         Top             =   4920
         Width           =   255
      End
      Begin VB.Label Label26 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   91
         Top             =   5280
         Width           =   255
      End
      Begin VB.Label Label25 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   90
         Top             =   5640
         Width           =   255
      End
      Begin VB.Label Label24 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   89
         Top             =   6000
         Width           =   255
      End
      Begin VB.Label Label23 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   88
         Top             =   6360
         Width           =   255
      End
      Begin VB.Label Label22 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   87
         Top             =   6720
         Width           =   255
      End
      Begin VB.Label Label21 
         Caption         =   "°"
         Height          =   255
         Left            =   1080
         TabIndex        =   86
         Top             =   7080
         Width           =   255
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Testes"
      Height          =   7575
      Left            =   1680
      TabIndex        =   0
      Top             =   120
      Width           =   1095
      Begin VB.CommandButton AV_1_button 
         Caption         =   "AV 1"
         Height          =   255
         Left            =   120
         TabIndex        =   20
         Top             =   240
         Width           =   855
      End
      Begin VB.CommandButton AV_10_button 
         Caption         =   "AV 10"
         Height          =   255
         Left            =   120
         TabIndex        =   19
         Top             =   600
         Width           =   855
      End
      Begin VB.CommandButton AV_20_button 
         Caption         =   "AV 20"
         Height          =   255
         Left            =   120
         TabIndex        =   18
         Top             =   960
         Width           =   855
      End
      Begin VB.CommandButton RE_1_button 
         Caption         =   "RE 1"
         Height          =   255
         Left            =   120
         TabIndex        =   17
         Top             =   1320
         Width           =   855
      End
      Begin VB.CommandButton RE_10_button 
         Caption         =   "RE 10"
         Height          =   255
         Left            =   120
         TabIndex        =   16
         Top             =   1680
         Width           =   855
      End
      Begin VB.CommandButton RE_20_button 
         Caption         =   "RE 20"
         Height          =   255
         Left            =   120
         TabIndex        =   15
         Top             =   2040
         Width           =   855
      End
      Begin VB.CommandButton TG_1_button 
         Caption         =   "TG 1"
         Height          =   255
         Left            =   120
         TabIndex        =   14
         Top             =   2400
         Width           =   855
      End
      Begin VB.CommandButton TG_15_button 
         Caption         =   "TG 15"
         Height          =   255
         Left            =   120
         TabIndex        =   13
         Top             =   2760
         Width           =   855
      End
      Begin VB.CommandButton TG_30_button 
         Caption         =   "TG 30"
         Height          =   255
         Left            =   120
         TabIndex        =   12
         Top             =   3120
         Width           =   855
      End
      Begin VB.CommandButton TG_45_button 
         Caption         =   "TG 45"
         Height          =   255
         Left            =   120
         TabIndex        =   11
         Top             =   3480
         Width           =   855
      End
      Begin VB.CommandButton TG_60_button 
         Caption         =   "TG 60"
         Height          =   255
         Left            =   120
         TabIndex        =   10
         Top             =   3840
         Width           =   855
      End
      Begin VB.CommandButton TG_90_button 
         Caption         =   "TG 90"
         Height          =   255
         Left            =   120
         TabIndex        =   9
         Top             =   4200
         Width           =   855
      End
      Begin VB.CommandButton TG_120_button 
         Caption         =   "TG_ 120"
         Height          =   255
         Left            =   120
         TabIndex        =   8
         Top             =   4560
         Width           =   855
      End
      Begin VB.CommandButton TD_1_button 
         Caption         =   "TD 1"
         Height          =   255
         Left            =   120
         TabIndex        =   7
         Top             =   4920
         Width           =   855
      End
      Begin VB.CommandButton TD_15_button 
         Caption         =   "TD 15"
         Height          =   255
         Left            =   120
         TabIndex        =   6
         Top             =   5280
         Width           =   855
      End
      Begin VB.CommandButton TD_30_button 
         Caption         =   "TD 30"
         Height          =   255
         Left            =   120
         TabIndex        =   5
         Top             =   5640
         Width           =   855
      End
      Begin VB.CommandButton TD_45_button 
         Caption         =   "TD 45"
         Height          =   255
         Left            =   120
         TabIndex        =   4
         Top             =   6000
         Width           =   855
      End
      Begin VB.CommandButton TD_60_button 
         Caption         =   "TD 60"
         Height          =   255
         Left            =   120
         TabIndex        =   3
         Top             =   6360
         Width           =   855
      End
      Begin VB.CommandButton TD_90_button 
         Caption         =   "TD 90"
         Height          =   255
         Left            =   120
         TabIndex        =   2
         Top             =   6720
         Width           =   855
      End
      Begin VB.CommandButton TD_120_button 
         Caption         =   "TD 120"
         Height          =   255
         Left            =   120
         TabIndex        =   1
         Top             =   7080
         Width           =   855
      End
   End
   Begin MSComctlLib.ProgressBar ProgressBarSend 
      Height          =   375
      Left            =   120
      TabIndex        =   83
      Top             =   8400
      Visible         =   0   'False
      Width           =   4215
      _ExtentX        =   7435
      _ExtentY        =   661
      _Version        =   393216
      Appearance      =   1
   End
   Begin VB.Label LabelProgress 
      Alignment       =   2  'Center
      Height          =   255
      Left            =   120
      TabIndex        =   84
      Top             =   8160
      Width           =   4215
   End
End
Attribute VB_Name = "Calibration"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub AV_1_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("AV_1"), AV_1_Target
End Sub

Private Sub AV_10_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("AV_10"), AV_10_Target
End Sub

Private Sub AV_20_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("AV_20"), AV_20_Target
End Sub

Private Sub Form_Load()
    AV_1_Target.text = T3_Manager.cardList.listByName.Item("AV_1").target
    AV_10_Target.text = T3_Manager.cardList.listByName.Item("AV_10").target
    AV_20_Target.text = T3_Manager.cardList.listByName.Item("AV_20").target
    RE_1_Target.text = T3_Manager.cardList.listByName.Item("RE_1").target
    RE_10_Target.text = T3_Manager.cardList.listByName.Item("RE_10").target
    RE_20_Target.text = T3_Manager.cardList.listByName.Item("RE_20").target
    TG_1_Target.text = T3_Manager.cardList.listByName.Item("TG_1").target
    TG_15_Target.text = T3_Manager.cardList.listByName.Item("TG_15").target
    TG_30_Target.text = T3_Manager.cardList.listByName.Item("TG_30").target
    TG_45_Target.text = T3_Manager.cardList.listByName.Item("TG_45").target
    TG_60_Target.text = T3_Manager.cardList.listByName.Item("TG_60").target
    TG_90_Target.text = T3_Manager.cardList.listByName.Item("TG_90").target
    TG_120_Target.text = T3_Manager.cardList.listByName.Item("TG_120").target
    TD_1_Target.text = T3_Manager.cardList.listByName.Item("TD_1").target
    TD_15_Target.text = T3_Manager.cardList.listByName.Item("TD_15").target
    TD_30_Target.text = T3_Manager.cardList.listByName.Item("TD_30").target
    TD_45_Target.text = T3_Manager.cardList.listByName.Item("TD_45").target
    TD_60_Target.text = T3_Manager.cardList.listByName.Item("TD_60").target
    TD_90_Target.text = T3_Manager.cardList.listByName.Item("TD_90").target
    TD_120_Target.text = T3_Manager.cardList.listByName.Item("TD_120").target
    
    AV_1_Result.text = T3_Manager.cardList.listByName.Item("AV_1").result
    AV_10_Result.text = T3_Manager.cardList.listByName.Item("AV_10").result
    AV_20_Result.text = T3_Manager.cardList.listByName.Item("AV_20").result
    RE_1_Result.text = T3_Manager.cardList.listByName.Item("RE_1").result
    RE_10_Result.text = T3_Manager.cardList.listByName.Item("RE_10").result
    RE_20_Result.text = T3_Manager.cardList.listByName.Item("RE_20").result
    TG_1_Result.text = T3_Manager.cardList.listByName.Item("TG_1").result
    TG_15_Result.text = T3_Manager.cardList.listByName.Item("TG_15").result
    TG_30_Result.text = T3_Manager.cardList.listByName.Item("TG_30").result
    TG_45_Result.text = T3_Manager.cardList.listByName.Item("TG_45").result
    TG_60_Result.text = T3_Manager.cardList.listByName.Item("TG_60").result
    TG_90_Result.text = T3_Manager.cardList.listByName.Item("TG_90").result
    TG_120_Result.text = T3_Manager.cardList.listByName.Item("TG_120").result
    TD_1_Result.text = T3_Manager.cardList.listByName.Item("TD_1").result
    TD_15_Result.text = T3_Manager.cardList.listByName.Item("TD_15").result
    TD_30_Result.text = T3_Manager.cardList.listByName.Item("TD_30").result
    TD_45_Result.text = T3_Manager.cardList.listByName.Item("TD_45").result
    TD_60_Result.text = T3_Manager.cardList.listByName.Item("TD_60").result
    TD_90_Result.text = T3_Manager.cardList.listByName.Item("TD_90").result
    TD_120_Result.text = T3_Manager.cardList.listByName.Item("TD_120").result
    T3_Manager.cardList.init
End Sub

Private Sub RE_1_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("RE_1"), RE_1_Target
End Sub

Private Sub RE_10_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("RE_10"), RE_10_Target
End Sub

Private Sub RE_20_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("RE_20"), RE_20_Target
End Sub

Private Sub save_Calibrate_Click()
    EcritDansFichierIni "target", "AV_1", AV_1_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "AV_10", AV_10_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "AV_20", AV_20_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "RE_1", RE_1_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "RE_10", RE_10_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "RE_20", RE_20_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "TG_1", TG_1_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "TG_15", TG_15_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "TG_30", TG_30_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "TG_45", TG_45_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "TG_60", TG_60_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "TG_90", TG_90_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "TG_120", TG_120_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "TD_1", TD_1_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "TD_15", TD_15_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "TD_30", TD_30_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "TD_45", TD_45_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "TD_60", TD_60_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "TD_90", TD_90_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "target", "TD_120", TD_120_Target.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "AV_1", AV_1_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "AV_10", AV_10_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "AV_20", AV_20_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "RE_1", RE_1_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "RE_10", RE_10_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "RE_20", RE_20_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "TG_1", TG_1_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "TG_15", TG_15_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "TG_30", TG_30_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "TG_45", TG_45_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "TG_60", TG_60_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "TG_90", TG_90_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "TG_120", TG_120_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "TD_1", TD_1_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "TD_15", TD_15_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "TD_30", TD_30_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "TD_45", TD_45_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "TD_60", TD_60_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "TD_90", TD_90_Result.text, App.Path & "\T3 Manager.ini"
    EcritDansFichierIni "result", "TD_120", TD_120_Result.text, App.Path & "\T3 Manager.ini"
    T3_Manager.cardList.init
End Sub

Private Sub TD_1_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("TD_1"), TD_1_Target
End Sub

Private Sub TD_120_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("TD_120"), TD_120_Target
End Sub

Private Sub TD_15_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("TD_15"), TD_15_Target
End Sub

Private Sub TD_30_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("TD_30"), TD_30_Target
End Sub

Private Sub TD_45_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("TD_45"), TD_45_Target
End Sub

Private Sub TD_60_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("TD_60"), TD_60_Target
End Sub

Private Sub TD_90_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("TD_90"), TD_90_Target
End Sub

Private Sub TG_1_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("TG_1"), TG_1_Target
End Sub

Private Sub TG_120_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("TG_120"), TG_120_Target
End Sub

Private Sub TG_15_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("TG_15"), TG_15_Target
End Sub

Private Sub TG_30_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("TG_30"), TG_30_Target
End Sub

Private Sub TG_45_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("TG_45"), TG_45_Target
End Sub

Private Sub TG_60_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("TG_60"), TG_60_Target
End Sub

Private Sub TG_90_button_Click()
    Test_Send T3_Manager.cardList.listByName.Item("TG_90"), TG_90_Target
End Sub
