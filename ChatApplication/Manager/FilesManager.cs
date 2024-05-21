using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace ChatApplication.Manager
{
    public static class FilesManager
    {
        public static string FileSaveingFolderName = "ChatApplicationFilesX";
        public static Dictionary<string, string> ContactsFilesPath_D = new Dictionary<string, string>() { { "DPPICTURE", "//SPARE-A1/ChatApplication/DPPICTURE/" } };
        public static Dictionary<string, string> FilesPath_D = new Dictionary<string, string>() { { "CONTACTSDPPICTURE", "C:/Users/Lucid/OneDrive/Desktop/ChatApplicationFilesX/ContactsPicture" }, { "GROUPSDPPICTURE", "C:/Users/Lucid/OneDrive/Desktop/ChatApplicationFilesX/GroupsPicture" } };
        public static string FileSaveDirectoryPath = @"C:/Users/Lucid/OneDrive/Desktop/ChatApplicationFilesX";
        public static string CheckAndCreateFolder(string folderPath, string folderName)
        {

            string path = Path.Combine(folderPath, folderName);
            // Check if the folder exists
            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                    return path;
                }
                catch (Exception ex)
                {
                    return "";
                }
            }
            return path;
        }
        public static void SetUp()
        {

            FileSaveDirectoryPath = CheckAndCreateFolder(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), FileSaveingFolderName).Replace("\\", "/");
            if (FileSaveDirectoryPath != "")
            {
                FilesPath_D["CONTACTSDPPICTURE"] = CheckAndCreateFolder(FileSaveDirectoryPath, "ContactsPicture").Replace("\\", "/");
                FilesPath_D["GROUPSDPPICTURE"] = CheckAndCreateFolder(FileSaveDirectoryPath, "GroupsPicture").Replace("\\", "/");
            }
        }

        public static string SaveFileInFolder(string destinationPath, string sourcefilePath, string newFileName)
        {
            try
            {
                string str = Path.GetExtension(sourcefilePath);
                string newfilePath = Path.Combine(destinationPath, newFileName + Path.GetExtension(sourcefilePath));
                File.Copy(sourcefilePath, newfilePath, true);
                return newfilePath;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return "File Not Found";
        }
        public static string saveFileUsingSaveFileDialog(string sourceFilePath)
        {

            if (string.IsNullOrEmpty(sourceFilePath))
            {
                MessageBox.Show("Please select a source file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save As";
            saveFileDialog.Filter = $"*{Path.GetExtension(sourceFilePath)} | *{Path.GetExtension(sourceFilePath)}";
            saveFileDialog.FileName = Path.GetFileName(sourceFilePath);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string destinationFilePath = saveFileDialog.FileName;
                try
                {
                    File.Copy(sourceFilePath, destinationFilePath, true);
                    SettingManager.notificationThrowManager.CreateNotification(Path.GetFileName(sourceFilePath) + " file saved success", NotificationType.None);
                    return destinationFilePath;
                }
                catch (Exception ex)
                {
                    SettingManager.notificationThrowManager.CreateNotification(Path.GetFileName(sourceFilePath) + " file saved fail", NotificationType.None);
                }
            }
            return "";
        }
        public static bool DeleteAllTheFilesInDirectory(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                string[] FilesPath = Directory.GetFiles(directoryPath);
                foreach (var path in FilesPath)
                {
                    try
                    {
                        File.Delete(path);
                    }
                    catch { }

                }
                return true;
            }
            return true;
        }
        public static string FilesTo64BaseString(string filePath)
        {
            byte[] ByteArray = File.ReadAllBytes(filePath);
            string StringFormat = Convert.ToBase64String(ByteArray);
            return StringFormat;
        }
        public static string SaveFilesInDirectoryFolder(string folderDirectoryPath, string fileName, string stringFormatFile)
        {
            try
            {
                try
                {
                    byte[] ByteArray = Convert.FromBase64String(stringFormatFile);
                    string filePath = Path.Combine(folderDirectoryPath, fileName);
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        fileStream.Write(ByteArray, 0, ByteArray.Length);
                    }
                    return filePath;
                }
                catch (Exception e)
                {
                    //byte[] ByteArray = Convert.FromBase64String(stringFormatFile);
                    //string filePath = Path.Combine(folderDirectoryPath, fileName);
                    //filePath = filePath + "UPDATED-" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
                    //using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                    //{
                    //    fileStream.Write(ByteArray, 0, ByteArray.Length);
                    //}
                    //  return filePath;
                }
            }
            catch
            {

            }
            return "";
        }
        public static string ConvertImageToBase64(string imagePath)
        {
            try
            {
                string base64String = "";
                long quality = 100;
                while (true)
                {
                    using (Image image = Image.FromFile(imagePath))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            // Set encoder parameters for JPEG compression
                            EncoderParameters encoderParams = new EncoderParameters(1);
                            encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
                            // Get codec
                            ImageCodecInfo codec = GetEncoderInfo("image/jpeg");
                            if (Path.GetExtension(imagePath).Equals(".png", StringComparison.OrdinalIgnoreCase))
                            {
                                codec = GetEncoderInfo("image/png");
                            }
                            // Save the image to the memory stream with specified quality
                            image.Save(ms, codec, encoderParams);
                            byte[] imageBytes = ms.ToArray();
                            base64String = Convert.ToBase64String(imageBytes);
                            if (base64String.Length < 50000)
                            {
                                break;
                            }
                            else
                            {
                                quality = quality - 2;
                                if (quality < 10)
                                    break;
                            }
                        }
                    }
                }
                return base64String;
            }
            catch (Exception e)
            {
                return "";
            }
        }

        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.MimeType == mimeType)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}
