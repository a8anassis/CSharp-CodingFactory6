namespace CopyingBinaryFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CopyBinaryFile(@"C:\tmp\aueb.jpg", @"C:\tmp\auebout.jpg");
        }

        static void CopyBinaryFile(string sourcePath, string destinationPath)
    {
        const int bufferSize = 4096; // Size of the buffer (4 KB)
        byte[] buffer = new byte[bufferSize];

        using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
        using (FileStream destinationStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
        {
            int bytesRead;
            while ((bytesRead = sourceStream.Read(buffer, 0, bufferSize)) > 0)
            {
                destinationStream.Write(buffer, 0, bytesRead);
            }
        }
    }

    }
}
