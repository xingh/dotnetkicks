using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;
using System.Web;
using Incremental.Kick.Dal.Entities;
using Incremental.Kick.Web.Helpers;

namespace Incremental.Kick.Web.Controls {
    class TagCommaList : KickHtmlControl {
        private WeightedTagList _tags;
        private int _storyID;
        private bool _showTagIt = true;
        public void DataBind(WeightedTagList tags, int storyID) {
            this.DataBind(tags, storyID, true);
        }
        public void DataBind(WeightedTagList tags, int storyID, bool showTagIt) {
            this._tags = tags;
            this._storyID = storyID;
            this._showTagIt = showTagIt;
        }

        protected override void Render(HtmlTextWriter writer) {

            if (this._tags.Count > 0) {
                if (_showTagIt)
                    writer.WriteLine("tags: ");

                string tagClass;
                //TODO: GJ: refactor the Tag rendering as the code is duplicated
                for (int i = 0; i < this._tags.Count; i++) {
                    if (i % 2 == 0)
                        tagClass = "evenTag";
                    else
                        tagClass = "oddTag";

                    string tagIcons = "";
                    if (this._tags[i].IsInNamespace) {
                        tagClass += " namespaceTag";

                        foreach (string tagNamespace in this._tags[i].Namespaces) {
                            //tagIcons += String.Format(@"<img src=""{0}/{1}_{2}.png"" width=""16"" height=""16"" border=""0""/> ", this.KickPage.StaticIconRootUrl, tagNamespace, this._tags[i].TagName);
                            tagClass += " " + tagNamespace + "_NamespaceTag";
                        }
                    }

                    writer.Write(@"<a href=""{0}"" class=""tag {2}"" rel=""tag"">{3}{1}</a>",
                        UrlFactory.CreateUrl(UrlFactory.PageName.ViewTag, HttpUtility.UrlEncode(this._tags[i].TagIdentifier)), this._tags[i].TagName, tagClass, tagIcons);

                    if (i < this._tags.Count - 1)
                        writer.Write(", ");

                }
            }

            if (_showTagIt)
                writer.WriteLine(@" | <a href=""javascript:ToggleStoryTags({0});""><strong>tag it</strong></a>", this._storyID);
        }
    }
}

