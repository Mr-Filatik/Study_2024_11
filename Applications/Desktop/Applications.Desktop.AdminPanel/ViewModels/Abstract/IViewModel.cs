namespace Applications.Desktop.AdminPanel.ViewModels.Abstract;

public interface IViewModel
{
    public Func<string, string, bool> MessageBoxYesNo { get; set; }
}
