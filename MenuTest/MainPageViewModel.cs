using CommunityToolkit.Mvvm.Input;

namespace MauiApp1.ViewModel;

public partial class MainPageViewModel
{
    [RelayCommand]
    public static void DoSomething()
    {
        // This point is never hit without workaround
        return;
    }
}