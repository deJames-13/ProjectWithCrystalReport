<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _payroll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.windowWrapper = New System.Windows.Forms.Panel()
        Me.contentWrapper = New System.Windows.Forms.Panel()
        Me.contentContainer = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.pageTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.titleIcon = New System.Windows.Forms.PictureBox()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.windowWrapper.SuspendLayout()
        Me.contentWrapper.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.titleIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'windowWrapper
        '
        Me.windowWrapper.BackColor = System.Drawing.Color.Transparent
        Me.windowWrapper.Controls.Add(Me.contentWrapper)
        Me.windowWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.windowWrapper.Location = New System.Drawing.Point(0, 0)
        Me.windowWrapper.Margin = New System.Windows.Forms.Padding(0)
        Me.windowWrapper.Name = "windowWrapper"
        Me.windowWrapper.Padding = New System.Windows.Forms.Padding(20)
        Me.windowWrapper.Size = New System.Drawing.Size(984, 661)
        Me.windowWrapper.TabIndex = 6
        '
        'contentWrapper
        '
        Me.contentWrapper.Controls.Add(Me.contentContainer)
        Me.contentWrapper.Controls.Add(Me.Panel7)
        Me.contentWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentWrapper.Location = New System.Drawing.Point(20, 20)
        Me.contentWrapper.Margin = New System.Windows.Forms.Padding(0)
        Me.contentWrapper.Name = "contentWrapper"
        Me.contentWrapper.Padding = New System.Windows.Forms.Padding(5)
        Me.contentWrapper.Size = New System.Drawing.Size(944, 621)
        Me.contentWrapper.TabIndex = 8
        '
        'contentContainer
        '
        Me.contentContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentContainer.Location = New System.Drawing.Point(5, 76)
        Me.contentContainer.Name = "contentContainer"
        Me.contentContainer.Padding = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.contentContainer.Size = New System.Drawing.Size(934, 540)
        Me.contentContainer.TabIndex = 25
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.pageTitle)
        Me.Panel7.Controls.Add(Me.Panel2)
        Me.Panel7.Controls.Add(Me.Panel21)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(5, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel7.Size = New System.Drawing.Size(934, 71)
        Me.Panel7.TabIndex = 23
        '
        'pageTitle
        '
        Me.pageTitle.AutoSize = True
        Me.pageTitle.BackColor = System.Drawing.Color.Transparent
        Me.pageTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pageTitle.Font = New System.Drawing.Font("Lexend", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pageTitle.Location = New System.Drawing.Point(62, 2)
        Me.pageTitle.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.pageTitle.Name = "pageTitle"
        Me.pageTitle.Size = New System.Drawing.Size(158, 58)
        Me.pageTitle.TabIndex = 29
        Me.pageTitle.Text = "Payroll"
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.titleIcon)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(60, 64)
        Me.Panel2.TabIndex = 28
        '
        'titleIcon
        '
        Me.titleIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.titleIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.titleIcon.Image = Global.ProjectTryCrystalReport1.My.Resources.Resources.icons8_payroll_100
        Me.titleIcon.Location = New System.Drawing.Point(5, 5)
        Me.titleIcon.Name = "titleIcon"
        Me.titleIcon.Size = New System.Drawing.Size(50, 54)
        Me.titleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.titleIcon.TabIndex = 25
        Me.titleIcon.TabStop = False
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel21.Location = New System.Drawing.Point(2, 66)
        Me.Panel21.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(930, 3)
        Me.Panel21.TabIndex = 1
        '
        '_payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.windowWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "_payroll"
        Me.Text = "_payroll"
        Me.windowWrapper.ResumeLayout(False)
        Me.contentWrapper.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.titleIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents windowWrapper As Panel
    Friend WithEvents contentWrapper As Panel
    Friend WithEvents contentContainer As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents pageTitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents titleIcon As PictureBox
End Class
