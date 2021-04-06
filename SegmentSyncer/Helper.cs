using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SegmentSyncer
{
    class Helpers
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="resource"></param>
        /// <returns></returns>
        public static String SaveResourceToTempFile(String resource)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("SegmentSyncer." + resource);
            return Helpers.SaveStreamToTempFile(stream);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static String SaveStreamToTempFile(Stream stream)
        {
            if (stream == null || stream.Length == 0) return null;

            // Temp file
            String tempFile = GetTempFileName("html");

            // Create a FileStream object to write a stream to a file
            FileStream fileStream = System.IO.File.Create(tempFile, (int)stream.Length);

            // Fill the bytes[] array with the stream data
            byte[] bytesInStream = new byte[stream.Length];
            stream.Read(bytesInStream, 0, (int)bytesInStream.Length);

            // Use FileStream object to write to the specified file
            fileStream.Write(bytesInStream, 0, bytesInStream.Length);

            // Close the file
            fileStream.Close();
            fileStream.Dispose();
            return tempFile;
        }

        /// <summary>
        /// Get a temporary file name with the given extension
        /// </summary>
        /// <param name="extension">The temp extension</param>
        /// <returns>A string containing a full path name of the temp file</returns>
        public static string GetTempFileName(string extension)
        {
            int attempt = 0;
            while (true)
            {
                string fileName = Path.GetRandomFileName();
                fileName = Path.ChangeExtension(fileName, extension);
                fileName = Path.Combine(Path.GetTempPath(), fileName);

                try
                {
                    using (new FileStream(fileName, FileMode.CreateNew)) { }
                    return fileName;
                }
                catch (IOException ex)
                {
                    if (++attempt == 10)
                        throw new IOException("No unique temporary file name is available.", ex);
                }
            }
        }
    }
}
