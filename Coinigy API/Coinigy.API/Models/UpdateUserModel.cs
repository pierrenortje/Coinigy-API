﻿#region License
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

using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class UpdateUserModel
    {
        [SerializeAs(Name = "first_name")]
        public string FirstName { get; set; }

        [SerializeAs(Name = "last_name")]
        public string LastName { get; set; }

        [SerializeAs(Name = "company")]
        public string Company { get; set; }

        [SerializeAs(Name = "phone")]
        public string Phone { get; set; }

        [SerializeAs(Name = "street1")]
        public string Street1 { get; set; }

        [SerializeAs(Name = "street2")]
        public string Street2 { get; set; }

        [SerializeAs(Name = "city")]
        public string City { get; set; }

        [SerializeAs(Name = "state")]
        public string State { get; set; }

        [SerializeAs(Name = "zip")]
        public string Zip { get; set; }

        [SerializeAs(Name = "country")]
        public string Country { get; set; }
    }
}
