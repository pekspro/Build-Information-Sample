namespace BuildInfoSample;

// This file is overwritten via Github Actions

#if DEBUG

public static partial class BuildInformation
{
    static partial void Initialize()
    {
        Branch = "mybranch";
        BuildTimeString = "2038-01-18T03:14:40Z";
        CommitId = "0123456789abcdef01234567890abcdef0123456";
        DotNetVersionString = "Fake 8.0.205";
        MauiWorkloadAndroidVersionString = "Fake 8.0.21/8.0.100";
        MauiWorkloadWindowsVersionString = "Fake 8.0.21/8.0.100";
        MauiWorkloadIosVersionString = "Fake 8.0.21/8.0.100";
        MauiWorkloadMacCatalystVersionString = "Fake 8.0.21/8.0.100";
    }
}

#endif
