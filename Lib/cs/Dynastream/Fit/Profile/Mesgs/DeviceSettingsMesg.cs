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
    /// Implements the DeviceSettings profile message.
    /// </summary>
    public class DeviceSettingsMesg : Mesg
    {
        #region Fields
        #endregion

        #region Constructors
        public DeviceSettingsMesg() : base(Profile.GetMesg(MesgNum.DeviceSettings))
        {
        }

        public DeviceSettingsMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the ActiveTimeZone field
        /// Comment: Index into time zone arrays.</summary>
        /// <returns>Returns nullable byte representing the ActiveTimeZone field</returns>
        public byte? GetActiveTimeZone()
        {
            return (byte?)GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set ActiveTimeZone field
        /// Comment: Index into time zone arrays.</summary>
        /// <param name="activeTimeZone_">Nullable field value to be set</param>
        public void SetActiveTimeZone(byte? activeTimeZone_)
        {
            SetFieldValue(0, 0, activeTimeZone_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the UtcOffset field
        /// Comment: Offset from system time. Required to convert timestamp from system time to UTC.</summary>
        /// <returns>Returns nullable uint representing the UtcOffset field</returns>
        public uint? GetUtcOffset()
        {
            return (uint?)GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set UtcOffset field
        /// Comment: Offset from system time. Required to convert timestamp from system time to UTC.</summary>
        /// <param name="utcOffset_">Nullable field value to be set</param>
        public void SetUtcOffset(uint? utcOffset_)
        {
            SetFieldValue(1, 0, utcOffset_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field TimeOffset</returns>
        public int GetNumTimeOffset()
        {
            return GetNumFieldValues(2, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the TimeOffset field
        /// Units: s
        /// Comment: Offset from system time.</summary>
        /// <param name="index">0 based index of TimeOffset element to retrieve</param>
        /// <returns>Returns nullable uint representing the TimeOffset field</returns>
        public uint? GetTimeOffset(int index)
        {
            return (uint?)GetFieldValue(2, index, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set TimeOffset field
        /// Units: s
        /// Comment: Offset from system time.</summary>
        /// <param name="index">0 based index of time_offset</param>
        /// <param name="timeOffset_">Nullable field value to be set</param>
        public void SetTimeOffset(int index, uint? timeOffset_)
        {
            SetFieldValue(2, index, timeOffset_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field TimeZoneOffset</returns>
        public int GetNumTimeZoneOffset()
        {
            return GetNumFieldValues(5, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the TimeZoneOffset field
        /// Units: hr
        /// Comment: timezone offset in 1/4 hour increments</summary>
        /// <param name="index">0 based index of TimeZoneOffset element to retrieve</param>
        /// <returns>Returns nullable float representing the TimeZoneOffset field</returns>
        public float? GetTimeZoneOffset(int index)
        {
            return (float?)GetFieldValue(5, index, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set TimeZoneOffset field
        /// Units: hr
        /// Comment: timezone offset in 1/4 hour increments</summary>
        /// <param name="index">0 based index of time_zone_offset</param>
        /// <param name="timeZoneOffset_">Nullable field value to be set</param>
        public void SetTimeZoneOffset(int index, float? timeZoneOffset_)
        {
            SetFieldValue(5, index, timeZoneOffset_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the DisplayOrientation field</summary>
        /// <returns>Returns nullable DisplayOrientation enum representing the DisplayOrientation field</returns>
        public DisplayOrientation? GetDisplayOrientation()
        {
            object obj = GetFieldValue(55, 0, Fit.SubfieldIndexMainField);
            DisplayOrientation? value = obj == null ? (DisplayOrientation?)null : (DisplayOrientation)obj;
            return value;
        }

        

        

        /// <summary>
        /// Set DisplayOrientation field</summary>
        /// <param name="displayOrientation_">Nullable field value to be set</param>
        public void SetDisplayOrientation(DisplayOrientation? displayOrientation_)
        {
            SetFieldValue(55, 0, displayOrientation_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MountingSide field</summary>
        /// <returns>Returns nullable Side enum representing the MountingSide field</returns>
        public Side? GetMountingSide()
        {
            object obj = GetFieldValue(56, 0, Fit.SubfieldIndexMainField);
            Side? value = obj == null ? (Side?)null : (Side)obj;
            return value;
        }

        

        

        /// <summary>
        /// Set MountingSide field</summary>
        /// <param name="mountingSide_">Nullable field value to be set</param>
        public void SetMountingSide(Side? mountingSide_)
        {
            SetFieldValue(56, 0, mountingSide_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the NumberOfScreens field
        /// Comment: Number of screens configured to display</summary>
        /// <returns>Returns nullable byte representing the NumberOfScreens field</returns>
        public byte? GetNumberOfScreens()
        {
            return (byte?)GetFieldValue(94, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set NumberOfScreens field
        /// Comment: Number of screens configured to display</summary>
        /// <param name="numberOfScreens_">Nullable field value to be set</param>
        public void SetNumberOfScreens(byte? numberOfScreens_)
        {
            SetFieldValue(94, 0, numberOfScreens_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SmartNotificationDisplayOrientation field
        /// Comment: Smart Notification display orientation</summary>
        /// <returns>Returns nullable DisplayOrientation enum representing the SmartNotificationDisplayOrientation field</returns>
        public DisplayOrientation? GetSmartNotificationDisplayOrientation()
        {
            object obj = GetFieldValue(95, 0, Fit.SubfieldIndexMainField);
            DisplayOrientation? value = obj == null ? (DisplayOrientation?)null : (DisplayOrientation)obj;
            return value;
        }

        

        

        /// <summary>
        /// Set SmartNotificationDisplayOrientation field
        /// Comment: Smart Notification display orientation</summary>
        /// <param name="smartNotificationDisplayOrientation_">Nullable field value to be set</param>
        public void SetSmartNotificationDisplayOrientation(DisplayOrientation? smartNotificationDisplayOrientation_)
        {
            SetFieldValue(95, 0, smartNotificationDisplayOrientation_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
