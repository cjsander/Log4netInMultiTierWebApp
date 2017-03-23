using System.Collections.Generic;
using System.Linq;
using log4net;
using Log4netSample.Model;

namespace Log4netSample.Data
{
    public class MediaData
    {
        private readonly ILog _logger = LogManager.GetLogger("LogDebug");
        public List<Media> GetAllMedia()
        {
            _logger.Debug("Starting GetAllMedia.");
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

            _logger.Debug("Ending GetAllMedia");

            return listMedia;

        }

        public Media GetMediaById(int searchId)
        {
            _logger.Debug("Starting GetMediaById.");
            List<Media> listMedia = GetAllMedia();

            IEnumerable<Media> media = from m in listMedia
                where m.Id == searchId
                select m;
            _logger.Debug("Ending GetMediaById");
            return media.FirstOrDefault();
        }
    }
}
