using System;


namespace R5T.Code.VisualStudio
{
    /// <summary>
    /// A combination of build configuration and platform target specifies a solution build configuration.
    /// </summary>
    public class SolutionBuildConfiguration
    {
        public static readonly SolutionBuildConfiguration DebugAnyCPU = new SolutionBuildConfiguration { BuildConfiguration = BuildConfiguration.Debug, PlatformTarget = PlatformTarget.AnyCPU };
        public static readonly SolutionBuildConfiguration DebugX64 = new SolutionBuildConfiguration { BuildConfiguration = BuildConfiguration.Debug, PlatformTarget = PlatformTarget.x64 };
        public static readonly SolutionBuildConfiguration DebugX86 = new SolutionBuildConfiguration { BuildConfiguration = BuildConfiguration.Debug, PlatformTarget = PlatformTarget.x32 };
        public static readonly SolutionBuildConfiguration ReleaseAnyCPU = new SolutionBuildConfiguration { BuildConfiguration = BuildConfiguration.Release, PlatformTarget = PlatformTarget.AnyCPU };
        public static readonly SolutionBuildConfiguration ReleaseX64 = new SolutionBuildConfiguration { BuildConfiguration = BuildConfiguration.Release, PlatformTarget = PlatformTarget.x64 };
        public static readonly SolutionBuildConfiguration ReleaseX86 = new SolutionBuildConfiguration { BuildConfiguration = BuildConfiguration.Release, PlatformTarget = PlatformTarget.x32 };


        public BuildConfiguration BuildConfiguration { get; set; }
        public PlatformTarget PlatformTarget { get; set; }
    }
}
