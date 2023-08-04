using System.Runtime.Serialization;

/// <summary>
/// Summary description for ContractStatus
/// </summary>
[DataContract(Name = "ContractStatus")]
public enum ContractStatus
{
    //
    // Summary:
    //     Contract is open/active.
    [EnumMember(Value = "Open")]
    Open,
    //
    // Summary:
    //     Contract is closed.
    [EnumMember(Value = "Closed")]
    Closed,
    //
    // Summary:
    //     Contract is new.
    [EnumMember(Value = "New")]
    New
}