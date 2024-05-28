VERSION 5.00
Begin VB.Form Scrolling_Mod_Configuration 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Configuration mode défilement"
   ClientHeight    =   9810
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   13575
   Icon            =   "Scrolling_Mod_Configuration.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   9810
   ScaleWidth      =   13575
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame2 
      Caption         =   "Options"
      Height          =   1335
      Left            =   120
      TabIndex        =   1
      Top             =   8280
      Width           =   13335
      Begin VB.TextBox confirm_time 
         Height          =   285
         Left            =   1920
         TabIndex        =   206
         Top             =   600
         Width           =   615
      End
      Begin VB.ComboBox confirm_mod 
         Height          =   315
         ItemData        =   "Scrolling_Mod_Configuration.frx":1CCA
         Left            =   3000
         List            =   "Scrolling_Mod_Configuration.frx":1CD7
         TabIndex        =   205
         Text            =   "Nom"
         Top             =   600
         Width           =   1095
      End
      Begin VB.ComboBox sound_mod 
         Height          =   315
         ItemData        =   "Scrolling_Mod_Configuration.frx":1CF3
         Left            =   3480
         List            =   "Scrolling_Mod_Configuration.frx":1D00
         TabIndex        =   204
         Text            =   "Nom"
         Top             =   240
         Width           =   975
      End
      Begin VB.CheckBox Auto_Return 
         Caption         =   "Retour automatique aux catégories après carte"
         Height          =   255
         Left            =   6600
         TabIndex        =   203
         Top             =   240
         Width           =   3735
      End
      Begin VB.CheckBox Use_Category 
         Caption         =   "Utiliser catégorie"
         Height          =   255
         Left            =   4800
         TabIndex        =   202
         Top             =   240
         Width           =   1575
      End
      Begin VB.TextBox scroll_time 
         Height          =   285
         Left            =   1800
         TabIndex        =   2
         Top             =   240
         Width           =   615
      End
      Begin VB.Label Label15 
         Caption         =   "ms"
         Height          =   255
         Left            =   2640
         TabIndex        =   208
         Top             =   600
         Width           =   255
      End
      Begin VB.Label Label14 
         Caption         =   "Temps de confirmation :"
         Height          =   255
         Left            =   120
         TabIndex        =   207
         Top             =   600
         Width           =   1815
      End
      Begin VB.Label Label13 
         Caption         =   "Son :"
         Height          =   255
         Left            =   3000
         TabIndex        =   201
         Top             =   240
         Width           =   375
      End
      Begin VB.Label Label1 
         Caption         =   "Temps de défilement :"
         Height          =   255
         Left            =   120
         TabIndex        =   4
         Top             =   240
         Width           =   1815
      End
      Begin VB.Label Label2 
         Caption         =   "ms"
         Height          =   255
         Left            =   2520
         TabIndex        =   3
         Top             =   240
         Width           =   255
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Cartes"
      Height          =   8055
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   13335
      Begin VB.Frame Frame6 
         BackColor       =   &H00FF0000&
         Height          =   7695
         Left            =   7560
         TabIndex        =   8
         Top             =   240
         Width           =   5655
         Begin VB.TextBox PROCEDURE_N36_Text 
            Height          =   285
            Left            =   4680
            TabIndex        =   190
            Top             =   6600
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N20_Text 
            Height          =   285
            Left            =   4680
            TabIndex        =   189
            Top             =   840
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N19_Text 
            Height          =   285
            Left            =   4680
            TabIndex        =   188
            Top             =   480
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N21_Text 
            Height          =   285
            Left            =   4680
            TabIndex        =   187
            Top             =   1200
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N35_Text 
            Height          =   285
            Left            =   4680
            TabIndex        =   186
            Top             =   6240
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N34_Text 
            Height          =   285
            Left            =   4680
            TabIndex        =   185
            Top             =   5880
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N32_Text 
            Height          =   285
            Left            =   4680
            TabIndex        =   184
            Top             =   5160
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N31_Text 
            Height          =   285
            Left            =   4680
            TabIndex        =   183
            Top             =   4800
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N33_Text 
            Height          =   285
            Left            =   4680
            TabIndex        =   182
            Top             =   5520
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N29_Text 
            Height          =   285
            Left            =   4680
            TabIndex        =   181
            Top             =   4080
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N28_Text 
            Height          =   285
            Left            =   4680
            TabIndex        =   180
            Top             =   3720
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N30_Text 
            Height          =   285
            Left            =   4680
            TabIndex        =   179
            Top             =   4440
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N26_Text 
            Height          =   285
            Left            =   4680
            TabIndex        =   178
            Top             =   3000
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N25_Text 
            Height          =   285
            Left            =   4680
            TabIndex        =   177
            Top             =   2640
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N27_Text 
            Height          =   285
            Left            =   4680
            TabIndex        =   176
            Top             =   3360
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N23_Text 
            Height          =   285
            Left            =   4680
            TabIndex        =   175
            Top             =   1920
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N22_Text 
            Height          =   285
            Left            =   4680
            TabIndex        =   174
            Top             =   1560
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N24_Text 
            Height          =   285
            Left            =   4680
            TabIndex        =   173
            Top             =   2280
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N18_Text 
            Height          =   285
            Left            =   1920
            TabIndex        =   172
            Top             =   6600
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N2_Text 
            Height          =   285
            Left            =   1920
            TabIndex        =   171
            Top             =   840
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N1_Text 
            Height          =   285
            Left            =   1920
            TabIndex        =   170
            Top             =   480
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N3_Text 
            Height          =   285
            Left            =   1920
            TabIndex        =   169
            Top             =   1200
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N17_Text 
            Height          =   285
            Left            =   1920
            TabIndex        =   168
            Top             =   6240
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N16_Text 
            Height          =   285
            Left            =   1920
            TabIndex        =   167
            Top             =   5880
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N14_Text 
            Height          =   285
            Left            =   1920
            TabIndex        =   166
            Top             =   5160
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N13_Text 
            Height          =   285
            Left            =   1920
            TabIndex        =   165
            Top             =   4800
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N15_Text 
            Height          =   285
            Left            =   1920
            TabIndex        =   164
            Top             =   5520
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N11_Text 
            Height          =   285
            Left            =   1920
            TabIndex        =   163
            Top             =   4080
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N10_Text 
            Height          =   285
            Left            =   1920
            TabIndex        =   162
            Top             =   3720
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N12_Text 
            Height          =   285
            Left            =   1920
            TabIndex        =   161
            Top             =   4440
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N8_Text 
            Height          =   285
            Left            =   1920
            TabIndex        =   160
            Top             =   3000
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N7_Text 
            Height          =   285
            Left            =   1920
            TabIndex        =   159
            Top             =   2640
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N9_Text 
            Height          =   285
            Left            =   1920
            TabIndex        =   158
            Top             =   3360
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N5_Text 
            Height          =   285
            Left            =   1920
            TabIndex        =   157
            Top             =   1920
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N4_Text 
            Height          =   285
            Left            =   1920
            TabIndex        =   156
            Top             =   1560
            Width           =   855
         End
         Begin VB.TextBox PROCEDURE_N6_Text 
            Height          =   285
            Left            =   1920
            TabIndex        =   155
            Top             =   2280
            Width           =   855
         End
         Begin VB.CheckBox PROCEDURE_N20_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°20"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   2880
            TabIndex        =   99
            Top             =   840
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N19_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°19"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   2880
            TabIndex        =   98
            Top             =   480
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N18_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°18"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   120
            TabIndex        =   97
            Top             =   6600
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N17_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°17"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   120
            TabIndex        =   96
            Top             =   6240
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N36_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°36"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   2880
            TabIndex        =   95
            Top             =   6600
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N16_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°16"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   120
            TabIndex        =   94
            Top             =   5880
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N35_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°35"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   2880
            TabIndex        =   93
            Top             =   6240
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N15_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°15"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   120
            TabIndex        =   92
            Top             =   5520
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N34_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°34"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   2880
            TabIndex        =   91
            Top             =   5880
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N14_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°14"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   120
            TabIndex        =   90
            Top             =   5160
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N33_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°33"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   2880
            TabIndex        =   89
            Top             =   5520
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N13_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°13"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   120
            TabIndex        =   88
            Top             =   4800
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N32_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°32"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   2880
            TabIndex        =   87
            Top             =   5160
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N12_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°12"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   120
            TabIndex        =   86
            Top             =   4440
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N31_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°31"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   2880
            TabIndex        =   85
            Top             =   4800
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N11_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°11"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   120
            TabIndex        =   84
            Top             =   4080
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N30_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°30"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   2880
            TabIndex        =   83
            Top             =   4440
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N10_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°10"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   120
            TabIndex        =   82
            Top             =   3720
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N29_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°29"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   2880
            TabIndex        =   81
            Top             =   4080
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N9_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°9"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   120
            TabIndex        =   80
            Top             =   3360
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N28_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°28"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   2880
            TabIndex        =   79
            Top             =   3720
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N8_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°8"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   120
            TabIndex        =   78
            Top             =   3000
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N27_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°27"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   2880
            TabIndex        =   77
            Top             =   3360
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N7_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°7"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   120
            TabIndex        =   76
            Top             =   2640
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N26_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°26"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   2880
            TabIndex        =   75
            Top             =   3000
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N6_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°6"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   120
            TabIndex        =   74
            Top             =   2280
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N25_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°25"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   2880
            TabIndex        =   73
            Top             =   2640
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N5_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°5"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   120
            TabIndex        =   72
            Top             =   1920
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N24_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°24"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   2880
            TabIndex        =   71
            Top             =   2280
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N4_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°4"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   120
            TabIndex        =   70
            Top             =   1560
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N23_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°23"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   2880
            TabIndex        =   69
            Top             =   1920
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N3_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°3"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   120
            TabIndex        =   68
            Top             =   1200
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N22_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°22"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   2880
            TabIndex        =   67
            Top             =   1560
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N2_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°2"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   120
            TabIndex        =   66
            Top             =   840
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N21_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°21"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   2880
            TabIndex        =   65
            Top             =   1200
            Width           =   1815
         End
         Begin VB.CheckBox PROCEDURE_N1_check 
            BackColor       =   &H00FF0000&
            Caption         =   "PROCEDURE N°1"
            ForeColor       =   &H80000009&
            Height          =   255
            Left            =   120
            TabIndex        =   64
            Top             =   480
            Width           =   1815
         End
         Begin VB.Label Label12 
            BackColor       =   &H00FF0000&
            Caption         =   "Catégories :"
            Height          =   255
            Left            =   4680
            TabIndex        =   200
            Top             =   240
            Width           =   855
         End
         Begin VB.Label Label11 
            BackColor       =   &H00FF0000&
            Caption         =   "Actif :"
            Height          =   255
            Left            =   2880
            TabIndex        =   199
            Top             =   240
            Width           =   855
         End
         Begin VB.Label Label10 
            BackColor       =   &H00FF0000&
            Caption         =   "Catégories :"
            Height          =   255
            Left            =   1920
            TabIndex        =   198
            Top             =   240
            Width           =   855
         End
         Begin VB.Label Label9 
            BackColor       =   &H00FF0000&
            Caption         =   "Actif :"
            Height          =   255
            Left            =   120
            TabIndex        =   197
            Top             =   240
            Width           =   855
         End
      End
      Begin VB.Frame Frame5 
         BackColor       =   &H000000FF&
         Height          =   7695
         Left            =   4800
         TabIndex        =   7
         Top             =   240
         Width           =   2655
         Begin VB.TextBox TOUCHE_STOP_Text 
            Height          =   285
            Left            =   1680
            TabIndex        =   154
            Top             =   6600
            Width           =   855
         End
         Begin VB.TextBox APPRENDS_Text 
            Height          =   285
            Left            =   1680
            TabIndex        =   153
            Top             =   840
            Width           =   855
         End
         Begin VB.TextBox OUBLIE_Text 
            Height          =   285
            Left            =   1680
            TabIndex        =   152
            Top             =   480
            Width           =   855
         End
         Begin VB.TextBox C_EST_Text 
            Height          =   285
            Left            =   1680
            TabIndex        =   151
            Top             =   1200
            Width           =   855
         End
         Begin VB.TextBox FIN_Text 
            Height          =   285
            Left            =   1680
            TabIndex        =   150
            Top             =   6240
            Width           =   855
         End
         Begin VB.TextBox TOUCHE_AR_Text 
            Height          =   285
            Left            =   1680
            TabIndex        =   149
            Top             =   5880
            Width           =   855
         End
         Begin VB.TextBox TOUCHE_AVG_Text 
            Height          =   285
            Left            =   1680
            TabIndex        =   148
            Top             =   5160
            Width           =   855
         End
         Begin VB.TextBox DES_QUE_Text 
            Height          =   285
            Left            =   1680
            TabIndex        =   147
            Top             =   4800
            Width           =   855
         End
         Begin VB.TextBox TOUCHE_AVD_Text 
            Height          =   285
            Left            =   1680
            TabIndex        =   146
            Top             =   5520
            Width           =   855
         End
         Begin VB.TextBox Tout_Text 
            Height          =   285
            Left            =   1680
            TabIndex        =   145
            Top             =   4080
            Width           =   855
         End
         Begin VB.TextBox SUPPRIME_Text 
            Height          =   285
            Left            =   1680
            TabIndex        =   144
            Top             =   3720
            Width           =   855
         End
         Begin VB.TextBox REGLAGE_Text 
            Height          =   285
            Left            =   1680
            TabIndex        =   143
            Top             =   4440
            Width           =   855
         End
         Begin VB.TextBox TEST_Text 
            Height          =   285
            Left            =   1680
            TabIndex        =   142
            Top             =   3000
            Width           =   855
         End
         Begin VB.TextBox GOMME_Text 
            Height          =   285
            Left            =   1680
            TabIndex        =   141
            Top             =   2640
            Width           =   855
         End
         Begin VB.TextBox ARRET_Text 
            Height          =   285
            Left            =   1680
            TabIndex        =   140
            Top             =   3360
            Width           =   855
         End
         Begin VB.TextBox EXECUTE_P_Text 
            Height          =   285
            Left            =   1680
            TabIndex        =   139
            Top             =   1920
            Width           =   855
         End
         Begin VB.TextBox EXECUTE_Text 
            Height          =   285
            Left            =   1680
            TabIndex        =   138
            Top             =   1560
            Width           =   855
         End
         Begin VB.TextBox EXECUTE_M_Text 
            Height          =   285
            Left            =   1680
            TabIndex        =   137
            Top             =   2280
            Width           =   855
         End
         Begin VB.CheckBox TOUCHE_STOP_check 
            BackColor       =   &H000000FF&
            Caption         =   "TOUCHE STOP"
            Height          =   255
            Left            =   120
            TabIndex        =   63
            Top             =   6600
            Width           =   1455
         End
         Begin VB.CheckBox FIN_check 
            BackColor       =   &H000000FF&
            Caption         =   "FIN"
            Height          =   255
            Left            =   120
            TabIndex        =   62
            Top             =   6240
            Width           =   1455
         End
         Begin VB.CheckBox TOUCHE_AR_check 
            BackColor       =   &H000000FF&
            Caption         =   "TOUCHE AR"
            Height          =   255
            Left            =   120
            TabIndex        =   61
            Top             =   5880
            Width           =   1455
         End
         Begin VB.CheckBox TOUCHE_AVD_check 
            BackColor       =   &H000000FF&
            Caption         =   "TOUCHE AVD"
            Height          =   255
            Left            =   120
            TabIndex        =   60
            Top             =   5520
            Width           =   1455
         End
         Begin VB.CheckBox TOUCHE_AVG_check 
            BackColor       =   &H000000FF&
            Caption         =   "TOUCHE_AVG"
            Height          =   255
            Left            =   120
            TabIndex        =   59
            Top             =   5160
            Width           =   1455
         End
         Begin VB.CheckBox DES_QUE_check 
            BackColor       =   &H000000FF&
            Caption         =   "DES QUE"
            Height          =   255
            Left            =   120
            TabIndex        =   58
            Top             =   4800
            Width           =   1335
         End
         Begin VB.CheckBox REGLAGE_check 
            BackColor       =   &H000000FF&
            Caption         =   "REGLAGE"
            Height          =   255
            Left            =   120
            TabIndex        =   57
            Top             =   4440
            Width           =   1335
         End
         Begin VB.CheckBox TOUT_check 
            BackColor       =   &H000000FF&
            Caption         =   "TOUT"
            Height          =   255
            Left            =   120
            TabIndex        =   56
            Top             =   4080
            Width           =   1335
         End
         Begin VB.CheckBox SUPPRIME_check 
            BackColor       =   &H000000FF&
            Caption         =   "SUPPRIME"
            Height          =   255
            Left            =   120
            TabIndex        =   55
            Top             =   3720
            Width           =   1335
         End
         Begin VB.CheckBox ARRET_check 
            BackColor       =   &H000000FF&
            Caption         =   "ARRET"
            Height          =   255
            Left            =   120
            TabIndex        =   54
            Top             =   3360
            Width           =   1215
         End
         Begin VB.CheckBox TEST_check 
            BackColor       =   &H000000FF&
            Caption         =   "TEST"
            Height          =   255
            Left            =   120
            TabIndex        =   53
            Top             =   3000
            Width           =   1335
         End
         Begin VB.CheckBox GOMME_check 
            BackColor       =   &H000000FF&
            Caption         =   "GOMME"
            Height          =   255
            Left            =   120
            TabIndex        =   52
            Top             =   2640
            Width           =   1335
         End
         Begin VB.CheckBox EXECUTE_M_check 
            BackColor       =   &H000000FF&
            Caption         =   "EXECUTE-"
            Height          =   255
            Left            =   120
            TabIndex        =   51
            Top             =   2280
            Width           =   1335
         End
         Begin VB.CheckBox EXECUTE_P_check 
            BackColor       =   &H000000FF&
            Caption         =   "EXECUTE+"
            Height          =   255
            Left            =   120
            TabIndex        =   50
            Top             =   1920
            Width           =   1455
         End
         Begin VB.CheckBox EXECUTE_check 
            BackColor       =   &H000000FF&
            Caption         =   "EXECUTE"
            Height          =   255
            Left            =   120
            TabIndex        =   49
            Top             =   1560
            Width           =   1335
         End
         Begin VB.CheckBox C_EST_check 
            BackColor       =   &H000000FF&
            Caption         =   "C'EST"
            Height          =   255
            Left            =   120
            TabIndex        =   48
            Top             =   1200
            Width           =   1455
         End
         Begin VB.CheckBox APPRENDS_check 
            BackColor       =   &H000000FF&
            Caption         =   "APPRENDS"
            Height          =   255
            Left            =   120
            TabIndex        =   47
            Top             =   840
            Width           =   1335
         End
         Begin VB.CheckBox OUBLIE_check 
            BackColor       =   &H000000FF&
            Caption         =   "OUBLIE"
            Height          =   255
            Left            =   120
            TabIndex        =   46
            Top             =   480
            Width           =   1335
         End
         Begin VB.Label Label8 
            BackColor       =   &H000000FF&
            Caption         =   "Catégories :"
            Height          =   255
            Left            =   1680
            TabIndex        =   196
            Top             =   240
            Width           =   855
         End
         Begin VB.Label Label7 
            BackColor       =   &H000000FF&
            Caption         =   "Actif :"
            Height          =   255
            Left            =   120
            TabIndex        =   195
            Top             =   240
            Width           =   855
         End
      End
      Begin VB.Frame Frame4 
         BackColor       =   &H0000FF00&
         Height          =   7695
         Left            =   2280
         TabIndex        =   6
         Top             =   240
         Width           =   2415
         Begin VB.TextBox ARC_AVG_10_Text 
            Height          =   285
            Left            =   1440
            TabIndex        =   136
            Top             =   840
            Width           =   855
         End
         Begin VB.TextBox ARC_AVG_5_Text 
            Height          =   285
            Left            =   1440
            TabIndex        =   135
            Top             =   480
            Width           =   855
         End
         Begin VB.TextBox ARC_AVG_20_Text 
            Height          =   285
            Left            =   1440
            TabIndex        =   134
            Top             =   1200
            Width           =   855
         End
         Begin VB.TextBox JOUE_AIR_Text 
            Height          =   285
            Left            =   1440
            TabIndex        =   133
            Top             =   6240
            Width           =   855
         End
         Begin VB.TextBox RALE_Text 
            Height          =   285
            Left            =   1440
            TabIndex        =   132
            Top             =   5880
            Width           =   855
         End
         Begin VB.TextBox ETEINS_D_Text 
            Height          =   285
            Left            =   1440
            TabIndex        =   131
            Top             =   5160
            Width           =   855
         End
         Begin VB.TextBox ETEINS_G_Text 
            Height          =   285
            Left            =   1440
            TabIndex        =   130
            Top             =   4800
            Width           =   855
         End
         Begin VB.TextBox SONNE_Text 
            Height          =   285
            Left            =   1440
            TabIndex        =   129
            Top             =   5520
            Width           =   855
         End
         Begin VB.TextBox CLIGNE_D_Text 
            Height          =   285
            Left            =   1440
            TabIndex        =   128
            Top             =   4080
            Width           =   855
         End
         Begin VB.TextBox CLIGNE_G_Text 
            Height          =   285
            Left            =   1440
            TabIndex        =   127
            Top             =   3720
            Width           =   855
         End
         Begin VB.TextBox ETEINS_Text 
            Height          =   285
            Left            =   1440
            TabIndex        =   126
            Top             =   4440
            Width           =   855
         End
         Begin VB.TextBox B_C_Text 
            Height          =   285
            Left            =   1440
            TabIndex        =   125
            Top             =   3000
            Width           =   855
         End
         Begin VB.TextBox L_C_Text 
            Height          =   285
            Left            =   1440
            TabIndex        =   124
            Top             =   2640
            Width           =   855
         End
         Begin VB.TextBox ALLUME_Text 
            Height          =   285
            Left            =   1440
            TabIndex        =   123
            Top             =   3360
            Width           =   855
         End
         Begin VB.TextBox ARC_AVD_10_Text 
            Height          =   285
            Left            =   1440
            TabIndex        =   122
            Top             =   1920
            Width           =   855
         End
         Begin VB.TextBox ARC_AVD_5_Text 
            Height          =   285
            Left            =   1440
            TabIndex        =   121
            Top             =   1560
            Width           =   855
         End
         Begin VB.TextBox ARC_AVD_20_Text 
            Height          =   285
            Left            =   1440
            TabIndex        =   120
            Top             =   2280
            Width           =   855
         End
         Begin VB.CheckBox ARC_AVG_5_check 
            BackColor       =   &H0000FF00&
            Caption         =   "ARC AVG 5"
            Height          =   255
            Left            =   120
            TabIndex        =   45
            Top             =   480
            Width           =   1335
         End
         Begin VB.CheckBox ARC_AVG_10_check 
            BackColor       =   &H0000FF00&
            Caption         =   "ARC AVG 10"
            Height          =   255
            Left            =   120
            TabIndex        =   44
            Top             =   840
            Width           =   1335
         End
         Begin VB.CheckBox ARC_AVG_20_check 
            BackColor       =   &H0000FF00&
            Caption         =   "ARC AVG 20"
            Height          =   255
            Left            =   120
            TabIndex        =   43
            Top             =   1200
            Width           =   1335
         End
         Begin VB.CheckBox ARC_AVD_5_check 
            BackColor       =   &H0000FF00&
            Caption         =   "ARC AVD 5"
            Height          =   255
            Left            =   120
            TabIndex        =   42
            Top             =   1560
            Width           =   1335
         End
         Begin VB.CheckBox ARC_AVD_10_check 
            BackColor       =   &H0000FF00&
            Caption         =   "ARC AVD 10"
            Height          =   255
            Left            =   120
            TabIndex        =   41
            Top             =   1920
            Width           =   1335
         End
         Begin VB.CheckBox ARC_AVD_20_check 
            BackColor       =   &H0000FF00&
            Caption         =   "ARC AVD 20"
            Height          =   255
            Left            =   120
            TabIndex        =   40
            Top             =   2280
            Width           =   1335
         End
         Begin VB.CheckBox L_C_check 
            BackColor       =   &H0000FF00&
            Caption         =   "L_C"
            Height          =   255
            Left            =   120
            TabIndex        =   39
            Top             =   2640
            Width           =   1335
         End
         Begin VB.CheckBox B_C_check 
            BackColor       =   &H0000FF00&
            Caption         =   "B_C"
            Height          =   255
            Left            =   120
            TabIndex        =   38
            Top             =   3000
            Width           =   1335
         End
         Begin VB.CheckBox ALLUME_check 
            BackColor       =   &H0000FF00&
            Caption         =   "ALLUME"
            Height          =   255
            Left            =   120
            TabIndex        =   37
            Top             =   3360
            Width           =   1335
         End
         Begin VB.CheckBox ETEINS_check 
            BackColor       =   &H0000FF00&
            Caption         =   "ETEINS"
            Height          =   255
            Left            =   120
            TabIndex        =   36
            Top             =   4440
            Width           =   1335
         End
         Begin VB.CheckBox CLIGNE_G_check 
            BackColor       =   &H0000FF00&
            Caption         =   "CLIGNE G"
            Height          =   255
            Left            =   120
            TabIndex        =   35
            Top             =   3720
            Width           =   1335
         End
         Begin VB.CheckBox CLIGNE_D_check 
            BackColor       =   &H0000FF00&
            Caption         =   "CLIGNE D"
            Height          =   255
            Left            =   120
            TabIndex        =   34
            Top             =   4080
            Width           =   1335
         End
         Begin VB.CheckBox SONNE_check 
            BackColor       =   &H0000FF00&
            Caption         =   "SONNE"
            Height          =   255
            Left            =   120
            TabIndex        =   33
            Top             =   5520
            Width           =   1095
         End
         Begin VB.CheckBox RALE_check 
            BackColor       =   &H0000FF00&
            Caption         =   "RALE"
            Height          =   255
            Left            =   120
            TabIndex        =   32
            Top             =   5880
            Width           =   1215
         End
         Begin VB.CheckBox JOUE_AIR_check 
            BackColor       =   &H0000FF00&
            Caption         =   "JOUE AIR"
            Height          =   255
            Left            =   120
            TabIndex        =   31
            Top             =   6240
            Width           =   1215
         End
         Begin VB.CheckBox ETEINS_G_check 
            BackColor       =   &H0000FF00&
            Caption         =   "ETEINS G"
            Height          =   255
            Left            =   120
            TabIndex        =   30
            Top             =   4800
            Width           =   1215
         End
         Begin VB.CheckBox ETEINS_D_check 
            BackColor       =   &H0000FF00&
            Caption         =   "ETEINS D"
            Height          =   255
            Left            =   120
            TabIndex        =   29
            Top             =   5160
            Width           =   1215
         End
         Begin VB.Label Label6 
            BackColor       =   &H0000FF00&
            Caption         =   "Catégories :"
            Height          =   255
            Left            =   1440
            TabIndex        =   194
            Top             =   240
            Width           =   855
         End
         Begin VB.Label Label5 
            BackColor       =   &H0000FF00&
            Caption         =   "Actif :"
            Height          =   255
            Left            =   120
            TabIndex        =   193
            Top             =   240
            Width           =   855
         End
      End
      Begin VB.Frame Frame3 
         BackColor       =   &H80000009&
         Height          =   7695
         Left            =   120
         TabIndex        =   5
         Top             =   240
         Width           =   2055
         Begin VB.TextBox AV_10_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   119
            Top             =   840
            Width           =   855
         End
         Begin VB.TextBox AV_1_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   118
            Top             =   480
            Width           =   855
         End
         Begin VB.TextBox AV_20_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   117
            Top             =   1200
            Width           =   855
         End
         Begin VB.TextBox TD_120_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   116
            Top             =   7320
            Width           =   855
         End
         Begin VB.TextBox TD_90_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   115
            Top             =   6960
            Width           =   855
         End
         Begin VB.TextBox TD_45_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   114
            Top             =   6240
            Width           =   855
         End
         Begin VB.TextBox TD_30_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   113
            Top             =   5880
            Width           =   855
         End
         Begin VB.TextBox TD_60_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   112
            Top             =   6600
            Width           =   855
         End
         Begin VB.TextBox TD_1_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   111
            Top             =   5160
            Width           =   855
         End
         Begin VB.TextBox TG_120_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   110
            Top             =   4800
            Width           =   855
         End
         Begin VB.TextBox TD_15_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   109
            Top             =   5520
            Width           =   855
         End
         Begin VB.TextBox TG_60_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   108
            Top             =   4080
            Width           =   855
         End
         Begin VB.TextBox TG_45_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   107
            Top             =   3720
            Width           =   855
         End
         Begin VB.TextBox TG_90_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   106
            Top             =   4440
            Width           =   855
         End
         Begin VB.TextBox TG_15_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   105
            Top             =   3000
            Width           =   855
         End
         Begin VB.TextBox TG_1_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   104
            Top             =   2640
            Width           =   855
         End
         Begin VB.TextBox TG_30_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   103
            Top             =   3360
            Width           =   855
         End
         Begin VB.TextBox RE_10_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   102
            Top             =   1920
            Width           =   855
         End
         Begin VB.TextBox RE_1_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   101
            Top             =   1560
            Width           =   855
         End
         Begin VB.TextBox RE_20_Text 
            Height          =   285
            Left            =   1080
            TabIndex        =   100
            Top             =   2280
            Width           =   855
         End
         Begin VB.CheckBox TD_120_Check 
            BackColor       =   &H80000009&
            Caption         =   "TD 120"
            Height          =   255
            Left            =   120
            TabIndex        =   28
            Top             =   7320
            Width           =   855
         End
         Begin VB.CheckBox TG_120_Check 
            BackColor       =   &H80000009&
            Caption         =   "TG 120"
            Height          =   255
            Left            =   120
            TabIndex        =   27
            Top             =   4800
            Width           =   855
         End
         Begin VB.CheckBox TD_90_Check 
            BackColor       =   &H80000009&
            Caption         =   "TD 90"
            Height          =   255
            Left            =   120
            TabIndex        =   26
            Top             =   6960
            Width           =   855
         End
         Begin VB.CheckBox TD_60_Check 
            BackColor       =   &H80000009&
            Caption         =   "TD 60"
            Height          =   255
            Left            =   120
            TabIndex        =   25
            Top             =   6600
            Width           =   855
         End
         Begin VB.CheckBox TD_45_Check 
            BackColor       =   &H80000009&
            Caption         =   "TD 45"
            Height          =   255
            Left            =   120
            TabIndex        =   24
            Top             =   6240
            Width           =   855
         End
         Begin VB.CheckBox TD_30_Check 
            BackColor       =   &H80000009&
            Caption         =   "TD 30"
            Height          =   255
            Left            =   120
            TabIndex        =   23
            Top             =   5880
            Width           =   855
         End
         Begin VB.CheckBox TD_15_Check 
            BackColor       =   &H80000009&
            Caption         =   "TD 15"
            Height          =   255
            Left            =   120
            TabIndex        =   22
            Top             =   5520
            Width           =   855
         End
         Begin VB.CheckBox TD_1_Check 
            BackColor       =   &H80000009&
            Caption         =   "TD_1"
            Height          =   255
            Left            =   120
            TabIndex        =   21
            Top             =   5160
            Width           =   855
         End
         Begin VB.CheckBox TG_90_Check 
            BackColor       =   &H80000009&
            Caption         =   "TG 90"
            Height          =   255
            Left            =   120
            TabIndex        =   20
            Top             =   4440
            Width           =   855
         End
         Begin VB.CheckBox TG_60_Check 
            BackColor       =   &H80000009&
            Caption         =   "TG 60"
            Height          =   255
            Left            =   120
            TabIndex        =   19
            Top             =   4080
            Width           =   855
         End
         Begin VB.CheckBox TG_45_Check 
            BackColor       =   &H80000009&
            Caption         =   "TG 45"
            Height          =   255
            Left            =   120
            TabIndex        =   18
            Top             =   3720
            Width           =   855
         End
         Begin VB.CheckBox TG_30_Check 
            BackColor       =   &H80000009&
            Caption         =   "TG 30"
            Height          =   255
            Left            =   120
            TabIndex        =   17
            Top             =   3360
            Width           =   855
         End
         Begin VB.CheckBox TG_15_Check 
            BackColor       =   &H80000009&
            Caption         =   "TG 15"
            Height          =   255
            Left            =   120
            TabIndex        =   16
            Top             =   3000
            Width           =   855
         End
         Begin VB.CheckBox TG_1_Check 
            BackColor       =   &H80000009&
            Caption         =   "TG_1"
            Height          =   255
            Left            =   120
            TabIndex        =   15
            Top             =   2640
            Width           =   855
         End
         Begin VB.CheckBox RE_20_Check 
            BackColor       =   &H80000009&
            Caption         =   "RE 20"
            Height          =   255
            Left            =   120
            TabIndex        =   14
            Top             =   2280
            Width           =   855
         End
         Begin VB.CheckBox RE_10_Check 
            BackColor       =   &H80000009&
            Caption         =   "RE 10"
            Height          =   255
            Left            =   120
            TabIndex        =   13
            Top             =   1920
            Width           =   855
         End
         Begin VB.CheckBox RE_1_Check 
            BackColor       =   &H80000009&
            Caption         =   "RE 1"
            Height          =   255
            Left            =   120
            TabIndex        =   12
            Top             =   1560
            Width           =   855
         End
         Begin VB.CheckBox AV_20_Check 
            BackColor       =   &H80000009&
            Caption         =   "AV 20"
            Height          =   255
            Left            =   120
            TabIndex        =   11
            Top             =   1200
            Width           =   855
         End
         Begin VB.CheckBox AV_10_Check 
            BackColor       =   &H80000009&
            Caption         =   "AV 10"
            Height          =   255
            Left            =   120
            TabIndex        =   10
            Top             =   840
            Width           =   855
         End
         Begin VB.CheckBox AV_1_Check 
            BackColor       =   &H80000009&
            Caption         =   "AV 1"
            Height          =   255
            Left            =   120
            TabIndex        =   9
            Top             =   480
            Width           =   855
         End
         Begin VB.Label Label4 
            BackColor       =   &H80000009&
            Caption         =   "Catégories :"
            Height          =   255
            Left            =   1080
            TabIndex        =   192
            Top             =   240
            Width           =   855
         End
         Begin VB.Label Label3 
            BackColor       =   &H80000009&
            Caption         =   "Actif :"
            Height          =   255
            Left            =   120
            TabIndex        =   191
            Top             =   240
            Width           =   855
         End
      End
   End
