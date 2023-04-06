﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace EZCode.CustomerService.Web.Pages;

public class IndexModel : CustomerServicePageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
