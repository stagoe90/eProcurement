Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace eProcurement
    Public Class PreContractController
        Inherits System.Web.Mvc.Controller

        Private db As New ProcurementDBEntities

        ' GET: /PreContract/
        Function Index() As ActionResult
            Return View(db.PreContracts.ToList())
        End Function

        ' GET: /PreContract/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim precontract As PreContract = db.PreContracts.Find(id)
            If IsNothing(precontract) Then
                Return HttpNotFound()
            End If
            Return View(precontract)
        End Function

        ' GET: /PreContract/Create
        Function Create() As ActionResult
            ViewBag.Currency_ID = New SelectList(db.Currencies, "Currency_ID", "Currency1")
            Return View()
        End Function

        ' POST: /PreContract/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "PContractID,PContractName,PContractIFT,PContractProcMethod,PContractPrepDate,PContractTenderInvitationDate,PContractTenderClosingDate,PContractSubEvalReport,PContractAppFinAuth,PContractAmount,PContractAward,PContractSign,PContractArrival,PContractInspection,Remarks,Version,CurrencyID")> ByVal precontract As PreContract) As ActionResult
            If ModelState.IsValid Then
                db.PreContracts.Add(precontract)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Currency_ID = New SelectList(db.Currencies, "Currency_ID", "Currency1")
            Return View(precontract)
        End Function

        ' GET: /PreContract/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim precontract As PreContract = db.PreContracts.Find(id)
            If IsNothing(precontract) Then
                Return HttpNotFound()
            End If
            ViewBag.Currency_ID = New SelectList(db.Currencies, "Currency_ID", "Currency1")
            Return View(precontract)

        End Function

        ' POST: /PreContract/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "PContractID,PContractName,PContractIFT,PContractProcMethod,PContractPrepDate,PContractTenderInvitationDate,PContractTenderClosingDate,PContractSubEvalReport,PContractAppFinAuth,PContractAmount,PContractAward,PContractSign,PContractArrival,PContractInspection,Remarks,Version,CurrencyID")> ByVal precontract As PreContract) As ActionResult
            If ModelState.IsValid Then
                db.Entry(precontract).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(precontract)
            ViewBag.Currency_ID = New SelectList(db.Currencies, "Currency_ID", "Currency1")
        End Function

        ' GET: /PreContract/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim precontract As PreContract = db.PreContracts.Find(id)
            If IsNothing(precontract) Then
                Return HttpNotFound()
            End If
            Return View(precontract)
        End Function

        ' POST: /PreContract/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim precontract As PreContract = db.PreContracts.Find(id)
            db.PreContracts.Remove(precontract)
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
