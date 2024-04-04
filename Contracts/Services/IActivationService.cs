namespace DidUP_for_Windows_11.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
