public interface IStringsRepository
{
    List<string> Read(string filePath);
    void Write(string filePAth, List<string> strings);
}