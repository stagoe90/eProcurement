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

Partial Public Class Staff
    Public Property Staff_ID As Integer
    Public Property Staff_Name As String
    Public Property Staff_UserName As String
    Public Property Staff_Password As String
    Public Property Group_ID As Nullable(Of Integer)
    Public Property Staff_Rank As String
    Public Property Staff_Audit As Nullable(Of Integer)

    Public Overridable Property Group As Group
    Public Overridable Property Tenders As ICollection(Of Tender) = New HashSet(Of Tender)

End Class
