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
    /// Implements the TimestampCorrelation profile message.
    /// </summary>
    public class TimestampCorrelationMesg : Mesg
    {
        #region Fields
        #endregion

        #region Constructors
        public TimestampCorrelationMesg() : base(Profile.GetMesg(MesgNum.TimestampCorrelation))
        {
        }

        public TimestampCorrelationMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the Timestamp field
        /// Units: s
        /// Comment: Whole second part of UTC timestamp at the time the system timestamp was recorded.</summary>
        /// <returns>Returns DateTime representing the Timestamp field</returns>
        public DateTime GetTimestamp()
        {
            return TimestampToDateTime((uint?)GetFieldValue(253, 0, Fit.SubfieldIndexMainField));
        }

        

        

        /// <summary>
        /// Set Timestamp field
        /// Units: s
        /// Comment: Whole second part of UTC timestamp at the time the system timestamp was recorded.</summary>
        /// <param name="timestamp_">Nullable field value to be set</param>
        public void SetTimestamp(DateTime timestamp_)
        {
            SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the FractionalTimestamp field
        /// Units: s
        /// Comment: Fractional part of the UTC timestamp at the time the system timestamp was recorded.</summary>
        /// <returns>Returns nullable float representing the FractionalTimestamp field</returns>
        public float? GetFractionalTimestamp()
        {
            return (float?)GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set FractionalTimestamp field
        /// Units: s
        /// Comment: Fractional part of the UTC timestamp at the time the system timestamp was recorded.</summary>
        /// <param name="fractionalTimestamp_">Nullable field value to be set</param>
        public void SetFractionalTimestamp(float? fractionalTimestamp_)
        {
            SetFieldValue(0, 0, fractionalTimestamp_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SystemTimestamp field
        /// Units: s
        /// Comment: Whole second part of the system timestamp</summary>
        /// <returns>Returns DateTime representing the SystemTimestamp field</returns>
        public DateTime GetSystemTimestamp()
        {
            return TimestampToDateTime((uint?)GetFieldValue(1, 0, Fit.SubfieldIndexMainField));
        }

        

        

        /// <summary>
        /// Set SystemTimestamp field
        /// Units: s
        /// Comment: Whole second part of the system timestamp</summary>
        /// <param name="systemTimestamp_">Nullable field value to be set</param>
        public void SetSystemTimestamp(DateTime systemTimestamp_)
        {
            SetFieldValue(1, 0, systemTimestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the FractionalSystemTimestamp field
        /// Units: s
        /// Comment: Fractional part of the system timestamp</summary>
        /// <returns>Returns nullable float representing the FractionalSystemTimestamp field</returns>
        public float? GetFractionalSystemTimestamp()
        {
            return (float?)GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set FractionalSystemTimestamp field
        /// Units: s
        /// Comment: Fractional part of the system timestamp</summary>
        /// <param name="fractionalSystemTimestamp_">Nullable field value to be set</param>
        public void SetFractionalSystemTimestamp(float? fractionalSystemTimestamp_)
        {
            SetFieldValue(2, 0, fractionalSystemTimestamp_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the LocalTimestamp field
        /// Units: s
        /// Comment: timestamp epoch expressed in local time used to convert timestamps to local time </summary>
        /// <returns>Returns nullable uint representing the LocalTimestamp field</returns>
        public uint? GetLocalTimestamp()
        {
            return (uint?)GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set LocalTimestamp field
        /// Units: s
        /// Comment: timestamp epoch expressed in local time used to convert timestamps to local time </summary>
        /// <param name="localTimestamp_">Nullable field value to be set</param>
        public void SetLocalTimestamp(uint? localTimestamp_)
        {
            SetFieldValue(3, 0, localTimestamp_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TimestampMs field
        /// Units: ms
        /// Comment: Millisecond part of the UTC timestamp at the time the system timestamp was recorded.</summary>
        /// <returns>Returns nullable ushort representing the TimestampMs field</returns>
        public ushort? GetTimestampMs()
        {
            return (ushort?)GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set TimestampMs field
        /// Units: ms
        /// Comment: Millisecond part of the UTC timestamp at the time the system timestamp was recorded.</summary>
        /// <param name="timestampMs_">Nullable field value to be set</param>
        public void SetTimestampMs(ushort? timestampMs_)
        {
            SetFieldValue(4, 0, timestampMs_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SystemTimestampMs field
        /// Units: ms
        /// Comment: Millisecond part of the system timestamp</summary>
        /// <returns>Returns nullable ushort representing the SystemTimestampMs field</returns>
        public ushort? GetSystemTimestampMs()
        {
            return (ushort?)GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set SystemTimestampMs field
        /// Units: ms
        /// Comment: Millisecond part of the system timestamp</summary>
        /// <param name="systemTimestampMs_">Nullable field value to be set</param>
        public void SetSystemTimestampMs(ushort? systemTimestampMs_)
        {
            SetFieldValue(5, 0, systemTimestampMs_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
