using Applications.Desktop.AdminPanel.Commands;
using Applications.Desktop.AdminPanel.ViewModels.Abstract;
using Microsoft.Extensions.Logging;
using System.ComponentModel;

namespace Applications.Desktop.AdminPanel.ViewModels;

public class LoginViewModel : INotifyPropertyChanged, ILoginViewModel
{
    private readonly ILogger<LoginViewModel> _logger;

    public LoginViewModel(ILogger<LoginViewModel> logger)
    {
        _logger = logger;
    }

    #region Properties

    private string _loginField;
    public string LoginField
    {
        get
        {
            return _loginField;
        }
        set
        {
            _loginField = value;
            OnPropertyChanged(nameof(LoginField));
        }
    }

    private string _passwordField;
    public string PasswordField
    {
        get
        {
            return _passwordField;
        }
        set
        {
            _passwordField = value;
            OnPropertyChanged(nameof(PasswordField));
        }
    }

    #endregion

    #region Commands

    private ButtonCommand _loginCommand;
    public ButtonCommand LoginCommand
    {
        get
        {
            if (_loginCommand == null)
            {
                _loginCommand = new ButtonCommand(LoginMethod);
            }
            return _loginCommand;
        }
    }

    private void LoginMethod(object? obj)
    {
        try
        {
            _logger.LogInformation($"Login button click. Login: {LoginField}. Password {PasswordField}.");
            if (!string.IsNullOrEmpty(LoginField) && !string.IsNullOrEmpty(PasswordField))
            {
                _logger.LogInformation($"Login for user {LoginField} is OK.");
                MessageBoxYesNo?.Invoke("Work", "Test");

                throw new Exception("Database ERROR.");
                //MessageBox.Show("Work"); //лучше отсюда не вызывать уведомления

                //LoginField = "LoginField";
                //PasswordField = "PasswordField";
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in login.");
        }
    }

    #endregion

    #region Implement INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged(string name = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    #endregion

    #region Implement IViewModel

    public Func<string, string, bool> MessageBoxYesNo { get; set; }

    #endregion
}
