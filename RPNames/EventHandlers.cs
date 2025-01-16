using Exiled.API.Features;
using PlayerRoles;
using System;
using Exiled.Events.EventArgs.Player;

namespace RPNames;

public class EventHandlers
{
    Random random = new Random();

    public void OnPlayerChangeRole(ChangingRoleEventArgs ev)
    {
        int randnumber = random.Next(1000, 9999);
        
        int RandomNameNumber = random.Next(1, Plugin.Singleton.NickNames.Count - 1);
        
        if (ev.NewRole == RoleTypeId.Tutorial)
        {
            if (Plugin.Singleton.Config.TutorialNick)
            {
                ev.Player.DisplayNickname = null;
                return;
            }
        }
        
        if (ev.NewRole == RoleTypeId.Scp0492 && Plugin.Singleton.Config.ZombieNames)
        {
            ev.Player.DisplayNickname = null;
            if (Plugin.Singleton.Config.ShowNick)
            {
                ev.Player.ShowHint(ev.Player.DisplayNickname);
            }
            return;
        }
        
        if (ev.NewRole.GetTeam() != Team.SCPs && Plugin.Singleton.Config.ClassTitles.ContainsKey(ev.NewRole))
        {
            if (Plugin.Singleton.Config.randomnames && ev.NewRole != RoleTypeId.ClassD && Plugin.Singleton.Config.DboisSetting)
            {

                ev.Player.DisplayNickname = $"{Plugin.Singleton.NickNames[RandomNameNumber]}";
                
                if (Plugin.Singleton.Config.ShowRealName)
                {
                    ev.Player.DisplayNickname = $"{Plugin.Singleton.NickNames[RandomNameNumber]} ({ev.Player.Nickname})";
                }
                
                if (Plugin.Singleton.Config.ShowNick)
                {
                    ev.Player.ShowHint(ev.Player.DisplayNickname);
                }
                return;
            }
            
            if (Plugin.Singleton.Config.ShowRealName && ev.NewRole != RoleTypeId.ClassD && Plugin.Singleton.Config.ShowRealName)
            { 
                ev.Player.DisplayNickname = $"{Plugin.Singleton.Config.ClassTitles[ev.NewRole]} {Plugin.Singleton.NickNames[RandomNameNumber]} ({ev.Player.Nickname})";
                if (Plugin.Singleton.Config.ShowNick)
                {
                    ev.Player.ShowHint(ev.Player.DisplayNickname);
                }
                return;
            }
            
            ev.Player.DisplayNickname = $"{Plugin.Singleton.Config.ClassTitles[ev.NewRole]} {Plugin.Singleton.NickNames[RandomNameNumber]}";
               
            if (Plugin.Singleton.Config.ShowNick)
            {
                ev.Player.ShowHint(ev.Player.DisplayNickname);
            }
            
            
            if (ev.NewRole == RoleTypeId.ClassD && Plugin.Singleton.Config.DboisSetting)
            {
                    ev.Player.DisplayNickname = $"{$"{Plugin.Singleton.Config.ClassTitles[ev.NewRole]}"+randnumber}";
                    if (Plugin.Singleton.Config.ShowRealName)
                    {
                        ev.Player.DisplayNickname = $"{$"{Plugin.Singleton.Config.ClassTitles[ev.NewRole]}"+randnumber} ({ev.Player.Nickname})";
                    }
                    if (Plugin.Singleton.Config.ShowNick)
                    {
                        ev.Player.ShowHint(ev.Player.DisplayNickname);
                    }
            }
        }
        
        if (ev.NewRole.GetTeam() == Team.SCPs && Plugin.Singleton.Config.ClassTitles.ContainsKey(ev.NewRole))
        {
            if (Plugin.Singleton.Config.SCPSetting.Equals(false))
            {
                    if (Plugin.Singleton.Config.ShowRealName)
                    {
                        ev.Player.DisplayNickname = $"D-{randnumber} ({ev.Player.Nickname})";
                           
                        if (Plugin.Singleton.Config.ShowNick)
                        {
                            ev.Player.ShowHint(ev.Player.DisplayNickname);
                        }
                        return;
                    }
                    ev.Player.DisplayNickname = $"D-{randnumber}";
                       
                    if (Plugin.Singleton.Config.ShowNick)
                    {
                        ev.Player.ShowHint(ev.Player.DisplayNickname);
                    }
                    return;
            }
            
            if (Plugin.Singleton.Config.ShowRealName)
            {
                if (Plugin.Singleton.Config.randnum && ev.NewRole == RoleTypeId.Scp049 || ev.NewRole == RoleTypeId.Scp939)
                {
                    int randnumberab = random.Next(1, 700);
                    Log.Info("generated random num");
                    ev.Player.DisplayNickname = $"{Plugin.Singleton.Config.ClassTitles[ev.NewRole]}-{randnumberab} ({ev.Player.Nickname})";
                    Log.Info("setted display nickname");
                    
                    if (Plugin.Singleton.Config.ShowNick)
                    {
                        ev.Player.ShowHint(ev.Player.DisplayNickname);
                        Log.Info("showed the nickname");
                    }
                    return;
                }
                
                ev.Player.DisplayNickname = $"{Plugin.Singleton.Config.ClassTitles[ev.NewRole]} ({ev.Player.Nickname})";
                if (Plugin.Singleton.Config.ShowNick)
                {
                    ev.Player.ShowHint(ev.Player.DisplayNickname);
                }
                return;
            }
            ev.Player.DisplayNickname = $"{Plugin.Singleton.Config.ClassTitles[ev.NewRole]}";
            if (Plugin.Singleton.Config.ShowNick)
            {
                ev.Player.ShowHint(ev.Player.DisplayNickname);
            }
        }
    }
    
    public void OnPlayerDeath(DiedEventArgs ev)
    {
        if (Plugin.Singleton.Config.DeathReset)
        {
            ev.Player.DisplayNickname = null;
        }
    }
}