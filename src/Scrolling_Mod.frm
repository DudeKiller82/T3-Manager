VERSION 5.00
Begin VB.Form Scrolling_Mod 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Mode défilement"
   ClientHeight    =   9240
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   11490
   Icon            =   "Scrolling_Mod.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   9240
   ScaleWidth      =   11490
   StartUpPosition =   3  'Windows Default
   Visible         =   0   'False
   Begin VB.CheckBox Scrolling_Pause 
      Caption         =   "Pause"
      Height          =   255
      Left            =   8400
      TabIndex        =   4
      Top             =   8880
      Width           =   855
   End
   Begin VB.CommandButton Scrolling_Configuraton_Button 
      Caption         =   "Configuration"
      Height          =   255
      Left            =   9360
      TabIndex        =   2
      ToolTipText     =   "Select a SVG image"
      Top             =   8880
      Width           =   2055
   End
   Begin VB.Timer Scroll_Timer 
      Left            =   10680
      Top             =   6960
   End
   Begin VB.Frame Frame1 
      Caption         =   "Carte"
      Height          =   8655
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   11295
      Begin VB.PictureBox cardPicture 
         Height          =   7095
         Left            =   120
         ScaleHeight     =   7035
         ScaleWidth      =   10995
         TabIndex        =   1
         Top             =   240
         Width           =   11055
         Begin VB.Timer confirm_timer 
            Interval        =   10
            Left            =   10440
            Top             =   6120
         End
      End
      Begin VB.Label CardText 
         Alignment       =   2  'Center
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   24
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1095
         Left            =   120
         TabIndex        =   3
         Top             =   7440
         Width           =   11055
      End
   End
End
Attribute VB_Name = "Scrolling_Mod"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'sleep
Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
'sound
Private Const SND_APPLICATION = &H80         '  look for application specific association
Private Const SND_ALIAS = &H10000     '  name is a WIN.INI [sounds] entry
Private Const SND_ALIAS_ID = &H110000    '  name is a WIN.INI [sounds] entry identifier
Private Const SND_ASYNC = &H1         '  play asynchronously
Private Const SND_FILENAME = &H20000     '  name is a file name
Private Const SND_LOOP = &H8         '  loop the sound until next sndPlaySound
Private Const SND_MEMORY = &H4         '  lpszSoundName points to a memory file
Private Const SND_NODEFAULT = &H2         '  silence not default, if sound not found
Private Const SND_NOSTOP = &H10        '  don't stop any currently playing sound
Private Const SND_NOWAIT = &H2000      '  don't wait if the driver is busy
Private Const SND_PURGE = &H40               '  purge non-static events for task
Private Const SND_RESOURCE = &H40004     '  name is a resource name or atom
Private Const SND_SYNC = &H0         '  play synchronously (default)
Private Declare Function PlaySound Lib "winmm.dll" Alias "PlaySoundA" _
(ByVal lpszName As String, ByVal hModule As Long, ByVal dwflags As Long) As Long

Public scroll_CardCategoryList As Collection
Public currentCategory As Integer
Public currentCardIndex As Integer
Public categoryScroll As Integer
Public loading As Integer
Public confirm As Integer
Public confirmCard As CardClass
Public countdown As Integer



