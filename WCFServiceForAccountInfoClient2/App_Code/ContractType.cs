using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for ContractType
/// </summary>
[DataContract(Name = "ContractType")]
public enum ContractType
{
    //
    // Summary:
    //     Current account.
    [EnumMember(Value = "CurrentAccount")]
    CurrentAccount,
    //
    // Summary:
    //     Saving account.
    [EnumMember(Value = "SavingAccount")]
    SavingAccount,
    //
    // Summary:
    //     Time deposit account.
    [EnumMember(Value = "TimeDepositAccount")]
    TimeDepositAccount,
    //
    // Summary:
    //     Loan.
    [EnumMember(Value = "Loan")]
    Loan,
    //
    // Summary:
    //     Card account.
    [EnumMember(Value = "CardAccount")]
    CardAccount,
    //
    // Summary:
    //     Overdraft account.
    [EnumMember(Value = "Overdraft")]
    Overdraft,
    //
    // Summary:
    //     Credit line account.
    [EnumMember(Value = "CreditLine")]
    CreditLine,
    //
    // Summary:
    //     Other type of account (Remove?)
    [EnumMember(Value = "OtherType")]
    OtherType,
    [EnumMember(Value = "CreditCard")]
    CreditCard,
    //
    // Summary:
    //     Savings Certificates are simplified TDAs.
    //
    // Remarks:
    //     In use in Germany at the moment of writing.
    [EnumMember(Value = "SavingsCertificate")]
    SavingsCertificate,
    //
    // Summary:
    //     Loro Account
    //
    // Remarks:
    //     A loro account is an account of another bank, held in our bank.
    [EnumMember(Value = "LoroAccount")]
    LoroAccount,
    //
    // Summary:
    //     Nostro Letter of Credit
    [EnumMember(Value = "NostroLC")]
    NostroLC,
    //
    // Summary:
    //     Nostro Letter of Guarantee
    [EnumMember(Value = "NostroLG")]
    NostroLG,
    [EnumMember(Value = "BusinessOverdraft")]
    BusinessOverdraft,
    //
    // Summary:
    //     Internal contract
    [EnumMember(Value = "InternalContract")]
    InternalContract,
    //
    // Summary:
    //     Service for non customers
    [EnumMember(Value = "NoncustomerService")]
    NoncustomerService
}