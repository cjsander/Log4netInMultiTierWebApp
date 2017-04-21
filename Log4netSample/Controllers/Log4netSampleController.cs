using System.Collections.Generic;
using System.Web.Http;
using log4net;
using Log4netSample.Data;
using Log4netSample.Model;
using Log4netSample.Util;

namespace Log4netSample.Controllers
{
    public class Log4netSampleController : ApiController
    {
        private readonly ILog _logger = LogManager.GetLogger("LogDebug");
        private readonly Log4NetHelper _msg = new Log4NetHelper();

        [System.Web.Http.Route("api/getmedia")]
        [HttpGet]
        public IEnumerable<Media> Get()
        {
            _logger.Debug(_msg.LogMsg(Log4NetHelper.Message.InitialGetRequestStart));
            return new MediaData().GetAllMedia();
        }

        [System.Web.Http.Route("api/getmediabyid")]
        [HttpGet]
        // GET: api/Log4netSample/5
        public Media GetById(int id)
        {
            
            _logger.Debug(_msg.LogMsg(Log4NetHelper.Message.InitialGetRequestStart));
            return new MediaData().GetMediaById(id);
        }
    }
}

