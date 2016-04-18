// Download the twilio-csharp library from twilio.com/docs/csharp/install
using System;
using Twilio;

class Example {
    static void Main (string[] args) {
    	// Find your Account Sid and Auth Token at twilio.com/user/account
    	const string accountSid = "accountSid";
    	const string authToken = "authToken";
    	const string credentialSid = "credentialSid";
    	const string channelSid = "channelSid";
        
    	// List all members of a channel
    	var client = new TwilioIpMessagingClient(accountSid, authToken);
    	MemberResult result = client.ListMembers(credentialSid, channelSid);
    	Console.WriteLine(result);
    }
}