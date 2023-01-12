using System.Timers;
using ConsoleApp1;
using Microsoft.Extensions.Configuration;

//환경변수 
// string _environment = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT");
// Console.WriteLine($"내 환경 변수 : {_environment} ");
//
// var configuration = new ConfigurationBuilder()
//     .AddJsonFile("Config.json", true)
//     .AddJsonFile($"Config.{_environment}.json", true)
//     .Build();
//
// var serverType = configuration.GetValue<string>("ServerInfo:ServerType");
// var Id = configuration.GetValue<int>("ServerInfo:Id");
// Console.WriteLine($"serverType : {serverType}, Id : {Id}");
//
// var testRes = configuration.GetSection("ServerInfo:ID");
// Console.WriteLine($"testRes : {testRes.Value}");

var interval = new JobInterval();

interval.Charge(TimeSpan.FromMinutes(3).TotalMilliseconds , OnHearBeatToProxy);

void OnHearBeatToProxy(object? sender, ElapsedEventArgs e)
{
  Console.WriteLine("OnHearBeatToProxy");
}







// var host = new HostBuilder()
//  .ConfigureAppConfiguration(
//   (context, config) =>
//   {
//    config.AddJsonFile("Config.json", true)
//          .AddJsonFile($"Config.{_environment}.json", true);
//   })
//  .Build();
// // Console.WriteLine($"HOST : {}");
//
// host.RunAsync();

// _configuration.GetValue<int>();
// var host = new HostBuilder();
// host
//  .ConfigureAppConfiguration()
//  .ConfigureServices((context, service) => { service.AddHostedService<SServer>();})
//  .Build();

// using System.Collections.Concurrent;
// using System.Diagnostics;

// var con = new ConcurrentDictionary<string, int>();
// con.TryAdd("cat", 1);
// con.TryAdd("dog", 2);
//         
// // Add dog with value of 5 if it does NOT exist.
// // ... Otherwise, add one to its value.
// con.AddOrUpdate("dog", 5, (k, v) => v + 1);
//         
// // Display dog value.
// Console.WriteLine(con["dog"]);
//         
// // Get mouse or add it with value of 4.
// int mouse = con.GetOrAdd("mouse", 4);
// Console.WriteLine(mouse);
//         
// // Get mouse or add it with value of 660.
// mouse = con.GetOrAdd("mouse", 660);
// Console.WriteLine(mouse);

// var rr= Guid.NewGuid();
// Console.WriteLine(rr);
// Console.WriteLine($"GUID TYPE : {RR}");
// Func<int, int> twice = x => x *2;
//
// int i = 3;
// int j = twice.Invoke(3);
// Console.WriteLine(j);
//
// Delegate slowTwice = twice;
// object[] ar = { i };
// var result = slowTwice.DynamicInvoke(ar);
// Console.WriteLine(result.GetType());
//
//
//
//
// using System.Diagnostics;
//

// using System.Diagnostics;
//
// int num = 300;
// Func<int, int> twice = x => x * 2;
//
// const int Loop = 50000000;
//
// var watch = Stopwatch.StartNew();
// for (int i = 0; i < Loop; ++i)
// {
//     twice.Invoke(3);
// }
//
// watch.Stop();
// Console.WriteLine(watch.ElapsedMilliseconds);
//
// watch = Stopwatch.StartNew();
// for (int i = 0; i < Loop; ++i)
// {
//     twice.DynamicInvoke(3);  //는 반환값이 object이다.. , 대리자가  나타내는 메서드를 동적으로 호출합니다. .ㅇ
// }
// watch.Stop();
// Console.WriteLine(watch.ElapsedMilliseconds);
//
// void Add(ref int input)
// {
//     input += 20;
// }

/*
 * 관례상으로 delegate 변수에 접미사는 Delegate를 적는 것이 관례이다. 
 */


/*
 * 상수는 정의와 함께 대입해야한다.... 생성자에서 접근할 수 없다.
 *
 * 상수는 static 예약어가 허용되지 않는다. 
*/

// 비동기 요청을 기준으로 발생하는 여전한 로직의 분절, 그에 따른 실행 시점 시간차 및 실행 환경상의 차이 등은 당연게도 여전히 존재하고 있기 때문이다

