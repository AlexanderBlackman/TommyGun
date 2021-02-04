using System;

namespace TommyGun
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBullets = StaticToolbox.ReadInt(20, "Number of bullets");
            int magazineSize = StaticToolbox.ReadInt(16, "Magazine size ");

            Console.Write($"Loaded [false]: ");
            bool.TryParse(Console.ReadLine(), out bool isLoaded); 



            MachineGun gun = new MachineGun(numberOfBullets, magazineSize, isLoaded);
            while (true) 
            {
                Console.WriteLine($"{gun.Bullets} bullets, {gun.BulletsLoaded} loaded");
                if (gun.IsEmpty()) Console.WriteLine("WARNING: you are out of ammo");
                Console.WriteLine("Space to shoot, r to reload, m to add ammo, q to quit");
                char key = Console.ReadKey(true).KeyChar;


                switch (key){
                        case ' ': Console.WriteLine($"Shooting returned {gun.Shoot}");
                            break;
                        case 'r': gun.Reload();
                            break;
                        case 'm': gun.Bullets += gun.MagazineSize;
                            break;
                        default: return;


                      
                    }
            }
        }
    }
}
