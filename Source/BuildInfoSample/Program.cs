using BuildInfoSample;

Console.WriteLine($"Branch: {BuildInformation.Branch}");
Console.WriteLine($"Build Time: {BuildInformation.BuildTimeString}");
Console.WriteLine($"Commit Id: {BuildInformation.ShortCommitId}");
Console.WriteLine($".NET Version: {BuildInformation.DotNetVersionString}");
//Console.WriteLine($"Maui Android Workload Version: {BuildInformation.MauiWorkloadAndroidVersionString}");
//Console.WriteLine($"Maui Windows Workload Version: {BuildInformation.MauiWorkloadWindowsVersionString}");
//Console.WriteLine($"Maui iOS Workload Version: {BuildInformation.MauiWorkloadIosVersionString}");
//Console.WriteLine($"Maui Mac Catalyst Workload Version: {BuildInformation.MauiWorkloadMacCatalystVersionString}");
