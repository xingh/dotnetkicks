using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using Incremental.Kick.Dal;
using Incremental.Kick.Caching;

namespace Incremental.Kick.Web.UI.Controls {
    public partial class Profile : Incremental.Kick.Web.Controls.KickUserControl {
        private User _userProfile;
        public User UserProfile {
            get { return _userProfile; }
        }
        public void DataBind(User userProfile) {
            this._userProfile = userProfile;
        }

        protected void Page_Load(object sender, EventArgs e) 
        {
            //if user is banned (and viewing user isn't admin or moderator) then hide profile
            if (_userProfile.IsBanned && !(this.KickPage.KickUserProfile.IsAdministrator || this.KickPage.KickUserProfile.IsModerator))
                mvUserProfile.SetActiveView(this.viewBannedUser);

            //don't display edit/add friend/remove friend, if not logged in
            this.mvProfileEditAndFriends.Visible = !this.UserProfile.IsGuest;

            //if looking at own profile page, don't display friends
            if (this.KickPage.KickUserProfile.UserID == this.UserProfile.UserID) //self
                this.mvProfileEditAndFriends.SetActiveView(this.viewProfileEdit);
            else if (this.KickPage.KickUserProfile.IsFriendOf(this.UserProfile.UserID)) //if looking at friend's profile
                this.mvProfileEditAndFriends.SetActiveView(this.viewProfileIsAFriend);
            else  //looking at non-friend's profile
                this.mvProfileEditAndFriends.SetActiveView(this.viewProfileIsNotAFriend);
        }

        protected void lnkAddFriend_Click(object sender, EventArgs e) {
            this.KickPage.KickUserProfile.AddFriend(this.UserProfile.UserID);
            this.KickPage.Reload();
        }

        protected void lnkRemoveFriend_Click(object sender, EventArgs e) {
            this.KickPage.KickUserProfile.RemoveFriend(this.UserProfile.UserID);
            this.KickPage.Reload();
        }
    }
}