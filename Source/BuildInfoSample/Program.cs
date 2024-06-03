using BuildInfoSample;

Console.WriteLine($"Branch: {BuildInformation.Branch}");
Console.WriteLine($"Build Time: {BuildInformation.BuildTimeString}");
Console.WriteLine($"Commit Id: {BuildInformation.ShortCommitId}");
Console.WriteLine($".NET Version: {BuildInformation.DotNetVersionString}");
// Console.WriteLine($"Workload Maui Version: {BuildInformation.WorkloadMauiVersionString}");
