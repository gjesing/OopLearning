using System;
using System.Collections.Generic;
using System.Text;

namespace OopLearning.BL.Inheritance
{
    public class ImageFileInfo : CustomFileInfo
    {
        protected int width;
        protected int height;

        public ImageFileInfo(string fileName, int fileSize, DateTime creationTime, int width, int height) : base(fileName, fileSize, creationTime)
        {
            Width = width;
            Height = height;
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public override bool IsSizeTooLarge()
        {
            if (base.IsSizeTooLarge() || Width > 1920 || Height > 1080)
            {
                return true;
            }
            return false;
        }
    }
}
