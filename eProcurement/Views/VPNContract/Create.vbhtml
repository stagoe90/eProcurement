@ModelType VPNContract
@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>VPNContract</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.Contract_IFTNo, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Contract_IFTNo)
                @Html.ValidationMessageFor(Function(model) model.Contract_IFTNo)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractNotification, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractNotification)
                @Html.ValidationMessageFor(Function(model) model.ContractNotification)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractPerformanceBond, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractPerformanceBond)
                @Html.ValidationMessageFor(Function(model) model.ContractPerformanceBond)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractDateSigned, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractDateSigned)
                @Html.ValidationMessageFor(Function(model) model.ContractDateSigned)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractCreditDateEstablished, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractCreditDateEstablished)
                @Html.ValidationMessageFor(Function(model) model.ContractCreditDateEstablished)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractAdvancePaymentGuarantee, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractAdvancePaymentGuarantee)
                @Html.ValidationMessageFor(Function(model) model.ContractAdvancePaymentGuarantee)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractExpectedDeliveryDate, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractExpectedDeliveryDate)
                @Html.ValidationMessageFor(Function(model) model.ContractExpectedDeliveryDate)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractActualDeliveryDate, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractActualDeliveryDate)
                @Html.ValidationMessageFor(Function(model) model.ContractActualDeliveryDate)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractStatus, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractStatus)
                @Html.ValidationMessageFor(Function(model) model.ContractStatus)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Contract_Let_Credit, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Contract_Let_Credit)
                @Html.ValidationMessageFor(Function(model) model.Contract_Let_Credit)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Contract_Credit, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Contract_Credit)
                @Html.ValidationMessageFor(Function(model) model.Contract_Credit)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractCompany, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractCompany)
                @Html.ValidationMessageFor(Function(model) model.ContractCompany)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractItem, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractItem)
                @Html.ValidationMessageFor(Function(model) model.ContractItem)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractQuantity, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractQuantity)
                @Html.ValidationMessageFor(Function(model) model.ContractQuantity)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractValue, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractValue)
                @Html.ValidationMessageFor(Function(model) model.ContractValue)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractRemarks, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractRemarks)
                @Html.ValidationMessageFor(Function(model) model.ContractRemarks)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractNotificationRemarks, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractNotificationRemarks)
                @Html.ValidationMessageFor(Function(model) model.ContractNotificationRemarks)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractPerformanceBondRemarks, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractPerformanceBondRemarks)
                @Html.ValidationMessageFor(Function(model) model.ContractPerformanceBondRemarks)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractDateSignedRemarks, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractDateSignedRemarks)
                @Html.ValidationMessageFor(Function(model) model.ContractDateSignedRemarks)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractCreditDateEstablishedRemarks, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractCreditDateEstablishedRemarks)
                @Html.ValidationMessageFor(Function(model) model.ContractCreditDateEstablishedRemarks)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractExpectedDeliveryDateRemarks, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractExpectedDeliveryDateRemarks)
                @Html.ValidationMessageFor(Function(model) model.ContractExpectedDeliveryDateRemarks)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractActualDeliveryDateRemarks, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractActualDeliveryDateRemarks)
                @Html.ValidationMessageFor(Function(model) model.ContractActualDeliveryDateRemarks)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Contract_CreditRemarks, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Contract_CreditRemarks)
                @Html.ValidationMessageFor(Function(model) model.Contract_CreditRemarks)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractDeliverySite, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractDeliverySite)
                @Html.ValidationMessageFor(Function(model) model.ContractDeliverySite)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractDeliverySiteRemarks, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractDeliverySiteRemarks)
                @Html.ValidationMessageFor(Function(model) model.ContractDeliverySiteRemarks)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContractAdvancePaymentGuaranteeTalk, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContractAdvancePaymentGuaranteeTalk)
                @Html.ValidationMessageFor(Function(model) model.ContractAdvancePaymentGuaranteeTalk)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CurrencyID, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.CurrencyID)
                @Html.ValidationMessageFor(Function(model) model.CurrencyID)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.UnitOfMeasureID, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.UnitOfMeasureID)
                @Html.ValidationMessageFor(Function(model) model.UnitOfMeasureID)
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