// 
// async Task<bool> FooAsync()
// {
//  // 0번 스레드가 실행.. 
//
//  bool result = await BarAsync();
//  // 2번 스레드가 실행 ... 
//
//  return true;
// }
//
// async Task<bool> BarAsync()
// {
//  return false;
// }

/*
 * . 스레드에 lock을 걸지 않으면서도 서로 다른 스레드간 간섭 없이 순차실행을 가능하게 하기 위해, 스레드는 현재 자신의 수행상태 일부를 tls에 기록해 두어야 한다.
 *  -> await를 하기 전 후로 다른 스레드가 나와 기록이 변경 될 수 있다면  AsyncLocal을 사용하면 해결이 된다. -> AsyncLocal은 스레드풀에서 스레드가 하나 들어가고 새로운 것이 나올 때 값을 복사해준다.. 
 */

// using BabyCarrot.Tools;
//
// LogManager log = new();
// // log.WriteConsole("TEST");
//
// string code = @"
// public string ReadFile(string fileName)
// {
//        if(!string.IsNullOrEmpty(filename))
//        {
//          
//        }
// }
// ";
//
// Console.WriteLine(code);
// StringMethod();
//
// // @ 심벌  사용법. -> c#키워드 앞에 @을 사용하면 무시가 가능하다.. 하시만 다른쪽이나 키워드 사용되는 말들은 피하도록하자.. 
// // @ 문자열 그래도 인식 가능
//
// void StringMethod()
// {
//  string @string = "객체";
//  @string = @string + "지향프로그래밍";
//  
//  Console.WriteLine(@string);
// }
//
// public static class ExtensionTest
// {
//  public static void WriteConsole(this LogManager log, string data)
//  {
//    log.Write(data);
//    Console.Write(data);
//  }
// }


//           메모리 테스팅.. 

// long mem = GC.GetTotalMemory(false);
// Console.WriteLine("Initial Memory: {0}", mem);
//
// Run();
// mem = GC.GetTotalMemory(false);
// Console.WriteLine("Current Memory: {0}", mem);
//
// GC.Collect();
// mem = GC.GetTotalMemory(false);
// Console.WriteLine("After Memory: {0}", mem);
//
// void Run()
// {
//  var obj = new LargeDataClass();
//  obj.Set(1, 2000);
// }
//
// public class LargeDataClass
// {
//  private int[] data = new int[1000000];
//
//  public void Set(int index, int value)
//  {
//   data[index] = value;
//  }
// }

//  Predicate<T> Delegate.. -> 리턴값이 bool, 입력 파라미터는 1개.. 
// Predicate<T> -> Func<T, bool>

// Predicate<int> p = delegate(int n)
// {
//  return n >= 0;
// };
// bool res = p(-1);
//
// Predicate<string> p2  = s => s.StartsWith("A");
// res = p2("Apple");
// Console.WriteLine(res);
//
//
// void Run()
// {
//  int[] arr = { -10, 20, -30, 4, -5 };
//
//  int pos = Array.Find(arr, IsPositive);
//
//  var v = arr.Where(n => n >= 0);
//  
// }
//
// bool IsPositive(int i)
// {
//  return i >= 0;
// }

// 무명메서드.. 
// delegate(int param1) { Console.WriteLine(param1); }


//
// MyDelegate d = delegate(int p)
// {
//  Console.Write(p);
// };
//
// d(100);
//
// delegate void MyDelegate(int a);


//====================================================Delegate============================================
// 컴파일러는 delegate 키워드를 본다면 이것을 Multicast delegate로 인식해서 그에 상응하는 개체 인스턴스로 만들어준다. -> 

// void Test()
// {
//  MyDelegate m = new(StringToInt);
//  
//  // m.Invoke("123");
//  Run(m);
// }
//
// int StringToInt(string s)
// {
//  return int.Parse(s);
// }
//
// void Run(MyDelegate m)
// {
//  int i = m("123");
//  // int i = m.Invoke("123");.. 
//  Console.WriteLine(i);
// }
//
// delegate int MyDelegate(string s);


// event는 delegate의 단점들을 위해서 탄샏ㅇ..! = 할당 연산자 x, += -= 연산자만 사용가능, 클래스 외부에서 호출 불가. 


