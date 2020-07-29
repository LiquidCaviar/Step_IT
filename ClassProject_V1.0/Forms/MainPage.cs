using ClassProject_V1._0.FormVisualStuff;
using MovieAPIPCL.Implementation.Services;
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
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // mainPage_WhatsPopularPanel1.AddMovieCard(textBox1.Text, Convert.ToInt32(textBox2.Text));
          
        }

        private async void StartUpTopRated()
        {
            mainPage_WhatsPopularPanel1.BackColor = Color.FromArgb(53, 53, 55);
            mainPage_WhatsPopularPanel1.Region = Region.FromHrgn(Roundანგლეს.CreateRoundRectRgn(0, 0, mainPage_WhatsPopularPanel2.Width, mainPage_WhatsPopularPanel2.Height, 30, 30));
            var gg = (await ServiceContainer.CustomServiceContainer.GetService<MovieService>().GetPopularMoviesPagenationAsync()).ToList();
            gg.Select(x=> { mainPage_WhatsPopularPanel1.AddMovieCard(x); return x; }).ToList(); 
        }

        private async void StartUpTrending()
        {
            mainPage_WhatsPopularPanel2.BackColor = Color.FromArgb(14, 195, 201);
            mainPage_WhatsPopularPanel2.Region = Region.FromHrgn(Roundანგლეს.CreateRoundRectRgn(0, 0, mainPage_WhatsPopularPanel2.Width, mainPage_WhatsPopularPanel2.Height, 30, 30));
            mainPage_WhatsPopularPanel2.SetHeadlineText("Trending");
            var cc = (await ServiceContainer.CustomServiceContainer.GetService<MovieService>().GetTrendingMoviesAsync("week")).ToList();
            cc.Select(x => { mainPage_WhatsPopularPanel2.AddMovieCard(x); return x; }).ToList();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            StartUpTopRated();
            StartUpTrending();
        }
    }
}
