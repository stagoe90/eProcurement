@ModelType Waybill
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Waybill</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.WaybillDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.WaybillDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.WaybillReceipient)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.WaybillReceipient)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.WaybillNo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.WaybillNo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ZoneID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ZoneID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DestinationID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DestinationID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.WaybillVehicleNo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.WaybillVehicleNo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.WaybillServiceProviderID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.WaybillServiceProviderID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.WaybillRefNo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.WaybillRefNo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.WaybillQty)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.WaybillQty)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TransactionTypeID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TransactionTypeID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ItemID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ItemID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.WaybillBOL)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.WaybillBOL)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Version)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Version)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.IFTNo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.IFTNo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UnitOfMeasureID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UnitOfMeasureID)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.WaybillID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
