namespace Sha1FileHasher;

public sealed record FileHashResult(string FilePath, long FileSize, string Hash);

public static class FileHashService
{
    public static FileHashResult Calculate(string filePath)
    {
        if (string.IsNullOrWhiteSpace(filePath))
            throw new ArgumentException("Не выбран исходный файл.", nameof(filePath));
        if (!File.Exists(filePath))
            throw new FileNotFoundException("Выбранный файл не найден.", filePath);

        byte[] data = File.ReadAllBytes(filePath);
        string hash = Sha1Hasher.ComputeHashHex(data);
        return new FileHashResult(filePath, data.LongLength, hash);
    }

    public static void SaveResult(FileHashResult result, string destinationPath)
    {
        ArgumentNullException.ThrowIfNull(result);
        if (string.IsNullOrWhiteSpace(destinationPath))
            throw new ArgumentException("Не выбран файл назначения.", nameof(destinationPath));

        string text =
            "Алгоритм: SHA-1" + Environment.NewLine +
            $"Файл: {result.FilePath}" + Environment.NewLine +
            $"Размер: {result.FileSize} байт" + Environment.NewLine +
            $"SHA-1: {result.Hash}" + Environment.NewLine;

        File.WriteAllText(destinationPath, text);
    }
}
