using DidUP_for_Windows_11.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DidUP_for_Windows_11.Views;

// To learn more about WebView2, see https://docs.microsoft.com/microsoft-edge/webview2/.
public sealed partial class AreaStudentiPage : Page
{
    public AreaStudentiViewModel ViewModel
    {
        get;
    }

    public AreaStudentiPage()
    {
        ViewModel = App.GetService<AreaStudentiViewModel>();
        InitializeComponent();

        ViewModel.WebViewService.Initialize(WebView);
    }
}
