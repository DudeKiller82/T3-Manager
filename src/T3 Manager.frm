VERSION 5.00
Object = "{648A5603-2C6E-101B-82B6-000000000014}#1.1#0"; "MSCOMM32.OCX"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form T3_Manager 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "T3 Manager V3.6"
   ClientHeight    =   10785
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   14130
   Icon            =   "T3 Manager.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   719
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   942
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame9 
      Caption         =   "Extra"
      Height          =   975
      Left            =   10800
      TabIndex        =   153
      Top             =   8760
      Width           =   3255
      Begin VB.CommandButton Show_Manual 
         Caption         =   "Ouvrir manuel T3"
         Height          =   255
         Left            =   120
         TabIndex        =   158
         ToolTipText     =   "Open the T3 manual"
         Top             =   600
         Width           =   3015
      End
      Begin VB.CommandButton Scrolling_Mod_Button 
         Caption         =   "Mode défilement"
         Height          =   255
         Left            =   120
         TabIndex        =   154
         ToolTipText     =   "Select a SVG image"
         Top             =   240
         Width           =   3015
      End
   End
   Begin VB.Frame Frame5 
      Caption         =   "Programmes"
      Height          =   8655
      Left            =   10800
      TabIndex        =   117
      Top             =   0
      Width           =   3255
      Begin VB.CheckBox programming 
         Caption         =   "Programmer"
         Height          =   255
         Left            =   120
         TabIndex        =   155
         Top             =   240
         Width           =   1215
      End
      Begin VB.Frame Frame8 
         Height          =   1695
         Left            =   1920
         TabIndex        =   147
         Top             =   5160
         Width           =   1215
         Begin VB.PictureBox Picture11 
            Appearance      =   0  'Flat
            AutoSize        =   -1  'True
            BackColor       =   &H80000005&
            ForeColor       =   &H80000008&
            Height          =   750
            Left            =   240
            Picture         =   "T3 Manager.frx":1CCA
            ScaleHeight     =   720
            ScaleWidth      =   720
            TabIndex        =   148
            Top             =   240
            Width           =   750
         End
         Begin VB.Label Label8 
            Alignment       =   2  'Center
            Caption         =   "2009"
            Height          =   255
            Left            =   240
            TabIndex        =   150
            Top             =   1320
            Width           =   735
         End
         Begin VB.Label Label7 
            Alignment       =   2  'Center
            Caption         =   "P. LE BIHAN"
            Height          =   255
            Left            =   120
            TabIndex        =   149
            Top             =   1080
            Width           =   975
         End
      End
      Begin VB.CheckBox Insert 
         Caption         =   "Insèrer"
         Height          =   255
         Left            =   1920
         TabIndex        =   146
         ToolTipText     =   "Insert command before the selected command"
         Top             =   4320
         Width           =   855
      End
      Begin VB.CommandButton Send_Program_Step_Backward_To_T3 
         Caption         =   "Envoyer pas  -"
         Height          =   255
         Left            =   1920
         TabIndex        =   145
         ToolTipText     =   "Send the opposite of the selected command to the T3 and goes to the previous one"
         Top             =   7920
         Width           =   1215
      End
      Begin VB.CommandButton Send_Program_Step_Forward_To_T3 
         Caption         =   "Envoyer pas  +"
         Height          =   255
         Left            =   1920
         TabIndex        =   144
         ToolTipText     =   "Send the selected command to the T3 and goes to the next command"
         Top             =   7560
         Width           =   1215
      End
      Begin VB.ListBox ProgramCommandList 
         Height          =   6495
         ItemData        =   "T3 Manager.frx":380C
         Left            =   120
         List            =   "T3 Manager.frx":380E
         TabIndex        =   137
         Top             =   2040
         Width           =   1695
      End
      Begin VB.CommandButton MoveCommandDown 
         Caption         =   "Glisser bas"
         Height          =   255
         Left            =   1920
         TabIndex        =   132
         ToolTipText     =   "Move a command down in the Program Command List"
         Top             =   3960
         Width           =   1215
      End
      Begin VB.CommandButton MoveCommandUp 
         Caption         =   "Glisser haut"
         Height          =   255
         Left            =   1920
         TabIndex        =   131
         ToolTipText     =   "Move a command up in the Program Command List"
         Top             =   3600
         Width           =   1215
      End
      Begin VB.CommandButton RemoveCommand 
         Caption         =   "Effacer"
         Height          =   255
         Left            =   1920
         TabIndex        =   130
         ToolTipText     =   "remove a command from the Program Command List"
         Top             =   3240
         Width           =   1215
      End
      Begin VB.CommandButton ClearProgramCommandList 
         Caption         =   "Effacer tout"
         Height          =   255
         Left            =   1920
         TabIndex        =   129
         ToolTipText     =   "Clear the Program Command List"
         Top             =   2880
         Width           =   1215
      End
      Begin VB.CommandButton SaveProgram 
         Caption         =   "Sauv. Program "
         Height          =   255
         Left            =   1920
         TabIndex        =   128
         ToolTipText     =   "Save the T3P program"
         Top             =   2520
         Width           =   1215
      End
      Begin VB.CommandButton LoadProgram 
         Caption         =   "Charg. Program"
         Height          =   255
         Left            =   1920
         TabIndex        =   127
         ToolTipText     =   "Load the T3P program"
         Top             =   2160
         Width           =   1215
      End
      Begin VB.TextBox programEditorPath 
         Height          =   315
         Left            =   120
         TabIndex        =   126
         Top             =   840
         Width           =   1695
      End
      Begin VB.TextBox programPath 
         Height          =   285
         Left            =   120
         TabIndex        =   125
         Top             =   1440
         Width           =   1695
      End
      Begin VB.CommandButton EditProgram 
         Caption         =   "Edit. Program."
         Height          =   255
         Left            =   1920
         TabIndex        =   121
         ToolTipText     =   "Edit T3P program in the external editor"
         Top             =   1800
         Width           =   1215
      End
      Begin VB.CommandButton SelectProgramEditorButton 
         Caption         =   "Select. Editeur"
         Height          =   255
         Left            =   1920
         TabIndex        =   120
         ToolTipText     =   "Select an external text file editor"
         Top             =   840
         Width           =   1215
      End
      Begin VB.CommandButton Send_Program_To_T3 
         Caption         =   "Envoy. vers T3"
         Height          =   255
         Left            =   1920
         TabIndex        =   119
         ToolTipText     =   "Send the Program Command List to the T3"
         Top             =   8280
         Width           =   1215
      End
      Begin VB.CommandButton selectProgram_Button 
         Caption         =   "Select Program"
         Height          =   255
         Left            =   1920
         TabIndex        =   118
         ToolTipText     =   "Select a T3P program"
         Top             =   1440
         Width           =   1215
      End
      Begin VB.Label Label6 
         Caption         =   "Liste de commandes :"
         Height          =   255
         Left            =   120
         TabIndex        =   124
         Top             =   1800
         Width           =   1695
      End
      Begin VB.Label Label5 
         Caption         =   "Chemin éditeur de texte :"
         Height          =   255
         Left            =   120
         TabIndex        =   123
         Top             =   600
         Width           =   2415
      End
      Begin VB.Label Label4 
         Caption         =   "Chemin du programme :"
         Height          =   255
         Left            =   120
         TabIndex        =   122
         Top             =   1200
         Width           =   2415
      End
   End
   Begin VB.Frame Frame6 
      Caption         =   "Communication port série"
      Height          =   855
      Left            =   3240
      TabIndex        =   36
      Top             =   9840
      Width           =   10815
      Begin VB.TextBox Com_Number 
         Height          =   285
         Left            =   600
         TabIndex        =   152
         ToolTipText     =   "Size of the image reproduction"
         Top             =   360
         Width           =   255
      End
      Begin VB.ComboBox Combo_Com_Setting 
         Height          =   315
         ItemData        =   "T3 Manager.frx":3810
         Left            =   1800
         List            =   "T3 Manager.frx":382C
         TabIndex        =   39
         Text            =   "1200,N,8,2"
         ToolTipText     =   "Serial Communication settings"
         Top             =   360
         Width           =   1215
      End
      Begin MSComctlLib.ProgressBar ProgressBarSend 
         Height          =   375
         Left            =   3120
         TabIndex        =   37
         Top             =   360
         Visible         =   0   'False
         Width           =   7575
         _ExtentX        =   13361
         _ExtentY        =   661
         _Version        =   393216
         Appearance      =   1
      End
      Begin VB.Label Label9 
         Caption         =   "Com:"
         Height          =   255
         Left            =   120
         TabIndex        =   151
         Top             =   360
         Width           =   495
      End
      Begin VB.Label Label3 
         Caption         =   "Réglages :"
         Height          =   255
         Left            =   960
         TabIndex        =   40
         Top             =   360
         Width           =   855
      End
      Begin VB.Label LabelProgress 
         Alignment       =   2  'Center
         Height          =   255
         Left            =   3120
         TabIndex        =   38
         Top             =   120
         Width           =   7575
      End
   End
   Begin VB.Frame Cards_Treatment 
      Caption         =   "Cartes"
      Height          =   9735
      Left            =   3240
      TabIndex        =   16
      Top             =   0
      Width           =   7455
      Begin VB.Frame Frame2 
         BackColor       =   &H80000009&
         Height          =   6735
         Left            =   120
         TabIndex        =   96
         Top             =   240
         Width           =   1935
         Begin VB.PictureBox Picture2 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            BorderStyle     =   0  'None
            ForeColor       =   &H80000008&
            Height          =   540
            Left            =   720
            Picture         =   "T3 Manager.frx":3890
            ScaleHeight     =   36
            ScaleMode       =   3  'Pixel
            ScaleWidth      =   36
            TabIndex        =   136
            Top             =   4920
            Width           =   540
         End
         Begin VB.PictureBox Picture6 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            BorderStyle     =   0  'None
            ForeColor       =   &H80000008&
            Height          =   540
            Left            =   120
            Picture         =   "T3 Manager.frx":4802
            ScaleHeight     =   36
            ScaleMode       =   3  'Pixel
            ScaleWidth      =   36
            TabIndex        =   135
            Top             =   1800
            Width           =   540
         End
         Begin VB.PictureBox Picture4 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            BorderStyle     =   0  'None
            ForeColor       =   &H80000008&
            Height          =   540
            Left            =   1320
            Picture         =   "T3 Manager.frx":5774
            ScaleHeight     =   36
            ScaleMode       =   3  'Pixel
            ScaleWidth      =   36
            TabIndex        =   134
            Top             =   1800
            Width           =   540
         End
         Begin VB.PictureBox Picture1 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            BorderStyle     =   0  'None
            ForeColor       =   &H80000008&
            Height          =   540
            Left            =   720
            Picture         =   "T3 Manager.frx":66E6
            ScaleHeight     =   36
            ScaleMode       =   3  'Pixel
            ScaleWidth      =   36
            TabIndex        =   133
            Top             =   120
            Width           =   540
         End
         Begin VB.CommandButton TD_120_button 
            Caption         =   "TD 120"
            Height          =   255
            Left            =   1080
            TabIndex        =   116
            Top             =   4560
            Width           =   735
         End
         Begin VB.CommandButton TD_90_button 
            Caption         =   "TD 90"
            Height          =   255
            Left            =   1080
            TabIndex        =   115
            Top             =   4200
            Width           =   735
         End
         Begin VB.CommandButton TD_60_button 
            Caption         =   "TD 60"
            Height          =   255
            Left            =   1080
            TabIndex        =   114
            Top             =   3840
            Width           =   735
         End
         Begin VB.CommandButton TD_45_button 
            Caption         =   "TD 45"
            Height          =   255
            Left            =   1080
            TabIndex        =   113
            Top             =   3480
            Width           =   735
         End
         Begin VB.CommandButton TD_30_button 
            Caption         =   "TD 30"
            Height          =   255
            Left            =   1080
            TabIndex        =   112
            Top             =   3120
            Width           =   735
         End
         Begin VB.CommandButton TD_15_button 
            Caption         =   "TD 15"
            Height          =   255
            Left            =   1080
            TabIndex        =   111
            Top             =   2760
            Width           =   735
         End
         Begin VB.CommandButton TD_1_button 
            Caption         =   "TD 1"
            Height          =   255
            Left            =   1080
            TabIndex        =   110
            Top             =   2400
            Width           =   735
         End
         Begin VB.CommandButton TG_120_button 
            Caption         =   "TG_ 120"
            Height          =   255
            Left            =   120
            TabIndex        =   109
            Top             =   4560
            Width           =   855
         End
         Begin VB.CommandButton TG_90_button 
            Caption         =   "TG 90"
            Height          =   255
            Left            =   120
            TabIndex        =   108
            Top             =   4200
            Width           =   855
         End
         Begin VB.CommandButton TG_60_button 
            Caption         =   "TG 60"
            Height          =   255
            Left            =   120
            TabIndex        =   107
            Top             =   3840
            Width           =   855
         End
         Begin VB.CommandButton TG_45_button 
            Caption         =   "TG 45"
            Height          =   255
            Left            =   120
            TabIndex        =   106
            Top             =   3480
            Width           =   855
         End
         Begin VB.CommandButton TG_30_button 
            Caption         =   "TG 30"
            Height          =   255
            Left            =   120
            TabIndex        =   105
            Top             =   3120
            Width           =   855
         End
         Begin VB.CommandButton TG_15_button 
            Caption         =   "TG 15"
            Height          =   255
            Left            =   120
            TabIndex        =   104
            Top             =   2760
            Width           =   855
         End
         Begin VB.CommandButton TG_1_button 
            Caption         =   "TG 1"
            Height          =   255
            Left            =   120
            TabIndex        =   103
            Top             =   2400
            Width           =   855
         End
         Begin VB.CommandButton RE_20_button 
            Caption         =   "RE 20"
            Height          =   255
            Left            =   120
            TabIndex        =   102
            Top             =   6240
            Width           =   1695
         End
         Begin VB.CommandButton RE_10_button 
            Caption         =   "RE 10"
            Height          =   255
            Left            =   120
            TabIndex        =   101
            Top             =   5880
            Width           =   1695
         End
         Begin VB.CommandButton RE_1_button 
            Caption         =   "RE 1"
            Height          =   255
            Left            =   120
            TabIndex        =   100
            Top             =   5520
            Width           =   1695
         End
         Begin VB.CommandButton AV_20_button 
            Caption         =   "AV 20"
            Height          =   255
            Left            =   120
            TabIndex        =   99
            Top             =   1440
            Width           =   1695
         End
         Begin VB.CommandButton AV_10_button 
            Caption         =   "AV 10"
            Height          =   255
            Left            =   120
            TabIndex        =   98
            Top             =   1080
            Width           =   1695
         End
         Begin VB.CommandButton AV_1_button 
            Caption         =   "AV 1"
            Height          =   255
            Left            =   120
            TabIndex        =   97
            Top             =   720
            Width           =   1695
         End
      End
      Begin VB.Frame Frame3 
         BackColor       =   &H0000FF00&
         Height          =   2535
         Left            =   120
         TabIndex        =   78
         Top             =   7080
         Width           =   7215
         Begin VB.PictureBox Picture10 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            BorderStyle     =   0  'None
            ForeColor       =   &H80000008&
            Height          =   540
            Left            =   2760
            Picture         =   "T3 Manager.frx":7658
            ScaleHeight     =   36
            ScaleMode       =   3  'Pixel
            ScaleWidth      =   36
            TabIndex        =   143
            Top             =   960
            Width           =   540
         End
         Begin VB.PictureBox Picture5 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            BorderStyle     =   0  'None
            ForeColor       =   &H80000008&
            Height          =   540
            Left            =   2760
            Picture         =   "T3 Manager.frx":85CA
            ScaleHeight     =   36
            ScaleMode       =   3  'Pixel
            ScaleWidth      =   36
            TabIndex        =   142
            Top             =   240
            Width           =   540
         End
         Begin VB.PictureBox Picture9 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            BorderStyle     =   0  'None
            ForeColor       =   &H80000008&
            Height          =   540
            Left            =   720
            Picture         =   "T3 Manager.frx":953C
            ScaleHeight     =   36
            ScaleMode       =   3  'Pixel
            ScaleWidth      =   36
            TabIndex        =   141
            Top             =   1920
            Width           =   540
         End
         Begin VB.PictureBox Picture8 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            BorderStyle     =   0  'None
            ForeColor       =   &H80000008&
            Height          =   540
            Left            =   720
            Picture         =   "T3 Manager.frx":A4AE
            ScaleHeight     =   36
            ScaleMode       =   3  'Pixel
            ScaleWidth      =   36
            TabIndex        =   140
            Top             =   1320
            Width           =   540
         End
         Begin VB.PictureBox Picture7 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            BorderStyle     =   0  'None
            ForeColor       =   &H80000008&
            Height          =   540
            Left            =   2760
            Picture         =   "T3 Manager.frx":B420
            ScaleHeight     =   36
            ScaleMode       =   3  'Pixel
            ScaleWidth      =   36
            TabIndex        =   139
            Top             =   1680
            Width           =   540
         End
         Begin VB.PictureBox Picture3 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            BorderStyle     =   0  'None
            ForeColor       =   &H80000008&
            Height          =   540
            Left            =   6120
            Picture         =   "T3 Manager.frx":C392
            ScaleHeight     =   36
            ScaleMode       =   3  'Pixel
            ScaleWidth      =   36
            TabIndex        =   138
            Top             =   240
            Width           =   540
         End
         Begin VB.CommandButton B_C_button 
            Caption         =   "B C"
            Height          =   495
            Left            =   1320
            TabIndex        =   95
            Top             =   1920
            Width           =   615
         End
         Begin VB.CommandButton L_C_button 
            Caption         =   "L C"
            Height          =   495
            Left            =   1320
            TabIndex        =   94
            Top             =   1320
            Width           =   615
         End
         Begin VB.CommandButton RALE_button 
            Caption         =   "RALE"
            Height          =   255
            Left            =   5640
            TabIndex        =   93
            Top             =   1200
            Width           =   1455
         End
         Begin VB.CommandButton SONNE_button 
            Caption         =   "SONNE"
            Height          =   255
            Left            =   5640
            TabIndex        =   92
            Top             =   840
            Width           =   1455
         End
         Begin VB.CommandButton JOUE_AIR_button 
            Caption         =   "JOUE AIR"
            Height          =   255
            Left            =   5640
            TabIndex        =   91
            Top             =   1560
            Width           =   1455
         End
         Begin VB.CommandButton ALLUME_button 
            Caption         =   "ALLUME"
            Height          =   255
            Left            =   3360
            TabIndex        =   90
            Top             =   360
            Width           =   2055
         End
         Begin VB.CommandButton ETEINS_button 
            Caption         =   "ETEINS"
            Height          =   255
            Left            =   3360
            TabIndex        =   89
            Top             =   1680
            Width           =   2055
         End
         Begin VB.CommandButton ETEINS_G_button 
            Caption         =   "ETEINS G"
            Height          =   255
            Left            =   3360
            TabIndex        =   88
            Top             =   2040
            Width           =   975
         End
         Begin VB.CommandButton ETEINS_D_button 
            Caption         =   "ETEINS D"
            Height          =   255
            Left            =   4440
            TabIndex        =   87
            Top             =   2040
            Width           =   975
         End
         Begin VB.CommandButton CLIGNE_G_button 
            Caption         =   "CLIGNE G"
            Height          =   255
            Left            =   3360
            TabIndex        =   86
            Top             =   1080
            Width           =   975
         End
         Begin VB.CommandButton CLIGNE_D_button 
            Caption         =   "CLIGNE D"
            Height          =   255
            Left            =   4440
            TabIndex        =   85
            Top             =   1080
            Width           =   975
         End
         Begin VB.CommandButton ARC_AVG_5_button 
            Caption         =   "ARC AVG 5"
            Height          =   255
            Left            =   120
            TabIndex        =   84
            Top             =   240
            Width           =   1215
         End
         Begin VB.CommandButton ARC_AVG_10_button 
            Caption         =   "ARC AVG 10"
            Height          =   255
            Left            =   120
            TabIndex        =   83
            Top             =   600
            Width           =   1215
         End
         Begin VB.CommandButton ARC_AVG_20_button 
            Caption         =   "ARC AVG 20"
            Height          =   255
            Left            =   120
            TabIndex        =   82
            Top             =   960
            Width           =   1215
         End
         Begin VB.CommandButton ARC_AVD_5_button 
            Caption         =   "ARC AVD 5"
            Height          =   255
            Left            =   1440
            TabIndex        =   81
            Top             =   240
            Width           =   1095
         End
         Begin VB.CommandButton ARC_AVD_10_button 
            Caption         =   "ARC AVD 10"
            Height          =   255
            Left            =   1440
            TabIndex        =   80
            Top             =   600
            Width           =   1095
         End
         Begin VB.CommandButton ARC_AVD_20_button 
            Caption         =   "ARC AVD 20"
            Height          =   255
            Left            =   1440
            TabIndex        =   79
            Top             =   960
            Width           =   1095
         End
      End
      Begin VB.Frame Frame4 
         BackColor       =   &H00FF0000&
         ForeColor       =   &H8000000F&
         Height          =   6735
         Left            =   3840
         TabIndex        =   41
         Top             =   240
         Width           =   3495
         Begin VB.CommandButton PROCEDURE_N1_button 
            Caption         =   "PROCEDURE N°1"
            Height          =   315
            Left            =   120
            TabIndex        =   77
            Top             =   240
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N2_button 
            Caption         =   "PROCEDURE N°2"
            Height          =   255
            Left            =   120
            TabIndex        =   76
            Top             =   600
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N3_button 
            Caption         =   "PROCEDURE N°3"
            Height          =   255
            Left            =   120
            TabIndex        =   75
            Top             =   960
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N4_button 
            Caption         =   "PROCEDURE N°4"
            Height          =   255
            Left            =   120
            TabIndex        =   74
            Top             =   1320
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N5_button 
            Caption         =   "PROCEDURE N°5"
            Height          =   255
            Left            =   120
            TabIndex        =   73
            Top             =   1680
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N6_button 
            Caption         =   "PROCEDURE N°6"
            Height          =   255
            Left            =   120
            TabIndex        =   72
            Top             =   2040
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N7_button 
            Caption         =   "PROCEDURE N°7"
            Height          =   255
            Left            =   120
            TabIndex        =   71
            Top             =   2400
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N8_button 
            Caption         =   "PROCEDURE N°8"
            Height          =   255
            Left            =   120
            TabIndex        =   70
            Top             =   2760
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N9_button 
            Caption         =   "PROCEDURE N°9"
            Height          =   255
            Left            =   120
            TabIndex        =   69
            Top             =   3120
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N10_button 
            Caption         =   "PROCEDURE N°10"
            Height          =   255
            Left            =   120
            TabIndex        =   68
            Top             =   3480
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N11_button 
            Caption         =   "PROCEDURE N°11"
            Height          =   255
            Left            =   120
            TabIndex        =   67
            Top             =   3840
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N12_button 
            Caption         =   "PROCEDURE N°12"
            Height          =   255
            Left            =   120
            TabIndex        =   66
            Top             =   4200
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N13_button 
            Caption         =   "PROCEDURE N°13"
            Height          =   255
            Left            =   120
            TabIndex        =   65
            Top             =   4560
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N14_button 
            Caption         =   "PROCEDURE N°14"
            Height          =   255
            Left            =   120
            TabIndex        =   64
            Top             =   4920
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N15_button 
            Caption         =   "PROCEDURE N°15"
            Height          =   255
            Left            =   120
            TabIndex        =   63
            Top             =   5280
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N16_button 
            Caption         =   "PROCEDURE N°16"
            Height          =   255
            Left            =   120
            TabIndex        =   62
            Top             =   5640
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N17_button 
            Caption         =   "PROCEDURE N°17"
            Height          =   255
            Left            =   120
            TabIndex        =   61
            Top             =   6000
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N18_button 
            Caption         =   "PROCEDURE N°18"
            Height          =   255
            Left            =   120
            TabIndex        =   60
            Top             =   6360
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N19_button 
            Caption         =   "PROCEDURE N°19"
            Height          =   255
            Left            =   1800
            TabIndex        =   59
            Top             =   240
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N20_button 
            Caption         =   "PROCEDURE N°20"
            Height          =   255
            Left            =   1800
            TabIndex        =   58
            Top             =   600
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N21_button 
            Caption         =   "PROCEDURE N°21"
            Height          =   255
            Left            =   1800
            TabIndex        =   57
            Top             =   960
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N22_button 
            Caption         =   "PROCEDURE N°22"
            Height          =   255
            Left            =   1800
            TabIndex        =   56
            Top             =   1320
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N23_button 
            Caption         =   "PROCEDURE N°23"
            Height          =   255
            Left            =   1800
            TabIndex        =   55
            Top             =   1680
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N24_button 
            Caption         =   "PROCEDURE N°24"
            Height          =   255
            Left            =   1800
            TabIndex        =   54
            Top             =   2040
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N26_button 
            Caption         =   "PROCEDURE N°26"
            Height          =   255
            Left            =   1800
            TabIndex        =   53
            Top             =   2760
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N27_button 
            Caption         =   "PROCEDURE N°27"
            Height          =   255
            Left            =   1800
            TabIndex        =   52
            Top             =   3120
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N28_button 
            Caption         =   "PROCEDURE N°28"
            Height          =   255
            Left            =   1800
            TabIndex        =   51
            Top             =   3480
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N29_button 
            Caption         =   "PROCEDURE N°29"
            Height          =   255
            Left            =   1800
            TabIndex        =   50
            Top             =   3840
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N30_button 
            Caption         =   "PROCEDURE N°30"
            Height          =   255
            Left            =   1800
            TabIndex        =   49
            Top             =   4200
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N31_button 
            Caption         =   "PROCEDURE N°31"
            Height          =   255
            Left            =   1800
            TabIndex        =   48
            Top             =   4560
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N32_button 
            Caption         =   "PROCEDURE N°32"
            Height          =   255
            Left            =   1800
            TabIndex        =   47
            Top             =   4920
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N33_button 
            Caption         =   "PROCEDURE N°33"
            Height          =   255
            Left            =   1800
            TabIndex        =   46
            Top             =   5280
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N34_button 
            Caption         =   "PROCEDURE N°34"
            Height          =   255
            Left            =   1800
            TabIndex        =   45
            Top             =   5640
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N36_button 
            Caption         =   "PROCEDURE N°36"
            Height          =   255
            Left            =   1800
            TabIndex        =   44
            Top             =   6360
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N25_button 
            Caption         =   "PROCEDURE N°25"
            Height          =   255
            Left            =   1800
            TabIndex        =   43
            Top             =   2400
            Width           =   1575
         End
         Begin VB.CommandButton PROCEDURE_N35_button 
            Caption         =   "PROCEDURE N°35"
            Height          =   255
            Left            =   1800
            TabIndex        =   42
            Top             =   6000
            Width           =   1575
         End
      End
      Begin VB.Frame Frame1 
         BackColor       =   &H000000FF&
         ForeColor       =   &H8000000F&
         Height          =   6735
         Left            =   2160
         TabIndex        =   17
         Top             =   240
         Width           =   1575
         Begin VB.CommandButton TOUCHE_STOP_button 
            Caption         =   "TOUCHE STOP"
            Height          =   255
            Left            =   120
            TabIndex        =   35
            Top             =   6360
            Width           =   1335
         End
         Begin VB.CommandButton TOUCHE_AR_button 
            Caption         =   "TOUCHE AR"
            Height          =   255
            Left            =   120
            TabIndex        =   34
            Top             =   5640
            Width           =   1335
         End
         Begin VB.CommandButton TOUCHE_AVD_button 
            Caption         =   "TOUCHE AVD"
            Height          =   255
            Left            =   120
            TabIndex        =   33
            Top             =   5280
            Width           =   1335
         End
         Begin VB.CommandButton TOUCHE_AVG_button 
            Caption         =   "TOUCHE AVG"
            Height          =   255
            Left            =   120
            TabIndex        =   32
            Top             =   4920
            Width           =   1335
         End
         Begin VB.CommandButton TEST_button 
            Caption         =   "TEST"
            Height          =   255
            Left            =   120
            TabIndex        =   31
            Top             =   2760
            Width           =   1335
         End
         Begin VB.CommandButton REGLAGE_button 
            Caption         =   "REGLAGE"
            Height          =   255
            Left            =   120
            TabIndex        =   30
            Top             =   4200
            Width           =   1335
         End
         Begin VB.CommandButton GOMME_button 
            Caption         =   "GOMME"
            Height          =   255
            Left            =   120
            TabIndex        =   29
            Top             =   2400
            Width           =   1335
         End
         Begin VB.CommandButton OUBLIE_button 
            Caption         =   "OUBLIE"
            Height          =   255
            Left            =   120
            TabIndex        =   28
            Top             =   240
            Width           =   1335
         End
         Begin VB.CommandButton SUPPRIME_button 
            Caption         =   "SUPPRIME"
            Height          =   255
            Left            =   120
            TabIndex        =   27
            Top             =   3480
            Width           =   1335
         End
         Begin VB.CommandButton FIN_button 
            Caption         =   "FIN"
            Height          =   255
            Left            =   120
            TabIndex        =   26
            Top             =   6000
            Width           =   1335
         End
         Begin VB.CommandButton TOUT_button 
            Caption         =   "TOUT"
            Height          =   255
            Left            =   120
            TabIndex        =   25
            Top             =   3840
            Width           =   1335
         End
         Begin VB.CommandButton DES_QUE_button 
            Caption         =   "DES QUE"
            Height          =   255
            Left            =   120
            TabIndex        =   24
            Top             =   4560
            Width           =   1335
         End
         Begin VB.CommandButton ARRET_button 
            Caption         =   "ARRET"
            Height          =   255
            Left            =   120
            TabIndex        =   23
            Top             =   3120
            Width           =   1335
         End
         Begin VB.CommandButton EXECUTE_M_button 
            Caption         =   "EXECUTE-"
            Height          =   255
            Left            =   120
            TabIndex        =   22
            Top             =   2040
            Width           =   1335
         End
         Begin VB.CommandButton EXECUTE_P_button 
            Caption         =   "EXECUTE+"
            Height          =   255
            Left            =   120
            TabIndex        =   21
            Top             =   1680
            Width           =   1335
         End
         Begin VB.CommandButton EXECUTE_button 
            Caption         =   "EXECUTE"
            Height          =   255
            Left            =   120
            TabIndex        =   20
            Top             =   1320
            Width           =   1335
         End
         Begin VB.CommandButton C_EST_button 
            Caption         =   "C'EST"
            Height          =   255
            Left            =   120
            TabIndex        =   19
            Top             =   960
            Width           =   1335
         End
         Begin VB.CommandButton APPRENDS_button 
            Caption         =   "APPRENDS"
            Height          =   255
            Left            =   120
            TabIndex        =   18
            ToolTipText     =   "blabla"
            Top             =   600
            Width           =   1335
         End
      End
   End
   Begin VB.Frame Image_Treatment 
      Caption         =   "Images"
      Height          =   10695
      Left            =   120
      TabIndex        =   0
      Top             =   0
      Width           =   3015
      Begin VB.CommandButton Calibrate_T3 
         Caption         =   "Calibrer T3"
         Height          =   255
         Left            =   1800
         TabIndex        =   157
         ToolTipText     =   "Open the calibration window"
         Top             =   10320
         Width           =   1095
      End
      Begin VB.CheckBox UseCorrections 
         Caption         =   "Utiliser corrections"
         Height          =   255
         Left            =   120
         TabIndex        =   156
         ToolTipText     =   "Use corrections for image drawing"
         Top             =   10320
         Value           =   1  'Checked
         Width           =   1695
      End
      Begin VB.CommandButton selectImage_Button 
         Caption         =   "Select. Image"
         Height          =   255
         Left            =   120
         TabIndex        =   9
         ToolTipText     =   "Select a SVG image"
         Top             =   1800
         Width           =   1335
      End
      Begin VB.CommandButton Generate_Command_List 
         Caption         =   "Generer commandes"
         Height          =   255
         Left            =   1080
         TabIndex        =   8
         ToolTipText     =   "Generate the list of card to draw the image and show a preview"
         Top             =   9600
         Width           =   1815
      End
      Begin VB.CommandButton Send_Image_To_T3 
         Caption         =   "Envoyer vers T3"
         Height          =   255
         Left            =   1080
         TabIndex        =   7
         ToolTipText     =   "Generate the list of card to draw the image and send it to the T3"
         Top             =   9960
         Width           =   1815
      End
      Begin VB.TextBox imagePath 
         Height          =   285
         Left            =   120
         TabIndex        =   6
         Top             =   1440
         Width           =   2775
      End
      Begin VB.TextBox imageEditorPath 
         Height          =   315
         Left            =   120
         TabIndex        =   5
         Top             =   480
         Width           =   2775
      End
      Begin VB.CommandButton SelectImageEditorButton 
         Caption         =   "Select. Editeur"
         Height          =   255
         Left            =   120
         TabIndex        =   4
         ToolTipText     =   "Select an external  SVG image editor"
         Top             =   840
         Width           =   1455
      End
      Begin VB.CommandButton EditImage 
         Caption         =   "Editer Image"
         Height          =   255
         Left            =   1560
         TabIndex        =   3
         ToolTipText     =   "Edit SVG image in the external editor"
         Top             =   1800
         Width           =   1335
      End
      Begin VB.TextBox TextCommandList 
         Height          =   7095
         Left            =   120
         MultiLine       =   -1  'True
         ScrollBars      =   3  'Both
         TabIndex        =   2
         Top             =   2400
         Width           =   2775
      End
      Begin VB.TextBox Size 
         Height          =   285
         Left            =   360
         TabIndex        =   1
         ToolTipText     =   "Size of the image reproduction"
         Top             =   9840
         Width           =   375
      End
      Begin MSCommLib.MSComm MSComm1 
         Left            =   1920
         Top             =   4440
         _ExtentX        =   1005
         _ExtentY        =   1005
         _Version        =   393216
         DTREnable       =   -1  'True
         BaudRate        =   1200
         StopBits        =   2
      End
      Begin VB.Label LabelImage 
         Caption         =   "Chemin de l'image :"
         Height          =   255
         Left            =   120
         TabIndex        =   15
         Top             =   1200
         Width           =   1935
      End
      Begin VB.Label LabelEditor 
         Caption         =   "Chemin éditeur d'image :"
         Height          =   255
         Left            =   120
         TabIndex        =   14
         Top             =   240
         Width           =   2055
      End
      Begin VB.Label LabelCommandList 
         Caption         =   "Liste de commandes :"
         Height          =   255
         Left            =   120
         TabIndex        =   13
         Top             =   2160
         Width           =   2775
      End
      Begin VB.Label LabelScale 
         Caption         =   "Taille : TxT"
         Height          =   255
         Left            =   120
         TabIndex        =   12
         Top             =   9600
         Width           =   855
      End
      Begin VB.Label Label1 
         Caption         =   "T="
         Height          =   255
         Left            =   120
         TabIndex        =   11
         Top             =   9840
         Width           =   255
      End
      Begin VB.Label Label2 
         Caption         =   "cm"
         Height          =   255
         Left            =   720
         TabIndex        =   10
         Top             =   9840
         Width           =   255
      End
   End
