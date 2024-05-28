Attribute VB_Name = "Process"
Public Const Pi = 3.14159265358979

Public Function Generate_Code(lineList As Collection, cardListByName As Collection) As Integer
  Dim minX As Double
  Dim maxX As Double
  Dim minY As Double
  Dim maxY As Double

  Parse_svg lineList, minX, maxX, minY, maxY
  Line_Resize lineList, minX, maxX, minY, maxY
  CompactLine lineList
  Get_Closer_Line lineList
  Insert_Off_Lines lineList
  Line_Length_Angle lineList, cardListByName
  Generate_Code = Line_Trace_Commande(lineList, cardListByName)
End Function
  
Public Function Parse_svg(lineList As Collection, minX As Double, maxX As Double, minY As Double, maxY As Double)
  Dim saxParser As SAXXMLReader
  Dim xmlFile As SvgFileClass
  Dim nbComm As Integer
  
  file_structure_parse = ErrorOnXmlParsing
  Set saxParser = New SAXXMLReader
  Set xmlFile = New SvgFileClass
  Set saxParser.contentHandler = xmlFile
  saxParser.parseURL T3_Manager.imagePath.text
  file_structure_parse = lastErrorCode
  
  maxX = xmlFile.maxX
  maxY = xmlFile.maxY
  minX = xmlFile.minX
  minY = xmlFile.minY
  Set lineList = xmlFile.lineList
End Function

Public Function Line_Resize(lineList As Collection, minX As Double, maxX As Double, minY As Double, maxY As Double)
    Dim line As LineClass
    Dim Size As Double
    Dim newSize As Double
    newSize = CDbl(T3_Manager.Size.text)
    
    Size = maxX - minX
    If maxY - minY > Size Then
        Size = maxY - minY
    End If
    
    For Each line In lineList
        'calculate the length of the line
        line.x1 = line.x1 - minX
        line.x2 = line.x2 - minX
        line.y1 = line.y1 - minY
        line.y2 = line.y2 - minY
        
        line.x1 = newSize * line.x1 / Size
        line.x2 = newSize * line.x2 / Size
        line.y1 = newSize * line.y1 / Size
        line.y2 = newSize * line.y2 / Size
    Next
End Function

Public Function CompactLine(lineList As Collection)
    Dim line As LineClass
    
    For Each line In lineList
        If Round(Sqr((line.x2 - line.x1) ^ 2 + (line.y2 - line.y1) ^ 2)) = 0 Then: line.ignored = True
    Next
End Function

Public Function Get_Closer_Line(lineList As Collection)
    Dim i As Integer
    Dim lineNumber As Integer
    Dim mini As Long
    Dim xLast As Double
    Dim yLast As Double
    Dim temp As Double
    Dim newLineList As Collection
    Dim line As LineClass
    Dim newLine As LineClass
    
    xLast = 0
    yLast = 0
    Set newLineList = New Collection
    
    Do While lineList.Count <> newLineList.Count
        mini = 1000000
        i = 0
        lineNumber = 0
        For Each line In lineList
            i = i + 1
            If line.mapped = False Then
                If mini > Sqr((line.x1 - xLast) ^ 2 + (line.y1 - yLast) ^ 2) Then
                    mini = Sqr((line.x1 - xLast) ^ 2 + (line.y1 - yLast) ^ 2)
                    lineNumber = i
                End If
                If mini > Sqr((line.x2 - xLast) ^ 2 + (line.y2 - yLast) ^ 2) Then
                    mini = Sqr((line.x2 - xLast) ^ 2 + (line.y2 - yLast) ^ 2)
                    temp = line.x1
                    line.x1 = line.x2
                    line.x2 = temp
                    temp = line.y1
                    line.y1 = line.y2
                    line.y2 = temp
                    lineNumber = i
                End If
            End If
        Next
        If lineNumber <> 0 Then
            lineList.Item(lineNumber).mapped = True
            If lineList.Item(lineNumber).ignored = False Then
                xLast = lineList.Item(lineNumber).x2
                yLast = lineList.Item(lineNumber).y2
            End If
            Set newLine = New LineClass
            newLine.x1 = lineList.Item(lineNumber).x1
            newLine.y1 = lineList.Item(lineNumber).y1
            newLine.x2 = lineList.Item(lineNumber).x2
            newLine.y2 = lineList.Item(lineNumber).y2
            newLine.x1Curve = lineList.Item(lineNumber).x1Curve
            newLine.y1Curve = lineList.Item(lineNumber).y1Curve
            newLine.x2Curve = lineList.Item(lineNumber).x2Curve
            newLine.y2Curve = lineList.Item(lineNumber).y2Curve
            newLine.drawing = lineList.Item(lineNumber).drawing
            newLine.ignored = lineList.Item(lineNumber).ignored
            newLine.mapped = lineList.Item(lineNumber).mapped
            newLineList.Add newLine
        End If
    Loop
    Set lineList = newLineList
