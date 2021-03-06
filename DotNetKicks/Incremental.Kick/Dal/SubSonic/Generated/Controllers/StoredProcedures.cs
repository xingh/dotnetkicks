using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;

namespace Incremental.Kick.Dal{
    public partial class SPs{
        
        /// <summary>
        /// Creates an object wrapper for the Kick_GetTagsByUserIDAndHostID Procedure
        /// </summary>
        public static StoredProcedure Kick_GetTagsByUserIDAndHostID(int? UserID, int? HostID)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_GetTagsByUserIDAndHostID" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@UserID", UserID,DbType.Int32);
        	    
            sp.Command.AddParameter("@HostID", HostID,DbType.Int32);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the Kick_GetTagsByHostIDAndCreatedOnRange Procedure
        /// </summary>
        public static StoredProcedure Kick_GetTagsByHostIDAndCreatedOnRange(int? HostID, DateTime? CreatedOn_Lower, DateTime? CreatedOn_Upper)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_GetTagsByHostIDAndCreatedOnRange" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@HostID", HostID,DbType.Int32);
        	    
            sp.Command.AddParameter("@CreatedOn_Lower", CreatedOn_Lower,DbType.DateTime);
        	    
            sp.Command.AddParameter("@CreatedOn_Upper", CreatedOn_Upper,DbType.DateTime);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the Kick_GetTagsByUserIDAndStoryID Procedure
        /// </summary>
        public static StoredProcedure Kick_GetTagsByUserIDAndStoryID(int? UserID, int? StoryID)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_GetTagsByUserIDAndStoryID" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@UserID", UserID,DbType.Int32);
        	    
            sp.Command.AddParameter("@StoryID", StoryID,DbType.Int32);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the Kick_GetTagsByUserID Procedure
        /// </summary>
        public static StoredProcedure Kick_GetTagsByUserID(int? UserID)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_GetTagsByUserID" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@UserID", UserID,DbType.Int32);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the Kick_GetTagsByStoryID Procedure
        /// </summary>
        public static StoredProcedure Kick_GetTagsByStoryID(int? StoryID)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_GetTagsByStoryID" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@StoryID", StoryID,DbType.Int32);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the Kick_GetPagedStoriesByTagIDAndHostID Procedure
        /// </summary>
        public static StoredProcedure Kick_GetPagedStoriesByTagIDAndHostID(int? TagID, int? HostID, int? PageNumber, int? PageSize)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_GetPagedStoriesByTagIDAndHostID" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@TagID", TagID,DbType.Int32);
        	    
            sp.Command.AddParameter("@HostID", HostID,DbType.Int32);
        	    
            sp.Command.AddParameter("@PageNumber", PageNumber,DbType.Int32);
        	    
            sp.Command.AddParameter("@PageSize", PageSize,DbType.Int32);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the Kick_GetPagedKickedStoriesByUserIDAndHostID Procedure
        /// </summary>
        public static StoredProcedure Kick_GetPagedKickedStoriesByUserIDAndHostID(int? UserID, int? HostID, int? PageNumber, int? PageSize)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_GetPagedKickedStoriesByUserIDAndHostID" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@UserID", UserID,DbType.Int32);
        	    
            sp.Command.AddParameter("@HostID", HostID,DbType.Int32);
        	    
            sp.Command.AddParameter("@PageNumber", PageNumber,DbType.Int32);
        	    
            sp.Command.AddParameter("@PageSize", PageSize,DbType.Int32);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the Kick_GetPagedFriendsKickedStoriesByUserIDAndHostIDCount Procedure
        /// </summary>
        public static StoredProcedure Kick_GetPagedFriendsKickedStoriesByUserIDAndHostIDCount(int? UserID, int? HostID, int? RecordCount)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_GetPagedFriendsKickedStoriesByUserIDAndHostIDCount" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@UserID", UserID,DbType.Int32);
        	    
            sp.Command.AddParameter("@HostID", HostID,DbType.Int32);
        	    
            sp.Command.AddOutputParameter("@RecordCount",DbType.Int32);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the Kick_GetPagedFriendsSubmittedStoriesByUserIDAndHostIDCount Procedure
        /// </summary>
        public static StoredProcedure Kick_GetPagedFriendsSubmittedStoriesByUserIDAndHostIDCount(int? UserID, int? HostID, int? RecordCount)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_GetPagedFriendsSubmittedStoriesByUserIDAndHostIDCount" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@UserID", UserID,DbType.Int32);
        	    
            sp.Command.AddParameter("@HostID", HostID,DbType.Int32);
        	    
            sp.Command.AddOutputParameter("@RecordCount",DbType.Int32);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the Kick_GetPagedFriendsSubmittedStoriesByUserIDAndHostID Procedure
        /// </summary>
        public static StoredProcedure Kick_GetPagedFriendsSubmittedStoriesByUserIDAndHostID(int? UserID, int? HostID, int? PageNumber, int? PageSize)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_GetPagedFriendsSubmittedStoriesByUserIDAndHostID" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@UserID", UserID,DbType.Int32);
        	    
            sp.Command.AddParameter("@HostID", HostID,DbType.Int32);
        	    
            sp.Command.AddParameter("@PageNumber", PageNumber,DbType.Int32);
        	    
            sp.Command.AddParameter("@PageSize", PageSize,DbType.Int32);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the Kick_GetTopKickedStoriesByYearMonth Procedure
        /// </summary>
        public static StoredProcedure Kick_GetTopKickedStoriesByYearMonth(int? HostId, int? Year, int? Month)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_GetTopKickedStoriesByYearMonth" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@HostId", HostId,DbType.Int32);
        	    
            sp.Command.AddParameter("@Year", Year,DbType.Int32);
        	    
            sp.Command.AddParameter("@Month", Month,DbType.Int32);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the Kick_GetTopCommentedOnStoriesByYear Procedure
        /// </summary>
        public static StoredProcedure Kick_GetTopCommentedOnStoriesByYear(int? HostId, int? Year)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_GetTopCommentedOnStoriesByYear" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@HostId", HostId,DbType.Int32);
        	    
            sp.Command.AddParameter("@Year", Year,DbType.Int32);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the Kick_GetTopCommentedOnStoriesByYearMonth Procedure
        /// </summary>
        public static StoredProcedure Kick_GetTopCommentedOnStoriesByYearMonth(int? HostId, int? Year, int? Month)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_GetTopCommentedOnStoriesByYearMonth" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@HostId", HostId,DbType.Int32);
        	    
            sp.Command.AddParameter("@Year", Year,DbType.Int32);
        	    
            sp.Command.AddParameter("@Month", Month,DbType.Int32);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the Kick_GetPagedFriendsKickedStoriesByUserIDAndHostID Procedure
        /// </summary>
        public static StoredProcedure Kick_GetPagedFriendsKickedStoriesByUserIDAndHostID(int? UserID, int? HostID, int? PageNumber, int? PageSize)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_GetPagedFriendsKickedStoriesByUserIDAndHostID" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@UserID", UserID,DbType.Int32);
        	    
            sp.Command.AddParameter("@HostID", HostID,DbType.Int32);
        	    
            sp.Command.AddParameter("@PageNumber", PageNumber,DbType.Int32);
        	    
            sp.Command.AddParameter("@PageSize", PageSize,DbType.Int32);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the Kick_GetTopKickedStoriesByYear Procedure
        /// </summary>
        public static StoredProcedure Kick_GetTopKickedStoriesByYear(int? HostId, int? Year)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_GetTopKickedStoriesByYear" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@HostId", HostId,DbType.Int32);
        	    
            sp.Command.AddParameter("@Year", Year,DbType.Int32);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the Kick_GetPagedStoriesByTagIDAndHostIDAndUserID Procedure
        /// </summary>
        public static StoredProcedure Kick_GetPagedStoriesByTagIDAndHostIDAndUserID(int? TagID, int? HostID, int? UserID, int? PageNumber, int? PageSize)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_GetPagedStoriesByTagIDAndHostIDAndUserID" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@TagID", TagID,DbType.Int32);
        	    
            sp.Command.AddParameter("@HostID", HostID,DbType.Int32);
        	    
            sp.Command.AddParameter("@UserID", UserID,DbType.Int32);
        	    
            sp.Command.AddParameter("@PageNumber", PageNumber,DbType.Int32);
        	    
            sp.Command.AddParameter("@PageSize", PageSize,DbType.Int32);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the Kick_GetPagedSubmittedStoriesByUserIDAndHostID Procedure
        /// </summary>
        public static StoredProcedure Kick_GetPagedSubmittedStoriesByUserIDAndHostID(int? UserID, int? HostID, int? PageNumber, int? PageSize)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_GetPagedSubmittedStoriesByUserIDAndHostID" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@UserID", UserID,DbType.Int32);
        	    
            sp.Command.AddParameter("@HostID", HostID,DbType.Int32);
        	    
            sp.Command.AddParameter("@PageNumber", PageNumber,DbType.Int32);
        	    
            sp.Command.AddParameter("@PageSize", PageSize,DbType.Int32);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the Kick_GetPagedCommentsByUserIDAndHostID Procedure
        /// </summary>
        public static StoredProcedure Kick_GetPagedCommentsByUserIDAndHostID(int? UserID, int? HostID, int? PageNumber, int? PageSize)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_GetPagedCommentsByUserIDAndHostID" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@UserID", UserID,DbType.Int32);
        	    
            sp.Command.AddParameter("@HostID", HostID,DbType.Int32);
        	    
            sp.Command.AddParameter("@PageNumber", PageNumber,DbType.Int32);
        	    
            sp.Command.AddParameter("@PageSize", PageSize,DbType.Int32);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the ELMAH_GetErrorXml Procedure
        /// </summary>
        public static StoredProcedure Elmah_GetErrorXml(string Application, Guid? ErrorId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ELMAH_GetErrorXml" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@Application", Application,DbType.String);
        	    
            sp.Command.AddParameter("@ErrorId", ErrorId,DbType.Guid);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the ELMAH_GetErrorsXml Procedure
        /// </summary>
        public static StoredProcedure Elmah_GetErrorsXml(string Application, int? PageIndex, int? PageSize, int? TotalCount)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ELMAH_GetErrorsXml" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@Application", Application,DbType.String);
        	    
            sp.Command.AddParameter("@PageIndex", PageIndex,DbType.Int32);
        	    
            sp.Command.AddParameter("@PageSize", PageSize,DbType.Int32);
        	    
            sp.Command.AddOutputParameter("@TotalCount",DbType.Int32);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the ELMAH_LogError Procedure
        /// </summary>
        public static StoredProcedure Elmah_LogError(Guid? ErrorId, string Application, string Host, string Type, string Source, string Message, string User, string AllXml, int? StatusCode, DateTime? TimeUtc)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ELMAH_LogError" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@ErrorId", ErrorId,DbType.Guid);
        	    
            sp.Command.AddParameter("@Application", Application,DbType.String);
        	    
            sp.Command.AddParameter("@Host", Host,DbType.String);
        	    
            sp.Command.AddParameter("@Type", Type,DbType.String);
        	    
            sp.Command.AddParameter("@Source", Source,DbType.String);
        	    
            sp.Command.AddParameter("@Message", Message,DbType.String);
        	    
            sp.Command.AddParameter("@User", User,DbType.String);
        	    
            sp.Command.AddParameter("@AllXml", AllXml,DbType.String);
        	    
            sp.Command.AddParameter("@StatusCode", StatusCode,DbType.Int32);
        	    
            sp.Command.AddParameter("@TimeUtc", TimeUtc,DbType.DateTime);
        	    
            return sp;
        }

        
        /// <summary>
        /// Creates an object wrapper for the Kick_AddAlertMessageForUser Procedure
        /// </summary>
        public static StoredProcedure Kick_AddAlertMessageForUser(int? userId, int? alertMessageId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Kick_AddAlertMessageForUser" , DataService.GetInstance("DotNetKicks"));
        	
            sp.Command.AddParameter("@userId", userId,DbType.Int32);
        	    
            sp.Command.AddParameter("@alertMessageId", alertMessageId,DbType.Int32);
        	    
            return sp;
        }

        
    }

    
}