Private Sub cardPicture_Click()
    Dim soundPath As String
    If Scrolling_Mod_Configuration.sound_mod.text <> "Non" Then
        PlaySound App.Path & "\Media\son\bip.wav", ByVal 0&, SND_FILENAME Or SND_ASYNC
    End If
    
    If confirm = 1 Then
        If Scrolling_Mod_Configuration.confirm_mod.text = "Accepter" Then
            CardText.Caption = "OK !"
            CardText.Refresh
            CommSendSingle confirmCard
            confirm = 0
            Exit Sub
        End If
        If Scrolling_Mod_Configuration.confirm_mod.text = "Annuler" Then
            CardText.Caption = "OK !"
            CardText.Refresh
            confirm = 0
            Exit Sub
        End If
    End If
    
    If Scrolling_Mod_Configuration.Use_Category.value = 1 Then
        If categoryScroll = 1 Then
            If Scrolling_Mod_Configuration.sound_mod.text = "Parole" Then
                soundPath = App.Path & "\media\son\categorie " & scroll_CardCategoryList.Item(currentCategory).name & ".wav"
                If Dir(soundPath, vbHidden) <> "" Then
                    cardPicture.picture = LoadPicture(soundPath)
                Else
                    PlaySound App.Path & "\media\son\entre dans categorie.wav", ByVal 0&, SND_FILENAME Or SND_ASYNC
                End If
            End If
            categoryScroll = 0
        Else
            If scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).name = "RETOUR_MENU" Then
                currentCategory = 2
                categoryScroll = 1
                PlaySound scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).sound, ByVal 0&, SND_FILENAME Or SND_ASYNC
            Else
                If Scrolling_Mod_Configuration.sound_mod.text = "Parole" Then
                    If Dir(scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).sound, vbHidden) <> "" Then
                        PlaySound scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).sound, ByVal 0&, SND_FILENAME Or SND_ASYNC
                    End If
                End If
                If Scrolling_Mod_Configuration.confirm_mod.text = "Non" Then
                    CommSendSingle scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex)
                Else
                    CardText.Caption = Scrolling_Mod_Configuration.confirm_mod.text & " ?"
                    countdown = Scrolling_Mod_Configuration.confirm_time.text
                    confirm = 1
                    Set confirmCard = scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex)
                    Exit Sub
                End If
                If Scrolling_Mod_Configuration.Auto_Return.value = 1 Then
                    currentCategory = 2
                    categoryScroll = 1
                End If
            End If
        End If
    Else
        If Scrolling_Mod_Configuration.sound_mod.text = "Parole" Then
            If Dir(scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).sound, vbHidden) <> "" Then
                PlaySound scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).sound, ByVal 0&, SND_FILENAME Or SND_ASYNC
            End If
        End If
        If Scrolling_Mod_Configuration.confirm_mod.text = "Non" Then
            CommSendSingle scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex)
        Else
            CardText.Caption = Scrolling_Mod_Configuration.confirm_mod.text & " ?"
            countdown = Scrolling_Mod_Configuration.confirm_time.text
            confirm = 1
            confirmCard = scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex)
            Exit Sub
        End If
    End If
End Sub

Private Sub confirm_timer_Timer()
    If countdown > 0 Then
        countdown = countdown - 10
        If countdown <= 0 And confirm = 1 Then
            If Scrolling_Mod_Configuration.confirm_mod.text = "Annuler" Then
                CardText.Caption = confirmCard.text
                CardText.Refresh
                CommSendSingle confirmCard
                confirm = 0
            End If
            If Scrolling_Mod_Configuration.confirm_mod.text = "Accepter" Then
                CardText.Caption = confirmCard.text
                CardText.Refresh
                confirm = 0
            End If
        End If
    End If
End Sub

Private Sub Form_Load()
    load_scrollConfiguration
End Sub

