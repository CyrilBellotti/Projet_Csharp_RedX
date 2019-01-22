using CoucheMiddlewareApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couche_Client
{
    public partial class MessageAlerte : Form
    {
        private PerfData perfData;
        
        public MessageAlerte()
        {
            InitializeComponent();
            this.perfData = new PerfData();
        }




        public void button1_Click_1(object sender, EventArgs e)
        {
            Comparaison compare = new Comparaison();
            int text1;
            int text2;
            int text3;

            Console.WriteLine(perfData.getAllStates()[1]);
            text1 = Convert.ToInt32(perfData.getAllStates()[1]);
          //  text1 = Convert.ToInt32(textBox1.Text);
            compare.CPUtest = text1;

            text2 = Convert.ToInt32(textBox2.Text);
            compare.RAMtest = text2;

            text3 = Convert.ToInt32(textBox3.Text);
            compare.Disktest = text3;

            compare.VerifTotal();
        }
    }
}
