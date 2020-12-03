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
            collection.Add(new ColorARGB(){A = 10, R = 15, G =40,B = 228});
        }
        public IEnumerable<ColorARGB> colorARGBs => collection;
        public ColorARGB SeclectedColor { get; set; }

        public void AddColor()
        {
            if (SeclectedColor != null)
            {
                collection.Add(new ColorARGB()
                {
                    A = SeclectedColor.A,
                    R = SeclectedColor.R,
                    G = SeclectedColor.G,
                    B = SeclectedColor.B,
                });
            }
        }
        public void RemoveColor()
        {
            if (SeclectedColor != null)
                collection.Remove(SeclectedColor);
        }
    }
}
