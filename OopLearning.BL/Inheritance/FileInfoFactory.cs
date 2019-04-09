using System;
using System.Collections.Generic;
using System.Text;

namespace OopLearning.BL.Inheritance
{
    public class FileInfoFactory
    {
        private static string GetRandomFileName()
        {
            string characters = "abcdefghijklmnopqrstuvwxyz";
            string fileName = "";
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                fileName += characters[random.Next(0, characters.Length)];
            }
            return fileName;
        }
        private static int GetRandomFileSize()
        {
            return new Random().Next(1, 100);
        }
        private static int GetRandomWidthOrHeight()
        {
            return new Random().Next(100, 1000);
        }
        private static int GetRandomDuration()
        {
            return new Random().Next(100, 2000);
        }
        private static DateTime GetRandomCreationTime()
        {
            Random random = new Random();
            int year = 0;
            int month = 0;
            int day = 0;
            int hour = 0;
            int minute = 0;
            int second = 0;
            year = random.Next(DateTime.Now.AddYears(-10).Year, DateTime.Now.AddYears(1).Year);
            if (year == DateTime.Now.Year)
            {
                month = random.Next(1, DateTime.Now.AddMonths(1).Month);
            }
            else
            {
                month = random.Next(1, 13);
            }
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (year == DateTime.Now.Year && month == DateTime.Now.Month)
                    {
                        day = random.Next(1, DateTime.Now.AddDays(1).Day);
                    }
                    else
                    {
                        day = random.Next(1, 32);
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (year == DateTime.Now.Year && month == DateTime.Now.Month)
                    {
                        day = random.Next(1, DateTime.Now.AddDays(1).Day);
                    }
                    else
                    {
                        day = random.Next(1, 31);
                    }
                    break;
                case 2:
                    if (DateTime.Now.Year % 4 == 0)
                    {
                        if (year == DateTime.Now.Year && month == DateTime.Now.Month)
                        {
                            day = random.Next(1, DateTime.Now.AddDays(1).Day);
                        }
                        else
                        {
                            day = random.Next(1, 30);
                        }
                    }
                    else
                    {
                        if (year == DateTime.Now.Year && month == DateTime.Now.Month)
                        {
                            day = random.Next(1, DateTime.Now.AddDays(1).Day);
                        }
                        else
                        {
                            day = random.Next(1, 29);
                        }
                    }
                    break;
            }
            if (year == DateTime.Now.Year && month == DateTime.Now.Month && day == DateTime.Now.Day)
            {
                hour = random.Next(1, DateTime.Now.AddHours(1).Hour);
            }
            else
            {
                hour = random.Next(0, 24);
            }
            if (year == DateTime.Now.Year && month == DateTime.Now.Month && day == DateTime.Now.Day && hour == DateTime.Now.Hour)
            {
                minute = random.Next(1, DateTime.Now.AddMinutes(1).Minute);
            }
            else
            {
                minute = random.Next(0, 60);
            }
            if (year == DateTime.Now.Year && month == DateTime.Now.Month && day == DateTime.Now.Day && hour == DateTime.Now.Hour && minute == DateTime.Now.Minute)
            {
                second = random.Next(1, DateTime.Now.AddSeconds(1).Second);
            }
            else
            {
                second = random.Next(0, 60);
            }
            return new DateTime(year, month, day, hour, minute, second);
        }
        private static string GetRandomFileType()
        {
            string[] fileTypes = new string[] { "Document", "Image", "Video"};
            return fileTypes[new Random().Next(0, fileTypes.Length)];
        }
        public static DocumentFileInfo CreateDocumentFileInfo()
        {
            return new DocumentFileInfo(GetRandomFileName(), GetRandomFileSize(), GetRandomCreationTime());
        }
        public static DocumentFileInfo CreateDocumentFileInfo(int fileSize)
        {
            return new DocumentFileInfo(GetRandomFileName(), fileSize, GetRandomCreationTime());
        }
        public static DocumentFileInfo CreateDocumentFileInfo(int fileSize, DateTime creationTime)
        {
            return new DocumentFileInfo(GetRandomFileName(), fileSize, creationTime);
        }
        public static ImageFileInfo CreateImageFileInfo()
        {
            return new ImageFileInfo(GetRandomFileName(), GetRandomFileSize(), GetRandomCreationTime(), GetRandomWidthOrHeight(), GetRandomWidthOrHeight());
        }
        public static ImageFileInfo CreateImageFileInfo(int fileSize)
        {
            return new ImageFileInfo(GetRandomFileName(), fileSize, GetRandomCreationTime(), GetRandomWidthOrHeight(), GetRandomWidthOrHeight());
        }
        public static ImageFileInfo CreateImageFileInfo(int fileSize, DateTime creationTime)
        {
            return new ImageFileInfo(GetRandomFileName(), fileSize, creationTime, GetRandomWidthOrHeight(), GetRandomWidthOrHeight());
        }
        public static VideoFileInfo CreateImageVideoInfo()
        {
            return new VideoFileInfo(GetRandomFileName(), GetRandomFileSize(), GetRandomCreationTime(), GetRandomWidthOrHeight(), GetRandomWidthOrHeight(), GetRandomDuration());
        }
        public static VideoFileInfo CreateImageVideoInfo(int duration)
        {
            return new VideoFileInfo(GetRandomFileName(), GetRandomFileSize(), GetRandomCreationTime(), GetRandomWidthOrHeight(), GetRandomWidthOrHeight(), duration);
        }
        public static VideoFileInfo CreateImageVideoInfo(int duration, int fileSize)
        {
            return new VideoFileInfo(GetRandomFileName(), fileSize, GetRandomCreationTime(), GetRandomWidthOrHeight(), GetRandomWidthOrHeight(), duration);
        }
        public static List<CustomFileInfo> CreateFileInfos(int number)
        {
            List<CustomFileInfo> fileInfos = new List<CustomFileInfo>();
            for (int i = 0; i < number; i++)
            {
                switch (GetRandomFileType())
                {
                    case "Document":
                        fileInfos.Add(CreateDocumentFileInfo());
                        break;
                    case "Image":
                        fileInfos.Add(CreateImageFileInfo());
                        break;
                    case "Video":
                        fileInfos.Add(CreateImageVideoInfo());
                        break;
                }
            }
            return fileInfos;
        }
    }
}
