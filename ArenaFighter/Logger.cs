using System;
using System.Text;


namespace ArenaFighter
{
    class Logger
    {
        static Graph Gr = new Graph();

        public StringBuilder LogData = new StringBuilder();
        public String[] ScreenData;
        public void BuildLog(string log)
        {
            LogData.Append(log + ";");
        }
 
        public void LogString()
        {
            ScreenData = LogData.ToString().Split('\n');
        }

        public int ShowLogOnScreen(int idx, int UpOrDown)
        {
            //if (ScreenData.) LogString();

            Gr.LogMenu();
            int end;     

            if (UpOrDown == 0)
            {
                end = idx + 30;          // Down 
            }
            else
            {
                idx -= 60;
                end = idx + 30;          // Upp 
            }

            if (idx < 0)
            {
                idx = 0;
                end = idx + 30;
            }

            if (end > ScreenData.Length - 1)
            {
                end = ScreenData.Length - 1;
                idx = end - 30;
                if (idx < 0)
                {
                    idx = 0;
                }
            }

            string s;
            
            int line = 4;
            for (; idx < end; idx++)
            {             
                s = ScreenData[idx].Replace('\n', ' '); 
                s = s.Replace(';', ' ');                

                Gr.WriteAt(s, 15, line++);
            }
            return idx;
        }

    }
}
