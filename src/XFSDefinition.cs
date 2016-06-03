using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace XFS.Net
{
    [StructLayout(LayoutKind.Sequential, Pack = XFSConstants.STRUCTPACKSIZE, CharSet = XFSConstants.CHARSET)]
    public struct SYSTEMTIME
    {
        public ushort wYear;
        public ushort wMonth;
        public ushort wDayOfWeek;
        public ushort wDay;
        public ushort wHour;
        public ushort wMinute;
        public ushort wSecond;
        public ushort wMilliseconds;
    }

    [StructLayout(LayoutKind.Sequential, Pack = XFSConstants.STRUCTPACKSIZE, CharSet = XFSConstants.CHARSET)]
    public struct WFSRESULT
    {
        public ulong RequestID;
        public ushort hService;
        public SYSTEMTIME tsTimestamp;
        public long hResult;
        public int dwCommandCodeOrEventID;
        public IntPtr lpBuffer;
    }
}
