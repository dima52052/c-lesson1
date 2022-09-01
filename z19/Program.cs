Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();

void ChekNumber(string number){
    if (number[0]==number[4] || number[1]==number[3])  
        {Console.WriteLine($"{number} - палиндром");}
    else   
        Console.WriteLine($"{number} - не палиндром");
}

ChekNumber(number);