﻿namespace PepperDash.Essentials.Core.Devices.Codec

{
    public enum eCodecCallDirection
    {
        Unknown = 0, Incoming, Outgoing
    }

    public class CodecCallDirection
    {
        /// <summary>
        /// Takes the Cisco call type and converts to the matching enum
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static eCodecCallDirection ConvertToDirectionEnum(string s)
        {
            switch (s.ToLower())
            {
                case "incoming":
                    {
                        return eCodecCallDirection.Incoming;
                    }
                case "outgoing":
                    {
                        return eCodecCallDirection.Outgoing;
                    }
                default:
                    return eCodecCallDirection.Unknown;
            }

        }

    }
}