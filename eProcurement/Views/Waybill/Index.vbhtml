@ModelType IEnumerable(Of Waybill)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.WaybillDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.WaybillReceipient)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.WaybillNo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ZoneID)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DestinationID)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.WaybillVehicleNo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.WaybillServiceProviderID)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.WaybillRefNo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.WaybillQty)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TransactionTypeID)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ItemID)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.WaybillBOL)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Version)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.IFTNo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.UnitOfMeasureID)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.WaybillDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.WaybillReceipient)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.WaybillNo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ZoneID)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DestinationID)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.WaybillVehicleNo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.WaybillServiceProviderID)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.WaybillRefNo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.WaybillQty)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TransactionTypeID)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ItemID)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.WaybillBOL)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Version)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.IFTNo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.UnitOfMeasureID)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.WaybillID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.WaybillID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.WaybillID })
        </td>
    </tr>
Next

</table>
