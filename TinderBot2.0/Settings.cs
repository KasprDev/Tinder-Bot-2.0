using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinderBot2._0
{
    public class Settings
    {
        public static string AppPath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Tinder Suite");

        public static string AccountPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Tinder Suite", "Accounts");
        public static string TempPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Tinder Suite", "Temp");

        public static void ValidateFolders()
        {
            if (!Directory.Exists(AppPath))
                Directory.CreateDirectory(AppPath);

            if (!Directory.Exists(AccountPath))
                Directory.CreateDirectory(AccountPath);

            if (!Directory.Exists(TempPath))
                Directory.CreateDirectory(TempPath);
        }

        public static async void SaveAccountInstance(string xAuthId)
        {
            ValidateFolders();

            await File.WriteAllTextAsync(Path.Combine(AccountPath, $"{xAuthId}.txt"), xAuthId);
        }
    }
}
