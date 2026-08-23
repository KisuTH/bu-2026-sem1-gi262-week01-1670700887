using UnityEngine;

public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // As01_CheckNumberSign();
         As02_GetDayName();
        // As03_ValidatePassword();
        // As04_GetGrade();
        // As05_IsLeapYear();
        // As06_Calculate();
        // As07_GetSeason();
        // As08_PurchasingSystemExample();
        // As09_RockPaperScissorsExample();
        // As10_CalculateWeaponDamage();
        // As11_DeterminePlayerRank();
    }

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        // TODO: Implement logic to determine sign
        // Example: Debug.Log("Positive");
        if (as01Number > 0)
        {
            Debug.Log("Positive");
        }
        else if (as01Number < 0)
        {
            Debug.Log("Negative");
        }
        else
        {
            Debug.Log("Zero");
        }
    }

    public int as02Day;
    public void As02_GetDayName()
    {
        // TODO: Implement logic to return day name
        // Example: Debug.Log("Monday");
        if (as02Day == 1)
        {
            Debug.Log("Monday");
        }
        else if (as02Day == 2)
        {
            Debug.Log("Tuesday");
        }
        else if (as02Day == 3)
        {
            Debug.Log("Wednesday");
        }
        else if (as02Day == 4)
        {
            Debug.Log("Thursday");
        }
        else if (as02Day == 5)
        {
            Debug.Log("Friday");
        }
        else if (as02Day == 6)
        {
            Debug.Log("Saturday");
        }
        else if (as02Day == 7)
        {
            Debug.Log("Sunday");
        }
        else
        {
            Debug.Log("Invalid day");
        }
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        // TODO: Implement password validation logic
        // Example: Debug.Log("True");
        if (as03InputPassword == as03CorrectPassword)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        // TODO: Implement logic to return grade
        // Example: Debug.Log("A");
        if (as04Score >= 80)
        {
            Debug.Log("A");
        }
        else if (as04Score >= 70)
        {
            Debug.Log("B");
        }
        else if (as04Score >= 60)
        {
            Debug.Log("C");
        }
        else if (as04Score >= 50)
        {
            Debug.Log("D");
        }
        else
        {
            Debug.Log("F");
        }
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        // TODO: Implement leap year check logic
        // Example: Debug.Log("True");
        if ((as05Year % 400 == 0) || (as05Year % 4 == 0 && as05Year % 100 != 0))
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public void As06_Calculate()
    {
        // TODO: Implement calculator logic
        // Example: Debug.Log("Result: 42");
        if (as06Op == '+')
        {
            Debug.Log("Result: " + (as06Num1 + as06Num2));
        }
        else if (as06Op == '-')
        {
            Debug.Log("Result: " + (as06Num1 - as06Num2));
        }
        else if (as06Op == '*')
        {
            Debug.Log("Result: " + (as06Num1 * as06Num2));
        }
        else if (as06Op == '/')
        {
            if (as06Num2 != 0)
            {
                Debug.Log("Result: " + (as06Num1 / as06Num2));
            }
            else
            {
                Debug.Log("Cannot divide by zero");
            }
        }
        else
        {
            Debug.Log("Invalid operator");
        }
    }

    public int as07Month;
    public void As07_GetSeason()
    {
        // TODO: Implement logic to return season
        // Example: Debug.Log("Summer");
        if (as07Month == 12 || as07Month == 1 || as07Month == 2)
        {
            Debug.Log("Winter");
        }
        else if (as07Month >= 3 && as07Month <= 5)
        {
            Debug.Log("Spring");
        }
        else if (as07Month >= 6 && as07Month <= 8)
        {
            Debug.Log("Summer");
        }
        else if (as07Month >= 9 && as07Month <= 11)
        {
            Debug.Log("Autumn");
        }
        else
        {
            Debug.Log("Invalid month");
        }
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        int totalPrice = as08Quantity * as08Price;

        if (as08Payment >= totalPrice)
        {
            Debug.Log("Purchase successful");
            Debug.Log("Change: " + (as08Payment - totalPrice));
        }
        else
        {
            Debug.Log("Insufficient payment");
            Debug.Log("Need more: " + (totalPrice - as08Payment));
        }
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        if (as09UserChoice < 1 || as09UserChoice > 3 || as09ComputerChoice < 1 || as09ComputerChoice > 3)
        {
            Debug.Log("Invalid choice");
        }
        else if (as09UserChoice == as09ComputerChoice)
        {
            Debug.Log("Draw");
        }
        else if ((as09UserChoice == 1 && as09ComputerChoice == 3) ||
                 (as09UserChoice == 2 && as09ComputerChoice == 1) ||
                 (as09UserChoice == 3 && as09ComputerChoice == 2))
        {
            Debug.Log("User wins");
        }
        else
        {
            Debug.Log("Computer wins");
        }
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        if (as10WeaponType == "Sword")
        {
            Debug.Log("Damage: " + (as10BaseDamage * 2));
        }
        else if (as10WeaponType == "Bow")
        {
            Debug.Log("Damage: " + (as10BaseDamage + 10));
        }
        else if (as10WeaponType == "Staff")
        {
            Debug.Log("Damage: " + (as10BaseDamage + 20));
        }
        else
        {
            Debug.Log("Damage: " + as10BaseDamage);
        }
    }

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        if (as11Score >= 90 && as11CompletionTime <= 60)
        {
            Debug.Log("S Rank");
        }
        else if (as11Score >= 80 && as11CompletionTime <= 120)
        {
            Debug.Log("A Rank");
        }
        else if (as11Score >= 70 && as11CompletionTime <= 180)
        {
            Debug.Log("B Rank");
        }
        else if (as11Score >= 60)
        {
            Debug.Log("C Rank");
        }
        else
        {
            Debug.Log("D Rank");
        }
    }
}