End
Attribute VB_Name = "Scrolling_Mod_Configuration"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub ALLUME_check_Click()
    save_scrollConfiguration
End Sub

Private Sub ALLUME_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub APPRENDS_check_Click()
    save_scrollConfiguration
End Sub

Private Sub APPRENDS_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub ARC_AVD_10_check_Click()
    save_scrollConfiguration
End Sub

Private Sub ARC_AVD_10_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub ARC_AVD_20_check_Click()
    save_scrollConfiguration
End Sub

Private Sub ARC_AVD_20_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub ARC_AVD_5_check_Click()
    save_scrollConfiguration
End Sub

Private Sub ARC_AVD_5_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub ARC_AVG_10_check_Click()
    save_scrollConfiguration
End Sub

Private Sub ARC_AVG_10_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub ARC_AVG_20_check_Click()
    save_scrollConfiguration
End Sub

Private Sub ARC_AVG_20_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub ARC_AVG_5_check_Click()
    save_scrollConfiguration
End Sub

Private Sub ARC_AVG_5_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub ARRET_check_Click()
    save_scrollConfiguration
End Sub

Private Sub ARRET_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub Auto_Return_Click()
    save_scrollConfiguration
End Sub

Private Sub AV_1_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub AV_1_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub AV_10_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub AV_10_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub AV_20_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub AV_20_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub B_C_check_Click()
    save_scrollConfiguration
