using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FG_beginner_guide_rework
{
    internal class FG_Character
    {
        public static void TK8_Characters()
        {
            string tk8_fighter = "";
            int tk8_option;
            int tk8character;

            List<String> tk8 = new List<String>();
            //easy to learn tekken 8 characters
            tk8.Add("Kuma");
            tk8.Add("Alisa");
            tk8.Add("Asuka");
            tk8.Add("Claudio");
            tk8.Add("Clive");
            tk8.Add("Jack-8");
            tk8.Add("Panda");
            tk8.Add("Lars");
            tk8.Add("Leroy");
            tk8.Add("Lili");
            tk8.Add("Dragunov");
            tk8.Add("Shaheen");

            //intermediate to learn tekken 8 characters
            tk8.Add("Azucena");
            tk8.Add("Eddy");
            tk8.Add("Feng");
            tk8.Add("Jun");
            tk8.Add("Leo");
            tk8.Add("Lidia");
            tk8.Add("Paul");
            tk8.Add("Raven");
            tk8.Add("Victor");
            tk8.Add("Zafina");

            //Advanced to learn tekken 8 characters
            tk8.Add("Jin");
            tk8.Add("Kazuya");
            tk8.Add("Reina");
            tk8.Add("Heihachi");
            tk8.Add("Lee");
            tk8.Add("DVJ (Devil Jin)");
            tk8.Add("Hwoarang");
            tk8.Add("King");
            tk8.Add("Xiaoyu");
            tk8.Add("Nina");
            tk8.Add("Steve");
            tk8.Add("Yoshimitsu");

            Console.WriteLine("\nTekken 8 has 36 Characters.");
            Console.WriteLine("Would you like to pick your character or have it picked randomly for you?");
            Console.WriteLine("Enter the number for the option.");
            Console.WriteLine("1. Pick your character \n2. Randomly pick my character");
            Console.WriteLine("Input:");

            if (int.TryParse(Console.ReadLine(), out tk8character))
            {

            };

            if (tk8character == 1)
            {

                bool repeatcode = true;
                while (repeatcode)
                {
                    Console.WriteLine("Which Tekken 8 character would you like to learn?\n");
                    Console.WriteLine("List of current TK8 Characters");
                    foreach (String characters in tk8)
                    {
                        Console.WriteLine(characters);
                    }

                    Console.WriteLine("\nInput: ");
                    tk8_fighter = Console.ReadLine();
                    tk8_fighter = tk8_fighter.ToUpper();

                    bool repeatcharacter = true;
                    while (repeatcharacter)
                    {
                        switch (tk8_fighter)
                        {
                            //Easy to learn
                            case "KUMA":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Kuma is the joke character of tekken 8 with good range, mixups, and gimmicks with their stances.");
                                Console.WriteLine("\nWhat would you like to learn about Kuma? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Kuma key moves:");
                                            Console.WriteLine("1. Bear jab: 1 which can lead to 1,1,1 combo launcher");
                                            Console.WriteLine("2. Anger hook: BF 2");
                                            Console.WriteLine("3. Bear Slash: B 1");
                                            Console.WriteLine("4. Falling Bear: FF 1+2");
                                            Console.WriteLine("5. Demon Uppercut: FF 2");
                                            Console.WriteLine("6. Bear Hopkick: UF 3 can also lead to UF 3,4,1+2 combo");
                                            Console.WriteLine("7. Rabid Bear: FFF 1+2");
                                            Console.WriteLine("8. Spinning Kuma: DB 4");
                                            Console.WriteLine("9. Kuma Musou: DB 1,2");
                                            Console.WriteLine("10. Grizzly Rampage: DF 1,2,1+2");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Kuma Basic Combos:");
                                            Console.WriteLine("1. DF+2,1 > B+2,2,1 > F 1+2,1+2");
                                            Console.WriteLine("2. F 1+2,1+2 > U+2 > B+2,2,1");
                                            Console.WriteLine("3. DF 2,1 > F+4 > B+2,1 > F 1+2,1+2 > U+2 > B+1");
                                            Console.WriteLine("4. DF 2,1 > B+2,2,1 > U+2 > QCF+2,1");
                                            Console.WriteLine("5. DF+2,1 > B+,2,2,1 > U+2 > HEAT > HEAT SMASH");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Kuma has excellent pokes and ways to deal tremendous amounts of chip damage to his opposition, \nbut actually getting in and forcing your opponent to make the wrong move to punish them can be extremely hard to pull off."
                                                              + "\nWhile you don't have to be a master of the game to pick Kuma up, you might have to hit the lab a bit to grasp everything he's capable of.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "ALISA":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Alisa is a well rounded character with strong/simple poking and neutral.");
                                Console.WriteLine("\nWhat would you like to learn about Alisa? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Alisa key moves:");
                                            Console.WriteLine("1. Clockwork Spring Middle: WR+3,3/WR+3,D+3");
                                            Console.WriteLine("2. Transmission: B+1+2");
                                            Console.WriteLine("3. Hertz Blade - Diable: DS F+1+2");
                                            Console.WriteLine("4. Shredder: DS 1");
                                            Console.WriteLine("5. Hertz Blade: DS F+1");
                                            Console.WriteLine("6. Quick Trim: 3,2");
                                            Console.WriteLine("7. Thruster Drill: DBB 1+2");
                                            Console.WriteLine("8. Optimizer: D+4, 1+2");
                                            Console.WriteLine("9. Image Cutter: UF+2");
                                            Console.WriteLine("10. Dual Session: F+2,1");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Alisa Basic Combos:");
                                            Console.WriteLine("1. DF+2 > B+2,3 > F+4,1,4");
                                            Console.WriteLine("2. DF+2 > DF+1,1 > B+2,3 > B+4,3");
                                            Console.WriteLine("3. DF+2 > UF+1,F+4 > F+1");
                                            Console.WriteLine("4. UF+4,4 > WR+1,2,3 > UF+1,F+4 > F+1");
                                            Console.WriteLine("5. UF+4,4 > F+2 > DF+1,1 > B+2,3 > 1,2,2");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Alisa Bosconovitch's many stances and extensive Move List can make her a bit daunting for newcomers to pick up, \nwhich is only elevated more by her intense speed and hyper-aggressive playstyle."
                                                              + "\nAnd, while she isn't the most beginner-friendly character in the game, she might be more approachable than you think.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "ASUKA":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Asuka has a strong keepout game along with strong and unique oki.");
                                Console.WriteLine("\nWhat would you like to learn about Asuka? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Auska key moves:");
                                            Console.WriteLine("1. Mist Palm Thrust: SS+2");
                                            Console.WriteLine("2. Swallow Vortex: DB+1+2");
                                            Console.WriteLine("3. Heart Stopper: B+4");
                                            Console.WriteLine("4. Sashiro: D+1+2");
                                            Console.WriteLine("5. White Mountain: DF+2+3");
                                            Console.WriteLine("6. Ryunntsui: 3+4");
                                            Console.WriteLine("7. Leaping Spin Kick: FF+4");
                                            Console.WriteLine("8. Double Lift Kicks: D+3+4");
                                            Console.WriteLine("9. Exorcisor: F+1+2");
                                            Console.WriteLine("10. Naniwa Gusto: U+1+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Asuka Basic Combos:");
                                            Console.WriteLine("1. F+2 > FF2+3 > DB+1,4 > FF+4 > FF+2,1+2 > 1+2");
                                            Console.WriteLine("2. UF+4 > FF+2,3 > DB+1,4 > FF+4 > FF+1,1+2 > 1+2");
                                            Console.WriteLine("3. WR+3 > FF+2,3 > DB+1,4 > FF+4 > FF+1,1+2 > 1+2");
                                            Console.WriteLine("4. DB+2 > FF+2,3 > DB+1,4 > FF+4 > FF+2,1+2 > 1+2");
                                            Console.WriteLine("5. DF+2 > FF+2,3 > DB+1,4 > FF+4 > FF+2,1+2 > 1+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Asuka Kazama is amongst the easiest characters to pick up and play, as she doesn't possess many stances, \nand the one she does have access to isn't overly complex or challenging to implement into her gameplan."
                                                              + "\nShe's just a relatively solid and straightforward character, which is as good as it gets for beginners.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "CLAUDIO":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Claudio is a unique install character with a strong hopkick option");
                                Console.WriteLine("\nWhat would you like to learn about Claudio? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Claudio key moves:");
                                            Console.WriteLine("1. Vanishing Storm: B+1");
                                            Console.WriteLine("2. Luxuria: SS+4");
                                            Console.WriteLine("3. Dispel Magic/Dispel Force: DF+3,1/DF+3,2");
                                            Console.WriteLine("4. Invidia: FF+4");
                                            Console.WriteLine("5. Sky Slash Nova: UF+4");
                                            Console.WriteLine("6. Sky's Arc: DF+1,2");
                                            Console.WriteLine("7. Cross Arm Impact Burst: F+1+2,1+2");
                                            Console.WriteLine("8. Chaos Fist: DF+2");
                                            Console.WriteLine("9. Acedia: DB+3");
                                            Console.WriteLine("10. Judgment Claw: Move_input");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Claudio Basic Combos:");
                                            Console.WriteLine("1. UF+4 > B+2 > FF+4 > B+3 > F+2 > B+4,2");
                                            Console.WriteLine("2. UF+4 > FF+4 > B+3 > DF+3,2 > B+4,4 > FFF+2");
                                            Console.WriteLine("3. DF+1,2 > FF+4 > B+3 > UF 3+4 > DB 1+2 > FFF+2");
                                            Console.WriteLine("4. UF+4 > FF+4 > B+3 > B+2 > FF+4 > 3,2");
                                            Console.WriteLine("5. UF+4 > FF+4 > B+3 > B+3 > UF 3+4 > DB 1+2 > FFF+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Claudio Serafino brings his unique install-based gameplay back into the mix, enabling him to use his Exorcism Sorcery to mix his opponents up and punish them for even thinking of trying to take him on."
                                                              + "\nHe is an unbelievably cool character but can be tricky to grasp due to his wildly different gameplay style."
                                                              + "\nHowever, even despite having an install, Claudio is actually pretty beginner-friendly and isn't terribly complex to learn.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "CLIVE":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Clive is a guest character with good space control and final fantasy character");
                                Console.WriteLine("\nWhat would you like to learn about Clive? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Clive key moves:");
                                            Console.WriteLine("1. Body Jab: DF+1");
                                            Console.WriteLine("2. Prominence: F+1+2");
                                            Console.WriteLine("3. Flame Bash: 1+2");
                                            Console.WriteLine("4. Blue Bolt: B+1");
                                            Console.WriteLine("5. Cold Cyclone: DB+4");
                                            Console.WriteLine("6. Pile Driver: D+1+2");
                                            Console.WriteLine("7. Door Knocker: DF+4");
                                            Console.WriteLine("8. Stone Smite: SS+1+2");
                                            Console.WriteLine("9. Windup: B+1+2");
                                            Console.WriteLine("10. Tidal Surge: DB+1");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Clive Basic Combos:");
                                            Console.WriteLine("1. DF+2 > DB 1+2,1 > UF+2,2 > B+2F > PS 2,2");
                                            Console.WriteLine("2. DF+2 > DF+1,4 > DB 1+2,1 > UPD 22 > DASH DF+1,2F > PS 1");
                                            Console.WriteLine("3. DF+2 > DB 1+2,1 > UPD 3 > DASH DF+1,4,3 > WOL 2");
                                            Console.WriteLine("4. F+3 > D+1 > WR+4 > 1 > DASH DF+1,4,3 > WOL 2");
                                            Console.WriteLine("5. SS 1+2 > DF+1,4 > DB 1+2,1 > UPD 2,2 > DASH B+2F > PS 1,2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Clive specializes in keep-out and defense but also has some decent offensive tools, such as the Zantatsuken. \nThe character is highly accessible and can be played by players of all skill levels."
                                                              + "\nClive might require a lot of time and effort to fully master, but he has something to offer for players of all skill brackets \nand once you've grasped the general game plan of the character, playing him will become a lot easier and more fun.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "JACK-8":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Jack-8 has good range with his attacks and rushdown pressure as well.");
                                Console.WriteLine("\nWhat would you like to learn about Jack-8? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Jack-8 key moves:");
                                            Console.WriteLine("1. Jackhammer: FF+1");
                                            Console.WriteLine("2. Pinpoint Assault: F+2");
                                            Console.WriteLine("3. Jab Elbow Smash: 2,1 (doing 2,1,2 can be a launcher)");
                                            Console.WriteLine("4. Granite Stomping: FF+3");
                                            Console.WriteLine("5. Impact Driver: F+1,1");
                                            Console.WriteLine("6. Drilling Engine/Piston Gun Blaster: F+1,2,1/F+1,2,2");
                                            Console.WriteLine("7. F+3,2/F+3,1+2: Two-Step Die/Machine Press");
                                            Console.WriteLine("8. Machinegun Blast: DB+1");
                                            Console.WriteLine("9. Barrel Jacket Hammer: UB+1+2");
                                            Console.WriteLine("10. Rolling Death Crusher: F+1+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Jack-8 Basic Combos:");
                                            Console.WriteLine("1. DF+2 > DF+1,1 > B+3,2,2");
                                            Console.WriteLine("2. 1+2 > FF+2 > B+1 > B+3,2D > GAHL F+1");
                                            Console.WriteLine("3. DF+2 > B+4 > B+3,2 > F+1,2,1 > RUN F+1,2,1");
                                            Console.WriteLine("4. DF+2,1D > GAHL 2 > FF+2 > B+3,2D > GAHL F+1");
                                            Console.WriteLine("5. DF+2,1(Hold 1) > FF+2 > B+1 > F+1,2,1 ");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Jack-8 is leaning heavily toward the easier end of the roster concerning being able to pick up and play as them regardless of your skill level,"
                                                              + "\nsome aspects of their gameplay can be tricky and deceptively challenging to get down, but if you're looking to dish out tons of damage in concise bursts, then he is your go-to man.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "PANDA":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Panda is the joke character of tekken 8 with good range, mixups, and gimmicks with their stances.");
                                Console.WriteLine("\nWhat would you like to learn about Panda? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Panda key moves:");
                                            Console.WriteLine("1. Bear jab: 1 which can lead to 1,1,1 combo launcher");
                                            Console.WriteLine("2. Anger hook: BF 2");
                                            Console.WriteLine("3. Bear Slash: B 1");
                                            Console.WriteLine("4. Falling Bear: FF 1+2");
                                            Console.WriteLine("5. Demon Uppercut: FF 2");
                                            Console.WriteLine("6. Bear Hopkick: UF 3 can also lead to UF 3,4,1+2 combo");
                                            Console.WriteLine("7. Rabid Bear: FFF 1+2");
                                            Console.WriteLine("8. Spinning Kuma: DB 4");
                                            Console.WriteLine("9. Kuma Musou: DB 1,2");
                                            Console.WriteLine("10. Grizzly Rampage: DF 1,2,1+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Panda Basic Combos:");
                                            Console.WriteLine("1. DF+2,1 > B+2,2,1 > F 1+2,1+2");
                                            Console.WriteLine("2. F 1+2,1+2 > U+2 > B+2,2,1");
                                            Console.WriteLine("3. DF 2,1 > F+4 > B+2,1 > F 1+2,1+2 > U+2 > B+1");
                                            Console.WriteLine("4. DF 2,1 > B+2,2,1 > U+2 > QCF+2,1");
                                            Console.WriteLine("5. DF+2,1 > B+,2,2,1 > U+2 > HEAT > HEAT SMASH");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Panda has excellent pokes and ways to deal tremendous amounts of chip damage to his opposition, \nbut actually getting in and forcing your opponent to make the wrong move to punish them can be extremely hard to pull off."
                                                              + "\nWhile you don't have to be a master of the game to pick Panda up, you might have to hit the lab a bit to grasp everything he's capable of.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "LARS":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Lars is a rushdown character with strong stance mixups");
                                Console.WriteLine("\nWhat would you like to learn about Lars? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Lars key moves:");
                                            Console.WriteLine("1. Ring Current: 2,1");
                                            Console.WriteLine("2. Bow Shock: DE+3");
                                            Console.WriteLine("3. Elbow Corona: FF+1+2");
                                            Console.WriteLine("4. Double Pulse: FF+4,3");
                                            Console.WriteLine("5. Shadow Cutter: DB+4");
                                            Console.WriteLine("6. Lighting Screw: UF+3");
                                            Console.WriteLine("7. Surge Blast: FF+2");
                                            Console.WriteLine("8. UF+4: Storm Axle");
                                            Console.WriteLine("9. Ark Blast: F+1+2");
                                            Console.WriteLine("10. X-Ray: 1+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Lars Basic Combos:");
                                            Console.WriteLine("1. UF+4 > DE+2 > DF+3,DFDE > F+2,1,SE 1+2 > F2,1,SE 3+4");
                                            Console.WriteLine("2. FB+2,1 > DE+2 > F+1,2,3 > 1 > SE+1+2 > F+3,2,UF > 4");
                                            Console.WriteLine("3. F+1+2 > DB2,1 > 2 > FF+4,2,DE+1 > SE+1+2 > FFF+2,1 > 1");
                                            Console.WriteLine("4. UF+3 > DF2 > DB+2,SE+1+2 > DF+1 > DF3,DF,DE,2,UF > 4");
                                            Console.WriteLine("5. WR+3 > FF+2 > FF+1,2,3,DE+1 > DE,SE+3+4");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Lars isn't necessarily the easiest character to learn, as he has several unique movement stances that cancel into one another, \nall offering various moves he can launch into."
                                                              + "\nWhile it isn't impossible to get down, it will take a bit of time, practice, and \npatience to learn everything he's capable of, but he's a generally easy character to learn compared to most.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "LEROY":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Leroy has good stance pressure/mixups and benefits from counter hits when players make a mistake");
                                Console.WriteLine("\nWhat would you like to learn about Leroy? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Leroy key moves:");
                                            Console.WriteLine("1. Jab: 1");
                                            Console.WriteLine("2. Body Jab: DF+1");
                                            Console.WriteLine("3. Outcast Arrow: B+1+2");
                                            Console.WriteLine("4. Hermit's Fist: B+1");
                                            Console.WriteLine("5. Feiche Xuan Feng Jiao: B+3");
                                            Console.WriteLine("6. Amputation Kick: DB+3");
                                            Console.WriteLine("7. Twin Snake Strike: D+3,2");
                                            Console.WriteLine("8. Floating Axe Drop: UF+4");
                                            Console.WriteLine("9. Zhuan Shen Jiao: B+4");
                                            Console.WriteLine("10. Snap Kick Knee: DF+4,3");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Leroy Basic Combos:");
                                            Console.WriteLine("1. DF+2,1+2 > QCF+2 > F+3 > D+3,2 > HRMT 2,3 > B+3+4");
                                            Console.WriteLine("2. DF+2,1+2 > F+2,3,4 > HRMT 2,3 > NMBL B+3 > HRMT 2,3");
                                            Console.WriteLine("3. DF+2,1+2 > QCF+2 > 2,2 > F+3,1+2,4 > DASH B+3 > HRMT 2,3");
                                            Console.WriteLine("4. DF+3+4 > QCF+2 > 2,2 > UF+3+4,1+2");
                                            Console.WriteLine("5. DB+2,3 > D > QCF+2 > 2 > DF+3,1 > DASH B+3+4");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Leroy Smith is a largely accessible character for all skill ranges, which is a relief as he is an incredibly cool and powerful fighter."
                                                              + "\nHowever, while he is easy to pick up, he has a tremendously high ceiling, making him rewarding to stick with and learn the ins and outs of.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "LILI":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Lili has good sidestepping tools along with applying pressure with her attacks.");
                                Console.WriteLine("\nWhat would you like to learn about Lili? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Lili key moves:");
                                            Console.WriteLine("1. Capricorn Kick: UF+3");
                                            Console.WriteLine("2. Submissive Heel: DF+3");
                                            Console.WriteLine("3. Thorn Whip: D+3");
                                            Console.WriteLine("4. Root of Evil: FF+4");
                                            Console.WriteLine("5. Orleans Sword: DF+2");
                                            Console.WriteLine("6. Heavy Languish: D+1,2");
                                            Console.WriteLine("7. Belier Attaque: F+4");
                                            Console.WriteLine("8. Kitty Claws: F+1+2");
                                            Console.WriteLine("9. Dominating Heel: DF+4,4");
                                            Console.WriteLine("10. Angel Heart: DGL 1+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Lili Basic Combos:");
                                            Console.WriteLine("1. UF+2 > B1,4 > 3,2,3");
                                            Console.WriteLine("2. DB+4 > 3,2 > 2 > D+2,2,3");
                                            Console.WriteLine("3. DF+2 > DF+2 > DF+3+4 > 1,2 > FF+3F > 1,4");
                                            Console.WriteLine("4. UF+3 > 4 > F+2,3 > DF+3+4 > 1,3 > FF+3F > 1,4");
                                            Console.WriteLine("5. UF+3 > DF+2 > F+2,3 > FF+3F > UF+3+4,3+4 > FF+3F > 1,4");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Despite her many stances, Lili remains pretty accessible to pick up and play. Still, she maintains a high skill ceiling, \nmeaning you will constantly be learning and getting better with her the more you play and practice."
                                                              + "\nLili isn't the most beginner-friendly character in the game, but she's approachable and fun to play, and that's more than enough!");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "DRAGUNOV":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Dragunov has strong pokes, rushdown and, throw game");
                                Console.WriteLine("\nWhat would you like to learn about Dragunov? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Dragunov key moves:");
                                            Console.WriteLine("1. Russian Hook Special: FFF+2");
                                            Console.WriteLine("2. Tundra Slash: B+4,3");
                                            Console.WriteLine("3. Tundra Strike to Ear Grab: B+4,2,1");
                                            Console.WriteLine("4. Tundra Strike to Ambush Tackle: B+4,2,1+2");
                                            Console.WriteLine("5. Ignition Switch: QCF+4");
                                            Console.WriteLine("6. Cocked Hammer: QCF+1");
                                            Console.WriteLine("7. Bunker-Buster Elbow: D+1");
                                            Console.WriteLine("8. Deadly Scorpion: DB+3+4");
                                            Console.WriteLine("9. Stinger Elbow: QCB+2");
                                            Console.WriteLine("10. Blizzard Hammer: B+1+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Dragunov Basic Combos:");
                                            Console.WriteLine("1. DF+2 > F+4,3 > FF+2");
                                            Console.WriteLine("2. DF+2 > F+4,4,3 > B+1,2 > DASH DF+3+4 > 3,1DF > SNK 1+2");
                                            Console.WriteLine("3. DF+2 > DF+1 > 4,4 > CR DF+1,4 > SNK2 > DASH DF+3+4 > 2,1DF > SNK4");
                                            Console.WriteLine("4. QCF+1 > SSL > QCF+3+4 > 4,4 > CR DF+1,4 > SNK2 > DASH > 2,1DF > SNK2");
                                            Console.WriteLine("5. QCB+2 > DASH > DF+3+4 > 4,4 > CR DF+1,4 > SNK4");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("He has many moves that are incredibly dubious and hard to counter, forcing his opponent to attempt to go on the defensive to take their turn back, which is playing directly into Dragunov's hands, \nas he can swiftly flip the script and punish them for being overly defensive with his grabs and devastating low attacks."
                                                              + "\nAnd, as mentioned earlier, it's not like Dragunov doesn't possess a high skill ceiling either, as the more you play as him, \nthe more you will be rewarded for learning all his options, how to implement them, and how to set up his suffocating offense properly.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "SHAHEEN":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Shaheen has a simple poking game to force mistakes from opponents along with a strong slide/mixup game");
                                Console.WriteLine("\nWhat would you like to learn about Shaheen? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Shaheen key moves:");
                                            Console.WriteLine("1. Body Jab: DF+1");
                                            Console.WriteLine("2. Rising Falcon: DF+2");
                                            Console.WriteLine("3. Piercing Talon: F+4");
                                            Console.WriteLine("4. Achernar: B+1");
                                            Console.WriteLine("5. Elnath: B+3+4");
                                            Console.WriteLine("6. Whirlwind Kick: DF+3");
                                            Console.WriteLine("7. Antares: FFF+2");
                                            Console.WriteLine("8. Heel Strike: B+3");
                                            Console.WriteLine("9. Silent Rigel: D+3");
                                            Console.WriteLine("10. Vicious Stomp: D+4");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Shaheen Basic Combos:");
                                            Console.WriteLine("1. UF+4 > 4,1 > F+2,3 > UF+1");
                                            Console.WriteLine("2. UF+4 > 3DF+SHSP > DB+2DF > 1 > F+2,3 > DASH DB+2DF+3");
                                            Console.WriteLine("3. UF+4 > 3DF+2 > F+2,4,4 > FF+3 > DASH DB2+DF+3");
                                            Console.WriteLine("4. DB+4 > D+2 > D+2 > DB+2+DF > 1 > F+2,3 > DASH DB+2+DF+3");
                                            Console.WriteLine("5. FF+4 > DASH D+2 > DB+2+DF > 1 > DF+4,1,DF+3");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Shaheen isn't overly complicated or complex, he isn't what we'd consider easy either."
                                                              + "\nHe is by far the easiest character with a slide move in the game, but his Stealth Step Stance and other bizarre moves can make him a bit harder to learn or pick up and play."
                                                              + "\nDespite this, we strongly recommend giving him a shot, as he is superbly fun and exhilarating when he gets cooking.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            //Intermediate to learn
                            case "AZUCENA":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Azucena, the Coffee Queen, has an aggressive rushdown playstyle along with float like a butterfly, sting like a bee offense with her stances.");
                                Console.WriteLine("\nWhat would you like to learn about Azucena? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Azucena key moves:");
                                            Console.WriteLine("1. Expresso Agression: FFF+3,2");
                                            Console.WriteLine("2. Grande Combo: DF+1");
                                            Console.WriteLine("3. Groovy Strike: 3");
                                            Console.WriteLine("4. High Mountain Combo: 1,1");
                                            Console.WriteLine("5. Taconees Drip: UF+4");
                                            Console.WriteLine("6. Aero Press Pegar: F+1+2");
                                            Console.WriteLine("7. Bitter Low Kick: DB+4");
                                            Console.WriteLine("8. Borassca Kick: DB+3");
                                            Console.WriteLine("9. Rhythmic Hook: U+2");
                                            Console.WriteLine("10. Hand Drip Hammer: D+1");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Azucena Basic Combos:");
                                            Console.WriteLine("1. DF+4,1 > F+3,2");
                                            Console.WriteLine("2. UF+4 > D+3,3,4 > B+4,3,4,3");
                                            Console.WriteLine("3. DF+2 > D+2,3 > LIB 4,1,2 > DASH F+2,1,4");
                                            Console.WriteLine("4. DF+2 > 4,3 > D+2,3 > LIB 1+2 > F+2,1,4");
                                            Console.WriteLine("5. DF+2 > 4,1 > 3 > LIB 4,1,2 > DASH F+2,1,4");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Azucena warrants a particular playstyle that can feel a bit complex or obtuse for newcomers. Her speedy nature is complemented well with the new Heat system,"
                                            + "\nbut her general playstyle can take a while to grasp if you're used to other characters."
                                            + "\nBut her ability to deal high damage while maintaining her aggressive offense is what sets her in a league of her own.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "EDDY":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Eddy Gordo, The Indomitable Flash, with his capoeria has some creative offense with his stances along with his attacks having 50/50 options.");
                                Console.WriteLine("\nWhat would you like to learn about Eddy? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Eddy key moves:");
                                            Console.WriteLine("1. Sincelo: 3,3");
                                            Console.WriteLine("2. Sismo: D+3");
                                            Console.WriteLine("3. Terremoto: FF+3");
                                            Console.WriteLine("4. Iemanja: NA 3+4");
                                            Console.WriteLine("5. Lunging Brush Fire: B+3+4");
                                            Console.WriteLine("6. Godeme Trovoada: FBA/BBA 1");
                                            Console.WriteLine("7. Travao: FFF+3");
                                            Console.WriteLine("8. Asfixiante: UF+3");
                                            Console.WriteLine("9. Gafanhoto: FC DF+3");
                                            Console.WriteLine("10. Faisca: SS 3+4");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Eddy Basic Combos:");
                                            Console.WriteLine("1. DF+3 > DF+1,3 > DB+4,4");
                                            Console.WriteLine("2. DF+3 > 3,3 > FBA/BBA 3,3,3 > NA 3,3");
                                            Console.WriteLine("3. DF+3 > 3,3 > FBA/BBA 3,3,3 > NA 1,4,4");
                                            Console.WriteLine("4. DF+3 > B+3,3 > NA 2 > B+1 > WR 1,4 > QCF+3 > DASH DB+4,4");
                                            Console.WriteLine("5. FF+4 > BA 2 > B+1 > WR 1,4 > QCF+3 > UF+4 > NA 3,3");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Eddy Gordo is incredibly beginner-friendly, but thanks to his high skill ceiling, he can evolve along with you during your journey."
                                            + "\nWhile button-mashing is enjoyable with a character like Eddy, properly learning his"
                                            + "\nunique fighting style and executing his toolkit online is phenomenally engaging and rewarding!");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "FENG":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Feng Wei, the God Fist, is know for his well rounded playstyle and strong turn stealing tools to get back on offense.");
                                Console.WriteLine("\nWhat would you like to learn about Feng Wei? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Feng Wei key moves:");
                                            Console.WriteLine("1. Iron Palm: B+1");
                                            Console.WriteLine("2. Evading Palm Strike: UF+2");
                                            Console.WriteLine("3. Piercing Arrow: DB+3");
                                            Console.WriteLine("4. Chin Breaker: B+3");
                                            Console.WriteLine("5. Lift Kick: DF+3");
                                            Console.WriteLine("6. Pau Lau Stinger: DF+4");
                                            Console.WriteLine("7. Xuan Jiao Xiao Yan Shou: FC DF+4,1");
                                            Console.WriteLine("8. Fish Hook: B+4");
                                            Console.WriteLine("9. Landslide: QCF+1");
                                            Console.WriteLine("10. Ruinous Halberd: DF+3+4");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Feng Wei Basic Combos:");
                                            Console.WriteLine("1. UF+4 > F+3,4 > F+2,1,2");
                                            Console.WriteLine("2. DF+3 > F+3,4 > B+1+2");
                                            Console.WriteLine("3. UF+4 > F+3,2 > DF+4,2,1+2 > DASH UF+3 > 3,1+2");
                                            Console.WriteLine("4. UF+4 > DF+4,3 > DF+4,2,1+2 > DASH UF+3 > 3,1+2");
                                            Console.WriteLine("5. SS+4 > B+3 > 2 > DF+4,2,1+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("While not the most complex character to pick up in the game, Feng Wei isn't necessarily all that easy either, placing him somewhere in the middle-ground,"
                                            + "\nas you will need to utilize mostly everything in his kit to get the most out of him and remain competent in the arena."
                                            + "\nStill, if he checks all your boxes, we recommend sticking with him, as it won't be impossible to learn what he's capable of.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "JUN":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Jun Kazama, The Light of Hope, is a well rounded character with strong poking game and punishing opponents for making mistakes.");
                                Console.WriteLine("\nWhat would you like to learn about Jun? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Jun key moves:");
                                            Console.WriteLine("1. Kagura: SS+4");
                                            Console.WriteLine("2. Tokkei - Misogi: FF+1+2");
                                            Console.WriteLine("3. Ayame: DB+2");
                                            Console.WriteLine("4. Leg Scythe: DB+3");
                                            Console.WriteLine("5. Saiuntsui: UF+3");
                                            Console.WriteLine("6. Sudare Nagashi: WR 1+2");
                                            Console.WriteLine("7. Getsukankyaku: F+4");
                                            Console.WriteLine("8. Saiuntsui: U+3+4");
                                            Console.WriteLine("9. Falling Rain: DB+1+2");
                                            Console.WriteLine("10. Grace: FC DF+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Jun Basic Combos:");
                                            Console.WriteLine("1. DF+2 > F+3,4 > FF+2,3");
                                            Console.WriteLine("2. UF+4,3 > MI F > GU 4 > B+2,1,4");
                                            Console.WriteLine("3. DF+2 > B+4,2 > DF+1 > F+3,2,IO,1,1 > DASH B+2,1F,GU 2");
                                            Console.WriteLine("4. F+2 > 4 > B+4,2 > FF+2B,IO 1 > F+3+4,GU 4 > FF2F,GU 2");
                                            Console.WriteLine("5. DF+2 > DF+4 > DASH F+4 > B+2,1 > F+3,2,IO,F+1+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Jun Kazama has access to several unique stances that help elevate her gameplay and overall combat prowess, making her one of the best options in the game."
                                            + "\nHowever, this comes at a slight cost, as she isn't nearly as easy to pick up and play as you might expect, making her a bit more complex for newcomers."
                                            + "\nBut this doesn't mean she's excruciatingly complex to learn. It just means that you will have to put in a bit more time and effort to get the hang of her.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "LEO":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Leo, The Seeker of Truth, with their basic stances can provide strong punishments for blocked attacks and whiff attacks too.");
                                Console.WriteLine("\nWhat would you like to learn about Leo? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Leo key moves:");
                                            Console.WriteLine("1. Heng Da Bai Tui: F+2,3");
                                            Console.WriteLine("2. Jin Ji Du Li: F+4");
                                            Console.WriteLine("3. Shuang Huan Da: DF+1,2");
                                            Console.WriteLine("4. Sheng Pao: DF+2");
                                            Console.WriteLine("5. Chuan Pao: DF+3");
                                            Console.WriteLine("6. Swallow Step: QCF+3+4");
                                            Console.WriteLine("7. Gui Xi: DF+2+3");
                                            Console.WriteLine("8. Lei Zhang: QCF+1");
                                            Console.WriteLine("9. Lighting Spear: QCF+2,1");
                                            Console.WriteLine("10. Lighting Skypiercer: QCF+2,4");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Leo Basic Combos:");
                                            Console.WriteLine("1. DF+2 > UF+1,1 > DB+2,4");
                                            Console.WriteLine("2. FF+4,3 > F+4 > JJDL 3,4 > FF+2,1+2");
                                            Console.WriteLine("3. DF+2 > F+2 > B+1,1+2D > 1,2 > DASH B+1+2,1+2, QCF+2");
                                            Console.WriteLine("4. UF+2,1 > QCF+3 > B+1,1+2D > 1,2 > DASH B+1+2,1+2, QCF+2");
                                            Console.WriteLine("5. DB+3 > F+3 > F+2 > B+1,1+2D > 1,2 > DASH B+1+2,1+2, QCF+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Leo is relatively easy to pick up and learn compared to the vast majority of the cast."
                                            + "\nStill, getting all of their attacks down will take a bit more time and effort, which can be troublesome for some players"
                                            + "\nOverall, they shouldn't feel impossible to get the hang of after spending time in Practice with them.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "LIDIA":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Lidia, The Warrior Prime Minister, focuses on opponents mistakes and punishing them for it as well with counter hits.");
                                Console.WriteLine("\nWhat would you like to learn about Lidia? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Lidia key moves:");
                                            Console.WriteLine("1. Stalwart Governance: B+1");
                                            Console.WriteLine("2. Chop: D+1");
                                            Console.WriteLine("3. Mid Left Hook Thrust: DF+1,1");
                                            Console.WriteLine("4. Mid Left Hook Thrust to Mid Left Sidekick: DF+1,3");
                                            Console.WriteLine("5. Lightning Seikenzuki: FF+2");
                                            Console.WriteLine("6. Political Storm: F+1+2,3,1+2");
                                            Console.WriteLine("7. Iron Lady: B+1+2");
                                            Console.WriteLine("8. Adjourning Sweep: DB+3");
                                            Console.WriteLine("9. Shin Splinter: DB+4");
                                            Console.WriteLine("10. Lame Duck: D+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Lidia Basic Combos:");
                                            Console.WriteLine("1. FF+4 > DF+4,2 > 1+2");
                                            Console.WriteLine("2. UF+4 > CATF > WOLF 2 > B+2,3 > QCF+2,2+1+2");
                                            Console.WriteLine("3. UF+4 > CATB > FFF+2 > HRS 2 > QCF+2,2,1+2");
                                            Console.WriteLine("4. 3,2 > F+3+4 > HRSF > WOLF 2 > B+2,3 > QCF+1+2,2 > WOLFF > B+3,4,QCF1+2");
                                            Console.WriteLine("5. 3,2 > F+3+4 > HRSF > WOLF2 > B+2,3 > F+4,3,4 > DASH > F+3+4 > HRS3 > FF+4,3");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Lidia Sobieska is a very robust and complex character that is tons of fun to play and learn but not necessarily what we'd call beginner-friendly by any means."
                                            + "\nHer four unique stances allow her to unleash many devastating combos, making her far more technical than you may have thought."
                                            + "\nAgain, she is not friendly to newcomers but is extremely rewarding to learn and execute combos; just be prepared to hit Practice Mode first!");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "LAW":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Law, The Legendary Dragon, focuses on mostly counter hits and rushdown playstle.");
                                Console.WriteLine("\nWhat would you like to learn about Law? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Law key moves:");
                                            Console.WriteLine("1. Shaolin Spin Kicks: 4,3");
                                            Console.WriteLine("2. Tornado Claw: 1+2");
                                            Console.WriteLine("3. Shin Crusher: DB+3");
                                            Console.WriteLine("4. Dragon Storm: B+1,2,2");
                                            Console.WriteLine("5. Body Blow to Dragon Lift: D+2,3");
                                            Console.WriteLine("6. Low Crush: SS+3");
                                            Console.WriteLine("7. Dragon Raise: DF+2");
                                            Console.WriteLine("8. Construct Kick: D+4,3");
                                            Console.WriteLine("9. Dragon's Fury: UF+3");
                                            Console.WriteLine("10. Dragon Hammer: F+1+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Law Basic Combos:");
                                            Console.WriteLine("1. UF+4,3 > FF+2,1,3");
                                            Console.WriteLine("2. DF+2 > B+2,1 > 3+4,4");
                                            Console.WriteLine("3. DF+2 4,U+3 > B+2 > B+2,1 > DASH > 4,3F > DC F+4");
                                            Console.WriteLine("4. UF+4 > UF+1 > 4,U+3 > B+2,1 > DASH 4,3F > DC F+4");
                                            Console.WriteLine("5. UF+4 > 4,U+3 > FF+4 > 2 > FF4 > DASH > 1+2 > DASH > 4,3F > DC F+4");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("When it comes to Marshall Law in Tekken 8, it's hard to gauge his general difficulty, as his quality-of-life updates"
                                            + "\nmake him much more of a threat than ever before. "
                                            + "\nHowever, his execution and overall strategy are still exceptionally challenging to master and get the hang of.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "PAUL":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Paul Pheonix, the Hot-Blooded Destoryer & Strongest in the world, is known for his high damage attacks along with his 50/50 attacks to trick the opponents.");
                                Console.WriteLine("\nWhat would you like to learn about Paul? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Paul key moves:");
                                            Console.WriteLine("1. Phoenix Smasher: QCF+2");
                                            Console.WriteLine("2. Demoman: D+4,2,1+2");
                                            Console.WriteLine("3. Moonfall: ");
                                            Console.WriteLine("4. Stone Lion: ");
                                            Console.WriteLine("5. Kawaragoma: ");
                                            Console.WriteLine("6. Lion Roar: ");
                                            Console.WriteLine("7. Gengetsu: ");
                                            Console.WriteLine("8. Kurenai: ");
                                            Console.WriteLine("9. Phoenix Bone Breaker: ");
                                            Console.WriteLine("10. Enfolding Dragon: ");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Paul Basic Combos:");
                                            Console.WriteLine("1. DF+2 > B+1,2 > F+4");
                                            Console.WriteLine("2. UF+3,4 > DF+1B > SWAY 1+2 > 1+2");
                                            Console.WriteLine("3. DF+2 > 4 > DF+4 > 3,2B > SWAY 1+2 > DASH D+4,2,1+2");
                                            Console.WriteLine("4. DF+2 > 1 > DF+4 > 2 > DASH 3,2B > SWAY 1+2 > DASH 2 > FFF+2");
                                            Console.WriteLine("5. B+3 > 3,2 > 3,2B > SWAY 1+2 > D+4,2,1+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Despite having some Just Frame attacks and access to several movement-based stances,"
                                            + "\nPaul isn't as hard to pick up as you might think but will take a bit"
                                            + "\nmore time and effort to really get a grasp of when compared to other characters on the roster.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "RAVEN":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Raven, the Shadow Agent, has good mobility with his ninja attacks along with 50/50 attacks and unique options for pressure");
                                Console.WriteLine("\nWhat would you like to learn about Raven? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Raven key moves:");
                                            Console.WriteLine("1. Jackknife Elbow: WR+2");
                                            Console.WriteLine("2. Utsusemi Escape/Sixth Sense: B+1+3/F+1+2");
                                            Console.WriteLine("3. Basilisk Fang: D+4");
                                            Console.WriteLine("4. Stinging Low: D+3");
                                            Console.WriteLine("5. Shinobi Cyclone: DB+4");
                                            Console.WriteLine("6. Tornado Destruction: FC DF+3+4");
                                            Console.WriteLine("7. Tartaros: F+2,3");
                                            Console.WriteLine("8. Shinobi Cyclone: LBR D+3");
                                            Console.WriteLine("9. Deadly Talon: LBR 2,2,1+2");
                                            Console.WriteLine("10. Vermillion: LBR FF+3+4");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Raven Basic Combos:");
                                            Console.WriteLine("1. DF+2,3 > B+2,4,2 > F+2,3");
                                            Console.WriteLine("2. FF+3 > DB+2,1 > B+2,3,2 > FF+4");
                                            Console.WriteLine("3. DF+2 > F+3 > FF4 > DB+2,1D > SZ 3,2 > DASH B+2,4,2");
                                            Console.WriteLine("4. UF+3 > DF+2,3 > DB+2,1D > SZ 3,2 > DASH LBR > 2,1,F+3");
                                            Console.WriteLine("5. UF+3+4 > D+3 > DB+2,1 > B+2,4,2 > DASH B+2,4,2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Being a master of Ninjutsu, Raven has many tools at his disposal that can make him very tricky to pick up and play"
                                            + "\nbut extraordinarily fun and rewarding to learn."
                                            + "\nOverall, Raven is one of the more complex characters to pick up and play in Tekken 8, but he is also one of the strongest for that very reason.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "VICTOR":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Victor, Agent of Refined Violence, is known for his counter hit playstyle and punishing opponents for being too aggressive or impatient.\nAlso with his fresh suits inspired by John Wick.");
                                Console.WriteLine("\nWhat would you like to learn about Victor? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Victor key moves:");
                                            Console.WriteLine("1. Asterism of Virtue: FFF+2");
                                            Console.WriteLine("2. Shangri-La: FC+1+2");
                                            Console.WriteLine("3. Failnaught: B+1+2");
                                            Console.WriteLine("4. Llawfrodedd: D+2");
                                            Console.WriteLine("5. Baguette Cut: WR+2");
                                            Console.WriteLine("6. Pearly Gates: WR+1+2");
                                            Console.WriteLine("7. Welcome Sweep: DB+4");
                                            Console.WriteLine("8. Fine Salute: D+4");
                                            Console.WriteLine("9. Eden: 1+2");
                                            Console.WriteLine("10. Durandal: F+1+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Victor Basic Combos:");
                                            Console.WriteLine("1. DF+2 > UF+1,1 > B+3,1");
                                            Console.WriteLine("2. DF+2 > DF+4,2 > IS+2 > 2,1F > PR+22 > IS+1,2,2");
                                            Console.WriteLine("3. DF+2 > DF+4,2 > IS+2 > DFWR+2 > DB+1,1F > PR+2,2 > IS+1,2,2");
                                            Console.WriteLine("4. DF+2 > DF+3,4 > 2,1F > PR+2,2,1 > FF+2 > DASH QCF+2 > IS+1,2,2");
                                            Console.WriteLine("5. FF+2 > DF+3,4 > DF+1+2F > PR+2,2,1 > FF+2 > DASHQCF+2 > IS+1,2,2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Victor Chevalier is a speedy and relentless character in Tekken 8. However, despite this,"
                                            + "\nVictor has access to two stances that can make picking him up a tad challenging for newcomers but nothing too drastic. Though,"
                                            + "\nif you're not used to super intense and in-your-face playstyles, the learning curve will be much steeper.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "ZAFINA":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Zafina, the Mystic Stargazer, has a strong poking game and stong stances that can applying heavy pressure.");
                                Console.WriteLine("\nWhat would you like to learn about Zafina? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Zafina key moves:");
                                            Console.WriteLine("1. Left Right Combo: 1,2");
                                            Console.WriteLine("2. Anzu: 1,3");
                                            Console.WriteLine("3. Ecdysis: 1,4");
                                            Console.WriteLine("4. Bloody Saif - Execution: DF+1,2");
                                            Console.WriteLine("5. Ningishzida: D+1,1");
                                            Console.WriteLine("6. Earwig Pincer: D+3");
                                            Console.WriteLine("7. Acinaces: DB+3");
                                            Console.WriteLine("8. Iskur: D+4,3");
                                            Console.WriteLine("9. Euphrates Cannon: DB+4");
                                            Console.WriteLine("10. Kur: DB+1+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Zafina Basic Combos:");
                                            Console.WriteLine("1. DF+2 > DF+4,2 > F+2,3,4");
                                            Console.WriteLine("2. DF+2 > UF+1 > DF+1 > F+2,3 > SC DF+1 > DASH B+1,1+2");
                                            Console.WriteLine("3. DF+2 > UF+1 > DF+1 > F+2,3 > SC 4 > DASH 2,1,3");
                                            Console.WriteLine("4. DF+2 > FF+2 > DF+1 > F+2,3 > SC 4 > DASH UF+1 > B+1,1+2");
                                            Console.WriteLine("5. DF+2 > FF+2 > DF+1 > DASH DF+1 > F+2,3 > SC DF+1 > FFF+1+2 > TS DF+1");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Zafina has always been a very evasive character, but on top of that,"
                                            + "\nshe’s known for her crazy mixups, along with her three stances and lots of pressure tools.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            //Advanced to learn
                            case "BYRAN":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Bryan Fury, The Harbinger of Chaos, has strong defense, high execution, and slow methodical playstyle plus taunt jet upper combos.");
                                Console.WriteLine("\nWhat would you like to learn about Byran? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Byran key moves:");
                                            Console.WriteLine("1. Cannonball Straight: QCB+1");
                                            Console.WriteLine("2. Knee Strike: F+3");
                                            Console.WriteLine("3. Orbital Heel Kick: UF+4");
                                            Console.WriteLine("4. Hatchet Kick: QCB+3");
                                            Console.WriteLine("5. Chopping Elbow: B+1");
                                            Console.WriteLine("6. Middle Side Kick: 3+4");
                                            Console.WriteLine("7. Mach Kick: FF+4");
                                            Console.WriteLine("8. Smash and Mach Kick: QCB+2,4");
                                            Console.WriteLine("9. High Knee Kick: WR+3");
                                            Console.WriteLine("10. Mach Breaker: FF+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Byran Basic Combos:");
                                            Console.WriteLine("1. UF+4 > D+3+4,2 > FF+2");
                                            Console.WriteLine("2. DF+3 > UF+3 > 3,3,4 ");
                                            Console.WriteLine("3. FB+2 > DASH > QCF+3,4 > B+2,4 > DASH > F+3+4 > B+2,1F > SSP 2,2");
                                            Console.WriteLine("4. UF+4 > 1+2,1 > 1 > B+2,1F > SSP 2,4 > DASH > B+3F > SSP 2,2");
                                            Console.WriteLine("5. DF+3 > DASH > 1+2,1 > 2 > B+2,1F > SSP 2,2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Bryan is a unique and rewarding character, boasting a large amount of CH launchers, extremely high combo damage, space control and keepout, and an unorthodox, but strong poking game."
                                            + "\nBryan can be difficult to learn and play, but he is a highly rewarding character who rewards the player for good timing, keepout, and an optimized combo game."
                                            + "\nPlay Bryan if you like big hits, fishing for counter hits, and putting on pressure both up close and at range");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "JIN":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Jin Kazama, The Lighting of Fate, has a well rounded playstyle along with good mobility with wavedashing and good poking, counter hitting, and poking games.");
                                Console.WriteLine("\nWhat would you like to learn about Jin? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Jin key moves:");
                                            Console.WriteLine("1. Wind Hook Fist: FDDF+2");
                                            Console.WriteLine("2. Shun Masatsu: B+2");
                                            Console.WriteLine("3. Demon's Paw: FF+2");
                                            Console.WriteLine("4. Battery Heel: FF+4");
                                            Console.WriteLine("5. Front Thrust Kick: F+4");
                                            Console.WriteLine("6. Right Sweep: D+4");
                                            Console.WriteLine("7. Right Spinning Axe Kick: DF+4");
                                            Console.WriteLine("8. Left Axe Kick: FF+3");
                                            Console.WriteLine("9. Tanden Nidan-uchi: F+3,1");
                                            Console.WriteLine("10. Shun Masatsu: B+2,1");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Jin Basic Combos:");
                                            Console.WriteLine("1. UF+4 > B+1,2 > DB+2,2,3");
                                            Console.WriteLine("2. FF+3 > B+3F > ZN U+1 > DB+2,2,3");
                                            Console.WriteLine("3. UF+4 > DF+2,4 > 3,1F > ZEN 2 > B+3F > ZEN U+1 > F+3+4 > ZEN 1,3");
                                            Console.WriteLine("4. UF+4 > B+3 > 3,1,F+2 > DF+2,3 > B+3F > U+1 > B+3,2");
                                            Console.WriteLine("5. FF+3 > BSTP+2 > B+3,F+1 > BF+2,3F > U+1 > DASH 2,4F > ZEN+4");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Jin is an excellent choice for newcomers but has a high skill ceiling due to his ability to land Electrics. While he's not reliant on them,"
                                            + "\nyou should aim to perfect them, as they will lead to higher damage outputs and"
                                            + "\ntheir properties will open the door for longer combo routes and options in general!");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "KAZUYA":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Kazuya Mishima, The Cold-Blooded Oppressor, has a strong mixup playstyle along with mobility with wavedashing and hell sweep stance and is a high execution based character.");
                                Console.WriteLine("\nWhat would you like to learn about Kazuya? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Kazuya key moves:");
                                            Console.WriteLine("1. Wind God Fist: FDDF+2");
                                            Console.WriteLine("2. Abolishing Fist: DF+2");
                                            Console.WriteLine("3. Slaughter Hook/Slaughter High Kick: DF+1,2/DF+1,4");
                                            Console.WriteLine("4. Left Splits Kick: FF+3");
                                            Console.WriteLine("5. Parricide Fist: FDDF+1+2");
                                            Console.WriteLine("6. Goutsuiken: DB+1,2");
                                            Console.WriteLine("7. Right Splits Kick: F+4");
                                            Console.WriteLine("8. Flash Tornado: B+4");
                                            Console.WriteLine("9. Nejiri Uraken: D+1+2");
                                            Console.WriteLine("10. Stature Smash: DB+4");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Kazuya Basic Combos:");
                                            Console.WriteLine("1. FF+3 > DF+1,DF+2 > FF+2");
                                            Console.WriteLine("2. WGS+2 > F+2 > B+2,2,1+2");
                                            Console.WriteLine("3. FF+3 > 3,1,4 > DF+1,DF+2 > DASH 3,1DF > WGS 3");
                                            Console.WriteLine("4. FF+3 > SSR 3 > B+2,2 > DF+1,DF+2 > DASH 3,1DF > WGS 3");
                                            Console.WriteLine("5. WR+1,2 > DASH DF+1+2 > B+2,2 > B+2,2,1+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Kazuya is not a beginner-friendly character as he does rely heavily on \nlanding Electric Attacks, Wave Dashing, and the new Heat mechanics"
                                            + "\nHowever, that doesn't make him impossible to learn. It just means it will take"
                                            + "\na bit more effort to feel comfortable with him than some of the other members on the roster!");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "REINA":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Reina, The Purple Lighting, most like the other mishima characters has greay mobility with wavedashing along with strong poking and stance mixups with her own unique twist.");
                                Console.WriteLine("\nWhat would you like to learn about Reina? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Reina key moves:");
                                            Console.WriteLine("1. Flash Punch Combo: 1,1,2");
                                            Console.WriteLine("2. Muso Tensho: DF+1,1");
                                            Console.WriteLine("3. Kamadhatu Splits Kick: F+4");
                                            Console.WriteLine("4. Muso Basara: DF+1,2");
                                            Console.WriteLine("5. Sin Smiter: B+2");
                                            Console.WriteLine("6. Eisaimon: DB+2");
                                            Console.WriteLine("7. Ten Chuten-geri: FFF+3");
                                            Console.WriteLine("8. Un Tobi Kaijo-geri: FFF+4");
                                            Console.WriteLine("9. Wind God Fist: DF+3,2");
                                            Console.WriteLine("10. Stonehead: UF+1+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Reina Basic Combos:");
                                            Console.WriteLine("1. UF+4 > 2,2,2,2");
                                            Console.WriteLine("2. DF+3 > 2 > 3,2 > 2,2,2,2");
                                            Console.WriteLine("3. DF+2 > DF+2 > DF+1,1 > F+2,3F > SI 1+2 > HW 3,4");
                                            Console.WriteLine("4. DF+2 > B+2 > FF+3+4 > DF+1,1 > F+2,3F > DF+1F > SI 1,QCF+2");
                                            Console.WriteLine("5. UF+4 > FF+3+4 > DF+1,1 > F+2,3F > DF+1F > SI 1,QCF+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Reina is an extremely overwhelming player to both play against and learn, \nand her many stances and abilities that build off them are prime examples of that."
                                            + "\nWhile she is one of the more unique and fun characters to play, \nyou will have to invest lots of time and effort to be proficient with her,"
                                            + "\nand even then, you would likely only be scratching the surface of what she can do.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "HEIHACHI":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Heihachi Mishima, The Resurrected King of Iron Fist, has high damage with his attacks and combos along with mixups from his hell sweep stance.");
                                Console.WriteLine("\nWhat would you like to learn about Heihachi? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Heihachi key moves:");
                                            Console.WriteLine("1. Right Splits Kick: F+4");
                                            Console.WriteLine("2. Wind God Fist: FDDF+2");
                                            Console.WriteLine("3. Demon God Fist: FF+2");
                                            Console.WriteLine("4. Left Splits Kick: FF+3");
                                            Console.WriteLine("5. Lightning Crush: F+3");
                                            Console.WriteLine("6. Iron Hand: QCF+2");
                                            Console.WriteLine("7. Hell Axle: UF+3,4");
                                            Console.WriteLine("8. Wind Slicer: UF+4");
                                            Console.WriteLine("9. Bone Splinter Kick: FDDF+3");
                                            Console.WriteLine("10. Indra's Kick: B+4");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Heihachi Basic Combos:");
                                            Console.WriteLine("1. FF+3 > 4 > UF+1");
                                            Console.WriteLine("2. FDDF+2 > F+3 > B+1,4 > FDDF+4,4,3");
                                            Console.WriteLine("3. FF+3 > FDDF+2 > F+3 > B+1,4 > UF+3,4 > UF+2,1");
                                            Console.WriteLine("4. UF+3,4 > F+3D > WGK DF+4,4,3 > F+3D > WGK 2 > DASH > B+2 HOLD > QCF+2");
                                            Console.WriteLine("5. CR DF+2 > F+3 > DF+1 > F+3D > WGK 2 > UF+3,4 > UF+2,1");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Heihachi is a rushdown Mishima-style character who excels at pressuring opponents and wearing down their defense with some of the strongest mid attacks in the game."
                                            + "\nHis combo damage is extremely high, he has tremendous chip damage potential in Heat, and his new stance options grant amazing mixup opportunities.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "LEE":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Lee Chaolan, The Silver Haired-Demon, has a strong counter hitting game where he thrives in the mistakes the opponents make, amazing wall carry, and flashy combos.");
                                Console.WriteLine("\nWhat would you like to learn about Lee? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Lee key moves:");
                                            Console.WriteLine("1. Silver Heel: B+4");
                                            Console.WriteLine("2. Silver Uppercut: DF+2");
                                            Console.WriteLine("3. Pulse Blast: FF+3");
                                            Console.WriteLine("4. Silver Low: D+3");
                                            Console.WriteLine("5. Deadly Edge: FF+4");
                                            Console.WriteLine("6. Right Cross to Revolution Zwei: 2,2,3");
                                            Console.WriteLine("7. Fabulous Whip: DF+4,4");
                                            Console.WriteLine("8. Gut Polisher: D+2");
                                            Console.WriteLine("9. Spin Kick Somersault Combo: 4,3,4");
                                            Console.WriteLine("10. Jostle Wolf: FF+1");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Lee Basic Combos:");
                                            Console.WriteLine("1. UF+4 > F+4,1 > FF+3");
                                            Console.WriteLine("2. DF+2 > D,U+3 > B+2F > F+4,1 > FF+3");
                                            Console.WriteLine("3. DF+2 > B+2,4,3 > F+4,1 > DASH DF+3,2,3");
                                            Console.WriteLine("4. DF+2 > 4,U+3 > B2F > F+4,1 > DASH B+1,1+2");
                                            Console.WriteLine("5. DF+2 > B+2,4,3 > B+2F > F+4,1 > DASH DF+3,2,3");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Lee Chaolan requires a tremendous amount of patience to learn, \nas many of his moves have additional properties when executed with perfect timing."
                                            + "\nIn a sense, playing Lee is like playing a rhythm game"
                                            + "\nas you will need to nail his combos with a specific pattern and flow every single time, which can be very tricky.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "DVJ":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Devil Jin, The Black Wings Of Ruin, has good space control along with mobility with his wings.");
                                Console.WriteLine("\nWhat would you like to learn about Devil Jin? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Devil Jin key moves:");
                                            Console.WriteLine("1. Wind God Fist: FDDF+2");
                                            Console.WriteLine("2. Wraith Kick: UF+4");
                                            Console.WriteLine("3. Reaper's Scythe: UF+3");
                                            Console.WriteLine("4. Double Lift Kick: D+3+4");
                                            Console.WriteLine("5. Broken Plate: D+3");
                                            Console.WriteLine("6. Malicious Mace: DB+2");
                                            Console.WriteLine("7. Spinning Demon Hellfire Beam: FDDF+4,1+2");
                                            Console.WriteLine("8. Bloody Glaive: DF+2");
                                            Console.WriteLine("9. Demon's Paw: FF+2");
                                            Console.WriteLine("10. Organ Wrecker: WR+3");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Devil Jin Basic Combos:");
                                            Console.WriteLine("1. D+3+4 > 3,1,2 > UF+1 > MC+4,2,1U");
                                            Console.WriteLine("2. D+3+4 > 3,1,2 > UF+1 > MC+4,2,1+2");
                                            Console.WriteLine("3. D+3+4 > B+2,1 > DASH > U+1+2 > UF+1 > MC+4,2,1+2");
                                            Console.WriteLine("4. U+4U > FLY+4 > B+2,1 > UF+1 > MC+4,2,1+2");
                                            Console.WriteLine("5. WS+2 > DASH > U+1+2 > 3,1 > BF+2,1,2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Devil Jin has access to several stances, which can be a bit hard to master."
                                            + "\nWhile his new 'Mourning Crow Stance' makes him far easier to play than ever before, "
                                            + "\nthe fact that you still have to utilize his 'Wind God Step' to execute some of his better offensive options makes him a poor choice for newcomers.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "HWOARANG":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Hwoarang, The Blood Talon, has flexible and creative offensive tools and attacks with his stances along with overwhelming rushdown as well.");
                                Console.WriteLine("\nWhat would you like to learn about Hwoarang? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Hwoarang key moves:");
                                            Console.WriteLine("1. Left Plasman Blade: B+3");
                                            Console.WriteLine("2. Nose Bleeder: B+4");
                                            Console.WriteLine("3. Ankle Biter: DB+4,4");
                                            Console.WriteLine("4. Right Hook Kick: F+4");
                                            Console.WriteLine("5. Double Claymore: DF+3,4");
                                            Console.WriteLine("6. Shark Step: QCF");
                                            Console.WriteLine("7. Right Stance: 3+4");
                                            Console.WriteLine("8. Left Flamingo: F+3");
                                            Console.WriteLine("9. Hunting Hawk: UF+3,4,3");
                                            Console.WriteLine("10. Air Raid: UF+4,4,4");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Hwoarang Basic Combos:");
                                            Console.WriteLine("1. DF+2 > U+3 > LF 2 > RS 3 > D+4,4 > DASH UF+3,4,3");
                                            Console.WriteLine("2. DF+2 > U+3 > LF 1 > U+3 > UF+3+4F > UF+4 > FF+3+4 > RS F+3 > LF 4,3");
                                            Console.WriteLine("3. DF+2 > F+4 > RF 3,4 > D+4,4 > DASH UF+3,4,3");
                                            Console.WriteLine("4. DF+2 > F+4 > 3,4 > UF+3+4F > LF UF+4 > F+3+4 > RS 3,4 > DASH UB+3");
                                            Console.WriteLine("5. B+3 > F+4 > B+3 > DASH 2,4 > 2,3 > DASH 3+4 > F+3 > 4,3");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Hwoarang looks like he would be the most challenging character to play in Tekken 8, boasting a whopping four stances to work with,"
                                            + "\nall leading to unique moves and combo routes, enabling him to set up all kinds of pressure on his opponent."
                                            + "\nHwoarang is a perfect example of a character anyone can pick up, play, and do some very cool stuff with by simply pressing and mashing buttons.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "KING":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("King, The Anger of the Beast, has a excellent throw game that can overwhelm opponents along with being unorthodox with throw mixups and pressure");
                                Console.WriteLine("\nWhat would you like to learn about King? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("King key moves:");
                                            Console.WriteLine("1. Lay Off: FF+1+2");
                                            Console.WriteLine("2. Jaguar Hook: FF+1");
                                            Console.WriteLine("3. Rolling Sobat: F+4");
                                            Console.WriteLine("4. Beast Elbow: FF+2");
                                            Console.WriteLine("5. Guillotine Drop: B+3,1+2");
                                            Console.WriteLine("6. Brain Chop: DB+2");
                                            Console.WriteLine("7. Front Kick to DDT: F+3,1+2");
                                            Console.WriteLine("8. Stomp: D+3");
                                            Console.WriteLine("9. Crouching Low Kick: DB+3");
                                            Console.WriteLine("10. Elbow Sting: DF+1,2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("King Basic Combos:");
                                            Console.WriteLine("1. UF+4 > 2+4 > F+2,1");
                                            Console.WriteLine("2. DB+2 > DF+4,3 > 2 > B+1,2 > FFF+2+4");
                                            Console.WriteLine("3. UF+4 > F+3 > DF+4,3 > B+1,2 > FFF+1+2");
                                            Console.WriteLine("4. D+1+2 > 4 > F+1+2 > DF+4,3 > B+1,2 > FFF+2+4");
                                            Console.WriteLine("5. UF+4 > 4 > DASH DF+4,3 > 1,2 > UF+3+4F > FFF+2+4");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Despite King having the longest Move List in Tekken 8, he is one of the most accessible characters in the game,"
                                            + "\nmaking him one of the best choices for newcomers. While he has access to many grabs and unique abilities,"
                                            + "\nyou can get far by only utilizing a fraction of what's available to him, which is what makes him so approachable in the first place.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "XIAOYU":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Ling Xiaoyu, The Dancing Pheonix, is a stance heavy character that has strong poking tools and a lot of creativity with applying pressure.");
                                Console.WriteLine("\nWhat would you like to learn about Xiaoyu? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Xiaoyu key moves:");
                                            Console.WriteLine("1. Storming Flower: DB+1");
                                            Console.WriteLine("2. Seven Star Fist: B+2,2");
                                            Console.WriteLine("3. Bolting Rabbit: UF+3");
                                            Console.WriteLine("4. Cloud Kick: 3");
                                            Console.WriteLine("5. Moon Swallow: DB+2,3");
                                            Console.WriteLine("6. Phoenix Tail: DB+3");
                                            Console.WriteLine("7. Nutcracker: DB+4");
                                            Console.WriteLine("8. Peacock Kick: B+3");
                                            Console.WriteLine("9. Moonhare Palm: B+4,1");
                                            Console.WriteLine("10. From the Ashes: UB+3");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Xiaoyu Basic Combos:");
                                            Console.WriteLine("1. B+1+2 > F+3,2,4 > DB+1");
                                            Console.WriteLine("2. UF+3 > DF+2 > F+3,1 > RD 1,2 > FFF+3 > PX 1+2");
                                            Console.WriteLine("3. 3 > FF+3 > RD DF+4 > F+3,1,4 > DASH DF+2,3");
                                            Console.WriteLine("4. UF+3 > PX 1 > WR+2 > RD 1,2 > FFF+3 > PX 1+2");
                                            Console.WriteLine("5. B+1+2 > DB+2 > RD 1,2 > B+2 > RD 2,2 > 4");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Although Xiaoyu has multiple stances, Xiaoyu is immensely fun to learn and can be pretty deadly in the right hands. "
                                            + "\nWhile she isn't the most complex character to learn in the game, she's definitely not the easiest, "
                                            + "\nso be prepared to hit the lab with her to learn everything she's capable of!");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "NINA":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Nina Williams, The Silent Assassin, has insane rushdown methods along with being a execution character with her combos to her throws as well.");
                                Console.WriteLine("\nWhat would you like to learn about Nina? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Nina key moves:");
                                            Console.WriteLine("1. Biting Kiss Shot: 1,2,1,1+2");
                                            Console.WriteLine("2. Uppercut to Jab: DF+1,2");
                                            Console.WriteLine("3. Creeping Snake to Right High Kick: DF+3,2,4");
                                            Console.WriteLine("4. Creeping Snake to Geyser Cannon: DF+3,2,3");
                                            Console.WriteLine("5. Blonde Bomb: F+1+2");
                                            Console.WriteLine("6. Wipe the Floor: DF+4");
                                            Console.WriteLine("7. Siren's Kiss: F+3");
                                            Console.WriteLine("8. Head Ringer: 3,4");
                                            Console.WriteLine("9. Double Whip: F+4,4");
                                            Console.WriteLine("10. Hellbringer: QCF+1");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Nina Basic Combos:");
                                            Console.WriteLine("1. DF+2 > B+1,4 > F+1+2");
                                            Console.WriteLine("2. DF+2 > UF+4 > DF+3,2 > B+3+4,4 > DS 4,2,1+2");
                                            Console.WriteLine("3. DF+2 > UF+4 > UF+3 > DF+3,2 > B+3+4,3 > DS 4,3,1+2");
                                            Console.WriteLine("4. DF+2 > UF+4 > UF+3 > DF+3,2F > DF 1 > B+1+4 > DASH UF+4 > F+1+2");
                                            Console.WriteLine("5. DF+2 > UF+4 > UF+3 > DF+3,2B > SWAY DB+2 > F+2,1,3 > DASH DS 4,3,1+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Nina Williams isn't exactly what we'd call an easy or accessible character to play by any stretch, \nas she relies heavily on her movement and offensive options, which can be tricky and complex to learn and master."
                                            + "\nSo, if movement or being overly aggressive isn't your strong suit or focus, Nina will be excruciatingly challenging to pick up."
                                            + "\nHowever, if you want to stick with her, learn what she can do, \nand dial in her quirky gameplay, she is easily one of the most rewarding characters in the game!");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "STEVE":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Steve Fox, The Counter-Punching Paragon, thrives when an opponent makes a mistake with his excellent counter hitting offense and along with confusing opponents with his many stances.");
                                Console.WriteLine("\nWhat would you like to learn about Steve? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Steve key moves:");
                                            Console.WriteLine("1. Quick Hook: B+1");
                                            Console.WriteLine("2. Crescent Hook: DF+2");
                                            Console.WriteLine("3. Swaying Hook: FS B+2");
                                            Console.WriteLine("4. Dreadnought Uppercut: U+2");
                                            Console.WriteLine("5. Fly Swatter: FS 2");
                                            Console.WriteLine("6. Eraser: FFF+2");
                                            Console.WriteLine("7. Knee Blaster: D+1");
                                            Console.WriteLine("8. Patella Smash: PB D+1");
                                            Console.WriteLine("9. Bounty Hunter: UB+2");
                                            Console.WriteLine("10. Foot Stomp Right Hook: DB+3,2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Steve Basic Combos:");
                                            Console.WriteLine("1. UF+2 > DI 1 > DF+1,2,1B > FS 1,2 > DASH DL 1,2 > LH 2");
                                            Console.WriteLine("2. UF+2 > F+3,1 > DF+1,2,1B > F+3DB+1 > F+2,2 > 2 > DASH 3,1,2 > 2");
                                            Console.WriteLine("3. DI 2 > DB+2 > F+3,1 > DF+1,2,1 > F+2,2 > 2 > DASH 3,1,2 > 2");
                                            Console.WriteLine("4. DI 2 > DI 2 > F+3,1 > DF+2,F+3,DB+1 > F+2,2 > 2 > DASH 3,1,2 > 2");
                                            Console.WriteLine("5. DI 2 > DI 2 > DF+2,2,1F > 1,2 > DASH 3,1,2 > 2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("While Steve Fox is an excellent character for all boxing fans, he may not be the best character for beginners. \nWith access to nine unique stances, all of which have various moves within them,"
                                            + "\nSteve Fox can be exhausting to learn and fight against, making him one of the most complex characters to master in the game."
                                            + "\nHowever, the upside to this is that he is incredibly rewarding to learn correctly, \nwhich will undoubtedly keep you engaged and focused when learning his capabilities.");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            case "YOSHIMITSU":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Yoshimitsu, The Mechanized Space Ninja, has an unorthodox and creative offensive with his many stances and unblockable moves.");
                                Console.WriteLine("\nWhat would you like to learn about Yoshimitsu? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                                {
                                    switch (tk8_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Yoshimitsu key moves:");
                                            Console.WriteLine("1. Rising Knee: UF+3");
                                            Console.WriteLine("2. Basic Uppercut: DF+2");
                                            Console.WriteLine("3. Reverse Cartwheel: FF+3+4");
                                            Console.WriteLine("4. Toita Daoshi: F+4");
                                            Console.WriteLine("5. Kincho: 1+2");
                                            Console.WriteLine("6. Meditation: 3+4");
                                            Console.WriteLine("7. Flea: D+1+2");
                                            Console.WriteLine("8. Indian: D+3+4");
                                            Console.WriteLine("9. Mutou no Kiwami: B+1+2");
                                            Console.WriteLine("10. Manji Dragonfly: U+1+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 2:
                                            Console.WriteLine("Yoshimitsu Basic Combos:");
                                            Console.WriteLine("1. DF+2 > F+2,1 > D+2,2,2");
                                            Console.WriteLine("2. DF+2 > D+2,2F > DF+1 > D+2,2,2 > DASH MNK 3,2,1+2");
                                            Console.WriteLine("3. DF+2 > DASH 1+4 > D+2,2 > DF+1,2,1 > DASH 1+4 > DASH D+2,2");
                                            Console.WriteLine("4. UF+3 > 3,2 > MD 2 > MD 2,4 > DASH 1+4 > DASH D+2,2,2");
                                            Console.WriteLine("5. DF+2 > D+2,2F > DF+1,2,1 > DASH 3,2,1+2");
                                            repeatcharacter = false;
                                            repeatcode = false;
                                            break;

                                        case 3:
                                            Console.WriteLine("Yoshimitsu offers a wide range of moves from each of his six different stance, only adding to the complexity of his gameplay."
                                            + "\nWith that said, however, he is easily one of the most rewarding and fun characters"
                                            + "\nto play if you can take losing in stride and use it to learn and improve!");
                                            repeatcode = false;
                                            repeatcharacter = false;
                                            break;

                                        default:
                                            Console.WriteLine("Please select the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                            default:
                                Console.WriteLine("\nPlease type correct character name.");
                                repeatcode = true;
                                repeatcharacter = false;
                                break;
                        }
                    }
                }

            }

            if (tk8character == 2)
            {

                Random tk8random = new Random();
                int tk8randomcheck = tk8random.Next(tk8.Count);
                string tk8randomconfirmed = tk8[tk8randomcheck];
                tk8randomconfirmed = tk8randomconfirmed.ToUpper();

                bool repeatcharacter = true;
                while (repeatcharacter)
                {
                    switch (tk8randomconfirmed)
                    {
                        //Easy to learn
                        case "KUMA":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Kuma is the joke character of tekken 8 with good range, mixups, and gimmicks with their stances.");
                            Console.WriteLine("\nWhat would you like to learn about Kuma? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Kuma key moves:");
                                        Console.WriteLine("1. Bear jab: 1 which can lead to 1,1,1 combo launcher");
                                        Console.WriteLine("2. Anger hook: BF 2");
                                        Console.WriteLine("3. Bear Slash: B 1");
                                        Console.WriteLine("4. Falling Bear: FF 1+2");
                                        Console.WriteLine("5. Demon Uppercut: FF 2");
                                        Console.WriteLine("6. Bear Hopkick: UF 3 can also lead to UF 3,4,1+2 combo");
                                        Console.WriteLine("7. Rabid Bear: FFF 1+2");
                                        Console.WriteLine("8. Spinning Kuma: DB 4");
                                        Console.WriteLine("9. Kuma Musou: DB 1,2");
                                        Console.WriteLine("10. Grizzly Rampage: DF 1,2,1+2");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Kuma Basic Combos:");
                                        Console.WriteLine("1. DF+2,1 > B+2,2,1 > F 1+2,1+2");
                                        Console.WriteLine("2. F 1+2,1+2 > U+2 > B+2,2,1");
                                        Console.WriteLine("3. DF 2,1 > F+4 > B+2,1 > F 1+2,1+2 > U+2 > B+1");
                                        Console.WriteLine("4. DF 2,1 > B+2,2,1 > U+2 > QCF+2,1");
                                        Console.WriteLine("5. DF+2,1 > B+,2,2,1 > U+2 > HEAT > HEAT SMASH");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "ALISA":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Alisa is a well rounded character with strong/simple poking and neutral.");
                            Console.WriteLine("\nWhat would you like to learn about Alisa? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Alisa key moves:");
                                        Console.WriteLine("1. Clockwork Spring Middle: WR+3,3/WR+3,D+3");
                                        Console.WriteLine("2. Transmission: B+1+2");
                                        Console.WriteLine("3. Hertz Blade - Diable: DS F+1+2");
                                        Console.WriteLine("4. Shredder: DS 1");
                                        Console.WriteLine("5. Hertz Blade: DS F+1");
                                        Console.WriteLine("6. Quick Trim: 3,2");
                                        Console.WriteLine("7. Thruster Drill: DBB 1+2");
                                        Console.WriteLine("8. Optimizer: D+4, 1+2");
                                        Console.WriteLine("9. Image Cutter: UF+2");
                                        Console.WriteLine("10. Dual Session: F+2,1");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Alisa Basic Combos:");
                                        Console.WriteLine("1. DF+2 > B+2,3 > F+4,1,4");
                                        Console.WriteLine("2. DF+2 > DF+1,1 > B+2,3 > B+4,3");
                                        Console.WriteLine("3. DF+2 > UF+1,F+4 > F+1");
                                        Console.WriteLine("4. UF+4,4 > WR+1,2,3 > UF+1,F+4 > F+1");
                                        Console.WriteLine("5. UF+4,4 > F+2 > DF+1,1 > B+2,3 > 1,2,2");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "ASUKA":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Asuka has a strong keepout game along with strong and unique oki.");
                            Console.WriteLine("\nWhat would you like to learn about Asuka? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Auska key moves:");
                                        Console.WriteLine("1. Mist Palm Thrust: SS+2");
                                        Console.WriteLine("2. Swallow Vortex: DB+1+2");
                                        Console.WriteLine("3. Heart Stopper: B+4");
                                        Console.WriteLine("4. Sashiro: D+1+2");
                                        Console.WriteLine("5. White Mountain: DF+2+3");
                                        Console.WriteLine("6. Ryunntsui: 3+4");
                                        Console.WriteLine("7. Leaping Spin Kick: FF+4");
                                        Console.WriteLine("8. Double Lift Kicks: D+3+4");
                                        Console.WriteLine("9. Exorcisor: F+1+2");
                                        Console.WriteLine("10. Naniwa Gusto: U+1+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Asuka Basic Combos:");
                                        Console.WriteLine("1. F+2 > FF2+3 > DB+1,4 > FF+4 > FF+2,1+2 > 1+2");
                                        Console.WriteLine("2. UF+4 > FF+2,3 > DB+1,4 > FF+4 > FF+1,1+2 > 1+2");
                                        Console.WriteLine("3. WR+3 > FF+2,3 > DB+1,4 > FF+4 > FF+1,1+2 > 1+2");
                                        Console.WriteLine("4. DB+2 > FF+2,3 > DB+1,4 > FF+4 > FF+2,1+2 > 1+2");
                                        Console.WriteLine("5. DF+2 > FF+2,3 > DB+1,4 > FF+4 > FF+2,1+2 > 1+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "CLAUDIO":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Claudio is a unique install character with a strong hopkick option");
                            Console.WriteLine("\nWhat would you like to learn about Claudio? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Claudio key moves:");
                                        Console.WriteLine("1. Vanishing Storm: B+1");
                                        Console.WriteLine("2. Luxuria: SS+4");
                                        Console.WriteLine("3. Dispel Magic/Dispel Force: DF+3,1/DF+3,2");
                                        Console.WriteLine("4. Invidia: FF+4");
                                        Console.WriteLine("5. Sky Slash Nova: UF+4");
                                        Console.WriteLine("6. Sky's Arc: DF+1,2");
                                        Console.WriteLine("7. Cross Arm Impact Burst: F+1+2,1+2");
                                        Console.WriteLine("8. Chaos Fist: DF+2");
                                        Console.WriteLine("9. Acedia: DB+3");
                                        Console.WriteLine("10. Judgment Claw: Move_input");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Claudio Basic Combos:");
                                        Console.WriteLine("1. UF+4 > B+2 > FF+4 > B+3 > F+2 > B+4,2");
                                        Console.WriteLine("2. UF+4 > FF+4 > B+3 > DF+3,2 > B+4,4 > FFF+2");
                                        Console.WriteLine("3. DF+1,2 > FF+4 > B+3 > UF 3+4 > DB 1+2 > FFF+2");
                                        Console.WriteLine("4. UF+4 > FF+4 > B+3 > B+2 > FF+4 > 3,2");
                                        Console.WriteLine("5. UF+4 > FF+4 > B+3 > B+3 > UF 3+4 > DB 1+2 > FFF+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "CLIVE":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Clive is a guest character with good space control and final fantasy character");
                            Console.WriteLine("\nWhat would you like to learn about Clive? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Clive key moves:");
                                        Console.WriteLine("1. Body Jab: DF+1");
                                        Console.WriteLine("2. Prominence: F+1+2");
                                        Console.WriteLine("3. Flame Bash: 1+2");
                                        Console.WriteLine("4. Blue Bolt: B+1");
                                        Console.WriteLine("5. Cold Cyclone: DB+4");
                                        Console.WriteLine("6. Pile Driver: D+1+2");
                                        Console.WriteLine("7. Door Knocker: DF+4");
                                        Console.WriteLine("8. Stone Smite: SS+1+2");
                                        Console.WriteLine("9. Windup: B+1+2");
                                        Console.WriteLine("10. Tidal Surge: DB+1");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Clive Basic Combos:");
                                        Console.WriteLine("1. DF+2 > DB 1+2,1 > UF+2,2 > B+2F > PS 2,2");
                                        Console.WriteLine("2. DF+2 > DF+1,4 > DB 1+2,1 > UPD 22 > DASH DF+1,2F > PS 1");
                                        Console.WriteLine("3. DF+2 > DB 1+2,1 > UPD 3 > DASH DF+1,4,3 > WOL 2");
                                        Console.WriteLine("4. F+3 > D+1 > WR+4 > 1 > DASH DF+1,4,3 > WOL 2");
                                        Console.WriteLine("5. SS 1+2 > DF+1,4 > DB 1+2,1 > UPD 2,2 > DASH B+2F > PS 1,2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "JACK-8":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Jack-8 has good range with his attacks and rushdown pressure as well.");
                            Console.WriteLine("\nWhat would you like to learn about Jack-8? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Jack-8 key moves:");
                                        Console.WriteLine("1. Jackhammer: FF+1");
                                        Console.WriteLine("2. Pinpoint Assault: F+2");
                                        Console.WriteLine("3. Jab Elbow Smash: 2,1 (doing 2,1,2 can be a launcher)");
                                        Console.WriteLine("4. Granite Stomping: FF+3");
                                        Console.WriteLine("5. Impact Driver: F+1,1");
                                        Console.WriteLine("6. Drilling Engine/Piston Gun Blaster: F+1,2,1/F+1,2,2");
                                        Console.WriteLine("7. F+3,2/F+3,1+2: Two-Step Die/Machine Press");
                                        Console.WriteLine("8. Machinegun Blast: DB+1");
                                        Console.WriteLine("9. Barrel Jacket Hammer: UB+1+2");
                                        Console.WriteLine("10. Rolling Death Crusher: F+1+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Jack-8 Basic Combos:");
                                        Console.WriteLine("1. DF+2 > DF+1,1 > B+3,2,2");
                                        Console.WriteLine("2. 1+2 > FF+2 > B+1 > B+3,2D > GAHL F+1");
                                        Console.WriteLine("3. DF+2 > B+4 > B+3,2 > F+1,2,1 > RUN F+1,2,1");
                                        Console.WriteLine("4. DF+2,1D > GAHL 2 > FF+2 > B+3,2D > GAHL F+1");
                                        Console.WriteLine("5. DF+2,1(Hold 1) > FF+2 > B+1 > F+1,2,1 ");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "PANDA":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Panda is the joke character of tekken 8 with good range, mixups, and gimmicks with their stances.");
                            Console.WriteLine("\nWhat would you like to learn about Panda? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Panda key moves:");
                                        Console.WriteLine("1. Bear jab: 1 which can lead to 1,1,1 combo launcher");
                                        Console.WriteLine("2. Anger hook: BF 2");
                                        Console.WriteLine("3. Bear Slash: B 1");
                                        Console.WriteLine("4. Falling Bear: FF 1+2");
                                        Console.WriteLine("5. Demon Uppercut: FF 2");
                                        Console.WriteLine("6. Bear Hopkick: UF 3 can also lead to UF 3,4,1+2 combo");
                                        Console.WriteLine("7. Rabid Bear: FFF 1+2");
                                        Console.WriteLine("8. Spinning Kuma: DB 4");
                                        Console.WriteLine("9. Kuma Musou: DB 1,2");
                                        Console.WriteLine("10. Grizzly Rampage: DF 1,2,1+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Panda Basic Combos:");
                                        Console.WriteLine("1. DF+2,1 > B+2,2,1 > F 1+2,1+2");
                                        Console.WriteLine("2. F 1+2,1+2 > U+2 > B+2,2,1");
                                        Console.WriteLine("3. DF 2,1 > F+4 > B+2,1 > F 1+2,1+2 > U+2 > B+1");
                                        Console.WriteLine("4. DF 2,1 > B+2,2,1 > U+2 > QCF+2,1");
                                        Console.WriteLine("5. DF+2,1 > B+,2,2,1 > U+2 > HEAT > HEAT SMASH");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "LARS":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Lars is a rushdown character with strong stance mixups");
                            Console.WriteLine("\nWhat would you like to learn about Lars? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Lars key moves:");
                                        Console.WriteLine("1. Ring Current: 2,1");
                                        Console.WriteLine("2. Bow Shock: DE+3");
                                        Console.WriteLine("3. Elbow Corona: FF+1+2");
                                        Console.WriteLine("4. Double Pulse: FF+4,3");
                                        Console.WriteLine("5. Shadow Cutter: DB+4");
                                        Console.WriteLine("6. Lighting Screw: UF+3");
                                        Console.WriteLine("7. Surge Blast: FF+2");
                                        Console.WriteLine("8. UF+4: Storm Axle");
                                        Console.WriteLine("9. Ark Blast: F+1+2");
                                        Console.WriteLine("10. X-Ray: 1+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Lars Basic Combos:");
                                        Console.WriteLine("1. UF+4 > DE+2 > DF+3,DFDE > F+2,1,SE 1+2 > F2,1,SE 3+4");
                                        Console.WriteLine("2. FB+2,1 > DE+2 > F+1,2,3 > 1 > SE+1+2 > F+3,2,UF > 4");
                                        Console.WriteLine("3. F+1+2 > DB2,1 > 2 > FF+4,2,DE+1 > SE+1+2 > FFF+2,1 > 1");
                                        Console.WriteLine("4. UF+3 > DF2 > DB+2,SE+1+2 > DF+1 > DF3,DF,DE,2,UF > 4");
                                        Console.WriteLine("5. WR+3 > FF+2 > FF+1,2,3,DE+1 > DE,SE+3+4");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "LEROY":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Leroy has good stance pressure/mixups and benefits from counter hits when players make a mistake");
                            Console.WriteLine("\nWhat would you like to learn about Leroy? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Leroy key moves:");
                                        Console.WriteLine("1. Jab: 1");
                                        Console.WriteLine("2. Body Jab: DF+1");
                                        Console.WriteLine("3. Outcast Arrow: B+1+2");
                                        Console.WriteLine("4. Hermit's Fist: B+1");
                                        Console.WriteLine("5. Feiche Xuan Feng Jiao: B+3");
                                        Console.WriteLine("6. Amputation Kick: DB+3");
                                        Console.WriteLine("7. Twin Snake Strike: D+3,2");
                                        Console.WriteLine("8. Floating Axe Drop: UF+4");
                                        Console.WriteLine("9. Zhuan Shen Jiao: B+4");
                                        Console.WriteLine("10. Snap Kick Knee: DF+4,3");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Leroy Basic Combos:");
                                        Console.WriteLine("1. DF+2,1+2 > QCF+2 > F+3 > D+3,2 > HRMT 2,3 > B+3+4");
                                        Console.WriteLine("2. DF+2,1+2 > F+2,3,4 > HRMT 2,3 > NMBL B+3 > HRMT 2,3");
                                        Console.WriteLine("3. DF+2,1+2 > QCF+2 > 2,2 > F+3,1+2,4 > DASH B+3 > HRMT 2,3");
                                        Console.WriteLine("4. DF+3+4 > QCF+2 > 2,2 > UF+3+4,1+2");
                                        Console.WriteLine("5. DB+2,3 > D > QCF+2 > 2 > DF+3,1 > DASH B+3+4");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "LILI":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Lili has good sidestepping tools along with applying pressure with her attacks.");
                            Console.WriteLine("\nWhat would you like to learn about Lili? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Lili key moves:");
                                        Console.WriteLine("1. Capricorn Kick: UF+3");
                                        Console.WriteLine("2. Submissive Heel: DF+3");
                                        Console.WriteLine("3. Thorn Whip: D+3");
                                        Console.WriteLine("4. Root of Evil: FF+4");
                                        Console.WriteLine("5. Orleans Sword: DF+2");
                                        Console.WriteLine("6. Heavy Languish: D+1,2");
                                        Console.WriteLine("7. BC)lier Attaque: F+4");
                                        Console.WriteLine("8. Kitty Claws: F+1+2");
                                        Console.WriteLine("9. Dominating Heel: DF+4,4");
                                        Console.WriteLine("10. Angel Heart: DGL 1+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Lili Basic Combos:");
                                        Console.WriteLine("1. UF+2 > B1,4 > 3,2,3");
                                        Console.WriteLine("2. DB+4 > 3,2 > 2 > D+2,2,3");
                                        Console.WriteLine("3. DF+2 > DF+2 > DF+3+4 > 1,2 > FF+3F > 1,4");
                                        Console.WriteLine("4. UF+3 > 4 > F+2,3 > DF+3+4 > 1,3 > FF+3F > 1,4");
                                        Console.WriteLine("5. UF+3 > DF+2 > F+2,3 > FF+3F > UF+3+4,3+4 > FF+3F > 1,4");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "DRAGUNOV":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Dragunov has strong pokes, rushdown and, throw game");
                            Console.WriteLine("\nWhat would you like to learn about Dragunov? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Dragunov key moves:");
                                        Console.WriteLine("1. Russian Hook Special: FFF+2");
                                        Console.WriteLine("2. Tundra Slash: B+4,3");
                                        Console.WriteLine("3. Tundra Strike to Ear Grab: B+4,2,1");
                                        Console.WriteLine("4. Tundra Strike to Ambush Tackle: B+4,2,1+2");
                                        Console.WriteLine("5. Ignition Switch: QCF+4");
                                        Console.WriteLine("6. Cocked Hammer: QCF+1");
                                        Console.WriteLine("7. Bunker-Buster Elbow: D+1");
                                        Console.WriteLine("8. Deadly Scorpion: DB+3+4");
                                        Console.WriteLine("9. Stinger Elbow: QCB+2");
                                        Console.WriteLine("10. Blizzard Hammer: B+1+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Dragunov Basic Combos:");
                                        Console.WriteLine("1. DF+2 > F+4,3 > FF+2");
                                        Console.WriteLine("2. DF+2 > F+4,4,3 > B+1,2 > DASH DF+3+4 > 3,1DF > SNK 1+2");
                                        Console.WriteLine("3. DF+2 > DF+1 > 4,4 > CR DF+1,4 > SNK2 > DASH DF+3+4 > 2,1DF > SNK4");
                                        Console.WriteLine("4. QCF+1 > SSL > QCF+3+4 > 4,4 > CR DF+1,4 > SNK2 > DASH > 2,1DF > SNK2");
                                        Console.WriteLine("5. QCB+2 > DASH > DF+3+4 > 4,4 > CR DF+1,4 > SNK4");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "SHAHEEN":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Shaheen has a simple poking game to force mistakes from opponents along with a strong slide/mixup game");
                            Console.WriteLine("\nWhat would you like to learn about Shaheen? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Shaheen key moves:");
                                        Console.WriteLine("1. Body Jab: DF+1");
                                        Console.WriteLine("2. Rising Falcon: DF+2");
                                        Console.WriteLine("3. Piercing Talon: F+4");
                                        Console.WriteLine("4. Achernar: B+1");
                                        Console.WriteLine("5. Elnath: B+3+4");
                                        Console.WriteLine("6. Whirlwind Kick: DF+3");
                                        Console.WriteLine("7. Antares: FFF+2");
                                        Console.WriteLine("8. Heel Strike: B+3");
                                        Console.WriteLine("9. Silent Rigel: D+3");
                                        Console.WriteLine("10. Vicious Stomp: D+4");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Shaheen Basic Combos:");
                                        Console.WriteLine("1. UF+4 > 4,1 > F+2,3 > UF+1");
                                        Console.WriteLine("2. UF+4 > 3DF+SHSP > DB+2DF > 1 > F+2,3 > DASH DB+2DF+3");
                                        Console.WriteLine("3. UF+4 > 3DF+2 > F+2,4,4 > FF+3 > DASH DB2+DF+3");
                                        Console.WriteLine("4. DB+4 > D+2 > D+2 > DB+2+DF > 1 > F+2,3 > DASH DB+2+DF+3");
                                        Console.WriteLine("5. FF+4 > DASH D+2 > DB+2+DF > 1 > DF+4,1,DF+3");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        //Intermediate to learn
                        case "AZUCENA":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Azucena, the Coffee Queen, has an aggressive rushdown playstyle along with float like a butterfly, sting like a bee offense with her stances.");
                            Console.WriteLine("\nWhat would you like to learn about Azucena? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Azucena key moves:");
                                        Console.WriteLine("1. Expresso Agression: FFF+3,2");
                                        Console.WriteLine("2. Grande Combo: DF+1");
                                        Console.WriteLine("3. Groovy Strike: 3");
                                        Console.WriteLine("4. High Mountain Combo: 1,1");
                                        Console.WriteLine("5. Taconees Drip: UF+4");
                                        Console.WriteLine("6. Aero Press Pegar: F+1+2");
                                        Console.WriteLine("7. Bitter Low Kick: DB+4");
                                        Console.WriteLine("8. Borassca Kick: DB+3");
                                        Console.WriteLine("9. Rhythmic Hook: U+2");
                                        Console.WriteLine("10. Hand Drip Hammer: D+1");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Azucena Basic Combos:");
                                        Console.WriteLine("1. DF+4,1 > F+3,2");
                                        Console.WriteLine("2. UF+4 > D+3,3,4 > B+4,3,4,3");
                                        Console.WriteLine("3. DF+2 > D+2,3 > LIB 4,1,2 > DASH F+2,1,4");
                                        Console.WriteLine("4. DF+2 > 4,3 > D+2,3 > LIB 1+2 > F+2,1,4");
                                        Console.WriteLine("5. DF+2 > 4,1 > 3 > LIB 4,1,2 > DASH F+2,1,4");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "EDDY":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Eddy Gordo, The Indomitable Flash, with his capoeria has some creative offense with his stances along with his attacks having 50/50 options.");
                            Console.WriteLine("\nWhat would you like to learn about Eddy? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Eddy key moves:");
                                        Console.WriteLine("1. Sincelo: 3,3");
                                        Console.WriteLine("2. Sismo: D+3");
                                        Console.WriteLine("3. Terremoto: FF+3");
                                        Console.WriteLine("4. Iemanja: NA 3+4");
                                        Console.WriteLine("5. Lunging Brush Fire: B+3+4");
                                        Console.WriteLine("6. Godeme Trovoada: FBA/BBA 1");
                                        Console.WriteLine("7. Travao: FFF+3");
                                        Console.WriteLine("8. Asfixiante: UF+3");
                                        Console.WriteLine("9. Gafanhoto: FC DF+3");
                                        Console.WriteLine("10. Faisca: SS 3+4");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Eddy Basic Combos:");
                                        Console.WriteLine("1. DF+3 > DF+1,3 > DB+4,4");
                                        Console.WriteLine("2. DF+3 > 3,3 > FBA/BBA 3,3,3 > NA 3,3");
                                        Console.WriteLine("3. DF+3 > 3,3 > FBA/BBA 3,3,3 > NA 1,4,4");
                                        Console.WriteLine("4. DF+3 > B+3,3 > NA 2 > B+1 > WR 1,4 > QCF+3 > DASH DB+4,4");
                                        Console.WriteLine("5. FF+4 > BA 2 > B+1 > WR 1,4 > QCF+3 > UF+4 > NA 3,3");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "FENG":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Feng Wei, the God Fist, is know for his well rounded playstyle and strong turn stealing tools to get back on offense.");
                            Console.WriteLine("\nWhat would you like to learn about Feng Wei? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Feng Wei key moves:");
                                        Console.WriteLine("1. Iron Palm: B+1");
                                        Console.WriteLine("2. Evading Palm Strike: UF+2");
                                        Console.WriteLine("3. Piercing Arrow: DB+3");
                                        Console.WriteLine("4. Chin Breaker: B+3");
                                        Console.WriteLine("5. Lift Kick: DF+3");
                                        Console.WriteLine("6. Pau Lau Stinger: DF+4");
                                        Console.WriteLine("7. Xuan Jiao Xiao Yan Shou: FC DF+4,1");
                                        Console.WriteLine("8. Fish Hook: B+4");
                                        Console.WriteLine("9. Landslide: QCF+1");
                                        Console.WriteLine("10. Ruinous Halberd: DF+3+4");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Feng Wei Basic Combos:");
                                        Console.WriteLine("1. UF+4 > F+3,4 > F+2,1,2");
                                        Console.WriteLine("2. DF+3 > F+3,4 > B+1+2");
                                        Console.WriteLine("3. UF+4 > F+3,2 > DF+4,2,1+2 > DASH UF+3 > 3,1+2");
                                        Console.WriteLine("4. UF+4 > DF+4,3 > DF+4,2,1+2 > DASH UF+3 > 3,1+2");
                                        Console.WriteLine("5. SS+4 > B+3 > 2 > DF+4,2,1+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "JUN":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Jun Kazama, The Light of Hope, is a well rounded character with strong poking game and punishing opponents for making mistakes.");
                            Console.WriteLine("\nWhat would you like to learn about Jun? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Jun key moves:");
                                        Console.WriteLine("1. Kagura: SS+4");
                                        Console.WriteLine("2. Tokkei - Misogi: FF+1+2");
                                        Console.WriteLine("3. Ayame: DB+2");
                                        Console.WriteLine("4. Leg Scythe: DB+3");
                                        Console.WriteLine("5. Saiuntsui: UF+3");
                                        Console.WriteLine("6. Sudare Nagashi: WR 1+2");
                                        Console.WriteLine("7. Getsukankyaku: F+4");
                                        Console.WriteLine("8. Saiuntsui: U+3+4");
                                        Console.WriteLine("9. Falling Rain: DB+1+2");
                                        Console.WriteLine("10. Grace: FC DF+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Jun Basic Combos:");
                                        Console.WriteLine("1. DF+2 > F+3,4 > FF+2,3");
                                        Console.WriteLine("2. UF+4,3 > MI F > GU 4 > B+2,1,4");
                                        Console.WriteLine("3. DF+2 > B+4,2 > DF+1 > F+3,2,IO,1,1 > DASH B+2,1F,GU 2");
                                        Console.WriteLine("4. F+2 > 4 > B+4,2 > FF+2B,IO 1 > F+3+4,GU 4 > FF2F,GU 2");
                                        Console.WriteLine("5. DF+2 > DF+4 > DASH F+4 > B+2,1 > F+3,2,IO,F+1+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "LEO":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Leo, The Seeker of Truth, with their basic stances can provide strong punishments for blocked attacks and whiff attacks too.");
                            Console.WriteLine("\nWhat would you like to learn about Leo? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Leo key moves:");
                                        Console.WriteLine("1. Heng Da Bai Tui: F+2,3");
                                        Console.WriteLine("2. Jin Ji Du Li: F+4");
                                        Console.WriteLine("3. Shuang Huan Da: DF+1,2");
                                        Console.WriteLine("4. Sheng Pao: DF+2");
                                        Console.WriteLine("5. Chuan Pao: DF+3");
                                        Console.WriteLine("6. Swallow Step: QCF+3+4");
                                        Console.WriteLine("7. Gui Xi: DF+2+3");
                                        Console.WriteLine("8. Lei Zhang: QCF+1");
                                        Console.WriteLine("9. Lighting Spear: QCF+2,1");
                                        Console.WriteLine("10. Lighting Skypiercer: QCF+2,4");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Leo Basic Combos:");
                                        Console.WriteLine("1. DF+2 > UF+1,1 > DB+2,4");
                                        Console.WriteLine("2. FF+4,3 > F+4 > JJDL 3,4 > FF+2,1+2");
                                        Console.WriteLine("3. DF+2 > F+2 > B+1,1+2D > 1,2 > DASH B+1+2,1+2, QCF+2");
                                        Console.WriteLine("4. UF+2,1 > QCF+3 > B+1,1+2D > 1,2 > DASH B+1+2,1+2, QCF+2");
                                        Console.WriteLine("5. DB+3 > F+3 > F+2 > B+1,1+2D > 1,2 > DASH B+1+2,1+2, QCF+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "LIDIA":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Lidia, The Warrior Prime Minister, focuses on opponents mistakes and punishing them for it as well with counter hits.");
                            Console.WriteLine("\nWhat would you like to learn about Lidia? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Lidia key moves:");
                                        Console.WriteLine("1. Stalwart Governance: B+1");
                                        Console.WriteLine("2. Chop: D+1");
                                        Console.WriteLine("3. Mid Left Hook Thrust: DF+1,1");
                                        Console.WriteLine("4. Mid Left Hook Thrust to Mid Left Sidekick: DF+1,3");
                                        Console.WriteLine("5. Lightning Seikenzuki: FF+2");
                                        Console.WriteLine("6. Political Storm: F+1+2,3,1+2");
                                        Console.WriteLine("7. Iron Lady: B+1+2");
                                        Console.WriteLine("8. Adjourning Sweep: DB+3");
                                        Console.WriteLine("9. Shin Splinter: DB+4");
                                        Console.WriteLine("10. Lame Duck: D+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Lidia Basic Combos:");
                                        Console.WriteLine("1. FF+4 > DF+4,2 > 1+2");
                                        Console.WriteLine("2. UF+4 > CATF > WOLF 2 > B+2,3 > QCF+2,2+1+2");
                                        Console.WriteLine("3. UF+4 > CATB > FFF+2 > HRS 2 > QCF+2,2,1+2");
                                        Console.WriteLine("4. 3,2 > F+3+4 > HRSF > WOLF 2 > B+2,3 > QCF+1+2,2 > WOLFF > B+3,4,QCF1+2");
                                        Console.WriteLine("5. 3,2 > F+3+4 > HRSF > WOLF2 > B+2,3 > F+4,3,4 > DASH > F+3+4 > HRS3 > FF+4,3");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "LAW":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Law, The Legendary Dragon, focuses on mostly counter hits and rushdown playstle.");
                            Console.WriteLine("\nWhat would you like to learn about Law? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Law key moves:");
                                        Console.WriteLine("1. Shaolin Spin Kicks: 4,3");
                                        Console.WriteLine("2. Tornado Claw: 1+2");
                                        Console.WriteLine("3. Shin Crusher: DB+3");
                                        Console.WriteLine("4. Dragon Storm: B+1,2,2");
                                        Console.WriteLine("5. Body Blow to Dragon Lift: D+2,3");
                                        Console.WriteLine("6. Low Crush: SS+3");
                                        Console.WriteLine("7. Dragon Raise: DF+2");
                                        Console.WriteLine("8. Construct Kick: D+4,3");
                                        Console.WriteLine("9. Dragon's Fury: UF+3");
                                        Console.WriteLine("10. Dragon Hammer: F+1+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Law Basic Combos:");
                                        Console.WriteLine("1. UF+4,3 > FF+2,1,3");
                                        Console.WriteLine("2. DF+2 > B+2,1 > 3+4,4");
                                        Console.WriteLine("3. DF+2 4,U+3 > B+2 > B+2,1 > DASH > 4,3F > DC F+4");
                                        Console.WriteLine("4. UF+4 > UF+1 > 4,U+3 > B+2,1 > DASH 4,3F > DC F+4");
                                        Console.WriteLine("5. UF+4 > 4,U+3 > FF+4 > 2 > FF4 > DASH > 1+2 > DASH > 4,3F > DC F+4");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "PAUL":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Paul Pheonix, the Hot-Blooded Destoryer & Strongest in the world, is known for his high damage attacks along with his 50/50 attacks to trick the opponents.");
                            Console.WriteLine("\nWhat would you like to learn about Paul? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Paul key moves:");
                                        Console.WriteLine("1. Phoenix Smasher: QCF+2");
                                        Console.WriteLine("2. Demoman: D+4,2,1+2");
                                        Console.WriteLine("3. Moonfall: ");
                                        Console.WriteLine("4. Stone Lion: ");
                                        Console.WriteLine("5. Kawaragoma: ");
                                        Console.WriteLine("6. Lion Roar: ");
                                        Console.WriteLine("7. Gengetsu: ");
                                        Console.WriteLine("8. Kurenai: ");
                                        Console.WriteLine("9. Phoenix Bone Breaker: ");
                                        Console.WriteLine("10. Enfolding Dragon: ");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Paul Basic Combos:");
                                        Console.WriteLine("1. DF+2 > B+1,2 > F+4");
                                        Console.WriteLine("2. UF+3,4 > DF+1B > SWAY 1+2 > 1+2");
                                        Console.WriteLine("3. DF+2 > 4 > DF+4 > 3,2B > SWAY 1+2 > DASH D+4,2,1+2");
                                        Console.WriteLine("4. DF+2 > 1 > DF+4 > 2 > DASH 3,2B > SWAY 1+2 > DASH 2 > FFF+2");
                                        Console.WriteLine("5. B+3 > 3,2 > 3,2B > SWAY 1+2 > D+4,2,1+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "RAVEN":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Raven, the Shadow Agent, has good mobility with his ninja attacks along with 50/50 attacks and unique options for pressure");
                            Console.WriteLine("\nWhat would you like to learn about Raven? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Raven key moves:");
                                        Console.WriteLine("1. Jackknife Elbow: WR+2");
                                        Console.WriteLine("2. Utsusemi Escape/Sixth Sense: B+1+3/F+1+2");
                                        Console.WriteLine("3. Basilisk Fang: D+4");
                                        Console.WriteLine("4. Stinging Low: D+3");
                                        Console.WriteLine("5. Shinobi Cyclone: DB+4");
                                        Console.WriteLine("6. Tornado Destruction: FC DF+3+4");
                                        Console.WriteLine("7. Tartaros: F+2,3");
                                        Console.WriteLine("8. Shinobi Cyclone: LBR D+3");
                                        Console.WriteLine("9. Deadly Talon: LBR 2,2,1+2");
                                        Console.WriteLine("10. Vermillion: LBR FF+3+4");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Raven Basic Combos:");
                                        Console.WriteLine("1. DF+2,3 > B+2,4,2 > F+2,3");
                                        Console.WriteLine("2. FF+3 > DB+2,1 > B+2,3,2 > FF+4");
                                        Console.WriteLine("3. DF+2 > F+3 > FF4 > DB+2,1D > SZ 3,2 > DASH B+2,4,2");
                                        Console.WriteLine("4. UF+3 > DF+2,3 > DB+2,1D > SZ 3,2 > DASH LBR > 2,1,F+3");
                                        Console.WriteLine("5. UF+3+4 > D+3 > DB+2,1 > B+2,4,2 > DASH B+2,4,2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "VICTOR":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Victor, Agent of Refined Violence, is known for his counter hit playstyle and punishing opponents for being too aggressive or impatient.\nAlso with his fresh suits inspired by John Wick.");
                            Console.WriteLine("\nWhat would you like to learn about Victor? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Victor key moves:");
                                        Console.WriteLine("1. Asterism of Virtue: FFF+2");
                                        Console.WriteLine("2. Shangri-La: FC+1+2");
                                        Console.WriteLine("3. Failnaught: B+1+2");
                                        Console.WriteLine("4. Llawfrodedd: D+2");
                                        Console.WriteLine("5. Baguette Cut: WR+2");
                                        Console.WriteLine("6. Pearly Gates: WR+1+2");
                                        Console.WriteLine("7. Welcome Sweep: DB+4");
                                        Console.WriteLine("8. Fine Salute: D+4");
                                        Console.WriteLine("9. Eden: 1+2");
                                        Console.WriteLine("10. Durandal: F+1+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Victor Basic Combos:");
                                        Console.WriteLine("1. DF+2 > UF+1,1 > B+3,1");
                                        Console.WriteLine("2. DF+2 > DF+4,2 > IS+2 > 2,1F > PR+22 > IS+1,2,2");
                                        Console.WriteLine("3. DF+2 > DF+4,2 > IS+2 > DFWR+2 > DB+1,1F > PR+2,2 > IS+1,2,2");
                                        Console.WriteLine("4. DF+2 > DF+3,4 > 2,1F > PR+2,2,1 > FF+2 > DASH QCF+2 > IS+1,2,2");
                                        Console.WriteLine("5. FF+2 > DF+3,4 > DF+1+2F > PR+2,2,1 > FF+2 > DASHQCF+2 > IS+1,2,2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "ZAFINA":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Zafina, the Mystic Stargazer, has a strong poking game and stong stances that can applying heavy pressure.");
                            Console.WriteLine("\nWhat would you like to learn about Zafina? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Zafina key moves:");
                                        Console.WriteLine("1. Left Right Combo: 1,2");
                                        Console.WriteLine("2. Anzu: 1,3");
                                        Console.WriteLine("3. Ecdysis: 1,4");
                                        Console.WriteLine("4. Bloody Saif - Execution: DF+1,2");
                                        Console.WriteLine("5. Ningishzida: D+1,1");
                                        Console.WriteLine("6. Earwig Pincer: D+3");
                                        Console.WriteLine("7. Acinaces: DB+3");
                                        Console.WriteLine("8. Iskur: D+4,3");
                                        Console.WriteLine("9. Euphrates Cannon: DB+4");
                                        Console.WriteLine("10. Kur: DB+1+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Zafina Basic Combos:");
                                        Console.WriteLine("1. DF+2 > DF+4,2 > F+2,3,4");
                                        Console.WriteLine("2. DF+2 > UF+1 > DF+1 > F+2,3 > SC DF+1 > DASH B+1,1+2");
                                        Console.WriteLine("3. DF+2 > UF+1 > DF+1 > F+2,3 > SC 4 > DASH 2,1,3");
                                        Console.WriteLine("4. DF+2 > FF+2 > DF+1 > F+2,3 > SC 4 > DASH UF+1 > B+1,1+2");
                                        Console.WriteLine("5. DF+2 > FF+2 > DF+1 > DASH DF+1 > F+2,3 > SC DF+1 > FFF+1+2 > TS DF+1");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        //Advanced to learn
                        case "BYRAN":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Bryan Fury, The Harbinger of Chaos, has strong defense, high execution, and slow methodical playstyle plus taunt jet upper combos.");
                            Console.WriteLine("\nWhat would you like to learn about Byran? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Byran key moves:");
                                        Console.WriteLine("1. Cannonball Straight: QCB+1");
                                        Console.WriteLine("2. Knee Strike: F+3");
                                        Console.WriteLine("3. Orbital Heel Kick: UF+4");
                                        Console.WriteLine("4. Hatchet Kick: QCB+3");
                                        Console.WriteLine("5. Chopping Elbow: B+1");
                                        Console.WriteLine("6. Middle Side Kick: 3+4");
                                        Console.WriteLine("7. Mach Kick: FF+4");
                                        Console.WriteLine("8. Smash and Mach Kick: QCB+2,4");
                                        Console.WriteLine("9. High Knee Kick: WR+3");
                                        Console.WriteLine("10. Mach Breaker: FF+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Byran Basic Combos:");
                                        Console.WriteLine("1. UF+4 > D+3+4,2 > FF+2");
                                        Console.WriteLine("2. DF+3 > UF+3 > 3,3,4 ");
                                        Console.WriteLine("3. FB+2 > DASH > QCF+3,4 > B+2,4 > DASH > F+3+4 > B+2,1F > SSP 2,2");
                                        Console.WriteLine("4. UF+4 > 1+2,1 > 1 > B+2,1F > SSP 2,4 > DASH > B+3F > SSP 2,2");
                                        Console.WriteLine("5. DF+3 > DASH > 1+2,1 > 2 > B+2,1F > SSP 2,2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "JIN":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Jin Kazama, The Lighting of Fate, has a well rounded playstyle along with good mobility with wavedashing and good poking, counter hitting, and poking games.");
                            Console.WriteLine("\nWhat would you like to learn about Jin? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Jin key moves:");
                                        Console.WriteLine("1. Wind Hook Fist: FDDF+2");
                                        Console.WriteLine("2. Shun Masatsu: B+2");
                                        Console.WriteLine("3. Demon's Paw: FF+2");
                                        Console.WriteLine("4. Battery Heel: FF+4");
                                        Console.WriteLine("5. Front Thrust Kick: F+4");
                                        Console.WriteLine("6. Right Sweep: D+4");
                                        Console.WriteLine("7. Right Spinning Axe Kick: DF+4");
                                        Console.WriteLine("8. Left Axe Kick: FF+3");
                                        Console.WriteLine("9. Tanden Nidan-uchi: F+3,1");
                                        Console.WriteLine("10. Shun Masatsu: B+2,1");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Jin Basic Combos:");
                                        Console.WriteLine("1. UF+4 > B+1,2 > DB+2,2,3");
                                        Console.WriteLine("2. FF+3 > B+3F > ZN U+1 > DB+2,2,3");
                                        Console.WriteLine("3. UF+4 > DF+2,4 > 3,1F > ZEN 2 > B+3F > ZEN U+1 > F+3+4 > ZEN 1,3");
                                        Console.WriteLine("4. UF+4 > B+3 > 3,1,F+2 > DF+2,3 > B+3F > U+1 > B+3,2");
                                        Console.WriteLine("5. FF+3 > BSTP+2 > B+3,F+1 > BF+2,3F > U+1 > DASH 2,4F > ZEN+4");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "KAZUYA":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Kazuya Mishima, The Cold-Blooded Oppressor, has a strong mixup playstyle along with mobility with wavedashing and hell sweep stance and is a high execution based character.");
                            Console.WriteLine("\nWhat would you like to learn about Kazuya? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Kazuya key moves:");
                                        Console.WriteLine("1. Wind God Fist: FDDF+2");
                                        Console.WriteLine("2. Abolishing Fist: DF+2");
                                        Console.WriteLine("3. Slaughter Hook/Slaughter High Kick: DF+1,2/DF+1,4");
                                        Console.WriteLine("4. Left Splits Kick: FF+3");
                                        Console.WriteLine("5. Parricide Fist: FDDF+1+2");
                                        Console.WriteLine("6. Goutsuiken: DB+1,2");
                                        Console.WriteLine("7. Right Splits Kick: F+4");
                                        Console.WriteLine("8. Flash Tornado: B+4");
                                        Console.WriteLine("9. Nejiri Uraken: D+1+2");
                                        Console.WriteLine("10. Stature Smash: DB+4");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Kazuya Basic Combos:");
                                        Console.WriteLine("1. FF+3 > DF+1,DF+2 > FF+2");
                                        Console.WriteLine("2. WGS+2 > F+2 > B+2,2,1+2");
                                        Console.WriteLine("3. FF+3 > 3,1,4 > DF+1,DF+2 > DASH 3,1DF > WGS 3");
                                        Console.WriteLine("4. FF+3 > SSR 3 > B+2,2 > DF+1,DF+2 > DASH 3,1DF > WGS 3");
                                        Console.WriteLine("5. WR+1,2 > DASH DF+1+2 > B+2,2 > B+2,2,1+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "REINA":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Reina, The Purple Lighting, most like the other mishima characters has greay mobility with wavedashing along with strong poking and stance mixups with her own unique twist.");
                            Console.WriteLine("\nWhat would you like to learn about Reina? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Reina key moves:");
                                        Console.WriteLine("1. Flash Punch Combo: 1,1,2");
                                        Console.WriteLine("2. Muso Tensho: DF+1,1");
                                        Console.WriteLine("3. Kamadhatu Splits Kick: F+4");
                                        Console.WriteLine("4. Muso Basara: DF+1,2");
                                        Console.WriteLine("5. Sin Smiter: B+2");
                                        Console.WriteLine("6. Eisaimon: DB+2");
                                        Console.WriteLine("7. Ten Chuten-geri: FFF+3");
                                        Console.WriteLine("8. Un Tobi Kaijo-geri: FFF+4");
                                        Console.WriteLine("9. Wind God Fist: DF+3,2");
                                        Console.WriteLine("10. Stonehead: UF+1+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Reina Basic Combos:");
                                        Console.WriteLine("1. UF+4 > 2,2,2,2");
                                        Console.WriteLine("2. DF+3 > 2 > 3,2 > 2,2,2,2");
                                        Console.WriteLine("3. DF+2 > DF+2 > DF+1,1 > F+2,3F > SI 1+2 > HW 3,4");
                                        Console.WriteLine("4. DF+2 > B+2 > FF+3+4 > DF+1,1 > F+2,3F > DF+1F > SI 1,QCF+2");
                                        Console.WriteLine("5. UF+4 > FF+3+4 > DF+1,1 > F+2,3F > DF+1F > SI 1,QCF+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "HEIHACHI":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Heihachi Mishima, The Resurrected King of Iron Fist, has high damage with his attacks and combos along with mixups from his hell sweep stance.");
                            Console.WriteLine("\nWhat would you like to learn about Heihachi? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Heihachi key moves:");
                                        Console.WriteLine("1. Right Splits Kick: F+4");
                                        Console.WriteLine("2. Wind God Fist: FDDF+2");
                                        Console.WriteLine("3. Demon God Fist: FF+2");
                                        Console.WriteLine("4. Left Splits Kick: FF+3");
                                        Console.WriteLine("5. Lightning Crush: F+3");
                                        Console.WriteLine("6. Iron Hand: QCF+2");
                                        Console.WriteLine("7. Hell Axle: UF+3,4");
                                        Console.WriteLine("8. Wind Slicer: UF+4");
                                        Console.WriteLine("9. Bone Splinter Kick: FDDF+3");
                                        Console.WriteLine("10. Indra's Kick: B+4");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Heihachi Basic Combos:");
                                        Console.WriteLine("1. FF+3 > 4 > UF+1");
                                        Console.WriteLine("2. FDDF+2 > F+3 > B+1,4 > FDDF+4,4,3");
                                        Console.WriteLine("3. FF+3 > FDDF+2 > F+3 > B+1,4 > UF+3,4 > UF+2,1");
                                        Console.WriteLine("4. UF+3,4 > F+3D > WGK DF+4,4,3 > F+3D > WGK 2 > DASH > B+2 HOLD > QCF+2");
                                        Console.WriteLine("5. CR DF+2 > F+3 > DF+1 > F+3D > WGK 2 > UF+3,4 > UF+2,1");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "LEE":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Lee Chaolan, The Silver Haired-Demon, has a strong counter hitting game where he thrives in the mistakes the opponents make, amazing wall carry, and flashy combos.");
                            Console.WriteLine("\nWhat would you like to learn about Lee? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Lee key moves:");
                                        Console.WriteLine("1. Silver Heel: B+4");
                                        Console.WriteLine("2. Silver Uppercut: DF+2");
                                        Console.WriteLine("3. Pulse Blast: FF+3");
                                        Console.WriteLine("4. Silver Low: D+3");
                                        Console.WriteLine("5. Deadly Edge: FF+4");
                                        Console.WriteLine("6. Right Cross to Revolution Zwei: 2,2,3");
                                        Console.WriteLine("7. Fabulous Whip: DF+4,4");
                                        Console.WriteLine("8. Gut Polisher: D+2");
                                        Console.WriteLine("9. Spin Kick Somersault Combo: 4,3,4");
                                        Console.WriteLine("10. Jostle Wolf: FF+1");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Lee Basic Combos:");
                                        Console.WriteLine("1. UF+4 > F+4,1 > FF+3");
                                        Console.WriteLine("2. DF+2 > D,U+3 > B+2F > F+4,1 > FF+3");
                                        Console.WriteLine("3. DF+2 > B+2,4,3 > F+4,1 > DASH DF+3,2,3");
                                        Console.WriteLine("4. DF+2 > 4,U+3 > B2F > F+4,1 > DASH B+1,1+2");
                                        Console.WriteLine("5. DF+2 > B+2,4,3 > B+2F > F+4,1 > DASH DF+3,2,3");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "DVJ":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Devil Jin, The Black Wings Of Ruin, has good space control along with mobility with his wings.");
                            Console.WriteLine("\nWhat would you like to learn about Devil Jin? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Devil Jin key moves:");
                                        Console.WriteLine("1. Wind God Fist: FDDF+2");
                                        Console.WriteLine("2. Wraith Kick: UF+4");
                                        Console.WriteLine("3. Reaper's Scythe: UF+3");
                                        Console.WriteLine("4. Double Lift Kick: D+3+4");
                                        Console.WriteLine("5. Broken Plate: D+3");
                                        Console.WriteLine("6. Malicious Mace: DB+2");
                                        Console.WriteLine("7. Spinning Demon Hellfire Beam: FDDF+4,1+2");
                                        Console.WriteLine("8. Bloody Glaive: DF+2");
                                        Console.WriteLine("9. Demon's Paw: FF+2");
                                        Console.WriteLine("10. Organ Wrecker: WR+3");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Devil Jin Basic Combos:");
                                        Console.WriteLine("1. D+3+4 > 3,1,2 > UF+1 > MC+4,2,1U");
                                        Console.WriteLine("2. D+3+4 > 3,1,2 > UF+1 > MC+4,2,1+2");
                                        Console.WriteLine("3. D+3+4 > B+2,1 > DASH > U+1+2 > UF+1 > MC+4,2,1+2");
                                        Console.WriteLine("4. U+4U > FLY+4 > B+2,1 > UF+1 > MC+4,2,1+2");
                                        Console.WriteLine("5. WS+2 > DASH > U+1+2 > 3,1 > BF+2,1,2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "HWOARANG":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Hwoarang, The Blood Talon, has flexible and creative offensive tools and attacks with his stances along with overwhelming rushdown as well.");
                            Console.WriteLine("\nWhat would you like to learn about Hwoarang? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Hwoarang key moves:");
                                        Console.WriteLine("1. Left Plasman Blade: B+3");
                                        Console.WriteLine("2. Nose Bleeder: B+4");
                                        Console.WriteLine("3. Ankle Biter: DB+4,4");
                                        Console.WriteLine("4. Right Hook Kick: F+4");
                                        Console.WriteLine("5. Double Claymore: DF+3,4");
                                        Console.WriteLine("6. Shark Step: QCF");
                                        Console.WriteLine("7. Right Stance: 3+4");
                                        Console.WriteLine("8. Left Flamingo: F+3");
                                        Console.WriteLine("9. Hunting Hawk: UF+3,4,3");
                                        Console.WriteLine("10. Air Raid: UF+4,4,4");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Hwoarang Basic Combos:");
                                        Console.WriteLine("1. DF+2 > U+3 > LF 2 > RS 3 > D+4,4 > DASH UF+3,4,3");
                                        Console.WriteLine("2. DF+2 > U+3 > LF 1 > U+3 > UF+3+4F > UF+4 > FF+3+4 > RS F+3 > LF 4,3");
                                        Console.WriteLine("3. DF+2 > F+4 > RF 3,4 > D+4,4 > DASH UF+3,4,3");
                                        Console.WriteLine("4. DF+2 > F+4 > 3,4 > UF+3+4F > LF UF+4 > F+3+4 > RS 3,4 > DASH UB+3");
                                        Console.WriteLine("5. B+3 > F+4 > B+3 > DASH 2,4 > 2,3 > DASH 3+4 > F+3 > 4,3");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "KING":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("King, The Anger of the Beast, has a excellent throw game that can overwhelm opponents along with being unorthodox with throw mixups and pressure");
                            Console.WriteLine("\nWhat would you like to learn about King? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("King key moves:");
                                        Console.WriteLine("1. Lay Off: FF+1+2");
                                        Console.WriteLine("2. Jaguar Hook: FF+1");
                                        Console.WriteLine("3. Rolling Sobat: F+4");
                                        Console.WriteLine("4. Beast Elbow: FF+2");
                                        Console.WriteLine("5. Guillotine Drop: B+3,1+2");
                                        Console.WriteLine("6. Brain Chop: DB+2");
                                        Console.WriteLine("7. Front Kick to DDT: F+3,1+2");
                                        Console.WriteLine("8. Stomp: D+3");
                                        Console.WriteLine("9. Crouching Low Kick: DB+3");
                                        Console.WriteLine("10. Elbow Sting: DF+1,2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("King Basic Combos:");
                                        Console.WriteLine("1. UF+4 > 2+4 > F+2,1");
                                        Console.WriteLine("2. DB+2 > DF+4,3 > 2 > B+1,2 > FFF+2+4");
                                        Console.WriteLine("3. UF+4 > F+3 > DF+4,3 > B+1,2 > FFF+1+2");
                                        Console.WriteLine("4. D+1+2 > 4 > F+1+2 > DF+4,3 > B+1,2 > FFF+2+4");
                                        Console.WriteLine("5. UF+4 > 4 > DASH DF+4,3 > 1,2 > UF+3+4F > FFF+2+4");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "XIAOYU":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Ling Xiaoyu, The Dancing Pheonix, is a stance heavy character that has strong poking tools and a lot of creativity with applying pressure.");
                            Console.WriteLine("\nWhat would you like to learn about Xiaoyu? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Xiaoyu key moves:");
                                        Console.WriteLine("1. Storming Flower: DB+1");
                                        Console.WriteLine("2. Seven Star Fist: B+2,2");
                                        Console.WriteLine("3. Bolting Rabbit: UF+3");
                                        Console.WriteLine("4. Cloud Kick: 3");
                                        Console.WriteLine("5. Moon Swallow: DB+2,3");
                                        Console.WriteLine("6. Phoenix Tail: DB+3");
                                        Console.WriteLine("7. Nutcracker: DB+4");
                                        Console.WriteLine("8. Peacock Kick: B+3");
                                        Console.WriteLine("9. Moonhare Palm: B+4,1");
                                        Console.WriteLine("10. From the Ashes: UB+3");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Xiaoyu Basic Combos:");
                                        Console.WriteLine("1. B+1+2 > F+3,2,4 > DB+1");
                                        Console.WriteLine("2. UF+3 > DF+2 > F+3,1 > RD 1,2 > FFF+3 > PX 1+2");
                                        Console.WriteLine("3. 3 > FF+3 > RD DF+4 > F+3,1,4 > DASH DF+2,3");
                                        Console.WriteLine("4. UF+3 > PX 1 > WR+2 > RD 1,2 > FFF+3 > PX 1+2");
                                        Console.WriteLine("5. B+1+2 > DB+2 > RD 1,2 > B+2 > RD 2,2 > 4");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "NINA":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Nina Williams, The Silent Assassin, has insane rushdown methods along with being a execution character with her combos to her throws as well.");
                            Console.WriteLine("\nWhat would you like to learn about Nina? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Nina key moves:");
                                        Console.WriteLine("1. Biting Kiss Shot: 1,2,1,1+2");
                                        Console.WriteLine("2. Uppercut to Jab: DF+1,2");
                                        Console.WriteLine("3. Creeping Snake to Right High Kick: DF+3,2,4");
                                        Console.WriteLine("4. Creeping Snake to Geyser Cannon: DF+3,2,3");
                                        Console.WriteLine("5. Blonde Bomb: F+1+2");
                                        Console.WriteLine("6. Wipe the Floor: DF+4");
                                        Console.WriteLine("7. Siren's Kiss: F+3");
                                        Console.WriteLine("8. Head Ringer: 3,4");
                                        Console.WriteLine("9. Double Whip: F+4,4");
                                        Console.WriteLine("10. Hellbringer: QCF+1");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Nina Basic Combos:");
                                        Console.WriteLine("1. DF+2 > B+1,4 > F+1+2");
                                        Console.WriteLine("2. DF+2 > UF+4 > DF+3,2 > B+3+4,4 > DS 4,2,1+2");
                                        Console.WriteLine("3. DF+2 > UF+4 > UF+3 > DF+3,2 > B+3+4,3 > DS 4,3,1+2");
                                        Console.WriteLine("4. DF+2 > UF+4 > UF+3 > DF+3,2F > DF 1 > B+1+4 > DASH UF+4 > F+1+2");
                                        Console.WriteLine("5. DF+2 > UF+4 > UF+3 > DF+3,2B > SWAY DB+2 > F+2,1,3 > DASH DS 4,3,1+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "STEVE":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Steve Fox, The Counter-Punching Paragon, thrives when an opponent makes a mistake with his excellent counter hitting offense and along with confusing opponents with his many stances.");
                            Console.WriteLine("\nWhat would you like to learn about Steve? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Steve key moves:");
                                        Console.WriteLine("1. Quick Hook: B+1");
                                        Console.WriteLine("2. Crescent Hook: DF+2");
                                        Console.WriteLine("3. Swaying Hook: FS B+2");
                                        Console.WriteLine("4. Dreadnought Uppercut: U+2");
                                        Console.WriteLine("5. Fly Swatter: FS 2");
                                        Console.WriteLine("6. Eraser: FFF+2");
                                        Console.WriteLine("7. Knee Blaster: D+1");
                                        Console.WriteLine("8. Patella Smash: PB D+1");
                                        Console.WriteLine("9. Bounty Hunter: UB+2");
                                        Console.WriteLine("10. Foot Stomp Right Hook: DB+3,2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Steve Basic Combos:");
                                        Console.WriteLine("1. UF+2 > DI 1 > DF+1,2,1B > FS 1,2 > DASH DL 1,2 > LH 2");
                                        Console.WriteLine("2. UF+2 > F+3,1 > DF+1,2,1B > F+3DB+1 > F+2,2 > 2 > DASH 3,1,2 > 2");
                                        Console.WriteLine("3. DI 2 > DB+2 > F+3,1 > DF+1,2,1 > F+2,2 > 2 > DASH 3,1,2 > 2");
                                        Console.WriteLine("4. DI 2 > DI 2 > F+3,1 > DF+2,F+3,DB+1 > F+2,2 > 2 > DASH 3,1,2 > 2");
                                        Console.WriteLine("5. DI 2 > DI 2 > DF+2,2,1F > 1,2 > DASH 3,1,2 > 2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "YOSHIMITSU":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Yoshimitsu, The Mechanized Space Ninja, has an unorthodox and creative offensive with his many stances and unblockable moves.");
                            Console.WriteLine("\nWhat would you like to learn about Yoshimitsu? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Yoshimitsu key moves:");
                                        Console.WriteLine("1. Rising Knee: UF+3");
                                        Console.WriteLine("2. Basic Uppercut: DF+2");
                                        Console.WriteLine("3. Reverse Cartwheel: FF+3+4");
                                        Console.WriteLine("4. Toita Daoshi: F+4");
                                        Console.WriteLine("5. Kincho: 1+2");
                                        Console.WriteLine("6. Meditation: 3+4");
                                        Console.WriteLine("7. Flea: D+1+2");
                                        Console.WriteLine("8. Indian: D+3+4");
                                        Console.WriteLine("9. Mutou no Kiwami: B+1+2");
                                        Console.WriteLine("10. Manji Dragonfly: U+1+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Yoshimitsu Basic Combos:");
                                        Console.WriteLine("1. DF+2 > F+2,1 > D+2,2,2");
                                        Console.WriteLine("2. DF+2 > D+2,2F > DF+1 > D+2,2,2 > DASH MNK 3,2,1+2");
                                        Console.WriteLine("3. DF+2 > DASH 1+4 > D+2,2 > DF+1,2,1 > DASH 1+4 > DASH D+2,2");
                                        Console.WriteLine("4. UF+3 > 3,2 > MD 2 > MD 2,4 > DASH 1+4 > DASH D+2,2,2");
                                        Console.WriteLine("5. DF+2 > D+2,2F > DF+1,2,1 > DASH 3,2,1+2");
                                        repeatcharacter = false;
                                        //repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        //repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        default:
                            //Console.WriteLine("\nPlease type correct character name.");
                            //repeatcode = true;
                            repeatcharacter = false;
                            break;
                    }
                }

            }
            //while (repeatcharacter)
            //break; //break for while (repeatcode) loop
        } //while (repeatcode)

        public static void SF6_Characters()
        {
            string sf6_fighter = "";
            int sf6_option;
            int sf6character;

            List<String> sf6 = new List<String>();
            //Easy to learn street fighter 6 Characters
            sf6.Add("Lily");
            sf6.Add("Marisa");

            //Intermediate to learn street fighter 6 Characters
            sf6.Add("Ryu");
            sf6.Add("Luke");
            sf6.Add("Jamie");
            sf6.Add("Guile");
            sf6.Add("Kimberly");
            sf6.Add("Ken");
            sf6.Add("Blanka");
            sf6.Add("E.Honda");
            sf6.Add("Deejay");
            sf6.Add("Manon");
            sf6.Add("Cammy");
            sf6.Add("Akuma");
            sf6.Add("Terry");
            sf6.Add("Mai");

            //Hard to learn street fighter 6 Characters
            sf6.Add("Chun Li");
            sf6.Add("Juri");
            sf6.Add("Dhalsim");
            sf6.Add("JP");
            sf6.Add("Zangief");
            sf6.Add("Rashid");
            sf6.Add("Aki");
            sf6.Add("Ed");
            sf6.Add("M.Bison");

            Console.WriteLine("\nStreet Fighter 6 has 36 characters.");
            Console.WriteLine("Would you like to pick your character or have it picked randomly?");
            Console.WriteLine("Enter the number for the option.");
            Console.WriteLine("1. Pick your character \n2. Randomly pick my character");
            Console.WriteLine("Input: ");

            if (int.TryParse(Console.ReadLine(), out sf6character))
            {

            };

            if (sf6character == 1)
            {
                bool repeatcode = true;
                while (repeatcode)
                {
                    Console.WriteLine("\nStreet Fighter 6 has 36 characters.");
                    Console.WriteLine("Which Street Fighter 6 character would you like to learn?\n");
                    Console.WriteLine("List of current SF6 Characters");
                    foreach (String characters in sf6)
                    {
                        Console.WriteLine(characters);
                    }

                    Console.WriteLine("\nInput: ");
                    sf6_fighter = Console.ReadLine();
                    sf6_fighter = sf6_fighter.ToUpper();

                    bool repeatcharacter = true;
                    while (repeatcharacter)
                    {
                        switch (sf6_fighter)
                        {
                            //Easy to learn
                            case "LILY":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Lily is a grappler character with good mid range and pressure.");
                                Console.WriteLine("\nWhat would you like to learn about Lily? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Lily Key Moves");
                                            Console.WriteLine("Crouching Strong: CR.MP");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Crouching Fierce: CR.HP");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Crouching Roundhouse: CR.HK");
                                            Console.WriteLine("Ridge Thrust: DF+HP");
                                            Console.WriteLine("Horn Breaker: B+HP");
                                            Console.WriteLine("Desert Storm: F+HP > HP > HP");
                                            Console.WriteLine("Canyon Throw: F+LP+LK");
                                            Console.WriteLine("Falling Cliff: B+LP+LK");
                                            break;
                                        case 2:
                                            Console.WriteLine("Lily Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Condor Wind: QCB+P");
                                            Console.WriteLine("Condor Spire: QCF+K");
                                            Console.WriteLine("Tomahawk Buster: FDDF+P");
                                            Console.WriteLine("Condor Dive: PP");
                                            Console.WriteLine("OD Condor Dive: PPP");
                                            Console.WriteLine("Mexican Typhoon: 360 Motion+P");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Breezing Hawk: QCFx2+P");
                                            Console.WriteLine("LVL2 Thunderbird/Soaring Thunderbird: QCFx2+K");
                                            Console.WriteLine("LVL3 Raging Typhoon: QCBx2+P");
                                            break;
                                        case 3:
                                            Console.WriteLine("Lily Combos");
                                            Console.WriteLine("1. LK/CR.LK > CR.LP > CR.LP > QCF+KK");
                                            Console.WriteLine("2. CR.LK > CR.LP > CR.LP > QCF+KK > LVL2 (QCFx2+K)");
                                            Console.WriteLine("3. CR.MP > LVL1 (QCFx2+P)");
                                            Console.WriteLine("4. MK/CR.MK > QCF+LK");
                                            Console.WriteLine("5. B+HP > LK > CR.LP > QCF+KK");
                                            Console.WriteLine("6. F+HP > QCF+HK");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "MARISA":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Marisa is hard hitting, rushdown character with high damage combos.");
                                Console.WriteLine("\nWhat would you like to learn about Marisa? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Marisa Key Moves");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Standing Forward: MK");
                                            Console.WriteLine("Crouching Strong: CR.MP");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Crouching Fierce: CR.HP");
                                            Console.WriteLine("Marisa Style: HP or HK (Can be held down)");
                                            Console.WriteLine("Medium Two Hitter: MP > MP");
                                            Console.WriteLine("Magna Bunker: B+HP");
                                            Console.WriteLine("Novacula Swipe: F+MP > HP");
                                            Console.WriteLine("Novacula Thrust: F+MP > HK");
                                            Console.WriteLine("Malleus Breaker: DF+HP > DF+HP");
                                            Console.WriteLine("Mounted Grace: F+LP+LK");
                                            Console.WriteLine("Ponte Milvio: B+LP+LK");
                                            break;
                                        case 2:
                                            Console.WriteLine("Marisa Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Gladius: QCB+P");
                                            Console.WriteLine("Dimachaerus: QCB+P > F+P");
                                            Console.WriteLine("Phalanx: FDDF+P");
                                            Console.WriteLine("Quadriga: QCF+K");
                                            Console.WriteLine("Scutum: QCB+K");
                                            Console.WriteLine("- Tonitus: P > P (During Scutum)");
                                            Console.WriteLine("- Procella: K (During Scutum)");
                                            Console.WriteLine("- Enfold: LP+LK (During Scutum)");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Javelin of Marisa: QCFx2+P");
                                            Console.WriteLine("LVL2 Meteorite: QCBx2+P");
                                            Console.WriteLine("LVL3 Goddess of the Hunt: QCBx2+K");
                                            break;
                                        case 3:
                                            Console.WriteLine("Marisa Combos");
                                            Console.WriteLine("1. CR.LK > CR.LP > CR.LP > QCB+LP,F+P");
                                            Console.WriteLine("2. CR.LK > CR.LP > QCB+LP > LVL3 (QCFx2+K)");
                                            Console.WriteLine("3. MP-MP > QCF+MP");
                                            Console.WriteLine("4. MP-MP > QCF+PP > LVL2 (QCBx2+P)");
                                            Console.WriteLine("5. B+HP > QCB+HP,F+P > QCF+LK");
                                            Console.WriteLine("6. B+HP (Hold) > B+HP > QCB+HP,F+P > QCF+LK > (LVL3?)");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            //Intermediate to learn
                            case "RYU":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Ryu is a all-rounder that focus on neutral and mid range attacks");
                                Console.WriteLine("\nWhat would you like to learn about Ryu? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Ryu Key Moves");
                                            Console.WriteLine("Collarbone Breaker: F+MP");
                                            Console.WriteLine("Solar Plexus Strike: F+HP");
                                            Console.WriteLine("Axe Kick: F+HK");
                                            Console.WriteLine("Crouching Fierce: CR+HP");
                                            Console.WriteLine("Standing Forward: MK");
                                            Console.WriteLine("Crouching Forward: CR+MK");
                                            Console.WriteLine("Shoulder Throw: F+LP+LK");
                                            Console.WriteLine("Somersault Throw: B+LP+LK");
                                            break;
                                        case 2:
                                            Console.WriteLine("Ryu Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Hadoken: QCF+P");
                                            Console.WriteLine("Shoryuken: FDDF+P");
                                            Console.WriteLine("Air Tatsumaki Senpu-kyaku/Tatsumaki Senpu-kyaku: QCB+K");
                                            Console.WriteLine("High Blade Kick: QCF+K");
                                            Console.WriteLine("Hashogeki: QCB+P");
                                            Console.WriteLine("Denjin Charge: DD+P");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Shinku Hadoken: QCFx2+P");
                                            Console.WriteLine("LVL2 Shin Hashogeki: QCBx2+P (Can hold for more power)");
                                            Console.WriteLine("LVL3 Shin Shoryuken: QCFx2+K");
                                            break;
                                        case 3:
                                            Console.WriteLine("Ryu Combos");
                                            Console.WriteLine("1. CR.MP > CR.LP > CR.LP > QCB+MK");
                                            Console.WriteLine("2. CR.LK > CR.LP > QCF+PP > LVL1 (QCFx2+P)");
                                            Console.WriteLine("3. MP > CR.MP > QCB+MK");
                                            Console.WriteLine("4. MP > CR.MP > QCF+KK > LVL 2 (QCBx2+P)");
                                            Console.WriteLine("5. HK > CR.MK > QCF+HP");
                                            Console.WriteLine("6. F+HP > CR.MP > QCF+KK > B+HK > QCF+HP > LVL3 (QCFx2+P)");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "LUKE":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Character_Name and Character_info");
                                Console.WriteLine("\nWhat would you like to learn about Luke? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Luke Key Moves");
                                            Console.WriteLine("Suppressor: B+HP");
                                            Console.WriteLine("Outlaw Kick: B+HK");
                                            Console.WriteLine("Rawhide: F+MP");
                                            Console.WriteLine("Crouching Fierce: CR.HP");
                                            Console.WriteLine("Crouching Strong: CR.MP");
                                            Console.WriteLine("Standing Forward: MK");
                                            Console.WriteLine("Crouching Forward: CR.MK");
                                            Console.WriteLine("Sweeper: F+LP+LK");
                                            Console.WriteLine("Scrapper: B+LP+LK");
                                            break;
                                        case 2:
                                            Console.WriteLine("Luke Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Sand Blast: QCF+P");
                                            Console.WriteLine("- Fatal Shot PP (After OD Sand Blast)");
                                            Console.WriteLine("Flash Knuckle: QCB+P");
                                            Console.WriteLine("- DDT: PP (After OD Flash Knuckle)");
                                            Console.WriteLine("Aerial Flash Knuckle: QCB+P");
                                            Console.WriteLine("Avenger: QCF+K");
                                            Console.WriteLine("- No Chaser: P (During Avenger)");
                                            Console.WriteLine("- Impaler: K (During Avenger)");
                                            Console.WriteLine("Rising Uppercut: FDDF+P");
                                            Console.WriteLine("- Slam Dunk: PP (After OD Rising Uppercut)");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Vulcan Blast: QCFx2+P");
                                            Console.WriteLine("LVL2 Eraser: QCBx2+P");
                                            Console.WriteLine("Pale Rider: QCFx2+K");
                                            break;
                                        case 3:
                                            Console.WriteLine("Luke Combos");
                                            Console.WriteLine("1. CR.LK > CR.LP > CR.LP > QCB+LP");
                                            Console.WriteLine("2. CR.LK > CR.LP > CR.LP > QCB+PP > LVL1/LVL2 (QCFx2+P/QCBx2+P)");
                                            Console.WriteLine("3. LP,MP,HP > QCB+PP > QCB+HP > LVL3 (QCFx2+K)");
                                            Console.WriteLine("4. CR.MP > LK > QCP+PP > QCB+MP");
                                            Console.WriteLine("5. CR.MK > QCB+PPxPP");
                                            Console.WriteLine("6. CR.HP > QCB+MP > QCB+LP > QCB+HP");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "JAMIE":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Jamie is a rush down character that gets cool new tricks when he drinks.");
                                Console.WriteLine("\nWhat would you like to learn about Jamie? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Jamie Key Moves");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Falling Star Kick: F+MK");
                                            Console.WriteLine("Crouching Strong: CR.MP");
                                            Console.WriteLine("Crouching Fierce: CR.HP");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Tensei Kick D+HK,HK");
                                            Console.WriteLine("Phantom Sway: D+HK+HK+P");
                                            Console.WriteLine("Bitter Strikers: LP > LK > MP (Drink lvl 1 or higher)");
                                            Console.WriteLine("Back Shaver: F+LP+LK");
                                            Console.WriteLine("Wheel Punch: B+LP+LK");
                                            break;
                                        case 2:
                                            Console.WriteLine("Jamie Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("The Devil Inside: DD+P (Increases Drink lvl)");
                                            Console.WriteLine("Freeflow Strikes: QCF+P,F+P,F+P (Changes at drink lvl 4)");
                                            Console.WriteLine("Swagger Step: QCB+P");
                                            Console.WriteLine("Arrow Kick: FDDF+K");
                                            Console.WriteLine("Luminous Dive Kick: QCB+F (Drink LVL 1 or higher)");
                                            Console.WriteLine("Bakkai: QCF+K (Drink LVL 2 or higher)");
                                            Console.WriteLine("Tenshin: HCB+K (Drink LVL 3 or higher)");
                                            Console.WriteLine("Swagger Hermit Punch: QCB+P,F+P (Drink LVL 4 or higher)");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Breakin': QCFx2+K (Hold down to add drink lvl)");
                                            Console.WriteLine("LVL2 The Devil's Song: QCBx2+P");
                                            Console.WriteLine("LVL3 Getsuga Saiho: QCFx2+P");
                                            break;
                                        case 3:
                                            Console.WriteLine("Jamie Combos");
                                            Console.WriteLine("1. CR.LK > CR.LP > LK > QCF+LP,F+P,F+P/QCF+LP,F+K,F+K");
                                            Console.WriteLine("2. CR.LK > CR.LP > LK > LVL1 (QCFx2+K)");
                                            Console.WriteLine("3. MP > LK > QCF+LP,F+P,F+P/QCF+LP,F+K,F+K");
                                            Console.WriteLine("4. MP > LK > LP,LK,MP > QCF+LP,F+P,F+P > LVL1/LVL3 (QCFx2+K/QCFx2+P)");
                                            Console.WriteLine("5. CR.HP > QCB+HP");
                                            Console.WriteLine("6. CR.HP > QCF+HP,F+P > LVL1/LVL3 (QCFx2+K/QCFx2+P)");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "GUILE":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Guile is a defensive zoner that focuses on controlling spacing.");
                                Console.WriteLine("\nWhat would you like to learn about Guile? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Guile Key Moves");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Crouching Strong: CR.MP");
                                            Console.WriteLine("Crouching Fierce: CR.HP");
                                            Console.WriteLine("Full Bullet Magnum: F+MP");
                                            Console.WriteLine("Standing Forward: MK");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Crouching Roundhouse: D+HK");
                                            Console.WriteLine("Spinning Back Knuckle: F+HP");
                                            Console.WriteLine("Knee Bazooka: B+LK");
                                            Console.WriteLine("Burning Straight: B+HP");
                                            Console.WriteLine("Rolling Sobat: F+MK/B+MK");
                                            Console.WriteLine("Drake Fang: D+MK > F+MP");
                                            Console.WriteLine("Dragon Suplex: F+LP+LK");
                                            Console.WriteLine("Judo Throw: B+LP+LK");
                                            Console.WriteLine("Flying Mare: F+LP+LK (During a jump)");
                                            Console.WriteLine("Flying Buster Drop: B+LP+LK (During a jump)");
                                            break;
                                        case 2:
                                            Console.WriteLine("Guile Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Sonic Boom: BF+P (Hold back for 2 seconds then F+P)");
                                            Console.WriteLine("Somersault Kick: DU+K (Hold down for 2 seconds then U+K)");
                                            Console.WriteLine("Sonic Blade: QCB+P");
                                            Console.WriteLine("- Sonic Cross: F+P");
                                            Console.WriteLine("- OD Sonic Cross: F+PP (During OD Sonic Blade)");
                                            Console.WriteLine("Sonic Break: PP");
                                            Console.WriteLine("- Sonic Break: P (During Solid Puncher/Sonic Boom/Sonic Break)");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Sonic Hurricane: BFBF+P (Hold first back for 2 secs)");
                                            Console.WriteLine("LVL2 Solid Puncher: QCBx2+P");
                                            Console.WriteLine("LVL3 Crossfire Somersault: BFBF+K (Hold first back for 2 secs)");
                                            break;
                                        case 3:
                                            Console.WriteLine("Guile Combos");
                                            Console.WriteLine("1. CR.LP > CR.LP > DU+HK (Hold down for 2 secs then U+HK)");
                                            Console.WriteLine("2. CR.LK > CR.LP > DU+HK (Hold down for 2 secs then U+HK)");
                                            Console.WriteLine("3. CR.MP > DU+HK (Hold down for 2 secs then U+HK)");
                                            Console.WriteLine("4. MP > CR.MP > CR.MP > DU+HK (Hold down for 2 secs then U+HK)");
                                            Console.WriteLine("5. MP > CR.MP > DU+HK (Hold down for 2 secs then U+HK)");
                                            Console.WriteLine("6. MP > HP > DU+HK (Hold down for 2 secs then U+HK)");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "KIMBERLY":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Kimberly is a rushdown character that has tricky mixups");
                                Console.WriteLine("\nWhat would you like to learn about Kimberly? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Character_Name Key Moves");
                                            Console.WriteLine("Standing Forward: MK");
                                            Console.WriteLine("Crouching Forward: MK");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Crouching Fierce: D+HP");
                                            Console.WriteLine("Bushin Tiger Fangs: MP > HP");
                                            Console.WriteLine("Hisen Kick: F+HK");
                                            Console.WriteLine("Windmill Kick: B+HK");
                                            Console.WriteLine("Water Slicer Slide: DF+MK");
                                            Console.WriteLine("Ripcord Throw: F+LP+LK");
                                            Console.WriteLine("Bell Ringer: B+LP+LK");
                                            break;
                                        case 2:
                                            Console.WriteLine("Character_Name Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Air Bushin Senpukyaku/Bushin Senpukyaku: QCB+K");
                                            Console.WriteLine("Sprint: QCF+K");
                                            Console.WriteLine("- Emergency Stop: P");
                                            Console.WriteLine("- Torso Cleaver: LK");
                                            Console.WriteLine("- Shadow Slide: MK");
                                            Console.WriteLine("- Neck Hunter: HK");
                                            Console.WriteLine("- Arc Step: Happens automatically");
                                            Console.WriteLine(" - Bushin Izuna Otoshi: P");
                                            Console.WriteLine(" - Bushin Hojin Kick: K");
                                            Console.WriteLine("Vagabond Edge: QCF+P");
                                            Console.WriteLine("Hidden Variable: QCB+P");
                                            Console.WriteLine("Genius at Play: DD+P");
                                            Console.WriteLine("- Shuriken Bomb: DD+P");
                                            Console.WriteLine("- Shuriken Bomb Spread: DD+PP");
                                            Console.WriteLine("Nue Twister: QCF+P (During a jump)");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Bushin Beats: QCFx2+K");
                                            Console.WriteLine("- Bushin Thunderous Beats: Keep pressing K (Need at least 1 Shuriken Bomb during Bushin Beats)");
                                            Console.WriteLine("LVL2 Bushin Scramble/Soaring Bushin Scramble: QCBx2+P");
                                            Console.WriteLine("LVL3 Bushin Ninjastar Cypher: QCFx2+P");
                                            break;
                                        case 3:
                                            Console.WriteLine("Character_Name Combos");
                                            Console.WriteLine("1. CR.LK > LP,MP,HP,HK");
                                            Console.WriteLine("2. CR.LK > LP > LK > QCF+LP > LVL3 (QCFx2+P)");
                                            Console.WriteLine("3. CR.MP > MP,HP > QCF+MP");
                                            Console.WriteLine("4. CR.MP > MP,HP > QCF+PP > J.MP > QCB+KK > LVL2 (QCBx2+P)");
                                            Console.WriteLine("5. HP > QCF+HP > J.QCF+HP");
                                            Console.WriteLine("6. HP > QCF+HP > LVL1/LVL2/LVL3");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "KEN":
                                Console.WriteLine("\nDifficulty: Normal");
                                Console.WriteLine("Ken is a rushdown character that applies aggressive pressure");
                                Console.WriteLine("\nWhat would you like to learn about Ken? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Ken Key Moves");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Crouching Fierce: D+HP");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Crouching Forward: D+MK");
                                            Console.WriteLine("Chin Buster: MP > HP");
                                            Console.WriteLine("Triple Flash Kicks: MK > MK > HK");
                                            Console.WriteLine("Knee Strikes: F+LP+LK");
                                            Console.WriteLine("Hell Wheel: LP+LK (During a Jump)");
                                            break;
                                        case 2:
                                            Console.WriteLine("Ken Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Hadoken: QCF+P");
                                            Console.WriteLine("Shoryuken: FDDF+P");
                                            Console.WriteLine("Air Tatsumaki Senpu-kyaku/Tatsumaki Senpu-kyaku: QCB+K");
                                            Console.WriteLine("Dragonlash Kick: FDDF+K");
                                            Console.WriteLine("Jinrai Kick: QCF+K");
                                            Console.WriteLine("- Kazekama Shin Kick (KSK): F+LK");
                                            Console.WriteLine("- Gorai Axe Kick (GAK): F+MK");
                                            Console.WriteLine("- Senka Snap Kick (SSK): F+HK");
                                            Console.WriteLine("Kasai Thrust Kick: F+K (During OD KSK,OD GAK,OD SSK)");
                                            Console.WriteLine("Quick Dash: KK");
                                            Console.WriteLine("- Emergency Stop: LK");
                                            Console.WriteLine("- Thunder Kick: MK");
                                            Console.WriteLine("- Forward Step Kick: HK");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Dragonlash Flame: QCBx2+K");
                                            Console.WriteLine("LVL2 Shippu Jinrai-kyaku: QCFx2+K");
                                            Console.WriteLine("LVL3 Shinryu Reppa: QCFx2+P");
                                            break;
                                        case 3:
                                            Console.WriteLine("Ken Combos");
                                            Console.WriteLine("1. CR.LP > CR.LP > QCF+LK,F+HK");
                                            Console.WriteLine("2. CR.LK > CR.LP > LK > FDDF+HP");
                                            Console.WriteLine("3. MP > CR.LP > LK > FDDF+HP");
                                            Console.WriteLine("4. MP,HK > KK,HK > LVL2 (QCFx2+K)");
                                            Console.WriteLine("5. CR.HP > QCF+HK > LVL2 (QCFx2+K)");
                                            Console.WriteLine("6. CR.HP > QCF+HK > FDDF+KK > LVL3 (QCFx2+P)");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "BLANKA":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Blanka is a wacky rushdown character that can confuse players with gimmicks and setups.");
                                Console.WriteLine("\nWhat would you like to learn about Blanka? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Blanka Key Moves");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Crouching Strong: CR.MP");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Rock Crusher: F+MP");
                                            Console.WriteLine("Wild Edge: B+MK");
                                            Console.WriteLine("Amazon River Run: DF+HP");
                                            Console.WriteLine("Wild Fang: F+LP+LK");
                                            Console.WriteLine("Jungle Flip: B+LP+LK");
                                            Console.WriteLine("Wild Bites: LP+LK (During a jump)");
                                            break;
                                        case 2:
                                            Console.WriteLine("Blanka Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Electric Thunder: QCB+P");
                                            Console.WriteLine("Air Rolling Attack/Rolling Attack: BF+P (Hold back for 2 secs then F+P)");
                                            Console.WriteLine("Vertical Rolling Attack: DU+K (Hold down for 2 secs then U+K)");
                                            Console.WriteLine("Backstep Rolling Attack: HCB+K");
                                            Console.WriteLine("Wild Hunt: QCF+K");
                                            Console.WriteLine("Blanka-chan Bomb: DD+P");
                                            Console.WriteLine("Rolling Cannon: Any dirction+P (During Lighting Beast)");
                                            Console.WriteLine("Coward Crouch: DD+PP");
                                            Console.WriteLine("- Wild Lift: P (During Coward Crouch)");
                                            Console.WriteLine("- Raid Jump: K (During Coward Crouch)");
                                            Console.WriteLine("Surprise Forward Hop: F+KKK");
                                            Console.WriteLine("Surprise Back Hop: B+KKK");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Shout of Earth: QCBx2+P");
                                            Console.WriteLine("LVL2 Lightning Beast: QCBx2+P");
                                            Console.WriteLine("LVL3 Ground Shave Cannonball: QCFx2+K");
                                            break;
                                        case 3:
                                            Console.WriteLine("Blanka Combos");
                                            Console.WriteLine("1. CR.LK > CR.LP > CR.LP > BF+MP (Hold back for 2 secs then F+P)");
                                            Console.WriteLine("2. CR.LK > CR.LP > CR.LP > LVL1 (QCBx2+P)");
                                            Console.WriteLine("3. CR.MK > LP > BF+MP (Hold back for 2 secs then F+P)");
                                            Console.WriteLine("4. F+MK > LK > CR.LP BF+MP (Hold back for 2 secs then F+P)");
                                            Console.WriteLine("5. HK > CR.LP > DU+LK (Hold down for 2 secs then U+K)");
                                            Console.WriteLine("6. HP > D+PP,P > DF+HP");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "E.HONDA":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("E.Honda is a rushdown character that does big damage in sumo style.");
                                Console.WriteLine("\nWhat would you like to learn about E.Honda? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("E.Honda Key Moves");
                                            Console.WriteLine("Crouching Forward: CR.MK");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Crouching Strong: MP");
                                            Console.WriteLine("Crouching Fierce: HP");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Harai Kick: F+HK");
                                            Console.WriteLine("Power Stomp: DF+HK");
                                            Console.WriteLine("Double Slaps: LP > MP");
                                            Console.WriteLine("Saba Ori: F+LP+LK");
                                            Console.WriteLine("Tawara Throw: B+LP+LK");
                                            break;
                                        case 2:
                                            Console.WriteLine("Character_Name Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Hundred Hand Slap: QCB+P");
                                            Console.WriteLine("Sumo Headbutt: BF+P (Hold back for 2 secs then F+P)");
                                            Console.WriteLine("Sumo Smash: DU+K (Hold down for 2 secs then U+K)");
                                            Console.WriteLine("Oicho Throw: HCB+K");
                                            Console.WriteLine("Sumo Dash: QCF+K");
                                            Console.WriteLine("- Teppo Triple Slap: P>P (During Sumo Dash)");
                                            Console.WriteLine("- Taiho Cannon Lift: D+P (During Sumo Dash)");
                                            Console.WriteLine("Neko Damashi: DD+P");
                                            Console.WriteLine("Sumo Spirit: DD+K");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Show of Force: QCFx2+P");
                                            Console.WriteLine("LVL2 Ultimate Killer Head Ram: BFBF+K (Hold first back for 2 secs)");
                                            Console.WriteLine("LVL3 The Final Bout: QCBx2+P");
                                            break;
                                        case 3:
                                            Console.WriteLine("Character_Name Combos");
                                            Console.WriteLine("1. CR.LK > CR.LP > CR.LP > QCB+LP");
                                            Console.WriteLine("2. LK > LP,MP > QCB+HP > LVL3 (QCBx2+P)");
                                            Console.WriteLine("3. MP > QCB+PP > CR.LP > QCB+LP");
                                            Console.WriteLine("4. MP > CR.LP > BF+MP (Hold back for 2 secs then F+P)");
                                            Console.WriteLine("5. HP > QCF+KK,D+P > DU+HK (Hold down for 2 secs then U+K)");
                                            Console.WriteLine("6. HP > QCB+PP > CR.LP > LVL3 (QCBx2+P)");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "DEEJAY":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Deejay is a rushdown character that has gimmicks and mixups with his feints and swal movements");
                                Console.WriteLine("\nWhat would you like to learn about Deejay? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Deejay Key Moves");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Crouching Strong: CR.MP");
                                            Console.WriteLine("Standing Forward: MK");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Crouching Fierce: CR.HP");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Crouching Forward: CR.MK");
                                            Console.WriteLine("Crouching Roundhouse: CR.HK");
                                            Console.WriteLine("Knee Shot: D+LK (During forward jump)");
                                            Console.WriteLine("Face Breaker: B+HK");
                                            Console.WriteLine("Sunrise Heel: F+MK");
                                            Console.WriteLine("Dee Jay Special: MP > HP > HK");
                                            Console.WriteLine("Funky Dance: MP > MP > HP");
                                            Console.WriteLine("Funky Dance Feint: MP > MP > B+HP");
                                            Console.WriteLine("Diss Track: F+LP+LK");
                                            Console.WriteLine("Flip Throw: B+LP+LK");
                                            break;
                                        case 2:
                                            Console.WriteLine("Deejay Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Air Slasher: BF+P (Hold back for 2 secs then F+P)");
                                            Console.WriteLine("Jackknife Maximum: DU+K (Hold down for 2 secs then U+K)");
                                            Console.WriteLine("Roll Through Feint: QCF+LK");
                                            Console.WriteLine("Quick Rolling Sobat: QCF+MK");
                                            Console.WriteLine("Double Rolling Sobat: QCF+HK");
                                            Console.WriteLine("Machine Gun Uppercut: QCB+P");
                                            Console.WriteLine("Jus Cool: QCB+K");
                                            Console.WriteLine("- Funky Slicer: LK (During Jus Cool)");
                                            Console.WriteLine("- Waning Moon: MK (During Jus Cool)");
                                            Console.WriteLine("- Maximum Strike: HK (During Jus Cool)");
                                            Console.WriteLine("- Juggling Dash: F+P (During Jus Cool)");
                                            Console.WriteLine(" - Juggling Sway: B+P (During Juggling Dash)");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 The Greatest Sobat: QCFx2+K");
                                            Console.WriteLine("LVL2 Lowkey Sunrise Festival (LSF): QCFx2+LP>LP>MP>HP>LK>MK>HK");
                                            Console.WriteLine("LVL2 Marvelous Sunrise Festival (MSF): QCFx2+MP>LP>MP>HP>LK>MK>HK");
                                            Console.WriteLine("- Climactic Strike: HP (After MSF/HSF connects)");
                                            Console.WriteLine("- Encore Beat: HK (After MSF/HSF connects)");
                                            Console.WriteLine("LVL2 Headliner Sunrise Festival (HSF): QCFx2+HP>LP>MP>HP>LK>MK>HK");
                                            Console.WriteLine("- Climactic Strike: HP (After MSF/HSF connects)");
                                            Console.WriteLine("- Encore Beat: HK (After MSF/HSF connects)");
                                            Console.WriteLine("LVL3 Weekend Pleasure: QCBx2+P");
                                            break;
                                        case 3:
                                            Console.WriteLine("Deejay Combos");
                                            Console.WriteLine("1. CR.LK > CR.LP > QCF+MK");
                                            Console.WriteLine("2. CR.LK > CR.LP > QCF+MK > LVL3 (QCBx2+P)");
                                            Console.WriteLine("3. MP > LK > QCF MK/HK");
                                            Console.WriteLine("4. MP > HP > HK > LVL1 (QCFx2+K)");
                                            Console.WriteLine("5. CR.HP > CR.MP > DU+HK (Hold down for 2 secs then U+K)");
                                            Console.WriteLine("6. CR.HP > CR.MP > QCB+P > LVL3 (QCBx2+P)");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "MANON":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Manon is a grappler character that focuses on elegance and beauty");
                                Console.WriteLine("\nWhat would you like to learn about Manon? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Manon Key Moves");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Crouching Strong: CR.MP");
                                            Console.WriteLine("Standing Forward: MK");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Crouching Fierce: CR.HP");
                                            Console.WriteLine("Crouching Forward: CR.MK");
                                            Console.WriteLine("Reverence: B+HP");
                                            Console.WriteLine("A Terre: MP > MK");
                                            Console.WriteLine("Temps Lie: HP > HP");
                                            Console.WriteLine("Allonge: D+HP > HP");
                                            Console.WriteLine("Ouchi Gari: F+LP+LK");
                                            Console.WriteLine("Uchi Mata: B+LP+LK");
                                            break;
                                        case 2:
                                            Console.WriteLine("Manon Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Manege Dore: HCB+P");
                                            Console.WriteLine("Rond-point: QCF+K");
                                            Console.WriteLine("Degage: QCB+K");
                                            Console.WriteLine("Renverse: QCF+P");
                                            Console.WriteLine("- Grand Fouette: K (During Renverse)");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Arabesque: QCFx2+K");
                                            Console.WriteLine("LVL2 Etoile: QCBx2+K");
                                            Console.WriteLine("LVL3 Pas de Deux: QCFx2+P");
                                            break;
                                        case 3:
                                            Console.WriteLine("Character_Name Combos");
                                            Console.WriteLine("1. CR.LK > CR.LP > QCF+MK");
                                            Console.WriteLine("2. CR.LK > CR.LP > QCF+KK > LVL2 (QCBx2+K)");
                                            Console.WriteLine("3. B+MK,MK > QCF+KK > QCB+MK");
                                            Console.WriteLine("4. B+MK,MK > QCB+MK");
                                            Console.WriteLine("5. B+HP > QCB+KK > LK > QCF+MK");
                                            Console.WriteLine("6. B+HP > QCB+KK > CR.MP > QCF+MK");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "CAMMY":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Cammy is a rushdown with aggressive pressure with her divekick and love for cats");
                                Console.WriteLine("\nWhat would you like to learn about Cammy? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Cammy Key Moves");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Standing Forward: MK");
                                            Console.WriteLine("Crouching Strong: CR.MP");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Crouching Fierce: CR.HP");
                                            Console.WriteLine("Crouching Roundhouse: CR.HK");
                                            Console.WriteLine("Lift Uppercut: B+MP");
                                            Console.WriteLine("Delayed Ripper: F+HK");
                                            Console.WriteLine("Assault Blade: B+HK");
                                            Console.WriteLine("Lift Combination: B+MP > HK");
                                            Console.WriteLine("Swing Combination: HP > HK");
                                            Console.WriteLine("Rough Landing: F+LP+LK");
                                            Console.WriteLine("Delta Throw: B+LP+LK");
                                            Console.WriteLine("Leg Scissors Choke: LP+LK (During a jump)");
                                            break;
                                        case 2:
                                            Console.WriteLine("Character_Name Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Spiral Arrow: QCF+K");
                                            Console.WriteLine("Canon Spike: FDDF+K");
                                            Console.WriteLine("Quick Spin Knuckle: QCB+P");
                                            Console.WriteLine("Cannon Strike: QCB+K (During forward jump)");
                                            Console.WriteLine("Hooligan Combination (HC): QCF+P");
                                            Console.WriteLine("- Razor's Edge Sliver: Don't press any button (During HC)");
                                            Console.WriteLine("- Cannon Strike: K (During HC)");
                                            Console.WriteLine("- Reverse Edge: D+K (During HC)");
                                            Console.WriteLine("- Fatal Leg Twister: LP+LK (During HC)");
                                            Console.WriteLine("- Silent Step: P (During HC)");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Spin Drive Smasher: QCFx2+K");
                                            Console.WriteLine("LVL2 Air Killer Bee Spin/Killer Bee Spin: QCBx2+P");
                                            Console.WriteLine("LVL3 Delta Red Assault: QCFx2+P");
                                            break;
                                        case 3:
                                            Console.WriteLine("Character_Name Combos");
                                            Console.WriteLine("1. CR.LK > CR.LP > DP.HK");
                                            Console.WriteLine("2. CR.LK > CR.LP > CR.LP > LVL1 (QCFx2+K)");
                                            Console.WriteLine("3. MP > LK > QCF+MK");
                                            Console.WriteLine("4. MP > B+MP,HK > J.MP > QCB+KK > LVL1/LVL3 (QCFx2+k/QCFx2+P)");
                                            Console.WriteLine("5. CR.HP > CR.MP > QCF+HK/FDDF+HK");
                                            Console.WriteLine("6. HP,HK > QCB+KK > LVL1 (QCFx2+K)");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "AKUMA":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Akuma is a shoto style character that searches for a worthy battle");
                                Console.WriteLine("\nWhat would you like to learn about Akuma? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Akuma Key Moves");
                                            Console.WriteLine("Crouching Fierce: CR.HP");
                                            Console.WriteLine("Crouching Forward: CR.MK");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Skull Splitter: F+MP");
                                            Console.WriteLine("Resso Snap Kick: F+MK");
                                            Console.WriteLine("Rago High Kick: B+HK");
                                            Console.WriteLine("Viscera Piercer: MP > MP");
                                            Console.WriteLine("Tenmaku Blade Kick: D+MK (During forward jump)");
                                            Console.WriteLine("Goshoha: F+LP+LK");
                                            Console.WriteLine("Shuretto: B+LP+LK");
                                            break;
                                        case 2:
                                            Console.WriteLine("Akuma Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Gou Hadoken: QCF+P");
                                            Console.WriteLine("Zanku Hadoken: QCF+P (During forward jump)");
                                            Console.WriteLine("Gou Shoryuken: FDDF+P");
                                            Console.WriteLine("Air Tatsumaki Zanku-kyaku/Tatsumaki Zanku-kyaku: QCB+K");
                                            Console.WriteLine("Adamant Flame: QCB+P > F+P");
                                            Console.WriteLine("Demon Raid: QCF+K");
                                            Console.WriteLine("- Demon Low Slash: No input (During Demon Raid)");
                                            Console.WriteLine("- Demon Guillontine: P (During Demon Raid)");
                                            Console.WriteLine("- Demon Blade Kick: K (During Demon Raid)");
                                            Console.WriteLine("- Demon Swoop: Hold Down (During Demon Raid)");
                                            Console.WriteLine("- Demon Gou Zanku: QCF+P (During OD Demon Raid)");
                                            Console.WriteLine("- Demon Gou Rasen: QCB+K (During OD Demon Raid)");
                                            Console.WriteLine("Ashura Senku: F+KKK/B+KKK");
                                            Console.WriteLine("Oboro Thow: F+KKK > LP+LK");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Messatsu Gohado/Tenma Gozanku: QCFx2+P/QCFx2+K (During Jump)");
                                            Console.WriteLine("LVL2 Empyrean's End: QCBx2+P");
                                            Console.WriteLine("LVL3 Sip of Calamity: QCFx2+K");
                                            Console.WriteLine("LVL3 Shun Goku Satsu: LP > LP > F+LK > HP (health is 25% or lower)");
                                            break;
                                        case 3:
                                            Console.WriteLine("Akuma Combos");
                                            Console.WriteLine("1. CR.LK > CR.LP > QCB+LK > FDDF+HP");
                                            Console.WriteLine("2. CR.LK > CR.LP > CR.LP > QCF+LP,F+P > LVL3 (QCFx2+K)");
                                            Console.WriteLine("3. MP > CR.LP > QCB+LK > FDDF+HP");
                                            Console.WriteLine("4. CR.MP > MP,MP > QCB+PP,F+P > LVL2 (QCBx2+P)");
                                            Console.WriteLine("5. F+HP > CR.LP > LK > QCB+LK > CR.HK");
                                            Console.WriteLine("6. HK > CR.MP > CR.MP > QCF+PP,F+P");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "TERRY":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Terry is a rushdown all rounder character that travelled from Florida to throw hands");
                                Console.WriteLine("\nWhat would you like to learn about Terry? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Terry Key Moves");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Standing Forward: MK");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Crouching Strong: CR.MP");
                                            Console.WriteLine("Crouching Forward: CR.MK");
                                            Console.WriteLine("Hammer Punch: F+HP");
                                            Console.WriteLine("Power Shoot: MP > HK");
                                            Console.WriteLine("Power Dunk: MP > HK > HK");
                                            Console.WriteLine("Passing Sway: MP > MK");
                                            Console.WriteLine("- Jumping Lariat: MP (After Passing Sway connects)");
                                            Console.WriteLine("- Jumping Knee: MK (After Passing Sway connects)");
                                            Console.WriteLine("Fire Kick: D+MK > D+HK");
                                            Console.WriteLine("Grasping Upper: F+LP+LK");
                                            Console.WriteLine("Buster Throw: B+LP+LK");
                                            break;
                                        case 2:
                                            Console.WriteLine("Terry Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Power Wave: QCF+LP/QCF+MP");
                                            Console.WriteLine("Round Wave: QCF+HP");
                                            Console.WriteLine("Quick Burn: QCB+LP");
                                            Console.WriteLine("Burning Knuckle: QCB+MP/QCB+HP");
                                            Console.WriteLine("Power Charge: QCF+K");
                                            Console.WriteLine("Crack Shoot: QCB+K");
                                            Console.WriteLine("Rising Tackle: FDDF+P");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Buster Wolf: QCFx2+K");
                                            Console.WriteLine("LVL2 Power Geyser: QCBx2+P");
                                            Console.WriteLine("- Twin Geyser: PP (After Power Geyser connects)");
                                            Console.WriteLine(" - Triple Geyser: PP (After Twin Geyser connects)");
                                            Console.WriteLine("LVL3 Rising Fang: QCFx2+P");
                                            break;
                                        case 3:
                                            Console.WriteLine("Terry Combos");
                                            Console.WriteLine("1. CR.LK > CR.LP > QCF+LP/QCF+LK");
                                            Console.WriteLine("2. CR.LK > LP > LP > LVL1/LVL2/LVL3 (QCFx2+K/QCBx2+P/QCFx2+P)");
                                            Console.WriteLine("3. MK > LK > QCF+LK > CR.LP > LP > FDDF+HP");
                                            Console.WriteLine("4. CR.MK,HK > QCB+MK > LVL1 (QCFx2+K)");
                                            Console.WriteLine("5. HP > QCF+HK > QCB+HK > FDDF+HP");
                                            Console.WriteLine("6. HP > QCF+HK > QCB+KK > FDDF+LP > LVL3 (QCFx2+P)");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "MAI":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Mai is a rushdown character that's shows her ninja skills");
                                Console.WriteLine("\nWhat would you like to learn about Mai? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Mai Key Moves");
                                            Console.WriteLine("Crouching Forward: CR.MK");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Standing Forward: MK");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Senkotsu Uchi: F+MP");
                                            Console.WriteLine("Hien Ren Kyaku: LK > LK > LK");
                                            Console.WriteLine("Shiranui Gourin: F+LP+LK");
                                            Console.WriteLine("Fuusha Kuzushi: B+LP+LK");
                                            Console.WriteLine("Yume Zakura: LP+LK (During a jump)");
                                            break;
                                        case 2:
                                            Console.WriteLine("Mai Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Kachousen: QCF+P");
                                            Console.WriteLine("- Midare Kachousen: F+P");
                                            Console.WriteLine("Ryuuenbu: QCB+P");
                                            Console.WriteLine("Hissatsu Shinobi Bachi: QCF+K");
                                            Console.WriteLine("Hishou Ryuuenjin: FDDF+K");
                                            Console.WriteLine("Musasabi no Mai: QCB+P");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Kagerou no Mai: QCFx2+P");
                                            Console.WriteLine("LVL2 Chou Hissatsu Shinobu Bachi: QCF+K");
                                            Console.WriteLine("LVL3 Shiranui Ryuu: Enbu Ada Zakura: QCBx2+P");
                                            break;
                                        case 3:
                                            Console.WriteLine("Mai Combos");
                                            Console.WriteLine("1. CR.LP > CR.LP > CR.LP > QCF+LK");
                                            Console.WriteLine("2. LP > LP > LP > QCB+PP > FDDF+HK");
                                            Console.WriteLine("3. CR.MP > QCF+KK > MP > QCB+PP > LVL2 (QCFx2+K)");
                                            Console.WriteLine("4. CR.MP > QCB+PP > LVL1 (QCFx2+P)");
                                            Console.WriteLine("5. HP > QCB+HP > QCF+LK");
                                            Console.WriteLine("6. CR.HP > LP > QCF+KK > MP > QCB+P");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            //Hard to learn characters
                            case "CHUN LI":
                                Console.WriteLine("\nDifficulty: Hard");
                                Console.WriteLine("Chun Li is a footise based character that looks opponents mistakes and counters them for it.");
                                Console.WriteLine("\nWhat would you like to learn about Chun Li? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Chun Li Key Moves");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Crouching Strong: CR.MP");
                                            Console.WriteLine("Crouching Fierce: CR.HP");
                                            Console.WriteLine("Standing Forward: MK");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Crouching Forward: CR.MK");
                                            Console.WriteLine("Swift Thurst: B+MP/F+MP");
                                            Console.WriteLine("Hakkei: B+HP");
                                            Console.WriteLine("Water Lotus Fist: DF+HP");
                                            Console.WriteLine("Yokusen Kick: F+HK");
                                            Console.WriteLine("Yoso Kick: D+MK (During a jump)");
                                            Console.WriteLine("Koshuto: F+LP+LK");
                                            Console.WriteLine("Taiji Fan: B+LP+LK");
                                            Console.WriteLine("Ryuseiraku: LP+LP (During a jump)");
                                            break;
                                        case 2:
                                            Console.WriteLine("Character_Name Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Kikoken: BF+P (Hold Back for 2 secs then F+P)");
                                            Console.WriteLine("Air Hundred Lighting Kicks/Hundred Lighting Kicks (HLK): QCF+K");
                                            Console.WriteLine("- Lighting Kick Barrage: KK (After OD HLK)");
                                            Console.WriteLine("Spinning Bird Kick: DU+K (Hold down for 2 secs then U+K)");
                                            Console.WriteLine("Hazanshu: QCB+K");
                                            Console.WriteLine("Tensho Kicks: DD+K");
                                            Console.WriteLine("Serenity Stream: QCB+P");
                                            Console.WriteLine("- Orchid Palm: LP (During Serenity Stream)");
                                            Console.WriteLine("- Snake Strike MP (During Serenity Stream)");
                                            Console.WriteLine("- Lotus Fist: HP (During Serenity Stream)");
                                            Console.WriteLine("- Forward Strike: LK (During Serenity Stream)");
                                            Console.WriteLine("- Senpu Kick: MK (During Serenity Stream)");
                                            Console.WriteLine("- Tenku Kick: HK (During Serenity Stream)");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Air Kikosho/Kikosho: QCFx2+P");
                                            Console.WriteLine("LVL2 Hoyoku-sen: QCFx2+K");
                                            Console.WriteLine("LVL3 Soten Ranka: QCBx2+K");
                                            break;
                                        case 3:
                                            Console.WriteLine("Chun Li Combos");
                                            Console.WriteLine("1. CR.LK > LP > LK > QCF+MK");
                                            Console.WriteLine("2. LP > MP > CR.MP > DU+KK > QCF+LK > LVL3 (QCBx2+K)");
                                            Console.WriteLine("3. MP > CR.MP > DU+MK (Hold down for 2 secs and pres U+MK)");
                                            Console.WriteLine("4. MK > QCB+P,HK > J.HP,HP > LVL1 (QCFx2+P)");
                                            Console.WriteLine("5. B+HP > QCF+HK > LVL1 (QCFx2+P)");
                                            Console.WriteLine("6. HK > QCB+P,MK > BF+PP > LK > QCF+MK");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "JURI":
                                Console.WriteLine("\nDifficulty: Hard");
                                Console.WriteLine("Juri is a crazy thrillseeker that focuses on pressure and overwhelming you.");
                                Console.WriteLine("\nWhat would you like to learn about Juri? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Juri Key Moves");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Standing Forward: MK");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Crouching Strong: CR.MP");
                                            Console.WriteLine("Crouching Fierce: CR.HP");
                                            Console.WriteLine("Crouching Forward: CR.MK");
                                            Console.WriteLine("Crouching Roundhouse: CR.HK");
                                            Console.WriteLine("Kyosesho: F+MP");
                                            Console.WriteLine("Senkai Kick: F+MK");
                                            Console.WriteLine("Renko Kicks: F+HP");
                                            Console.WriteLine("Korenzan: B+HK");
                                            Console.WriteLine("Death Crest: MP > B+HP > HP");
                                            Console.WriteLine("Spider Fang Throw: F+LP+LK");
                                            Console.WriteLine("Shadow Kick Throw: B+LP+LK");
                                            Console.WriteLine("Zanka-sen: LP+LK (During a jump)");
                                            break;
                                        case 2:
                                            Console.WriteLine("Juri Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Fuhajin: QCB+K");
                                            Console.WriteLine("Saihasho: QCF+LK (LK to activate)");
                                            Console.WriteLine("Ankensatsu: QCF+MK (MK to activate)");
                                            Console.WriteLine("Go Ohsatsu: QCF+HK (HK to activate)");
                                            Console.WriteLine("Tensenrin: FDDF+P");
                                            Console.WriteLine("Shiku-sen: QCB+K (During a forward jump)");
                                            Console.WriteLine("- Shiren-sen: K (After Shiku-sen)");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Sakkai Fuhazan: QCFx2+K");
                                            Console.WriteLine("LVL2 Feng Shui Engine: QCBx2+P");
                                            Console.WriteLine("LVL3 Kaisen Dankai Raku: QCBx2+K");
                                            break;
                                        case 3:
                                            Console.WriteLine("Juri Combos");
                                            Console.WriteLine("1. CR.LK > LP > LK > FDDF+HP");
                                            Console.WriteLine("2. LP > MK > QCB+HK > LVL1 (QCFx2+K)");
                                            Console.WriteLine("3. MP > CR.MP > FDDF+LP");
                                            Console.WriteLine("4. CR.MP > MK > QCF+MK > F+MP > QCF+MK,HK > LVL1 (QCFx2+K)");
                                            Console.WriteLine("5. HP > QCB+HK > FDDF+HP");
                                            Console.WriteLine("6. F+HP > QCF+MK > F+MP > QCF+MK,HK");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "DHALSIM":
                                Console.WriteLine("\nDifficulty: Hard");
                                Console.WriteLine("Dhalsim is a zoning character that thrives on long range along with yoga as well.");
                                Console.WriteLine("\nWhat would you like to learn about Dhalsim? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Dhalsim Key Moves");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Crouching Strong: CR.MP");
                                            Console.WriteLine("Crouching Fierce: CR.HP");
                                            Console.WriteLine("Standing Short: LK");
                                            Console.WriteLine("Standing Forward: MK");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Crouching Short: CR.LK");
                                            Console.WriteLine("Crouching Forward: CR.MK");
                                            Console.WriteLine("Crouching Roundhouse: CR.HK");
                                            Console.WriteLine("Yoga Uppercut: B+MP");
                                            Console.WriteLine("Yoga Lance: B+HP");
                                            Console.WriteLine("Nirvana Punch: DB+HP");
                                            Console.WriteLine("Diving Kick: B+MK");
                                            Console.WriteLine("Yoga Mountain: B+HK");
                                            Console.WriteLine("Yoga Mummy: D+LP (During a jump)");
                                            Console.WriteLine("Drill Kick: D+K (During a jump)");
                                            Console.WriteLine("Thrust Kick: DB+MK");
                                            Console.WriteLine("Yoga Smash: F+LP+LK");
                                            Console.WriteLine("Yoga Throw: B+LP+LK");
                                            Console.WriteLine("Yoga Splash: D+LP+LK");
                                            break;
                                        case 2:
                                            Console.WriteLine("Dhalsim Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Yoga Fire: QCF+P");
                                            Console.WriteLine("Yoga Arch: QCF+K");
                                            Console.WriteLine("Yoga Flame: HCB+P");
                                            Console.WriteLine("Yoga Blast: HCB+K");
                                            Console.WriteLine("Yoga Comet: HCB+P (During a jump)");
                                            Console.WriteLine("Aerial Yoga Float/Yoga Float: D+KK/DF+KK");
                                            Console.WriteLine("Aerial Yoga Teleport/Yoga Teleport: F+PPP/B+PPP/F+KKK/B+KKK");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Yoga Inferno: QCFx2+P");
                                            Console.WriteLine("LVL2 Yoga Sunburst: QCBx2+K");
                                            Console.WriteLine("LVL3 Merciless Yoga: QCFx2+K");
                                            break;
                                        case 3:
                                            Console.WriteLine("Dhalsim Combos");
                                            Console.WriteLine("1. LP > CR.LP > QCF+PP");
                                            Console.WriteLine("2. DB+LK > CR.LP > CR.LP > LVL1 (QCFx2+P)");
                                            Console.WriteLine("3. CR.MP/DB+MK > HCB+LP");
                                            Console.WriteLine("4. CR.MP > HCB+PP > LVL1 (QCFx2+P)");
                                            Console.WriteLine("5. DB+MK > HCB+PP > CR.HK");
                                            Console.WriteLine("6. DB+MK > HCB+PP > HK > LVL1 (QCFx2+P)");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "JP":
                                Console.WriteLine("\nDifficulty: Hard");
                                Console.WriteLine("JP with his gentleman attire, focus on trying to keep the opponent in far range.");
                                Console.WriteLine("\nWhat would you like to learn about JP? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("JP Key Moves");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Crouching Strong: CR.MP");
                                            Console.WriteLine("Crouching Fierce: CR.HP");
                                            Console.WriteLine("Standing Forward: MK");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Crouching Forward: CR.MK");
                                            Console.WriteLine("Guillotinna: F+MK");
                                            Console.WriteLine("Malice: DF+HP");
                                            Console.WriteLine("Bylina: F+HK");
                                            Console.WriteLine("Grom Strelka: B+MP > MP");
                                            Console.WriteLine("Zilant: HK > HP");
                                            Console.WriteLine("Ravina: F+LP+LK");
                                            Console.WriteLine("Uragan: B+LP+LK");
                                            Console.WriteLine("Tornado: LP+LP (During a jump)");
                                            break;
                                        case 2:
                                            Console.WriteLine("JP Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Triglav: DD+P");
                                            Console.WriteLine("Stribog: QCF+P");
                                            Console.WriteLine("Departure: QCB+P");
                                            Console.WriteLine("- Departure-Window: QCB+LP/QCB+MP (While Departure is out)");
                                            Console.WriteLine("- Departure-Shadow: QCB+HP (While Departure is out)");
                                            Console.WriteLine("Amnesia: DD+K");
                                            Console.WriteLine("Torbalan: QCF+K");
                                            Console.WriteLine("Embrace: QCB+K");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Chornobog: QCFx2+P");
                                            Console.WriteLine("LVL2 Lovushka: QCBx2+P");
                                            Console.WriteLine("LVL3 Interdiction: QCFx2+K");
                                            break;
                                        case 3:
                                            Console.WriteLine("JP Combos");
                                            Console.WriteLine("1. CR.LK > CR.LP > LP > QCF+LP");
                                            Console.WriteLine("2. CR.LK > CR.LP > LP > QCF+LP > LVL1/LVL3 (QCFx2+P/QCFx2+K)");
                                            Console.WriteLine("3. B+MP > CR.LP > LP > QCF+LP");
                                            Console.WriteLine("4. B+MP,MP > QCF+PP > DD+MP > LVL3 (QCFx2+K)?");
                                            Console.WriteLine("5. HK > CR.MP > QCF+MP");
                                            Console.WriteLine("6. F+HK > QCF+MK > LVL3 (QCFx2+K)");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "ZANGEIF":
                                Console.WriteLine("\nDifficulty: Hard");
                                Console.WriteLine("Zangief is close range grappler where his main focus is to put the graps on you for muscle power.");
                                Console.WriteLine("\nWhat would you like to learn about Zangief? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Zangief Key Moves");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Crouching Strong: CR.MP");
                                            Console.WriteLine("Crouching Fierce: CR.HP");
                                            Console.WriteLine("Standing Forward: MK");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Crouching Forward: CR.MK");
                                            Console.WriteLine("Crouching Roundhouse: CR.HK");
                                            Console.WriteLine("Hellstab: DF+MP");
                                            Console.WriteLine("Knee Hammer: F+MK");
                                            Console.WriteLine("Headbutt: F+HP");
                                            Console.WriteLine("Cyclone Wheel Kick: F+HK");
                                            Console.WriteLine("Smetana Dropkick: DF+HK");
                                            Console.WriteLine("Machine Gun Chops: MP > MP > MP");
                                            Console.WriteLine("Power Stomps: DD+MK > MK > MK");
                                            Console.WriteLine("Bodyslam: LP+LK");
                                            Console.WriteLine("Capture Suplex: B+LP+LK");
                                            Console.WriteLine("German Suplex: F+LP+LK");
                                            Console.WriteLine("Spinebuster: DF+LP+LK");
                                            Console.WriteLine("Russian Drop: DB+LP+LK");
                                            Console.WriteLine("Brain Buster: D+LP+LK");
                                            break;
                                        case 2:
                                            Console.WriteLine("Zangief Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Double Lariat: PP");
                                            Console.WriteLine("Screw Piledriver: 360 Motion+P");
                                            Console.WriteLine("Borscht Dynamite: 360 Motion+K (During a jump)");
                                            Console.WriteLine("Russian Suplex: HCB+K");
                                            Console.WriteLine("Siberian Express: HCB+K (When far from opponent)");
                                            Console.WriteLine("Tundra Storm: DD+HK");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Air Russian Slam: QCFx2+K");
                                            Console.WriteLine("LVL2 Cyclone Lariat: QCFx2+P");
                                            Console.WriteLine("LVL3 Bolshoi Storm Buster: 360 Motionx2+P");
                                            break;
                                        case 3:
                                            Console.WriteLine("Zangief Combos");
                                            Console.WriteLine("1. CR.LK > CR.LP > PP");
                                            Console.WriteLine("2. CR.LK > CR.LP > PPP > LVL2 (QCFx2+P)");
                                            Console.WriteLine("3. CR.MP + PP");
                                            Console.WriteLine("4. DD+MK > CR.LK > CR.LP > PPP");
                                            Console.WriteLine("5. F+HP > PP");
                                            Console.WriteLine("6. F+HP > CR.LP > PPP");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "RASHID":
                                Console.WriteLine("\nDifficulty: Hard");
                                Console.WriteLine("Rashid is a rushdown/setup character that expresses his pressure and mixups with his wind and parkout");
                                Console.WriteLine("\nWhat would you like to learn about Rashid? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Rashid Key Moves");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Standing Forward: MK");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Crouching Strong: CR.MP");
                                            Console.WriteLine("Crouching Fierce: CR.HP");
                                            Console.WriteLine("Crouching Forward: CR.MK");
                                            Console.WriteLine("Flapping Spin: F+MP");
                                            Console.WriteLine("Beak Assault: F+HP");
                                            Console.WriteLine("Rising Kick: MP > HK");
                                            Console.WriteLine("Riding Glider: F+LP+LK");
                                            Console.WriteLine("Sunset Drop: B+LP+LK");
                                            Console.WriteLine("Desert Slider: LP+LK");
                                            break;
                                        case 2:
                                            Console.WriteLine("Rashid Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Spinning Mixer: QCF+P");
                                            Console.WriteLine("Eagle Spike: QCB+K");
                                            Console.WriteLine("Whirlwind Shot: QCF+K");
                                            Console.WriteLine("Arabian Cyclone: QCB+P");
                                            Console.WriteLine("- Wing Stroke: B+K (During Arabian Cyclone)");
                                            Console.WriteLine("- Rolling Assault: F+K (During Arabian Cyclone)");
                                            Console.WriteLine(" - Nail Assault: K (During Rolling Assault)");
                                            Console.WriteLine("Arabian Skyhigh: QCB+K (During a forward jump)");
                                            Console.WriteLine("Run: FF (Hold Second F)");
                                            Console.WriteLine("- Backup: F+P (During Run)");
                                            Console.WriteLine("- Tempest Moon: F+K (During Run)");
                                            Console.WriteLine("Side Flip: F+KK");
                                            Console.WriteLine("- Front Flip: F+PP/B+PP");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Super Rashid Kick: QCFx2+K");
                                            Console.WriteLine("LVL2 Ysaar: QCBx2+K");
                                            Console.WriteLine("LVL3 Altair: QCFx2+P");
                                            break;
                                        case 3:
                                            Console.WriteLine("Rashid Combos");
                                            Console.WriteLine("1. CR.LK > CR.LP > LP > QCF+LP/QCF+MP");
                                            Console.WriteLine("2. CR.LK > LP > LP > LVL1 (QCFx2+K)");
                                            Console.WriteLine("3. CR.MP > LK > QCB+LK");
                                            Console.WriteLine("4. MP,HK > QCB+HP,B+K > J.MP > LVL1 (QCFx2+K)");
                                            Console.WriteLine("5. HP > QCB+MK");
                                            Console.WriteLine("6. HP > QCB+PP,F+K,K > LVL3 (QCFx2+P)");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "AKI":
                                Console.WriteLine("\nDifficulty: Hard");
                                Console.WriteLine("AKI as cool as she looks, inflicits poisons with her rushdown and setups.");
                                Console.WriteLine("\nWhat would you like to learn about AKI? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("AKI Key Moves");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Standing Forward: MK");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Crouching Strong: CR.MP");
                                            Console.WriteLine("Crouching Fierce: CR.HP");
                                            Console.WriteLine("Crouching Forward: CR.MK");
                                            Console.WriteLine("Crouching Roundhouse: CR.HK");
                                            Console.WriteLine("Pu Lao: DF+MP");
                                            Console.WriteLine("Chi Wen: F+HP");
                                            Console.WriteLine("Qiu Niu: F+HK");
                                            Console.WriteLine("Hun Dun: LP > LP");
                                            Console.WriteLine("Qiong Qi: HP > HP");
                                            Console.WriteLine("Whisper: F+LP+LK");
                                            Console.WriteLine("Gluttony: B+LP+LK");
                                            break;
                                        case 2:
                                            Console.WriteLine("Character_Name Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Nightshade Pulse: QCB+LP");
                                            Console.WriteLine("- Nightshade Chaser: F+P (During Nightshade Pulse)");
                                            Console.WriteLine("Orchide Spring: QCB+MP");
                                            Console.WriteLine("Toxic Wreath: QCB+HP");
                                            Console.WriteLine("Serpent Lash: QCF+P");
                                            Console.WriteLine("Cruel Fate: QCB+K");
                                            Console.WriteLine("Snake Step: QCF+K");
                                            Console.WriteLine("Sinister Slide: D+PP");
                                            Console.WriteLine("- Venomous Fang: P (During Sinister Slide)");
                                            Console.WriteLine("- Heel Strike: K (During Sinister Slide)");
                                            Console.WriteLine("- Entrapment: LP+LK (During Sinister Slide)");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Deadly Implication: QCFx2+K");
                                            Console.WriteLine("LVL2 Tainted Talons: QCBx2+P");
                                            Console.WriteLine("LVL3 Claws of Ya Zi: QCFx2+P");
                                            break;
                                        case 3:
                                            Console.WriteLine("Character_Name Combos");
                                            Console.WriteLine("1. LK > CR.LP > CR.LP > QCB+HP");
                                            Console.WriteLine("2. CR.LK > CR.LP > CR.LP > QCF+HP > LVL3 (QCFx2+P)");
                                            Console.WriteLine("3. MK > MP > QCB+LP,F+LP");
                                            Console.WriteLine("4. MK > MP > QCB+PP,F+P > LVL 2 (QCBx2+P)");
                                            Console.WriteLine("5. F+HK > CR.LP > CR.LP > QCF+HP");
                                            Console.WriteLine("6. HP,HP > QCF+PP > QCF+HP > LVL1/LVL2/LVL3 (QCFx2+K/QCBx2+P/QCFx2P)");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "ED":
                                Console.WriteLine("\nDifficulty: Hard");
                                Console.WriteLine("Ed trained by Balrog and leader of Neo-Shadaloo, controls spacing along with applying pressure.");
                                Console.WriteLine("\nWhat would you like to learn about Ed? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Ed Key Moves");
                                            Console.WriteLine("Psycho Knuckle: Hold HP");
                                            Console.WriteLine("Cobra Punch: F+HP");
                                            Console.WriteLine("Flicker Combination: LK + LK + LK");
                                            Console.WriteLine("Body Blow Combination: MP > HP");
                                            Console.WriteLine("Hitman Combination: MK > MK > HP");
                                            Console.WriteLine("Low Smash Combination: D+HK > HP");
                                            Console.WriteLine("Face Buster: F+LP+LK");
                                            Console.WriteLine("Rib Crusher: B+LP+LK");
                                            break;
                                        case 2:
                                            Console.WriteLine("Ed Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Psycho Spark: QCF+P");
                                            Console.WriteLine("- Psycho Shoot: F+P (During Spark)");
                                            Console.WriteLine("Psycho Uppercut: FDDF+P");
                                            Console.WriteLine("Psycho Blitz: QCB+P");
                                            Console.WriteLine("Psycho Flicker: QCF+K");
                                            Console.WriteLine("Kill Rush (Forward) (KRF): F+KK");
                                            Console.WriteLine("- Kill Switch Break: F+P (During first half of KRF)");
                                            Console.WriteLine("- Kill Switch Chaser: F+P (During latter of KRF)");
                                            Console.WriteLine("Kill Rush (Backward): B+KK");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Psycho Storm: QCFx2+K");
                                            Console.WriteLine("LVL2 Psycho Cannon: QCBx2+P");
                                            Console.WriteLine("LVL3 Psycho Chamber: QCFx2+P");
                                            break;
                                        case 3:
                                            Console.WriteLine("Ed Combos");
                                            Console.WriteLine("1. CR.LP > LP > LP > QCB+MP");
                                            Console.WriteLine("2. CR.LP > LP > LP > QCB+MP > LVL3 (QCFx2+P)");
                                            Console.WriteLine("3. CR.MK > MP,HP > QCB+HP/FDDF+HP");
                                            Console.WriteLine("4. CR.MK > MP,HK > QCF+KK > FDDF+LP > QCB+LP");
                                            Console.WriteLine("5. HP > CR.LK > FDDF+MP");
                                            Console.WriteLine("6. HP (HOLD) > HP > QCF+KK > FDDF+HP > QCB+HP > LVL3 (QCFx2+P)");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the coorect option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "M.BISON":
                                Console.WriteLine("\nDifficulty: Hard");
                                Console.WriteLine("M.Bison the former head of Shadaloo with amnesia, focuses on defensive and applying pressure.");
                                Console.WriteLine("\nWhat would you like to learn about M.Bison? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                                {
                                    switch (sf6_option)
                                    {
                                        case 1:
                                            Console.WriteLine("M.Bison Key Moves");
                                            Console.WriteLine("Standing Strong: MP");
                                            Console.WriteLine("Standing Fierce: HP");
                                            Console.WriteLine("Standing Forward: MK");
                                            Console.WriteLine("Standing Roundhouse: HK");
                                            Console.WriteLine("Crouching Strong: CR.MP");
                                            Console.WriteLine("Crouching Fierce: CR.HP");
                                            Console.WriteLine("Crouching Forward: CR.MK");
                                            Console.WriteLine("Crouching Roundhouse: CR.HK");
                                            Console.WriteLine("Psycho Hammer: F+HP");
                                            Console.WriteLine("Evil Knee: B+HK");
                                            Console.WriteLine("Hover Kick: DF+HK");
                                            Console.WriteLine("Shadow Hammer: MP > F+HP");
                                            Console.WriteLine("Deadly Throw: F+LP+LK");
                                            Console.WriteLine("Death Tower: B+LP+LK");
                                            break;
                                        case 2:
                                            Console.WriteLine("M.Bison Special Moves/Super Arts");
                                            Console.WriteLine("Special Moves");
                                            Console.WriteLine("Psycho Crusher Attack: BF+P (Hold back for 2 secs then F+P)");
                                            Console.WriteLine("Double Knee Press: QCF+K");
                                            Console.WriteLine("Backfist Combo: QCB+P");
                                            Console.WriteLine("Shadown Rise: DU+K (Hold down for secs then U+K)");
                                            Console.WriteLine("- Head Press: K (During Shadow Rise)");
                                            Console.WriteLine(" - Somersault Skull Diver: P (After Head Press connects)");
                                            Console.WriteLine("- Devil Reverse (During Shadow Rise)");

                                            Console.WriteLine("\nSuper Arts");
                                            Console.WriteLine("LVL1 Knee Press Nightmare: QCFx2+K");
                                            Console.WriteLine("LVL2 Psycho Punisher: QCBx2+K");
                                            Console.WriteLine("LVL3 Unlimited Psycho Crusher: QCFx2+P");
                                            break;
                                        case 3:
                                            Console.WriteLine("M.Bison Combos");
                                            Console.WriteLine("1. CR.LK > CR.LP > LP/CR.LP > QCF+LK");
                                            Console.WriteLine("2. CR.LK > CR.LP > LP/CR.LP > QCB+PP > LVL2 (QCBx2+K)");
                                            Console.WriteLine("3. MP > CR.MP > BF+MP (Hold Back for 2 secs then F+MP)");
                                            Console.WriteLine("4. CR.MP/CR.MK > QCB+MP/QCF+MK");
                                            Console.WriteLine("5. HP > LK > QCB+LP");
                                            Console.WriteLine("6. B+HK > LK > QCB+LP/QCF+LK");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                        }
                        break;
                    }
                    break;
                }
            }

            if (sf6character == 2)
            {
                Random sf6random = new Random();
                int sf6randomcheck = sf6random.Next(sf6.Count);
                string sf6randomconfirmed = sf6[sf6randomcheck];
                sf6randomconfirmed = sf6randomconfirmed.ToUpper();

                bool repeatcharacter = true;
                while (repeatcharacter)
                {
                    switch (sf6randomconfirmed)
                    {
                        //Easy to learn
                        case "LILY":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Lily is a grappler character with good mid range and pressure.");
                            Console.WriteLine("\nWhat would you like to learn about Lily? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Lily Key Moves");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Roundhouse: CR.HK");
                                        Console.WriteLine("Ridge Thrust: DF+HP");
                                        Console.WriteLine("Horn Breaker: B+HP");
                                        Console.WriteLine("Desert Storm: F+HP > HP > HP");
                                        Console.WriteLine("Canyon Throw: F+LP+LK");
                                        Console.WriteLine("Falling Cliff: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Lily Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Condor Wind: QCB+P");
                                        Console.WriteLine("Condor Spire: QCF+K");
                                        Console.WriteLine("Tomahawk Buster: FDDF+P");
                                        Console.WriteLine("Condor Dive: PP");
                                        Console.WriteLine("OD Condor Dive: PPP");
                                        Console.WriteLine("Mexican Typhoon: 360 Motion+P");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Breezing Hawk: QCFx2+P");
                                        Console.WriteLine("LVL2 Thunderbird/Soaring Thunderbird: QCFx2+K");
                                        Console.WriteLine("LVL3 Raging Typhoon: QCBx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Lily Combos");
                                        Console.WriteLine("1. LK/CR.LK > CR.LP > CR.LP > QCF+KK");
                                        Console.WriteLine("2. CR.LK > CR.LP > CR.LP > QCF+KK > LVL2 (QCFx2+K)");
                                        Console.WriteLine("3. CR.MP > LVL1 (QCFx2+P)");
                                        Console.WriteLine("4. MK/CR.MK > QCF+LK");
                                        Console.WriteLine("5. B+HP > LK > CR.LP > QCF+KK");
                                        Console.WriteLine("6. F+HP > QCF+HK");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "MARISA":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Marisa is hard hitting, rushdown character with high damage combos.");
                            Console.WriteLine("\nWhat would you like to learn about Marisa? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Marisa Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Marisa Style: HP or HK (Can be held down)");
                                        Console.WriteLine("Medium Two Hitter: MP > MP");
                                        Console.WriteLine("Magna Bunker: B+HP");
                                        Console.WriteLine("Novacula Swipe: F+MP > HP");
                                        Console.WriteLine("Novacula Thrust: F+MP > HK");
                                        Console.WriteLine("Malleus Breaker: DF+HP > DF+HP");
                                        Console.WriteLine("Mounted Grace: F+LP+LK");
                                        Console.WriteLine("Ponte Milvio: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Marisa Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Gladius: QCB+P");
                                        Console.WriteLine("Dimachaerus: QCB+P > F+P");
                                        Console.WriteLine("Phalanx: FDDF+P");
                                        Console.WriteLine("Quadriga: QCF+K");
                                        Console.WriteLine("Scutum: QCB+K");
                                        Console.WriteLine("- Tonitus: P > P (During Scutum)");
                                        Console.WriteLine("- Procella: K (During Scutum)");
                                        Console.WriteLine("- Enfold: LP+LK (During Scutum)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Javelin of Marisa: QCFx2+P");
                                        Console.WriteLine("LVL2 Meteorite: QCBx2+P");
                                        Console.WriteLine("LVL3 Goddess of the Hunt: QCBx2+K");
                                        break;
                                    case 3:
                                        Console.WriteLine("Marisa Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > CR.LP > QCB+LP,F+P");
                                        Console.WriteLine("2. CR.LK > CR.LP > QCB+LP > LVL3 (QCFx2+K)");
                                        Console.WriteLine("3. MP-MP > QCF+MP");
                                        Console.WriteLine("4. MP-MP > QCF+PP > LVL2 (QCBx2+P)");
                                        Console.WriteLine("5. B+HP > QCB+HP,F+P > QCF+LK");
                                        Console.WriteLine("6. B+HP (Hold) > B+HP > QCB+HP,F+P > QCF+LK > (LVL3?)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        //Intermediate to learn
                        case "RYU":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Ryu is a all-rounder that focus on neutral and mid range attacks");
                            Console.WriteLine("\nWhat would you like to learn about Ryu? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Ryu Key Moves");
                                        Console.WriteLine("Collarbone Breaker: F+MP");
                                        Console.WriteLine("Solar Plexus Strike: F+HP");
                                        Console.WriteLine("Axe Kick: F+HK");
                                        Console.WriteLine("Crouching Fierce: CR+HP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Crouching Forward: CR+MK");
                                        Console.WriteLine("Shoulder Throw: F+LP+LK");
                                        Console.WriteLine("Somersault Throw: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Ryu Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Hadoken: QCF+P");
                                        Console.WriteLine("Shoryuken: FDDF+P");
                                        Console.WriteLine("Air Tatsumaki Senpu-kyaku/Tatsumaki Senpu-kyaku: QCB+K");
                                        Console.WriteLine("High Blade Kick: QCF+K");
                                        Console.WriteLine("Hashogeki: QCB+P");
                                        Console.WriteLine("Denjin Charge: DD+P");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Shinku Hadoken: QCFx2+P");
                                        Console.WriteLine("LVL2 Shin Hashogeki: QCBx2+P (Can hold for more power)");
                                        Console.WriteLine("LVL3 Shin Shoryuken: QCFx2+K");
                                        break;
                                    case 3:
                                        Console.WriteLine("Ryu Combos");
                                        Console.WriteLine("1. CR.MP > CR.LP > CR.LP > QCB+MK");
                                        Console.WriteLine("2. CR.LK > CR.LP > QCF+PP > LVL1 (QCFx2+P)");
                                        Console.WriteLine("3. MP > CR.MP > QCB+MK");
                                        Console.WriteLine("4. MP > CR.MP > QCF+KK > LVL 2 (QCBx2+P)");
                                        Console.WriteLine("5. HK > CR.MK > QCF+HP");
                                        Console.WriteLine("6. F+HP > CR.MP > QCF+KK > B+HK > QCF+HP > LVL3 (QCFx2+P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "LUKE":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Character_Name and Character_info");
                            Console.WriteLine("\nWhat would you like to learn about Luke? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Luke Key Moves");
                                        Console.WriteLine("Suppressor: B+HP");
                                        Console.WriteLine("Outlaw Kick: B+HK");
                                        Console.WriteLine("Rawhide: F+MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Sweeper: F+LP+LK");
                                        Console.WriteLine("Scrapper: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Luke Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Sand Blast: QCF+P");
                                        Console.WriteLine("- Fatal Shot PP (After OD Sand Blast)");
                                        Console.WriteLine("Flash Knuckle: QCB+P");
                                        Console.WriteLine("- DDT: PP (After OD Flash Knuckle)");
                                        Console.WriteLine("Aerial Flash Knuckle: QCB+P");
                                        Console.WriteLine("Avenger: QCF+K");
                                        Console.WriteLine("- No Chaser: P (During Avenger)");
                                        Console.WriteLine("- Impaler: K (During Avenger)");
                                        Console.WriteLine("Rising Uppercut: FDDF+P");
                                        Console.WriteLine("- Slam Dunk: PP (After OD Rising Uppercut)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Vulcan Blast: QCFx2+P");
                                        Console.WriteLine("LVL2 Eraser: QCBx2+P");
                                        Console.WriteLine("Pale Rider: QCFx2+K");
                                        break;
                                    case 3:
                                        Console.WriteLine("Luke Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > CR.LP > QCB+LP");
                                        Console.WriteLine("2. CR.LK > CR.LP > CR.LP > QCB+PP > LVL1/LVL2 (QCFx2+P/QCBx2+P)");
                                        Console.WriteLine("3. LP,MP,HP > QCB+PP > QCB+HP > LVL3 (QCFx2+K)");
                                        Console.WriteLine("4. CR.MP > LK > QCP+PP > QCB+MP");
                                        Console.WriteLine("5. CR.MK > QCB+PPxPP");
                                        Console.WriteLine("6. CR.HP > QCB+MP > QCB+LP > QCB+HP");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "JAMIE":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Jamie is a rush down character that gets cool new tricks when he drinks.");
                            Console.WriteLine("\nWhat would you like to learn about Jamie? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Jamie Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Falling Star Kick: F+MK");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Tensei Kick D+HK,HK");
                                        Console.WriteLine("Phantom Sway: D+HK+HK+P");
                                        Console.WriteLine("Bitter Strikers: LP > LK > MP (Drink lvl 1 or higher)");
                                        Console.WriteLine("Back Shaver: F+LP+LK");
                                        Console.WriteLine("Wheel Punch: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Jamie Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("The Devil Inside: DD+P (Increases Drink lvl)");
                                        Console.WriteLine("Freeflow Strikes: QCF+P,F+P,F+P (Changes at drink lvl 4)");
                                        Console.WriteLine("Swagger Step: QCB+P");
                                        Console.WriteLine("Arrow Kick: FDDF+K");
                                        Console.WriteLine("Luminous Dive Kick: QCB+F (Drink LVL 1 or higher)");
                                        Console.WriteLine("Bakkai: QCF+K (Drink LVL 2 or higher)");
                                        Console.WriteLine("Tenshin: HCB+K (Drink LVL 3 or higher)");
                                        Console.WriteLine("Swagger Hermit Punch: QCB+P,F+P (Drink LVL 4 or higher)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Breakin': QCFx2+K (Hold down to add drink lvl)");
                                        Console.WriteLine("LVL2 The Devil's Song: QCBx2+P");
                                        Console.WriteLine("LVL3 Getsuga Saiho: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Jamie Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > LK > QCF+LP,F+P,F+P/QCF+LP,F+K,F+K");
                                        Console.WriteLine("2. CR.LK > CR.LP > LK > LVL1 (QCFx2+K)");
                                        Console.WriteLine("3. MP > LK > QCF+LP,F+P,F+P/QCF+LP,F+K,F+K");
                                        Console.WriteLine("4. MP > LK > LP,LK,MP > QCF+LP,F+P,F+P > LVL1/LVL3 (QCFx2+K/QCFx2+P)");
                                        Console.WriteLine("5. CR.HP > QCB+HP");
                                        Console.WriteLine("6. CR.HP > QCF+HP,F+P > LVL1/LVL3 (QCFx2+K/QCFx2+P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "GUILE":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Guile is a defensive zoner that focuses on controlling spacing.");
                            Console.WriteLine("\nWhat would you like to learn about Guile? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Guile Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Full Bullet Magnum: F+MP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Roundhouse: D+HK");
                                        Console.WriteLine("Spinning Back Knuckle: F+HP");
                                        Console.WriteLine("Knee Bazooka: B+LK");
                                        Console.WriteLine("Burning Straight: B+HP");
                                        Console.WriteLine("Rolling Sobat: F+MK/B+MK");
                                        Console.WriteLine("Drake Fang: D+MK > F+MP");
                                        Console.WriteLine("Dragon Suplex: F+LP+LK");
                                        Console.WriteLine("Judo Throw: B+LP+LK");
                                        Console.WriteLine("Flying Mare: F+LP+LK (During a jump)");
                                        Console.WriteLine("Flying Buster Drop: B+LP+LK (During a jump)");
                                        break;
                                    case 2:
                                        Console.WriteLine("Guile Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Sonic Boom: BF+P (Hold back for 2 seconds then F+P)");
                                        Console.WriteLine("Somersault Kick: DU+K (Hold down for 2 seconds then U+K)");
                                        Console.WriteLine("Sonic Blade: QCB+P");
                                        Console.WriteLine("- Sonic Cross: F+P");
                                        Console.WriteLine("- OD Sonic Cross: F+PP (During OD Sonic Blade)");
                                        Console.WriteLine("Sonic Break: PP");
                                        Console.WriteLine("- Sonic Break: P (During Solid Puncher/Sonic Boom/Sonic Break)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Sonic Hurricane: BFBF+P (Hold first back for 2 secs)");
                                        Console.WriteLine("LVL2 Solid Puncher: QCBx2+P");
                                        Console.WriteLine("LVL3 Crossfire Somersault: BFBF+K (Hold first back for 2 secs)");
                                        break;
                                    case 3:
                                        Console.WriteLine("Guile Combos");
                                        Console.WriteLine("1. CR.LP > CR.LP > DU+HK (Hold down for 2 secs then U+HK)");
                                        Console.WriteLine("2. CR.LK > CR.LP > DU+HK (Hold down for 2 secs then U+HK)");
                                        Console.WriteLine("3. CR.MP > DU+HK (Hold down for 2 secs then U+HK)");
                                        Console.WriteLine("4. MP > CR.MP > CR.MP > DU+HK (Hold down for 2 secs then U+HK)");
                                        Console.WriteLine("5. MP > CR.MP > DU+HK (Hold down for 2 secs then U+HK)");
                                        Console.WriteLine("6. MP > HP > DU+HK (Hold down for 2 secs then U+HK)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "KIMBERLY":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Kimberly is a rushdown character that has tricky mixups");
                            Console.WriteLine("\nWhat would you like to learn about Kimberly? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Character_Name Key Moves");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Crouching Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Crouching Fierce: D+HP");
                                        Console.WriteLine("Bushin Tiger Fangs: MP > HP");
                                        Console.WriteLine("Hisen Kick: F+HK");
                                        Console.WriteLine("Windmill Kick: B+HK");
                                        Console.WriteLine("Water Slicer Slide: DF+MK");
                                        Console.WriteLine("Ripcord Throw: F+LP+LK");
                                        Console.WriteLine("Bell Ringer: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Character_Name Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Air Bushin Senpukyaku/Bushin Senpukyaku: QCB+K");
                                        Console.WriteLine("Sprint: QCF+K");
                                        Console.WriteLine("- Emergency Stop: P");
                                        Console.WriteLine("- Torso Cleaver: LK");
                                        Console.WriteLine("- Shadow Slide: MK");
                                        Console.WriteLine("- Neck Hunter: HK");
                                        Console.WriteLine("- Arc Step: Happens automatically");
                                        Console.WriteLine(" - Bushin Izuna Otoshi: P");
                                        Console.WriteLine(" - Bushin Hojin Kick: K");
                                        Console.WriteLine("Vagabond Edge: QCF+P");
                                        Console.WriteLine("Hidden Variable: QCB+P");
                                        Console.WriteLine("Genius at Play: DD+P");
                                        Console.WriteLine("- Shuriken Bomb: DD+P");
                                        Console.WriteLine("- Shuriken Bomb Spread: DD+PP");
                                        Console.WriteLine("Nue Twister: QCF+P (During a jump)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Bushin Beats: QCFx2+K");
                                        Console.WriteLine("- Bushin Thunderous Beats: Keep pressing K (Need at least 1 Shuriken Bomb during Bushin Beats)");
                                        Console.WriteLine("LVL2 Bushin Scramble/Soaring Bushin Scramble: QCBx2+P");
                                        Console.WriteLine("LVL3 Bushin Ninjastar Cypher: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Character_Name Combos");
                                        Console.WriteLine("1. CR.LK > LP,MP,HP,HK");
                                        Console.WriteLine("2. CR.LK > LP > LK > QCF+LP > LVL3 (QCFx2+P)");
                                        Console.WriteLine("3. CR.MP > MP,HP > QCF+MP");
                                        Console.WriteLine("4. CR.MP > MP,HP > QCF+PP > J.MP > QCB+KK > LVL2 (QCBx2+P)");
                                        Console.WriteLine("5. HP > QCF+HP > J.QCF+HP");
                                        Console.WriteLine("6. HP > QCF+HP > LVL1/LVL2/LVL3");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "KEN":
                            Console.WriteLine("\nDifficulty: Normal");
                            Console.WriteLine("Ken is a rushdown character that applies aggressive pressure");
                            Console.WriteLine("\nWhat would you like to learn about Ken? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Ken Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Crouching Fierce: D+HP");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Forward: D+MK");
                                        Console.WriteLine("Chin Buster: MP > HP");
                                        Console.WriteLine("Triple Flash Kicks: MK > MK > HK");
                                        Console.WriteLine("Knee Strikes: F+LP+LK");
                                        Console.WriteLine("Hell Wheel: LP+LK (During a Jump)");
                                        break;
                                    case 2:
                                        Console.WriteLine("Ken Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Hadoken: QCF+P");
                                        Console.WriteLine("Shoryuken: FDDF+P");
                                        Console.WriteLine("Air Tatsumaki Senpu-kyaku/Tatsumaki Senpu-kyaku: QCB+K");
                                        Console.WriteLine("Dragonlash Kick: FDDF+K");
                                        Console.WriteLine("Jinrai Kick: QCF+K");
                                        Console.WriteLine("- Kazekama Shin Kick (KSK): F+LK");
                                        Console.WriteLine("- Gorai Axe Kick (GAK): F+MK");
                                        Console.WriteLine("- Senka Snap Kick (SSK): F+HK");
                                        Console.WriteLine("Kasai Thrust Kick: F+K (During OD KSK,OD GAK,OD SSK)");
                                        Console.WriteLine("Quick Dash: KK");
                                        Console.WriteLine("- Emergency Stop: LK");
                                        Console.WriteLine("- Thunder Kick: MK");
                                        Console.WriteLine("- Forward Step Kick: HK");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Dragonlash Flame: QCBx2+K");
                                        Console.WriteLine("LVL2 Shippu Jinrai-kyaku: QCFx2+K");
                                        Console.WriteLine("LVL3 Shinryu Reppa: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Ken Combos");
                                        Console.WriteLine("1. CR.LP > CR.LP > QCF+LK,F+HK");
                                        Console.WriteLine("2. CR.LK > CR.LP > LK > FDDF+HP");
                                        Console.WriteLine("3. MP > CR.LP > LK > FDDF+HP");
                                        Console.WriteLine("4. MP,HK > KK,HK > LVL2 (QCFx2+K)");
                                        Console.WriteLine("5. CR.HP > QCF+HK > LVL2 (QCFx2+K)");
                                        Console.WriteLine("6. CR.HP > QCF+HK > FDDF+KK > LVL3 (QCFx2+P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "BLANKA":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Blanka is a wacky rushdown character that can confuse players with gimmicks and setups.");
                            Console.WriteLine("\nWhat would you like to learn about Blanka? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Blanka Key Moves");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Rock Crusher: F+MP");
                                        Console.WriteLine("Wild Edge: B+MK");
                                        Console.WriteLine("Amazon River Run: DF+HP");
                                        Console.WriteLine("Wild Fang: F+LP+LK");
                                        Console.WriteLine("Jungle Flip: B+LP+LK");
                                        Console.WriteLine("Wild Bites: LP+LK (During a jump)");
                                        break;
                                    case 2:
                                        Console.WriteLine("Blanka Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Electric Thunder: QCB+P");
                                        Console.WriteLine("Air Rolling Attack/Rolling Attack: BF+P (Hold back for 2 secs then F+P)");
                                        Console.WriteLine("Vertical Rolling Attack: DU+K (Hold down for 2 secs then U+K)");
                                        Console.WriteLine("Backstep Rolling Attack: HCB+K");
                                        Console.WriteLine("Wild Hunt: QCF+K");
                                        Console.WriteLine("Blanka-chan Bomb: DD+P");
                                        Console.WriteLine("Rolling Cannon: Any dirction+P (During Lighting Beast)");
                                        Console.WriteLine("Coward Crouch: DD+PP");
                                        Console.WriteLine("- Wild Lift: P (During Coward Crouch)");
                                        Console.WriteLine("- Raid Jump: K (During Coward Crouch)");
                                        Console.WriteLine("Surprise Forward Hop: F+KKK");
                                        Console.WriteLine("Surprise Back Hop: B+KKK");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Shout of Earth: QCBx2+P");
                                        Console.WriteLine("LVL2 Lightning Beast: QCBx2+P");
                                        Console.WriteLine("LVL3 Ground Shave Cannonball: QCFx2+K");
                                        break;
                                    case 3:
                                        Console.WriteLine("Blanka Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > CR.LP > BF+MP (Hold back for 2 secs then F+P)");
                                        Console.WriteLine("2. CR.LK > CR.LP > CR.LP > LVL1 (QCBx2+P)");
                                        Console.WriteLine("3. CR.MK > LP > BF+MP (Hold back for 2 secs then F+P)");
                                        Console.WriteLine("4. F+MK > LK > CR.LP BF+MP (Hold back for 2 secs then F+P)");
                                        Console.WriteLine("5. HK > CR.LP > DU+LK (Hold down for 2 secs then U+K)");
                                        Console.WriteLine("6. HP > D+PP,P > DF+HP");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "E.HONDA":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("E.Honda is a rushdown character that does big damage in sumo style.");
                            Console.WriteLine("\nWhat would you like to learn about E.Honda? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("E.Honda Key Moves");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Strong: MP");
                                        Console.WriteLine("Crouching Fierce: HP");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Harai Kick: F+HK");
                                        Console.WriteLine("Power Stomp: DF+HK");
                                        Console.WriteLine("Double Slaps: LP > MP");
                                        Console.WriteLine("Saba Ori: F+LP+LK");
                                        Console.WriteLine("Tawara Throw: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Character_Name Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Hundred Hand Slap: QCB+P");
                                        Console.WriteLine("Sumo Headbutt: BF+P (Hold back for 2 secs then F+P)");
                                        Console.WriteLine("Sumo Smash: DU+K (Hold down for 2 secs then U+K)");
                                        Console.WriteLine("Oicho Throw: HCB+K");
                                        Console.WriteLine("Sumo Dash: QCF+K");
                                        Console.WriteLine("- Teppo Triple Slap: P>P (During Sumo Dash)");
                                        Console.WriteLine("- Taiho Cannon Lift: D+P (During Sumo Dash)");
                                        Console.WriteLine("Neko Damashi: DD+P");
                                        Console.WriteLine("Sumo Spirit: DD+K");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Show of Force: QCFx2+P");
                                        Console.WriteLine("LVL2 Ultimate Killer Head Ram: BFBF+K (Hold first back for 2 secs)");
                                        Console.WriteLine("LVL3 The Final Bout: QCBx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Character_Name Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > CR.LP > QCB+LP");
                                        Console.WriteLine("2. LK > LP,MP > QCB+HP > LVL3 (QCBx2+P)");
                                        Console.WriteLine("3. MP > QCB+PP > CR.LP > QCB+LP");
                                        Console.WriteLine("4. MP > CR.LP > BF+MP (Hold back for 2 secs then F+P)");
                                        Console.WriteLine("5. HP > QCF+KK,D+P > DU+HK (Hold down for 2 secs then U+K)");
                                        Console.WriteLine("6. HP > QCB+PP > CR.LP > LVL3 (QCBx2+P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "DEEJAY":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Deejay is a rushdown character that has gimmicks and mixups with his feints and swal movements");
                            Console.WriteLine("\nWhat would you like to learn about Deejay? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Deejay Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Crouching Roundhouse: CR.HK");
                                        Console.WriteLine("Knee Shot: D+LK (During forward jump)");
                                        Console.WriteLine("Face Breaker: B+HK");
                                        Console.WriteLine("Sunrise Heel: F+MK");
                                        Console.WriteLine("Dee Jay Special: MP > HP > HK");
                                        Console.WriteLine("Funky Dance: MP > MP > HP");
                                        Console.WriteLine("Funky Dance Feint: MP > MP > B+HP");
                                        Console.WriteLine("Diss Track: F+LP+LK");
                                        Console.WriteLine("Flip Throw: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Deejay Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Air Slasher: BF+P (Hold back for 2 secs then F+P)");
                                        Console.WriteLine("Jackknife Maximum: DU+K (Hold down for 2 secs then U+K)");
                                        Console.WriteLine("Roll Through Feint: QCF+LK");
                                        Console.WriteLine("Quick Rolling Sobat: QCF+MK");
                                        Console.WriteLine("Double Rolling Sobat: QCF+HK");
                                        Console.WriteLine("Machine Gun Uppercut: QCB+P");
                                        Console.WriteLine("Jus Cool: QCB+K");
                                        Console.WriteLine("- Funky Slicer: LK (During Jus Cool)");
                                        Console.WriteLine("- Waning Moon: MK (During Jus Cool)");
                                        Console.WriteLine("- Maximum Strike: HK (During Jus Cool)");
                                        Console.WriteLine("- Juggling Dash: F+P (During Jus Cool)");
                                        Console.WriteLine(" - Juggling Sway: B+P (During Juggling Dash)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 The Greatest Sobat: QCFx2+K");
                                        Console.WriteLine("LVL2 Lowkey Sunrise Festival (LSF): QCFx2+LP>LP>MP>HP>LK>MK>HK");
                                        Console.WriteLine("LVL2 Marvelous Sunrise Festival (MSF): QCFx2+MP>LP>MP>HP>LK>MK>HK");
                                        Console.WriteLine("- Climactic Strike: HP (After MSF/HSF connects)");
                                        Console.WriteLine("- Encore Beat: HK (After MSF/HSF connects)");
                                        Console.WriteLine("LVL2 Headliner Sunrise Festival (HSF): QCFx2+HP>LP>MP>HP>LK>MK>HK");
                                        Console.WriteLine("- Climactic Strike: HP (After MSF/HSF connects)");
                                        Console.WriteLine("- Encore Beat: HK (After MSF/HSF connects)");
                                        Console.WriteLine("LVL3 Weekend Pleasure: QCBx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Deejay Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > QCF+MK");
                                        Console.WriteLine("2. CR.LK > CR.LP > QCF+MK > LVL3 (QCBx2+P)");
                                        Console.WriteLine("3. MP > LK > QCF MK/HK");
                                        Console.WriteLine("4. MP > HP > HK > LVL1 (QCFx2+K)");
                                        Console.WriteLine("5. CR.HP > CR.MP > DU+HK (Hold down for 2 secs then U+K)");
                                        Console.WriteLine("6. CR.HP > CR.MP > QCB+P > LVL3 (QCBx2+P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "MANON":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Manon is a grappler character that focuses on elegance and beauty");
                            Console.WriteLine("\nWhat would you like to learn about Manon? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Manon Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Reverence: B+HP");
                                        Console.WriteLine("A Terre: MP > MK");
                                        Console.WriteLine("Temps Lie: HP > HP");
                                        Console.WriteLine("Allonge: D+HP > HP");
                                        Console.WriteLine("Ouchi Gari: F+LP+LK");
                                        Console.WriteLine("Uchi Mata: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Manon Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Manege Dore: HCB+P");
                                        Console.WriteLine("Rond-point: QCF+K");
                                        Console.WriteLine("Degage: QCB+K");
                                        Console.WriteLine("Renverse: QCF+P");
                                        Console.WriteLine("- Grand Fouette: K (During Renverse)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Arabesque: QCFx2+K");
                                        Console.WriteLine("LVL2 Etoile: QCBx2+K");
                                        Console.WriteLine("LVL3 Pas de Deux: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Character_Name Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > QCF+MK");
                                        Console.WriteLine("2. CR.LK > CR.LP > QCF+KK > LVL2 (QCBx2+K)");
                                        Console.WriteLine("3. B+MK,MK > QCF+KK > QCB+MK");
                                        Console.WriteLine("4. B+MK,MK > QCB+MK");
                                        Console.WriteLine("5. B+HP > QCB+KK > LK > QCF+MK");
                                        Console.WriteLine("6. B+HP > QCB+KK > CR.MP > QCF+MK");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "CAMMY":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Cammy is a rushdown with aggressive pressure with her divekick and love for cats");
                            Console.WriteLine("\nWhat would you like to learn about Cammy? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Cammy Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Crouching Roundhouse: CR.HK");
                                        Console.WriteLine("Lift Uppercut: B+MP");
                                        Console.WriteLine("Delayed Ripper: F+HK");
                                        Console.WriteLine("Assault Blade: B+HK");
                                        Console.WriteLine("Lift Combination: B+MP > HK");
                                        Console.WriteLine("Swing Combination: HP > HK");
                                        Console.WriteLine("Rough Landing: F+LP+LK");
                                        Console.WriteLine("Delta Throw: B+LP+LK");
                                        Console.WriteLine("Leg Scissors Choke: LP+LK (During a jump)");
                                        break;
                                    case 2:
                                        Console.WriteLine("Character_Name Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Spiral Arrow: QCF+K");
                                        Console.WriteLine("Canon Spike: FDDF+K");
                                        Console.WriteLine("Quick Spin Knuckle: QCB+P");
                                        Console.WriteLine("Cannon Strike: QCB+K (During forward jump)");
                                        Console.WriteLine("Hooligan Combination (HC): QCF+P");
                                        Console.WriteLine("- Razor's Edge Sliver: Don't press any button (During HC)");
                                        Console.WriteLine("- Cannon Strike: K (During HC)");
                                        Console.WriteLine("- Reverse Edge: D+K (During HC)");
                                        Console.WriteLine("- Fatal Leg Twister: LP+LK (During HC)");
                                        Console.WriteLine("- Silent Step: P (During HC)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Spin Drive Smasher: QCFx2+K");
                                        Console.WriteLine("LVL2 Air Killer Bee Spin/Killer Bee Spin: QCBx2+P");
                                        Console.WriteLine("LVL3 Delta Red Assault: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Character_Name Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > DP.HK");
                                        Console.WriteLine("2. CR.LK > CR.LP > CR.LP > LVL1 (QCFx2+K)");
                                        Console.WriteLine("3. MP > LK > QCF+MK");
                                        Console.WriteLine("4. MP > B+MP,HK > J.MP > QCB+KK > LVL1/LVL3 (QCFx2+k/QCFx2+P)");
                                        Console.WriteLine("5. CR.HP > CR.MP > QCF+HK/FDDF+HK");
                                        Console.WriteLine("6. HP,HK > QCB+KK > LVL1 (QCFx2+K)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "AKUMA":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Akuma is a shoto style character that searches for a worthy battle");
                            Console.WriteLine("\nWhat would you like to learn about Akuma? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Akuma Key Moves");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Skull Splitter: F+MP");
                                        Console.WriteLine("Resso Snap Kick: F+MK");
                                        Console.WriteLine("Rago High Kick: B+HK");
                                        Console.WriteLine("Viscera Piercer: MP > MP");
                                        Console.WriteLine("Tenmaku Blade Kick: D+MK (During forward jump)");
                                        Console.WriteLine("Goshoha: F+LP+LK");
                                        Console.WriteLine("Shuretto: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Akuma Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Gou Hadoken: QCF+P");
                                        Console.WriteLine("Zanku Hadoken: QCF+P (During forward jump)");
                                        Console.WriteLine("Gou Shoryuken: FDDF+P");
                                        Console.WriteLine("Air Tatsumaki Zanku-kyaku/Tatsumaki Zanku-kyaku: QCB+K");
                                        Console.WriteLine("Adamant Flame: QCB+P > F+P");
                                        Console.WriteLine("Demon Raid: QCF+K");
                                        Console.WriteLine("- Demon Low Slash: No input (During Demon Raid)");
                                        Console.WriteLine("- Demon Guillontine: P (During Demon Raid)");
                                        Console.WriteLine("- Demon Blade Kick: K (During Demon Raid)");
                                        Console.WriteLine("- Demon Swoop: Hold Down (During Demon Raid)");
                                        Console.WriteLine("- Demon Gou Zanku: QCF+P (During OD Demon Raid)");
                                        Console.WriteLine("- Demon Gou Rasen: QCB+K (During OD Demon Raid)");
                                        Console.WriteLine("Ashura Senku: F+KKK/B+KKK");
                                        Console.WriteLine("Oboro Thow: F+KKK > LP+LK");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Messatsu Gohado/Tenma Gozanku: QCFx2+P/QCFx2+K (During Jump)");
                                        Console.WriteLine("LVL2 Empyrean's End: QCBx2+P");
                                        Console.WriteLine("LVL3 Sip of Calamity: QCFx2+K");
                                        Console.WriteLine("LVL3 Shun Goku Satsu: LP > LP > F+LK > HP (health is 25% or lower)");
                                        break;
                                    case 3:
                                        Console.WriteLine("Akuma Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > QCB+LK > FDDF+HP");
                                        Console.WriteLine("2. CR.LK > CR.LP > CR.LP > QCF+LP,F+P > LVL3 (QCFx2+K)");
                                        Console.WriteLine("3. MP > CR.LP > QCB+LK > FDDF+HP");
                                        Console.WriteLine("4. CR.MP > MP,MP > QCB+PP,F+P > LVL2 (QCBx2+P)");
                                        Console.WriteLine("5. F+HP > CR.LP > LK > QCB+LK > CR.HK");
                                        Console.WriteLine("6. HK > CR.MP > CR.MP > QCF+PP,F+P");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "TERRY":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Terry is a rushdown all rounder character that travelled from Florida to throw hands");
                            Console.WriteLine("\nWhat would you like to learn about Terry? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Terry Key Moves");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Hammer Punch: F+HP");
                                        Console.WriteLine("Power Shoot: MP > HK");
                                        Console.WriteLine("Power Dunk: MP > HK > HK");
                                        Console.WriteLine("Passing Sway: MP > MK");
                                        Console.WriteLine("- Jumping Lariat: MP (After Passing Sway connects)");
                                        Console.WriteLine("- Jumping Knee: MK (After Passing Sway connects)");
                                        Console.WriteLine("Fire Kick: D+MK > D+HK");
                                        Console.WriteLine("Grasping Upper: F+LP+LK");
                                        Console.WriteLine("Buster Throw: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Terry Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Power Wave: QCF+LP/QCF+MP");
                                        Console.WriteLine("Round Wave: QCF+HP");
                                        Console.WriteLine("Quick Burn: QCB+LP");
                                        Console.WriteLine("Burning Knuckle: QCB+MP/QCB+HP");
                                        Console.WriteLine("Power Charge: QCF+K");
                                        Console.WriteLine("Crack Shoot: QCB+K");
                                        Console.WriteLine("Rising Tackle: FDDF+P");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Buster Wolf: QCFx2+K");
                                        Console.WriteLine("LVL2 Power Geyser: QCBx2+P");
                                        Console.WriteLine("- Twin Geyser: PP (After Power Geyser connects)");
                                        Console.WriteLine(" - Triple Geyser: PP (After Twin Geyser connects)");
                                        Console.WriteLine("LVL3 Rising Fang: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Terry Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > QCF+LP/QCF+LK");
                                        Console.WriteLine("2. CR.LK > LP > LP > LVL1/LVL2/LVL3 (QCFx2+K/QCBx2+P/QCFx2+P)");
                                        Console.WriteLine("3. MK > LK > QCF+LK > CR.LP > LP > FDDF+HP");
                                        Console.WriteLine("4. CR.MK,HK > QCB+MK > LVL1 (QCFx2+K)");
                                        Console.WriteLine("5. HP > QCF+HK > QCB+HK > FDDF+HP");
                                        Console.WriteLine("6. HP > QCF+HK > QCB+KK > FDDF+LP > LVL3 (QCFx2+P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "MAI":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Mai is a rushdown character that's shows her ninja skills");
                            Console.WriteLine("\nWhat would you like to learn about Mai? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Mai Key Moves");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Senkotsu Uchi: F+MP");
                                        Console.WriteLine("Hien Ren Kyaku: LK > LK > LK");
                                        Console.WriteLine("Shiranui Gourin: F+LP+LK");
                                        Console.WriteLine("Fuusha Kuzushi: B+LP+LK");
                                        Console.WriteLine("Yume Zakura: LP+LK (During a jump)");
                                        break;
                                    case 2:
                                        Console.WriteLine("Mai Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Kachousen: QCF+P");
                                        Console.WriteLine("- Midare Kachousen: F+P");
                                        Console.WriteLine("Ryuuenbu: QCB+P");
                                        Console.WriteLine("Hissatsu Shinobi Bachi: QCF+K");
                                        Console.WriteLine("Hishou Ryuuenjin: FDDF+K");
                                        Console.WriteLine("Musasabi no Mai: QCB+P");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Kagerou no Mai: QCFx2+P");
                                        Console.WriteLine("LVL2 Chou Hissatsu Shinobu Bachi: QCF+K");
                                        Console.WriteLine("LVL3 Shiranui Ryuu: Enbu Ada Zakura: QCBx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Mai Combos");
                                        Console.WriteLine("1. CR.LP > CR.LP > CR.LP > QCF+LK");
                                        Console.WriteLine("2. LP > LP > LP > QCB+PP > FDDF+HK");
                                        Console.WriteLine("3. CR.MP > QCF+KK > MP > QCB+PP > LVL2 (QCFx2+K)");
                                        Console.WriteLine("4. CR.MP > QCB+PP > LVL1 (QCFx2+P)");
                                        Console.WriteLine("5. HP > QCB+HP > QCF+LK");
                                        Console.WriteLine("6. CR.HP > LP > QCF+KK > MP > QCB+P");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        //Hard to learn characters
                        case "CHUN LI":
                            Console.WriteLine("\nDifficulty: Hard");
                            Console.WriteLine("Chun Li is a footise based character that looks opponents mistakes and counters them for it.");
                            Console.WriteLine("\nWhat would you like to learn about Chun Li? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Chun Li Key Moves");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Swift Thurst: B+MP/F+MP");
                                        Console.WriteLine("Hakkei: B+HP");
                                        Console.WriteLine("Water Lotus Fist: DF+HP");
                                        Console.WriteLine("Yokusen Kick: F+HK");
                                        Console.WriteLine("Yoso Kick: D+MK (During a jump)");
                                        Console.WriteLine("Koshuto: F+LP+LK");
                                        Console.WriteLine("Taiji Fan: B+LP+LK");
                                        Console.WriteLine("Ryuseiraku: LP+LP (During a jump)");
                                        break;
                                    case 2:
                                        Console.WriteLine("Character_Name Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Kikoken: BF+P (Hold Back for 2 secs then F+P)");
                                        Console.WriteLine("Air Hundred Lighting Kicks/Hundred Lighting Kicks (HLK): QCF+K");
                                        Console.WriteLine("- Lighting Kick Barrage: KK (After OD HLK)");
                                        Console.WriteLine("Spinning Bird Kick: DU+K (Hold down for 2 secs then U+K)");
                                        Console.WriteLine("Hazanshu: QCB+K");
                                        Console.WriteLine("Tensho Kicks: DD+K");
                                        Console.WriteLine("Serenity Stream: QCB+P");
                                        Console.WriteLine("- Orchid Palm: LP (During Serenity Stream)");
                                        Console.WriteLine("- Snake Strike MP (During Serenity Stream)");
                                        Console.WriteLine("- Lotus Fist: HP (During Serenity Stream)");
                                        Console.WriteLine("- Forward Strike: LK (During Serenity Stream)");
                                        Console.WriteLine("- Senpu Kick: MK (During Serenity Stream)");
                                        Console.WriteLine("- Tenku Kick: HK (During Serenity Stream)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Air Kikosho/Kikosho: QCFx2+P");
                                        Console.WriteLine("LVL2 Hoyoku-sen: QCFx2+K");
                                        Console.WriteLine("LVL3 Soten Ranka: QCBx2+K");
                                        break;
                                    case 3:
                                        Console.WriteLine("Chun Li Combos");
                                        Console.WriteLine("1. CR.LK > LP > LK > QCF+MK");
                                        Console.WriteLine("2. LP > MP > CR.MP > DU+KK > QCF+LK > LVL3 (QCBx2+K)");
                                        Console.WriteLine("3. MP > CR.MP > DU+MK (Hold down for 2 secs and pres U+MK)");
                                        Console.WriteLine("4. MK > QCB+P,HK > J.HP,HP > LVL1 (QCFx2+P)");
                                        Console.WriteLine("5. B+HP > QCF+HK > LVL1 (QCFx2+P)");
                                        Console.WriteLine("6. HK > QCB+P,MK > BF+PP > LK > QCF+MK");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "JURI":
                            Console.WriteLine("\nDifficulty: Hard");
                            Console.WriteLine("Juri is a crazy thrillseeker that focuses on pressure and overwhelming you.");
                            Console.WriteLine("\nWhat would you like to learn about Juri? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Juri Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Crouching Roundhouse: CR.HK");
                                        Console.WriteLine("Kyosesho: F+MP");
                                        Console.WriteLine("Senkai Kick: F+MK");
                                        Console.WriteLine("Renko Kicks: F+HP");
                                        Console.WriteLine("Korenzan: B+HK");
                                        Console.WriteLine("Death Crest: MP > B+HP > HP");
                                        Console.WriteLine("Spider Fang Throw: F+LP+LK");
                                        Console.WriteLine("Shadow Kick Throw: B+LP+LK");
                                        Console.WriteLine("Zanka-sen: LP+LK (During a jump)");
                                        break;
                                    case 2:
                                        Console.WriteLine("Juri Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Fuhajin: QCB+K");
                                        Console.WriteLine("Saihasho: QCF+LK (LK to activate)");
                                        Console.WriteLine("Ankensatsu: QCF+MK (MK to activate)");
                                        Console.WriteLine("Go Ohsatsu: QCF+HK (HK to activate)");
                                        Console.WriteLine("Tensenrin: FDDF+P");
                                        Console.WriteLine("Shiku-sen: QCB+K (During a forward jump)");
                                        Console.WriteLine("- Shiren-sen: K (After Shiku-sen)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Sakkai Fuhazan: QCFx2+K");
                                        Console.WriteLine("LVL2 Feng Shui Engine: QCBx2+P");
                                        Console.WriteLine("LVL3 Kaisen Dankai Raku: QCBx2+K");
                                        break;
                                    case 3:
                                        Console.WriteLine("Juri Combos");
                                        Console.WriteLine("1. CR.LK > LP > LK > FDDF+HP");
                                        Console.WriteLine("2. LP > MK > QCB+HK > LVL1 (QCFx2+K)");
                                        Console.WriteLine("3. MP > CR.MP > FDDF+LP");
                                        Console.WriteLine("4. CR.MP > MK > QCF+MK > F+MP > QCF+MK,HK > LVL1 (QCFx2+K)");
                                        Console.WriteLine("5. HP > QCB+HK > FDDF+HP");
                                        Console.WriteLine("6. F+HP > QCF+MK > F+MP > QCF+MK,HK");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "DHALSIM":
                            Console.WriteLine("\nDifficulty: Hard");
                            Console.WriteLine("Dhalsim is a zoning character that thrives on long range along with yoga as well.");
                            Console.WriteLine("\nWhat would you like to learn about Dhalsim? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Dhalsim Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Standing Short: LK");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Short: CR.LK");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Crouching Roundhouse: CR.HK");
                                        Console.WriteLine("Yoga Uppercut: B+MP");
                                        Console.WriteLine("Yoga Lance: B+HP");
                                        Console.WriteLine("Nirvana Punch: DB+HP");
                                        Console.WriteLine("Diving Kick: B+MK");
                                        Console.WriteLine("Yoga Mountain: B+HK");
                                        Console.WriteLine("Yoga Mummy: D+LP (During a jump)");
                                        Console.WriteLine("Drill Kick: D+K (During a jump)");
                                        Console.WriteLine("Thrust Kick: DB+MK");
                                        Console.WriteLine("Yoga Smash: F+LP+LK");
                                        Console.WriteLine("Yoga Throw: B+LP+LK");
                                        Console.WriteLine("Yoga Splash: D+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Dhalsim Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Yoga Fire: QCF+P");
                                        Console.WriteLine("Yoga Arch: QCF+K");
                                        Console.WriteLine("Yoga Flame: HCB+P");
                                        Console.WriteLine("Yoga Blast: HCB+K");
                                        Console.WriteLine("Yoga Comet: HCB+P (During a jump)");
                                        Console.WriteLine("Aerial Yoga Float/Yoga Float: D+KK/DF+KK");
                                        Console.WriteLine("Aerial Yoga Teleport/Yoga Teleport: F+PPP/B+PPP/F+KKK/B+KKK");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Yoga Inferno: QCFx2+P");
                                        Console.WriteLine("LVL2 Yoga Sunburst: QCBx2+K");
                                        Console.WriteLine("LVL3 Merciless Yoga: QCFx2+K");
                                        break;
                                    case 3:
                                        Console.WriteLine("Dhalsim Combos");
                                        Console.WriteLine("1. LP > CR.LP > QCF+PP");
                                        Console.WriteLine("2. DB+LK > CR.LP > CR.LP > LVL1 (QCFx2+P)");
                                        Console.WriteLine("3. CR.MP/DB+MK > HCB+LP");
                                        Console.WriteLine("4. CR.MP > HCB+PP > LVL1 (QCFx2+P)");
                                        Console.WriteLine("5. DB+MK > HCB+PP > CR.HK");
                                        Console.WriteLine("6. DB+MK > HCB+PP > HK > LVL1 (QCFx2+P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "JP":
                            Console.WriteLine("\nDifficulty: Hard");
                            Console.WriteLine("JP with his gentleman attire, focus on trying to keep the opponent in far range.");
                            Console.WriteLine("\nWhat would you like to learn about JP? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("JP Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Guillotinna: F+MK");
                                        Console.WriteLine("Malice: DF+HP");
                                        Console.WriteLine("Bylina: F+HK");
                                        Console.WriteLine("Grom Strelka: B+MP > MP");
                                        Console.WriteLine("Zilant: HK > HP");
                                        Console.WriteLine("Ravina: F+LP+LK");
                                        Console.WriteLine("Uragan: B+LP+LK");
                                        Console.WriteLine("Tornado: LP+LP (During a jump)");
                                        break;
                                    case 2:
                                        Console.WriteLine("JP Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Triglav: DD+P");
                                        Console.WriteLine("Stribog: QCF+P");
                                        Console.WriteLine("Departure: QCB+P");
                                        Console.WriteLine("- Departure-Window: QCB+LP/QCB+MP (While Departure is out)");
                                        Console.WriteLine("- Departure-Shadow: QCB+HP (While Departure is out)");
                                        Console.WriteLine("Amnesia: DD+K");
                                        Console.WriteLine("Torbalan: QCF+K");
                                        Console.WriteLine("Embrace: QCB+K");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Chornobog: QCFx2+P");
                                        Console.WriteLine("LVL2 Lovushka: QCBx2+P");
                                        Console.WriteLine("LVL3 Interdiction: QCFx2+K");
                                        break;
                                    case 3:
                                        Console.WriteLine("JP Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > LP > QCF+LP");
                                        Console.WriteLine("2. CR.LK > CR.LP > LP > QCF+LP > LVL1/LVL3 (QCFx2+P/QCFx2+K)");
                                        Console.WriteLine("3. B+MP > CR.LP > LP > QCF+LP");
                                        Console.WriteLine("4. B+MP,MP > QCF+PP > DD+MP > LVL3 (QCFx2+K)?");
                                        Console.WriteLine("5. HK > CR.MP > QCF+MP");
                                        Console.WriteLine("6. F+HK > QCF+MK > LVL3 (QCFx2+K)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "ZANGEIF":
                            Console.WriteLine("\nDifficulty: Hard");
                            Console.WriteLine("Zangief is close range grappler where his main focus is to put the graps on you for muscle power.");
                            Console.WriteLine("\nWhat would you like to learn about Zangief? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Zangief Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Crouching Roundhouse: CR.HK");
                                        Console.WriteLine("Hellstab: DF+MP");
                                        Console.WriteLine("Knee Hammer: F+MK");
                                        Console.WriteLine("Headbutt: F+HP");
                                        Console.WriteLine("Cyclone Wheel Kick: F+HK");
                                        Console.WriteLine("Smetana Dropkick: DF+HK");
                                        Console.WriteLine("Machine Gun Chops: MP > MP > MP");
                                        Console.WriteLine("Power Stomps: DD+MK > MK > MK");
                                        Console.WriteLine("Bodyslam: LP+LK");
                                        Console.WriteLine("Capture Suplex: B+LP+LK");
                                        Console.WriteLine("German Suplex: F+LP+LK");
                                        Console.WriteLine("Spinebuster: DF+LP+LK");
                                        Console.WriteLine("Russian Drop: DB+LP+LK");
                                        Console.WriteLine("Brain Buster: D+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Zangief Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Double Lariat: PP");
                                        Console.WriteLine("Screw Piledriver: 360 Motion+P");
                                        Console.WriteLine("Borscht Dynamite: 360 Motion+K (During a jump)");
                                        Console.WriteLine("Russian Suplex: HCB+K");
                                        Console.WriteLine("Siberian Express: HCB+K (When far from opponent)");
                                        Console.WriteLine("Tundra Storm: DD+HK");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Air Russian Slam: QCFx2+K");
                                        Console.WriteLine("LVL2 Cyclone Lariat: QCFx2+P");
                                        Console.WriteLine("LVL3 Bolshoi Storm Buster: 360 Motionx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Zangief Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > PP");
                                        Console.WriteLine("2. CR.LK > CR.LP > PPP > LVL2 (QCFx2+P)");
                                        Console.WriteLine("3. CR.MP + PP");
                                        Console.WriteLine("4. DD+MK > CR.LK > CR.LP > PPP");
                                        Console.WriteLine("5. F+HP > PP");
                                        Console.WriteLine("6. F+HP > CR.LP > PPP");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "RASHID":
                            Console.WriteLine("\nDifficulty: Hard");
                            Console.WriteLine("Rashid is a rushdown/setup character that expresses his pressure and mixups with his wind and parkout");
                            Console.WriteLine("\nWhat would you like to learn about Rashid? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Rashid Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Flapping Spin: F+MP");
                                        Console.WriteLine("Beak Assault: F+HP");
                                        Console.WriteLine("Rising Kick: MP > HK");
                                        Console.WriteLine("Riding Glider: F+LP+LK");
                                        Console.WriteLine("Sunset Drop: B+LP+LK");
                                        Console.WriteLine("Desert Slider: LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Rashid Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Spinning Mixer: QCF+P");
                                        Console.WriteLine("Eagle Spike: QCB+K");
                                        Console.WriteLine("Whirlwind Shot: QCF+K");
                                        Console.WriteLine("Arabian Cyclone: QCB+P");
                                        Console.WriteLine("- Wing Stroke: B+K (During Arabian Cyclone)");
                                        Console.WriteLine("- Rolling Assault: F+K (During Arabian Cyclone)");
                                        Console.WriteLine(" - Nail Assault: K (During Rolling Assault)");
                                        Console.WriteLine("Arabian Skyhigh: QCB+K (During a forward jump)");
                                        Console.WriteLine("Run: FF (Hold Second F)");
                                        Console.WriteLine("- Backup: F+P (During Run)");
                                        Console.WriteLine("- Tempest Moon: F+K (During Run)");
                                        Console.WriteLine("Side Flip: F+KK");
                                        Console.WriteLine("- Front Flip: F+PP/B+PP");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Super Rashid Kick: QCFx2+K");
                                        Console.WriteLine("LVL2 Ysaar: QCBx2+K");
                                        Console.WriteLine("LVL3 Altair: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Rashid Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > LP > QCF+LP/QCF+MP");
                                        Console.WriteLine("2. CR.LK > LP > LP > LVL1 (QCFx2+K)");
                                        Console.WriteLine("3. CR.MP > LK > QCB+LK");
                                        Console.WriteLine("4. MP,HK > QCB+HP,B+K > J.MP > LVL1 (QCFx2+K)");
                                        Console.WriteLine("5. HP > QCB+MK");
                                        Console.WriteLine("6. HP > QCB+PP,F+K,K > LVL3 (QCFx2+P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "AKI":
                            Console.WriteLine("\nDifficulty: Hard");
                            Console.WriteLine("AKI as cool as she looks, inflicits poisons with her rushdown and setups.");
                            Console.WriteLine("\nWhat would you like to learn about AKI? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("AKI Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Crouching Roundhouse: CR.HK");
                                        Console.WriteLine("Pu Lao: DF+MP");
                                        Console.WriteLine("Chi Wen: F+HP");
                                        Console.WriteLine("Qiu Niu: F+HK");
                                        Console.WriteLine("Hun Dun: LP > LP");
                                        Console.WriteLine("Qiong Qi: HP > HP");
                                        Console.WriteLine("Whisper: F+LP+LK");
                                        Console.WriteLine("Gluttony: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Character_Name Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Nightshade Pulse: QCB+LP");
                                        Console.WriteLine("- Nightshade Chaser: F+P (During Nightshade Pulse)");
                                        Console.WriteLine("Orchide Spring: QCB+MP");
                                        Console.WriteLine("Toxic Wreath: QCB+HP");
                                        Console.WriteLine("Serpent Lash: QCF+P");
                                        Console.WriteLine("Cruel Fate: QCB+K");
                                        Console.WriteLine("Snake Step: QCF+K");
                                        Console.WriteLine("Sinister Slide: D+PP");
                                        Console.WriteLine("- Venomous Fang: P (During Sinister Slide)");
                                        Console.WriteLine("- Heel Strike: K (During Sinister Slide)");
                                        Console.WriteLine("- Entrapment: LP+LK (During Sinister Slide)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Deadly Implication: QCFx2+K");
                                        Console.WriteLine("LVL2 Tainted Talons: QCBx2+P");
                                        Console.WriteLine("LVL3 Claws of Ya Zi: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Character_Name Combos");
                                        Console.WriteLine("1. LK > CR.LP > CR.LP > QCB+HP");
                                        Console.WriteLine("2. CR.LK > CR.LP > CR.LP > QCF+HP > LVL3 (QCFx2+P)");
                                        Console.WriteLine("3. MK > MP > QCB+LP,F+LP");
                                        Console.WriteLine("4. MK > MP > QCB+PP,F+P > LVL 2 (QCBx2+P)");
                                        Console.WriteLine("5. F+HK > CR.LP > CR.LP > QCF+HP");
                                        Console.WriteLine("6. HP,HP > QCF+PP > QCF+HP > LVL1/LVL2/LVL3 (QCFx2+K/QCBx2+P/QCFx2P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "ED":
                            Console.WriteLine("\nDifficulty: Hard");
                            Console.WriteLine("Ed trained by Balrog and leader of Neo-Shadaloo, controls spacing along with applying pressure.");
                            Console.WriteLine("\nWhat would you like to learn about Ed? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Ed Key Moves");
                                        Console.WriteLine("Psycho Knuckle: Hold HP");
                                        Console.WriteLine("Cobra Punch: F+HP");
                                        Console.WriteLine("Flicker Combination: LK + LK + LK");
                                        Console.WriteLine("Body Blow Combination: MP > HP");
                                        Console.WriteLine("Hitman Combination: MK > MK > HP");
                                        Console.WriteLine("Low Smash Combination: D+HK > HP");
                                        Console.WriteLine("Face Buster: F+LP+LK");
                                        Console.WriteLine("Rib Crusher: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Ed Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Psycho Spark: QCF+P");
                                        Console.WriteLine("- Psycho Shoot: F+P (During Spark)");
                                        Console.WriteLine("Psycho Uppercut: FDDF+P");
                                        Console.WriteLine("Psycho Blitz: QCB+P");
                                        Console.WriteLine("Psycho Flicker: QCF+K");
                                        Console.WriteLine("Kill Rush (Forward) (KRF): F+KK");
                                        Console.WriteLine("- Kill Switch Break: F+P (During first half of KRF)");
                                        Console.WriteLine("- Kill Switch Chaser: F+P (During latter of KRF)");
                                        Console.WriteLine("Kill Rush (Backward): B+KK");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Psycho Storm: QCFx2+K");
                                        Console.WriteLine("LVL2 Psycho Cannon: QCBx2+P");
                                        Console.WriteLine("LVL3 Psycho Chamber: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Ed Combos");
                                        Console.WriteLine("1. CR.LP > LP > LP > QCB+MP");
                                        Console.WriteLine("2. CR.LP > LP > LP > QCB+MP > LVL3 (QCFx2+P)");
                                        Console.WriteLine("3. CR.MK > MP,HP > QCB+HP/FDDF+HP");
                                        Console.WriteLine("4. CR.MK > MP,HK > QCF+KK > FDDF+LP > QCB+LP");
                                        Console.WriteLine("5. HP > CR.LK > FDDF+MP");
                                        Console.WriteLine("6. HP (HOLD) > HP > QCF+KK > FDDF+HP > QCB+HP > LVL3 (QCFx2+P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "M.BISON":
                            Console.WriteLine("\nDifficulty: Hard");
                            Console.WriteLine("M.Bison the former head of Shadaloo with amnesia, focuses on defensive and applying pressure.");
                            Console.WriteLine("\nWhat would you like to learn about M.Bison? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("M.Bison Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Crouching Roundhouse: CR.HK");
                                        Console.WriteLine("Psycho Hammer: F+HP");
                                        Console.WriteLine("Evil Knee: B+HK");
                                        Console.WriteLine("Hover Kick: DF+HK");
                                        Console.WriteLine("Shadow Hammer: MP > F+HP");
                                        Console.WriteLine("Deadly Throw: F+LP+LK");
                                        Console.WriteLine("Death Tower: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("M.Bison Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Psycho Crusher Attack: BF+P (Hold back for 2 secs then F+P)");
                                        Console.WriteLine("Double Knee Press: QCF+K");
                                        Console.WriteLine("Backfist Combo: QCB+P");
                                        Console.WriteLine("Shadown Rise: DU+K (Hold down for secs then U+K)");
                                        Console.WriteLine("- Head Press: K (During Shadow Rise)");
                                        Console.WriteLine(" - Somersault Skull Diver: P (After Head Press connects)");
                                        Console.WriteLine("- Devil Reverse (During Shadow Rise)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Knee Press Nightmare: QCFx2+K");
                                        Console.WriteLine("LVL2 Psycho Punisher: QCBx2+K");
                                        Console.WriteLine("LVL3 Unlimited Psycho Crusher: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("M.Bison Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > LP/CR.LP > QCF+LK");
                                        Console.WriteLine("2. CR.LK > CR.LP > LP/CR.LP > QCB+PP > LVL2 (QCBx2+K)");
                                        Console.WriteLine("3. MP > CR.MP > BF+MP (Hold Back for 2 secs then F+MP)");
                                        Console.WriteLine("4. CR.MP/CR.MK > QCB+MP/QCF+MK");
                                        Console.WriteLine("5. HP > LK > QCB+LP");
                                        Console.WriteLine("6. B+HK > LK > QCB+LP/QCF+LK");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                    }
                    break;
                }
            }


        }

        public static void MK1_Characters()
        {
            string mk1_fighter = "";
            int mk1_option;
            int mk1character;

            List<String> mk1 = new List<String>();
            //Easy to learn Mortal Kombat 1 MK1_Characters
            mk1.Add("Liu Kang");
            mk1.Add("Sub-Zero");
            mk1.Add("Scorpion");
            mk1.Add("Baraka");
            mk1.Add("Kung Lao");
            mk1.Add("Reptile");
            mk1.Add("Raiden");
            mk1.Add("Kitana");
            mk1.Add("Havik");
            mk1.Add("Mileena");
            mk1.Add("Sektor");
            mk1.Add("T-1000");
            mk1.Add("Peacemaker");
            mk1.Add("Li-Mei");
            mk1.Add("Reiko");
            mk1.Add("Conan");

            //Intermediate to learn
            mk1.Add("Johnny Cage");
            mk1.Add("General Shao");
            mk1.Add("Tanya");
            mk1.Add("Takeda");
            mk1.Add("Ermac");
            mk1.Add("Cyrax");
            mk1.Add("Ghostface");
            mk1.Add("Smoke");
            mk1.Add("Omni-Man");

            //Advanced to learn
            mk1.Add("Geras");
            mk1.Add("Kenshi");
            mk1.Add("Nitara");
            mk1.Add("Shang Tsung");
            mk1.Add("Rain");
            mk1.Add("Sindel");
            mk1.Add("Ashrah");
            mk1.Add("Homelander");
            mk1.Add("Quan Chi");
            mk1.Add("Noob-Saibot");

            Console.WriteLine("\nMortal Kombat 1 has 35 Characters.");
            Console.WriteLine("Would you like to pick your character or have it picked randomly?");
            Console.WriteLine("Enter the number for the option.");
            Console.WriteLine("1. Pick your character \n2. Randomly pick my character");
            Console.WriteLine("Input: ");

            if (int.TryParse(Console.ReadLine(), out mk1character))
            {

            };

            if (mk1character == 1)
            {
                bool repeatcode = true;
                while (repeatcode)
                {
                    Console.WriteLine("Which Mortal Kombat 1 character would you like learn?\n");
                    Console.WriteLine("List of current MK1 Characters");
                    foreach (String characters in mk1)
                    {
                        Console.WriteLine(characters);
                    }

                    Console.WriteLine("\nInput: ");
                    mk1_fighter = Console.ReadLine();
                    mk1_fighter = mk1_fighter.ToUpper();

                    bool repeatcharacter = true;
                    while (repeatcharacter)
                    {
                        switch (mk1_fighter)
                        {
                            //Easy to learn
                            case "LIU KANG":
                                Console.WriteLine("Difficulty: Easy");
                                Console.WriteLine("Liu Kang is a all rounder with good attacks and projectiles.");
                                Console.WriteLine("\n What would you like to learn about Liu Kang? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Liu Kang Key Moves:");
                                            Console.WriteLine("Bare Knuckles: 1,2");
                                            Console.WriteLine("Shaolin Stutter: F+1,4");
                                            Console.WriteLine("Dragon Fangs: 2,2");
                                            Console.WriteLine("Holding Back: 3,3,3");
                                            Console.WriteLine("The Creator: F+4,3");
                                            Console.WriteLine("TailWhip: B+2,3");
                                            break;
                                        case 2:
                                            Console.WriteLine("Liu Kang Special Moves");
                                            Console.WriteLine("Cosmic Flame: BF+1");
                                            Console.WriteLine("Low Dragon: DB+1");
                                            Console.WriteLine("Dragon's Tail: BF+3");
                                            Console.WriteLine("Dancing Dragon: BF+4");
                                            Console.WriteLine("Dragon's Breath: DB+4");
                                            break;
                                        case 3:
                                            Console.WriteLine("Liu Kang Combos");
                                            Console.WriteLine("1. F+4,3 > BF+3");
                                            Console.WriteLine("2. 1,2 > BF+1");
                                            Console.WriteLine("3. F+1,4 > DB+4 > DASH > 333 > BF+3");
                                            Console.WriteLine("4. F+1,4 > DB+4 > DASH > B+2,3 > 4 > BF+3");
                                            Console.WriteLine("5. 333 > DB+4 > DASH > B+2,3 > DASH > 33 > BF+3");
                                            Console.WriteLine("6. B+2,3 > B+2,3 > DASH > 333 > BF+3");
                                            break;
                                        case 4:
                                            Console.WriteLine("Liu Kang Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Kung Lao,Scorpion,Sonya,Sareena,Darrius,Ferra,Janet Cage,Khameleon,Stryker,Madam Bo");
                                            Console.WriteLine("-Intermediate: Cyrax,Frost,Goro,Jax,Kano,Mavado,Sub-Zero,Tremor,Sektor");
                                            Console.WriteLine("-Advanced: Motaro,Shujinko");
                                            break;

                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "SUB-ZERO":
                                Console.WriteLine("Difficulty: Easy");
                                Console.WriteLine("Sub-Zero is known for his space control, mix-up options, and zoning.");
                                Console.WriteLine("\n What would you like to learn about Sub-Zero? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Sub-Zero Key Moves:");
                                            Console.WriteLine("Lin Keui Storm: 1,2");
                                            Console.WriteLine("Blistering Blizzard: 2,1");
                                            Console.WriteLine("Frozen Over: F+1,2");
                                            Console.WriteLine("Shin Shatter: B+3");
                                            Console.WriteLine("Spinal Tap: B+2");
                                            break;
                                        case 2:
                                            Console.WriteLine("Sub-Zero Special Moves");
                                            Console.WriteLine("Ice Ball: DF+1");
                                            Console.WriteLine("Ice Klone: DB+1");
                                            Console.WriteLine("Ice Klone Charge: BF+2");
                                            Console.WriteLine("Ice Slide: BF+3");
                                            Console.WriteLine("Diving Glacier: J.DB+4");
                                            Console.WriteLine("Deadly Vapors: DF+4");
                                            break;
                                        case 3:
                                            Console.WriteLine("Sub-Zero Combos");
                                            Console.WriteLine("1. 2,1 > BF+3");
                                            Console.WriteLine("2. B+2 > J1,2 > J.1,2 > F+1,2 > BF3");
                                            Console.WriteLine("3. B+2 > B+2 > J.1,2 > F+1,2 > BF+3");
                                            Console.WriteLine("4. J.1,2 > J.1,2 > F+1,2 > BF+3");
                                            Console.WriteLine("5. B2 > J.2,2 > DB4 > F+1,2 > BF+3");
                                            Console.WriteLine("6. F+1,2 > EXDF4 > B+2 > B+2 > J.1,2 > F+1,2 > BF+3");
                                            break;
                                        case 4:
                                            Console.WriteLine("Sub-Zero Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Sareena,Khameleon,Kung Lao,Sonya,Ferra,Kung Lao,Mavado,Madam Bo,Scorpion");
                                            Console.WriteLine("-Intermediate: Cyrax,Darrius,Goro,Janet Cage,Kano,Khameleon,Stryker,Motaro,Sektor,Sub-Zero,Tremor");
                                            Console.WriteLine("-Advanced: Shujinko");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "SCORPION":
                                Console.WriteLine("Difficulty: Easy");
                                Console.WriteLine("Scorpion is known for his rushdown pressure with a mix of close and mid range attacks.");
                                Console.WriteLine("\n What would you like to learn about Scorpion? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Scorpion Key Moves:");
                                            Console.WriteLine("Whiplash: 1,2");
                                            Console.WriteLine("Inner Pain: 2,1");
                                            Console.WriteLine("Shirai Who: 3,3");
                                            Console.WriteLine("Krackjaw: 3,3,3");
                                            Console.WriteLine("Raising Hell: F+3,2");
                                            break;
                                        case 2:
                                            Console.WriteLine("Scorpion Special Moves");
                                            Console.WriteLine("Spear: BF+1");
                                            Console.WriteLine("Blazing Charge: BF+2");
                                            Console.WriteLine("Kyo Snag: J.BF+2");
                                            Console.WriteLine("Close Kyo Snag: J.DB+2");
                                            Console.WriteLine("Twisted Kyo: DB+2");
                                            Console.WriteLine("Flame-Port: DB+3");
                                            Console.WriteLine("Devouring Flame: BF+4");
                                            break;
                                        case 3:
                                            Console.WriteLine("Scorpion Combos");
                                            Console.WriteLine("1. 1,2 > BF+2");
                                            Console.WriteLine("2. 3,3 > DB+2");
                                            Console.WriteLine("3. 2,1 > BF+4");
                                            Console.WriteLine("4. 1,2 > BF+1 > 333 > BF+2");
                                            Console.WriteLine("5. 1,2 > BF+1 > F+3,2 > F+3,2 > F+3,2 > 4 > BF+2");
                                            Console.WriteLine("6. 2,1 > BF+1 > F+3,2 > F+3,2 > J.1,2 > EXDB+2 > J.3 > BF+2");
                                            break;
                                        case 4:
                                            Console.WriteLine("Scorpion Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Sektor,Frost,Sareena,Ferra,Janet Cage,Khameleon,Kung Lao,Stryker,Mavado,Madam Bo,Scorpion,Sonya");
                                            Console.WriteLine("-Intermediate: Cyrax,Darrius,Frost,Goro,Jax,Kano,Tremor");
                                            Console.WriteLine("-Advanced: Shujinko,Motaro");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "BARAKA":
                                Console.WriteLine("Difficulty: Easy");
                                Console.WriteLine("Baraka is known for his aggressive playstyle and overwheling opponents with strong attacks and mix ups.");
                                Console.WriteLine("\n What would you like to learn about Baraka? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Baraka Key Moves:");
                                            Console.WriteLine("Gutwrencher: 1,2");
                                            Console.WriteLine("Reflex Tester: B+1");
                                            Console.WriteLine("Gurgler: 2,1");
                                            Console.WriteLine("Bleeding Foot: B+3");
                                            Console.WriteLine("Slaughterhouse: 4,4,4,4,4,4");
                                            Console.WriteLine("Muay Kry: F+4");
                                            Console.WriteLine("Battle Cry: B+3,1");
                                            break;
                                        case 2:
                                            Console.WriteLine("Baraka Special Moves");
                                            Console.WriteLine("Air Blade Sparks: J.DB+1");
                                            Console.WriteLine("Air Death Spin: J.DF+2");
                                            Console.WriteLine("Baraka Barrage: DF+2");
                                            Console.WriteLine("Bledding Blade: BF+1");
                                            Console.WriteLine("Chop Chop: BF+3");
                                            Console.WriteLine("Stab Stab: DB+1");
                                            break;
                                        case 3:
                                            Console.WriteLine("Baraka Combos");
                                            Console.WriteLine("1. 4,4,4,4,4,4 > DB+1");
                                            Console.WriteLine("2. 2,1 > BF+3");
                                            Console.WriteLine("3. 2,1 > DF+2");
                                            Console.WriteLine("4. B+3,1 > J.1,4 > 2,1 > DF+2");
                                            Console.WriteLine("5. B+3,1 > B+3,1 > DASH > 2,1 > DB+1");
                                            Console.WriteLine("6. F+3 > B+3,1 > DASH > 2,1 > DF+2");
                                            break;
                                        case 4:
                                            Console.WriteLine("Baraka Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Cyrax,Ferra,Frost,Janet Cage,Jax,Kano,Khameleon,Kung Lao,Sareena,Scorpion,Sub-Zero,Sonya");
                                            Console.WriteLine("-Intermediate: Darrius,Goro,Stryker,Mavado,Madam Bo,Sektor,Tremor");
                                            Console.WriteLine("-Advanced: Shujinko,Motaro");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "KUNG LAO":
                                Console.WriteLine("Difficulty: Easy");
                                Console.WriteLine("Kung Lao is a known for his hard hitting pressure and mix ups.");
                                Console.WriteLine("\n What would you like to learn about Kung Lao? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Kung Lao Key Moves:");
                                            Console.WriteLine("Swollen Throat: 1,2,1");
                                            Console.WriteLine("Madam El-Bo: 2,1,2");
                                            Console.WriteLine("Downward Slice: F+2");
                                            Console.WriteLine("Knee Buckle: B+3");
                                            Console.WriteLine("Leg Day: F+3,3");
                                            Console.WriteLine("Human Weapon: B+2,4");
                                            break;
                                        case 2:
                                            Console.WriteLine("Kung Lao Special Moves");
                                            Console.WriteLine("Air Dive Kick: J.DB+4");
                                            Console.WriteLine("Buzzsaw: BF+1");
                                            Console.WriteLine("Hat Toss: DB+1");
                                            Console.WriteLine("Kung-Kussion: DB+2");
                                            Console.WriteLine("Shaolin Shimmy: BF+2");
                                            Console.WriteLine("Shaolin Spin: DU+3");
                                            Console.WriteLine("Soaring Monk: DB+4");
                                            break;
                                        case 3:
                                            Console.WriteLine("Kung Lao Combos");
                                            Console.WriteLine("1. 2,1,2 > DB+4");
                                            Console.WriteLine("2. 1,2,1 > BF+1");
                                            Console.WriteLine("3. 1,2,1 > DB+1");
                                            Console.WriteLine("4. B+2,4 > B+2,4 > 1,2,1 > BF+2");
                                            Console.WriteLine("5. B+2,4 > B+2,4 > DASH > F+3,3 > EXDB+2 > 4 > DB+2");
                                            Console.WriteLine("6. 2,1,2 > EXDB+4 > J.2 > DASH > B+2,4 > DASH > 1,2,1 > BF+2");
                                            break;
                                        case 4:
                                            Console.WriteLine("Kung Lao Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Kung Lao,Goro,Ferra,Janet Cage,Jax,Khameleon,Mavado,Madam Bo,Sareena");
                                            Console.WriteLine("-Intermediate: Cyrax,Darrius,Kano,Stryker,Scorpion,Sektor,Sub-Zero,Sonya,Frost");
                                            Console.WriteLine("-Advanced: Shujinko,Motaro,Tremor");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "REPTILE":
                                Console.WriteLine("Difficulty: Easy");
                                Console.WriteLine("Reptile is knowing for space control with his projectiles and confusing opponents with his invisibility along with mix-ups and combos.");
                                Console.WriteLine("\n What would you like to learn about Reptile? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Reptile Key Moves:");
                                            Console.WriteLine("Kroco-Die-Le: 1,1");
                                            Console.WriteLine("Froggy Knee: 2,3");
                                            Console.WriteLine("Raking Blow: F+2,1");
                                            Console.WriteLine("Bloody Trail: B+3,1");
                                            Console.WriteLine("Hidden Klaws: F+3,1");
                                            Console.WriteLine("Visceral Klaw: F+3,2");
                                            break;
                                        case 2:
                                            Console.WriteLine("Reptile Special Moves");
                                            Console.WriteLine("Acid Spit: DF+1");
                                            Console.WriteLine("Air Falling Fangs: J.DB+4");
                                            Console.WriteLine("Dash Attack: BF+2");
                                            Console.WriteLine("Death Roll: BF+4");
                                            Console.WriteLine("Force Ball: DF+3");
                                            Console.WriteLine("Invisibility: DU+4");
                                            break;
                                        case 3:
                                            Console.WriteLine("Reptile Combos");
                                            Console.WriteLine("1. F+2,1 > BF+2");
                                            Console.WriteLine("2. F+3,2 > BF+4");
                                            Console.WriteLine("3. 2,3 > J.2,3,3 > DB+4");
                                            Console.WriteLine("4. HOLD B+2 > 2,3 > F+3,2 > BF+4");
                                            Console.WriteLine("5. F+2,3 > F+2,3 > F+3,2 > BF+4");
                                            Console.WriteLine("6. F+2,1 > DF+3 > F+2,3 > F+3,2 > BF+4");
                                            break;
                                        case 4:
                                            Console.WriteLine("Reptile Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Scorpion,Motaro,Cyrax,Ferra,Frost,Janet Cage,Khameleon,Madam Bo,Sareena");
                                            Console.WriteLine("-Intermediate: Darrius,Goro,Jax,Kano,Kung Lao,Stryker,Mavado,Motaro,Sektor,Sonya,Sub-Zero");
                                            Console.WriteLine("-Advanced: Shujinko");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "RAIDEN":
                                Console.WriteLine("Difficulty: Easy");
                                Console.WriteLine("Raiden is a all rounder with moves that can reach the opponents and good pressure.");
                                Console.WriteLine("\n What would you like to learn about Raiden? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Raiden Key Moves:");
                                            Console.WriteLine("Warrior's Stance: 1,2");
                                            Console.WriteLine("Deadly Current: 2,4,2,1");
                                            Console.WriteLine("Quick Learner: F+2,2");
                                            Console.WriteLine("The Basics: F+4,3");
                                            Console.WriteLine("Little Shock: 3,4");
                                            Console.WriteLine("Double Strike: F+3,4");
                                            break;
                                        case 2:
                                            Console.WriteLine("Raiden Special Moves");
                                            Console.WriteLine("Electric Fly: BF+3");
                                            Console.WriteLine("Electric Orb: DF+1Electromagnetic Storm: DB+3");
                                            Console.WriteLine("Lighting Port: DU");
                                            Console.WriteLine("Razzle Dazzle: DB+2");
                                            Console.WriteLine("Shocker: DF+2");
                                            break;
                                        case 3:
                                            Console.WriteLine("Raiden Combos");
                                            Console.WriteLine("1. F+4,3 > BF+3");
                                            Console.WriteLine("2. F+2,2 > DB+3");
                                            Console.WriteLine("3. 2,4,2,1 > DF+2");
                                            Console.WriteLine("4. 3,4 > J.2,1,2 > BF+3");
                                            Console.WriteLine("5. 3,4 > F+3,4 > F+2,2 > DF+2");
                                            Console.WriteLine("6. F+3,4 > F+3,4 > F+2,2 > EXDF+2 > 3 > DF+2");
                                            break;
                                        case 4:
                                            Console.WriteLine("Raiden Kameos based of easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Jax,Sektor,Kano,Cyrax,Darrius,Ferra,Frost,Goro,Janet Cage,Mavado,Madam Bo,Sareena,Scorpion,Sonya,Sub-Zero");
                                            Console.WriteLine("-Intermediate: Kano,Stryker,Motaro,Sektor,Tremor");
                                            Console.WriteLine("-Advanced: Shujinko");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "KITANA":
                                Console.WriteLine("Difficulty: Easy");
                                Console.WriteLine("Kitana is known for her mobile fan based attacks along with the zoning potential.");
                                Console.WriteLine("\n What would you like to learn about Kitana? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Kitana Key Moves:");
                                            Console.WriteLine("Limitless: 1,1");
                                            Console.WriteLine("Step Off: 2,4");
                                            Console.WriteLine("The Comeback: 2,4,1,2");
                                            Console.WriteLine("Heavy Is The Krown: B+2,4");
                                            Console.WriteLine("Booty Bump: B+3,4");
                                            break;
                                        case 2:
                                            Console.WriteLine("Kitana Special Moves");
                                            Console.WriteLine("Air Fan Nado: J.DB+1");
                                            Console.WriteLine("Bending Wind: BDF+4");
                                            Console.WriteLine("Fan Nado: DB+1");
                                            Console.WriteLine("Fan Toss: BF+1");
                                            Console.WriteLine("Princess Pirouette: DF+2");
                                            Console.WriteLine("Square Wave: DB+2");
                                            break;
                                        case 3:
                                            Console.WriteLine("Kitana Combos");
                                            Console.WriteLine("1. 2,4 > DF+2");
                                            Console.WriteLine("2. B+2,4 > DB+2");
                                            Console.WriteLine("3. B+2,4 > DB+1 > J.1 > J.1,1,2");
                                            Console.WriteLine("4. 2,4,1,2 > DB+1");
                                            Console.WriteLine("5. 4,F+3,4 > DB+1");
                                            Console.WriteLine("6. B+3,4 > DB+2");
                                            break;
                                        case 4:
                                            Console.WriteLine("Kitana Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Jax,Sub-Zero,Ferra,Frost,Goro,Janet Cage,Khameleon,Mavado,Madam Bo,Sareena,Scorpion");
                                            Console.WriteLine("-Intermediate: Cyrax,Darrius,Kano,Kung Lao,Stryker,Motaro,Sektor,Sonya,Tremor");
                                            Console.WriteLine("-Advanced: Shujinko");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "HAVIK":
                                Console.WriteLine("Difficulty: Easy");
                                Console.WriteLine("Havik is known for forcing opponents to adjust to his playstyle and reactions with his rushdown.");
                                Console.WriteLine("\n What would you like to learn about Havik? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Havik Key Moves:");
                                            Console.WriteLine("Cleric of Chaos: 1,1");
                                            Console.WriteLine("Undead Warrior: F+1,2");
                                            Console.WriteLine("Flesh Wound: 2,2");
                                            Console.WriteLine("Gut Buster: B+2,2");
                                            Console.WriteLine("Sinister Stomp: F+4");
                                            break;
                                        case 2:
                                            Console.WriteLine("Havik Special Moves");
                                            Console.WriteLine("Blood Bath: BF+2");
                                            Console.WriteLine("Helping Hand: DB+1");
                                            Console.WriteLine("Neoplasm: BF+1");
                                            Console.WriteLine("Seeking Neoplasm: BF+3");
                                            Console.WriteLine("Twist Torso: DB+4");
                                            break;
                                        case 3:
                                            Console.WriteLine("Havik Combos");
                                            Console.WriteLine("1. 1,1 > BF+1");
                                            Console.WriteLine("2. F+4 > DB+4");
                                            Console.WriteLine("3. B+2,2 > BF+2");
                                            Console.WriteLine("4. B+2,2 > BF+1 > J.2,1,2 > F1,2 > BF+2B");
                                            Console.WriteLine("5. B+2,2 > BF+1 > BF+2");
                                            Console.WriteLine("6. B+2,2 > BF+1 > DASH > B+2,2 > BF+2B");
                                            break;
                                        case 4:
                                            Console.WriteLine("Havik Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Sub-Zero,Cyrax,Jax,Darrius,Ferra,Janet Cage,Stryker,Mavado,Madam Bo,Sareena,Scorpion");
                                            Console.WriteLine("-Intermediate: Frost,Goro,Kano,Khameleon,Kung Lao,Sektor,Sonya,Tremor");
                                            Console.WriteLine("-Advanced: Shujinko,Motaro");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "MILEENA":
                                Console.WriteLine("Difficulty: Easy");
                                Console.WriteLine("Mileena is known for an aggressive and close range pressure and mix up potential.");
                                Console.WriteLine("\n What would you like to learn about Mileena? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Mileena Key Moves:");
                                            Console.WriteLine("Ambitious Strikes: 1,2");
                                            Console.WriteLine("Karrion Kuts: F+1,4,4");
                                            Console.WriteLine("The Right Sais: 2,1");
                                            Console.WriteLine("Rugsweeper: F+2,4");
                                            Console.WriteLine("Entry Point: 3");
                                            Console.WriteLine("Can't Fight It: F+3,4");
                                            break;
                                        case 2:
                                            Console.WriteLine("Mileena Special Moves");
                                            Console.WriteLine("Air Ball: J.DB+4");
                                            Console.WriteLine("Teleport Up: DB+2");
                                            Console.WriteLine("Low Sai: BF+3");
                                            Console.WriteLine("Roll: BD+4");
                                            Console.WriteLine("Straight Sai: BF+1");
                                            Console.WriteLine("Teleport Down: DF+2");
                                            break;
                                        case 3:
                                            Console.WriteLine("Mileena Combos");
                                            Console.WriteLine("1. 1,2 > BF+1");
                                            Console.WriteLine("2. F+1,4,4 > DB+2");
                                            Console.WriteLine("3. 2,1 > BD+4 > J.1,2,2 > BD+4");
                                            Console.WriteLine("4. 1,2 > BD+4 > J.2,2 > DB+4 > BD+4");
                                            Console.WriteLine("5. F+3,4 > BD+4 > J.2,2 > DB+4 > DASH > F+4");
                                            Console.WriteLine("6. 1,2 > EXDF+2 > J.1,2,2 > BD+4 > J.1,2,2 > DB+2");
                                            break;
                                        case 4:
                                            Console.WriteLine("Mileena Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Scorpion,Sonya,Cyrax,Darrius,Ferra,Frost,Goro,Janet Cage,Jax,Khameleon,Kung Lao,Mavado,Sareena");
                                            Console.WriteLine("-Intermediate: Kano,Stryker,Madam Bo,Motaro,Sektor,Sub-Zero,Tremor");
                                            Console.WriteLine("-Advanced: Shujinko");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "SEKTOR":
                                Console.WriteLine("Difficulty: Easy");
                                Console.WriteLine("Sektor is known for their zoning and anti-zoning tools.");
                                Console.WriteLine("\n What would you like to learn about Sektor? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Sektor Key Moves:");
                                            Console.WriteLine("Gut Crusher: 4,2");
                                            Console.WriteLine("Afterburn: 1,1");
                                            Console.WriteLine("Assembly Required: B+2");
                                            Console.WriteLine("Overcharging Elbow: F+2,1");
                                            Console.WriteLine("Shin Shatter: B+3");
                                            Console.WriteLine("Rocket Punch: F+2,1,2");
                                            break;
                                        case 2:
                                            Console.WriteLine("Sektor Special Moves");
                                            Console.WriteLine("Burst Grenade: J.DB+1");
                                            Console.WriteLine("Tactical Redeploy: DB+4");
                                            Console.WriteLine("Thrust Boost: UB/U/UF+Stance");
                                            Console.WriteLine("Anti-Air Flak: DB+2");
                                            Console.WriteLine("Blast Shield: DB+3");
                                            Console.WriteLine("Flamethrower: BF+2");
                                            Console.WriteLine("Sidewinder: DB+1");
                                            Console.WriteLine("Unguided Rocket: BF+1");
                                            break;
                                        case 3:
                                            Console.WriteLine("Sektor Combos");
                                            Console.WriteLine("1. 1,1 > BF+1");
                                            Console.WriteLine("2. 4,2 > BF+2");
                                            Console.WriteLine("3. F+2,1,2 > DB+4");
                                            Console.WriteLine("4. 1,1 > DB+4 > J.2,1,2 > DB+2 > J.2,1,2 > DB+4");
                                            Console.WriteLine("5. 1,1 > DB+4 > J.2,1,2 > DB+2 > J.1,3,4 > EXDB+4 > J.3,2");
                                            Console.WriteLine("6. F+2,1,2 > F+Stance > J.2,1,2 > DB+2 > J.2,1,2 > DB+4");
                                            break;
                                        case 4:
                                            Console.WriteLine("Sektor Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Motaro,Sonya,Kung Lao,Tremor,Mavado,Kano,Sektor,Stryker");
                                            Console.WriteLine("-Intermediate: Jax,Ferra,Frost,Janet Cage,Goro,Khameleon,Madam Bo,Sareena,Scorpion,Cyrax,Darrius,Sub-Zero");
                                            Console.WriteLine("-Advanced: Shujinko");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "T-1000":
                                Console.WriteLine("Difficulty: Easy");
                                Console.WriteLine("T-1000 is known for his rushdown pressure with mixups, combos, and command grabs.");
                                Console.WriteLine("\n What would you like to learn about T-1000? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("T-1000 Key Moves:");
                                            Console.WriteLine("Abdominal Crunch: 1,2");
                                            Console.WriteLine("Deltoid Snare: B+1");
                                            Console.WriteLine("Diaphragm Compressor: F+1,3");
                                            Console.WriteLine("Tibia Displacer: 2,4");
                                            Console.WriteLine("Thoracic Spike: 4,3");
                                            Console.WriteLine("Multiplanar Laceration: 4,3,4,3,4");
                                            Console.WriteLine("Diaphragm Rupturer: F+1,4");
                                            Console.WriteLine("Parietal Rod: 3,2,1");
                                            Console.WriteLine("Femoral Stab: B+3,2");
                                            break;
                                        case 2:
                                            Console.WriteLine("T-1000 Special Moves");
                                            Console.WriteLine("Acute Angle Hooks: DB+2");
                                            Console.WriteLine("Massive Droplet: J.DF+3");
                                            Console.WriteLine("Amorphous Step: BF+4");
                                            Console.WriteLine("Ballistic Approach: DF+1");
                                            Console.WriteLine("Ballistic Suppression: DB+1");
                                            Console.WriteLine("Sacral Spike: DB+3");
                                            Console.WriteLine("Superfluid Matter: BF+3");
                                            Console.WriteLine("Tornado Slam Emulation: DF+2");
                                            Console.WriteLine("Wrath Hammer Emulation: DFB+2");
                                            break;
                                        case 3:
                                            Console.WriteLine("T-1000 Combos");
                                            Console.WriteLine("1. B+3,2 > DF+2");
                                            Console.WriteLine("2. F+1,3 > DBF+2");
                                            Console.WriteLine("3. 3,2,1 > BF+3 > 2");
                                            Console.WriteLine("4. 4,3,3,3,3 > DB+3");
                                            Console.WriteLine("5. F+1,4 > DB+2");
                                            Console.WriteLine("6. F+1,4 > BF+3 > 2 > J.1,2,2 > B+3,2,1+3");
                                            break;
                                        case 4:
                                            Console.WriteLine("T-100 Kameos based off easiest to advanced for combo/strategy");
                                            Console.WriteLine("-Easy: Cyrax,Darrius,Ferra,Janet Cage,Jax,Khameleon,Mavado,Scorpion");
                                            Console.WriteLine("-Intermediate: Frost,Goro,Kano,Kung Lao,Stryker,Madam Bo,Sareena,Sektor,Sonya,Sub-Zero");
                                            Console.WriteLine("-Advanced: Motaro, Shujinko");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "PEACEMAKER":
                                Console.WriteLine("Difficulty: Easy");
                                Console.WriteLine("Peacemaker is known for his brawler tactics with close range attacks and mix-ups.");
                                Console.WriteLine("\n What would you like to learn about Peacemaker? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Peacemaker Key Moves:");
                                            Console.WriteLine("Clock Cleaner: 1,2");
                                            Console.WriteLine("Peace Eater: F+1,1");
                                            Console.WriteLine("Bee Stinger: 2,2");
                                            Console.WriteLine("Krotch Obilterator: B+2,4");
                                            Console.WriteLine("Flag Flyer: F+4,1,2");
                                            break;
                                        case 2:
                                            Console.WriteLine("Peacemaker Special Moves");
                                            Console.WriteLine("Activate Anti-Gravity: DB+2");
                                            Console.WriteLine("Activate Force Field: FDB+3");
                                            Console.WriteLine("Activate Human Torpedo: BF+2");
                                            Console.WriteLine("Activate Sonic Boom: BF+2");
                                            Console.WriteLine("Beautiful Bird Bullet: DB+4");
                                            Console.WriteLine("Force Multiplier: BF+1");
                                            Console.WriteLine("Ground-Air Offensive: DF+4");
                                            Console.WriteLine("Silent And Deadly: DB+1");
                                            Console.WriteLine("The Ultimate Ally: D+Stance");
                                            break;
                                        case 3:
                                            Console.WriteLine("Peacemaker Combos");
                                            Console.WriteLine("1. B+2,4 > BF+2");
                                            Console.WriteLine("2. 2,2 > BF+3");
                                            Console.WriteLine("3. F+4,1,2 > DF+4");
                                            Console.WriteLine("4. 2,2,1+3 > DB+4 > BF+2");
                                            Console.WriteLine("5. F+4,1,2 > BF+3 > BF+2");
                                            Console.WriteLine("6. 2,2 > BF+3 > DASH > F+4,1,2 > BF+2");
                                            break;
                                        case 4:
                                            Console.WriteLine("Peacemaker Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Cyrax,Ferra,Frost,Janet Cage,Khameleon,Sareena,Scorpion,Sonya,Sub-Zero");
                                            Console.WriteLine("-Intermediate: Darrius,Goro,Jax,Kano,Kung Lao,Stryker,Mavado,Sektor");
                                            Console.WriteLine("-Advanced: Motaro,Shujinko");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "LI MEI":
                                Console.WriteLine("Difficulty: Easy");
                                Console.WriteLine("Li Mei is known for their rushdown pressure and options for zoning along with latern setups.");
                                Console.WriteLine("\n What would you like to learn about Li Mei? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Li Mei Key Moves:");
                                            Console.WriteLine("Seeking Sanctuary: 1,2,4");
                                            Console.WriteLine("Seasoned Warrior: 2,1");
                                            Console.WriteLine("Double Palm: B+2");
                                            Console.WriteLine("Rough Zuffa: 4,3");
                                            Console.WriteLine("Pankration Champion: 4,3,1,2");
                                            Console.WriteLine("Sliding In: F+4");
                                            Console.WriteLine("No Holds Barred: B+3,4");
                                            Console.WriteLine("Kick Precision: F+4,3");
                                            break;
                                        case 2:
                                            Console.WriteLine("Li Mei Special Moves");
                                            Console.WriteLine("Air Flipping Heel Kick: J.DB+4");
                                            Console.WriteLine("Chain Reaction: BF+4");
                                            Console.WriteLine("Foo Tang: DB+3");
                                            Console.WriteLine("Nova Blast: BF+1");
                                            Console.WriteLine("Sky Lantern: DB+2");
                                            break;
                                        case 3:
                                            Console.WriteLine("Li Mei Combos");
                                            Console.WriteLine("1. 2,1 > DB+3");
                                            Console.WriteLine("2. B+3,4 > BF+4");
                                            Console.WriteLine("3. F+4,3 > J.1,3,4 > DB+4");
                                            Console.WriteLine("4. F+4,3 > 4,3 > EXBF+1 > DB+2 > J.1,3,4 > DB+4");
                                            Console.WriteLine("5. F+4,3 > J.2,1,2 > EXBF+1 > 4 > BF+4");
                                            Console.WriteLine("6. DB+2 > F+4,3 > J.2,1,2 > EXBF+1 > DASH > DB+2 > J.1,3,4 > DB+4");
                                            break;
                                        case 4:
                                            Console.WriteLine("Li Mei Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Scorpion,Sonya,Jax,Ferra,Janet Cage,Mavado,Sareena");
                                            Console.WriteLine("-Intermediate: Cyrax,Darrius,Frost,Goro,Khameleon,Kung Lao,Stryker,Madam Bo,Sektor,Sub-Zero,Tremor");
                                            Console.WriteLine("-Advanced: Motaro,Shujinko");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "REIKO":
                                Console.WriteLine("Difficulty: Easy");
                                Console.WriteLine("Reiko is known his close range attacks, mix-ups, and command grabs.");
                                Console.WriteLine("\n What would you like to learn about Reiko? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Reiko Key Moves:");
                                            Console.WriteLine("Body Bag: F+1,2");
                                            Console.WriteLine("Devastating Blow: 1,2");
                                            Console.WriteLine("Deadly Warfare: 2,1");
                                            Console.WriteLine("Kollateral Damage: 3,4");
                                            Console.WriteLine("Push Kick: B+3");
                                            Console.WriteLine("Mass Casualities: 4,3,4");
                                            break;
                                        case 2:
                                            Console.WriteLine("Reiko Special Moves");
                                            Console.WriteLine("Assassin Throwing Stars: BF+2");
                                            Console.WriteLine("Charging Pain: BF+3");
                                            Console.WriteLine("Pale Rider: BDF+1");
                                            Console.WriteLine("Retaliation: DB+1");
                                            Console.WriteLine("Tactical Takedown: DB+3");
                                            break;
                                        case 3:
                                            Console.WriteLine("Reiko Combos");
                                            Console.WriteLine("1. F+1,2 > DB+3");
                                            Console.WriteLine("2. 4,3,4 > BF+3");
                                            Console.WriteLine("3. F+1,2,4 > J.2,1,4");
                                            Console.WriteLine("4. F+1,2,4 > 3,4 > DB+3");
                                            Console.WriteLine("5. 2,1 > BF3U > 3,4 > EXBF+3 > 3 > BDF+1");
                                            Console.WriteLine("6. F+1,2,4 > DASH > 3,4 > EXBF+3 > DB+3");
                                            break;
                                        case 4:
                                            Console.WriteLine("Reiko Kameos based off easiest to advanced for Combos/strategy");
                                            Console.WriteLine("-Easy: Scorpion,Darrius,Tremor,Sonya,Ferra,Janet Cage,Mavado,Sareena,Sub-Zero");
                                            Console.WriteLine("-Intermediate: Cyrax,Frost,Goro,Jax,Kano,Khameleon,Kung Lao,Stryker,Madam Bo,Sektor");
                                            Console.WriteLine("-Advanced: Motaro,Shujinko");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "CONAN":
                                Console.WriteLine("Difficulty: Easy");
                                Console.WriteLine("Conan is known for his close range attacks, strong grabs, and controling the space to apply pressure.");
                                Console.WriteLine("\n What would you like to learn about Conan? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Conan Key Moves:");
                                            Console.WriteLine("Half-Sword Check: 1,1");
                                            Console.WriteLine("Abdomen Slice: B+1,2");
                                            Console.WriteLine("Gut Thrust: 2,2");
                                            Console.WriteLine("Rogue Rogue: F+2,1,1");
                                            Console.WriteLine("Reverse-Grip Return: 3,2");
                                            Console.WriteLine("Destroyer's Boot: B+3");
                                            Console.WriteLine("Skull Splitter: F+3,3");
                                            Console.WriteLine("Thief's Elbow: 4,2");
                                            Console.WriteLine("Two-Handed Sweep: F+3,3,4");
                                            break;
                                        case 2:
                                            Console.WriteLine("Conan Special Moves");
                                            Console.WriteLine("Destroyer's Drop: J.DB+1");
                                            Console.WriteLine("Atlantean Bulwark: DF+1");
                                            Console.WriteLine("Barbarian's Blitz: BF+3");
                                            Console.WriteLine("Berserker's March: BF+4");
                                            Console.WriteLine("Camel Counter: DB+1");
                                            Console.WriteLine("Cimmerian Rising: DF+2");
                                            Console.WriteLine("Crom's Curse: DB+Stance");
                                            Console.WriteLine("Skyward Guardian: DB+2");
                                            Console.WriteLine("Thief's Catapult: DF+Stance");
                                            break;
                                        case 3:
                                            Console.WriteLine("Conan Combos");
                                            Console.WriteLine("1. 1,1 > DF+1");
                                            Console.WriteLine("2. F+2,1,1 > BF+3");
                                            Console.WriteLine("3. 2,2 > BF+4");
                                            Console.WriteLine("4. B+1,2 > DF+2 > 1");
                                            Console.WriteLine("5. F+3,3,4 > J.1,2,3 > DB+2 > 3,2 > DF+2 > 1");
                                            Console.WriteLine("6. F+3,3,4 > 4 > DB+2 > 3,2 > EXDB+2 > 3,2 > DF+2 > 1");
                                            break;
                                        case 4:
                                            Console.WriteLine("Conan Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Ferra,Janet Cage,Khameleon,Jax,Mavado,Sareena,Scorpion,Sonya,Sub-Zero");
                                            Console.WriteLine("-Intermediate: Cyrax,Darrius,Frost,Goro,Kano,Kung Lao,Stryker,Madam Bo,Sektor,Tremor");
                                            Console.WriteLine("-Advanced: Motaro,Shujinko");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            //Intermediate to learn
                            case "JOHNNY CAGE":
                                Console.WriteLine("Difficulty: Intermediate");
                                Console.WriteLine("Johnny Cage is a rushdown character that focuses on close range and mix-up attacks.");
                                Console.WriteLine("\n What would you like to learn about Johnny Cage? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Johnny Cage Key Moves:");
                                            Console.WriteLine("Elbow's World: F+1,2");
                                            Console.WriteLine("Legbanged Redemptshin: 2,1,4");
                                            Console.WriteLine("Gutbusters: B+2");
                                            Console.WriteLine("Elbow Before Me: F+3,2");
                                            Console.WriteLine("Style Points: F+3,4");
                                            Console.WriteLine("Dunking On Haters: 2,1,2");
                                            Console.WriteLine("Flipper: F+4");
                                            Console.WriteLine("Back To The Footure: F+1,2,4");
                                            break;
                                        case 2:
                                            Console.WriteLine("Johnny Cage Special Moves");
                                            Console.WriteLine("Ball Buster: BD+1");
                                            Console.WriteLine("Hype: FDB+4");
                                            Console.WriteLine("Rising Star: DB+3");
                                            Console.WriteLine("Shadow Dash: DF+3");
                                            Console.WriteLine("Shadow Kick: BF+4");
                                            Console.WriteLine("Show Off: DB+1");
                                            Console.WriteLine("Throwing Shade: FDB+2");
                                            break;
                                        case 3:
                                            Console.WriteLine("Johnny Cage Combos");
                                            Console.WriteLine("1. 2,1,4 > BF+4");
                                            Console.WriteLine("2. F+1,2 > DB+3");
                                            Console.WriteLine("3. F+3,4 > F+3,2,1 > BF+4");
                                            Console.WriteLine("4. HOLD B+2 > DASH > 2,1,2 > DASH > F+3,2 > BF+4");
                                            Console.WriteLine("5. HOLD B+2 > DASH > 2,1,2 > DASH > F+1,2 > BD+1 ");
                                            Console.WriteLine("6. F+4 > DASH > 2,1,2 > DASH > F+3,2 > BF+4");
                                            break;
                                        case 4:
                                            Console.WriteLine("Johnny Cage Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Kano,Stryker,Frost,Sub-Zero,Sareena,Cyrax,Janet Cage,Khameleon,Kung Lao,Scorpion,Sonya");
                                            Console.WriteLine("-Intermediate: Darrius,Ferra,Goro,Jax,Mavado,Madam Bo,Sektor,Tremor");
                                            Console.WriteLine("-Advanced: Shujinko,Motaro");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "GENERAL SHAO":
                                Console.WriteLine("Difficulty: Intermediate");
                                Console.WriteLine("General Shao is known for thier stance attacks with strong mid-range attacks and mix-ups.");
                                Console.WriteLine("\n What would you like to learn about General Shao? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("General Shao Key Moves:");
                                            Console.WriteLine("Direct Orders: F+1,2,2 ");
                                            Console.WriteLine("Fury Strikes: 1,2");
                                            Console.WriteLine("For The Jugular: B+1");
                                            Console.WriteLine("Forward March: 2,2");
                                            Console.WriteLine("Beneath Me: B+3");
                                            break;
                                        case 2:
                                            Console.WriteLine("General Shao Special Moves");
                                            Console.WriteLine("Axe Recall (No Axe to Axe): DF+4");
                                            Console.WriteLine("Dark Energy (Axe): DF+1");
                                            Console.WriteLine("Death Quake (Axe): DB+4");
                                            Console.WriteLine("Devastator (Axe): DB+3");
                                            Console.WriteLine("Power Strike (Axe to No Axe): DF+4");
                                            Console.WriteLine("Reverse Treechopper (No Axe to Axe): DF+2B");
                                            Console.WriteLine("Treechopper (No Axe, Near Axe): DF+1");
                                            break;
                                        case 3:
                                            Console.WriteLine("General Shao Combos");
                                            Console.WriteLine("1. F+1,2,2 > DB+3");
                                            Console.WriteLine("2. 1,2 > DF+4");
                                            Console.WriteLine("3. 1,2 > DF+4 > 2,2 > DF+2");
                                            Console.WriteLine("4. 1,2 > DF+4 > B+3,2 > 2,2 > DB+3");
                                            Console.WriteLine("5. F+1,2,2 > DF+4 > DASH > 2 > DF+2");
                                            Console.WriteLine("6. 2,2 > EXDB+3 > DF+4 > 2,2 > DF+2");
                                            break;
                                        case 4:
                                            Console.WriteLine("General Shao Kameos based off easiest to advanced for combo/strategy");
                                            Console.WriteLine("-Easy: Sektor,Sonya,Sub-Zero,Sareena,Kung Lao,Frost,Darrius,Ferra,Janet Cage,Mavado,Madam Bo");
                                            Console.WriteLine("-Intermediate: Cyrax,Kano,Khameleon,Stryker,Scorpion,Motaro,Goro,Tremor,Jax");
                                            Console.WriteLine("-Advanced: Shujinko");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "TANYA":
                                Console.WriteLine("Difficulty: Intermediate");
                                Console.WriteLine("Tanya is known for her mobility and mix-up potential attacks.");
                                Console.WriteLine("\n What would you like to learn about Tanya? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Tanya Key Moves:");
                                            Console.WriteLine("Activate Threat: 1,2");
                                            Console.WriteLine("Devoted Follower: F+2,1,1");
                                            Console.WriteLine("Branching Out: 3");
                                            Console.WriteLine("Crossed Kick: B+3");
                                            Console.WriteLine("Wraparound: 2,1+3");
                                            break;
                                        case 2:
                                            Console.WriteLine("Tanya Special Moves");
                                            Console.WriteLine("Deity Push: DB+Hold3+B");
                                            Console.WriteLine("Divine Protection: DB+3");
                                            Console.WriteLine("Drill Kick: BF+4");
                                            Console.WriteLine("Heavenly Hand: DF+1");
                                            Console.WriteLine("Seeking Guidance: DF+3");
                                            Console.WriteLine("Spinning Splits Kick: DB+4");
                                            Console.WriteLine("Umgadi Dodge (Requires 2 Guidance): DF+3");
                                            Console.WriteLine("Umgadi Evade: DB+Hold3+F");
                                            break;
                                        case 3:
                                            Console.WriteLine("Tanya Combos");
                                            Console.WriteLine("1. 2,1+3 > BF+4");
                                            Console.WriteLine("2. F+2,1,1 > DB+4");
                                            Console.WriteLine("3. F+2,1,1 > EXBF+4 > DASH > F+2,1,1 > BF+4");
                                            Console.WriteLine("4. F+2,1,1 > EXBF+4 > DASH > F+4 > 2,1+3 > BF+4");
                                            Console.WriteLine("5. 2,1+3 > EXBF+4 > DASH > F+2,1,1 > DB+4");
                                            Console.WriteLine("6. 3 > DF+3 > J1 > F+2,1,1 > EXBF+4 > DASH > F+4 > DASH > F4 > DASH > 2,1+3 > BF+4");
                                            break;
                                        case 4:
                                            Console.WriteLine("Tanya Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Goro,Sub-Zero,Frost,Scorpion,Darrius,Ferra,Janet Cage,Khameleon,Mavado,Madam Bo,Sareena");
                                            Console.WriteLine("-Intermediate: Cyrax,Jax,Kano,Kung Lao,Stryker,Sektor,Sonya,Tremor");
                                            Console.WriteLine("-Advanced: Shujinko,Motaro");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "TAKEDA":
                                Console.WriteLine("Difficulty: Intermediate");
                                Console.WriteLine("Takeda is known for his space control and mix-ups attacks.");
                                Console.WriteLine("\n What would you like to learn about Takeda? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Takeda Key Moves:");
                                            Console.WriteLine("Twisting Blades: 1,2");
                                            Console.WriteLine("Rising Suns: F+1,2");
                                            Console.WriteLine("Falling Moon: F+1,4");
                                            Console.WriteLine("Stomach Smasher: 2,1");
                                            Console.WriteLine("Temple Razer: B+2,1");
                                            Console.WriteLine("Ankle Biter: B+3");
                                            break;
                                        case 2:
                                            Console.WriteLine("Takeda Special Moves");
                                            Console.WriteLine("Reverse Falling Stars: DB+1");
                                            Console.WriteLine("Falling Star: J.DF+1");
                                            Console.WriteLine("Rushing Nimbus Attack: J.DB+3");
                                            Console.WriteLine("Rushing Nimbus Technique: J.BF+3");
                                            Console.WriteLine("Smart Shuriken: J.DB+1");
                                            Console.WriteLine("Spear Ryu: J.DB+2");
                                            Console.WriteLine("Tornado Kick: DB+4");
                                            Console.WriteLine("Double Spear Ryu: BF+2");
                                            Console.WriteLine("Shooting Star: DF+1");
                                            Console.WriteLine("Swift Stride: BF+3");
                                            Console.WriteLine("Whip Art: DF+4");
                                            break;
                                        case 3:
                                            Console.WriteLine("Takeda Combos");
                                            Console.WriteLine("1. 1,2 > BF+2");
                                            Console.WriteLine("2. F+1,2 > BF+3");
                                            Console.WriteLine("3. F+1,2 > DF+4 > DF+4 > DF+4");
                                            Console.WriteLine("4. B+2,1 > EXBF+2 > J.2,4,1+3");
                                            Console.WriteLine("5. B+2,1 > EXBF+2 > J.2,4 > BF+3 > J.2,4,1+3");
                                            Console.WriteLine("6. 2,1 > DF+4 > DF+4 > EXDF+4 > J.2,4 > BF+3 > J.2,4,1+3");
                                            break;
                                        case 4:
                                            Console.WriteLine("Takeda Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Janet Cage,Cyrax,Jax,Ferra,Mavado,Khameleon,Sektor,Scorpion");
                                            Console.WriteLine("-Intermediate: Kung Lao,Sareena,Motaro,Sonya,Stryker,Goro,Sub-Zero,Frost,Kano");
                                            Console.WriteLine("-Advanced: Shunjinko,Darrius,Tremor");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "ERMAC":
                                Console.WriteLine("Difficulty: Intermediate");
                                Console.WriteLine("Ermac is known for their rushdown pressure with a mixure of attacks, grabs, and teleporting.");
                                Console.WriteLine("\n What would you like to learn about Ermac? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Ermac Key Moves:");
                                            Console.WriteLine("Heavy Wights: B+2,4");
                                            Console.WriteLine("Sinking Feeling: 1,2");
                                            Console.WriteLine("Ceiling Krawl:F+2");
                                            Console.WriteLine("Kasket Kloser: 4");
                                            break;
                                        case 2:
                                            Console.WriteLine("Ermac Special Moves");
                                            Console.WriteLine("Hungry Hands: J.DB+3");
                                            Console.WriteLine("Shifting Spirits: DB+4");
                                            Console.WriteLine("Suspended Animation: DB+2");
                                            Console.WriteLine("Behind You: BF+2");
                                            Console.WriteLine("Death's Embrace: FDB+3");
                                            Console.WriteLine("Spirit Punch: BF+1");
                                            Console.WriteLine("Too Late: BF+2");
                                            Console.WriteLine("Witch Slam: DB+1");
                                            break;
                                        case 3:
                                            Console.WriteLine("Ermac Combos");
                                            Console.WriteLine("1. B+2,4 > BF+1");
                                            Console.WriteLine("2. 1,2 > DB+1");
                                            Console.WriteLine("3. B+2,4 > 4 > BF+2");
                                            Console.WriteLine("4. B+2,4 > 4 > EXDB+1 > J.1,4 > 1,2,3,1+3");
                                            Console.WriteLine("5. 1,2 > EXDB+1 > J.2,4 > DB+2 > J.1,4 > 1,2,3,1+3");
                                            Console.WriteLine("6. EXDB+4 > B+2,4 > 1,2 > BF+2");
                                            break;
                                        case 4:
                                            Console.WriteLine("Ermac Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Janet Cage,Scorpion,Sonya,Sareena,Mavado,Sub-Zero");
                                            Console.WriteLine("-Intermediate: Kung Lao,Mavado,Jax,Kano,Khameleon,Stryker,Ferra,Cyrax,Sektor,Frost");
                                            Console.WriteLine("-Advanced: Shunjinko,Motaro,Tremor,Goro,Darrius");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "CYRAX":
                                Console.WriteLine("Difficulty: Intermediate");
                                Console.WriteLine("Cyrax is known for their technical playstyle by setting up bomb traps.");
                                Console.WriteLine("\n What would you like to learn about Cyrax? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Cyrax Key Moves:");
                                            Console.WriteLine("Short Circuit: 1,1");
                                            Console.WriteLine("Bionic Kick: 2,3");
                                            Console.WriteLine("Quick Buzz: F+2");
                                            Console.WriteLine("Syntax Error: B+3,3,4");
                                            Console.WriteLine("Metal Mid Heel: B+3,3");
                                            break;
                                        case 2:
                                            Console.WriteLine("Cryax Special Moves");
                                            Console.WriteLine("Friction Assist Snare: J.DB+4");
                                            Console.WriteLine("Friction Boot Parkour: J.U+Block");
                                            Console.WriteLine("Bomb Mistwalk: DB+3");
                                            Console.WriteLine("Capture Foam: BF+1");
                                            Console.WriteLine("Close Bomb: DB+2");
                                            Console.WriteLine("Far Bomb: DBF+2");
                                            Console.WriteLine("Mid Bomb: DF+2");
                                            Console.WriteLine("Mistwalk: DF+3");
                                            Console.WriteLine("Sawtooth Kick: DB+4");
                                            break;
                                        case 3:
                                            Console.WriteLine("Cryax Combos");
                                            Console.WriteLine("1. 1,1 > DB+4");
                                            Console.WriteLine("2. B+3,3 > BF+1");
                                            Console.WriteLine("3. 2,1 > 2,1 > 2,1 > 2,3 > DB+4");
                                            Console.WriteLine("4. 2,1 > 2,1 > DASH > B+3,3,4 > DB+4");
                                            Console.WriteLine("5. 2,1 > 3 > BF+1 > DBF+2 > J.3,4 > J.3,4 > DB+4");
                                            Console.WriteLine("6. 2,1 > 3 > BF+1 > DF+2 > DF+2 > DF+2 > 3 > 3 > 3 > DB+4");
                                            break;
                                        case 4:
                                            Console.WriteLine("Cyrax Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Scorpion,Kano,Madam Bo,Mavado,Sareena,Sonya,Cyrax,Ferra,Frost,Sonya");
                                            Console.WriteLine("-Intermediate: Janet,Sektor,Stryker,Sub-Zero,Khameleon,Kung Lao,Goro,Jax");
                                            Console.WriteLine("-Advanced: Shujinko,Tremor,Motato");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "GHOSTFACE":
                                Console.WriteLine("Difficulty: Intermediate");
                                Console.WriteLine("Ghostface is known for their tricky mix-ups and pressure with their command grabs and attacks.");
                                Console.WriteLine("\n What would you like to learn about Ghostface? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Ghostface Key Moves:");
                                            Console.WriteLine("Slasher Flick: 1,2");
                                            Console.WriteLine("Director's Cut: 2,2");
                                            Console.WriteLine("Final Cut: 2,2,2");
                                            Console.WriteLine("Weary Slice: B+3");
                                            Console.WriteLine("Stab Trilogy: 4,4");
                                            Console.WriteLine("Jilted Lover: F+2,1");
                                            break;
                                        case 2:
                                            Console.WriteLine("Ghostface Special Moves");
                                            Console.WriteLine("Always Outnumbered: DB+4");
                                            Console.WriteLine("Backstage Pass: DB+3");
                                            Console.WriteLine("Father Death: BDF+1");
                                            Console.WriteLine("Psychotic Dive: DF+4");
                                            Console.WriteLine("Psychotic Rush: DF+3");
                                            break;
                                        case 3:
                                            Console.WriteLine("Ghostface Combos");
                                            Console.WriteLine("1. 1,2 > DF+4,1");
                                            Console.WriteLine("2. 2,2,2 > DF+3,1");
                                            Console.WriteLine("3. 2,2,2 > BDF+1");
                                            Console.WriteLine("4. 2,2,1+3 > J.2,2 > F+4 > J.2,2 > B+3 > DF+3,1");
                                            Console.WriteLine("5. F+4 > J.2,2 > 2,2,1+3 > > J.2,2 > B+3 > DF+3,1");
                                            Console.WriteLine("6. F+2,1 > EXDB+3 > 2,2,1+3 > J.2,2 > F+4 > J.2,2 > B+3 > DF+3,1");
                                            break;
                                        case 4:
                                            Console.WriteLine("Ghost Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Mavado,Sektor,Scorpion,Sareena,Ferra,Kano,Madam Bo,Cyrax,Janet Cage");
                                            Console.WriteLine("-Intermediate: Darrius,Sonya,Stryker,Jax,Tremor,Khameleon,Frost,Kung Lao,Sub-Zero,Goro");
                                            Console.WriteLine("-Advanced: Shujinko,Motaro");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "SMOKE":
                                Console.WriteLine("Difficulty: Intermediate");
                                Console.WriteLine("Smoke is known for being extremely aggressive to overwhelm the opponents with pressure.");
                                Console.WriteLine("\n What would you like to learn about Smoke? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Smoke Key Moves:");
                                            Console.WriteLine("Never Submit: 1,1");
                                            Console.WriteLine("No Escape: 1,1,1,4");
                                            Console.WriteLine("Perfect Pierce: F+1,2");
                                            Console.WriteLine("Missing The Toes: F+1,2,2,4");
                                            Console.WriteLine("Everywhere: 2,1,2");
                                            Console.WriteLine("Smoke Damage (Low): B+2,3");
                                            Console.WriteLine("Tricky Karambit: F+3,2");
                                            Console.WriteLine("Kutting-Room Four: F+1,2,1+3");
                                            break;
                                        case 2:
                                            Console.WriteLine("Smoke Special Moves");
                                            Console.WriteLine("Shadow Blade: DB+1");
                                            Console.WriteLine("Smoke Bomb: DB+2");
                                            Console.WriteLine("Smoke-Port: DB+4");
                                            Console.WriteLine("Vicious Vapors: BF+3");
                                            break;
                                        case 3:
                                            Console.WriteLine("Smoke Combos");
                                            Console.WriteLine("1. 1,1 > BF+3");
                                            Console.WriteLine("2. F+3,2 > DB+2");
                                            Console.WriteLine("3. F+1,2,2,4 > DB+1");
                                            Console.WriteLine("4. F+1,2,1+3 > EXDB+4 > J.1,1,2");
                                            Console.WriteLine("5. F+1,2,1+3 > EXDB+4 > J.1,1 > EXDB+4 > J.1,1 > EXDB+4 > J.1,1,2");
                                            Console.WriteLine("6. 3,2 > DASH > 3,2 > F1,2,1+3 > DB+1");
                                            break;
                                        case 4:
                                            Console.WriteLine("Smoke Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Scorpion,Sareena,Sektor,Darrius,Stryker,Ferra,Goro,Janet Cage,Mavado,Madam Bo");
                                            Console.WriteLine("-Intermediate: Cyrax,Frost,Jax,Kano,Khameleon,Kung Lao,Sonya,Sub-Zero,Tremor");
                                            Console.WriteLine("-Advanced: Shujinko,Motaro");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "OMNI-MAN":
                                Console.WriteLine("Difficulty: Intermediate");
                                Console.WriteLine("Omni-Man is known for their strong attacks and mix up attacks.");
                                Console.WriteLine("\n What would you like to learn about Omni-Man? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Omni-Man Key Moves:");
                                            Console.WriteLine("Konquerer Killer: 1,2");
                                            Console.WriteLine("Demon Slaying Punch: 2,2");
                                            Console.WriteLine("Earthquake Stomp: F+3");
                                            Console.WriteLine("Spilled Kontents: F+4,1");
                                            break;
                                        case 2:
                                            Console.WriteLine("Omni-Man Special Moves");
                                            Console.WriteLine("Fly Toward: J.F+Block");
                                            Console.WriteLine("Giblet Maker: BF+2");
                                            Console.WriteLine("Invincible Rush: BF+4");
                                            Console.WriteLine("Mega Clap: BF+1");
                                            Console.WriteLine("Viltrumite Stance: DB+3");
                                            Console.WriteLine("- Thragged Through Mud: 1");
                                            Console.WriteLine("- Honorable Death: 2");
                                            Console.WriteLine("- TieBreaker: 3");
                                            Console.WriteLine("- Up and Away: 4");
                                            break;
                                        case 3:
                                            Console.WriteLine("Omni-Man Combos");
                                            Console.WriteLine("1. 1,2 > BF+4");
                                            Console.WriteLine("2. 2,2 > BF+1");
                                            Console.WriteLine("3. 1,2 > DB+3,1 > J.1,2,1+3");
                                            Console.WriteLine("4. 1,2 > DB+3,1 > J.2,1,2 > F+Stance > J.1,2,1+3");
                                            Console.WriteLine("5. 1,2 > DB+3,1 > J.2,1,2 > F+Stance > J.2,1,2 > F+Stance > J.1,2,1+3");
                                            Console.WriteLine("6. 1,2 > EXDB+3,4 > 3 > DB+3,1 > J.2,1,2 > F+Stance > J.1,2,1+3 ");
                                            break;
                                        case 4:
                                            Console.WriteLine("Omni-Man Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Darrius,Kung Lao,Sareena,Mavado,Ferra,Scorpion,Jax");
                                            Console.WriteLine("-Intermediate: Cyrax,Tremor,Goro,Frost,Sonya,Kano,Stryker,Sub-Zero,Janet Cage, Madam Bo,Khameleon,Sektor");
                                            Console.WriteLine("-Advanced: Shujinko,Motaro");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            //Advanced to learn
                            case "GERAS":
                                Console.WriteLine("Difficulty: Advanced");
                                Console.WriteLine("Geras is known for rushdown methods but has some grapple moves with his time stop.");
                                Console.WriteLine("\n What would you like to learn about Geras? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Geras Key Moves:");
                                            Console.WriteLine("Clogged Up: 1,2");
                                            Console.WriteLine("Speed Up: B+1,2");
                                            Console.WriteLine("Slow Down: F+1,2");
                                            Console.WriteLine("Elbow Before Me: 2,1");
                                            Console.WriteLine("Stopping Time: F+2,4,2");
                                            Console.WriteLine("For The Fire God: F+4,4");
                                            break;
                                        case 2:
                                            Console.WriteLine("Geras Special Moves");
                                            Console.WriteLine("Countdown: DB+3");
                                            Console.WriteLine("Denial: DB+4");
                                            Console.WriteLine("Fixed Point (Countdown at 3): DB+3");
                                            Console.WriteLine("Follow-Up Exam: DB+2");
                                            Console.WriteLine("History Lesson: DF+2");
                                            Console.WriteLine("Inevitable (Countdown at 3): DB+3");
                                            Console.WriteLine("Redo: BF+3");
                                            Console.WriteLine("Sandstorm: DF+4");
                                            Console.WriteLine("Time Stop: BF+1");
                                            break;
                                        case 3:
                                            Console.WriteLine("Geras Combos");
                                            Console.WriteLine("1. 1,2 > BF+1");
                                            Console.WriteLine("2. B+1,2 > DF+2");
                                            Console.WriteLine("3. F+2,4 > DF+4 > 1 > DASH > 1,2,2,1+3");
                                            Console.WriteLine("4. F+2,4 > DF+4 > 1 > F+2,4 > DF+2");
                                            Console.WriteLine("5. F+2,4 > DF+4 > 1 > F+2,4 > EXBF+1 > DB+3 > DASH > 1,2,2,1+3");
                                            Console.WriteLine("6. F+2,4 > DF+4 > 1 > F+2,4 > EXBF+1 > 4 > DB+4 > F+2 > DF+2");
                                            break;
                                        case 4:
                                            Console.WriteLine("Geras Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Sub-Zero,Sareena,Kung Lao,Cyrax,Ferra,Mavado,Madam Bo");
                                            Console.WriteLine("-Intermediate: Darrius,Sektor,Stryker,Frost,Goro,Jax,Kano,Khameleon,Janet Cage,Tremor");
                                            Console.WriteLine("-Advanced: Motaro,Shujinko,Sonya,Scopion");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "KENSHI":
                                Console.WriteLine("Difficulty: Advanced");
                                Console.WriteLine("Kenshi is a technical character with the goal of releaing sento to trick and overwhelm the opponent.");
                                Console.WriteLine("\n What would you like to learn about Kenshi? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Kenshi Key Moves:");
                                            Console.WriteLine("Blind Sided: 1,4,1");
                                            Console.WriteLine("Gut Check: 2,1");
                                            Console.WriteLine("Spirit Strike: B+2");
                                            Console.WriteLine("Slice N' Dice: F+2,2");
                                            Console.WriteLine("Face Breaker: 4");
                                            break;
                                        case 2:
                                            Console.WriteLine("Kenshi Special Moves");
                                            Console.WriteLine("Ancestral Guard: DF+1");
                                            Console.WriteLine("Demon Drop: DB+2");
                                            Console.WriteLine("Force Push: BF+4");
                                            Console.WriteLine("Rising Karma: BF+3");
                                            Console.WriteLine("Sento Stance: DB+1");
                                            Console.WriteLine("Soul Charge: BF+2");
                                            break;
                                        case 3:
                                            Console.WriteLine("Kenshi Combos");
                                            Console.WriteLine("1. 1,4,1 > DB+2B");
                                            Console.WriteLine("2. F+2,2 > BF+2");
                                            Console.WriteLine("3. 1,4,1 > BF+3 > J.1,2,2");
                                            Console.WriteLine("4. F+2,2 > BF+3 > F+2,2,F+2");
                                            Console.WriteLine("5. F+2,2 > BF+3 > DASH > F+2,2 > BF+2");
                                            Console.WriteLine("6. F+2,2 > BF+3 > DASH > 4 > BF+2");
                                            break;
                                        case 4:
                                            Console.WriteLine("Kenshi Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Sub-Zero,Frost,Cyrax,Jax,Mavado,Scorpion,Sareena");
                                            Console.WriteLine("-Intermediate: Darrius,Stryker,Sonya,Khameleon,Sektor,Kung Lao,Kano,Goro,Tremor,Madam Bo,Ferra,Janet Cage");
                                            Console.WriteLine("-Advanced: Shujinko,Motaro");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "NITARA":
                                Console.WriteLine("Difficulty: Advanced");
                                Console.WriteLine("Nitara is known for their air movement and combos.");
                                Console.WriteLine("\n What would you like to learn about Nitara? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Nitara Key Moves:");
                                            Console.WriteLine("Blood Strike: 2,2");
                                            Console.WriteLine("Never Grow Old: 1,2");
                                            Console.WriteLine("Never  Die: 1,2,1,2");
                                            Console.WriteLine("Broken Nails: F+1");
                                            Console.WriteLine("Lunging Leech: B+2");
                                            Console.WriteLine("Hex Kick: 3");
                                            Console.WriteLine("Bleeding Out: F+4");
                                            break;
                                        case 2:
                                            Console.WriteLine("Nitara Special Moves");
                                            Console.WriteLine("Dark Plunge: DB+4");
                                            Console.WriteLine("Air Dash Forward: J.F+Stance");
                                            Console.WriteLine("Bad Blood: BF+1");
                                            Console.WriteLine("Blood Sacrifice: DF+4");
                                            Console.WriteLine("Bloody Bolt (Requires Blood Sacrifice): BF+3");
                                            Console.WriteLine("Leap of Faith: DB+2");
                                            Console.WriteLine("Quick Taste: BF+2");
                                            break;
                                        case 3:
                                            Console.WriteLine("Nitara Combos");
                                            Console.WriteLine("1. 1,2,1,2 > BF+2");
                                            Console.WriteLine("2. B+2 > DB+4");
                                            Console.WriteLine("3. 1,2,1,2 > J.1,2,4 > DF+Stance > J.2,4,2 > BF+2");
                                            Console.WriteLine("4. 1,2,1,2 > J.2,4,2 > EXBF+2 > J.2,4,2 > BF+2");
                                            Console.WriteLine("5. 1,2,1,2 > J.2,4 > F+Stance > J.2,4,2 > EXBF+2 > J.2,4,2 > BF+2");
                                            Console.WriteLine("6. 1,2,1,2 > 4 > DB+2 > EXBF+2 > J.1,2,4 > DF+Stance > J.2,4,2 > BF+2");
                                            break;
                                        case 4:
                                            Console.WriteLine("Nitara Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Scorpion,Cyrax,Kung Lao,Sonya,Ferra,Darrius,Mavado,Jax");
                                            Console.WriteLine("-Intermediate: Sareena,Frost,Goro,Khameleon,Sub-Zero,Tremor,Madam Bo,Sektor,Stryker,Kano,Janet Cage");
                                            Console.WriteLine("-Advanced: Shujinko,Motaro");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "SHANG TSUNG":
                                Console.WriteLine("Difficulty: Advanced");
                                Console.WriteLine("Shang Tsung is known for their unique style of switching between young and old form along with \nbeing able to transform into other characters.");
                                Console.WriteLine("\n What would you like to learn about Shang Tsung? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Shang Tsung Key Moves:");
                                            Console.WriteLine("Die-Agnosis: 1,2");
                                            Console.WriteLine("Knee Reverser (Old Form): 2,4");
                                            Console.WriteLine("Lovetap: B+2,2");
                                            Console.WriteLine("Die-V (Young Form): F+4,3");
                                            break;
                                        case 2:
                                            Console.WriteLine("Shang Tsung Special Moves");
                                            Console.WriteLine("Form Stealer: FDB+4");
                                            Console.WriteLine("Quick Age Morph: D+Stance");
                                            Console.WriteLine("- Old Form ");
                                            Console.WriteLine(" - Ground Skull: DF+1");
                                            Console.WriteLine(" - Injection: DB+3");
                                            Console.WriteLine(" - Vicinity Slash: DF+2");
                                            Console.WriteLine("- Young Form");
                                            Console.WriteLine(" - Bed of Spikes: DB+3");
                                            Console.WriteLine(" - Double Skull: DB+1 ");
                                            Console.WriteLine(" - Spinning Spikes: DF+2");
                                            Console.WriteLine(" - Straight Skull: DF+1");
                                            Console.WriteLine(" - Triple Skull: DBF+1");
                                            break;
                                        case 3:
                                            Console.WriteLine("Shang Tsung Combos");
                                            Console.WriteLine("1. 2,4 > DB+1F (Young)");
                                            Console.WriteLine("2. B+1,2 > F+4,3 > DB+1F (Young)");
                                            Console.WriteLine("3. B+2,2 > DB+3 (Old)");
                                            Console.WriteLine("4. 1,2 > DB+1 (Old)");
                                            Console.WriteLine("5. B+1,2 > D+Stance > 4 > DF+1 > 4 > DF+1 > 2,4 > DB+3");
                                            Console.WriteLine("6. B+1,2 > D+Stance > 4 > DF+1 > 4 > DF+1 > F+4 > DF+1 > F+4 > DB+3");
                                            break;
                                        case 4:
                                            Console.WriteLine("Shang Tsung Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Kung Lao,Shujinko,Goro,Stryker,Scorpion,Mavado,Sektor,Motaro");
                                            Console.WriteLine("-Intermediate: Tremor,Sonya,Sareena,Madam Bo,Sub-Zero,Khameleon,Ferra,Kano,Jax");
                                            Console.WriteLine("-Advanced: Sonya,Frost,Cyrax,Darrius");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "RAIN":
                                Console.WriteLine("Difficulty: Advanced");
                                Console.WriteLine("Rain is known is defensive strategy and strong damage and water portal setups.");
                                Console.WriteLine("\n What would you like to learn about Rain? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Rain Key Moves:");
                                            Console.WriteLine("Beach Slap: 1,1");
                                            Console.WriteLine("When It Rains: 2,1,1");
                                            Console.WriteLine("Tide: B+2");
                                            Console.WriteLine("Undertow: F+2,1");
                                            Console.WriteLine("H2Blow: F+3");
                                            break;
                                        case 2:
                                            Console.WriteLine("Rain Special Moves");
                                            Console.WriteLine("Ancient Trap: BF+4");
                                            Console.WriteLine("Geyser: DB+3");
                                            Console.WriteLine("Rain God: DDU");
                                            Console.WriteLine("Upflow: DB+1");
                                            Console.WriteLine("Water Beam: BF+1");
                                            Console.WriteLine("Water Gate: DB+2");
                                            Console.WriteLine("Water Shield: FDB+4");
                                            break;
                                        case 3:
                                            Console.WriteLine("Rain Combos");
                                            Console.WriteLine("1. 1,1 > DB+1");
                                            Console.WriteLine("2. 1,1,4 > DB+3");
                                            Console.WriteLine("3. Hold 4 > 2,1,1 > DB+3");
                                            Console.WriteLine("4. F+3,2 > J.2,4,3 > DB+3");
                                            Console.WriteLine("5. F+3,2 > J.2,4,3 > DASH > F+2,1 > DB+3");
                                            Console.WriteLine("6. BF+4 > J.1 > J.2,4,3 > F+2 > DB+3F");
                                            break;
                                        case 4:
                                            Console.WriteLine("Rain Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Sonya,Janet Cage,Scorpion,Khameleon,Mavado,Ferra,Frost");
                                            Console.WriteLine("-Intermediate: Sub-Zero,Cyrax,Darrius,Sektor,Madam Bo,Stryker,Sareena,Kano,Jax,Kung Lao");
                                            Console.WriteLine("-Advanced: Shujinko,Motaro,Tremor,Goro");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "SINDEL":
                                Console.WriteLine("Difficulty: Advanced");
                                Console.WriteLine("Sindel is an all rounder where she can trick opponents with her mix-ups but also with flight combos.");
                                Console.WriteLine("\n What would you like to learn about Sindel? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Sindel Key Moves:");
                                            Console.WriteLine("Kiss The Ring: 1,1");
                                            Console.WriteLine("Shear Genius: F+1");
                                            Console.WriteLine("Turning Heel: 2,4");
                                            Console.WriteLine("Divine Decree: B+2,3");
                                            Console.WriteLine("Flippy Flip: F+4");
                                            break;
                                        case 2:
                                            Console.WriteLine("Sindel Special Moves");
                                            Console.WriteLine("Air Levitate: DB+2");
                                            Console.WriteLine("Hairball: DF+1");
                                            Console.WriteLine("Inspire: DB+3");
                                            Console.WriteLine("Kartwheel: DF+4");
                                            Console.WriteLine("Low Hairball: DB+1");
                                            Console.WriteLine("Queen's Command: DF+4");
                                            Console.WriteLine("Scream: BF+2");
                                            break;
                                        case 3:
                                            Console.WriteLine("Sindel Combos");
                                            Console.WriteLine("1. 1,1 > DF+1");
                                            Console.WriteLine("2. B+2,3 > DF+4");
                                            Console.WriteLine("3. 2,4 > BF+2");
                                            Console.WriteLine("4. B+2,3 > 2,4 > BF+2 > DASH > B+2,3 > DF+4");
                                            Console.WriteLine("5. 2,4 > BF+2 > DASH > F+4,3 > J.1,1,4 > DF+1");
                                            Console.WriteLine("6. 2,4 > BF+2 > DASH > F+4,3 > J.1,1,4 > DF+4");
                                            break;
                                        case 4:
                                            Console.WriteLine("Sindel Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Sub-Zero,Sonya,Sareena,Darrius,Ferra,Kung Lao,Mavado,Scorpion");
                                            Console.WriteLine("-Intermediate: Cyrax,Ferra,Frost,Goro,Jax,Khameleon,Stryker,Madam Bo,Sektor,Tremor");
                                            Console.WriteLine("-Advanced: Shujinko,Motaro,Janet Cage,Kano");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "ASHRAH":
                                Console.WriteLine("Difficulty: Advanced");
                                Console.WriteLine("Ashrah is known for their mid to far range attacks along with their light/dark stance.");
                                Console.WriteLine("\n What would you like to learn about Ashrah? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Ashrah Key Moves:");
                                            Console.WriteLine("Cleansed Soul: 1,2,2");
                                            Console.WriteLine("Kriss Kross: 2,2");
                                            Console.WriteLine("Sinner Stab: F+2");
                                            Console.WriteLine("Short Stab: B+3");
                                            Console.WriteLine("Soaring Demon: F+3");
                                            Console.WriteLine("Crown Cracker: F+4,2");
                                            Console.WriteLine("Playful Prickle: 2,1");
                                            break;
                                        case 2:
                                            Console.WriteLine("Ashrah Special Moves");
                                            Console.WriteLine("Astral Projection: BF+2");
                                            Console.WriteLine("Dark Ascension (Dark Stance): DF+3");
                                            Console.WriteLine("Demon's Wrath (Dark Stance): DB+2");
                                            Console.WriteLine("God's Wrath (Light Stance): DB+2");
                                            Console.WriteLine("Heaven's Beacon (Light Stance): DF+1");
                                            Console.WriteLine("Hell's Pillar (Dark Stance): DF+1");
                                            Console.WriteLine("Light Ascension (Light Stance): DF+3");
                                            Console.WriteLine("Switch Light/Dark Stance: DB+1");
                                            break;
                                        case 3:
                                            Console.WriteLine("Ashrah Combos");
                                            Console.WriteLine("1. 1,2,2 > BF+2");
                                            Console.WriteLine("2. 2,2 > DB+2");
                                            Console.WriteLine("3. F+4,2 > EXDF+3 > J.1,2,2 > BF+2");
                                            Console.WriteLine("4. F+4,2 > EXDF+3 > J.2 > F+2 > EXDF+3 > J.1,2,2 > BF+2");
                                            Console.WriteLine("5. 2,1 > DF+1 > F+2 > BF+2");
                                            Console.WriteLine("6. 2,1 > DF+1 > F+2 > EXDF+3 > J.1,2,2 > BF+2");
                                            break;
                                        case 4:
                                            Console.WriteLine("Ashrah Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Scorpion,Frost,Sub-Zero,Sonya,Sareena,Ferra,Goro,Janet Cage,Mavado");
                                            Console.WriteLine("-Intermediate: Cyrax,Kano,Khameleon,Kung Lao,Stryker,Madam Bo,Sektor,Tremor,Jax");
                                            Console.WriteLine("-Advanced: Shujinko,Motaro,Darrius");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "HOMELANDER":
                                Console.WriteLine("Difficulty: Advanced");
                                Console.WriteLine("Homelander is known for their zoning and air combat combos.");
                                Console.WriteLine("\n What would you like to learn about Homelander? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Homelander Key Moves:");
                                            Console.WriteLine("Smash Hit: 1,2");
                                            Console.WriteLine("Enforcing Order: B+1,4");
                                            Console.WriteLine("Breathtaker: F+1");
                                            Console.WriteLine("Take Your Breath Away: 2,1");
                                            Console.WriteLine("Brightest Day: B+2,2");
                                            break;
                                        case 2:
                                            Console.WriteLine("Homelander Special Moves");
                                            Console.WriteLine("Diabolical Dash: BF+2");
                                            Console.WriteLine("God Complex: J.DB+4");
                                            Console.WriteLine("Blast Off: DB+2");
                                            Console.WriteLine("Dirty Trick: DB+1");
                                            Console.WriteLine("Flight: U+Stance");
                                            Console.WriteLine("Laser Eyes: BF+1");
                                            Console.WriteLine("Low Laser Eyes: BF+3");
                                            Console.WriteLine("Sky Laser Eyes: DB+3");
                                            Console.WriteLine("Sweeping Laser Eyes: BDF+4");

                                            break;
                                        case 3:
                                            Console.WriteLine("Homelander Combos");
                                            Console.WriteLine("1. 1,2 > BF+1");
                                            Console.WriteLine("2. 1,2 > BF+3");
                                            Console.WriteLine("3. 2,1 > BF+2,1 > J.2,1,4");
                                            Console.WriteLine("4. 2,1 > BF+2,1 > J.2,1 > BF+2,1 > 2,1,2");
                                            Console.WriteLine("5. 2,1 > U+Stance > 4 > BF+2,1 > 4 > BF+2,1 > J.2,1,4");
                                            Console.WriteLine("6. 2,1 > U+Stance > BF+2,1 > B+2,2 > U+Stance > BF+2,1 > B+2,2 > BF+2,1 > J.2,1,4");
                                            break;
                                        case 4:
                                            Console.WriteLine("Homelander Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Cyrax,Ferra,Scorpion,Sub-Zero,Sareena,Janet Cage,Jax,Mavado");
                                            Console.WriteLine("-Intermediate: Darrius,Frost,Goro,Kano,Khameleon,Kung Lao,Stryker,Madam Bo,Tremor,Sektor,Sonya");
                                            Console.WriteLine("-Advanced: Shujinko,Motaro");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "QUAN CHI":
                                Console.WriteLine("Difficulty: Advanced");
                                Console.WriteLine("Quan Chi is known for their zoning ablities and setting up plans to trick opponents.");
                                Console.WriteLine("\n What would you like to learn about Quan Chi? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Quan Chi Key Moves:");
                                            Console.WriteLine("Dangerous Ally: 1,2");
                                            Console.WriteLine("Bow Already!: 2,1,4");
                                            Console.WriteLine("Nether Eruption: B+2");
                                            Console.WriteLine("Table Test: B+3,4");
                                            Console.WriteLine("Alternative Acrobatics: F+4");
                                            Console.WriteLine("Skewer Strike: 1,3");
                                            break;
                                        case 2:
                                            Console.WriteLine("Quan Chi Special Moves");
                                            Console.WriteLine("Falling Death: BF+4");
                                            Console.WriteLine("Head Rush: BF+1");
                                            Console.WriteLine("Field of Bones: BDF+2");
                                            Console.WriteLine("From The Fog: DB+4");
                                            Console.WriteLine("Psycho Skull: DB+1");
                                            Console.WriteLine("Zone of Power: DB+3");
                                            Console.WriteLine("Zone of Waste: DF+3");
                                            break;
                                        case 3:
                                            Console.WriteLine("Quan Chi Combos");
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            break;
                                        case 4:
                                            Console.WriteLine("Quan Chi Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("1. 1,2 > BF+1");
                                            Console.WriteLine("2. 2,1,4 > DB+4");
                                            Console.WriteLine("3. B+3,4 > BF+4");
                                            Console.WriteLine("4. 1,3 > J.2,1 > 2,1,4,4");
                                            Console.WriteLine("5. 1,3 > 3 > J.2,1 > F+2,1");
                                            Console.WriteLine("6. 3, J.2,1 > 1,3 > DASH > F+2,1");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;

                            case "NOOB-SAIBOT":
                                Console.WriteLine("Difficulty: Advanced");
                                Console.WriteLine("Noob-Saibot is known for their unique playstyle with managing his shadow and setups.");
                                Console.WriteLine("\n What would you like to learn about Noob-Saibot? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                                Console.WriteLine("\nInput: ");
                                if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                                {
                                    switch (mk1_option)
                                    {
                                        case 1:
                                            Console.WriteLine("Noob-Saibot Key Moves:");
                                            Console.WriteLine("Shadow Upper: 1,2,1");
                                            Console.WriteLine("Shadow Strike: F+1,2");
                                            Console.WriteLine("Abyssal Hook: F+1,3");
                                            Console.WriteLine("Night Rain: 2,1,2");
                                            Console.WriteLine("Gravedigger: B+3,3");
                                            Console.WriteLine("Black Mace: 4,4");
                                            break;
                                        case 2:
                                            Console.WriteLine("Noob-Saibot Special Moves");
                                            Console.WriteLine("Shadow Dive/Dive Kick: DB+4");
                                            Console.WriteLine("Shadow Kick: BF+4");
                                            Console.WriteLine("Shadown Plunge: DD+4");
                                            Console.WriteLine("Tele-Slam: DU");
                                            Console.WriteLine("Embrace Khaos: FDB+1");
                                            Console.WriteLine("Shadow Ghostball: DF+1");
                                            Console.WriteLine("Exorcism: DF+1");
                                            Console.WriteLine("Netherrealm Portal: DB+2");
                                            Console.WriteLine("Netherrealm Summons: BF+2");
                                            Console.WriteLine("Shadow Slide/Saibot Slide: BF+4");
                                            Console.WriteLine("Shadow Slicer: DB+3");
                                            Console.WriteLine("Shadow Sweep: DB+4");
                                            Console.WriteLine("Shadow Tackle: BF+3");
                                            break;
                                        case 3:
                                            Console.WriteLine("Noob-Saibot Combos");
                                            Console.WriteLine("1. 1,2,1 > BF+4");
                                            Console.WriteLine("2. F+1,2 > DB+3");
                                            Console.WriteLine("3. 2,1,2 > BF+3");
                                            Console.WriteLine("4. 2,1,2 > BF+3 > 2,1 > DU");
                                            Console.WriteLine("5. 2,1,2 > BF+3 > 2,1 > EXDU > J.2,3,4 > B+4");
                                            Console.WriteLine("6. 2,1,2 > EXBF+3 > J.2,3,4 > EXDU > J.1,2,4,4 > EXDU > J.2,3,4 > DU");
                                            break;
                                        case 4:
                                            Console.WriteLine("Noob-Saibot Kameos based off easiest to advanced for combos/strategy");
                                            Console.WriteLine("-Easy: Janet Cage,Scorpion,Mavado,Sub-Zero,Sonya");
                                            Console.WriteLine("-Intermediate: Shujinko,Sektor,Kung Lao,Stryker,Darrius,Sareena,Jax,Khameleon");
                                            Console.WriteLine("-Advanced: Motato,Ferra,Cyrax,Frost,Goro,Tremor");
                                            break;
                                        default:
                                            Console.WriteLine("Please enter the correct option.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please select the correct number!");
                                }
                                break;
                        }
                        break;
                    }
                    break;
                }
            }

            if (mk1character == 2)
            {
                Random mk1random = new Random();
                int mk1randomcheck = mk1random.Next(mk1.Count);
                string mk1randomconfirmed = mk1[mk1randomcheck];
                mk1randomconfirmed = mk1randomconfirmed.ToUpper();

                bool repeatcharacter = true;
                while (repeatcharacter)
                {
                    switch (mk1randomconfirmed)
                    {
                        //Easy to learn
                        case "LIU KANG":
                            Console.WriteLine("Difficulty: Easy");
                            Console.WriteLine("Liu Kang is a all rounder with good attacks and projectiles.");
                            Console.WriteLine("\n What would you like to learn about Liu Kang? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Liu Kang Key Moves:");
                                        Console.WriteLine("Bare Knuckles: 1,2");
                                        Console.WriteLine("Shaolin Stutter: F+1,4");
                                        Console.WriteLine("Dragon Fangs: 2,2");
                                        Console.WriteLine("Holding Back: 3,3,3");
                                        Console.WriteLine("The Creator: F+4,3");
                                        Console.WriteLine("TailWhip: B+2,3");
                                        break;
                                    case 2:
                                        Console.WriteLine("Liu Kang Special Moves");
                                        Console.WriteLine("Cosmic Flame: BF+1");
                                        Console.WriteLine("Low Dragon: DB+1");
                                        Console.WriteLine("Dragon's Tail: BF+3");
                                        Console.WriteLine("Dancing Dragon: BF+4");
                                        Console.WriteLine("Dragon's Breath: DB+4");
                                        break;
                                    case 3:
                                        Console.WriteLine("Liu Kang Combos");
                                        Console.WriteLine("1. F+4,3 > BF+3");
                                        Console.WriteLine("2. 1,2 > BF+1");
                                        Console.WriteLine("3. F+1,4 > DB+4 > DASH > 333 > BF+3");
                                        Console.WriteLine("4. F+1,4 > DB+4 > DASH > B+2,3 > 4 > BF+3");
                                        Console.WriteLine("5. 333 > DB+4 > DASH > B+2,3 > DASH > 33 > BF+3");
                                        Console.WriteLine("6. B+2,3 > B+2,3 > DASH > 333 > BF+3");
                                        break;
                                    case 4:
                                        Console.WriteLine("Liu Kang Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Kung Lao,Scorpion,Sonya,Sareena,Darrius,Ferra,Janet Cage,Khameleon,Stryker,Madam Bo");
                                        Console.WriteLine("-Intermediate: Cyrax,Frost,Goro,Jax,Kano,Mavado,Sub-Zero,Tremor,Sektor");
                                        Console.WriteLine("-Advanced: Motaro,Shujinko");
                                        break;

                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "SUB-ZERO":
                            Console.WriteLine("Difficulty: Easy");
                            Console.WriteLine("Sub-Zero is known for his space control, mix-up options, and zoning.");
                            Console.WriteLine("\n What would you like to learn about Sub-Zero? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Sub-Zero Key Moves:");
                                        Console.WriteLine("Lin Keui Storm: 1,2");
                                        Console.WriteLine("Blistering Blizzard: 2,1");
                                        Console.WriteLine("Frozen Over: F+1,2");
                                        Console.WriteLine("Shin Shatter: B+3");
                                        Console.WriteLine("Spinal Tap: B+2");
                                        break;
                                    case 2:
                                        Console.WriteLine("Sub-Zero Special Moves");
                                        Console.WriteLine("Ice Ball: DF+1");
                                        Console.WriteLine("Ice Klone: DB+1");
                                        Console.WriteLine("Ice Klone Charge: BF+2");
                                        Console.WriteLine("Ice Slide: BF+3");
                                        Console.WriteLine("Diving Glacier: J.DB+4");
                                        Console.WriteLine("Deadly Vapors: DF+4");
                                        break;
                                    case 3:
                                        Console.WriteLine("Sub-Zero Combos");
                                        Console.WriteLine("1. 2,1 > BF+3");
                                        Console.WriteLine("2. B+2 > J1,2 > J.1,2 > F+1,2 > BF3");
                                        Console.WriteLine("3. B+2 > B+2 > J.1,2 > F+1,2 > BF+3");
                                        Console.WriteLine("4. J.1,2 > J.1,2 > F+1,2 > BF+3");
                                        Console.WriteLine("5. B2 > J.2,2 > DB4 > F+1,2 > BF+3");
                                        Console.WriteLine("6. F+1,2 > EXDF4 > B+2 > B+2 > J.1,2 > F+1,2 > BF+3");
                                        break;
                                    case 4:
                                        Console.WriteLine("Sub-Zero Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Sareena,Khameleon,Kung Lao,Sonya,Ferra,Kung Lao,Mavado,Madam Bo,Scorpion");
                                        Console.WriteLine("-Intermediate: Cyrax,Darrius,Goro,Janet Cage,Kano,Khameleon,Stryker,Motaro,Sektor,Sub-Zero,Tremor");
                                        Console.WriteLine("-Advanced: Shujinko");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "SCORPION":
                            Console.WriteLine("Difficulty: Easy");
                            Console.WriteLine("Scorpion is known for his rushdown pressure with a mix of close and mid range attacks.");
                            Console.WriteLine("\n What would you like to learn about Scorpion? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Scorpion Key Moves:");
                                        Console.WriteLine("Whiplash: 1,2");
                                        Console.WriteLine("Inner Pain: 2,1");
                                        Console.WriteLine("Shirai Who: 3,3");
                                        Console.WriteLine("Krackjaw: 3,3,3");
                                        Console.WriteLine("Raising Hell: F+3,2");
                                        break;
                                    case 2:
                                        Console.WriteLine("Scorpion Special Moves");
                                        Console.WriteLine("Spear: BF+1");
                                        Console.WriteLine("Blazing Charge: BF+2");
                                        Console.WriteLine("Kyo Snag: J.BF+2");
                                        Console.WriteLine("Close Kyo Snag: J.DB+2");
                                        Console.WriteLine("Twisted Kyo: DB+2");
                                        Console.WriteLine("Flame-Port: DB+3");
                                        Console.WriteLine("Devouring Flame: BF+4");
                                        break;
                                    case 3:
                                        Console.WriteLine("Scorpion Combos");
                                        Console.WriteLine("1. 1,2 > BF+2");
                                        Console.WriteLine("2. 3,3 > DB+2");
                                        Console.WriteLine("3. 2,1 > BF+4");
                                        Console.WriteLine("4. 1,2 > BF+1 > 333 > BF+2");
                                        Console.WriteLine("5. 1,2 > BF+1 > F+3,2 > F+3,2 > F+3,2 > 4 > BF+2");
                                        Console.WriteLine("6. 2,1 > BF+1 > F+3,2 > F+3,2 > J.1,2 > EXDB+2 > J.3 > BF+2");
                                        break;
                                    case 4:
                                        Console.WriteLine("Scorpion Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Sektor,Frost,Sareena,Ferra,Janet Cage,Khameleon,Kung Lao,Stryker,Mavado,Madam Bo,Scorpion,Sonya");
                                        Console.WriteLine("-Intermediate: Cyrax,Darrius,Frost,Goro,Jax,Kano,Tremor");
                                        Console.WriteLine("-Advanced: Shujinko,Motaro");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "BARAKA":
                            Console.WriteLine("Difficulty: Easy");
                            Console.WriteLine("Baraka is known for his aggressive playstyle and overwheling opponents with strong attacks and mix ups.");
                            Console.WriteLine("\n What would you like to learn about Baraka? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Baraka Key Moves:");
                                        Console.WriteLine("Gutwrencher: 1,2");
                                        Console.WriteLine("Reflex Tester: B+1");
                                        Console.WriteLine("Gurgler: 2,1");
                                        Console.WriteLine("Bleeding Foot: B+3");
                                        Console.WriteLine("Slaughterhouse: 4,4,4,4,4,4");
                                        Console.WriteLine("Muay Kry: F+4");
                                        Console.WriteLine("Battle Cry: B+3,1");
                                        break;
                                    case 2:
                                        Console.WriteLine("Baraka Special Moves");
                                        Console.WriteLine("Air Blade Sparks: J.DB+1");
                                        Console.WriteLine("Air Death Spin: J.DF+2");
                                        Console.WriteLine("Baraka Barrage: DF+2");
                                        Console.WriteLine("Bledding Blade: BF+1");
                                        Console.WriteLine("Chop Chop: BF+3");
                                        Console.WriteLine("Stab Stab: DB+1");
                                        break;
                                    case 3:
                                        Console.WriteLine("Baraka Combos");
                                        Console.WriteLine("1. 4,4,4,4,4,4 > DB+1");
                                        Console.WriteLine("2. 2,1 > BF+3");
                                        Console.WriteLine("3. 2,1 > DF+2");
                                        Console.WriteLine("4. B+3,1 > J.1,4 > 2,1 > DF+2");
                                        Console.WriteLine("5. B+3,1 > B+3,1 > DASH > 2,1 > DB+1");
                                        Console.WriteLine("6. F+3 > B+3,1 > DASH > 2,1 > DF+2");
                                        break;
                                    case 4:
                                        Console.WriteLine("Baraka Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Cyrax,Ferra,Frost,Janet Cage,Jax,Kano,Khameleon,Kung Lao,Sareena,Scorpion,Sub-Zero,Sonya");
                                        Console.WriteLine("-Intermediate: Darrius,Goro,Stryker,Mavado,Madam Bo,Sektor,Tremor");
                                        Console.WriteLine("-Advanced: Shujinko,Motaro");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "KUNG LAO":
                            Console.WriteLine("Difficulty: Easy");
                            Console.WriteLine("Kung Lao is a known for his hard hitting pressure and mix ups.");
                            Console.WriteLine("\n What would you like to learn about Kung Lao? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Kung Lao Key Moves:");
                                        Console.WriteLine("Swollen Throat: 1,2,1");
                                        Console.WriteLine("Madam El-Bo: 2,1,2");
                                        Console.WriteLine("Downward Slice: F+2");
                                        Console.WriteLine("Knee Buckle: B+3");
                                        Console.WriteLine("Leg Day: F+3,3");
                                        Console.WriteLine("Human Weapon: B+2,4");
                                        break;
                                    case 2:
                                        Console.WriteLine("Kung Lao Special Moves");
                                        Console.WriteLine("Air Dive Kick: J.DB+4");
                                        Console.WriteLine("Buzzsaw: BF+1");
                                        Console.WriteLine("Hat Toss: DB+1");
                                        Console.WriteLine("Kung-Kussion: DB+2");
                                        Console.WriteLine("Shaolin Shimmy: BF+2");
                                        Console.WriteLine("Shaolin Spin: DU+3");
                                        Console.WriteLine("Soaring Monk: DB+4");
                                        break;
                                    case 3:
                                        Console.WriteLine("Kung Lao Combos");
                                        Console.WriteLine("1. 2,1,2 > DB+4");
                                        Console.WriteLine("2. 1,2,1 > BF+1");
                                        Console.WriteLine("3. 1,2,1 > DB+1");
                                        Console.WriteLine("4. B+2,4 > B+2,4 > 1,2,1 > BF+2");
                                        Console.WriteLine("5. B+2,4 > B+2,4 > DASH > F+3,3 > EXDB+2 > 4 > DB+2");
                                        Console.WriteLine("6. 2,1,2 > EXDB+4 > J.2 > DASH > B+2,4 > DASH > 1,2,1 > BF+2");
                                        break;
                                    case 4:
                                        Console.WriteLine("Kung Lao Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Kung Lao,Goro,Ferra,Janet Cage,Jax,Khameleon,Mavado,Madam Bo,Sareena");
                                        Console.WriteLine("-Intermediate: Cyrax,Darrius,Kano,Stryker,Scorpion,Sektor,Sub-Zero,Sonya,Frost");
                                        Console.WriteLine("-Advanced: Shujinko,Motaro,Tremor");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "REPTILE":
                            Console.WriteLine("Difficulty: Easy");
                            Console.WriteLine("Reptile is knowing for space control with his projectiles and confusing opponents with his invisibility along with mix-ups and combos.");
                            Console.WriteLine("\n What would you like to learn about Reptile? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Reptile Key Moves:");
                                        Console.WriteLine("Kroco-Die-Le: 1,1");
                                        Console.WriteLine("Froggy Knee: 2,3");
                                        Console.WriteLine("Raking Blow: F+2,1");
                                        Console.WriteLine("Bloody Trail: B+3,1");
                                        Console.WriteLine("Hidden Klaws: F+3,1");
                                        Console.WriteLine("Visceral Klaw: F+3,2");
                                        break;
                                    case 2:
                                        Console.WriteLine("Reptile Special Moves");
                                        Console.WriteLine("Acid Spit: DF+1");
                                        Console.WriteLine("Air Falling Fangs: J.DB+4");
                                        Console.WriteLine("Dash Attack: BF+2");
                                        Console.WriteLine("Death Roll: BF+4");
                                        Console.WriteLine("Force Ball: DF+3");
                                        Console.WriteLine("Invisibility: DU+4");
                                        break;
                                    case 3:
                                        Console.WriteLine("Reptile Combos");
                                        Console.WriteLine("1. F+2,1 > BF+2");
                                        Console.WriteLine("2. F+3,2 > BF+4");
                                        Console.WriteLine("3. 2,3 > J.2,3,3 > DB+4");
                                        Console.WriteLine("4. HOLD B+2 > 2,3 > F+3,2 > BF+4");
                                        Console.WriteLine("5. F+2,3 > F+2,3 > F+3,2 > BF+4");
                                        Console.WriteLine("6. F+2,1 > DF+3 > F+2,3 > F+3,2 > BF+4");
                                        break;
                                    case 4:
                                        Console.WriteLine("Reptile Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Scorpion,Motaro,Cyrax,Ferra,Frost,Janet Cage,Khameleon,Madam Bo,Sareena");
                                        Console.WriteLine("-Intermediate: Darrius,Goro,Jax,Kano,Kung Lao,Stryker,Mavado,Motaro,Sektor,Sonya,Sub-Zero");
                                        Console.WriteLine("-Advanced: Shujinko");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "RAIDEN":
                            Console.WriteLine("Difficulty: Easy");
                            Console.WriteLine("Raiden is a all rounder with moves that can reach the opponents and good pressure.");
                            Console.WriteLine("\n What would you like to learn about Raiden? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Raiden Key Moves:");
                                        Console.WriteLine("Warrior's Stance: 1,2");
                                        Console.WriteLine("Deadly Current: 2,4,2,1");
                                        Console.WriteLine("Quick Learner: F+2,2");
                                        Console.WriteLine("The Basics: F+4,3");
                                        Console.WriteLine("Little Shock: 3,4");
                                        Console.WriteLine("Double Strike: F+3,4");
                                        break;
                                    case 2:
                                        Console.WriteLine("Raiden Special Moves");
                                        Console.WriteLine("Electric Fly: BF+3");
                                        Console.WriteLine("Electric Orb: DF+1Electromagnetic Storm: DB+3");
                                        Console.WriteLine("Lighting Port: DU");
                                        Console.WriteLine("Razzle Dazzle: DB+2");
                                        Console.WriteLine("Shocker: DF+2");
                                        break;
                                    case 3:
                                        Console.WriteLine("Raiden Combos");
                                        Console.WriteLine("1. F+4,3 > BF+3");
                                        Console.WriteLine("2. F+2,2 > DB+3");
                                        Console.WriteLine("3. 2,4,2,1 > DF+2");
                                        Console.WriteLine("4. 3,4 > J.2,1,2 > BF+3");
                                        Console.WriteLine("5. 3,4 > F+3,4 > F+2,2 > DF+2");
                                        Console.WriteLine("6. F+3,4 > F+3,4 > F+2,2 > EXDF+2 > 3 > DF+2");
                                        break;
                                    case 4:
                                        Console.WriteLine("Raiden Kameos based of easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Jax,Sektor,Kano,Cyrax,Darrius,Ferra,Frost,Goro,Janet Cage,Mavado,Madam Bo,Sareena,Scorpion,Sonya,Sub-Zero");
                                        Console.WriteLine("-Intermediate: Kano,Stryker,Motaro,Sektor,Tremor");
                                        Console.WriteLine("-Advanced: Shujinko");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "KITANA":
                            Console.WriteLine("Difficulty: Easy");
                            Console.WriteLine("Kitana is known for her mobile fan based attacks along with the zoning potential.");
                            Console.WriteLine("\n What would you like to learn about Kitana? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Kitana Key Moves:");
                                        Console.WriteLine("Limitless: 1,1");
                                        Console.WriteLine("Step Off: 2,4");
                                        Console.WriteLine("The Comeback: 2,4,1,2");
                                        Console.WriteLine("Heavy Is The Krown: B+2,4");
                                        Console.WriteLine("Booty Bump: B+3,4");
                                        break;
                                    case 2:
                                        Console.WriteLine("Kitana Special Moves");
                                        Console.WriteLine("Air Fan Nado: J.DB+1");
                                        Console.WriteLine("Bending Wind: BDF+4");
                                        Console.WriteLine("Fan Nado: DB+1");
                                        Console.WriteLine("Fan Toss: BF+1");
                                        Console.WriteLine("Princess Pirouette: DF+2");
                                        Console.WriteLine("Square Wave: DB+2");
                                        break;
                                    case 3:
                                        Console.WriteLine("Kitana Combos");
                                        Console.WriteLine("1. 2,4 > DF+2");
                                        Console.WriteLine("2. B+2,4 > DB+2");
                                        Console.WriteLine("3. B+2,4 > DB+1 > J.1 > J.1,1,2");
                                        Console.WriteLine("4. 2,4,1,2 > DB+1");
                                        Console.WriteLine("5. 4,F+3,4 > DB+1");
                                        Console.WriteLine("6. B+3,4 > DB+2");
                                        break;
                                    case 4:
                                        Console.WriteLine("Kitana Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Jax,Sub-Zero,Ferra,Frost,Goro,Janet Cage,Khameleon,Mavado,Madam Bo,Sareena,Scorpion");
                                        Console.WriteLine("-Intermediate: Cyrax,Darrius,Kano,Kung Lao,Stryker,Motaro,Sektor,Sonya,Tremor");
                                        Console.WriteLine("-Advanced: Shujinko");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "HAVIK":
                            Console.WriteLine("Difficulty: Easy");
                            Console.WriteLine("Havik is known for forcing opponents to adjust to his playstyle and reactions with his rushdown.");
                            Console.WriteLine("\n What would you like to learn about Havik? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Havik Key Moves:");
                                        Console.WriteLine("Cleric of Chaos: 1,1");
                                        Console.WriteLine("Undead Warrior: F+1,2");
                                        Console.WriteLine("Flesh Wound: 2,2");
                                        Console.WriteLine("Gut Buster: B+2,2");
                                        Console.WriteLine("Sinister Stomp: F+4");
                                        break;
                                    case 2:
                                        Console.WriteLine("Havik Special Moves");
                                        Console.WriteLine("Blood Bath: BF+2");
                                        Console.WriteLine("Helping Hand: DB+1");
                                        Console.WriteLine("Neoplasm: BF+1");
                                        Console.WriteLine("Seeking Neoplasm: BF+3");
                                        Console.WriteLine("Twist Torso: DB+4");
                                        break;
                                    case 3:
                                        Console.WriteLine("Havik Combos");
                                        Console.WriteLine("1. 1,1 > BF+1");
                                        Console.WriteLine("2. F+4 > DB+4");
                                        Console.WriteLine("3. B+2,2 > BF+2");
                                        Console.WriteLine("4. B+2,2 > BF+1 > J.2,1,2 > F1,2 > BF+2B");
                                        Console.WriteLine("5. B+2,2 > BF+1 > BF+2");
                                        Console.WriteLine("6. B+2,2 > BF+1 > DASH > B+2,2 > BF+2B");
                                        break;
                                    case 4:
                                        Console.WriteLine("Havik Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Sub-Zero,Cyrax,Jax,Darrius,Ferra,Janet Cage,Stryker,Mavado,Madam Bo,Sareena,Scorpion");
                                        Console.WriteLine("-Intermediate: Frost,Goro,Kano,Khameleon,Kung Lao,Sektor,Sonya,Tremor");
                                        Console.WriteLine("-Advanced: Shujinko,Motaro");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "MILEENA":
                            Console.WriteLine("Difficulty: Easy");
                            Console.WriteLine("Mileena is known for an aggressive and close range pressure and mix up potential.");
                            Console.WriteLine("\n What would you like to learn about Mileena? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Mileena Key Moves:");
                                        Console.WriteLine("Ambitious Strikes: 1,2");
                                        Console.WriteLine("Karrion Kuts: F+1,4,4");
                                        Console.WriteLine("The Right Sais: 2,1");
                                        Console.WriteLine("Rugsweeper: F+2,4");
                                        Console.WriteLine("Entry Point: 3");
                                        Console.WriteLine("Can't Fight It: F+3,4");
                                        break;
                                    case 2:
                                        Console.WriteLine("Mileena Special Moves");
                                        Console.WriteLine("Air Ball: J.DB+4");
                                        Console.WriteLine("Teleport Up: DB+2");
                                        Console.WriteLine("Low Sai: BF+3");
                                        Console.WriteLine("Roll: BD+4");
                                        Console.WriteLine("Straight Sai: BF+1");
                                        Console.WriteLine("Teleport Down: DF+2");
                                        break;
                                    case 3:
                                        Console.WriteLine("Mileena Combos");
                                        Console.WriteLine("1. 1,2 > BF+1");
                                        Console.WriteLine("2. F+1,4,4 > DB+2");
                                        Console.WriteLine("3. 2,1 > BD+4 > J.1,2,2 > BD+4");
                                        Console.WriteLine("4. 1,2 > BD+4 > J.2,2 > DB+4 > BD+4");
                                        Console.WriteLine("5. F+3,4 > BD+4 > J.2,2 > DB+4 > DASH > F+4");
                                        Console.WriteLine("6. 1,2 > EXDF+2 > J.1,2,2 > BD+4 > J.1,2,2 > DB+2");
                                        break;
                                    case 4:
                                        Console.WriteLine("Mileena Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Scorpion,Sonya,Cyrax,Darrius,Ferra,Frost,Goro,Janet Cage,Jax,Khameleon,Kung Lao,Mavado,Sareena");
                                        Console.WriteLine("-Intermediate: Kano,Stryker,Madam Bo,Motaro,Sektor,Sub-Zero,Tremor");
                                        Console.WriteLine("-Advanced: Shujinko");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "SEKTOR":
                            Console.WriteLine("Difficulty: Easy");
                            Console.WriteLine("Sektor is known for their zoning and anti-zoning tools.");
                            Console.WriteLine("\n What would you like to learn about Sektor? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Sektor Key Moves:");
                                        Console.WriteLine("Gut Crusher: 4,2");
                                        Console.WriteLine("Afterburn: 1,1");
                                        Console.WriteLine("Assembly Required: B+2");
                                        Console.WriteLine("Overcharging Elbow: F+2,1");
                                        Console.WriteLine("Shin Shatter: B+3");
                                        Console.WriteLine("Rocket Punch: F+2,1,2");
                                        break;
                                    case 2:
                                        Console.WriteLine("Sektor Special Moves");
                                        Console.WriteLine("Burst Grenade: J.DB+1");
                                        Console.WriteLine("Tactical Redeploy: DB+4");
                                        Console.WriteLine("Thrust Boost: UB/U/UF+Stance");
                                        Console.WriteLine("Anti-Air Flak: DB+2");
                                        Console.WriteLine("Blast Shield: DB+3");
                                        Console.WriteLine("Flamethrower: BF+2");
                                        Console.WriteLine("Sidewinder: DB+1");
                                        Console.WriteLine("Unguided Rocket: BF+1");
                                        break;
                                    case 3:
                                        Console.WriteLine("Sektor Combos");
                                        Console.WriteLine("1. 1,1 > BF+1");
                                        Console.WriteLine("2. 4,2 > BF+2");
                                        Console.WriteLine("3. F+2,1,2 > DB+4");
                                        Console.WriteLine("4. 1,1 > DB+4 > J.2,1,2 > DB+2 > J.2,1,2 > DB+4");
                                        Console.WriteLine("5. 1,1 > DB+4 > J.2,1,2 > DB+2 > J.1,3,4 > EXDB+4 > J.3,2");
                                        Console.WriteLine("6. F+2,1,2 > F+Stance > J.2,1,2 > DB+2 > J.2,1,2 > DB+4");
                                        break;
                                    case 4:
                                        Console.WriteLine("Sektor Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Motaro,Sonya,Kung Lao,Tremor,Mavado,Kano,Sektor,Stryker");
                                        Console.WriteLine("-Intermediate: Jax,Ferra,Frost,Janet Cage,Goro,Khameleon,Madam Bo,Sareena,Scorpion,Cyrax,Darrius,Sub-Zero");
                                        Console.WriteLine("-Advanced: Shujinko");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "T-1000":
                            Console.WriteLine("Difficulty: Easy");
                            Console.WriteLine("T-1000 is known for his rushdown pressure with mixups, combos, and command grabs.");
                            Console.WriteLine("\n What would you like to learn about T-1000? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("T-1000 Key Moves:");
                                        Console.WriteLine("Abdominal Crunch: 1,2");
                                        Console.WriteLine("Deltoid Snare: B+1");
                                        Console.WriteLine("Diaphragm Compressor: F+1,3");
                                        Console.WriteLine("Tibia Displacer: 2,4");
                                        Console.WriteLine("Thoracic Spike: 4,3");
                                        Console.WriteLine("Multiplanar Laceration: 4,3,4,3,4");
                                        Console.WriteLine("Diaphragm Rupturer: F+1,4");
                                        Console.WriteLine("Parietal Rod: 3,2,1");
                                        Console.WriteLine("Femoral Stab: B+3,2");
                                        break;
                                    case 2:
                                        Console.WriteLine("T-1000 Special Moves");
                                        Console.WriteLine("Acute Angle Hooks: DB+2");
                                        Console.WriteLine("Massive Droplet: J.DF+3");
                                        Console.WriteLine("Amorphous Step: BF+4");
                                        Console.WriteLine("Ballistic Approach: DF+1");
                                        Console.WriteLine("Ballistic Suppression: DB+1");
                                        Console.WriteLine("Sacral Spike: DB+3");
                                        Console.WriteLine("Superfluid Matter: BF+3");
                                        Console.WriteLine("Tornado Slam Emulation: DF+2");
                                        Console.WriteLine("Wrath Hammer Emulation: DFB+2");
                                        break;
                                    case 3:
                                        Console.WriteLine("T-1000 Combos");
                                        Console.WriteLine("1. B+3,2 > DF+2");
                                        Console.WriteLine("2. F+1,3 > DBF+2");
                                        Console.WriteLine("3. 3,2,1 > BF+3 > 2");
                                        Console.WriteLine("4. 4,3,3,3,3 > DB+3");
                                        Console.WriteLine("5. F+1,4 > DB+2");
                                        Console.WriteLine("6. F+1,4 > BF+3 > 2 > J.1,2,2 > B+3,2,1+3");
                                        break;
                                    case 4:
                                        Console.WriteLine("T-100 Kameos based off easiest to advanced for combo/strategy");
                                        Console.WriteLine("-Easy: Cyrax,Darrius,Ferra,Janet Cage,Jax,Khameleon,Mavado,Scorpion");
                                        Console.WriteLine("-Intermediate: Frost,Goro,Kano,Kung Lao,Stryker,Madam Bo,Sareena,Sektor,Sonya,Sub-Zero");
                                        Console.WriteLine("-Advanced: Motaro, Shujinko");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "PEACEMAKER":
                            Console.WriteLine("Difficulty: Easy");
                            Console.WriteLine("Peacemaker is known for his brawler tactics with close range attacks and mix-ups.");
                            Console.WriteLine("\n What would you like to learn about Peacemaker? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Peacemaker Key Moves:");
                                        Console.WriteLine("Clock Cleaner: 1,2");
                                        Console.WriteLine("Peace Eater: F+1,1");
                                        Console.WriteLine("Bee Stinger: 2,2");
                                        Console.WriteLine("Krotch Obilterator: B+2,4");
                                        Console.WriteLine("Flag Flyer: F+4,1,2");
                                        break;
                                    case 2:
                                        Console.WriteLine("Peacemaker Special Moves");
                                        Console.WriteLine("Activate Anti-Gravity: DB+2");
                                        Console.WriteLine("Activate Force Field: FDB+3");
                                        Console.WriteLine("Activate Human Torpedo: BF+2");
                                        Console.WriteLine("Activate Sonic Boom: BF+2");
                                        Console.WriteLine("Beautiful Bird Bullet: DB+4");
                                        Console.WriteLine("Force Multiplier: BF+1");
                                        Console.WriteLine("Ground-Air Offensive: DF+4");
                                        Console.WriteLine("Silent And Deadly: DB+1");
                                        Console.WriteLine("The Ultimate Ally: D+Stance");
                                        break;
                                    case 3:
                                        Console.WriteLine("Peacemaker Combos");
                                        Console.WriteLine("1. B+2,4 > BF+2");
                                        Console.WriteLine("2. 2,2 > BF+3");
                                        Console.WriteLine("3. F+4,1,2 > DF+4");
                                        Console.WriteLine("4. 2,2,1+3 > DB+4 > BF+2");
                                        Console.WriteLine("5. F+4,1,2 > BF+3 > BF+2");
                                        Console.WriteLine("6. 2,2 > BF+3 > DASH > F+4,1,2 > BF+2");
                                        break;
                                    case 4:
                                        Console.WriteLine("Peacemaker Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Cyrax,Ferra,Frost,Janet Cage,Khameleon,Sareena,Scorpion,Sonya,Sub-Zero");
                                        Console.WriteLine("-Intermediate: Darrius,Goro,Jax,Kano,Kung Lao,Stryker,Mavado,Sektor");
                                        Console.WriteLine("-Advanced: Motaro,Shujinko");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "LI MEI":
                            Console.WriteLine("Difficulty: Easy");
                            Console.WriteLine("Li Mei is known for their rushdown pressure and options for zoning along with latern setups.");
                            Console.WriteLine("\n What would you like to learn about Li Mei? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Li Mei Key Moves:");
                                        Console.WriteLine("Seeking Sanctuary: 1,2,4");
                                        Console.WriteLine("Seasoned Warrior: 2,1");
                                        Console.WriteLine("Double Palm: B+2");
                                        Console.WriteLine("Rough Zuffa: 4,3");
                                        Console.WriteLine("Pankration Champion: 4,3,1,2");
                                        Console.WriteLine("Sliding In: F+4");
                                        Console.WriteLine("No Holds Barred: B+3,4");
                                        Console.WriteLine("Kick Precision: F+4,3");
                                        break;
                                    case 2:
                                        Console.WriteLine("Li Mei Special Moves");
                                        Console.WriteLine("Air Flipping Heel Kick: J.DB+4");
                                        Console.WriteLine("Chain Reaction: BF+4");
                                        Console.WriteLine("Foo Tang: DB+3");
                                        Console.WriteLine("Nova Blast: BF+1");
                                        Console.WriteLine("Sky Lantern: DB+2");
                                        break;
                                    case 3:
                                        Console.WriteLine("Li Mei Combos");
                                        Console.WriteLine("1. 2,1 > DB+3");
                                        Console.WriteLine("2. B+3,4 > BF+4");
                                        Console.WriteLine("3. F+4,3 > J.1,3,4 > DB+4");
                                        Console.WriteLine("4. F+4,3 > 4,3 > EXBF+1 > DB+2 > J.1,3,4 > DB+4");
                                        Console.WriteLine("5. F+4,3 > J.2,1,2 > EXBF+1 > 4 > BF+4");
                                        Console.WriteLine("6. DB+2 > F+4,3 > J.2,1,2 > EXBF+1 > DASH > DB+2 > J.1,3,4 > DB+4");
                                        break;
                                    case 4:
                                        Console.WriteLine("Li Mei Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Scorpion,Sonya,Jax,Ferra,Janet Cage,Mavado,Sareena");
                                        Console.WriteLine("-Intermediate: Cyrax,Darrius,Frost,Goro,Khameleon,Kung Lao,Stryker,Madam Bo,Sektor,Sub-Zero,Tremor");
                                        Console.WriteLine("-Advanced: Motaro,Shujinko");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "REIKO":
                            Console.WriteLine("Difficulty: Easy");
                            Console.WriteLine("Reiko is known his close range attacks, mix-ups, and command grabs.");
                            Console.WriteLine("\n What would you like to learn about Reiko? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Reiko Key Moves:");
                                        Console.WriteLine("Body Bag: F+1,2");
                                        Console.WriteLine("Devastating Blow: 1,2");
                                        Console.WriteLine("Deadly Warfare: 2,1");
                                        Console.WriteLine("Kollateral Damage: 3,4");
                                        Console.WriteLine("Push Kick: B+3");
                                        Console.WriteLine("Mass Casualities: 4,3,4");
                                        break;
                                    case 2:
                                        Console.WriteLine("Reiko Special Moves");
                                        Console.WriteLine("Assassin Throwing Stars: BF+2");
                                        Console.WriteLine("Charging Pain: BF+3");
                                        Console.WriteLine("Pale Rider: BDF+1");
                                        Console.WriteLine("Retaliation: DB+1");
                                        Console.WriteLine("Tactical Takedown: DB+3");
                                        break;
                                    case 3:
                                        Console.WriteLine("Reiko Combos");
                                        Console.WriteLine("1. F+1,2 > DB+3");
                                        Console.WriteLine("2. 4,3,4 > BF+3");
                                        Console.WriteLine("3. F+1,2,4 > J.2,1,4");
                                        Console.WriteLine("4. F+1,2,4 > 3,4 > DB+3");
                                        Console.WriteLine("5. 2,1 > BF3U > 3,4 > EXBF+3 > 3 > BDF+1");
                                        Console.WriteLine("6. F+1,2,4 > DASH > 3,4 > EXBF+3 > DB+3");
                                        break;
                                    case 4:
                                        Console.WriteLine("Reiko Kameos based off easiest to advanced for Combos/strategy");
                                        Console.WriteLine("-Easy: Scorpion,Darrius,Tremor,Sonya,Ferra,Janet Cage,Mavado,Sareena,Sub-Zero");
                                        Console.WriteLine("-Intermediate: Cyrax,Frost,Goro,Jax,Kano,Khameleon,Kung Lao,Stryker,Madam Bo,Sektor");
                                        Console.WriteLine("-Advanced: Motaro,Shujinko");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "CONAN":
                            Console.WriteLine("Difficulty: Easy");
                            Console.WriteLine("Conan is known for his close range attacks, strong grabs, and controling the space to apply pressure.");
                            Console.WriteLine("\n What would you like to learn about Conan? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Conan Key Moves:");
                                        Console.WriteLine("Half-Sword Check: 1,1");
                                        Console.WriteLine("Abdomen Slice: B+1,2");
                                        Console.WriteLine("Gut Thrust: 2,2");
                                        Console.WriteLine("Rogue Rogue: F+2,1,1");
                                        Console.WriteLine("Reverse-Grip Return: 3,2");
                                        Console.WriteLine("Destroyer's Boot: B+3");
                                        Console.WriteLine("Skull Splitter: F+3,3");
                                        Console.WriteLine("Thief's Elbow: 4,2");
                                        Console.WriteLine("Two-Handed Sweep: F+3,3,4");
                                        break;
                                    case 2:
                                        Console.WriteLine("Conan Special Moves");
                                        Console.WriteLine("Destroyer's Drop: J.DB+1");
                                        Console.WriteLine("Atlantean Bulwark: DF+1");
                                        Console.WriteLine("Barbarian's Blitz: BF+3");
                                        Console.WriteLine("Berserker's March: BF+4");
                                        Console.WriteLine("Camel Counter: DB+1");
                                        Console.WriteLine("Cimmerian Rising: DF+2");
                                        Console.WriteLine("Crom's Curse: DB+Stance");
                                        Console.WriteLine("Skyward Guardian: DB+2");
                                        Console.WriteLine("Thief's Catapult: DF+Stance");
                                        break;
                                    case 3:
                                        Console.WriteLine("Conan Combos");
                                        Console.WriteLine("1. 1,1 > DF+1");
                                        Console.WriteLine("2. F+2,1,1 > BF+3");
                                        Console.WriteLine("3. 2,2 > BF+4");
                                        Console.WriteLine("4. B+1,2 > DF+2 > 1");
                                        Console.WriteLine("5. F+3,3,4 > J.1,2,3 > DB+2 > 3,2 > DF+2 > 1");
                                        Console.WriteLine("6. F+3,3,4 > 4 > DB+2 > 3,2 > EXDB+2 > 3,2 > DF+2 > 1");
                                        break;
                                    case 4:
                                        Console.WriteLine("Conan Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Ferra,Janet Cage,Khameleon,Jax,Mavado,Sareena,Scorpion,Sonya,Sub-Zero");
                                        Console.WriteLine("-Intermediate: Cyrax,Darrius,Frost,Goro,Kano,Kung Lao,Stryker,Madam Bo,Sektor,Tremor");
                                        Console.WriteLine("-Advanced: Motaro,Shujinko");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        //Intermediate to learn
                        case "JOHNNY CAGE":
                            Console.WriteLine("Difficulty: Intermediate");
                            Console.WriteLine("Johnny Cage is a rushdown character that focuses on close range and mix-up attacks.");
                            Console.WriteLine("\n What would you like to learn about Johnny Cage? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Johnny Cage Key Moves:");
                                        Console.WriteLine("Elbow's World: F+1,2");
                                        Console.WriteLine("Legbanged Redemptshin: 2,1,4");
                                        Console.WriteLine("Gutbusters: B+2");
                                        Console.WriteLine("Elbow Before Me: F+3,2");
                                        Console.WriteLine("Style Points: F+3,4");
                                        Console.WriteLine("Dunking On Haters: 2,1,2");
                                        Console.WriteLine("Flipper: F+4");
                                        Console.WriteLine("Back To The Footure: F+1,2,4");
                                        break;
                                    case 2:
                                        Console.WriteLine("Johnny Cage Special Moves");
                                        Console.WriteLine("Ball Buster: BD+1");
                                        Console.WriteLine("Hype: FDB+4");
                                        Console.WriteLine("Rising Star: DB+3");
                                        Console.WriteLine("Shadow Dash: DF+3");
                                        Console.WriteLine("Shadow Kick: BF+4");
                                        Console.WriteLine("Show Off: DB+1");
                                        Console.WriteLine("Throwing Shade: FDB+2");
                                        break;
                                    case 3:
                                        Console.WriteLine("Johnny Cage Combos");
                                        Console.WriteLine("1. 2,1,4 > BF+4");
                                        Console.WriteLine("2. F+1,2 > DB+3");
                                        Console.WriteLine("3. F+3,4 > F+3,2,1 > BF+4");
                                        Console.WriteLine("4. HOLD B+2 > DASH > 2,1,2 > DASH > F+3,2 > BF+4");
                                        Console.WriteLine("5. HOLD B+2 > DASH > 2,1,2 > DASH > F+1,2 > BD+1 ");
                                        Console.WriteLine("6. F+4 > DASH > 2,1,2 > DASH > F+3,2 > BF+4");
                                        break;
                                    case 4:
                                        Console.WriteLine("Johnny Cage Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Kano,Stryker,Frost,Sub-Zero,Sareena,Cyrax,Janet Cage,Khameleon,Kung Lao,Scorpion,Sonya");
                                        Console.WriteLine("-Intermediate: Darrius,Ferra,Goro,Jax,Mavado,Madam Bo,Sektor,Tremor");
                                        Console.WriteLine("-Advanced: Shujinko,Motaro");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "GENERAL SHAO":
                            Console.WriteLine("Difficulty: Intermediate");
                            Console.WriteLine("General Shao is known for thier stance attacks with strong mid-range attacks and mix-ups.");
                            Console.WriteLine("\n What would you like to learn about General Shao? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("General Shao Key Moves:");
                                        Console.WriteLine("Direct Orders: F+1,2,2 ");
                                        Console.WriteLine("Fury Strikes: 1,2");
                                        Console.WriteLine("For The Jugular: B+1");
                                        Console.WriteLine("Forward March: 2,2");
                                        Console.WriteLine("Beneath Me: B+3");
                                        break;
                                    case 2:
                                        Console.WriteLine("General Shao Special Moves");
                                        Console.WriteLine("Axe Recall (No Axe to Axe): DF+4");
                                        Console.WriteLine("Dark Energy (Axe): DF+1");
                                        Console.WriteLine("Death Quake (Axe): DB+4");
                                        Console.WriteLine("Devastator (Axe): DB+3");
                                        Console.WriteLine("Power Strike (Axe to No Axe): DF+4");
                                        Console.WriteLine("Reverse Treechopper (No Axe to Axe): DF+2B");
                                        Console.WriteLine("Treechopper (No Axe, Near Axe): DF+1");
                                        break;
                                    case 3:
                                        Console.WriteLine("General Shao Combos");
                                        Console.WriteLine("1. F+1,2,2 > DB+3");
                                        Console.WriteLine("2. 1,2 > DF+4");
                                        Console.WriteLine("3. 1,2 > DF+4 > 2,2 > DF+2");
                                        Console.WriteLine("4. 1,2 > DF+4 > B+3,2 > 2,2 > DB+3");
                                        Console.WriteLine("5. F+1,2,2 > DF+4 > DASH > 2 > DF+2");
                                        Console.WriteLine("6. 2,2 > EXDB+3 > DF+4 > 2,2 > DF+2");
                                        break;
                                    case 4:
                                        Console.WriteLine("General Shao Kameos based off easiest to advanced for combo/strategy");
                                        Console.WriteLine("-Easy: Sektor,Sonya,Sub-Zero,Sareena,Kung Lao,Frost,Darrius,Ferra,Janet Cage,Mavado,Madam Bo");
                                        Console.WriteLine("-Intermediate: Cyrax,Kano,Khameleon,Stryker,Scorpion,Motaro,Goro,Tremor,Jax");
                                        Console.WriteLine("-Advanced: Shujinko");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "TANYA":
                            Console.WriteLine("Difficulty: Intermediate");
                            Console.WriteLine("Tanya is known for her mobility and mix-up potential attacks.");
                            Console.WriteLine("\n What would you like to learn about Tanya? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Tanya Key Moves:");
                                        Console.WriteLine("Activate Threat: 1,2");
                                        Console.WriteLine("Devoted Follower: F+2,1,1");
                                        Console.WriteLine("Branching Out: 3");
                                        Console.WriteLine("Crossed Kick: B+3");
                                        Console.WriteLine("Wraparound: 2,1+3");
                                        break;
                                    case 2:
                                        Console.WriteLine("Tanya Special Moves");
                                        Console.WriteLine("Deity Push: DB+Hold3+B");
                                        Console.WriteLine("Divine Protection: DB+3");
                                        Console.WriteLine("Drill Kick: BF+4");
                                        Console.WriteLine("Heavenly Hand: DF+1");
                                        Console.WriteLine("Seeking Guidance: DF+3");
                                        Console.WriteLine("Spinning Splits Kick: DB+4");
                                        Console.WriteLine("Umgadi Dodge (Requires 2 Guidance): DF+3");
                                        Console.WriteLine("Umgadi Evade: DB+Hold3+F");
                                        break;
                                    case 3:
                                        Console.WriteLine("Tanya Combos");
                                        Console.WriteLine("1. 2,1+3 > BF+4");
                                        Console.WriteLine("2. F+2,1,1 > DB+4");
                                        Console.WriteLine("3. F+2,1,1 > EXBF+4 > DASH > F+2,1,1 > BF+4");
                                        Console.WriteLine("4. F+2,1,1 > EXBF+4 > DASH > F+4 > 2,1+3 > BF+4");
                                        Console.WriteLine("5. 2,1+3 > EXBF+4 > DASH > F+2,1,1 > DB+4");
                                        Console.WriteLine("6. 3 > DF+3 > J1 > F+2,1,1 > EXBF+4 > DASH > F+4 > DASH > F4 > DASH > 2,1+3 > BF+4");
                                        break;
                                    case 4:
                                        Console.WriteLine("Tanya Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Goro,Sub-Zero,Frost,Scorpion,Darrius,Ferra,Janet Cage,Khameleon,Mavado,Madam Bo,Sareena");
                                        Console.WriteLine("-Intermediate: Cyrax,Jax,Kano,Kung Lao,Stryker,Sektor,Sonya,Tremor");
                                        Console.WriteLine("-Advanced: Shujinko,Motaro");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "TAKEDA":
                            Console.WriteLine("Difficulty: Intermediate");
                            Console.WriteLine("Takeda is known for his space control and mix-ups attacks.");
                            Console.WriteLine("\n What would you like to learn about Takeda? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Takeda Key Moves:");
                                        Console.WriteLine("Twisting Blades: 1,2");
                                        Console.WriteLine("Rising Suns: F+1,2");
                                        Console.WriteLine("Falling Moon: F+1,4");
                                        Console.WriteLine("Stomach Smasher: 2,1");
                                        Console.WriteLine("Temple Razer: B+2,1");
                                        Console.WriteLine("Ankle Biter: B+3");
                                        break;
                                    case 2:
                                        Console.WriteLine("Takeda Special Moves");
                                        Console.WriteLine("Reverse Falling Stars: DB+1");
                                        Console.WriteLine("Falling Star: J.DF+1");
                                        Console.WriteLine("Rushing Nimbus Attack: J.DB+3");
                                        Console.WriteLine("Rushing Nimbus Technique: J.BF+3");
                                        Console.WriteLine("Smart Shuriken: J.DB+1");
                                        Console.WriteLine("Spear Ryu: J.DB+2");
                                        Console.WriteLine("Tornado Kick: DB+4");
                                        Console.WriteLine("Double Spear Ryu: BF+2");
                                        Console.WriteLine("Shooting Star: DF+1");
                                        Console.WriteLine("Swift Stride: BF+3");
                                        Console.WriteLine("Whip Art: DF+4");
                                        break;
                                    case 3:
                                        Console.WriteLine("Takeda Combos");
                                        Console.WriteLine("1. 1,2 > BF+2");
                                        Console.WriteLine("2. F+1,2 > BF+3");
                                        Console.WriteLine("3. F+1,2 > DF+4 > DF+4 > DF+4");
                                        Console.WriteLine("4. B+2,1 > EXBF+2 > J.2,4,1+3");
                                        Console.WriteLine("5. B+2,1 > EXBF+2 > J.2,4 > BF+3 > J.2,4,1+3");
                                        Console.WriteLine("6. 2,1 > DF+4 > DF+4 > EXDF+4 > J.2,4 > BF+3 > J.2,4,1+3");
                                        break;
                                    case 4:
                                        Console.WriteLine("Takeda Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Janet Cage,Cyrax,Jax,Ferra,Mavado,Khameleon,Sektor,Scorpion");
                                        Console.WriteLine("-Intermediate: Kung Lao,Sareena,Motaro,Sonya,Stryker,Goro,Sub-Zero,Frost,Kano");
                                        Console.WriteLine("-Advanced: Shunjinko,Darrius,Tremor");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "ERMAC":
                            Console.WriteLine("Difficulty: Intermediate");
                            Console.WriteLine("Ermac is known for their rushdown pressure with a mixure of attacks, grabs, and teleporting.");
                            Console.WriteLine("\n What would you like to learn about Ermac? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Ermac Key Moves:");
                                        Console.WriteLine("Heavy Wights: B+2,4");
                                        Console.WriteLine("Sinking Feeling: 1,2");
                                        Console.WriteLine("Ceiling Krawl:F+2");
                                        Console.WriteLine("Kasket Kloser: 4");
                                        break;
                                    case 2:
                                        Console.WriteLine("Ermac Special Moves");
                                        Console.WriteLine("Hungry Hands: J.DB+3");
                                        Console.WriteLine("Shifting Spirits: DB+4");
                                        Console.WriteLine("Suspended Animation: DB+2");
                                        Console.WriteLine("Behind You: BF+2");
                                        Console.WriteLine("Death's Embrace: FDB+3");
                                        Console.WriteLine("Spirit Punch: BF+1");
                                        Console.WriteLine("Too Late: BF+2");
                                        Console.WriteLine("Witch Slam: DB+1");
                                        break;
                                    case 3:
                                        Console.WriteLine("Ermac Combos");
                                        Console.WriteLine("1. B+2,4 > BF+1");
                                        Console.WriteLine("2. 1,2 > DB+1");
                                        Console.WriteLine("3. B+2,4 > 4 > BF+2");
                                        Console.WriteLine("4. B+2,4 > 4 > EXDB+1 > J.1,4 > 1,2,3,1+3");
                                        Console.WriteLine("5. 1,2 > EXDB+1 > J.2,4 > DB+2 > J.1,4 > 1,2,3,1+3");
                                        Console.WriteLine("6. EXDB+4 > B+2,4 > 1,2 > BF+2");
                                        break;
                                    case 4:
                                        Console.WriteLine("Ermac Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Janet Cage,Scorpion,Sonya,Sareena,Mavado,Sub-Zero");
                                        Console.WriteLine("-Intermediate: Kung Lao,Mavado,Jax,Kano,Khameleon,Stryker,Ferra,Cyrax,Sektor,Frost");
                                        Console.WriteLine("-Advanced: Shunjinko,Motaro,Tremor,Goro,Darrius");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "CYRAX":
                            Console.WriteLine("Difficulty: Intermediate");
                            Console.WriteLine("Cyrax is known for their technical playstyle by setting up bomb traps.");
                            Console.WriteLine("\n What would you like to learn about Cyrax? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Cyrax Key Moves:");
                                        Console.WriteLine("Short Circuit: 1,1");
                                        Console.WriteLine("Bionic Kick: 2,3");
                                        Console.WriteLine("Quick Buzz: F+2");
                                        Console.WriteLine("Syntax Error: B+3,3,4");
                                        Console.WriteLine("Metal Mid Heel: B+3,3");
                                        break;
                                    case 2:
                                        Console.WriteLine("Cryax Special Moves");
                                        Console.WriteLine("Friction Assist Snare: J.DB+4");
                                        Console.WriteLine("Friction Boot Parkour: J.U+Block");
                                        Console.WriteLine("Bomb Mistwalk: DB+3");
                                        Console.WriteLine("Capture Foam: BF+1");
                                        Console.WriteLine("Close Bomb: DB+2");
                                        Console.WriteLine("Far Bomb: DBF+2");
                                        Console.WriteLine("Mid Bomb: DF+2");
                                        Console.WriteLine("Mistwalk: DF+3");
                                        Console.WriteLine("Sawtooth Kick: DB+4");
                                        break;
                                    case 3:
                                        Console.WriteLine("Cryax Combos");
                                        Console.WriteLine("1. 1,1 > DB+4");
                                        Console.WriteLine("2. B+3,3 > BF+1");
                                        Console.WriteLine("3. 2,1 > 2,1 > 2,1 > 2,3 > DB+4");
                                        Console.WriteLine("4. 2,1 > 2,1 > DASH > B+3,3,4 > DB+4");
                                        Console.WriteLine("5. 2,1 > 3 > BF+1 > DBF+2 > J.3,4 > J.3,4 > DB+4");
                                        Console.WriteLine("6. 2,1 > 3 > BF+1 > DF+2 > DF+2 > DF+2 > 3 > 3 > 3 > DB+4");
                                        break;
                                    case 4:
                                        Console.WriteLine("Cyrax Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Scorpion,Kano,Madam Bo,Mavado,Sareena,Sonya,Cyrax,Ferra,Frost,Sonya");
                                        Console.WriteLine("-Intermediate: Janet,Sektor,Stryker,Sub-Zero,Khameleon,Kung Lao,Goro,Jax");
                                        Console.WriteLine("-Advanced: Shujinko,Tremor,Motato");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "GHOSTFACE":
                            Console.WriteLine("Difficulty: Intermediate");
                            Console.WriteLine("Ghostface is known for their tricky mix-ups and pressure with their command grabs and attacks.");
                            Console.WriteLine("\n What would you like to learn about Ghostface? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Ghostface Key Moves:");
                                        Console.WriteLine("Slasher Flick: 1,2");
                                        Console.WriteLine("Director's Cut: 2,2");
                                        Console.WriteLine("Final Cut: 2,2,2");
                                        Console.WriteLine("Weary Slice: B+3");
                                        Console.WriteLine("Stab Trilogy: 4,4");
                                        Console.WriteLine("Jilted Lover: F+2,1");
                                        break;
                                    case 2:
                                        Console.WriteLine("Ghostface Special Moves");
                                        Console.WriteLine("Always Outnumbered: DB+4");
                                        Console.WriteLine("Backstage Pass: DB+3");
                                        Console.WriteLine("Father Death: BDF+1");
                                        Console.WriteLine("Psychotic Dive: DF+4");
                                        Console.WriteLine("Psychotic Rush: DF+3");
                                        break;
                                    case 3:
                                        Console.WriteLine("Ghostface Combos");
                                        Console.WriteLine("1. 1,2 > DF+4,1");
                                        Console.WriteLine("2. 2,2,2 > DF+3,1");
                                        Console.WriteLine("3. 2,2,2 > BDF+1");
                                        Console.WriteLine("4. 2,2,1+3 > J.2,2 > F+4 > J.2,2 > B+3 > DF+3,1");
                                        Console.WriteLine("5. F+4 > J.2,2 > 2,2,1+3 > > J.2,2 > B+3 > DF+3,1");
                                        Console.WriteLine("6. F+2,1 > EXDB+3 > 2,2,1+3 > J.2,2 > F+4 > J.2,2 > B+3 > DF+3,1");
                                        break;
                                    case 4:
                                        Console.WriteLine("Ghost Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Mavado,Sektor,Scorpion,Sareena,Ferra,Kano,Madam Bo,Cyrax,Janet Cage");
                                        Console.WriteLine("-Intermediate: Darrius,Sonya,Stryker,Jax,Tremor,Khameleon,Frost,Kung Lao,Sub-Zero,Goro");
                                        Console.WriteLine("-Advanced: Shujinko,Motaro");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "SMOKE":
                            Console.WriteLine("Difficulty: Intermediate");
                            Console.WriteLine("Smoke is known for being extremely aggressive to overwhelm the opponents with pressure.");
                            Console.WriteLine("\n What would you like to learn about Smoke? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Smoke Key Moves:");
                                        Console.WriteLine("Never Submit: 1,1");
                                        Console.WriteLine("No Escape: 1,1,1,4");
                                        Console.WriteLine("Perfect Pierce: F+1,2");
                                        Console.WriteLine("Missing The Toes: F+1,2,2,4");
                                        Console.WriteLine("Everywhere: 2,1,2");
                                        Console.WriteLine("Smoke Damage (Low): B+2,3");
                                        Console.WriteLine("Tricky Karambit: F+3,2");
                                        Console.WriteLine("Kutting-Room Four: F+1,2,1+3");
                                        break;
                                    case 2:
                                        Console.WriteLine("Smoke Special Moves");
                                        Console.WriteLine("Shadow Blade: DB+1");
                                        Console.WriteLine("Smoke Bomb: DB+2");
                                        Console.WriteLine("Smoke-Port: DB+4");
                                        Console.WriteLine("Vicious Vapors: BF+3");
                                        break;
                                    case 3:
                                        Console.WriteLine("Smoke Combos");
                                        Console.WriteLine("1. 1,1 > BF+3");
                                        Console.WriteLine("2. F+3,2 > DB+2");
                                        Console.WriteLine("3. F+1,2,2,4 > DB+1");
                                        Console.WriteLine("4. F+1,2,1+3 > EXDB+4 > J.1,1,2");
                                        Console.WriteLine("5. F+1,2,1+3 > EXDB+4 > J.1,1 > EXDB+4 > J.1,1 > EXDB+4 > J.1,1,2");
                                        Console.WriteLine("6. 3,2 > DASH > 3,2 > F1,2,1+3 > DB+1");
                                        break;
                                    case 4:
                                        Console.WriteLine("Smoke Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Scorpion,Sareena,Sektor,Darrius,Stryker,Ferra,Goro,Janet Cage,Mavado,Madam Bo");
                                        Console.WriteLine("-Intermediate: Cyrax,Frost,Jax,Kano,Khameleon,Kung Lao,Sonya,Sub-Zero,Tremor");
                                        Console.WriteLine("-Advanced: Shujinko,Motaro");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "OMNI-MAN":
                            Console.WriteLine("Difficulty: Intermediate");
                            Console.WriteLine("Omni-Man is known for their strong attacks and mix up attacks.");
                            Console.WriteLine("\n What would you like to learn about Omni-Man? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Omni-Man Key Moves:");
                                        Console.WriteLine("Konquerer Killer: 1,2");
                                        Console.WriteLine("Demon Slaying Punch: 2,2");
                                        Console.WriteLine("Earthquake Stomp: F+3");
                                        Console.WriteLine("Spilled Kontents: F+4,1");
                                        break;
                                    case 2:
                                        Console.WriteLine("Omni-Man Special Moves");
                                        Console.WriteLine("Fly Toward: J.F+Block");
                                        Console.WriteLine("Giblet Maker: BF+2");
                                        Console.WriteLine("Invincible Rush: BF+4");
                                        Console.WriteLine("Mega Clap: BF+1");
                                        Console.WriteLine("Viltrumite Stance: DB+3");
                                        Console.WriteLine("- Thragged Through Mud: 1");
                                        Console.WriteLine("- Honorable Death: 2");
                                        Console.WriteLine("- TieBreaker: 3");
                                        Console.WriteLine("- Up and Away: 4");
                                        break;
                                    case 3:
                                        Console.WriteLine("Omni-Man Combos");
                                        Console.WriteLine("1. 1,2 > BF+4");
                                        Console.WriteLine("2. 2,2 > BF+1");
                                        Console.WriteLine("3. 1,2 > DB+3,1 > J.1,2,1+3");
                                        Console.WriteLine("4. 1,2 > DB+3,1 > J.2,1,2 > F+Stance > J.1,2,1+3");
                                        Console.WriteLine("5. 1,2 > DB+3,1 > J.2,1,2 > F+Stance > J.2,1,2 > F+Stance > J.1,2,1+3");
                                        Console.WriteLine("6. 1,2 > EXDB+3,4 > 3 > DB+3,1 > J.2,1,2 > F+Stance > J.1,2,1+3 ");
                                        break;
                                    case 4:
                                        Console.WriteLine("Omni-Man Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Darrius,Kung Lao,Sareena,Mavado,Ferra,Scorpion,Jax");
                                        Console.WriteLine("-Intermediate: Cyrax,Tremor,Goro,Frost,Sonya,Kano,Stryker,Sub-Zero,Janet Cage, Madam Bo,Khameleon,Sektor");
                                        Console.WriteLine("-Advanced: Shujinko,Motaro");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        //Advanced to learn
                        case "GERAS":
                            Console.WriteLine("Difficulty: Advanced");
                            Console.WriteLine("Geras is known for rushdown methods but has some grapple moves with his time stop.");
                            Console.WriteLine("\n What would you like to learn about Geras? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Geras Key Moves:");
                                        Console.WriteLine("Clogged Up: 1,2");
                                        Console.WriteLine("Speed Up: B+1,2");
                                        Console.WriteLine("Slow Down: F+1,2");
                                        Console.WriteLine("Elbow Before Me: 2,1");
                                        Console.WriteLine("Stopping Time: F+2,4,2");
                                        Console.WriteLine("For The Fire God: F+4,4");
                                        break;
                                    case 2:
                                        Console.WriteLine("Geras Special Moves");
                                        Console.WriteLine("Countdown: DB+3");
                                        Console.WriteLine("Denial: DB+4");
                                        Console.WriteLine("Fixed Point (Countdown at 3): DB+3");
                                        Console.WriteLine("Follow-Up Exam: DB+2");
                                        Console.WriteLine("History Lesson: DF+2");
                                        Console.WriteLine("Inevitable (Countdown at 3): DB+3");
                                        Console.WriteLine("Redo: BF+3");
                                        Console.WriteLine("Sandstorm: DF+4");
                                        Console.WriteLine("Time Stop: BF+1");
                                        break;
                                    case 3:
                                        Console.WriteLine("Geras Combos");
                                        Console.WriteLine("1. 1,2 > BF+1");
                                        Console.WriteLine("2. B+1,2 > DF+2");
                                        Console.WriteLine("3. F+2,4 > DF+4 > 1 > DASH > 1,2,2,1+3");
                                        Console.WriteLine("4. F+2,4 > DF+4 > 1 > F+2,4 > DF+2");
                                        Console.WriteLine("5. F+2,4 > DF+4 > 1 > F+2,4 > EXBF+1 > DB+3 > DASH > 1,2,2,1+3");
                                        Console.WriteLine("6. F+2,4 > DF+4 > 1 > F+2,4 > EXBF+1 > 4 > DB+4 > F+2 > DF+2");
                                        break;
                                    case 4:
                                        Console.WriteLine("Geras Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Sub-Zero,Sareena,Kung Lao,Cyrax,Ferra,Mavado,Madam Bo");
                                        Console.WriteLine("-Intermediate: Darrius,Sektor,Stryker,Frost,Goro,Jax,Kano,Khameleon,Janet Cage,Tremor");
                                        Console.WriteLine("-Advanced: Motaro,Shujinko,Sonya,Scopion");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "KENSHI":
                            Console.WriteLine("Difficulty: Advanced");
                            Console.WriteLine("Kenshi is a technical character with the goal of releaing sento to trick and overwhelm the opponent.");
                            Console.WriteLine("\n What would you like to learn about Kenshi? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Kenshi Key Moves:");
                                        Console.WriteLine("Blind Sided: 1,4,1");
                                        Console.WriteLine("Gut Check: 2,1");
                                        Console.WriteLine("Spirit Strike: B+2");
                                        Console.WriteLine("Slice N' Dice: F+2,2");
                                        Console.WriteLine("Face Breaker: 4");
                                        break;
                                    case 2:
                                        Console.WriteLine("Kenshi Special Moves");
                                        Console.WriteLine("Ancestral Guard: DF+1");
                                        Console.WriteLine("Demon Drop: DB+2");
                                        Console.WriteLine("Force Push: BF+4");
                                        Console.WriteLine("Rising Karma: BF+3");
                                        Console.WriteLine("Sento Stance: DB+1");
                                        Console.WriteLine("Soul Charge: BF+2");
                                        break;
                                    case 3:
                                        Console.WriteLine("Kenshi Combos");
                                        Console.WriteLine("1. 1,4,1 > DB+2B");
                                        Console.WriteLine("2. F+2,2 > BF+2");
                                        Console.WriteLine("3. 1,4,1 > BF+3 > J.1,2,2");
                                        Console.WriteLine("4. F+2,2 > BF+3 > F+2,2,F+2");
                                        Console.WriteLine("5. F+2,2 > BF+3 > DASH > F+2,2 > BF+2");
                                        Console.WriteLine("6. F+2,2 > BF+3 > DASH > 4 > BF+2");
                                        break;
                                    case 4:
                                        Console.WriteLine("Kenshi Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Sub-Zero,Frost,Cyrax,Jax,Mavado,Scorpion,Sareena");
                                        Console.WriteLine("-Intermediate: Darrius,Stryker,Sonya,Khameleon,Sektor,Kung Lao,Kano,Goro,Tremor,Madam Bo,Ferra,Janet Cage");
                                        Console.WriteLine("-Advanced: Shujinko,Motaro");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "NITARA":
                            Console.WriteLine("Difficulty: Advanced");
                            Console.WriteLine("Nitara is known for their air movement and combos.");
                            Console.WriteLine("\n What would you like to learn about Nitara? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Nitara Key Moves:");
                                        Console.WriteLine("Blood Strike: 2,2");
                                        Console.WriteLine("Never Grow Old: 1,2");
                                        Console.WriteLine("Never  Die: 1,2,1,2");
                                        Console.WriteLine("Broken Nails: F+1");
                                        Console.WriteLine("Lunging Leech: B+2");
                                        Console.WriteLine("Hex Kick: 3");
                                        Console.WriteLine("Bleeding Out: F+4");
                                        break;
                                    case 2:
                                        Console.WriteLine("Nitara Special Moves");
                                        Console.WriteLine("Dark Plunge: DB+4");
                                        Console.WriteLine("Air Dash Forward: J.F+Stance");
                                        Console.WriteLine("Bad Blood: BF+1");
                                        Console.WriteLine("Blood Sacrifice: DF+4");
                                        Console.WriteLine("Bloody Bolt (Requires Blood Sacrifice): BF+3");
                                        Console.WriteLine("Leap of Faith: DB+2");
                                        Console.WriteLine("Quick Taste: BF+2");
                                        break;
                                    case 3:
                                        Console.WriteLine("Nitara Combos");
                                        Console.WriteLine("1. 1,2,1,2 > BF+2");
                                        Console.WriteLine("2. B+2 > DB+4");
                                        Console.WriteLine("3. 1,2,1,2 > J.1,2,4 > DF+Stance > J.2,4,2 > BF+2");
                                        Console.WriteLine("4. 1,2,1,2 > J.2,4,2 > EXBF+2 > J.2,4,2 > BF+2");
                                        Console.WriteLine("5. 1,2,1,2 > J.2,4 > F+Stance > J.2,4,2 > EXBF+2 > J.2,4,2 > BF+2");
                                        Console.WriteLine("6. 1,2,1,2 > 4 > DB+2 > EXBF+2 > J.1,2,4 > DF+Stance > J.2,4,2 > BF+2");
                                        break;
                                    case 4:
                                        Console.WriteLine("Nitara Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Scorpion,Cyrax,Kung Lao,Sonya,Ferra,Darrius,Mavado,Jax");
                                        Console.WriteLine("-Intermediate: Sareena,Frost,Goro,Khameleon,Sub-Zero,Tremor,Madam Bo,Sektor,Stryker,Kano,Janet Cage");
                                        Console.WriteLine("-Advanced: Shujinko,Motaro");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "SHANG TSUNG":
                            Console.WriteLine("Difficulty: Advanced");
                            Console.WriteLine("Shang Tsung is known for their unique style of switching between young and old form along with \nbeing able to transform into other characters.");
                            Console.WriteLine("\n What would you like to learn about Shang Tsung? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Shang Tsung Key Moves:");
                                        Console.WriteLine("Die-Agnosis: 1,2");
                                        Console.WriteLine("Knee Reverser (Old Form): 2,4");
                                        Console.WriteLine("Lovetap: B+2,2");
                                        Console.WriteLine("Die-V (Young Form): F+4,3");
                                        break;
                                    case 2:
                                        Console.WriteLine("Shang Tsung Special Moves");
                                        Console.WriteLine("Form Stealer: FDB+4");
                                        Console.WriteLine("Quick Age Morph: D+Stance");
                                        Console.WriteLine("- Old Form ");
                                        Console.WriteLine(" - Ground Skull: DF+1");
                                        Console.WriteLine(" - Injection: DB+3");
                                        Console.WriteLine(" - Vicinity Slash: DF+2");
                                        Console.WriteLine("- Young Form");
                                        Console.WriteLine(" - Bed of Spikes: DB+3");
                                        Console.WriteLine(" - Double Skull: DB+1 ");
                                        Console.WriteLine(" - Spinning Spikes: DF+2");
                                        Console.WriteLine(" - Straight Skull: DF+1");
                                        Console.WriteLine(" - Triple Skull: DBF+1");
                                        break;
                                    case 3:
                                        Console.WriteLine("Shang Tsung Combos");
                                        Console.WriteLine("1. 2,4 > DB+1F (Young)");
                                        Console.WriteLine("2. B+1,2 > F+4,3 > DB+1F (Young)");
                                        Console.WriteLine("3. B+2,2 > DB+3 (Old)");
                                        Console.WriteLine("4. 1,2 > DB+1 (Old)");
                                        Console.WriteLine("5. B+1,2 > D+Stance > 4 > DF+1 > 4 > DF+1 > 2,4 > DB+3");
                                        Console.WriteLine("6. B+1,2 > D+Stance > 4 > DF+1 > 4 > DF+1 > F+4 > DF+1 > F+4 > DB+3");
                                        break;
                                    case 4:
                                        Console.WriteLine("Shang Tsung Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Kung Lao,Shujinko,Goro,Stryker,Scorpion,Mavado,Sektor,Motaro");
                                        Console.WriteLine("-Intermediate: Tremor,Sonya,Sareena,Madam Bo,Sub-Zero,Khameleon,Ferra,Kano,Jax");
                                        Console.WriteLine("-Advanced: Sonya,Frost,Cyrax,Darrius");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "RAIN":
                            Console.WriteLine("Difficulty: Advanced");
                            Console.WriteLine("Rain is known is defensive strategy and strong damage and water portal setups.");
                            Console.WriteLine("\n What would you like to learn about Rain? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Rain Key Moves:");
                                        Console.WriteLine("Beach Slap: 1,1");
                                        Console.WriteLine("When It Rains: 2,1,1");
                                        Console.WriteLine("Tide: B+2");
                                        Console.WriteLine("Undertow: F+2,1");
                                        Console.WriteLine("H2Blow: F+3");
                                        break;
                                    case 2:
                                        Console.WriteLine("Rain Special Moves");
                                        Console.WriteLine("Ancient Trap: BF+4");
                                        Console.WriteLine("Geyser: DB+3");
                                        Console.WriteLine("Rain God: DDU");
                                        Console.WriteLine("Upflow: DB+1");
                                        Console.WriteLine("Water Beam: BF+1");
                                        Console.WriteLine("Water Gate: DB+2");
                                        Console.WriteLine("Water Shield: FDB+4");
                                        break;
                                    case 3:
                                        Console.WriteLine("Rain Combos");
                                        Console.WriteLine("1. 1,1 > DB+1");
                                        Console.WriteLine("2. 1,1,4 > DB+3");
                                        Console.WriteLine("3. Hold 4 > 2,1,1 > DB+3");
                                        Console.WriteLine("4. F+3,2 > J.2,4,3 > DB+3");
                                        Console.WriteLine("5. F+3,2 > J.2,4,3 > DASH > F+2,1 > DB+3");
                                        Console.WriteLine("6. BF+4 > J.1 > J.2,4,3 > F+2 > DB+3F");
                                        break;
                                    case 4:
                                        Console.WriteLine("Rain Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Sonya,Janet Cage,Scorpion,Khameleon,Mavado,Ferra,Frost");
                                        Console.WriteLine("-Intermediate: Sub-Zero,Cyrax,Darrius,Sektor,Madam Bo,Stryker,Sareena,Kano,Jax,Kung Lao");
                                        Console.WriteLine("-Advanced: Shujinko,Motaro,Tremor,Goro");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "SINDEL":
                            Console.WriteLine("Difficulty: Advanced");
                            Console.WriteLine("Sindel is an all rounder where she can trick opponents with her mix-ups but also with flight combos.");
                            Console.WriteLine("\n What would you like to learn about Sindel? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Sindel Key Moves:");
                                        Console.WriteLine("Kiss The Ring: 1,1");
                                        Console.WriteLine("Shear Genius: F+1");
                                        Console.WriteLine("Turning Heel: 2,4");
                                        Console.WriteLine("Divine Decree: B+2,3");
                                        Console.WriteLine("Flippy Flip: F+4");
                                        break;
                                    case 2:
                                        Console.WriteLine("Sindel Special Moves");
                                        Console.WriteLine("Air Levitate: DB+2");
                                        Console.WriteLine("Hairball: DF+1");
                                        Console.WriteLine("Inspire: DB+3");
                                        Console.WriteLine("Kartwheel: DF+4");
                                        Console.WriteLine("Low Hairball: DB+1");
                                        Console.WriteLine("Queen's Command: DF+4");
                                        Console.WriteLine("Scream: BF+2");
                                        break;
                                    case 3:
                                        Console.WriteLine("Sindel Combos");
                                        Console.WriteLine("1. 1,1 > DF+1");
                                        Console.WriteLine("2. B+2,3 > DF+4");
                                        Console.WriteLine("3. 2,4 > BF+2");
                                        Console.WriteLine("4. B+2,3 > 2,4 > BF+2 > DASH > B+2,3 > DF+4");
                                        Console.WriteLine("5. 2,4 > BF+2 > DASH > F+4,3 > J.1,1,4 > DF+1");
                                        Console.WriteLine("6. 2,4 > BF+2 > DASH > F+4,3 > J.1,1,4 > DF+4");
                                        break;
                                    case 4:
                                        Console.WriteLine("Sindel Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Sub-Zero,Sonya,Sareena,Darrius,Ferra,Kung Lao,Mavado,Scorpion");
                                        Console.WriteLine("-Intermediate: Cyrax,Ferra,Frost,Goro,Jax,Khameleon,Stryker,Madam Bo,Sektor,Tremor");
                                        Console.WriteLine("-Advanced: Shujinko,Motaro,Janet Cage,Kano");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "ASHRAH":
                            Console.WriteLine("Difficulty: Advanced");
                            Console.WriteLine("Ashrah is known for their mid to far range attacks along with their light/dark stance.");
                            Console.WriteLine("\n What would you like to learn about Ashrah? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Ashrah Key Moves:");
                                        Console.WriteLine("Cleansed Soul: 1,2,2");
                                        Console.WriteLine("Kriss Kross: 2,2");
                                        Console.WriteLine("Sinner Stab: F+2");
                                        Console.WriteLine("Short Stab: B+3");
                                        Console.WriteLine("Soaring Demon: F+3");
                                        Console.WriteLine("Crown Cracker: F+4,2");
                                        Console.WriteLine("Playful Prickle: 2,1");
                                        break;
                                    case 2:
                                        Console.WriteLine("Ashrah Special Moves");
                                        Console.WriteLine("Astral Projection: BF+2");
                                        Console.WriteLine("Dark Ascension (Dark Stance): DF+3");
                                        Console.WriteLine("Demon's Wrath (Dark Stance): DB+2");
                                        Console.WriteLine("God's Wrath (Light Stance): DB+2");
                                        Console.WriteLine("Heaven's Beacon (Light Stance): DF+1");
                                        Console.WriteLine("Hell's Pillar (Dark Stance): DF+1");
                                        Console.WriteLine("Light Ascension (Light Stance): DF+3");
                                        Console.WriteLine("Switch Light/Dark Stance: DB+1");
                                        break;
                                    case 3:
                                        Console.WriteLine("Ashrah Combos");
                                        Console.WriteLine("1. 1,2,2 > BF+2");
                                        Console.WriteLine("2. 2,2 > DB+2");
                                        Console.WriteLine("3. F+4,2 > EXDF+3 > J.1,2,2 > BF+2");
                                        Console.WriteLine("4. F+4,2 > EXDF+3 > J.2 > F+2 > EXDF+3 > J.1,2,2 > BF+2");
                                        Console.WriteLine("5. 2,1 > DF+1 > F+2 > BF+2");
                                        Console.WriteLine("6. 2,1 > DF+1 > F+2 > EXDF+3 > J.1,2,2 > BF+2");
                                        break;
                                    case 4:
                                        Console.WriteLine("Ashrah Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Scorpion,Frost,Sub-Zero,Sonya,Sareena,Ferra,Goro,Janet Cage,Mavado");
                                        Console.WriteLine("-Intermediate: Cyrax,Kano,Khameleon,Kung Lao,Stryker,Madam Bo,Sektor,Tremor,Jax");
                                        Console.WriteLine("-Advanced: Shujinko,Motaro,Darrius");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "HOMELANDER":
                            Console.WriteLine("Difficulty: Advanced");
                            Console.WriteLine("Homelander is known for their zoning and air combat combos.");
                            Console.WriteLine("\n What would you like to learn about Homelander? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Homelander Key Moves:");
                                        Console.WriteLine("Smash Hit: 1,2");
                                        Console.WriteLine("Enforcing Order: B+1,4");
                                        Console.WriteLine("Breathtaker: F+1");
                                        Console.WriteLine("Take Your Breath Away: 2,1");
                                        Console.WriteLine("Brightest Day: B+2,2");
                                        break;
                                    case 2:
                                        Console.WriteLine("Homelander Special Moves");
                                        Console.WriteLine("Diabolical Dash: BF+2");
                                        Console.WriteLine("God Complex: J.DB+4");
                                        Console.WriteLine("Blast Off: DB+2");
                                        Console.WriteLine("Dirty Trick: DB+1");
                                        Console.WriteLine("Flight: U+Stance");
                                        Console.WriteLine("Laser Eyes: BF+1");
                                        Console.WriteLine("Low Laser Eyes: BF+3");
                                        Console.WriteLine("Sky Laser Eyes: DB+3");
                                        Console.WriteLine("Sweeping Laser Eyes: BDF+4");

                                        break;
                                    case 3:
                                        Console.WriteLine("Homelander Combos");
                                        Console.WriteLine("1. 1,2 > BF+1");
                                        Console.WriteLine("2. 1,2 > BF+3");
                                        Console.WriteLine("3. 2,1 > BF+2,1 > J.2,1,4");
                                        Console.WriteLine("4. 2,1 > BF+2,1 > J.2,1 > BF+2,1 > 2,1,2");
                                        Console.WriteLine("5. 2,1 > U+Stance > 4 > BF+2,1 > 4 > BF+2,1 > J.2,1,4");
                                        Console.WriteLine("6. 2,1 > U+Stance > BF+2,1 > B+2,2 > U+Stance > BF+2,1 > B+2,2 > BF+2,1 > J.2,1,4");
                                        break;
                                    case 4:
                                        Console.WriteLine("Homelander Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Cyrax,Ferra,Scorpion,Sub-Zero,Sareena,Janet Cage,Jax,Mavado");
                                        Console.WriteLine("-Intermediate: Darrius,Frost,Goro,Kano,Khameleon,Kung Lao,Stryker,Madam Bo,Tremor,Sektor,Sonya");
                                        Console.WriteLine("-Advanced: Shujinko,Motaro");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "QUAN CHI":
                            Console.WriteLine("Difficulty: Advanced");
                            Console.WriteLine("Quan Chi is known for their zoning ablities and setting up plans to trick opponents.");
                            Console.WriteLine("\n What would you like to learn about Quan Chi? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Quan Chi Key Moves:");
                                        Console.WriteLine("Dangerous Ally: 1,2");
                                        Console.WriteLine("Bow Already!: 2,1,4");
                                        Console.WriteLine("Nether Eruption: B+2");
                                        Console.WriteLine("Table Test: B+3,4");
                                        Console.WriteLine("Alternative Acrobatics: F+4");
                                        Console.WriteLine("Skewer Strike: 1,3");
                                        break;
                                    case 2:
                                        Console.WriteLine("Quan Chi Special Moves");
                                        Console.WriteLine("Falling Death: BF+4");
                                        Console.WriteLine("Head Rush: BF+1");
                                        Console.WriteLine("Field of Bones: BDF+2");
                                        Console.WriteLine("From The Fog: DB+4");
                                        Console.WriteLine("Psycho Skull: DB+1");
                                        Console.WriteLine("Zone of Power: DB+3");
                                        Console.WriteLine("Zone of Waste: DF+3");
                                        break;
                                    case 3:
                                        Console.WriteLine("Quan Chi Combos");
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        break;
                                    case 4:
                                        Console.WriteLine("Quan Chi Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("1. 1,2 > BF+1");
                                        Console.WriteLine("2. 2,1,4 > DB+4");
                                        Console.WriteLine("3. B+3,4 > BF+4");
                                        Console.WriteLine("4. 1,3 > J.2,1 > 2,1,4,4");
                                        Console.WriteLine("5. 1,3 > 3 > J.2,1 > F+2,1");
                                        Console.WriteLine("6. 3, J.2,1 > 1,3 > DASH > F+2,1");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "NOOB-SAIBOT":
                            Console.WriteLine("Difficulty: Advanced");
                            Console.WriteLine("Noob-Saibot is known for their unique playstyle with managing his shadow and setups.");
                            Console.WriteLine("\n What would you like to learn about Noob-Saibot? \n1. Key Moves \n2.Special Moves \n3.Combos \n4.Kameos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out mk1_option))
                            {
                                switch (mk1_option)
                                {
                                    case 1:
                                        Console.WriteLine("Noob-Saibot Key Moves:");
                                        Console.WriteLine("Shadow Upper: 1,2,1");
                                        Console.WriteLine("Shadow Strike: F+1,2");
                                        Console.WriteLine("Abyssal Hook: F+1,3");
                                        Console.WriteLine("Night Rain: 2,1,2");
                                        Console.WriteLine("Gravedigger: B+3,3");
                                        Console.WriteLine("Black Mace: 4,4");
                                        break;
                                    case 2:
                                        Console.WriteLine("Noob-Saibot Special Moves");
                                        Console.WriteLine("Shadow Dive/Dive Kick: DB+4");
                                        Console.WriteLine("Shadow Kick: BF+4");
                                        Console.WriteLine("Shadown Plunge: DD+4");
                                        Console.WriteLine("Tele-Slam: DU");
                                        Console.WriteLine("Embrace Khaos: FDB+1");
                                        Console.WriteLine("Shadow Ghostball: DF+1");
                                        Console.WriteLine("Exorcism: DF+1");
                                        Console.WriteLine("Netherrealm Portal: DB+2");
                                        Console.WriteLine("Netherrealm Summons: BF+2");
                                        Console.WriteLine("Shadow Slide/Saibot Slide: BF+4");
                                        Console.WriteLine("Shadow Slicer: DB+3");
                                        Console.WriteLine("Shadow Sweep: DB+4");
                                        Console.WriteLine("Shadow Tackle: BF+3");
                                        break;
                                    case 3:
                                        Console.WriteLine("Noob-Saibot Combos");
                                        Console.WriteLine("1. 1,2,1 > BF+4");
                                        Console.WriteLine("2. F+1,2 > DB+3");
                                        Console.WriteLine("3. 2,1,2 > BF+3");
                                        Console.WriteLine("4. 2,1,2 > BF+3 > 2,1 > DU");
                                        Console.WriteLine("5. 2,1,2 > BF+3 > 2,1 > EXDU > J.2,3,4 > B+4");
                                        Console.WriteLine("6. 2,1,2 > EXBF+3 > J.2,3,4 > EXDU > J.1,2,4,4 > EXDU > J.2,3,4 > DU");
                                        break;
                                    case 4:
                                        Console.WriteLine("Noob-Saibot Kameos based off easiest to advanced for combos/strategy");
                                        Console.WriteLine("-Easy: Janet Cage,Scorpion,Mavado,Sub-Zero,Sonya");
                                        Console.WriteLine("-Intermediate: Shujinko,Sektor,Kung Lao,Stryker,Darrius,Sareena,Jax,Khameleon");
                                        Console.WriteLine("-Advanced: Motato,Ferra,Cyrax,Frost,Goro,Tremor");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                    }
                    break;
                }
            }
        }
    }
}

