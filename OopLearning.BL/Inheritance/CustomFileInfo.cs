using System;
using System.Collections.Generic;
using System.Text;

namespace OopLearning.BL.Inheritance
{
    public abstract class CustomFileInfo
    {
        protected string fileName;
        protected int fileSize;
        protected DateTime creationTime;

        protected CustomFileInfo(string fileName, int fileSize, DateTime creationTime)
        {
            FileName = fileName;
            FileSize = fileSize;
            CreationTime = creationTime;
        }

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        public int FileSize
        {
            get { return fileSize; }
            set { fileSize = value; }
        }
        public DateTime CreationTime
        {
            get { return creationTime; }
            set { creationTime = value; }
        }

        public virtual bool IsSizeTooLarge()
        {
            if (FileSize > 45 * 1024 * 1024)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return FileName;
        }
    }
}
