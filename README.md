# Summary

This project demonstrates how to inject build information into your .NET
application during the build process using [GitHub
Actions](.github/workflows/build.yml). It is centered around the partial class
[BuildInformation](Source/BuildInfoSample/BuildInformation.cs) which you use to
retrieve information about your build. A part of this class is replaced when
your application is built with GitHub Actions, so it contains the following
information:

* Branch
* Commit hash
* .NET version
* Build time

Additionally, it includes commented-out code showing how to integrate the build
information into a MAUI application.