Private Function createScrollCardList()
    Dim card As CardClass
    Dim newCategory As CategoryClass
    Dim returnCard As CardClass
    
    categoryScroll = Scrolling_Mod_Configuration.Use_Category.value
    Set scroll_CardCategoryList = New Collection
    Set newCategory = New CategoryClass
    newCategory.name = "all"
    scroll_CardCategoryList.Add newCategory
    If Scrolling_Mod_Configuration.Use_Category.value = 0 Then
        currentCategory = 1
    Else
        currentCategory = 2
    End If
    For Each card In T3_Manager.cardList.listByName
        If card.scrolling = True Then
            scroll_CardCategoryList.Item(getCategoryNumber("all")).list.Add card
            If card.scrollingCategory = "" Then
                If getCategoryNumber("Autres") = 0 Then
                    Set returnCard = New CardClass
                    returnCard.name = "RETOUR_MENU"
                    returnCard.picture = App.Path & "\media\image\categorie.bmp"
                    returnCard.sound = App.Path & "\media\son\sort de categorie.wav"
                    returnCard.text = "Retour aux catégories"
                    Set newCategory = New CategoryClass
                    newCategory.name = "Autres"
                    scroll_CardCategoryList.Add newCategory
                    scroll_CardCategoryList.Item(getCategoryNumber("Autres")).list.Add returnCard
                End If
                scroll_CardCategoryList.Item(getCategoryNumber("Autres")).list.Add card
            Else
                If getCategoryNumber(card.scrollingCategory) = 0 Then
                    Set returnCard = New CardClass
                    returnCard.name = "RETOUR_MENU"
                    returnCard.picture = App.Path & "\media\image\categorie.bmp"
                    returnCard.sound = App.Path & "\media\son\sort de categorie.wav"
                    returnCard.text = "Retour aux catégories"
                    Set newCategory = New CategoryClass
                    newCategory.name = card.scrollingCategory
                    scroll_CardCategoryList.Add newCategory, card.scrollingCategory
                    scroll_CardCategoryList.Item(getCategoryNumber(card.scrollingCategory)).list.Add returnCard
                End If
                scroll_CardCategoryList.Item(getCategoryNumber(card.scrollingCategory)).list.Add card
            End If
        End If
    Next
End Function

Public Function getCategoryNumber(catName As String) As Integer
    Dim i As Integer
    For i = 1 To scroll_CardCategoryList.Count
        If scroll_CardCategoryList.Item(i).name = catName Then
            getCategoryNumber = i
            Exit Function
        End If
    Next
    getCategoryNumber = 0
End Function

Public Function refreshCardPicture()
    Dim picturePath As String
    If Scrolling_Mod_Configuration.Use_Category.value = 1 Then
        If categoryScroll = 1 Then
            If scroll_CardCategoryList.Count <> 0 And Scrolling_Pause.value = 0 Then
                currentCategory = currentCategory + 1
                If currentCategory > scroll_CardCategoryList.Count Then
                    currentCategory = 2
                End If
                CardText.Caption = scroll_CardCategoryList.Item(currentCategory).name
                picturePath = App.Path & "\media\image\categorie " & scroll_CardCategoryList.Item(currentCategory).name & ".bmp"
                If Dir(picturePath, vbHidden) <> "" Then
                    cardPicture.picture = LoadPicture(picturePath)
                Else
                    cardPicture.picture = LoadPicture(App.Path & "\media\image\categorie.bmp")
                End If
            End If
        Else
            If scroll_CardCategoryList.Item(currentCategory).list.Count <> 0 And Scrolling_Pause.value = 0 Then
                currentCardIndex = currentCardIndex + 1
                If currentCardIndex > scroll_CardCategoryList.Item(currentCategory).list.Count Then
                    currentCardIndex = 1
                End If
                CardText.Caption = scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).text
                If Dir(scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).picture, vbHidden) <> "" Then
                    cardPicture.picture = LoadPicture(scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).picture)
                Else
                    cardPicture.picture = LoadPicture("")
                End If
            End If
        End If
    Else
        If scroll_CardCategoryList.Item(currentCategory).list.Count <> 0 And Scrolling_Pause.value = 0 Then
            currentCardIndex = currentCardIndex + 1
            If currentCardIndex > scroll_CardCategoryList.Item(currentCategory).list.Count Then
                currentCardIndex = 1
            End If
            CardText.Caption = scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).text
            If Dir(scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).picture, vbHidden) <> "" Then
                cardPicture.picture = LoadPicture(scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).picture)
            Else
                cardPicture.picture = LoadPicture("")
            End If
        End If
    End If
End Function

Private Sub Scroll_Timer_Timer()
    If confirm = 0 Then
        refreshCardPicture
    End If
End Sub

Private Sub Scrolling_Configuraton_Button_Click()
    Scrolling_Mod_Configuration.Visible = True
End Sub

