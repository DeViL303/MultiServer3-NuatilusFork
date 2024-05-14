namespace NautilusXP2024
{
    public enum OverwriteBehavior
    {
        Overwrite,
        Rename,
        Skip
    }

    public enum ArchiveTypeSetting
    {
        BAR,
        BAR_S,
        SDAT,
        SDAT_SHARC,
        CORE_SHARC,
        CONFIG_SHARC
    }

    public enum RememberLastTabUsed
    {
        ArchiveTool,
        CDSTool,
        HCDBTool,
        TickLSTTool,
        SceneIDTool,
        LUACTool,
        SDCODCTool,
        Path2Hash,
        EbootPatcher,
        SHAChecker,
        Video
    }

    public enum ArchiveMapperSetting
    {
        NORM,
        FAST,
        CORE,
        EXP
    }

    public enum SaveDebugLog
    {
        True,
        False,
    }
}
