#region Copyright
////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Dynastream Innovations Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2016 Dynastream Innovations Inc.
////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 20.00Release
// Tag = production/akw/20.00.00-0-g04241f7
////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;


namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the SegmentLeaderboardEntry profile message.
    /// </summary>
    public class SegmentLeaderboardEntryMesg : Mesg
    {
        #region Fields
        #endregion

        #region Constructors
        public SegmentLeaderboardEntryMesg() : base(Profile.GetMesg(MesgNum.SegmentLeaderboardEntry))
        {
        }

        public SegmentLeaderboardEntryMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the MessageIndex field</summary>
        /// <returns>Returns nullable ushort representing the MessageIndex field</returns>
        public ushort? GetMessageIndex()
        {
            return (ushort?)GetFieldValue(254, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set MessageIndex field</summary>
        /// <param name="messageIndex_">Nullable field value to be set</param>
        public void SetMessageIndex(ushort? messageIndex_)
        {
            SetFieldValue(254, 0, messageIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Name field
        /// Comment: Friendly name assigned to leader</summary>
        /// <returns>Returns byte[] representing the Name field</returns>
        public byte[] GetName()
        {
            return (byte[])GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
        }

        
        ///<summary>
        /// Retrieves the Name field
        /// Comment: Friendly name assigned to leader</summary>
        /// <returns>Returns String representing the Name field</returns>
        public String GetNameAsString()
        {
            byte[] data = (byte[])GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            return Encoding.UTF8.GetString(data, 0, data.Length - 1);
        }
        

        
        ///<summary>
        /// Set Name field
        /// Comment: Friendly name assigned to leader</summary>
        /// <param name="name_"> field value to be set</param>
        public void SetName(String name_)
        {
            byte[] data = Encoding.UTF8.GetBytes(name_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(0, 0, zdata, Fit.SubfieldIndexMainField);
        }
        

        /// <summary>
        /// Set Name field
        /// Comment: Friendly name assigned to leader</summary>
        /// <param name="name_">field value to be set</param>
        public void SetName(byte[] name_)
        {
            SetFieldValue(0, 0, name_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Type field
        /// Comment: Leader classification</summary>
        /// <returns>Returns nullable SegmentLeaderboardType enum representing the Type field</returns>
        new public SegmentLeaderboardType? GetType()
        {
            object obj = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            SegmentLeaderboardType? value = obj == null ? (SegmentLeaderboardType?)null : (SegmentLeaderboardType)obj;
            return value;
        }

        

        

        /// <summary>
        /// Set Type field
        /// Comment: Leader classification</summary>
        /// <param name="type_">Nullable field value to be set</param>
        public void SetType(SegmentLeaderboardType? type_)
        {
            SetFieldValue(1, 0, type_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the GroupPrimaryKey field
        /// Comment: Primary user ID of this leader</summary>
        /// <returns>Returns nullable uint representing the GroupPrimaryKey field</returns>
        public uint? GetGroupPrimaryKey()
        {
            return (uint?)GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set GroupPrimaryKey field
        /// Comment: Primary user ID of this leader</summary>
        /// <param name="groupPrimaryKey_">Nullable field value to be set</param>
        public void SetGroupPrimaryKey(uint? groupPrimaryKey_)
        {
            SetFieldValue(2, 0, groupPrimaryKey_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ActivityId field
        /// Comment: ID of the activity associated with this leader time</summary>
        /// <returns>Returns nullable uint representing the ActivityId field</returns>
        public uint? GetActivityId()
        {
            return (uint?)GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set ActivityId field
        /// Comment: ID of the activity associated with this leader time</summary>
        /// <param name="activityId_">Nullable field value to be set</param>
        public void SetActivityId(uint? activityId_)
        {
            SetFieldValue(3, 0, activityId_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SegmentTime field
        /// Units: s
        /// Comment: Segment Time (includes pauses)</summary>
        /// <returns>Returns nullable float representing the SegmentTime field</returns>
        public float? GetSegmentTime()
        {
            return (float?)GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set SegmentTime field
        /// Units: s
        /// Comment: Segment Time (includes pauses)</summary>
        /// <param name="segmentTime_">Nullable field value to be set</param>
        public void SetSegmentTime(float? segmentTime_)
        {
            SetFieldValue(4, 0, segmentTime_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ActivityIdString field
        /// Comment: String version of the activity_id. 21 characters long, express in decimal</summary>
        /// <returns>Returns byte[] representing the ActivityIdString field</returns>
        public byte[] GetActivityIdString()
        {
            return (byte[])GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
        }

        
        ///<summary>
        /// Retrieves the ActivityIdString field
        /// Comment: String version of the activity_id. 21 characters long, express in decimal</summary>
        /// <returns>Returns String representing the ActivityIdString field</returns>
        public String GetActivityIdStringAsString()
        {
            byte[] data = (byte[])GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            return Encoding.UTF8.GetString(data, 0, data.Length - 1);
        }
        

        
        ///<summary>
        /// Set ActivityIdString field
        /// Comment: String version of the activity_id. 21 characters long, express in decimal</summary>
        /// <param name="activityIdString_"> field value to be set</param>
        public void SetActivityIdString(String activityIdString_)
        {
            byte[] data = Encoding.UTF8.GetBytes(activityIdString_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(5, 0, zdata, Fit.SubfieldIndexMainField);
        }
        

        /// <summary>
        /// Set ActivityIdString field
        /// Comment: String version of the activity_id. 21 characters long, express in decimal</summary>
        /// <param name="activityIdString_">field value to be set</param>
        public void SetActivityIdString(byte[] activityIdString_)
        {
            SetFieldValue(5, 0, activityIdString_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
