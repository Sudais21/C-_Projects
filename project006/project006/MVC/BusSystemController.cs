using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project006.MVC
{
    class BusSystemController
    {
        private BusSystem busSystem;
        private BusSystemView view;

        public BusSystemController(BusSystem busSystem, BusSystemView view)
        {
            this.busSystem = busSystem;
            this.view = view;
        }

        public void AddDevice(string device)
        {
            busSystem.AddDevice(device);
            view.UpdateSystem();
        }

        public void AddLine()
        {
            busSystem.AddLine();
            view.UpdateSystem();
        }

        public void RemoveDevice(string device)
        {
            busSystem.RemoveDevice(device);
            view.UpdateSystem();
        }

        

        public void RemoveLine(Line line)
        {
            busSystem.RemoveLine(line);
            view.UpdateSystem();
        }

        public void GenerateDataPacket(string sender, string receiver)
        {
            busSystem.GenerateDataPacket(sender, receiver);
            view.UpdateSystem();
        }

        public void CalculateStatistics()
        {
            double averageWaitingTime = busSystem.GetAverageWaitingTime();
            view.DisplayStatistics(averageWaitingTime);
        }
    }
}