// Nullable Reference Type 개요..  = > 
// 만약 Non-nullable Reference Type에 NULL을 할당하면, 컴파일러가 경고 메시지를 표시하게 된다.


// string? s1 = null;


/*
 * Nullable Reference Type은 기존 Reference Type 뒤에 물음표를 붙여 표시한다. 예를 들어, string은 Non-nullable Reference Type이며, string? 은 Nullable Reference Type임을 표시한다. Nullable Reference Type의 변수를 사용할 때는 항상 먼저 NULL 인지를 체크해야 하며, 만약 그렇지 않으면 컴파일러가 경고(Warning) 메시지를 표시한다.
 * 즉, 컴파일러가 이렇게 NULL이 들어갈 수 있는 부분을 자동으로 체크해서 경고를 표시하기 때문에, 개발자가 실수로 Null Reference Exception를 발생시키는 오류를 범하지 않도록 도와주게 된다
 * 
 */
// RunRun();


// void Print(string? s)
// {
//     Console.Write(s.Length); // // Warning: Dereference of a possibly null reference
//
//     if (s != null)
//         Console.WriteLine(s);
// }


//==========================================nameof 연산자 

// -> nameof연산자를 사용하면 메서드 속성 등의 이름을 리턴할 수 있어서, 하드코딩도 줄일 수 있고, 코딩의 실수도 줄일 수 있다 

// ex : throw new ArgumentException("Invalid argument", nameof(id));

//메서드명 로깅에 추가 
// void RunRun()
// {
//    Console.WriteLine(nameof(RunRun) + " : Started");
// }


//======================================로컬함수..===============================

// Run();
// IEnumerable<int> GetNumbers(int count, Func<int, bool> filter)
// {
//     if (count < 1 || filter == null) throw new ArgumentException();
//     return NumberIterator();
//     //로컬함수 
//     IEnumerable<int> NumberIterator()
//     {
//         for (int i = 0; i < count; ++i)
//         {
//             if (filter(i))
//             {
//                 yield return i;
//             }
//         }
//     }
// }
//
// void Run()
// {
//     foreach (var item in GetNumbers(100, n => n % 2 == 0))
//     {
//         Console.WriteLine(item);
//     }
// }


// -> yield 키워드는 호출자에게 데이터를 하나씩 리턴할 때 사용.. 
// -> yield return or yield break(리턴을 중지하고 빠져나오기. ) 2가지 방식으로 사용.. 
//  (Lazy Operation) 가능.! 

// foreach (var num in GetNumber())
// {
//  Console.WriteLine(num);
// }
//
// IEnumerable<int> GetNumber()
// {
//      yield return 10;
//      yield return 20;
//      yield return 30;
// }

// var list = new MyList();
//
// foreach (var item in list)
//         Console.WriteLine(item);
//
// // 수동 iteration.. 
// IEnumerator it = list.GetEnumerator();
// it.MoveNext();
// Console.WriteLine(it.Current);
// it.MoveNext();
// Console.WriteLine(it.Current);
//
//
// public class MyList
// {
//  private int[] data = { 1, 2, 3, 4, 5 };
//
//  public IEnumerator GetEnumerator()
//  {
//   int i = 0;
//   while (i < data.Length)
//   {
//    yield return data[i];
//
//    i++;
//   }
//  }
// }



//= ===================================================  호출 스택 ======================================================

// HasProblem();
//
// void HasNoProblem()
// {
//  WriteText("ASDFASDFASDF");
// }
//
// void HasProblem()
// {
//  WriteText(null);
// }
//
// void WriteText(string txt)
// {
//   Console.WriteLine(txt.ToLower());
// }


// try
// {
//  HasProblem();
// }
// catch (Exception ex)
// {
//  throw;  // throw ex..
// }
//
//
//
// void HasProblem()
// {
//  WriteText(null);
// }
// void WriteText(string txt)
// {
//   Console.WriteLine(txt.ToLower());
// }


//======================== 예외필터. ==================================
// string filepath = @"c:xxxx";
// try
// {
//  string txt = File.ReadAllText(filepath);
// }
// catch (Exception ex) when(SwallowWhenTempFile(filepath))
// {
//  Console.WriteLine(ex.ToString());
// }
//
// bool SwallowWhenTempFile(string filePaht)
// {
//  return filepath.IndexOf("temp") != -1;
// }


