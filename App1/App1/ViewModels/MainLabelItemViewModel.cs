using System;

namespace App1
{
    public class MainLabelItemViewModel : BaseBindable
    {
        private string _text;
        public string Text
        {
            get
            {
                return _text;
            }

            set
            {
                if (_text != value )
                {
                    _text = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}