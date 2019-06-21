<!-- default file list -->
*Files to look at*:

* [ResponseHelper.cs](./CS/WebSite/App_Code/ResponseHelper.cs) (VB: [ResponseHelper.vb](./VB/WebSite/App_Code/ResponseHelper.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
* [Default2.aspx](./CS/WebSite/Default2.aspx) (VB: [Default2.aspx](./VB/WebSite/Default2.aspx))
* [Default2.aspx.cs](./CS/WebSite/Default2.aspx.cs) (VB: [Default2.aspx.vb](./VB/WebSite/Default2.aspx.vb))
<!-- default file list end -->
# ASPxGridViewExporter - How to show content document in a new tab
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4940/)**
<!-- run online end -->


<p>To accomplish this tack I suggest you implement the following:</p><p>- Write PDF to the server with <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewExportASPxGridViewExporter_WritePdftopic">ASPxGridViewExporter.WritePdf</a>;</p><p>- Redirect to the new tab with custom <a href="http://msdn.microsoft.com/en-us/library/ms524309(v=vs.90).aspx">Response.Redirect</a> wrapper;</p><p>- Display the PDF on the page.<strong></strong></p><p><strong>See also:</strong><strong><br />
</strong><a href="https://www.devexpress.com/Support/Center/p/E3919">ASPxTreeList - How to download a file by clicking a custom command button</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E2577">How to load a file on the callback of the ASPxGridView using the ASPxWebControl.RedirectOnCallback method</a></p>

<br/>


