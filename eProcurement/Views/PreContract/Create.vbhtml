@ModelType PreContract
@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>PreContract</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.PContractName, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PContractName)
                @Html.ValidationMessageFor(Function(model) model.PContractName)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PContractIFT, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PContractIFT)
                @Html.ValidationMessageFor(Function(model) model.PContractIFT)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PContractProcMethod, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PContractProcMethod)
                @Html.ValidationMessageFor(Function(model) model.PContractProcMethod)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PContractPrepDate, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PContractPrepDate)
                @Html.ValidationMessageFor(Function(model) model.PContractPrepDate)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PContractTenderInvitationDate, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PContractTenderInvitationDate)
                @Html.ValidationMessageFor(Function(model) model.PContractTenderInvitationDate)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PContractTenderClosingDate, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PContractTenderClosingDate)
                @Html.ValidationMessageFor(Function(model) model.PContractTenderClosingDate)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PContractSubEvalReport, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PContractSubEvalReport)
                @Html.ValidationMessageFor(Function(model) model.PContractSubEvalReport)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PContractAppFinAuth, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PContractAppFinAuth)
                @Html.ValidationMessageFor(Function(model) model.PContractAppFinAuth)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PContractAmount, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PContractAmount)
                @Html.ValidationMessageFor(Function(model) model.PContractAmount)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PContractAward, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PContractAward)
                @Html.ValidationMessageFor(Function(model) model.PContractAward)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PContractSign, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PContractSign)
                @Html.ValidationMessageFor(Function(model) model.PContractSign)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PContractArrival, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PContractArrival)
                @Html.ValidationMessageFor(Function(model) model.PContractArrival)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PContractInspection, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PContractInspection)
                @Html.ValidationMessageFor(Function(model) model.PContractInspection)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Remarks, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Remarks)
                @Html.ValidationMessageFor(Function(model) model.Remarks)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CurrencyID, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("Currency_ID", String.Empty)
                @*@Html.EditorFor(Function(model) model.CurrencyID)*@
                @Html.ValidationMessageFor(Function(model) model.CurrencyID)
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
