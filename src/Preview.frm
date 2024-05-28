VERSION 5.00
Begin VB.Form Preview 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Aperçu"
   ClientHeight    =   9315
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   9090
   Icon            =   "Preview.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   9315
   ScaleWidth      =   9090
   StartUpPosition =   3  'Windows Default
   Visible         =   0   'False
   Begin VB.CheckBox CheckInterLine 
      BackColor       =   &H0000FF00&
      Caption         =   "Afficher les lignes non dessinées"
      Height          =   255
      Left            =   3240
      TabIndex        =   3
      Top             =   9000
      Width           =   2655
   End
   Begin VB.CheckBox CheckReal 
      BackColor       =   &H000000FF&
      Caption         =   "Afficher l'aperçu"
      ForeColor       =   &H00000000&
      Height          =   255
      Left            =   1680
      TabIndex        =   2
      Top             =   9000
      Value           =   1  'Checked
      Width           =   1455
   End
   Begin VB.CheckBox CheckImage 
      Caption         =   "Afficher l'image"
      Height          =   255
      Left            =   120
      TabIndex        =   1
      Top             =   9000
      Value           =   1  'Checked
      Width           =   1455
   End
   Begin VB.PictureBox PreviewZone 
      BackColor       =   &H80000009&
      Height          =   8835
      Left            =   120
      ScaleHeight     =   33.176
      ScaleMode       =   0  'User
      ScaleWidth      =   33.176
      TabIndex        =   0
      Top             =   120
      Width           =   8835
   End
End
Attribute VB_Name = "Preview"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CheckImage_Click()
    printAll T3_Manager.lineList
End Sub

Private Sub CheckInterLine_Click()
    printAll T3_Manager.lineList
End Sub

Private Sub CheckReal_Click()
    printAll T3_Manager.lineList
End Sub

Private Sub Form_Click()
    printAll T3_Manager.lineList
End Sub

Private Sub PreviewZone_Click()
    printAll T3_Manager.lineList
End Sub
