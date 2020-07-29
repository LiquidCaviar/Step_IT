using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Http;
using ClassProject_V1._0.FormVisualStuff;
using MovieAPIPCL.Implementation.Services;
using ClassProject_V1._0.Forms;

namespace ClassProject_V1._0.UserDefinedControls
{
    public partial class MovieCard : UserControl
    {
        private int? movieid;
        public MovieCard()
        {
            InitializeComponent();
            pictureBox1.Region = Region.FromHrgn(Roundანგლეს.CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 20, 20));
        }

        public void SetMovieRating(double? MovieRating)
        {

            if (MovieRating > 0 && MovieRating <= 40)
            {
                UpdateCircullarProgressbar(Convert.ToInt32(MovieRating), Color.FromArgb(177, 0, 0));
            }
            else if (MovieRating > 40 && MovieRating <= 60)
            {
                UpdateCircullarProgressbar(Convert.ToInt32(MovieRating), Color.FromArgb(255, 189, 44));

            }
            else if (MovieRating > 60 && MovieRating <= 100)
            {
                UpdateCircullarProgressbar(Convert.ToInt32(MovieRating), Color.FromArgb(24, 160, 94));
            }
            else
            {
                circularProgressBar1.Value = 0;
                circularProgressBar1.Text = $"NR";
            }
        }

        private void UpdateCircullarProgressbar(int Rating, Color PBcolor)
        {
            circularProgressBar1.Value = Rating;
            circularProgressBar1.Text = $"{Rating}%";
            circularProgressBar1.ProgressColor = PBcolor;
        }

        public void SetMovieName(string Mname)
        {
            lbl_name.Text = Mname;
        }

        public void SetMovieDate(DateTime? Mdate)
        {
            lbl_date.Text = Mdate.Value.ToShortDateString().ToString();
        } 

        public void SetMoviePoster(string imagelink)
        { 
            pictureBox1.Load(imagelink);
        }

        public void SetMovieID(int? i_ID)
        {
            movieid = i_ID;
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            var gg = new MovieDetailsPage();
            
            gg.Show();

            gg.Setup(await ServiceContainer.CustomServiceContainer.GetService<MovieService>().GetMovieDetailAsync(movieid.Value));
        }
    }
}
