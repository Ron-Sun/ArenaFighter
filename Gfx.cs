using System;

namespace ArenaFighter
{



public class Gfx
{
	public Gfx()
	{
        static void ArenaLogo()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            WriteAt("╔════════════════════════════════════════════════════════════════════════════════════════════════╗", 12, 2);
            WriteAt("║░█████╗░██████╗░███████╗███╗░░██╗░█████╗░  ███████╗██╗░██████╗░██╗░░██╗████████╗███████╗██████╗░║", 12, 3);
            WriteAt("║██╔══██╗██╔══██╗██╔════╝████╗░██║██╔══██╗  ██╔════╝██║██╔════╝░██║░░██║╚══██╔══╝██╔════╝██╔══██╗║", 12, 4);
            WriteAt("║███████║██████╔╝█████╗░░██╔██╗██║███████║  █████╗░░██║██║░░██╗░███████║░░░██║░░░█████╗░░██████╔╝║", 12, 5);
            WriteAt("║██╔══██║██╔══██╗██╔══╝░░██║╚████║██╔══██║  ██╔══╝░░██║██║░░╚██╗██╔══██║░░░██║░░░██╔══╝░░██╔══██╗║", 12, 6);
            WriteAt("║██║░░██║██║░░██║███████╗██║░╚███║██║░░██║  ██║░░░░░██║╚██████╔╝██║░░██║░░░██║░░░███████╗██║░░██║║", 12, 7);
            WriteAt("║╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝╚═╝░░╚══╝╚═╝░░╚═╝  ╚═╝░░░░░╚═╝░╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝║", 12, 8);
            WriteAt("╚════════════════════════════════════════════════════════════════════════════════════════════════╝", 12, 9);
            Console.BackgroundColor = ConsoleColor.Black;
        }

        static void DiceLogo()
        {

            //Console.WriteLine("                                                       (( _______");
            //Console.WriteLine("                                             _______     /\\O    O\\");
            //Console.WriteLine("                                            /O     /\\   /  \\      \\");
            //Console.WriteLine("                                           /   O  /O \\ / O  \\O____O\\ ))");
            //Console.WriteLine("                                        ((/_____O/    \\\\    /O     /");
            //Console.WriteLine("                                          \\O    O\\    / \\  /   O  /");
            //Console.WriteLine("                                           \\O    O\\ O/   \\/_____O/");
            //Console.WriteLine("                                            \\O____O\\/ ))          ))");
            //Console.WriteLine("                                          ((");


            for (int i = 2; i < 42; i++)
            {

                WriteAt("                (( _______          ", i, 11);
                WriteAt("      _______     /\\O    O\\       ", i, 12);
                WriteAt("     /O     /\\   /  \\      \\     ", i, 13);
                WriteAt("    /   O  /O \\ / O  \\O____O\\ )) ", i, 14);
                WriteAt(" ((/_____O/    \\\\    /O     /     ", i, 15);
                WriteAt("   \\O    O\\    / \\  /   O  /     ", i, 16);
                WriteAt("    \\O    O\\ O/   \\/_____O/      ", i, 17);
                WriteAt("     \\O____O\\/ ))          ))     ", i, 18);
                WriteAt("   ((                               ", i, 19);
                Thread.Sleep(i);
            }
        }

        static void ArenaFrame()
        {
            WriteAt("╔══════════════════════════════════════════════════════════════════════════════════════════════╗", 12, 22);
            WriteAt("║                                                                                              ║", 12, 23);
            WriteAt("║                                                                                              ║", 12, 24);
            WriteAt("║                                                                                              ║", 12, 25);
            WriteAt("║                                                                                              ║", 12, 26);
            WriteAt("║                                                                                              ║", 12, 27);
            WriteAt("║                                                                                              ║", 12, 28);
            WriteAt("║                                                                                              ║", 12, 29);
            WriteAt("║                                                                                              ║", 12, 30);
            WriteAt("║                                                                                              ║", 12, 31);
            WriteAt("║                                                                                              ║", 12, 32);
            WriteAt("╚══════════════════════════════════════════════════════════════════════════════════════════════╝", 12, 33);
            WriteAt("                               Hit Esc to give up or exit game.                                 ", 12, 34);
        }
        //static void XvsYLogo()                                                                                   
        //{                                                                                                        
        //    Console.WriteLine("                                                （ ^_^）  Vs  （^_^ ）");
        //    Console.WriteLine();
        //    Console.WriteLine("                                                " + MyAvatar.UserName + "      " + Opponent.UserName);
        //    Console.WriteLine();
        //}


    }
}
}
