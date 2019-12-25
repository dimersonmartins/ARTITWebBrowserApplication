using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ART_IT_Web_Browser_Application.Auth
{
    class Authentication
    {
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
        public async Task<string> AuthASC()
        {
            string asc_key_remote = GenereteKey(8);
            InternetSetCookieEx("https://netsales.netservicos.com.br/NETSales/j_security_check", null, "asc-key-remote=" + asc_key_remote, 0, 0);
            InternetSetCookieEx("https://www.atlas.netservicos.com.br/nethome/", null, "asc-key-remote=" + asc_key_remote, 0, 0);
            return await request(asc_key_remote);
        }
        private string GenereteKey(int length)
        {
            Random random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public async Task<string> request(string asc_key_remote)
        {
            string url = @"https://updateasc.netservicos.com.br/home/portal.do";

            Dictionary<string, string> form_data = new Dictionary<string, string>
            {
                { "token", "20160708*Artit@ASCWebBrowserV1.1" },
                { "login","Enter Here" }
            };

            HttpClient client = new HttpClient(
                new HttpClientHandler {
                    UseCookies = false, AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
                });
            client.Timeout = TimeSpan.FromHours(2);

            string[] AcceptEncoding = new string[] { "gzip", "deflate" };

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", "*/*");
            client.DefaultRequestHeaders.Add("Accept-Language", "pt-BR");
            client.DefaultRequestHeaders.Add("Accept-Encoding", AcceptEncoding);
            client.DefaultRequestHeaders.Add("Referer", "wanet01.netservicos.com.br");
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)");
            client.DefaultRequestHeaders.Add("Host", "updateasc.netservicos.com.br");
            client.DefaultRequestHeaders.Add("Cookie", "asc-key-remote=" + asc_key_remote + ";BIGipServerpool_netascs_https=2244091146.47873.0000; BIGipServerPOOL-ASC_HTTPS=370744586.20480.0000; BIGipServerpool_netasc_https=2193759498.47873.00");

            HttpContent content = new FormUrlEncodedContent(form_data);
            HttpResponseMessage response = await client.PostAsync(url, content);
            var contents = await response.Content.ReadAsStringAsync();
            HttpContentHeaders headers = content.Headers;

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    return contents;
                }
                catch (Exception)
                {
                    return "error";
                }
            }
            else
            {
                return "error";
            }
        }
    }
}
