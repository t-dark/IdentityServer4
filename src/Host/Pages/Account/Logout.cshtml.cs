using IdentityServer4.Quickstart.UI;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Host.Pages.Account
{
    public class LogoutModel : PageModel
    {
        public bool ShowLogoutPrompt { get; set; } = true;

        [BindProperty]
        public LogoutInputModel Input { get; set; }

        public class LogoutInputModel
        {
            public string LogoutId { get; set; }
        }
        
        public async Task<IActionResult> OnGet(string logoutId)
        {
            // build a model so the logout page knows what to display
            await BuildModelAsync(logoutId);

            if (ShowLogoutPrompt)
            {
                return Page();
            }

            return await OnPost();
        }

        public async Task<IActionResult> OnPost()
        {
            // build a model so the logged out page knows what to display
            //var vm = await BuildLoggedOutViewModelAsync(model.LogoutId);

            if (User?.Identity.IsAuthenticated == true)
            {
                // delete local authentication cookie
                await HttpContext.SignOutAsync();

                // raise the logout event
                //await _events.RaiseAsync(new UserLogoutSuccessEvent(User.GetSubjectId(), User.GetDisplayName()));
            }

            // check if we need to trigger sign-out at an upstream identity provider
            //if (vm.TriggerExternalSignout)
            //{
            //    // build a return URL so the upstream provider will redirect back
            //    // to us after the user has logged out. this allows us to then
            //    // complete our single sign-out processing.
            //    string url = Url.Action("Logout", new { logoutId = vm.LogoutId });

            //    // this triggers a redirect to the external provider for sign-out
            //    return SignOut(new AuthenticationProperties { RedirectUri = url }, vm.ExternalAuthenticationScheme);
            //}

            //return View("LoggedOut", vm);

            return null;
        }

        private async Task BuildModelAsync(string logoutId)
        {
            //ShowLogoutPrompt = AccountOptions.ShowLogoutPrompt;
            //Input = new LogoutInputModel
            //{
            //    LogoutId = logoutId
            //};

            //if (User?.Identity.IsAuthenticated != true)
            //{
            //    // if the user is not authenticated, then just show logged out page
            //    ShowLogoutPrompt = false;
            //    return;
            //}

            //var context = await _interaction.GetLogoutContextAsync(logoutId);
            //if (context?.ShowSignoutPrompt == false)
            //{
            //    // it's safe to automatically sign-out
            //    vm.ShowLogoutPrompt = false;
            //    return vm;
            //}

            //// show the logout prompt. this prevents attacks where the user
            //// is automatically signed out by another malicious web page.
            //return vm;
        }
    }
}