End
Attribute VB_Name = "T3_Manager"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private Declare Sub InitCommonControls Lib "COMCTL32.DLL" ()

Public cardList As cardListClass
Public lineList As Collection

Private Sub ALLUME_button_Click()
    cardButtonPressed cardList.listByName.Item("ALLUME")
End Sub

Private Sub APPRENDS_button_Click()
    cardButtonPressed cardList.listByName.Item("APPRENDS")
End Sub

Private Sub ARC_AVD_10_button_Click()
    cardButtonPressed cardList.listByName.Item("ARC_AVD_10")
End Sub

Private Sub ARC_AVD_20_button_Click()
    cardButtonPressed cardList.listByName.Item("ARC_AVD_20")
End Sub

Private Sub ARC_AVD_5_button_Click()
    cardButtonPressed cardList.listByName.Item("ARC_AVD_5")
End Sub

Private Sub ARC_AVG_10_button_Click()
    cardButtonPressed cardList.listByName.Item("ARC_AVG_10")
End Sub

Private Sub ARC_AVG_20_button_Click()
    cardButtonPressed cardList.listByName.Item("ARC_AVG_20")
End Sub

Private Sub ARC_AVG_5_button_Click()
    cardButtonPressed cardList.listByName.Item("ARC_AVG_5")
