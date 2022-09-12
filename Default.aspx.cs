using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cloudcliper
{
    public partial class Default : System.Web.UI.Page
    {
        public static string text = "";
        public static string filename = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tbtext.Text = text;

            }
            btnFileDownload.Text = filename;
        }

        protected void btntextsubmit_Click(object sender, EventArgs e)
        {
             text= tbtext.Text;
            lbTextSaveMsg.Text = "保存时间"+DateTime.Now.ToString();
        }

        protected void btnfilesubmit_Click(object sender, EventArgs e)
        {
            string filepath = Server.MapPath("tempfile");
            if (fufile.HasFile)
            {
                if (File.Exists(filepath))
                {
                    File.Delete(filepath);
                }
                fufile.SaveAs(filepath);
                filename = fufile.FileName;
                btnFileDownload.Text = filename;
                lbFileSaveMsg.Text = "保存时间" + DateTime.Now.ToString();
            }
        }

        protected void btnFileDownload_Click(object sender, EventArgs e)
        {
            string filepath = Server.MapPath("tempfile");
            FileStream fs = new FileStream(filepath, FileMode.Open);
            byte[] bytes = new byte[(int)fs.Length];
            fs.Read(bytes, 0, bytes.Length);
            fs.Close();
            Response.ContentType = "application/octet-stream";
            //通知浏览器下载文件而不是打开
            Response.AddHeader("Content-Disposition", "attachment;  filename=" + HttpUtility.UrlEncode(filename, System.Text.Encoding.UTF8));
            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();



        }
    }
}