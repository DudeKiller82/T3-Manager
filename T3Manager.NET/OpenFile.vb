Option Strict Off
Option Explicit On
Module OpenFile
	' ini file
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
	Private Declare Function GetPrivateProfileString Lib "kernel32"  Alias "GetPrivateProfileStringA"(ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
	
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
	Private Declare Function WritePrivateProfileString Lib "kernel32"  Alias "WritePrivateProfileStringA"(ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpString As Any, ByVal lpFileName As String) As Integer
	
	'Déclaration de l'API
	
	'UPGRADE_WARNING: Structure OPENFILENAME may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function GetOpenFileName Lib "comdlg32.dll"  Alias "GetOpenFileNameA"(ByRef pOpenfilename As OPENFILENAME) As Integer
	
	'Structure du fichier
	Private Structure OPENFILENAME
		Dim lStructSize As Integer
		Dim hwndOwner As Integer
		Dim hInstance As Integer
		Dim lpstrFilter As String
		Dim lpstrCustomFilter As String
		Dim nMaxCustFilter As Integer
		Dim nFilterIndex As Integer
		Dim lpstrFile As String
		Dim nMaxFile As Integer
		Dim lpstrFileTitle As String
		Dim nMaxFileTitle As Integer
		Dim lpstrInitialDir As String
		Dim lpstrTitle As String
		Dim flags As Integer
		Dim nFileOffset As Short
		Dim nFileExtension As Short
		Dim lpstrDefExt As String
		Dim lCustData As Integer
		Dim lpfnHook As Integer
		Dim lpTemplateName As String
	End Structure
	
	'Constantes
	Private Const OFN_READONLY As Integer = &H1
	Private Const OFN_OVERWRITEPROMPT As Integer = &H2
	Private Const OFN_HIDEREADONLY As Integer = &H4
	Private Const OFN_NOCHANGEDIR As Integer = &H8
	Private Const OFN_SHOWHELP As Integer = &H10
	Private Const OFN_ENABLEHOOK As Integer = &H20
	Private Const OFN_ENABLETEMPLATE As Integer = &H40
	Private Const OFN_ENABLETEMPLATEHANDLE As Integer = &H80
	Private Const OFN_NOVALIDATE As Integer = &H100
	Private Const OFN_ALLOWMULTISELECT As Integer = &H200
	Private Const OFN_EXTENSIONDIFFERENT As Integer = &H400
	Private Const OFN_PATHMUSTEXIST As Integer = &H800
	Private Const OFN_FILEMUSTEXIST As Integer = &H1000
	Private Const OFN_CREATEPROMPT As Integer = &H2000
	Private Const OFN_SHAREAWARE As Integer = &H4000
	Private Const OFN_NOREADONLYRETURN As Integer = &H8000
	Private Const OFN_NOTESTFILECREATE As Integer = &H10000
	
	Private Const OFN_SHAREFALLTHROUGH As Short = 2
	Private Const OFN_SHARENOWARN As Short = 1
	Private Const OFN_SHAREWARN As Short = 0
	
	
	Public Function OuvrirUnFichier(ByRef Handle As Integer, ByRef Titre As String, ByRef TypeRetour As Byte, Optional ByRef TitreFiltre As String = "", Optional ByRef TypeFichier As String = "", Optional ByRef RepParDefaut As String = "") As String
		'OuvrirUnFichier est la fonction a utiliser dans votre formulaire pour ouvrir _
		''la boîte de dialogue de sélection d'un fichier.
		'Explication des paramètres
		'Handle = le handle de la fenêtre (Me.Hwnd)
		'Titre = Titre de la boîte de dialogue
		'TypeRetour (Définit la valeur, de type String, renvoyée par la fonction)
		'1 = Chemin complet + Nom du fichier
		'2 = Nom fichier seulement
		'TitreFiltre = Titre du filtre
		'Exemple: Fichier Access
		'N'utilisez pas cet argument si vous ne voulez spécifier aucun filtre
		'TypeFichier = Extention du fichier (Sans le .)
		'Exemple: MDB
		'N'utilisez pas cet argument si vous ne voulez spécifier aucun filtre
		'RepParDefaut = Répertoire d'ouverture par defaut
		'Exemple: C:\windows\system32
		'Si vous laissé l'argument vide, par defaut il se place dans le répertoire de votre application
		
		Dim StructFile As OPENFILENAME
		Dim sFiltre As String
		
		'Construction du filtre en fonction des arguments spécifiés
		If Len(TitreFiltre) > 0 And Len(TypeFichier) > 0 Then
			sFiltre = TitreFiltre & " (" & TypeFichier & ")" & Chr(0) & "*." & TypeFichier & Chr(0)
		End If
		sFiltre = sFiltre & "Tous (*.*)" & Chr(0) & "*.*" & Chr(0)
		
		
		'Configuration de la boîte de dialogue
		With StructFile
			.lStructSize = Len(StructFile) 'Initialisation de la grosseur de la structure
			.hwndOwner = Handle 'Identification du handle de la fenêtre
			.lpstrFilter = sFiltre 'Application du filtre
			.lpstrFile = New String(vbNullChar, 254) 'Initialisation du fichier '0' x 254
			.nMaxFile = 254 'Taille maximale du fichier
			.lpstrFileTitle = New String(vbNullChar, 254) 'Initialisation du nom du fichier '0' x 254
			.nMaxFileTitle = 254 'Taille maximale du nom du fichier
			.lpstrTitle = Titre 'Titre de la boîte de dialogue
			.flags = OFN_HIDEREADONLY 'Option de la boite de dialogue
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If ((IsDbNull(RepParDefaut)) Or (RepParDefaut = "")) Then
				.lpstrInitialDir = My.Application.Info.DirectoryPath
			Else : .lpstrInitialDir = RepParDefaut
			End If
		End With
		
		If (GetOpenFileName(StructFile)) Then 'Si un fichier est sélectionné
			Select Case TypeRetour
				Case 1 : OuvrirUnFichier = Trim(Left(StructFile.lpstrFile, InStr(1, StructFile.lpstrFile, vbNullChar) - 1))
				Case 2 : OuvrirUnFichier = Trim(Left(StructFile.lpstrFileTitle, InStr(1, StructFile.lpstrFileTitle, vbNullChar) - 1))
			End Select
		End If
		
	End Function
	
	Public Function EcritDansFichierIni(ByRef Section As String, ByRef Cle As String, ByRef Valeur As String, ByRef Fichier As String) As Integer
		EcritDansFichierIni = WritePrivateProfileString(Section, Cle, Valeur, Fichier)
	End Function
	
	Public Function LitDansFichierIni(ByRef Section As String, ByRef Cle As String, ByRef Fichier As String, Optional ByRef ValeurParDefaut As String = "") As String
		
		Dim strReturn As String
		strReturn = New String(Chr(0), 255)
		GetPrivateProfileString(Section, Cle, ValeurParDefaut, strReturn, Len(strReturn), Fichier)
		LitDansFichierIni = Left(strReturn, InStr(strReturn, Chr(0)) - 1)
	End Function
End Module