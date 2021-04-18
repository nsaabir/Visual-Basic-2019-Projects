'Program Name: Fitness Challenge
'Author:       Nile Saabir
'Date:         February 23, 2020
'Purpose:      The fitness Challenge program enters the weight loss
'              loss from team members for a fitness challenge. It displays each
'              weight loss value. After all weight loss values have been entered,
'              it displays the average weight loss for the team.

Option Strict On
Public Class frmFitness
    Private Sub btnWeightLoss_Click(sender As Object, e As EventArgs) Handles btnWeightLoss.Click
        'The btnWeightLoss_Click event accepts and displays up to 8 weight loss values
        'and then calculates and displays the average weight loss for the team

        'Declare and initialize variables
        Dim strWeightLoss As String
        Dim decWeightLoss As Decimal
        Dim decAverageLoss As Decimal
        Dim decTotalWeightLoss As Decimal = 0D
        Dim strInputMessage As String = "Enter the weight loss for team member"
        Dim strInputHeading As String = "WeightLoss"
        Dim strNormalMessage As String = "Enter the weight loss for team member #"
        Dim strNonNumericError As String = "Error - Enter a number for the weight loss of team member #"
        Dim strNegativeError As String = "Error - Enter a positive number for the weight ;oss of team member #"

        'Declare and initialize loop variables
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 8
        Dim intNumberOfEntries As Integer = 1

        'This loop allows the user to enter the weight loss of up to 8 team memebers.
        'The loop terminates when the user has entered 8 weight loss values or the user
        'clicks the Cancel button or the Close button in the InputBox
        strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, "")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strWeightLoss = strCancelClicked
            If IsNumeric(strWeightLoss) Then
                decWeightLoss = Convert.ToDecimal(strWeightLoss)
                If decWeightLoss > 0 Then
                    lstWeightLoss.Items.Add(decWeightLoss)
                    decTotalWeightLoss += decWeightLoss
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, "")
            End If
        Loop

        'Calculates and displays average team weight loss
        If intNumberOfEntries > 1 Then
            lblAverageLoss.Visible = True
            decAverageLoss = decTotalWeightLoss / (intNumberOfEntries - 1)
            lblAverageLoss.Text = "Average weight loss is " &
                decAverageLoss.ToString("F1") & "lbs"
        Else
            MsgBox("No weight loss value entered")
        End If

        'Disables the Weight Loss button
        btnWeightLoss.Enabled = False
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        'The mnuClear click event clears the ListBox object and hides
        'the average weight loss label.It also enables the weight Loss button

        lstWeightLoss.Items.Clear()
        lblAverageLoss.Visible = False
        btnWeightLoss.Enabled = True
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'The mnuExit click event closes the window and exits the application

        Close()
    End Sub

    Private Sub frmFitness_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
