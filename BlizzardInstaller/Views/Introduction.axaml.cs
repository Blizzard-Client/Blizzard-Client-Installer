using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace BlizzardInstaller.Views;

public partial class Introduction : Window
{
    public Introduction()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}