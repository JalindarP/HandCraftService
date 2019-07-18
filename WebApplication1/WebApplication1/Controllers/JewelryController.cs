using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Repository.Contracts;

namespace Jewelry
{
    [Route("api/jewelry")]
    [ApiController]
    public class JewelryController : ControllerBase
    {

        private readonly IJewelryRepositorycs _jewelryRepository;

        public JewelryController(IJewelryRepositorycs jewelryRepository)
        {
            _jewelryRepository = jewelryRepository;
        }
        /// <summary>
        /// Get jewelery details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<JewelryItem>> Get()
        {
            var response = _jewelryRepository.GetItems();
            return Ok(response);
        } 
    }
}
