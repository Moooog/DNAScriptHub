<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HubUI
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HubUI))
        Me.TextBoxScript = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.ScriptLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ImportDialog = New System.Windows.Forms.OpenFileDialog()
        Me.BunifuSwitch1 = New Bunifu.Framework.UI.BunifuSwitch()
        Me.BunifuSwitch2 = New Bunifu.Framework.UI.BunifuSwitch()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton25 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton26 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton27 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton28 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton29 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton210 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton211 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton212 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton213 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton214 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton215 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton216 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton217 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton218 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton219 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton220 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton221 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton222 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton223 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton224 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton225 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton226 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton227 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton228 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton229 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton230 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton231 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton232 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton233 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
        CType(Me.TextBoxScript, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxScript
        '
        Me.TextBoxScript.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.TextBoxScript.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>.+)" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextBoxScript.AutoScrollMinSize = New System.Drawing.Size(331, 14)
        Me.TextBoxScript.BackBrush = Nothing
        Me.TextBoxScript.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2
        Me.TextBoxScript.CharHeight = 14
        Me.TextBoxScript.CharWidth = 8
        Me.TextBoxScript.CommentPrefix = "--"
        Me.TextBoxScript.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxScript.DescriptionFile = ""
        Me.TextBoxScript.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.TextBoxScript.IsReplaceMode = False
        Me.TextBoxScript.Language = FastColoredTextBoxNS.Language.Lua
        Me.TextBoxScript.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.TextBoxScript.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(123)
        Me.TextBoxScript.Location = New System.Drawing.Point(491, 40)
        Me.TextBoxScript.Name = "TextBoxScript"
        Me.TextBoxScript.Paddings = New System.Windows.Forms.Padding(0)
        Me.TextBoxScript.ReadOnly = True
        Me.TextBoxScript.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.TextBoxScript.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(125)
        Me.TextBoxScript.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxScript.ServiceColors = CType(resources.GetObject("TextBoxScript.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.TextBoxScript.Size = New System.Drawing.Size(535, 484)
        Me.TextBoxScript.TabIndex = 0
        Me.TextBoxScript.Text = "Click a button to paste a script here!"
        Me.TextBoxScript.Zoom = 100
        '
        'ScriptLabel
        '
        Me.ScriptLabel.AutoSize = True
        Me.ScriptLabel.Location = New System.Drawing.Point(488, 24)
        Me.ScriptLabel.Name = "ScriptLabel"
        Me.ScriptLabel.Size = New System.Drawing.Size(123, 13)
        Me.ScriptLabel.TabIndex = 36
        Me.ScriptLabel.Text = "Current Script: Unloaded"
        '
        'ImportDialog
        '
        Me.ImportDialog.Filter = "Text File(*.txt)|*.txt|Lua File(*.lua)|*.lua"
        Me.ImportDialog.Title = "Import Text File or Lua File"
        '
        'BunifuSwitch1
        '
        Me.BunifuSwitch1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuSwitch1.BorderRadius = 0
        Me.BunifuSwitch1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuSwitch1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuSwitch1.Location = New System.Drawing.Point(433, 40)
        Me.BunifuSwitch1.Name = "BunifuSwitch1"
        Me.BunifuSwitch1.Oncolor = System.Drawing.Color.SeaGreen
        Me.BunifuSwitch1.Onoffcolor = System.Drawing.Color.DarkGray
        Me.BunifuSwitch1.Size = New System.Drawing.Size(51, 19)
        Me.BunifuSwitch1.TabIndex = 37
        Me.BunifuSwitch1.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuSwitch1.Value = True
        '
        'BunifuSwitch2
        '
        Me.BunifuSwitch2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuSwitch2.BorderRadius = 0
        Me.BunifuSwitch2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuSwitch2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuSwitch2.Location = New System.Drawing.Point(376, 40)
        Me.BunifuSwitch2.Name = "BunifuSwitch2"
        Me.BunifuSwitch2.Oncolor = System.Drawing.Color.SeaGreen
        Me.BunifuSwitch2.Onoffcolor = System.Drawing.Color.DarkGray
        Me.BunifuSwitch2.Size = New System.Drawing.Size(51, 19)
        Me.BunifuSwitch2.TabIndex = 38
        Me.BunifuSwitch2.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuSwitch2.Value = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(376, 24)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(49, 13)
        Me.BunifuCustomLabel1.TabIndex = 39
        Me.BunifuCustomLabel1.Text = "TopMost"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(475, 24)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(0, 13)
        Me.BunifuCustomLabel2.TabIndex = 40
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(432, 24)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(54, 13)
        Me.BunifuCustomLabel3.TabIndex = 41
        Me.BunifuCustomLabel3.Text = "ReadOnly"
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Script"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(22, 96)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton21.TabIndex = 42
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Script"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Location = New System.Drawing.Point(178, 96)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton22.TabIndex = 43
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "Script"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.Location = New System.Drawing.Point(333, 96)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton23.TabIndex = 44
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton24
        '
        Me.BunifuThinButton24.ActiveBorderThickness = 1
        Me.BunifuThinButton24.ActiveCornerRadius = 20
        Me.BunifuThinButton24.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton24.BackgroundImage = CType(resources.GetObject("BunifuThinButton24.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton24.ButtonText = "Script"
        Me.BunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.IdleBorderThickness = 1
        Me.BunifuThinButton24.IdleCornerRadius = 20
        Me.BunifuThinButton24.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton24.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.Location = New System.Drawing.Point(333, 130)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton24.TabIndex = 47
        Me.BunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton25
        '
        Me.BunifuThinButton25.ActiveBorderThickness = 1
        Me.BunifuThinButton25.ActiveCornerRadius = 20
        Me.BunifuThinButton25.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton25.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton25.BackgroundImage = CType(resources.GetObject("BunifuThinButton25.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton25.ButtonText = "Script"
        Me.BunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton25.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.IdleBorderThickness = 1
        Me.BunifuThinButton25.IdleCornerRadius = 20
        Me.BunifuThinButton25.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton25.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.Location = New System.Drawing.Point(178, 130)
        Me.BunifuThinButton25.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton25.Name = "BunifuThinButton25"
        Me.BunifuThinButton25.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton25.TabIndex = 46
        Me.BunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton26
        '
        Me.BunifuThinButton26.ActiveBorderThickness = 1
        Me.BunifuThinButton26.ActiveCornerRadius = 20
        Me.BunifuThinButton26.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton26.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton26.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton26.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton26.BackgroundImage = CType(resources.GetObject("BunifuThinButton26.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton26.ButtonText = "Script"
        Me.BunifuThinButton26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton26.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton26.IdleBorderThickness = 1
        Me.BunifuThinButton26.IdleCornerRadius = 20
        Me.BunifuThinButton26.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton26.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton26.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton26.Location = New System.Drawing.Point(22, 130)
        Me.BunifuThinButton26.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton26.Name = "BunifuThinButton26"
        Me.BunifuThinButton26.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton26.TabIndex = 45
        Me.BunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton27
        '
        Me.BunifuThinButton27.ActiveBorderThickness = 1
        Me.BunifuThinButton27.ActiveCornerRadius = 20
        Me.BunifuThinButton27.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton27.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton27.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton27.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton27.BackgroundImage = CType(resources.GetObject("BunifuThinButton27.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton27.ButtonText = "Script"
        Me.BunifuThinButton27.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton27.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton27.IdleBorderThickness = 1
        Me.BunifuThinButton27.IdleCornerRadius = 20
        Me.BunifuThinButton27.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton27.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton27.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton27.Location = New System.Drawing.Point(333, 199)
        Me.BunifuThinButton27.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton27.Name = "BunifuThinButton27"
        Me.BunifuThinButton27.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton27.TabIndex = 53
        Me.BunifuThinButton27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton28
        '
        Me.BunifuThinButton28.ActiveBorderThickness = 1
        Me.BunifuThinButton28.ActiveCornerRadius = 20
        Me.BunifuThinButton28.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton28.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton28.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton28.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton28.BackgroundImage = CType(resources.GetObject("BunifuThinButton28.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton28.ButtonText = "Script"
        Me.BunifuThinButton28.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton28.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton28.IdleBorderThickness = 1
        Me.BunifuThinButton28.IdleCornerRadius = 20
        Me.BunifuThinButton28.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton28.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton28.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton28.Location = New System.Drawing.Point(178, 199)
        Me.BunifuThinButton28.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton28.Name = "BunifuThinButton28"
        Me.BunifuThinButton28.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton28.TabIndex = 52
        Me.BunifuThinButton28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton29
        '
        Me.BunifuThinButton29.ActiveBorderThickness = 1
        Me.BunifuThinButton29.ActiveCornerRadius = 20
        Me.BunifuThinButton29.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton29.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton29.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton29.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton29.BackgroundImage = CType(resources.GetObject("BunifuThinButton29.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton29.ButtonText = "Script"
        Me.BunifuThinButton29.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton29.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton29.IdleBorderThickness = 1
        Me.BunifuThinButton29.IdleCornerRadius = 20
        Me.BunifuThinButton29.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton29.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton29.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton29.Location = New System.Drawing.Point(22, 199)
        Me.BunifuThinButton29.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton29.Name = "BunifuThinButton29"
        Me.BunifuThinButton29.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton29.TabIndex = 51
        Me.BunifuThinButton29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton210
        '
        Me.BunifuThinButton210.ActiveBorderThickness = 1
        Me.BunifuThinButton210.ActiveCornerRadius = 20
        Me.BunifuThinButton210.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton210.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton210.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton210.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton210.BackgroundImage = CType(resources.GetObject("BunifuThinButton210.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton210.ButtonText = "Script"
        Me.BunifuThinButton210.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton210.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton210.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton210.IdleBorderThickness = 1
        Me.BunifuThinButton210.IdleCornerRadius = 20
        Me.BunifuThinButton210.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton210.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton210.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton210.Location = New System.Drawing.Point(333, 165)
        Me.BunifuThinButton210.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton210.Name = "BunifuThinButton210"
        Me.BunifuThinButton210.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton210.TabIndex = 50
        Me.BunifuThinButton210.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton211
        '
        Me.BunifuThinButton211.ActiveBorderThickness = 1
        Me.BunifuThinButton211.ActiveCornerRadius = 20
        Me.BunifuThinButton211.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton211.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton211.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton211.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton211.BackgroundImage = CType(resources.GetObject("BunifuThinButton211.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton211.ButtonText = "Script"
        Me.BunifuThinButton211.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton211.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton211.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton211.IdleBorderThickness = 1
        Me.BunifuThinButton211.IdleCornerRadius = 20
        Me.BunifuThinButton211.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton211.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton211.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton211.Location = New System.Drawing.Point(178, 165)
        Me.BunifuThinButton211.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton211.Name = "BunifuThinButton211"
        Me.BunifuThinButton211.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton211.TabIndex = 49
        Me.BunifuThinButton211.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton212
        '
        Me.BunifuThinButton212.ActiveBorderThickness = 1
        Me.BunifuThinButton212.ActiveCornerRadius = 20
        Me.BunifuThinButton212.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton212.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton212.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton212.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton212.BackgroundImage = CType(resources.GetObject("BunifuThinButton212.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton212.ButtonText = "Script"
        Me.BunifuThinButton212.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton212.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton212.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton212.IdleBorderThickness = 1
        Me.BunifuThinButton212.IdleCornerRadius = 20
        Me.BunifuThinButton212.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton212.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton212.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton212.Location = New System.Drawing.Point(22, 165)
        Me.BunifuThinButton212.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton212.Name = "BunifuThinButton212"
        Me.BunifuThinButton212.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton212.TabIndex = 48
        Me.BunifuThinButton212.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton213
        '
        Me.BunifuThinButton213.ActiveBorderThickness = 1
        Me.BunifuThinButton213.ActiveCornerRadius = 20
        Me.BunifuThinButton213.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton213.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton213.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton213.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton213.BackgroundImage = CType(resources.GetObject("BunifuThinButton213.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton213.ButtonText = "Script"
        Me.BunifuThinButton213.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton213.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton213.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton213.IdleBorderThickness = 1
        Me.BunifuThinButton213.IdleCornerRadius = 20
        Me.BunifuThinButton213.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton213.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton213.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton213.Location = New System.Drawing.Point(333, 337)
        Me.BunifuThinButton213.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton213.Name = "BunifuThinButton213"
        Me.BunifuThinButton213.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton213.TabIndex = 65
        Me.BunifuThinButton213.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton214
        '
        Me.BunifuThinButton214.ActiveBorderThickness = 1
        Me.BunifuThinButton214.ActiveCornerRadius = 20
        Me.BunifuThinButton214.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton214.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton214.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton214.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton214.BackgroundImage = CType(resources.GetObject("BunifuThinButton214.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton214.ButtonText = "Script"
        Me.BunifuThinButton214.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton214.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton214.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton214.IdleBorderThickness = 1
        Me.BunifuThinButton214.IdleCornerRadius = 20
        Me.BunifuThinButton214.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton214.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton214.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton214.Location = New System.Drawing.Point(178, 337)
        Me.BunifuThinButton214.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton214.Name = "BunifuThinButton214"
        Me.BunifuThinButton214.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton214.TabIndex = 64
        Me.BunifuThinButton214.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton215
        '
        Me.BunifuThinButton215.ActiveBorderThickness = 1
        Me.BunifuThinButton215.ActiveCornerRadius = 20
        Me.BunifuThinButton215.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton215.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton215.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton215.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton215.BackgroundImage = CType(resources.GetObject("BunifuThinButton215.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton215.ButtonText = "Script"
        Me.BunifuThinButton215.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton215.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton215.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton215.IdleBorderThickness = 1
        Me.BunifuThinButton215.IdleCornerRadius = 20
        Me.BunifuThinButton215.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton215.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton215.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton215.Location = New System.Drawing.Point(22, 337)
        Me.BunifuThinButton215.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton215.Name = "BunifuThinButton215"
        Me.BunifuThinButton215.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton215.TabIndex = 63
        Me.BunifuThinButton215.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton216
        '
        Me.BunifuThinButton216.ActiveBorderThickness = 1
        Me.BunifuThinButton216.ActiveCornerRadius = 20
        Me.BunifuThinButton216.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton216.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton216.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton216.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton216.BackgroundImage = CType(resources.GetObject("BunifuThinButton216.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton216.ButtonText = "Script"
        Me.BunifuThinButton216.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton216.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton216.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton216.IdleBorderThickness = 1
        Me.BunifuThinButton216.IdleCornerRadius = 20
        Me.BunifuThinButton216.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton216.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton216.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton216.Location = New System.Drawing.Point(333, 303)
        Me.BunifuThinButton216.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton216.Name = "BunifuThinButton216"
        Me.BunifuThinButton216.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton216.TabIndex = 62
        Me.BunifuThinButton216.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton217
        '
        Me.BunifuThinButton217.ActiveBorderThickness = 1
        Me.BunifuThinButton217.ActiveCornerRadius = 20
        Me.BunifuThinButton217.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton217.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton217.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton217.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton217.BackgroundImage = CType(resources.GetObject("BunifuThinButton217.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton217.ButtonText = "Script"
        Me.BunifuThinButton217.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton217.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton217.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton217.IdleBorderThickness = 1
        Me.BunifuThinButton217.IdleCornerRadius = 20
        Me.BunifuThinButton217.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton217.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton217.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton217.Location = New System.Drawing.Point(178, 303)
        Me.BunifuThinButton217.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton217.Name = "BunifuThinButton217"
        Me.BunifuThinButton217.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton217.TabIndex = 61
        Me.BunifuThinButton217.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton218
        '
        Me.BunifuThinButton218.ActiveBorderThickness = 1
        Me.BunifuThinButton218.ActiveCornerRadius = 20
        Me.BunifuThinButton218.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton218.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton218.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton218.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton218.BackgroundImage = CType(resources.GetObject("BunifuThinButton218.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton218.ButtonText = "Script"
        Me.BunifuThinButton218.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton218.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton218.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton218.IdleBorderThickness = 1
        Me.BunifuThinButton218.IdleCornerRadius = 20
        Me.BunifuThinButton218.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton218.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton218.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton218.Location = New System.Drawing.Point(22, 303)
        Me.BunifuThinButton218.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton218.Name = "BunifuThinButton218"
        Me.BunifuThinButton218.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton218.TabIndex = 60
        Me.BunifuThinButton218.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton219
        '
        Me.BunifuThinButton219.ActiveBorderThickness = 1
        Me.BunifuThinButton219.ActiveCornerRadius = 20
        Me.BunifuThinButton219.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton219.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton219.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton219.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton219.BackgroundImage = CType(resources.GetObject("BunifuThinButton219.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton219.ButtonText = "Script"
        Me.BunifuThinButton219.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton219.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton219.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton219.IdleBorderThickness = 1
        Me.BunifuThinButton219.IdleCornerRadius = 20
        Me.BunifuThinButton219.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton219.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton219.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton219.Location = New System.Drawing.Point(333, 268)
        Me.BunifuThinButton219.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton219.Name = "BunifuThinButton219"
        Me.BunifuThinButton219.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton219.TabIndex = 59
        Me.BunifuThinButton219.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton220
        '
        Me.BunifuThinButton220.ActiveBorderThickness = 1
        Me.BunifuThinButton220.ActiveCornerRadius = 20
        Me.BunifuThinButton220.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton220.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton220.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton220.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton220.BackgroundImage = CType(resources.GetObject("BunifuThinButton220.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton220.ButtonText = "Script"
        Me.BunifuThinButton220.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton220.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton220.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton220.IdleBorderThickness = 1
        Me.BunifuThinButton220.IdleCornerRadius = 20
        Me.BunifuThinButton220.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton220.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton220.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton220.Location = New System.Drawing.Point(178, 268)
        Me.BunifuThinButton220.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton220.Name = "BunifuThinButton220"
        Me.BunifuThinButton220.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton220.TabIndex = 58
        Me.BunifuThinButton220.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton221
        '
        Me.BunifuThinButton221.ActiveBorderThickness = 1
        Me.BunifuThinButton221.ActiveCornerRadius = 20
        Me.BunifuThinButton221.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton221.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton221.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton221.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton221.BackgroundImage = CType(resources.GetObject("BunifuThinButton221.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton221.ButtonText = "Script"
        Me.BunifuThinButton221.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton221.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton221.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton221.IdleBorderThickness = 1
        Me.BunifuThinButton221.IdleCornerRadius = 20
        Me.BunifuThinButton221.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton221.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton221.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton221.Location = New System.Drawing.Point(22, 268)
        Me.BunifuThinButton221.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton221.Name = "BunifuThinButton221"
        Me.BunifuThinButton221.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton221.TabIndex = 57
        Me.BunifuThinButton221.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton222
        '
        Me.BunifuThinButton222.ActiveBorderThickness = 1
        Me.BunifuThinButton222.ActiveCornerRadius = 20
        Me.BunifuThinButton222.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton222.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton222.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton222.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton222.BackgroundImage = CType(resources.GetObject("BunifuThinButton222.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton222.ButtonText = "Script"
        Me.BunifuThinButton222.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton222.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton222.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton222.IdleBorderThickness = 1
        Me.BunifuThinButton222.IdleCornerRadius = 20
        Me.BunifuThinButton222.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton222.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton222.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton222.Location = New System.Drawing.Point(333, 234)
        Me.BunifuThinButton222.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton222.Name = "BunifuThinButton222"
        Me.BunifuThinButton222.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton222.TabIndex = 56
        Me.BunifuThinButton222.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton223
        '
        Me.BunifuThinButton223.ActiveBorderThickness = 1
        Me.BunifuThinButton223.ActiveCornerRadius = 20
        Me.BunifuThinButton223.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton223.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton223.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton223.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton223.BackgroundImage = CType(resources.GetObject("BunifuThinButton223.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton223.ButtonText = "Script"
        Me.BunifuThinButton223.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton223.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton223.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton223.IdleBorderThickness = 1
        Me.BunifuThinButton223.IdleCornerRadius = 20
        Me.BunifuThinButton223.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton223.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton223.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton223.Location = New System.Drawing.Point(178, 234)
        Me.BunifuThinButton223.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton223.Name = "BunifuThinButton223"
        Me.BunifuThinButton223.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton223.TabIndex = 55
        Me.BunifuThinButton223.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton224
        '
        Me.BunifuThinButton224.ActiveBorderThickness = 1
        Me.BunifuThinButton224.ActiveCornerRadius = 20
        Me.BunifuThinButton224.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton224.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton224.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton224.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton224.BackgroundImage = CType(resources.GetObject("BunifuThinButton224.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton224.ButtonText = "Script"
        Me.BunifuThinButton224.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton224.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton224.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton224.IdleBorderThickness = 1
        Me.BunifuThinButton224.IdleCornerRadius = 20
        Me.BunifuThinButton224.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton224.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton224.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton224.Location = New System.Drawing.Point(22, 234)
        Me.BunifuThinButton224.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton224.Name = "BunifuThinButton224"
        Me.BunifuThinButton224.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton224.TabIndex = 54
        Me.BunifuThinButton224.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton225
        '
        Me.BunifuThinButton225.ActiveBorderThickness = 1
        Me.BunifuThinButton225.ActiveCornerRadius = 20
        Me.BunifuThinButton225.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton225.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton225.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton225.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton225.BackgroundImage = CType(resources.GetObject("BunifuThinButton225.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton225.ButtonText = "Sode No Konayuki"
        Me.BunifuThinButton225.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton225.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton225.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton225.IdleBorderThickness = 1
        Me.BunifuThinButton225.IdleCornerRadius = 20
        Me.BunifuThinButton225.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton225.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton225.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton225.Location = New System.Drawing.Point(333, 61)
        Me.BunifuThinButton225.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton225.Name = "BunifuThinButton225"
        Me.BunifuThinButton225.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton225.TabIndex = 68
        Me.BunifuThinButton225.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton226
        '
        Me.BunifuThinButton226.ActiveBorderThickness = 1
        Me.BunifuThinButton226.ActiveCornerRadius = 20
        Me.BunifuThinButton226.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton226.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton226.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton226.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton226.BackgroundImage = CType(resources.GetObject("BunifuThinButton226.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton226.ButtonText = "Custom Titan V2"
        Me.BunifuThinButton226.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton226.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton226.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton226.IdleBorderThickness = 1
        Me.BunifuThinButton226.IdleCornerRadius = 20
        Me.BunifuThinButton226.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton226.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton226.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton226.Location = New System.Drawing.Point(178, 61)
        Me.BunifuThinButton226.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton226.Name = "BunifuThinButton226"
        Me.BunifuThinButton226.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton226.TabIndex = 67
        Me.BunifuThinButton226.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton227
        '
        Me.BunifuThinButton227.ActiveBorderThickness = 1
        Me.BunifuThinButton227.ActiveCornerRadius = 20
        Me.BunifuThinButton227.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton227.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton227.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton227.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton227.BackgroundImage = CType(resources.GetObject("BunifuThinButton227.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton227.ButtonText = "Atlas V1"
        Me.BunifuThinButton227.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton227.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton227.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton227.IdleBorderThickness = 1
        Me.BunifuThinButton227.IdleCornerRadius = 20
        Me.BunifuThinButton227.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton227.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton227.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton227.Location = New System.Drawing.Point(22, 61)
        Me.BunifuThinButton227.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton227.Name = "BunifuThinButton227"
        Me.BunifuThinButton227.Size = New System.Drawing.Size(150, 35)
        Me.BunifuThinButton227.TabIndex = 66
        Me.BunifuThinButton227.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton228
        '
        Me.BunifuThinButton228.ActiveBorderThickness = 1
        Me.BunifuThinButton228.ActiveCornerRadius = 20
        Me.BunifuThinButton228.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton228.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton228.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton228.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton228.BackgroundImage = CType(resources.GetObject("BunifuThinButton228.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton228.ButtonText = "Keemstars News"
        Me.BunifuThinButton228.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton228.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton228.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton228.IdleBorderThickness = 1
        Me.BunifuThinButton228.IdleCornerRadius = 20
        Me.BunifuThinButton228.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton228.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton228.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton228.Location = New System.Drawing.Point(22, 372)
        Me.BunifuThinButton228.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton228.Name = "BunifuThinButton228"
        Me.BunifuThinButton228.Size = New System.Drawing.Size(461, 35)
        Me.BunifuThinButton228.TabIndex = 69
        Me.BunifuThinButton228.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton229
        '
        Me.BunifuThinButton229.ActiveBorderThickness = 1
        Me.BunifuThinButton229.ActiveCornerRadius = 20
        Me.BunifuThinButton229.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton229.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton229.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton229.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton229.BackgroundImage = CType(resources.GetObject("BunifuThinButton229.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton229.ButtonText = "Update"
        Me.BunifuThinButton229.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton229.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton229.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton229.IdleBorderThickness = 1
        Me.BunifuThinButton229.IdleCornerRadius = 20
        Me.BunifuThinButton229.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton229.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton229.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton229.Location = New System.Drawing.Point(22, 403)
        Me.BunifuThinButton229.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton229.Name = "BunifuThinButton229"
        Me.BunifuThinButton229.Size = New System.Drawing.Size(461, 35)
        Me.BunifuThinButton229.TabIndex = 70
        Me.BunifuThinButton229.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton230
        '
        Me.BunifuThinButton230.ActiveBorderThickness = 1
        Me.BunifuThinButton230.ActiveCornerRadius = 20
        Me.BunifuThinButton230.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton230.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton230.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton230.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton230.BackgroundImage = CType(resources.GetObject("BunifuThinButton230.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton230.ButtonText = "Clear"
        Me.BunifuThinButton230.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton230.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton230.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton230.IdleBorderThickness = 1
        Me.BunifuThinButton230.IdleCornerRadius = 20
        Me.BunifuThinButton230.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton230.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton230.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton230.Location = New System.Drawing.Point(22, 434)
        Me.BunifuThinButton230.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton230.Name = "BunifuThinButton230"
        Me.BunifuThinButton230.Size = New System.Drawing.Size(461, 35)
        Me.BunifuThinButton230.TabIndex = 71
        Me.BunifuThinButton230.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton231
        '
        Me.BunifuThinButton231.ActiveBorderThickness = 1
        Me.BunifuThinButton231.ActiveCornerRadius = 20
        Me.BunifuThinButton231.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton231.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton231.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton231.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton231.BackgroundImage = CType(resources.GetObject("BunifuThinButton231.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton231.ButtonText = "Save As"
        Me.BunifuThinButton231.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton231.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton231.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton231.IdleBorderThickness = 1
        Me.BunifuThinButton231.IdleCornerRadius = 20
        Me.BunifuThinButton231.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton231.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton231.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton231.Location = New System.Drawing.Point(181, 470)
        Me.BunifuThinButton231.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton231.Name = "BunifuThinButton231"
        Me.BunifuThinButton231.Size = New System.Drawing.Size(149, 54)
        Me.BunifuThinButton231.TabIndex = 72
        Me.BunifuThinButton231.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton232
        '
        Me.BunifuThinButton232.ActiveBorderThickness = 1
        Me.BunifuThinButton232.ActiveCornerRadius = 20
        Me.BunifuThinButton232.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton232.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton232.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton232.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton232.BackgroundImage = CType(resources.GetObject("BunifuThinButton232.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton232.ButtonText = "Copy"
        Me.BunifuThinButton232.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton232.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton232.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton232.IdleBorderThickness = 1
        Me.BunifuThinButton232.IdleCornerRadius = 20
        Me.BunifuThinButton232.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton232.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton232.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton232.Location = New System.Drawing.Point(22, 470)
        Me.BunifuThinButton232.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton232.Name = "BunifuThinButton232"
        Me.BunifuThinButton232.Size = New System.Drawing.Size(149, 54)
        Me.BunifuThinButton232.TabIndex = 73
        Me.BunifuThinButton232.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton233
        '
        Me.BunifuThinButton233.ActiveBorderThickness = 1
        Me.BunifuThinButton233.ActiveCornerRadius = 20
        Me.BunifuThinButton233.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton233.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton233.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton233.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuThinButton233.BackgroundImage = CType(resources.GetObject("BunifuThinButton233.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton233.ButtonText = "Import"
        Me.BunifuThinButton233.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton233.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton233.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton233.IdleBorderThickness = 1
        Me.BunifuThinButton233.IdleCornerRadius = 20
        Me.BunifuThinButton233.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton233.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton233.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton233.Location = New System.Drawing.Point(340, 470)
        Me.BunifuThinButton233.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton233.Name = "BunifuThinButton233"
        Me.BunifuThinButton233.Size = New System.Drawing.Size(149, 54)
        Me.BunifuThinButton233.TabIndex = 74
        Me.BunifuThinButton233.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SaveDialog
        '
        Me.SaveDialog.Filter = "Text File(*.txt)|*.txt|Lua File(*.lua)|*.lua"
        Me.SaveDialog.Title = "Save As"
        '
        'HubUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 545)
        Me.Controls.Add(Me.BunifuThinButton233)
        Me.Controls.Add(Me.BunifuThinButton232)
        Me.Controls.Add(Me.BunifuThinButton231)
        Me.Controls.Add(Me.BunifuThinButton230)
        Me.Controls.Add(Me.BunifuThinButton229)
        Me.Controls.Add(Me.BunifuThinButton228)
        Me.Controls.Add(Me.BunifuThinButton225)
        Me.Controls.Add(Me.BunifuThinButton226)
        Me.Controls.Add(Me.BunifuThinButton227)
        Me.Controls.Add(Me.BunifuThinButton213)
        Me.Controls.Add(Me.BunifuThinButton214)
        Me.Controls.Add(Me.BunifuThinButton215)
        Me.Controls.Add(Me.BunifuThinButton216)
        Me.Controls.Add(Me.BunifuThinButton217)
        Me.Controls.Add(Me.BunifuThinButton218)
        Me.Controls.Add(Me.BunifuThinButton219)
        Me.Controls.Add(Me.BunifuThinButton220)
        Me.Controls.Add(Me.BunifuThinButton221)
        Me.Controls.Add(Me.BunifuThinButton222)
        Me.Controls.Add(Me.BunifuThinButton223)
        Me.Controls.Add(Me.BunifuThinButton224)
        Me.Controls.Add(Me.BunifuThinButton27)
        Me.Controls.Add(Me.BunifuThinButton28)
        Me.Controls.Add(Me.BunifuThinButton29)
        Me.Controls.Add(Me.BunifuThinButton210)
        Me.Controls.Add(Me.BunifuThinButton211)
        Me.Controls.Add(Me.BunifuThinButton212)
        Me.Controls.Add(Me.BunifuThinButton24)
        Me.Controls.Add(Me.BunifuThinButton25)
        Me.Controls.Add(Me.BunifuThinButton26)
        Me.Controls.Add(Me.BunifuThinButton23)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuSwitch2)
        Me.Controls.Add(Me.BunifuSwitch1)
        Me.Controls.Add(Me.ScriptLabel)
        Me.Controls.Add(Me.TextBoxScript)
        Me.MaximizeBox = False
        Me.Name = "HubUI"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "DNA Script Hub - V1"
        CType(Me.TextBoxScript, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxScript As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents ScriptLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ImportDialog As OpenFileDialog
    Friend WithEvents BunifuSwitch1 As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents BunifuSwitch2 As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton25 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton26 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton27 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton28 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton29 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton210 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton211 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton212 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton213 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton214 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton215 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton216 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton217 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton218 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton219 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton220 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton221 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton222 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton223 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton224 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton225 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton226 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton227 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton228 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton229 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton230 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton231 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton232 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton233 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents SaveDialog As SaveFileDialog
End Class
