using Microsoft.AspNetCore.Mvc;
using SlackNet;
using SlackNet.WebApi;

namespace SlackConnectorAPIv2.Controllers;

[ApiController]
[Route("[controller]")]
public class SampleController : ControllerBase
{
    // Test Method for sanity
    [HttpGet("echo")]
    public string echo(string testMessage)
    {
        return "back: " + testMessage;
    }

    // Test Method for sanity
    [HttpGet("ping")]
    public string ping()
    {
        return "pong!";
    }

    // Send message to channel
    [HttpGet("SendTestSlackMessage")]
    public async void SendTestSlackMessage(string oathToken, string channel, string testMessage)
    {
        // Good tutorial on setting up SlackNet and Slack API configurations
        // You'll need your oath token!
        // -- -- looks like: xoxp-989876-86896976-945595859876789-987sadf67sd5f56s87sa5fdsd1b
        // -- https://danielko.medium.com/building-an-app-as-an-agent-for-slack-with-net-959e1c2ba3af
        //
        // SlackNet .Net library
        // -- https://github.com/soxtoby/SlackNet 

        // SlackNet send message to channel
        var api = new SlackServiceBuilder().UseApiToken(oathToken).GetApiClient();

        // Send a message
        await api.Chat.PostMessage(new Message { Text = "Test Message: " + testMessage, Channel = channel });
    } 
}
