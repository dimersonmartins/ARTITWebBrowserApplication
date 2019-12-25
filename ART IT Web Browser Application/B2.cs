using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ART_IT_Web_Browser_Application
{
    public partial class B2 : Form
    {
        public B2()
        {
            InitializeComponent();
        }
        private void B2_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("https://netsales.netservicos.com.br/NETSales/pesquisaEnderecoLogradouros.do?acao=prepareSearch");
        }
    }
}
