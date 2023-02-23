using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LeagueBot.Windows;
using LeagueBot.Api;
using LeagueBot.Game.Enums;
using LeagueBot.Game.Misc;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using LeagueBot.ApiHelpers;

namespace LeagueBot
{
    public partial class Logger : Form
    {
        public enum MessageState
        {
            INFO = 0,
            INFO2 = 1,
            IMPORTANT_INFO = 2,
            WARNING = 3,
            ERROR = 4,
            ERROR_FATAL = 5,
            SUCCES = 6,
        }

        private Color COLOR_1 = Color.Magenta;
        private Color COLOR_2 = Color.DarkMagenta;
        public static Dictionary<MessageState, Color> Colors = new Dictionary<MessageState, Color>()
        {
            { MessageState.INFO,            Color.Gray },
            { MessageState.INFO2,           Color.DarkGray },
            { MessageState.IMPORTANT_INFO,  Color.White },
            { MessageState.SUCCES,          Color.Green },
            { MessageState.WARNING,         Color.Yellow },
            { MessageState.ERROR ,          Color.DarkRed},
            { MessageState.ERROR_FATAL,     Color.Red }
        };

        public void Write(object value, MessageState state = MessageState.INFO)
        {
            WriteColored(value, Colors[state]);

            if (state == MessageState.ERROR_FATAL)
            {
                Console.ReadLine();
                Environment.Exit(1);
            }
        }

        public void WriteColored(object value, Color color)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                LoggerText.AppendText(value.ToString(), color);
            });
        }
        public void WriteColor1(object value)
        {
            WriteColored(value, COLOR_1);
        }
        public void WriteColor2(object value)
        {
            WriteColored(value, COLOR_2);
        }
        public void NewLine()
        {
            this.BeginInvoke((MethodInvoker)delegate {
                LoggerText.AppendText(Environment.NewLine);
            });
        }



        ClientApi Client = new ClientApi();
        GameApi Game = new GameApi();
        
        public Logger()
        {

            InitializeComponent();
        }

        private void Logger_Load(object sender, EventArgs e)
        {
            
            Globals.logger = this;
            
            comboPick.DataSource = Enum.GetValues(typeof(ChampionEnum));
        }

        private void Logger_Shown(object sender, EventArgs e)
        {
            Configuration.InitCall();
            Client.initialize();
            Client.loadSummoner();



            
        }

        private void gameStateTimer_Tick(object sender, EventArgs e)
        {
            if (Interop.IsProcessOpen(Constants.ClientProcessName))
            {

            }
            else 
            {
            }
            if (Interop.IsProcessOpen(Constants.GameProcessName))
            {

            }
            else
            {

            }

        }

        private void btnCSChat_Click(object sender, EventArgs e)
        {
            Interop.CenterProcessWindow(Constants.ClientProcessName);
            ClientApi.focusClient();

        }

        private void ChatTimer_Tick(object sender, EventArgs e)
        {
            if (Client.getGameflowPhase() == GameflowPhaseEnum.ChampSelect)
            {

                if (checkPick.Checked)
                {
                    ChampionEnum selected = (ChampionEnum)comboPick.SelectedItem;
                    Client.pickChampion(selected);
                }
                else 
                {
                    btnPick.Enabled = true;
                }
                
            }
            else
            {

                btnPick.Enabled = false;
            }

            if (Client.getGameflowPhase() == GameflowPhaseEnum.InProgress)
            {

            }
            else
            {

            }
        }

        private void btnIGChat_Click(object sender, EventArgs e)
        {
            //Interop.CenterProcessWindow(Constants.GameProcessName);
            Game.focusGame();

        }

        private void tmrLobby_Tick(object sender, EventArgs e)
        {
            if (Client.getGameflowPhase() == GameflowPhaseEnum.Lobby)
            {

                btnFind.Enabled = true;
            }
            else 
            {
                btnFind.Enabled = false;

                if (Client.getGameflowPhase() == GameflowPhaseEnum.None) 
                {

                }
            }

            if (Client.isMatchFound())
            {
                if (checkMatch.Checked == true)
                {
                    Client.acceptMatch();
                }
                else
                {
                    btnAccept.Enabled = true;
                }

            }
            else 
            {
                btnAccept.Enabled = false;
            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Client.acceptMatch();
        }

        private void btnLobby_Click(object sender, EventArgs e)
        {
            Client.createLobby(QueueEnum.BotIntro);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Client.searchMatch();
        }

        private void checkMatch_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMatch.Checked)
            {
                btnAccept.BackColor = Color.LightGreen;
            }
            else 
            {
                btnAccept.BackColor = Color.Teal;
            }
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            ChampionEnum selected = (ChampionEnum)comboPick.SelectedItem;
            Client.pickChampion(selected);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Interop.IsProcessOpen(Constants.GameProcessName))
            {
                if (GameLCU.IsApiReady()) 
                {


                }
            }
        }
    }
}
public static class RichTextBoxExtensions
{
    public static void AppendText(this RichTextBox box, string text, Color color)
    {
        box.SelectionStart = box.TextLength;
        box.SelectionLength = 0;

        box.SelectionColor = color;
        box.AppendText(text);
        box.SelectionColor = box.ForeColor;
    }
}