Imports System.Data.SqlClient

Module Module1
    Public cnn As SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public baca As SqlDataReader
    Public ttlpilih As Integer

    Public Sub buka()
        Dim pth As String
        Try
            Dim dtsrc() As String
            'dtsrc = {".\SQLEXPRESS"}
            pth = System.Reflection.Assembly.GetExecutingAssembly().Location
            dtsrc = System.IO.File.ReadAllLines(Application.StartupPath & "\setting.txt")

            cnn = New SqlConnection(String.Format("DATA SOURCE={0};Initial Catalog=pemilihanosis;User ID=rizky;password=cswxspeed;", dtsrc(0)))
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If

            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message & pth)
        End Try
    End Sub
End Module