End Sub

Private Sub ARRET_button_Click()
    cardButtonPressed cardList.listByName.Item("ARRET")
End Sub

Private Sub AV_1_button_Click()
    cardButtonPressed cardList.listByName.Item("AV_1")
End Sub

Private Sub AV_10_button_Click()
    cardButtonPressed cardList.listByName.Item("AV_10")
End Sub

Private Sub AV_20_button_Click()
    cardButtonPressed cardList.listByName.Item("AV_20")
End Sub

Private Sub B_C_button_Click()
    cardButtonPressed cardList.listByName.Item("B_C")
End Sub

Private Sub C_EST_button_Click()
    cardButtonPressed cardList.listByName.Item("C_EST")
End Sub

Private Sub Calibrate_T3_Click()
    Calibration.Visible = True
End Sub

Private Sub ClearProgramCommandList_Click()
    ProgramCommandList.Clear
End Sub

Private Sub CLIGNE_D_button_Click()
    cardButtonPressed cardList.listByName.Item("CLIGNE_D")
End Sub

Private Sub CLIGNE_G_button_Click()
    cardButtonPressed cardList.listByName.Item("CLIGNE_G")
End Sub

Private Sub Com_Number_Change()
    EcritDansFichierIni "com", "comNumber", Com_Number.text, App.Path & "\T3 Manager.ini"
