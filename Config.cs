using EasyClipper.Serializer;

namespace EasyClipper;

public class Config
{
    private static JsonConfigSerializer<Config> _Serializer = new();

    public static Config Load() => _Serializer.Load();

    public void Save() => _Serializer.Save(this);

    public static void DeleteFile() => _Serializer.DeleteFile();

    public int Left { get; set; } = 10;
    public int Top { get; set; } = 40;
    public int Right { get; set; } = 10;
    public int Bottom { get; set; } = 10;
}
