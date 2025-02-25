using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using T_Tier.BLL.Interfaces;
using T_Tier.BLL.Wrappers;

namespace T_Tier.API.Controllers.v2;

[ApiVersion("2")]
public class PostsController(IPostService postService) : BaseApiController
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [SwaggerOperation(Summary = "Rota de Teste de Versionamento")]
    public async Task<IActionResult> VersioningTest()
    {
        var response = new Response<string>("Rota de Teste de Versionamento");

        return response.Type switch
        {
            ResponseTypeEnum.Success => Ok(response),
            ResponseTypeEnum.NotFound => NotFound(response),
            _ => StatusCode(StatusCodes.Status500InternalServerError, response)
        };
    }

    [AllowAnonymous]
    [HttpGet("Teste")]
    public IActionResult Test()
    {
        return Ok("Teste");
    }

    [AllowAnonymous]
    [HttpGet("TesteDB")]
    public async Task<IActionResult> GetAllPosts()
    {
        var response = await postService.GetAllPost();

        return response.Type switch
        {
            ResponseTypeEnum.Success => Ok(response),
            ResponseTypeEnum.NotFound => NotFound(response),
            _ => StatusCode(StatusCodes.Status500InternalServerError, response)
        };
    }
}