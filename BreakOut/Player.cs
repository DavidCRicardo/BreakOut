using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BreakOut
{
    class Player : INotifyPropertyChanged
    {
        private double _xposition;

        public double XPosition
        {
            get { return _xposition; }
            set
            {
                _xposition = value;
                OnPropertyChanged("XPosition");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
