using System;

namespace App1
{
    public class MainDatePickerItemViewModel : BaseBindable
    {
        private DateTime _date;
        public DateTime Date
        {
            get
            {
                return _date;
            }

            set
            {
                if (_date != value)
                {
                    _date = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}