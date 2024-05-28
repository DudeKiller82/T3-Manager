Attribute VB_Name = "Print"
Public Function printAll(lineList As Collection)
    Dim line As LineClass
    Dim width As Integer
    Dim offset As Integer
    
    width = CInt(T3_Manager.Size.text)
    offset = 2 * width / 100
    
    Preview.PreviewZone.ScaleHeight = width + 2 * offset
    Preview.PreviewZone.ScaleWidth = width + 2 * offset
    Preview.PreviewZone.Cls

    Preview.PreviewZone.Line (0 + offset, width - 0 + offset)-(0 + offset, width - width + offset), vbBlue
    Preview.PreviewZone.Line (0 + offset, width - width + offset)-(width + offset, width - width + offset), vbBlue
    Preview.PreviewZone.Line (width + offset, width - width + offset)-(width + offset, width - 0 + offset), vbBlue
    Preview.PreviewZone.Line (width + offset, width - 0 + offset)-(0 + offset, width - 0 + offset), vbBlue
    For Each line In lineList
        If line.drawing = True And Preview.CheckImage.value = 1 Then: Preview.PreviewZone.Line (line.x1 + offset, width - line.y1 + offset)-(line.x2 + offset, width - line.y2 + offset), vbBlack
        If line.ignored <> True Then
            If line.drawing = True Then
                If Preview.CheckReal.value = 1 Then: Preview.PreviewZone.Line (line.x1Real + offset, width - line.y1Real + offset)-(line.x2Real + offset, width - line.y2Real + offset), vbRed
            Else
                If Preview.CheckInterLine.value = 1 Then: Preview.PreviewZone.Line (line.x1Real + offset, width - line.y1Real + offset)-(line.x2Real + offset, width - line.y2Real + offset), vbGreen
            End If
        End If
    Next
End Function



