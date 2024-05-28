Attribute VB_Name = "OpenFile"
' ini file
Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" _
    (ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpDefault As String, _
    ByVal lpReturnedString As String, ByVal nSize As Long, ByVal lpFileName As String) As Long

Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" _
    (ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpString As Any, _
    ByVal lpFileName As String) As Long
  
'Déclaration de l'API

Private Declare Function GetOpenFileName Lib "comdlg32.dll" Alias _
                   "GetOpenFileNameA" (pOpenfilename As OPENFILENAME) As Long

 'Structure du fichier
Private Type OPENFILENAME
    lStructSize As Long
    hwndOwner As Long
    hInstance As Long
    lpstrFilter As String
    lpstrCustomFilter As String
    nMaxCustFilter As Long
    nFilterIndex As Long
    lpstrFile As String
    nMaxFile As Long
    lpstrFileTitle As String
    nMaxFileTitle As Long
    lpstrInitialDir As String
    lpstrTitle As String
    flags As Long
    nFileOffset As Integer
    nFileExtension As Integer
    lpstrDefExt As String
    lCustData As Long
    lpfnHook As Long
    lpTemplateName As String
End Type

 'Constantes
Private Const OFN_READONLY = &H1
Private Const OFN_OVERWRITEPROMPT = &H2
Private Const OFN_HIDEREADONLY = &H4
Private Const OFN_NOCHANGEDIR = &H8
Private Const OFN_SHOWHELP = &H10
Private Const OFN_ENABLEHOOK = &H20
Private Const OFN_ENABLETEMPLATE = &H40
Private Const OFN_ENABLETEMPLATEHANDLE = &H80
Private Const OFN_NOVALIDATE = &H100
Private Const OFN_ALLOWMULTISELECT = &H200
Private Const OFN_EXTENSIONDIFFERENT = &H400
Private Const OFN_PATHMUSTEXIST = &H800
Private Const OFN_FILEMUSTEXIST = &H1000
Private Const OFN_CREATEPROMPT = &H2000
Private Const OFN_SHAREAWARE = &H4000
Private Const OFN_NOREADONLYRETURN = &H8000
Private Const OFN_NOTESTFILECREATE = &H10000

Private Const OFN_SHAREFALLTHROUGH = 2
Private Const OFN_SHARENOWARN = 1
Private Const OFN_SHAREWARN = 0


Public Function OuvrirUnFichier(Handle As Long, _
                                Titre As String, _
                                TypeRetour As Byte, _
                                Optional TitreFiltre As String, _
                                Optional TypeFichier As String, _
                                Optional RepParDefaut As String) As String
 'OuvrirUnFichier est la fonction a utiliser dans votre formulaire pour ouvrir _
 'la boîte de dialogue de sélection d'un fichier.
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
  sFiltre = TitreFiltre & " (" & TypeFichier & ")" & Chr$(0) & "*." & TypeFichier & Chr$(0)
End If
sFiltre = sFiltre & "Tous (*.*)" & Chr$(0) & "*.*" & Chr$(0)


 'Configuration de la boîte de dialogue
  With StructFile
    .lStructSize = Len(StructFile) 'Initialisation de la grosseur de la structure
    .hwndOwner = Handle 'Identification du handle de la fenêtre
    .lpstrFilter = sFiltre 'Application du filtre
    .lpstrFile = String$(254, vbNullChar) 'Initialisation du fichier '0' x 254
    .nMaxFile = 254 'Taille maximale du fichier
    .lpstrFileTitle = String$(254, vbNullChar) 'Initialisation du nom du fichier '0' x 254
    .nMaxFileTitle = 254  'Taille maximale du nom du fichier
    .lpstrTitle = Titre 'Titre de la boîte de dialogue
    .flags = OFN_HIDEREADONLY  'Option de la boite de dialogue
    If ((IsNull(RepParDefaut)) Or (RepParDefaut = "")) Then
        .lpstrInitialDir = App.Path
        Else: .lpstrInitialDir = RepParDefaut
    End If
  End With
   
If (GetOpenFileName(StructFile)) Then 'Si un fichier est sélectionné
    Select Case TypeRetour
      Case 1: OuvrirUnFichier = Trim$(Left(StructFile.lpstrFile, InStr(1, StructFile.lpstrFile, vbNullChar) - 1))
      Case 2: OuvrirUnFichier = Trim$(Left(StructFile.lpstrFileTitle, InStr(1, StructFile.lpstrFileTitle, vbNullChar) - 1))
    End Select
  End If

End Function

Public Function EcritDansFichierIni(Section As String, Cle As String, _
                                     Valeur As String, Fichier As String) As Long
EcritDansFichierIni = WritePrivateProfileString(Section, Cle, Valeur, Fichier)
End Function

Public Function LitDansFichierIni(Section As String, Cle As String, Fichier As String, _
    Optional ValeurParDefaut As String = "") As String

    Dim strReturn As String
    strReturn = String(255, 0)
    GetPrivateProfileString Section, Cle, ValeurParDefaut, strReturn, Len(strReturn), Fichier
    LitDansFichierIni = Left(strReturn, InStr(strReturn, Chr(0)) - 1)
End Function
