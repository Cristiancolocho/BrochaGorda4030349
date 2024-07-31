using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;



namespace BrochaGorda4030349
{
    partial class BrochaViewModel : INotifyPropertyChanged
    {

        public double? _area;
        public double? _tasaPorCuadrado;
        public double? _totalCost;


        public double? Area
        {
            get => _area;
            set
            {
                if (_area != value)
                {
                    _area = value;
                    OnPropertyChanged();
                    CalcularTotalCost();
                }
            }
        }

        public double? TasaPorCuadrado
        {
            get => _tasaPorCuadrado;
            set
            {
                if (_tasaPorCuadrado != value)
                {
                    _tasaPorCuadrado = value;
                    OnPropertyChanged();
                    CalcularTotalCost();
                }
            }
        }

        public double? TotalCost
        {
            get => _totalCost;
            private set
            {
                if (_totalCost != value)
                {
                    _totalCost = value;
                    OnPropertyChanged();
                }
            }
        }


        public void CalcularTotalCost()
        {
            TotalCost= Area* TasaPorCuadrado;
          
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
