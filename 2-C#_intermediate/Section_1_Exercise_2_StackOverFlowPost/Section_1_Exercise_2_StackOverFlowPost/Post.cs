using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Section_1_Exercise_2_StackOverFlowPost
{
    internal class Post
    {
        public Post(string title, string description, DateTime created)
        {
            _title = title;
            _description = description;
            _created = created;
        }

        private string _title { get; set; }
        private string _description { get; set; }
        private DateTime _created {get; set; }
        private int _voteValue { get; set; } = 0;

        public int VoteValue
        {
            get { return _voteValue; }
        }

        private string Title 
        { 
            get { return _title; } 
        }
        private string Description { 
            get { return _description; } 
        }

        private DateTime Created { 
            get { return _created; } 
        }

        public void UpVote()
        {
            ++_voteValue;
        }
        public void DownVote()
        {
            --_voteValue;
        }

        public void DisplayPost()
        {
            Console.WriteLine("Title: {0}\n\nPost: {1}\n\nPostDate: {2}\nVote count: {3}\n", Title, Description, Created, VoteValue);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
        
        }

    }
}
