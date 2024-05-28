Option Strict Off
Option Explicit On
Friend Class SvgFileClass
	Implements MSXML2.IVBSAXContentHandler
	
	
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
	
	
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Initialize_Renamed()
		lineList = New Collection
		minX = 1000000
		minY = 1000000
		maxX = -1000000
		maxY = -1000000
		startX = 0
		startY = 0
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
	
	
	'''''''''''''''''''''''''''''''''''''''''''''''''''
	'                                                 '
	' IVBSAXContentHandler Properties                 '
	'                                                 '
	'''''''''''''''''''''''''''''''''''''''''''''''''''
	
	Private WriteOnly Property IVBSAXContentHandler_documentLocator() As MSXML2.IVBSAXLocator Implements MSXML2.IVBSAXContentHandler.documentLocator
		Set(ByVal Value As MSXML2.IVBSAXLocator)
		End Set
	End Property
	
	
	'''''''''''''''''''''''''''''''''''''''''''''''''''
	'                                                 '
	' IVBSAXContentHandler Methods                    '
	'                                                 '
	'''''''''''''''''''''''''''''''''''''''''''''''''''
	
	Private Sub IVBSAXContentHandler_startElement(ByRef sNamespaceURI As String, ByRef sLocalName As String, ByRef sQName As String, ByVal oAttributes As MSXML2.IVBSAXAttributes) Implements MSXML2.IVBSAXContentHandler.startElement
		Dim pos As Short
		Dim d As String
		'UPGRADE_NOTE: command was upgraded to command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim command_Renamed As String
		Select Case sLocalName
			Case "path"
				pathCommands = New Collection
				d = oAttributes.getValueFromName("", "d")
				Do While Len(d) <> 0
					command_Renamed = d
					If InStr(Mid(command_Renamed, 2), "M") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "M") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "m") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "m") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "Z") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "Z") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "z") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "z") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "L") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "L") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "l") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "l") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "H") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "H") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "h") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "h") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "V") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "V") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "v") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "v") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "C") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "C") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "c") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "c") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "S") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "S") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "s") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "s") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "Q") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "Q") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "q") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "q") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "T") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "T") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "t") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "t") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "A") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "A") - 1)
					End If
					If InStr(Mid(command_Renamed, 2), "a") <> 0 Then
						command_Renamed = Left(command_Renamed, InStr(Mid(command_Renamed, 2), "a") - 1)
					End If
					If Len(command_Renamed) <> 0 Then
						pathCommands.Add(command_Renamed)
						If Len(d) - Len(command_Renamed) - 1 > 0 Then
							d = Right(d, Len(d) - Len(command_Renamed) - 1)
						Else
							d = ""
						End If
					End If
				Loop 
		End Select
	End Sub
	
	Private Sub IVBSAXContentHandler_characters(ByRef sChars As String) Implements MSXML2.IVBSAXContentHandler.characters
	End Sub
	
	Private Sub IVBSAXContentHandler_endElement(ByRef sNamespaceURI As String, ByRef sLocalName As String, ByRef sQName As String) Implements MSXML2.IVBSAXContentHandler.endElement
		'UPGRADE_NOTE: command was upgraded to command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim command_Renamed As Object
		Select Case sLocalName
			Case "path"
				For	Each command_Renamed In pathCommands
					line = New LineClass
					'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Select Case Left(command_Renamed, 1)
						Case "M"
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							command_Renamed = Mid(command_Renamed, 2)
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							startX = CDbl(Replace(Left(command_Renamed, InStr(command_Renamed, ",") - 1), ".", ","))
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							command_Renamed = Mid(command_Renamed, InStr(command_Renamed, ",") + 1)
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							startY = -CDbl(Replace(command_Renamed, ".", ","))
							
						Case "m"
							
						Case "Z"
							
						Case "z"
							
						Case "L"
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							command_Renamed = Mid(command_Renamed, 2)
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							line.x2 = CDbl(Replace(Left(command_Renamed, InStr(command_Renamed, ",") - 1), ".", ","))
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							command_Renamed = Mid(command_Renamed, InStr(command_Renamed, ",") + 1)
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							line.y2 = -CDbl(Replace(command_Renamed, ".", ","))
							line.x1 = startX
							line.y1 = startY
							startX = line.x2
							startY = line.y2
							lineList.Add(line)
							line.drawing = True
							If line.x1 < minX Then
								minX = line.x1
							End If
							If line.x2 < minX Then
								minX = line.x2
							End If
							If line.y1 < minY Then
								minY = line.y1
							End If
							If line.y2 < minY Then
								minY = line.y2
							End If
							If line.x1 > maxX Then
								maxX = line.x1
							End If
							If line.x2 > maxX Then
								maxX = line.x2
							End If
							If line.y1 > maxY Then
								maxY = line.y1
							End If
							If line.y2 > maxY Then
								maxY = line.y2
							End If
							
						Case "l"
							
						Case "H"
							
						Case "h"
							
						Case "V"
							
						Case "v"
							
						Case "C"
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							command_Renamed = Mid(command_Renamed, 2)
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							line.x1Curve = CDbl(Replace(Left(command_Renamed, InStr(command_Renamed, ",") - 1), ".", ","))
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							command_Renamed = Mid(command_Renamed, InStr(command_Renamed, ",") + 1)
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							line.y1Curve = CDbl(Replace(Left(command_Renamed, InStr(command_Renamed, " ") - 1), ".", ","))
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							command_Renamed = Mid(command_Renamed, InStr(command_Renamed, " ") + 1)
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							line.x2Curve = CDbl(Replace(Left(command_Renamed, InStr(command_Renamed, ",") - 1), ".", ","))
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							command_Renamed = Mid(command_Renamed, InStr(command_Renamed, ",") + 1)
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							line.y2Curve = CDbl(Replace(Left(command_Renamed, InStr(command_Renamed, " ") - 1), ".", ","))
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							command_Renamed = Mid(command_Renamed, InStr(command_Renamed, " ") + 1)
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							line.x2 = CDbl(Replace(Left(command_Renamed, InStr(command_Renamed, ",") - 1), ".", ","))
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							command_Renamed = Mid(command_Renamed, InStr(command_Renamed, ",") + 1)
							'UPGRADE_WARNING: Couldn't resolve default property of object command_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							line.y2 = -CDbl(Replace(command_Renamed, ".", ","))
							line.x1 = startX
							line.y1 = startY
							startX = line.x2
							startY = line.y2
							lineList.Add(line)
							line.drawing = True
							If line.x1 < minX Then
								minX = line.x1
							End If
							If line.x2 < minX Then
								minX = line.x2
							End If
							If line.y1 < minY Then
								minY = line.y1
							End If
							If line.y2 < minY Then
								minY = line.y2
							End If
							If line.x1 > maxX Then
								maxX = line.x1
							End If
							If line.x2 > maxX Then
								maxX = line.x2
							End If
							If line.y1 > maxY Then
								maxY = line.y1
							End If
							If line.y2 > maxY Then
								maxY = line.y2
							End If
							
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
				Next command_Renamed
		End Select
	End Sub
	
	
	'''''''''''''''''''''''''''''''''''''''''''''''''''
	'                                                 '
	' IVBSAXContentHandler unused abstract Methods    '
	'                                                 '
	'''''''''''''''''''''''''''''''''''''''''''''''''''
	
	Private Sub IVBSAXContentHandler_startDocument() Implements MSXML2.IVBSAXContentHandler.startDocument
	End Sub
	
	Private Sub IVBSAXContentHandler_startPrefixMapping(ByRef sPrefix As String, ByRef sURI As String) Implements MSXML2.IVBSAXContentHandler.startPrefixMapping
	End Sub
	
	Private Sub IVBSAXContentHandler_endPrefixMapping(ByRef sPrefix As String) Implements MSXML2.IVBSAXContentHandler.endPrefixMapping
	End Sub
	
	Private Sub IVBSAXContentHandler_ignorableWhitespace(ByRef sChars As String) Implements MSXML2.IVBSAXContentHandler.ignorableWhitespace
	End Sub
	
	Private Sub IVBSAXContentHandler_processingInstruction(ByRef sTarget As String, ByRef sData As String) Implements MSXML2.IVBSAXContentHandler.processingInstruction
	End Sub
	
	Private Sub IVBSAXContentHandler_skippedEntity(ByRef sName As String) Implements MSXML2.IVBSAXContentHandler.skippedEntity
	End Sub
	
	Private Sub IVBSAXContentHandler_endDocument() Implements MSXML2.IVBSAXContentHandler.endDocument
	End Sub
End Class