using OopLearning.BL;
using OopLearning.BL.Inheritance;
using System;
using System.Collections.Generic;

namespace OopLearning.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CustomFileInfo> fileInfos = FileInfoFactory.CreateFileInfos(35);
            int numberOfDocumentFileInfos = 0;
            int numberOfImageFileInfos = 0;
            int numberOfVideoFileInfos = 0;
            foreach (CustomFileInfo fileInfo in fileInfos)
            {
                switch (fileInfo)
                {
                    case DocumentFileInfo documentFileInfo:
                        numberOfDocumentFileInfos++;
                        break;
                    case VideoFileInfo videoFileInfo:
                        numberOfVideoFileInfos++;
                        break;
                    case ImageFileInfo imageFileInfo:
                        numberOfImageFileInfos++;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
