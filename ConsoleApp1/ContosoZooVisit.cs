using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

//////////////////////     Execution    //////////////////

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

//////////////////////     Methods      //////////////////

void RandomizeAnimals()
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++) 
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }
}

string[,] AnimalsGrouping(int groups = 6)
{
    string[,] result = new string[groups, pettingZoo.Length/groups];
    int count = 0;

    for (int i=0; i<result.GetLength(0); i++){
        for (int j=0; j<result.GetLength(1); j++){
            result[i,j] = pettingZoo[count];
            count++;
        }
    }
    return result;
}

void PrintAnimalGroup(string[,] group)
{
    for (int i=0; i<group.GetLength(0); i++){
        Console.Write($"Group {i+1}: ");
        for (int j=0; j<group.GetLength(1); j++){
            Console.Write(group[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AnimalsGrouping(groups);
    Console.WriteLine(schoolName);
    PrintAnimalGroup(group);
    Console.WriteLine();
}

