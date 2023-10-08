<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlHoloLogo = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.picbBigHololiveLogo = New System.Windows.Forms.PictureBox
        Me.picbBG = New System.Windows.Forms.PictureBox
        Me.tmrAnimateTopButton = New System.Windows.Forms.Timer(Me.components)
        Me.pnlGen1 = New System.Windows.Forms.Panel
        Me.btnAzki = New System.Windows.Forms.Button
        Me.btnRoboco = New System.Windows.Forms.Button
        Me.btnMiko = New System.Windows.Forms.Button
        Me.btnSuisei = New System.Windows.Forms.Button
        Me.btnSora = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tmrGenHoverAnimate = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.pnlHoloLogo.SuspendLayout()
        CType(Me.picbBigHololiveLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGen1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Controls.Add(Me.pnlHoloLogo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(925, 65)
        Me.Panel1.TabIndex = 0
        '
        'pnlHoloLogo
        '
        Me.pnlHoloLogo.BackColor = System.Drawing.Color.SkyBlue
        Me.pnlHoloLogo.Controls.Add(Me.Label1)
        Me.pnlHoloLogo.Controls.Add(Me.picbBigHololiveLogo)
        Me.pnlHoloLogo.Controls.Add(Me.picbBG)
        Me.pnlHoloLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlHoloLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlHoloLogo.Name = "pnlHoloLogo"
        Me.pnlHoloLogo.Size = New System.Drawing.Size(62, 65)
        Me.pnlHoloLogo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(73, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 11)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "   Home Page  "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picbBigHololiveLogo
        '
        Me.picbBigHololiveLogo.BackColor = System.Drawing.SystemColors.Control
        Me.picbBigHololiveLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picbBigHololiveLogo.Image = Global.peta.My.Resources.Resources.Hololive_Production_logo_svg
        Me.picbBigHololiveLogo.Location = New System.Drawing.Point(22, 18)
        Me.picbBigHololiveLogo.Name = "picbBigHololiveLogo"
        Me.picbBigHololiveLogo.Size = New System.Drawing.Size(155, 34)
        Me.picbBigHololiveLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbBigHololiveLogo.TabIndex = 0
        Me.picbBigHololiveLogo.TabStop = False
        '
        'picbBG
        '
        Me.picbBG.Image = Global.peta.My.Resources.Resources.rounded_corner_button_white_
        Me.picbBG.Location = New System.Drawing.Point(8, 0)
        Me.picbBG.Name = "picbBG"
        Me.picbBG.Size = New System.Drawing.Size(59, 72)
        Me.picbBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbBG.TabIndex = 1
        Me.picbBG.TabStop = False
        '
        'tmrAnimateTopButton
        '
        Me.tmrAnimateTopButton.Interval = 10
        '
        'pnlGen1
        '
        Me.pnlGen1.BackColor = System.Drawing.Color.Transparent
        Me.pnlGen1.BackgroundImage = Global.peta.My.Resources.Resources.blue_button_2
        Me.pnlGen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlGen1.Controls.Add(Me.btnAzki)
        Me.pnlGen1.Controls.Add(Me.btnRoboco)
        Me.pnlGen1.Controls.Add(Me.btnMiko)
        Me.pnlGen1.Controls.Add(Me.btnSuisei)
        Me.pnlGen1.Controls.Add(Me.btnSora)
        Me.pnlGen1.Controls.Add(Me.PictureBox1)
        Me.pnlGen1.Location = New System.Drawing.Point(22, 277)
        Me.pnlGen1.Name = "pnlGen1"
        Me.pnlGen1.Size = New System.Drawing.Size(911, 204)
        Me.pnlGen1.TabIndex = 1
        '
        'btnAzki
        '
        Me.btnAzki.BackgroundImage = Global.peta.My.Resources.Resources.azkiLogo
        Me.btnAzki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAzki.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAzki.FlatAppearance.BorderSize = 0
        Me.btnAzki.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAzki.Location = New System.Drawing.Point(677, 23)
        Me.btnAzki.Name = "btnAzki"
        Me.btnAzki.Size = New System.Drawing.Size(139, 128)
        Me.btnAzki.TabIndex = 5
        Me.btnAzki.UseVisualStyleBackColor = True
        '
        'btnRoboco
        '
        Me.btnRoboco.BackgroundImage = Global.peta.My.Resources.Resources.robocoLogo
        Me.btnRoboco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRoboco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRoboco.FlatAppearance.BorderSize = 0
        Me.btnRoboco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoboco.Location = New System.Drawing.Point(520, 23)
        Me.btnRoboco.Name = "btnRoboco"
        Me.btnRoboco.Size = New System.Drawing.Size(139, 128)
        Me.btnRoboco.TabIndex = 4
        Me.btnRoboco.UseVisualStyleBackColor = True
        '
        'btnMiko
        '
        Me.btnMiko.BackgroundImage = Global.peta.My.Resources.Resources.mikoLogo
        Me.btnMiko.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMiko.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMiko.FlatAppearance.BorderSize = 0
        Me.btnMiko.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMiko.Location = New System.Drawing.Point(365, 23)
        Me.btnMiko.Name = "btnMiko"
        Me.btnMiko.Size = New System.Drawing.Size(139, 128)
        Me.btnMiko.TabIndex = 3
        Me.btnMiko.UseVisualStyleBackColor = True
        '
        'btnSuisei
        '
        Me.btnSuisei.BackgroundImage = Global.peta.My.Resources.Resources.suiseiLogo
        Me.btnSuisei.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSuisei.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSuisei.FlatAppearance.BorderSize = 0
        Me.btnSuisei.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuisei.Location = New System.Drawing.Point(208, 23)
        Me.btnSuisei.Name = "btnSuisei"
        Me.btnSuisei.Size = New System.Drawing.Size(139, 128)
        Me.btnSuisei.TabIndex = 2
        Me.btnSuisei.UseVisualStyleBackColor = True
        '
        'btnSora
        '
        Me.btnSora.AutoSize = True
        Me.btnSora.BackgroundImage = Global.peta.My.Resources.Resources.soraLogo
        Me.btnSora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSora.FlatAppearance.BorderSize = 0
        Me.btnSora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSora.Location = New System.Drawing.Point(53, 23)
        Me.btnSora.Name = "btnSora"
        Me.btnSora.Size = New System.Drawing.Size(139, 128)
        Me.btnSora.TabIndex = 1
        Me.btnSora.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.peta.My.Resources.Resources.rounded_corner_button_white_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-44, -36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(955, 255)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-9, 78)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(860, 121)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Perpetua Titling MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(65, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 58)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Gen-0"
        '
        'tmrGenHoverAnimate
        '
        Me.tmrGenHoverAnimate.Interval = 5
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.BackgroundImage = Global.peta.My.Resources.Resources.Untitled
        Me.ClientSize = New System.Drawing.Size(925, 467)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.pnlGen1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Hololive Talents"
        Me.Panel1.ResumeLayout(False)
        Me.pnlHoloLogo.ResumeLayout(False)
        Me.pnlHoloLogo.PerformLayout()
        CType(Me.picbBigHololiveLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGen1.ResumeLayout(False)
        Me.pnlGen1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlHoloLogo As System.Windows.Forms.Panel
    Friend WithEvents picbBigHololiveLogo As System.Windows.Forms.PictureBox
    Friend WithEvents picbBG As System.Windows.Forms.PictureBox
    Friend WithEvents tmrAnimateTopButton As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlGen1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSora As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAzki As System.Windows.Forms.Button
    Friend WithEvents btnRoboco As System.Windows.Forms.Button
    Friend WithEvents btnMiko As System.Windows.Forms.Button
    Friend WithEvents btnSuisei As System.Windows.Forms.Button
    Friend WithEvents tmrGenHoverAnimate As System.Windows.Forms.Timer
End Class
