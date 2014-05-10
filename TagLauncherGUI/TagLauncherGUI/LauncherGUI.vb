Public Class LauncherGUI
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub LauncherGUI_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub LauncherGUI_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub LauncherGUI_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub CloseBTN_Click(sender As Object, e As EventArgs) Handles CloseBTN.Click
        Me.Close()
    End Sub

    Private Sub MinimizeBTN_Click(sender As Object, e As EventArgs) Handles MinimizeBTN.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub OptionsBTN_Click(sender As Object, e As EventArgs) Handles OptionsBTN.Click
        OptionsGUI.Show()
    End Sub
    Private Sub CloseBTN_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBTN.MouseEnter

        CloseBTN.BackgroundImage = My.Resources.ToolBarClose_Hover

    End Sub
    Private Sub CloseBTN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBTN.MouseLeave

        CloseBTN.BackgroundImage = My.Resources.ToolBarClose

    End Sub

    Private Sub OptionsBTN_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsBTN.MouseEnter

        OptionsBTN.BackgroundImage = My.Resources.ToolBarOptions_Hover

    End Sub
    Private Sub OptionsBTN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsBTN.MouseLeave

        OptionsBTN.BackgroundImage = My.Resources.ToolBarOptions

    End Sub

    Private Sub MinimizeBTN_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeBTN.MouseEnter

        MinimizeBTN.BackgroundImage = My.Resources.ToolBarMinimize_Hover

    End Sub
    Private Sub MinimizeBTN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeBTN.MouseLeave

        MinimizeBTN.BackgroundImage = My.Resources.ToolBarMinimize

    End Sub
End Class
