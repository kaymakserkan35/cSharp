using System;

namespace ProxyLazyCatching
{
    class Program
    {
        static void Main(string[] args)
        {

          

            ThirdPartyYouTubeClass thirdPartyYouTubeClass = new ThirdPartyYouTubeClass();
            CachedYouTubeClass cachedYouTubeClass = new CachedYouTubeClass(thirdPartyYouTubeClass);
            YouTubeManager youTubeManager = new YouTubeManager(cachedYouTubeClass);


            youTubeManager.renderVideoPage(4);
            youTubeManager.renderVideoPage(4);
            Console.WriteLine("----------------------");
            youTubeManager.renderListPanel();
            Console.WriteLine("----------------------");
            youTubeManager.renderListPanel();
            Console.WriteLine("----------------------");
            youTubeManager.DownloadVideo(2);
            youTubeManager.DownloadVideo(2);
        }
    }
}
