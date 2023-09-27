string firstName = "Mahesh";
string lastName = "Dhant";
string emailTail = "contoso.com";

emailGenerator(firstName,lastName,emailTail);

void emailGenerator(string firstName, string lastName, string emailTail){
    string emailHead = firstName.Substring(0, 2).ToLower() + lastName.ToLower();
    string email = emailHead + "@" + emailTail;
    Console.WriteLine(email);
}

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string corporateDomain = "contoso.com";

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    string emailHead = corporate[i,0].Substring(0, 2).ToLower() + corporate[i,1].ToLower();
    string email = emailHead + "@" + corporateDomain;
    Console.WriteLine(email);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    string emailHead = external[i,0].Substring(0, 2).ToLower() + external[i,1].ToLower();
    string email = emailHead + "@" + externalDomain;
    Console.WriteLine(email);
}

////////////// Display email using function ///////////////

Console.WriteLine();
for (int i = 0; i < corporate.GetLength(0); i++) 
{
   emailGenerator(firstName: corporate[i,0], lastName: corporate[i,1], emailTail: corporateDomain);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
   emailGenerator(firstName: external[i,0], lastName: external[i,1], emailTail: externalDomain);
}