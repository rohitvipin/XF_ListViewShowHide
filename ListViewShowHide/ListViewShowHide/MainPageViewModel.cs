using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace ListViewShowHide
{
    internal class MainPageViewModel : INotifyPropertyChanged
    {
        private IEnumerable<ColorEntity> _colors;
        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {

            var nameToColor = new Dictionary<string, Color>
            {
                { "Aqua", Color.Aqua },
                { "Black", Color.Black },
                { "Blue", Color.Blue },
                { "Fucshia", Color.Fuchsia },
                { "Gray", Color.Gray },
                { "Green", Color.Green },
                { "Lime", Color.Lime },
                { "Maroon", Color.Maroon },
                { "Navy", Color.Navy },
                { "Olive", Color.Olive },
                { "Purple", Color.Purple },
                { "Red", Color.Red },
                { "Silver", Color.Silver },
                { "Teal", Color.Teal },
                { "White", Color.White },
                { "Yellow", Color.Yellow }
            };

            Colors = nameToColor.Select(x => new ColorEntity
            {
                Color = x.Value,
                Name = x.Key
            });
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public IEnumerable<ColorEntity> Colors
        {
            get { return _colors; }
            set
            {
                _colors = value;
                OnPropertyChanged();
            }
        }
    }

    internal class ColorEntity
    {
        public string Name { get; set; }
        public Color Color { get; set; }
    }
}