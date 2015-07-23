Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace eProcurement
    Public Class WaybillController
        Inherits System.Web.Mvc.Controller

        Private db As New ProcurementDBEntities

        ' GET: /Waybill/
        Function Index() As ActionResult
            Return View(db.Waybills.ToList())
        End Function

        ' GET: /Waybill/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim waybill As Waybill = db.Waybills.Find(id)
            If IsNothing(waybill) Then
                Return HttpNotFound()
            End If
            Return View(waybill)
        End Function

        ' GET: /Waybill/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /Waybill/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "WaybillID,WaybillDate,WaybillReceipient,WaybillNo,ZoneID,DestinationID,WaybillVehicleNo,WaybillServiceProviderID,WaybillRefNo,WaybillQty,TransactionTypeID,ItemID,WaybillBOL,Version,IFTNo,UnitOfMeasureID")> ByVal waybill As Waybill) As ActionResult
            If ModelState.IsValid Then
                db.Waybills.Add(waybill)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            Return View(waybill)
        End Function

        ' GET: /Waybill/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim waybill As Waybill = db.Waybills.Find(id)
            If IsNothing(waybill) Then
                Return HttpNotFound()
            End If
            Return View(waybill)
        End Function

        ' POST: /Waybill/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "WaybillID,WaybillDate,WaybillReceipient,WaybillNo,ZoneID,DestinationID,WaybillVehicleNo,WaybillServiceProviderID,WaybillRefNo,WaybillQty,TransactionTypeID,ItemID,WaybillBOL,Version,IFTNo,UnitOfMeasureID")> ByVal waybill As Waybill) As ActionResult
            If ModelState.IsValid Then
                db.Entry(waybill).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(waybill)
        End Function

        ' GET: /Waybill/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim waybill As Waybill = db.Waybills.Find(id)
            If IsNothing(waybill) Then
                Return HttpNotFound()
            End If
            Return View(waybill)
        End Function

        ' POST: /Waybill/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim waybill As Waybill = db.Waybills.Find(id)
            db.Waybills.Remove(waybill)
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
