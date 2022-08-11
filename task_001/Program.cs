/*
    Напишите программу, которая по заданному номеру четверти, 
    показывает диапазон возможных координат точек в этой четверти (x и y).

*/

Console.WriteLine("Введите номер четверти: ");
int chetvert = Convert.ToInt32(Console.ReadLine());

switch(chetvert)
{
    case 1:
    {
        Console.WriteLine("x+, y+");
        break;
    }
    case 2:
    {
        Console.WriteLine("-x, y+");
        break;
    }
    case 3:
    {
        Console.WriteLine("-x, -y");
        break;
    }
    case 4:
    {
        Console.WriteLine("x+, -y");
        break;
    }
    default:
    {
        Console.WriteLine("Такой четверти нет!");
        break;
    }
}


