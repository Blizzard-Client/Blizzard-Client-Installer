namespace BlizzardInstaller.ViewModels;

public abstract class PageViewmodelBase : ViewModelBase
{
    public abstract bool CanNavigateNext { get; protected set; }
    
    public abstract bool CanNavigatePrev { get; protected set; }
}