// a + b	-> 3	 '3'으로 평가된다 -> expression.
// statement는 expression을 포함한다.. expression에서 중요한 것은 값을 평하한다는 것이다.. 
//Partitioning.. -> 

// void Demo()
// {
//  Parallel.For(
//   0, 20, x =>
//   {
//    Console.WriteLine($"{x} [{Task.CurrentId}\t");
//   });
// }\

// int sum = 0;
// Parallel.For(
//  1, 1001, x =>
//  {
//   Interlocked.Add(ref sum, x);
//  });


// 컬렉션 문제들...
// -> c#의 List<T>는 .Add()를하게 된다면 메모리 재 확보와 복사가 발생한다. 값 접근이 별로 없다면 LinkedList<T>도 생각을 해봐야한다. 
// async의 정체는 state Machine.. -> 컴파일러가 class를 만들고 구현중.. 


// ReaderWriterLock

// 

// int x = 90;
// int y = 3;
// //location, value, comparand에 들어가는 타입이 일치해야한다.. , not null..
// var res = Interlocked.CompareExchange(ref x, y, 90);
// Console.WriteLine($"반환값 res : {res}, 변화된 x의 값 : {x}"); // 90,  3

// lock의 문제점.. 
//베타제어는 병행처리를 부분적으로 병행동작을 하지 않도록 제어하고있다..
// 저하를 최소화 하기 위해 우선 잠금에 의한 배타 제어를 하지 않아도 되는 디자인을 고려하는 것이 좋다. 꼭 배타 제어를 해야 하는 곳은 가능한 잠금 범위와 시간을 작게하면 좋다.
// 



//c# ReaderWriterLock -> 
// - 스레드가 리더 락을 취득한 경우에는 다른 thread는 reader lock을 얻을 수 있지만, wirter lock은 해제까지 대기해야한다.
// - 스레드가 라이터 락을 취득한 경우에는 다른 thread는 대기해야한다. 

// Resource resource = new();
//
// for (int i=0; i < 10; i++)
// {
//  new Thread(resource.ReaderLock).Start(); // （1）
//  new Thread(resource.WriterLock).Start(); // （2）
// }
//
// public class Resource
// {
//  private ReaderWriterLock rwLock = new();
//
//  private int balance = 1000;
//
//  public void ReaderLock()
//  {
//   try
//   {
//    rwLock.AcquireReaderLock(Timeout.Infinite);
//
//    Console.WriteLine(balance);
//   }
//   finally
//   {
//     rwLock.ReleaseReaderLock();
//   }
//  }
//
//  public void WriterLock()
//  {
//   try
//   {
//    // rwLock.AcquireWriterLock(Timeout.Infinite);
//    balance += 100;
//    Thread.Sleep(1000);
//    balance -= 100;
//    
//    Console.WriteLine(balance);
//   }
//   finally
//   {
//     // rwLock.ReleaseWriterLock();
//   }
//  }
// }
//  


// Parallel.For(1, 100, PrintNumber);
//
// void PrintNumber(int i)
// {
//  Console.WriteLine(i);
// }


//============== init 설정자 추가 

// public class Point
// {
//  public int X { get;}
//  public int Y { get;}
//
//  public Point(int x ,int y)
//  {
//   X = x;
//   Y = y;
//  }
// }

// var pt = new Point
// {
//  X = 2,
//  Y = 3
// };
// public class Point
// {
//  public int X { get; init; }
//  public int Y { get; init; }
//  
// }

// public record Point
// {
//  public int X { get; init; }
//  public int Y { get; init; }
// }

//줄여서 표현 가능
// public record Point(int X, int Y) { }


