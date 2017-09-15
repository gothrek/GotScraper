<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen1))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraFormattedLinkLabel1 = New Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel()
        Me.UltraLabelVersion = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabelCopyright = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraButtonInsertCoin = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabelApplicationTitle = New Infragistics.Win.Misc.UltraLabel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.UltraPanel2 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        Me.UltraPanel2.ClientArea.SuspendLayout()
        Me.UltraPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'UltraPanel1
        '
        Appearance1.ImageBackground = Global.GotScraper.My.Resources.Resources.Classic_NES_Controller_nintendo_5433196_500_375
        Me.UltraPanel1.Appearance = Appearance1
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraPanel2)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraLabelVersion)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraLabelCopyright)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraButtonInsertCoin)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraLabelApplicationTitle)
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel1.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(622, 428)
        Me.UltraPanel1.TabIndex = 3
        '
        'UltraFormattedLinkLabel1
        '
        Me.UltraFormattedLinkLabel1.Location = New System.Drawing.Point(0, 0)
        Me.UltraFormattedLinkLabel1.Name = "UltraFormattedLinkLabel1"
        Me.UltraFormattedLinkLabel1.Size = New System.Drawing.Size(130, 202)
        Me.UltraFormattedLinkLabel1.TabIndex = 8
        Me.UltraFormattedLinkLabel1.TabStop = True
        Me.UltraFormattedLinkLabel1.Value = resources.GetString("UltraFormattedLinkLabel1.Value")
        '
        'UltraLabelVersion
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.UltraLabelVersion.Appearance = Appearance2
        Me.UltraLabelVersion.AutoSize = True
        Me.UltraLabelVersion.Location = New System.Drawing.Point(520, 411)
        Me.UltraLabelVersion.Name = "UltraLabelVersion"
        Me.UltraLabelVersion.Size = New System.Drawing.Size(92, 14)
        Me.UltraLabelVersion.TabIndex = 7
        Me.UltraLabelVersion.Text = "Versione {0}.{1:00}"
        '
        'UltraLabelCopyright
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.White
        Me.UltraLabelCopyright.Appearance = Appearance3
        Me.UltraLabelCopyright.AutoSize = True
        Me.UltraLabelCopyright.Location = New System.Drawing.Point(247, 393)
        Me.UltraLabelCopyright.Name = "UltraLabelCopyright"
        Me.UltraLabelCopyright.Size = New System.Drawing.Size(118, 14)
        Me.UltraLabelCopyright.TabIndex = 5
        Me.UltraLabelCopyright.Text = "Copyright by Gothrek 2017"
        '
        'UltraButtonInsertCoin
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.White
        Appearance4.ImageBackground = Global.GotScraper.My.Resources.Resources.Classicbottone
        Me.UltraButtonInsertCoin.Appearance = Appearance4
        Me.UltraButtonInsertCoin.ButtonStyle = Infragistics.Win.UIElementButtonStyle.FlatBorderless
        Me.UltraButtonInsertCoin.Font = New System.Drawing.Font("Perpetua", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButtonInsertCoin.Location = New System.Drawing.Point(375, 261)
        Me.UltraButtonInsertCoin.Name = "UltraButtonInsertCoin"
        Me.UltraButtonInsertCoin.Size = New System.Drawing.Size(104, 102)
        Me.UltraButtonInsertCoin.TabIndex = 4
        Me.UltraButtonInsertCoin.Text = "Start"
        Me.UltraButtonInsertCoin.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraLabelApplicationTitle
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Red
        Appearance5.ImageBackground = Global.GotScraper.My.Resources.Resources.Nintendo_Logo_bordo
        Me.UltraLabelApplicationTitle.Appearance = Appearance5
        Me.UltraLabelApplicationTitle.Font = New System.Drawing.Font("Perpetua", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabelApplicationTitle.Location = New System.Drawing.Point(208, 3)
        Me.UltraLabelApplicationTitle.Name = "UltraLabelApplicationTitle"
        Me.UltraLabelApplicationTitle.Size = New System.Drawing.Size(204, 46)
        Me.UltraLabelApplicationTitle.TabIndex = 3
        Me.UltraLabelApplicationTitle.Text = " GotScraper"
        '
        'Timer2
        '
        '
        'UltraPanel2
        '
        '
        'UltraPanel2.ClientArea
        '
        Me.UltraPanel2.ClientArea.Controls.Add(Me.UltraFormattedLinkLabel1)
        Me.UltraPanel2.Location = New System.Drawing.Point(418, 70)
        Me.UltraPanel2.Name = "UltraPanel2"
        Me.UltraPanel2.Size = New System.Drawing.Size(130, 100)
        Me.UltraPanel2.TabIndex = 9
        '
        'SplashScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 428)
        Me.ControlBox = False
        Me.Controls.Add(Me.UltraPanel1)
        Me.Font = New System.Drawing.Font("Perpetua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.PerformLayout()
        Me.UltraPanel1.ResumeLayout(False)
        Me.UltraPanel2.ClientArea.ResumeLayout(False)
        Me.UltraPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraLabelCopyright As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraButtonInsertCoin As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabelApplicationTitle As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabelVersion As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraFormattedLinkLabel1 As Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents UltraPanel2 As Infragistics.Win.Misc.UltraPanel
End Class
