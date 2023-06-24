// Censor the local-part of an email.
// This program is manual validating the email format.


public class CensorEmail
{
    public static void Main()
    {
        Console.Write("Your email adress is: ");
        var userEmail = Console.ReadLine();
        var approveEmail = ValidateEmail(userEmail);

        if(approveEmail) 
        {
            var censoredAdress = Censorship(userEmail);
            Console.WriteLine(censoredAdress);
        }
        
    }

    private static string Censorship(string userEmail)
    {
        var arondIndex = userEmail.IndexOf('@');

        var username = userEmail.Substring(0, arondIndex);
        var domain = userEmail.Substring(arondIndex);
        var censoredAdress = new string('*', username.Length);

        return censoredAdress + domain;
    }

    public static bool ValidateEmail(string adress)
    {
        if(adress != null && adress.Count(c => c == '@') == 1)
        {

            var username = ValidateUserName(adress);
            var domaine = ValidateDomaine(adress);

            return username && domaine;
        }

        Console.WriteLine("You entered an invalid email, or the email is in wrong format!");
        return false;
    }

    private static bool ValidateDomaine(string adress)
    {
        var domain = adress.Substring(adress.IndexOf('@') + 1);
        if(domain.Count(c => c == '.') == 1)
        {
            return PointPosition(domain) && OnlyLettersDomain(domain);
        }

        return false;
    }

    private static bool ValidateUserName(string adress)
    {
        var username = adress.Substring(0, adress.IndexOf('@'));
        char[] unallowed = { '\"', '(', ')', ',', ':', ';', '<', '>', '@', '[', '\\', ']' };

        foreach (char c in username)
        {
            if (Array.IndexOf(unallowed, c) != -1)
                return false;
        }

        return true;
    }

    private static bool PointPosition(string domain)
    {
        return (domain.IndexOf('.') != 0 && domain.IndexOf('.') != domain.Length - 1);
    }

    private static bool OnlyLettersDomain(string domain)
    {
        foreach(char ch in domain)
        {
            if (!(char.IsLetterOrDigit(ch) || ch == '.'))
            {
                return false;
            }
        }

        return true;
    }

    
        
}