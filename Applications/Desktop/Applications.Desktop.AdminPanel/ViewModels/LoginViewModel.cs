using Applications.Desktop.AdminPanel.Commands;
using Applications.Desktop.AdminPanel.ViewModels.Abstract;
using System.ComponentModel;

namespace Applications.Desktop.AdminPanel.ViewModels;

public class LoginViewModel : INotifyPropertyChanged, ILoginViewModel
{
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
        if (!string.IsNullOrEmpty(LoginField) && !string.IsNullOrEmpty(PasswordField))
        {
            MessageBoxYesNo?.Invoke("Work", "Test");

            //MessageBox.Show("Work"); //лучше отсюда не вызывать уведомления

            //LoginField = "LoginField";
            //PasswordField = "PasswordField";
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