End Sub

Private Sub B_C_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub C_EST_check_Click()
    save_scrollConfiguration
End Sub

Private Sub CLIGN_D_check_Click()
    save_scrollConfiguration
End Sub

Private Sub CLIGN_G_check_Click()
    save_scrollConfiguration
End Sub

Private Sub C_EST_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub CLIGNE_D_check_Click()
    save_scrollConfiguration
End Sub

Private Sub CLIGNE_D_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub CLIGNE_G_check_Click()
    save_scrollConfiguration
End Sub

Private Sub CLIGNE_G_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub confirm_mod_Click()
    save_scrollConfiguration
End Sub

Private Sub confirm_time_Change()
    save_scrollConfiguration
End Sub

Private Sub DES_QUE_check_Click()
    save_scrollConfiguration
End Sub

Private Sub DES_QUE_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub ETEINS_check_Click()
    save_scrollConfiguration
End Sub

Private Sub ETEINS_D_check_Click()
    save_scrollConfiguration
End Sub

Private Sub ETEINS_D_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub ETEINS_G_check_Click()
    save_scrollConfiguration
End Sub

Private Sub ETEINS_G_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub ETEINS_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub EXECUTE_check_Click()
    save_scrollConfiguration
End Sub

Private Sub EXECUTE_M_check_Click()
    save_scrollConfiguration
