Public NotInheritable Class SplashScreen1
    Dim tempo As Integer = 0

    'TODO: questo form può essere facilmente impostato come schermata iniziale per l'applicazione dalla scheda "Applicazione"
    '  di Creazione progetti (scegliere "Proprietà" dal menu "Progetto").


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Imposta il testo della finestra di dialogo in fase di esecuzione in base alle informazioni sull'assembly dell'applicazione.  

        'TODO: personalizzare le informazioni sull'assembly dell'applicazione nel riquadro "Applicazione" 
        '  della finestra delle proprietà del progetto (accessibile dal menu "Progetto").

        'Titolo dell'applicazione
        If My.Application.Info.Title <> "" Then
            UltraLabelApplicationTitle.Text = My.Application.Info.Title
        Else
            'Se il titolo dell'applicazione manca, verrà usato il nome dell'applicazione, senza l'estensione
            UltraLabelApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Formatta le informazioni sulla versione utilizzando come stringa di formattazione il testo impostato nel controllo Version in fase di esecuzione.
        '  Consente una localizzazione efficace, se necessario.
        '  Le informazioni sulla build e la revisione possono essere incluse utilizzando il codice seguente e modificando 
        '  in "Versione {0}.{1:00}.{2}.{3}", o simile, il testo del controllo Version impostato in fase di progettazione.
        '  Per ulteriori informazioni, vedere String.Format() nella Guida.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        UltraLabelVersion.Text = System.String.Format(UltraLabelVersion.Text, My.Application.Info.Version.Major, My.Application.Info.Version.MinorRevision)

        'Informazioni sul copyright
        UltraLabelCopyright.Text = My.Application.Info.Copyright

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tempo += 1
        If tempo = 2 Then
            Form1.Show()
            Me.Close()

        End If
    End Sub

    Private Sub UltraButtonInsertCoin_Click(sender As Object, e As EventArgs) Handles UltraButtonInsertCoin.Click
        Form1.Show()
        Me.Close()

    End Sub
End Class
