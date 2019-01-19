using Microsoft.AspNetCore.Mvc;
using participate_registration.Models.DTOs;

namespace participate_registration.Controllers
{
    [Route("register")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        #region GetTemplates
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> IsUsernameTaken(int id)
        //{
        //    return "value";
        //}
        #endregion

        #region POST actions
        [HttpPost("new-user")]
        public IActionResult OnBoardNewUser([FromBody] InsertUser requestedUser)
        {
            if (ModelState.IsValid)
            {
                //Call Lambda

                return Ok($"Successfully created new user: {requestedUser.UserName}");
            }

            return BadRequest(ModelState);
        }
        #endregion

        #region UpdateTemplates
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}
        #endregion

        #region DeleteTempate
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
        #endregion
    }
}
