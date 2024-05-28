Option Strict Off
Option Explicit On
'UPGRADE_NOTE: Print was upgraded to Print_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
Module Print_Renamed
	Public Function printAll(ByRef lineList As Collection) As Object
		Dim line As LineClass
		Dim width As Short
		Dim offset As Short
		
		width = CShort(T3_Manager.Size_Renamed.Text)
		offset = 2 * width / 100
		
		'UPGRADE_ISSUE: PictureBox property PreviewZone.ScaleHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Preview.PreviewZone.ScaleHeight = width + 2 * offset
		'UPGRADE_ISSUE: PictureBox property PreviewZone.ScaleWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Preview.PreviewZone.ScaleWidth = width + 2 * offset
		'UPGRADE_ISSUE: PictureBox method PreviewZone.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Preview.PreviewZone.Cls()
		
		'UPGRADE_ISSUE: PictureBox method PreviewZone.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Preview.PreviewZone.Line (0 + offset, width - 0 + offset) - (0 + offset, width - width + offset), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
		'UPGRADE_ISSUE: PictureBox method PreviewZone.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Preview.PreviewZone.Line (0 + offset, width - width + offset) - (width + offset, width - width + offset), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
		'UPGRADE_ISSUE: PictureBox method PreviewZone.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Preview.PreviewZone.Line (width + offset, width - width + offset) - (width + offset, width - 0 + offset), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
		'UPGRADE_ISSUE: PictureBox method PreviewZone.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Preview.PreviewZone.Line (width + offset, width - 0 + offset) - (0 + offset, width - 0 + offset), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
		For	Each line In lineList
			'UPGRADE_ISSUE: PictureBox method PreviewZone.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			If line.drawing = True And Preview.CheckImage.CheckState = 1 Then Preview.PreviewZone.Line (line.x1 + offset, width - line.y1 + offset) - (line.x2 + offset, width - line.y2 + offset), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
			If line.ignored <> True Then
				If line.drawing = True Then
					'UPGRADE_ISSUE: PictureBox method PreviewZone.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If Preview.CheckReal.CheckState = 1 Then Preview.PreviewZone.Line (line.x1Real + offset, width - line.y1Real + offset) - (line.x2Real + offset, width - line.y2Real + offset), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
				Else
					'UPGRADE_ISSUE: PictureBox method PreviewZone.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					If Preview.CheckInterLine.CheckState = 1 Then Preview.PreviewZone.Line (line.x1Real + offset, width - line.y1Real + offset) - (line.x2Real + offset, width - line.y2Real + offset), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Lime)
				End If
			End If
		Next line
	End Function
End Module