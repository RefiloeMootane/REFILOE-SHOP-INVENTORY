Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SHOPDataSet.PRODUCT_CATALOG' table. You can move, or remove it, as needed.
        Me.PRODUCT_CATALOGTableAdapter.Fill(Me.SHOPDataSet.PRODUCT_CATALOG)
        'TODO: This line of code loads data into the 'SHOPDataSet.PRODUCT_ORDER' table. You can move, or remove it, as needed.
        Me.PRODUCT_ORDERTableAdapter.Fill(Me.SHOPDataSet.PRODUCT_ORDER)
        'TODO: This line of code loads data into the 'SHOPDataSet.PRODUCT_DETAILS' table. You can move, or remove it, as needed.
        Me.PRODUCT_DETAILSTableAdapter.Fill(Me.SHOPDataSet.PRODUCT_DETAILS)
        'TODO: This line of code loads data into the 'SHOPDataSet.CUSTOMER_DETAILS' table. You can move, or remove it, as needed.
        Me.CUSTOMER_DETAILSTableAdapter.Fill(Me.SHOPDataSet.CUSTOMER_DETAILS)
        'TODO: This line of code loads data into the 'SHOPDataSet.SHOP' table. You can move, or remove it, as needed.
        Me.SHOPTableAdapter.Fill(Me.SHOPDataSet.SHOP)

    End Sub
End Class