End Function

Public Function Insert_Off_Lines(lineList As Collection)
    Dim line As LineClass
    Dim newLineList As Collection
    Dim xLast As Double
    Dim yLast As Double
    Dim lineOff As LineClass
    
    Set newLineList = New Collection
    xLast = 0
    yLast = 0
    
    For Each line In lineList
        If line.ignored <> True Then
            If (xLast <> line.x1 Or yLast <> line.y1) And Round(Sqr((line.x1 - xLast) ^ 2 + (line.y1 - yLast) ^ 2)) <> 0 Then
              Set lineOff = New LineClass
              lineOff.x1 = xLast
              lineOff.y1 = yLast
              lineOff.x2 = line.x1
              lineOff.y2 = line.y1
              lineOff.drawing = False
              newLineList.Add lineOff
            End If
            newLineList.Add line
            xLast = line.x2
            yLast = line.y2
        End If
        
    Next
    Set lineList = newLineList
End Function

Public Function Line_Length_Angle(lineList As Collection, cardListByName As Collection)
    Dim a As Integer
    Dim i As Integer
    Dim mini As Long
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
    For Each line In lineList
        line.x1Real = xLast
        line.y1Real = yLast
        If line.ignored <> True Then
            'calculate the length of the line
            line.length = Sqr((line.x2 - line.x1Real) ^ 2 + (line.y2 - line.y1Real) ^ 2)
            
            'calculate the angle of the line
            cosTeta = (line.x2 - line.x1Real) / line.length
            sinTeta = (line.y2 - line.y1Real) / line.length
            If cosTeta <> 0 Then
                line.teta = 180 * Atn((line.y2 - line.y1Real) / (line.x2 - line.x1Real)) / Pi
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
        Do While Round(angle) <> 0
           Set card = New CardClass
           If Abs(mini) > Abs(angle - cardListByName.Item("TG_120").trueValue) Then
                Set card = cardListByName.Item("TG_120")
                mini = angle - cardListByName.Item("TG_120").trueValue
           End If
           If Abs(mini) > Abs(angle - cardListByName.Item("TD_120").trueValue) Then
                Set card = cardListByName.Item("TD_120")
                mini = angle - cardListByName.Item("TD_120").trueValue
           End If
           If Abs(mini) > Abs(angle - cardListByName.Item("TG_90").trueValue) Then
                Set card = cardListByName.Item("TG_90")
                mini = angle - cardListByName.Item("TG_90").trueValue
           End If
           If Abs(mini) > Abs(angle - cardListByName.Item("TD_90").trueValue) Then
                Set card = cardListByName.Item("TD_90")
                mini = angle - cardListByName.Item("TD_90").trueValue
           End If
           If Abs(mini) > Abs(angle - cardListByName.Item("TG_60").trueValue) Then
                Set card = cardListByName.Item("TG_60")
                mini = angle - cardListByName.Item("TG_60").trueValue
           End If
           If Abs(mini) > Abs(angle - cardListByName.Item("TD_60").trueValue) Then
                Set card = cardListByName.Item("TD_60")
                mini = angle - cardListByName.Item("TD_60").trueValue
           End If
            If Abs(mini) > Abs(angle - cardListByName.Item("TG_45").trueValue) Then
                Set card = cardListByName.Item("TG_45")
                mini = angle - cardListByName.Item("TG_45").trueValue
           End If
           If Abs(mini) > Abs(angle - cardListByName.Item("TD_45").trueValue) Then
                Set card = cardListByName.Item("TD_45")
                mini = angle - cardListByName.Item("TD_45").trueValue
           End If
           If Abs(mini) > Abs(angle - cardListByName.Item("TG_30").trueValue) Then
                Set card = cardListByName.Item("TG_30")
                mini = angle - cardListByName.Item("TG_30").trueValue
           End If
           If Abs(mini) > Abs(angle - cardListByName.Item("TD_30").trueValue) Then
                Set card = cardListByName.Item("TD_30")
                mini = angle - cardListByName.Item("TD_30").trueValue
           End If
           If Abs(mini) > Abs(angle - cardListByName.Item("TG_15").trueValue) Then
                Set card = cardListByName.Item("TG_15")
                mini = angle - cardListByName.Item("TG_15").trueValue
           End If
           If Abs(mini) > Abs(angle - cardListByName.Item("TD_15").trueValue) Then
                Set card = cardListByName.Item("TD_15")
                mini = angle - cardListByName.Item("TD_15").trueValue
           End If
           If Abs(mini) > Abs(angle - cardListByName.Item("TG_1").trueValue) Then
                Set card = cardListByName.Item("TG_1")
                mini = angle - cardListByName.Item("TG_1").trueValue
           End If
           If Abs(mini) > Abs(angle - cardListByName.Item("TD_1").trueValue) Then
                Set card = cardListByName.Item("TD_1")
                mini = angle - cardListByName.Item("TD_1").trueValue
           End If
           angle = angle - card.trueValue
           If card.trueValue <> 0 Then: line.move_Card_List.Add card
        Loop
        
        'straight command
        mini = 1000000
        length = line.length
        Do While Round(length) <> 0
            Set card = New CardClass
            delta = length - cardListByName.Item("AV_20").trueValue
            If Abs(mini) > Abs(delta) And Not (length > 0 And Round(delta < 0) And line.drawing = True) Then
                 Set card = cardListByName.Item("AV_20")
                 mini = delta
            End If
            delta = length - cardListByName.Item("RE_20").trueValue
            If Abs(mini) > Abs(delta) And Not (length < 0 And Round(delta) > 0 And line.drawing = True) Then
                 Set card = cardListByName.Item("RE_20")
                 mini = delta
            End If
            delta = length - cardListByName.Item("AV_10").trueValue
            If Abs(mini) > Abs(delta) And Not (length > 0 And Round(delta) < 0 And line.drawing = True) Then
                 Set card = cardListByName.Item("AV_10")
                 mini = delta
            End If
            delta = length - cardListByName.Item("RE_10").trueValue
            If Abs(mini) > Abs(delta) And Not (length < 0 And Round(delta) > 0 And line.drawing = True) Then
                 Set card = cardListByName.Item("RE_10")
                 mini = delta
            End If
            delta = length - cardListByName.Item("AV_1").trueValue
            If Abs(mini) > Abs(delta) And Not (length > 0 And Round(delta) < 0 And line.drawing = True) Then
                 Set card = cardListByName.Item("AV_1")
                 mini = delta
            End If
            delta = length - cardListByName.Item("RE_1").trueValue
            If Abs(mini) > Abs(delta) And Not (length < 0 And Round(delta) > 0 And line.drawing = True) Then
                 Set card = cardListByName.Item("RE_1")
                 mini = delta
            End If
            length = length - card.trueValue
            If card.trueValue <> 0 Then line.move_Card_List.Add card
          Loop
        
        line.lengthReal = line.length - length
        line.transfertAngleReal = line.transfertAngle - angle
        xLast = xLast + line.lengthReal * Cos(Pi * (previousTeta + line.transfertAngleReal) / 180)
        yLast = yLast + line.lengthReal * Sin(Pi * (previousTeta + line.transfertAngleReal) / 180)
        line.x2Real = xLast
        line.y2Real = yLast
        
        previousTeta = previousTeta + line.transfertAngleReal
        If previousTeta > 180 Then
            previousTeta = previousTeta - 360
        End If
        If previousTeta < -180 Then
            previousTeta = previousTeta + 360
        End If
    Next
