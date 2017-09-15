Public Class FileIni
    Inherits List(Of Sezione)

    Private m_nomeFileCompleto As String

    Public Sub New(ByVal nomeFileCompleto As String)

        m_nomeFileCompleto = nomeFileCompleto

    End Sub

    Public Sub Carica()

        Me.Clear()
        Dim linee As String() = IO.File.ReadAllLines(m_nomeFileCompleto)
        For Each l As String In linee
            If l <> "" Then
                Select Case l.First
                    Case ";" 'Commento di Sezione
                        Me.Last.Commento = l.Replace("; ", "")

                    Case "[" 'Sezione
                        Me.Add(New Sezione(l.Replace("[", "").Replace("]", "")))

                    Case Else 'Parametro ?
                        If l.Contains("=") Then Me.Last.Add(New Parametro(l.Split("=")(0).Trim, l.Split("=")(1).Trim))
                End Select
            End If
        Next

    End Sub

    Public Sub Salva()

        If Me.Count = 0 Then Exit Sub
        Dim linee As New List(Of String)

        For Each S As Sezione In Me
            linee.Add("[" & S.Nome & "]")
            If S.Commento <> "" Then linee.Add("; " & S.Commento)
            For Each P As Parametro In S
                linee.Add(P.ToString)
            Next
            linee.Add("")
        Next

        IO.File.WriteAllLines(m_nomeFileCompleto, linee)

    End Sub

    Public Function GetSezioneByNome(ByVal nomeSezione As String) As Sezione

        For Each S As Sezione In Me
            If S.Nome = nomeSezione Then Return S
        Next
        Return Nothing

    End Function
End Class
