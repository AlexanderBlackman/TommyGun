using System;
using System.Collections.Generic;
using System.Text;

namespace TommyGun
{
    class MachineGun
    {
        public int MagazineSize { get; private set; } = 16;

        private int bullets = 0;
        public int BulletsLoaded { get; private set; }
        public bool IsEmpty() { return BulletsLoaded == 0; }
        
        public MachineGun(int bullets, int magazineSize, bool loaded)
        {
            this.bullets = bullets;
            MagazineSize = magazineSize;
            if (!loaded) Reload();
        }

        public int Bullets
        {
            get { return bullets; }
            set
            {
                if (value > 0)
                    bullets = value;
                Reload();
                
            }
        }

        /*    public void Reload()
            {
                if (bullets > MagazineSize)
                    BulletsLoaded = MagazineSize;
                else
                    BulletsLoaded = bullets;
            }*/

        public void Reload() => BulletsLoaded = bullets > MagazineSize ? MagazineSize : bullets;
        public bool Shoot
        {
            get
            {
                if (BulletsLoaded == 0) return false;
                BulletsLoaded--;
                bullets--;
                return true;
            }
        }
    }
}
