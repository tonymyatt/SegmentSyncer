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
    /// Implements the FieldDescription profile message.
    /// </summary>
    public class FieldDescriptionMesg : Mesg
    {
        #region Fields
        #endregion

        #region Constructors
        public FieldDescriptionMesg() : base(Profile.GetMesg(MesgNum.FieldDescription))
        {
        }

        public FieldDescriptionMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the DeveloperDataIndex field</summary>
        /// <returns>Returns nullable byte representing the DeveloperDataIndex field</returns>
        public byte? GetDeveloperDataIndex()
        {
            return (byte?)GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set DeveloperDataIndex field</summary>
        /// <param name="developerDataIndex_">Nullable field value to be set</param>
        public void SetDeveloperDataIndex(byte? developerDataIndex_)
        {
            SetFieldValue(0, 0, developerDataIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the FieldDefinitionNumber field</summary>
        /// <returns>Returns nullable byte representing the FieldDefinitionNumber field</returns>
        public byte? GetFieldDefinitionNumber()
        {
            return (byte?)GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set FieldDefinitionNumber field</summary>
        /// <param name="fieldDefinitionNumber_">Nullable field value to be set</param>
        public void SetFieldDefinitionNumber(byte? fieldDefinitionNumber_)
        {
            SetFieldValue(1, 0, fieldDefinitionNumber_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the FitBaseTypeId field</summary>
        /// <returns>Returns nullable byte representing the FitBaseTypeId field</returns>
        public byte? GetFitBaseTypeId()
        {
            return (byte?)GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set FitBaseTypeId field</summary>
        /// <param name="fitBaseTypeId_">Nullable field value to be set</param>
        public void SetFitBaseTypeId(byte? fitBaseTypeId_)
        {
            SetFieldValue(2, 0, fitBaseTypeId_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field FieldName</returns>
        public int GetNumFieldName()
        {
            return GetNumFieldValues(3, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the FieldName field</summary>
        /// <param name="index">0 based index of FieldName element to retrieve</param>
        /// <returns>Returns byte[] representing the FieldName field</returns>
        public byte[] GetFieldName(int index)
        {
            return (byte[])GetFieldValue(3, index, Fit.SubfieldIndexMainField);
        }

        
        ///<summary>
        /// Retrieves the FieldName field</summary>
        /// <param name="index">0 based index of FieldName element to retrieve</param>
        /// <returns>Returns String representing the FieldName field</returns>
        public String GetFieldNameAsString(int index)
        {
            byte[] data = (byte[])GetFieldValue(3, index, Fit.SubfieldIndexMainField);
            return Encoding.UTF8.GetString(data, 0, data.Length - 1);
        }
        

        
        ///<summary>
        /// Set FieldName field</summary>
        /// <param name="index">0 based index of FieldName element to retrieve</param>
        /// <param name="fieldName_"> field value to be set</param>
        public void SetFieldName(int index, String fieldName_)
        {
            byte[] data = Encoding.UTF8.GetBytes(fieldName_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(3, index, zdata, Fit.SubfieldIndexMainField);
        }
        

        /// <summary>
        /// Set FieldName field</summary>
        /// <param name="index">0 based index of field_name</param>
        /// <param name="fieldName_">field value to be set</param>
        public void SetFieldName(int index, byte[] fieldName_)
        {
            SetFieldValue(3, index, fieldName_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Array field</summary>
        /// <returns>Returns nullable byte representing the Array field</returns>
        public byte? GetArray()
        {
            return (byte?)GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set Array field</summary>
        /// <param name="array_">Nullable field value to be set</param>
        public void SetArray(byte? array_)
        {
            SetFieldValue(4, 0, array_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Components field</summary>
        /// <returns>Returns byte[] representing the Components field</returns>
        public byte[] GetComponents()
        {
            return (byte[])GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
        }

        
        ///<summary>
        /// Retrieves the Components field</summary>
        /// <returns>Returns String representing the Components field</returns>
        public String GetComponentsAsString()
        {
            byte[] data = (byte[])GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            return Encoding.UTF8.GetString(data, 0, data.Length - 1);
        }
        

        
        ///<summary>
        /// Set Components field</summary>
        /// <param name="components_"> field value to be set</param>
        public void SetComponents(String components_)
        {
            byte[] data = Encoding.UTF8.GetBytes(components_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(5, 0, zdata, Fit.SubfieldIndexMainField);
        }
        

        /// <summary>
        /// Set Components field</summary>
        /// <param name="components_">field value to be set</param>
        public void SetComponents(byte[] components_)
        {
            SetFieldValue(5, 0, components_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Scale field</summary>
        /// <returns>Returns nullable byte representing the Scale field</returns>
        public byte? GetScale()
        {
            return (byte?)GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set Scale field</summary>
        /// <param name="scale_">Nullable field value to be set</param>
        public void SetScale(byte? scale_)
        {
            SetFieldValue(6, 0, scale_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Offset field</summary>
        /// <returns>Returns nullable sbyte representing the Offset field</returns>
        public sbyte? GetOffset()
        {
            return (sbyte?)GetFieldValue(7, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set Offset field</summary>
        /// <param name="offset_">Nullable field value to be set</param>
        public void SetOffset(sbyte? offset_)
        {
            SetFieldValue(7, 0, offset_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field Units</returns>
        public int GetNumUnits()
        {
            return GetNumFieldValues(8, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the Units field</summary>
        /// <param name="index">0 based index of Units element to retrieve</param>
        /// <returns>Returns byte[] representing the Units field</returns>
        public byte[] GetUnits(int index)
        {
            return (byte[])GetFieldValue(8, index, Fit.SubfieldIndexMainField);
        }

        
        ///<summary>
        /// Retrieves the Units field</summary>
        /// <param name="index">0 based index of Units element to retrieve</param>
        /// <returns>Returns String representing the Units field</returns>
        public String GetUnitsAsString(int index)
        {
            byte[] data = (byte[])GetFieldValue(8, index, Fit.SubfieldIndexMainField);
            return Encoding.UTF8.GetString(data, 0, data.Length - 1);
        }
        

        
        ///<summary>
        /// Set Units field</summary>
        /// <param name="index">0 based index of Units element to retrieve</param>
        /// <param name="units_"> field value to be set</param>
        public void SetUnits(int index, String units_)
        {
            byte[] data = Encoding.UTF8.GetBytes(units_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(8, index, zdata, Fit.SubfieldIndexMainField);
        }
        

        /// <summary>
        /// Set Units field</summary>
        /// <param name="index">0 based index of units</param>
        /// <param name="units_">field value to be set</param>
        public void SetUnits(int index, byte[] units_)
        {
            SetFieldValue(8, index, units_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Bits field</summary>
        /// <returns>Returns byte[] representing the Bits field</returns>
        public byte[] GetBits()
        {
            return (byte[])GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
        }

        
        ///<summary>
        /// Retrieves the Bits field</summary>
        /// <returns>Returns String representing the Bits field</returns>
        public String GetBitsAsString()
        {
            byte[] data = (byte[])GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
            return Encoding.UTF8.GetString(data, 0, data.Length - 1);
        }
        

        
        ///<summary>
        /// Set Bits field</summary>
        /// <param name="bits_"> field value to be set</param>
        public void SetBits(String bits_)
        {
            byte[] data = Encoding.UTF8.GetBytes(bits_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(9, 0, zdata, Fit.SubfieldIndexMainField);
        }
        

        /// <summary>
        /// Set Bits field</summary>
        /// <param name="bits_">field value to be set</param>
        public void SetBits(byte[] bits_)
        {
            SetFieldValue(9, 0, bits_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Accumulate field</summary>
        /// <returns>Returns byte[] representing the Accumulate field</returns>
        public byte[] GetAccumulate()
        {
            return (byte[])GetFieldValue(10, 0, Fit.SubfieldIndexMainField);
        }

        
        ///<summary>
        /// Retrieves the Accumulate field</summary>
        /// <returns>Returns String representing the Accumulate field</returns>
        public String GetAccumulateAsString()
        {
            byte[] data = (byte[])GetFieldValue(10, 0, Fit.SubfieldIndexMainField);
            return Encoding.UTF8.GetString(data, 0, data.Length - 1);
        }
        

        
        ///<summary>
        /// Set Accumulate field</summary>
        /// <param name="accumulate_"> field value to be set</param>
        public void SetAccumulate(String accumulate_)
        {
            byte[] data = Encoding.UTF8.GetBytes(accumulate_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(10, 0, zdata, Fit.SubfieldIndexMainField);
        }
        

        /// <summary>
        /// Set Accumulate field</summary>
        /// <param name="accumulate_">field value to be set</param>
        public void SetAccumulate(byte[] accumulate_)
        {
            SetFieldValue(10, 0, accumulate_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the FitBaseUnitId field</summary>
        /// <returns>Returns nullable ushort representing the FitBaseUnitId field</returns>
        public ushort? GetFitBaseUnitId()
        {
            return (ushort?)GetFieldValue(13, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set FitBaseUnitId field</summary>
        /// <param name="fitBaseUnitId_">Nullable field value to be set</param>
        public void SetFitBaseUnitId(ushort? fitBaseUnitId_)
        {
            SetFieldValue(13, 0, fitBaseUnitId_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
