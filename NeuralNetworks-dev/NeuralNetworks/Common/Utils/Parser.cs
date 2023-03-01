using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace NeuralNetworks.Common.Utils;

public static class Parser
{
    /// <summary>
    ///  Get .bmp files from folder 
    /// </summary>
    /// <param name="imagesPath">Path to folder</param>
    /// <returns> Dictionary with file name and Image</returns>
    public static Dictionary<string, Image> ParseImages(string imagesPath)
    {
        var pathList = new List<string>();

        pathList.AddRange(Directory.GetFiles(imagesPath));

        return pathList.Where(currentPath => currentPath.Contains(".bmp")).ToDictionary(Path.GetFileName, Image.FromFile);
    }
}