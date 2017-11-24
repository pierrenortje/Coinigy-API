#region License
// Copyright (c) 2017 Pierre Nortje
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

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
