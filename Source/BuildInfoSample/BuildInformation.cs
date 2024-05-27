namespace BuildInfoSample;

public static partial class BuildInformation
{
    static BuildInformation()
    {
        Initialize();
    }

    static partial void Initialize();

    public static string? Branch { get; private set; }

    public static string? BuildTimeString { get; private set; }

    public static DateTime BuildTime =>
        BuildTimeString is null ? DateTime.MinValue : DateTime.Parse(BuildTimeString);

    public static string? CommitId { get; private set; }

    public static string? ShortCommitId => CommitId?.Substring(0, Math.Min(CommitId.Length, 7));

    public static string? DotNetVersionString { get; private set; }

    public static string? MauiWorkloadAndroidVersionString { get; private set; }

    public static string? MauiWorkloadWindowsVersionString { get; private set; }

    public static string? MauiWorkloadIosVersionString { get; private set; }

    public static string? MauiWorkloadMacCatalystVersionString { get; private set; }
}

/*
 * When building in GitHub, a file like this is generated:
 
public static partial class BuildInformation
{
    static partial void Initialize()
    {
        Branch = "main";
        BuildTimeString = "2038-01-18T03:14:40Z";
        CommitId = "45b439e0b8ce1a72a2d0d5b413a580f32d894f56";
        DotNetVersionString = "8.0.205";
        MauiWorkloadAndroidVersionString = "8.0.21/8.0.100";
        MauiWorkloadWindowsVersionString = "8.0.21/8.0.100";
        MauiWorkloadIosVersionString = "8.0.21/8.0.100";
        MauiWorkloadMacCatalystVersionString = "8.0.21/8.0.100";
    }
}
*/
