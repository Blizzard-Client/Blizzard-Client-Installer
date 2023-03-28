namespace BlizzardInstaller.ViewModels;

public class EulaWindowViewModel : PageViewmodelBase
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
}