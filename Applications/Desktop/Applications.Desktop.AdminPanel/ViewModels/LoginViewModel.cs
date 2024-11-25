using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Desktop.AdminPanel.ViewModels;

public class LoginViewModel : INotifyPropertyChanged
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

    #region Implement INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged(string name = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    #endregion
}
