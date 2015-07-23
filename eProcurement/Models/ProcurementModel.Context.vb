﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class ProcurementDBEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=ProcurementDBEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Charges() As DbSet(Of Charge)
    Public Overridable Property ClearingAgentContracts() As DbSet(Of ClearingAgentContract)
    Public Overridable Property ClearingAgentDetails() As DbSet(Of ClearingAgentDetail)
    Public Overridable Property ClearingAgents() As DbSet(Of ClearingAgent)
    Public Overridable Property Contracts() As DbSet(Of Contract)
    Public Overridable Property ContractStatus() As DbSet(Of ContractStatu)
    Public Overridable Property Currencies() As DbSet(Of Currency)
    Public Overridable Property Delivery_Periods() As DbSet(Of Delivery_Periods)
    Public Overridable Property Delivery_Sites() As DbSet(Of Delivery_Sites)
    Public Overridable Property Departments() As DbSet(Of Department)
    Public Overridable Property Groups() As DbSet(Of Group)
    Public Overridable Property LPOes() As DbSet(Of LPO)
    Public Overridable Property LPO_Products() As DbSet(Of LPO_Products)
    Public Overridable Property LPO_Status() As DbSet(Of LPO_Status)
    Public Overridable Property Payment_Terms() As DbSet(Of Payment_Terms)
    Public Overridable Property PreContracts() As DbSet(Of PreContract)
    Public Overridable Property Quotation_Products() As DbSet(Of Quotation_Products)
    Public Overridable Property Quotations() As DbSet(Of Quotation)
    Public Overridable Property Staffs() As DbSet(Of Staff)
    Public Overridable Property Supplier_Categories() As DbSet(Of Supplier_Categories)
    Public Overridable Property Suppliers() As DbSet(Of Supplier)
    Public Overridable Property sysdiagrams() As DbSet(Of sysdiagram)
    Public Overridable Property Taxes() As DbSet(Of Tax)
    Public Overridable Property Temas() As DbSet(Of Tema)
    Public Overridable Property Tender_Products() As DbSet(Of Tender_Products)
    Public Overridable Property Tender_Status() As DbSet(Of Tender_Status)
    Public Overridable Property Tenders() As DbSet(Of Tender)
    Public Overridable Property Unit_Of_Measure() As DbSet(Of Unit_Of_Measure)
    Public Overridable Property VPNContracts() As DbSet(Of VPNContract)
    Public Overridable Property Warranties() As DbSet(Of Warranty)
    Public Overridable Property Waybills() As DbSet(Of Waybill)

End Class
