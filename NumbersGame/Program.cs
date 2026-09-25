
 
 Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");    
    

    Random random = new Random();

    int number = random.Next(1,20);
    
     bool isCorrect = false;

    for (int i = 0; i < 5; i++)
    
{
    int guess = int.Parse(Console.ReadLine());

    if (guess > number)

{
    Console.WriteLine("Tyvärr, du gissade för högt!");
}
else if (guess < number)

{
    Console.WriteLine("Tyvärr, du gissade för lågt!");
}

else

    {
        Console.WriteLine("Wohoo! Du klarade det!");
    
        isCorrect = true;

        break;
    } 

}
 
    if (!isCorrect)
  {
        Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
    }

