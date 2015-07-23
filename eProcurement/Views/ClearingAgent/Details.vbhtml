@ModelType ClearingAgent
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>ClearingAgent</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentCepsDuty)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentCepsDuty)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentMolShipping)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentMolShipping)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentMpsCharges)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentMpsCharges)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentGphaCharges)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentGphaCharges)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentForkLift)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentForkLift)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentTransportation)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentTransportation)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentInterestCharges)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentInterestCharges)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentLabour)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentLabour)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentAgencyFee)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentAgencyFee)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Version)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Version)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentAgencyDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentAgencyDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentAgencyRefNo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentAgencyRefNo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentDetailsID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentDetailsID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentInvoice)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentInvoice)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentVAT)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentVAT)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentEPA)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentEPA)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentDescription)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentDescription)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentShippingLine)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentShippingLine)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentContainerAgent)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentContainerAgent)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentDumurrage)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentDumurrage)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.IFTNo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.IFTNo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.BOLNo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.BOLNo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SubTotal)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SubTotal)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentContractID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentContractID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentQuantityCleared)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClearingAgentQuantityCleared)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ClearingAgentID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