End Sub

Private Sub EXECUTE_M_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub EXECUTE_P_check_Click()
    save_scrollConfiguration
End Sub

Private Sub FINcheck_Click()
    save_scrollConfiguration
End Sub

Private Sub EXECUTE_P_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub EXECUTE_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub FIN_check_Click()
    save_scrollConfiguration
End Sub

Private Sub FIN_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub Form_Load()
    Scrolling_Mod.load_scrollConfiguration
End Sub

Private Sub GOMME_check_Click()
    save_scrollConfiguration
End Sub

Private Sub GOMME_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub JOUE_AIR_check_Click()
    save_scrollConfiguration
End Sub

Private Sub JOUE_AIR_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub L_C_check_Click()
    save_scrollConfiguration
End Sub

Private Sub L_C_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub OUBLIE_check_Click()
    save_scrollConfiguration
End Sub

Private Sub OUBLIE_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N1_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N1_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N10_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N10_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N11_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N11_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N12_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N12_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N13_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N13_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N14_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N14_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N15_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N15_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N16_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N16_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N17_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N17_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N18_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N18_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N19_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N19_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N2_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N2_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N20_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N20_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N21_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N21_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N22_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N22_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N23_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N23_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N24_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N24_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N25_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N25_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N26_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N26_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N27_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N27_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N28_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N28_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N29_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N29_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N3_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N3_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N30_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N30_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N31_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N31_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N32_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N32_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N33_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N33_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N34_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N34_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N35_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N35_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N36_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N36_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N4_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N4_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N5_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N5_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N6_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N6_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N7_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N7_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N8_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N8_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N9_check_Click()
    save_scrollConfiguration
