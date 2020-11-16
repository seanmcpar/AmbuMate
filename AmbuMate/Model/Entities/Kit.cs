using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

namespace AmbuMate.Entities
{
    public class Kit //: INotifyPropertyChanged
    {
        private string id;

        public string Id
        {
            get { return id; }
            set 
            { 
                id = value;
                //OnPropertyChanged("Id");
            }
        }

        private string shiftID;

        public string ShiftID
        {
            get { return shiftID; }
            set { shiftID = value;
                //OnPropertyChanged("ShiftID");
            }
        }

        private string paraBag;

        public string ParaBag
        {
            get { return paraBag; }
            set { paraBag = value;
               // OnPropertyChanged("ParaBag");
            }
        }

        private string drugsBag;

        public string DrugsBag
        {
            get { return drugsBag; }
            set { drugsBag = value;
                //OnPropertyChanged("DrugsBag");
            }
        }

        private string zoll;

        public string Zoll
        {
            get { return zoll; }
            set { zoll = value;
                //OnPropertyChanged("Zoll");
            }
        }

        private string carryChair;

        public string CarryChair
        {
            get { return carryChair; }
            set { carryChair = value;
                //OnPropertyChanged("CarryChair");
            }
        }

        private string wheelchair;

        public string Wheelchair
        {
            get { return wheelchair; }
            set { wheelchair = value;
               // OnPropertyChanged("Wheelchair");
            }
        }

        private string stretcher;

        public string Stretcher
        {
            get { return stretcher; }
            set { stretcher = value;
                //OnPropertyChanged("Stretcher");
            }
        }

        private string vomitBowl;

        public string VomitBowl
        {
            get { return vomitBowl; }
            set { vomitBowl = value;
               // OnPropertyChanged("VomitBowl");
            }
        }

        private string wipes;

        public string Wipes
        {
            get { return wipes; }
            set { wipes = value;
                //OnPropertyChanged("Wipes");
            }
        }

        private string blueRoll;

        public string BlueRoll
        {
            get { return blueRoll; }
            set { blueRoll = value;
               // OnPropertyChanged("BlueRoll");
            }
        }

        private string sheets;

        public string Sheets
        {
            get { return sheets; }
            set { sheets = value;
                //OnPropertyChanged("Sheets");
            }
        }

        private string pillows;

        public string Pillows
        {
            get { return pillows; }
            set { pillows = value;
                //OnPropertyChanged("Pillows");
            }
        }

        private string blankets;

        public string Blankets
        {
            get { return blankets; }
            set { blankets = value;
                //OnPropertyChanged("Blankets");
            }
        }

        private string spo2;

        public string SPO2
        {
            get { return spo2; }
            set { spo2 = value;
               // OnPropertyChanged("SPO2");
            }
        }

        private string bpcuff;

        public string BPCuff
        {
            get { return bpcuff; }
            set { bpcuff = value;
               // OnPropertyChanged("BPCuff");
            }
        }

        private string thermometer;

        public string Thermometer
        {
            get { return thermometer; }
            set { thermometer = value;
                //OnPropertyChanged("Thermometer");
            }
        }

        private string bandages;

        public string Bandages
        {
            get { return bandages; }
            set { bandages = value;
                //OnPropertyChanged("Bandages");
            }
        }

        private string plasters;

        public string Plasters
        {
            get { return plasters; }
            set { plasters = value;
                //OnPropertyChanged("Plasters");
            }
        }

        private string woundDressing;

        public string WoundDressing
        {
            get { return woundDressing; }
            set { woundDressing = value;
                //OnPropertyChanged("WoundDressing");
            }
        }

        private string gauze;

        public string Gauze
        {
            get { return gauze; }
            set { gauze = value;
                //OnPropertyChanged("Gauze");
            }
        }

        private string cleansingWipe;

        public string CleansingWipe
        {
            get { return cleansingWipe; }
            set { cleansingWipe = value;
                //OnPropertyChanged("CleansingWipe");
            }
        }

        private string pinsclips;

        public string PinsClips
        {
            get { return pinsclips; }
            set { pinsclips = value;
                //OnPropertyChanged("PinsClips");
            }
        }

        private string tape;

        public string Tape
        {
            get { return tape; }
            set { tape = value;
                //OnPropertyChanged("Tape");
            }
        }

        private string tweezers;

        public string Tweezers
        {
            get { return tweezers; }
            set { tweezers = value;
                //OnPropertyChanged("Tweezers");
            }
        }

        private string scissors;

        public string Scissors
        {
            get { return scissors; }
            set { scissors = value;
                //OnPropertyChanged("Scissors");
            }
        }

        private string foilBlanket;

        public string FoilBlanket
        {
            get { return foilBlanket; }
            set { foilBlanket = value;
                //OnPropertyChanged("FoilBlanket");
            }
        }

        private string torch;

        public string Torch
        {
            get { return torch; }
            set { torch = value;
               // OnPropertyChanged("Torch");
            }
        }

        private string bvmask;

        public string BVMask
        {
            get { return bvmask; }
            set { bvmask = value;
                //OnPropertyChanged("BVMask");
            }
        }

        private int o2;

        public int O2
        {
            get { return o2; }
            set { o2 = value;
               // OnPropertyChanged("O2");
            }
        }

        private int n2o2;

        public int N2O2
        {
            get { return n2o2; }
            set { n2o2 = value;
                //OnPropertyChanged("N2O2");
            }
        }

        private string kitUsed;

        public string KitUsed
        {
            get { return kitUsed; }
            set { kitUsed = value;
                //OnPropertyChanged("KitUsed");
            }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value;
               // OnPropertyChanged("Status");
            }
        }


       // public event PropertyChangedEventHandler PropertyChanged;

        public static async void Insert(Kit kit)
        {
            await App.MobileService.GetTable<Kit>().InsertAsync(kit);
        }

        public static async void Update(Kit kit)
        {
            await App.MobileService.GetTable<Kit>().UpdateAsync(kit);
        }

        /*private void OnPropertyChanged (string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }*/
    }
}
