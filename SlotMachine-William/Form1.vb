
Imports System.IO
Public Class Form1

    Const strPrefix As String = "\images\" 'Points to images
    Const strSuffix As String = ".png"
    Dim objRandom As Random = New Random
    Dim counter As Integer
    Dim intPic1, intPic2, intPic3 As Integer
    Dim StoryMessageBox As CustomMessageBox1 ' Custom Message Box - Story
    Dim RulesMessageBox As CustomMessageBox2  'Custom Message Box - Rules
    Dim Music As Integer ' Variable to Control Music



    Private Sub Roll(ByVal die As PictureBox, ByRef intPic As Integer)

        Dim intFace As Integer = objRandom.Next(1, 8) 'Roll from 7 - Can be increased if game feels too easy
        die.Image = Image.FromFile(Directory.GetCurrentDirectory & _
               strPrefix & intFace & strSuffix) ' Locate the Images
        intPic = intFace
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        
        If counter < 15 Then
            Roll(PicCard1, intPic1)
        End If
        If counter < 30 Then
            Roll(PicCard2, intPic2)
        End If
        If counter < 45 Then
            Roll(PicCard3, intPic3)  ' Row 1
        End If
        If counter >= 44 Then
            WageButton.Enabled = True
            WagerAllButton.Enabled = True
            RestartButton.Enabled = True  'Enable Wage/Wager All and Restart Buttons After Spinning stops
            AllyBox3.Enabled = True 'Turn Medli back on after Spin
            CheatBox.Enabled = True ' Turn Cheat back on after Spin
        End If

        counter += 1 'Counter

        If counter >= 45 Then
            Timer1.Enabled = False

            If (intPic1 = intPic2) And (intPic2 = intPic3) Then

                WinAmountLabel.Text = CDec(WAmountLabel.Text) * 5 ' Jackpot hit
                MAmountLabel.Text = CDec(MAmountLabel.Text) + CDec(WinAmountLabel.Text) ' Add Winnings to Money
                WAmountLabel.Text = 0
                JackPotBox.ShowDialog() 'Show JackPot Box



            ElseIf (intPic1 = intPic2) Or (intPic1 = intPic3) Or (intPic2 = intPic3) Then

                WinAmountLabel.Text = CDec(WAmountLabel.Text) * 2
                MAmountLabel.Text = CDec(MAmountLabel.Text) + CDec(WinAmountLabel.Text) ' Add Winnings to Money
                WAmountLabel.Text = 0
            Else
                WAmountLabel.Text = 0
            End If
        End If


    End Sub

    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
        Dim MessageBoxStory As New CustomMessageBox1() 'Custom Story MessageBox
        Dim RulesMessageBox As New CustomMessageBox2() 'Box for Rules

        My.Computer.Audio.Play(My.Resources.Beedle, AudioPlayMode.BackgroundLoop) 'Music
        Dim ReturnDialogStory = MessageBoxStory.ShowDialog() ' Show Story Box
        If ReturnDialogStory = Windows.Forms.DialogResult.OK Then
            Dim ReturnDialogRules = RulesMessageBox.ShowDialog() ' Show Rules Box
        End If

        If ReturnDialogStory = Windows.Forms.DialogResult.OK Then  ' If OK, then load up Game
            'Enable game functions
            MAmountLabel.Text = CDec(MAmountLabel.Text) + 500 'Fill Wallet
            RestartButton.Enabled = True ' Turn on Restart
            WagerAllButton.Enabled = True 'Turn on Wager All
            WageButton.Enabled = True    ' Turn on Wagers
            StartButton.Enabled = False  'Disable Spamming start game
            AllyBox1.Visible = True ' Turn on Ally1
            AllyBox2.Visible = True ' Turn on Ally2
            AllyBox3.Visible = True ' Turn on Ally3
            MusicBox.Visible = True ' Turn on Music controls
            CheatBox.Visible = True 'Turn on Cheat Button
        End If
