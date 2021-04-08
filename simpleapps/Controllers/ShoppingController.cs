using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using simpleapps.Models;
using simpleapps.Context;

namespace simpleapps.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        #region shopping
        private readonly DataContext _dataContext;

        public ShoppingController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public IEnumerable<shopping> GetShopping()
        {
            return _dataContext.shoppings;
        }

        [HttpGet("{id}", Name = "GetShopping")]
        public shopping GetShopping(string id)
        {
            return _dataContext.shoppings.SingleOrDefault(x => x.id == id);
        }

        [HttpPost]
        public void AddShopping([FromBody] shopping item)
        {
            item.id = DateTime.Now.ToString("yyMMdd") + "shop";
            _dataContext.shoppings.Add(item);
            _dataContext.SaveChanges();
        }

        [HttpPut]
        public void UpdateShopping([FromBody] shopping item)
        {
            _dataContext.shoppings.Update(item);
            _dataContext.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void DeleteShopping(string id)
        {
            var item = _dataContext.shoppings.FirstOrDefault(x => x.id == id);
            if (item != null)
            {
                _dataContext.shoppings.Remove(item);
                _dataContext.SaveChanges();
            }
        }

        #endregion
    }
}
