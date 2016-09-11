' Joshua Pickenpaugh
' September 11th, 2016
' "Willow Health Club" calculator. 

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Declares variables:
        Dim decClientWeight As Decimal
        Dim decTotalCalories As Decimal

        'Assigns user weight to variable:
        Decimal.TryParse(txtWeight.Text, decClientWeight)

        'Decision structure:
        Select Case True
            Case rdoMale.Checked
                If rdoActive.Checked Then
                    decTotalCalories = decClientWeight * 15
                    lblTotal.Text = decTotalCalories
                ElseIf rdoInactive.CheckAlign Then
                    decTotalCalories = decClientWeight * 13
                    lblTotal.Text = decTotalCalories
                End If

            Case rdoFemale.Checked
                If rdoActive.Checked Then
                    decTotalCalories = decClientWeight * 12
                    lblTotal.Text = decTotalCalories
                ElseIf rdoInactive.Checked Then
                    decTotalCalories = decClientWeight * 10
                    lblTotal.Text = decTotalCalories
                End If
        End Select

    End Sub
End Class
