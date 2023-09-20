using Atomas2.Contracts.Items;
using Atomas2.Contracts.Modules;
using Atomas2.Models.Items;
using Atomas2.Models.Web;
using Atomas2.Models.Web.BaseRes;
using Atomas2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Atomas2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private IItemModule Module;
        public ItemController(IItemModule module)
        {
            Module = module;
        }

        [HttpGet("nextItem")]
        public BaseResult GetNextItem() => ResultService<Item>.GetResult(() => (Item)Module.GetNextItem());

        [HttpPost("updateMax")]

        public BaseResult UpdateMax(WebNumber MaxAtom) => ResultService.GetResult(() => Module.UpdateMax(MaxAtom.Value));
    }
       
}