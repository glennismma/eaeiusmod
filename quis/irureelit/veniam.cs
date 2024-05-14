public async Task<string> ReadFileContentAsync(string filePath)
{
    if (string.IsNullOrEmpty(filePath))
    {
        throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));
    }

    if (!File.Exists(filePath))
    {
        throw new FileNotFoundException($"The file at {filePath} was not found.");
    }

    try
    {
        string data = await File.ReadAllTextAsync(filePath);
        return data;
    }
    catch (Exception ex)
    {
        // Log the exception details here or handle it as required
        throw new ApplicationException("Error reading from the file.", ex);
    }
}
