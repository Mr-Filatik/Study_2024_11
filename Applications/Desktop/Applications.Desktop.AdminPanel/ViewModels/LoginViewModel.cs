using Applications.Desktop.AdminPanel.Commands;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Applications.Desktop.AdminPanel.ViewModels;

public class LoginViewModel : ILoginViewModel
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

    private ButtonCommand? _loginCommand;
    public ButtonCommand LoginCommand
    {
        get
        {
            return _loginCommand ?? (_loginCommand = new ButtonCommand(obj =>
            {
                if (!string.IsNullOrEmpty(LoginField) && !string.IsNullOrEmpty(PasswordField))
                {
                    _logger.LogInformation("Wokr is pressed");
                    MessageBoxShow?.Invoke("Work", "Test");
                }
            }));
        }
    }

    #endregion

    #region Implement ILoginViewModel

    public Func<string, string, bool>? MessageBoxShow { get; set; }
    public Action? CloseWindow { get; set; }

    #endregion

    #region Implement INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string name = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    #endregion
}
