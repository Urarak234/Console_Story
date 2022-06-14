using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStory
{
    internal class Items_Classes
    {
        public string name = "";
        public int hp;
        public int atk;
        public int def;
        public bool weapon_equiped = false;
        public bool armour_equiped = false;
        public int id;
        public void Dwarf()
        {
            hp = 10;
            atk = 4;
            def = 6;
        }
        public void Human()
        {
            hp = 9;
            atk = 5;
            def = 5;
        }
        public void Elf()
        {
            hp = 8;
            atk = 6;
            def = 4;
        }
        //--------------------------------------------Equipement-----------------------------------
        //                                   -----==== Weapons ====-----

        public void Stick()
        {
            atk = 1;
            id = 0;
        }
        public void Sword()
        {
            atk = 2;
            id = 0;
        }
        public void Axe()
        {
            atk = 4;
            id = 0;
        }

        public void Cursed_Dagger()
        {
            atk = 5;
            hp -= 1;
            id = 0;
        }

        //                                   -----==== Armour ====-----
        public void Leather_Bracers()
        {
            def = 1;
            id = 1;
        }
        public void Helmet()
        {
            def = 3;
            id = 1;
        }
        public void Ornate_Helmet()
        {
            def = 4;
            id = 1;
        }
        public void black_Helmet()
        {
            def = 5;
            hp = 2;
            atk = 1;
            id = 1;
        }

        public void Reset()
        {
            atk = 0;
            def = 0;
            hp = 0;
        }

    }
}
