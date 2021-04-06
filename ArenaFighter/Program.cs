using System;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Text;

namespace ArenaFighter
{
    class Program
    {
        static Logger Log = new Logger();
        static Avatar MyAvatar = new Avatar(); 
        static Avatar Opponent = new Avatar();
        static Graph Gr = new Graph();

        static bool GameEnd = false;
        static int Round;
        static int Game;
        static string log = "";

        static void Main(string[] args)
        {
            ArenaFighterBegin();
        }

        static void ArenaFighterBegin()
        {
            bool playgame = true;
            do
            {
                SetupGame();
                StartNewGame();
                playgame =  FirstMenu();  
                
            } while (playgame);   
            
        }

        static bool FirstMenu()
        {
            char key;
            do
            {
                Console.Clear();
                Gr.FirstMenu();
                key = Console.ReadKey().KeyChar;
                key = char.ToUpper(key);

                switch (key)
                {
                    case '0':
                        {
                            WriteAt("Bye bye... Ha en bra dag.", 47, 13);
                            Thread.Sleep(2000);
                            return false;
                        }

                    case '1':
                        {
                            return true;
                        }

                    case '2':
                        {
                            ShowLog();
                            break;
                        }

                    case '3':
                        {
                            SaveLog();
                            break;
                        }

                    case '9':        // Cheat code... Load a pre saved log..
                        {
                            LoadLog();
                            break;
                        }
                }
            } while (true);     
        }

        static void ShowLog()
        {
            int logindex = 0;
          
            Gr.LogMenu();
            Log.LogString();
        
            logindex = 0;
            logindex = Log.ShowLogOnScreen(logindex, 0);

            do
            {
                var key = Console.ReadKey(); //.KeyChar;
                //key = char.ToUpper(key);

                switch (key.Key)
                {
                    case (ConsoleKey)'U':         // This is how "or" is done :o
                    case (ConsoleKey)'u':
                        {
                            logindex = Log.ShowLogOnScreen(logindex, 1);
                            break;
                        }

                    case (ConsoleKey)'N': 
                    case (ConsoleKey)'n':
                        {
                            logindex = Log.ShowLogOnScreen(logindex, 0);
                            break;
                        }

                    case ConsoleKey.PageUp:
                        {
                            logindex = Log.ShowLogOnScreen(logindex, 1);
                            break;
                        }

                    case ConsoleKey.PageDown:
                        {
                            logindex = Log.ShowLogOnScreen(logindex, 0);
                            break;
                        }

                    case ConsoleKey.Escape:
                        {
                            return;
                        }
                }
            } while (true);         
        }

        static void SaveLog()
        {
            string GameTime = DateTime.Now.ToString();
            GameTime = GameTime.Replace(':', '-');
            System.IO.File.WriteAllText(@".\GameLog" + GameTime + ".txt", Log.LogData.ToString());
            WriteAt("Fil GameLog" + GameTime + ".txt är sparad.", 47, 13);
            Thread.Sleep(3000);
            return;
        }

        static void LoadLog()
        {
            Log.LogData.Append(System.IO.File.ReadAllText(@".\GameLog.txt"));  //, Log.LogData.ToString()); ; ;
            WriteAt("Fil GameLog är Läst.", 47, 13);
            Thread.Sleep(1000);
            return;
        }


        static void SetupGame()                     // Only once.
        {
            ResetGame();
        }


        static void ResetGame()                     // Every new game
        {
            MyAvatar.PlayerNumber = 0;
            Opponent.PlayerNumber = 1;

            Console.Clear();
            Console.SetWindowSize(120, 60);
            Round = 0;
            Game = 0;
        }


