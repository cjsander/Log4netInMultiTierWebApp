using System;
using System.Collections.Generic;
using System.Linq;
using log4net;
using Log4netSample.Model;
using Log4netSample.Util;

namespace Log4netSample.Data
{
    public class MediaData
    {
        private readonly ILog _logger = LogManager.GetLogger("LogDebug");
        private readonly Log4NetHelper _msg = new Log4NetHelper();

        public List<Media> GetAllMedia()
        {
            _logger.Debug(_msg.LogMsg(Log4NetHelper.Message.DbCallStart));
            var listMedia = new List<Media>();

            var media = new Media
            {
                Id = 1,
                Title = "Halo: Guardians",
                Genre = Genre.Shooter,
                MediaType = MediaType.Game,
                Platform = Platform.Xbox
            };
            ;
            var media2 = new Media
            {
                Id = 2,
                Title = "Les Miserables",
                Genre = Genre.Fiction,
                MediaType = MediaType.Print,
                Platform = Platform.Book
            };
            var media3 = new Media
            {
                Id = 3,
                Title = "Napoleon Dynamite",
                Genre = Genre.Comedy,
                MediaType = MediaType.DVD,
                Platform = Platform.Movie
            };
            listMedia.Add(media);
            listMedia.Add(media2);
            listMedia.Add(media3);

            _logger.Debug(_msg.LogMsg(Log4NetHelper.Message.DbCallEnd));
            _logger.Debug(_msg.LogMsg(Log4NetHelper.Message.InitialGetRequestStop));
            return listMedia;

        }

        public Media GetMediaById(int searchId)
        {
            _logger.Debug(_msg.LogMsg(Log4NetHelper.Message.DbCallStart));
            IEnumerable<Media> media = new List<Media>();

            try
            {
                if (searchId == 1111)
                {
                    throw new Exception("Invalid ID");
                }
                var listMedia = GetAllMedia();
                media = from m in listMedia
                        where m.Id == searchId
                        select m;
            }
            catch (System.Exception ex)
            {
                _logger.Error(_msg.LogMsg(Log4NetHelper.Message.Error, ex.Message));
                return null;

            }
            _logger.Debug(_msg.LogMsg(Log4NetHelper.Message.DbCallEnd));
            _logger.Debug(_msg.LogMsg(Log4NetHelper.Message.InitialGetRequestStop));
            return media.FirstOrDefault();
        }
    }
}
