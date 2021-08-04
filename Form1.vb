Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblDepartment.Click, lblUsername.Click, lblPassword.Click, lblUsername.Click

    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPASSWORD.Click



        If txtUsername.Text = "Manager" And txtPASSWORD.Text = "CapeNexis" And txtUsername.Text = "Manager" Then

            TabControl1.Show()
            TabControl2.Visible = False
            GroupBox1.Visible = False
        ElseIf txtUsername.Text = "Cashier" And txtPASSWORD.Text = "CapeNexis" And txtUsername.Text = "Cashier" Then
            TabControl2.Show()
            TabControl1.Visible = False
            GroupBox1.Visible = False

        ElseIf txtUsername.Text = "Stock Controller" And txtPASSWORD.Text = "CapeNexis" And txtUsername.Text = "Stock Controller" Then
            TabControl2.Show()
            TabControl2.Visible = False
            GroupBox1.Visible = False
        Else

            MsgBox("Please Enter Your Username And Password", MsgBoxStyle.Information, "Login")

        End If
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnEXIT.Click
        Dim result = MessageBox.Show("are you sure you want to exit?", "Clossing system", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnRESET.Click
        txtPASSWORD.Clear()
        txtUsername.Clear()
    End Sub

    Private Sub CUSTOMER_DETAILSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles txtUsername.Click, TabControl1.BindingContextChanged
        Me.Validate()
        Me.CUSTOMER_DETAILSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SHOPDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SHOP_INVENTORYDataSet.CUSTOMER_DETAILS' table. You can move, or remove it, as needed.
        Me.PRODUCT_CATALOGTableAdapter.Fill(Me.SHOPDataSet.PRODUCT_CATALOG)
        'TODO: This line of code loads data into the 'SHOP_INVENTORYDataSet.CUSTOMER_DETAILS' table. You can move, or remove it, as needed.
        Me.CUSTOMER_DETAILSTableAdapter.Fill(Me.SHOPDataSet.CUSTOMER_DETAILS)


        cmbUsername.Items.Add("Manager")
        cmbUsername.Items.Add("Cashier")
        cmbUsername.Items.Add("Stock Controller")

        cmbSearch.Items.Add("CUSTOMER ID")
        cmbSearch.Items.Add("TITLE")
        cmbSearch.Items.Add("FIRST NAME")
        cmbSearch.Items.Add("LASTNAME")
        cmbSearch.Items.Add("ADRESS")
        cmbSearch.Items.Add("CONTACT NUMBER")




    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result = MessageBox.Show("are you sure you want to exit?", "Clossing system", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        CUSTOMER_DETAILSBindingSource.AddNew()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        CUSTOMER_DETAILSBindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        CUSTOMER_DETAILSBindingSource.MovePrevious()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        CUSTOMER_DETAILSBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        On Error GoTo Feedback
        Me.Validate()
        Me.CUSTOMER_DETAILSBindingSource.EndEdit()
        Me.CUSTOMER_DETAILSTableAdapter.Update(Me.SHOPDataSet)
Feedback:
        MsgBox("Check your Record", vbInformation)
        Exit Sub
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim stock As String
        stock = cmbSearch.Text

        Select Case stock
            Case "CUSTOMER ID"
                Me.CUSTOMER_DETAILSBindingSource.Filter = "CUSTOMER ID ='" & txtSearch.Text & "'"
            Case "TITLE"
                Me.CUSTOMER_DETAILSBindingSource.Filter = "TITLE='" & txtSearch.Text & "'"
            Case "FIRST NAME"
                Me.CUSTOMER_DETAILSBindingSource.Filter = "FIRST NAME ='" & txtSearch.Text & "'"
            Case "LASTNAME"
                Me.CUSTOMER_DETAILSBindingSource.Filter = "LASTNAME ='" & txtSearch.Text & "'"
            Case "ADRESS"
                Me.CUSTOMER_DETAILSBindingSource.Filter = "ADRESS ='" & txtSearch.Text & "'"
            Case "CONTACT"
                Me.CUSTOMER_DETAILSBindingSource.Filter = "CONTACT NUMBER ='" & txtSearch.Text & "'"

        End Select

    End Sub

End Class