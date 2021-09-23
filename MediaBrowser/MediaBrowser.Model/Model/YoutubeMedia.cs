using MediaBrowser.Model.Abstract;
using MediaBrowser.Model.Interface;

namespace MediaBrowser.Model.Model
{
    public class YoutubeMedia : AMediaBase
    {

        public YoutubeMedia(
            string id,
            string title,
            IAuthor author,
            DateTimeOffset uploadDate,
            string description,
            TimeSpan? duration,
            IReadOnlyList<string> thumbnails,
            IReadOnlyList<string> keywords,
            Engagement engagement) :base(id,title,author,uploadDate,description,duration,thumbnails,keywords,engagement) 
        {
        }
    }
}