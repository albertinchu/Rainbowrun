using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smod2.EventHandlers;
using Smod2.Events;
using Smod2.API;
using scp4aiur;


namespace Rainbowrun
{
    partial class Eventos1 : IEventHandlerPlayerHurt
    {
        public void OnPlayerHurt(PlayerHurtEvent ev)
        {
            System.Random daño = new System.Random();
            int evento1 = daño.Next(0, 50);

            if ((evento1 == 0) || (evento1 == 1))
            {
                ev.Damage = 0;
                
            }
            if ((evento1 == 2)) { ev.Damage *= 2; }
            if ((evento1 == 3)) { ev.Damage /= 2; }
            if ((evento1 == 5)) { ev.Attacker.AddHealth(-Convert.ToInt32(ev.Damage)); }
            if ((evento1 == 6)) { ev.Attacker.AddHealth(Convert.ToInt32(ev.Damage)); }
            if(evento1 == 7) { ev.Player.Kill(DamageType.E11_STANDARD_RIFLE); }
            if(evento1 == 8) { ev.Attacker.Kill(DamageType.SCP_173); }
            if (evento1 == 9) { ev.Player.AddHealth(300); }
            if (evento1 == 10) { ev.Attacker.AddHealth(300); }
            if (evento1 == 11) { ev.Attacker.Disconnect(); }
            if (evento1 == 12) { ev.Player.Disconnect(); }
            if(evento1 == 13) { ev.Damage = ev.Player.GetHealth(); }
            if (evento1 == 14) { ev.Damage = ev.Attacker.GetHealth(); }
            if(evento1 == 15) { ev.Player.GiveItem(ItemType.FRAG_GRENADE); }
            if (evento1 == 17) { ev.Attacker.GiveItem(ItemType.FLASHBANG); }
            if (evento1 == 16) { ev.Player.GiveItem(ItemType.FLASHBANG); }
            if (evento1 == 18) { ev.Attacker.GiveItem(ItemType.FRAG_GRENADE); }
            if (evento1 == 19) { ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true,ev.Attacker.GetPosition(), true, ev.Player.GetPosition(),false,0,false); }
            if (evento1 == 20) { ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, ev.Player.GetPosition(), true, ev.Player.GetPosition(), false, 0, false); }
            if (evento1 == 21) { ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, ev.Player.GetPosition(), true, ev.Attacker.GetPosition(), false, 0, false); }
            if (evento1 == 22) { ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, ev.Attacker.GetPosition(), true, ev.Attacker.GetPosition(), false, 0, false); }
            if(evento1 == 24) { ev.Attacker.GiveItem(ItemType.O5_LEVEL_KEYCARD); }
            if (evento1 == 25) { ev.Player.GiveItem(ItemType.O5_LEVEL_KEYCARD); }
            if(evento1 == 26) { ev.Player.ChangeRole(Role.SCP_173, false, false); ev.Player.SetGodmode(true); ev.Player.SetHealth(1); }
            if(evento1 == 27) { ev.Attacker.ChangeRole(Role.SCP_106, false, false); ev.Player.SetHealth(1); }
            if(evento1 == 28) { ev.Attacker.Teleport(ev.Player.GetPosition()); }
            if (evento1 == 29) { ev.Player.Teleport(ev.Attacker.GetPosition()); }
            if(evento1 == 30) { ev.Attacker.ChangeRole(Role.CHAOS_INSURGENCY, false, false); }
            if (evento1 == 31) { ev.Attacker.ChangeRole(Role.CLASSD, false, false); }
            if (evento1 == 32) { ev.Attacker.ChangeRole(Role.SCIENTIST, false, false); }
            if (evento1 == 33) { ev.Attacker.ChangeRole(Role.NTF_LIEUTENANT, false, false); }
            if (evento1 == 34) { ev.Attacker.ChangeRole(Role.SCP_049_2, false, false); }
            if(evento1 == 35) { ev.Player.ChangeRole(Role.SCP_049, false, false); }
            if (evento1 == 36) { ev.Player.ChangeRole(Role.CHAOS_INSURGENCY, false, false); }
            if (evento1 == 37) { ev.Player.ChangeRole(Role.CLASSD, false, false); }
            if (evento1 == 38) { ev.Player.ChangeRole(Role.SCIENTIST, false, false); }
            if (evento1 == 39) { ev.Player.ChangeRole(Role.NTF_LIEUTENANT, false, false); }
            if (evento1 == 40) { ev.Player.ChangeRole(Role.SCP_049_2, false, false); }
            if (evento1 == 41) { Smod2.PluginManager.Manager.Server.Map.StartWarhead(); }
            if (evento1 == 42) { Smod2.PluginManager.Manager.Server.Map.StopWarhead(); }
            if (evento1 == 43) { Smod2.PluginManager.Manager.Server.Map.AnnounceCustomMessage("I will destroy u . j a j a j a"); }
            if(evento1 == 44) { ev.Attacker.GiveItem(ItemType.MEDKIT); }
            if (evento1 == 45) { ev.Player.GiveItem(ItemType.MEDKIT); }
            if (evento1 == 46) { ev.Player.GiveItem(ItemType.RADIO); }
            if (evento1 == 47) { ev.Attacker.GiveItem(ItemType.RADIO); }
            if (evento1 == 48) { ev.Player.GiveItem(ItemType.USP); }
            if (evento1 == 49) { ev.Attacker.GiveItem(ItemType.USP); }
            if (evento1 == 50) { Smod2.PluginManager.Manager.Server.Map.Broadcast(5, "Gana " + ev.Attacker.Name, false); }
        }
    }
}
