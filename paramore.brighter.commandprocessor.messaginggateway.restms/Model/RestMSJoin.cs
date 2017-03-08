﻿// ***********************************************************************
// Assembly         : paramore.brighter.restms.core
// Author           : ian
// Created          : 11-05-2014
//
// Last Modified By : ian
// Last Modified On : 11-05-2014
// ***********************************************************************
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

#region Licence
/* The MIT License (MIT)
Copyright © 2014 Ian Cooper <ian_hammond_cooper@yahoo.co.uk>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the “Software”), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE. */

#endregion

using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Paramore.Brighter.MessagingGateway.RESTMS.Model
{
    [DataContract(Name = "join"), XmlRoot(ElementName = "join", Namespace = "http://www.restms.org/schema/restms")]
    public class RestMSJoin
    {
        [DataMember(Name = "name"), XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [DataMember(Name = "type"), XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [DataMember(Name = "address"), XmlAttribute(AttributeName = "address")]
        public string Address { get; set; }

        [DataMember(Name = "feed"), XmlAttribute(AttributeName = "feed")]
        public string Feed { get; set; }
    }
}