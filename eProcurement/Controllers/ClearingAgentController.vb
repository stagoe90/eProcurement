Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace eProcurement
    Public Class ClearingAgentController
        Inherits System.Web.Mvc.Controller

        Private db As New ProcurementDBEntities

        ' GET: /ClearingAgent/
        Function Index() As ActionResult
            Return View(db.ClearingAgents.ToList())
        End Function

        ' GET: /ClearingAgent/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim clearingagent As ClearingAgent = db.ClearingAgents.Find(id)
            If IsNothing(clearingagent) Then
                Return HttpNotFound()
            End If
            Return View(clearingagent)
        End Function

        ' GET: /ClearingAgent/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /ClearingAgent/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "ClearingAgentID,ClearingAgentName,ClearingAgentCepsDuty,ClearingAgentMolShipping,ClearingAgentMpsCharges,ClearingAgentGphaCharges,ClearingAgentForkLift,ClearingAgentTransportation,ClearingAgentInterestCharges,ClearingAgentLabour,ClearingAgentAgencyFee,Version,ClearingAgentAgencyDate,ClearingAgentAgencyRefNo,ClearingAgentDetailsID,ClearingAgentInvoice,ClearingAgentVAT,ClearingAgentEPA,ClearingAgentDescription,ClearingAgentShippingLine,ClearingAgentContainerAgent,ClearingAgentDumurrage,IFTNo,BOLNo,SubTotal,ClearingAgentContractID,ClearingAgentQuantityCleared")> ByVal clearingagent As ClearingAgent) As ActionResult
            If ModelState.IsValid Then
                db.ClearingAgents.Add(clearingagent)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            Return View(clearingagent)
        End Function

        ' GET: /ClearingAgent/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim clearingagent As ClearingAgent = db.ClearingAgents.Find(id)
            If IsNothing(clearingagent) Then
                Return HttpNotFound()
            End If
            Return View(clearingagent)
        End Function

        ' POST: /ClearingAgent/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "ClearingAgentID,ClearingAgentName,ClearingAgentCepsDuty,ClearingAgentMolShipping,ClearingAgentMpsCharges,ClearingAgentGphaCharges,ClearingAgentForkLift,ClearingAgentTransportation,ClearingAgentInterestCharges,ClearingAgentLabour,ClearingAgentAgencyFee,Version,ClearingAgentAgencyDate,ClearingAgentAgencyRefNo,ClearingAgentDetailsID,ClearingAgentInvoice,ClearingAgentVAT,ClearingAgentEPA,ClearingAgentDescription,ClearingAgentShippingLine,ClearingAgentContainerAgent,ClearingAgentDumurrage,IFTNo,BOLNo,SubTotal,ClearingAgentContractID,ClearingAgentQuantityCleared")> ByVal clearingagent As ClearingAgent) As ActionResult
            If ModelState.IsValid Then
                db.Entry(clearingagent).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(clearingagent)
        End Function

        ' GET: /ClearingAgent/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim clearingagent As ClearingAgent = db.ClearingAgents.Find(id)
            If IsNothing(clearingagent) Then
                Return HttpNotFound()
            End If
            Return View(clearingagent)
        End Function

        ' POST: /ClearingAgent/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim clearingagent As ClearingAgent = db.ClearingAgents.Find(id)
            db.ClearingAgents.Remove(clearingagent)
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
