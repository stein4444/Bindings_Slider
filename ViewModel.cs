using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Argb_Slider_bindings
{
    public class ViewModel
    {
        ColorARGB colorARGB = new ColorARGB();
        private ICollection<ColorARGB> collection = new ObservableCollection<ColorARGB>();
        public ViewModel()
        {
            collection.Add(new ColorARGB() { A = 100, R = 110, G = 110, B = 110});
            SelectedColor = new ColorARGB()
            {

            };
        }
        public IEnumerable<ColorARGB> ColorARGBs => collection;
        public ColorARGB SelectedColor { get; set; }

        public void AddColor()
        {
            if (SelectedColor != null)
            {
                collection.Add(new ColorARGB()
                {
                    A = SelectedColor.A,
                    R = SelectedColor.R,
                    G = SelectedColor.G,
                    B = SelectedColor.B,
                });
            }
        }
        public void RemoveColor()
        {
            if (SelectedColor != null)
                collection.Remove(SelectedColor);
        }
    }
}
