USE [DotNetKicks]
GO
/****** Object:  StoredProcedure [dbo].[Kick_GetPagedFriendsKickedStoriesByUserIDAndHostIDCount]    Script Date: 09/16/2007 20:29:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	returns count of a user's friends kicked stories
-- =============================================
CREATE PROCEDURE [dbo].[Kick_GetPagedFriendsKickedStoriesByUserIDAndHostIDCount] 
	-- Add the parameters for the stored procedure here
	@UserID int,
	@HostID int,
    @RecordCount int out
AS
BEGIN

SET NOCOUNT ON;

SET @RecordCount = (Select count(0) from (select distinct Kick_Story.StoryId
	FROM  dbo.Kick_Story INNER JOIN
			dbo.Kick_StoryKick ON dbo.Kick_Story.StoryID = dbo.Kick_StoryKick.StoryID
		INNER JOIN dbo.Kick_UserFriend ON dbo.Kick_UserFriend.FriendID = dbo.Kick_StoryKick.UserID
	WHERE dbo.Kick_UserFriend.UserID=@UserID AND dbo.Kick_StoryKick.HostID=@HostID) a
)

return @RecordCount

END
