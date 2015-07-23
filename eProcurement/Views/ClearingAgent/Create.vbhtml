@ModelType ClearingAgent
@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>ClearingAgent</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentName, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentName)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentName)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentCepsDuty, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentCepsDuty)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentCepsDuty)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentMolShipping, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentMolShipping)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentMolShipping)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentMpsCharges, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentMpsCharges)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentMpsCharges)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentGphaCharges, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentGphaCharges)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentGphaCharges)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentForkLift, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentForkLift)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentForkLift)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentTransportation, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentTransportation)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentTransportation)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentInterestCharges, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentInterestCharges)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentInterestCharges)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentLabour, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentLabour)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentLabour)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentAgencyFee, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentAgencyFee)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentAgencyFee)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentAgencyDate, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentAgencyDate)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentAgencyDate)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentAgencyRefNo, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentAgencyRefNo)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentAgencyRefNo)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentDetailsID, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentDetailsID)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentDetailsID)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentInvoice, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentInvoice)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentInvoice)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentVAT, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentVAT)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentVAT)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentEPA, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentEPA)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentEPA)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentDescription, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentDescription)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentDescription)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentShippingLine, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentShippingLine)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentShippingLine)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentContainerAgent, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentContainerAgent)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentContainerAgent)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentDumurrage, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentDumurrage)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentDumurrage)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.IFTNo, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.IFTNo)
                @Html.ValidationMessageFor(Function(model) model.IFTNo)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.BOLNo, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.BOLNo)
                @Html.ValidationMessageFor(Function(model) model.BOLNo)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentContractID, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentContractID)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentContractID)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ClearingAgentQuantityCleared, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ClearingAgentQuantityCleared)
                @Html.ValidationMessageFor(Function(model) model.ClearingAgentQuantityCleared)
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
