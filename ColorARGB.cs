using System.ComponentModel;
namespace Argb_Slider_bindings
{
    public class ColorARGB : INotifyPropertyChanged
    {
        public byte A;
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }
        public string Color => System.Windows.Media.Color.FromArgb(A, R, G, B).ToString();

        
        public byte _A
        {
            get => A;
            set
            {
                if (A != value)
                {
                    A = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(A)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Color)));
                }
            }
        }
        public byte _R
        {
            get => R;
            set
            {
                if (R != value)
                {
                    R = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(R)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Color)));
                }
            }
        }
        public byte _G
        {
            get => G;
            set
            {
                if (G != value)
                {
                    R = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(G)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Color)));
                }
            }
        }
        public byte _B
        {
            get => B;
            set
            {
                if (B != value)
                {
                    B = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(B)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Color)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public override string ToString()
        {
            return $"{Color}";
        }


    }
}
