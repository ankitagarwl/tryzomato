using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using System.Collections.Generic;

namespace tryzomato
{
    public class Sendsms
    {
        // Download the twilio-csharp library from twilio.com/docs/libraries/csharp

        public void sendmsg()
        {

          
            // Set our Account SID and Auth Token
            const string accountSid = "ACbda20490fb7ed6470333f07756caf394";
            const string authToken = "3dbdfd8ed92c367015dad23aeb8407bd";

            // Initialize the Twilio client
            TwilioClient.Init(accountSid, authToken);

            // make an associative array of people we know, indexed by phone number
            var people = new Dictionary<string, string>() {
                {"+919680143931", "Curious George"}
                
            };

            // Iterate over all our friends
            foreach (var person in people)
            {
                // Send a new outgoing SMS by POSTing to the Messages resource
                MessageResource.Create(
                    from: new PhoneNumber("+15755877347"), // From number, must be an SMS-enabled Twilio number
                    to: new PhoneNumber(person.Key), // To number, if using Sandbox see note above
                                                     // Message content
                    body: $"Hey {person.Value} Monkey Party at 6PM. Bring Bananas!");

                Console.WriteLine($"Sent message to {person.Value}");
            }




        }
   
}
}