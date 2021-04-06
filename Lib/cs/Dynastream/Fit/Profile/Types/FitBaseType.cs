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

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the profile FitBaseType type as a class
    /// </summary>
    public static class FitBaseType 
    {
        public const byte Enum = 0;
        public const byte Sint8 = 1;
        public const byte Uint8 = 2;
        public const byte Sint16 = 131;
        public const byte Uint16 = 132;
        public const byte Sint32 = 133;
        public const byte Uint32 = 134;
        public const byte String = 7;
        public const byte Float32 = 136;
        public const byte Float64 = 137;
        public const byte Uint8z = 10;
        public const byte Uint16z = 139;
        public const byte Uint32z = 140;
        public const byte Byte = 13;
        public const byte Invalid = (byte)0xFF;


        public static bool IsNumericInvalid(long value, byte type)
        {
            bool isInvalid = false;

            switch(type)
            {
                case Enum:
                case Byte:
                case Uint8:
                case Uint8z:
                {
                    byte val = (byte)Fit.BaseType[type & Fit.BaseTypeNumMask].invalidValue;
                    if ((byte)value == val)
                        isInvalid = true;
                    break;
                }
                case Sint8:
                {
                    sbyte val = (sbyte)Fit.BaseType[type & Fit.BaseTypeNumMask].invalidValue;
                    if ((sbyte)value == val)
                        isInvalid = true;
                    break;
                }
                case Sint16:
                {
                    short val = (short)Fit.BaseType[type & Fit.BaseTypeNumMask].invalidValue;
                    if ((short)value == val)
                        isInvalid = true;
                    break;
                }
                case Uint16:
                case Uint16z:
                {
                    ushort val = (ushort)Fit.BaseType[type & Fit.BaseTypeNumMask].invalidValue;
                    if ((ushort)value == val)
                        isInvalid = true;
                    break;
                }
                case Sint32:
                {
                    int val = (int)Fit.BaseType[type & Fit.BaseTypeNumMask].invalidValue;
                    if ((int)value == val)
                        isInvalid = true;
                    break;
                }
                case Uint32:
                case Uint32z:
                {
                    uint val = (uint)Fit.BaseType[type & Fit.BaseTypeNumMask].invalidValue;
                    if (((uint)value) == val)
                        isInvalid = true;
                    break;
                }
                case Float32:
                {
                    float val = (float)Fit.BaseType[type & Fit.BaseTypeNumMask].invalidValue;
                    if ((float)value == val)
                        isInvalid = true;
                    break;
                }
                case Float64:
                {
                    double val = (double)Fit.BaseType[type & Fit.BaseTypeNumMask].invalidValue;
                    if ((double)value == val)
                        isInvalid = true;
                    break;
                }
                default:
                    isInvalid = true;
                    break;
            }

            return isInvalid;
        }
    }
}

