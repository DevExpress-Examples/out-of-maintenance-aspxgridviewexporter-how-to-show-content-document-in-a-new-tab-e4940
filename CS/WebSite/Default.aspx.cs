using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using System.IO;

public partial class _Default : System.Web.UI.Page {
    private static string fileName = "myFile.pdf";
    private static string folder = HttpContext.Current.Server.MapPath("~/PDF");
    private static string fullPath = Path.Combine(folder, "myFile.pdf");

    protected void Page_Init(object sender, EventArgs e) {
        gv.DataSource = Enumerable.Range(0, 9).Select(i => new {
            CategoryID = i,
            CategoryName = "CategoryName" + i,
            Description = "Description" + i
        });
        gv.DataBind();
    }

    protected void btn_Click(object sender, EventArgs e) {
        using (FileStream fileStream = File.Create(fullPath)) {
            exporter.WritePdf(fileStream);
        }

        string url = String.Format("Default2.aspx?Name={0}", fileName);
        Response.Redirect(url, "_blank", "");
    }
}