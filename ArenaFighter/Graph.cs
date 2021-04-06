using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArenaFighter
{
    class Graph
    {

        public void FirstMenu()
        {
            GetSetName();
        
            WriteAt("Avsluta            [ 0 ]", 47, 4);

            WriteAt("Starta nytt spel   [ 1 ]", 47, 6);
            WriteAt("Läsa   spel logg   [ 2 ]  På skärmen.", 47, 7);
            WriteAt("Spara  spel logg   [ 3 ]  Som fil.", 47, 8);

            WriteAt("Vad väljer du ->   [ ? ]", 47, 10);
            WriteAt("Vad väljer du ->   [ ", 47, 10);           // Cheat code to place cursor.
        }

        public void GetSetName()
        {
            int line = 1;
            WriteAt( "                                _____________                                   ", 20, line++);
            WriteAt(@" ______________________________/ARENA FIGHTER\_________________________________ ", 20, line++);
            WriteAt( "|                                                                              |", 20, line++);
            WriteAt( "|                                                                              |", 20, line++);
            WriteAt( "|                                                                              |", 20, line++);
            WriteAt( "|                                                                              |", 20, line++);
            WriteAt( "|                                                                              |", 20, line++);
            WriteAt( "|                                                                              |", 20, line++);
            WriteAt( "|                                                                              |", 20, line++);
            WriteAt( "|                                                                              |", 20, line++);
            WriteAt( "|______________________________________________________________________________|", 20, line++);
            WriteAt( "|                                                                              |", 20, line++);
            WriteAt( "|                                                                              |", 20, line++);
            WriteAt( "|______________________________________________________________________________|", 20, line++);
        }

        public void LogMenu()
        {
            int line = 1;
               WriteAt( "         'U' eller PageUp = Upp              ________             'N' eller PageDown = Ned               ", 7, line++);
               WriteAt(@" ___________________________________________/GAME LOG\___________________________________________________", 7, line++);

            for (; line < 42;)
            {
               WriteAt( "|                                                                                                        |", 7, line++);
            }

               WriteAt( "|________________________________________________________________________________________________________|", 7, line++);
               WriteAt( "                                       Tryc ESC för att avsluta                                           ", 7, line++);
        }




        public void NewGameArena() 
        {
            int line = 7;
            WriteAt("╔╗╔╔═╗╦ ╦  ╔═╗╔═╗╔╦╗╔═╗", 48, line++);
            WriteAt("║║║║╣ ║║║  ║ ╦╠═╣║║║║╣ ", 48, line++);
            WriteAt("╝╚╝╚═╝╚╩╝  ╚═╝╩ ╩╩ ╩╚═╝", 48, line++);

        }
        public void ArenaLogo()
        {
            ConsoleColor tmp = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            int line = 2;
            WriteAt("╔════════════════════════════════════════════════════════════════════════════════════════════════╗", 12, line++);
            WriteAt("║░█████╗░██████╗░███████╗███╗░░██╗░█████╗░  ███████╗██╗░██████╗░██╗░░██╗████████╗███████╗██████╗░║", 12, line++);
            WriteAt("║██╔══██╗██╔══██╗██╔════╝████╗░██║██╔══██╗  ██╔════╝██║██╔════╝░██║░░██║╚══██╔══╝██╔════╝██╔══██╗║", 12, line++);
            WriteAt("║███████║██████╔╝█████╗░░██╔██╗██║███████║  █████╗░░██║██║░░██╗░███████║░░░██║░░░█████╗░░██████╔╝║", 12, line++);
            WriteAt("║██╔══██║██╔══██╗██╔══╝░░██║╚████║██╔══██║  ██╔══╝░░██║██║░░╚██╗██╔══██║░░░██║░░░██╔══╝░░██╔══██╗║", 12, line++);
            WriteAt("║██║░░██║██║░░██║███████╗██║░╚███║██║░░██║  ██║░░░░░██║╚██████╔╝██║░░██║░░░██║░░░███████╗██║░░██║║", 12, line++);
            WriteAt("║╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝╚═╝░░╚══╝╚═╝░░╚═╝  ╚═╝░░░░░╚═╝░╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝║", 12, line++);
            WriteAt("╚════════════════════════════════════════════════════════════════════════════════════════════════╝", 12, line++);
            Console.BackgroundColor = tmp;
        }                 

        public void ClearLogo()
        {
            int line = 2;
            WriteAt("                                                                                                    ", 12, line++);
            WriteAt("                                                                                                    ", 12, line++);
            WriteAt("                                                                                                    ", 12, line++);
            WriteAt("                                                                                                    ", 12, line++);
            WriteAt("                                                                                                    ", 12, line++);
            WriteAt("                                                                                                    ", 12, line++);
            WriteAt("                                                                                                    ", 12, line++);
            WriteAt("                                                                                                    ", 12, line++);
        }

        public void PrepareNewGame()
        {
            int line = 2;
            WriteAt( "                                                                                                    ", 12, line++);
            WriteAt( "                              --<( Press ENTER to start a NEW GAME )>--                             ", 12, line++);
            WriteAt( "                      _   __ ______ _       __   ______ ___     __  ___ ______                      ", 12, line++);
            WriteAt( "                     / | / // ____/| |     / /  / ____//   |   /  |/  // ____/                      ", 12, line++);
            WriteAt( "                    /  |/ // __/   | | /| / /  / / __ / /| |  / /|_/ // __/                         ", 12, line++);
            WriteAt( "                   / /|  // /___   | |/ |/ /  / /_/ // ___ | / /  / // /___                         ", 12, line++);
            WriteAt(@"                  /_/ |_//_____/   |__/|__/   \____//_/  |_|/_/  /_//_____/                         ", 12, line++);
            WriteAt( "                                                                                                    ", 12, line++);


        }

        public void YouWin()
        {
            ClearLogo();
            ConsoleColor tmp = Console.ForegroundColor;
            int wait = 250;
            for (int i=0; i <= 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Winner();
                Thread.Sleep(wait);
                Console.ForegroundColor = ConsoleColor.Green;
                Winner();
                Thread.Sleep(wait);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Winner();
            Thread.Sleep(1000);
            Console.ForegroundColor = tmp;

        }
        public void Winner()
        {          
            int line = 2; 

            WriteAt( " /$$     /$$ /$$$$$$  /$$   /$$       /$$      /$$ /$$$$$$ /$$   /$$       /$$ ",  25, line++);
            WriteAt(@"|  $$   /$$//$$__  $$| $$  | $$      | $$  /$ | $$|_  $$_/| $$$ | $$      | $$ ",  25, line++);
            WriteAt(@" \  $$ /$$/| $$  \ $$| $$  | $$      | $$ /$$$| $$  | $$  | $$$$| $$      | $$ ",  25, line++);
            WriteAt(@"  \  $$$$/ | $$  | $$| $$  | $$      | $$/$$ $$ $$  | $$  | $$ $$ $$      | $$ ",  25, line++);
            WriteAt(@"   \  $$/  | $$  | $$| $$  | $$      | $$$$_  $$$$  | $$  | $$  $$$$      |__/ ",  25, line++);
            WriteAt(@"    | $$   | $$  | $$| $$  | $$      | $$$/ \  $$$  | $$  | $$\  $$$           ",  25, line++);
            WriteAt(@"    | $$   |  $$$$$$/|  $$$$$$/      | $$/   \  $$ /$$$$$$| $$ \  $$       /$$ ",  25, line++);
            WriteAt(@"    |__/    \______/  \______/       |__/     \__/|______/|__/  \__/      |__/ ",  25, line++);

        }
        public void YouLost()
        {
            ClearLogo();
            ConsoleColor tmp = Console.ForegroundColor;
            int wait = 250;
            for (int i = 0; i <= 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Looooser();
                Thread.Sleep(wait);
                Console.ForegroundColor = ConsoleColor.Red;
                Looooser();
                Thread.Sleep(wait);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Looooser();
            Thread.Sleep(1000);
            Console.ForegroundColor = tmp;
        }
        public void Looooser()
        {    
            int line = 2; 

            WriteAt(@" /$$     /$$ /$$$$$$  /$$   /$$       /$$        /$$$$$$   /$$$$$$  /$$$$$$$$ ", 25, line++);
            WriteAt(@"|  $$   /$$//$$__  $$| $$  | $$      | $$       /$$__  $$ /$$__  $$|__  $$__/ ", 25, line++);
            WriteAt(@" \  $$ /$$/| $$  \ $$| $$  | $$      | $$      | $$  \ $$| $$  \__/   | $$    ", 25, line++);
            WriteAt(@"  \  $$$$/ | $$  | $$| $$  | $$      | $$      | $$  | $$|  $$$$$$    | $$    ", 25, line++);
            WriteAt(@"   \  $$/  | $$  | $$| $$  | $$      | $$      | $$  | $$ \____  $$   | $$    ", 25, line++);
            WriteAt(@"    | $$   | $$  | $$| $$  | $$      | $$      | $$  | $$ /$$  \ $$   | $$    ", 25, line++);
            WriteAt(@"    | $$   |  $$$$$$/|  $$$$$$/      | $$$$$$$$|  $$$$$$/|  $$$$$$/   | $$    ", 25, line++);
            WriteAt(@"    |__/    \______/  \______/       |________/ \______/  \______/    |__/    ", 25, line++);
        }

        public void ShowDice(int Dice, int line)
        {
            int row = 95;
            switch (Dice)
            {

                case 1:
                    {
                        WriteAt("╔═════════╗", row, line++);
                        WriteAt("║         ║", row, line++);
                        WriteAt("║    ■    ║", row, line++);
                        WriteAt("║         ║", row, line++);
                        WriteAt("╚═════════╝", row, line++);
                        break;
                    }

                case 2:
                    {
                        WriteAt("╔═════════╗", row, line++);
                        WriteAt("║       ■ ║", row, line++);
                        WriteAt("║         ║", row, line++);
                        WriteAt("║ ■       ║", row, line++);
                        WriteAt("╚═════════╝", row, line++);

                        break;
                    }
                case 3:
                    {
                        WriteAt("╔═════════╗", row, line++);
                        WriteAt("║       ■ ║", row, line++);
                        WriteAt("║    ■    ║", row, line++);
                        WriteAt("║ ■       ║", row, line++);
                        WriteAt("╚═════════╝", row, line++);

                        break;
                    }
                case 4:
                    {
                        WriteAt("╔═════════╗", row, line++);
                        WriteAt("║ ■     ■ ║", row, line++);
                        WriteAt("║         ║", row, line++);
                        WriteAt("║ ■     ■ ║", row, line++);
                        WriteAt("╚═════════╝", row, line++);

                        break;
                    }
                case 5:
                    {
                        WriteAt("╔═════════╗", row, line++);
                        WriteAt("║ ■     ■ ║", row, line++);
                        WriteAt("║    ■    ║", row, line++);
                        WriteAt("║ ■     ■ ║", row, line++);
                        WriteAt("╚═════════╝", row, line++);

                        break;
                    }
                case 6:
                    {
                        WriteAt("╔═════════╗", row, line++);
                        WriteAt("║ ■     ■ ║", row, line++);
                        WriteAt("║ ■     ■ ║", row, line++);
                        WriteAt("║ ■     ■ ║", row, line++);
                        WriteAt("╚═════════╝", row, line++);

                        break;
                    }
            }
        }


        public void DiceLogo()
        {
            // return;
            for (int i = 2; i < 72; i++)
            {

                WriteAt( "                (( _______        ", i, 11);
                WriteAt(@"      _______     /\O    O\       ", i, 12);
                WriteAt(@"     /O     /\   /  \      \      ", i, 13);
                WriteAt(@"    /   O  /O \ / O  \O____O\ ))  ", i, 14);
                WriteAt(@" ((/_____O/    \\    /O     /     ", i, 15);
                WriteAt(@"   \O    O\    / \  /   O  /      ", i, 16);
                WriteAt(@"    \O    O\ O/   \/_____O/       ", i, 17);
                WriteAt(@"     \O____O\/ ))          ))     ", i, 18);
                WriteAt( "   ((                             ", i, 19);

                Thread.Sleep(i/2);
            }
        }


        int ArenaFrameFirstLine = 21;
        public void QuitGameQuestion()
        {
            int line = ArenaFrameFirstLine;
            WriteAt("   Vill du verkligen avsluta spelet?    Ja / Nej [?]                   ", 12, line);
            Console.SetCursorPosition(62, line);
            Console.CursorVisible = true;
        }

        public void ClearGameInfoLine()
        {
            int line = ArenaFrameFirstLine;
            WriteAt("                                                                                                  ", 12, line);

        }

        public void ArenaFrame()
        {
            int line = ArenaFrameFirstLine;
            //           12      20        3         4         5         6         7         8         9         100     
            //           234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890
                WriteAt("   Enter utför    [ K ] utan tärnings grafik.                                                     ", 12, line++);
                WriteAt("╔════════════════════════════════════════════════════════════════════════════════════════════════╗", 12, line++);
            for ( ; line < 42;)
            {
                WriteAt("║                                                                                                ║", 12, line++);
            }
                WriteAt("╚════════════════════════════════════════════════════════════════════════════════════════════════╝", 12, line++);     
                WriteAt("                            Tryck Esc om du ger upp eller vill sluta.                             ", 12, line++);
        }       //WriteAt("Du och din rival tävlar med tärningkast. Vinner du tar du styrka från                       ", 15, line++);


        public void ShowHelpText()
        {
            ArenaFrame();   // Clean frame.
            int line = ArenaFrameFirstLine + 2;
            
            WriteAt("                                       Hjälp.                                               ", 15, line++);
            WriteAt("Spelets regler:                                                                             ", 15, line++);
            WriteAt("Du och din motståndare tävlar med tärningkast. Vinner du tar du styrka från din motståndare.", 15, line++);
            WriteAt("Ex. Du slår 5 och din motståndare 3. Du tar då 2 styrkor från din motståndare och tvärt om. ", 15, line++);
            WriteAt("                                                                                            ", 15, line++);
            WriteAt("Du vinner spelet när du tagit allt av motståndarens styrka.                                 ", 15, line++);
            WriteAt("Du belönas med 10 prispengar samt alla motståndarens pengar och Tur (om något är kvar).     ", 15, line++);
            WriteAt("                                                                                            ", 15, line++);
            WriteAt("Styrka:  Om nivån är låg kan du köpa styrka med pengar.                                     ", 15, line++);
            WriteAt("En styrka kostar en peng. Se till att hålla dig över 5 så du inte förlorar med 1 mot 6.     ", 15, line++);
            WriteAt("                                                                                            ", 15, line++);
            WriteAt("Tur:  Om du ligger pyrt till kan du använda tur. Du anger hur många du vill använda och     ", 15, line++);
            WriteAt("får då det antal extra tärningskast. Det tärningskast som är högst sparas.                  ", 15, line++);
            WriteAt("Inte bara det...  Så fort du får en 6a sparas resterande turslag. Då har du extra tur ;)    ", 15, line++);
            WriteAt("                                                                                            ", 15, line++);
            WriteAt("                         Tryck Enter för att återgå till Arenan.                            ", 15, line++);

        }

        public void PlayerStat(Avatar Player,int OwerUnder)
        {
            int Line = ArenaFrameFirstLine + 3 + OwerUnder * 10;      // Set line.  Me = 0 , Opponent = 1
            WriteAt(Player.UserName, 15, Line++);
            WriteAt("", 15, Line++);
            WriteAt("                                                                       ", 15, Line);
            WriteAt("Styrka  " + FormatNumber(Player.Strengt), 15, Line); ShowBar(Player.Strengt, Line++);
            WriteAt("                                                                       ", 15, Line);
            WriteAt("Tur     " + FormatNumber(Player.Luck), 15, Line);    ShowBar(Player.Luck   , Line++);
            WriteAt("                                                                       ", 15, Line);
            WriteAt("Pengar  " + FormatNumber(Player.Cash), 15, Line);    ShowBar(Player.Cash   , Line++);

        }

        public void DiceResult(Avatar Player)
        {

            int line = ArenaFrameFirstLine + 3 + Player.PlayerNumber * 10;
            WriteAt(Player.UserName + "  slog  " , 75, line); WriteAt(Player.Dice.ToString(),100, line++);
            ShowDice(Player.Dice, line + 1);
        }
        public void ShowBar(int p, int l)
        {
            ConsoleColor tmp = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.DarkRed;

            for (int i = 0; i <= p; i++)
            {
                if (i < 2)      Console.BackgroundColor = ConsoleColor.DarkRed;
                else if (i < 6) Console.BackgroundColor = ConsoleColor.DarkYellow;
                else            Console.BackgroundColor = ConsoleColor.DarkGreen;

                WriteAt("░", 30 + i, l);
                if (i > 50)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    WriteAt("░░<- ", 30 + i + 1, l);
                    Console.BackgroundColor = tmp;
                    WriteAt("      ", 30 + i + 5, l);
                    return;
                }
            }
            Console.BackgroundColor = tmp;
        }


        public void PlaceCursor()
        {
            WriteAt("Gör ditt val   [ ? ]", 15, 13);
            WriteAt(" ", 31, 13);
        }

        public void UserSelectOptions()
        {
            WriteAt("Gör ditt val   [ ? ]", 15, 13);
            WriteAt("Kasta tärning  [ K ]", 15, 15);
            WriteAt("Köpa   styrka  [ S ]", 15, 16);
            WriteAt(" Jag har Tur   [ T ]", 15, 17);
            WriteAt(" Visa  hjälp   [ H ]", 15, 19);
        }

        public string FormatNumber(int x)
        {

            string s = x.ToString();
            if (s.Length < 2) return "  " + s;
            if (s.Length < 3) return " " + s;
            return s;

        }

        public void WriteAt(string s, int x, int y)
        {
                Console.SetCursorPosition( x, y);
                Console.Write(s);
        }
    }
}
