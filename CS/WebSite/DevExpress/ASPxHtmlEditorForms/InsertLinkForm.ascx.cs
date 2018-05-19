using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.ASPxHtmlEditor.Localization;
using System.IO;
using DevExpress.Web.ASPxEditors;

public partial class InsertLinkForm : HtmlEditorUserControl {
    protected override void PrepareChildControls() {
        Localize();
      
        base.PrepareChildControls();
    }
    void Localize() {
        rblLinkType.Items.Add(ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_Url), "URL");
        rblLinkType.Items.Add(ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_Email), "Email");
        lblUrl.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_Url) + ":";
        txbURL.ValidationSettings.RequiredField.ErrorText = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.RequiredFieldError);
        lblEmailTo.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_EmailTo) + ":";
        txbEmailTo.ValidationSettings.RequiredField.ErrorText = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.RequiredFieldError);
        lblSubject.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_Subject) + ":";
        lblLinkDisplay.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_DisplayProperties);
        lblText.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_Text) + ":";
        lblToolTip.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_ToolTip) + ":";
        ckbOpenInNewWindow.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_OpenInNewWindow);
        btnOk.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ButtonOk);
        btnChange.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ButtonChange);
        btnCancel.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ButtonCancel);
    }

    protected override ASPxEditBase[] GetChildDxEdits() {
        return new ASPxEditBase[] { 
			rblLinkType, 
			lblUrl, txbURL,
			lblEmailTo, txbEmailTo,
			lblSubject, txbSubject,
            lblLinkDisplay, lblText,
            txbText, lblToolTip,
            txbToolTip, ckbOpenInNewWindow
        };
    }
    protected override ASPxButton[] GetChildDxButtons() {
        return new ASPxButton[] { btnOk, btnCancel, btnChange };
    }
    protected override ASPxHtmlEditorRoundPanel GetChildDxHtmlEditorRoundPanel() {
        return rpInsertLink;
    }
    protected string SaveUploadFile() {
        string fileName = "";
        if (HasFile()) {
            string uploadFolder = HtmlEditor.SettingsImageUpload.UploadImageFolder;
            fileName = MapPath(uploadFolder) + uplImage.UploadedFiles[0].FileName;
            try {
                uplImage.UploadedFiles[0].SaveAs(fileName, false);
            }
            catch (IOException) {
                fileName = MapPath(uploadFolder) + uplImage.GetRandomFileName();
                uplImage.UploadedFiles[0].SaveAs(fileName);
            }
        }
        return Path.GetFileName(fileName);
    }
    protected bool HasFile() {
        return uplImage.UploadedFiles != null && uplImage.UploadedFiles.Length > 0 && uplImage.UploadedFiles[0].FileName != "";
    }
    protected void uplImage_FileUploadComplete(object sender, DevExpress.Web.ASPxUploadControl.FileUploadCompleteEventArgs args) {
        try {
            args.CallbackData = SaveUploadFile();
        }
        catch (Exception e) {
            args.IsValid = false;
            args.ErrorText = e.Message;
        }
    }
}