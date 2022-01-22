using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using System.Linq;

namespace AvaloniaSample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            var fontComboBox = this.Find<ComboBox>("fontComboBox");
            fontComboBox.Items = FontManager.Current.GetInstalledFontFamilyNames().Select(x => new FontFamily(x));
            fontComboBox.SelectedIndex = 0;
        }
    }
}
