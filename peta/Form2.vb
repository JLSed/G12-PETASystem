Public Class Form2
    Dim soraHover = False
    Dim mikoHover = False
    Dim suiseiHover = False
    Dim robocoHover = False
    Dim azkiHover = False


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = formMain.Size
        Me.Location = formMain.Location
    End Sub

    Private Sub picbBigHololiveLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picbBigHololiveLogo.Click
        Me.Close()
        formMain.Show()
        formMain.Location = Me.Location
    End Sub

    Private Sub picbBigHololiveLogo_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picbBigHololiveLogo.MouseHover
        tmrAnimateTopButton.Start()
    End Sub

    Private Sub picbBigHololiveLogo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picbBigHololiveLogo.MouseLeave
        tmrAnimateTopButton.Stop()
        picbBG.Width = 59
        pnlHoloLogo.Width = 62
        picbBigHololiveLogo.Location = New Point(22, 18)

    End Sub

    Private Sub tmrAnimateTopButton_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAnimateTopButton.Tick
        If pnlHoloLogo.Size.Width < 211 Then
            pnlHoloLogo.Width += 10
        End If
        If picbBG.Width < 201 Then
            picbBG.Width += 20
        End If
        If picbBigHololiveLogo.Location.X < 32 Then
            picbBigHololiveLogo.Left += 5
        End If
    End Sub

    Private Sub btnSora_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSora.MouseHover
        soraHover = True
        tmrGenHoverAnimate.Start()
        btnSora.Text = "Sora"
        btnSora.Font = New Font(btnSora.Font.SystemFontName, 20, FontStyle.Bold)
        btnSora.ForeColor = Color.Azure
        btnSora.TextAlign = ContentAlignment.TopCenter
    End Sub

    Private Sub btnSora_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSora.MouseLeave
        soraHover = False
        btnSora.Location = New Point(53, 23)
        tmrGenHoverAnimate.Stop()
        btnSora.Text = Nothing
    End Sub

    Private Sub btnSuisei_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuisei.MouseHover
        suiseiHover = True
        tmrGenHoverAnimate.Start()
        btnSuisei.Text = "Suisei"
        btnSuisei.Font = New Font(btnSora.Font.SystemFontName, 20, FontStyle.Bold)
        btnSuisei.ForeColor = Color.Azure
        btnSuisei.TextAlign = ContentAlignment.TopCenter
    End Sub

    Private Sub btnSuisei_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSuisei.MouseLeave
        suiseiHover = False
        btnSuisei.Location = New Point(208, 23)
        tmrGenHoverAnimate.Stop()
        btnSuisei.Text = Nothing
    End Sub

    Private Sub btnMiko_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMiko.MouseHover
        mikoHover = True
        tmrGenHoverAnimate.Start()
        btnMiko.Text = "Miko"
        btnMiko.Font = New Font(btnSora.Font.SystemFontName, 20, FontStyle.Bold)
        btnMiko.ForeColor = Color.Azure
        btnMiko.TextAlign = ContentAlignment.TopCenter
    End Sub

    Private Sub btnMiko_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMiko.MouseLeave
        mikoHover = False
        btnMiko.Location = New Point(365, 23)
        tmrGenHoverAnimate.Stop()
        btnMiko.Text = Nothing
    End Sub

    Private Sub btnRoboco_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRoboco.MouseHover
        robocoHover = True
        tmrGenHoverAnimate.Start()
        btnRoboco.Text = "Roboco"
        btnRoboco.Font = New Font(btnSora.Font.SystemFontName, 20, FontStyle.Bold)
        btnRoboco.ForeColor = Color.Azure
        btnRoboco.TextAlign = ContentAlignment.TopCenter
    End Sub

    Private Sub btnRoboco_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRoboco.MouseLeave
        robocoHover = False
        btnRoboco.Location = New Point(520, 23)
        tmrGenHoverAnimate.Stop()
        btnRoboco.Text = Nothing
    End Sub

    Private Sub btnAzki_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAzki.MouseHover
        azkiHover = True
        tmrGenHoverAnimate.Start()
        btnAzki.Text = "AZKi"
        btnAzki.Font = New Font(btnSora.Font.SystemFontName, 20, FontStyle.Bold)
        btnAzki.ForeColor = Color.Azure
        btnAzki.TextAlign = ContentAlignment.TopCenter
    End Sub

    Private Sub btnAzki_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAzki.MouseLeave
        azkiHover = False
        btnAzki.Location = New Point(677, 23)
        tmrGenHoverAnimate.Stop()
        btnAzki.Text = Nothing
    End Sub

    Private Sub tmrGenHoverAnimate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGenHoverAnimate.Tick
        If soraHover = True And btnSora.Location.Y > 16 Then
            btnSora.Top -= 1
        ElseIf suiseiHover = True And btnSuisei.Location.Y > 16 Then
            btnSuisei.Top -= 1
        ElseIf mikoHover = True And btnMiko.Location.Y > 16 Then
            btnMiko.Top -= 1
        ElseIf robocoHover = True And btnRoboco.Location.Y > 16 Then
            btnRoboco.Top -= 1
        ElseIf azkiHover = True And btnAzki.Location.Y > 16 Then
            btnAzki.Top -= 1
        End If
    End Sub

    Private Sub btnSora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSora.Click
        genZero.TabControl1.SelectedIndex = 0
        genZero.Show()
        Me.Hide()
    End Sub

    Private Sub btnSuisei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuisei.Click
        genZero.TabControl1.SelectedIndex = 1
        genZero.Show()
        Me.Hide()
    End Sub

    Private Sub btnMiko_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiko.Click
        genZero.TabControl1.SelectedIndex = 2
        genZero.Show()
        Me.Hide()
    End Sub

    Private Sub btnRoboco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoboco.Click
        genZero.TabControl1.SelectedIndex = 3
        genZero.Show()
        Me.Hide()
    End Sub

    Private Sub btnAzki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAzki.Click
        genZero.TabControl1.SelectedIndex = 4
        genZero.Show()
        Me.Hide()
    End Sub
End Class