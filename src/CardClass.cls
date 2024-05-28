VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CardClass"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit
Public name As String
Public code As Integer
Public revert As String
Public text As String
Public runningTime As Long
Public isRotation As Boolean
Public isTranslation As Boolean
Public target As Double
Public result As Double
Public value As Double
Public trueValue As Double
Public picture As String
Public sound As String
Public scrolling As Boolean
Public scrollingCategory As String


Private Sub Class_Initialize()
    name = ""
    code = 0
    revert = ""
    text = ""
    isRotation = False
    isTranslation = False
    target = 0
    result = 0
    runningTime = 0
    value = 0
    trueValue = 0
    picture = ""
    sound = ""
    scrolling = False
    scrollingCategory = ""
End Sub



