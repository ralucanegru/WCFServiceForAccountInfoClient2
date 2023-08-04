using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Linq;

/// <summary>
/// Summary description for AccountSticker
/// </summary>
/// 
[DataContract(Name = "AccountSticker")]
[KnownType(typeof(AccountRestriction))]
public class AccountSticker
{
    private List<MultiLanguageText> restrictionDescriptionField;

    private AccountRestriction accountRestrictionField;

    private List<MultiLanguageText> messageField;

    public AccountSticker(List<MultiLanguageText> restrictionDescription, AccountRestriction accountRestriction, List<MultiLanguageText> message)
    {
        RestrictionDescription = restrictionDescription;
        AccountRestriction = accountRestriction;
        Message = message;
    }

    //
    // Summary:
    //     A list of Quipu.Banking.DataContracts.MultiLanguageText items describing the
    //     restriction coming with current sticker.
    [DataMember(Name = "RestrictionDescription", IsRequired = false, Order = 1)]
    public List<MultiLanguageText> RestrictionDescription
    {
        get
        {
            return restrictionDescriptionField;
        }
        set
        {
            restrictionDescriptionField = value;
        }
    }

    //
    // Summary:
    //     Restriction applied with current sticker item.
    [DataMember(Name = "AccountRestriction", IsRequired = false, Order = 0)]
    public AccountRestriction AccountRestriction
    {
        get
        {
            return accountRestrictionField;
        }
        set
        {
            accountRestrictionField = value;
        }
    }

    //
    // Summary:
    //     Indivdual message in multiple languages.
    //
    // Remarks:
    //     Optional individual description of restriction in multiple languages.
    [DataMember(Name = "Message", IsRequired = false, Order = 2)]
    public List<MultiLanguageText> Message
    {
        get
        {
            return messageField;
        }
        set
        {
            messageField = value;
        }
    }
}