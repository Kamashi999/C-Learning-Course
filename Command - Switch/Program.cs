/* Switch nie może być zapisany w float!!! */

/* Switche działają na zasadzie sprawdzenia co jest zawarte w () po switch. Jeżeli żadna z podanych liczb/liter/itd nie spełnia 
 * warunku case, wykonany zostanie "default". Po każdym case trzeba go zamknąć komendą "break;".
*/

// Case również można wywołać zmienną string (tekstem), warunkiem jest ustawienie wywołania danego case np case "a":.

int sw = 3;

switch (sw)
{
    case 0:
        Console.WriteLine("case 0");
        break;
    case 1:
        Console.WriteLine("case 1");
        break;
    default:
        Console.WriteLine("Default");
        break;
}