
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions

Module trailerNetDownloadGrabber

    Function getDownloadLink(movieLink As String)
        Return readData(movieLink)


    End Function

    Private Function readData(movieLink As String)
        Dim downloadLink As String = ""

        Dim html As String = getUrlData(movieLink)

        Dim bottomHTML As ArrayList = matchAll("(<table class=""bottomTable"">.+?)(</table>)", html)
        Dim subHTML As ArrayList


        Select Case True
            Case html.Contains("http://trailers.apple.com/movies") Or html.Contains("http://movietrailers.apple.com/movies")
                downloadLink = appleLink(bottomHTML(0))
                'Console.WriteLine(downloadLink & "   FINAL LINK")
               ' Console.WriteLine(bottomHTML)

               ' subHTML = matchAll("(http://trailers.apple.com/movies.+?)\.mov", bottomHTML(0))
            Case html.Contains("http://avideos.5min.com/")
                'NEED TO CODE LINK PARSER




                'call link grabber
                subHTML = matchAll("(http://avideos.5min.com/.+?)\.mp4", bottomHTML(0))
            Case Else
                'Download link failed


        End Select





        Return downloadLink

    End Function

    'function to parse out highest quality link from apple
    Private Function appleLink(html As String)
        'load possible links
        Dim possibleMatches As ArrayList = matchAll("(<a href=""http://.*?.apple.com/movies/.+?/.+?</a>)", html)

        Dim bestQuality As String = ""
        Dim qualityObtained As String = ""
        Dim returnLink As String = ""
        'test each possible link for quality. Needs cleaned up if adding quality selection.
        For Each link As String In possibleMatches

            Select Case True
                Case link.Contains("Trailer 2")
                    'Alt trailer? Not sure how to handle. 
                Case link.Contains("Trailer")
                    Select Case True
                        'test if 1080p available. 
                        Case link.Contains("1080p")
                            bestQuality = link
                            qualityObtained = "1080p"
                            'test for 720p, disregard if already higher found
                        Case link.Contains("720p")
                            If Not qualityObtained = "1080p" Then
                                bestQuality = link
                                qualityObtained = "720p"
                            End If
                            'test for 480p, disregard if already higher found.
                        Case link.Contains("480p")
                            If Not qualityObtained = "720p" Or qualityObtained = "1080p" Then
                                bestQuality = link
                                qualityObtained = "480p"
                            End If
                    End Select
                Case Else
                    bestQuality = "could not find link" 'could not find good link.
            End Select

            'Console.WriteLine(link)

        Next
        'Console.WriteLine(bestQuality)
        returnLink = matchAll("(http://.*?.apple.com/movies/.+?.mov)", bestQuality)(0)
        ' Console.WriteLine(returnLink)
        Return returnLink
    End Function


    ' function to get URL data. Borrowed from IMBD Tool. 
    Private Function getUrlData(url As String) As String
        Dim client As New WebClient()
        Dim r As New Random()
        Dim arrayRange() As Integer = {3, 4, 6, 7, 8, 9, 11, 12, 15, 16, 17, 18, 19, 20, 21, 22, 26, 28, 29, 30, 33, 34, 38, 44, 48, 55, 56, 73, 214, 215}
        'Get Ip that is in USA :)
        Dim index As Integer = r.Next(0, arrayRange.Length - 1)
        'Random IP Address
        client.Headers("X-Forwarded-For") = arrayRange(index) & "." & r.[Next](0, 255) & "." & r.[Next](0, 255) & "." & r.[Next](0, 255)
        'Random User-Agent
        client.Headers("User-Agent") = "Mozilla/" & r.[Next](3, 5) & ".0 (Windows NT " & r.[Next](3, 5) & "." & r.[Next](0, 2) & "; rv:2.0.1) Gecko/20100101 Firefox/" & r.[Next](3, 5) & "." & r.[Next](0, 5) & "." & r.[Next](0, 5)
        Dim datastream As Stream = client.OpenRead(url)
        Dim reader As New StreamReader(datastream)
        Dim sb As New StringBuilder()
        While Not reader.EndOfStream
            sb.Append(reader.ReadLine())
        End While
        Return sb.ToString()
    End Function

    'Match all instances and return as ArrayList. Borrowed from IMDB Tool
    Private Function matchAll(regex As String, html As String, Optional i As Integer = 1) As ArrayList
        Dim list As New ArrayList()
        For Each m As Match In New Regex(regex, RegexOptions.Multiline).Matches(html)
            list.Add(m.Groups(i).Value.Trim())
        Next
        Return list
    End Function







End Module
