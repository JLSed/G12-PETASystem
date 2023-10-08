Public Class genZero
    Dim soraDataClicked = False
    Dim soraAboutClicked = False
    Dim suiseiDataClicked = False
    Dim suiseiAboutClicked = False
    Dim mikoDataClicked = False
    Dim mikoAboutClicked = False
    Dim robocoDataClicked = False
    Dim robocoAboutClicked = False
    Dim azkiDataClicked = False
    Dim azkiAboutClicked = False

    Private Sub genZero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = Form2.Location
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://space.bilibili.com/286179206")
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.youtube.com/channel/UCp6993wxpyDPHUpavwDFqgg")
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://twitter.com/tokino_sora")
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Process.Start("https://www.youtube.com/channel/UC5CwaMl1eIgY8h02uZw7u8A")
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Process.Start("https://space.bilibili.com/9034870")
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("https://twitter.com/suisei_hosimati")
    End Sub

    Private Sub LinkLabel9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        Process.Start("https://www.youtube.com/channel/UC-hM6YJuNYVAmUWxeIr9FeA")
    End Sub

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Process.Start("https://space.bilibili.com/366690056/")
    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Process.Start("https://twitter.com/sakuramiko35")
    End Sub

    Private Sub LinkLabel12_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        Process.Start("https://www.youtube.com/channel/UCDqI2jOz0weumE8s7paEk6g")
    End Sub

    Private Sub LinkLabel11_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        Process.Start("https://space.bilibili.com/20813493")
    End Sub

    Private Sub LinkLabel10_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        Process.Start("https://twitter.com/robocosan")
    End Sub

    Private Sub LinkLabel15_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel15.LinkClicked
        Process.Start("https://www.youtube.com/channel/UC0TXe_LYZ4scaW2XMyi5_kw")
    End Sub

    Private Sub LinkLabel13_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        Process.Start("https://twitter.com/AZKi_VDiVA")
    End Sub

    Private Sub LinkLabel14_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel14.LinkClicked
        Process.Start("https://space.bilibili.com/389056211")
    End Sub



    Private Sub lblSoraData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSoraData.Click
        soraDataClicked = True
        soraAboutClicked = False
        suiseiAboutClicked = False
        suiseiDataClicked = False
        mikoDataClicked = False
        mikoAboutClicked = False
        robocoDataClicked = False
        robocoAboutClicked = False
        azkiDataClicked = False
        azkiAboutClicked = False
        tmrAnimateInfo.Start()
        pnlAboutSora.Width = 0
        pnlSoraData.Location = New Point(9, 97)
    End Sub

    Private Sub lblSoraAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSoraAbout.Click
        soraAboutClicked = True
        soraDataClicked = False
        suiseiDataClicked = False
        suiseiAboutClicked = False
        mikoDataClicked = False
        mikoAboutClicked = False
        robocoDataClicked = False
        robocoAboutClicked = False
        azkiDataClicked = False
        azkiAboutClicked = False
        tmrAnimateInfo.Start()
        pnlSoraData.Width = 0
    End Sub

    Private Sub lblSuiseiAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSuiseiAbout.Click
        suiseiAboutClicked = True
        soraDataClicked = False
        soraAboutClicked = False
        suiseiDataClicked = False
        mikoDataClicked = False
        mikoAboutClicked = False
        robocoDataClicked = False
        robocoAboutClicked = False
        azkiDataClicked = False
        azkiAboutClicked = False
        tmrAnimateInfo.Start()
        pnlDataSuisei.Width = 0
    End Sub

    Private Sub lblSuiseiData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSuiseiData.Click
        suiseiDataClicked = True
        suiseiAboutClicked = False
        soraDataClicked = False
        soraAboutClicked = False
        mikoDataClicked = False
        mikoAboutClicked = False
        robocoDataClicked = False
        robocoAboutClicked = False
        azkiDataClicked = False
        azkiAboutClicked = False
        tmrAnimateInfo.Start()
        pnlDataSuisei.Location = New Point(9, 97)
        pnlAboutSuisei.Width = 0
    End Sub

    Private Sub lblAboutMiko_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAboutMiko.Click
        suiseiDataClicked = False
        suiseiAboutClicked = False
        soraDataClicked = False
        soraAboutClicked = False
        mikoDataClicked = False
        mikoAboutClicked = True
        robocoDataClicked = False
        robocoAboutClicked = False
        azkiDataClicked = False
        azkiAboutClicked = False
        tmrAnimateInfo.Start()
        pnlDataMiko.Width = 0
    End Sub

    Private Sub lblDataMiko_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDataMiko.Click
        suiseiDataClicked = False
        suiseiAboutClicked = False
        soraDataClicked = False
        soraAboutClicked = False
        mikoDataClicked = True
        mikoAboutClicked = False
        robocoDataClicked = False
        robocoAboutClicked = False
        azkiDataClicked = False
        azkiAboutClicked = False
        tmrAnimateInfo.Start()
        pnlDataMiko.Location = New Point(9, 97)
        pnlAboutMiko.Width = 0
    End Sub

    Private Sub lblAboutRoboco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAboutRoboco.Click
        suiseiDataClicked = False
        suiseiAboutClicked = False
        soraDataClicked = False
        soraAboutClicked = False
        mikoDataClicked = False
        mikoAboutClicked = False
        robocoDataClicked = False
        robocoAboutClicked = True
        azkiDataClicked = False
        azkiAboutClicked = False
        tmrAnimateInfo.Start()
        pnlDataRoboco.Width = 0
    End Sub

    Private Sub lblDataRoboco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDataRoboco.Click
        suiseiDataClicked = False
        suiseiAboutClicked = False
        soraDataClicked = False
        soraAboutClicked = False
        mikoDataClicked = False
        mikoAboutClicked = False
        robocoDataClicked = True
        robocoAboutClicked = False
        azkiDataClicked = False
        azkiAboutClicked = False
        tmrAnimateInfo.Start()
        pnlAboutRoboco.Width = 0
        pnlDataRoboco.Location = New Point(9, 97)
    End Sub

    Private Sub lblAboutAzki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAboutAzki.Click
        suiseiDataClicked = False
        suiseiAboutClicked = False
        soraDataClicked = False
        soraAboutClicked = False
        mikoDataClicked = False
        mikoAboutClicked = False
        robocoDataClicked = False
        robocoAboutClicked = False
        azkiDataClicked = False
        azkiAboutClicked = True
        tmrAnimateInfo.Start()
        pnlDataAzki.Width = 0
    End Sub

    Private Sub lblDataAzki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDataAzki.Click
        suiseiDataClicked = False
        suiseiAboutClicked = False
        soraDataClicked = False
        soraAboutClicked = False
        mikoDataClicked = False
        mikoAboutClicked = False
        robocoDataClicked = False
        robocoAboutClicked = False
        azkiDataClicked = True
        azkiAboutClicked = False
        tmrAnimateInfo.Start()
        pnlAboutAzki.Width = 0
        pnlDataAzki.Location = New Point(9, 97)
    End Sub

    Private Sub tmrAnimateInfo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAnimateInfo.Tick
        If soraAboutClicked = True And pnlAboutSora.Width < 600 Then
            pnlAboutSora.Width += 30
        ElseIf soraDataClicked = True And pnlSoraData.Width < 600 Then
            pnlSoraData.Width += 30
        ElseIf suiseiAboutClicked = True And pnlAboutSuisei.Width < 600 Then
            pnlAboutSuisei.Width += 30
        ElseIf suiseiDataClicked = True And pnlDataSuisei.Width < 600 Then
            pnlDataSuisei.Width += 30
        ElseIf mikoAboutClicked = True And pnlAboutMiko.Width < 600 Then
            pnlAboutMiko.Width += 30
        ElseIf mikoDataClicked = True And pnlDataMiko.Width < 600 Then
            pnlDataMiko.Width += 30
        ElseIf robocoAboutClicked = True And pnlAboutRoboco.Width < 600 Then
            pnlAboutRoboco.Width += 30
        ElseIf robocoDataClicked = True And pnlDataRoboco.Width < 600 Then
            pnlDataRoboco.Width += 30
        ElseIf azkiAboutClicked = True And pnlAboutAzki.Width < 600 Then
            pnlAboutAzki.Width += 30
        ElseIf azkiDataClicked = True And pnlDataAzki.Width < 600 Then
            pnlDataAzki.Width += 30
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        formMain.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class