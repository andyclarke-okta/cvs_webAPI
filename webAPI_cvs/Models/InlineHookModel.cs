using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPI_allDemo_core31.Models
{
    /// Import Hook
    public class ImportCallbackResponse
    {
        public List<Command> commands { get; set; }
    }

    public class Command
    {
        public string type { get; set; }
        public ActionValue value { get; set; }
    }

    public class ActionValue
    {
        public string result { get; set; }
    }



    public class ImportCallbackRequest
    {
        public string source { get; set; }
        public string eventId { get; set; }
        public DateTime eventTime { get; set; }
        public EventData data { get; set; }
        public string eventTypeVersion { get; set; }
        public string cloudEventVersion { get; set; }
        public string eventType { get; set; }
        public string contentType { get; set; }
    }

    public class EventData
    {
        public Context context { get; set; }
        public Action action { get; set; }
        public Appuser appUser { get; set; }
        public User user { get; set; }
    }

    public class Context
    {
        public List<string> conflicts { get; set; }
        public Application application { get; set; }
        public Job job { get; set; }
        public List<object> matches { get; set; }
        public List<string> policy { get; set; }
    }

    public class Application
    {
        public string name { get; set; }
        public string id { get; set; }
        public string label { get; set; }
        public string status { get; set; }
    }

    public class Job
    {
        public string id { get; set; }
        public string type { get; set; }
    }

    public class Action
    {
        public string result { get; set; }
    }

    public class Appuser
    {
        public AppUserProfile profile { get; set; }
    }

    public class AppUserProfile
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public object mobilePhone { get; set; }
        public string accountType { get; set; }
        public object secondEmail { get; set; }
        public object failProvisioning { get; set; }
        public object failDeprovisioning { get; set; }
        public string externalId { get; set; }
        public List<string> groups { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
    }

    public class User
    {
        public UserProfile profile { get; set; }
    }

    public class UserProfile
    {
        public string lastName { get; set; }
        public object zipCode { get; set; }
        public object city { get; set; }
        public object secondEmail { get; set; }
        public object postAddress { get; set; }
        public string login { get; set; }
        public string firstName { get; set; }
        public object primaryPhone { get; set; }
        public object mobilePhone { get; set; }
        public object streetAddress { get; set; }
        public object countryCode { get; set; }
        public object typeId { get; set; }
        public object state { get; set; }
        public string email { get; set; }
    }

    /// Password Hook

    public class PasswordHookRequest
    {
        public string eventId { get; set; }
        public DateTime eventTime { get; set; }
        public string eventType { get; set; }
        public string eventTypeVersion { get; set; }
        public string contentType { get; set; }
        public string cloudEventVersion { get; set; }
        public string source { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public Context3 context { get; set; }
        public Action3 action { get; set; }
    }

    public class Context3
    {
        public Request3 request { get; set; }
        public Credential credential { get; set; }
    }

    public class Request3
    {
        public string id { get; set; }
        public string method { get; set; }
        public Url3 url { get; set; }
        public string ipAddress { get; set; }
    }

    public class Url3
    {
        public string value { get; set; }
    }

    public class Credential
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    public class Action3
    {
        public string credential { get; set; }
    }




    //OIDC
    public class TokenCallbackRequest
    {
        public string eventTypeVersion { get; set; }
        public string cloudEventVersion { get; set; }
        public string eventType { get; set; }
        public string contentType { get; set; }
        public string source { get; set; }
        public string eventId { get; set; }
        public DateTime eventTime { get; set; }
        public Data1 data { get; set; }
    }

    public class Data1
    {
        public Context1 context { get; set; }
        public Tokens tokens { get; set; }
    }

    public class Context1
    {
        public Request request { get; set; }
        public Protocol protocol { get; set; }
        public Session1 session { get; set; }
        public User1 user { get; set; }
        public Policy policy { get; set; }
    }

    public class Request
    {
        public string id { get; set; }
        public string method { get; set; }
        public Url url { get; set; }
        public string ipAddress { get; set; }
    }

    public class Url
    {
        public string value { get; set; }
    }

    public class Protocol
    {
        public string type { get; set; }
        public Request1 request { get; set; }
        public Issuer issuer { get; set; }
        public Client client { get; set; }
    }

    public class Request1
    {
        public string scope { get; set; }
        public string state { get; set; }
        public string redirect_uri { get; set; }
        public string response_mode { get; set; }
        public string response_type { get; set; }
        public string client_id { get; set; }
    }

    public class Issuer
    {
        public string uri { get; set; }
    }

    public class Client
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Session1
    {
        public string id { get; set; }
        public string userId { get; set; }
        public string login { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime expiresAt { get; set; }
        public string status { get; set; }
        public DateTime lastPasswordVerification { get; set; }
        public DateTime lastFactorVerification { get; set; }
        public string[] amr { get; set; }
        public Idp1 idp { get; set; }
        public bool mfaActive { get; set; }
    }

    public class Idp1
    {
        public string id { get; set; }
        public string type { get; set; }
    }

    public class User1
    {
        public string id { get; set; }
        public DateTime passwordChanged { get; set; }
        public Profile2 profile { get; set; }
        public _Links2 _links { get; set; }
    }

    public class Profile2
    {
        public string login { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string locale { get; set; }
        public string timeZone { get; set; }
    }

    public class _Links2
    {
        public Groups groups { get; set; }
        public Factors factors { get; set; }
    }

    public class Groups
    {
        public string href { get; set; }
    }

    public class Factors
    {
        public string href { get; set; }
    }

    public class Policy
    {
        public string id { get; set; }
        public Rule rule { get; set; }
    }

    public class Rule
    {
        public string id { get; set; }
    }

    public class Tokens
    {
        public Access_Token access_token { get; set; }
        public Id_Token id_token { get; set; }
    }

    public class Access_Token
    {
        public Claims claims { get; set; }
        public Lifetime lifetime { get; set; }
        public Scopes scopes { get; set; }
    }

    public class Claims
    {
        public int ver { get; set; }
        public string jti { get; set; }
        public string iss { get; set; }
        public string aud { get; set; }
        public string cid { get; set; }
        public string uid { get; set; }
        public string sub { get; set; }
        public string patientId { get; set; }
        public object[] appProfile { get; set; }
        public string claim1 { get; set; }
    }

    public class Lifetime
    {
        public int expiration { get; set; }
    }

    public class Scopes
    {
        public ProvidersRead providersread { get; set; }
        public Address2 address { get; set; }
        public Phone phone { get; set; }
        public Openid openid { get; set; }
        public Profile3 profile { get; set; }
        public Email email { get; set; }
    }

    public class ProvidersRead
    {
        public string id { get; set; }
        public string action { get; set; }
    }

    public class Address2
    {
        public string id { get; set; }
        public string action { get; set; }
    }

    public class Phone
    {
        public string id { get; set; }
        public string action { get; set; }
    }

    public class Openid
    {
        public string id { get; set; }
        public string action { get; set; }
    }

    public class Profile3
    {
        public string id { get; set; }
        public string action { get; set; }
    }

    public class Email
    {
        public string id { get; set; }
        public string action { get; set; }
    }

    public class Id_Token
    {
        public Claims1 claims { get; set; }
        public Lifetime1 lifetime { get; set; }
    }

    public class Claims1
    {
        public string sub { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int ver { get; set; }
        public string iss { get; set; }
        public string aud { get; set; }
        public string jti { get; set; }
        public string[] amr { get; set; }
        public string idp { get; set; }
        public string nonce { get; set; }
        public string preferred_username { get; set; }
        public int auth_time { get; set; }
    }

    public class Lifetime1
    {
        public int expiration { get; set; }
    }



    public class TokenCallbackResponse
    {
        public List<Command1> commands { get; set; }
        public Debugcontext debugContext { get; set; }
    }

    public class Debugcontext
    {
        public string extraParams { get; set; }
    }

    public class Command1
    {
        public string type { get; set; }
        public List<Value> value { get; set; }
    }

    public class Value
    {
        public string op { get; set; }
        public string path { get; set; }
        public string value { get; set; }
    }




    /// Registration Hook

    public class RegistrationCallbackRequest
    {
        public string eventType { get; set; }
        public string eventTypeVersion { get; set; }
        public string cloudEventVersion { get; set; }
        public string source { get; set; }
        public string eventID { get; set; }
        public DateTime eventTime { get; set; }
        public string contentType { get; set; }
        public Data2 data { get; set; }
    }

    public class Data2
    {
        public Context2 context { get; set; }
        public User2 user { get; set; }
        public Debugcontext2 debugContext { get; set; }
    }

    public class Context2
    {
        public Request2 request { get; set; }
    }

    public class Request2
    {
        public string id { get; set; }
        public string method { get; set; }
        public Url2 url { get; set; }
        public string ipAddress { get; set; }
        public string locale { get; set; }
        public string client { get; set; }
    }

    public class Url2
    {
        public string value { get; set; }
    }

    public class User2
    {
        public Profile profile { get; set; }
    }

    public class Profile
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string login { get; set; }
        public string mobilePhone { get; set; }
    }

    public class Debugcontext2
    {
        public string loglevel { get; set; }
        public DateTime requestSentTime { get; set; }
        public DateTime requestReceivedTime { get; set; }
        public DateTime responseSentTime { get; set; }
    }

    /// SAML Hook
    /// 

    public class SamlCallbackRequest
    {
        public string eventId { get; set; }
        public DateTime eventTime { get; set; }
        public string eventType { get; set; }
        public string eventTypeVersion { get; set; }
        public string contentType { get; set; }
        public string cloudEventVersion { get; set; }
        public string source { get; set; }
        public Data4 data { get; set; }
    }

    public class Data4
    {
        public Context4 context { get; set; }
        public Assertion assertion { get; set; }
    }

    public class Context4
    {
        public Request4 request { get; set; }
        public Protocol4 protocol { get; set; }
        public Session4 session { get; set; }
        public User4 user { get; set; }
    }

    public class Request4
    {
        public string id { get; set; }
        public string method { get; set; }
        public Url4 url { get; set; }
        public string ipAddress { get; set; }
    }

    public class Url4
    {
        public string value { get; set; }
    }

    public class Protocol4
    {
        public Request14 request { get; set; }
        public string type { get; set; }
        public Issuer4 issuer { get; set; }
    }

    public class Request14
    {
        public string id { get; set; }
        public string version { get; set; }
        public DateTime issuerInstant { get; set; }
        public string destination { get; set; }
        public bool forceAuthn { get; set; }
        public bool passive { get; set; }
        public string issuer { get; set; }
        public string relayState { get; set; }
    }

    public class Issuer4
    {
        public string id { get; set; }
        public string name { get; set; }
        public string uri { get; set; }
    }

    public class Session4
    {
        public string id { get; set; }
        public string userId { get; set; }
        public string login { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime expiresAt { get; set; }
        public string status { get; set; }
        public DateTime lastPasswordVerification { get; set; }
        public DateTime lastFactorVerification { get; set; }
        public string[] amr { get; set; }
        public Idp idp { get; set; }
        public bool mfaActive { get; set; }
    }

    public class Idp
    {
        public string id { get; set; }
        public string type { get; set; }
    }

    public class User4
    {
        public string id { get; set; }
        public DateTime passwordChanged { get; set; }
        public Profile4 profile { get; set; }
        public _Links _links { get; set; }
    }

    public class Profile4
    {
        public string login { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string locale { get; set; }
        public string timeZone { get; set; }
    }

    public class _Links
    {
        public Groups4 groups { get; set; }
        public Factors4 factors { get; set; }
    }

    public class Groups4
    {
        public string href { get; set; }
    }

    public class Factors4
    {
        public string href { get; set; }
    }

    public class Assertion
    {
        public Subject4 subject { get; set; }
        public Authentication authentication { get; set; }
        public Conditions conditions { get; set; }
        public Claims4 claims { get; set; }
        public Lifetime4 lifetime { get; set; }
    }

    public class Subject4
    {
        public string nameId { get; set; }
        public string nameFormat { get; set; }
        public Confirmation4 confirmation { get; set; }
    }

    public class Confirmation4
    {
        public string method { get; set; }
        public Data14 data { get; set; }
    }

    public class Data14
    {
        public string inResponseTo { get; set; }
        public string recipient { get; set; }
    }

    public class Authentication
    {
        public string sessionIndex { get; set; }
        public Authncontext authnContext { get; set; }
    }

    public class Authncontext
    {
        public string authnContextClassRef { get; set; }
    }

    public class Conditions
    {
        public string[] audienceRestriction { get; set; }
    }

    public class Claims4
    {
        public Firstname firstName { get; set; }
        public Lastname lastName { get; set; }
        public Email email { get; set; }
    }

    public class Firstname
    {
        public Attributes attributes { get; set; }
        public Attributevalue[] attributeValues { get; set; }
    }

    public class Attributes
    {
        public string NameFormat { get; set; }
    }

    public class Attributevalue
    {
        public Attributes1 attributes { get; set; }
        public string value { get; set; }
    }

    public class Attributes1
    {
        public string xsitype { get; set; }
    }

    public class Lastname
    {
        public Attributes2 attributes { get; set; }
        public Attributevalue1[] attributeValues { get; set; }
    }

    public class Attributes2
    {
        public string NameFormat { get; set; }
    }

    public class Attributevalue1
    {
        public Attributes3 attributes { get; set; }
        public string value { get; set; }
    }

    public class Attributes3
    {
        public string xsitype { get; set; }
    }

    public class Email2
    {
        public Attributes4 attributes { get; set; }
        public Attributevalue2[] attributeValues { get; set; }
    }

    public class Attributes4
    {
        public string NameFormat { get; set; }
    }

    public class Attributevalue2
    {
        public Attributes5 attributes { get; set; }
        public string value { get; set; }
    }

    public class Attributes5
    {
        public string xsitype { get; set; }
    }

    public class Lifetime4
    {
        public int expiration { get; set; }
    }



    public class SamlCallbackResponse
    {
        public List<Command5> commands { get; set; }
    }

    public class Command5
    {
        public string type { get; set; }
        public List<Value5> value { get; set; }
    }

    public class Value5
    {
        public string op { get; set; }
        public string path { get; set; }
        public Value51 value { get; set; }
    }

    public class Value51
    {
        public Attributes6 attributes { get; set; }
        public List<Attributevalue6> attributeValues { get; set; }
    }

    public class Attributes6
    {
        public string NameFormat { get; set; }
    }

    public class Attributevalue6
    {
        public Attributes7 attributes { get; set; }
        public string value { get; set; }
    }

    public class Attributes7
    {
        public string xsitype { get; set; }
    }



}
