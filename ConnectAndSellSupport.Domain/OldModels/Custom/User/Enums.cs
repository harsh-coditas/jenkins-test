namespace ConnectAndSellSupport.Domain.Models.Custom.User
{
    public enum ExistingUserActivationStatus : byte
    {
        Inactive = 0,
        IsExistingUser = 1,
        UserActivated = 2
    }

    public enum Roles
    {
        None = 0,
        Administrator = 1,
        SessionManager = 2,
        Agent = 4,
        Pitcher = 8,
        Researcher = 16,
        SalesRep = 32,
        AccountManager = 64,
        ClientSvcsManager = 128,
        Coordinator = 256,
        CRMAdministrator = 512,
        WebManager = 1024,
        Coach = 2048,
        Demo = 4096,
        ELM = 8192,
        LeadPooling = 16384,
        Lightning = 32768,
        ReportSuperuser = 65536,
        Dialer = 131072,
        OOD = 262144,
        hotTransferEnabled = 524288,
        Executive = 2097152,
        NativeSFDC = 4194304,
        SuperExec = 8388608,
        FacilityManager = 16777216,
        SessionAnalyst = 33554432,
        Engineering = 67108864,
        COLV = 134217728
    }

    public enum PostAction : byte
    {
        None = 0,
        Deactivate = 1,
        DncAll = 2
    };
}
