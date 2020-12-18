
using System;
using System.Collections.Generic;
using System.Text;

namespace Temp
{
    class Post
    {
        private static int CurrrentPostId;
        public int ID { get; set; }
        public string Title { get; set; }
        public string SendByUserName { get; set; }
        public bool Ispublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My first Post";
            Ispublic = true;
            SendByUserName = "Moso";
        }

        public Post(string title, string sendByUserName, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.Ispublic = Ispublic;
        }

        protected int GetNextID()
        {
            return ++CurrrentPostId;
        }
    }
}
