using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace App1
{
    public class MainViewModel : BaseBindable
    {

        private ObservableCollection<BaseBindable> _items;
        public ObservableCollection<BaseBindable> Items
        {
            get
            {
                if (_items == null)
                {
                    _items = new ObservableCollection<BaseBindable>()
                    {
                        new MainLabelItemViewModel()
                        {
                            Text = "Hello1"
                        },
                        new MainLabelItemViewModel()
                        {
                            Text = "Hello2"
                        },
                        new MainDatePickerItemViewModel()
                        {
                            Date = DateTime.Now.AddDays(1)
                        }
                    };
                }

                return _items;
            }

            set
            {
                if (_items != value)
                {
                    _items = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public MainViewModel()
        {

        }
    }
}
