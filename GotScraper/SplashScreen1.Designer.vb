<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraLabelApplicationTitle = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraButtonInsertCoin = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabelCopyright = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabelVersion = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'UltraPanel1
        '
        Appearance1.ImageBackground = Global.GotScraper.My.Resources.Resources.BarTop
        Me.UltraPanel1.Appearance = Appearance1
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraLabelVersion)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraLabel2)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraLabelCopyright)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraButtonInsertCoin)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraLabelApplicationTitle)
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel1.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(622, 428)
        Me.UltraPanel1.TabIndex = 3
        '
        'UltraLabelApplicationTitle
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.White
        Me.UltraLabelApplicationTitle.Appearance = Appearance4
        Me.UltraLabelApplicationTitle.AutoSize = True
        Me.UltraLabelApplicationTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabelApplicationTitle.Location = New System.Drawing.Point(249, 12)
        Me.UltraLabelApplicationTitle.Name = "UltraLabelApplicationTitle"
        Me.UltraLabelApplicationTitle.Size = New System.Drawing.Size(137, 31)
        Me.UltraLabelApplicationTitle.TabIndex = 3
        Me.UltraLabelApplicationTitle.Text = "GotScraper"
        '
        'UltraButtonInsertCoin
        '
        Me.UltraButtonInsertCoin.Location = New System.Drawing.Point(509, 373)
        Me.UltraButtonInsertCoin.Name = "UltraButtonInsertCoin"
        Me.UltraButtonInsertCoin.Size = New System.Drawing.Size(75, 23)
        Me.UltraButtonInsertCoin.TabIndex = 4
        Me.UltraButtonInsertCoin.Text = "Insert coin"
        '
        'UltraLabelCopyright
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.White
        Me.UltraLabelCopyright.Appearance = Appearance3
        Me.UltraLabelCopyright.AutoSize = True
        Me.UltraLabelCopyright.Location = New System.Drawing.Point(228, 382)
        Me.UltraLabelCopyright.Name = "UltraLabelCopyright"
        Me.UltraLabelCopyright.Size = New System.Drawing.Size(139, 14)
        Me.UltraLabelCopyright.TabIndex = 5
        Me.UltraLabelCopyright.Text = "Copyright by Gothrek 2017"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(185, 405)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(242, 14)
        Me.UltraLabel2.TabIndex = 6
        Me.UltraLabel2.Text = "Scraping using Arcade Database by motoschifo "
        '
        'UltraLabelVersion
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.White
        Me.UltraLabelVersion.Appearance = Appearance2
        Me.UltraLabelVersion.AutoSize = True
        Me.UltraLabelVersion.Location = New System.Drawing.Point(520, 411)
        Me.UltraLabelVersion.Name = "UltraLabelVersion"
        Me.UltraLabelVersion.Size = New System.Drawing.Size(99, 14)
        Me.UltraLabelVersion.TabIndex = 7
        Me.UltraLabelVersion.Text = "Versione {0}.{1:00}"
        '
        'SplashScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 428)
        Me.ControlBox = False
        Me.Controls.Add(Me.UltraPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.PerformLayout()
        Me.UltraPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabelCopyright As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraButtonInsertCoin As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabelApplicationTitle As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabelVersion As Infragistics.Win.Misc.UltraLabel
End Class
