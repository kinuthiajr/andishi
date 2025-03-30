using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Andishi.Core.Entities;
using Andishi.Application.Services.ResponseService;
using Andishi.Core.Interfaces;
using Andishi.Application.Interfaces;
using Andishi.Application.DTOs.Response;

namespace Andishi.API.Controllers
{
    [ApiController]
    public class ResponseApiController : ControllerBase
    {

        private readonly IResponseService _responseService;

        public ResponseApiController(IResponseService responseService)
        {
            _responseService = responseService;
        }

        [HttpGet(ResponseAPIEndpoints.Response.GetAll)]
        public async Task<ActionResult<IEnumerable<Response>>> GetResponses()
        {
            var allResponses = await _responseService.GetAllResponsesAsync();
            return Ok(allResponses);
        }

        [HttpPost(ResponseAPIEndpoints.Response.Create)]
        public async Task<ActionResult<Response>> CreateResponse([FromBody]PostResponseDTO postResponseDTO)
        {
            var newResponse = await _responseService.CreateResponseAsync(postResponseDTO);
            return CreatedAtAction(nameof(GetResponseById), new { id = newResponse.Id }, newResponse);
        }

        [HttpGet(ResponseAPIEndpoints.Response.GetById)]
        public async Task<ActionResult<ResponseDTO>> GetResponseById([FromRoute]Guid id)
        {
            var getResponse = await _responseService.GetResponseByIdAsync(id);
            if (getResponse == null)
            {
                return NotFound();
            }
            return Ok(getResponse);
        }

        [HttpPut(ResponseAPIEndpoints.Response.Update)]
        public async Task<ActionResult<Response>> UpdateResponse([FromRoute]Guid id, [FromBody]UpdateResponseDTO updateResponseDTO)
        {
            var updatedResponse = await _responseService.UpdateResponseAsync(id, updateResponseDTO);
            return Ok(updatedResponse);
        }
            
        [HttpDelete(ResponseAPIEndpoints.Response.Delete)]
        public async Task<ActionResult> DeleteResponse([FromRoute]Guid id)
        {
            await _responseService.DeleteResponseAsync(id);
            return NoContent();
        }
        


    }
}