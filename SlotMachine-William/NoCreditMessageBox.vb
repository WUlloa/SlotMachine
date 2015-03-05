Public Class NoCreditMessageBox

    Private Sub WalletOKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WalletOKButton.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class