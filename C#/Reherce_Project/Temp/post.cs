
using System;
using System.Collections.Generic;
using System.Text;

namespace Temp
{
    class Post
    {
        private static int CurrrentPostId;
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool Ispublic { get; set; }

        //Constructor Empty
        public Post()
        {
            ID = GetNextID();
            Title = "My first Post";
            Ispublic = true;
            SendByUserName = "Moso";
        }

        //Constructor 3 Parameters
        public Post(string title, string sendByUserName, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.Ispublic = Ispublic;
        }

        //Generates ID
        protected int GetNextID()
        {
            return ++CurrrentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.Ispublic = isPublic;
        }

        public override string ToString()
        {
            return ($"{this.ID} - {this.Title} by {this.SendByUserName}");
        }

    }
}
