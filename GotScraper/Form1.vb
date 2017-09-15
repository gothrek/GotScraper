Imports System.IO
Imports System.Net
Imports System.Xml
Imports Newtonsoft.Json

Public Class Form1
    Dim fileXML_name As String = "gamelist.xml" 'nome di default della piattaforma recalbox
    Dim fileXML_path As String = "" 'UltraStatusBar1.Panels("Directory").Text 'directory di default del file XML 
    Dim images_path As String = "" 'UltraStatusBar1.Panels("Directory").Text & "\downloaded_images" 'directory di default della piattaforma recalbox
    Dim rom_path As String = "" 'UltraStatusBar1.Panels("Directory").Text 'directory delle rom su cui è stata fatta la scansione 
    Dim filelog_name As String = "log.txt" 'nome del file di log
    Dim fileini_name As String = "config.ini" 'nome del file di configurazione del programma

    Public Function GetCRC32(ByVal sFileName As String) As String
        Try
            Dim FS As FileStream = New FileStream(sFileName, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
            Dim CRC32Result As Integer = &HFFFFFFFF
            Dim Buffer(4096) As Byte
            Dim ReadSize As Integer = 4096
            Dim Count As Integer = FS.Read(Buffer, 0, ReadSize)
            Dim CRC32Table(256) As Integer
            Dim DWPolynomial As Integer = &HEDB88320
            Dim DWCRC As Integer
            Dim i As Integer, j As Integer, n As Integer

            'Create CRC32 Table
            For i = 0 To 255
                DWCRC = i
                For j = 8 To 1 Step -1
                    If (DWCRC And 1) Then
                        DWCRC = ((DWCRC And &HFFFFFFFE) \ 2&) And &H7FFFFFFF
                        DWCRC = DWCRC Xor DWPolynomial
                    Else
                        DWCRC = ((DWCRC And &HFFFFFFFE) \ 2&) And &H7FFFFFFF
                    End If
                Next j
                CRC32Table(i) = DWCRC
            Next i

            'Calcualting CRC32 Hash
            Do While (Count > 0)
                For i = 0 To Count - 1
                    n = (CRC32Result And &HFF) Xor Buffer(i)
                    CRC32Result = ((CRC32Result And &HFFFFFF00) \ &H100) And &HFFFFFF
                    CRC32Result = CRC32Result Xor CRC32Table(n)
                Next i
                Count = FS.Read(Buffer, 0, ReadSize)
            Loop
            Return Hex(Not (CRC32Result))
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function CercaArcadeDatabase(ByVal sFileName As String) As String
        Dim strReq As String = "" 'Testo della richiesta/query
        Dim strData As String = "" 'Testo recuperato dalla richiesta
        Dim dataStream As Stream
        Dim reader As StreamReader
        Dim request As WebRequest
        Dim response As WebResponse

        Dim query As String = "query_mame&game_name="
        Dim lingua As String = "it"

        If UltraRadioButtonGroupManager1.SelectedRadioButton.Text = "Inglese" Then
            lingua = "en"
        End If

        strReq = "http://adb.arcadeitalia.net/service_scraper.php?ajax=" & query & sFileName & "&lang=" & lingua
        'strReq = "http://www.progettoemma.net/index.php?gioco=4dwarrio"
        request = WebRequest.Create(strReq)
        response = request.GetResponse()
        dataStream = response.GetResponseStream()
        reader = New StreamReader(dataStream)
        strData = reader.ReadToEnd()
        CercaArcadeDatabase = strData
        reader.Close()
        response.Close()
    End Function

    Private Sub createNodoJSON(ByVal stringa As Newtonsoft.Json.Linq.JObject, ByVal scrivi As XmlTextWriter, ByVal sito As String, ByVal url_images As String)

        scrivi.WriteStartElement("game")
        scrivi.WriteAttributeString("id", stringa.Item("result").Item(0).Item("emulator_id").ToString & " - " & stringa.Item("result").Item(0).Item("game_name").ToString)
        scrivi.WriteAttributeString("source", sito)
        scrivi.WriteStartElement("path")
        scrivi.WriteString("./" & stringa.Item("result").Item(0).Item("game_name").ToString & ".zip")
        scrivi.WriteEndElement()
        scrivi.WriteStartElement("name")
        scrivi.WriteString(stringa.Item("result").Item(0).Item("title").ToString)
        scrivi.WriteEndElement()
        scrivi.WriteStartElement("desc")
        scrivi.WriteString(stringa.Item("result").Item(0).Item("history").ToString & " " & stringa.Item("result").Item(0).Item("history_copyright_short").ToString)
        scrivi.WriteEndElement()
        scrivi.WriteStartElement("image")

        Try
            Dim Client As New WebClient

            Client.DownloadFile(url_images & stringa.Item("result").Item(0).Item("game_name").ToString & ".png", images_path & "/" & stringa.Item("result").Item(0).Item("game_name").ToString & ".png")
            Client.Dispose()
            scrivi.WriteString("./downloaded_images/" & stringa.Item("result").Item(0).Item("game_name").ToString & ".png")
        Catch ex As Exception
            'TODO se non trovato creare immagine standard

        End Try

        scrivi.WriteEndElement()
        scrivi.WriteStartElement("rating")

        Try
            scrivi.WriteString(Int(stringa.Item("result").Item(0).Item("rate").ToString) / 100)
        Catch ex As Exception
            scrivi.WriteString(stringa.Item("result").Item(0).Item("rate").ToString)
        End Try

        scrivi.WriteEndElement()
        scrivi.WriteStartElement("releasedate")
        scrivi.WriteString(stringa.Item("result").Item(0).Item("year").ToString & "0101T000000")
        scrivi.WriteEndElement()
        scrivi.WriteStartElement("developer")
        scrivi.WriteString(stringa.Item("result").Item(0).Item("manufacturer").ToString)
        scrivi.WriteEndElement()
        scrivi.WriteStartElement("publisher")
        'scrivi.WriteString(pCode)
        scrivi.WriteEndElement()
        scrivi.WriteStartElement("genre")
        scrivi.WriteString(stringa.Item("result").Item(0).Item("genre").ToString)
        scrivi.WriteEndElement()
        scrivi.WriteStartElement("players")

        Try
            scrivi.WriteString(Int(stringa.Item("result").Item(0).Item("players").ToString))
        Catch ex As Exception
            scrivi.WriteString(stringa.Item("result").Item(0).Item("players").ToString)
        End Try

        scrivi.WriteEndElement()
        scrivi.WriteStartElement("region")
        scrivi.WriteString(stringa.Item("result").Item(0).Item("languages").ToString)
        scrivi.WriteEndElement()
        scrivi.WriteEndElement()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Caricamento dati da file config.ini

        Dim fs As FileStream = Nothing
        Dim INI As FileIni

        If Not File.Exists(fileini_name) Then
            fs = File.Create(fileini_name)
            fs.Close()

            INI = New FileIni(fileini_name)
            INI.Carica()

            INI.Add(New Sezione("Path RecalBox", "Configurazione RecalBox"))

            With INI.Last
                .Add(New Parametro("Path", "C:\"))
                .Add(New Parametro("FileXML", fileXML_name))
            End With

            INI.Salva()

        End If

        INI = New FileIni(fileini_name)
        INI.Carica()

        UltraStatusBar1.Panels("Directory").Text = INI.GetSezioneByNome("Path RecalBox").GetParametroByNome("Path").Valore

        If UltraStatusBar1.Panels("Directory").Text <> "" Then
            UltraButtonScan.Enabled = True
        Else
            UltraButtonScan.Enabled = False
        End If

    End Sub

    Private Sub UltraButtonDirectory_Click(sender As Object, e As EventArgs) Handles UltraButtonDirectory.Click
        Dim cartella As String = ""
        Dim INI = New FileIni(fileini_name)

        INI.Carica()

        FolderBrowserDialog1.ShowDialog()

        cartella = FolderBrowserDialog1.SelectedPath
        UltraStatusBar1.Panels("Directory").Text = cartella

        If UltraStatusBar1.Panels("Directory").Text <> "" Then
            UltraButtonScan.Enabled = True
        Else
            UltraButtonScan.Enabled = False
        End If

        INI.GetSezioneByNome("Path RecalBox").GetParametroByNome("Path").Valore = cartella
        INI.Salva()

    End Sub

    Private Sub UltraButtonScan_Click(sender As Object, e As EventArgs) Handles UltraButtonScan.Click

        Dim sito As String = "ArcadeDataBase"
        Dim url_images As String = "http://adb.arcadeitalia.net/media/mame.current/ingames/"

        Dim sw As StreamWriter
        Dim fs As FileStream = Nothing

        Dim game As String = ""
        Dim info As String = ""

        Dim crc32 As String = ""
        Dim contatore As Integer = 0
        Dim contatoreScartati As Integer = 0

        fileXML_path = UltraStatusBar1.Panels("Directory").Text 'directory di default del file XML 
        images_path = UltraStatusBar1.Panels("Directory").Text & "\downloaded_images" 'directory di default della piattaforma recalbox
        rom_path = UltraStatusBar1.Panels("Directory").Text 'directory delle rom su cui è stata fatta la scansione 

        Try 'se non esiste la directory delle immagini la creiamo
            Directory.CreateDirectory(images_path)
        Catch ex As Exception
            MsgBox("Errore durante la creazione della directory!!", MsgBoxStyle.Critical)
        End Try

        Try 'se esite un file di log lo cancelliamo
            File.Delete(filelog_name)
        Catch ex As Exception

        End Try

        fs = File.Create(filelog_name)
        fs.Close()
        sw = File.AppendText(filelog_name)

        Dim inizio As DateTime = Now

        Dim Scrivi As New XmlTextWriter(fileXML_path & "\" & fileXML_name, System.Text.Encoding.UTF8)

        Scrivi.WriteStartDocument(True)
        Scrivi.Formatting = System.Xml.Formatting.Indented
        Scrivi.Indentation = 2
        Scrivi.WriteStartElement("gameList")

        For Each file As String In Directory.GetFiles(rom_path)

            game = file.Substring(rom_path.Length + 1, file.Length - rom_path.Length - 5)
            UltraStatusBar1.Panels("Directory").Text = game
            UltraStatusBar1.Refresh()

            info = CercaArcadeDatabase(game)

            Dim dati As Newtonsoft.Json.Linq.JObject = JsonConvert.DeserializeObject(Of Object)(info)

            If dati.Item("result").Count >= 1 Then
                crc32 = GetCRC32(file)

                sw.WriteLine(game & ".zip - " & crc32 & " - " & info)
                contatore += 1

                'TODO check crc32
                createNodoJSON(dati, Scrivi, sito, url_images)

            Else
                game = file.Substring(rom_path.Length + 1, file.Length - rom_path.Length - 1)
                sw.WriteLine(game & " - Fallito")
                contatoreScartati += 1
            End If
        Next

        Dim fine As DateTime = Now

        sw.Close()

        Scrivi.WriteEndElement()
        Scrivi.WriteEndDocument()
        Scrivi.Close()

        UltraStatusBar1.Panels("Directory").Text = rom_path
        UltraStatusBar1.Refresh()

        MsgBox("Scansione terminata! Elementi individuati:" & contatore & " in " & fine.Subtract(inizio).Minutes * 60 + fine.Subtract(inizio).Seconds & " secondi, con " & contatoreScartati & " anomalie.")
    End Sub

End Class
