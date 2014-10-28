using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResizer
{
   public class ImageItem
    {
       public ImageItem()
       { }
       public ImageItem(string title, System.IO.FileInfo file)
       {
           Title = title;
           File = file;
       }

        public string Title { get; set; }
        public System.IO.FileInfo File { get; set; }
    }
}
