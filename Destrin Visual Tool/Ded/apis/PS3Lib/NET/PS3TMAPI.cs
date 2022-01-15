// Decompiled with JetBrains decompiler
// Type: PS3Lib.NET.PS3TMAPI
// Assembly: mw3rcetoolbyexiil, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8C8A46AA-3509-4194-8E44-AF9366ECB502
// Assembly location: C:\Users\Kelly\Desktop\Mods HEN\MW2\PS3 MW2 RCE Tool by ExIIL\MW2 RCE Tool by ExIIL.exe

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

namespace PS3Lib.NET
{
  public class PS3TMAPI
  {
    [DllImport("PS3TMAPIX64.dll", EntryPoint = "SNPS3InitTargetComms", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT InitTargetCommsX64();

    [DllImport("PS3TMAPI.dll", EntryPoint = "SNPS3InitTargetComms", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT InitTargetCommsX86();

    [DllImport("PS3TMAPIX64.dll", EntryPoint = "SNPS3PowerOn", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT PowerOnX64(int target);

    [DllImport("PS3TMAPI.dll", EntryPoint = "SNPS3PowerOn", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT PowerOnX86(int target);

    [DllImport("PS3TMAPIX64.dll", EntryPoint = "SNPS3PowerOff", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT PowerOffX64(int target, uint force);

    [DllImport("PS3TMAPI.dll", EntryPoint = "SNPS3PowerOff", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT PowerOffX86(int target, uint force);

    [DllImport("PS3TMAPIX64.dll", EntryPoint = "SNPS3Connect", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT ConnectX64(int target, string application);

    [DllImport("PS3TMAPI.dll", EntryPoint = "SNPS3Connect", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT ConnectX86(int target, string application);

    [DllImport("PS3TMAPIX64.dll", EntryPoint = "SNPS3GetConnectionInfo", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT GetConnectionInfoX64(
      int target,
      IntPtr connectProperties);

    [DllImport("PS3TMAPI.dll", EntryPoint = "SNPS3GetConnectionInfo", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT GetConnectionInfoX86(
      int target,
      IntPtr connectProperties);

    [DllImport("PS3TMAPIX64.dll", EntryPoint = "SNPS3GetConnectStatus", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT GetConnectStatusX64(
      int target,
      out uint status,
      out IntPtr usage);

    [DllImport("PS3TMAPI.dll", EntryPoint = "SNPS3GetConnectStatus", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT GetConnectStatusX86(
      int target,
      out uint status,
      out IntPtr usage);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern int MultiByteToWideChar(
      int codepage,
      int flags,
      IntPtr utf8,
      int utf8len,
      StringBuilder buffer,
      int buflen);

    [DllImport("PS3TMAPIX64.dll", EntryPoint = "SNPS3ProcessList", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT GetProcessListX64(
      int target,
      ref uint count,
      IntPtr processIdArray);

    [DllImport("PS3TMAPI.dll", EntryPoint = "SNPS3ProcessList", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT GetProcessListX86(
      int target,
      ref uint count,
      IntPtr processIdArray);

    [DllImport("PS3TMAPIX64.dll", EntryPoint = "SNPS3ProcessContinue", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT ProcessContinueX64(int target, uint processId);

    [DllImport("PS3TMAPI.dll", EntryPoint = "SNPS3ProcessContinue", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT ProcessContinueX86(int target, uint processId);

    [DllImport("PS3TMAPIX64.dll", EntryPoint = "SNPS3ProcessAttach", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT ProcessAttachX64(
      int target,
      uint unitId,
      uint processId);

    [DllImport("PS3TMAPI.dll", EntryPoint = "SNPS3ProcessAttach", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT ProcessAttachX86(
      int target,
      uint unitId,
      uint processId);

    [DllImport("PS3TMAPIX64.dll", EntryPoint = "SNPS3ProcessGetMemory", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT ProcessGetMemoryX64(
      int target,
      PS3TMAPI.UnitType unit,
      uint processId,
      ulong threadId,
      ulong address,
      int count,
      byte[] buffer);

    [DllImport("PS3TMAPI.dll", EntryPoint = "SNPS3ProcessGetMemory", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT ProcessGetMemoryX86(
      int target,
      PS3TMAPI.UnitType unit,
      uint processId,
      ulong threadId,
      ulong address,
      int count,
      byte[] buffer);

    [DllImport("PS3TMAPIX64.dll", EntryPoint = "SNPS3GetTargetFromName", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT GetTargetFromNameX64(
      IntPtr name,
      out int target);

    [DllImport("PS3TMAPI.dll", EntryPoint = "SNPS3GetTargetFromName", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT GetTargetFromNameX86(
      IntPtr name,
      out int target);

    [DllImport("PS3TMAPIX64.dll", EntryPoint = "SNPS3Reset", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT ResetX64(int target, ulong resetParameter);

    [DllImport("PS3TMAPI.dll", EntryPoint = "SNPS3Reset", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT ResetX86(int target, ulong resetParameter);

    [DllImport("PS3TMAPIX64.dll", EntryPoint = "SNPS3ProcessSetMemory", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT ProcessSetMemoryX64(
      int target,
      PS3TMAPI.UnitType unit,
      uint processId,
      ulong threadId,
      ulong address,
      int count,
      byte[] buffer);

    [DllImport("PS3TMAPI.dll", EntryPoint = "SNPS3ProcessSetMemory", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT ProcessSetMemoryX86(
      int target,
      PS3TMAPI.UnitType unit,
      uint processId,
      ulong threadId,
      ulong address,
      int count,
      byte[] buffer);

    [DllImport("PS3TMAPIX64.dll", EntryPoint = "SNPS3GetTargetInfo", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT GetTargetInfoX64(
      ref PS3TMAPI.TargetInfoPriv targetInfoPriv);

    [DllImport("PS3TMAPI.dll", EntryPoint = "SNPS3GetTargetInfo", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT GetTargetInfoX86(
      ref PS3TMAPI.TargetInfoPriv targetInfoPriv);

    [DllImport("PS3TMAPIX64.dll", EntryPoint = "SNPS3Disconnect", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT DisconnectX64(int target);

    [DllImport("PS3TMAPI.dll", EntryPoint = "SNPS3Disconnect", CallingConvention = CallingConvention.Cdecl)]
    private static extern PS3TMAPI.SNRESULT DisconnectX86(int target);

    private static bool Is32Bit()
    {
      return IntPtr.Size == 4;
    }

    public static bool FAILED(PS3TMAPI.SNRESULT res)
    {
      return !PS3TMAPI.SUCCEEDED(res);
    }

    public static bool SUCCEEDED(PS3TMAPI.SNRESULT res)
    {
      return res >= PS3TMAPI.SNRESULT.SN_S_OK;
    }

    private static IntPtr AllocUtf8FromString(string wcharString)
    {
      if (wcharString == null)
        return IntPtr.Zero;
      byte[] bytes = Encoding.UTF8.GetBytes(wcharString);
      IntPtr destination = Marshal.AllocHGlobal(bytes.Length + 1);
      Marshal.Copy(bytes, 0, destination, bytes.Length);
      Marshal.WriteByte((IntPtr) (destination.ToInt64() + (long) bytes.Length), (byte) 0);
      return destination;
    }

    public static string Utf8ToString(IntPtr utf8, uint maxLength)
    {
      int wideChar = PS3TMAPI.MultiByteToWideChar(65001, 0, utf8, -1, (StringBuilder) null, 0);
      if (wideChar == 0)
        throw new Win32Exception();
      StringBuilder buffer = new StringBuilder(wideChar);
      PS3TMAPI.MultiByteToWideChar(65001, 0, utf8, -1, buffer, wideChar);
      return buffer.ToString();
    }

    private static IntPtr ReadDataFromUnmanagedIncPtr<T>(IntPtr unmanagedBuf, ref T storage)
    {
      storage = (T) Marshal.PtrToStructure(unmanagedBuf, typeof (T));
      return new IntPtr(unmanagedBuf.ToInt64() + (long) Marshal.SizeOf<T>(storage));
    }

    public static PS3TMAPI.SNRESULT InitTargetComms()
    {
      if (!PS3TMAPI.Is32Bit())
        return PS3TMAPI.InitTargetCommsX64();
      return PS3TMAPI.InitTargetCommsX86();
    }

    public static PS3TMAPI.SNRESULT Connect(int target, string application)
    {
      if (!PS3TMAPI.Is32Bit())
        return PS3TMAPI.ConnectX64(target, application);
      return PS3TMAPI.ConnectX86(target, application);
    }

    public static PS3TMAPI.SNRESULT PowerOn(int target)
    {
      if (!PS3TMAPI.Is32Bit())
        return PS3TMAPI.PowerOnX64(target);
      return PS3TMAPI.PowerOnX86(target);
    }

    public static PS3TMAPI.SNRESULT PowerOff(int target, bool bForce)
    {
      uint force = bForce ? 1U : 0U;
      if (!PS3TMAPI.Is32Bit())
        return PS3TMAPI.PowerOffX64(target, force);
      return PS3TMAPI.PowerOffX86(target, force);
    }

    public static PS3TMAPI.SNRESULT GetProcessList(int target, out uint[] processIDs)
    {
      processIDs = (uint[]) null;
      uint count = 0;
      PS3TMAPI.SNRESULT res = PS3TMAPI.Is32Bit() ? PS3TMAPI.GetProcessListX86(target, ref count, IntPtr.Zero) : PS3TMAPI.GetProcessListX64(target, ref count, IntPtr.Zero);
      if (!PS3TMAPI.FAILED(res))
      {
        PS3TMAPI.ScopedGlobalHeapPtr scopedGlobalHeapPtr = new PS3TMAPI.ScopedGlobalHeapPtr(Marshal.AllocHGlobal(4 * (int) count));
        res = PS3TMAPI.Is32Bit() ? PS3TMAPI.GetProcessListX86(target, ref count, scopedGlobalHeapPtr.Get()) : PS3TMAPI.GetProcessListX64(target, ref count, scopedGlobalHeapPtr.Get());
        if (PS3TMAPI.FAILED(res))
          return res;
        IntPtr unmanagedBuf = scopedGlobalHeapPtr.Get();
        processIDs = new uint[(int) count];
        for (uint index = 0; index < count; ++index)
          unmanagedBuf = PS3TMAPI.ReadDataFromUnmanagedIncPtr<uint>(unmanagedBuf, ref processIDs[(int) index]);
      }
      return res;
    }

    public static PS3TMAPI.SNRESULT ProcessAttach(
      int target,
      PS3TMAPI.UnitType unit,
      uint processID)
    {
      if (!PS3TMAPI.Is32Bit())
        return PS3TMAPI.ProcessAttachX64(target, (uint) unit, processID);
      return PS3TMAPI.ProcessAttachX86(target, (uint) unit, processID);
    }

    public static PS3TMAPI.SNRESULT ProcessContinue(int target, uint processID)
    {
      if (!PS3TMAPI.Is32Bit())
        return PS3TMAPI.ProcessContinueX64(target, processID);
      return PS3TMAPI.ProcessContinueX86(target, processID);
    }

    public static PS3TMAPI.SNRESULT GetTargetInfo(ref PS3TMAPI.TargetInfo targetInfo)
    {
      PS3TMAPI.TargetInfoPriv targetInfoPriv = new PS3TMAPI.TargetInfoPriv()
      {
        Flags = targetInfo.Flags,
        Target = targetInfo.Target
      };
      PS3TMAPI.SNRESULT res = PS3TMAPI.Is32Bit() ? PS3TMAPI.GetTargetInfoX86(ref targetInfoPriv) : PS3TMAPI.GetTargetInfoX64(ref targetInfoPriv);
      if (!PS3TMAPI.FAILED(res))
      {
        targetInfo.Flags = targetInfoPriv.Flags;
        targetInfo.Target = targetInfoPriv.Target;
        targetInfo.Name = PS3TMAPI.Utf8ToString(targetInfoPriv.Name, uint.MaxValue);
        targetInfo.Type = PS3TMAPI.Utf8ToString(targetInfoPriv.Type, uint.MaxValue);
        targetInfo.Info = PS3TMAPI.Utf8ToString(targetInfoPriv.Info, uint.MaxValue);
        targetInfo.HomeDir = PS3TMAPI.Utf8ToString(targetInfoPriv.HomeDir, uint.MaxValue);
        targetInfo.FSDir = PS3TMAPI.Utf8ToString(targetInfoPriv.FSDir, uint.MaxValue);
        targetInfo.Boot = targetInfoPriv.Boot;
      }
      return res;
    }

    public static PS3TMAPI.SNRESULT GetTargetFromName(string name, out int target)
    {
      PS3TMAPI.ScopedGlobalHeapPtr scopedGlobalHeapPtr = new PS3TMAPI.ScopedGlobalHeapPtr(PS3TMAPI.AllocUtf8FromString(name));
      if (!PS3TMAPI.Is32Bit())
        return PS3TMAPI.GetTargetFromNameX64(scopedGlobalHeapPtr.Get(), out target);
      return PS3TMAPI.GetTargetFromNameX86(scopedGlobalHeapPtr.Get(), out target);
    }

    public static PS3TMAPI.SNRESULT GetConnectionInfo(
      int target,
      out PS3TMAPI.TCPIPConnectProperties connectProperties)
    {
      connectProperties = (PS3TMAPI.TCPIPConnectProperties) null;
      PS3TMAPI.ScopedGlobalHeapPtr scopedGlobalHeapPtr = new PS3TMAPI.ScopedGlobalHeapPtr(Marshal.AllocHGlobal(Marshal.SizeOf(typeof (PS3TMAPI.TCPIPConnectProperties))));
      PS3TMAPI.SNRESULT res = PS3TMAPI.Is32Bit() ? PS3TMAPI.GetConnectionInfoX86(target, scopedGlobalHeapPtr.Get()) : PS3TMAPI.GetConnectionInfoX64(target, scopedGlobalHeapPtr.Get());
      if (PS3TMAPI.SUCCEEDED(res))
      {
        connectProperties = new PS3TMAPI.TCPIPConnectProperties();
        Marshal.PtrToStructure<PS3TMAPI.TCPIPConnectProperties>(scopedGlobalHeapPtr.Get(), connectProperties);
      }
      return res;
    }

    public static PS3TMAPI.SNRESULT GetConnectStatus(
      int target,
      out PS3TMAPI.ConnectStatus status,
      out string usage)
    {
      uint status1;
      IntPtr usage1;
      PS3TMAPI.SNRESULT snresult = PS3TMAPI.Is32Bit() ? PS3TMAPI.GetConnectStatusX86(target, out status1, out usage1) : PS3TMAPI.GetConnectStatusX64(target, out status1, out usage1);
      status = (PS3TMAPI.ConnectStatus) status1;
      usage = PS3TMAPI.Utf8ToString(usage1, uint.MaxValue);
      return snresult;
    }

    public static PS3TMAPI.SNRESULT Reset(
      int target,
      PS3TMAPI.ResetParameter resetParameter)
    {
      if (!PS3TMAPI.Is32Bit())
        return PS3TMAPI.ResetX64(target, (ulong) resetParameter);
      return PS3TMAPI.ResetX86(target, (ulong) resetParameter);
    }

    public static PS3TMAPI.SNRESULT ProcessGetMemory(
      int target,
      PS3TMAPI.UnitType unit,
      uint processID,
      ulong threadID,
      ulong address,
      ref byte[] buffer)
    {
      if (!PS3TMAPI.Is32Bit())
        return PS3TMAPI.ProcessGetMemoryX64(target, unit, processID, threadID, address, buffer.Length, buffer);
      return PS3TMAPI.ProcessGetMemoryX86(target, unit, processID, threadID, address, buffer.Length, buffer);
    }

    public static PS3TMAPI.SNRESULT ProcessSetMemory(
      int target,
      PS3TMAPI.UnitType unit,
      uint processID,
      ulong threadID,
      ulong address,
      byte[] buffer)
    {
      if (!PS3TMAPI.Is32Bit())
        return PS3TMAPI.ProcessSetMemoryX64(target, unit, processID, threadID, address, buffer.Length, buffer);
      return PS3TMAPI.ProcessSetMemoryX86(target, unit, processID, threadID, address, buffer.Length, buffer);
    }

    public static PS3TMAPI.SNRESULT Disconnect(int target)
    {
      if (!PS3TMAPI.Is32Bit())
        return PS3TMAPI.DisconnectX64(target);
      return PS3TMAPI.DisconnectX86(target);
    }

    public enum SNRESULT
    {
      SN_E_ERROR = -2147483648, // -0x80000000
      SN_E_COMMS_EVENT_MISMATCHED_ERR = -39, // -0x00000027
      SN_E_CONNECTED = -38, // -0x00000026
      SN_E_PROTOCOL_ALREADY_REGISTERED = -37, // -0x00000025
      SN_E_COMMAND_CANCELLED = -36, // -0x00000024
      SN_E_CONNECT_TO_GAMEPORT_FAILED = -35, // -0x00000023
      SN_E_MODULE_NOT_FOUND = -34, // -0x00000022
      SN_E_CHECK_TARGET_CONFIGURATION = -33, // -0x00000021
      SN_E_LICENSE_ERROR = -32, // -0x00000020
      SN_E_LOAD_MODULE_FAILED = -31, // -0x0000001F
      SN_E_NOT_SUPPORTED_IN_SDK_VERSION = -30, // -0x0000001E
      SN_E_FILE_ERROR = -29, // -0x0000001D
      SN_E_BAD_ALIGN = -28, // -0x0000001C
      SN_E_DEPRECATED = -27, // -0x0000001B
      SN_E_DATA_TOO_LONG = -26, // -0x0000001A
      SN_E_INSUFFICIENT_DATA = -25, // -0x00000019
      SN_E_EXISTING_CALLBACK = -24, // -0x00000018
      SN_E_DECI_ERROR = -23, // -0x00000017
      SN_E_BUSY = -22, // -0x00000016
      SN_E_BAD_PARAM = -21, // -0x00000015
      SN_E_NO_SEL = -20, // -0x00000014
      SN_E_NO_TARGETS = -19, // -0x00000013
      SN_E_BAD_MEMSPACE = -18, // -0x00000012
      SN_E_TARGET_RUNNING = -17, // -0x00000011
      SN_E_DLL_NOT_INITIALISED = -15, // -0x0000000F
      SN_E_TM_VERSION = -14, // -0x0000000E
      SN_E_NOT_LISTED = -13, // -0x0000000D
      SN_E_OUT_OF_MEM = -12, // -0x0000000C
      SN_E_BAD_UNIT = -11, // -0x0000000B
      SN_E_LOAD_ELF_FAILED = -10, // -0x0000000A
      SN_E_TARGET_IN_USE = -9,
      SN_E_HOST_NOT_FOUND = -8,
      SN_E_TIMEOUT = -7,
      SN_E_TM_COMMS_ERR = -6,
      SN_E_COMMS_ERR = -5,
      SN_E_NOT_CONNECTED = -4,
      SN_E_BAD_TARGET = -3,
      SN_E_TM_NOT_RUNNING = -2,
      SN_E_NOT_IMPL = -1,
      SN_S_OK = 0,
      SN_S_PENDING = 1,
      SN_S_NO_MSG = 3,
      SN_S_TM_VERSION = 4,
      SN_S_REPLACED = 5,
      SN_S_NO_ACTION = 6,
      SN_S_TARGET_STILL_REGISTERED = 7,
    }

    public enum UnitType
    {
      PPU,
      SPU,
      SPURAW,
    }

    [Flags]
    public enum ResetParameter : ulong
    {
      Hard = 1,
      Quick = 2,
      ResetEx = 9223372036854775808, // 0x8000000000000000
      Soft = 0,
    }

    private class ScopedGlobalHeapPtr
    {
      private IntPtr m_intPtr = IntPtr.Zero;

      public ScopedGlobalHeapPtr(IntPtr intPtr)
      {
        this.m_intPtr = intPtr;
      }

      ~ScopedGlobalHeapPtr()
      {
        if (!(this.m_intPtr != IntPtr.Zero))
          return;
        Marshal.FreeHGlobal(this.m_intPtr);
      }

      public IntPtr Get()
      {
        return this.m_intPtr;
      }
    }

    public enum ConnectStatus
    {
      Connected,
      Connecting,
      NotConnected,
      InUse,
      Unavailable,
    }

    [StructLayout(LayoutKind.Sequential)]
    public class TCPIPConnectProperties
    {
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 255)]
      public string IPAddress;
      public uint Port;
    }

    [Flags]
    public enum TargetInfoFlag : uint
    {
      Boot = 32, // 0x00000020
      FileServingDir = 16, // 0x00000010
      HomeDir = 8,
      Info = 4,
      Name = 2,
      TargetID = 1,
    }

    private struct TargetInfoPriv
    {
      public PS3TMAPI.TargetInfoFlag Flags;
      public int Target;
      public IntPtr Name;
      public IntPtr Type;
      public IntPtr Info;
      public IntPtr HomeDir;
      public IntPtr FSDir;
      public PS3TMAPI.BootParameter Boot;
    }

    [Flags]
    public enum BootParameter : ulong
    {
      BluRayEmuOff = 4,
      BluRayEmuUSB = 32, // 0x0000000000000020
      DebugMode = 16, // 0x0000000000000010
      Default = 0,
      DualNIC = 128, // 0x0000000000000080
      HDDSpeedBluRayEmu = 8,
      HostFSTarget = 64, // 0x0000000000000040
      MemSizeConsole = 2,
      ReleaseMode = 1,
      SystemMode = ReleaseMode | DebugMode, // 0x0000000000000011
    }

    public struct TargetInfo
    {
      public PS3TMAPI.TargetInfoFlag Flags;
      public int Target;
      public string Name;
      public string Type;
      public string Info;
      public string HomeDir;
      public string FSDir;
      public PS3TMAPI.BootParameter Boot;
    }
  }
}
