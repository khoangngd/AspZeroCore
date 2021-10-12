using System;
using System.Collections.Generic;
using Castle.Components.DictionaryAdapter;
using tls.demo.Friendships.Dto;

namespace tls.demo.Chat.Dto
{
    public class GetUserChatFriendsWithSettingsOutput
    {
        public DateTime ServerTime { get; set; }
        
        public List<FriendDto> Friends { get; set; }

        public GetUserChatFriendsWithSettingsOutput()
        {
            Friends = new EditableList<FriendDto>();
        }
    }
}