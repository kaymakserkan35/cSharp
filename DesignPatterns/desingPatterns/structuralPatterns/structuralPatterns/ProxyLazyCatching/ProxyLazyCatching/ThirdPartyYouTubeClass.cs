using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyLazyCatching
{
    class Video
    {
        public int VideoId { get; set; }
        public string VideoInformation { get; set; }
        public string VideoBytes { get; set; }
    }
    class VeriTabanı
    {
        public List<Video> Videos;
        public VeriTabanı()
        {
            Videos = new List<Video>();
            Seed();
        }
        void Seed()
        {

            for (int i = 1; i < 10; i++)
            {
                Videos.Add(new Video() { VideoId = i, VideoInformation = $"Video[{i}]  info...", VideoBytes = Guid.NewGuid().ToString() });
            }
        }
    }

    class ThirdPartyYouTubeClass : AThirdPartyYouTubeLib
    {
        private VeriTabanı veritabanı = new VeriTabanı();

        public int GetMoiveListCount() { return veritabanı.Videos.Count(); }
        public override string DownloadVideo(int VideoId)
        {
            Console.WriteLine($"{VideoId} numaralı video veritabanından indiriliyor...");
            return veritabanı.Videos[VideoId].VideoBytes;
        }

        public override string GetVideoInfo(int VideoId)
        {
            Console.WriteLine($"{VideoId} numaralı video bilgileri veritabanından getiriliyor...");
            return veritabanı.Videos[VideoId].VideoInformation;
        }

        public override List<Video> ListVideos()
        {
            Console.WriteLine("bütün videolar veritabanından getiriliyor...");
            return veritabanı.Videos;
        }

    }
}
