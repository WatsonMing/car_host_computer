using System.IO;

namespace uart
{
    class ImageFile
    {
        public void CopyFolder(string strFromPath, string strToPath)
        {
            FileInfo file = new FileInfo(strFromPath);
            if (file.Exists)
            {
                // true is overwrite 
                file.CopyTo(strToPath, true);
            }
        }
    }
}
