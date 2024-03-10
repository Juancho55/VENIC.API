using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Services.Authority;
using Services.Services.Third;
using System.Net.Mime;
using VENIC.API.WEB.Models.Authority;
using VENIC.API.WEB.Models.Mapper;
using VENIC.API.WEB.Models.Third;

namespace VENIC.API.WEB.Controllers
{
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class AuthorityController : BaseController
    {
        private readonly IAuthorityServie authorityServie;

        public AuthorityController(IMapper mapper, IAuthorityServie authorityServie) : base(mapper)
        {
            this.authorityServie = authorityServie;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Authority/Auth")]
        public async Task<IActionResult> Auth([FromBody] RequestAuthorityAPI modelAPI)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                return Ok(new AuthorityMapperAPI().MapRes(await authorityServie.AuthorityAsync(new AuthorityMapperAPI().MapReq(modelAPI))));
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }
    }
}