        static void StartNewGame()          // Arena 
        {
            Gr.GetSetName();
            Console.CursorVisible = true;

            if (MyAvatar.UserName == "")
            {
                WriteAt("Vad är ditt namn? ", 45, 4);
                MyAvatar.UserName = Console.ReadLine();  
            }

            do      // Arena loop
            {
                Game++;
                Round = 0;
                Console.Clear();
                Console.CursorVisible = false;
                log = "---< Nytt Arenaspel startar >---. Spel Nr: " + Game + '\n';
                if (MyAvatar.Strengt <= 0) MyAvatar.RandomAbility();    // If New game or return from loosing battle...

                Opponent.RandomName();
                Opponent.RandomAbility();
               
                ConsoleColor tmp = Console.BackgroundColor;
                WriteAt("                                                    ", 40, 4);
                Gr.GetSetName();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                WriteAt("-{ " + MyAvatar.UserName + " möter " + Opponent.UserName + " }-", 42, 4);

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                WriteAt(MyAvatar.UserName, 25, 5);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                WriteAt(Opponent.UserName, 83, 5);
                Console.BackgroundColor = tmp;

                WriteAt("Styrka:   = " + MyAvatar.Strengt, 25, 7);
                WriteAt("Tur:      = " + MyAvatar.Luck, 25, 8);
                WriteAt("Pengar:   = " + MyAvatar.Cash, 25, 9);

                WriteAt("Styrka:   = " + Opponent.Strengt, 83, 7);
                WriteAt("Tur:      = " + Opponent.Luck, 83, 8);
                WriteAt("Pengar:   = " + Opponent.Cash, 83, 9);

                Gr.NewGameArena();

                WriteAt("Tryck enter för att börja matchen.", 45, 13);
                Console.ReadKey();

                if (!PlayRound()) return;   // User Quit or lost.
            } while (true);
        }

        
        static bool PlayRound()
        {
            DisplayLogo();         
           
            GameEnd = false;

            char key;

            do          // Rounds
            {
                DisplayAndSaveLog();
                PlayerStatistic();

                key = Console.ReadKey().KeyChar;
                key = char.ToUpper(key);

                Console.CursorVisible = true;

                switch (key)
                {
                    case '\u000D':              //  Lazy dice trow on Enter.
                        {
                            ThrowDice(-99);
                            Round++;
                            break;
                        }

                    case 'K':                   // Trow dice.
                        {
                            ThrowDice(0);
                            Round++;
                            break;
                        }
                    case 'S':
                        {
                            BuyStrenght();
                            break;
                        }
                    case 'H':
                        {
                            ShowHelpText();
                            break;
                        }

                    case 'T':
                        {
                            TrowLuckyDize();
                            Round++;
                            break;
                        }

                    case '+':   // Cheat code... I Win.
                        {
                            Opponent.Strengt = -100;
                            ThrowDice(0);
                            break;
                        }

                    case '-':   // Cheat code... I Lose.
                        {
                            MyAvatar.Strengt = -100;
                            ThrowDice(0);
                            break;
                        }

                    case '\u001B':
                        {
                            if (StayInGame()) break;        // Stay
                            else return false;              // Quit
                        }
                }

                if (GameEnd)
                {
                    return true;        // Game end,  Win / Loss.
                }

            } while (true); 
          
        }

        static bool StayInGame()
        {

            Gr.QuitGameQuestion();          
            char key;
            key = Console.ReadKey().KeyChar;
            key = char.ToUpper(key);
            if (key == 'J') return false;       // Quit
            Gr.ClearGameInfoLine();
            return true;
        }

        static void PlayerStatistic()
        {
            Gr.PlayerStat(MyAvatar, 0);
            Gr.PlayerStat(Opponent, 1);
            Gr.PlaceCursor();
        }

        static void ShowHelpText()
        {
            Gr.ShowHelpText();
            Console.ReadKey();
            Gr.ArenaFrame();
        }

        static void BuyStrenght()
        {
            if (MyAvatar.Cash < 1)
            {
                WriteAt("Tyvärr har du inget kvar, kontot är tomt.", 15, 21);
                Thread.Sleep(2000);
                return;
            }
            Console.CursorVisible = true;
            WriteAt("Du har " + MyAvatar.Cash  + " pengar kvar. hur mycket vill du använda ? ", 15, 21);
            int cash = ConvertToInt(Console.ReadLine());
            if (cash == 0) return;

            Thread.Sleep(500);
            WriteAt("                                                                            ", 15, 21);
            if (cash > MyAvatar.Cash ) WriteAt("Du har bara " + MyAvatar.Cash  + " pengar kvar. Använder allt.", 15, 21);
            MyAvatar.BuyStrengt(cash);
        }

        static void TrowLuckyDize()
        {
            if (MyAvatar.Luck < 1)
            {
                WriteAt("Tyvärr har du ingen tur kvar. Turkontot är tomt.", 15, 21);
                Thread.Sleep(2000);
                return;
            }
            Console.CursorVisible = true;
            WriteAt("Du har " + MyAvatar.Luck + " tur kvar. hur mycket vill du använda ? ", 15, 21);
            int luck = ConvertToInt(Console.ReadLine());
            if (luck == 0) return;
         
            WriteAt("                                                                            ", 15, 21);
            if (luck > MyAvatar.Luck) WriteAt("Du har bara " + MyAvatar.Luck + " tur kvar. Använder allt.", 15, 21);
            Thread.Sleep(500);
            ThrowDice(luck); 
        }