End Sub
    Private Sub WageButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WageButton.Click
        If MAmountLabel.Text > 0 Then
            MAmountLabel.Text = CDec(MAmountLabel.Text) - 50 'Reduce Money
            WAmountLabel.Text = CDec(WAmountLabel.Text) + 50 'Increase Wager
            WinAmountLabel.Text = 0 ' Reset Win amount display for each spin
        End If

        If MAmountLabel.Text = 0 And WAmountLabel.Text > 0 Then
            WageButton.Enabled = False And
             FightMessageBox.ShowDialog() 'Show Empty Wallet Message
        End If

        If MAmountLabel.Text = 0 And WAmountLabel.Text = 0 Then
            WageButton.Enabled = False And
            NoCreditMessageBox.ShowDialog()
        End If

        'Betting
        If WAmountLabel.Text > 0 Then
            SpinButton.Enabled = True
        End If

        If WageButton.Enabled = False Then
            WagerAllButton.Enabled = False 'Disable both buttons at once
        End If
    End Sub

    Private Sub RestartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartButton.Click

        Dim MessageBoxR As New RestartMessageBox() 'Custom Restart MessageBox
        Dim ReturnDialogResult = MessageBoxR.ShowDialog


        If ReturnDialogResult = DialogResult.Yes Then
            'Restarting the game
            MAmountLabel.Text = 500  'Add Money
            WAmountLabel.Text = 0
            WinAmountLabel.Text = 0
            WagerAllButton.Enabled = True 'Turn on Wager All
            WageButton.Enabled = True ' Turn on Wager
            AllyBox1.Visible = True ' Return Aryll
            AllyBox2.Visible = True ' Turn on Tetra
            AllyBox3.Visible = True ' Turn on Medli
            GemBox1.Visible = False  'Turn off Gems
            GemBox2.Visible = False
            GemBox3.Visible = False
        End If
    End Sub
    Private Sub SpinButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpinButton.Click
        WagerAllButton.Enabled = False 'Disable Wager All button during Spin
        WageButton.Enabled = False 'disable Wager button during A Spin
        RestartButton.Enabled = False ' Disable Restart button during Spin
        SpinButton.Enabled = False
        Timer1.Enabled = True
        counter = 0 'Counter
        AllyBox3.Enabled = False 'Disable Medli doubling Wager during Spin
        CheatBox.Enabled = False 'Disable Cheat Button During Spin
    End Sub
    Private Sub WagerAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WagerAllButton.Click
        If MAmountLabel.Text > 0 Then

            WAmountLabel.Text = CDec(WAmountLabel.Text) + CDec(MAmountLabel.Text) 'Increase Wager
            MAmountLabel.Text = CDec(MAmountLabel.Text) - CDec(MAmountLabel.Text) 'Reduce Money
            WinAmountLabel.Text = 0 ' Reset Win amount display for each spin
        End If

        If MAmountLabel.Text = 0 And WAmountLabel.Text > 0 Then
            WagerAllButton.Enabled = False And
            FightMessageBox.ShowDialog() 'Show Empty Wallet Message
        End If

        If MAmountLabel.Text = 0 And WAmountLabel.Text = 0 Then
            WagerAllButton.Enabled = False And
            NoCreditMessageBox.ShowDialog() 'Game Over Box
        End If

        'Betting
        If WAmountLabel.Text > 0 Then
            SpinButton.Enabled = True
        End If

        If WagerAllButton.Enabled = False Then
            WageButton.Enabled = False 'Disable both buttons at once
        End If
    End Sub

    Private Sub AllyBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllyBox1.Click
        If MAmountLabel.Text = 0 And WAmountLabel.Text = 0 Then 'Prevent player from getting more rupees unless broke
            Dim ReturnDialogResult = AryllAbility.ShowDialog  ' Custom Aryll Box
            If ReturnDialogResult = Windows.Forms.DialogResult.Yes Then
                AryllSuccess.ShowDialog()
                If GemBox1.Visible Or GemBox2.Visible Then
                    MAmountLabel.Text = CDec(MAmountLabel.Text) + 600 ' Add More Money if Gem Acquired
                Else
                    MAmountLabel.Text = CDec(MAmountLabel.Text) + 200 ' No Gems only gets 200 Rupees
                    
                End If
                AllyBox1.Visible = False
                WageButton.Enabled = True ' Allow for more Wagers
                WagerAllButton.Enabled = True 'Allow for more Wagers
            End If
        End If
    End Sub

    Private Sub MAmountLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MAmountLabel.Click

    End Sub

    Private Sub MAmountLabel_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MAmountLabel.TextChanged

        If CDec(MAmountLabel.Text) >= 1000 And GemBox1.Visible = False Then ' Prevent Message Box Spam
            Gem1Box.ShowDialog()     'Display Gem 1 Box
            GemBox1.Visible = True  ' Display Gem 1
        End If
        If CDec(MAmountLabel.Text) >= 2100 And GemBox2.Visible = False Then  ' Prevent Message Box Spam
            Gem2Box.ShowDialog()      ' Display Gem 2 Box
            GemBox2.Visible = True   ' Display Gem 2
        End If
        If CDec(MAmountLabel.Text) >= 3000 And GemBox3.Visible = False Then  ' Prevent Message Box Spam
            Gem3.ShowDialog()         'Display Gem 3 Box
            GemBox3.Visible = True    ' Displaye Gem 3
        End If
    End Sub

    Private Sub GemBox3_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GemBox3.VisibleChanged
        'Dim MessageString3 As String ' You've won the game section
        'Dim ReturnDialogResult As DialogResult

        If GemBox3.Visible = True Then
            WonGameBox.ShowDialog()
            'MessageString3 = "CONGRATULATIONS HERO!" & vbCrLf & "You've colleted all three gems and saved the land!....Probably. "
            'ReturnDialogResult = MessageBox.Show(MessageString3, "You've WON!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub


    Private Sub AllyBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllyBox2.Click
        If CDec(MAmountLabel.Text) > 0 And WAmountLabel.Text = 0 Then  'Prevent player from doubling wallet AFTER Wager
            Dim ReturnDialogResult = TetraAbility.ShowDialog  ' Custom Tetra Box
            If ReturnDialogResult = Windows.Forms.DialogResult.Yes Then 'Player Hit Yes
                If CDec(MAmountLabel.Text) < 500 And WAmountLabel.Text = 0 Then  ' Only Allow Player with less that 500 rupees to double
                    MAmountLabel.Text = CDec(MAmountLabel.Text) * 2 ' Double Money in Wallet
                    TetraSuccess.ShowDialog() ' Tetra Success box
                Else
                    TetraFail.ShowDialog() 'Tetra Fail Box
                End If

                AllyBox2.Visible = False ' Turn off Tetra
            End If
        End If
    End Sub

    Private Sub AllyBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllyBox3.Click

        If WAmountLabel.Text > 0 Then  'Prevent for doubling with no wager
            Dim ReturnDialogResult = MedliAbility.ShowDialog  ' Custom Medli Box
            If ReturnDialogResult = Windows.Forms.DialogResult.Yes Then  ' If Yes is Hit
                If CDec(WAmountLabel.Text) < 500 Then  ' Only Allow Wagers less than 500 can be doubled
                    WAmountLabel.Text = CDec(WAmountLabel.Text) * 2
                    MedliSuccess.ShowDialog() 'Medli Success Box
                    WageButton.Enabled = False ' Prevent any more wagers after double
                    WagerAllButton.Enabled = False ' Prevent any more wagers after the double

                Else
                    MedliFail.ShowDialog() ' Medli Fail Box
                    'MessageString9 = "Medli failed to double your wager and left after smashing her harp in anger." ' Failed Message
                    'ReturnDialogResult8 = MessageBox.Show(MessageString9, "Helping Hand", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
                AllyBox3.Visible = False ' Turn off Medli
            End If

        End If

    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Confirm closing on program
        Dim ReturnDialogResult As DialogResult
        Dim MessageString As String

        MessageString = "Exit program?"
        ReturnDialogResult = MessageBox.Show(MessageString, "Exit program", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If ReturnDialogResult = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub WinningsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WinningsToolStripMenuItem.Click
        Winnings.ShowDialog() ' Winnings Box
        End Sub

    Private Sub LegalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LegalToolStripMenuItem.Click
        MessageBox.Show("This is only a fan made project for a class assignment." & vbCrLf & "Everything Zelda belongs to Nintendo." & vbCrLf &
                         " " & vbCrLf &
                        "Big Thanks to the Zelda Community that uploaded so many Zelda images online.", "Legal", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub CreatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreatorToolStripMenuItem.Click

        MessageBox.Show("This program was created by William Ulloa for a Visual-Programming class project." & vbCrLf &
                                                            "                            03/27/14", "Creator", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub HowtoPlayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowtoPlayToolStripMenuItem.Click
        CustomMessageBox2.ShowDialog() 'Show Rules
    End Sub

    Private Sub AlliesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlliesToolStripMenuItem.Click
        Allies.ShowDialog() ' Allies Box

    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub


    Private Sub MusicBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MusicBox.Click
        Music += 1 ' See Dr.Ngatchou, I was paying attention

        If Music = 1 Then
            My.Computer.Audio.Stop() 'Turn Music off
        End If
        If Music = 2 Then
            My.Computer.Audio.Play(My.Resources.Beedle, AudioPlayMode.BackgroundLoop) ' Turn Music back ON
        End If

        If Music = 2 Then  ' Keep N within 1 and 2
            Music = 0
        End If
    End Sub

    Private Sub CheatBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheatBox.Click
        MAmountLabel.Text = CDec(MAmountLabel.Text) + 1000 ' Free Money
    End Sub
End Class
