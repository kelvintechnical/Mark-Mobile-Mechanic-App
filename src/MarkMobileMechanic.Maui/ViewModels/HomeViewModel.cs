namespace MarkMobileMechanic.Maui.ViewModels;

public class HomeViewModel : BaseViewModel
{
    private string _welcomeMessage = "Welcome to Mark Mobile Mechanic";

    public string WelcomeMessage
    {
        get => _welcomeMessage;
        set
        {
            if (_welcomeMessage != value)
            {
                _welcomeMessage = value;
                OnPropertyChanged();
            }
        }
    }
}
