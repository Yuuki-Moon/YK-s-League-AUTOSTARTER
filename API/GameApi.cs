//using InputManager;
using LeagueBot.ApiHelpers;
using LeagueBot.Game.Entities;
using LeagueBot.Game.Enums;
using LeagueBot.Game.Misc;
using LeagueBot.IO;
using LeagueBot.Utils;
using LeagueBot.Windows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LeagueBot.Api
{

    public class GameApi : IApi // Teams[] CameraIndex PlayerIndex
    {
        public Shop shop
        {
            get;
            private set;
        }
        public Camera camera
        {
            get;
            private set;
        }
        public Chat chat
        {
            get;
            private set;
        }
        private SideEnum? side
        {
            get;
            set;
        }
        
        public ActivePlayer player
        {
            get;
            private set;
        }
        
        public GameApi()
        {
            this.shop = new Shop(this);
            this.camera = new Camera(this);
            this.chat = new Chat(this);
            this.player = new ActivePlayer(this);
        }
        public void focusGame()
        {
            Interop.BringWindowToFront(Constants.GameProcessName);
        }
        public dynamic getAllies()
        {
            return GameLCU.GetAllies();
        }

        public SideEnum getSide()
        {
            if (side == null)
            {
                side = GameLCU.GetPlayerSide();
            }
            return side.Value;
        }

    }
}
