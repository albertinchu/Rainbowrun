﻿using System;
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
    partial class Events : IEventHandlerDoorAccess, IEventHandlerPlayerHurt, IEventHandlerWaitingForPlayers, IEventHandlerPlayerDie, IEventHandlerSetRole, IEventHandler079Elevator
    {
        static Dictionary<string, int> Vidaextra = new Dictionary<string, int>();
        static Dictionary<string, String> Love = new Dictionary<string,String>();
        

        public IEnumerator<float> spectator(Player player)
        {

            yield return MEC.Timing.WaitForSeconds(60f);
            player.ChangeRole(Role.SPECTATOR);
        }
        static Dictionary<string, bool> Cooldown = new Dictionary<string, bool>();
        public IEnumerator<float> Cooldownw(Player player)
        {

            yield return MEC.Timing.WaitForSeconds(5f);
            Cooldown[player.SteamId] = true;
        }
        public void OnDoorAccess(PlayerDoorAccessEvent ev)
        {
            System.Random puertas = new System.Random();
            int p = (int)System.Environment.OSVersion.Platform;
            int evento = puertas.Next(0, 100);
            if(Cooldown[ev.Player.SteamId])
            {
                Cooldown[ev.Player.SteamId] = false;
            if ((evento == 1) || (evento == 0))
            {
                ev.Destroy = true;
                ev.Player.PersonalBroadcast(5, "estoy mamadisimo", true);
            }
            if (evento == 2)
            {
                ev.Player.PersonalBroadcast(5, "<color=#AC0BD4> No ocurre nada jaja salu2 </color>", false);
            }
            if (evento == 3)
            {
                ev.Allow = false;
                ev.Player.PersonalBroadcast(3, "<color=#C50000> No puedes abrirme jajajajaj </color>", false);

            }
            if (evento == 4)
            {
                ev.Player.AddHealth(-10);
                if (ev.Player.TeamRole.Team == Smod2.API.Team.SCP) { ev.Player.AddHealth(-200); }
                ev.Player.PersonalBroadcast(3, "<color=#C50000> Toma, por abrirme tonto </color>", false);
            }
            if (evento == 5)
            {
                ev.Player.ChangeRole(Smod2.API.Role.FACILITY_GUARD);
                ev.Player.PersonalBroadcast(5, "<color=#17CE28> Estas de coña, no? GUARDIA EN SERIO?!!! </color>", false);
            }
            if (evento == 6)
            {
                ev.Player.GiveItem(Smod2.API.ItemType.FRAG_GRENADE);
                ev.Player.PersonalBroadcast(5, "<color=#17CE28> Granada gratis </color>", false);

            }
            if (evento == 7)
            {

                ev.Player.PersonalBroadcast(5, "<color=#17CE28>V</color><color=#C50000>I</color><color=#FF5000>D</color><color=#D68312>A </color><color=#0013FF>E</color><color=#00FFC9>X</color><color=#17CE28>T</color><color=#81A700>R</color><color=#763B00>A</color>         ", false);
                if (!Vidaextra.ContainsKey(ev.Player.SteamId)) { Vidaextra.Add(ev.Player.SteamId, 1); }
                if (Vidaextra.ContainsKey(ev.Player.SteamId)) { Vidaextra[ev.Player.SteamId] += 1; }
            }
            if (evento == 8)
            {
                ev.Player.SetAmmo(AmmoType.DROPPED_5, 999);
                ev.Player.PersonalBroadcast(5, "<color=#17CE28> 999 de munición tipo 5 </color>", false);
            }
            if (evento == 9)
            {
                ev.Player.SetAmmo(AmmoType.DROPPED_5, 0);
                ev.Player.PersonalBroadcast(5, "<color=#C50000> 0 de munición tipo 5 ;d </color>", false);
            }
            if (evento == 10)
            {
                ev.Door.Locked = true;
                ev.Door.LockCooldown = 100;
                ev.Player.PersonalBroadcast(5, "<color=#C50000> puerta bloqueda 100 segundos ;d </color>", false);
            }
            if (evento == 11)
            {
                ev.Door.Locked = false;
                ev.Door.LockCooldown = 1;
                ev.Player.PersonalBroadcast(5, "<color=#FF0500> puerta desbloqueda </color>", false);
            }
            if (evento == 12)
            {
                ev.Player.ChangeRole(Role.SCP_049, false, false, false);
                ev.Player.PersonalBroadcast(5, "<color=#FF0500> Tengo un master en medicina, Lo juro </color>", false);
            }
            if (evento == 13)
            {
                ev.Player.ChangeRole(Role.CLASSD, false, false, false);
                ev.Player.PersonalBroadcast(5, "<color=#EE7700> Te cambio la bombona de butano? </color>", false);
            }
            if (evento == 14)
            {
                ev.Player.Teleport(Smod2.PluginManager.Manager.Server.Map.GetRandomSpawnPoint(Role.FACILITY_GUARD));
                ev.Player.PersonalBroadcast(2, "<color=#FF0500> eeeemmmm, ¿HOla? </color>", false);
            }
            if (evento == 15)
            {
                ev.Player.Teleport(Smod2.PluginManager.Manager.Server.Map.GetRandomSpawnPoint(Role.SCP_049_2));
                ev.Player.PersonalBroadcast(2, "<color=#FF0500> eeeemmmm, ¿HOla? </color>", false);
            }
            if (evento == 16)
            {
                ev.Player.Teleport(Smod2.PluginManager.Manager.Server.Map.GetRandomSpawnPoint(Role.SCP_049));
                ev.Player.PersonalBroadcast(2, "<color=#FF0500> eeeemmmm, ¿HOla? </color>", false);
            }
            if (evento == 17)
            {
                ev.Player.AddHealth(-50);
                ev.Player.PersonalBroadcast(2, "<color=#C50000> ¡No toques!, mi espacio vital tio </color>", false);
            }
            if (evento == 18)
            {
                ev.Player.AddHealth(50);
                ev.Player.PersonalBroadcast(2, "<color=#EE00A6> UwU </color>", false);
            }
            if (evento == 19)
            {
                ev.Player.AddHealth(500);
                ev.Player.PersonalBroadcast(2, "<color=#EE00A6> !UwU¡ </color>", false);
            }
            if (evento == 20)
            {
                Smod2.PluginManager.Manager.Server.Map.StartWarhead();
                ev.Player.PersonalBroadcast(2, "<color=#C50000> FUUUUUUUUUCK </color>", false);
            }
            if (evento == 21)
            {
                Smod2.PluginManager.Manager.Server.Map.StopWarhead();
                ev.Player.PersonalBroadcast(2, "<color=#EE00A6> well, nuke off </color>", false);
            }
            if (evento == 22)
            {
                ev.Player.ChangeRole(Role.SCP_079);
                ev.Player.PersonalBroadcast(2, "<color=#0026E6> SYSTEM ERROR BIT BIT </color>", false);
            }
            if (evento == 23)
            {
                ev.Player.ChangeRole(Role.NTF_COMMANDER);
                ev.Player.PersonalBroadcast(2, "<color=#0026E6> ¿A luchar? </color>", false);
            }
            if (evento == 24)
            {
                if (Vidaextra.ContainsKey(ev.Player.SteamId))
                {
                    if (Vidaextra[ev.Player.SteamId] > 0)
                    {
                        Vidaextra[ev.Player.SteamId] -= 1;
                    }
                    else { ev.Player.Kill(DamageType.FLYING); }
                }
                else { ev.Player.Kill(DamageType.FALLDOWN); }

                ev.Player.PersonalBroadcast(2, "<color=#C50000> ufff </color>", false);
            }
            if (evento == 25)
            {
                ev.Player.ThrowGrenade(GrenadeType.FLASHBANG, true, new Vector(0, 0, 0), true, ev.Player.GetPosition(), true, 0, true);
                ev.Player.PersonalBroadcast(2, "<color=#C50000> no puedes ver </color>", false);
            }
            if (evento == 25)
            {
                ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, new Vector(0, 0, 0), true, ev.Player.GetPosition(), true, 0, true);
                ev.Player.PersonalBroadcast(2, "<color=#C50000> corre </color>", false);
            }
            if (evento == 26)
            {
                ev.Player.SetAmmo(AmmoType.DROPPED_7, 999);
                ev.Player.PersonalBroadcast(2, "<color=#0026E6> 999 de munición 7 </color>", false);
            }
            if (evento == 27)
            {
                ev.Player.SetAmmo(AmmoType.DROPPED_7, 0);
                ev.Player.PersonalBroadcast(2, "<color=#C50000> 0 de munición 7 </color>", false);
            }
            if (evento == 28)
            {
                ev.Player.SetAmmo(AmmoType.DROPPED_7, 0);
                ev.Player.SetAmmo(AmmoType.DROPPED_5, 0);
                ev.Player.SetAmmo(AmmoType.DROPPED_9, 0);
                ev.Player.PersonalBroadcast(2, "<color=#C50000> 0 de munición de todas las municiones </color>", false);
            }
            if (evento == 29)
            {
                ev.Player.GiveItem(ItemType.O5_LEVEL_KEYCARD);
                ev.Player.PersonalBroadcast(2, "<color=#AB00E6> O5 Gratis </color>", false);
            }
            if (evento == 30)
            {
                ev.Player.AddHealth(9999);
                ev.Player.SetAmmo(AmmoType.DROPPED_9, 999);
                ev.Player.SetAmmo(AmmoType.DROPPED_7, 999);
                ev.Player.SetAmmo(AmmoType.DROPPED_5, 999);
                ev.Player.GiveItem(ItemType.LOGICER);
                ev.Player.GiveItem(ItemType.E11_STANDARD_RIFLE);
                ev.Player.GiveItem(ItemType.O5_LEVEL_KEYCARD);
                ev.Player.PersonalBroadcast(5, "<color=#E600AB> Ahora eres un star Guardian y estas mamadisimo </color>", false);
            }
            if (evento == 31)
            {
                ev.Player.GiveItem(ItemType.JANITOR_KEYCARD);
                ev.Player.PersonalBroadcast(2, "<color=#AB00E6> Basura Gratis </color>", false);
            }
            if (evento == 32)
            {
                ev.Player.GiveItem(ItemType.CUP);
                ev.Player.PersonalBroadcast(2, "<color=#AB00E6> Cafe Gratis </color>", false);
            }
            if (evento == 33)
            {
                ev.Player.GiveItem(ItemType.RADIO);
                ev.Player.PersonalBroadcast(2, "<color=#AB00E6> Radio Gratis </color>", false);
            }
            if (evento == 34)
            {
                ev.Player.GiveItem(ItemType.P90);
                ev.Player.PersonalBroadcast(2, "<color=#AB00E6> P90 Gratis </color>", false);
            }
            if (evento == 35)
            {
                ev.Player.ChangeRole(Role.ZOMBIE);
                ev.Player.PersonalBroadcast(2, "<color=#C50000> JaJAAAAAAA </color>", false);
            }
            if (evento == 36)
            {
                ev.Player.ChangeRole(Role.SCP_173, false, false);
                ev.Player.PersonalBroadcast(2, "<color=#C50000> hasme pinut </color>", false);
            }
            if (evento == 37)
            {
                ev.Player.ChangeRole(Role.SCP_173, false, false);
                ev.Player.PersonalBroadcast(2, "<color=#C50000> hasme pinut </color>", false);
            }
            if (evento == 38)
            {

                ev.Player.PersonalBroadcast(2, "<color=#C50000> Te salvas por esta vez </color>", false);
            }
            if (evento == 39)
            {

                ev.Player.PersonalBroadcast(3, "<color=#C50000> eemmm esto sa roto, por que no hase naa </color>", false);
            }
            if (evento == 40)
            {

                ev.Player.PersonalBroadcast(2, "<color=#C50000> lo importante es participar </color>", false);
            }
            if (evento == 41)
            {
                ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, ev.Player.GetPosition(), true, new Vector(0, 2, 0), true, 0, true);

                ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, ev.Player.GetPosition(), true, ev.Player.GetPosition(), true, 0, false);

                ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, ev.Player.GetPosition(), true, new Vector(0, 0, 0), true, 0, true);
                ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, new Vector(0, 3, 0), true, ev.Player.GetPosition(), true, 0, true);
                ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, ev.Player.GetPosition(), true, ev.Player.GetPosition(), true, 0, true);
                ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, new Vector(0, 4, 0), true, ev.Player.GetPosition(), true, 0, true);
                ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, ev.Player.GetPosition(), true, new Vector(0, 0, 0), true, 0, true);
                ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, new Vector(0, 2, 0), true, ev.Player.GetPosition(), true, 0, true);
                ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, ev.Player.GetPosition(), true, ev.Player.GetPosition(), true, 0, true);
                ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, new Vector(0, 0, 0), true, ev.Player.GetPosition(), true, 0, true);
                ev.Player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, ev.Player.GetPosition(), true, new Vector(0, 4, 0), true, 0, false);
                ev.Player.PersonalBroadcast(2, "<color=#C50000> Corre por tu vida YA </color>", false);
            }
            if (evento == 42)
            {
                ev.Player.ChangeRole(Role.SCIENTIST, false);
                ev.Player.PersonalBroadcast(2, " 100tífico ", false);
            }
            if (evento == 43)
            {
                ev.Player.SetAmmo(AmmoType.DROPPED_9, 999);
                ev.Player.PersonalBroadcast(2, "<color=#DF193D> 999 de munición tipo 9 </color>", false);
            }
            if (evento == 44)
            {
                ev.Player.SetAmmo(AmmoType.DROPPED_9, 0);
                ev.Player.PersonalBroadcast(2, "<color=#C50000> 0 de munición tipo 9 </color>", false);
            }
            if (evento == 45)
            {
                ev.Player.Teleport(Smod2.PluginManager.Manager.Server.Map.GetRandomSpawnPoint(Role.SCP_939_89));
                ev.Player.PersonalBroadcast(2, "<color=#DF193D> Que pasó? </color>", false);
            }
            if (evento == 46)
            {
                if (Vidaextra.ContainsKey(ev.Player.SteamId))
                {
                    if (Vidaextra[ev.Player.SteamId] > 0)
                    {
                        Vidaextra[ev.Player.SteamId] -= 1;
                    }
                    else { ev.Player.Kill(DamageType.FLYING); }
                }
                else { ev.Player.Kill(DamageType.FALLDOWN); }
                ev.Player.PersonalBroadcast(2, "<color=#C50000> F en el chat si no tenías vida extra </color>", false);
            }
            if (evento == 47)
            {
                ev.Player.GiveItem(ItemType.COIN);
                ev.Player.PersonalBroadcast(2, "<color=#DF193D> Moneda gratis </color>", false);
            }
            if (evento == 48)
            {
                ev.Player.GiveItem(ItemType.COIN);
                ev.Player.GiveItem(ItemType.COIN);
                ev.Player.PersonalBroadcast(2, "<color=#DF193D> 2 Moneda gratis </color>", false);
            }
            if (evento == 49)
            {
                ev.Player.GiveItem(ItemType.COIN);
                ev.Player.GiveItem(ItemType.COIN); ev.Player.GiveItem(ItemType.COIN); ev.Player.GiveItem(ItemType.COIN);
                ev.Player.GiveItem(ItemType.COIN); ev.Player.GiveItem(ItemType.COIN); ev.Player.GiveItem(ItemType.COIN); ev.Player.GiveItem(ItemType.COIN);
                ev.Player.GiveItem(ItemType.COIN); ev.Player.GiveItem(ItemType.COIN); ev.Player.GiveItem(ItemType.COIN); ev.Player.GiveItem(ItemType.COIN);
                ev.Player.GiveItem(ItemType.COIN); ev.Player.GiveItem(ItemType.COIN); ev.Player.GiveItem(ItemType.COIN); ev.Player.GiveItem(ItemType.COIN);
                ev.Player.GiveItem(ItemType.COIN); ev.Player.GiveItem(ItemType.COIN); ev.Player.GiveItem(ItemType.COIN);
                ev.Player.PersonalBroadcast(2, "<color=#DF193D> MUCHAS Moneda gratis </color>", false);
            }
            if (evento == 50)
            {
                ev.Player.ChangeRole(Role.SCP_106);
                ev.Player.PersonalBroadcast(2, "<color=#FF05FF> 106.exe started working </color>", false);
            }
            if (evento == 51)
            {
                ev.Player.SetHealth(1);
                ev.Player.PersonalBroadcast(2, "<color=#1928DF> Muerte súbita?? </color>", false);
            }
            if (evento == 52)
            {
                foreach (Player player in Smod2.PluginManager.Manager.Server.GetPlayers()) { player.SetHealth(1); }
                ev.Player.PersonalBroadcast(2, "<color=#1928DF> Todos 1 de vida MUAJAJAJJA </color>", false);
            }
            if (evento == 53)
            {
                foreach (Player player in Smod2.PluginManager.Manager.Server.GetPlayers()) { player.GiveItem(ItemType.FRAG_GRENADE); }
                ev.Player.PersonalBroadcast(2, "<color=#FF05FF> +1 frag a todos </color>", false);
            }
            if (evento == 57)
            {
                foreach (Player player in Smod2.PluginManager.Manager.Server.GetPlayers()) { player.GiveItem(ItemType.FLASHLIGHT); }
                ev.Player.PersonalBroadcast(2, "<color=#FF05FF> +1 flash a todos </color>", false);
            }
            if (evento == 54)
            {
                foreach (Player player in Smod2.PluginManager.Manager.Server.GetPlayers()) { player.GiveItem(ItemType.MICROHID); }
                ev.Player.PersonalBroadcast(2, "<color=#FF05FF> +1 Micro a todos </color>", false);
            }
            if (evento == 55)
            {
                foreach (Player player in Smod2.PluginManager.Manager.Server.GetPlayers()) { player.GiveItem(ItemType.FRAG_GRENADE); player.GiveItem(ItemType.FRAG_GRENADE); player.GiveItem(ItemType.FRAG_GRENADE); }
                ev.Player.PersonalBroadcast(2, "<color=#FF05FF> +3 frag a todos </color>", false);
            }
            if (evento == 56)
            {
                foreach (Player player in Smod2.PluginManager.Manager.Server.GetPlayers()) { player.GiveItem(ItemType.CUP); }
                ev.Player.PersonalBroadcast(2, "<color=#FF05FF> +1 cafe a todos </color>", false);
            }
            if (evento == 58)
            {

                ev.Player.PersonalBroadcast(2, " Nada jajaj ", false);
            }
            if (evento == 59)
            {
                ev.Player.Teleport(Smod2.PluginManager.Manager.Server.Map.GetRandomSpawnPoint(Role.SCP_106));
                ev.Player.PersonalBroadcast(2, " Y ahora que? ", false);
            }
            if (evento == 60)
            {

                   
                    if ((p == 4) || (p == 6) || (p == 128))
                    {
                        MEC.Timing.RunCoroutine(spectator(ev.Player), MEC.Segment.FixedUpdate);

                    }
                    else { MEC.Timing.RunCoroutine(spectator(ev.Player), 1); }
                    ev.Player.PersonalBroadcast(4, " en 60 segundos moriras sin importar nada, vidas extras, NADA ", false);
            }
            if (evento == 61)
            {
                foreach (Player player in Smod2.PluginManager.Manager.Server.GetPlayers()) { if (player.Name != ev.Player.Name)
                        {
                         
                            if ((p == 4) || (p == 6) || (p == 128))
                            {
                                MEC.Timing.RunCoroutine(spectator(ev.Player), MEC.Segment.FixedUpdate);

                            }
                            else { MEC.Timing.RunCoroutine(spectator(ev.Player), 1); }
                        } }

                ev.Player.PersonalBroadcast(4, " en 60 segundos todos moriran menos tu ", false);
            }
            if (evento == 62) { ev.Player.GiveItem(ItemType.MEDKIT); ev.Player.PersonalBroadcast(4, " Botiquín gratis ", false); }
            if (evento == 63)
            {
                ev.Player.ChangeRole(Role.SCP_939_89, false, false);
                ev.Player.PersonalBroadcast(2, "<color=#C50000> Hoy me siento mas perro que nunca </color>", false);
            }
            if (evento == 64)
            {
                ev.Player.ChangeRole(Role.SCP_939_53, false, false); ev.Player.SetHealth(1);
                ev.Player.PersonalBroadcast(2, "<color=#C50000> yo solo quería pienso </color>", false);
            }
            if (evento == 65)
            {
                ev.Player.GiveItem(ItemType.FLASHLIGHT);
                ev.Player.PersonalBroadcast(2, "<color=#DFDC19> Linterna gratis </color>", false);
            }
            if (evento == 66)
            {
                foreach (Player player in Smod2.PluginManager.Manager.Server.GetPlayers()) { player.GiveItem(ItemType.FLASHLIGHT); }
                ev.Player.PersonalBroadcast(2, "<color=#DFDC19> Linterna gratis para todos </color>", false);
            }
            if (evento == 67)
            {
                foreach (Player player in Smod2.PluginManager.Manager.Server.GetPlayers()) { ev.Player.AddHealth(-1); }
                ev.Player.PersonalBroadcast(2, "<color=#C50000> -[numero de jugadores] de salud </color>", false);
            }
            if (evento == 68)
            {
                foreach (Player player in Smod2.PluginManager.Manager.Server.GetPlayers()) { ev.Player.AddHealth(1); }
                ev.Player.PersonalBroadcast(2, "<color=#FF00FF> +[numero de jugadores] de salud </color>", false);
            }
            if (evento == 69)
            {
                foreach (Player player in Smod2.PluginManager.Manager.Server.GetPlayers()) { player.Teleport(ev.Player.GetPosition()); }
                ev.Player.PersonalBroadcast(2, "<color=#FF00FF> Todos, venid YA! </color>", false);
            }
            if (evento == 70)
            {
                foreach (Player player in Smod2.PluginManager.Manager.Server.GetPlayers()) { if (player.TeamRole.Role == Role.SPECTATOR) { player.ChangeRole(Role.NTF_LIEUTENANT); } }
                ev.Player.PersonalBroadcast(2, "<color=#FF00FF>TENIENTES ADELANTE </color>", false);
            }
            if (evento == 71)
            {
                foreach (Player player in Smod2.PluginManager.Manager.Server.GetPlayers()) { if (player.TeamRole.Role == Role.SPECTATOR) { player.ChangeRole(Role.CHAOS_INSURGENCY); } }
                ev.Player.PersonalBroadcast(2, "<color=#FF00FF>Chaos ADELANTE </color>", false);
            }
            if (evento == 72)
            {
                foreach (Player player in Smod2.PluginManager.Manager.Server.GetPlayers()) { if (player.TeamRole.Role == Role.SPECTATOR) { player.ChangeRole(Role.ZOMBIE); } }
                ev.Player.PersonalBroadcast(2, "<color=#C50000>Zombies?¿ ADELANTE </color>", false);
            }
            if (evento == 73)
            {
                foreach (Player player in Smod2.PluginManager.Manager.Server.GetPlayers()) { player.GiveItem(ItemType.LOGICER); }
                ev.Player.PersonalBroadcast(2, "<color=#C50000>Logicer para todos </color>", false);
            }
            if (evento == 74)
            {
                foreach (Player player in Smod2.PluginManager.Manager.Server.GetPlayers()) { player.GiveItem(ItemType.USP); }
                ev.Player.PersonalBroadcast(2, "<color=#C50000>USP para todos </color>", false);
            }
            if (evento == 75)
            {
                foreach (Player player in Smod2.PluginManager.Manager.Server.GetPlayers()) { player.GiveItem(ItemType.RADIO); }
                ev.Player.PersonalBroadcast(2, "<color=#FF00FF>Radio para todos </color>", false);
            }
            if (evento == 76)
            {
                ev.Destroy = true;
                ev.Player.PersonalBroadcast(2, "<color=#FF00FF>DEJAME PASAR SUSIA </color>", false);
            }
            if (evento == 77)
            {
                ev.Destroy = true;
                ev.Player.AddHealth(-80);
                ev.Player.PersonalBroadcast(4, "<color=#FF00FF>auch, romper puertas no es buena idea </color>", false);
            }
            if (evento == 78)
            {

                if (Vidaextra.ContainsKey(ev.Player.SteamId))
                {
                    if (Vidaextra[ev.Player.SteamId] > 0)
                    {
                        Vidaextra[ev.Player.SteamId] -= 1;
                    }
                    else { ev.Player.Kill(DamageType.WALL); }
                }
                else { ev.Player.Kill(DamageType.WALL); }
                ev.Destroy = true;
                ev.Player.PersonalBroadcast(4, "<color=#C50000>auch, romper puertas no es buena idea, puedes morir </color>", false);
            }
            if (evento == 79)
            {
                ev.Player.ChangeRole(Role.SCP_096, false);
                ev.Player.PersonalBroadcast(4, "LA DEPRESIÓN TE CONSUME", true);
            }
            if (evento == 80)
            {
                if (!Vidaextra.ContainsKey(ev.Player.SteamId)) { Vidaextra.Add(ev.Player.SteamId, 1); }
                if (Vidaextra.ContainsKey(ev.Player.SteamId)) { Vidaextra[ev.Player.SteamId] += 1; }
                ev.Player.PersonalBroadcast(4, "<color=#E40BD7> ♥ </color>", false);
            }
            if (evento == 81)
            {
                System.Random jugadores = new System.Random();
                int numero = jugadores.Next(0, Smod2.PluginManager.Manager.Server.NumPlayers);
                if (!Love.ContainsKey(ev.Player.SteamId)) { Love.Add(ev.Player.SteamId, Smod2.PluginManager.Manager.Server.GetPlayers()[numero].Name); }
                if (!Love.ContainsKey(ev.Player.SteamId)) { Love.Add(Smod2.PluginManager.Manager.Server.GetPlayers()[numero].SteamId, ev.Player.Name); }
                ev.Player.PersonalBroadcast(4, "<color=#E40BD7> ♥.♥ (te enamorastes de " + Smod2.PluginManager.Manager.Server.GetPlayers()[numero].Name + " y no le puedes hacer daño)</color>", false);
                Smod2.PluginManager.Manager.Server.GetPlayers()[numero].PersonalBroadcast(4, "<color=#E40BD7> ♥.♥ (te enamorastes de " + ev.Player.Name + "y no le puedes hacer daño)</color>", false);
            }
            if (evento == 82)
            {
                if (!Vidaextra.ContainsKey(ev.Player.SteamId)) { Vidaextra.Add(ev.Player.SteamId, 1); }
                if (Vidaextra.ContainsKey(ev.Player.SteamId)) { Vidaextra[ev.Player.SteamId] += 1; }
                ev.Player.PersonalBroadcast(4, "<color=#E40BD7> ♥ </color>", false);
            }
            if (evento == 83)
            {
                ev.Player.ChangeRole(Role.SCP_173, false, false);
                ev.Player.SetHealth(1);
                ev.Player.PersonalBroadcast(4, "<color=#C50000> RUNNING IN THE 90S </color>", false);
            }
            if (evento == 84)
            {
                ev.Destroy = true;
                ev.Player.PersonalBroadcast(4, "<color=#0BD4E4> Esta casi tan rota como mi corazón :,( </color>", false);
            }
            if (evento == 85)
            {
                System.Random jugadoress = new System.Random();
                int numero2 = jugadoress.Next(0, Smod2.PluginManager.Manager.Server.NumPlayers);
                Smod2.PluginManager.Manager.Server.GetPlayers()[numero2].Kill(DamageType.SCP_173);
                ev.Player.PersonalBroadcast(4, "<color=#0BD4E4>Jugador aleatorio se le a torcido el cuello</color>", false);
            }
            if (evento == 87)
            {
                ev.Destroy = true;
                ev.Player.GiveItem(ItemType.FRAG_GRENADE);
                ev.Player.PersonalBroadcast(4, "<color=#0BD4E4> al romper la puerta encontre una granada </color>", false);
            }
            if (evento == 88)
            {
                ev.Destroy = true;
                ev.Player.GiveItem(ItemType.DISARMER);
                ev.Player.PersonalBroadcast(4, "<color=#FF05FF> al romper la puerta encontre un disarmer </color>", false);
            }
            if (evento == 89)
            {
                ev.Destroy = true;
                ev.Player.GiveItem(ItemType.WEAPON_MANAGER_TABLET);
                ev.Player.PersonalBroadcast(4, "<color=#FF05FF> al romper la puerta encontre una tablet </color>", false);
            }
            if (evento == 90)
            {
                ev.Destroy = true;
                ev.Player.GiveItem(ItemType.E11_STANDARD_RIFLE); ;
                ev.Player.PersonalBroadcast(4, "<color=#FF05FF> al romper la puerta encontre una Fusil de asalto, jaja que cosas </color>", false);
            }
            if (evento == 91)
            {
                ev.Allow = false;
                ev.Player.GiveItem(ItemType.MICROHID); ;
                ev.Player.PersonalBroadcast(4, "<color=#FF05FF>la puerta te regalo una micro UwU </color>", false);
            }
            if (evento == 92)
            {
                ev.Player.AddHealth(10);
                ev.Player.PersonalBroadcast(4, "<color=#FF05FF> +10 de vida </color>", false);
            }
            if (evento == 93)
            {
                ev.Destroy = true;
                ev.Player.AddHealth(300);
                ev.Player.PersonalBroadcast(4, "<color=#FF05FF> +300 de vida pero a que precio asesino de puertas </color>", false);
            }
            if (evento == 94)
            {
                ev.Destroy = true;

                ev.Player.PersonalBroadcast(4, "<color=#FF05FF> QUE HAS HECHO?!! </color>", false);
            }
            if (evento == 95)
            {
                ev.Door.LockCooldown = 10;
                ev.Door.Locked = true;
                ev.Player.PersonalBroadcast(4, "<color=#FF05FF> upss, no se abre </color>", false);
            }
            if (evento == 96)
            {
                ev.Player.GiveItem(ItemType.DROPPED_7);
                ev.Player.PersonalBroadcast(4, "<color=#FF05FF> Munición? xD </color>", false);
            }
            if (evento == 97)
            {
                ev.Player.GiveItem(ItemType.DROPPED_9);
                ev.Player.PersonalBroadcast(4, "<color=#FF05FF> Munición? xD </color>", false);
            }
            if (evento == 98)
            {
                ev.Player.GiveItem(ItemType.DROPPED_5);
                ev.Player.PersonalBroadcast(4, "<color=#FF05FF> Munición? xD </color>", false);
            }
            if (evento == 99)
            {

                ev.Player.PersonalBroadcast(4, "<color=#FF05FF> GANASTE JAJA </color>", false);
                if (Love.ContainsKey(ev.Player.SteamId)) { Smod2.PluginManager.Manager.Server.Map.Broadcast(10, ev.Player.Name + " ES EL GANADOR JAJAAAA y su enamorado " + Love[ev.Player.SteamId] + " tambien", false); }
                else
                {
                    Smod2.PluginManager.Manager.Server.Map.Broadcast(10, ev.Player.Name + " ES EL GANADO JAJAAAA", false);
                }

            }
            if (evento == 100)
            {

                ev.Player.PersonalBroadcast(4, "<color=#FF05FF> F, no pasó nada </color>", false);
            }

               
                if ((p == 4) || (p == 6) || (p == 128))
                {
                    MEC.Timing.RunCoroutine(Cooldownw(ev.Player), MEC.Segment.FixedUpdate);

                }
                else { MEC.Timing.RunCoroutine(Cooldownw(ev.Player), 1); }
            }
        }

        public void OnPlayerDie(PlayerDeathEvent ev)
        {
            System.Random muertos = new System.Random();
            int eventod = muertos.Next(0, 20);

            if ((eventod == 1) || (eventod == 0))
            {
                ev.SpawnRagdoll = false;
                ev.Player.PersonalBroadcast(5, "No te preocupes, nadie sabrá que has muerto puesto que escondí tu cuerpo", false);
            }
            if ((eventod == 2))
            {
                ev.Killer.SetAmmo(AmmoType.DROPPED_9, ev.Killer.GetAmmo(AmmoType.DROPPED_9) + 100);
                ev.Killer.PersonalBroadcast(5, "Ammo Up", false);
            }
            if ((eventod == 3))
            {
                ev.Killer.SetAmmo(AmmoType.DROPPED_7, ev.Killer.GetAmmo(AmmoType.DROPPED_7) + 100);
                ev.Killer.PersonalBroadcast(5, "Ammo Up", false);
            }
            if ((eventod == 4))
            {
                ev.Killer.SetAmmo(AmmoType.DROPPED_5, ev.Killer.GetAmmo(AmmoType.DROPPED_5) + 100);
                ev.Killer.PersonalBroadcast(5, "Ammo Up", false);
            }
            if ((eventod == 5))
            {
                ev.Killer.SetAmmo(AmmoType.DROPPED_5, ev.Killer.GetAmmo(AmmoType.DROPPED_5) - 100);
                ev.Killer.PersonalBroadcast(5, "Ammo down", false);
            }
            if ((eventod == 6))
            {
                ev.Killer.SetAmmo(AmmoType.DROPPED_7, ev.Killer.GetAmmo(AmmoType.DROPPED_7) - 100);
                ev.Killer.PersonalBroadcast(5, "Ammo down", false);
            }
            if ((eventod == 7))
            {
                ev.Killer.SetAmmo(AmmoType.DROPPED_9, ev.Killer.GetAmmo(AmmoType.DROPPED_9) - 100);
                ev.Killer.PersonalBroadcast(5, "Ammo down", false);
            }
            if ((eventod == 8))
            {
  
                ev.Killer.SetAmmo(AmmoType.DROPPED_5, ev.Killer.GetAmmo(AmmoType.DROPPED_5) +20);
                ev.Killer.SetAmmo(AmmoType.DROPPED_7, ev.Killer.GetAmmo(AmmoType.DROPPED_7) + 20);
                ev.Killer.SetAmmo(AmmoType.DROPPED_9, ev.Killer.GetAmmo(AmmoType.DROPPED_9) + 20);
                ev.Killer.AddHealth(20);
                ev.Killer.PersonalBroadcast(5, "Has alcanzado el nivel 2, sonidito de pokemon subiendo de nivel...", false);
            }
            if ((eventod == 11))
            {

                ev.Killer.Kill();
                ev.Killer.PersonalBroadcast(5, "Mala idea...", false);
            }
            if ((eventod == 13))
            {

                ev.Killer.AddHealth(-50);
                ev.Killer.PersonalBroadcast(5, "Eso esta feo...", false);
            }
            if ((eventod == 15))
            {

                ev.Killer.AddHealth(+50);
                ev.Killer.PersonalBroadcast(5, "=)", false);
            }
            if ((eventod == 17))
            {

                ev.Killer.AddHealth(+250);
                ev.Killer.PersonalBroadcast(5, "=D", false);
            }
            if ((eventod == 19))
            {
                if (Vidaextra.ContainsKey(ev.Killer.SteamId)) { Vidaextra[ev.Killer.SteamId] += 1; }
                if (!Vidaextra.ContainsKey(ev.Killer.SteamId)) { Vidaextra.Add(ev.Killer.SteamId, 1); }
                
                ev.Killer.PersonalBroadcast(5, "Robaste un vida, y ahora te pertenece...", false);
            }

        }

        public void OnPlayerHurt(PlayerHurtEvent ev)
        {
            if((Love.ContainsKey(ev.Player.SteamId))&&(Love[ev.Player.SteamId] == ev.Attacker.Name))
            {
                ev.Damage = 0;
            }

            if (Vidaextra.ContainsKey(ev.Player.SteamId))
            {
                if ((Vidaextra[ev.Player.SteamId] > 0)&&(ev.Player.GetHealth() <= ev.Damage))
                {
                    Vidaextra[ev.Player.SteamId] -= 1;
                }
               
            }
            
        }

        public void OnSetRole(PlayerSetRoleEvent ev)
        {
            if (!Cooldown.ContainsKey(ev.Player.SteamId)) { Cooldown.Add(ev.Player.SteamId, true); }
        }

        public void OnWaitingForPlayers(WaitingForPlayersEvent ev)
        {
            Love.Clear();
            Vidaextra.Clear();
        }

        public void On079Elevator(Player079ElevatorEvent ev)
        {
            System.Random muertos = new System.Random();
            int eventod = muertos.Next(0, 15);
            if((eventod == 0)||(eventod == 1)) 
            {
                ev.Player.ChangeRole(Role.CHAOS_INSURGENCY);
            }
            if ((eventod == 2) || (eventod == 3))
            {
                ev.Player.ChangeRole(Role.CLASSD);
            }
            if ((eventod == 4) || (eventod == 5))
            {
                ev.Player.ChangeRole(Role.NTF_COMMANDER);
            }
            if ((eventod == 6) || (eventod == 7))
            {
                foreach (Player player in Smod2.PluginManager.Manager.Server.GetPlayers())
                { player.ThrowGrenade(GrenadeType.FLASHBANG, true, new Vector(0, 0, 0), true, player.GetPosition(), false,0);
                    player.ThrowGrenade(GrenadeType.FRAG_GRENADE, true, new Vector(0, 0, 0), true, player.GetPosition(), false, 0);
                }
            }
            if ((eventod == 8) || (eventod == 9))
            {
                ev.Player.ChangeRole(Role.FACILITY_GUARD);
            }
            if ((eventod == 14))
            {
                ev.Player.Kill();
            }
            if ((eventod == 15))
            {
                ev.Player.Scp079Data.MaxAP = 99999;
            }
        }
    }
}
