using System.ComponentModel;
namespace Argb_Slider_bindings
{
    public class ColorARGB : INotifyPropertyChanged
    {
        private byte a;
        private byte r;
        private byte g { get; set; }
        private byte b { get; set; }
        public string Color => System.Windows.Media.Color.FromArgb(A, R, G, B).ToString();

        
        public byte A
        {
            get => a;
            set
            {
                if (a != value)
                {
                    a = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(A)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Color)));
                }
            }
        }
        public byte R
        {
            get => r;
            set
            {
                if (r != value)
                {
                    r = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(R)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Color)));
                }
            }
        }
        public byte G
        {
            get => g;
            set
            {
                if (g != value)
                {
                    g = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(G)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Color)));
                }
            }
        }
        public byte B
        {
            get => b;
            set
            {
                if (b != value)
                {
                    b = value;
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
