using System.Collections;

namespace TheCourse.M03_CSharp101.Exercises.M04_Conditions;

public class MoreConditions
{
    // 1. Easy: returns true if the number is negative
    public bool IsNegative(int number)
    {
        return number < 0;
    }

    // 2. Easy: returns "Yes" if the person is a senior (65 or older), otherwise "No"
    public string IsSenior(int age)
    {
        if (age >= 65)
        {
            return "Yes";
        }
        else
        {
            return "No";
        }
    }

    // 3. Easy: returns true if the password has at least 8 characters
    public bool IsPasswordLongEnough(string password)
    {

        return password.Length >= 8;
    }

    // 4. Easy: returns the day type based on a switch ("zaterdag" or "zondag" => "weekend", anything else => "weekdag")
    public string GetDayType(string day)
    {
        switch (day)
        {
            case "zaterdag":
                return "weekend";

            case "zondag":
                return "weekend";

            default:
                return "weekdag";
        }
    }

    // 5. Medium: returns true if a person may drive
    // (at least 18 years old AND has a license)
    public bool MayDrive(int age, bool hasLicense)
    {
        return age >= 18 && hasLicense == true;


    }

    // 6. Medium: returns the ticket price based on age
    // under 12: 5, 12 to 64 (inclusive): 10, 65 and older: 7
    public int TicketPrice(int age)
    {
        if (age < 12)
            return 5;

        else if (age >= 65)
            return 7;

        else
            return 10;
    }

    // 7. Medium: returns true if a number is within the range 1 to 100 (inclusive)
    public bool IsValidPercentage(int value)
    {
        return value >= 1 && value <= 100;
    }

    // 8. Medium: returns the BMI category
    // bmi < 18.5: "Ondergewicht", 18.5 to 24.9: "Normaal", 25 to 29.9: "Overgewicht", 30 or higher: "Obesitas"
    public string BmiCategory(double bmi)
    {
        if (bmi < 18.5)
            return "Ondergewicht";

        else if (bmi >= 18.5 && bmi <= 24.9)
            return "Normaal";

        else if (bmi >= 25 && bmi <= 29.9)
            return "Overgewicht";

        else
            return "Obesitas";
    }

    // 9. Medium: returns true if the login is successful
    // (username equals "admin" AND password equals "1234")
    public bool IsLoginSuccessful(string username, string password)
    {
        return username == "admin" && password == "1234";
    }

    // 10. Medium: returns the season based on the month number (1-12)
    // 12, 1, 2: "Winter", 3, 4, 5: "Lente", 6, 7, 8: "Zomer", 9, 10, 11: "Herfst"
    public string GetSeason(int month)
    {
        switch (month)
        {
            case 12:
            case 1:
            case 2:

                return "Winter";

            case 3:
            case 4:
            case 5:
                return "Lente";

            case 6 or 7 or 8:

                return "Zomer";

            case 9 or 10 or 11:
                return "Herfst";

            default:
                return "Onbekend";
        }
    }

    // 11. Hard: returns the membership fee
    // isStudent and age < 26: 20
    // isStudent: 35
    // age >= 65: 25
    // otherwise: 50
    public int MembershipFee(int age, bool isStudent)
    {
        throw new NotImplementedException(); // TODO
    }

    // 12. Hard: returns true if a triangle with the given sides is valid
    // (the sum of any two sides must be greater than the third side, and all sides must be positive)
    public bool IsValidTriangle(int sideA, int sideB, int sideC)
    {
        throw new NotImplementedException(); // TODO
    }

    // 13. Hard: returns the parking fee based on hours parked
    // first hour (0 to 1, inclusive): free
    // 1 to 3 hours: 2 per hour
    // more than 3 hours: 6 + 1 per additional hour above 3
    public decimal ParkingFee(decimal hours)
    {
        throw new NotImplementedException(); // TODO
    }

    // 14. Hard: returns the password strength
    // length < 6: "Zwak"
    // length 6 to 9 without a digit: "Gemiddeld"
    // length 6 to 9 with at least one digit, or length >= 10 without digit: "Sterk"
    // length >= 10 with at least one digit: "Zeer sterk"
    public string PasswordStrength(string password, bool containsDigit)
    {
        throw new NotImplementedException(); // TODO
    }

    // 15. Hard: returns the shipping label based on combined conditions
    // isFragile and isInternational: "Fragiel - Internationaal"
    // isFragile: "Fragiel"
    // isInternational: "Internationaal"
    // otherwise: "Standaard"
    public string GetShippingLabel(bool isFragile, bool isInternational)
    {
        throw new NotImplementedException(); // TODO
    }
}