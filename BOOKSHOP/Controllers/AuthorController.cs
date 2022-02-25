using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Models.Request;
using Models.Response;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BOOKSHOP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly ILibrary _library;

        EmptyDataResponse ResponseE;
        GenericResponse<DTO_AUTHOR> Response;

        public AuthorController(ILibrary library)
        {
            _library = library;
        }
        // POST api/<AuthorController>
        [HttpPost]
        public IActionResult Post([FromBody] RqAuthor rqAuthor)
        {
            try
            {
                var result = new object();

                result = _library.InsertAuthor(rqAuthor);
                if (result.GetType().Name.Equals("EmptyDataResponse"))
                {
                    ResponseE = new EmptyDataResponse();
                    ResponseE = (EmptyDataResponse)result;
                }
                else if (result.GetType().Name.Equals("GenericResponse`1"))
                {
                    Response = new GenericResponse<DTO_AUTHOR>();
                    Response = (GenericResponse<DTO_AUTHOR>)result;
                }

                switch (ResponseE != null ? Convert.ToInt32(ResponseE.Notification.Code) :
                       Response != null ? Convert.ToInt32(Response.Notification.Code) : 500)
                {
                    case 200:
                        return Ok(Response);
                    default:
                        return StatusCode(ResponseE != null ? Convert.ToInt32(ResponseE.Notification.Code) : 500,
                                          ResponseE != null ? ResponseE : EmptyDataResponse.Error500);
                }
            }
            catch (Exception e)
            {
                EmptyDataResponse empty500 = EmptyDataResponse.Error500;
                empty500.Notification.Description = e.Message;
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status500InternalServerError, empty500); // Si hubo algún error retorna error del servidor.

            }
        }

    }
}
