using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowsocks.Model
{

    /// <summary>
    /// Github API v3
    /// https://developer.github.com/v3/repos/releases/
    /// </summary>
    [Serializable]
    public class GithubRelease
    {
        public string url;
        public string html_url;
        public string assets_url;
        public string upload_url;
        public string tarball_url;
        public string zipball_url;
        public int id;
        public string node_id;
        public string tag_name;
        public string target_commitish;
        public string name;
        public string body;
        public bool draft;
        public bool prerelease;
        public DateTime created_at;
        public DateTime published_at;
        public User author;
        public IList<Assert> assets;

        public class User
        {
            public string login;
            public int id;
            public string node_id;
            public string avatar_url;
            public string gravatar_id;
            public string url;
            public string html_url;
            public string followers_url;
            public string following_url;
            public string gists_url;
            public string starred_url;
            public string subscriptions_url;
            public string organizations_url;
            public string repos_url;
            public string events_url;
            public string received_events_url;
            public string type;
            public bool site_admin;

            public override string ToString()
            {
                return login;
            }
        }

        public class Assert
        {
            public string url;
            public string browser_download_url;
            public int id;
            public string node_id;
            public string name;
            public string label;
            public string state;
            public string content_type;
            public int size;
            public int download_count;
            public string created_at;
            public string updated_at;

            public override string ToString()
            {
                return $"Assert name: {name}";
            }
        }

        public override string ToString()
        {
            return $"Release name: {name}";
        }
    }

}