        static void ThrowDice(int LuckyDize)
        {   
            if (LuckyDize == -99)       // -99  User hit Enter. No dize graphic.
            {
                MyAvatar.TrowDiceNoGr();

                if (Opponent.Strengt < 5)
                {
                    Opponent.TrowLuckyDice(5);              // Autoselect Opponent Luck
                }
                else    
                Opponent.TrowDiceNoGr();
            }
            else
            {     
                if (LuckyDize > 0)          MyAvatar.TrowLuckyDice(LuckyDize);      // Me trying my luck.
                else                        MyAvatar.TrowDice();
            
                if (Opponent.Strengt < 5)   Opponent.TrowLuckyDice(5);              // Autoselect Opponent Luck
                else                        Opponent.TrowDice();
            }

            Gr.DiceResult(MyAvatar);
            Gr.DiceResult(Opponent);

            if (MyAvatar.Dice == Opponent.Dice)
            {
                log += "Spelare " + MyAvatar.UserName + "  <-->  " + Opponent.UserName + " slog samma resultat. En  " + MyAvatar.Dice + "a" +'\n';
                return;                 //Draw
            }

            if (MyAvatar.Dice > Opponent.Dice)
            {
                int result = MyAvatar.Dice - Opponent.Dice;
                Opponent.Strengt -= result;      // I win.
                MyAvatar.Strengt += result;

                AddToLog(MyAvatar.PlayerNumber , result);
            }

            else

            {
                int result = Opponent.Dice - MyAvatar.Dice;
                MyAvatar.Strengt -= result;      // I Loose
                Opponent.Strengt += result;

                AddToLog(Opponent.PlayerNumber , result);                       
            }


            // -------   Win Loose ?  -----------------------------------

            if (MyAvatar.Strengt < 1)
            {
                PlayerStatistic();
                Gr.YouLost(); 
                log += "Spelare " + MyAvatar.UserName + " har förlorat matchen." + '\n';
                CompleteRound();
                return;
            }

            if (Opponent.Strengt < 1)
            {
                PlayerStatistic();
                Gr.YouWin();
                MyAvatar.Cash += 10;                     // Awarded Cash.
                MyAvatar.Luck +=  5;                     // Awarded Luck.
                MyAvatar.Cash += Opponent.Cash;          // If any left.
                MyAvatar.Luck += Opponent.Luck;          // If any left.
                log += "Du har vunnit matchen. Hurra..." + '\n';
                CompleteRound();
                return;
            }
           
            Opponent.CheckStrengtStatus();               // Opponent buy strenght if needed.
        }

        static void AddToLog(int Who, int result)
        {
            if (Who == 0)               // 0 = me
            {
                if (result == 1)
                {
                    log += "Du vann " + result.ToString() + " styrka från " + Opponent.UserName + '\n';
                }
                else
                {
                    log += "Du har vunnit " + result.ToString() + " styrkor från " + Opponent.UserName + '\n';
                }
            }
            else
            {
                if (result == 1)        // Every one else...
                {
                    log += "Spelare " + Opponent.UserName + " har vunnit " + result.ToString() + " styrka från dig." + '\n';
                }
                else
                {
                    log += "Spelare " + Opponent.UserName + " har vunnit " + result.ToString() + " styrkor från dig." + '\n';                  
                }
            }    
        }

        static void CompleteRound()
        {
            DisplayAndSaveLog();
            Gr.PrepareNewGame();
            Console.ReadKey();
            GameEnd = true;
        }

        static void DisplayLogo()
        {
            Console.CursorVisible = false;
            Console.Clear();
            Gr.ArenaLogo();
            Gr.DiceLogo();
            Gr.ArenaFrame();
            Gr.UserSelectOptions();
        }
    
        static void DisplayAndSaveLog()
        {
            int line = 45;
            CleanLogLinesOnScreen(45, 10);
            WriteAt("Runda " + Round.ToString() + '\n', 15, line++);
            line = WriteLogLines(MyAvatar.log, 15, line);
            line = WriteLogLines(Opponent.log, 15, line);
                   WriteLogLines(log, 15, line);

            SaveMainLogAndClearLocalLog();
        }

        static int WriteLogLines(string log, int row, int line)
        {
            string[] s = log.Split('\n');
            foreach (string l in s)
            {
                WriteAt(l, row, line++);
            }
            return line;
        }

        static void CleanLogLinesOnScreen(int line, int ammount)
        {
            for (int y = line; y<= line + ammount; y++)
            {
                WriteAt("                                                                                            ", 15, y);
            }
        }

        static void SaveMainLogAndClearLocalLog()
        {

            Log.BuildLog("Runda " + Round.ToString() + '\n' + MyAvatar.log + Opponent.log + log);
 
            MyAvatar.log = "";
            Opponent.log = "";
            log = "";

        }

        protected static void WriteAt(string s, int x, int y)
        {
                Console.SetCursorPosition(x, y);
                Console.Write(s);
        }

        static int ConvertToInt(string InputText)
        {
            if (int.TryParse(InputText, out int Nr))  return Nr;    
            return 0;   
        }
    }
}
