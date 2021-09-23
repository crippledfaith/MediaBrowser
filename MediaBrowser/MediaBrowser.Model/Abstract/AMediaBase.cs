using MediaBrowser.Helper;
using MediaBrowser.Model.Interface;
using MediaBrowser.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBrowser.Model.Abstract
{
    public abstract class AMediaBase : NotifyPropertyChanged, IMedia
    {
        private string id;
        private string _title;
        private IAuthor _author;
        private DateTimeOffset _uploadDate;
        private string _description;
        private TimeSpan? _duration;
        private IReadOnlyList<string> _thumbnails;
        private IReadOnlyList<string> _keywords;
        private Engagement _engagement;

        public string Id
        {
            get => id;
            set
            {
                id = value;
                RaisePropertyChanged(() => Id);
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                RaisePropertyChanged(() => Id);
            }
        }

        public IAuthor Author
        {
            get => _author;
            set
            {
                _author = value;
                RaisePropertyChanged(() => Id);
            }
        }

        public DateTimeOffset UploadDate
        {
            get => _uploadDate;
            set
            {
                _uploadDate = value;
                RaisePropertyChanged(() => Id);
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                RaisePropertyChanged(() => Id);
            }
        }

        public TimeSpan? Duration
        {
            get => _duration;
            set
            {
                _duration = value;
                RaisePropertyChanged(() => Id);
            }
        }

        public IReadOnlyList<string> Thumbnails
        {
            get => _thumbnails;
            set
            {
                _thumbnails = value;
                RaisePropertyChanged(() => Id);
            }
        }

        public IReadOnlyList<string> Keywords
        {
            get => _keywords;
            set
            {
                _keywords = value;
                RaisePropertyChanged(() => Id);
            }
        }


        public Engagement Engagement
        {
            get => _engagement;
            set
            {
                _engagement = value;
                RaisePropertyChanged(() => Id);
            }
        }


        public AMediaBase(
            string id,
            string title,
            IAuthor author,
            DateTimeOffset uploadDate,
            string description,
            TimeSpan? duration,
            IReadOnlyList<string> thumbnails,
            IReadOnlyList<string> keywords,
            Engagement engagement)
        {
            Id = id;
            Title = title;
            Author = author;
            UploadDate = uploadDate;
            Description = description;
            Duration = duration;
            Thumbnails = thumbnails;
            Keywords = keywords;
            Engagement = engagement;
        }
    }
}
