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
    /// Implements .FIT header encode/decode.
    /// </summary>
    public class Header
    {
        #region Fields
        private char[] dataType;
        private byte size;
        #endregion

        #region Properties
        public byte Size
        {
            get
            {
                return size;
            }
            set
            {
                if (value == Fit.HeaderWithCRCSize || value == Fit.HeaderWithoutCRCSize)
                {
                    size = value;
                }
                else
                {
                    throw new FitException("Tried to set Header Size to " + value);
                }
            }
        }
        public byte ProtocolVersion { get; set; }
        public ushort ProfileVersion { get; set; }
        public uint DataSize { get; set; }
        public ushort Crc { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Build a standard header with CRC.  The CRC will be
        /// precomputed and it is assumed no data is present yet.
        /// </summary>
        [Obsolete("Headers now support multiple Protocol versions.")]
        public Header()
            : this(Dynastream.Fit.ProtocolVersion.V10)
        {
        }

        /// <summary>
        /// Build a standard header with CRC.  The CRC will be
        /// precomputed and it is assumed no data is present yet.
        /// </summary>
        public Header(ProtocolVersion version)
        {
            Size = Fit.HeaderWithCRCSize;
            ProtocolVersion = version.GetVersionByte();
            ProfileVersion = Fit.ProfileVersion;
            DataSize = 0;
            dataType = new char[] { '.', 'F', 'I', 'T' };

            UpdateCRC();
        }

        /// <summary>
        /// Build header by decoding callers stream.
        /// </summary>
        /// <param name="fitStream"></param>
        public Header(Stream fitStream)
        {
            Read(fitStream);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Verify Header format is valid.
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            if (new string(dataType) == ".FIT")
            {
                // Don't enforce header CRC anymore
                return true;
            }
            return false;
        }

        /// <summary>
        /// Populate header object by decoding callers stream
        /// </summary>
        /// <param name="fitStream">Readable stream</param>
        public void Read(Stream fitStream)
        {
            BinaryReader binReader = new BinaryReader(fitStream);
            try
            {
                Size = binReader.ReadByte();
                ProtocolVersion = binReader.ReadByte();
                ProfileVersion = binReader.ReadUInt16();
                DataSize = binReader.ReadUInt32();
                dataType = binReader.ReadChars(4);
                if (Size == Fit.HeaderWithCRCSize)
                {
                    Crc = binReader.ReadUInt16();
                }
                else
                {
                    Crc = 0x0000;
                }
            }
            catch (EndOfStreamException e)
            {
                throw new FitException("Header:Read() Failed at byte " + fitStream.Position + " - ", e);
            }
        }

        /// <summary>
        /// Output header object to beginning of callers writeable stream.  Crc should
        /// be recalculated before calling.
        /// </summary>
        /// <param name="fitStream">Writeable, Seekable stream.  Position set to end of header</param>
        public void Write(Stream fitStream)
        {
            BinaryWriter bw = new BinaryWriter(fitStream);

            bw.BaseStream.Position = 0;

            bw.Write(Size);
            bw.Write(ProtocolVersion);
            bw.Write(ProfileVersion);
            bw.Write(DataSize);
            bw.Write(dataType);
            if (Size == Fit.HeaderWithCRCSize)
            {
                bw.Write(Crc);
            }
        }

        /// <summary>
        /// Recompute the header CRC based on the current contents of the header object
        /// </summary>
        public void UpdateCRC()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Write(ms);
                byte[] headerBuffer = ms.ToArray();
                Crc = CRC.Calc16(headerBuffer, headerBuffer.Length - 2);
            }
        }
        #endregion // methods
    } // class
} // namespace