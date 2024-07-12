using System;
class Program
{
    public Program()
    {
        MainMethod();
        Attendance();
        College();
        friends();
        Nature();
        Essay();
        Trim();
        StartTrim();
        TrimEnd();
        TrimCharacter();
    }

    static void Main(string[] args)
    {
        new Program();
    }
    void MainMethod()  //SimpleSplit
    {
        string input = "Apple,Banana,Cherry";
        string[] fruits = input.Split(',');
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
            Console.WriteLine(".................................");
        }
    }
    void Attendance()  //SplittingWithMultipleDelimiters
    {
        string input = "Abhay;Bhanvi|Gurjot;Tanishsa";
        char[] delimiters = { ';', '|' };
        string[] students = input.Split(delimiters);
        foreach (var student in students)
        {
            Console.WriteLine(student);
            Console.WriteLine(".................................");
        }
    }
    void College()  //RemovingEmptyEntries
    {
        string input = "Sdcollege,,Abcollege,,DAVcollege";
        string[] institutes = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var institute in institutes)
        {
            Console.WriteLine(institute);
            Console.WriteLine(".................................");
        }
    }
    void friends()        //SplittingWithStringsAsDelimiters
    {
        string input = "Tushar---Amandeep+++Samrat";
        string[] delimiters = { "---", "+++" };
        string[] Brothers = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        //foreach (var item in Brothers)
        //{
        //    Console.WriteLine(item);
        //}
        Array.ForEach(Brothers, Console.WriteLine);  ///Array.ForEach method can also be used to print 
        Console.WriteLine(".................................");
    }
    void Nature()
    {
        string input = "Eagle,Sparrow,Peacock,GoldenHawk,Crow,WoodPecker,Pigeon";
        string[] Birds = input.Split(',', 4);
        Array.ForEach(Birds, Console.WriteLine);      //Limiting the number of substrings
        Console.WriteLine(".................................");
    }
    void Essay()
    {
        string input = "MyxxNamexxIsxxPrabhjotxxIxxAmxxAnxxTraineexxInxxXybyte";
        string[] intro = input.Split("xx");

        Array.ForEach(intro, Console.WriteLine);
        Console.WriteLine(".................................");
    }
    //TrimString
    void Trim()
    {
        string input = "    Hello,World    ";      //TrimWhitespaceFromBothEnds
        string trimmed = input.Trim();
        Console.WriteLine($"'{trimmed}'");
        Console.WriteLine(".................................");
    }
    void StartTrim()
    {
        string input = "     Hello,IamPrabhjot         ";            //TrimWhitespaceFromStart
        string trimmed = input.TrimStart();
        Console.WriteLine($"'{trimmed}'");
        Console.WriteLine(".................................");
    }
    void TrimEnd()
    {
        string input = "     Hello,IamPrabhjot         ";            //TrimWhitespaceFromEnd
        string trimmed = input.TrimEnd();
        Console.WriteLine($"'{trimmed}'");
        Console.WriteLine(".................................");
    }
    void TrimCharacter()
    {
        string input = "***Hello,Welcome!ToMyPage!!!!!!!***";      //TrimSpecificCharacters
        char[] CharsToTrim = { '*', '!' };
        string trimmed = input.Trim(CharsToTrim);
        Console.WriteLine($"'{trimmed}'");
    }
}
