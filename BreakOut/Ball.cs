using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

class Ball : INotifyPropertyChanged
{
    private double _x;
    private double _y;


    public double X
    {
        get { return _x; }
        set
        {
            _x = value;
            OnPropertyChanged("X");
        }
    }

    public double Y
    {
        get { return _y; }
        set
        {
            _y = value;
            OnPropertyChanged("Y");
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChangedEventHandler handler = PropertyChanged;
        if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
    }
}