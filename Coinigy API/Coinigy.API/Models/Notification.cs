using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class Notification
    {
        [DeserializeAs(Name = "notification_vars")]
        public string NotificationVars { get; set; }

        [DeserializeAs(Name = "notification_title_vars")]
        public string NotificationTitleVars { get; set; }

        [DeserializeAs(Name = "notification_time_added")]
        public string NotificationTimeAdded { get; set; }

        [DeserializeAs(Name = "notification_type_title")]
        public string NotificationTypeTitle { get; set; }

        [DeserializeAs(Name = "notification_type_message")]
        public string NotificationTypeMessage { get; set; }

        [DeserializeAs(Name = "notification_style")]
        public string NotificationStyle { get; set; }

        [DeserializeAs(Name = "notification_sound")]
        public string NotificationSound { get; set; }

        [DeserializeAs(Name = "notification_sound_id")]
        public string NotificationSoundId { get; set; }
    }
}
