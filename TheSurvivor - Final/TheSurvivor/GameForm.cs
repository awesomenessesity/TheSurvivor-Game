using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TheSurvivor
{
    public class GameForm : Form
    {
        public DataBase db;

        //struct for dll function
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct DEVMODE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string dmDeviceName;

            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public int dmPositionX;
            public int dmPositionY;
            public int dmDisplayOrientation;
            public int dmDisplayFixedOutput;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string dmFormName;

            public short dmLogPixels;
            public short dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;
            public int dmPanningWidth;
            public int dmPanningHeight;
        };

        [DllImport("user32.dll")]
        public static extern int EnumDisplaySettings(string deviceName, int modeNum, ref DEVMODE devMode);
        [DllImport("user32.dll")]
        public static extern int ChangeDisplaySettings(ref DEVMODE devMode, int flags);

        // Control to change the screen resolution.
        public const int ENUM_CURRENT_SETTINGS = -1;
        public const int CDS_UPDATEREGISTRY = 0x01;
        public const int CDS_TEST = 0x02;
        public const int DISP_CHANGE_SUCCESSFUL = 0;
        public const int DISP_CHANGE_RESTART = 1;
        public const int DISP_CHANGE_FAILED = -1;

        public void ChangeResolution(int width, int height)
        {
            // Initialize the DEVMODE structure
            DEVMODE devmode = new DEVMODE();
            devmode.dmDeviceName = new String(new char[32]);
            devmode.dmFormName = new String(new char[32]);
            devmode.dmSize = (short)Marshal.SizeOf(devmode);

            if (0 != EnumDisplaySettings(null, ENUM_CURRENT_SETTINGS, ref devmode))
            {
                devmode.dmPelsWidth = width;
                devmode.dmPelsHeight = height;

                // Change the screen resolution
                int iRet = ChangeDisplaySettings(ref devmode, CDS_TEST);

                if (iRet == DISP_CHANGE_FAILED)
                {
                    MessageBox.Show("Can't you request execution", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    iRet = ChangeDisplaySettings(ref devmode, CDS_UPDATEREGISTRY);

                    switch (iRet)
                    {
                        // Successful change
                        case DISP_CHANGE_SUCCESSFUL:
                            {
                                break;
                            }
                        case DISP_CHANGE_RESTART:
                            {
                                MessageBox.Show("You need to restart your computer settings to take effect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        default:
                            {
                                MessageBox.Show("Change the screen resolution failed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                    }
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (db.Change)
            {
                ChangeResolution(db.ScreenWidth, db.ScreenHeight);
            }
        }
    }
}
