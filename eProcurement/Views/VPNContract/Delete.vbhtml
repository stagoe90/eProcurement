@ModelType VPNContract
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>VPNContract</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Contract_IFTNo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Contract_IFTNo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractNotification)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractNotification)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractPerformanceBond)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractPerformanceBond)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractDateSigned)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractDateSigned)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractCreditDateEstablished)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractCreditDateEstablished)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractAdvancePaymentGuarantee)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractAdvancePaymentGuarantee)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractExpectedDeliveryDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractExpectedDeliveryDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractActualDeliveryDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractActualDeliveryDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractStatus)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractStatus)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Version)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Version)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Contract_Let_Credit)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Contract_Let_Credit)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Contract_Credit)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Contract_Credit)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractCompany)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractCompany)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractItem)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractItem)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractQuantity)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractQuantity)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractValue)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractValue)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractRemarks)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractRemarks)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractNotificationRemarks)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractNotificationRemarks)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractPerformanceBondRemarks)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractPerformanceBondRemarks)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractDateSignedRemarks)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractDateSignedRemarks)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractCreditDateEstablishedRemarks)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractCreditDateEstablishedRemarks)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractExpectedDeliveryDateRemarks)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractExpectedDeliveryDateRemarks)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractActualDeliveryDateRemarks)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractActualDeliveryDateRemarks)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Contract_CreditRemarks)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Contract_CreditRemarks)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractDeliverySite)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractDeliverySite)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractDeliverySiteRemarks)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractDeliverySiteRemarks)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContractAdvancePaymentGuaranteeTalk)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContractAdvancePaymentGuaranteeTalk)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CurrencyID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CurrencyID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UnitOfMeasureID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UnitOfMeasureID)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
