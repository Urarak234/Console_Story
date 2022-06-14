using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStory
{
    internal class Enemies
    {
        public int hp;
        public int atk;
        public bool fight = false;
        public void Dark_liq()
        {
            hp = 20;
            atk = 2;
            fight = true;
        }
        public void Strange_Darkness()
        {
            hp = 20;
            atk = 6;
            fight = true;
        }

        public void Nictorine_Darkness(int stage)
        {
            hp = 25;
            atk = 9;
            fight = true;
            switch (stage)
            {
                case 0: hp = 25;
                    break;
                case 1: hp = 30;
                    break;
                case 2: hp = 35;
                    break;
                
                default:
                    break;
            }
        }

        public void Dark_Foggy()
        {
            hp = 20;
            atk = 10;
            fight = true;
        }

        public void Cyclope_Soldier()
        {
            hp = 25;
            atk = 11;
            fight = true;
        }
        //----------------------------BOSSES!-----------------------

        public void GroolGaalag()
        {
            hp = 30;
            atk = 13;
            fight = true;
        }
    }
}
