# SlackConnectorAPIv2

This is a sample C# Slack Connector/Bot Web API to send a message to a channel. This is a simple project. Code was written for readability.


This is a good tutorial on setting up SlackNet and Slack API configurations.
* https://danielko.medium.com/building-an-app-as-an-agent-for-slack-with-net-959e1c2ba3afhttps://danielko.medium.com/building-an-app-as-an-agent-for-slack-with-net-959e1c2ba3af

## You'll need your oath token

Looks like: xoxp-989876-86896976-945595859876789-987sadf67sd5f56s87sa5fdsd1b

Withing the api.slack.com portal the oath token can be found here:


![image info](images/slackconnector-OATH-token.png)


## SlackNet .Net library

This is the official C# interface to Slack Bot features

* https://github.com/soxtoby/SlackNet


</br>

## Swagger test URL

* http://localhost:5160/swagger/index.html

</br>

## Recommended Slack Bot Token Scopes

Reference link below.
* https://api.slack.com/methods


### channels:manage
Manage public channels that @YourBot has been added to and create new ones

### channels:read
View basic information about public channels in a workspace

### chat:write
Send messages as @YourBot

### chat:write.public
Send messages to channels @YourBot isn't a member of

### dnd:read
View Do Not Disturb settings for people in a workspace

### groups:write
Manage private channels that YourBot has been added to and create new ones

### im:read
View basic information about direct messages that YourBot has been added to

### im:write
Start direct messages with people

### mpim:write
Start group direct messages with people

### users:read
View people in a workspace

### users:read.email
View email addresses of people in a workspace

### users:write
Set presence for YourBot
