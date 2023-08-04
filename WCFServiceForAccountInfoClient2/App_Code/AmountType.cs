using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for AmountType
/// </summary>
/// 
[DataContract(Name = "AmountType")]
public enum AmountType
{
    //
    // Summary:
    //     Balance allowed to be transfered from account in this moment.
    [EnumMember(Value = "AvailableBalance")]
    AvailableBalance,
    //
    // Summary:
    //     Amount of allowed overdraft for contract.
    [EnumMember(Value = "AllowedOverdraft")]
    AllowedOverdraft,
    //
    // Summary:
    //     Current balance on primary account of contract.
    [EnumMember(Value = "CurrentBalance")]
    CurrentBalance,
    //
    // Summary:
    //     Minimum rquired balance of an account.
    [EnumMember(Value = "MinimumBalance")]
    MinimumBalance,
    //
    // Summary:
    //     Positive interest (from client's perspective) amount accrued to date.
    [EnumMember(Value = "AccruedPositiveInterest")]
    AccruedPositiveInterest,
    //
    // Summary:
    //     Matured positive interest amount at maturity.
    [EnumMember(Value = "MaturedPositiveInterest")]
    MaturedPositiveInterest,
    //
    // Summary:
    //     Bonus amount.
    //
    // Remarks:
    //     Used in conjunction with cards.
    [EnumMember(Value = "Bonus")]
    Bonus,
    //
    // Summary:
    //     Due capital amount, as defined by schedule, not including any overdue amount.
    //     For loan: capital balance; for overdraft, credit line or credit card: primary
    //     account balance.
    [EnumMember(Value = "CapitalDue")]
    CapitalDue,
    //
    // Summary:
    //     Amount is owed to bank but not yet due. Calculation depends on individual bank's
    //     definition.
    [EnumMember(Value = "Owed")]
    Owed,
    //
    // Summary:
    //     Interest amount due.
    [EnumMember(Value = "InterestDue")]
    InterestDue,
    //
    // Summary:
    //     Overdue capital amount, violating defined schedule.
    [EnumMember(Value = "CapitalOverdue")]
    CapitalOverdue,
    //
    // Summary:
    //     Penalty amount charged on overdue amount.
    [EnumMember(Value = "Penalty ")]
    Penalty,
    //
    // Summary:
    //     Overdue interest, on overdue capital (loan type products) or on not allowed overdrafts.
    [EnumMember(Value = "InterestOverdue")]
    InterestOverdue,
    //
    // Summary:
    //     Next regular installment, as defined by contract. E.g. captial due + interest
    //     due for loans or minimum installment for revolving credit cards.
    [EnumMember(Value = "NextScheduledInstallment")]
    NextScheduledInstallment,
    //
    // Summary:
    //     Not allowed overdraft (technical).
    [EnumMember(Value = "NotAllowedOverdraft")]
    NotAllowedOverdraft,
    //
    // Summary:
    //     Amount as defined by product's contract. Could be initial TDA amount, granted
    //     overdraft limit, granted credit card limit or loan amount.
    [EnumMember(Value = "ContractValue")]
    ContractValue,
    //
    // Summary:
    //     Proposed next installment, based on next scheduled installment and any overdue
    //     amounts, including overdue capital, overdue interest and penalty. "Proposed"
    //     means suggested to client.
    [EnumMember(Value = "NextProposedInstallment")]
    NextProposedInstallment,
    //
    // Summary:
    //     Kosovo only: primary balance of current account component of loan (CA loan component).
    [EnumMember(Value = "LoanCurrentAccount")]
    LoanCurrentAccount,
    //
    // Summary:
    //     Ukraine only: balance of secondary card account in different currency.
    [EnumMember(Value = "CardSecondaryBalance")]
    CardSecondaryBalance,
    //
    // Summary:
    //     Total sum of all insurances accrued for a loan. Can include loan insurance, unemployment
    //     insurance and so on.
    [EnumMember(Value = "DebtInsurance")]
    DebtInsurance,
    //
    // Summary:
    //     [Definition pending]
    [EnumMember(Value = "OverdueInterestPenalty")]
    OverdueInterestPenalty,
    //
    // Summary:
    //     [Definition pending]
    //
    // Remarks:
    //     Initially added for Nicaragua which are displaying this information separately
    //     from other insurances and additional charges.
    [EnumMember(Value = "GuaranteeInsurance")]
    GuaranteeInsurance,
    //
    // Summary:
    //     [Definition pending]
    //
    // Remarks:
    //     Nicaragua only: Total sum of all additional charges calculated for a loan.
    [EnumMember(Value = "AdditionalCharges")]
    AdditionalCharges,
    //
    // Summary:
    //     [Definition pending]
    [EnumMember(Value = "BalanceFromLastPeriod")]
    BalanceFromLastPeriod,
    //
    // Summary:
    //     [Definition pending]
    [EnumMember(Value = "CreditCardDebitTurnOver")]
    CreditCardDebitTurnOver,
    //
    // Summary:
    //     [Definition pending]
    [EnumMember(Value = "CreditCardCreditTurnOver")]
    CreditCardCreditTurnOver,
    //
    // Summary:
    //     [Definition pending]
    [EnumMember(Value = "CreditCardTodayCreditTurnOver")]
    CreditCardTodayCreditTurnOver,
    //
    // Summary:
    //     [Definition pending]
    [EnumMember(Value = "CreditCardTotalPayment")]
    CreditCardTotalPayment
}