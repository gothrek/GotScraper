﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraStatusPanel5 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel()
        Dim UltraStatusPanel6 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel()
        Dim UltraStatusPanel7 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel()
        Dim UltraStatusPanel8 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel()
        Me.UltraButtonDirectory = New Infragistics.Win.Misc.UltraButton()
        Me.UltraRadioButtonItaliano = New Infragistics.Win.UltraWinEditors.UltraRadioButton()
        Me.UltraRadioButtonGroupManager1 = New Infragistics.Win.UltraWinEditors.UltraRadioButtonGroupManager(Me.components)
        Me.UltraRadioButtonEnglish = New Infragistics.Win.UltraWinEditors.UltraRadioButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraButtonScan = New Infragistics.Win.Misc.UltraButton()
        Me.UltraStatusBar1 = New Infragistics.Win.UltraWinStatusBar.UltraStatusBar()
        CType(Me.UltraRadioButtonItaliano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraRadioButtonGroupManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraRadioButtonEnglish, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.UltraStatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraStatusBar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraButtonDirectory
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Transparent
        Appearance1.ImageBackground = Global.GotScraper.My.Resources.Resources.folder
        Me.UltraButtonDirectory.Appearance = Appearance1
        Me.UltraButtonDirectory.Location = New System.Drawing.Point(1, 3)
        Me.UltraButtonDirectory.Name = "UltraButtonDirectory"
        Me.UltraButtonDirectory.Size = New System.Drawing.Size(30, 28)
        Me.UltraButtonDirectory.TabIndex = 9
        Me.UltraButtonDirectory.Text = "Directory"
        Me.UltraButtonDirectory.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraRadioButtonItaliano
        '
        Appearance2.ForeColor = System.Drawing.Color.Transparent
        Appearance2.ImageBackground = Global.GotScraper.My.Resources.Resources.italian_flag
        Me.UltraRadioButtonItaliano.Appearance = Appearance2
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
        'UltraRadioButtonEnglish
        '
        Appearance3.ForeColor = System.Drawing.Color.Transparent
        Appearance3.ImageBackground = Global.GotScraper.My.Resources.Resources.english_flag
        Me.UltraRadioButtonEnglish.Appearance = Appearance3
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.GotScraper.My.Resources.Resources.BarTop
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.UltraButtonScan)
        Me.Panel1.Controls.Add(Me.UltraStatusBar1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(503, 426)
        Me.Panel1.TabIndex = 1
        '
        'UltraButtonScan
        '
        Me.UltraButtonScan.Enabled = False
        Me.UltraButtonScan.Location = New System.Drawing.Point(224, 137)
        Me.UltraButtonScan.Name = "UltraButtonScan"
        Me.UltraButtonScan.Size = New System.Drawing.Size(75, 23)
        Me.UltraButtonScan.TabIndex = 11
        Me.UltraButtonScan.Text = "Scan"
        '
        'UltraStatusBar1
        '
        Me.UltraStatusBar1.Controls.Add(Me.UltraButtonDirectory)
        Me.UltraStatusBar1.Controls.Add(Me.UltraRadioButtonItaliano)
        Me.UltraStatusBar1.Controls.Add(Me.UltraRadioButtonEnglish)
        Me.UltraStatusBar1.Location = New System.Drawing.Point(0, 394)
        Me.UltraStatusBar1.Name = "UltraStatusBar1"
        UltraStatusPanel5.Control = Me.UltraButtonDirectory
        UltraStatusPanel5.SizingMode = Infragistics.Win.UltraWinStatusBar.PanelSizingMode.Adjustable
        UltraStatusPanel5.Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.ControlContainer
        UltraStatusPanel5.Width = 32
        UltraStatusPanel6.AccessibleName = ""
        UltraStatusPanel6.Key = "Directory"
        UltraStatusPanel6.SizingMode = Infragistics.Win.UltraWinStatusBar.PanelSizingMode.Spring
        UltraStatusPanel7.Control = Me.UltraRadioButtonItaliano
        UltraStatusPanel7.SizingMode = Infragistics.Win.UltraWinStatusBar.PanelSizingMode.Adjustable
        UltraStatusPanel7.Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.ControlContainer
        UltraStatusPanel7.Width = 32
        UltraStatusPanel8.Control = Me.UltraRadioButtonEnglish
        UltraStatusPanel8.SizingMode = Infragistics.Win.UltraWinStatusBar.PanelSizingMode.Adjustable
        UltraStatusPanel8.Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.ControlContainer
        UltraStatusPanel8.Width = 32
        Me.UltraStatusBar1.Panels.AddRange(New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel() {UltraStatusPanel5, UltraStatusPanel6, UltraStatusPanel7, UltraStatusPanel8})
        Me.UltraStatusBar1.Size = New System.Drawing.Size(503, 32)
        Me.UltraStatusBar1.TabIndex = 10
        Me.UltraStatusBar1.Text = "UltraStatusBar1"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(503, 426)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "GotScraper - Video Games Scraper x windows by Gothrek"
        CType(Me.UltraRadioButtonItaliano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraRadioButtonGroupManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraRadioButtonEnglish, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.UltraStatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraStatusBar1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Private WithEvents UltraRadioButtonGroupManager1 As Infragistics.Win.UltraWinEditors.UltraRadioButtonGroupManager
    Private WithEvents UltraRadioButtonEnglish As Infragistics.Win.UltraWinEditors.UltraRadioButton
    Private WithEvents UltraRadioButtonItaliano As Infragistics.Win.UltraWinEditors.UltraRadioButton
    Private WithEvents UltraButtonDirectory As Infragistics.Win.Misc.UltraButton
    Private WithEvents UltraStatusBar1 As Infragistics.Win.UltraWinStatusBar.UltraStatusBar
    Private WithEvents UltraButtonScan As Infragistics.Win.Misc.UltraButton
End Class
