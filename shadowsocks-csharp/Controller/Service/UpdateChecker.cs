using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Shadowsocks.Model;
using Shadowsocks.Util;

namespace Shadowsocks.Controller
{
    public class UpdateChecker
    {
        private const string UpdateURL = "https://api.github.com/repos/shadowsocks/shadowsocks-windows/releases";
        private const string UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.121 Safari/537.36";
        private const string GithubV3API = "application / vnd.github.v3 + json";

        private Configuration config;
        public bool NewVersionFound;
        private GithubRelease LatestVersionRelease = null;
        public string LatestVersionNumber;
        public string LatestVersionSuffix;
        public string LatestVersionName;
        public string LatestVersionLocalName;
        public string LatestVersionURL;
        public event EventHandler CheckUpdateCompleted;

        public const string Version = "4.1.7.1";

        private class CheckUpdateTimer : System.Timers.Timer
        {
            public Configuration config;

            public CheckUpdateTimer(int p) : base(p)
            {
            }
        }

        public void CheckUpdate(Configuration config, int delay)
        {
            CheckUpdateTimer timer = new CheckUpdateTimer(delay);
            timer.AutoReset = false;
            timer.Elapsed += Timer_Elapsed;
            timer.config = config;
            timer.Enabled = true;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            CheckUpdateTimer timer = (CheckUpdateTimer)sender;
            Configuration config = timer.config;
            timer.Elapsed -= Timer_Elapsed;
            timer.Enabled = false;
            timer.Dispose();
            CheckUpdate(config);
        }

        public void CheckUpdate(Configuration config)
        {
            this.config = config;

            try
            {
                Logging.Debug("Checking updates...");
                WebClient http = CreateWebClient();
                http.Headers.Add(HttpRequestHeader.Accept, GithubV3API);
                http.DownloadStringCompleted += http_DownloadStringCompleted;
                http.DownloadStringAsync(new Uri(UpdateURL));
            }
            catch (Exception ex)
            {
                Logging.LogUsefulException(ex);
            }
        }

        private void http_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                string response = e.Result;

                // github lists the most recent 30 releases, including preleases
                IList<GithubRelease> releases = JsonConvert.DeserializeObject<IList<GithubRelease>>(response);

                string latestQualifiedReleaseVersion = Version;

                foreach(GithubRelease release in releases)
                {
                    if (release.prerelease && !config.checkPreRelease)
                    {
                        continue;
                    }
                    if (release.assets != null && release.assets.Count > 0)
                    {
                        foreach(GithubRelease.Assert assert in release.assets)
                        {
                            string version, suffix;
                            // only record the main release file.
                            if (ExtractVersionInfoFromFileName(assert.name, out version, out suffix))
                            {
                                if (CompareVersion(version, latestQualifiedReleaseVersion) > 0)
                                {
                                    latestQualifiedReleaseVersion = version;
                                    LatestVersionRelease = release;
                                    LatestVersionNumber = version;
                                    LatestVersionSuffix = suffix == string.Empty ? string.Empty : $"-{suffix}";
                                    LatestVersionName = assert.name;
                                    LatestVersionURL = assert.browser_download_url;
                                    NewVersionFound = true;
                                }
                                break;
                            }
                        }
                    }
                }

                // has new version
                if (LatestVersionRelease != null)
                {
                    LatestVersionLocalName = Utils.GetTempPath(LatestVersionName);
                    StartDownload(LatestVersionLocalName, LatestVersionURL);
                }
                else
                {
                    Logging.Debug("No update is available");
                    CheckUpdateCompleted?.Invoke(this, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                Logging.LogUsefulException(ex);
            }
        }

        private void StartDownload(string url, string localFile)
        {
            try
            {
                WebClient http = CreateWebClient();
                http.DownloadFileCompleted += Http_DownloadFileCompleted;
                http.DownloadFileAsync(new Uri(url), localFile);
            }
            catch (Exception ex)
            {
                Logging.LogUsefulException(ex);
            }
        }

        private void Http_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                {
                    Logging.LogUsefulException(e.Error);
                    return;
                }
                Logging.Debug($"New version {LatestVersionNumber}{LatestVersionSuffix} found: {LatestVersionLocalName}");
                CheckUpdateCompleted?.Invoke(this, new EventArgs());
            }
            catch (Exception ex)
            {
                Logging.LogUsefulException(ex);
            }
        }

        private WebClient CreateWebClient()
        {
            WebClient http = new WebClient();
            http.Headers.Add(HttpRequestHeader.UserAgent, UserAgent);
            http.Proxy = new WebProxy(config.localHost, config.localPort);
            return http;
        }


        public bool ExtractVersionInfoFromFileName(string fileName, out string version, out string suffix)
        {
            version = string.Empty;
            suffix = string.Empty;
            // Ideal name: [Shadowsocks-1.0.0.0.zip] OR [Shadowsocks-1.0.0.0-prerelease.zip]
            Match match = Regex.Match(fileName, @"^Shadowsocks-(?<version>\d+(?:\.\d+)*)(?:|-(?<suffix>.+))\.(zip|exe)$",
                    RegexOptions.IgnoreCase);

            if (match.Success)
            {
                version = match.Groups["version"].Value;
                if (match.Groups["suffix"].Success)
                {
                    suffix = match.Groups["suffix"].Value;
                }
                return true;
            }
            return false;
        }

        public static int CompareVersion(string l, string r)
        {
            var ls = l.Split('.');
            var rs = r.Split('.');
            for (int i = 0; i < Math.Max(ls.Length, rs.Length); i++)
            {
                int lp = (i < ls.Length) ? int.Parse(ls[i]) : 0;
                int rp = (i < rs.Length) ? int.Parse(rs[i]) : 0;
                if (lp != rp)
                {
                    return lp - rp;
                }
            }
            return 0;
        }

    }
}
