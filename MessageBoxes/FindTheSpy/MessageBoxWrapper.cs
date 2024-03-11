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
    }
}
