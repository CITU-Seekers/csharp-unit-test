using System.Runtime.InteropServices;

namespace CodeChum
{
    public class MessageBoxWrapper
    {
        public static bool IsOpened { get; set; }
        public static string Title { get; set; }
        public static string Message { get; set; }
        public static MessageBoxButtons MessageBoxButtons { get; set; }
        public static void Show(string messageBoxText)
        {
            IsOpened = true;
            Message = messageBoxText;
            Task.Factory.StartNew(() =>
            {
                return MessageBox.Show(messageBoxText, "Notice");
            });
        }

        public static void Show(string messageBoxText, string caption)
        {
            IsOpened = true;
            Message = messageBoxText;
            Title = caption;
            Task.Factory.StartNew(() =>
            {
                MessageBox.Show(messageBoxText, caption);
            });
        }

        public static void Show(string messageBoxText, string title, MessageBoxButtons messageBoxButtons)
        {
            IsOpened = true;
            Title = title;
            Message = messageBoxText;
            MessageBoxButtons = messageBoxButtons;
            Task.Factory.StartNew(() =>
            {
                MessageBox.Show(messageBoxText, title, messageBoxButtons);
            });
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        private const UInt32 WM_CLOSE = 0x0010;

        public static void CloseMessageBox()
        {
            IntPtr messageBoxWnd = FindWindow(null, "Notice");

            if (messageBoxWnd != IntPtr.Zero)
            {
                PostMessage(messageBoxWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            }
        }
    }
}
