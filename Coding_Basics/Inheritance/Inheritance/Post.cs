using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Post
    {
        private static int currentPostId;

        //Properities
        //protected means it can be used by the post class or classes derived from post

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool isPublic { get; set; }

        //default constructor. if a derived class does not invoke a base constructor explicityly, the default is called implicity.

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            isPublic = true;
            SendByUsername = "Chris Wuydts";
        }

        //Instance constructor w/ 3 params
        public Post(string title, bool IsPublic, string sendByUserName)
        {
            ID = GetNextID();
            Title = title;
            SendByUsername = sendByUserName;
            isPublic = IsPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool ISPublic)
        {
            Title = title;
            isPublic = ISPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", ID, Title, SendByUsername);
        }

     
    }
}
