using System;
using System.Runtime.Serialization;

namespace ThinkOut.Models
{
    public class BaseModel
    {
        [DataMember(Name = "id")] 
        public string Id
        {
            get;
            set;
        }

        public DateTime CreatedAt
        {
            get;
            set;
        }

        public DateTime UpdatedAt
        {
            get;
            set;
        }

        public DateTime Version
        {
            get;
            set;
        }

        public bool Deleted
        {
            get;
            set;
        }

    }
}

