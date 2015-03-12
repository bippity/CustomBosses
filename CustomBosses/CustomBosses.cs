using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TShockAPI;
using TShockAPI.Hooks;
using Terraria;
using TerrariaApi.Server;

namespace CustomBosses
{
    [ApiVersion(1, 17)]
    public class CustomBosses : TerrariaPlugin
    {
        #region plugin info
        public override Version Version
        {
            get { return new Version("1.0"); }
        }
        public override string Name
        {
            get { return "CustomBosses"; }
        }
        public override string Author
        {
            get { return "Bippity"; }
        }
        public override string Description
        {
            get { return "Customized Bosses"; }
        }
        public CustomBosses(Main game)
            : base(game)
        {
            Order = 1;
        }
        #endregion

        #region Initialize/Dispose
        public override void Initialize()
        {
            ServerApi.Hooks.NpcSpawn.Register(this, OnNpcSpawn);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ServerApi.Hooks.NpcSpawn.Deregister(this, OnNpcSpawn);
            }
            base.Dispose(disposing);
        }
        #endregion

        #region CustomBosses
        private void OnNpcSpawn(NpcSpawnEventArgs args)
        {
            /*if (args.Npc.type == 113)
            {
                args.Npc.damage = 5000;
                args.Npc.lifeMax = 28000;
                args.Npc.life = 28000;
                args.Npc.defense = 24;
            }*/
            NPC npc = Main.npc[args.NpcId];
            switch (npc.type) //5x damage, around 30k health
            {
#region Pre-HM
                #region King Slime
                case 50:
                    npc.damage = 200;
                    npc.lifeMax = 13000;
                    npc.life = 13000;
                    break;
                #endregion
                #region Brain of Cthulhu
                case 226:
                    npc.damage = 150;
                    npc.lifeMax = 5000;
                    npc.life = 5000;
                    break;
                #endregion
                #region Queen Bee
                case 222:
                    npc.damage = 150;
                    npc.lifeMax = 17000;
                    npc.life = 17000;
                    break;
                #endregion
                #region EoC
                case 4:
                    npc.damage = 75;
                    npc.lifeMax = 10000; //2x health
                    npc.life = 10000;
                    break;
                case 5:
                    npc.damage = 60;
                    npc.lifeMax = 25;
                    npc.life = 25;
                    break;
                #endregion
                #region Eater of Worlds
                case 13:
                    npc.damage = 110;
                    npc.lifeMax = 325;
                    npc.life = 325;
                    break;
                case 14:
                    npc.damage = 65;
                    npc.lifeMax = 750;
                    npc.life = 750;
                    break;
                case 15:
                    npc.damage = 60;
                    npc.lifeMax = 1100;
                    npc.life = 1100;
                    break;
                #endregion
                #region WoF
                case 113:
                    npc.damage = 250;
                    npc.lifeMax = 29000;
                    npc.life = 29000;
                    break;
                case 114:
                    npc.damage = 350;
                    npc.lifeMax = 20000;
                    npc.life = 20000;
                    break;
                case 115:
                    npc.damage = 150;
                    npc.lifeMax = 10000;
                    npc.life = 10000;
                    break;
                case 116:
                    npc.damage = 150;
                    npc.lifeMax = 10000;
                    npc.life = 10000;
                    break;
                #endregion
#endregion
#region HM
                #region Golem
                case 245:
                    npc.damage = 750;
                    npc.lifeMax = 28000;
                    npc.life = 28000;
                    break;
                case 246:
                    npc.damage = 150;
                    npc.lifeMax = 20000;
                    npc.life = 20000;
                    break;
                case 247:
                case 248:
                    npc.damage = 300;
                    npc.lifeMax = 9000;
                    npc.life = 9000;
                    break;
                case 249:
                    npc.damage = 400;
                    npc.lifeMax = 28000;
                    npc.life = 28000;
                    break;
                #endregion
            }
#endregion
        }
        #endregion
    }
}
