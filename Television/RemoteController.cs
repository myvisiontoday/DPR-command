using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Television
{
    public partial class RemoteController : Form
    {
        private RemoteControl remoteControl;
        private Television television;
        private ICommand powerOnOff;
        private ICommand volumeUp;
        private ICommand volumeDown;
        private ICommand channelUp;
        private ICommand channelDown;
        TelevisionDisplay form;
        public RemoteController()
        {
            InitializeComponent();
            remoteControl = new RemoteControl();
            television = new Television();

            form = new TelevisionDisplay();
            form.BringToFront();
            form.Show();
            form.SetTelevision(television);

            powerOnOff = new PowerCommand(television);
            volumeUp = new VolumeCommand(television, true);
            volumeDown = new VolumeCommand(television, false);
            channelUp = new ChannelCommand(television, true);
            channelDown = new ChannelCommand(television, false);
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            remoteControl.setCommand(powerOnOff);
            remoteControl.executeCommand();
            form.panel1_BackColorChanged(sender, e);
        }

        private void volumeUpButton_Click(object sender, EventArgs e)
        {
            remoteControl.setCommand(volumeUp);
            remoteControl.executeCommand();
            form.volumeBar_SizeChanged(sender, e);
        }

        private void volumeDownButton_Click(object sender, EventArgs e)
        {
            remoteControl.setCommand(volumeDown);
            remoteControl.executeCommand();
            form.volumeBar_SizeChanged(sender, e);
        }

        private void channelUpButton_Click(object sender, EventArgs e)
        {
            remoteControl.setCommand(channelUp);
            remoteControl.executeCommand();
            form.channelLabel_TextChanged(sender, e);
        }

        private void channelDownButton_Click(object sender, EventArgs e)
        {
            remoteControl.setCommand(channelDown);
            remoteControl.executeCommand();
            form.channelLabel_TextChanged(sender, e);
        }
    }
}
