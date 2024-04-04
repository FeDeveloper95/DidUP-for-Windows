using Microsoft.UI.Xaml.Controls;

namespace DidUP_for_Windows_11.Helpers;

public static class FrameExtensions
{
    public static object? GetPageViewModel(this Frame frame) => frame?.Content?.GetType().GetProperty("ViewModel")?.GetValue(frame.Content, null);
}
