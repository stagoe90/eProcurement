Imports System.ComponentModel.DataAnnotations

<MetadataTypeAttribute(GetType(PreContract.PreContractMetadata))> _
Partial Public Class PreContract
    Friend NotInheritable Class PreContractMetadata

        'Metadata classes are not meant to be instantiated.
        Private Sub New()
            MyBase.New()
        End Sub

        <Required()> _
        <StringLength(60)> _
        <Display(Name:="Contract Name")> _
        Public PContractName As String

        <Display(Name:="IFT No")> _
        Public PContractIFT As String

        <Display(Name:="Proc. Method")> _
        Public PContractProcMethod As String

        <Display(Name:="Prep Date")> _
         <DisplayFormat(ApplyFormatInEditMode:=True, DataFormatString:="{0:d}")> _
        Public PContractPrepDate As Date

        <Display(Name:="Tender Inv. Date")> _
         <DisplayFormat(ApplyFormatInEditMode:=True, DataFormatString:="{0:d}")> _
        Public PContractTenderInvitationDate As Date

        <Display(Name:="Tender Closing Date")> _
         <DisplayFormat(ApplyFormatInEditMode:=True, DataFormatString:="{0:d}")> _
        Public PContractTenderClosingDate As Date

        <Display(Name:="Sub Eval Report")> _
         <DisplayFormat(ApplyFormatInEditMode:=True, DataFormatString:="{0:d}")> _
        Public PContractSubEvalReport As Date

        <Display(Name:="App Fin Auth")> _
         <DisplayFormat(ApplyFormatInEditMode:=True, DataFormatString:="{0:d}")> _
        Public PContractAppFinAuth As Date

        <Display(Name:="Amount")> _
        Public PContractAmount As Decimal

        <Display(Name:="Award date")> _
         <DisplayFormat(ApplyFormatInEditMode:=True, DataFormatString:="{0:d}")> _
        Public PContractAward As Date

        <Display(Name:="Sign Date")> _
         <DisplayFormat(ApplyFormatInEditMode:=True, DataFormatString:="{0:d}")> _
        Public PContractSign As Date

        <Display(Name:="Exp. Arrival Date")> _
         <DisplayFormat(ApplyFormatInEditMode:=True, DataFormatString:="{0:d}")> _
        Public PContractArrival As Date

        <Display(Name:="Insp. Date")> _
         <DisplayFormat(ApplyFormatInEditMode:=True, DataFormatString:="{0:d}")> _
        Public PContractInspection As Date

        <Display(Name:="Currency")> _
        Public CurrencyID As Integer

        <Display(Name:="Remarks")> _
        Public Remarks As String




    End Class
End Class