// var rectangle = new Rectangle(5, 6, 20, 25);
// {
//  (int x, int y) = rectangle;
//  Console.WriteLine($"x : {x}, y : {y}");
// }
//
// {
//  (int x, int y, int width, int height) = rectangle;
//  Console.WriteLine($"x : {x}, y : {y}, width = {width}, height = {height}");
// }
//===================================== Deconstruct 메서드==================================
// class Rectangle
// {
//  public int X { get; }
//  public int Y { get; }
//  public int Width { get; }
//  public int Height { get; }
//
//  public Rectangle(int x, int y, int width, int height)
//  {
//   X = x;
//   Y = y;
//   Width = width;
//   Height = height;
//  }
//
//  public void Deconstruct(out int x, out int y)
//  {
//   x = X;
//   y = Y;
//  }
//
//  public void Deconstruct(out int x, out int y, out int width, out int height)
//  {
//   x = X;
//   y = Y;
//   width = Width;
//   height = Height;
//  }
// }
//=======================================================================

//=============================== 비동기 스트림 변경전 ==========================================
// static async Task Main()
// {
//  foreach (int value in GenerateSequence(10))
//  {
//    Console.WriteLine($"tid : {Thread.CurrentThread.ManagedThreadId}");
//  }
//  
//  Console.WriteLine($"tid : {Thread.CurrentThread.ManagedThreadId}");
//  
// }
//
// static IEnumerable<int> GenerateSequence(int count)
// {
//  for (int i = 0; i < count; i++)
//  {
//   Thread.Sleep(1000);
//   yield return i;
//  }
// }


//============================== 비동기 스트림 변경 후 =================================================

// await Main();
//
// async Task Main()
// {
// await foreach (int value in GenerateSequence(10))
//  {
//    Console.WriteLine($"tid : {Thread.CurrentThread.ManagedThreadId}");
//  }
//  
//  Console.WriteLine($"tid : {Thread.CurrentThread.ManagedThreadId}");
//  
// }
//
// async IAsyncEnumerable<int> GenerateSequence(int cnt)
// {
//  for (int i = 0; i < cnt; ++i)
//  {
//   await Task.Run(() => Thread.Sleep(100));
//   yield return i;
//  }
// }
// 8.0에 추가된 비동기 스트림은 await foreach이고 나머지는 해당사항에 맞게 활용한 부분들이다.. 


//=================== 범위연산자.-==


// void Main()
// {
//  string text = "(this)";
//  PrintText(text);
// }
//
// void PrintText(string txt)
// {
//  if (txt.Length >= 2 && txt[0] == '(' && txt[txt.Length - 1] == ')')
//  {
//   txt = txt.Substring(1, txt.Length - 2);
//  }
//  Console.WriteLine(txt);
// }

// void PrintText(string txt)
// {
//  if (txt.Length >= 2 && txt[0] == '(' && txt[^1] == ')')
//  {
//   txt = txt[1..^1];
//  }
//  Console.WriteLine((txt));
// }
// // java도 interface에 default 키워드를 사용하면 인터페이스 내 함수 구현이가능하다., c#도 추가했당..
//
// // =============== Interface===================
//
// public interface ILog
// {
//  void Log(string txt) => WriteConsole(txt);
//
//  static void WriteConsole(string txt)
//  {
//   Console.WriteLine(txt);
//  }
// }
//================= c# interface내에 매서드구현이 있지만 호출시 메서드가 속한 인터페이스를 명시로인해 다이아몬드 상속해결. ====================
// C c = new C();
// // c.M(); 허용 x 
//
// (c as IA).M();
//
// interface IA
// {
//  void M() {Console.WriteLine("IA.M");}
// }
//
// interface IB : IA
// {
//   new void M() {Console.WriteLine("IB.M");}
// }
//
// interface IB2 : IA
// {
//   new void M() {Console.WriteLine("IB2.M");}
// }
//
// class C : IB, IB2, IA
// {
//  
// }
//===================================================
//   =================  제일 깔끔해보인다 =================
// var p1 = new Point {X = 3, Y = 2};
//
// public record Point(int X, int Y)
// {
//  public Point() : this(0, 0) { }
// }

// =================> c# compiler 타입 추론 대상이확대되고있다. 

// Point pt3 = new(5, 6);
//
// var linePt = new Point[]
// {
//  new(5, 6),
//  new() { X = 5, Y = 2 }
// };
//
// var dic = new Dictionary<Point, bool>()
// {
//  [new(5, 6)] = true,
//  [new(7, 3)] = true,
//  [new() {X =3, Y = 2}] = false,
// };
// public record Point(int X, int Y)
// {
//  public Point() : this(0, 0) {}
// }


