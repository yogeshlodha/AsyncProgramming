using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AsyncProgramming.Controllers
{
    public class ThreadTaskController : Controller
    {
        /// <summary>
        /// Sleep method, process wait for 8 second. 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> ASleepMethod()
        {
            // 8 Second sleep.
            await Task.Delay(8000);
            return true;
        }

        /// <summary>
        /// Async process wait for responce.
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> AsyncLoad()
        {
          var tBool=  await ASleepMethod();
            return View();
        }

        /// <summary>
        /// Sync process do not wait for sleep responce.
        /// </summary>
        /// <returns></returns>
        public ActionResult SyncLoad()
        {
            var tBool = ASleepMethod();
            return View();
        }
    }
}