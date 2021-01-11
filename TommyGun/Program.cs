using System;

namespace TommyGun
{
    class Program
    {
        static void Main(string[] args)
        {
            MachineGun gun = new MachineGun();
            while (true)
            {
                Console.WriteLine($"{gun.GetBullets()} bullets, {gun.GetBulletsLoaded()} loaded");
                if (gun.IsEmpty()) Console.WriteLine("WARNING: you are out of ammo");
                Console.WriteLine("Space to shoot, r to reload, + to add ammo, q to quit");
                char key = Console.ReadKey(true).KeyChar;
                if (key == ' ') 


                switch (key){
                        case ' ': Console.WriteLine($"Shooting returned {gun.Shoot()}");
                            break;
                        case 'r': gun.Reload();
                            break;
                        case '+': gun.SetBullets(gun.GetBullets() + MachineGun.MAGAZINE_SIZE);
                            break;
                        case 'q': return;


                      
                    }
            }
        }
    }
}
