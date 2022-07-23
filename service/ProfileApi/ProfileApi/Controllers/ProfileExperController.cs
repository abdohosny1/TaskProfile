using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProfileApi.dto;
using ProfileWithCore;
using ProfileWithCore.Model;
using System.Net;
using System.Threading.Tasks;

namespace ProfileApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileExperController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProfileExperController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet(Name = "Get ProfileExpriences")]
        [ProducesResponseType(typeof(ProfileExprience), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<ProfileExprience>> GetAllExper()
        {

           var res= await _unitOfWork.ProfileExpriences.GetAll();
            return Ok(res);
        }

        //[HttpPost(Name = "Add ProfileExprience")]
        //[ProducesResponseType(typeof(ProfileExprience), (int)HttpStatusCode.OK)]

        //public  async Task<ActionResult<ProfileExprience>> AddExper([FromForm] ProfileExprience exprience)
        //{
        //    if(ModelState.IsValid) return BadRequest();
        //    //var profileExprience = new ProfileExprience()
        //    //{
        //    //    Branch = exprience.Branch,
        //    //    CompanyName = exprience.CompanyName,
        //    //    Description = exprience.Description,
        //    //    EndDate = exprience.EndDate,
        //    //    StartDate = exprience.StartDate,
        //    //    Id = exprience.Id,
        //    //    Titiles.




        //    //};
        //    var res =  _unitOfWork.ProfileExpriences.Add(exprience);
        //    return Ok(res);
        //}


    }
}
