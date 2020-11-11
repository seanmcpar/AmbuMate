using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AmbuMate.Entities
{
    public class Shift : INotifyPropertyChanged
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

        private int attendantID;

        public int AttendantID
        {
            get { return attendantID; }
            set 
            { 
                attendantID = value;
                OnPropertyChanged("AttendantID");
            }
        }

        private int driverID;

        public int DriverID
        {
            get { return driverID; }
            set 
            { 
                driverID = value;
                OnPropertyChanged("DriverID");
            }
        }

        private int crew;

        public int Crew
        {
            get { return crew; }
            set 
            { 
                crew = value;
                OnPropertyChanged("Crew");
            }
        }

        private string shiftType;

        public string ShiftType
        {
            get { return shiftType; }
            set 
            { 
                shiftType = value;
                OnPropertyChanged("ShiftType");
            }
        }

        private string shiftStatus;

        public string ShiftStatus
        {
            get { return shiftStatus; }
            set 
            { 
                shiftStatus = value;
                OnPropertyChanged("ShiftStatus");
            }
        }

        private DateTime shiftDate;

        public DateTime ShiftDate
        {
            get { return shiftDate; }
            set 
            { 
                shiftDate = value;
                OnPropertyChanged("ShiftDate");
            }
        }

        private DateTime startTime;

        public DateTime StartTime
        {
            get { return StartTime; }
            set 
            {
                startTime = value;
                OnPropertyChanged("StartTime");
            }
        }

        private DateTime endTime;

        public DateTime EndTime
        {
            get { return endTime; }
            set 
            { 
                endTime = value;
                OnPropertyChanged("EndTime");
            }
        }

        private string notes;

        public string Notes
        {
            get { return notes; }
            set 
            {
                notes = value;
                OnPropertyChanged("Notes");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public static async void Insert(Shift shift)
        {
            await App.MobileService.GetTable<Shift>().InsertAsync(shift);
        }
        public static async void Update(Shift shift)
        {
            await App.MobileService.GetTable<Shift>().UpdateAsync(shift);
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}
