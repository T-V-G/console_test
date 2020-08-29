using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = string.Format("Кол-во: {0}", richTextBox1.Text.Length.ToString());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }

        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel3.Text = string.Format("X={0}, Y={1}", e.X, e.Y);
        }
    }
}
