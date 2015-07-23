'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class LPO
    Public Property LPO_ID As Integer
    Public Property LPO_No As String
    Public Property Quotatio_ID As Nullable(Of Integer)
    Public Property Supplier_ID As Nullable(Of Integer)
    Public Property Staff_ID As Nullable(Of Integer)
    Public Property LPO_Date As Nullable(Of Date)
    Public Property LPO_Delivery_Date As Nullable(Of Date)
    Public Property Currency_ID As Nullable(Of Integer)
    Public Property LPO_VAT As Nullable(Of Integer)
    Public Property LPO_NHIL As Nullable(Of Integer)
    Public Property LPO_Status_ID As Nullable(Of Integer)
    Public Property LPO_Tax As Nullable(Of Decimal)
    Public Property LPO_Date_Received As Nullable(Of Date)
    Public Property LPO_Delivery_Site As String
    Public Property LPO_Warranty As String
    Public Property Delivery_Site_ID As Nullable(Of Integer)
    Public Property Delivery_Period_ID As Nullable(Of Integer)
    Public Property Warranty_ID As Nullable(Of Integer)
    Public Property Payment_Term_ID As Nullable(Of Integer)
    Public Property LPO_Invoice_Num_Note As String
    Public Property LPO_Goods_Rec_Note_No As String
    Public Property LPO_Contract_Letter_No As String
    Public Property LPO_Amount As Nullable(Of Decimal)
    Public Property LPO_Invoice_Num_Note_Date As Nullable(Of Date)
    Public Property LPO_Goods_Rec_Note_No_Date As Nullable(Of Date)
    Public Property LPO_ForDept As String
    Public Property LPOItem As String
    Public Property LPOcc As String

    Public Overridable Property Charge As Charge
    Public Overridable Property LPO_Status As LPO_Status
    Public Overridable Property Quotation As Quotation

End Class