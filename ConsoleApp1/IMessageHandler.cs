namespace ConsoleApp1;

// EX : NETMQ를 사용한다면 구현체에서는 타입파라미터를 NETMQ를 사용하도록... 
// NATSMQ를 사용한다면 해당 부분은 NATSMQ를 사용하도록 GENERIC화.. 
public interface IMessageHandler<T>
{
    Task RunAsync(T message);
}