Public Class CommandMap
    Private commandList As New ArrayList()

    Public Sub AddCommand(ByVal cmd As String, ByVal act As String, ByVal resp As String, ByVal rest As Boolean, ByVal ParamArray params() As String)
        If (IsNothing(SearchCommand(cmd))) Then
            Dim mn As New MapNode
            mn.Command = cmd
            mn.Action = act
            mn.Parameters = params
            mn.Response = resp
            mn.UICommand = rest

            commandList.Add(mn)
        End If
        Save()
    End Sub

    Public Sub RemoveCommand(ByVal cmd As String)
        Dim mn As New MapNode
        mn = SearchCommand(cmd)
        If Not IsNothing(mn) Then
            commandList.Remove(mn)
        End If
        Save()
    End Sub

    Public Function SearchCommand(ByVal cmd As String) As MapNode
        Dim mn As New MapNode
        For Each mn In commandList
            If mn.Command = cmd Then
                SearchCommand = mn
                Exit Function
            End If
        Next
        SearchCommand = Nothing
    End Function

    Public Sub Load()
        Dim line As String
        Dim items() As String
        If (System.IO.File.Exists(".\Commands.csv") = True) Then
            Dim fileReader As System.IO.StreamReader
            fileReader = New System.IO.StreamReader(".\Commands.csv")
            While (fileReader.EndOfStream = False)
                line = fileReader.ReadLine()
                items = Split(line, ",")
                Dim mn As New MapNode
                mn.Command = items(0)
                mn.Action = items(1)
                mn.Response = items(2)
                mn.UICommand = items(3)

                Dim list As New List(Of String)
                For i = 4 To items.Length - 1
                    list.Add(items(i))
                Next
                mn.Parameters = list.ToArray()
                commandList.Add(mn)
            End While
            fileReader.Close()
        End If
    End Sub

    Public Sub Save()
        Dim mn As MapNode
        Dim line As String
        If (System.IO.File.Exists(".\Commands.csv") = True) Then
            System.IO.File.Delete(".\Commands.csv")
        End If
        Dim fileWriter As System.IO.StreamWriter
        fileWriter = New System.IO.StreamWriter(New System.IO.FileStream(".\Commands.csv", IO.FileMode.Create))
        For Each mn In commandList
            line = mn.Command + "," + mn.Action + "," + mn.Response + "," + mn.UICommand.ToString
            For Each param In mn.Parameters
                line = line + "," + param
            Next
            fileWriter.WriteLine(line)
        Next
        fileWriter.Close()

    End Sub
End Class
