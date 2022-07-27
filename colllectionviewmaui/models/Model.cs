using System;
using System.ComponentModel;
using System.Diagnostics;

namespace collectionviewmaui.models
{
    public class Model : INotifyPropertyChanged
    {
        private bool isVisible;

        public event PropertyChangedEventHandler PropertyChanged;

        public Model(string title, string subtitle)
        {
            this.Title = title;
            this.Subtitle = subtitle;
            this.isVisible = true;
        }

        public string Title { get; private set; }

        public string Subtitle { get; private set; }

        public bool IsVisible
        {
            get => this.isVisible;
            set
            {
                if (value != this.isVisible)
                {
                    this.isVisible = value;
                    this.OnPropertyChanged(nameof(IsVisible));
                }
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            Debug.Assert(propertyName != null);

            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

