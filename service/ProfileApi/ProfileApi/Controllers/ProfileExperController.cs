﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProfileApi.dto;
using ProfileWithCore;
using ProfileWithCore.Model;
using System.Linq;
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

        [HttpGet()]
        [ProducesResponseType(typeof(ProfileExprience), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<ProfileExprience>> GetAllExper()
        {

            var res = await _unitOfWork.ProfileExpriences.GetAll();
            var items = res.Select(i => new ProfileExperinceDto
            {
                Id=i.Id,
                Title=i.Title,
                Branch=i.Branch,
                CompanyName=i.CompanyName,
                Description=i.Description,
                EndDate=i.EndDate,
                ProfiletId=i.ProfiletId,
                StartDate=i.StartDate
            });
            return Ok(items);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(ProfileExprience), (int)HttpStatusCode.OK)]

        public async Task<ActionResult<ProfileExperinceDto>> AddExper([FromForm] ProfileExperinceDto exprience)
        {
         //   if (ModelState.IsValid) return BadRequest();
            var profileExprience = new ProfileExprience()
            {
                Branch = exprience.Branch,
                CompanyName = exprience.CompanyName,
                Description = exprience.Description,
                EndDate = exprience.EndDate,
                StartDate = exprience.StartDate,
                Title = exprience.Title,
                ProfiletId = exprience.ProfiletId

            };
            var res =await _unitOfWork.ProfileExpriences.Add(profileExprience);
            return Ok(res);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ProfileExprience), (int)HttpStatusCode.OK)]

        public async Task<ActionResult> DeleteProfile(int id)
        {
            if (id == null) return NotFound();
            var item = await _unitOfWork.ProfileExpriences.GetById(id);

            if (item == null)
            {
                return NotFound($"Not found Id ={id}");
            }
            else
            {
                await _unitOfWork.ProfileExpriences.DeleteAsync(id);
                return Ok();
            }
        }

        //  [ProducesResponseType(typeof(ProfileExprience), (int)HttpStatusCode.OK)]
        [HttpPut("{id}")]
        public async Task<IActionResult> update(int id, [FromBody] ProfileExperinceDto experinceDto)
        {
            if (id == null) return NotFound();
            var item = await _unitOfWork.ProfileExpriences.GetById(id);

            if (item == null)
            {
                return NotFound($"Not found Id ={id}");
            }
            else
            {
                item.ProfiletId = experinceDto.ProfiletId;
                item.StartDate = experinceDto.StartDate;
                item.EndDate = experinceDto.EndDate;
                item.CompanyName = experinceDto.CompanyName;
                item.Branch = experinceDto.Branch;
                item.Title = experinceDto.Title;
                item.Description = experinceDto.Description;
                await _unitOfWork.ProfileExpriences.update(item);
                return Ok(item);

            }

        }


    }




        }







