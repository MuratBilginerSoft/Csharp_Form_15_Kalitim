using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalıtım
{
    public partial class Form1 : Form
    {
        AnaSınıf AS = new AnaSınıf();

        public Form1()
        {
            InitializeComponent();
        }

        public static void Main()
        {
            int sonuc;
            sonuc = Aritmetik.Toplama(5, 6);
        }

        private static void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = AS.Toplama(5, 6).ToString(); ;
        }
    }
}
