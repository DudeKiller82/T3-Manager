Option Strict Off
Option Explicit On
Friend Class Scrolling_Mod
	Inherits System.Windows.Forms.Form
	'sleep
	Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)
	'sound
	Private Const SND_APPLICATION As Integer = &H80 '  look for application specific association
	Private Const SND_ALIAS As Integer = &H10000 '  name is a WIN.INI [sounds] entry
	Private Const SND_ALIAS_ID As Integer = &H110000 '  name is a WIN.INI [sounds] entry identifier
	Private Const SND_ASYNC As Integer = &H1 '  play asynchronously
	Private Const SND_FILENAME As Integer = &H20000 '  name is a file name
	Private Const SND_LOOP As Integer = &H8 '  loop the sound until next sndPlaySound
	Private Const SND_MEMORY As Integer = &H4 '  lpszSoundName points to a memory file
	Private Const SND_NODEFAULT As Integer = &H2 '  silence not default, if sound not found
	Private Const SND_NOSTOP As Integer = &H10 '  don't stop any currently playing sound
	Private Const SND_NOWAIT As Integer = &H2000 '  don't wait if the driver is busy
	Private Const SND_PURGE As Integer = &H40 '  purge non-static events for task
	Private Const SND_RESOURCE As Integer = &H40004 '  name is a resource name or atom
	Private Const SND_SYNC As Integer = &H0 '  play synchronously (default)
	Private Declare Function PlaySound Lib "winmm.dll"  Alias "PlaySoundA"(ByVal lpszName As String, ByVal hModule As Integer, ByVal dwflags As Integer) As Integer
	
	Public scroll_CardCategoryList As Collection
	Public currentCategory As Short
	Public currentCardIndex As Short
	Public categoryScroll As Short
	Public loading As Short
	Public confirm As Short
	Public confirmCard As CardClass
	Public countdown As Short
	
	
	
	Private Sub cardPicture_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cardPicture.Click
		Dim soundPath As String
		If Scrolling_Mod_Configuration.sound_mod.Text <> "Non" Then
			PlaySound(My.Application.Info.DirectoryPath & "\Media\son\bip.wav", 0, SND_FILENAME Or SND_ASYNC)
		End If
		
		If confirm = 1 Then
			If Scrolling_Mod_Configuration.confirm_mod.Text = "Accepter" Then
				CardText.Text = "OK !"
				CardText.Refresh()
				CommSendSingle(confirmCard)
				confirm = 0
				Exit Sub
			End If
			If Scrolling_Mod_Configuration.confirm_mod.Text = "Annuler" Then
				CardText.Text = "OK !"
				CardText.Refresh()
				confirm = 0
				Exit Sub
			End If
		End If
		
		If Scrolling_Mod_Configuration.Use_Category.CheckState = 1 Then
			If categoryScroll = 1 Then
				If Scrolling_Mod_Configuration.sound_mod.Text = "Parole" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					soundPath = My.Application.Info.DirectoryPath & "\media\son\categorie " & scroll_CardCategoryList.Item(currentCategory).name & ".wav"
					'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
					If Dir(soundPath, FileAttribute.Hidden) <> "" Then
						cardPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
						'UPGRADE_WARNING: Picture has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
						cardPicture.BackgroundImage = System.Drawing.Image.FromFile(soundPath)
					Else
						PlaySound(My.Application.Info.DirectoryPath & "\media\son\entre dans categorie.wav", 0, SND_FILENAME Or SND_ASYNC)
					End If
				End If
				categoryScroll = 0
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).name = "RETOUR_MENU" Then
					currentCategory = 2
					categoryScroll = 1
					'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					PlaySound(scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).sound, 0, SND_FILENAME Or SND_ASYNC)
				Else
					If Scrolling_Mod_Configuration.sound_mod.Text = "Parole" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
						If Dir(scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).sound, FileAttribute.Hidden) <> "" Then
							'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							PlaySound(scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).sound, 0, SND_FILENAME Or SND_ASYNC)
						End If
					End If
					If Scrolling_Mod_Configuration.confirm_mod.Text = "Non" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						CommSendSingle(scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex))
					Else
						CardText.Text = Scrolling_Mod_Configuration.confirm_mod.Text & " ?"
						countdown = CShort(Scrolling_Mod_Configuration.confirm_time.Text)
						confirm = 1
						'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						confirmCard = scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex)
						Exit Sub
					End If
					If Scrolling_Mod_Configuration.Auto_Return.CheckState = 1 Then
						currentCategory = 2
						categoryScroll = 1
					End If
				End If
			End If
		Else
			If Scrolling_Mod_Configuration.sound_mod.Text = "Parole" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				If Dir(scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).sound, FileAttribute.Hidden) <> "" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					PlaySound(scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).sound, 0, SND_FILENAME Or SND_ASYNC)
				End If
			End If
			If Scrolling_Mod_Configuration.confirm_mod.Text = "Non" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				CommSendSingle(scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex))
			Else
				CardText.Text = Scrolling_Mod_Configuration.confirm_mod.Text & " ?"
				countdown = CShort(Scrolling_Mod_Configuration.confirm_time.Text)
				confirm = 1
				'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object confirmCard. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				confirmCard = scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex)
				Exit Sub
			End If
		End If
	End Sub
	
	Private Sub confirm_timer_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles confirm_timer.Tick
		If countdown > 0 Then
			countdown = countdown - 10
			If countdown <= 0 And confirm = 1 Then
				If Scrolling_Mod_Configuration.confirm_mod.Text = "Annuler" Then
					CardText.Text = confirmCard.text
					CardText.Refresh()
					CommSendSingle(confirmCard)
					confirm = 0
				End If
				If Scrolling_Mod_Configuration.confirm_mod.Text = "Accepter" Then
					CardText.Text = confirmCard.text
					CardText.Refresh()
					confirm = 0
				End If
			End If
		End If
	End Sub
	
	Private Sub Scrolling_Mod_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		load_scrollConfiguration()
	End Sub
	
	Private Function createScrollCardList() As Object
		Dim card As CardClass
		Dim newCategory As CategoryClass
		Dim returnCard As CardClass
		
		categoryScroll = Scrolling_Mod_Configuration.Use_Category.CheckState
		scroll_CardCategoryList = New Collection
		newCategory = New CategoryClass
		newCategory.name = "all"
		scroll_CardCategoryList.Add(newCategory)
		If Scrolling_Mod_Configuration.Use_Category.CheckState = 0 Then
			currentCategory = 1
		Else
			currentCategory = 2
		End If
		For	Each card In T3_Manager.cardList.listByName
			If card.scrolling = True Then
				'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				scroll_CardCategoryList.Item(getCategoryNumber("all")).list.Add(card)
				If card.scrollingCategory = "" Then
					If getCategoryNumber("Autres") = 0 Then
						returnCard = New CardClass
						returnCard.name = "RETOUR_MENU"
						returnCard.picture = My.Application.Info.DirectoryPath & "\media\image\categorie.bmp"
						returnCard.sound = My.Application.Info.DirectoryPath & "\media\son\sort de categorie.wav"
						returnCard.text = "Retour aux catégories"
						newCategory = New CategoryClass
						newCategory.name = "Autres"
						scroll_CardCategoryList.Add(newCategory)
						'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						scroll_CardCategoryList.Item(getCategoryNumber("Autres")).list.Add(returnCard)
					End If
					'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					scroll_CardCategoryList.Item(getCategoryNumber("Autres")).list.Add(card)
				Else
					If getCategoryNumber((card.scrollingCategory)) = 0 Then
						returnCard = New CardClass
						returnCard.name = "RETOUR_MENU"
						returnCard.picture = My.Application.Info.DirectoryPath & "\media\image\categorie.bmp"
						returnCard.sound = My.Application.Info.DirectoryPath & "\media\son\sort de categorie.wav"
						returnCard.text = "Retour aux catégories"
						newCategory = New CategoryClass
						newCategory.name = card.scrollingCategory
						scroll_CardCategoryList.Add(newCategory, card.scrollingCategory)
						'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						scroll_CardCategoryList.Item(getCategoryNumber((card.scrollingCategory))).list.Add(returnCard)
					End If
					'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					scroll_CardCategoryList.Item(getCategoryNumber((card.scrollingCategory))).list.Add(card)
				End If
			End If
		Next card
	End Function
	
	Public Function getCategoryNumber(ByRef catName As String) As Short
		Dim i As Short
		For i = 1 To scroll_CardCategoryList.Count()
			'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item(i).name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If scroll_CardCategoryList.Item(i).name = catName Then
				getCategoryNumber = i
				Exit Function
			End If
		Next 
		getCategoryNumber = 0
	End Function
	
	Public Function refreshCardPicture() As Object
		Dim picturePath As String
		If Scrolling_Mod_Configuration.Use_Category.CheckState = 1 Then
			If categoryScroll = 1 Then
				If scroll_CardCategoryList.Count() <> 0 And Scrolling_Pause.CheckState = 0 Then
					currentCategory = currentCategory + 1
					If currentCategory > scroll_CardCategoryList.Count() Then
						currentCategory = 2
					End If
					'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					CardText.Text = scroll_CardCategoryList.Item(currentCategory).name
					'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					picturePath = My.Application.Info.DirectoryPath & "\media\image\categorie " & scroll_CardCategoryList.Item(currentCategory).name & ".bmp"
					'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
					If Dir(picturePath, FileAttribute.Hidden) <> "" Then
						cardPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
						'UPGRADE_WARNING: Picture has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
						cardPicture.BackgroundImage = System.Drawing.Image.FromFile(picturePath)
					Else
						cardPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
						'UPGRADE_WARNING: Picture has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
						cardPicture.BackgroundImage = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\media\image\categorie.bmp")
					End If
				End If
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item(currentCategory).list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If scroll_CardCategoryList.Item(currentCategory).list.Count <> 0 And Scrolling_Pause.CheckState = 0 Then
					currentCardIndex = currentCardIndex + 1
					'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item(currentCategory).list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If currentCardIndex > scroll_CardCategoryList.Item(currentCategory).list.Count Then
						currentCardIndex = 1
					End If
					'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					CardText.Text = scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).text
					'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
					If Dir(scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).picture, FileAttribute.Hidden) <> "" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						cardPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
						'UPGRADE_WARNING: Picture has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
						cardPicture.BackgroundImage = System.Drawing.Image.FromFile(scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).picture)
					Else
						cardPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
						'UPGRADE_WARNING: Picture has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
						cardPicture.BackgroundImage = System.Drawing.Image.FromFile("")
					End If
				End If
			End If
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item(currentCategory).list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If scroll_CardCategoryList.Item(currentCategory).list.Count <> 0 And Scrolling_Pause.CheckState = 0 Then
				currentCardIndex = currentCardIndex + 1
				'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item(currentCategory).list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If currentCardIndex > scroll_CardCategoryList.Item(currentCategory).list.Count Then
					currentCardIndex = 1
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				CardText.Text = scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).text
				'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				If Dir(scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).picture, FileAttribute.Hidden) <> "" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object scroll_CardCategoryList.Item().list. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cardPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
					'UPGRADE_WARNING: Picture has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
					cardPicture.BackgroundImage = System.Drawing.Image.FromFile(scroll_CardCategoryList.Item(currentCategory).list.Item(currentCardIndex).picture)
				Else
					cardPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
					'UPGRADE_WARNING: Picture has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
					cardPicture.BackgroundImage = System.Drawing.Image.FromFile("")
				End If
			End If
		End If
	End Function
	
	Private Sub Scroll_Timer_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Scroll_Timer.Tick
		If confirm = 0 Then
			refreshCardPicture()
		End If
	End Sub
	
	Private Sub Scrolling_Configuraton_Button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Scrolling_Configuraton_Button.Click
		Scrolling_Mod_Configuration.Visible = True
	End Sub
	
	Public Function load_scrollConfiguration() As Object
		loading = 1
		Scrolling_Mod_Configuration.AV_1_Check.CheckState = CShort(LitDansFichierIni("scrolling", "AV_1", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.AV_10_Check.CheckState = CShort(LitDansFichierIni("scrolling", "AV_10", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.AV_20_Check.CheckState = CShort(LitDansFichierIni("scrolling", "AV_20", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.RE_1_Check.CheckState = CShort(LitDansFichierIni("scrolling", "RE_1", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.RE_10_Check.CheckState = CShort(LitDansFichierIni("scrolling", "RE_10", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.RE_20_Check.CheckState = CShort(LitDansFichierIni("scrolling", "RE_20", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TG_1_Check.CheckState = CShort(LitDansFichierIni("scrolling", "TG_1", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TG_15_Check.CheckState = CShort(LitDansFichierIni("scrolling", "TG_15", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TG_30_Check.CheckState = CShort(LitDansFichierIni("scrolling", "TG_30", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TG_45_Check.CheckState = CShort(LitDansFichierIni("scrolling", "TG_45", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TG_60_Check.CheckState = CShort(LitDansFichierIni("scrolling", "TG_60", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TG_90_Check.CheckState = CShort(LitDansFichierIni("scrolling", "TG_90", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TG_120_Check.CheckState = CShort(LitDansFichierIni("scrolling", "TG_120", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TD_1_Check.CheckState = CShort(LitDansFichierIni("scrolling", "TD_1", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TD_15_Check.CheckState = CShort(LitDansFichierIni("scrolling", "TD_15", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TD_30_Check.CheckState = CShort(LitDansFichierIni("scrolling", "TD_30", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TD_45_Check.CheckState = CShort(LitDansFichierIni("scrolling", "TD_45", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TD_60_Check.CheckState = CShort(LitDansFichierIni("scrolling", "TD_60", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TD_90_Check.CheckState = CShort(LitDansFichierIni("scrolling", "TD_90", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TD_120_Check.CheckState = CShort(LitDansFichierIni("scrolling", "TD_120", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		
		Scrolling_Mod_Configuration.B_C_check.CheckState = CShort(LitDansFichierIni("scrolling", "B_C", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.L_C_check.CheckState = CShort(LitDansFichierIni("scrolling", "L_C", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.RALE_check.CheckState = CShort(LitDansFichierIni("scrolling", "RALE", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.SONNE_check.CheckState = CShort(LitDansFichierIni("scrolling", "SONNE", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.JOUE_AIR_check.CheckState = CShort(LitDansFichierIni("scrolling", "JOUE_AIR", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.ALLUME_check.CheckState = CShort(LitDansFichierIni("scrolling", "ALLUME", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.ETEINS_check.CheckState = CShort(LitDansFichierIni("scrolling", "ETEINS", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.ETEINS_G_check.CheckState = CShort(LitDansFichierIni("scrolling", "ETEINS_G", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.ETEINS_D_check.CheckState = CShort(LitDansFichierIni("scrolling", "ETEINS_D", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.CLIGNE_G_check.CheckState = CShort(LitDansFichierIni("scrolling", "CLIGNE_G", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.CLIGNE_D_check.CheckState = CShort(LitDansFichierIni("scrolling", "CLIGNE_D", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.ARC_AVG_5_check.CheckState = CShort(LitDansFichierIni("scrolling", "ARC_AVG_5", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.ARC_AVG_10_check.CheckState = CShort(LitDansFichierIni("scrolling", "ARC_AVG_10", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.ARC_AVG_20_check.CheckState = CShort(LitDansFichierIni("scrolling", "ARC_AVG_20", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.ARC_AVD_5_check.CheckState = CShort(LitDansFichierIni("scrolling", "ARC_AVD_5", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.ARC_AVD_10_check.CheckState = CShort(LitDansFichierIni("scrolling", "ARC_AVD_10", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.ARC_AVD_20_check.CheckState = CShort(LitDansFichierIni("scrolling", "ARC_AVD_20", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		
		Scrolling_Mod_Configuration.REGLAGE_check.CheckState = CShort(LitDansFichierIni("scrolling", "REGLAGE", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TEST_check.CheckState = CShort(LitDansFichierIni("scrolling", "TEST", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TOUCHE_AVG_check.CheckState = CShort(LitDansFichierIni("scrolling", "TOUCHE_AVG", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TOUCHE_AVD_check.CheckState = CShort(LitDansFichierIni("scrolling", "TOUCHE_AVD", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TOUCHE_AR_check.CheckState = CShort(LitDansFichierIni("scrolling", "TOUCHE_AR", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TOUCHE_STOP_check.CheckState = CShort(LitDansFichierIni("scrolling", "TOUCHE_STOP", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.DES_QUE_check.CheckState = CShort(LitDansFichierIni("scrolling", "DES_QUE", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.C_EST_check.CheckState = CShort(LitDansFichierIni("scrolling", "C_EST", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.FIN_check.CheckState = CShort(LitDansFichierIni("scrolling", "FIN", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.SUPPRIME_check.CheckState = CShort(LitDansFichierIni("scrolling", "SUPPRIME", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.OUBLIE_check.CheckState = CShort(LitDansFichierIni("scrolling", "OUBLIE", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.APPRENDS_check.CheckState = CShort(LitDansFichierIni("scrolling", "APPRENDS", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.GOMME_check.CheckState = CShort(LitDansFichierIni("scrolling", "GOMME", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.EXECUTE_check.CheckState = CShort(LitDansFichierIni("scrolling", "EXECUTE", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.EXECUTE_P_check.CheckState = CShort(LitDansFichierIni("scrolling", "EXECUTE_P", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.EXECUTE_M_check.CheckState = CShort(LitDansFichierIni("scrolling", "EXECUTE_M", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.TOUT_check.CheckState = CShort(LitDansFichierIni("scrolling", "TOUT", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.ARRET_check.CheckState = CShort(LitDansFichierIni("scrolling", "ARRET", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		
		Scrolling_Mod_Configuration.PROCEDURE_N1_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N1", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N2_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N2", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N3_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N3", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N4_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N4", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N5_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N5", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N6_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N6", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N7_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N7", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N8_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N8", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N9_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N9", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N10_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N10", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N11_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N11", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N12_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N12", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N13_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N13", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N14_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N14", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N15_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N15", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N16_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N16", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N17_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N17", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N18_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N18", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N19_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N19", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N20_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N20", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N21_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N21", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N22_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N22", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N23_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N23", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N24_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N24", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N25_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N25", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N26_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N26", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N27_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N27", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N28_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N28", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N29_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N29", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N30_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N30", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N31_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N31", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N32_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N32", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N33_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N33", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N34_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N34", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N35_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N35", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		Scrolling_Mod_Configuration.PROCEDURE_N36_check.CheckState = CShort(LitDansFichierIni("scrolling", "PROCEDURE_N36", My.Application.Info.DirectoryPath & "\T3 Manager.ini", ""))
		
		Scrolling_Mod_Configuration.AV_1_Text.Text = LitDansFichierIni("category", "AV_1", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.AV_10_Text.Text = LitDansFichierIni("category", "AV_10", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.AV_20_Text.Text = LitDansFichierIni("category", "AV_20", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.RE_1_Text.Text = LitDansFichierIni("category", "RE_1", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.RE_10_Text.Text = LitDansFichierIni("category", "RE_10", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.RE_20_Text.Text = LitDansFichierIni("category", "RE_20", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TG_1_Text.Text = LitDansFichierIni("category", "TG_1", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TG_15_Text.Text = LitDansFichierIni("category", "TG_15", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TG_30_Text.Text = LitDansFichierIni("category", "TG_30", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TG_45_Text.Text = LitDansFichierIni("category", "TG_45", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TG_60_Text.Text = LitDansFichierIni("category", "TG_60", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TG_90_Text.Text = LitDansFichierIni("category", "TG_90", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TG_120_Text.Text = LitDansFichierIni("category", "TG_120", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TD_1_Text.Text = LitDansFichierIni("category", "TD_1", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TD_15_Text.Text = LitDansFichierIni("category", "TD_15", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TD_30_Text.Text = LitDansFichierIni("category", "TD_30", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TD_45_Text.Text = LitDansFichierIni("category", "TD_45", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TD_60_Text.Text = LitDansFichierIni("category", "TD_60", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TD_90_Text.Text = LitDansFichierIni("category", "TD_90", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TD_120_Text.Text = LitDansFichierIni("category", "TD_120", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		
		Scrolling_Mod_Configuration.B_C_Text.Text = LitDansFichierIni("category", "B_C", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.L_C_Text.Text = LitDansFichierIni("category", "L_C", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.RALE_Text.Text = LitDansFichierIni("category", "RALE", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.SONNE_Text.Text = LitDansFichierIni("category", "SONNE", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.JOUE_AIR_Text.Text = LitDansFichierIni("category", "JOUE_AIR", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.ALLUME_Text.Text = LitDansFichierIni("category", "ALLUME", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.ETEINS_Text.Text = LitDansFichierIni("category", "ETEINS", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.ETEINS_G_Text.Text = LitDansFichierIni("category", "ETEINS_G", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.ETEINS_D_Text.Text = LitDansFichierIni("category", "ETEINS_D", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.CLIGNE_G_Text.Text = LitDansFichierIni("category", "CLIGNE_G", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.CLIGNE_D_Text.Text = LitDansFichierIni("category", "CLIGNE_D", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.ARC_AVG_5_Text.Text = LitDansFichierIni("category", "ARC_AVG_5", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.ARC_AVG_10_Text.Text = LitDansFichierIni("category", "ARC_AVG_10", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.ARC_AVG_20_Text.Text = LitDansFichierIni("category", "ARC_AVG_20", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.ARC_AVD_5_Text.Text = LitDansFichierIni("category", "ARC_AVD_5", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.ARC_AVD_10_Text.Text = LitDansFichierIni("category", "ARC_AVD_10", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.ARC_AVD_20_Text.Text = LitDansFichierIni("category", "ARC_AVD_20", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		
		Scrolling_Mod_Configuration.REGLAGE_Text.Text = LitDansFichierIni("category", "REGLAGE", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TEST_Text.Text = LitDansFichierIni("category", "TEST", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TOUCHE_AVG_Text.Text = LitDansFichierIni("category", "TOUCHE_AVG", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TOUCHE_AVD_Text.Text = LitDansFichierIni("category", "TOUCHE_AVD", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TOUCHE_AR_Text.Text = LitDansFichierIni("category", "TOUCHE_AR", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.TOUCHE_STOP_Text.Text = LitDansFichierIni("category", "TOUCHE_STOP", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.DES_QUE_Text.Text = LitDansFichierIni("category", "DES_QUE", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.C_EST_Text.Text = LitDansFichierIni("category", "C_EST", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.FIN_Text.Text = LitDansFichierIni("category", "FIN", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.SUPPRIME_Text.Text = LitDansFichierIni("category", "SUPPRIME", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.OUBLIE_Text.Text = LitDansFichierIni("category", "OUBLIE", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.APPRENDS_Text.Text = LitDansFichierIni("category", "APPRENDS", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.GOMME_Text.Text = LitDansFichierIni("category", "GOMME", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.EXECUTE_Text.Text = LitDansFichierIni("category", "EXECUTE", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.EXECUTE_P_Text.Text = LitDansFichierIni("category", "EXECUTE_P", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.EXECUTE_M_Text.Text = LitDansFichierIni("category", "EXECUTE_M", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.Tout_Text.Text = LitDansFichierIni("category", "TOUT", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.ARRET_Text.Text = LitDansFichierIni("category", "ARRET", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		
		Scrolling_Mod_Configuration.PROCEDURE_N1_Text.Text = LitDansFichierIni("category", "PROCEDURE_N1", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N2_Text.Text = LitDansFichierIni("category", "PROCEDURE_N2", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N3_Text.Text = LitDansFichierIni("category", "PROCEDURE_N3", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N4_Text.Text = LitDansFichierIni("category", "PROCEDURE_N4", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N5_Text.Text = LitDansFichierIni("category", "PROCEDURE_N5", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N6_Text.Text = LitDansFichierIni("category", "PROCEDURE_N6", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N7_Text.Text = LitDansFichierIni("category", "PROCEDURE_N7", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N8_Text.Text = LitDansFichierIni("category", "PROCEDURE_N8", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N9_Text.Text = LitDansFichierIni("category", "PROCEDURE_N9", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N10_Text.Text = LitDansFichierIni("category", "PROCEDURE_N10", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N11_Text.Text = LitDansFichierIni("category", "PROCEDURE_N11", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N12_Text.Text = LitDansFichierIni("category", "PROCEDURE_N12", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N13_Text.Text = LitDansFichierIni("category", "PROCEDURE_N13", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N14_Text.Text = LitDansFichierIni("category", "PROCEDURE_N14", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N15_Text.Text = LitDansFichierIni("category", "PROCEDURE_N15", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N16_Text.Text = LitDansFichierIni("category", "PROCEDURE_N16", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N17_Text.Text = LitDansFichierIni("category", "PROCEDURE_N17", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N18_Text.Text = LitDansFichierIni("category", "PROCEDURE_N18", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N19_Text.Text = LitDansFichierIni("category", "PROCEDURE_N19", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N20_Text.Text = LitDansFichierIni("category", "PROCEDURE_N20", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N21_Text.Text = LitDansFichierIni("category", "PROCEDURE_N21", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N22_Text.Text = LitDansFichierIni("category", "PROCEDURE_N22", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N23_Text.Text = LitDansFichierIni("category", "PROCEDURE_N23", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N24_Text.Text = LitDansFichierIni("category", "PROCEDURE_N24", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N25_Text.Text = LitDansFichierIni("category", "PROCEDURE_N25", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N26_Text.Text = LitDansFichierIni("category", "PROCEDURE_N26", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N27_Text.Text = LitDansFichierIni("category", "PROCEDURE_N27", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N28_Text.Text = LitDansFichierIni("category", "PROCEDURE_N28", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N29_Text.Text = LitDansFichierIni("category", "PROCEDURE_N29", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N30_Text.Text = LitDansFichierIni("category", "PROCEDURE_N30", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N31_Text.Text = LitDansFichierIni("category", "PROCEDURE_N31", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N32_Text.Text = LitDansFichierIni("category", "PROCEDURE_N32", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N33_Text.Text = LitDansFichierIni("category", "PROCEDURE_N33", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N34_Text.Text = LitDansFichierIni("category", "PROCEDURE_N34", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N35_Text.Text = LitDansFichierIni("category", "PROCEDURE_N35", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		Scrolling_Mod_Configuration.PROCEDURE_N36_Text.Text = LitDansFichierIni("category", "PROCEDURE_N36", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "")
		
		Scrolling_Mod_Configuration.Use_Category.CheckState = CShort(LitDansFichierIni("scroll", "useCategory", My.Application.Info.DirectoryPath & "\T3 Manager.ini", CStr(0)))
		Scrolling_Mod_Configuration.Auto_Return.CheckState = CShort(LitDansFichierIni("scroll", "autoReturn", My.Application.Info.DirectoryPath & "\T3 Manager.ini", CStr(0)))
		Scrolling_Mod_Configuration.scroll_time.Text = LitDansFichierIni("scroll", "scrollingTime", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "1000")
		Scrolling_Mod_Configuration.sound_mod.Text = LitDansFichierIni("scroll", "soundMod", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "Non")
		Scrolling_Mod_Configuration.confirm_time.Text = LitDansFichierIni("scroll", "confirmTime", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "1000")
		Scrolling_Mod_Configuration.confirm_mod.Text = LitDansFichierIni("scroll", "confirmMod", My.Application.Info.DirectoryPath & "\T3 Manager.ini", "Non")
		
		'UPGRADE_WARNING: Timer property Scroll_Timer.Interval cannot have a value of 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="169ECF4A-1968-402D-B243-16603CC08604"'
		Scroll_Timer.Interval = CInt(Scrolling_Mod_Configuration.scroll_time.Text)
		If Scrolling_Mod_Configuration.Use_Category.CheckState = 0 Then
			currentCategory = 1
		Else
			currentCategory = 2
		End If
		currentCardIndex = 1
		createScrollCardList()
		refreshCardPicture()
		loading = 0
	End Function
	
	Public Function Exists(ByRef col As Object, ByRef index As Object) As Boolean
		On Error GoTo ExistsTryNonObject
		Dim o As Object
		
		o = col(index)
		Exists = True
		Exit Function
		
ExistsTryNonObject: 
		Exists = ExistsNonObject(col, index)
	End Function
	
	Private Function ExistsNonObject(ByRef col As Object, ByRef index As Object) As Boolean
		On Error GoTo ExistsNonObjectErrorHandler
		Dim v As Object
		
		'UPGRADE_WARNING: Couldn't resolve default property of object col(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object v. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		v = col(index)
		ExistsNonObject = True
		Exit Function
		
ExistsNonObjectErrorHandler: 
		ExistsNonObject = False
	End Function
End Class