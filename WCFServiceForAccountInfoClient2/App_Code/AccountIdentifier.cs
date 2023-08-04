using System.Runtime.Serialization;

/// <summary>
/// Summary description for AccountIdentifier
/// </summary>
[DataContract(Name = "AccountIdentifier")]
public class AccountIdentifier
{
    private string accountNumberField;

    private string accountNameField;

    private string iBANField;

    private BankIdentifier bankIdentifierField;
    private string nBANField;

    public AccountIdentifier(string accountNumber, string accountName, string iBAN, BankIdentifier bankIdentifier, string nBAN)
    {
        AccountNumber = accountNumber;
        AccountName = accountName;
        IBAN = iBAN;
        BankIdentifier = bankIdentifier;
        NBAN = nBAN;
    }

    [DataMember(Name = "AccountNumber", IsRequired = true, Order = 0)]
    public string AccountNumber
    {
        get
        {
            return accountNumberField;
        }
        set
        {
            accountNumberField = value;
        }
    }

    [DataMember(Name = "AccountName", IsRequired = false, Order = 1)]
    public string AccountName
    {
        get
        {
            return accountNameField;
        }
        set
        {
            accountNameField = value;
        }
    }

    //
    // Summary:
    //     International Banking Account Number.
    [DataMember(Name = "IBAN", IsRequired = false, Order = 2)]
    public string IBAN
    {
        get
        {
            return iBANField;
        }
        set
        {
            iBANField = value;
        }
    }

    [DataMember(Name = "BankIdentifier", IsRequired = false, Order = 3)]
    public BankIdentifier BankIdentifier
    {
        get
        {
            return bankIdentifierField;
        }
        set
        {
            bankIdentifierField = value;
        }
    }

    //
    // Summary:
    //     National Banking Account Number. Similar to IBAN, but on national level, with
    //     different rules.
    [DataMember(Name = "NBAN", IsRequired = false, Order = 4)]
    public string NBAN
    {
        get
        {
            return nBANField;
        }
        set
        {
            nBANField = value;
        }
    }
}