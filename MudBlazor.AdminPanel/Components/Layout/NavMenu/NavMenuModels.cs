using Microsoft.AspNetCore.Components.Routing;

namespace MudBlazor.AdminPanel.Components.Layout.NavMenu;

public record NavItemModel(string? Href = null,
    string? Title = null,
    string? Icon = null,
    NavLinkMatch Match = NavLinkMatch.Prefix, 
    List<NavItemModel>? NavItems = null);
public record NavGropModel(string? Title, List<NavItemModel> NavItems);

