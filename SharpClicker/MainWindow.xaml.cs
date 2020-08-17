using System.Windows;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;
using System.Windows.Interop;
using System.Timers;

namespace SharpClicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowVM VM => (MainWindowVM)DataContext;

        public const int MW_HOTKEY = 0x0312;
        public const int HOTKEY_ID = 8888;  // Id we use to register

        private IntPtr windowHandle;
        private HwndSource source;

        public MainWindow()
        {
            InitializeComponent();            
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);
            // Getting the window handle (hwnd)
            windowHandle = new WindowInteropHelper(this).Handle;
            source = HwndSource.FromHwnd(windowHandle);

            // Adding a callback
            source.AddHook(ToggleHooks);
            RegisterHotKey(windowHandle, HOTKEY_ID, 0, 0x75);
        }


        /// <summary>
        ///     Handles key callbacks from the user32.dll
        /// </summary>
        /// <param name="hwnd"> Window Handle Ptr </param>
        /// <param name="msg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <param name="handled"></param>
        /// <returns></returns>
        public IntPtr ToggleHooks(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            if (msg == MW_HOTKEY && wParam.ToInt32() == HOTKEY_ID)
            {
                uint clickedKey = ((uint)lParam >> 16) & 0xFFFF;
                switch (clickedKey)
                {
                    case (uint)VirtualKeys.F6:

                        if (VM.Timer.Enabled) VM.Timer.Stop();
                        else VM.Timer.Start();

                        break;
                    //case (uint)Keys.F6 when !MainPage.clickTimer.Enabled:
                    //    MainPage.clickTimer.Start();
                    //    break;
                    //case (uint)Keys.F7 when MainPage.clickTimer.Enabled:
                    //    MainPage.clickTimer.Stop();
                    //    break;
                    case (uint)VirtualKeys.F8:
                        // DropAllButMetalAsync(null, null);
                        break;
                }
                handled = true;
            }
            return IntPtr.Zero;
        }

        /// <summary>
        ///     Handles all resets for a given hotkey btn.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHotKeyResetBtnClicked(object sender, RoutedEventArgs e)
        {
            UnregisterHotKey(windowHandle, HOTKEY_ID);
        }

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        public static extern void KeyBind_Event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        
    }
}
