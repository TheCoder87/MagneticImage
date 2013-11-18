using System;

namespace DskTool.LogicalDisk
{
    public class Sector
    {
        public int TrackId { get; set; }

        public int SideId { get; set; }

        public int Id { get; set; }

        public int Size { get; set; }

        public byte[] Data { get; set; }

        public bool IsFormatted { get { return Data.Length > 0; } }
    }

    public class PD765Sector : Sector
    {
        public Byte Flag1 { get; set; }

        public Byte Flag2 { get; set; }

        public ushort DataLength { get; set; }
    }
}