End Sub

Private Sub Combo_Com_Setting_Click()
    EcritDansFichierIni "com", "comSetting", Combo_Com_Setting.text, App.Path & "\T3 Manager.ini"
End Sub

Private Sub Scrolling_Mod_Button_Click()
    Scrolling_Mod.Visible = True
End Sub

Private Sub Show_Manual_Click()
    Dim execID As Integer
    execID = Shell("C:\WINDOWS\explorer.exe "".\Documentation Tortue T3.pdf""", 1)
End Sub

Private Sub DES_QUE_button_Click()
    cardButtonPressed cardList.listByName.Item("DES_QUE")
End Sub

Private Sub EditImage_Click()
    Dim execID As Integer
    If (imageEditorPath.text = "") Then: selectImageEditor
    If (imagePath.text = "") Then: selectImage
    If ((programEditorPath.text <> "") And (programPath.text <> "")) Then execID = Shell(imageEditorPath.text & " """ & imagePath.text & """", 3)
End Sub

Private Sub EditProgram_Click()
    Dim execID As Integer
    If (programEditorPath.text = "") Then: selectProgramEditor
    If (programPath.text = "") Then: selectProgram
    If ((programEditorPath.text <> "") And (programPath.text <> "")) Then execID = Shell("""" & programEditorPath.text & """ """ & programPath.text & """", 3)
End Sub

Private Sub ETEINS_button_Click()
    cardButtonPressed cardList.listByName.Item("ETEINS")
End Sub

Private Sub ETEINS_D_button_Click()
    cardButtonPressed cardList.listByName.Item("ETEINS_D")
End Sub

Private Sub ETEINS_G_button_Click()
    cardButtonPressed cardList.listByName.Item("ETEINS_G")
End Sub

Private Sub EXECUTE_button_Click()
    cardButtonPressed cardList.listByName.Item("EXECUTE")
End Sub

Private Sub EXECUTE_M_button_Click()
    cardButtonPressed cardList.listByName.Item("EXECUTE_M")
End Sub

Private Sub EXECUTE_P_button_Click()
    cardButtonPressed cardList.listByName.Item("EXECUTE_P")
End Sub

Private Sub FIN_button_Click()
    cardButtonPressed cardList.listByName.Item("FIN")
End Sub

Private Sub Form_Initialize()
    InitCommonControls
End Sub

Private Sub Form_Load()
    imagePath.text = LitDansFichierIni("path", "imagePath", App.Path & "\T3 Manager.ini", "")
    imageEditorPath.text = LitDansFichierIni("path", "imageEditorPath", App.Path & "\T3 Manager.ini", "")
    Size.text = LitDansFichierIni("transformation", "size", App.Path & "\T3 Manager.ini", 30)
    
    programPath.text = LitDansFichierIni("path", "programPath", App.Path & "\T3 Manager.ini", "")
    programEditorPath.text = LitDansFichierIni("path", "programEditorPath", App.Path & "\T3 Manager.ini", "")
    
    Combo_Com_Setting.text = LitDansFichierIni("com", "comSetting", App.Path & "\T3 Manager.ini", "1200,N,8,2")
    Com_Number.text = LitDansFichierIni("com", "comNumber", App.Path & "\T3 Manager.ini", "1")
    
    AV_1_button.ToolTipText = LitDansFichierIni("text", "AV_1", App.Path & "\T3 Manager.ini", "")
    AV_10_button.ToolTipText = LitDansFichierIni("text", "AV_10", App.Path & "\T3 Manager.ini", "")
    AV_20_button.ToolTipText = LitDansFichierIni("text", "AV_20", App.Path & "\T3 Manager.ini", "")
    RE_1_button.ToolTipText = LitDansFichierIni("text", "RE_1", App.Path & "\T3 Manager.ini", "")
    RE_10_button.ToolTipText = LitDansFichierIni("text", "RE_10", App.Path & "\T3 Manager.ini", "")
    RE_20_button.ToolTipText = LitDansFichierIni("text", "RE_20", App.Path & "\T3 Manager.ini", "")
    TG_1_button.ToolTipText = LitDansFichierIni("text", "TG_1", App.Path & "\T3 Manager.ini", "")
    TG_15_button.ToolTipText = LitDansFichierIni("text", "TG_15", App.Path & "\T3 Manager.ini", "")
    TG_30_button.ToolTipText = LitDansFichierIni("text", "TG_30", App.Path & "\T3 Manager.ini", "")
    TG_45_button.ToolTipText = LitDansFichierIni("text", "TG_45", App.Path & "\T3 Manager.ini", "")
    TG_60_button.ToolTipText = LitDansFichierIni("text", "TG_60", App.Path & "\T3 Manager.ini", "")
    TG_90_button.ToolTipText = LitDansFichierIni("text", "TG_90", App.Path & "\T3 Manager.ini", "")
    TG_120_button.ToolTipText = LitDansFichierIni("text", "TG_120", App.Path & "\T3 Manager.ini", "")
    TD_1_button.ToolTipText = LitDansFichierIni("text", "TD_1", App.Path & "\T3 Manager.ini", "")
    TD_15_button.ToolTipText = LitDansFichierIni("text", "TD_15", App.Path & "\T3 Manager.ini", "")
    TD_30_button.ToolTipText = LitDansFichierIni("text", "TD_30", App.Path & "\T3 Manager.ini", "")
    TD_45_button.ToolTipText = LitDansFichierIni("text", "TD_45", App.Path & "\T3 Manager.ini", "")
    TD_60_button.ToolTipText = LitDansFichierIni("text", "TD_60", App.Path & "\T3 Manager.ini", "")
    TD_90_button.ToolTipText = LitDansFichierIni("text", "TD_90", App.Path & "\T3 Manager.ini", "")
    TD_120_button.ToolTipText = LitDansFichierIni("text", "TD_120", App.Path & "\T3 Manager.ini", "")
    
    B_C_button.ToolTipText = LitDansFichierIni("text", "B_C", App.Path & "\T3 Manager.ini", "")
    L_C_button.ToolTipText = LitDansFichierIni("text", "L_C", App.Path & "\T3 Manager.ini", "")
    RALE_button.ToolTipText = LitDansFichierIni("text", "RALE", App.Path & "\T3 Manager.ini", "")
    SONNE_button.ToolTipText = LitDansFichierIni("text", "SONNE", App.Path & "\T3 Manager.ini", "")
    JOUE_AIR_button.ToolTipText = LitDansFichierIni("text", "JOUE_AIR", App.Path & "\T3 Manager.ini", "")
    ALLUME_button.ToolTipText = LitDansFichierIni("text", "ALLUME", App.Path & "\T3 Manager.ini", "")
    ETEINS_button.ToolTipText = LitDansFichierIni("text", "ETEINS", App.Path & "\T3 Manager.ini", "")
    ETEINS_G_button.ToolTipText = LitDansFichierIni("text", "ETEINS_G", App.Path & "\T3 Manager.ini", "")
    ETEINS_D_button.ToolTipText = LitDansFichierIni("text", "ETEINS_D", App.Path & "\T3 Manager.ini", "")
    CLIGNE_G_button.ToolTipText = LitDansFichierIni("text", "CLIGNE_G", App.Path & "\T3 Manager.ini", "")
    CLIGNE_D_button.ToolTipText = LitDansFichierIni("text", "CLIGNE_D", App.Path & "\T3 Manager.ini", "")
    ARC_AVG_5_button.ToolTipText = LitDansFichierIni("text", "ARC_AVG_5", App.Path & "\T3 Manager.ini", "")
    ARC_AVG_10_button.ToolTipText = LitDansFichierIni("text", "ARC_AVG_10", App.Path & "\T3 Manager.ini", "")
    ARC_AVG_20_button.ToolTipText = LitDansFichierIni("text", "ARC_AVG_20", App.Path & "\T3 Manager.ini", "")
    ARC_AVD_5_button.ToolTipText = LitDansFichierIni("text", "ARC_AVD_5", App.Path & "\T3 Manager.ini", "")
    ARC_AVD_10_button.ToolTipText = LitDansFichierIni("text", "ARC_AVD_10", App.Path & "\T3 Manager.ini", "")
    ARC_AVD_20_button.ToolTipText = LitDansFichierIni("text", "ARC_AVD_20", App.Path & "\T3 Manager.ini", "")
    
    REGLAGE_button.ToolTipText = LitDansFichierIni("text", "REGLAGE", App.Path & "\T3 Manager.ini", "")
    TEST_button.ToolTipText = LitDansFichierIni("text", "TEST", App.Path & "\T3 Manager.ini", "")
    TOUCHE_AVG_button.ToolTipText = LitDansFichierIni("text", "TOUCHE_AVG", App.Path & "\T3 Manager.ini", "")
    TOUCHE_AVD_button.ToolTipText = LitDansFichierIni("text", "TOUCHE_AVD", App.Path & "\T3 Manager.ini", "")
    TOUCHE_AR_button.ToolTipText = LitDansFichierIni("text", "TOUCHE_AR", App.Path & "\T3 Manager.ini", "")
    TOUCHE_STOP_button.ToolTipText = LitDansFichierIni("text", "TOUCHE_STOP", App.Path & "\T3 Manager.ini", "")
    DES_QUE_button.ToolTipText = LitDansFichierIni("text", "DES_QUE", App.Path & "\T3 Manager.ini", "")
    C_EST_button.ToolTipText = LitDansFichierIni("text", "C_EST", App.Path & "\T3 Manager.ini", "")
    FIN_button.ToolTipText = LitDansFichierIni("text", "FIN", App.Path & "\T3 Manager.ini", "")
    SUPPRIME_button.ToolTipText = LitDansFichierIni("text", "SUPPRIME", App.Path & "\T3 Manager.ini", "")
    OUBLIE_button.ToolTipText = LitDansFichierIni("text", "OUBLIE", App.Path & "\T3 Manager.ini", "")
    APPRENDS_button.ToolTipText = LitDansFichierIni("text", "APPRENDS", App.Path & "\T3 Manager.ini", "")
    GOMME_button.ToolTipText = LitDansFichierIni("text", "GOMME", App.Path & "\T3 Manager.ini", "")
    EXECUTE_button.ToolTipText = LitDansFichierIni("text", "EXECUTE", App.Path & "\T3 Manager.ini", "")
    EXECUTE_P_button.ToolTipText = LitDansFichierIni("text", "EXECUTE_P", App.Path & "\T3 Manager.ini", "")
    EXECUTE_M_button.ToolTipText = LitDansFichierIni("text", "EXECUTE_M", App.Path & "\T3 Manager.ini", "")
    TOUT_button.ToolTipText = LitDansFichierIni("text", "TOUT", App.Path & "\T3 Manager.ini", "")
    ARRET_button.ToolTipText = LitDansFichierIni("text", "ARRET", App.Path & "\T3 Manager.ini", "")
        
    PROCEDURE_N1_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N1", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N2_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N2", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N3_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N3", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N4_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N4", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N5_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N5", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N6_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N6", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N7_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N7", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N8_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N8", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N9_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N9", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N10_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N10", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N11_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N11", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N12_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N12", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N13_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N13", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N14_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N14", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N15_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N15", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N16_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N16", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N17_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N17", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N18_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N18", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N19_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N19", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N20_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N20", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N21_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N21", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N22_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N22", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N23_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N23", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N24_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N24", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N25_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N25", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N26_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N26", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N27_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N27", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N28_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N28", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N29_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N29", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N30_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N30", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N31_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N31", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N32_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N32", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N33_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N33", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N34_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N34", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N35_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N35", App.Path & "\T3 Manager.ini", "")
    PROCEDURE_N36_button.ToolTipText = LitDansFichierIni("text", "PROCEDURE_N36", App.Path & "\T3 Manager.ini", "")
    
    Set cardList = New cardListClass
End Sub

Private Sub Generate_Command_List_Click()
    Dim nbComm As Integer
    
    If (imagePath.text = "") Then: selectImage
    If (imagePath.text <> "") Then
        nbComm = Generate_Code(lineList, cardList.listByName)
        Preview.Visible = True
        printAll lineList
    End If
End Sub

Private Sub GOMME_button_Click()
    cardButtonPressed cardList.listByName.Item("GOMME")
End Sub

Private Sub JOUE_AIR_button_Click()
    cardButtonPressed cardList.listByName.Item("JOUE_AIR")
End Sub

Private Sub L_C_button_Click()
    cardButtonPressed cardList.listByName.Item("L_C")
End Sub

Private Sub LoadProgram_Click()
    Dim command As String
    Open programPath For Input As #1
    command = ""
    On Error Resume Next
    Input #1, command
    On Error GoTo 0
    ProgramCommandList.Clear
    Do While command <> ""
        ProgramCommandList.AddItem (command)
        command = ""
        On Error Resume Next
        Input #1, command
        On Error GoTo 0
    Loop
    Close #1
End Sub

Private Sub MoveCommandDown_Click()
    Dim index As Integer
    Dim temp As String
    index = ProgramCommandList.ListIndex
    If (index > -1) And (index + 1 < ProgramCommandList.ListCount) Then
        temp = ProgramCommandList.list(index)
        ProgramCommandList.list(index) = ProgramCommandList.list(index + 1)
        ProgramCommandList.list(index + 1) = temp
        ProgramCommandList.ListIndex = index + 1
    End If
End Sub

Private Sub MoveCommandUp_Click()
    Dim index As Integer
    Dim temp As String
    index = ProgramCommandList.ListIndex
    If (index > 0) And (index < ProgramCommandList.ListCount) Then
        temp = ProgramCommandList.list(index)
        ProgramCommandList.list(index) = ProgramCommandList.list(index - 1)
        ProgramCommandList.list(index - 1) = temp
        ProgramCommandList.ListIndex = index - 1
    End If
End Sub

Private Sub RemoveCommand_Click()
    Dim index As Integer
    index = ProgramCommandList.ListIndex
    If index <> -1 Then
        ProgramCommandList.RemoveItem (index)
        If ProgramCommandList.ListCount = 0 Then ProgramCommandList.ListIndex = -1
        If (index = ProgramCommandList.ListCount) Then
            ProgramCommandList.ListIndex = ProgramCommandList.ListCount - 1
        Else
            ProgramCommandList.ListIndex = index
        End If
    End If
End Sub

Private Sub SaveProgram_Click()
    Dim i As Integer
    Dim command As String
    Open programPath For Output As #1
    For i = 0 To ProgramCommandList.ListCount - 1
        Print #1, ProgramCommandList.list(i)
    Next
    Close #1
    EcritDansFichierIni "path", "programPath", programPath.text, App.Path & "\T3 Manager.ini"
End Sub

Private Sub selectImage_Button_Click()
    selectImage
End Sub

Private Sub OUBLIE_button_Click()
    cardButtonPressed cardList.listByName.Item("OUBLIE")
End Sub

Private Sub PROCEDURE_N1_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N1")
End Sub

Private Sub PROCEDURE_N10_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N10")
End Sub

Private Sub PROCEDURE_N11_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N11")
End Sub

Private Sub PROCEDURE_N12_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N12")
End Sub

Private Sub PROCEDURE_N13_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N13")
End Sub

Private Sub PROCEDURE_N14_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N14")
End Sub

Private Sub PROCEDURE_N15_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N15")
End Sub

Private Sub PROCEDURE_N16_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N16")
End Sub

Private Sub PROCEDURE_N17_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N17")
End Sub

Private Sub PROCEDURE_N18_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N18")
End Sub

Private Sub PROCEDURE_N19_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N19")
End Sub

Private Sub PROCEDURE_N2_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N2")
End Sub

Private Sub PROCEDURE_N20_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N20")
End Sub

Private Sub PROCEDURE_N21_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N21")
End Sub

Private Sub PROCEDURE_N22_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N22")
End Sub

Private Sub PROCEDURE_N23_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N23")
End Sub

Private Sub PROCEDURE_N24_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N24")
End Sub

Private Sub PROCEDURE_N25_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N25")
End Sub

Private Sub PROCEDURE_N26_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N26")
End Sub

Private Sub PROCEDURE_N27_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N27")
End Sub

Private Sub PROCEDURE_N28_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N28")
End Sub

Private Sub PROCEDURE_N29_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N29")
End Sub

Private Sub PROCEDURE_N3_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N3")
End Sub

Private Sub PROCEDURE_N30_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N30")
End Sub

Private Sub PROCEDURE_N31_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N31")
End Sub

Private Sub PROCEDURE_N32_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N32")
End Sub

Private Sub PROCEDURE_N33_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N33")
End Sub

Private Sub PROCEDURE_N34_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N34")
End Sub

Private Sub PROCEDURE_N35_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N35")
End Sub

Private Sub PROCEDURE_N36_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N36")
End Sub

Private Sub PROCEDURE_N4_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N4")
End Sub

Private Sub PROCEDURE_N5_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N5")
End Sub

Private Sub PROCEDURE_N6_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N6")
End Sub

Private Sub PROCEDURE_N7_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N7")
End Sub

Private Sub PROCEDURE_N8_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N8")
End Sub

Private Sub PROCEDURE_N9_button_Click()
    cardButtonPressed cardList.listByName.Item("PROCEDURE_N9")
End Sub

Private Sub RALE_button_Click()
    cardButtonPressed cardList.listByName.Item("RALE")
End Sub

Private Sub RE_1_button_Click()
    cardButtonPressed cardList.listByName.Item("RE_1")
End Sub

Private Sub RE_10_button_Click()
    cardButtonPressed cardList.listByName.Item("RE_10")
End Sub

Private Sub RE_20_button_Click()
    cardButtonPressed cardList.listByName.Item("RE_20")
End Sub

Private Sub REGLAGE_button_Click()
    cardButtonPressed cardList.listByName.Item("REGLAGE")
End Sub

Private Sub SelectImageEditorButton_Click()
    selectImageEditor
End Sub

Private Sub selectProgram_Button_Click()
    selectProgram
End Sub

Private Sub SelectProgramEditorButton_Click()
    selectProgramEditor
End Sub

Private Sub Send_Image_To_T3_Click()
    Dim nbComm As Integer
    Dim lineList As Collection
    
    If (imagePath.text = "") Then: selectImage
    If (imagePath.text <> "") Then
        nbComm = Generate_Code(lineList, cardList.listByName)
        Line_Send lineList, nbComm
    End If
End Sub

Private Sub Send_Program_Step_Backward_To_T3_Click()
    Dim index As Integer
    Dim revert As String
    index = ProgramCommandList.ListIndex
    If index > 0 Then
        revert = cardList.listByName(ProgramCommandList.list(index - 1)).revert
        If revert <> "" Then CommSendSingle cardList.listByName(revert)
        If index <> 0 Then ProgramCommandList.ListIndex = index - 1
    End If
End Sub

Private Sub Send_Program_Step_Forward_To_T3_Click()
    Dim index As Integer
    index = ProgramCommandList.ListIndex
    If index <> -1 Then
        CommSendSingle cardList.listByName(ProgramCommandList.list(index))
        If index <> ProgramCommandList.ListCount - 1 Then ProgramCommandList.ListIndex = index + 1
    End If
End Sub

Private Sub Send_Program_To_T3_Click()
    If ProgramCommandList.ListCount <> 0 Then program_Send
End Sub

Private Sub Size_Change()
    EcritDansFichierIni "transformation", "size", Size.text, App.Path & "\T3 Manager.ini"
End Sub

Private Sub SONNE_button_Click()
    cardButtonPressed cardList.listByName.Item("SONNE")
End Sub

Private Sub SUPPRIME_button_Click()
    cardButtonPressed cardList.listByName.Item("SUPPRIME")
End Sub

Private Sub TD_1_button_Click()
    cardButtonPressed cardList.listByName.Item("TD_1")
End Sub

Private Sub TD_120_button_Click()
    cardButtonPressed cardList.listByName.Item("TD_120")
End Sub

Private Sub TD_15_button_Click()
    cardButtonPressed cardList.listByName.Item("TD_15")
End Sub

Private Sub TD_30_button_Click()
    cardButtonPressed cardList.listByName.Item("TD_30")
End Sub

Private Sub TD_45_button_Click()
    cardButtonPressed cardList.listByName.Item("TD_45")
End Sub

Private Sub TD_60_button_Click()
    cardButtonPressed cardList.listByName.Item("TD_60")
End Sub

Private Sub TD_90_button_Click()
    cardButtonPressed cardList.listByName.Item("TD_90")
End Sub

Private Sub TEST_button_Click()
    cardButtonPressed cardList.listByName.Item("TEST")
End Sub

Private Sub TG_1_button_Click()
    cardButtonPressed cardList.listByName.Item("TG_1")
End Sub

Private Sub TG_120_button_Click()
    cardButtonPressed cardList.listByName.Item("TG_120")
End Sub

Private Sub TG_15_button_Click()
    cardButtonPressed cardList.listByName.Item("TG_15")
End Sub

Private Sub TG_30_button_Click()
    cardButtonPressed cardList.listByName.Item("TG_30")
End Sub

Private Sub TG_45_button_Click()
    cardButtonPressed cardList.listByName.Item("TG_45")
End Sub

Private Sub TG_60_button_Click()
    cardButtonPressed cardList.listByName.Item("TG_60")
End Sub

Private Sub TG_90_button_Click()
    cardButtonPressed cardList.listByName.Item("TG_90")
End Sub

Private Sub TOUCHE_AR_button_Click()
    cardButtonPressed cardList.listByName.Item("TOUCHE_AR")
End Sub

Private Sub TOUCHE_AVD_button_Click()
    cardButtonPressed cardList.listByName.Item("TOUCHE_AVD")
End Sub

Private Sub TOUCHE_AVG_button_Click()
    cardButtonPressed cardList.listByName.Item("TOUCHE_AVG")
End Sub

Private Sub TOUCHE_STOP_button_Click()
    cardButtonPressed cardList.listByName.Item("TOUCHE_STOP")
End Sub

Private Sub TOUT_button_Click()
    cardButtonPressed cardList.listByName.Item("TOUT")
End Sub

Public Function selectImageEditor()
  Dim Path As String
  Path = OuvrirUnFichier(Me.hWnd, "Select a SVG image editor", 1, "Executable Files", "exe")
  If Path <> "" Then
      imageEditorPath.text = Path
      EcritDansFichierIni "path", "imageEditorPath", imageEditorPath.text, App.Path & "\T3 Manager.ini"
  End If
End Function

Public Function selectImage()
    Dim Path As String
    Path = OuvrirUnFichier(Me.hWnd, "Select a SVG image", 1, "SVG Files", "svg")
    If Path <> "" Then
        imagePath.text = Path
        EcritDansFichierIni "path", "imagePath", imagePath.text, App.Path & "\T3 Manager.ini"
    End If
End Function

Public Function selectProgramEditor()
  Dim Path As String
  Path = OuvrirUnFichier(Me.hWnd, "Select a texte editor", 1, "Executable Files", "exe")
  If Path <> "" Then
      programEditorPath.text = Path
      EcritDansFichierIni "path", "programEditorPath", programEditorPath.text, App.Path & "\T3 Manager.ini"
  End If
End Function

Public Function selectProgram()
    Dim Path As String
    Path = OuvrirUnFichier(Me.hWnd, "Select a program", 1, "T3 program", "t3p")
    If Path <> "" Then
        programPath.text = Path
        EcritDansFichierIni "path", "programPath", programPath.text, App.Path & "\T3 Manager.ini"
    End If
End Function


Public Function cardButtonPressed(card As CardClass)
    Dim index As Integer
    If (programming.value = 1) Then
        index = ProgramCommandList.ListIndex
        If Insert = 1 Then
            If index <> -1 Then
                ProgramCommandList.AddItem card.name, index
            Else
                ProgramCommandList.AddItem card.name
            End If
        Else
            ProgramCommandList.AddItem card.name
        End If
    Else
        CommSendSingle card
    End If
End Function

Private Sub UseCorrections_Click()
    T3_Manager.cardList.init
End Sub
