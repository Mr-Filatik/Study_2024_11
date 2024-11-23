using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Desktop.AdminPanel.ViewModels;

/// <summary>
/// Base class for ViewModels
/// </summary>
public class ViewModel
{
    public Func<string, string, bool>? MessageBoxShow { get; set; }
    public Action? CloseWindow { get; set; }
}
