
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AmbuMate.Entities
{
    public class Vehicle : INotifyPropertyChanged
    {
        private string id;

        public string Id
        {
            get { return id; }
            set 
            { 
                id = value;
                OnPropertyChanged("Id");
            }
        }

        private string registration;

        public string Registration
        {
            get { return registration; }
            set 
            { 
                registration = value;
                OnPropertyChanged("Registration");
            }
        }

        private string shiftID;

        public string ShiftID
        {
            get { return shiftID; }
            set 
            { 
                shiftID = value;
                OnPropertyChanged("ShiftID");
            }
        }

        private int startMileage;

        public int StartMileage
        {
            get { return startMileage; }
            set 
            { 
                startMileage = value;
                OnPropertyChanged("StartMileage");
            }
        }

        private string lights;

        public string Lights
        {
            get { return lights; }
            set 
            { 
                lights = value;
                OnPropertyChanged("Lights");
            }
        }

        private string signals;

        public string Signals
        {
            get { return signals; }
            set 
            { 
                signals = value;
                OnPropertyChanged("Signals");
            }
        }

        private string sirens;

        public string Sirens
        {
            get { return sirens; }
            set 
            { 
                sirens = value;
                OnPropertyChanged("Sirens");
            }
        }

        private string fireExtinguisher;

        public string FireExtinguisher
        {
            get { return fireExtinguisher; }
            set 
            { 
                fireExtinguisher = value;
                OnPropertyChanged("FireExtinguisher");
            }
        }

        private string warningTriangle;

        public string WarningTriangle
        {
            get { return warningTriangle; }
            set 
            { 
                warningTriangle = value;
                OnPropertyChanged("WarningTriangle");
            }
        }

        private string fireBlanket;

        public string FireBlanket
        {
            get { return fireBlanket; }
            set 
            { 
                fireBlanket = value;
                OnPropertyChanged("FireBlanket");
            }
        }

        private string clean;

        public string Clean
        {
            get { return clean; }
            set 
            {
                clean = value;
                OnPropertyChanged("Clean");
            }
        }

        private string deepClean;

        public string DeepClean
        {
            get { return deepClean; }
            set 
            { 
                deepClean = value;
                OnPropertyChanged("DeepClean");
            }
        }

        private int fuel;

        public int Fuel
        {
            get { return fuel; }
            set 
            { 
                fuel = value;
                OnPropertyChanged("Fuel");
            }
        }

        private int endMileage;

        public int EndMileage
        {
            get { return endMileage; }
            set 
            {
                endMileage = value;
                OnPropertyChanged("EndMileage");
            }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set 
            { 
                status = value;
                OnPropertyChanged("Status");
            }
        }

        private string vehicleNotes;

        public string VehicleNotes
        {
            get { return vehicleNotes; }
            set 
            { 
                vehicleNotes = value;
                OnPropertyChanged("VehicleNotes");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public static async void Insert(Vehicle vehicle)
        {
            await App.MobileService.GetTable<Vehicle>().InsertAsync(vehicle);
        }

        public static async void Update(Vehicle vehicle)
        {
            await App.MobileService.GetTable<Vehicle>().UpdateAsync(vehicle);
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
