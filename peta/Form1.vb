Public Class formMain
    Dim animatedGif As New PictureBox
    Dim talentHover = False
    Dim companyHover = False
    Dim scheduleHover = False

    Private Sub mainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animatedGif.SizeMode = PictureBoxSizeMode.StretchImage
        animatedGif.Image = My.Resources.holomem_en1
        animatedGif.BackColor = Color.Transparent
        Me.Controls.Add(animatedGif)
        animatedGif.Size = New Size(0, 0)
    End Sub

    Private Sub btnTalent_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTalent.MouseHover
        talentHover = True
        animatedGif.Location = New Point(381, 158)
        animatedGif.Size = New Size(173, 16)
        animatedGif.BringToFront()
        animateButton.Start()
    End Sub

    Private Sub btnTalent_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTalent.MouseLeave
        talentHover = False
        animatedGif.Size = New Size(0, 0)
        btnTalent.Location = New Point(352, 184)
        animateButton.Stop()
    End Sub

    Private Sub btnCompany_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompany.MouseHover
        companyHover = True
        animatedGif.Location = New Point(250, 270)
        animatedGif.Size = New Size(173, 16)
        animatedGif.BringToFront()
        animateButton.Start()
    End Sub

    Private Sub btnCompany_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCompany.MouseLeave
        companyHover = False
        animatedGif.Size = New Size(0, 0)
        btnCompany.Location = New Point(222, 298)
        animateButton.Stop()
    End Sub

    Private Sub btnSchedule_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchedule.MouseHover
        scheduleHover = True
        animatedGif.Location = New Point(510, 270)
        animatedGif.Size = New Size(173, 16)
        animatedGif.BringToFront()
        animateButton.Start()
    End Sub

    Private Sub btnSchedule_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSchedule.MouseLeave
        scheduleHover = False
        animatedGif.Size = New Size(0, 0)
        btnSchedule.Location = New Point(477, 298)
        animateButton.Stop()
    End Sub

    Private Sub animateButton_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles animateButton.Tick
        If animatedGif.Height < 40 Then
            animatedGif.Height += 5
        End If
        If btnTalent.Location.Y < 190 And talentHover = True Then
            btnTalent.Top += 5
        ElseIf btnCompany.Location.Y < 304 And companyHover = True Then
            btnCompany.Top += 5
        ElseIf btnSchedule.Location.Y < 304 And scheduleHover = True Then
            btnSchedule.Top += 5
        End If

    End Sub

    Private Sub btnSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchedule.Click
        Process.Start("https://schedule.hololive.tv/")
    End Sub

    Private Sub btnTalent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTalent.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompany.Click
        Process.Start("https://cover-corp.com/")
    End Sub
End Class
