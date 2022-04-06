using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyLazyCatching
{
    class YouTubeManager
    {
        protected AThirdPartyYouTubeLib service;
        public YouTubeManager(AThirdPartyYouTubeLib service)
        {
            this.service = service;
        }

        public void renderVideoPage(int videoid)
        {
            string videoInfo = service.GetVideoInfo(videoid);
            Console.WriteLine($"kullanıcı arayüzü  video[{videoid}] bilgisi ile renderleniyor...");
            Console.WriteLine(videoInfo);
        }


        public void renderListPanel()
        {
            var liste = service.ListVideos();
            Console.WriteLine($"kullanıcı arayüzü  videolar listesi bilgisi ile renderleniyor...");
            foreach (var video in liste)
            {
                Console.WriteLine($"{video.VideoId} - {video.VideoInformation}");
            }
        }

        public void DownloadVideo(int videoid)
        {
            var video = service.DownloadVideo(videoid);
            Console.WriteLine($"kullanıcı arayüzü indirilen video ile renderleniyor...");
            Console.WriteLine(video.ToString());
        }
    }
}
