﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoCreditMessageBox
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
        Me.NoCreditLabel = New System.Windows.Forms.Label()
        Me.WalletOKButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoCreditLabel
        '
        Me.NoCreditLabel.AutoSize = True
        Me.NoCreditLabel.BackColor = System.Drawing.Color.Transparent
        Me.NoCreditLabel.Font = New System.Drawing.Font("Century", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoCreditLabel.ForeColor = System.Drawing.Color.Black
        Me.NoCreditLabel.Location = New System.Drawing.Point(35, 19)
        Me.NoCreditLabel.Name = "NoCreditLabel"
        Me.NoCreditLabel.Size = New System.Drawing.Size(234, 34)
        Me.NoCreditLabel.TabIndex = 3
        Me.NoCreditLabel.Text = "You're out of rupees hero and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "we don't take credit!"
        Me.NoCreditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WalletOKButton
        '
        Me.WalletOKButton.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.WalletOKButton.Font = New System.Drawing.Font("Showcard Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WalletOKButton.Image = Global.SlotMachine_William.My.Resources.Resources.WindWaker
        Me.WalletOKButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.WalletOKButton.Location = New System.Drawing.Point(95, 152)
        Me.WalletOKButton.Name = "WalletOKButton"
        Me.WalletOKButton.Size = New System.Drawing.Size(105, 31)
        Me.WalletOKButton.TabIndex = 7
        Me.WalletOKButton.Text = "OK"
        Me.WalletOKButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.SlotMachine_William.My.Resources.Resources.BeedleImage
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(118, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 64)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'NoCreditMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.SlotMachine_William.My.Resources.Resources.Box
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(295, 195)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.WalletOKButton)
        Me.Controls.Add(Me.NoCreditLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NoCreditMessageBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Over?!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NoCreditLabel As System.Windows.Forms.Label
    Friend WithEvents WalletOKButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
