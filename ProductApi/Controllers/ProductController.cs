using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace ProductApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{

		[HttpGet]
		public ActionResult<IEnumerable<string>> Get() {

			return new string[] {"ürün1","ürün2" };
		
		}
	}
}
