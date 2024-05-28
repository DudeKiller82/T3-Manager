VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "SvgFileClass"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

Implements IVBSAXContentHandler

Public lineList As Collection
Public minX As Double
Public minY As Double
Public maxX As Double
Public maxY As Double
Private startX As Double
Private startY As Double
Private line As LineClass
Private lineOff As LineClass
Private pathCommands As Collection



Private Sub Class_Initialize()
    Set lineList = New Collection
    minX = 1000000
    minY = 1000000
    maxX = -1000000
    maxY = -1000000
    startX = 0
    startY = 0
End Sub


'''''''''''''''''''''''''''''''''''''''''''''''''''
'                                                 '
' IVBSAXContentHandler Properties                 '
'                                                 '
'''''''''''''''''''''''''''''''''''''''''''''''''''

Private Property Set IVBSAXContentHandler_documentLocator(ByVal RHS As MSXML2.IVBSAXLocator)
End Property


'''''''''''''''''''''''''''''''''''''''''''''''''''
'                                                 '
' IVBSAXContentHandler Methods                    '
'                                                 '
'''''''''''''''''''''''''''''''''''''''''''''''''''

Private Sub IVBSAXContentHandler_startElement(sNamespaceURI As String, sLocalName As String, sQName As String, ByVal oAttributes As MSXML2.IVBSAXAttributes)
    Dim pos As Integer
    Dim d As String
    Dim command As String
    Select Case sLocalName
        Case "path"
            Set pathCommands = New Collection
            d = oAttributes.getValueFromName("", "d")
            Do While Len(d) <> 0
                command = d
                If InStr(Mid(command, 2), "M") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "M") - 1)
                If InStr(Mid(command, 2), "m") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "m") - 1)
                If InStr(Mid(command, 2), "Z") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "Z") - 1)
                If InStr(Mid(command, 2), "z") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "z") - 1)
                If InStr(Mid(command, 2), "L") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "L") - 1)
                If InStr(Mid(command, 2), "l") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "l") - 1)
                If InStr(Mid(command, 2), "H") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "H") - 1)
                If InStr(Mid(command, 2), "h") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "h") - 1)
                If InStr(Mid(command, 2), "V") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "V") - 1)
                If InStr(Mid(command, 2), "v") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "v") - 1)
                If InStr(Mid(command, 2), "C") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "C") - 1)
                If InStr(Mid(command, 2), "c") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "c") - 1)
                If InStr(Mid(command, 2), "S") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "S") - 1)
                If InStr(Mid(command, 2), "s") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "s") - 1)
                If InStr(Mid(command, 2), "Q") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "Q") - 1)
                If InStr(Mid(command, 2), "q") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "q") - 1)
                If InStr(Mid(command, 2), "T") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "T") - 1)
                If InStr(Mid(command, 2), "t") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "t") - 1)
                If InStr(Mid(command, 2), "A") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "A") - 1)
                If InStr(Mid(command, 2), "a") <> 0 Then: command = Left(command, InStr(Mid(command, 2), "a") - 1)
                If Len(command) <> 0 Then
                    pathCommands.Add command
                    If Len(d) - Len(command) - 1 > 0 Then
                        d = Right(d, Len(d) - Len(command) - 1)
                    Else
                        d = ""
                    End If
                End If
            Loop
    End Select
End Sub

Private Sub IVBSAXContentHandler_characters(sChars As String)
End Sub

