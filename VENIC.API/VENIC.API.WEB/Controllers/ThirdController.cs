using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Services.DocumentType;
using Services.Services.Third;
using Services.Services.ThirdType;
using System.Net.Mime;
using VENIC.API.WEB.Models.DocumentType;
using VENIC.API.WEB.Models.Mapper;
using VENIC.API.WEB.Models.Third;
using VENIC.API.WEB.Models.ThirdType;

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
        private readonly IThirdTypeService thirdTypeService;
        private readonly IDocumentTypeService documentTypeService;

        public ThirdController(IMapper mapper, IThirdService thirdService, IThirdTypeService thirdTypeService, IDocumentTypeService documentTypeService) : base(mapper)
        {
            this.thirdService = thirdService;
            this.thirdTypeService = thirdTypeService;
            this.documentTypeService = documentTypeService;
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

        [HttpGet]
        [AllowAnonymous]
        [Route("third/Type")]
        public async Task<IActionResult> ThirdType()
        {
            try
            {
                List<ResponseThirdType> result = new ThirdTypeMapperAPI().MappResp(await thirdTypeService.GetThirdsType());

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("third/Document")]
        public async Task<IActionResult> DocumentType()
        {
            try
            {
                List<ResponseDocumentType> result = new DocumentTypeMapperAPI().MappResp(await documentTypeService.GetDocumentType());

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }
    }
}
