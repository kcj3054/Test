namespace ConsoleApp1;

public class OOP
{
    /*
     *            - 컴파일타임에 호출할 함수를 결정하는 방식이 정적 바인딩, 초기 바인딩, 컴파일타임 바인딩이라고한다.
     *            - OOP에서는 메시지를 수신했을 때 실행 될 메서드가 런타임에 결정된다 이러한 것을 동적바인딩, 지연 바이딩이라고한다.
     *                         - foo.bar()가 실행될 때 실행되는 bar가 어떤 클래스의 어떤 메서드인지도 알아야한다...왜냐하면 상속 관계가 얽혀져있으면 bar메서드가 어떤 계층의 메서드인지도 확인해야하기에.. 
     * 
     */
    
    
    /*
     * 동적메서드가 이루어지는 과정.. -> 메시지를 수신한 개체는 자신을 생성한 클래스가 해당 메서드를 가지고 있는지 확인 후 없다면 상위 계층으로 이동하면서 계속 해당 메서드를 탐색하는 과정을 거친다..
     * self 참조를 this라고한다.. 개체가 메시지를 수신하면 self 변수를 컴파일러가 생성하면서 최종에 이르면 자동으로 소멸시킨다
     */
    
    /*
     * oop에서 동적메서드 탐색으로 자식의 오버라이딩 메서드는 부모의 메서드를 감춘다 하지만 오버로딩은 클라이언트 입장에서 모든 메서드가 함께 공존할 수 있다 
     */
    
    /*
     * self 전송은 self 참조부터 탐색을 다시 시작하게만든다. 
     */
    
    
    //정적타입언어.. , c# base, java super
    // 메서드 호출 x -> base참조를 이용해 메시지 전송. base는 단순 부모를 호출하는 것이 아니라 그 위의조상을 호출하는 것일 수도 있다. -> 지금 이 클래스의 부모 클래스에서부터 메서드 탐색을 시작하세요.. 
    // self참조는 항상 수신한 개체를 가리킨다 
    // 
    
    // 자신이 수신한 메시지를 다른 개체에게 동일하게 전달해서 처리를 요청하는 것을 위임이라고한다
    /*
     *    public class Graduate : Lecture. 
     *   {
     *      public void Status(this)
     *     {
     *        base.Status(this);
     *      }
     *   }
     * => 상속의 장점은 우리가 구현해야하는 것들을 동적으로.. 자동으로 위임을 해줄 수 있다는 것이다
     * => 위임의 정확한 용도는..  클래스 상속관계를 개체관의 합성 관계로 대체해서 다형서을 만드는것.. 
     */
    
    
    /*
     *  상속의 진실적인 2가지 측면
     *
     *  - 타입 계층을 구현하는 것이다.
     *        - 부모클래스는 자식 클래스의 일반화이고 자식클래스는 특수화이다.
     *
     * -  코드 재사용.. 하지만 코드 재사용만을 목적으로 상속을 사용한다면 부모, 자식간의 결합도는 강해져버린다. ... 놉.
     * 
     */
    
    /*
     * 개체지향 프로그래밍에서  객체가 수신할 수 있는 메시지의 집합은 public Interface라고한다..
     *
     * 개체에게 중요한 것은 속성이 아니라 행동이다. 동일한 상태를 가지고 있더라도 public interface가 다르면 다른 타입으로 분류된다. 
     * 
     */
    
    /*
     * 
     */
}