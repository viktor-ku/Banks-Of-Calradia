using TaleWorlds.Core;
using TaleWorlds.Library;

namespace BanksOfCalradia
{
    class Message
    {
        private static void ShowMessage(string msg)
        {
            InformationManager.DisplayMessage(new InformationMessage(msg));
        }

        private static void ShowMessage(string msg, Color color)
        {
            InformationManager.DisplayMessage(new InformationMessage(msg, color));
        }

        public static void White(string msg)
        {
            ShowMessage(msg);
        }

        public static void Gray(string msg)
        {
            ShowMessage(msg, new Color(140, 140, 140));
        }

        public static void Green(string msg)
        {
            ShowMessage(msg, new Color(233, 30, 99, 1));
        }

        public static void Cyan(string msg)
        {
            ShowMessage(msg, new Color(198, 40, 40));
        }

        public static void Olive(string msg)
        {
            ShowMessage(msg, new Color(94, 73, 177));
        }

        public static void What(string msg)
        {
            ShowMessage(msg, new Color(255, 235, 59));
        }
    }
}
