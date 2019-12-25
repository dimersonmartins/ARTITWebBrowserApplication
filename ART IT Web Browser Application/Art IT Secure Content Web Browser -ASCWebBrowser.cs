using ART_IT_Web_Browser_Application.Auth;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ART_IT_Web_Browser_Application
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        WebBrowser     MyAsc          = new WebBrowser();
        Authentication authentication = new Authentication();

        [DllImport("wininet.dll")]
        static extern InternetCookieState InternetSetCookieEx(
          string lpszURL,
          string lpszCookieName,
          string lpszCookieData,
          int dwFlags,
          int dwReserved);
        enum InternetCookieState : int
        {
            COOKIE_STATE_UNKNOWN = 0x0,
            COOKIE_STATE_ACCEPT = 0x1,
            COOKIE_STATE_PROMPT = 0x2,
            COOKIE_STATE_LEASH = 0x3,
            COOKIE_STATE_DOWNGRADE = 0x4,
            COOKIE_STATE_REJECT = 0x5,
            COOKIE_STATE_MAX = COOKIE_STATE_REJECT
        }
        public async void AuthASC(string url)
        {
            string asc_key_remote = GenereteKey(8);
            InternetSetCookieEx(url, null, "asc-key-remote=" + asc_key_remote, 0, 0);
        }
        private string GenereteKey(int length)
        {
            Random random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            auth();
            //MyAsc.DocumentText = formData();
            //MyAsc.Dock = DockStyle.Fill;
            //container.Controls.Clear();
            //container.Controls.Add(MyAsc);
           
            //MyAsc.DocumentCompleted += MyAsc_DocumentCompleted;
            //MyAsc.Navigate("http://aflinemao.fs.ngestor.com/");
            // auth();
        }


        private string formData()
        {
            StringBuilder form = new StringBuilder();
            form.AppendLine("<form action=\"https://updateasc.netservicos.com.br/home/portal.do\" method=\"post\">");
            form.AppendLine("<input type=\"text\" name=\"token\" value=\"20160708*Artit@ASCWebBrowserV1.1\">");
            form.AppendLine("<input type=\"text\" name=\"login\" value=\"Enter Here\">");
            form.AppendLine("<input type=\"submit\" value=\"Submit\">");
            form.AppendLine("</form>");
            return form.ToString();
        }
          

        private async void auth()
        {
            MyAsc.ScriptErrorsSuppressed = true;
            MyAsc.NewWindow += MyAsc_NewWindow;
            string html = await authentication.AuthASC();

            MyAsc.DocumentText = html.Replace("<link href=\"./", "<link href=\"https://updateasc.netservicos.com.br/home/")
            .Replace("src=\"./common/imgs/asc/logo_america_movel_net_claro_embratel.png", "src=\"https://updateasc.netservicos.com.br/home/common/imgs/asc/logo_america_movel_net_claro_embratel.png");
            MyAsc.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(MyAsc);
          
        }

        private void MyAsc_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                AuthASC(MyAsc.Document.Url.ToString());
                MessageBox.Show(MyAsc.Document.Url.ToString());
                MessageBox.Show(MyAsc.Document.Cookie.ToString());
            }
            catch { }
           
        }


        [DllImport("wininet.dll", SetLastError = true)]
        public static extern bool InternetGetCookieEx(
        string url,
        string cookieName,
        StringBuilder cookieData,
        ref int size,
        Int32 dwFlags,
        IntPtr lpReserved);

        private const Int32 InternetCookieHttponly = 0x2000;

        /// <summary>
        /// Gets the URI cookie container.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <returns></returns>
        public static CookieContainer GetUriCookieContainer(Uri uri)
        {
            CookieContainer cookies = null;
            // Determine the size of the cookie
            int datasize = 8192 * 16;
            StringBuilder cookieData = new StringBuilder(datasize);
            if (!InternetGetCookieEx(uri.ToString(), null, cookieData, ref datasize, InternetCookieHttponly, IntPtr.Zero))
            {
                if (datasize < 0)
                    return null;
                // Allocate stringbuilder large enough to hold the cookie
                cookieData = new StringBuilder(datasize);
                if (!InternetGetCookieEx(
                    uri.ToString(),
                    null, cookieData,
                    ref datasize,
                    InternetCookieHttponly,
                    IntPtr.Zero))
                    return null;
            }
            if (cookieData.Length > 0)
            {
                cookies = new CookieContainer();
                cookies.SetCookies(uri, cookieData.ToString().Replace(';', ','));
            }
            return cookies;
        }

        private string varHtml = "";
        private void MyAsc_NewWindow(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
           // WebBrowser webBrowser_temp = (WebBrowser)sender;
            //string newUrl = webBrowser_temp.Document.ActiveElement.GetAttribute("href");
            //MyAsc.Url = new Uri(newUrl);

          
        }

        private void btn_app_Click(object sender, EventArgs e)
        {
            auth();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            MyAsc.GoBack();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MyAsc.GoForward();
        }
        private void btn_stop_Click(object sender, EventArgs e)
        {
            MyAsc.Stop();
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            MyAsc.Refresh();
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            auth();
        }
        private void aboutASCWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about_AscWebBrowser about_AscWebBrowser = new about_AscWebBrowser();
            about_AscWebBrowser.ShowDialog();
        }

        private void btn_code_Click(object sender, EventArgs e)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(MyAsc.DocumentText);
            HtmlAgilityPack.HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//frame[@src]");

            try
            {
                foreach (HtmlAgilityPack.HtmlNode node in nodes)
                {
                    //  HtmlAgilityPack.HtmlAttribute attr = node.Attributes["input"];
                    varHtml += node.InnerHtml;
                }

                ViewCode viewCode = new ViewCode(varHtml);
                viewCode.ShowDialog();
            }
            catch { }
            
        }
    }
}
