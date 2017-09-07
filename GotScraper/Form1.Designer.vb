<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraStatusPanel1 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel()
        Dim UltraStatusPanel2 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel()
        Dim UltraStatusPanel4 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel()
        Dim UltraStatusPanel3 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UltraRadioButtonGroupManager1 = New Infragistics.Win.UltraWinEditors.UltraRadioButtonGroupManager(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraButtonDirectory = New Infragistics.Win.Misc.UltraButton()
        Me.UltraRadioButtonEnglish = New Infragistics.Win.UltraWinEditors.UltraRadioButton()
        Me.UltraRadioButtonItaliano = New Infragistics.Win.UltraWinEditors.UltraRadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.UltraStatusBar1 = New Infragistics.Win.UltraWinStatusBar.UltraStatusBar()
        CType(Me.UltraRadioButtonGroupManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.UltraRadioButtonEnglish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraRadioButtonItaliano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraStatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraStatusBar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.GotScraper.My.Resources.Resources.BarTop
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.UltraStatusBar1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(503, 426)
        Me.Panel1.TabIndex = 1
        '
        'UltraButtonDirectory
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Transparent
        Appearance4.ImageBackground = Global.GotScraper.My.Resources.Resources.folder
        Me.UltraButtonDirectory.Appearance = Appearance4
        Me.UltraButtonDirectory.Location = New System.Drawing.Point(1, 3)
        Me.UltraButtonDirectory.Name = "UltraButtonDirectory"
        Me.UltraButtonDirectory.Size = New System.Drawing.Size(30, 28)
        Me.UltraButtonDirectory.TabIndex = 9
        Me.UltraButtonDirectory.Text = "Directory"
        Me.UltraButtonDirectory.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraRadioButtonEnglish
        '
        Appearance2.ForeColor = System.Drawing.Color.Transparent
        Appearance2.ImageBackground = Global.GotScraper.My.Resources.Resources.english_flag
        Me.UltraRadioButtonEnglish.Appearance = Appearance2
        Me.UltraRadioButtonEnglish.BackColor = System.Drawing.Color.Transparent
        Me.UltraRadioButtonEnglish.BackColorInternal = System.Drawing.Color.Transparent
        Me.UltraRadioButtonEnglish.GroupManager = Me.UltraRadioButtonGroupManager1
        Me.UltraRadioButtonEnglish.Location = New System.Drawing.Point(472, 3)
        Me.UltraRadioButtonEnglish.Name = "UltraRadioButtonEnglish"
        Me.UltraRadioButtonEnglish.Size = New System.Drawing.Size(30, 28)
        Me.UltraRadioButtonEnglish.TabIndex = 8
        Me.UltraRadioButtonEnglish.TabStop = False
        Me.UltraRadioButtonEnglish.Text = "Inglese"
        '
        'UltraRadioButtonItaliano
        '
        Appearance5.ForeColor = System.Drawing.Color.Transparent
        Appearance5.ImageBackground = Global.GotScraper.My.Resources.Resources.italian_flag
        Me.UltraRadioButtonItaliano.Appearance = Appearance5
        Me.UltraRadioButtonItaliano.BackColor = System.Drawing.Color.Transparent
        Me.UltraRadioButtonItaliano.BackColorInternal = System.Drawing.Color.Transparent
        Me.UltraRadioButtonItaliano.Checked = True
        Me.UltraRadioButtonItaliano.GroupManager = Me.UltraRadioButtonGroupManager1
        Me.UltraRadioButtonItaliano.Location = New System.Drawing.Point(438, 3)
        Me.UltraRadioButtonItaliano.Name = "UltraRadioButtonItaliano"
        Me.UltraRadioButtonItaliano.Size = New System.Drawing.Size(30, 28)
        Me.UltraRadioButtonItaliano.TabIndex = 7
        Me.UltraRadioButtonItaliano.Tag = "    "
        Me.UltraRadioButtonItaliano.Text = "Italiano"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(216, 200)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Scan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'UltraStatusBar1
        '
        Me.UltraStatusBar1.Controls.Add(Me.UltraButtonDirectory)
        Me.UltraStatusBar1.Controls.Add(Me.UltraRadioButtonItaliano)
        Me.UltraStatusBar1.Controls.Add(Me.UltraRadioButtonEnglish)
        Me.UltraStatusBar1.Location = New System.Drawing.Point(0, 394)
        Me.UltraStatusBar1.Name = "UltraStatusBar1"
        UltraStatusPanel1.Control = Me.UltraButtonDirectory
        UltraStatusPanel1.SizingMode = Infragistics.Win.UltraWinStatusBar.PanelSizingMode.Adjustable
        UltraStatusPanel1.Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.ControlContainer
        UltraStatusPanel1.Width = 32
        UltraStatusPanel2.AccessibleName = ""
        UltraStatusPanel2.Key = "Directory"
        UltraStatusPanel2.SizingMode = Infragistics.Win.UltraWinStatusBar.PanelSizingMode.Spring
        UltraStatusPanel4.Control = Me.UltraRadioButtonItaliano
        UltraStatusPanel4.SizingMode = Infragistics.Win.UltraWinStatusBar.PanelSizingMode.Adjustable
        UltraStatusPanel4.Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.ControlContainer
        UltraStatusPanel4.Width = 32
        UltraStatusPanel3.Control = Me.UltraRadioButtonEnglish
        UltraStatusPanel3.SizingMode = Infragistics.Win.UltraWinStatusBar.PanelSizingMode.Adjustable
        UltraStatusPanel3.Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.ControlContainer
        UltraStatusPanel3.Width = 32
        Me.UltraStatusBar1.Panels.AddRange(New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel() {UltraStatusPanel1, UltraStatusPanel2, UltraStatusPanel4, UltraStatusPanel3})
        Me.UltraStatusBar1.Size = New System.Drawing.Size(503, 32)
        Me.UltraStatusBar1.TabIndex = 10
        Me.UltraStatusBar1.Text = "UltraStatusBar1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 426)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "GotScraper - Video Games Scraper x windows by Gothrek"
        CType(Me.UltraRadioButtonGroupManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.UltraRadioButtonEnglish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraRadioButtonItaliano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraStatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraStatusBar1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer
    Private WithEvents UltraRadioButtonGroupManager1 As Infragistics.Win.UltraWinEditors.UltraRadioButtonGroupManager
    Friend WithEvents UltraRadioButtonEnglish As Infragistics.Win.UltraWinEditors.UltraRadioButton
    Friend WithEvents UltraRadioButtonItaliano As Infragistics.Win.UltraWinEditors.UltraRadioButton
    Friend WithEvents UltraButtonDirectory As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraStatusBar1 As Infragistics.Win.UltraWinStatusBar.UltraStatusBar
End Class
