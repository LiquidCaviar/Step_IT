﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassProject_V1._0.FormVisualStuff;

namespace ClassProject_V1._0.UserDefinedControls
{
    public partial class ActorCard : UserControl
    {
        public ActorCard()
        {
            InitializeComponent();
            pictureBox1.Region = Region.FromHrgn(Roundანგლეს.CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 20, 20));
        }
    }
}
