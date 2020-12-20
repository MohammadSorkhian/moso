using System;
using System.Collections.Generic;
using System.Text;

namespace Temp
{
    class ImagePost : Post
    {
        public string ImageURL { get; set; }
        public ImagePost()
        {
            this.ImageURL = "c:/";
        }

        public ImagePost(string title, string sentByName, bool isPublic, string url)
        {
            this.Title = title;
            this.SendByUserName = sentByName;
            this.Ispublic = isPublic;
            this.ImageURL = url;
        }

        public override string ToString()
        {
            return ($"{this.ID} - {this.Title} by {this.SendByUserName} in address: {ImageURL}");
        }
    }
}
