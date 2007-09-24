using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Reflection;

namespace Incremental.Kick.Web.Controls {
    public class KickUIPage : KickPage {

        private string _adSenseID;
        public string AdSenseID {
            get {
                if (string.IsNullOrEmpty(this._adSenseID))
                    return this.HostProfile.AdsenseID;
                else
                    return this._adSenseID;
            }
            set { this._adSenseID = value; }
        }

        private string _rssFeedUrl;
        public string RssFeedUrl {
            get { return this._rssFeedUrl; }
            set { this._rssFeedUrl = value; }
        }

        public bool HasRssFeed {
            get { return !String.IsNullOrEmpty(this.RssFeedUrl); }
        }

        private string _assemblyVersion;
        public string AssemblyVersion {
            get {
                if (String.IsNullOrEmpty(_assemblyVersion))
                    _assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                return _assemblyVersion;
            }
        }

        public void AddJavaScript(string relativeUrl) {
            HtmlGenericControl script = new HtmlGenericControl("script");
            script.Attributes["type"] = "text/javascript";
            script.Attributes["src"] = this.ResolveUrl(relativeUrl) + "?" + this.AssemblyVersion;

            this.Header.Controls.Add(script);

            Literal literal = new Literal();
            literal.Text = "\n";
            this.Header.Controls.Add(literal);
        }

        public void AddStyleSheet(string relativeUrl) {
            HtmlLink cssLink = new HtmlLink();
            cssLink.Href = this.ResolveUrl(relativeUrl) + "?" + this.AssemblyVersion;
            cssLink.Attributes["type"] = "text/css";
            cssLink.Attributes["rel"] = "stylesheet";

            this.Header.Controls.Add(cssLink);

            Literal literal = new Literal();
            literal.Text = "\n";
            this.Header.Controls.Add(literal);
        }

        public void AddRssUrl(string relativeUrl) {
            HtmlLink cssLink = new HtmlLink();
            cssLink.Href = this.ResolveUrl(relativeUrl);
            cssLink.Attributes["type"] = "application/rss+xml";
            cssLink.Attributes["rel"] = "alternate";

            this.Header.Controls.Add(cssLink);

            Literal literal = new Literal();
            literal.Text = "\n";
            this.Header.Controls.Add(literal);
        }

        protected override void OnPreInit(EventArgs e) {
            this.MasterPageFile = "~/Templates/" + this.HostProfile.Template + "/MasterPage.master";
            base.OnPreInit(e);
        }

        protected override void OnPreRender(EventArgs e) {
            this.AddStyleSheet(this.MasterPageBaseCssUrl);
            this.AddStyleSheet(this.MasterPageTemplateCssUrl);

            this.AddJavaScript(this.StaticScriptRootUrl + "/2.0.1/jQuery/jquery-1.2.min.js");

            this.AddJavaScript(this.ResolveUrl("~/Scripts/Constants.aspx"));
            this.AddJavaScript(this.StaticScriptRootUrl + "/2.0.1/Common.js");
            this.AddJavaScript(this.StaticScriptRootUrl + "/2.0.1/Tagging.js");

            if (this.IsHostModerator)
                this.AddJavaScript(this.StaticScriptRootUrl + "/2.0.1/Moderator/HostModerator.js");

            if (this.KickUserProfile.IsAdministrator)
                this.AddJavaScript(this.StaticScriptRootUrl + "/2.0.1/Admin/Kick.js");

            if (!String.IsNullOrEmpty(this.RssFeedUrl)) {
                if(this.RssFeedUrl.StartsWith("http:"))
                    this.AddRssUrl(this.RssFeedUrl);
                else
                    this.AddRssUrl(this.HostProfile.RootUrl + this.RssFeedUrl);
            }

            if (this.KickUserProfile.IsDebugger) {
                DebugInformation debugInfo = new DebugInformation();
                this.Controls.Add(debugInfo);
            }

            base.OnPreRender(e);
        }

        public void Reload() { //NOTE: GJ: This is useful to get away from post-postback state of forms
            Response.Redirect(this.Request.RawUrl);
        }
    }
}
