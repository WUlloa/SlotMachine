<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestartMessageBox
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
        Me.RestartLabel = New System.Windows.Forms.Label()
        Me.RestartYesButton = New System.Windows.Forms.Button()
        Me.RestartNoButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RestartLabel
        '
        Me.RestartLabel.AutoSize = True
        Me.RestartLabel.BackColor = System.Drawing.Color.Transparent
        Me.RestartLabel.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartLabel.ForeColor = System.Drawing.Color.Black
        Me.RestartLabel.Location = New System.Drawing.Point(81, 30)
        Me.RestartLabel.Name = "RestartLabel"
        Me.RestartLabel.Size = New System.Drawing.Size(144, 21)
        Me.RestartLabel.TabIndex = 1
        Me.RestartLabel.Text = "Restart Quest?"
        '
        'RestartYesButton
        '
        Me.RestartYesButton.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.RestartYesButton.Font = New System.Drawing.Font("Showcard Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartYesButton.Image = Global.SlotMachine_William.My.Resources.Resources.WindWaker
        Me.RestartYesButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RestartYesButton.Location = New System.Drawing.Point(28, 89)
        Me.RestartYesButton.Name = "RestartYesButton"
        Me.RestartYesButton.Size = New System.Drawing.Size(105, 31)
        Me.RestartYesButton.TabIndex = 5
        Me.RestartYesButton.Text = "Yes"
        Me.RestartYesButton.UseVisualStyleBackColor = True
        '
        'RestartNoButton
        '
        Me.RestartNoButton.DialogResult = System.Windows.Forms.DialogResult.No
        Me.RestartNoButton.Font = New System.Drawing.Font("Showcard Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartNoButton.Image = Global.SlotMachine_William.My.Resources.Resources.WindWaker
        Me.RestartNoButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RestartNoButton.Location = New System.Drawing.Point(176, 89)
        Me.RestartNoButton.Name = "RestartNoButton"
        Me.RestartNoButton.Size = New System.Drawing.Size(105, 31)
        Me.RestartNoButton.TabIndex = 0
        Me.RestartNoButton.Text = "No"
        Me.RestartNoButton.UseVisualStyleBackColor = True
        '
        'RestartMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.SlotMachine_William.My.Resources.Resources.Box
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(307, 132)
        Me.Controls.Add(Me.RestartNoButton)
        Me.Controls.Add(Me.RestartYesButton)
        Me.Controls.Add(Me.RestartLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RestartMessageBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restart Game?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RestartLabel As System.Windows.Forms.Label
    Friend WithEvents RestartYesButton As System.Windows.Forms.Button
    Friend WithEvents RestartNoButton As System.Windows.Forms.Button
End Class
