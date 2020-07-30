using ClassProject_V1._0.FormVisualStuff;
using MovieAPIPCL.Abstraction.Models;
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
using System.Windows.Media.Imaging;

namespace ClassProject_V1._0.Forms
{
    public partial class MovieDetailsPage : Form
    {
        public MovieDetailsPage()
        {
            InitializeComponent();
            pictureBox1.Region = Region.FromHrgn(Roundანგლეს.CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 30, 30));
        }

        public void Setup(IMovieDetail i_movie)
        {
           
            pictureBox1.Load(i_movie.Poster_path);
            //
            var tt = new PictureBox();
            tt.Load(i_movie.backDropPath);
            mainPanel.BackgroundImage = tt.Image;
            //
           // BitmapImage gg = new BitmapImage( new Uri(i_movie.backDropPath));
           // mainPanel.BackgroundImage = Image.
            mainPanel.BackgroundImageLayout = ImageLayout.Center;
            tableLayoutPanel1.BackColor = Color.FromArgb(100, 255, 189, 44);
            tableLayoutPanel2.BackColor = Color.FromArgb(80, 255, 189, 44);

            SetMovieRating(i_movie.Vote_average);
            lbl_moviename.Text = i_movie.Original_title;
     

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


    }
}