End Sub

Private Sub PROCEDURE_N9_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub RALE_check_Click()
    save_scrollConfiguration
End Sub

Private Sub RALE_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub RE_1_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub RE_1_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub RE_10_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub RE_10_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub RE_20_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub RE_20_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub REGLAGE_check_Click()
    save_scrollConfiguration
End Sub

Private Sub REGLAGE_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub scroll_time_Change()
    save_scrollConfiguration
    If scroll_time.text <> "" Then
        Scrolling_Mod.Scroll_Timer.Interval = CInt(scroll_time.text)
    End If
End Sub

Public Function save_scrollConfiguration()
    If Not Scrolling_Mod.loading = 1 Then
        EcritDansFichierIni "scrolling", "AV_1", AV_1_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "AV_10", AV_10_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "AV_20", AV_20_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "RE_1", RE_1_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "RE_10", RE_10_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "RE_20", RE_20_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TG_1", TG_1_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TG_15", TG_15_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TG_30", TG_30_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TG_45", TG_45_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TG_60", TG_60_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TG_90", TG_90_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TG_120", TG_120_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TD_1", TD_1_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TD_15", TD_15_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TD_30", TD_30_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TD_45", TD_45_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TD_60", TD_60_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TD_90", TD_90_Check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TD_120", TD_120_Check.value, App.Path & "\T3 Manager.ini"
        
        EcritDansFichierIni "scrolling", "B_C", B_C_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "L_C", L_C_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "RALE", RALE_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "SONNE", SONNE_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "JOUE_AIR", JOUE_AIR_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "ALLUME", ALLUME_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "ETEINS", ETEINS_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "ETEINS_G", ETEINS_G_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "ETEINS_D", ETEINS_D_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "CLIGNE_G", CLIGNE_G_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "CLIGNE_D", CLIGNE_D_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "ARC_AVG_5", ARC_AVG_5_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "ARC_AVG_10", ARC_AVG_10_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "ARC_AVG_20", ARC_AVG_20_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "ARC_AVD_5", ARC_AVD_5_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "ARC_AVD_10", ARC_AVD_10_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "ARC_AVD_20", ARC_AVD_20_check.value, App.Path & "\T3 Manager.ini"
        
        EcritDansFichierIni "scrolling", "REGLAGE", REGLAGE_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TEST", TEST_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TOUCHE_AVG", TOUCHE_AVG_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TOUCHE_AVD", TOUCHE_AVD_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TOUCHE_AR", TOUCHE_AR_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TOUCHE_STOP", TOUCHE_STOP_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "DES_QUE", DES_QUE_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "C_EST", C_EST_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "FIN", FIN_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "SUPPRIME", SUPPRIME_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "OUBLIE", OUBLIE_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "APPRENDS", APPRENDS_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "GOMME", GOMME_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "EXECUTE", EXECUTE_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "EXECUTE_P", EXECUTE_P_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "EXECUTE_M", EXECUTE_M_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "TOUT", TOUT_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "ARRET", ARRET_check.value, App.Path & "\T3 Manager.ini"
    
        EcritDansFichierIni "scrolling", "PROCEDURE_N1", PROCEDURE_N1_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N2", PROCEDURE_N2_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N3", PROCEDURE_N3_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N4", PROCEDURE_N4_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N5", PROCEDURE_N5_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N6", PROCEDURE_N6_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N7", PROCEDURE_N7_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N8", PROCEDURE_N8_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N9", PROCEDURE_N9_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N10", PROCEDURE_N10_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N11", PROCEDURE_N11_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N12", PROCEDURE_N12_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N13", PROCEDURE_N13_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N14", PROCEDURE_N14_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N15", PROCEDURE_N15_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N16", PROCEDURE_N16_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N17", PROCEDURE_N17_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N18", PROCEDURE_N18_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N19", PROCEDURE_N19_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N20", PROCEDURE_N20_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N21", PROCEDURE_N21_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N22", PROCEDURE_N22_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N23", PROCEDURE_N23_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N24", PROCEDURE_N24_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N25", PROCEDURE_N25_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N26", PROCEDURE_N26_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N27", PROCEDURE_N27_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N28", PROCEDURE_N28_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N29", PROCEDURE_N29_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N30", PROCEDURE_N30_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N31", PROCEDURE_N31_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N32", PROCEDURE_N32_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N33", PROCEDURE_N33_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N34", PROCEDURE_N34_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N35", PROCEDURE_N35_check.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scrolling", "PROCEDURE_N36", PROCEDURE_N36_check.value, App.Path & "\T3 Manager.ini"
        
        EcritDansFichierIni "category", "AV_1", AV_1_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "AV_10", AV_10_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "AV_20", AV_20_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "RE_1", RE_1_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "RE_10", RE_10_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "RE_20", RE_20_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TG_1", TG_1_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TG_15", TG_15_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TG_30", TG_30_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TG_45", TG_45_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TG_60", TG_60_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TG_90", TG_90_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TG_120", TG_120_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TD_1", TD_1_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TD_15", TD_15_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TD_30", TD_30_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TD_45", TD_45_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TD_60", TD_60_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TD_90", TD_90_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TD_120", TD_120_Text.text, App.Path & "\T3 Manager.ini"
        
        EcritDansFichierIni "category", "B_C", B_C_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "L_C", L_C_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "RALE", RALE_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "SONNE", SONNE_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "JOUE_AIR", JOUE_AIR_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "ALLUME", ALLUME_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "ETEINS", ETEINS_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "ETEINS_G", ETEINS_G_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "ETEINS_D", ETEINS_D_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "CLIGNE_G", CLIGNE_G_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "CLIGNE_D", CLIGNE_D_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "ARC_AVG_5", ARC_AVG_5_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "ARC_AVG_10", ARC_AVG_10_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "ARC_AVG_20", ARC_AVG_20_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "ARC_AVD_5", ARC_AVD_5_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "ARC_AVD_10", ARC_AVD_10_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "ARC_AVD_20", ARC_AVD_20_Text.text, App.Path & "\T3 Manager.ini"
        
        EcritDansFichierIni "category", "REGLAGE", REGLAGE_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TEST", TEST_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TOUCHE_AVG", TOUCHE_AVG_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TOUCHE_AVD", TOUCHE_AVD_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TOUCHE_AR", TOUCHE_AR_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TOUCHE_STOP", TOUCHE_STOP_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "DES_QUE", DES_QUE_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "C_EST", C_EST_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "FIN", FIN_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "SUPPRIME", SUPPRIME_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "OUBLIE", OUBLIE_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "APPRENDS", APPRENDS_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "GOMME", GOMME_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "EXECUTE", EXECUTE_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "EXECUTE_P", EXECUTE_P_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "EXECUTE_M", EXECUTE_M_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "TOUT", Tout_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "ARRET", ARRET_Text.text, App.Path & "\T3 Manager.ini"
    
        EcritDansFichierIni "category", "PROCEDURE_N1", PROCEDURE_N1_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N2", PROCEDURE_N2_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N3", PROCEDURE_N3_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N4", PROCEDURE_N4_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N5", PROCEDURE_N5_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N6", PROCEDURE_N6_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N7", PROCEDURE_N7_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N8", PROCEDURE_N8_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N9", PROCEDURE_N9_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N10", PROCEDURE_N10_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N11", PROCEDURE_N11_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N12", PROCEDURE_N12_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N13", PROCEDURE_N13_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N14", PROCEDURE_N14_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N15", PROCEDURE_N15_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N16", PROCEDURE_N16_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N17", PROCEDURE_N17_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N18", PROCEDURE_N18_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N19", PROCEDURE_N19_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N20", PROCEDURE_N20_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N21", PROCEDURE_N21_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N22", PROCEDURE_N22_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N23", PROCEDURE_N23_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N24", PROCEDURE_N24_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N25", PROCEDURE_N25_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N26", PROCEDURE_N26_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N27", PROCEDURE_N27_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N28", PROCEDURE_N28_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N29", PROCEDURE_N29_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N30", PROCEDURE_N30_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N31", PROCEDURE_N31_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N32", PROCEDURE_N32_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N33", PROCEDURE_N33_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N34", PROCEDURE_N34_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N35", PROCEDURE_N35_Text.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "category", "PROCEDURE_N36", PROCEDURE_N36_Text.text, App.Path & "\T3 Manager.ini"
            
        EcritDansFichierIni "scroll", "useCategory", Use_Category.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scroll", "autoReturn", Auto_Return.value, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scroll", "scrollingTime", scroll_time.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scroll", "soundMod", sound_mod.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scroll", "confirmTime", confirm_time.text, App.Path & "\T3 Manager.ini"
        EcritDansFichierIni "scroll", "confirmMod", confirm_mod.text, App.Path & "\T3 Manager.ini"
        
        
        T3_Manager.cardList.init
        Scrolling_Mod.load_scrollConfiguration
    End If
