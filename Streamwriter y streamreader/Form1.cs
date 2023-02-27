using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Streamwriter_y_streamreader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            using (StreamReader re = new StreamReader(@"C:\Users\pc\OneDrive\Documentos\2do semestre\Streamwriter y streamreader\Streamwriter y streamreader\TextoWR.txt"))
            {
                while(!re.EndOfStream)
                {
                    rtbCampo.AppendText(re.ReadLine());
                }
            }
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            using(StreamWriter wr = new StreamWriter(@"C:\Users\pc\OneDrive\Documentos\2do semestre\Streamwriter y streamreader\Streamwriter y streamreader\TextoWR.txt"))
            {
                wr.WriteLine((rtbCampo.Text));
            }
        }

        private void rtbCampo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
