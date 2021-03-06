USE [DotNetKicks]
GO
/****** Object:  StoredProcedure [dbo].[Kick_GetPagedFriendsSubmittedStoriesByUserIDAndHostIDCount]    Script Date: 09/16/2007 20:31:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	returns count of a user's friends submitted stories
-- =============================================
CREATE PROCEDURE [dbo].[Kick_GetPagedFriendsSubmittedStoriesByUserIDAndHostIDCount] 
	-- Add the parameters for the stored procedure here
	@UserID int,
	@HostID int,
	@RecordCount int out
AS
BEGIN

SET NOCOUNT ON;
DECLARE @TotalRows int

SET @RecordCount = (select count(0) from 
	(Select distinct dbo.Kick_Story.StoryId
		FROM         
			dbo.Kick_Story INNER JOIN dbo.Kick_UserFriend ON 
			dbo.Kick_UserFriend.FriendID = dbo.Kick_Story.UserID
		WHERE dbo.Kick_UserFriend.UserID=@UserID AND dbo.Kick_Story.HostID=@HostID) a
	)

RETURN @RecordCount

END
