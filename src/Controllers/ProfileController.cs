using deno_tpp_dotnet.Models;
using deno_tpp_dotnet.Services;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace deno_tpp_dotnet.Controllers;

[ApiController]
[Route("[controller]")]
public class ProfileController : ControllerBase
{
    private readonly ILogger<ProfileController> _logger;
    private readonly TropiPayService _tropiPay;

    public ProfileController(ILogger<ProfileController> logger, TropiPayService tropiPay)
    {
        _logger = logger;
        _tropiPay = tropiPay;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var result = await _tropiPay.GetProfileAsync();
            return Ok(result);
        }
        catch (HttpRequestException)
        {
            return NotFound();
        }
    }
}
