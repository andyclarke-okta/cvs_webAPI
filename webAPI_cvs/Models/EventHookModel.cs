using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPI_allDemo_core31.Models
{
    public class EventHookRequest
    {
        public string eventType { get; set; }
        public string eventTypeVersion { get; set; }
        public string cloudEventsVersion { get; set; }
        public string source { get; set; }
        public string eventId { get; set; }
        public EventData1 data { get; set; }
        public DateTime eventTime { get; set; }
        public string contentType { get; set; }
    }

    public class EventData1
    {
        public Event[] events { get; set; }
    }

    public class Event
    {
        public string uuid { get; set; }
        public DateTime published { get; set; }
        public string eventType { get; set; }
        public string version { get; set; }
        public string displayMessage { get; set; }
        public string severity { get; set; }
        public Client1 client { get; set; }
        public Actor actor { get; set; }
        public Outcome outcome { get; set; }
        public Target[] target { get; set; }
        public Transaction transaction { get; set; }
        public Debugcontext1 debugContext { get; set; }
        public string legacyEventType { get; set; }
        public Authenticationcontext authenticationContext { get; set; }
        public Securitycontext securityContext { get; set; }
    }

    public class Client1
    {
        public Useragent userAgent { get; set; }
        public string zone { get; set; }
        public string device { get; set; }
        public string ipAddress { get; set; }
        public Geographicalcontext geographicalContext { get; set; }
        public Ipchain[] ipChain { get; set; }
    }

    public class Useragent
    {
        public string rawUserAgent { get; set; }
        public string os { get; set; }
        public string browser { get; set; }
    }

    public class Geographicalcontext
    {
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
        public Geolocation geolocation { get; set; }
    }

    public class Geolocation
    {
        public float lat { get; set; }
        public float lon { get; set; }
    }

    public class Ipchain
    {
        public string ip { get; set; }
        public Geographicalcontext1 geographicalContext { get; set; }
        public string version { get; set; }
    }

    public class Geographicalcontext1
    {
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
        public Geolocation1 geolocation { get; set; }
    }

    public class Geolocation1
    {
        public float lat { get; set; }
        public float lon { get; set; }
    }

    public class Actor
    {
        public string id { get; set; }
        public string type { get; set; }
        public string alternateId { get; set; }
        public string displayName { get; set; }
    }

    public class Outcome
    {
        public string result { get; set; }
    }

    public class Transaction
    {
        public string type { get; set; }
        public string id { get; set; }
        public Detail detail { get; set; }
    }

    public class Detail
    {
    }

    public class Debugcontext1
    {
        public Debugdata debugData { get; set; }
    }

    public class Debugdata
    {
        public string requestId { get; set; }
        public string threatSuspected { get; set; }
        public string requestUri { get; set; }
        public string changedAttributes { get; set; }
        public string targetEventHookIds { get; set; }
        public string url { get; set; }
    }

    public class Authenticationcontext
    {
        public int authenticationStep { get; set; }
        public string externalSessionId { get; set; }
    }

    public class Securitycontext
    {
        public int asNumber { get; set; }
        public string asOrg { get; set; }
        public string isp { get; set; }
        public string domain { get; set; }
        public bool isProxy { get; set; }
    }

    public class Target
    {
        public string id { get; set; }
        public string type { get; set; }
        public string alternateId { get; set; }
        public string displayName { get; set; }
    }
}
