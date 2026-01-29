using System.Runtime.InteropServices;

namespace SelfCSharp.Chap07
{
    internal class AccessBasic
    {
        [DllImport("kernel32.dll")]
        private extern static bool Beep(uint dwFreq, uint dwDuration);
        static void Main(string[] args)
        {
            Beep(440, 200);
            Beep(660, 200);
            Beep(880, 200);
        }
    }
}
