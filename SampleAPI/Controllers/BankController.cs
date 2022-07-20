using Microsoft.AspNetCore.Mvc;
using SampleAPI.Models;

namespace SampleAPI.Controllers
{
    [ApiController]
    public class BankController : ControllerBase
    {
        [Route("GetMaster")]
        public string GetMaster()
        {
            return "Sricharan";
        }

        [Route("GetBankByID/{ID:Int:Min(1)}")]
        [HttpGet]
        public ActionResult <Bank> GetBankByID(int bankID)
        {
            var BankData = new Bank
            {
                bankID = 1,
                bankName = "SBI",
                bankBranch = "V.House"
            };
            if(BankData != null)
            {
                return Ok(BankData);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
