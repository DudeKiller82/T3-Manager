<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Preview
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
	Public WithEvents CheckInterLine As System.Windows.Forms.CheckBox
	Public WithEvents CheckReal As System.Windows.Forms.CheckBox
	Public WithEvents CheckImage As System.Windows.Forms.CheckBox
	Public WithEvents PreviewZone As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Preview))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.CheckInterLine = New System.Windows.Forms.CheckBox
		Me.CheckReal = New System.Windows.Forms.CheckBox
		Me.CheckImage = New System.Windows.Forms.CheckBox
		Me.PreviewZone = New System.Windows.Forms.PictureBox
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Aperçu"
		Me.ClientSize = New System.Drawing.Size(606, 621)
		Me.Location = New System.Drawing.Point(3, 29)
		Me.Icon = CType(resources.GetObject("Preview.Icon"), System.Drawing.Icon)
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
		Me.Name = "Preview"
		Me.CheckInterLine.BackColor = System.Drawing.Color.Green
		Me.CheckInterLine.Text = "Afficher les lignes non dessinées"
		Me.CheckInterLine.Size = New System.Drawing.Size(177, 17)
		Me.CheckInterLine.Location = New System.Drawing.Point(216, 600)
		Me.CheckInterLine.TabIndex = 3
		Me.CheckInterLine.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CheckInterLine.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.CheckInterLine.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.CheckInterLine.CausesValidation = True
		Me.CheckInterLine.Enabled = True
		Me.CheckInterLine.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CheckInterLine.Cursor = System.Windows.Forms.Cursors.Default
		Me.CheckInterLine.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CheckInterLine.Appearance = System.Windows.Forms.Appearance.Normal
		Me.CheckInterLine.TabStop = True
		Me.CheckInterLine.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.CheckInterLine.Visible = True
		Me.CheckInterLine.Name = "CheckInterLine"
		Me.CheckReal.BackColor = System.Drawing.Color.Red
		Me.CheckReal.Text = "Afficher l'aperçu"
		Me.CheckReal.ForeColor = System.Drawing.Color.Black
		Me.CheckReal.Size = New System.Drawing.Size(97, 17)
		Me.CheckReal.Location = New System.Drawing.Point(112, 600)
		Me.CheckReal.TabIndex = 2
		Me.CheckReal.CheckState = System.Windows.Forms.CheckState.Checked
		Me.CheckReal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CheckReal.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.CheckReal.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.CheckReal.CausesValidation = True
		Me.CheckReal.Enabled = True
		Me.CheckReal.Cursor = System.Windows.Forms.Cursors.Default
		Me.CheckReal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CheckReal.Appearance = System.Windows.Forms.Appearance.Normal
		Me.CheckReal.TabStop = True
		Me.CheckReal.Visible = True
		Me.CheckReal.Name = "CheckReal"
		Me.CheckImage.Text = "Afficher l'image"
		Me.CheckImage.Size = New System.Drawing.Size(97, 17)
		Me.CheckImage.Location = New System.Drawing.Point(8, 600)
		Me.CheckImage.TabIndex = 1
		Me.CheckImage.CheckState = System.Windows.Forms.CheckState.Checked
		Me.CheckImage.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CheckImage.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.CheckImage.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.CheckImage.BackColor = System.Drawing.SystemColors.Control
		Me.CheckImage.CausesValidation = True
		Me.CheckImage.Enabled = True
		Me.CheckImage.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CheckImage.Cursor = System.Windows.Forms.Cursors.Default
		Me.CheckImage.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CheckImage.Appearance = System.Windows.Forms.Appearance.Normal
		Me.CheckImage.TabStop = True
		Me.CheckImage.Visible = True
		Me.CheckImage.Name = "CheckImage"
		Me.PreviewZone.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.PreviewZone.Size = New System.Drawing.Size(589, 589)
		Me.PreviewZone.Location = New System.Drawing.Point(8, 8)
		Me.PreviewZone.TabIndex = 0
		Me.PreviewZone.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PreviewZone.Dock = System.Windows.Forms.DockStyle.None
		Me.PreviewZone.CausesValidation = True
		Me.PreviewZone.Enabled = True
		Me.PreviewZone.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PreviewZone.Cursor = System.Windows.Forms.Cursors.Default
		Me.PreviewZone.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PreviewZone.TabStop = True
		Me.PreviewZone.Visible = True
		Me.PreviewZone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.PreviewZone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.PreviewZone.Name = "PreviewZone"
		Me.Controls.Add(CheckInterLine)
		Me.Controls.Add(CheckReal)
		Me.Controls.Add(CheckImage)
		Me.Controls.Add(PreviewZone)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class