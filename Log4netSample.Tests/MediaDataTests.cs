using Microsoft.VisualStudio.TestTools.UnitTesting;
using Log4netSample.Model;

namespace Log4netSample.Data.Tests
{
    [TestClass()]
    public class MediaDataTests
    {
        MediaData mediaData = new MediaData();

        [TestMethod()]
        public void GetMediaByIdTest_Pass()
        {
            Media media = mediaData.GetMediaById(1);
            Assert.IsNotNull(media.Title);
        }
        [TestMethod()]
        public void GetMediaByIdTest_Fail()
        {
            Media media = mediaData.GetMediaById(1111);
            Assert.IsNull(media);
        }

    }
}