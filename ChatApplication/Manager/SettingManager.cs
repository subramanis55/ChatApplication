using DatabaseLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Manager
{
    public static class  SettingManager
    {
        public static NotificationThrowManager notificationThrowManager = new NotificationThrowManager();
        public static event EventHandler ThemeSetUpInvoke;
        public static List<string> ThemesNameList = new List<string>() { "LightGreen", "Purple", "SkyBlue","LightBlue"};
        public static Dictionary<string, List<Color>> ThemeColorList = new Dictionary<string, List<Color>>() { { "PrimaryColor", new List<Color>() {ColorTranslator.FromHtml("#1FB141"), ColorTranslator.FromHtml("#4B53BC"), ColorTranslator.FromHtml("#0FB0B6"), ColorTranslator.FromHtml("#0078D4") } }, { "SecondaryColor", new List<Color>() { ColorTranslator.FromHtml("#B8FBC7"), ColorTranslator.FromHtml("#E8EBFA"), ColorTranslator.FromHtml("#0FB0B6"), ColorTranslator.FromHtml("#2196F3") } },{ "FontColor", new List<Color>() {ColorTranslator.FromHtml("#5A5A5E"), ColorTranslator.FromHtml("#5A5A5E"), Color.White,Color.White} } };
        public static Color ChatPageBackGroundColor= Color.FromArgb(250, 246, 243);
        public static Color PrimaryThemeColor= ColorTranslator.FromHtml("#1FB141");    
        public static Color SecontroyThemeColor= ColorTranslator.FromHtml("#B8FBC7");
        public static Color FontThemeColor = Color.Black;
        public static int ThemeNumber=0;
        public static bool IsMuteTheMessageNotification = false;
        public static void SettingSetUP(){
            ChatPageBackGroundColor = getChatPageBackGroundColor();
            ThemeNumber = getTheme();
            ThemeSetUP();
        }
        public static void ThemeSetUP()
        {
            PrimaryThemeColor= ThemeColorList["PrimaryColor"][ThemeNumber];
            SecontroyThemeColor = ThemeColorList["SecondaryColor"][ThemeNumber];
            FontThemeColor= ThemeColorList["FontColor"][ThemeNumber];
            IsMuteTheMessageNotification = getMuteMessageNotification();
            ThemeSetUpInvoke?.Invoke(new object(),EventArgs.Empty);
        }
        public static bool ChangeChatPageBackGroundColor(Color color){
            var result = DatabaseManager.Manager.UpdateData("SETTING", "", new ParameterData("CHATPAGEBACKGROUNDCOLOR", ColorTranslator.ToHtml(color)));
            ChatPageBackGroundColor = color;
            return result.Result;
        }
        public static bool ChangeMuteMessageNotification(bool value)
        {
            var result = DatabaseManager.Manager.UpdateData("SETTING", "", new ParameterData("MUTETHEMESSAGENOTIFICATION", value));
            IsMuteTheMessageNotification = value;
            return result.Result;
        }
        public static bool getMuteMessageNotification()
        {
            var result = DatabaseManager.Manager.FetchSingleData("SETTING", "MUTETHEMESSAGENOTIFICATION", "");
            return (bool)result.Value;
        }  
        public static Color getChatPageBackGroundColor()
        {
            var result = DatabaseManager.Manager.FetchSingleData("SETTING", "CHATPAGEBACKGROUNDCOLOR", "" );
            return ColorTranslator.FromHtml( result.Value.ToString());
        }
        public static bool InsertChatPageBackGroundColor(Color color)
        {  
            var result = DatabaseManager.Manager.InsertData("SETTING",  new ParameterData("CHATPAGEBACKGROUNDCOLOR", ColorTranslator.ToHtml(color)));
            return result.Result;
        }
        public static bool InsertSettingValues(Color color,int themeNumber)
        {
            var result = DatabaseManager.Manager.InsertData("SETTING", new ParameterData("CHATPAGEBACKGROUNDCOLOR", ColorTranslator.ToHtml(color)), new ParameterData("THEMENUMBER", themeNumber), new ParameterData("MUTETHEMESSAGENOTIFICATION", false));
            return result.Result;
        }
        public static bool ChangeTheme(int themeNumber)
        {
            var result = DatabaseManager.Manager.UpdateData("SETTING","", new ParameterData("THEMENUMBER", themeNumber));
            if(result.Result)
            ThemeNumber = themeNumber;
            return result.Result;
        }
        public static int getTheme()
        {
            var result = DatabaseManager.Manager.FetchSingleData("SETTING", "THEMENUMBER","");
            return Convert.ToInt32(result.Value);
        }
        public static bool InsertTheme(int themeNumber)
        {
            var result = DatabaseManager.Manager.InsertData("SETTING", new ParameterData("THEMENUMBER", themeNumber));  
            return result.Result;
        }
    }
}
