using System.Threading;

namespace ArenaFighter
{
    class Avatar
    {
        static readonly System.Random N_Rnd = new System.Random(System.Convert.ToInt32(System.DateTime.Now.Ticks % System.Int32.MaxValue));
        static int Rnr(int L, int H)
        {
            return N_Rnd.Next(L, H + 1);
        }

        public string UserName  // property
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public int Strengt
        {
            get { return _strengt; }
            set { _strengt = value; }
        }

        public int Luck
        {
            get { return _luck; }
            set { _luck = value; }
        }

        public int Cash
        {
            get { return _cash; }
            set { _cash = value; }
        }

        public int Dice
        {
            get { return _dice; }
            set { _dice = value; }
        }

        public int PlayerNumber
        {
            get { return _playernr; }
            set { _playernr = value; }
        }

        public string log
        {
            get { return _log; }
            set { _log = value; }
        }

        private string _userName = "";       // Avatar
        private int _strengt = 0;            // Reduced by opponent higher score. Gained by beating opponent or buy.
        private int _luck = 0;               // Get extra dice trow. Winner Get extra 5 and opponents remaining if any.
        private int _cash = 0;               // Reduced by buing stuff. Gained by Winnin matches. 
        private int _dice = 0;               // Last Dice result.
        private int _playernr = 0;           // Player using this class.
        private string _log = "";           

        public void RandomName()
        {
            // First Name.
            string s = NameGenerator(2, 6);
            s += " ";
            // Sir Name.
            s += NameGenerator(2, 4);
            _userName = s;
        }


        public string NameGenerator(int l, int h)
        {
            string n = "absrdtohbuir.ewncvxop";         // Just for the picking.
            int nr = Rnr(l, h);
            string s = n.Substring(Rnr(0, n.Length - 1), 1).ToUpper();

            for (int i = 0; i <= nr - 1; i++)
            {
                s += n.Substring(Rnr(1, n.Length - 1), 1); //n.(i);
            }
            return s;
        }


        public void RandomAbility()
        {
            _strengt = Rnr(10, 20);     // Reduced by opponent higher score. Gained by beating opponent.
            _luck = Rnr(3, 10);         // Reduced by time. Gained by buing luck leaf.
            _cash = Rnr(5, 10);         // Reduced by buing stuff. Gained by Winnin matches. Winnings = Opponents Cash.
            log += "Spelare " + _userName + " har egenskaper Styrka, Tur, Pengar. " + _strengt + ", " + _luck + ", " + _cash +  ":" + '\n';
        }

        static Graph Gr = new Graph();

        public void TrowDice()
        {
            int wait = 100;
            for (int i= 0; i < 10; i++)
            {
                _dice = Rnr(1, 6);
                Gr.DiceResult(this);
                Thread.Sleep(wait - i*6);
            }

            _dice = Rnr(1, 6);
            Gr.DiceResult(this);
            log += "Spelare " + _userName + " slog en " + _dice.ToString () + "a" + '\n';
        }

        public void TrowDiceNoGr()
        {
            _dice = Rnr(1, 6);
            Gr.DiceResult(this);
            log += "Spelare " + _userName + " slog en " + _dice.ToString() + "a" + '\n';
        }

        public void CheckStrengtStatus()
        {    
            if (_strengt < 1) return;       // Allredy lost.
            if (_cash < 1) return;          // Broke...

            int c = 5;                      // Prepare to buy 5
            if (_strengt <= c)              // Only 5 str or less left. BUY...
            {
                if (_cash <= c) c = _cash;  // If low on cash take whats left.
                BuyStrengt(c);
            }
        }

        public void BuyStrengt(int c)
        {
            _strengt += c;
            _cash -= c;
            log += _userName + " Köpte " + c.ToString() + " enheter styrka för " + c.ToString() + '\n';
        }

        // Trow as many times as you pay in luck. Receive the higest score.
        public void TrowLuckyDice(int tryMyLuck)
        {
            
            TrowDice();     // Always the normal dice trow. If super lucky no Luck will be used.
            if (_dice == 6)
            {
                if (_luck < 1) return;  // All luck gone. Just a normal throw.
                log += _userName + " hade tur och fick en " + _dice.ToString() + "a på normal kastet och sparade all sina turkast." + '\n';
                return;
            }

            // How much luck remain.
            if (_luck < 1)
            {
                return;
            }

            if (tryMyLuck > _luck) tryMyLuck = _luck;   // Can't use more than existing.

            // Now try some luck.
            int d = 0;
            int i;

            for (i = 1; i <= tryMyLuck; i++)
            {
                _dice = Rnr(1, 6);
                _luck--;

                if (_dice == 6)
                {
                    if (i < tryMyLuck) // Only if we have luck to save.
                    { 
                    log += _userName + " hade tur och fick en " + _dice.ToString() + "a efter " + i.ToString() + " försök och sparade " + (tryMyLuck - i).ToString() + " turkast." + '\n';
                    Gr.DiceResult(this);
                    return;
                    }
                }
                if (_dice > d) d = _dice;       // Save highest value.
            }

            _dice = d;
            log += _userName + " försökte med tur och fick en " + _dice.ToString() + "a efter " + i.ToString() + " försök" + '\n';
            Gr.DiceResult(this);
            return;
        }   
    }
}
