using project006.MVC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project006
{
    public partial class Form1 : Form
    {
        private BusSystem busSystem;
        private BusSystemController controller;

        public Form1()
        {
            InitializeComponent();
            busSystem = new BusSystem(numDevices: 4, numLines: 3);
            BusSystemView view = new BusSystemView(busSystem, devicesTextBox, linesTextBox, packetsTextBox);
            controller = new BusSystemController(busSystem, view);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // controller.UpdateSystem();
        }

        private void addDeviceButton_Click(object sender, EventArgs e)
        {
            string device = deviceTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(device))
            {
                controller.AddDevice(device);
            }
        }

        private void addLineButton_Click(object sender, EventArgs e)
        {
            controller.AddLine();
        }

        private void removeDeviceButton_Click(object sender, EventArgs e)
        {
            string device = deviceTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(device))
            {
                controller.RemoveDevice(device);
            }
        }

     

        private void generatePacketButton_Click(object sender, EventArgs e)
        {
            string v = senderTextBox.Text.Trim();
            
            string receiver = receiverTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(v) && !string.IsNullOrEmpty(receiver))
            {
                controller.GenerateDataPacket(v, receiver);
            }
        }

        private void calculateStatisticsButton_Click(object sender, EventArgs e)
        {
            controller.CalculateStatistics();
        }

       
    }

}

