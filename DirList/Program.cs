namespace DirList;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static List<DirectoryInfo> GetAlbums(List<FileInfo> files)
    {
        var result = new List<DirectoryInfo>();

        foreach (var file in files)
        {
            var ext = file.Extension;
            if (!result.Exists(x => x.FullName == file.Directory?.FullName) &&
                (ext.Equals(".mp3") || ext.Equals(".wav"))) result.Add(file.Directory);
        }

        return result;
    }
}