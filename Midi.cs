using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

// http://www.codeguru.com/columns/dotnet/making-music-with-midi-and-c.html
namespace MidiScaleTest
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MidiOutCaps
    {
        public UInt16 wMid;
        public UInt16 wPid;
        public UInt32 vDriverVersion;

        [MarshalAs(UnmanagedType.ByValTStr,
           SizeConst = 32)]
        public String szPname;

        public UInt16 wTechnology;
        public UInt16 wVoices;
        public UInt16 wNotes;
        public UInt16 wChannelMask;
        public UInt32 dwSupport;
    }

    class Midi
    {
        // MCI INterface
        [DllImport("winmm.dll")]
        public static extern long mciSendString(string command, StringBuilder returnValue, int returnLength, IntPtr winHandle);

        // Midi API
        [DllImport("winmm.dll")]
        public static extern int midiOutGetNumDevs();

        [DllImport("winmm.dll")]
        public static extern int midiOutGetDevCaps(Int32 uDeviceID, ref MidiOutCaps lpMidiOutCaps, UInt32 cbMidiOutCaps);

        [DllImport("winmm.dll")]
        public static extern int midiOutOpen(ref int handle, int deviceID, MidiCallBack proc, int instance, int flags);

        [DllImport("winmm.dll")]
        public static extern int midiOutShortMsg(int handle, int message);

        [DllImport("winmm.dll")]
        public static extern int midiOutClose(int handle);

        public delegate void MidiCallBack(int handle, int msg, int instance, int param1, int param2);

        static string Mci(string command)
        {
            StringBuilder reply = new StringBuilder(256);
            mciSendString(command, reply, 256, IntPtr.Zero);
            return reply.ToString();
        }
    }
}
