using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Applications.Desktop.AdminPanel;

public class Login : IDataErrorInfo
{
    public string this[string columnName]
    {
        get
        {
            string error = string.Empty;
            switch (columnName)
            {
                case nameof(LoginField):
                    
                    break;
                case nameof(PasswordField):
                    if (string.IsNullOrEmpty(PasswordField))
                    {
                        error = "Введите пароль!";
                    }
                    break;
            }
            return error;
        }
    }

    public string LoginField { get; set; }
    public string PasswordField { get; set; }

    public string Error => throw new NotImplementedException();
}
