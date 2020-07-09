using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_operator
{
    public partial class FormTechView : Form
    {
        public FormTechView(string title, int sEngine, int sClutch, int sDoors, int sBody, int sWheel)
        {
            InitializeComponent();
            titleLabel.Text = title;
            statusEngine.Text = sEngine.ToString();
            statusClutch.Text = sClutch.ToString();
            statusDoors.Text = sDoors.ToString();
            statusBody.Text = sBody.ToString();
            statusWheels.Text = sWheel.ToString();
        }

        public FormTechView(string title, string sEngine, string sClutch, string sDoors, string sBody, string sWheel)
        {
            InitializeComponent();
            titleLabel.Text = title;
            statusEngine.Text = sEngine;
            statusClutch.Text = sClutch;
            statusDoors.Text = sDoors;
            statusBody.Text = sBody;
            statusWheels.Text = sWheel;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
