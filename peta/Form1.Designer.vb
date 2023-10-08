<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnCompany = New System.Windows.Forms.Button
        Me.sideSora = New System.Windows.Forms.PictureBox
        Me.sideRushia = New System.Windows.Forms.PictureBox
        Me.btnTalent = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSchedule = New System.Windows.Forms.Button
        Me.animateButton = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sideSora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sideRushia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.peta.My.Resources.Resources.Hololive_Production_logo_svg
        Me.PictureBox1.Location = New System.Drawing.Point(295, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnCompany
        '
        Me.btnCompany.BackColor = System.Drawing.Color.Transparent
        Me.btnCompany.BackgroundImage = Global.peta.My.Resources.Resources.blue_button_2
        Me.btnCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCompany.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCompany.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCompany.FlatAppearance.BorderSize = 0
        Me.btnCompany.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCompany.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompany.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompany.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCompany.Location = New System.Drawing.Point(222, 298)
        Me.btnCompany.Name = "btnCompany"
        Me.btnCompany.Size = New System.Drawing.Size(240, 76)
        Me.btnCompany.TabIndex = 2
        Me.btnCompany.Text = "ABOUT THE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "COMPANY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnCompany.UseVisualStyleBackColor = False
        '
        'sideSora
        '
        Me.sideSora.BackColor = System.Drawing.Color.Transparent
        Me.sideSora.Image = Global.peta.My.Resources.Resources.sora2
        Me.sideSora.Location = New System.Drawing.Point(-57, 45)
        Me.sideSora.Name = "sideSora"
        Me.sideSora.Size = New System.Drawing.Size(273, 489)
        Me.sideSora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sideSora.TabIndex = 3
        Me.sideSora.TabStop = False
        '
        'sideRushia
        '
        Me.sideRushia.BackColor = System.Drawing.Color.Transparent
        Me.sideRushia.Image = CType(resources.GetObject("sideRushia.Image"), System.Drawing.Image)
        Me.sideRushia.Location = New System.Drawing.Point(642, 45)
        Me.sideRushia.Name = "sideRushia"
        Me.sideRushia.Size = New System.Drawing.Size(433, 798)
        Me.sideRushia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sideRushia.TabIndex = 4
        Me.sideRushia.TabStop = False
        '
        'btnTalent
        '
        Me.btnTalent.BackColor = System.Drawing.Color.Transparent
        Me.btnTalent.BackgroundImage = Global.peta.My.Resources.Resources.light_blue_button
        Me.btnTalent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTalent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTalent.FlatAppearance.BorderSize = 0
        Me.btnTalent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTalent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTalent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTalent.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTalent.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTalent.Location = New System.Drawing.Point(352, 184)
        Me.btnTalent.Name = "btnTalent"
        Me.btnTalent.Size = New System.Drawing.Size(233, 73)
        Me.btnTalent.TabIndex = 6
        Me.btnTalent.Text = "TALENTS"
        Me.btnTalent.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(179, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(560, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "VTuber agency from Japan that makes fans go wild, the world over!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Violet
        Me.Label2.Location = New System.Drawing.Point(345, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 37)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = """Hololive Project"""
        '
        'btnSchedule
        '
        Me.btnSchedule.BackColor = System.Drawing.Color.Transparent
        Me.btnSchedule.BackgroundImage = Global.peta.My.Resources.Resources.blue_button_2
        Me.btnSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSchedule.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSchedule.FlatAppearance.BorderSize = 0
        Me.btnSchedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchedule.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSchedule.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSchedule.Location = New System.Drawing.Point(477, 298)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(240, 76)
        Me.btnSchedule.TabIndex = 9
        Me.btnSchedule.Text = "STREAM SCHEDULE"
        Me.btnSchedule.UseVisualStyleBackColor = False
        '
        'animateButton
        '
        Me.animateButton.Interval = 5
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImage = Global.peta.My.Resources.Resources.Untitled
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(925, 467)
        Me.Controls.Add(Me.btnSchedule)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTalent)
        Me.Controls.Add(Me.btnCompany)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.sideSora)
        Me.Controls.Add(Me.sideRushia)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formMain"
        Me.Text = "Hololive Production"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sideSora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sideRushia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCompany As System.Windows.Forms.Button
    Friend WithEvents sideSora As System.Windows.Forms.PictureBox
    Friend WithEvents sideRushia As System.Windows.Forms.PictureBox
    Friend WithEvents btnTalent As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSchedule As System.Windows.Forms.Button
    Friend WithEvents animateButton As System.Windows.Forms.Timer

End Class
