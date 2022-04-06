using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyLazyCatching
{
    class CachedYouTubeClass : AThirdPartyYouTubeLib
    {
        private ThirdPartyYouTubeClass thirdPartyYouTubeClass;
        private List<Video> CachedVideoList;
        private bool NeedReset = false;

        public CachedYouTubeClass(ThirdPartyYouTubeClass thirdPartyYouTubeClass)
        {
            this.thirdPartyYouTubeClass = thirdPartyYouTubeClass;
            CachedVideoList = new List<Video>();


        }



        public override string DownloadVideo(int VideoId)
        {

            if (CachedVideoList.Any(video => video.VideoId == VideoId && video.VideoBytes != null))
            {
                Console.WriteLine($"video[{VideoId}]  cache ten indiriliyor...");
                return CachedVideoList.FirstOrDefault(v => v.VideoId == VideoId).VideoBytes;
            }
            else
            {
                var VideoBytes = thirdPartyYouTubeClass.DownloadVideo(VideoId);
                CachedVideoList.Add(new Video() { VideoId = VideoId, VideoBytes = VideoBytes });
                return VideoBytes;

            }
        }

        public override string GetVideoInfo(int VideoId)
        {
            if (CachedVideoList.Any(video => video.VideoId == VideoId && video.VideoInformation != null))
            {
                Console.WriteLine($"video[{VideoId}] bilgileri cache ten getiriliyor...");
                return CachedVideoList.FirstOrDefault(v => v.VideoId == VideoId).VideoInformation;
            }
            else
            {
                var videoInfo = thirdPartyYouTubeClass.GetVideoInfo(VideoId);
                CachedVideoList.Add(new Video() { VideoId = VideoId, VideoInformation = videoInfo });
                return videoInfo;

            }
        }

        public override List<Video> ListVideos()
        {
            if (CachedVideoList.Count == thirdPartyYouTubeClass.GetMoiveListCount())
            {
                Console.WriteLine($"bütün videolar  cache ten getiriliyor...");
                return CachedVideoList;
            }
            else
            {
                CachedVideoList = thirdPartyYouTubeClass.ListVideos();
                return CachedVideoList;
            }
        }
    }
}
