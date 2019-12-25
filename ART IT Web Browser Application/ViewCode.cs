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
    public partial class ViewCode : Form
    {
        public ViewCode(string codefont)
        {
            InitializeComponent();
            _codefont = codefont;
        }
        private string _codefont;
        private void ViewCode_Load(object sender, EventArgs e)
        {
            richTextBox1.AppendText(_codefont);
        }
    }
}
