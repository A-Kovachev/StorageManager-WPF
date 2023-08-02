using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageTracker
{
    public class Item : INotifyPropertyChanged
    {
        private string _name = "name";
        private double _price;
        private int _quantity;
        private bool _isChecked;

        public event PropertyChangedEventHandler? PropertyChanged;

        public Item(string name, int quantity, double pricePerUnit)
        {
            Name = name;
            Quantity = quantity;
            PricePerUnit = pricePerUnit;
        }
        public string Name
        {
            get { return _name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentNullException("Name must be longer than 3 symbols.");
                }
                else
                {
                    _name = value;
                }
            }
        }
        public int Quantity 
        {
            get { return _quantity; }
            set
            {
                if(_quantity != value)
                {
                    if(value < 0)
                    {
                        _quantity = 0;
                    }
                    else
                    {
                        _quantity = value;
                    }
                    OnPropertyChanged(nameof(Quantity));
                }
            }
        }   
        public double PricePerUnit
        {
            get { return _price; }
            set
            {
                if(_price != value)
                {
                    if (value <= 0)
                    {
                        _price = 0;
                    }
                    else
                    {
                        _price = value;
                    }
                    OnPropertyChanged(nameof(PricePerUnit));
                }
            }
        }
        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                if (_isChecked != value)
                {
                    _isChecked = value;
                    OnPropertyChanged(nameof(IsChecked));
                }
            }
        }

        protected virtual void OnPropertyChanged(string IsChecked)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(IsChecked));
        }
        protected virtual void OnPropertyChanged(int Quantity)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Quantity.ToString()));
        }
        protected virtual void OnPropertyChanged(double PricePerUnit)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PricePerUnit.ToString()));
        }

    }
}
