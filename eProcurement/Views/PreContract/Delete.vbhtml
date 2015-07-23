@ModelType PreContract
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>PreContract</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.PContractName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PContractName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PContractIFT)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PContractIFT)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PContractProcMethod)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PContractProcMethod)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PContractPrepDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PContractPrepDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PContractTenderInvitationDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PContractTenderInvitationDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PContractTenderClosingDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PContractTenderClosingDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PContractSubEvalReport)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PContractSubEvalReport)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PContractAppFinAuth)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PContractAppFinAuth)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PContractAmount)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PContractAmount)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PContractAward)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PContractAward)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PContractSign)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PContractSign)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PContractArrival)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PContractArrival)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PContractInspection)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PContractInspection)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Remarks)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Remarks)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Version)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Version)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CurrencyID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CurrencyID)
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
