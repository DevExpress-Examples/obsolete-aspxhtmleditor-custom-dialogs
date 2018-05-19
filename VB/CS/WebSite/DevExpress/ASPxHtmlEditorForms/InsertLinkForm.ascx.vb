Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxHtmlEditor
Imports DevExpress.Web.ASPxHtmlEditor.Localization
Imports DevExpress.Web.ASPxClasses
Imports DevExpress.Web.ASPxEditors
Imports System.IO

Partial Public Class InsertLinkForm
	Inherits HtmlEditorUserControl
	Protected Overrides Sub PrepareChildControls()
		Localize()

		MyBase.PrepareChildControls()
	End Sub
	Private Sub Localize()
		rblLinkType.Items.Add(ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_Url), "URL")
		rblLinkType.Items.Add(ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_Email), "Email")
		lblUrl.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_Url) & ":"
		txbURL.ValidationSettings.RequiredField.ErrorText = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.RequiredFieldError)
		lblEmailTo.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_EmailTo) & ":"
		txbEmailTo.ValidationSettings.RequiredField.ErrorText = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.RequiredFieldError)
		lblSubject.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_Subject) & ":"
		lblLinkDisplay.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_DisplayProperties)
		lblText.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_Text) & ":"
		lblToolTip.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_ToolTip) & ":"
		ckbOpenInNewWindow.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_OpenInNewWindow)
		btnOk.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ButtonOk)
		btnChange.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ButtonChange)
		btnCancel.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ButtonCancel)
	End Sub

	Protected Overrides Function GetChildDxEdits() As ASPxEditBase()
		Return New ASPxEditBase() { rblLinkType, lblUrl, txbURL, lblEmailTo, txbEmailTo, lblSubject, txbSubject, lblLinkDisplay, lblText, txbText, lblToolTip, txbToolTip, ckbOpenInNewWindow }
	End Function
	Protected Overrides Function GetChildDxButtons() As ASPxButton()
		Return New ASPxButton() { btnOk, btnCancel, btnChange }
	End Function
	Protected Overrides Function GetChildDxHtmlEditorRoundPanel() As ASPxHtmlEditorRoundPanel
		Return rpInsertLink
	End Function
	Protected Function SaveUploadFile() As String
		Dim fileName As String = ""
		If HasFile() Then
			Dim uploadFolder As String = HtmlEditor.SettingsImageUpload.UploadImageFolder
			fileName = MapPath(uploadFolder) + uplImage.UploadedFiles(0).FileName
			Try
				uplImage.UploadedFiles(0).SaveAs(fileName, False)
			Catch e1 As IOException
				fileName = MapPath(uploadFolder) + uplImage.GetRandomFileName()
				uplImage.UploadedFiles(0).SaveAs(fileName)
			End Try
		End If
		Return Path.GetFileName(fileName)
	End Function
	Protected Function HasFile() As Boolean
		Return uplImage.UploadedFiles IsNot Nothing AndAlso uplImage.UploadedFiles.Length > 0 AndAlso uplImage.UploadedFiles(0).FileName <> ""
	End Function
	Protected Sub uplImage_FileUploadComplete(ByVal sender As Object, ByVal args As DevExpress.Web.ASPxUploadControl.FileUploadCompleteEventArgs)
		Try
			args.CallbackData = SaveUploadFile()
		Catch e As Exception
			args.IsValid = False
			args.ErrorText = e.Message
		End Try
	End Sub
End Class