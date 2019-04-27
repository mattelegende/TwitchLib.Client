﻿using TwitchLib.Client.Models.Internal;

namespace TwitchLib.Client.Models.Builders
{
    public sealed class SubscriberBuilder : SubscriberBaseBuilder, IBuilder<Subscriber>, IFromIrcMessageBuilder<Subscriber>
    {
        public SubscriberBuilder()
        {
        }

        public static new SubscriberBuilder Create()
        {
            return new SubscriberBuilder();
        }

        public Subscriber BuildFromIrcMessage(IrcMessage ircMessage)
        {
            return new Subscriber(ircMessage);
        }

        Subscriber IBuilder<Subscriber>.Build()
        {
            return (Subscriber)Build();
        }

        public override SubscriberBase Build()
        {
            return new Subscriber(
                Badges,
                ColorHex,
                Color,
                DisplayName,
                EmoteSet,
                Id,
                Login,
                SystemMessage,
                ParsedSystemMessage,
                ResubMessage,
                SubscriptionPlan,
                SubscriptionPlanName,
                RoomId,
                UserId,
                IsModerator,
                IsTurbo,
                IsSubscriber,
                IsPartner,
                TmiSentTs,
                UserType,
                RawIrc,
                Channel);
        }
    }
}
