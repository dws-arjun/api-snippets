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
        const string memberSid = "memberSid";

        // Delete a member
        var client = new TwilioIpMessagingClient(accountSid, authToken);
        DeleteStatus status = client.DeleteMember(serviceSid, channelSid, memberSid);
        Console.WriteLine(status);
    }
}