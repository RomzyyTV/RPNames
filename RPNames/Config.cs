using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;
using PlayerRoles;

namespace RPNames;
public class Config : IConfig
{
    [Description("Is the plugin enabled?")]
    public bool IsEnabled { get; set; } = true;

    [Description("Is the Debug on?")]
    public bool Debug { get; set; } = false;

    [Description("Random numbers for instances of 939 or 049?")]
    
    public bool randnum { get; set; } = false;
    
    [Description("Should people lose nick when they turn into a tutorial?")]
    public bool TutorialNick { get; set; } = true;

    [Description("Should Class-D be D-#### (true) or should it follow the other names with Title + Name (false)?")]
    public bool DboisSetting { get; set; } = true;

    [Description("Should SCPs have their SCP as a name (true) or should they be hidden as a D-Class (false)?")]
    public bool SCPSetting { get; set; } = true;

    [Description("Should Zombies NOT have names? (THIS OVERRIDES SCPSETTINGS)")]
    public bool ZombieNames { get; set; } = false;
    
    [Description("Use only human_names (dbois setting must be on!)?")]
    public bool randomnames { get; set; } = false;
    
    [Description("Should nicknames reset on death?")]
    public bool DeathReset { get; set; } = true;

    [Description("Should a player be told their nickname?")]
    public bool ShowNick { get; set; } = true;

    [Description("Should a player have there real name after their nickname?")]
    public bool ShowRealName { get; set; } = false;

    [Description("A dictionary with classes and their title")]
    public Dictionary<RoleTypeId, string> ClassTitles { get; set; } = new Dictionary<RoleTypeId, string>
    {
        {
            RoleTypeId.ClassD, "D-"
        },
        {
            RoleTypeId.Scientist, "Dr."
        },
        {
            RoleTypeId.FacilityGuard, "Security Officer"
        },
        {
            RoleTypeId.NtfCaptain, "Commander"
        },
        {
            RoleTypeId.NtfPrivate, "Cadet"
        },
        {
            RoleTypeId.NtfSergeant, "Lieutenant"
        },
        {
            RoleTypeId.NtfSpecialist, "Field Agent"
        },
        {
            RoleTypeId.ChaosConscript, "Agent of Chaos"
        },
        {
            RoleTypeId.ChaosMarauder, "Agent of Chaos"
        },
        {
            RoleTypeId.ChaosRepressor, "Agent of Chaos"
        },
        {
            RoleTypeId.ChaosRifleman, "Agent of Chaos"
        },
        {
            RoleTypeId.Scp049, "SCP-049"
        },
        {
            RoleTypeId.Scp0492, "SCP-049-2"
        },
        {
            RoleTypeId.Scp079, "SCP-079"
        },
        {
            RoleTypeId.Scp096, "SCP-096"
        },
        {
            RoleTypeId.Scp106, "SCP-106"
        },
        {
            RoleTypeId.Scp173, "SCP-173"
        },
        {
            RoleTypeId.Scp939, "SCP-939"
        },
        {
            RoleTypeId.Scp3114, "SCP-3114"
        },
    };

    [Description("The list of names to be given. (Leave empty for default, if you want to make your own list, look at readme) ")]
    public List<string> HumanNames { get; set; } = new List<string> {"Woodson", "Winthrop", "Wall", "Wight", "Webb", "Woodard", "Wixx", "Wong", "Whesker", "Wolfenstein", "Rooney", "Russo", "Rude", "Roland", "Reader", "Renshaw", "Rossi", "Riddle", "Ripa", "Richter", "Rosenberg", "Romo", "Ramirez", "Reagan", "Rainwater", "Romirez", "Riker","Abbington", "Axworthy", "Arora", "Tray", "R.Tey", "A.Clef", "Amathor", "Jesus", "Joker", "Lemon", "Boucher", "Enes"};

    }