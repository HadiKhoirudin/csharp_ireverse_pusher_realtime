﻿namespace iReverse_Pusher_Realtime
{
    internal class ChatMember
    {
        public ChatMember()
        {
        }

        public ChatMember(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
