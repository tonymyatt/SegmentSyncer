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
    /// Implements the BloodPressure profile message.
    /// </summary>
    public class BloodPressureMesg : Mesg
    {
        #region Fields
        #endregion

        #region Constructors
        public BloodPressureMesg() : base(Profile.GetMesg(MesgNum.BloodPressure))
        {
        }

        public BloodPressureMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the Timestamp field
        /// Units: s</summary>
        /// <returns>Returns DateTime representing the Timestamp field</returns>
        public DateTime GetTimestamp()
        {
            return TimestampToDateTime((uint?)GetFieldValue(253, 0, Fit.SubfieldIndexMainField));
        }

        

        

        /// <summary>
        /// Set Timestamp field
        /// Units: s</summary>
        /// <param name="timestamp_">Nullable field value to be set</param>
        public void SetTimestamp(DateTime timestamp_)
        {
            SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SystolicPressure field
        /// Units: mmHg</summary>
        /// <returns>Returns nullable ushort representing the SystolicPressure field</returns>
        public ushort? GetSystolicPressure()
        {
            return (ushort?)GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set SystolicPressure field
        /// Units: mmHg</summary>
        /// <param name="systolicPressure_">Nullable field value to be set</param>
        public void SetSystolicPressure(ushort? systolicPressure_)
        {
            SetFieldValue(0, 0, systolicPressure_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the DiastolicPressure field
        /// Units: mmHg</summary>
        /// <returns>Returns nullable ushort representing the DiastolicPressure field</returns>
        public ushort? GetDiastolicPressure()
        {
            return (ushort?)GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set DiastolicPressure field
        /// Units: mmHg</summary>
        /// <param name="diastolicPressure_">Nullable field value to be set</param>
        public void SetDiastolicPressure(ushort? diastolicPressure_)
        {
            SetFieldValue(1, 0, diastolicPressure_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MeanArterialPressure field
        /// Units: mmHg</summary>
        /// <returns>Returns nullable ushort representing the MeanArterialPressure field</returns>
        public ushort? GetMeanArterialPressure()
        {
            return (ushort?)GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set MeanArterialPressure field
        /// Units: mmHg</summary>
        /// <param name="meanArterialPressure_">Nullable field value to be set</param>
        public void SetMeanArterialPressure(ushort? meanArterialPressure_)
        {
            SetFieldValue(2, 0, meanArterialPressure_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Map3SampleMean field
        /// Units: mmHg</summary>
        /// <returns>Returns nullable ushort representing the Map3SampleMean field</returns>
        public ushort? GetMap3SampleMean()
        {
            return (ushort?)GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set Map3SampleMean field
        /// Units: mmHg</summary>
        /// <param name="map3SampleMean_">Nullable field value to be set</param>
        public void SetMap3SampleMean(ushort? map3SampleMean_)
        {
            SetFieldValue(3, 0, map3SampleMean_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MapMorningValues field
        /// Units: mmHg</summary>
        /// <returns>Returns nullable ushort representing the MapMorningValues field</returns>
        public ushort? GetMapMorningValues()
        {
            return (ushort?)GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set MapMorningValues field
        /// Units: mmHg</summary>
        /// <param name="mapMorningValues_">Nullable field value to be set</param>
        public void SetMapMorningValues(ushort? mapMorningValues_)
        {
            SetFieldValue(4, 0, mapMorningValues_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MapEveningValues field
        /// Units: mmHg</summary>
        /// <returns>Returns nullable ushort representing the MapEveningValues field</returns>
        public ushort? GetMapEveningValues()
        {
            return (ushort?)GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set MapEveningValues field
        /// Units: mmHg</summary>
        /// <param name="mapEveningValues_">Nullable field value to be set</param>
        public void SetMapEveningValues(ushort? mapEveningValues_)
        {
            SetFieldValue(5, 0, mapEveningValues_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the HeartRate field
        /// Units: bpm</summary>
        /// <returns>Returns nullable byte representing the HeartRate field</returns>
        public byte? GetHeartRate()
        {
            return (byte?)GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set HeartRate field
        /// Units: bpm</summary>
        /// <param name="heartRate_">Nullable field value to be set</param>
        public void SetHeartRate(byte? heartRate_)
        {
            SetFieldValue(6, 0, heartRate_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the HeartRateType field</summary>
        /// <returns>Returns nullable HrType enum representing the HeartRateType field</returns>
        public HrType? GetHeartRateType()
        {
            object obj = GetFieldValue(7, 0, Fit.SubfieldIndexMainField);
            HrType? value = obj == null ? (HrType?)null : (HrType)obj;
            return value;
        }

        

        

        /// <summary>
        /// Set HeartRateType field</summary>
        /// <param name="heartRateType_">Nullable field value to be set</param>
        public void SetHeartRateType(HrType? heartRateType_)
        {
            SetFieldValue(7, 0, heartRateType_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Status field</summary>
        /// <returns>Returns nullable BpStatus enum representing the Status field</returns>
        public BpStatus? GetStatus()
        {
            object obj = GetFieldValue(8, 0, Fit.SubfieldIndexMainField);
            BpStatus? value = obj == null ? (BpStatus?)null : (BpStatus)obj;
            return value;
        }

        

        

        /// <summary>
        /// Set Status field</summary>
        /// <param name="status_">Nullable field value to be set</param>
        public void SetStatus(BpStatus? status_)
        {
            SetFieldValue(8, 0, status_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the UserProfileIndex field
        /// Comment: Associates this blood pressure message to a user.  This corresponds to the index of the user profile message in the blood pressure file.</summary>
        /// <returns>Returns nullable ushort representing the UserProfileIndex field</returns>
        public ushort? GetUserProfileIndex()
        {
            return (ushort?)GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set UserProfileIndex field
        /// Comment: Associates this blood pressure message to a user.  This corresponds to the index of the user profile message in the blood pressure file.</summary>
        /// <param name="userProfileIndex_">Nullable field value to be set</param>
        public void SetUserProfileIndex(ushort? userProfileIndex_)
        {
            SetFieldValue(9, 0, userProfileIndex_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
