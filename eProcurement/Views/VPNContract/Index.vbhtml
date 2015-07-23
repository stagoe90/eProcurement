@ModelType IEnumerable(Of VPNContract)
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
            @Html.DisplayNameFor(Function(model) model.Contract_IFTNo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractNotification)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractPerformanceBond)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractDateSigned)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractCreditDateEstablished)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractAdvancePaymentGuarantee)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractExpectedDeliveryDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractActualDeliveryDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractStatus)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Version)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Contract_Let_Credit)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Contract_Credit)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractCompany)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractItem)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractQuantity)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractValue)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractRemarks)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractNotificationRemarks)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractPerformanceBondRemarks)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractDateSignedRemarks)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractCreditDateEstablishedRemarks)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractExpectedDeliveryDateRemarks)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractActualDeliveryDateRemarks)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Contract_CreditRemarks)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractDeliverySite)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractDeliverySiteRemarks)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContractAdvancePaymentGuaranteeTalk)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CurrencyID)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.UnitOfMeasureID)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Contract_IFTNo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractNotification)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractPerformanceBond)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractDateSigned)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractCreditDateEstablished)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractAdvancePaymentGuarantee)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractExpectedDeliveryDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractActualDeliveryDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractStatus)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Version)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Contract_Let_Credit)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Contract_Credit)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractCompany)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractItem)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractQuantity)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractValue)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractRemarks)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractNotificationRemarks)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractPerformanceBondRemarks)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractDateSignedRemarks)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractCreditDateEstablishedRemarks)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractExpectedDeliveryDateRemarks)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractActualDeliveryDateRemarks)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Contract_CreditRemarks)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractDeliverySite)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractDeliverySiteRemarks)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContractAdvancePaymentGuaranteeTalk)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CurrencyID)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.UnitOfMeasureID)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ContractID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ContractID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ContractID })
        </td>
    </tr>
Next

</table>
