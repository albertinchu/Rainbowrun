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
    partial class Eventos1 : IEventHandlerPlayerHurt, IEventHandlerPlayerDropItem, IEventHandlerPlayerTriggerTesla, IEventHandlerSetRole, IEventHandlerPlayerDropAllItems
    {
        static Dictionary<string, bool> Cooldown2 = new Dictionary<string, bool>();
        public static IEnumerable<float> Cooldownw2(Player player)
        {

            yield return 1.5f;
            Cooldown2[player.SteamId] = true;
        }
        public void OnPlayerDropItem(PlayerDropItemEvent ev)
        {
            System.Random objeto = new System.Random();
            int evento1b = objeto.Next(0, 30);
            if((evento1b == 0) || (evento1b == 1))
            {
                ev.Allow = false;
            }
            if (evento1b == 2){ ev.ChangeTo = ItemType.NULL; }
            if (evento1b == 3) { ev.ChangeTo = ItemType.MTF_LIEUTENANT_KEYCARD; }
            if (evento1b == 4) { ev.ChangeTo = ItemType.MTF_COMMANDER_KEYCARD; }
            if (evento1b == 5) { ev.ChangeTo = ItemType.MP7; }
            if (evento1b == 6) { ev.ChangeTo = ItemType.MICROHID; }
            if (evento1b == 7) { ev.ChangeTo = ItemType.MEDKIT; }
            if (evento1b == 8) { ev.ChangeTo = ItemType.MAJOR_SCIENTIST_KEYCARD; }
            if (evento1b == 9) { ev.ChangeTo = ItemType.LOGICER; }
            if (evento1b == 10) { ev.ChangeTo = ItemType.JANITOR_KEYCARD; }
            if (evento1b == 11) { ev.ChangeTo = ItemType.GUARD_KEYCARD; }
            if (evento1b == 12) { ev.ChangeTo = ItemType.FRAG_GRENADE; }
            if (evento1b == 13) { ev.ChangeTo = ItemType.FLASHLIGHT; }
            if (evento1b == 14) { ev.ChangeTo = ItemType.FLASHBANG; }
            if (evento1b == 15) { ev.ChangeTo = ItemType.FACILITY_MANAGER_KEYCARD; }
            if (evento1b == 16) { ev.ChangeTo = ItemType.E11_STANDARD_RIFLE; }
            if (evento1b == 17) { ev.ChangeTo = ItemType.DISARMER; }
            if (evento1b == 18) { ev.ChangeTo = ItemType.CONTAINMENT_ENGINEER_KEYCARD; }
            if (evento1b == 19) { ev.ChangeTo = ItemType.COM15; }
            if (evento1b == 20) { ev.ChangeTo = ItemType.CHAOS_INSURGENCY_DEVICE; }
            if (evento1b == 21) { ev.ChangeTo = ItemType.COIN; }
            if (evento1b == 22) { ev.ChangeTo = ItemType.ZONE_MANAGER_KEYCARD; }
            if (evento1b == 23) { ev.ChangeTo = ItemType.WEAPON_MANAGER_TABLET; }
            if (evento1b == 24) { ev.ChangeTo = ItemType.USP; }
            if (evento1b == 25) { ev.ChangeTo = ItemType.SENIOR_GUARD_KEYCARD; }
            if (evento1b == 26) { ev.ChangeTo = ItemType.SCIENTIST_KEYCARD; }
            if (evento1b == 27) { ev.ChangeTo = ItemType.RADIO; }
            if (evento1b == 28) { ev.ChangeTo = ItemType.P90; }
            if (evento1b == 29) { ev.ChangeTo = ItemType.O5_LEVEL_KEYCARD; }
            if (evento1b == 30) { ev.Player.Kill(DamageType.POCKET); }
             
        }

        public void OnPlayerHurt(PlayerHurtEvent ev)
        {
            System.Random daño = new System.Random();
            int evento1 = daño.Next(0, 50);
            if (ev.Attacker.GetGodmode()) { ev.Attacker.SetGodmode(false); }
            if(Cooldown2[ev.Player.SteamId])
            {
                Cooldown2[ev.Player.SteamId] = false;
            if ((evento1 == 0) || (evento1 == 1))
            {
                ev.Damage = 0;

            }
            if ((evento1 == 2)) { ev.Damage *= 2; }
            if ((evento1 == 3)) { ev.Damage /= 2; }
            if ((evento1 == 5)) { ev.Attacker.AddHealth(-Convert.ToInt32(ev.Damage)); }
            if ((evento1 == 6)) { ev.Attacker.AddHealth(Convert.ToInt32(ev.Damage)); }
            if (evento1 == 7) { ev.Player.Kill(DamageType.E11_STANDARD_RIFLE); }
            if (evento1 == 8) { ev.Attacker.Kill(DamageType.SCP_173); }
            if (evento1 == 9) { ev.Player.AddHealth(300); }
            if (evento1 == 10) { ev.Attacker.AddHealth(300); }

            if (evento1 == 13) { ev.Damage = ev.Player.GetHealth(); }
            if (evento1 == 14) { ev.Damage = ev.Attacker.GetHealth(); }
            if (evento1 == 15) { ev.Player.GiveItem(ItemType.FRAG_GRENADE); }
            if (evento1 == 17) { ev.Attacker.GiveItem(ItemType.FLASHBANG); }
            if (evento1 == 16) { ev.Player.GiveItem(ItemType.FLASHBANG); }
            if (evento1 == 18) { ev.Attacker.GiveItem(ItemType.FRAG_GRENADE); }
            if (evento1 == 19) { ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, ev.Attacker.GetPosition(), true, ev.Player.GetPosition(), false, 0, false); }
            if (evento1 == 20) { ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, ev.Player.GetPosition(), true, ev.Player.GetPosition(), false, 0, false); }
            if (evento1 == 21) { ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, ev.Player.GetPosition(), true, ev.Attacker.GetPosition(), false, 0, false); }
            if (evento1 == 22) { ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, ev.Attacker.GetPosition(), true, ev.Attacker.GetPosition(), false, 0, false); }
            if (evento1 == 24) { ev.Attacker.GiveItem(ItemType.O5_LEVEL_KEYCARD); }
            if (evento1 == 25) { ev.Player.GiveItem(ItemType.O5_LEVEL_KEYCARD); }
            if (evento1 == 26) { ev.Player.ChangeRole(Role.SCP_173, false, false); ev.Player.SetGodmode(true); ev.Player.SetHealth(1); }
            if (evento1 == 27) { ev.Attacker.ChangeRole(Role.SCP_106, false, false); ev.Player.SetHealth(1); }
            if (evento1 == 28) { ev.Attacker.Teleport(ev.Player.GetPosition()); }
            if (evento1 == 29) { ev.Player.Teleport(ev.Attacker.GetPosition()); }
            if (evento1 == 30) { ev.Attacker.ChangeRole(Role.CHAOS_INSURGENCY, false, false); }
            if (evento1 == 31) { ev.Attacker.ChangeRole(Role.CLASSD, false, false); }
            if (evento1 == 32) { ev.Attacker.ChangeRole(Role.SCIENTIST, false, false); }
            if (evento1 == 33) { ev.Attacker.ChangeRole(Role.NTF_LIEUTENANT, false, false); }
            if (evento1 == 34) { ev.Attacker.ChangeRole(Role.SCP_049_2, false, false); }
            if (evento1 == 35) { ev.Player.ChangeRole(Role.SCP_049, false, false); }
            if (evento1 == 36) { ev.Player.ChangeRole(Role.CHAOS_INSURGENCY, false, false); }
            if (evento1 == 37) { ev.Player.ChangeRole(Role.CLASSD, false, false); }
            if (evento1 == 38) { ev.Player.ChangeRole(Role.SCIENTIST, false, false); }
            if (evento1 == 39) { ev.Player.ChangeRole(Role.NTF_LIEUTENANT, false, false); }
            if (evento1 == 40) { ev.Player.ChangeRole(Role.SCP_049_2, false, false); }
            if (evento1 == 41) { Smod2.PluginManager.Manager.Server.Map.StartWarhead(); }
            if (evento1 == 42) { Smod2.PluginManager.Manager.Server.Map.StopWarhead(); }
            if (evento1 == 43) { Smod2.PluginManager.Manager.Server.Map.AnnounceCustomMessage("I will destroy u . j a j a j a"); }
            if (evento1 == 44) { ev.Attacker.GiveItem(ItemType.MEDKIT); }
            if (evento1 == 45) { ev.Player.GiveItem(ItemType.MEDKIT); }
            if (evento1 == 46) { ev.Player.GiveItem(ItemType.RADIO); }
            if (evento1 == 47) { ev.Attacker.GiveItem(ItemType.RADIO); }
            if (evento1 == 48) { ev.Player.GiveItem(ItemType.USP); }
            if (evento1 == 49) { ev.Attacker.GiveItem(ItemType.USP); }
            if (evento1 == 50) { Smod2.PluginManager.Manager.Server.Map.Broadcast(5, "Gana " + ev.Attacker.Name, false); }
                Timing.Run(Cooldownw2(ev.Player));
        }
        }
        public static IEnumerable<float> dañoo(Player player)
        {
            int daño = 0;
            while(daño <= 10)
            {
                if(player.GetHealth() <= 9) { player.Kill(); }
                yield return 3f;
                player.AddHealth(-9);
                

            }
                   
        }
        public static IEnumerable<float> vidaa(Player player)
        {
            int daño = 0;
            while (daño <= 10)
            {
                
                yield return 3f;
                player.AddHealth(9);


            }

        }

        public void OnPlayerTriggerTesla(PlayerTriggerTeslaEvent ev)
        {
            System.Random tesla = new System.Random();
            int evento2 = tesla.Next(0, 25);
            if((evento2 == 0) || (evento2 == 1)) 
            {
                ev.Player.AddHealth(-10);
            }
            if(evento2 == 2) 
            {
                Timing.Run(dañoo(ev.Player));
            }
            if (evento2 == 3)
            {
                Timing.Run(vidaa(ev.Player));
            }
            if(evento2 == 4)
            {
                ev.Player.GiveItem(ItemType.P90);
            }
            if (evento2 == 5)
            {
                ev.Player.Teleport(Smod2.PluginManager.Manager.Server.Map.GetRandomSpawnPoint(Role.FACILITY_GUARD));
            }
            if (evento2 == 6)
            {
                ev.Player.Teleport(Smod2.PluginManager.Manager.Server.Map.GetRandomSpawnPoint(Role.CLASSD));
            }
            if (evento2 == 7)
            {
                ev.Player.Teleport(Smod2.PluginManager.Manager.Server.Map.GetRandomSpawnPoint(Role.SCIENTIST));

            }
            if (evento2 == 8)
            {
                ev.Player.Teleport(Smod2.PluginManager.Manager.Server.Map.GetRandomSpawnPoint(Role.SCP_096));
            }
            if (evento2 == 9)
            {
                ev.Player.Teleport(Smod2.PluginManager.Manager.Server.Map.GetRandomSpawnPoint(Role.SCP_939_53));
            }
            if (evento2 == 10)
            {
                ev.Player.Teleport(Smod2.PluginManager.Manager.Server.Map.GetRandomSpawnPoint(Role.SCP_049));
            }
            if (evento2 == 21)
            {
                ev.Triggerable = false;
              
            }
            if (evento2 == 22)
            {
                ev.Triggerable = false;

            }
            if (evento2 == 23)
            {
                ev.Triggerable = true;

            }
            if (evento2 == 24)
            {
                ev.Triggerable = true;

            }
            if (evento2 == 25)
            {
                ev.Player.HandcuffPlayer(Smod2.PluginManager.Manager.Server.GetPlayers()[1]);

            }

        }

        public void OnSetRole(PlayerSetRoleEvent ev)
        {
            if (!Cooldown2.ContainsKey(ev.Player.SteamId)) { Cooldown2.Add(ev.Player.SteamId, true); }
        }

        public void OnPlayerDropAllItems(PlayerDropAllItemsEvent ev)
        {
            System.Random tirar = new System.Random();
            int evento3 = tirar.Next(0, 10);

            if((evento3 == 0)||(evento3 == 1)) 
            {
                ev.Player.GiveItem(ItemType.FRAG_GRENADE);
                ev.Player.PersonalBroadcast(3, "encontre una granada mientras limpiaba mis bolsillos xdd", false);
            }
            if ((evento3 == 2))
            {
                ev.Player.GiveItem(ItemType.MEDKIT);
                ev.Player.PersonalBroadcast(3, "encontre una botiquín mientras limpiaba mis bolsillos xdd", false);
            }
            if ((evento3 == 3))
            {
               
                ev.Player.PersonalBroadcast(3, "Bien, ya no tengo nada en el inventario GG", false);
            }
            if ((evento3 == 4))
            {
                ev.Player.AddHealth(10);
                ev.Player.PersonalBroadcast(3, " < color =#E40BD7> HP UP </color>", false);
            }
            if ((evento3 == 5))
            {
                ev.Player.AddHealth(-10);
                ev.Player.PersonalBroadcast(3, " < color =#C50000> HP down </color>", false);
            }
            if ((evento3 == 6))
            {
                ev.Player.ThrowGrenade(GrenadeType.FLASHBANG, true, new Vector(0, 0, 0), true, ev.Player.GetPosition(), true, 0);
                ev.Player.PersonalBroadcast(3, " < color =#C50000> =D </color>", false);
            }
            if ((evento3 == 7))
            {
                ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, new Vector(0, 0, 0), true, ev.Player.GetPosition(), true, 0);
                ev.Player.PersonalBroadcast(3, " < color =#C50000> Deja de tirar basura al suelo )=V </color>", false);
            }
            if ((evento3 == 8))
            {
                ev.Allow = false;
                ev.Player.PersonalBroadcast(3, " < color =#C50000> Noooo </color>", false);
            }
            if ((evento3 == 9))
            {
                ev.Player.GiveItem(ItemType.LOGICER);
                ev.Player.GiveItem(ItemType.E11_STANDARD_RIFLE);
                ev.Player.GiveItem(ItemType.MEDKIT);
                ev.Player.GiveItem(ItemType.O5_LEVEL_KEYCARD);
                ev.Player.SetAmmo(AmmoType.DROPPED_5, 300);
                ev.Player.SetAmmo(AmmoType.DROPPED_7, 300);
                ev.Player.SetAmmo(AmmoType.DROPPED_9, 300);
                ev.Player.PersonalBroadcast(3, " < color =#C50000> Comienza tu genocidio =D </color>", false);
            }
            if ((evento3 == 10))
            {
                ev.Player.Teleport(Smod2.PluginManager.Manager.Server.Map.GetRandomSpawnPoint(Role.SCP_096));
                ev.Player.PersonalBroadcast(3, " < color =#C50000> Por tirar basura, Tonto </color>", false);
            }
        }
    }
}