// 9.0부터 1과 null 대상 타입인 int?로 암시적 형변환이 가능하므로 허용. 
// int? result = (args.Length != 0) ? 1 : null;

// await DosomethingAsync();
//
// async Task DosomethingAsync()
// {
//  int value = 13;
//
//  await Task.Delay(TimeSpan.FromSeconds(3)); // context를 저장한다.. -> 널이 아니기에 SynchronizationContext를 저장한다.. 
//
//  value *= 2;
//
//  await Task.Delay(TimeSpan.FromSeconds(3));
//  
//  Console.WriteLine(value);
// }


// ======================================================


/*async Task WaitAsync()
{
 // await는 현재 컨텍스트를 저장하고... 
 await Task.Delay(TimeSpan.FromSeconds(1));
}*/

// void DeadLock()
// {
//  //지연 시작.. 
//   Task task = WaitAsync();
//  
//   //동기적으로 차단하고 async 메소드 완료를 대기 
//   task.Wait();
// }
// async  Task DeadLock()
// {
//  //지연 시작.. 
//  await WaitAsync();
// }


// 병렬처리의 지침... -> 작업 가능한 다른 작업과 독립적이어야한다...

// HashSet -> 집합... 중복 x, 순서 x 
// var evenNumbers = new HashSet<int>();
// var oddNumbers = new HashSet<int>();
//
// for (int i = 0; i < 5; i++)
// {
//  evenNumbers.Add(i * 2);
//
//  oddNumbers.Add((i * 2) + 1);
// }
// DisplaySet(evenNumbers);
// DisplaySet(oddNumbers);
//
// var numbers = new HashSet<int>(evenNumbers);
// Console.WriteLine("numbers UnionWith oddNumbers...");
// numbers.UnionWith(oddNumbers);
//
// DisplaySet(numbers);
//
// void DisplaySet(HashSet<int> collection)
// {
//   Console.Write("{");
//
//   foreach (var i in collection)
//   {
//     Console.Write($" {i}");
//   }
//   Console.Write("  }");
// }


// ========== 간단한 지수 백오프... -> 재시도 사이의 지연시간을 늘리는 것이다 ... 1.2 4초.. 

// async Task<string> DownloadStringWithRetries(HttpClient client, string uri)
// {
//  TimeSpan nextDelay = TimeSpan.FromSeconds(1);
//
//  for (int i = 0; i != 3; ++i)
//  {
//   try
//   {
//    return await client.GetStringAsync(uri);
//   }
//   catch (Exception e)
//   {
//    
//   }
//
//   await Task.Delay(nextDelay);
//   nextDelay += nextDelay;
//  
//  }
//  return await client.GetStringAsync(uri);
// }


// async Task<string> DownloadStringWithTimeout(HttpClient client, string uri)
// {
//  using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(3)); // 타임아웃에 사용된다. 
//  Task<string> downloadTask = client.GetStringAsync(uri);
//  Task timeoutTask = Task.Delay(Timeout.Infinite, cts.Token);
//
//  Task completedTask = await Task.WhenAny(downloadTask, timeoutTask);
//  if (completedTask == timeoutTask)
//   return null;
//
//  return await downloadTask;
// }


// var test = new MySynchrousImplementation();
// var res = test.GetValueAsync();
// Console.WriteLine(res.Result);
//
// interface IMyAsyncInterface
// {
//  Task<int> GetValueAsync();
// }
//
// class MySynchrousImplementation : IMyAsyncInterface
// {
//
//  public Task<int> GetValueAsync()
//  {
//   return Task.FromResult(13); // task.FromResult를 사용하면 지정한 값으로 이미 완료한 Task<T> 새로 만들어서 반환.. , 성공적으로 완료한 작업만 제공한다.. 
//    // NotImplementedException등으로 완료한 작업은... Task.FromException 
//  }
// }

// readonly는 
//주기적으로 같은 값을 사용해서 Task.FromResult로 작업을 만들어야한다면  작업을 미리 만들어서 저장해 놓는 방법도 좋다. 
// Task<int> zeroTask = Task.FromResult(0);



// 문득 생각이든다.. readonly는 왜 local에서 지원을 해주지않는가?... -> 첫번재로 CLR이 지원해주지않는다 그리고 의미가 없는것이다.. LOCAL은 곧 사라지는데 머하러 readonly.. 

