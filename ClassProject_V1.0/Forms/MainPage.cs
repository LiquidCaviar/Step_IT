using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassProject_V1._0
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPage_WhatsPopularPanel1.AddMovieCard(textBox1.Text, Convert.ToInt32(textBox2.Text));
        }
    }
}
