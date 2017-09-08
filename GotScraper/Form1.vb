Imports System.IO
Imports System.Net
Imports System.Xml

Public Class Form1

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

    Private Sub UltraButtonDirectory_Click(sender As Object, e As EventArgs) Handles UltraButtonDirectory.Click
        Dim cartella As String = ""

        FolderBrowserDialog1.ShowDialog()
        cartella = FolderBrowserDialog1.SelectedPath
        UltraStatusBar1.Panels("Directory").Text = cartella
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fileXML_name As String = "gamelist.xml" 'nome di default della piattaforma recalbox
        Dim images_path As String = UltraStatusBar1.Panels("Directory").Text & "\downloaded_images" 'directory di default della piattaforma recalbox
        Dim fileXML_path As String = UltraStatusBar1.Panels("Directory").Text 'directory di default del file XML 
        Dim rom_path As String = UltraStatusBar1.Panels("Directory").Text 'directory delle rom su cui è stata fatta la scansione 
        Dim filelog_name As String = "log.txt" 'nome del file di log

        Dim sw As StreamWriter
        Dim fs As FileStream = Nothing

        Dim game As String = ""
        Dim info As String = ""

        Dim crc32 As String = ""
        Dim contatore As Integer = 0
        Dim contatoreScartati As Integer = 0

        Try 'se non esiste la directory delle immagini la creiamo
            Directory.CreateDirectory(images_path)
        Catch ex As Exception

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
        Scrivi.Formatting = Formatting.Indented
        Scrivi.Indentation = 2
        Scrivi.WriteStartElement("gameList")

        For Each file As String In Directory.GetFiles(UltraStatusBar1.Panels("Directory").Text)

            game = file.Substring(rom_path.Length + 1, file.Length - rom_path.Length - 5)
            UltraStatusBar1.Panels("Directory").Text = game
            UltraStatusBar1.Refresh()

            info = CercaArcadeDatabase(game)
            If info.Chars(11) <> "]" Then
                crc32 = GetCRC32(file)

                sw.WriteLine(game & " - " & crc32 & " - " & info)
                contatore += 1

                'TODO check crc32
                'TODO comporre correttamente la stringa e i parametri
                createNodo(1, "172-32-1176", "TOSHIBA", "e-STUDIO456SE", "Multifunzione TOSHIBA a e-STUDIO456SE", True, Scrivi)

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

        MsgBox("Scansione terminata! Elementi individuati:" & contatore & " in " & fine.Subtract(inizio).Minutes * 60 + fine.Subtract(inizio).Seconds)

    End Sub

    Private Sub createNodo(ByVal pId As String, ByVal pCode As String, ByVal pMarca As String,
                              ByVal pModello As String, ByVal pDescrizione As String,
                              ByVal pOfferta As Boolean, ByVal scrivi As XmlTextWriter)

        Dim sito As String = "ArcadeDataBase"
        Dim id As String = ""

        scrivi.WriteStartElement("game id=" & id & " source=" & sito)
        scrivi.WriteStartElement("path")
        'scrivi.WriteString("./" & rom_name)
        scrivi.WriteEndElement()
        scrivi.WriteStartElement("name")
        'scrivi.WriteString(pCode)
        scrivi.WriteEndElement()
        scrivi.WriteStartElement("desc")
        'scrivi.WriteString(pMarca)
        scrivi.WriteEndElement()
        scrivi.WriteStartElement("image")
        'scrivi.WriteString(pModello)
        scrivi.WriteEndElement()
        scrivi.WriteStartElement("rating")
        'scrivi.WriteString(pDescrizione)
        scrivi.WriteEndElement()
        scrivi.WriteStartElement("releasedate")
        ' scrivi.WriteString(pOfferta)
        scrivi.WriteEndElement()
        scrivi.WriteStartElement("developer")
        'scrivi.WriteString("./" & rom_name)
        scrivi.WriteEndElement()
        scrivi.WriteStartElement("publisher")
        'scrivi.WriteString(pCode)
        scrivi.WriteEndElement()
        scrivi.WriteStartElement("genre")
        'scrivi.WriteString(pMarca)
        scrivi.WriteEndElement()
        scrivi.WriteStartElement("players")
        'scrivi.WriteString(pModello)
        scrivi.WriteEndElement()
        scrivi.WriteStartElement("region")
        'scrivi.WriteString(pDescrizione)
        scrivi.WriteEndElement()
        scrivi.WriteEndElement()
    End Sub

End Class
