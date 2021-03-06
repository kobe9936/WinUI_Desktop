---
page_type: template
languages:
  - csharp
  - xaml
products:
  - windows desktop
  - WPF
  - Azure Active Directory
description: Demonstrates WinUI3 Desktop App Interface with new features like WebView2 and NavigationView. Demonstrates OAuth2 for third-party authentication with Azure Active Directory.
---

# WinUI3 

![WinUI_Desktop Screenshot](README_Images/WinUI_Desktop.png)

Shows WinUI3.0 with WebView2 and NavigationView controls. This App is a template interface for Windows Desktop WPF. 


# OAuth2

### OAuth2 for Native Apps scenario 
![Native Apps Screenshot](README_Images/convergence-scenarios-native.png)


It also has an OAuth2 implementation for third-party authentication with Azure Active Directory. To use this favor, you should register your own App in [Azure Active Directory](https://azure.microsoft.com/zh-tw/services/active-directory/) and mark the clientID and Tenant in App.xaml.cs. 

```csharp 
private static string ClientId = "0708f526-5d99-432d-ace8-be7e6bbd963f";
private static string Tenant = "223bcf98-a4ce-4db8-998b-30fb36bd589a";
```

## Related topics
[Windows UI Library 3 Preview 2 (July 2020)](https://docs.microsoft.com/en-us/windows/apps/winui/winui3)                                
[Windows UI Library 2.x (WinUI)](https://docs.microsoft.com/uwp/toolkits/winui/)                                      
[Azure AD Authentication in WPF Application using MSAL](https://manojchoudhari.wordpress.com/2020/05/29/azure-ad-authentication-in-wpf-application-using-msal/)              
[Active-directory-scenario-desktop-acquire-token](https://docs.microsoft.com/zh-tw/azure/active-directory/develop/scenario-desktop-acquire-token?tabs=dotnet)              
[Application types for Microsoft identity platform](https://docs.microsoft.com/en-us/azure/active-directory/develop/v2-app-types)

## Related samples
[WinUI3 XAML Controls Gallery](https://github.com/microsoft/Xaml-Controls-Gallery/tree/winui3preview)                             
[Quickstart: Acquire a token and call Microsoft Graph API from a Windows desktop app](https://docs.microsoft.com/zh-tw/azure/active-directory/develop/quickstart-v2-windows-desktop)  