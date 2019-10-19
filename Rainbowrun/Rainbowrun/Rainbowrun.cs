using Smod2;
using Smod2.Attributes;
using scp4aiur;
using System;

namespace Rainbowrun
{
    [PluginDetails(
        author = "Albertinchu",
        name = "Rainbowrun",
        description = "todo aleatorio",
        id = "albertinchu.gamemode.Rainbowrun",
        version = "3.5.0",
        SmodMajor = 3,
        SmodMinor = 4,
        SmodRevision = 0
        )]
    public class RainBowrun : Plugin
    {

        public override void OnDisable()
        {
            this.Info("Rainbowrun - Desactivado");
        }

        public override void OnEnable()
        {
            this.Info("Rainbowrun - Activado");
        }

        public override void Register()
        {
            this.AddEventHandlers(new Events(this));
            Timing.Init(this);
           

            GamemodeManager.Manager.RegisterMode(this);

        }



        public void RefreshConfig()
        {


        }
    }

}