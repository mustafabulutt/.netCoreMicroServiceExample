using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CustomerApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{

			return new string[] { "müşteri1", "müşteri2" };

		}

	}
}
