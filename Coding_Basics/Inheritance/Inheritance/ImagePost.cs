using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Derives from post. Adds a property (ImageURL) and Two Constructors
    class ImagePost:Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageURL, bool ISpublic)
        {
            ID = GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            isPublic = ISpublic;

            ImageURL = imageURL;

        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}", ID, Title, ImageURL, SendByUsername);
        }
    }
}
