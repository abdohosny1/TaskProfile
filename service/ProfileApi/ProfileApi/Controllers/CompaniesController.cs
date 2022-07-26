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
    public class CompaniesController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public CompaniesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet()]
        [ProducesResponseType(typeof(companies), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<companies>> GetAllExper()
        {

            var res = await _unitOfWork.companiess.GetAll();
            var items = res.Select(i => new companiesDto
            {

                Name = i.Name,



            });
            return Ok(items);
        }
    }
}
