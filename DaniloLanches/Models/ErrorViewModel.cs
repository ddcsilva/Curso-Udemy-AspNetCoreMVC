namespace DaniloLanches.Models;

/// <summary>
/// Classe responsável por representar o view model de erro
/// </summary>
public class ErrorViewModel
{
    public string RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
