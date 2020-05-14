Module Module1

    Sub Main()
        'Dim ts As System.IO.StreamReader
        Dim ts1 As System.IO.StreamWriter
        'ts = FileIO.FileSystem.OpenTextFileReader("D:\Projects\Anagram Solver\Java\Anagram_Solver\Source_Projects\resources\_extra_dicts\1000words.txt")
        ts1 = FileIO.FileSystem.OpenTextFileWriter("D:\xml.xml", False)
        Dim strword As String
        strword = "madhu"
        ts1.WriteLine("<GRAMMAR>")
        'While (ts.EndOfStream() = False)
        'strword = ts.ReadLine()
        For i = 97 To 122
            With ts1
                .WriteLine(vbTab + "<RULE NAME=" + """" + Chr(i) + """" + " TOPLEVEL=""ACTIVE"">")
                .WriteLine(vbTab + vbTab + "<P>" + Chr(i) + "</P>")
                .WriteLine(vbTab + "</RULE>")
            End With
        Next
        'End While
        ts1.WriteLine("</GRAMMAR>")
        ts1.Flush()
        ts1.Close()
        Dim wsh As IWshRuntimeLibrary.WshShell
        wsh.SendKeys("Ctrl Alt z")
    End Sub

End Module
