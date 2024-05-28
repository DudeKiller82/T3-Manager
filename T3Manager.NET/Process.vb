Option Strict Off
Option Explicit On
Module Process
	Public Const Pi As Double = 3.14159265358979
	
	Public Function Generate_Code(ByRef lineList As Collection, ByRef cardListByName As Collection) As Short
		Dim minX As Double
		Dim maxX As Double
		Dim minY As Double
		Dim maxY As Double
		
		Parse_svg(lineList, minX, maxX, minY, maxY)
		Line_Resize(lineList, minX, maxX, minY, maxY)
		CompactLine(lineList)
		Get_Closer_Line(lineList)
		Insert_Off_Lines(lineList)
		Line_Length_Angle(lineList, cardListByName)
		Generate_Code = Line_Trace_Commande(lineList, cardListByName)
	End Function
	
	Public Function Parse_svg(ByRef lineList As Collection, ByRef minX As Double, ByRef maxX As Double, ByRef minY As Double, ByRef maxY As Double) As Object
		Dim lastErrorCode As Object
		Dim file_structure_parse As Object
		Dim ErrorOnXmlParsing As Object
		Dim saxParser As MSXML2.SAXXMLReader
		Dim xmlFile As SvgFileClass
		Dim nbComm As Short
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ErrorOnXmlParsing. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object file_structure_parse. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		file_structure_parse = ErrorOnXmlParsing
		saxParser = New MSXML2.SAXXMLReader
		xmlFile = New SvgFileClass
		saxParser.contentHandler = xmlFile
		saxParser.parseURL(T3_Manager.imagePath.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object lastErrorCode. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object file_structure_parse. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		file_structure_parse = lastErrorCode
		
		maxX = xmlFile.maxX
		maxY = xmlFile.maxY
		minX = xmlFile.minX
		minY = xmlFile.minY
		lineList = xmlFile.lineList
	End Function
	
	Public Function Line_Resize(ByRef lineList As Collection, ByRef minX As Double, ByRef maxX As Double, ByRef minY As Double, ByRef maxY As Double) As Object
		Dim line As LineClass
		Dim Size As Double
		Dim newSize As Double
		newSize = CDbl(T3_Manager.Size_Renamed.Text)
		
		Size = maxX - minX
		If maxY - minY > Size Then
			Size = maxY - minY
		End If
		
		For	Each line In lineList
			'calculate the length of the line
			line.x1 = line.x1 - minX
			line.x2 = line.x2 - minX
			line.y1 = line.y1 - minY
			line.y2 = line.y2 - minY
			
			line.x1 = newSize * line.x1 / Size
			line.x2 = newSize * line.x2 / Size
			line.y1 = newSize * line.y1 / Size
			line.y2 = newSize * line.y2 / Size
		Next line
	End Function
	
	Public Function CompactLine(ByRef lineList As Collection) As Object
		Dim line As LineClass
		
		For	Each line In lineList
			If System.Math.Round(System.Math.Sqrt((line.x2 - line.x1) ^ 2 + (line.y2 - line.y1) ^ 2)) = 0 Then
				line.ignored = True
			End If
		Next line
	End Function
	
	Public Function Get_Closer_Line(ByRef lineList As Collection) As Object
		Dim i As Short
		Dim lineNumber As Short
		Dim mini As Integer
		Dim xLast As Double
		Dim yLast As Double
		Dim temp As Double
		Dim newLineList As Collection
		Dim line As LineClass
		Dim newLine As LineClass
		
		xLast = 0
		yLast = 0
		newLineList = New Collection
		
		Do While lineList.Count() <> newLineList.Count()
			mini = 1000000
			i = 0
			lineNumber = 0
			For	Each line In lineList
				i = i + 1
				If line.mapped = False Then
					If mini > System.Math.Sqrt((line.x1 - xLast) ^ 2 + (line.y1 - yLast) ^ 2) Then
						mini = System.Math.Sqrt((line.x1 - xLast) ^ 2 + (line.y1 - yLast) ^ 2)
						lineNumber = i
					End If
					If mini > System.Math.Sqrt((line.x2 - xLast) ^ 2 + (line.y2 - yLast) ^ 2) Then
						mini = System.Math.Sqrt((line.x2 - xLast) ^ 2 + (line.y2 - yLast) ^ 2)
						temp = line.x1
						line.x1 = line.x2
						line.x2 = temp
						temp = line.y1
						line.y1 = line.y2
						line.y2 = temp
						lineNumber = i
					End If
				End If
			Next line
			If lineNumber <> 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object lineList.Item().mapped. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lineList.Item(lineNumber).mapped = True
				'UPGRADE_WARNING: Couldn't resolve default property of object lineList.Item(lineNumber).ignored. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If lineList.Item(lineNumber).ignored = False Then
					'UPGRADE_WARNING: Couldn't resolve default property of object lineList.Item().x2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					xLast = lineList.Item(lineNumber).x2
					'UPGRADE_WARNING: Couldn't resolve default property of object lineList.Item().y2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					yLast = lineList.Item(lineNumber).y2
				End If
				newLine = New LineClass
				'UPGRADE_WARNING: Couldn't resolve default property of object lineList.Item().x1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				newLine.x1 = lineList.Item(lineNumber).x1
				'UPGRADE_WARNING: Couldn't resolve default property of object lineList.Item().y1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				newLine.y1 = lineList.Item(lineNumber).y1
				'UPGRADE_WARNING: Couldn't resolve default property of object lineList.Item().x2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				newLine.x2 = lineList.Item(lineNumber).x2
				'UPGRADE_WARNING: Couldn't resolve default property of object lineList.Item().y2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				newLine.y2 = lineList.Item(lineNumber).y2
				'UPGRADE_WARNING: Couldn't resolve default property of object lineList.Item().x1Curve. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				newLine.x1Curve = lineList.Item(lineNumber).x1Curve
				'UPGRADE_WARNING: Couldn't resolve default property of object lineList.Item().y1Curve. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				newLine.y1Curve = lineList.Item(lineNumber).y1Curve
				'UPGRADE_WARNING: Couldn't resolve default property of object lineList.Item().x2Curve. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				newLine.x2Curve = lineList.Item(lineNumber).x2Curve
				'UPGRADE_WARNING: Couldn't resolve default property of object lineList.Item().y2Curve. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				newLine.y2Curve = lineList.Item(lineNumber).y2Curve
				'UPGRADE_WARNING: Couldn't resolve default property of object lineList.Item().drawing. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				newLine.drawing = lineList.Item(lineNumber).drawing
				'UPGRADE_WARNING: Couldn't resolve default property of object lineList.Item().ignored. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				newLine.ignored = lineList.Item(lineNumber).ignored
				'UPGRADE_WARNING: Couldn't resolve default property of object lineList.Item().mapped. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				newLine.mapped = lineList.Item(lineNumber).mapped
				newLineList.Add(newLine)
			End If
		Loop 
		lineList = newLineList
	End Function
	
	Public Function Insert_Off_Lines(ByRef lineList As Collection) As Object
		Dim line As LineClass
		Dim newLineList As Collection
		Dim xLast As Double
		Dim yLast As Double
		Dim lineOff As LineClass
		
		newLineList = New Collection
		xLast = 0
		yLast = 0
		
		For	Each line In lineList
			If line.ignored <> True Then
				If (xLast <> line.x1 Or yLast <> line.y1) And System.Math.Round(System.Math.Sqrt((line.x1 - xLast) ^ 2 + (line.y1 - yLast) ^ 2)) <> 0 Then
					lineOff = New LineClass
					lineOff.x1 = xLast
					lineOff.y1 = yLast
					lineOff.x2 = line.x1
					lineOff.y2 = line.y1
					lineOff.drawing = False
					newLineList.Add(lineOff)
				End If
				newLineList.Add(line)
				xLast = line.x2
				yLast = line.y2
			End If
			
		Next line
		lineList = newLineList
	End Function
	
	Public Function Line_Length_Angle(ByRef lineList As Collection, ByRef cardListByName As Collection) As Object
		Dim a As Short
		Dim i As Short
		Dim mini As Integer
		Dim xLast As Double
		Dim yLast As Double
		Dim angle As Double
		Dim length As Double
		Dim cosTeta As Double
		Dim sinTeta As Double
		Dim previousTeta As Double
		Dim delta As Double
		Dim line As LineClass
		Dim card As CardClass
		
		xLast = 0
		yLast = 0
		previousTeta = 0
		For	Each line In lineList
			line.x1Real = xLast
			line.y1Real = yLast
			If line.ignored <> True Then
				'calculate the length of the line
				line.length = System.Math.Sqrt((line.x2 - line.x1Real) ^ 2 + (line.y2 - line.y1Real) ^ 2)
				
				'calculate the angle of the line
				cosTeta = (line.x2 - line.x1Real) / line.length
				sinTeta = (line.y2 - line.y1Real) / line.length
				If cosTeta <> 0 Then
					line.teta = 180 * System.Math.Atan((line.y2 - line.y1Real) / (line.x2 - line.x1Real)) / Pi
					If cosTeta < 0 Then
						If line.teta >= 0 Then
							line.teta = line.teta - 180
						Else
							line.teta = line.teta + 180
						End If
					End If
				Else
					If sinTeta > 0 Then
						line.teta = 90
					Else
						line.teta = -90
					End If
				End If
				'calculate the transfert angle of the line
				line.transfertAngle = line.teta - previousTeta
				If line.transfertAngle > 180 Then
					line.transfertAngle = line.transfertAngle - 360
				End If
				If line.transfertAngle < -180 Then
					line.transfertAngle = line.transfertAngle + 360
				End If
				
				If line.transfertAngle > 90 Then
					line.transfertAngle = -180 + line.transfertAngle
					line.length = -line.length
				End If
				If line.transfertAngle < -90 Then
					line.transfertAngle = 180 + line.transfertAngle
					line.length = -line.length
				End If
			End If
			
			'rotate command
			mini = 1000000
			angle = line.transfertAngle
			Do While System.Math.Round(angle) <> 0
				card = New CardClass
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If System.Math.Abs(mini) > System.Math.Abs(angle - cardListByName.Item("TG_120").trueValue) Then
					card = cardListByName.Item("TG_120")
					'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					mini = angle - cardListByName.Item("TG_120").trueValue
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If System.Math.Abs(mini) > System.Math.Abs(angle - cardListByName.Item("TD_120").trueValue) Then
					card = cardListByName.Item("TD_120")
					'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					mini = angle - cardListByName.Item("TD_120").trueValue
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If System.Math.Abs(mini) > System.Math.Abs(angle - cardListByName.Item("TG_90").trueValue) Then
					card = cardListByName.Item("TG_90")
					'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					mini = angle - cardListByName.Item("TG_90").trueValue
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If System.Math.Abs(mini) > System.Math.Abs(angle - cardListByName.Item("TD_90").trueValue) Then
					card = cardListByName.Item("TD_90")
					'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					mini = angle - cardListByName.Item("TD_90").trueValue
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If System.Math.Abs(mini) > System.Math.Abs(angle - cardListByName.Item("TG_60").trueValue) Then
					card = cardListByName.Item("TG_60")
					'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					mini = angle - cardListByName.Item("TG_60").trueValue
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If System.Math.Abs(mini) > System.Math.Abs(angle - cardListByName.Item("TD_60").trueValue) Then
					card = cardListByName.Item("TD_60")
					'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					mini = angle - cardListByName.Item("TD_60").trueValue
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If System.Math.Abs(mini) > System.Math.Abs(angle - cardListByName.Item("TG_45").trueValue) Then
					card = cardListByName.Item("TG_45")
					'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					mini = angle - cardListByName.Item("TG_45").trueValue
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If System.Math.Abs(mini) > System.Math.Abs(angle - cardListByName.Item("TD_45").trueValue) Then
					card = cardListByName.Item("TD_45")
					'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					mini = angle - cardListByName.Item("TD_45").trueValue
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If System.Math.Abs(mini) > System.Math.Abs(angle - cardListByName.Item("TG_30").trueValue) Then
					card = cardListByName.Item("TG_30")
					'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					mini = angle - cardListByName.Item("TG_30").trueValue
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If System.Math.Abs(mini) > System.Math.Abs(angle - cardListByName.Item("TD_30").trueValue) Then
					card = cardListByName.Item("TD_30")
					'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					mini = angle - cardListByName.Item("TD_30").trueValue
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If System.Math.Abs(mini) > System.Math.Abs(angle - cardListByName.Item("TG_15").trueValue) Then
					card = cardListByName.Item("TG_15")
					'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					mini = angle - cardListByName.Item("TG_15").trueValue
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If System.Math.Abs(mini) > System.Math.Abs(angle - cardListByName.Item("TD_15").trueValue) Then
					card = cardListByName.Item("TD_15")
					'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					mini = angle - cardListByName.Item("TD_15").trueValue
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If System.Math.Abs(mini) > System.Math.Abs(angle - cardListByName.Item("TG_1").trueValue) Then
					card = cardListByName.Item("TG_1")
					'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					mini = angle - cardListByName.Item("TG_1").trueValue
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If System.Math.Abs(mini) > System.Math.Abs(angle - cardListByName.Item("TD_1").trueValue) Then
					card = cardListByName.Item("TD_1")
					'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					mini = angle - cardListByName.Item("TD_1").trueValue
				End If
				angle = angle - card.trueValue
				If card.trueValue <> 0 Then
					line.move_Card_List.Add(card)
				End If
			Loop 
			
			'straight command
			mini = 1000000
			length = line.length
			Do While System.Math.Round(length) <> 0
				card = New CardClass
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				delta = length - cardListByName.Item("AV_20").trueValue
				If System.Math.Abs(mini) > System.Math.Abs(delta) And Not (length > 0 And System.Math.Round(delta < 0) And line.drawing = True) Then
					card = cardListByName.Item("AV_20")
					mini = delta
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				delta = length - cardListByName.Item("RE_20").trueValue
				If System.Math.Abs(mini) > System.Math.Abs(delta) And Not (length < 0 And System.Math.Round(delta) > 0 And line.drawing = True) Then
					card = cardListByName.Item("RE_20")
					mini = delta
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				delta = length - cardListByName.Item("AV_10").trueValue
				If System.Math.Abs(mini) > System.Math.Abs(delta) And Not (length > 0 And System.Math.Round(delta) < 0 And line.drawing = True) Then
					card = cardListByName.Item("AV_10")
					mini = delta
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				delta = length - cardListByName.Item("RE_10").trueValue
				If System.Math.Abs(mini) > System.Math.Abs(delta) And Not (length < 0 And System.Math.Round(delta) > 0 And line.drawing = True) Then
					card = cardListByName.Item("RE_10")
					mini = delta
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				delta = length - cardListByName.Item("AV_1").trueValue
				If System.Math.Abs(mini) > System.Math.Abs(delta) And Not (length > 0 And System.Math.Round(delta) < 0 And line.drawing = True) Then
					card = cardListByName.Item("AV_1")
					mini = delta
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().trueValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				delta = length - cardListByName.Item("RE_1").trueValue
				If System.Math.Abs(mini) > System.Math.Abs(delta) And Not (length < 0 And System.Math.Round(delta) > 0 And line.drawing = True) Then
					card = cardListByName.Item("RE_1")
					mini = delta
				End If
				length = length - card.trueValue
				If card.trueValue <> 0 Then line.move_Card_List.Add(card)
			Loop 
			
			line.lengthReal = line.length - length
			line.transfertAngleReal = line.transfertAngle - angle
			xLast = xLast + line.lengthReal * System.Math.Cos(Pi * (previousTeta + line.transfertAngleReal) / 180)
			yLast = yLast + line.lengthReal * System.Math.Sin(Pi * (previousTeta + line.transfertAngleReal) / 180)
			line.x2Real = xLast
			line.y2Real = yLast
			
			previousTeta = previousTeta + line.transfertAngleReal
			If previousTeta > 180 Then
				previousTeta = previousTeta - 360
			End If
			If previousTeta < -180 Then
				previousTeta = previousTeta + 360
			End If
		Next line
	End Function
	
	Public Function Line_Trace_Commande(ByRef lineList As Collection, ByRef cardListByName As Collection) As Short
		Dim line As LineClass
		Dim card As CardClass
		Dim nbCommand As Short
		Dim totalLength As Double
		Dim totalRotation As Double
		Dim penDown As Boolean
		
		penDown = False
		nbCommand = 0
		T3_Manager.TextCommandList.Text = "List of card to insert to trace:" & vbCrLf & """" & T3_Manager.imagePath.Text & """" & vbCrLf & "_____________________________" & vbCrLf & vbCrLf
		For	Each line In lineList
			If line.ignored <> True Then
				If System.Math.Round(line.transfertAngle) > 0 Then
					If penDown = True Then
						T3_Manager.TextCommandList.Text = T3_Manager.TextCommandList.Text & "Turning left of " & System.Math.Round(System.Math.Abs(line.transfertAngleReal), 2) & ", pen down:" & vbCrLf
					Else
						T3_Manager.TextCommandList.Text = T3_Manager.TextCommandList.Text & "Turning left of " & System.Math.Round(System.Math.Abs(line.transfertAngleReal), 2) & ", pen up:" & vbCrLf
					End If
				End If
				If System.Math.Round(line.transfertAngle) < 0 Then
					If penDown = True Then
						T3_Manager.TextCommandList.Text = T3_Manager.TextCommandList.Text & "Turning right of " & System.Math.Round(System.Math.Abs(line.transfertAngleReal), 2) & ", pen down:" & vbCrLf
					Else
						T3_Manager.TextCommandList.Text = T3_Manager.TextCommandList.Text & "Turning right of " & System.Math.Round(System.Math.Abs(line.transfertAngleReal), 2) & ", pen up:" & vbCrLf
					End If
				End If
				For	Each card In line.move_Card_List
					'rotate command
					If card.isRotation = True Then
						totalRotation = totalRotation + System.Math.Abs(card.trueValue)
						line.command_card_list.Add(card)
						nbCommand = nbCommand + 1
						T3_Manager.TextCommandList.Text = T3_Manager.TextCommandList.Text & card.name & " (" & System.Math.Round(card.trueValue, 2) & ")" & vbCrLf
					End If
				Next card
				If System.Math.Round(line.length) <> 0 Then
					'put pen down
					If line.drawing = True And penDown = False Then
						line.command_card_list.Add(cardListByName.Item("B_C"))
						nbCommand = nbCommand + 1
						'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						T3_Manager.TextCommandList.Text = T3_Manager.TextCommandList.Text & cardListByName.Item("B_C").name & vbCrLf
						penDown = True
					End If
					'put pen up
					If line.drawing = False And penDown = True Then
						line.command_card_list.Add(cardListByName.Item("L_C"))
						nbCommand = nbCommand + 1
						'UPGRADE_WARNING: Couldn't resolve default property of object cardListByName.Item().name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						T3_Manager.TextCommandList.Text = T3_Manager.TextCommandList.Text & cardListByName.Item("L_C").name & vbCrLf
						penDown = False
					End If
				End If
				If System.Math.Round(line.length) > 0 Then
					If penDown = True Then
						T3_Manager.TextCommandList.Text = T3_Manager.TextCommandList.Text & "Advance of " & System.Math.Round(System.Math.Abs(line.lengthReal), 2) & ", pen down:" & vbCrLf
					Else
						T3_Manager.TextCommandList.Text = T3_Manager.TextCommandList.Text & "Advance of " & System.Math.Round(System.Math.Abs(line.lengthReal), 2) & ", pen up:" & vbCrLf
					End If
				End If
				If System.Math.Round(line.length) < 0 Then
					If penDown Then
						T3_Manager.TextCommandList.Text = T3_Manager.TextCommandList.Text & "Move back of " & System.Math.Round(System.Math.Abs(line.lengthReal), 2) & ", pen down:" & vbCrLf
					Else
						T3_Manager.TextCommandList.Text = T3_Manager.TextCommandList.Text & "Move back of " & System.Math.Round(System.Math.Abs(line.lengthReal), 2) & ", pen up:" & vbCrLf
					End If
				End If
				
				For	Each card In line.move_Card_List
					'rotate command
					If card.isTranslation = True Then
						totalLength = totalLength + System.Math.Abs(card.trueValue)
						line.command_card_list.Add(card)
						nbCommand = nbCommand + 1
						T3_Manager.TextCommandList.Text = T3_Manager.TextCommandList.Text & card.name & " (" & System.Math.Round(card.trueValue, 2) & ")" & vbCrLf
					End If
				Next card
			End If
		Next line
		'put pen up
		T3_Manager.TextCommandList.Text = T3_Manager.TextCommandList.Text & vbCrLf & "_____________________________" & vbCrLf & nbCommand & " commands" & vbCrLf & System.Math.Round(totalLength, 2) & " cm of translation" & vbCrLf & System.Math.Round(totalRotation, 2) & " � of rotation" & vbCrLf
		Line_Trace_Commande = nbCommand
	End Function
End Module