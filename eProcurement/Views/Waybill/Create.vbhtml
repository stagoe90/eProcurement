@ModelType Waybill
@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Waybill</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.WaybillDate, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.WaybillDate)
                @Html.ValidationMessageFor(Function(model) model.WaybillDate)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.WaybillReceipient, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.WaybillReceipient)
                @Html.ValidationMessageFor(Function(model) model.WaybillReceipient)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.WaybillNo, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.WaybillNo)
                @Html.ValidationMessageFor(Function(model) model.WaybillNo)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ZoneID, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ZoneID)
                @Html.ValidationMessageFor(Function(model) model.ZoneID)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.DestinationID, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.DestinationID)
                @Html.ValidationMessageFor(Function(model) model.DestinationID)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.WaybillVehicleNo, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.WaybillVehicleNo)
                @Html.ValidationMessageFor(Function(model) model.WaybillVehicleNo)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.WaybillServiceProviderID, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.WaybillServiceProviderID)
                @Html.ValidationMessageFor(Function(model) model.WaybillServiceProviderID)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.WaybillRefNo, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.WaybillRefNo)
                @Html.ValidationMessageFor(Function(model) model.WaybillRefNo)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.WaybillQty, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.WaybillQty)
                @Html.ValidationMessageFor(Function(model) model.WaybillQty)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.TransactionTypeID, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.TransactionTypeID)
                @Html.ValidationMessageFor(Function(model) model.TransactionTypeID)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ItemID, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ItemID)
                @Html.ValidationMessageFor(Function(model) model.ItemID)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.WaybillBOL, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.WaybillBOL)
                @Html.ValidationMessageFor(Function(model) model.WaybillBOL)
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
            @Html.LabelFor(Function(model) model.UnitOfMeasureID, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.UnitOfMeasureID)
                @Html.ValidationMessageFor(Function(model) model.UnitOfMeasureID)
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
