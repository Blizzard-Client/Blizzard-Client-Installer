using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using BlizzardInstaller.ViewModels;
using ReactiveUI;

namespace BlizzardInstaller.Views;

public partial class Introduction : ReactiveUserControl<FirstViewModel>
{
    public Introduction()
    {
        InitializeComponent();
        this.WhenActivated(disposables =>
        {
            this.OneWayBind(ViewModel, x => x.UrlPathSegment, x => x.But)
        });
    }
}