End Function

Public Function Line_Trace_Commande(lineList As Collection, cardListByName As Collection) As Integer
    Dim line As LineClass
    Dim card As CardClass
    Dim nbCommand As Integer
    Dim totalLength As Double
    Dim totalRotation As Double
    Dim penDown As Boolean
    
    penDown = False
    nbCommand = 0
    T3_Manager.TextCommandList.text = "List of card to insert to trace:" & vbCrLf & """" & T3_Manager.imagePath.text & """" & vbCrLf & "_____________________________" & vbCrLf & vbCrLf
    For Each line In lineList
        If line.ignored <> True Then
            If Round(line.transfertAngle) > 0 Then
                If penDown = True Then
                    T3_Manager.TextCommandList.text = T3_Manager.TextCommandList.text & "Turning left of " & Round(Abs(line.transfertAngleReal), 2) & ", pen down:" & vbCrLf
                Else
                    T3_Manager.TextCommandList.text = T3_Manager.TextCommandList.text & "Turning left of " & Round(Abs(line.transfertAngleReal), 2) & ", pen up:" & vbCrLf
                End If
            End If
            If Round(line.transfertAngle) < 0 Then
                If penDown = True Then
                    T3_Manager.TextCommandList.text = T3_Manager.TextCommandList.text & "Turning right of " & Round(Abs(line.transfertAngleReal), 2) & ", pen down:" & vbCrLf
                Else
                    T3_Manager.TextCommandList.text = T3_Manager.TextCommandList.text & "Turning right of " & Round(Abs(line.transfertAngleReal), 2) & ", pen up:" & vbCrLf
                End If
            End If
            For Each card In line.move_Card_List
                'rotate command
                If card.isRotation = True Then
                    totalRotation = totalRotation + Abs(card.trueValue)
                    line.command_card_list.Add card
                    nbCommand = nbCommand + 1
                    T3_Manager.TextCommandList.text = T3_Manager.TextCommandList.text & card.name & " (" & Round(card.trueValue, 2) & ")" & vbCrLf
                End If
            Next
            If Round(line.length) <> 0 Then
                'put pen down
                If line.drawing = True And penDown = False Then
                    line.command_card_list.Add cardListByName.Item("B_C")
                    nbCommand = nbCommand + 1
                    T3_Manager.TextCommandList.text = T3_Manager.TextCommandList.text & cardListByName.Item("B_C").name & vbCrLf
                    penDown = True
                End If
                'put pen up
                If line.drawing = False And penDown = True Then
                    line.command_card_list.Add cardListByName.Item("L_C")
                    nbCommand = nbCommand + 1
                    T3_Manager.TextCommandList.text = T3_Manager.TextCommandList.text & cardListByName.Item("L_C").name & vbCrLf
                    penDown = False
                End If
            End If
            If Round(line.length) > 0 Then
                If penDown = True Then
                    T3_Manager.TextCommandList.text = T3_Manager.TextCommandList.text & "Advance of " & Round(Abs(line.lengthReal), 2) & ", pen down:" & vbCrLf
                Else
                    T3_Manager.TextCommandList.text = T3_Manager.TextCommandList.text & "Advance of " & Round(Abs(line.lengthReal), 2) & ", pen up:" & vbCrLf
                End If
            End If
            If Round(line.length) < 0 Then
                If penDown Then
                    T3_Manager.TextCommandList.text = T3_Manager.TextCommandList.text & "Move back of " & Round(Abs(line.lengthReal), 2) & ", pen down:" & vbCrLf
                Else
                    T3_Manager.TextCommandList.text = T3_Manager.TextCommandList.text & "Move back of " & Round(Abs(line.lengthReal), 2) & ", pen up:" & vbCrLf
                End If
            End If
                
            For Each card In line.move_Card_List
                'rotate command
                If card.isTranslation = True Then
                    totalLength = totalLength + Abs(card.trueValue)
                    line.command_card_list.Add card
                    nbCommand = nbCommand + 1
                    T3_Manager.TextCommandList.text = T3_Manager.TextCommandList.text & card.name & " (" & Round(card.trueValue, 2) & ")" & vbCrLf
                End If
            Next
        End If
    Next
    'put pen up
    T3_Manager.TextCommandList.text = T3_Manager.TextCommandList.text & vbCrLf & "_____________________________" & vbCrLf & nbCommand & " commands" & vbCrLf & Round(totalLength, 2) & " cm of translation" & vbCrLf & Round(totalRotation, 2) & " ° of rotation" & vbCrLf
    Line_Trace_Commande = nbCommand
End Function

