using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for AccountRestriction
/// </summary>
[DataContract(Name = "AccountRestriction")]
public enum AccountRestriction
{
    [EnumMember(Value = "Information")]
    Information,
    [EnumMember(Value = "Dormant")]
    Dormant,
    [EnumMember(Value = "DebitRestricted")]
    DebitRestricted,
    [EnumMember(Value = "CreditRestricted")]
    CreditRestricted,
    [EnumMember(Value = "DebitAndCreditRestricted")]
    DebitAndCreditRestricted
}