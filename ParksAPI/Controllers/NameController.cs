using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using ParksAPI.Models;

namespace ParksAPI.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class NameController : ControllerBase
  {
    private readonly IJwtAuthenticationManager jwtAuthenticationManager;

    public NameController(IJwtAuthenticationManager jwtAuthenticationManager)
    {
      this.jwtAuthenticationManager = jwtAuthenticationManager;
    }



    //GET: api/Name
    // public IEnumerable<string> Get()
    // {
    //   return new string[] { "value1", "value2" };
    // }

    // GET: api/Name/5
    // [HttpGet("{id}", Name = "Get")]
    // public string Get(int id)
    // {
    //   return "value";
    // }

    [AllowAnonymous]
    [HttpPost("authenticate")]
    public IActionResult Authenticate([FromBody] UserCred userCred)
    {
      var token = jwtAuthenticationManager.Authenticate(userCred.Username, userCred.Password);
      if (token == null)
        return Unauthorized();
      return Ok(token);

      //I think this is what he meant to write.
      // if (token == null)
      // {
      //   return Unauthorized();
      // }
      // else 
      // {
      //   return Ok(token);
      // }
    }
  }
}