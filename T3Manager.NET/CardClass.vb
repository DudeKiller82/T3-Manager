Option Strict Off
Option Explicit On
Friend Class CardClass
	Public name As String
	Public code As Short
	Public revert As String
	Public text As String
	Public runningTime As Integer
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
	
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Initialize_Renamed()
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
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
End Class