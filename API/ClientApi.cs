using LeagueBot.ApiHelpers;
using LeagueBot.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Leaf.xNet;
using System.Threading;
using LeagueBot.LCU;
using LeagueBot.Game;
using LeagueBot.Game.Enums;
using LeagueBot.LCU.Protocol;
using LeagueBot.Windows;
using LeagueBot.Game.Misc;

namespace LeagueBot.Api
{
    public class ClientApi : IApi
    {
        public Summoner summoner
        {
            get;
            private set;
        }
        public void initialize()
        {
            ClientLCU.Initialize();
        }
        public void waitClientReady()
        {
            while (true)
            {
                if (ClientLCU.IsApiReady())
                {
                    break;
                }
                Thread.Sleep(2000);
            }
        }
        public void closeClient()
        {
            ClientLCU.CloseClient();
        }
        public void openClient()
        {
            ClientLCU.OpenClient();
        }
        public static void focusClient()
        {
            Interop.BringWindowToFront(Constants.ClientProcessName);
        }

        public bool loadSummoner()
        {
            this.summoner = ClientLCU.GetCurrentSummoner();
            return summoner != null;
        }
        public void createLobby(QueueEnum queueId)
        {
            ClientLCU.CreateLobby(queueId);
        }
        public SearchMatchResult searchMatch()
        {
            return ClientLCU.SearchMatch();
        }
        public void acceptMatch()
        {
            ClientLCU.AcceptMatch();
        }
        public bool isMatchFound()
        {
            return ClientLCU.IsMatchFound();
        }
        public GameflowPhaseEnum getGameflowPhase()
        {
            return ClientLCU.GetGameflowPhase();
        }

        public ChampionPickResult pickChampion(ChampionEnum champion)
        {
            return ClientLCU.PickChampion(summoner, champion);
        }

        public static void TalkChat(string Message) 
        {
            Chat.talkInChampSelect(Message);
        }

    }
}
