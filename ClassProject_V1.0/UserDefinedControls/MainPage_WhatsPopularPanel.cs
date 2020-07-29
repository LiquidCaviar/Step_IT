using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using ClassProject_V1._0.FormVisualStuff;
using MovieAPIPCL.Implementation.Models;
using MovieAPIPCL.Abstraction.Models;
using MovieAPIPCL.Implementation.Services;

namespace ClassProject_V1._0.UserDefinedControls
{
    public partial class MainPage_WhatsPopularPanel : UserControl
    {
        private Action GetPopularMoviesOnTV;
        private Action GetPopularMoviesInTheaters;
        public MainPage_WhatsPopularPanel()
        {
            InitializeComponent();
            button1.Region = Region.FromHrgn(Roundანგლეს.CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 40, 40));
            button2.Region = Region.FromHrgn(Roundანგლეს.CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 40, 40));
            ActivateButton(button1);
            DeactivateButton(button2);

            button1.Visible = false;
            button2.Visible = false;
        }

        public void AddMovieCard(IFrontMediaModel movie_info)
        {
            flowLayoutPanel1.Controls.Add(new MovieCard());
            (flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1] as MovieCard).SetMoviePoster(movie_info.Image);
            (flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1] as MovieCard).SetMovieRating(movie_info.Rate);
            (flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1] as MovieCard).SetMovieDate(movie_info.ReleaseDate);
            (flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1] as MovieCard).SetMovieName(movie_info.MediaTitle);
            (flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1] as MovieCard).SetMovieID(movie_info.Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender as Button);
            DeactivateButton(button2);
            //LoadPopularMoviesOnTV?.Invoke();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender as Button);
            DeactivateButton(button1);
        }
        private void DeactivateButton(Button i_button)
        {
            i_button.BackColor = Color.Transparent;
            i_button.ForeColor = Color.Black;
        }
        private void ActivateButton(Button i_button)
        {

            i_button.BackColor = Color.FromArgb(3, 37, 65);
            i_button.ForeColor = Color.FromArgb(81, 226, 181);
        }

        public void SetHeadlineText(string text)
        {
            label1.Text = text;
        }

        private void LoadPopularMoviesOnTV()
        {
           // ServiceContainer.CustomServiceContainer.GetService<MovieService>().get;
        }

        private void LoadPopularMoviesInTheaters()
        {

        }

    }
}
