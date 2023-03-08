using Behavior.Mediator.ChatRooms;
using Behavior.Mediator.TeamMembers;
using Common;

namespace Behavior.Mediator;

public class MediatorRunner : IRunner
{
    public string Name => nameof(MediatorRunner);
    public void Run()
    {
        var chatRoom = new TeamChatRoom();

        var sven = new Lawyer("Sven");
        var kenneth = new Lawyer("Kenneth");
        var ann = new AccountManager("Ann");
        var john = new AccountManager("John");
        var kylie = new AccountManager("Kylie");
        
        chatRoom.Register(sven);
        chatRoom.Register(kenneth);
        chatRoom.Register(ann);
        chatRoom.Register(john);
        chatRoom.Register(kylie);
        
        ann.Send("Hi everyone, can someone have a look at file ABC123? I need a compliance check.");
        sven.Send("On it!");
        sven.Send(ann.Name, "Could you join me in a Teams call?");
        sven.Send(ann.Name, "All good :)");
        ann.SendTo<AccountManager>("The file was approved!");
    }
}