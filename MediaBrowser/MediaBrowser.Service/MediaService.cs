using YoutubeExplode;

namespace MediaBrowser.Service
{
    public class MediaService
    {
        public YoutubeClient _youtubeClient;
        private static MediaService? _instance;
        public MediaService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MediaService();
                }
                return _instance;
            }
        }

        private MediaService()
        {
            _youtubeClient = new YoutubeClient();
        }

    }
}