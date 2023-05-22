using StructuralDesignPatterns.Components;

namespace StructuralDesignPatterns.User;

public class UserData
{
    public readonly List<Card> Data = new List<Card>();

    public void CardInitializer()
    {
        BankCardComponent janeSmithBankCard = new BankCardComponent("1234567890", "Example Bank");
        BankCardComponent johnDoeBankCard = new BankCardComponent("9876543210", "Another Bank");
        BankCardComponent aliceJohnsonBankCard = new BankCardComponent("5555555555", "Bank of Examples");
        BankCardComponent bobWilliamsBankCard = new BankCardComponent("1111222233", "Sample Bank");
        BankCardComponent emilyBrownBankCard = new BankCardComponent("9999888877", "Test Bank");

        InsuranceComponent janeSmithIC = new InsuranceComponent("GHI789", "Insurance Co.", new DateTime(2023, 10, 15));
        InsuranceComponent johnDoeIC = new InsuranceComponent("JKL012", "Insurance Corp.", new DateTime(2023, 9, 1));
        InsuranceComponent bobWilliamsIC = new InsuranceComponent("MNO345", "Insurance Ltd.", new DateTime(2024, 3, 22));

        PassportComponent janeSmithPassport = new PassportComponent("Jane", "Smith", new DateTime(1990, 3, 15), new DateTime(2030, 3, 14));
        PassportComponent johnDoePassport = new PassportComponent("John", "Doe", new DateTime(1985, 7, 22), new DateTime(2035, 7, 21));
        PassportComponent aliceJohnsonPassport = new PassportComponent("Alice", "Johnson", new DateTime(2005, 9, 5), new DateTime(2028, 9, 4));
        PassportComponent bobWilliamsPassport = new PassportComponent("Bob", "Williams", new DateTime(1976, 12, 10), new DateTime(2031, 12, 9));
        PassportComponent emilyBrownPassport = new PassportComponent("Emily", "Brown", new DateTime(2004, 1, 20), new DateTime(2036, 1, 19));

        StudentID aliceJohnsonID = new StudentID("Jane", "Smith", 123456, new DateTime(2026, 6, 30));
        StudentID emilyBrownID= new StudentID("John", "Doe", 654321, new DateTime(2025, 12, 31));

        List<ICardComponent> janeSmithComponent = new List<ICardComponent>()
        {
            janeSmithPassport, janeSmithBankCard, janeSmithIC
        };
        List<ICardComponent> johnDoeComponent = new List<ICardComponent>()
        {
            johnDoePassport, johnDoeBankCard, johnDoeIC
        }
            ;List<ICardComponent> aliceJohnsonComponent = new List<ICardComponent>()
        {
            aliceJohnsonPassport, aliceJohnsonBankCard, aliceJohnsonID
        }
            ;List<ICardComponent> bobWilliamsComponent = new List<ICardComponent>()
        {
            bobWilliamsPassport, bobWilliamsBankCard, bobWilliamsIC
        }
            ;List<ICardComponent> emilyBrownComponent = new List<ICardComponent>()
        {
            emilyBrownPassport, emilyBrownBankCard, emilyBrownID
        };

        Card janeSmith = new Card("Jane Smith");
        janeSmith.AddComponent(janeSmithComponent);
        Card johnDoe = new Card("John Doe");
        johnDoe.AddComponent(johnDoeComponent);
        Card aliceJohnson = new Card("Alice Johnson");
        aliceJohnson.AddComponent(aliceJohnsonComponent);
        Card bobWilliams = new Card("Bob Williams");
        bobWilliams.AddComponent(bobWilliamsComponent);
        Card emilyBrown = new Card("Emily Brown");
        emilyBrown.AddComponent(emilyBrownComponent);
        
        Data.AddRange(new List<Card>()
        {
            johnDoe,
            janeSmith,
            aliceJohnson,
            bobWilliams,
            emilyBrown
        });
    }

}