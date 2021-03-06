using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial.Blog
{
    /// <summary>
    /// Database table name constants
    /// </summary>
    public class TrialBlogDbConst
    {
        public static class DbTableName
        {
            public const string Posts = "posts";

            public const string Categories = "categories";

            public const string Tags = "tags";

            public const string PostTags = "post_tags";

            public const string FriendLinks = "friend_links";
        }
    }
}
