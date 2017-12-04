
Imports Trailer_Link.IMDb_Scraper
Imports System.Threading
Imports Trailer_Link.trailerNetDownloadGrabber
Imports System.IO
Imports System.Reflection
Imports System.Configuration
Imports System.Collections.Concurrent
Imports System.Net
Imports System.Security.Permissions.FileIOPermission
'class to operate as data set in queue
Public Class movieToQueue
    Public Sub New(ByVal movieName As String, ByVal pathToFolder As String, ByVal yearPassed As String)
        Me.name = movieName
        Me.url = ""
        Me.workingDir = pathToFolder
        Me.year = yearPassed
    End Sub
    Public name As String
    Public url As String
    Public workingDir As String
    Public year As String

End Class


Module Main
#Region "multithreading"
    Private downloadHandler_Thread As Threading.Thread
    'Private Delegate Sub downloadHandler_Add_Delegate(ByVal i As Integer)

#End Region
    'declare public queue. 
    Public queuev3 As New ConcurrentQueue(Of movieToQueue)
    Sub Main()
        'queue for downloading
        ' Dim downloadQueue As New Queue()
        Dim workingDirectory As String = ConfigurationManager.AppSettings.Get("workingDirectory")


        'load args, Arguments should be submitted as movie name, movie path, movie year
        Dim args As String() = Environment.GetCommandLineArgs()


        Dim movie As New IMDb(args(1), False)
            Dim dataToQueue As New movieToQueue(args(1), args(2), args(3))
            dataToQueue.url = getDownloadLink(movie.ImdbURL)


        queuev3.Enqueue(dataToQueue)

            Console.WriteLine(queuev3.Count)



        'started to work on multithreading, but it seems to kill the downloader.

        'If downloadHandler_Thread Is Nothing Then
        'downloadHandler_Thread = New Threading.Thread(AddressOf downloadHandler)
        'downloadHandler_Thread.IsBackground = True

        'downloadHandler_Thread.Start()

        'Else

        'End If

        'Code for download handler
        downloadHandler()




    End Sub


    Sub downloadHandler()
        Console.WriteLine(queuev3.Count
                      )
        If queuev3.Count > 0 Then
            Console.WriteLine("started")
            Dim handle As movieToQueue
            Dim saveLocation As String = ""
            queuev3.TryDequeue(handle)
            Console.WriteLine("still working")
            Dim saveName As String = returnFileName(handle)
            Console.WriteLine(handle.url & "   " & handle.workingDir & "\" & saveName)
            saveLocation = handle.workingDir & "\" & saveName

            Using webC As New WebClient()






                Try
                    Console.WriteLine("starting")
                    webC.DownloadFile(handle.url, saveLocation)

                    Console.WriteLine("should have worked")
                Catch excpt As System.Exception

                    Console.WriteLine(excpt.Message & "IT FALIED ASSHOLE")
                End Try
            End Using

            Console.WriteLine("ifthentriggered")
        Else
            Console.WriteLine("if then failed")
        End If

    End Sub

    Function returnFileName(ByRef input As movieToQueue)
        Dim extension As String = ""
        Dim saveName As String = input.name & " (" & input.year & ")" & "-trailer"
        Dim returnValue As String = ""
        extension = input.url.Substring(input.url.Length - 4)
        returnValue = saveName & extension
        Return returnValue
    End Function








End Module
