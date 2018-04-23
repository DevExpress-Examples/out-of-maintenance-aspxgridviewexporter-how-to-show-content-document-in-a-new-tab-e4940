using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        string fileName = "PDF/" + Request.QueryString["Name"];
        string filePath = Server.MapPath(fileName);

        Response.AddHeader("Content-Disposition", "inline;filename=" + Request.QueryString["Name"]);
        Response.ContentType = "application/pdf";
        Response.TransmitFile(filePath);
        Response.End();
    }
}