# SlackConnectorAPIv2

This is a sample C# Slack Connector/Bot Web API to send a message to a channel. This is a simple project. Code was written for readability.


This is a good tutorial on setting up SlackNet and Slack API configurations.
* https://danielko.medium.com/building-an-app-as-an-agent-for-slack-with-net-959e1c2ba3afhttps://danielko.medium.com/building-an-app-as-an-agent-for-slack-with-net-959e1c2ba3af

## Descriptor.yaml
This file contains all parts that are needed for consumption of this service.

Example:
```cs
name: SlackConnectorAPIv2
version: 1.0
author:
  - name: First Last
  - email: test.email@email.com
  - company: Company Name
description: This is a sample Slack Bot API.
requiredfiles:
  - DLL:
      name: SlackNet.dll
      version: 1.0.0.0
  - DLL:
      name: Newtonsoft.Json.dll
      version: 13.0.0.0
  - DLL:
      name: System.Reactive.dll
      version: 0.16.1.0
  - DLL:
      name: Microsoft.Bcl.AsyncInterfaces.dll
      version: 4.3.0.0
inputs:
  - oathkey: string

```
### TODO
* Define a schema for the above yaml.


## Restful Calls Available

### Get a list of all names and assocated IDs 
```cs
[HttpGet("GetNamesAndIDs")]
public async Task<Dictionary<string, string>> GetNamesAndIDs(string oathToken)
```

<br/>

### Get a list of all human readable names 
```cs
[HttpGet("GetAvailableRealNames")]
public async Task<List<string>> GetAvailableRealNames(string oathToken)
```

<br/>

### Send a message to a person by name 
```cs
[HttpGet("SendMessageToRealName")]
public async Task<string> SendMessageToRealName(string oathToken, string humanName, string message)
```

<br/>

### Send a message to a channel synchronously
```cs
[HttpGet("SendMessageToChannelNotAsync")]
public string SendMessageToChannelNotAsync(string oathToken, string channel, string message)
```

<br/>

### Send a message to a channel asynchronously 
```cs
[HttpGet("SendMessageToChannel")]
public async Task<string> SendMessageToChannel(string oathToken, string channel, string message)
```
<br/>

### Test call to see if web api is available
```cs
[HttpGet("ping")]
public string ping()
``` 

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

Scopes define what rights and actions a slack bot will have acess to. Reference link below.
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
