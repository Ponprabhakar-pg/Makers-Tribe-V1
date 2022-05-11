using Microsoft.AspNetCore.Mvc;
using CFCApiService.Interface;
using Microsoft.Extensions.Logging;
using System;
using CFCApiModal;

namespace MakersTribeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CFCController : Controller
    {
        private readonly ILogger<CFCController> _logger;
        private readonly IClientService _clientService;
        private readonly IFreelancerService _freelancerService;
        public CFCController(IClientService clientService, IFreelancerService freelancerService, ILogger<CFCController> logger)
        {
            _clientService = clientService;
            _freelancerService = freelancerService;
            _logger = logger;
        }
        
        [HttpGet("get")]
        public IActionResult Index()
        {
            return Ok("Welcome to CFC API");
        }

        [HttpPost("registerFreelancer")]
        public IActionResult RegisterFreelancer([FromBody]FreelancerModal freelancerDetails)
        {
            try
            {
                if (freelancerDetails.Name != null && freelancerDetails.MailId != null && freelancerDetails.PhoneNumber != null && freelancerDetails.Address != null && freelancerDetails.Password != null && freelancerDetails.AccountCreationType != null)
                {
                    var result = _freelancerService.RegisterFreelancer(freelancerDetails);
                    if (!result)
                        return BadRequest("user exist");
                    return Ok(true);
                }
                return BadRequest("invalid request");
            }
            catch(Exception e)
            {
                _logger.LogError(e, "RegisterFreelancer value: {freelancerDetails}", freelancerDetails);
                throw;
            }
        }

        [HttpPost("loginManual")]
        public IActionResult LoginUserManual([FromBody]UserLoginModal userDetails)
        {
            try
            {
                if(userDetails.MailId != null && userDetails.Password != null)
                {
                    var result = _freelancerService.LoginUserManual(userDetails);
                    if (result == "not exist")
                        return BadRequest("user doesn't exist");
                    return Ok(result);
                }
                return BadRequest("invalid request");
            }
            catch(Exception e)
            {
                _logger.LogError(e, "LoginUserManual value: {userDetails}", userDetails);
                throw;
            }
        }

        [HttpGet("getFreelancerByMailId")]
        public IActionResult GetFreelancerByMailId([FromQuery] string mailId)
        {
            try
            {
                if (mailId != null)
                {
                    return Ok(_freelancerService.GetFreelancerByMailId(mailId));
                }
                return BadRequest("invalid request");
            }
            catch (Exception e)
            {
                _logger.LogError(e, "GetFreelancerByMailId value: {mailId}", mailId);
                throw;
            }
        }



        // Client Controllers

        [HttpPost("registerClient")]
        public IActionResult RegisterClient([FromBody] ClientModal clientDetails)
        {
            try
            {
                if (clientDetails.Name != null && clientDetails.MailId != null && clientDetails.PhoneNumber != null && clientDetails.Address != null && clientDetails.Password != null && clientDetails.AccountCreationType != null)
                {
                    var result = _clientService.RegisterClient(clientDetails);
                    if (!result)
                        return BadRequest("user exist");
                    return Ok(true);
                }
                return BadRequest("invalid request");
            }
            catch (Exception e)
            {
                _logger.LogError(e, "RegisterClient value: {clientDetails}", clientDetails);
                throw;
            }
        }

        [HttpGet("getClientByMailId")]
        public IActionResult GetClientByMailId([FromQuery] string mailId)
        {
            try
            {
                if (mailId != null)
                {
                    return Ok(_clientService.GetClientByMailId(mailId));
                }
                return BadRequest("invalid request");
            }
            catch (Exception e)
            {
                _logger.LogError(e, "GetClientByMailId value: {mailId}", mailId);
                throw;
            }
        }
    }
}