// 

// await CallMyMethodAsync();
//
// async Task CallMyMethodAsync()
// {
//  var progress = new Progress<double>();
//  progress.ProgressChanged += (sender, args) =>
//  {
//
//  };
//  await MyMethodAsync(progress);
// }
//
// async Task MyMethodAsync(IProgress<double> progress = null)
// {
//  bool done = false;
//  double percentComplete = 0;
//  
//  while (!done)
//  {
//    progress?.Report(percentComplete);
//  } 
// }


//======================================= Tuple Class===============================================

// var tuple = new Tuple<string, int>("asdf", 123);
// Console.WriteLine(tuple.Item1);
//
// //===================== VALUE Tuple...========================
// // tuple class에 비해 조금 더 간결하다.. 편리하고... 
// // (type fieldName 1, type fieldName 2) referenceVariable = (value1, value2,..);..
// // method parameters,.. return value로 사용가능.. 
// // 써보니 훨씨 명시적이긴하하다.. 
// var customer = new Customer();
// var customerInfo = customer.GetCustomerDetails(); // reference value..
//
// //Deconstructing..
// (int ID, string name, string email) = customer.GetCustomerDetails();
// Console.WriteLine(customerInfo.email);
//
// // Discard .. -> _ (underscore..)
// (int ID2, _, string email2) = customer.GetCustomerDetails();
//
// public class Customer
// {
//  public (int customerID, string customerName, string email) GetCustomerDetails()
//  {
//   return (101, "kcj3054", "kcjkcj");
//  }
//  
// }


// Entities -> model classses -> ex.. student
// Exceptions..
// 

//====================================== anonymous Types..

// var referenceVariable = new {Property1 = value, Property2 = value,..} 
// -> 위의 내용대로 하면 c# compliler가 익명 클래스이름으로 클래스하나를 만들어준다. 
// need store only once or twice in a big project..
// properties of anonymous types will be always 'public' and readonly'.
// properties null x 
// 
// Customer c = new();
// var person = new { Name = c.GetCustomerDetails().customerName, Age = c.GetCustomerDetails().email, Address = new{Street = "abc", City = "Daegu"} };
// Console.WriteLine(person.Address.City);
//
// public class Customer
// {
//  public (int customerID, string customerName, string email) GetCustomerDetails()
//  {
//   return (101, "kcj3054", "kcjkcj");
//  }
// }

// ============================= Nested Anonymous Types ==============================
// 익명 오브젝트 안에 익명 타입을 만들 수 있다 -> 그렇다면 두개의 익명 타입이 만들어지는 것.. 
// var referenceVariable = new {Property1 = value, Property2 = new{Prop1 = value, Prop2 = value}};
// ...


//======================Anonymous Arrays....======================
//same order, same type..
// var person = new[]
// {
//  new { PersonName = "ASDF", Email = "asdfa@asdfadf" },
//  new { PersonName = "ASDF", Email = "asdfa@asdfadf" },
//  new { PersonName = "ASDF", Email = "asdfa@asdfadf" },
//  new { PersonName = "ASDF", Email = "asdfa@asdfadf" },
// };


//======================= null 포기 연산자!  이것은 개발자가 100% 해당 값이 null아니라고 확신할 경우 사용하자.. 아니면 exception이 발생한다.. 
// 해당 구문을 사용하지않고 nullable에게 . 만 찍어서 사용하면 warning이 뜨는데 이것을 방지하려면 무조건 사용하기전에 null Check를 해야한다 
// 
// immutable class -> readonly field readonly properties.. .. 변하지 않는 값인데 만약 해당 부분에 멀티스레드가 접근한다면  immutable class로 만들면 관리하기 편하다.. 

// 'init' -> declaration in the constructor or in the object initializer..


// class BankAccount
// {
//  private readonly int _accountNubmer;
//  private readonly double _currentBal;
//
//  public BankAccount(int number, int balance)
//  {
//   _accountNubmer = number;
//   _currentBal = balance;
//  }
//
//  public int AccountNumber
//  {
//   get => _accountNubmer;
//   init => _accountNubmer = value; // 필드 초기화에만 사용가능하고 다른 곳에서는 값 변경 불가능
//  }
//  
// }

