' Program Name: Burger Specials 
' Developer:    Natasha Patel 
' Date:         02/18/24
' Purpose       For user to have a burger selection 



Public Class frmBurgers
    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        ' Change Pictures and Select button on click 
        picPrime.Visible = True
        picVeggie.Visible = False
        btnSelectMeal.Enabled = True
    End Sub

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        ' Change Pictures and select button on click 
        picVeggie.Visible = True
        picPrime.Visible = False
        btnSelectMeal.Enabled = True
    End Sub

    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        ' Shows the final confirmation and shows exit button. 
        btnPrime.Enabled = False
        btnVeggie.Enabled = False
        btnSelectMeal.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close out the program 
        Close()
    End Sub
End Class
