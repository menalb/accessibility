using System.Collections.Specialized;
using System.Web;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

public static class Extensions
{
    public static ValueTask NavigateToFragmentAsync(this NavigationManager navigationManager, IJSRuntime jSRuntime)
    {
        var uri = navigationManager.ToAbsoluteUri(navigationManager.Uri);

        if (uri.Fragment.Length == 0)
        {
            return default;
        }
        return jSRuntime.InvokeVoidAsync("blazorHelpers.scrollToFragment", uri.Fragment.Substring(1));
    }

    public static NameValueCollection QueryString(this NavigationManager navigationManager)
    {
        return HttpUtility.ParseQueryString(new Uri(navigationManager.Uri).Query);
    }

    // get single querystring value with specified key
    public static string QueryString(this NavigationManager navigationManager, string key)
    {
        return navigationManager.QueryString()[key];
    }
}
