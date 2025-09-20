using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicClasses
{
    public class User
    {
        public Guid id { get; }
        public string username { get; }
        public string email { get; }
        public string password { get; }
        public DateOnly? birthday { get; private set; }

        List<Follower> artistsFollowing;

        public User(string username, string userEmail,string userPassword)
        { 
            this.id = Guid.NewGuid();
            this.username = username;
            this.email = userEmail;
            this.password = userPassword;
            this.artistsFollowing = new List<Follower>();
        }

        public User(string username, string userEmail, string userPassword, DateOnly? userBirthday)
        {
            this.id = Guid.NewGuid();
            this.username = username;
            this.email = userEmail;
            this.password = userPassword;
            this.birthday = userBirthday;
            this.artistsFollowing = new List<Follower>();
        }

        public User(Guid userId, string username, string userEmail,string userPassword)
        {
            this.id = userId;
            this.username = username;
            this.email = userEmail;
            this.password = userPassword;
            this.artistsFollowing = new List<Follower>();
        }
        public List<Follower> getFollowing()
        {
            return this.artistsFollowing;
        }


   

        public override string ToString()
        {
            return $"User ID: {this.id}, Username: {this.username}, Email  {this.email} ";  
        }

        
    }
}
