using MediaBrowser.Helper;
using MediaBrowser.Model.Interface;
using System.Diagnostics.CodeAnalysis;
using YoutubeExplode.Channels;

namespace MediaBrowser.Model
{

    public class Author : NotifyPropertyChanged, IAuthor
    {
        private string _id;
        private string _title;

        public string Id
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
                RaisePropertyChanged(()=>Id);
            }
        }


        public string Title {
            get
            {
                return _title;
            }
            private set
            {
                _title = value;
                RaisePropertyChanged(() => Title);
            }
        }
        public Author(string id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}