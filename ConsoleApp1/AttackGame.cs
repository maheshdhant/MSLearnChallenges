using System.Runtime.InteropServices;

public class Challenges{
    public int heroLife = 10;
    public int monsterLife = 10;
    Random num = new Random();
    public void Fight(){
        do{
            int heroAttack = num.Next(1, 10);
            int monsterAttack = num.Next(1,10);

            monsterLife -= heroAttack;
            Console.WriteLine("Hero attacked by: " + heroAttack+ " monster health: " + monsterLife);
            if (monsterLife <= 0) continue;

            heroLife -= monsterAttack;
            Console.WriteLine("Monster attacked by: "+monsterAttack+ " hero health: " + heroLife);

        }while(heroLife>0 && monsterLife>0);
    
        Console.WriteLine(heroLife>monsterLife? "Hero won": "monster won");
    }
    public void Main(){
        Fight();
    }
}