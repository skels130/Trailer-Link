
Imports System.Collections.Generic
Imports System.Linq
Imports System.Collections
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions


'******************************************************************************
' * Free ASP.net IMDb Scraper API for the new IMDb Template.
' * Author: Abhinay Rathore
' * Website: http://www.AbhinayRathore.com
' * Blog: http://web3o.blogspot.com
' * More Info: http://web3o.blogspot.com/2010/11/aspnetc-imdb-scraping-api.html
' * Last Updated: Feb 20, 2013
' ******************************************************************************


Namespace IMDb_Scraper
    Public Class IMDb
        Public Property status() As Boolean
            Get
                Return m_status
            End Get
            Set(value As Boolean)
                m_status = Value
            End Set
        End Property
        Private m_status As Boolean
        Public Property Id() As String
            Get
                Return m_Id
            End Get
            Set(value As String)
                m_Id = Value
            End Set
        End Property
        Private m_Id As String
        Public Property Title() As String
            Get
                Return m_Title
            End Get
            Set(value As String)
                m_Title = Value
            End Set
        End Property
        Private m_Title As String
        Public Property OriginalTitle() As String
            Get
                Return m_OriginalTitle
            End Get
            Set(value As String)
                m_OriginalTitle = Value
            End Set
        End Property
        Private m_OriginalTitle As String
        Public Property Year() As String
            Get
                Return m_Year
            End Get
            Set(value As String)
                m_Year = Value
            End Set
        End Property
        Private m_Year As String
        Public Property Rating() As String
            Get
                Return m_Rating
            End Get
            Set(value As String)
                m_Rating = Value
            End Set
        End Property
        Private m_Rating As String
        Public Property Genres() As ArrayList
            Get
                Return m_Genres
            End Get
            Set(value As ArrayList)
                m_Genres = Value
            End Set
        End Property
        Private m_Genres As ArrayList
        Public Property Directors() As ArrayList
            Get
                Return m_Directors
            End Get
            Set(value As ArrayList)
                m_Directors = Value
            End Set
        End Property
        Private m_Directors As ArrayList
        Public Property Writers() As ArrayList
            Get
                Return m_Writers
            End Get
            Set(value As ArrayList)
                m_Writers = Value
            End Set
        End Property
        Private m_Writers As ArrayList
        Public Property Cast() As ArrayList
            Get
                Return m_Cast
            End Get
            Set(value As ArrayList)
                m_Cast = Value
            End Set
        End Property
        Private m_Cast As ArrayList
        Public Property Producers() As ArrayList
            Get
                Return m_Producers
            End Get
            Set(value As ArrayList)
                m_Producers = Value
            End Set
        End Property
        Private m_Producers As ArrayList
        Public Property Musicians() As ArrayList
            Get
                Return m_Musicians
            End Get
            Set(value As ArrayList)
                m_Musicians = Value
            End Set
        End Property
        Private m_Musicians As ArrayList
        Public Property Cinematographers() As ArrayList
            Get
                Return m_Cinematographers
            End Get
            Set(value As ArrayList)
                m_Cinematographers = Value
            End Set
        End Property
        Private m_Cinematographers As ArrayList
        Public Property Editors() As ArrayList
            Get
                Return m_Editors
            End Get
            Set(value As ArrayList)
                m_Editors = Value
            End Set
        End Property
        Private m_Editors As ArrayList
        Public Property MpaaRating() As String
            Get
                Return m_MpaaRating
            End Get
            Set(value As String)
                m_MpaaRating = Value
            End Set
        End Property
        Private m_MpaaRating As String
        Public Property ReleaseDate() As String
            Get
                Return m_ReleaseDate
            End Get
            Set(value As String)
                m_ReleaseDate = Value
            End Set
        End Property
        Private m_ReleaseDate As String
        Public Property Plot() As String
            Get
                Return m_Plot
            End Get
            Set(value As String)
                m_Plot = Value
            End Set
        End Property
        Private m_Plot As String
        Public Property PlotKeywords() As ArrayList
            Get
                Return m_PlotKeywords
            End Get
            Set(value As ArrayList)
                m_PlotKeywords = Value
            End Set
        End Property
        Private m_PlotKeywords As ArrayList
        Public Property Poster() As String
            Get
                Return m_Poster
            End Get
            Set(value As String)
                m_Poster = Value
            End Set
        End Property
        Private m_Poster As String
        Public Property PosterLarge() As String
            Get
                Return m_PosterLarge
            End Get
            Set(value As String)
                m_PosterLarge = Value
            End Set
        End Property
        Private m_PosterLarge As String
        Public Property PosterFull() As String
            Get
                Return m_PosterFull
            End Get
            Set(value As String)
                m_PosterFull = Value
            End Set
        End Property
        Private m_PosterFull As String
        Public Property Runtime() As String
            Get
                Return m_Runtime
            End Get
            Set(value As String)
                m_Runtime = Value
            End Set
        End Property
        Private m_Runtime As String
        Public Property Top250() As String
            Get
                Return m_Top250
            End Get
            Set(value As String)
                m_Top250 = Value
            End Set
        End Property
        Private m_Top250 As String
        Public Property Oscars() As String
            Get
                Return m_Oscars
            End Get
            Set(value As String)
                m_Oscars = Value
            End Set
        End Property
        Private m_Oscars As String
        Public Property Awards() As String
            Get
                Return m_Awards
            End Get
            Set(value As String)
                m_Awards = Value
            End Set
        End Property
        Private m_Awards As String
        Public Property Nominations() As String
            Get
                Return m_Nominations
            End Get
            Set(value As String)
                m_Nominations = Value
            End Set
        End Property
        Private m_Nominations As String
        Public Property Storyline() As String
            Get
                Return m_Storyline
            End Get
            Set(value As String)
                m_Storyline = Value
            End Set
        End Property
        Private m_Storyline As String
        Public Property Tagline() As String
            Get
                Return m_Tagline
            End Get
            Set(value As String)
                m_Tagline = Value
            End Set
        End Property
        Private m_Tagline As String
        Public Property Votes() As String
            Get
                Return m_Votes
            End Get
            Set(value As String)
                m_Votes = Value
            End Set
        End Property
        Private m_Votes As String
        Public Property Languages() As ArrayList
            Get
                Return m_Languages
            End Get
            Set(value As ArrayList)
                m_Languages = Value
            End Set
        End Property
        Private m_Languages As ArrayList
        Public Property Countries() As ArrayList
            Get
                Return m_Countries
            End Get
            Set(value As ArrayList)
                m_Countries = Value
            End Set
        End Property
        Private m_Countries As ArrayList
        Public Property ReleaseDates() As ArrayList
            Get
                Return m_ReleaseDates
            End Get
            Set(value As ArrayList)
                m_ReleaseDates = Value
            End Set
        End Property
        Private m_ReleaseDates As ArrayList
        Public Property MediaImages() As ArrayList
            Get
                Return m_MediaImages
            End Get
            Set(value As ArrayList)
                m_MediaImages = Value
            End Set
        End Property
        Private m_MediaImages As ArrayList
        Public Property RecommendedTitles() As ArrayList
            Get
                Return m_RecommendedTitles
            End Get
            Set(value As ArrayList)
                m_RecommendedTitles = Value
            End Set
        End Property
        Private m_RecommendedTitles As ArrayList

        Public Property ImdbURL() As String
            Get
                Return m_ImdbURL
            End Get
            Set(value As String)
                m_ImdbURL = Value
            End Set
        End Property
        Private m_ImdbURL As String

        'Search Engine URLs
        'Private GoogleSearch As String = "https://www.google.com/search?q=imdb+"
        Private GoogleSearch As String = "https://www.google.com/search?q=site:http://www.hd-trailers.net+"
        Private BingSearch As String = "http://www.bing.com/search?q=site:http://www.hd-trailers.net+"
        Private AskSearch As String = "http://www.ask.com/web?q=site:http://www.hd-trailers.net+"

        'Constructor
        Public Sub New(MovieName As String, Optional GetExtraInfo As Boolean = True)
            Dim imdbUrl As String = getIMDbUrl(System.Uri.EscapeUriString(MovieName))
            status = False

            If Not String.IsNullOrEmpty(imdbUrl) Then
                parseIMDbPage(imdbUrl, GetExtraInfo)
            End If
        End Sub

        'Get IMDb URL from search results
        Private Function getIMDbUrl(MovieName As String, Optional searchEngine As String = "google") As String
            Dim url As String = GoogleSearch & MovieName
            'default to Google search
            If searchEngine.ToLower().Equals("bing") Then
                url = BingSearch & MovieName
            End If
            If searchEngine.ToLower().Equals("ask") Then
                url = AskSearch & MovieName
            End If
            Dim html As String = getUrlData(url)





            Dim imdbUrls As ArrayList = matchAll("(http://www.hd-trailers.net/movie/.+?/).+?/", html)

            'Console.WriteLine(DirectCast(imdbUrls(0), String))

            If imdbUrls.Count > 0 Then
                Return DirectCast(imdbUrls(0), String)
                'return first IMDb result
            ElseIf searchEngine.ToLower().Equals("google") Then
                'if Google search fails
                Return getIMDbUrl(MovieName, "bing")
                'search using Bing
            ElseIf searchEngine.ToLower().Equals("bing") Then
                'if Bing search fails
                Return getIMDbUrl(MovieName, "ask")
            Else
                'search using Ask
                'search fails
                Return String.Empty
            End If
        End Function

        'Parse IMDb page data
        Private Sub parseIMDbPage(imdbUrl__1 As String, GetExtraInfo As Boolean)

            ImdbURL = imdbUrl__1



        End Sub

        'Get all release dates
        Private Function getReleaseDates() As ArrayList
            Dim list As New ArrayList()
            Dim releasehtml As String = getUrlData("http://www.imdb.com/title/" & Id & "/releaseinfo")
            For Each r As String In matchAll("<tr>(.*?)</tr>", match("Date</th></tr>\n*?(.*?)</table>", releasehtml))
                Dim rd As Match = New Regex("<td>(.*?)</td>\n*?.*?<td align=""right"">(.*?)</td>", RegexOptions.Multiline).Match(r)
                list.Add(StripHTML(rd.Groups(1).Value.Trim()) & " = " & StripHTML(rd.Groups(2).Value.Trim()))
            Next
            Return list
        End Function

        'Get all media images
        Private Function getMediaImages() As ArrayList
            Dim list As New ArrayList()
            Dim mediaurl As String = "http://www.imdb.com/title/" & Id & "/mediaindex"
            Dim mediahtml As String = getUrlData(mediaurl)
            Dim pagecount As Integer = matchAll("<a href=""\?page=(.*?)"">", match("<span style=""padding: 0 1em;"">(.*?)</span>", mediahtml)).Count
            For p As Integer = 1 To pagecount + 1
                mediahtml = getUrlData(mediaurl & "?page=" & p)
                For Each m As Match In New Regex("src=""(.*?)""", RegexOptions.Multiline).Matches(match("<div class=""thumb_list"" style=""font-size: 0px;"">(.*?)</div>", mediahtml))
                    Dim image As [String] = m.Groups(1).Value
                    list.Add(Regex.Replace(image, "_V1\..*?.jpg", "_V1._SY0.jpg"))
                Next
            Next
            Return list
        End Function

        'Get Recommended Titles
        Private Function getRecommendedTitles() As ArrayList
            Dim list As New ArrayList()
            Dim recUrl As String = "http://www.imdb.com/widget/recommendations/_ajax/get_more_recs?specs=p13nsims%3A" & Id
            Dim json As String = getUrlData(recUrl)
            list = matchAll("title=\\""(.*?)\\""", json)
            Dim [set] As HashSet(Of [String]) = New HashSet(Of String)()
            For Each rec As [String] In list
                [set].Add(rec)
            Next
            Return New ArrayList([set].ToList())
        End Function

        '******************************[ Helper Methods ]*******************************


        'Match single instance
        Private Function match(regex As String, html As String, Optional i As Integer = 1) As String
            Return New Regex(regex, RegexOptions.Multiline).Match(html).Groups(i).Value.Trim()
        End Function

        'Match all instances and return as ArrayList
        Private Function matchAll(regex As String, html As String, Optional i As Integer = 1) As ArrayList
            Dim list As New ArrayList()
            For Each m As Match In New Regex(regex, RegexOptions.Multiline).Matches(html)
                list.Add(m.Groups(i).Value.Trim())
            Next
            Return list
        End Function

        'Strip HTML Tags
        Private Shared Function StripHTML(inputString As String) As String
            Return Regex.Replace(inputString, "<.*?>", String.Empty)
        End Function

        'Get URL Data
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
    End Class
End Namespace