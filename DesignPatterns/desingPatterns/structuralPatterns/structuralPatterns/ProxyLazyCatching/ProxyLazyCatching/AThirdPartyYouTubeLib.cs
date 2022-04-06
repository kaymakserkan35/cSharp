using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyLazyCatching
{
    abstract class AThirdPartyYouTubeLib
    {
        abstract public List<Video> ListVideos();
        abstract public string GetVideoInfo(int VideoId);
        abstract public string DownloadVideo(int VideoId);
    }
}
