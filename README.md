# SlackConnectorAPIv2

Sample C# Slack Connector/Bot Web API to send a message to a channel.


This is a simple project. Code was written for readability.


Good tutorial on setting up SlackNet and Slack API configurations
You'll need your oath token!
-- looks like: xoxp-989876-86896976-945595859876789-987sadf67sd5f56s87sa5fdsd1b
-- https://danielko.medium.com/building-an-app-as-an-agent-for-slack-with-net-959e1c2ba3af

SlackNet .Net library
-- https://github.com/soxtoby/SlackNet

Above library implements these slack calls
-- https://api.slack.com/methods



</br>
!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!</br>
Test URL (port may vary)</br>
!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!</br>

http://localhost:5160/swagger/index.html



</br>
!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!</br>
Recommended Bot Token Scopes</br>
!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!</br>

channels:manage
Manage public channels that DaisySlackBotv2 has been added to and create new ones

channels:read
View basic information about public channels in a workspace

chat:write
Send messages as @DaisySlackBotv2

chat:write.public
Send messages to channels @DaisySlackBotv2 isn't a member of

dnd:read
View Do Not Disturb settings for people in a workspace

groups:write
Manage private channels that DaisySlackBotv2 has been added to and create new ones

im:read
View basic information about direct messages that DaisySlackBotv2 has been added to

im:write
Start direct messages with people

mpim:write
Start group direct messages with people

users:read
View people in a workspace

users:read.email
View email addresses of people in a workspace

users:write
Set presence for DaisySlackBotv2