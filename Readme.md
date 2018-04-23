# ASPxGridViewExporter - How to show content document in a new tab


<p>To accomplish this tack I suggest you implement the following:</p><p>- Write PDF to the server with <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewExportASPxGridViewExporter_WritePdftopic">ASPxGridViewExporter.WritePdf</a>;</p><p>- Redirect to the new tab with custom <a href="http://msdn.microsoft.com/en-us/library/ms524309(v=vs.90).aspx">Response.Redirect</a> wrapper;</p><p>- Display the PDF on the page.<strong></strong></p><p><strong>See also:</strong><strong><br />
</strong><a href="https://www.devexpress.com/Support/Center/p/E3919">ASPxTreeList - How to download a file by clicking a custom command button</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E2577">How to load a file on the callback of the ASPxGridView using the ASPxWebControl.RedirectOnCallback method</a></p>

<br/>


