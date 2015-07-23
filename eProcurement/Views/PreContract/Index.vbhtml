@ModelType IEnumerable(Of PreContract)
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
            @Html.DisplayNameFor(Function(model) model.PContractName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PContractIFT)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PContractProcMethod)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PContractPrepDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PContractTenderInvitationDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PContractTenderClosingDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PContractSubEvalReport)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PContractAppFinAuth)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PContractAmount)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PContractAward)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PContractSign)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PContractArrival)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PContractInspection)
        </th>
        @*<th>
            @Html.DisplayNameFor(Function(model) model.Remarks)
        </th>*@
        @*<th>
            @Html.DisplayNameFor(Function(model) model.Version)
        </th>*@
        <th>
            @Html.DisplayNameFor(Function(model) model.CurrencyID)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PContractName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PContractIFT)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PContractProcMethod)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PContractPrepDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PContractTenderInvitationDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PContractTenderClosingDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PContractSubEvalReport)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PContractAppFinAuth)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PContractAmount)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PContractAward)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PContractSign)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PContractArrival)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PContractInspection)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.Remarks)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Version)
        </td>*@
        <td>
            @Html.DisplayFor(Function(modelItem) item.CurrencyID)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.PContractID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PContractID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PContractID })
        </td>
    </tr>
Next

</table>
