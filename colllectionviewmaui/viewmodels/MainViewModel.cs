using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using collectionviewmaui.models;

namespace collectionviewmaui.viewmodels
{
    public class MainViewModel
    {
        private ObservableCollection<Model> _items;
        private ICommand selectCommand;

        public ObservableCollection<Model> Items => _items;
        public ICommand SelectCommand => selectCommand;

        public MainViewModel()
        {
            this.selectCommand = new Command<Model>(this.OnSelect);

            _items = new ObservableCollection<Model>();

            for (int i = 0; i < 20; i++)
            {
                _items.Add(new Model($"Element {i}", $"subtitle {i}"));
            }
        }

        private void OnSelect(Model model)
        {
            model.IsVisible = !model.IsVisible;
        }
    }
}

