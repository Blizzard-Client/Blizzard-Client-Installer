using System.Windows.Input;
using DynamicData;
using ReactiveUI;

namespace BlizzardInstaller.ViewModels;

public class MainWindowViewModel : PageViewmodelBase
{
    public override bool CanNavigateNext
    {
        get => true;
        protected set {}
    }

    public override bool CanNavigatePrev
    {
        get => false;
        protected set {}
    }
    
    public MainWindowViewModel()
    {
        _CurrentPage = Pages[0];

        var canNavNext = this.WhenAnyValue(x => x.CurrentPage.CanNavigateNext);
        var canNavPrev = this.WhenAnyValue(x => x.CurrentPage.CanNavigatePrev);

        NavigateNextCommand = ReactiveCommand.Create(NavigateNext, canNavNext);
        NavigatePreviousCommand = ReactiveCommand.Create(NavigatePrevious, canNavPrev);
    }

    private readonly PageViewmodelBase[] Pages =
    {
        new EulaWindowViewModel(),
    };

    private PageViewmodelBase _CurrentPage;
    
    public PageViewmodelBase CurrentPage
    {
        get { return _CurrentPage; }
        private set { this.RaiseAndSetIfChanged(ref _CurrentPage, value); }
    }

    public ICommand NavigateNextCommand { get; }

    private void NavigateNext()
    {
        var index = Pages.IndexOf(CurrentPage) + 1;

        CurrentPage = Pages[index];
    }

    public ICommand NavigatePreviousCommand { get; }

    private void NavigatePrevious()
    {
        var index = Pages.IndexOf(CurrentPage) - 1;

        CurrentPage = Pages[index];
    }
}
