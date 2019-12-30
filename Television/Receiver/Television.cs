using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Television
{
    // The Television class has actual TV operations. It plays the role of a receiver: all commands end up delegating
    // execution to the television's methods.
    public class Television
    {
        private bool power = false;
        private int volume = 20; // initial volume
        private int channel = 0; // initial channel

        public int GetChannel() { return channel; }

        public int GetVolume() { return volume; }

        public bool GetPower() { return power; }

        //method to set power on or off
        public void powerOnOff()
        {
            power = !power;
        }

        //increases the volume by 1
        public void volumeUp()
        {
            if(volume< 100)
                this.volume++;
        }

        //decreases the volume by 1
        public void volumeDown()
        {
            if(volume > 0)
                this.volume--;
        }

        //increases the channel by 1
        public void channelUp()
        {
            if (channel < 500)
                this.channel++;
        }

        //decreases the channel by 1
        public void channelDown()
        {
            if (channel > 0)
                this.channel--;
        }
    }
}
