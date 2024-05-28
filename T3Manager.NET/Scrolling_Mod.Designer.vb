<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Scrolling_Mod
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Scrolling_Pause As System.Windows.Forms.CheckBox
	Public WithEvents Scrolling_Configuraton_Button As System.Windows.Forms.Button
	Public WithEvents Scroll_Timer As System.Windows.Forms.Timer
	Public WithEvents confirm_timer As System.Windows.Forms.Timer
	Public WithEvents cardPicture As System.Windows.Forms.Panel
	Public WithEvents CardText As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Scrolling_Mod))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Scrolling_Pause = New System.Windows.Forms.CheckBox
		Me.Scrolling_Configuraton_Button = New System.Windows.Forms.Button
		Me.Scroll_Timer = New System.Windows.Forms.Timer(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cardPicture = New System.Windows.Forms.Panel
		Me.confirm_timer = New System.Windows.Forms.Timer(components)
		Me.CardText = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.cardPicture.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Mode défilement"
		Me.ClientSize = New System.Drawing.Size(766, 616)
		Me.Location = New System.Drawing.Point(3, 29)
		Me.Icon = CType(resources.GetObject("Scrolling_Mod.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Visible = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "Scrolling_Mod"
		Me.Scrolling_Pause.Text = "Pause"
		Me.Scrolling_Pause.Size = New System.Drawing.Size(57, 17)
		Me.Scrolling_Pause.Location = New System.Drawing.Point(560, 592)
		Me.Scrolling_Pause.TabIndex = 4
		Me.Scrolling_Pause.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Scrolling_Pause.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Scrolling_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.Scrolling_Pause.BackColor = System.Drawing.SystemColors.Control
		Me.Scrolling_Pause.CausesValidation = True
		Me.Scrolling_Pause.Enabled = True
		Me.Scrolling_Pause.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Scrolling_Pause.Cursor = System.Windows.Forms.Cursors.Default
		Me.Scrolling_Pause.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Scrolling_Pause.Appearance = System.Windows.Forms.Appearance.Normal
		Me.Scrolling_Pause.TabStop = True
		Me.Scrolling_Pause.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.Scrolling_Pause.Visible = True
		Me.Scrolling_Pause.Name = "Scrolling_Pause"
		Me.Scrolling_Configuraton_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Scrolling_Configuraton_Button.Text = "Configuration"
		Me.Scrolling_Configuraton_Button.Size = New System.Drawing.Size(137, 17)
		Me.Scrolling_Configuraton_Button.Location = New System.Drawing.Point(624, 592)
		Me.Scrolling_Configuraton_Button.TabIndex = 2
		Me.ToolTip1.SetToolTip(Me.Scrolling_Configuraton_Button, "Select a SVG image")
		Me.Scrolling_Configuraton_Button.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Scrolling_Configuraton_Button.BackColor = System.Drawing.SystemColors.Control
		Me.Scrolling_Configuraton_Button.CausesValidation = True
		Me.Scrolling_Configuraton_Button.Enabled = True
		Me.Scrolling_Configuraton_Button.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Scrolling_Configuraton_Button.Cursor = System.Windows.Forms.Cursors.Default
		Me.Scrolling_Configuraton_Button.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Scrolling_Configuraton_Button.TabStop = True
		Me.Scrolling_Configuraton_Button.Name = "Scrolling_Configuraton_Button"
		Me.Scroll_Timer.Enabled = False
		Me.Scroll_Timer.Interval = 1
		Me.Frame1.Text = "Carte"
		Me.Frame1.Size = New System.Drawing.Size(753, 577)
		Me.Frame1.Location = New System.Drawing.Point(8, 8)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.cardPicture.Size = New System.Drawing.Size(737, 473)
		Me.cardPicture.Location = New System.Drawing.Point(8, 16)
		Me.cardPicture.TabIndex = 1
		Me.cardPicture.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cardPicture.Dock = System.Windows.Forms.DockStyle.None
		Me.cardPicture.BackColor = System.Drawing.SystemColors.Control
		Me.cardPicture.CausesValidation = True
		Me.cardPicture.Enabled = True
		Me.cardPicture.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cardPicture.Cursor = System.Windows.Forms.Cursors.Default
		Me.cardPicture.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cardPicture.TabStop = True
		Me.cardPicture.Visible = True
		Me.cardPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.cardPicture.Name = "cardPicture"
		Me.confirm_timer.Interval = 10
		Me.confirm_timer.Enabled = True
		Me.CardText.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.CardText.Font = New System.Drawing.Font("Arial", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CardText.Size = New System.Drawing.Size(737, 73)
		Me.CardText.Location = New System.Drawing.Point(8, 496)
		Me.CardText.TabIndex = 3
		Me.CardText.BackColor = System.Drawing.SystemColors.Control
		Me.CardText.Enabled = True
		Me.CardText.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CardText.Cursor = System.Windows.Forms.Cursors.Default
		Me.CardText.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CardText.UseMnemonic = True
		Me.CardText.Visible = True
		Me.CardText.AutoSize = False
		Me.CardText.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.CardText.Name = "CardText"
		Me.Controls.Add(Scrolling_Pause)
		Me.Controls.Add(Scrolling_Configuraton_Button)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(cardPicture)
		Me.Frame1.Controls.Add(CardText)
		Me.Frame1.ResumeLayout(False)
		Me.cardPicture.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class