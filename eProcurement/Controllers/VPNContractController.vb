Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace eProcurement
    Public Class VPNContractController
        Inherits System.Web.Mvc.Controller

        Private db As New ProcurementDBEntities

        ' GET: /VPNContract/
        Function Index() As ActionResult
            Return View(db.VPNContracts.ToList())
        End Function

        ' GET: /VPNContract/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vpncontract As VPNContract = db.VPNContracts.Find(id)
            If IsNothing(vpncontract) Then
                Return HttpNotFound()
            End If
            Return View(vpncontract)
        End Function

        ' GET: /VPNContract/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /VPNContract/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "ContractID,Contract_IFTNo,ContractNotification,ContractPerformanceBond,ContractDateSigned,ContractCreditDateEstablished,ContractAdvancePaymentGuarantee,ContractExpectedDeliveryDate,ContractActualDeliveryDate,ContractStatus,Version,Contract_Let_Credit,Contract_Credit,ContractCompany,ContractItem,ContractQuantity,ContractValue,ContractRemarks,ContractNotificationRemarks,ContractPerformanceBondRemarks,ContractDateSignedRemarks,ContractCreditDateEstablishedRemarks,ContractExpectedDeliveryDateRemarks,ContractActualDeliveryDateRemarks,Contract_CreditRemarks,ContractDeliverySite,ContractDeliverySiteRemarks,ContractAdvancePaymentGuaranteeTalk,CurrencyID,UnitOfMeasureID")> ByVal vpncontract As VPNContract) As ActionResult
            If ModelState.IsValid Then
                db.VPNContracts.Add(vpncontract)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            Return View(vpncontract)
        End Function

        ' GET: /VPNContract/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vpncontract As VPNContract = db.VPNContracts.Find(id)
            If IsNothing(vpncontract) Then
                Return HttpNotFound()
            End If
            Return View(vpncontract)
        End Function

        ' POST: /VPNContract/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "ContractID,Contract_IFTNo,ContractNotification,ContractPerformanceBond,ContractDateSigned,ContractCreditDateEstablished,ContractAdvancePaymentGuarantee,ContractExpectedDeliveryDate,ContractActualDeliveryDate,ContractStatus,Version,Contract_Let_Credit,Contract_Credit,ContractCompany,ContractItem,ContractQuantity,ContractValue,ContractRemarks,ContractNotificationRemarks,ContractPerformanceBondRemarks,ContractDateSignedRemarks,ContractCreditDateEstablishedRemarks,ContractExpectedDeliveryDateRemarks,ContractActualDeliveryDateRemarks,Contract_CreditRemarks,ContractDeliverySite,ContractDeliverySiteRemarks,ContractAdvancePaymentGuaranteeTalk,CurrencyID,UnitOfMeasureID")> ByVal vpncontract As VPNContract) As ActionResult
            If ModelState.IsValid Then
                db.Entry(vpncontract).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(vpncontract)
        End Function

        ' GET: /VPNContract/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vpncontract As VPNContract = db.VPNContracts.Find(id)
            If IsNothing(vpncontract) Then
                Return HttpNotFound()
            End If
            Return View(vpncontract)
        End Function

        ' POST: /VPNContract/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim vpncontract As VPNContract = db.VPNContracts.Find(id)
            db.VPNContracts.Remove(vpncontract)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
