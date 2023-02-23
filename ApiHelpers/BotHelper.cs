using System.Threading;


namespace LeagueBot.ApiHelpers
{
    class BotHelper
    {
        /*
         * In milliseconds
         */
        private const int IDLE_DELAY = 250;

        public static void Wait(int ms)
        {
            Thread.Sleep(ms);
        }
        public static void InputIdle()
        {
            Thread.Sleep(IDLE_DELAY);
        }
    }
}
