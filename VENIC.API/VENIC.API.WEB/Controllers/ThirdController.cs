using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Services.Third;
using System.Net.Mime;
using VENIC.API.WEB.Models.Mapper;
using VENIC.API.WEB.Models.Third;

namespace VENIC.API.WEB.Controllers
{
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]

    public class ThirdController : BaseController
    {
        private readonly IThirdService thirdService;

        public ThirdController(IMapper mapper, IThirdService thirdService) : base(mapper)
        {
            this.thirdService = thirdService;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("third/Save")]
        public async Task<IActionResult> SaveClient([FromBody] RequestThirdModelAPI modelAPI)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                bool result = await thirdService.SaveThirdAsync(new ThirdMapperAPI().MapReq(modelAPI));

                return new Result.CreateResult(result);
            }
            catch(Exception ex)
            {
                return GetErrorresult(ex);
            }
        }
    }
}
