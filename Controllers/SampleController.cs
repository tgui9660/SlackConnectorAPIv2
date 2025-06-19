using Microsoft.AspNetCore.Mvc;
using SlackNet;
using SlackNet.WebApi;

namespace SlackConnectorAPIv2.Controllers;

// Good tutorial on setting up SlackNet and Slack API configurations
// You'll need your oath token!
// -- -- looks like: xoxp-989876-86896976-945595859876789-987sadf67sd5f56s87sa5fdsd1b
// -- https://danielko.medium.com/building-an-app-as-an-agent-for-slack-with-net-959e1c2ba3af
//
// SlackNet .Net library
// -- https://github.com/soxtoby/SlackNet 
//
// Above library implements these slack calls
// -- https://api.slack.com/methods


[ApiController]
[Route("[controller]")]
public class SampleController : ControllerBase
{
    // Send message to channel
    [HttpGet("SendMessageToChannel")]
    public async Task<string> SendMessageToChannel(string oathToken, string channel, string message)
    {

        try
        {
            // SlackNet send message to channel
            var api = new SlackServiceBuilder().UseApiToken(oathToken).GetApiClient();

            // Send a message
            await api.Chat.PostMessage(new Message { Text = "Bot Message: [" + message + "]", Channel = channel });

            return "Everything executed OK!";
        }
        catch (Exception e)
        {
            return "Error: " + e.Message;
        }
    }

    // Get a list of available real user names
    [HttpGet("GetAvailableRealNames")]
    public async Task<List<string>> GetAvailableRealNames(string oathToken)
    {

        List<string> userRealNamesFound = new List<string>();

        var api = new SlackServiceBuilder().UseApiToken(oathToken).GetApiClient();

        UserListResponse listOfUsers = await api.Users.List();

        foreach (User theUser in listOfUsers.Members)
        {
            if (theUser.RealName != null)
            {
                userRealNamesFound.Add(theUser.RealName);
            }
        }
        return userRealNamesFound;
    }

    // Send message to person by name
    [HttpGet("SendMessageToRealName")]
    public async Task<string> SendMessageToRealName(string oathToken, string humanName, string message)
    {
        string userIDFromHumanName = "";
        string userRealNamesFound = "";
        string userNames = "";

        string returnPayload = "";

        try
        {
            var api = new SlackServiceBuilder().UseApiToken(oathToken).GetApiClient();

            UserListResponse listOfUsers = await api.Users.List();

            foreach (User theUser in listOfUsers.Members)
            {
                if (theUser.RealName != null)
                {
                    userRealNamesFound = userRealNamesFound + " : " + theUser.RealName.ToLower();
                }

                if (theUser.Name != null)
                {
                    userNames = userNames + " : " + theUser.Name.ToLower();
                }

                if (theUser.RealName != null && theUser.RealName.ToLower() == humanName.Trim().ToLower())
                {
                    userIDFromHumanName = theUser.Id;
                    // break;
                }
            }
            returnPayload = "humanName: " + humanName + " userIDFromHumanName: " + userIDFromHumanName + "  message: " + message + " userRealNamesFound: [" + userRealNamesFound + "] " + " userNames: [" + userNames + "] ";
            Message theMessage = new Message();
            theMessage.Channel = userIDFromHumanName;
            theMessage.Text = message;

            PostMessageResponse messageResponse = await api.Chat.PostMessage(theMessage);

            return "Execution OK!!: " + returnPayload;
        }
        catch (Exception e)
        {
            return returnPayload + " Error: " + e.Message + " : " + e.StackTrace;
        }
    }


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
}
