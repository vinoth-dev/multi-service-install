Imports System.IO

Public Class Common

	Private Const FilePath As String = "C:\Output.txt"

	Public Shared Sub Write(ByVal message As String)
		Using fs As New FileStream(FilePath, FileMode.Append)
			Using sw As New StreamWriter(fs)
				sw.WriteLine(message)
			End Using
		End Using
	End Sub

End Class
