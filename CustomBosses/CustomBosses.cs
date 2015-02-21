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
    [ApiVersion(1, 16)]
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
            switch (args.Npc.type) //5x damage, around 30k health
            {
#region Pre-HM
                #region King Slime
                case 50:
                    args.Npc.damage = 200;
                    args.Npc.lifeMax = 13000;
                    args.Npc.life = 13000;
                    break;
                #endregion
                #region Brain of Cthulhu
                case 226:
                    args.Npc.damage = 150;
                    args.Npc.lifeMax = 5000;
                    args.Npc.life = 5000;
                    break;
                #endregion
                #region Queen Bee
                case 222:
                    args.Npc.damage = 150;
                    args.Npc.lifeMax = 17000;
                    args.Npc.life = 17000;
                    break;
                #endregion
                #region EoC
                case 4:
                    args.Npc.damage = 75;
                    args.Npc.lifeMax = 10000; //2x health
                    args.Npc.life = 10000;
                    break;
                case 5:
                    args.Npc.damage = 60;
                    args.Npc.lifeMax = 25;
                    args.Npc.life = 25;
                    break;
                #endregion
                #region Eater of Worlds
                case 13:
                    args.Npc.damage = 110;
                    args.Npc.lifeMax = 325;
                    args.Npc.life = 325;
                    break;
                case 14:
                    args.Npc.damage = 65;
                    args.Npc.lifeMax = 750;
                    args.Npc.life = 750;
                    break;
                case 15:
                    args.Npc.damage = 60;
                    args.Npc.lifeMax = 1100;
                    args.Npc.life = 1100;
                    break;
                #endregion
                #region WoF
                case 113:
                    args.Npc.damage = 250;
                    args.Npc.lifeMax = 29000;
                    args.Npc.life = 29000;
                    break;
                case 114:
                    args.Npc.damage = 350;
                    args.Npc.lifeMax = 20000;
                    args.Npc.life = 20000;
                    break;
                case 115:
                    args.Npc.damage = 150;
                    args.Npc.lifeMax = 10000;
                    args.Npc.life = 10000;
                    break;
                case 116:
                    args.Npc.damage = 150;
                    args.Npc.lifeMax = 10000;
                    args.Npc.life = 10000;
                    break;
                #endregion
#endregion
#region HM
                #region Golem
                case 245:
                    args.Npc.damage = 750;
                    args.Npc.lifeMax = 28000;
                    args.Npc.life = 28000;
                    break;
                case 246:
                    args.Npc.damage = 150;
                    args.Npc.lifeMax = 20000;
                    args.Npc.life = 20000;
                    break;
                case 247:
                case 248:
                    args.Npc.damage = 300;
                    args.Npc.lifeMax = 9000;
                    args.Npc.life = 9000;
                    break;
                case 249:
                    args.Npc.damage = 400;
                    args.Npc.lifeMax = 28000;
                    args.Npc.life = 28000;
                    break;
                #endregion
            }
#endregion
        }
        #endregion
    }
}
