using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FG_beginner_guide_rework
{
    internal class FG_Combos
    {
        public static void TK8_Combos()
        {
            bool repeatcode = true;
            while (repeatcode)
            {
                int tk8_character_option;

                Console.WriteLine("\nCombos for Tekken 8 are usually short and simple with some moments where longer combos can provide more damage or wall carry potential.");
                Console.WriteLine("Tekken 8 combo structure is usually a launcher, attack strings to extend the combo, tornado, and a combo ender or wall carry that can end with a wall combo.");
                Console.WriteLine("\nWould you like to learn chracter specific beginner combos,key moves,and strategy? \n1.Yes \n2.No");
                Console.WriteLine("\nInput:");
                tk8_character_option = Convert.ToInt32(Console.ReadLine());
                if (tk8_character_option == 1)
                {
                    FG_Character.TK8_Characters();
                }
                if (tk8_character_option == 2)
                {
                    Console.WriteLine("Head out to practice mode and lab out some characters");
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose the correct option.");
                    repeatcode = true;
                }
            }

        }

        public static void SF6_Combos()
        {

            bool repeatcode = true;
            while (repeatcode)
            {
                int sf6_character_option;

                Console.WriteLine("Combos for Street Fighter 6 are usually short but with drive rush can make the combos longer along with creative.");
                Console.WriteLine("Street Fighter 6 combo structure consists of chains, links, special cancels, and drive rush.");
                Console.WriteLine("\nWould you like to learn character specific beginner combos,key moves,and strategy? \n1. Yes \n2. No");
                Console.WriteLine("\nInput:");

                sf6_character_option = Convert.ToInt32(Console.ReadLine());
                if (sf6_character_option == 1)
                {
                    FG_Character.SF6_Characters();
                }
                if (sf6_character_option == 2)
                {
                    Console.WriteLine("Head out to practice mode and lab out some characters");
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose the correct option.");
                    repeatcode = true;
                }

            }

        }

        public static void MK1_Combos()
        {
            bool repeatcode = true;
            while (repeatcode)
            {
                int mk1_character_option;

                Console.WriteLine("\nCombos for Mortal Kombat 1 can vary from short combos to longer combos.");
                Console.WriteLine("\nCombo structure for MK1 consist of string combos, special moves, and sometimes kameo assistance as well.");
                Console.WriteLine("\nWould you like to learn character specific beginner combos,key moves,and strategy? \n1. Yes \n2. No");
                Console.WriteLine("\nInput: ");
                mk1_character_option = Convert.ToInt32(Console.ReadLine());
                if (mk1_character_option == 1)
                {
                    FG_Character.MK1_Characters();
                }
                if (mk1_character_option == 2)
                {
                    Console.WriteLine("Head out to practice mode and lab out some characters");
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose the correct option.");
                    repeatcode = true;
                }
            }
        }
    }
}
