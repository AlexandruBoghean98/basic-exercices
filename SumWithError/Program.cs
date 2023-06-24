public class SumWithError
{
    public static void Main()
    {
        int limit = 5;  // Setez limita
        int[] numbers = new int[limit]; // Initiez un array in care urmeaza sa stochez fiecare numar in parte

        // Umplu array-ul cu numere (de la coada la cap)
        do  
        {
            numbers[limit-1] = ValidateInput(); // pornesc de la pozitia 4 (adica limita - 1) si merg pana la pozitia 0.
            limit--;  // Scade si limita de la 5 la 4 apoi 3, 2, 1. Cand limita e 1, algoritmul mai ruleaza inca odata si completeaza si pozitia 0.  
        }while (limit > 0);  // Repeta procesul pana cand limita = 0. Daca limita ajunge la 0, se opreste (Do - While) -ul 

        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }

        Console.WriteLine(sum);
    }

    public static int ValidateInput()  // Validez fiecare input in parte, pe masura ce utilizatorul il introduce
    {

        try  // incerca sa parseze numarul intr-un int; In cazul in care nu reuseste, si int.Parse da o eroare, se executa codul din catch
        {
            int number = int.Parse(Console.ReadLine());  // daca inputul este bun, si se reuseste Parse-ul la int, returneaza numarul care apoi va si memorat pe pozitia aferenta in array-ul de mai devreme
            return number;
        }
        catch  // Daca Parse -ul de mai devreme da erare pentru ca input-ul nu e in format corespunzator, executa codul de mai jos
        {
            Console.WriteLine("You entered an invalid number. Try again!"); // Display a message to try again.
            int number = int.Parse(Console.ReadLine()); // Ii cer din nou utilizatorului un nou input
            return number; // returnez numarul.

            // Liniile de cod din Catch se executa o singura data, de asta utilizatorul e rugat o singura data sa introduca o alta valoare.
            // Daca introduce din nou o valoare gresita, atunci programul va da o eroare si va opri programul.
        }
    }
}