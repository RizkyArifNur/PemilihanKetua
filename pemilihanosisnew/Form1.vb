Imports DevExpress.XtraEditors
Public Class Form1
#Region "geser"
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler Panel1.MouseDown, AddressOf onmousepressed
        AddHandler Panel1.MouseUp, AddressOf onctlmouseup
        AddHandler Panel1.MouseMove, AddressOf ctlmousemove
    End Sub
    Private mousepressed As Boolean
    Private oldx, oldy As Integer

    Private Sub onmousepressed(sender As Object, e As MouseEventArgs)
        Dim ts As Point = Me.PointToScreen(e.Location)
        oldx = ts.X
        oldy = ts.Y
        mousepressed = True
    End Sub

    Private Sub onctlmouseup(sender As Object, e As MouseEventArgs)
        mousepressed = False
    End Sub

    Private Sub ctlmousemove(sender As Object, e As MouseEventArgs)
        If mousepressed Then
            Dim ts As Point = Me.PointToScreen(e.Location)
            Me.Location = New Point(Me.Location.X + (ts.X - oldx), Me.Location.Y + (ts.Y - oldy))
            oldx = ts.X
            oldy = ts.Y
        End If
    End Sub


#End Region
    Public usernya As String
    Public Sub awal(admin As Boolean)
        If admin Then
            TileBarItem3.Enabled = False
            TileBarItem1.Enabled = True
            TileBarItem4.Enabled = True
            TileBarItem5.Enabled = True
            NavigationFrame1.SelectedPage = NavigationPage1
        Else
            TileBarItem3.Enabled = True
            TileBarItem1.Enabled = False
            TileBarItem4.Enabled = False
            TileBarItem5.Enabled = False
            NavigationFrame1.SelectedPage = NavigationPage2
        End If
    End Sub
    Private Sub TileBarItem3_ItemClick(sender As Object, e As TileItemEventArgs) Handles TileBarItem3.ItemClick
        NavigationFrame1.SelectedPage = NavigationPage2
    End Sub

    Private Sub adminme_ItemClick(sender As Object, e As TileItemEventArgs) Handles adminme.ItemClick
        TileBar1.HideDropDownWindow()
        NavigationFrame1.SelectedPage = NavigationPage1
    End Sub

    Private Sub dtkandidat_ItemClick(sender As Object, e As TileItemEventArgs) Handles dtkandidat.ItemClick
        TileBar1.HideDropDownWindow()
        NavigationFrame1.SelectedPage = NavigationPage3
    End Sub

    Private Sub TileBarItem6_ItemClick(sender As Object, e As TileItemEventArgs) Handles TileBarItem6.ItemClick
        TileBar1.HideDropDownWindow()
        NavigationFrame1.SelectedPage = NavigationPage6
    End Sub

    Private Sub TileBarItem5_ItemClick(sender As Object, e As TileItemEventArgs) Handles TileBarItem5.ItemClick
        NavigationFrame1.SelectedPage = NavigationPage5
    End Sub

    Private Sub TileBarItem4_ItemClick(sender As Object, e As TileItemEventArgs) Handles TileBarItem4.ItemClick
        NavigationFrame1.SelectedPage = NavigationPage4
    End Sub

    Private Sub TileBarItem2_ItemClick(sender As Object, e As TileItemEventArgs) Handles TileBarItem2.ItemClick
        Me.Close()
        login.CustomHeaderTextboxMD1.TextBoxText = ""
        login.CustomHeaderTextboxMD4.TextBoxText = ""
        login.Show()
    End Sub
End Class
