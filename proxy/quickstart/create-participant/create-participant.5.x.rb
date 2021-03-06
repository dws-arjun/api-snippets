# Get the Ruby helper library from https://twilio.com/docs/libraries/ruby
require 'twilio-ruby'

# Get your Account SID and Auth Token from https://twilio.com/console
account_sid = 'ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX'
auth_token = 'your_auth_token'

# Initialize Twilio Client
client = Twilio::REST::Client.new account_sid, auth_token

participant = client.proxy
                    .services('KSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX')
                    .sessions('KCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX')
                    .participants.create(
                      identifier: '+15558675309',
                      unique_name: 'Alice'
                    )

puts participant.sid
