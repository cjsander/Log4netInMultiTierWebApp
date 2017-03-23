using System.Collections.Generic;
using System.Web.Http;
using log4net;
using Log4netSample.Data;
using Log4netSample.Model;

namespace Log4netSample.Controllers
{
    public class Log4netSampleController : ApiController
    {
        private readonly ILog _logger = LogManager.GetLogger("LogDebug");

        [System.Web.Http.Route("api/getmedia")]
        [HttpGet]
        public IEnumerable<Media> Get()
        {
            _logger.Debug("LOG: Getting Data.");
            return new MediaData().GetAllMedia();
            
        }

        [System.Web.Http.Route("api/getmediabyid")]
        [HttpGet]
        // GET: api/Log4netSample/5
        public Media GetById(int id)
        {
            return new MediaData().GetMediaById(id);
        }
    }
}

