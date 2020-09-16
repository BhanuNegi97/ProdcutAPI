using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.DataAccess;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Repository;
using AutoMapper;
using ProductAPI.DTO;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace ProductAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
   
    public class ProductController : ControllerBase
    {

        private readonly IRepositoryWrapper _IRepositoryWrapper;
        private readonly IMapper _mapper;
       public ProductController(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            _IRepositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        [HttpGet]
       // [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any)]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var products = await _IRepositoryWrapper.Product.GetAllProductAsync();
                var _products = _mapper.Map<IEnumerable<ProductDTO>>(products);
                return Ok(_products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
          
        }



        [HttpGet("getproductbyid/{productId:int}")]

        //[HttpPost("getproductbyid")]
        public async Task<IActionResult> GetByProductId(int productId)
        {
            try
            {

                var products = await _IRepositoryWrapper.Product.GetProductByIdAsync(productId);
                var _products = _mapper.Map<ProductDTO>(products);
                if (_products == null)
                {
                    return NotFound();
                }
                return Ok(_products);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }

        }


        [HttpGet("getproductbyname/{prodname:alpha}")]
      //  [HttpPost("getproductbyname")]
        //[ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any, VaryByQueryKeys = new[] { "prodname" })]
        public async Task<IActionResult> GetByProductName(string prodname)
        
        {
            try
            {

                var products = await _IRepositoryWrapper.Product.GetProductByNameAsync(prodname);
                var _products = _mapper.Map<ProductDTO>(products);
                if (_products == null)
                {
                    return NotFound();
                }
                return Ok(_products);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }

        }
        // [HttpGet("{rearchItem}")]
        [HttpGet("find/{search:alpha}")]
        //[HttpPost("find")]
        public async Task<IActionResult> Search(string search)
        {
            try
            {
             var products = await _IRepositoryWrapper.Product.GetByCondition(search, x => x.name, x => x.price.ToString(), x => x.rating.ToString()).ToListAsync();
                var _products = _mapper.Map<IEnumerable<ProductDTO>>(products);
                if (_products == null)
                {
                    return NotFound();
                }
                return Ok(_products);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }

        }

    }
}
