using MediaBrowser.Helper;
using System.Diagnostics.CodeAnalysis;

namespace MediaBrowser.Model.Model
{

    public class Engagement : NotifyPropertyChanged
    {
        private long _viewCount;
        private long likeCount;
        private long dislikeCount;

        public long ViewCount
        {
            get
            {
                return _viewCount;
            }
            set
            {
                if (_viewCount != value)
                {
                    _viewCount = value;
                    RaisePropertyChanged(() => ViewCount);
                    RaisePropertyChanged(() => AverageRating);

                }
            }
        }

        public long LikeCount
        {
            get => likeCount;
            set
            {
                likeCount = value;
                RaisePropertyChanged(() => LikeCount);
                RaisePropertyChanged(() => AverageRating);

            }
        }

        public long DislikeCount
        {
            get => dislikeCount;
            set
            {
                dislikeCount = value;
                RaisePropertyChanged(() => DislikeCount);
                RaisePropertyChanged(() => AverageRating);

            }
        }

        public double AverageRating => LikeCount + DislikeCount != 0
            ? 1 + 4.0 * LikeCount / (LikeCount + DislikeCount)
            : 0; // avoid division by 0
        public Engagement()
        {

        }
        public Engagement(long viewCount, long likeCount, long dislikeCount)
        {
            ViewCount = viewCount;
            LikeCount = likeCount;
            DislikeCount = dislikeCount;
        }

    }
}