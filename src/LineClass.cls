VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "LineClass"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False


Option Explicit
Public x1 As Double
Public y1 As Double
Public x2 As Double
Public y2 As Double
Public x1Curve As Double
Public y1Curve As Double
Public x2Curve As Double
Public y2Curve As Double
Public x1Real As Double
Public y1Real As Double
Public x2Real As Double
Public y2Real As Double
Public length As Double
Public lengthReal As Double
Public teta As Double
Public transfertAngle As Double
Public transfertAngleReal As Double
Public drawing As Boolean
Public mapped As Boolean
Public ignored As Boolean
Public move_Card_List As Collection
Public command_card_list As Collection



Private Sub Class_Initialize()
    x1 = 0
    y1 = 0
    x2 = 0
    y2 = 0
    x1Curve = 0
    y1Curve = 0
    x2Curve = 0
    y2Curve = 0
    x1Real = 0
    y1Real = 0
    x2Real = 0
    y2Real = 0
    length = 0
    lengthReal = 0
    teta = 0
    transfertAngle = 0
    transfertAngleReal = 0
    drawing = False
    ignored = False
    mapped = False
    Set move_Card_List = New Collection
    Set command_card_list = New Collection
End Sub



