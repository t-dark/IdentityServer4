using IdentityServer4.Models;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Host.Pages
{
    public class ErrorModel : PageModel
    {
        private readonly IIdentityServerInteractionService _interactionService;

        public ErrorMessage Error { get; set; }

        public ErrorModel(IIdentityServerInteractionService interactionService)
        {
            _interactionService = interactionService;
        }

        public async Task OnGet(string errorId)
        {
            // retrieve error details from identityserver
            Error = await _interactionService.GetErrorContextAsync(errorId);
        }
    }
}