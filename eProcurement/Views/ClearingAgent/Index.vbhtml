@ModelType IEnumerable(Of ClearingAgent)
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
            @Html.DisplayNameFor(Function(model) model.ClearingAgentName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentCepsDuty)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentMolShipping)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentMpsCharges)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentGphaCharges)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentForkLift)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentTransportation)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentInterestCharges)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentLabour)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentAgencyFee)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Version)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentAgencyDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentAgencyRefNo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentDetailsID)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentInvoice)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentVAT)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentEPA)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentDescription)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentShippingLine)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentContainerAgent)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentDumurrage)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.IFTNo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.BOLNo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SubTotal)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentContractID)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ClearingAgentQuantityCleared)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentCepsDuty)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentMolShipping)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentMpsCharges)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentGphaCharges)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentForkLift)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentTransportation)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentInterestCharges)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentLabour)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentAgencyFee)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Version)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentAgencyDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentAgencyRefNo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentDetailsID)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentInvoice)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentVAT)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentEPA)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentDescription)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentShippingLine)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentContainerAgent)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentDumurrage)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.IFTNo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.BOLNo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SubTotal)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentContractID)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ClearingAgentQuantityCleared)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ClearingAgentID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ClearingAgentID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ClearingAgentID })
        </td>
    </tr>
Next

</table>
