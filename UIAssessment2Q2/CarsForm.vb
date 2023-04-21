Public Class CarsForm
    Private _CarLogic As CarLogic
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _CarLogic = New CarLogic()
        txtDate.Text = Today
        lblValidation.ForeColor = Color.Red
        lblValidation.Text = ""
        lbMakeModel.SelectedIndex = 0
    End Sub

    Private Sub btnDisplayChoice_Click(sender As Object, e As EventArgs) Handles btnDisplayChoice.Click
        Dim isValid = True
        lblValidation.Text = ""
        'validate phone:
        If Not String.IsNullOrEmpty(txtContactNumber.Text) And txtContactNumber.Text.Length < 7 Then
            lblValidation.Text = "phone number must be 10 characters"
            Return
        End If
        If Not String.IsNullOrEmpty(txtContactNumber.Text) And _CarLogic.CheckForNumeric(txtContactNumber.Text) = False Then
            lblValidation.Text = "phone number can only accept numbers"
            Return
        End If

        'update display:
        If isValid Then
            _CarLogic.MakeModel = lbMakeModel.SelectedItem
            _CarLogic.Year = ""
            If cb2019.Checked Then
                _CarLogic.Year += " " + cb2019.Text
            End If
            If cb2020.Checked Then
                _CarLogic.Year += " " + cb2020.Text
            End If
            If cb2021.Checked Then
                _CarLogic.Year += " " + cb2021.Text
            End If
            If cb2022.Checked Then
                _CarLogic.Year += " " + cb2022.Text
            End If
            If cb2023.Checked Then
                _CarLogic.Year += " " + cb2023.Text
            End If
            txtDisplay.Text = _CarLogic.DisplayChoice()
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton9.Click, RadioButton8.Click, RadioButton7.Click, RadioButton6.Click, RadioButton5.Click, RadioButton4.Click, RadioButton3.Click, RadioButton2.Click
        Dim radio = CType(sender, RadioButton)
        _CarLogic.Province = radio.Text
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cb2023.CheckedChanged, cb2022.CheckedChanged, cb2021.CheckedChanged, cb2020.CheckedChanged, cb2019.CheckedChanged
        Dim checkbox = CType(sender, CheckBox)
    End Sub
End Class
