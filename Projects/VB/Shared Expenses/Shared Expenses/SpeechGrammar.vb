Public Class SpeechGrammar
    ' Constants
    Private Const grammarStartTag = "<GRAMMAR>"
    Private Const grammarEndTag = "</GRAMMAR>"
    Private Const ruleStartTag = "<RULE NAME="
    Private Const ruleEndTag = "</RULE>"
    Private Const phraseStartTag = "<P>"
    Private Const phraseEndTag = "</P>"
    Private Const optionalStartTag = "<O>"
    Private Const optionalEndTag = "</O>"
    Private Const topLevelAttr = "TOPLEVEL=""ACTIVE"">"

    Private xmlFile As String
    
    Public Property Xml() As String
        Get
            Xml = xmlFile
        End Get
        Set(ByVal value As String)
            xmlFile = value
        End Set
    End Property
    Public Sub Initialize()
        If (System.IO.File.Exists(xmlFile) = False) Then
            Dim fileWriter As System.IO.StreamWriter
            fileWriter = New System.IO.StreamWriter(New System.IO.FileStream(xmlFile, IO.FileMode.Create))
            fileWriter.WriteLine(grammarStartTag)
            fileWriter.WriteLine(grammarEndTag)
            fileWriter.Close()
        End If
    End Sub

    Public Sub AddRule(ByVal fromName As String, ByVal toName As String)
        ' Check if rule already exists.
        Dim ruleName As String = fromName + " to " + toName
        Dim bExists As Boolean
        bExists = False
        Dim srules() As String
        srules = GetRulesList()
        For index = 0 To srules.Length - 1
            If (srules(index) = ruleName) Then
                bExists = True
            End If
        Next
        If (Not bExists) Then
            Dim fileReader As New System.IO.StreamReader(xmlFile)
            Dim fileWriter As New System.IO.StreamWriter(".\temp.txt")
            While (fileReader.EndOfStream = False)
                Dim line As String
                line = fileReader.ReadLine()
                If (line <> grammarEndTag) Then
                    fileWriter.WriteLine(line)
                Else
                    fileWriter.WriteLine(vbTab + ruleStartTag + """" + ruleName + """" + " " + topLevelAttr)
                    fileWriter.WriteLine(vbTab + vbTab + optionalStartTag + "How much does" + optionalEndTag)
                    fileWriter.WriteLine(vbTab + vbTab + optionalStartTag + "How much should" + optionalEndTag)
                    fileWriter.WriteLine(vbTab + vbTab + phraseStartTag + fromName + phraseEndTag)
                    fileWriter.WriteLine(vbTab + vbTab + optionalStartTag + "owe" + optionalEndTag)
                    fileWriter.WriteLine(vbTab + vbTab + optionalStartTag + "give" + optionalEndTag)
                    fileWriter.WriteLine(vbTab + vbTab + phraseStartTag + toName + phraseEndTag)
                    fileWriter.WriteLine(vbTab + ruleEndTag)
                    fileWriter.WriteLine(line)
                End If
            End While
            fileWriter.Flush()
            fileWriter.Close()
            fileReader.Close()
            System.IO.File.Delete(xmlFile)
            System.IO.File.Move(".\temp.txt", xmlFile)
        End If
    End Sub

    Public Sub RemoveRule(ByVal ruleName As String)
        Dim fileReader As New System.IO.StreamReader(xmlFile)
        Dim fileWriter As New System.IO.StreamWriter(".\temp.txt")
        While (fileReader.EndOfStream = False)
            Dim line As String
            line = fileReader.ReadLine()
            If (Not line.Contains(ruleName)) Then
                fileWriter.WriteLine(line)
            Else
                fileReader.ReadLine()
                fileReader.ReadLine()
            End If
        End While
        fileWriter.Flush()
        fileWriter.Close()
        fileReader.Close()
        System.IO.File.Delete(xmlFile)
        System.IO.File.Move(".\temp.txt", xmlFile)
    End Sub

    Public Function GetRulesList() As String()
        Dim fileReader As New System.IO.StreamReader(xmlFile)
        Dim list As New List(Of String)
        While (fileReader.EndOfStream = False)
            Dim line As String
            line = fileReader.ReadLine()
            If (line.Contains(ruleStartTag)) Then
                line = line.Replace(ruleStartTag, "")
                line = line.Replace(topLevelAttr, "")
                line = line.Replace("""", "")
                list.Add(line.Trim())
            End If
        End While
        fileReader.Close()
        GetRulesList = list.ToArray()
    End Function
End Class
