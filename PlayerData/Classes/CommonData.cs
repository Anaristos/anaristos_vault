using System.Collections.Generic;

namespace PlayerData.Classes
{
    public static class CommonData
    {
        internal static readonly string[] states = new string[] {  "LOGIN    ", "MOTD     ", "STANDING ", "AFK      ",
                                                                  "NOTE     ", "EDIT     ", "PROMPT   ", "IN COMBAT",
                                                                  "SLEEPING ", "         ", "RESTING  ", "MOVING   " };

        internal static readonly string[] scolors = new string[] { "#FFFFFFFF", "#FFFFFFFF", "#FF00FF7F", "#FFA9A9A9",
                                                                  "#FF00FFFF", "#FF00FFFF", "#FF00FFFF", "#FFFF0000",
                                                                  "#FFDA70D6", "#FFFFFFFF", "#FFDA70D6", "#FFFFFF00" };

        internal static readonly string[] formats = new string[] { "{0,2:#0}",   "{0,3:##0}", "{0,4:###0}",  "{0,5:####0}",
                                                                   "{0,3:##0}%", "{0,15:n0}", "{0,7:######0}" };
    }
}
