using NetCore_DemoConverterParameter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore_DemoConverterParameter.ViewModels
{
    public class MainViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private Genres? _genre;

        public Genres? Genre
        {
            get
            {
                return _genre;
            }

            set
            {
                if (_genre != value)
                {
                    _genre = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Genre)));
                }
            }
        }

        public MainViewModels()
        {
            Genre = Genres.Femme;
        }
    }
}
