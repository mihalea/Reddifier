using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reddifier
{
    public class RedPost
    {
        public String Text { get; set; }
        public String Link { get; set; }
        public String Id   { get; set; }

        public override bool Equals(object obj)
        {
            RedPost post = (RedPost)obj;
            if (post == null)
                return false;
            return String.Equals(this.Id, post.Id);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

    }
}
