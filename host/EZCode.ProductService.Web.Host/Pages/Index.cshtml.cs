using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace EZCode.ProductService.Pages;

public class IndexModel : ProductServicePageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
