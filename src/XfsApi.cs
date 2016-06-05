using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace XFS.Net
{
    public static class XfsApi
    {
        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSCancelAsyncRequest(ushort hService, ulong RequestID);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSCancelBlockingCall(int dwThreadID);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSCleanUp();

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSClose(ushort hService);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSAsyncClose(ushort hService, IntPtr hWnd, ref ulong lpRequestID);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSCreateAppHandle(ref IntPtr lphApp);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSDeregister(ushort hService, int dwEventClass, IntPtr hWndReg);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSAsyncDeregister(ushort hService, int dwEventClass, IntPtr hWndReg, IntPtr hWnd, ref ulong lpRequestID);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSDestroyAppHandle(IntPtr hApp);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSExecute(ushort hService, int dwCommand, IntPtr lpCmdData, int dwTimeOut, ref IntPtr lppResult);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSAsyncExecute(ushort hService, int dwCommand, IntPtr lpCmdData, int dwTimeOut, IntPtr hWnd, 
            ref ulong lpRequestID);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSFreeResult(ref WFSRESULT lpResult);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSGetInfo(ushort hService, int dwCategory, IntPtr lpQueryDetails, int dwTimeOut, ref IntPtr lppResult);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSAsyncGetInfo(ushort hService, int dwCategory, IntPtr lpQueryDetails, int dwTimeOut, IntPtr hWnd,
            ref ulong lpRequestID);
        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern bool WFSIsBlocking();

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSLock(ushort hService, int dwTimeOut, ref IntPtr lppResult);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSAsyncLock(ushort hService, int dwTimeOut, IntPtr hWnd, ref ulong lpRequestID);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSOpen(string lpszLogicalName, IntPtr hApp, string lpszAppID, int dwTraceLevel, int dwTimeOut, 
            int dwSrvcVersionsRequired, LPWFSVERSION lpSrvcVersion, LPWFSVERSION lpSPIVersion, ref ushort lphService);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSAsyncOpen(string lpszLogicalName, IntPtr hApp, string lpszAppID, int dwTraceLevel, int dwTimeOut, 
            ref ushort lphService, IntPtr hWnd, int dwSrvcVersionsRequired, LPWFSVERSION lpSrvcVersion, LPWFSVERSION lpSPIVersion, 
            ref ulong lpRequestID);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSRegister(ushort hService, int dwEventClass, IntPtr hWndReg);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSAsyncRegister(ushort hService, int dwEventClass, IntPtr hWndReg, IntPtr hWnd, ref ulong lpRequestID);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSSetBlockingHook(XFSBLOCKINGHOOK lpBlockFunc, LPXFSBLOCKINGHOOK lppPrevFunc);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSStartUp(int dwVersionsRequired, LPWFSVERSION lpWFSVersion);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSUnhookBlockingHook();

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSUnlock(ushort hService);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFSAsyncUnlock(ushort hService, IntPtr hWnd, ref ulong lpRequestID);

        [DllImport(XFSConstants.LIBNAME, CharSet = XFSConstants.CHARSET, CallingConvention = XFSConstants.CALLINGCONVENTION)]
        public static extern long WFMSetTraceLevel(ushort hService, int dwTraceLevel);
    }
}
