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

using Newtonsoft.Json;

namespace Coinigy.API.Models
{
    public class NotificationDataItem
    {
        [JsonProperty("pinned")]
        public bool Pinned { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }

        [JsonProperty("message_vars")]
        public string MessageVars { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("notification_id")]
        public long NotificationId { get; set; }

        [JsonProperty("sound_id")]
        public string SoundId { get; set; }

        [JsonProperty("sound")]
        public bool Sound { get; set; }

        [JsonProperty("sound_override")]
        public string SoundOverride { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("title_vars")]
        public string TitleVars { get; set; }

        [JsonProperty("type")]
        public long Type { get; set; }
    }
}