//lambda return type expression... 
// 

// Func<int, object> getResult = object (marks) =>
// {
//  if (marks >= 35)
//   return "Pass";
//  else
//   return 0;
// };
// // 시나리오2.. 
// var getNubmers = IList<int>() => new int[] { 10, 20, 30 };
// var result = getNubmers();
// // c# 10 -> string interpolation.. $ {}...



// =========================== default interface...============================ -> interface type으로만 해당 메소드를 부를수 있으?.., 추상뿐만 구체성까지도가능..

// public interface IEmployee
// {
//   public string Name { get; set; }
//
//   public string GetNameInUpperCase()
//   {
//    return Name.ToUpper();
//   }
//
//   string GetName(); // default가 public method이다.. 
// }
//
// public class Manager : IEmployee
// {
//  private string _name;
//  
//  public string Name { get => _name; set => _name = value; }
//
//  string IEmployee.GetName()
//  {
//   return "asdf";
//  }
//  
// }
//
// public class Clerk : IEmployee
// {
//  private string _name;
//  
//  public string Name { get => _name; set => _name = value; }
//
//  public string GetName()
//  { 
//   return "Asdfasdf";
//  }
// }


// record는 set이 아니라 init키워드로 들어가있다.. 
// 
//  var p1 = new Person("asdf", new Address("Daegu"));
//  var p2 = new Person("asdf", new Address("Daegu"));
//     
//  Console.WriteLine(p1.Equals(p2));
//
//  var p3 = p2;
//  Console.WriteLine(p3.Equals(p2));
//  
//  public record Address(string City)
//  {
//    public string? Country { get; set; }
//  }
// public record Person(string Name, Address PersonAddress);
// // recored의 with는 shallow copy, reference copy..
//
//
// public record P(string Name, DateTime? DateOfBirth, int? Age)
// {
//  public P(string name, DateTime? dateOfBirth) : this(name, dateOfBirth, null)
//  {
//   if (DateOfBirth is not null)
//   {
//    
//   }
//  }
// }
// Person p = new();
// p.Age = 20;
// public record struct Person(string? Name, int? Age);   // record struct , getset 가능 
// // -> record struct is..  struct.. internally..
// // -> read-writer properties by default...
// // 
//
//
// public interface IPerson
// {
//  string Name { get; init; }
// }
//
// public record PPerson(string? Name, DateTime? DateOfBirth, int? Age) : IPerson // IPerson이 set이 포함되면 안된다 왜냐 recore는 오직 recore로만초기화되어야.. 
// {
//  
// }

// static method in interface.. -> interface 내의 static method도 만들 수 있다.. 왜지?. 


// int sum = 0;
//
// Parallel.For(
//  1, 1001,
//  () => 0,
//  (x, state, tls) =>
//  {
//   tls += x;
//   return tls;
//  },
//  partialSum =>
//  {
//   // Console.WriteLine();
//   Interlocked.Add(ref sum, partialSum);
//  });

// //=====================Linq
//
// var employees = new List<Employees>()
// {
//  new Employees {EmplD = 101, EmpName = "Henry", Job = "Actor", Salary = 123123},
//  new Employees {EmplD = 101, EmpName = "Henry", Job = "Actor", Salary = 123123},
//  new Employees {EmplD = 101, EmpName = "Henry", Job = "Actor", Salary = 123123},
//  new Employees {EmplD = 101, EmpName = "Henry", Job = "Actor", Salary = 123123},
// };
// //ElementAt
//
// // ElementAtOrDefault.. 
// var res = employees.Where(emp => emp.Job == "Manager").ElementAtOrDefault(4);
//
// if (res != null)
// {
//   //
// }
// // 
//
// // Min Max, Average, Count...
//
// public class Employees
// {
//   public int EmplD { get; set; }
//   public string EmpName { get; set; }
//   public string Job { get; set; }
//   public int Salary { get; set; }
// }
//
// //======================== Linq



// var builder = WebApplication.CreateBuilder(new WebApplicationOptions
// {
//  EnvironmentName = Environments.Staging
// });
//
// Console.WriteLine($"Environment Name: {builder.Environment.EnvironmentName}");
//
// var app = builder.Build();