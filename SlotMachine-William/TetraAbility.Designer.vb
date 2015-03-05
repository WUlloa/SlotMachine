<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TetraAbility
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RestartNoButton = New System.Windows.Forms.Button()
        Me.RestartYesButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.SlotMachine_William.My.Resources.Resources.Tetra1
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(111, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(91, 103)
        Me.PictureBox2.TabIndex = 55
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 34)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = """Yo! Want me to try and double your " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "current rupees in wallet?"""
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RestartNoButton
        '
        Me.RestartNoButton.DialogResult = System.Windows.Forms.DialogResult.No
        Me.RestartNoButton.Font = New System.Drawing.Font("Showcard Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartNoButton.Image = Global.SlotMachine_William.My.Resources.Resources.WindWaker
        Me.RestartNoButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RestartNoButton.Location = New System.Drawing.Point(178, 196)
        Me.RestartNoButton.Name = "RestartNoButton"
        Me.RestartNoButton.Size = New System.Drawing.Size(105, 31)
        Me.RestartNoButton.TabIndex = 56
        Me.RestartNoButton.Text = "No"
        Me.RestartNoButton.UseVisualStyleBackColor = True
        '
        'RestartYesButton
        '
        Me.RestartYesButton.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.RestartYesButton.Font = New System.Drawing.Font("Showcard Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartYesButton.Image = Global.SlotMachine_William.My.Resources.Resources.WindWaker
        Me.RestartYesButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RestartYesButton.Location = New System.Drawing.Point(30, 196)
        Me.RestartYesButton.Name = "RestartYesButton"
        Me.RestartYesButton.Size = New System.Drawing.Size(105, 31)
        Me.RestartYesButton.TabIndex = 57
        Me.RestartYesButton.Text = "Yes"
        Me.RestartYesButton.UseVisualStyleBackColor = True
        '
        'TetraAbility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.SlotMachine_William.My.Resources.Resources.Box
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(313, 242)
        Me.Controls.Add(Me.RestartNoButton)
        Me.Controls.Add(Me.RestartYesButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TetraAbility"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pirate Ways!"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RestartNoButton As System.Windows.Forms.Button
    Friend WithEvents RestartYesButton As System.Windows.Forms.Button
End Class
