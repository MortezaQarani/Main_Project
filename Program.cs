
string firstname = null;
string lastname = null;
int nationalcode = 0;
long phone_num = 0;
int age = 0;
string str1 = "";
string mm = firstname + lastname;
bool age_flag = true;
bool phon_num_flag = true;
Console.WriteLine("Please ente your first name:");
firstname = Console.ReadLine();
Console.WriteLine("Please ente your last name:");
lastname = Console.ReadLine();
while (age_flag)
{
    Console.WriteLine("Please ente your age:");
    //string test = Console.ReadLine();
    try
    {
        age = int.Parse(Console.ReadLine());
        age_flag = false;
        if (age < 15 || age > 130)
        {
            phon_num_flag = false;
            Console.WriteLine("Your registration faild. because, your age is out of range.");
            Console.ReadKey();
        }
    }
    catch
    {
        Console.WriteLine("invalid value.");
        age_flag = true;
    }
}

while (phon_num_flag)
{
    Console.WriteLine("Please ente your phone number:");
    str1=Console.ReadLine();
    try
    {
        if ((str1.Length == 11 && str1.StartsWith('0')) || (str1.Length == 10 && !str1.StartsWith('0')))
        {
            phone_num = long.Parse(str1);
            phon_num_flag = false;
        }
        else if (str1.Length == 13 && str1.StartsWith("+98"))
        {
            str1 = str1.Remove(0, 3);
            phone_num = long.Parse(str1);
            phon_num_flag = false;
        }
        else
        {
            Console.WriteLine("Invalid phone number.");
            phon_num_flag = true;
        }
    }
    catch
    {
        Console.WriteLine("Invalid phone number.");
        phon_num_flag = true;
    }
}
str1 = '0'+phone_num.ToString();
Console.WriteLine($"A user was registered with the following information:\nName: {firstname} {lastname}\nPhone number: {str1}\nAge:{ age} ");

