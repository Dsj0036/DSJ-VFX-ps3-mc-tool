// Decompiled with JetBrains decompiler
// Type: PS3Lib.CCAPI
// Assembly: HEN RTM Tool by zFxbixn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C687F458-A7E2-4DD3-B516-C68C6A7F95BF
// Assembly location: C:\Users\Kelly\Desktop\Nouveau dossier (2)\AcuraRTM_HEN_Version old.exe

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PS3Lib
{
    public class CCAPI
    {
        private IntPtr libModule = IntPtr.Zero;
        private readonly string CCAPIHASH = "C2FE9E1C387CF29AAC781482C28ECF86";
        private CCAPI.TargetInfo pInfo = new CCAPI.TargetInfo();
        private CCAPI.connectConsoleDelegate connectConsole;
        private CCAPI.disconnectConsoleDelegate disconnectConsole;
        private CCAPI.getConnectionStatusDelegate getConnectionStatus;
        private CCAPI.getConsoleInfoDelegate getConsoleInfo;
        private CCAPI.getDllVersionDelegate getDllVersion;
        private CCAPI.getFirmwareInfoDelegate getFirmwareInfo;
        private CCAPI.getNumberOfConsolesDelegate getNumberOfConsoles;
        private CCAPI.getProcessListDelegate getProcessList;
        private CCAPI.getProcessMemoryDelegate getProcessMemory;
        private CCAPI.getProcessNameDelegate getProcessName;
        private CCAPI.getTemperatureDelegate getTemperature;
        private CCAPI.notifyDelegate notify;
        private CCAPI.ringBuzzerDelegate ringBuzzer;
        private CCAPI.setBootConsoleIdsDelegate setBootConsoleIds;
        private CCAPI.setConsoleIdsDelegate setConsoleIds;
        private CCAPI.setConsoleLedDelegate setConsoleLed;
        private CCAPI.setProcessMemoryDelegate setProcessMemory;
        private CCAPI.shutdownDelegate shutdown;

        [DllImport("kernel32.dll")]
        private static extern IntPtr LoadLibrary(string dllName);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        public CCAPI()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\FrenchModdingTeam\\CCAPI\\InstallFolder");
            if (registryKey != null)
            {
                string str1 = registryKey.GetValue("path") as string;
                if (!string.IsNullOrEmpty(str1))
                {
                    string str2 = str1 + "\\CCAPI.dll";
                    if (File.Exists(str2))
                    {
                        if (BitConverter.ToString(MD5.Create().ComputeHash(File.ReadAllBytes(str2))).Replace("-", "").Equals(this.CCAPIHASH))
                        {
                            if (this.libModule == IntPtr.Zero)
                                this.libModule = CCAPI.LoadLibrary(str2);
                            if (this.libModule != IntPtr.Zero)
                            {
                                this.connectConsole = (CCAPI.connectConsoleDelegate)Marshal.GetDelegateForFunctionPointer(CCAPI.GetProcAddress(this.libModule, "CCAPIConnectConsole"), typeof(CCAPI.connectConsoleDelegate));
                                this.disconnectConsole = (CCAPI.disconnectConsoleDelegate)Marshal.GetDelegateForFunctionPointer(CCAPI.GetProcAddress(this.libModule, "CCAPIDisconnectConsole"), typeof(CCAPI.disconnectConsoleDelegate));
                                this.getConnectionStatus = (CCAPI.getConnectionStatusDelegate)Marshal.GetDelegateForFunctionPointer(CCAPI.GetProcAddress(this.libModule, "CCAPIGetConnectionStatus"), typeof(CCAPI.getConnectionStatusDelegate));
                                this.getConsoleInfo = (CCAPI.getConsoleInfoDelegate)Marshal.GetDelegateForFunctionPointer(CCAPI.GetProcAddress(this.libModule, "CCAPIGetConsoleInfo"), typeof(CCAPI.getConsoleInfoDelegate));
                                this.getDllVersion = (CCAPI.getDllVersionDelegate)Marshal.GetDelegateForFunctionPointer(CCAPI.GetProcAddress(this.libModule, "CCAPIGetDllVersion"), typeof(CCAPI.getDllVersionDelegate));
                                this.getFirmwareInfo = (CCAPI.getFirmwareInfoDelegate)Marshal.GetDelegateForFunctionPointer(CCAPI.GetProcAddress(this.libModule, "CCAPIGetFirmwareInfo"), typeof(CCAPI.getFirmwareInfoDelegate));
                                this.getNumberOfConsoles = (CCAPI.getNumberOfConsolesDelegate)Marshal.GetDelegateForFunctionPointer(CCAPI.GetProcAddress(this.libModule, "CCAPIGetNumberOfConsoles"), typeof(CCAPI.getNumberOfConsolesDelegate));
                                this.getProcessList = (CCAPI.getProcessListDelegate)Marshal.GetDelegateForFunctionPointer(CCAPI.GetProcAddress(this.libModule, "CCAPIGetProcessList"), typeof(CCAPI.getProcessListDelegate));
                                this.getProcessMemory = (CCAPI.getProcessMemoryDelegate)Marshal.GetDelegateForFunctionPointer(CCAPI.GetProcAddress(this.libModule, "CCAPIGetMemory"), typeof(CCAPI.getProcessMemoryDelegate));
                                this.getProcessName = (CCAPI.getProcessNameDelegate)Marshal.GetDelegateForFunctionPointer(CCAPI.GetProcAddress(this.libModule, "CCAPIGetProcessName"), typeof(CCAPI.getProcessNameDelegate));
                                this.getTemperature = (CCAPI.getTemperatureDelegate)Marshal.GetDelegateForFunctionPointer(CCAPI.GetProcAddress(this.libModule, "CCAPIGetTemperature"), typeof(CCAPI.getTemperatureDelegate));
                                this.notify = (CCAPI.notifyDelegate)Marshal.GetDelegateForFunctionPointer(CCAPI.GetProcAddress(this.libModule, "CCAPIVshNotify"), typeof(CCAPI.notifyDelegate));
                                this.ringBuzzer = (CCAPI.ringBuzzerDelegate)Marshal.GetDelegateForFunctionPointer(CCAPI.GetProcAddress(this.libModule, "CCAPIRingBuzzer"), typeof(CCAPI.ringBuzzerDelegate));
                                this.setBootConsoleIds = (CCAPI.setBootConsoleIdsDelegate)Marshal.GetDelegateForFunctionPointer(CCAPI.GetProcAddress(this.libModule, "CCAPISetBootConsoleIds"), typeof(CCAPI.setBootConsoleIdsDelegate));
                                this.setConsoleIds = (CCAPI.setConsoleIdsDelegate)Marshal.GetDelegateForFunctionPointer(CCAPI.GetProcAddress(this.libModule, "CCAPISetConsoleIds"), typeof(CCAPI.setConsoleIdsDelegate));
                                this.setConsoleLed = (CCAPI.setConsoleLedDelegate)Marshal.GetDelegateForFunctionPointer(CCAPI.GetProcAddress(this.libModule, "CCAPISetConsoleLed"), typeof(CCAPI.setConsoleLedDelegate));
                                this.setProcessMemory = (CCAPI.setProcessMemoryDelegate)Marshal.GetDelegateForFunctionPointer(CCAPI.GetProcAddress(this.libModule, "CCAPISetMemory"), typeof(CCAPI.setProcessMemoryDelegate));
                                this.shutdown = (CCAPI.shutdownDelegate)Marshal.GetDelegateForFunctionPointer(CCAPI.GetProcAddress(this.libModule, "CCAPIShutdown"), typeof(CCAPI.shutdownDelegate));
                            }
                            else
                            {
                                int num = (int)MessageBox.Show("Impossible to load CCAPI.dll version 2.60.", "CCAPI.dll cannot be load", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                        }
                        else
                        {
                            int num1 = (int)MessageBox.Show("You're not using the right CCAPI.dll please install the version 2.60.", "CCAPI.dll version incorrect", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else
                    {
                        int num2 = (int)MessageBox.Show("You need to install CCAPI to use this library.", "CCAPI.dll not found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    int num3 = (int)MessageBox.Show("Invalid CCAPI folder, please re-install it.", "CCAPI not installed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                int num4 = (int)MessageBox.Show("You need to install CCAPI to use this library.", "CCAPI not installed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private IntPtr ReadDataFromUnBufPtr<T>(IntPtr unBuf, ref T storage)
        {
            storage = (T)Marshal.PtrToStructure(unBuf, typeof(T));
            return new IntPtr(unBuf.ToInt64() + (long)Marshal.SizeOf<T>(storage));
        }

        public Extension Extension
        {
            get
            {
                return new Extension(SelectAPI.ControlConsole);
            }
        }

        private void CompleteInfo(
          ref CCAPI.TargetInfo Info,
          int fw,
          int ccapi,
          ulong sysTable,
          int consoleType,
          int tempCELL,
          int tempRSX)
        {
            Info.Firmware = fw;
            Info.CCAPI = ccapi;
            Info.SysTable = sysTable;
            Info.ConsoleType = consoleType;
            Info.TempCell = tempCELL;
            Info.TempRSX = tempRSX;
        }

        public bool SUCCESS(int Void)
        {
            return Void == 0;
        }

        public bool ConnectTarget()
        {
            return new ConsoleList(new PS3API(SelectAPI.ControlConsole)).Show();
        }

        public int ConnectTarget(string targetIP)
        {
            return this.connectConsole(targetIP);
        }

        public int GetConnectionStatus()
        {
            int status = 0;
            int num = this.getConnectionStatus(ref status);
            return status;
        }

        public int DisconnectTarget()
        {
            return this.disconnectConsole();
        }

        public int AttachProcess()
        {
            CCAPI.System.processID = 0U;
            int Void = this.GetProcessList(out CCAPI.System.processIDs);
            if (this.SUCCESS(Void) && (uint)CCAPI.System.processIDs.Length > 0U)
            {
                for (int index = 0; index < CCAPI.System.processIDs.Length; ++index)
                {
                    string name = string.Empty;
                    Void = this.GetProcessName(CCAPI.System.processIDs[index], out name);
                    if (this.SUCCESS(Void))
                    {
                        if (!name.Contains("flash"))
                        {
                            CCAPI.System.processID = CCAPI.System.processIDs[index];
                            break;
                        }
                        Void = -1;
                    }
                    else
                        break;
                }
                if (CCAPI.System.processID == 0U)
                    CCAPI.System.processID = CCAPI.System.processIDs[CCAPI.System.processIDs.Length - 1];
            }
            else
                Void = -1;
            return Void;
        }

        public int AttachProcess(CCAPI.ProcessType procType)
        {
            CCAPI.System.processID = 0U;
            int num = this.GetProcessList(out CCAPI.System.processIDs);
            if (num >= 0 && (uint)CCAPI.System.processIDs.Length > 0U)
            {
                for (int index = 0; index < CCAPI.System.processIDs.Length; ++index)
                {
                    string name = string.Empty;
                    num = this.GetProcessName(CCAPI.System.processIDs[index], out name);
                    if (num >= 0)
                    {
                        if (procType == CCAPI.ProcessType.VSH && name.Contains("vsh"))
                        {
                            CCAPI.System.processID = CCAPI.System.processIDs[index];
                            break;
                        }
                        if (procType == CCAPI.ProcessType.SYS_AGENT && name.Contains("agent"))
                        {
                            CCAPI.System.processID = CCAPI.System.processIDs[index];
                            break;
                        }
                        if (procType == CCAPI.ProcessType.CURRENTGAME && !name.Contains("flash"))
                        {
                            CCAPI.System.processID = CCAPI.System.processIDs[index];
                            break;
                        }
                    }
                    else
                        break;
                }
                if (CCAPI.System.processID == 0U)
                    CCAPI.System.processID = CCAPI.System.processIDs[CCAPI.System.processIDs.Length - 1];
            }
            else
                num = -1;
            return num;
        }

        public int AttachProcess(uint process)
        {
            uint[] processIds = new uint[64];
            int Void = this.GetProcessList(out processIds);
            if (this.SUCCESS(Void))
            {
                for (int index = 0; index < processIds.Length; ++index)
                {
                    if ((int)processIds[index] == (int)process)
                    {
                        Void = 0;
                        CCAPI.System.processID = process;
                        break;
                    }
                    Void = -1;
                }
            }
            return Void;
        }

        public int GetProcessList(out uint[] processIds)
        {
            uint numberProcesses = 64;
            IntPtr num = Marshal.AllocHGlobal(256);
            int Void = this.getProcessList(ref numberProcesses, num);
            processIds = new uint[(int)numberProcesses];
            if (this.SUCCESS(Void))
            {
                IntPtr unBuf = num;
                for (uint index = 0; index < numberProcesses; ++index)
                    unBuf = this.ReadDataFromUnBufPtr<uint>(unBuf, ref processIds[(int)index]);
            }
            Marshal.FreeHGlobal(num);
            return Void;
        }

        public int GetProcessName(uint processId, out string name)
        {
            IntPtr num = Marshal.AllocHGlobal(529);
            int Void = this.getProcessName(processId, num);
            name = string.Empty;
            if (this.SUCCESS(Void))
                name = Marshal.PtrToStringAnsi(num);
            Marshal.FreeHGlobal(num);
            return Void;
        }

        public uint GetAttachedProcess()
        {
            return CCAPI.System.processID;
        }

        public int SetMemory(uint offset, byte[] buffer)
        {
            return this.setProcessMemory(CCAPI.System.processID, (ulong)offset, (uint)buffer.Length, buffer);
        }

        public int SetMemory(ulong offset, byte[] buffer)
        {
            return this.setProcessMemory(CCAPI.System.processID, offset, (uint)buffer.Length, buffer);
        }

        public int SetMemory(ulong offset, string hexadecimal, EndianType Type = EndianType.BigEndian)
        {
            byte[] byteArray = CCAPI.StringToByteArray(hexadecimal);
            if (Type == EndianType.LittleEndian)
                Array.Reverse((Array)byteArray);
            return this.setProcessMemory(CCAPI.System.processID, offset, (uint)byteArray.Length, byteArray);
        }

        public int GetMemory(uint offset, byte[] buffer)
        {
            return this.getProcessMemory(CCAPI.System.processID, (ulong)offset, (uint)buffer.Length, buffer);
        }

        public int GetMemory(ulong offset, byte[] buffer)
        {
            return this.getProcessMemory(CCAPI.System.processID, offset, (uint)buffer.Length, buffer);
        }

        public byte[] GetBytes(uint offset, uint length)
        {
            byte[] buffer = new byte[(int)length];
            this.GetMemory(offset, buffer);
            return buffer;
        }

        public byte[] GetBytes(ulong offset, uint length)
        {
            byte[] buffer = new byte[(int)length];
            this.GetMemory(offset, buffer);
            return buffer;
        }

        public int Notify(CCAPI.NotifyIcon icon, string message)
        {
            return this.notify((int)icon, message);
        }

        public int Notify(int icon, string message)
        {
            return this.notify(icon, message);
        }

        public int ShutDown(CCAPI.RebootFlags flag)
        {
            return this.shutdown((int)flag);
        }

        public int RingBuzzer(CCAPI.BuzzerMode flag)
        {
            return this.ringBuzzer((int)flag);
        }

        public int SetConsoleLed(CCAPI.LedColor color, CCAPI.LedMode mode)
        {
            return this.setConsoleLed((int)color, (int)mode);
        }

        private int GetTargetInfo()
        {
            int[] numArray = new int[2];
            int firmware = 0;
            int ccapi = 0;
            int consoleType = 0;
            ulong sysTable = 0;
            int num = this.getFirmwareInfo(ref firmware, ref ccapi, ref consoleType);
            if (num >= 0)
            {
                num = this.getTemperature(ref numArray[0], ref numArray[1]);
                if (num >= 0)
                    this.CompleteInfo(ref this.pInfo, firmware, ccapi, sysTable, consoleType, numArray[0], numArray[1]);
            }
            return num;
        }

        public int GetTargetInfo(out CCAPI.TargetInfo Info)
        {
            Info = new CCAPI.TargetInfo();
            int[] numArray = new int[2];
            int firmware = 0;
            int ccapi = 0;
            int consoleType = 0;
            ulong sysTable = 0;
            int num = this.getFirmwareInfo(ref firmware, ref ccapi, ref consoleType);
            if (num >= 0)
            {
                num = this.getTemperature(ref numArray[0], ref numArray[1]);
                if (num >= 0)
                {
                    this.CompleteInfo(ref Info, firmware, ccapi, sysTable, consoleType, numArray[0], numArray[1]);
                    this.CompleteInfo(ref this.pInfo, firmware, ccapi, sysTable, consoleType, numArray[0], numArray[1]);
                }
            }
            return num;
        }

        public string GetFirmwareVersion()
        {
            if (this.pInfo.Firmware == 0)
                this.GetTargetInfo();
            string str = this.pInfo.Firmware.ToString("X8");
            return str.Substring(1, 1) + "." + str.Substring(3, 1) + str.Substring(4, 1);
        }

        public string GetTemperatureCELL()
        {
            if (this.pInfo.TempCell == 0)
                this.GetTargetInfo(out this.pInfo);
            return this.pInfo.TempCell.ToString() + " C";
        }

        public string GetTemperatureRSX()
        {
            if (this.pInfo.TempRSX == 0)
                this.GetTargetInfo(out this.pInfo);
            return this.pInfo.TempRSX.ToString() + " C";
        }

        public string GetFirmwareType()
        {
            if (this.pInfo.ConsoleType == 0)
                this.GetTargetInfo(out this.pInfo);
            string str = string.Empty;
            if (this.pInfo.ConsoleType == 1)
                str = "CEX";
            else if (this.pInfo.ConsoleType == 2)
                str = "DEX";
            else if (this.pInfo.ConsoleType == 3)
                str = "TOOL";
            return str;
        }

        public void ClearTargetInfo()
        {
            this.pInfo = new CCAPI.TargetInfo();
        }

        public int SetConsoleID(string consoleID)
        {
            if (string.IsNullOrEmpty(consoleID))
            {
                int num = (int)MessageBox.Show("Cannot send an empty value", "Empty or null console id", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return -1;
            }
            string hex = string.Empty;
            if (consoleID.Length >= 32)
                hex = consoleID.Substring(0, 32);
            return this.SetConsoleID(CCAPI.StringToByteArray(hex));
        }

        public int SetConsoleID(byte[] consoleID)
        {
            if (consoleID.Length != 0)
                return this.setConsoleIds(0, consoleID);
            int num = (int)MessageBox.Show("Cannot send an empty value", "Empty or null console id", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return -1;
        }

        public int SetPSID(string PSID)
        {
            if (string.IsNullOrEmpty(PSID))
            {
                int num = (int)MessageBox.Show("Cannot send an empty value", "Empty or null psid", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return -1;
            }
            string hex = string.Empty;
            if (PSID.Length >= 32)
                hex = PSID.Substring(0, 32);
            return this.SetPSID(CCAPI.StringToByteArray(hex));
        }

        public int SetPSID(byte[] consoleID)
        {
            if (consoleID.Length != 0)
                return this.setConsoleIds(1, consoleID);
            int num = (int)MessageBox.Show("Cannot send an empty value", "Empty or null psid", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return -1;
        }

        public int SetBootConsoleID(string consoleID, CCAPI.IdType Type = CCAPI.IdType.IDPS)
        {
            string str = string.Empty;
            if (consoleID.Length >= 32)
                str = consoleID.Substring(0, 32);
            return this.SetBootConsoleID(CCAPI.StringToByteArray(consoleID), Type);
        }

        public int SetBootConsoleID(byte[] consoleID, CCAPI.IdType Type = CCAPI.IdType.IDPS)
        {
            return this.setBootConsoleIds((int)Type, 1, consoleID);
        }

        public int ResetBootConsoleID(CCAPI.IdType Type = CCAPI.IdType.IDPS)
        {
            return this.setBootConsoleIds((int)Type, 0, (byte[])null);
        }

        public int GetDllVersion()
        {
            return this.getDllVersion();
        }

        public List<CCAPI.ConsoleInfo> GetConsoleList()
        {
            List<CCAPI.ConsoleInfo> consoleInfoList = new List<CCAPI.ConsoleInfo>();
            int num1 = this.getNumberOfConsoles();
            IntPtr num2 = Marshal.AllocHGlobal(256);
            IntPtr num3 = Marshal.AllocHGlobal(256);
            for (int index = 0; index < num1; ++index)
            {
                CCAPI.ConsoleInfo consoleInfo = new CCAPI.ConsoleInfo();
                int num4 = this.getConsoleInfo(index, num2, num3);
                consoleInfo.Name = Marshal.PtrToStringAnsi(num2);
                consoleInfo.Ip = Marshal.PtrToStringAnsi(num3);
                consoleInfoList.Add(consoleInfo);
            }
            Marshal.FreeHGlobal(num2);
            Marshal.FreeHGlobal(num3);
            return consoleInfoList;
        }

        internal static byte[] StringToByteArray(string hex)
        {
            try
            {
                string replace = hex.Replace("0x", "");
                string Stringz = replace.Insert(replace.Length - 1, "0");
                if (replace.Length % 2 == 0)
                    return Enumerable.Range(0, replace.Length).Where<int>((Func<int, bool>)(x => x % 2 == 0)).Select<int, byte>((Func<int, byte>)(x => Convert.ToByte(replace.Substring(x, 2), 16))).ToArray<byte>();
                return Enumerable.Range(0, replace.Length).Where<int>((Func<int, bool>)(x => x % 2 == 0)).Select<int, byte>((Func<int, byte>)(x => Convert.ToByte(Stringz.Substring(x, 2), 16))).ToArray<byte>();
            }
            catch
            {
                int num = (int)MessageBox.Show("Incorrect value (empty)", "StringToByteArray Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return new byte[1];
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int connectConsoleDelegate(string targetIP);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int disconnectConsoleDelegate();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int getConnectionStatusDelegate(ref int status);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int getConsoleInfoDelegate(int index, IntPtr ptrN, IntPtr ptrI);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int getDllVersionDelegate();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int getFirmwareInfoDelegate(
          ref int firmware,
          ref int ccapi,
          ref int consoleType);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int getNumberOfConsolesDelegate();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int getProcessListDelegate(ref uint numberProcesses, IntPtr processIdPtr);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int getProcessMemoryDelegate(
          uint processID,
          ulong offset,
          uint size,
          byte[] buffOut);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int getProcessNameDelegate(uint processID, IntPtr strPtr);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int getTemperatureDelegate(ref int cell, ref int rsx);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int notifyDelegate(int mode, string msgWChar);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int ringBuzzerDelegate(int type);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int setBootConsoleIdsDelegate(int idType, int on, byte[] ID);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int setConsoleIdsDelegate(int idType, byte[] consoleID);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int setConsoleLedDelegate(int color, int status);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int setProcessMemoryDelegate(
          uint processID,
          ulong offset,
          uint size,
          byte[] buffIn);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int shutdownDelegate(int mode);

        public enum IdType
        {
            IDPS,
            PSID,
        }

        public enum NotifyIcon
        {
            INFO,
            CAUTION,
            FRIEND,
            SLIDER,
            WRONGWAY,
            DIALOG,
            DIALOGSHADOW,
            TEXT,
            POINTER,
            GRAB,
            HAND,
            PEN,
            FINGER,
            ARROW,
            ARROWRIGHT,
            PROGRESS,
            TROPHY1,
            TROPHY2,
            TROPHY3,
            TROPHY4,
        }

        public enum ConsoleType
        {
            CEX = 1,
            DEX = 2,
            TOOL = 3,
        }

        public enum ProcessType
        {
            VSH,
            SYS_AGENT,
            CURRENTGAME,
        }

        public enum RebootFlags
        {
            ShutDown = 1,
            SoftReboot = 2,
            HardReboot = 3,
        }

        public enum BuzzerMode
        {
            Continuous,
            Single,
            Double,
        }

        public enum LedColor
        {
            Green = 1,
            Red = 2,
        }

        public enum LedMode
        {
            Off,
            On,
            Blink,
        }

        private class System
        {
            public static int connectionID = -1;
            public static uint processID = 0;
            public static uint[] processIDs;
        }

        public class TargetInfo
        {
            public int Firmware = 0;
            public int CCAPI = 0;
            public int ConsoleType = 0;
            public int TempCell = 0;
            public int TempRSX = 0;
            public ulong SysTable = 0;
        }

        public class ConsoleInfo
        {
            public string Name;
            public string Ip;
        }
    }
}
