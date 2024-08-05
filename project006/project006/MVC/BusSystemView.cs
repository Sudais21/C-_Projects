using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project006.MVC
{
     class BusSystemView
    {
        private BusSystem busSystem;
        private TextBox devicesTextBox;
        private TextBox linesTextBox;
        private TextBox packetsTextBox;

        public BusSystemView(BusSystem busSystem, TextBox devicesTextBox, TextBox linesTextBox, TextBox packetsTextBox)
        {
            this.busSystem = busSystem;
            this.devicesTextBox = devicesTextBox;
            this.linesTextBox = linesTextBox;
            this.packetsTextBox = packetsTextBox;
        }

        public void UpdateSystem()
        {
            
            string v = string.Join(", ", busSystem.Devices);
            devicesTextBox.Text = v;
            linesTextBox.Text = busSystem.Lines.ToString();
            packetsTextBox.Text = busSystem.DataPackets.ToString();
        }

        public void DisplayStatistics(double averageWaitingTime)
        {
            MessageBox.Show("Average Waiting Time: " + averageWaitingTime);
        }
    }
}

