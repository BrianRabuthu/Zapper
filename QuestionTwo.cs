//Question 2.1
public bool IsFeatureEnabled(string settings, int featurePosition)
{
    if (featurePosition < 1 || featurePosition > settings.Length)
    {
        throw new ArgumentOutOfRangeException(nameof(featurePosition),
        $"Feature position must be between 1 and {settings.Length}. Given: {featurePosition}");
    }

    return settings[featurePosition - 1] == '1';
}

//Question 2.2
public static void SaveSettingsToFile(string settings, string filePath)
{
    //This will use 1 byte for 8 flags 
    byte settingsByte = Convert.ToByte(settings, 2);

    using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
    {
        fs.WriteByte(settingsByte);
    }
}

public static string LoadSettingsFromFile(string filePath)
{
    byte settingsByte;

    try
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            settingsByte = (byte)fs.ReadByte();
        }
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine($"Error: File '{filePath}' not found. Loading default settings.");
        return "00000000";
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        return "00000000"; // Fallback to default settings in case of other errors
    }

    // Pad the setting if less than 8
    return Convert.ToString(settingsByte, 2).PadLeft(8, '0');
}