Private Sub IVBSAXContentHandler_endElement(sNamespaceURI As String, sLocalName As String, sQName As String)
    Dim command As Variant
    Select Case sLocalName
        Case "path"
            For Each command In pathCommands
                Set line = New LineClass
                Select Case Left(command, 1)
                    Case "M"
                        command = Mid(command, 2)
                        startX = CDbl(Replace(Left(command, InStr(command, ",") - 1), ".", ","))
                        command = Mid(command, InStr(command, ",") + 1)
                        startY = -CDbl(Replace(command, ".", ","))
                    
                    Case "m"
                    
                    Case "Z"
                    
                    Case "z"
                    
                    Case "L"
                        command = Mid(command, 2)
                        line.x2 = CDbl(Replace(Left(command, InStr(command, ",") - 1), ".", ","))
                        command = Mid(command, InStr(command, ",") + 1)
                        line.y2 = -CDbl(Replace(command, ".", ","))
                        line.x1 = startX
                        line.y1 = startY
                        startX = line.x2
                        startY = line.y2
                        lineList.Add line
                        line.drawing = True
                        If line.x1 < minX Then: minX = line.x1
                        If line.x2 < minX Then: minX = line.x2
                        If line.y1 < minY Then: minY = line.y1
                        If line.y2 < minY Then: minY = line.y2
                        If line.x1 > maxX Then: maxX = line.x1
                        If line.x2 > maxX Then: maxX = line.x2
                        If line.y1 > maxY Then: maxY = line.y1
                        If line.y2 > maxY Then: maxY = line.y2
                        
                    Case "l"
                    
                    Case "H"
                    
                    Case "h"
                    
                    Case "V"
                    
                    Case "v"
                    
                    Case "C"
                        command = Mid(command, 2)
                        line.x1Curve = CDbl(Replace(Left(command, InStr(command, ",") - 1), ".", ","))
                        command = Mid(command, InStr(command, ",") + 1)
                        line.y1Curve = CDbl(Replace(Left(command, InStr(command, " ") - 1), ".", ","))
                        command = Mid(command, InStr(command, " ") + 1)
                        line.x2Curve = CDbl(Replace(Left(command, InStr(command, ",") - 1), ".", ","))
                        command = Mid(command, InStr(command, ",") + 1)
                        line.y2Curve = CDbl(Replace(Left(command, InStr(command, " ") - 1), ".", ","))
                        command = Mid(command, InStr(command, " ") + 1)
                        line.x2 = CDbl(Replace(Left(command, InStr(command, ",") - 1), ".", ","))
                        command = Mid(command, InStr(command, ",") + 1)
                        line.y2 = -CDbl(Replace(command, ".", ","))
                        line.x1 = startX
                        line.y1 = startY
                        startX = line.x2
                        startY = line.y2
                        lineList.Add line
                        line.drawing = True
                        If line.x1 < minX Then: minX = line.x1
                        If line.x2 < minX Then: minX = line.x2
                        If line.y1 < minY Then: minY = line.y1
                        If line.y2 < minY Then: minY = line.y2
                        If line.x1 > maxX Then: maxX = line.x1
                        If line.x2 > maxX Then: maxX = line.x2
                        If line.y1 > maxY Then: maxY = line.y1
                        If line.y2 > maxY Then: maxY = line.y2
                    
                    Case "c"
                    
                    Case "S"
                    
                    Case "s"
                    
                    Case "Q"
                    
                    Case "q"
                    
                    Case "T"
                    
                    Case "t"
                    
                    Case "A"
                    
                    Case "a"
                
                End Select
            Next
    End Select
End Sub


'''''''''''''''''''''''''''''''''''''''''''''''''''
'                                                 '
' IVBSAXContentHandler unused abstract Methods    '
'                                                 '
'''''''''''''''''''''''''''''''''''''''''''''''''''

Private Sub IVBSAXContentHandler_startDocument()
End Sub

Private Sub IVBSAXContentHandler_startPrefixMapping(sPrefix As String, sURI As String)
End Sub

Private Sub IVBSAXContentHandler_endPrefixMapping(sPrefix As String)
End Sub

Private Sub IVBSAXContentHandler_ignorableWhitespace(sChars As String)
End Sub

Private Sub IVBSAXContentHandler_processingInstruction(sTarget As String, sData As String)
End Sub

Private Sub IVBSAXContentHandler_skippedEntity(sName As String)
End Sub

Private Sub IVBSAXContentHandler_endDocument()
End Sub




