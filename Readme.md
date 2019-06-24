<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
* [ImagePropertiesForm.ascx](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/ImagePropertiesForm.ascx) (VB: [ImagePropertiesForm.ascx](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/ImagePropertiesForm.ascx))
* [ImagePropertiesForm.ascx.cs](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/ImagePropertiesForm.ascx.cs) (VB: [ImagePropertiesForm.ascx.vb](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/ImagePropertiesForm.ascx.vb))
* [InsertImageForm.ascx](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/InsertImageForm.ascx) (VB: [InsertImageForm.ascx](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/InsertImageForm.ascx))
* [InsertImageForm.ascx.cs](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/InsertImageForm.ascx.cs) (VB: [InsertImageForm.ascx.vb](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/InsertImageForm.ascx.vb))
* [InsertLinkForm.ascx](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/InsertLinkForm.ascx) (VB: [InsertLinkForm.ascx](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/InsertLinkForm.ascx))
* [InsertLinkForm.ascx.cs](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/InsertLinkForm.ascx.cs) (VB: [InsertLinkForm.ascx.vb](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/InsertLinkForm.ascx.vb))
* [InsertTableForm.ascx](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/InsertTableForm.ascx) (VB: [InsertTableForm.ascx](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/InsertTableForm.ascx))
* [InsertTableForm.ascx.cs](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/InsertTableForm.ascx.cs) (VB: [InsertTableForm.ascx.vb](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/InsertTableForm.ascx.vb))
* [PasteFromWordForm.ascx](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/PasteFromWordForm.ascx) (VB: [PasteFromWordForm.ascx](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/PasteFromWordForm.ascx))
* [PasteFromWordForm.ascx.cs](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/PasteFromWordForm.ascx.cs) (VB: [PasteFromWordForm.ascx.vb](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/PasteFromWordForm.ascx.vb))
* [SelectImageForm.ascx](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/SelectImageForm.ascx) (VB: [SelectImageForm.ascx](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/SelectImageForm.ascx))
* [SelectImageForm.ascx.cs](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/SelectImageForm.ascx.cs) (VB: [SelectImageForm.ascx.vb](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/SelectImageForm.ascx.vb))
* [TableColumnPropertiesForm.ascx](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/TableColumnPropertiesForm.ascx) (VB: [TableColumnPropertiesForm.ascx](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/TableColumnPropertiesForm.ascx))
* [TableColumnPropertiesForm.ascx.cs](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/TableColumnPropertiesForm.ascx.cs) (VB: [TableColumnPropertiesForm.ascx.vb](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/TableColumnPropertiesForm.ascx.vb))
* [SpellCheckForm.ascx](./CS/WebSite/DevExpress/ASPxSpellCheckerForms/SpellCheckForm.ascx) (VB: [SpellCheckForm.ascx](./VB/WebSite/DevExpress/ASPxSpellCheckerForms/SpellCheckForm.ascx))
* [SpellCheckForm.ascx.cs](./CS/WebSite/DevExpress/ASPxSpellCheckerForms/SpellCheckForm.ascx.cs) (VB: [SpellCheckForm.ascx.vb](./VB/WebSite/DevExpress/ASPxSpellCheckerForms/SpellCheckForm.ascx.vb))
* [SpellCheckOptionsForm.ascx](./CS/WebSite/DevExpress/ASPxSpellCheckerForms/SpellCheckOptionsForm.ascx) (VB: [SpellCheckOptionsForm.ascx](./VB/WebSite/DevExpress/ASPxSpellCheckerForms/SpellCheckOptionsForm.ascx))
* [SpellCheckOptionsForm.ascx.cs](./CS/WebSite/DevExpress/ASPxSpellCheckerForms/SpellCheckOptionsForm.ascx.cs) (VB: [SpellCheckOptionsForm.ascx.vb](./VB/WebSite/DevExpress/ASPxSpellCheckerForms/SpellCheckOptionsForm.ascx.vb))
<!-- default file list end -->
# OBSOLETE - ASPxHtmlEditor – How to insert a link with an image
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3464)**
<!-- run online end -->


<p><strong>OBSOLETE:<br></strong>Starting with version 15.1 custom dialog froms are not supported.<br><br>ASPxHtmlEditor provides a rich API to edit Html content including the capability to operate built-in toolbars. However, sometimes the embedded functionality is not enough, and you may wish to add a custom feature to the default functionality. For instance, ASPxHtmlEditor does not allow end-users to choose an image when inserting a link. Such tasks can be easily implemented by extending built-in dialog forms.</p>
<p>This example illustrates how to enlarge a built-in dialog form, in particular add an image chooser to the InsertLinkForm dialog. To utilize this scenario, perform the following steps:</p>
<p>1. Extract built-in ASPxHtmlEditor dialog forms to your application folder:</p>
<p><em>Design Time -> ASPxHtmlEditor's Smart Tag - > “Copy Default Dialog Forms to the Project" command; </em></p>
<p>2. Add ASPxUploadControl to the InsertLinkForm.ascx page to allow end-users to choose a desired image;<br> 3. Modify the OnOkButtonClick_InsertLinkForm function as follows:<br>   a) If ASPxUploadControl does not contain any file, call the aspxDialogComplete method to insert a link without an image;<br>   b) If ASPxUploadControl contains a file (an upload editor has text), first upload the file and save it to a psychical folder. After completing this operation, call the aspxDialogComplete method to insert a link with an image:</p>


```js
function OnOkButtonClick_InsertLinkForm() {

        if (IsValidFields_InsertLinkForm()) { 

            if (_dxeUplImage.GetText() != "") {

                _dxeUplImage.Upload();

            }

            else {

                aspxDialogComplete(1, GetDialogData_InsertLinkForm(""));

            }

        }

    }

//ASPxClientUploadControl.FilesUploadComplete Event 

function aspxImageLinkUploadComplete(e) {

        aspxDialogComplete(1, GetDialogData_InsertLinkForm(e.callbackData));

} 




```


<p>4. Handle the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxUploadControlASPxUploadControl_FileUploadCompletetopic"><u>ASPxUploadControl.FileUploadComplete</u></a> event to save the uploaded file to the application directory;<br> 5. Send a path of the just saved file to the client side as the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxUploadControlFilesUploadCompleteEventArgs_CallbackDatatopic"><u>CallbackData</u></a> parameter:</p>


```cs
protected void uplImage_FileUploadComplete(object sender,DevExpress.Web.ASPxUploadControl.FileUploadCompleteEventArgs args) {

       try {

           args.CallbackData = SaveUploadFile();

       }

       catch (Exception e) {

           args.IsValid = false;

           args.ErrorText = e.Message;

       }

} 
```


<p> </p>
<p>6. To insert a link with an image, modify the GetDialogData_InsertLinkForm code as follows:</p>


```js
if (image == "") {

    res.text = _dxeTxbText.GetText();

}

else {

    res.text = _dxeTxbText.GetText() + '<img alt="" src="' + image + '" />';

}
```


<p> </p>
<p>The «res» contains text that will be inserted into ASPxHtmlEditor.</p>
<p>By design, ASPxHtmlEditor converts tags (e.g. <img>) to special symbols when inserting text. To prevent this, add the following non-public function to a JavaScript block:</p>

<br/>


