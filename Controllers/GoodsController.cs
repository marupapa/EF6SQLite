using EF6SQLite.Data;
using EF6SQLite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EF6SQLite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public GoodsController(DataContext context)
        {
            _dataContext = context;
        }
        [HttpPost]
        public async Task<ActionResult<Goods>> AddGoods(AddGoodsDto addGoods)
        {
            _dataContext.Add<Goods>(new Goods
            {
                goodsName = addGoods.goodsName,
                price = addGoods.goodsType,
                goodsType = addGoods.goodsType
            });
            await _dataContext.SaveChangesAsync();
            return Ok(addGoods);
        }

        [HttpGet]
        public async Task<ActionResult<List<Goods>>> GetGoodsList()
        {
            return Ok(await _dataContext.goodsList.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Goods>>> GetGoods(int id)
        {
            return Ok(await _dataContext.goodsList.FindAsync(id));
        }
    }
}

