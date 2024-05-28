Option Strict Off
Option Explicit On
Friend Class Preview
	Inherits System.Windows.Forms.Form
	'UPGRADE_WARNING: Event CheckImage.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub CheckImage_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CheckImage.CheckStateChanged
		printAll((T3_Manager.lineList))
	End Sub
	
	'UPGRADE_WARNING: Event CheckInterLine.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub CheckInterLine_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CheckInterLine.CheckStateChanged
		printAll((T3_Manager.lineList))
	End Sub
	
	'UPGRADE_WARNING: Event CheckReal.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub CheckReal_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CheckReal.CheckStateChanged
		printAll((T3_Manager.lineList))
	End Sub
	
	Private Sub Preview_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Click
		printAll((T3_Manager.lineList))
	End Sub
	
	Private Sub PreviewZone_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PreviewZone.Click
		printAll((T3_Manager.lineList))
	End Sub
End Class