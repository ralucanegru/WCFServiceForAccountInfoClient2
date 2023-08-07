using Quipu.Banking.Client;
using Quipu.Banking.FaultContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

    // TODO: Add your service operations here
    ////[OperationContract(Action= "http://quipugmbh.com/banking/services/Account/Information/2009/03/AccountInfoServiceContract/InquireAccountInfosByIdentifiers")]
    //[OperationContract]
    //Task<InquireAccountInfosByIdentifiersResponse> InquireAccountInfosByIdentifiersAsync();

    [OperationContract(Action = "http://quipugmbh.com/banking/services/Account/Information/2009/03/AccountInfoServiceContract/InquireAccountInfosByIdentifiers", ReplyAction = "http://quipugmbh.com/banking/services/Account/Information/2009/03/AccountInfoServiceContract/InquireAccountInfosByIdentifiersResponse")]
    [FaultContract(typeof(ReceiverFaultDetail), Action = "http://quipugmbh.com/banking/services/Account/Information/2009/03/AccountInfoServiceContract/InquireAccountInfosByIdentifiersReceiverFaultDetailFault", Name = "ReceiverFaultDetail", Namespace = "http://quipugmbh.com/banking/types/2009/04")]
    [FaultContract(typeof(SenderFaultDetail), Action = "http://quipugmbh.com/banking/services/Account/Information/2009/03/AccountInfoServiceContract/InquireAccountInfosByIdentifiersSenderFaultDetailFault", Name = "SenderFaultDetail", Namespace = "http://quipugmbh.com/banking/types/2009/04")]
    Quipu.Banking.Client.InquireAccountInfosByIdentifiersResponse InquireAccountInfosByIdentifiers(Quipu.Banking.Client.InquireAccountInfosByIdentifiersRequest request);
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
public class CompositeType
{
    bool boolValue = true;
    string stringValue = "Hello ";

    [DataMember]
    public bool BoolValue
    {
        get { return boolValue; }
        set { boolValue = value; }
    }

    [DataMember]
    public string StringValue
    {
        get { return stringValue; }
        set { stringValue = value; }
    }
}

[DataContract]
public class InquireAccountInfosByIdentifiersResponse
{
    [DataMember]
    public AccountInfos AccountInfos { get; set; }

    public InquireAccountInfosByIdentifiersResponse()
    {
    }

    public InquireAccountInfosByIdentifiersResponse(AccountInfos AccountInfos)
    {
        this.AccountInfos = AccountInfos;
    }
}

[CollectionDataContract]
public class AccountInfos : List<AccountInfo>
{
    public AccountInfos()
    {
    }

    public AccountInfos(IEnumerable<AccountInfo> collection) : base(collection)
    {
    }

}

[DataContract]
public class AccountInfo
{
    private AccountIdentifier accountIdentifierField;

    private ContractType contractTypeField;

    private AccountIdentifier parentAccountIdentifierField;

    private List<MultiLanguageText> multiLanguageProductNameField;

    private ContractStatus accountStatusField;

    private List<AccountSticker> accountStickersField;

    private List<AccountAmount> accountAmountsField;

    private string maskedPANField;

    private string contractHolderIdentifierField;

    public AccountInfo(AccountIdentifier accountIdentifier, ContractType contractType, AccountIdentifier parentAccountIdentifier, List<MultiLanguageText> multiLanguageProductName, ContractStatus accountStatus, List<AccountSticker> accountStickers, List<AccountAmount> accountAmounts, string maskedPAN, string contractHolderIdentifier)
    {
        AccountIdentifier = accountIdentifier;
        ContractType = contractType;
        ParentAccountIdentifier = parentAccountIdentifier;
        MultiLanguageProductName = multiLanguageProductName;
        AccountStatus = accountStatus;
        AccountStickers = accountStickers;
        AccountAmounts = accountAmounts;
        MaskedPAN = maskedPAN;
        ContractHolderIdentifier = contractHolderIdentifier;
    }

    //
    // Summary:
    //     The Quipu.Banking.DataContracts.AccountInfo.AccountIdentifier of current Quipu.Banking.DataContracts.AccountInfo
    //     instance.
    [DataMember(Name = "AccountIdentifier", IsRequired = false, Order = 0)]
    public AccountIdentifier AccountIdentifier
    {
        get
        {
            return accountIdentifierField;
        }
        set
        {
            accountIdentifierField = value;
        }
    }

    //
    // Summary:
    //     Type of contract of current Quipu.Banking.DataContracts.AccountInfo instance.
    [DataMember(Name = "ContractType", IsRequired = false, Order = 1)]
    public ContractType ContractType
    {
        get
        {
            return contractTypeField;
        }
        set
        {
            contractTypeField = value;
        }
    }

    //
    // Summary:
    //     Indicates that current account information item belongs to a parent account.
    //     For example, a credit line account can belong to a current account.
    [DataMember(Name = "ParentAccountIdentifier", IsRequired = false, Order = 2)]
    public AccountIdentifier ParentAccountIdentifier
    {
        get
        {
            return parentAccountIdentifierField;
        }
        set
        {
            parentAccountIdentifierField = value;
        }
    }

    //
    // Summary:
    //     Name of product in the public, in multiple languages.
    //
    // Remarks:
    //     Usually a marketing name in different languages.
    [DataMember(Name = "MultiLanguageProductName", IsRequired = false, Order = 3)]
    public List<MultiLanguageText> MultiLanguageProductName
    {
        get
        {
            return multiLanguageProductNameField;
        }
        set
        {
            multiLanguageProductNameField = value;
        }
    }

    //
    // Summary:
    //     Indicates status of current Quipu.Banking.DataContracts.AccountInfo instance.
    [DataMember(Name = "AccountStatus", IsRequired = false, Order = 4)]
    public ContractStatus AccountStatus
    {
        get
        {
            return accountStatusField;
        }
        set
        {
            accountStatusField = value;
        }
    }

    //
    // Summary:
    //     An account can be temporarily flagged with one or more "stickers" due to serveral
    //     reasons, e.g. inactivity or blocking. These stickers can be specific by country.
    //     Depending on the kind of sticker, operations with an account can be restricted.
    [DataMember(Name = "AccountStickers", IsRequired = false, Order = 5)]
    public List<AccountSticker> AccountStickers
    {
        get
        {
            return accountStickersField;
        }
        set
        {
            accountStickersField = value;
        }
    }

    //
    // Summary:
    //     List of Quipu.Banking.DataContracts.AccountAmount items.
    [DataMember(Name = "AccountAmounts", IsRequired = false, Order = 6)]
    public List<AccountAmount> AccountAmounts
    {
        get
        {
            return accountAmountsField;
        }
        set
        {
            accountAmountsField = value;
        }
    }

    //
    // Summary:
    //     Masked Primary Account Number.
    //
    // Remarks:
    //     The card identifiers is referred to as "PAN" (See https://en.wikipedia.org/wiki/Payment_card_number).
    [DataMember(Name = "MaskedPAN", IsRequired = false, Order = 7)]
    public string MaskedPAN
    {
        get
        {
            return maskedPANField;
        }
        set
        {
            maskedPANField = value;
        }
    }

    //
    // Summary:
    //     Contract holder identifier used by CBS for current related contract.
    [DataMember(Name = "ContractHolderIdentifier", IsRequired = false, Order = 8)]
    public string ContractHolderIdentifier
    {
        get
        {
            return contractHolderIdentifierField;
        }
        set
        {
            contractHolderIdentifierField = value;
        }
    }
}