Public Function load_scrollConfiguration()
    loading = 1
    Scrolling_Mod_Configuration.AV_1_Check.value = LitDansFichierIni("scrolling", "AV_1", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.AV_10_Check.value = LitDansFichierIni("scrolling", "AV_10", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.AV_20_Check.value = LitDansFichierIni("scrolling", "AV_20", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.RE_1_Check.value = LitDansFichierIni("scrolling", "RE_1", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.RE_10_Check.value = LitDansFichierIni("scrolling", "RE_10", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.RE_20_Check.value = LitDansFichierIni("scrolling", "RE_20", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TG_1_Check.value = LitDansFichierIni("scrolling", "TG_1", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TG_15_Check.value = LitDansFichierIni("scrolling", "TG_15", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TG_30_Check.value = LitDansFichierIni("scrolling", "TG_30", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TG_45_Check.value = LitDansFichierIni("scrolling", "TG_45", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TG_60_Check.value = LitDansFichierIni("scrolling", "TG_60", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TG_90_Check.value = LitDansFichierIni("scrolling", "TG_90", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TG_120_Check.value = LitDansFichierIni("scrolling", "TG_120", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TD_1_Check.value = LitDansFichierIni("scrolling", "TD_1", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TD_15_Check.value = LitDansFichierIni("scrolling", "TD_15", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TD_30_Check.value = LitDansFichierIni("scrolling", "TD_30", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TD_45_Check.value = LitDansFichierIni("scrolling", "TD_45", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TD_60_Check.value = LitDansFichierIni("scrolling", "TD_60", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TD_90_Check.value = LitDansFichierIni("scrolling", "TD_90", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TD_120_Check.value = LitDansFichierIni("scrolling", "TD_120", App.Path & "\T3 Manager.ini", "")
    
    Scrolling_Mod_Configuration.B_C_check.value = LitDansFichierIni("scrolling", "B_C", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.L_C_check.value = LitDansFichierIni("scrolling", "L_C", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.RALE_check.value = LitDansFichierIni("scrolling", "RALE", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.SONNE_check.value = LitDansFichierIni("scrolling", "SONNE", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.JOUE_AIR_check.value = LitDansFichierIni("scrolling", "JOUE_AIR", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ALLUME_check.value = LitDansFichierIni("scrolling", "ALLUME", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ETEINS_check.value = LitDansFichierIni("scrolling", "ETEINS", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ETEINS_G_check.value = LitDansFichierIni("scrolling", "ETEINS_G", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ETEINS_D_check.value = LitDansFichierIni("scrolling", "ETEINS_D", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.CLIGNE_G_check.value = LitDansFichierIni("scrolling", "CLIGNE_G", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.CLIGNE_D_check.value = LitDansFichierIni("scrolling", "CLIGNE_D", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ARC_AVG_5_check.value = LitDansFichierIni("scrolling", "ARC_AVG_5", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ARC_AVG_10_check.value = LitDansFichierIni("scrolling", "ARC_AVG_10", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ARC_AVG_20_check.value = LitDansFichierIni("scrolling", "ARC_AVG_20", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ARC_AVD_5_check.value = LitDansFichierIni("scrolling", "ARC_AVD_5", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ARC_AVD_10_check.value = LitDansFichierIni("scrolling", "ARC_AVD_10", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ARC_AVD_20_check.value = LitDansFichierIni("scrolling", "ARC_AVD_20", App.Path & "\T3 Manager.ini", "")
    
    Scrolling_Mod_Configuration.REGLAGE_check.value = LitDansFichierIni("scrolling", "REGLAGE", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TEST_check.value = LitDansFichierIni("scrolling", "TEST", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TOUCHE_AVG_check.value = LitDansFichierIni("scrolling", "TOUCHE_AVG", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TOUCHE_AVD_check.value = LitDansFichierIni("scrolling", "TOUCHE_AVD", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TOUCHE_AR_check.value = LitDansFichierIni("scrolling", "TOUCHE_AR", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TOUCHE_STOP_check.value = LitDansFichierIni("scrolling", "TOUCHE_STOP", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.DES_QUE_check.value = LitDansFichierIni("scrolling", "DES_QUE", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.C_EST_check.value = LitDansFichierIni("scrolling", "C_EST", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.FIN_check.value = LitDansFichierIni("scrolling", "FIN", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.SUPPRIME_check.value = LitDansFichierIni("scrolling", "SUPPRIME", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.OUBLIE_check.value = LitDansFichierIni("scrolling", "OUBLIE", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.APPRENDS_check.value = LitDansFichierIni("scrolling", "APPRENDS", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.GOMME_check.value = LitDansFichierIni("scrolling", "GOMME", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.EXECUTE_check.value = LitDansFichierIni("scrolling", "EXECUTE", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.EXECUTE_P_check.value = LitDansFichierIni("scrolling", "EXECUTE_P", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.EXECUTE_M_check.value = LitDansFichierIni("scrolling", "EXECUTE_M", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TOUT_check.value = LitDansFichierIni("scrolling", "TOUT", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ARRET_check.value = LitDansFichierIni("scrolling", "ARRET", App.Path & "\T3 Manager.ini", "")

    Scrolling_Mod_Configuration.PROCEDURE_N1_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N1", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N2_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N2", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N3_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N3", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N4_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N4", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N5_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N5", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N6_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N6", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N7_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N7", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N8_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N8", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N9_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N9", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N10_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N10", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N11_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N11", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N12_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N12", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N13_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N13", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N14_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N14", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N15_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N15", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N16_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N16", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N17_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N17", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N18_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N18", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N19_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N19", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N20_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N20", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N21_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N21", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N22_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N22", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N23_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N23", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N24_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N24", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N25_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N25", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N26_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N26", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N27_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N27", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N28_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N28", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N29_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N29", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N30_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N30", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N31_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N31", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N32_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N32", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N33_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N33", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N34_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N34", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N35_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N35", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N36_check.value = LitDansFichierIni("scrolling", "PROCEDURE_N36", App.Path & "\T3 Manager.ini", "")
    
    Scrolling_Mod_Configuration.AV_1_Text.text = LitDansFichierIni("category", "AV_1", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.AV_10_Text.text = LitDansFichierIni("category", "AV_10", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.AV_20_Text.text = LitDansFichierIni("category", "AV_20", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.RE_1_Text.text = LitDansFichierIni("category", "RE_1", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.RE_10_Text.text = LitDansFichierIni("category", "RE_10", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.RE_20_Text.text = LitDansFichierIni("category", "RE_20", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TG_1_Text.text = LitDansFichierIni("category", "TG_1", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TG_15_Text.text = LitDansFichierIni("category", "TG_15", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TG_30_Text.text = LitDansFichierIni("category", "TG_30", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TG_45_Text.text = LitDansFichierIni("category", "TG_45", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TG_60_Text.text = LitDansFichierIni("category", "TG_60", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TG_90_Text.text = LitDansFichierIni("category", "TG_90", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TG_120_Text.text = LitDansFichierIni("category", "TG_120", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TD_1_Text.text = LitDansFichierIni("category", "TD_1", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TD_15_Text.text = LitDansFichierIni("category", "TD_15", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TD_30_Text.text = LitDansFichierIni("category", "TD_30", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TD_45_Text.text = LitDansFichierIni("category", "TD_45", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TD_60_Text.text = LitDansFichierIni("category", "TD_60", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TD_90_Text.text = LitDansFichierIni("category", "TD_90", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TD_120_Text.text = LitDansFichierIni("category", "TD_120", App.Path & "\T3 Manager.ini", "")
    
    Scrolling_Mod_Configuration.B_C_Text.text = LitDansFichierIni("category", "B_C", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.L_C_Text.text = LitDansFichierIni("category", "L_C", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.RALE_Text.text = LitDansFichierIni("category", "RALE", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.SONNE_Text.text = LitDansFichierIni("category", "SONNE", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.JOUE_AIR_Text.text = LitDansFichierIni("category", "JOUE_AIR", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ALLUME_Text.text = LitDansFichierIni("category", "ALLUME", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ETEINS_Text.text = LitDansFichierIni("category", "ETEINS", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ETEINS_G_Text.text = LitDansFichierIni("category", "ETEINS_G", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ETEINS_D_Text.text = LitDansFichierIni("category", "ETEINS_D", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.CLIGNE_G_Text.text = LitDansFichierIni("category", "CLIGNE_G", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.CLIGNE_D_Text.text = LitDansFichierIni("category", "CLIGNE_D", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ARC_AVG_5_Text.text = LitDansFichierIni("category", "ARC_AVG_5", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ARC_AVG_10_Text.text = LitDansFichierIni("category", "ARC_AVG_10", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ARC_AVG_20_Text.text = LitDansFichierIni("category", "ARC_AVG_20", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ARC_AVD_5_Text.text = LitDansFichierIni("category", "ARC_AVD_5", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ARC_AVD_10_Text.text = LitDansFichierIni("category", "ARC_AVD_10", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ARC_AVD_20_Text.text = LitDansFichierIni("category", "ARC_AVD_20", App.Path & "\T3 Manager.ini", "")
    
    Scrolling_Mod_Configuration.REGLAGE_Text.text = LitDansFichierIni("category", "REGLAGE", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TEST_Text.text = LitDansFichierIni("category", "TEST", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TOUCHE_AVG_Text.text = LitDansFichierIni("category", "TOUCHE_AVG", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TOUCHE_AVD_Text.text = LitDansFichierIni("category", "TOUCHE_AVD", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TOUCHE_AR_Text.text = LitDansFichierIni("category", "TOUCHE_AR", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.TOUCHE_STOP_Text.text = LitDansFichierIni("category", "TOUCHE_STOP", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.DES_QUE_Text.text = LitDansFichierIni("category", "DES_QUE", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.C_EST_Text.text = LitDansFichierIni("category", "C_EST", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.FIN_Text.text = LitDansFichierIni("category", "FIN", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.SUPPRIME_Text.text = LitDansFichierIni("category", "SUPPRIME", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.OUBLIE_Text.text = LitDansFichierIni("category", "OUBLIE", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.APPRENDS_Text.text = LitDansFichierIni("category", "APPRENDS", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.GOMME_Text.text = LitDansFichierIni("category", "GOMME", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.EXECUTE_Text.text = LitDansFichierIni("category", "EXECUTE", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.EXECUTE_P_Text.text = LitDansFichierIni("category", "EXECUTE_P", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.EXECUTE_M_Text.text = LitDansFichierIni("category", "EXECUTE_M", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.Tout_Text.text = LitDansFichierIni("category", "TOUT", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.ARRET_Text.text = LitDansFichierIni("category", "ARRET", App.Path & "\T3 Manager.ini", "")

    Scrolling_Mod_Configuration.PROCEDURE_N1_Text.text = LitDansFichierIni("category", "PROCEDURE_N1", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N2_Text.text = LitDansFichierIni("category", "PROCEDURE_N2", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N3_Text.text = LitDansFichierIni("category", "PROCEDURE_N3", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N4_Text.text = LitDansFichierIni("category", "PROCEDURE_N4", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N5_Text.text = LitDansFichierIni("category", "PROCEDURE_N5", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N6_Text.text = LitDansFichierIni("category", "PROCEDURE_N6", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N7_Text.text = LitDansFichierIni("category", "PROCEDURE_N7", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N8_Text.text = LitDansFichierIni("category", "PROCEDURE_N8", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N9_Text.text = LitDansFichierIni("category", "PROCEDURE_N9", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N10_Text.text = LitDansFichierIni("category", "PROCEDURE_N10", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N11_Text.text = LitDansFichierIni("category", "PROCEDURE_N11", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N12_Text.text = LitDansFichierIni("category", "PROCEDURE_N12", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N13_Text.text = LitDansFichierIni("category", "PROCEDURE_N13", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N14_Text.text = LitDansFichierIni("category", "PROCEDURE_N14", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N15_Text.text = LitDansFichierIni("category", "PROCEDURE_N15", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N16_Text.text = LitDansFichierIni("category", "PROCEDURE_N16", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N17_Text.text = LitDansFichierIni("category", "PROCEDURE_N17", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N18_Text.text = LitDansFichierIni("category", "PROCEDURE_N18", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N19_Text.text = LitDansFichierIni("category", "PROCEDURE_N19", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N20_Text.text = LitDansFichierIni("category", "PROCEDURE_N20", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N21_Text.text = LitDansFichierIni("category", "PROCEDURE_N21", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N22_Text.text = LitDansFichierIni("category", "PROCEDURE_N22", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N23_Text.text = LitDansFichierIni("category", "PROCEDURE_N23", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N24_Text.text = LitDansFichierIni("category", "PROCEDURE_N24", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N25_Text.text = LitDansFichierIni("category", "PROCEDURE_N25", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N26_Text.text = LitDansFichierIni("category", "PROCEDURE_N26", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N27_Text.text = LitDansFichierIni("category", "PROCEDURE_N27", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N28_Text.text = LitDansFichierIni("category", "PROCEDURE_N28", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N29_Text.text = LitDansFichierIni("category", "PROCEDURE_N29", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N30_Text.text = LitDansFichierIni("category", "PROCEDURE_N30", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N31_Text.text = LitDansFichierIni("category", "PROCEDURE_N31", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N32_Text.text = LitDansFichierIni("category", "PROCEDURE_N32", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N33_Text.text = LitDansFichierIni("category", "PROCEDURE_N33", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N34_Text.text = LitDansFichierIni("category", "PROCEDURE_N34", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N35_Text.text = LitDansFichierIni("category", "PROCEDURE_N35", App.Path & "\T3 Manager.ini", "")
    Scrolling_Mod_Configuration.PROCEDURE_N36_Text.text = LitDansFichierIni("category", "PROCEDURE_N36", App.Path & "\T3 Manager.ini", "")
    
    Scrolling_Mod_Configuration.Use_Category.value = LitDansFichierIni("scroll", "useCategory", App.Path & "\T3 Manager.ini", 0)
    Scrolling_Mod_Configuration.Auto_Return.value = LitDansFichierIni("scroll", "autoReturn", App.Path & "\T3 Manager.ini", 0)
    Scrolling_Mod_Configuration.scroll_time.text = LitDansFichierIni("scroll", "scrollingTime", App.Path & "\T3 Manager.ini", "1000")
    Scrolling_Mod_Configuration.sound_mod.text = LitDansFichierIni("scroll", "soundMod", App.Path & "\T3 Manager.ini", "Non")
    Scrolling_Mod_Configuration.confirm_time.text = LitDansFichierIni("scroll", "confirmTime", App.Path & "\T3 Manager.ini", "1000")
    Scrolling_Mod_Configuration.confirm_mod.text = LitDansFichierIni("scroll", "confirmMod", App.Path & "\T3 Manager.ini", "Non")
    
    Scroll_Timer.Interval = Scrolling_Mod_Configuration.scroll_time.text
    If Scrolling_Mod_Configuration.Use_Category.value = 0 Then
        currentCategory = 1
    Else
        currentCategory = 2
    End If
    currentCardIndex = 1
    createScrollCardList
    refreshCardPicture
    loading = 0
End Function

Public Function Exists(col, index) As Boolean
On Error GoTo ExistsTryNonObject
    Dim o As Object

    Set o = col(index)
    Exists = True
    Exit Function

ExistsTryNonObject:
    Exists = ExistsNonObject(col, index)
End Function

Private Function ExistsNonObject(col, index) As Boolean
On Error GoTo ExistsNonObjectErrorHandler
    Dim v As Variant

    v = col(index)
    ExistsNonObject = True
    Exit Function

ExistsNonObjectErrorHandler:
    ExistsNonObject = False
End Function
