string cas;
int vw = 0; //Number of Vowels
int cons = 0; //Number of Consonants

Console.WriteLine("Enter a string of your choice >>");
string? con = Console.ReadLine();

cas = con.ToLower(); //Store the Lower case of the string input

//Convert the string case - [ Either Upper or Lower ]
if (con != cas)
{
    cas = con.ToLower();
}
else
{
    cas = con.ToUpper();
}

//Counts Number of Vowels and Consonants
for (int y = 0; y < con.Length; y++)
{

    if (con[y] == 'a' || con[y] == 'e' || con[y] == 'i'
        || con[y] == 'o' || con[y] == 'u' || con[y] == 'A'
        || con[y] == 'E' || con[y] == 'I' || con[y] == 'O' || con[y] == 'U')
    {
        vw++;
    }
    else
    {
        if (con[y] != ' ') //if there are white spaces 
        {
            cons++;
        }

    }
}

//Determines the length of the string
Console.WriteLine("String Length: {0}", con.Length);

//Display the string either in Upper case or Lower case
Console.WriteLine("The Converted Case: {0}", cas);

//Calculate the number of Vowels
Console.WriteLine("The string has {0} Vowels.", vw);

//Calculate the number of Consonants
Console.WriteLine("The string has {0} Consonants.", cons);