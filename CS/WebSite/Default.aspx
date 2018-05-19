﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxSpellChecker.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxSpellChecker" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxHtmlEditor ID="ASPxHtmlEditor1" runat="server">
            <SettingsImageSelector>
                <CommonSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></CommonSettings>
            </SettingsImageSelector>
            <SettingsImageUpload>
                <ValidationSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png">
                </ValidationSettings>
            </SettingsImageUpload>
            <SettingsForms InsertImageFormPath="~/DevExpress/ASPxHtmlEditorForms/InsertImageForm.ascx"
                InsertLinkFormPath="~/DevExpress/ASPxHtmlEditorForms/InsertLinkForm.ascx" InsertTableFormPath="~/DevExpress/ASPxHtmlEditorForms/InsertTableForm.ascx"
                PasteFromWordFormPath="~/DevExpress/ASPxHtmlEditorForms/PasteFromWordForm.ascx"
                TableColumnPropertiesFormPath="~/DevExpress/ASPxHtmlEditorForms/TableColumnPropertiesForm.ascx">
                <SpellCheckerForms SpellCheckFormPath="~/DevExpress/ASPxSpellCheckerForms/SpellCheckForm.ascx"
                    SpellCheckOptionsFormPath="~/DevExpress/ASPxSpellCheckerForms/SpellCheckOptionsForm.ascx" />
            </SettingsForms>
        </dx:ASPxHtmlEditor>
    </div>
    </form>
</body>
</html>
