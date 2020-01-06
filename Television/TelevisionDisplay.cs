using System;
using System.Drawing;
using System.Windows.Forms;

namespace Television
{
    public partial class TelevisionDisplay : Form
    {
        private Television television;
        public TelevisionDisplay()
        {
            InitializeComponent();
            channelLabel.Visible = false;
            volumeBar.Visible = false;
            volumeLabel.Visible = false;
        }

        public void SetTelevision(Television television)
        {
            this.television = television;
        }

        public void channelLabel_TextChanged(object sender, EventArgs e)
        {
            channelLabel.Text = "CH " + television.GetChannel();
        }

        public void volumeBar_SizeChanged(object sender, EventArgs e)
        {
            volumeBar.Value = television.GetVolume();
            volumeLabel.Text = television.GetVolume().ToString();
        }

        public void panel1_BackColorChanged(object sender, EventArgs e)
        {
            if (television.GetPower())
            {
                panel1.BackColor = Color.Blue;
                channelLabel.Visible = true;
                volumeBar.Visible = true;
                volumeLabel.Visible = true;
            }

            else
            {
                panel1.BackColor = Color.Black;
                channelLabel.Visible = false;
                volumeBar.Visible = false;
                volumeLabel.Visible = false;
            }
        }
    }
}
