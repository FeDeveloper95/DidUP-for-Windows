using DidUP_for_Windows_11.Contracts.Services;
using DidUP_for_Windows_11.ViewModels;

using Microsoft.UI.Xaml;

namespace DidUP_for_Windows_11.Activation;

public class DefaultActivationHandler : ActivationHandler<LaunchActivatedEventArgs>
{
    private readonly INavigationService _navigationService;

    public DefaultActivationHandler(INavigationService navigationService)
    {
        _navigationService = navigationService;
    }

    protected override bool CanHandleInternal(LaunchActivatedEventArgs args)
    {
        // None of the ActivationHandlers has handled the activation.
        return _navigationService.Frame?.Content == null;
    }

    protected async override Task HandleInternalAsync(LaunchActivatedEventArgs args)
    {
        _navigationService.NavigateTo(typeof(AreaStudentiViewModel).FullName!, args.Arguments);

        await Task.CompletedTask;
    }
}
