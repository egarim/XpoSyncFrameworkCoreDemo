using BIT.Data.Sync.AspNetCore.Controllers;
using BIT.Data.Sync.Server;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.WebApi.Sync
{
    [Route("[controller]")]
    //[Route("custom/[controller]")]
    [ApiController]
    public class SyncController : SyncControllerBase
    {
        public SyncController(ILogger<SyncControllerBase> logger, ISyncServer SyncServer) : base(logger, SyncServer)
        {
        }
        [HttpGet()]
        public string Get()
        {
            return "Hello SyncFramework XPO";
        }
        public override Task<string> Fetch(string startIndex, string identity)
        {
            Task<string> task = base.Fetch(startIndex, identity);
            return task;
        }
        public override Task<string> Push()
        {
            return base.Push();
        }

    }
}
