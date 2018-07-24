namespace DotaAutoChecker.Interfaces
{
    public interface IConfigManager
    {
        string DoMagic(string path);

        string GetCameraDistanceValue(string path);
    }
}
