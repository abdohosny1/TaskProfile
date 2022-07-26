using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProfileApi.dto;
using ProfileWithCore;
using ProfileWithCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ProfileApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitlesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TitlesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet()]
        [ProducesResponseType(typeof(Titiles), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Titiles>> GetAllExper()
        {

            var res = await _unitOfWork.Titiless.GetAll();
            var items = res.Select(i => new TitilesDto
            {

                Name=i.Name,
               


            });
            return Ok(items);
        }
    }
}
