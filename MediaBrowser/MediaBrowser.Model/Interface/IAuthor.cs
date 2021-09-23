using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBrowser.Model.Interface
{
    public interface IAuthor
    {
        string Id { get; }
        string Title { get; }
    }
}