End Function

Private Sub SONNE_check_Click()
    save_scrollConfiguration
End Sub

Private Sub SUPPRIME_P_check_Click()
    save_scrollConfiguration
End Sub

Private Sub SONNE_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub sound_mod_Click()
    save_scrollConfiguration
End Sub

Private Sub SUPPRIME_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TD_1_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub TD_1_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TD_120_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub TD_120_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TD_15_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub TD_15_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TD_30_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub TD_30_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TD_45_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub TD_45_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TD_60_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub TD_60_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TD_90_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub TD_90_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TEST_check_Click()
    save_scrollConfiguration
End Sub

Private Sub TEST_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TG_1_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub TG_1_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TG_120_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub TG_120_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TG_15_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub TG_15_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TG_30_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub TG_30_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TG_45_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub TG_45_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TG_60_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub TG_60_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TG_90_Check_Click()
    save_scrollConfiguration
End Sub

Private Sub TG_90_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TOUCHE_AR_check_Click()
    save_scrollConfiguration
End Sub

Private Sub TOUCHE_AR_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TOUCHE_AVD_check_Click()
    save_scrollConfiguration
End Sub

Private Sub TOUCHE_AVD_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TOUCHE_AVG_check_Click()
    save_scrollConfiguration
End Sub

Private Sub TOUCHE_AVG_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TOUCHE_STOP_check_Click()
    save_scrollConfiguration
End Sub

Private Sub TOUCHE_STOP_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub TOUT_check_Click()
    save_scrollConfiguration
End Sub

Private Sub Tout_Text_Change()
    save_scrollConfiguration
End Sub

Private Sub Use_Category_Click()
    save_scrollConfiguration
End Sub
