using MediaBrowser.Helper;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace YouTubeDownLoader.Models
{
    public class SearchModel : NotifyPropertyChanged
    {
        private string _title;
        private string _url;
        private string _author;

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                RaisePropertyChanged(()=>this.Title);
            }
        }

        public string Url
        {
            get { return _url; }
            set
            {
                _url = value;
                RaisePropertyChanged(() => this.Title);
            }
        }

        public string Author
        {
            get 
            {
                return _author;
            }
            set
            {
                _author = value;
                RaisePropertyChanged(() => this.Title);
            }
        }

        public string Duration { get; private set; }


        public SearchModel()
        {
     
            
        }
    }
}
