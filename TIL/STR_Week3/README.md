# 제네릭스 (Generics)
- Generics : int, float, double 같은 데이터 타입을 확정하지 않고 이 데이터 타입 자체를 타입 파라미터(Type Parameter)로 받아들이도록 하는 기능 

## 일반화 메소드
```
일반화 메소드 선언 형식

접근제한자 반환형식 메소드이름 <T(형식매개변수)> (매개변수)
{

}
```

```
void CopyData<T>(T a, T b) // T 는 Type을 뜻함.
{
    b = a; // 문자열 b에 a를 복사 
}

```

```
 class Program
 {
    // 일반화 메소드
     static void CopyData<T>( T[] a , T[] b)
     {
         for (int i = 0; i < a.Length; i++)
         {
             b[i] = a[i];
         }
     }
     static void Main(string[] args)
     {
         int[] a = { 11, 2, 22, 34, 56, 7 };
         int[] b = new int[a.Length];

         CopyData<int>(a, b);
         
         foreach(int item in b)
         {
             Console.WriteLine(item);
         }
     }
 }

출력 : 
11
2
22
34
56
7
```

## 일반화 클래스
```
일반화 클래스 선언방식
- 일반화 클래스는 똑같은 기능을 하지만 내부적으로 사용하는 데이터 형식이 다를 경우에 사용하면 편리하다.

class 클래스명 <T>
{

}
```
```
class DemoList
{
    private int[] arr;

    public int GetItem(int idx) { return arr[idx]}
}

class DemoList2
{
    private double[] arr;

    public double GetItem(int idx) {return arr[idx]}
}
```
- 제너릭을 사용하지 않은 클래스의 다른 형식을 만들려면 클래스를 여러개 만들어야 한다.


```
class DemoList<T>
{
    private T[] arr;

    public T GetItem(int idx) {return arr[idx];}
}

DemoList<int> demoList1 = new DemoList<int>();
DemoList<double> demoList2 = new DemoList<double>();
```
- 제네릭을 사용한 클래스는 하나의 클래스로도 여러개의 데이터형식을 구현할 수 있다.

# 제네릭스 타입 제약
- 앞의 일반화 메소드, 일반화 클래스에서 사용하던 T는 모든 데이터 형식을 대신할 수 있는 매개변수로 사용했다.
- 모든 형식을 대신하는 매개변수가 필요할 수도 있지만 그렇지 않은 경우도 종종있다. 그런 경우에는 매개변수에 제약 조건을 줄 수 있다.
- 제약조건을 주는 방법으로 where 절을 이용한다.

```
class DemoList<T> where T: Democlass
{

}
```
- 위의 경우는 T라고 하는 매개변수는 DemoClass로부터 상속받는 형식이어야한다는 의미이다.
```
void CopyData<T>(T a , T b) where T : struct
{

}
```

- 위의 경우 T는 "값 형식이어야 한다" 라는 제약조건을 준 의미이다.
제네릭스에서 제약조건을 주는 방식은 where T : 제약조건

### 제약조건의 종류
- where T : struct  : T가 값형식이어야 한다.
- where T : class  :  T는 참조형식이어야 한다.
- where T : new() : T는 반드시 매개변수가 없는 생성자가 있어야 한다. (기본 생성자가 없으면 안됨.)
- where T : 기반클래스명 : T는 기반 클래스의 파생 클래스이어야 한다.
- where T : 인터페이스명 : T는 인터페이스를 반드시 구현해야 한다.
- where T : U : T는 또 다른 형식의 매개변수 U로부터 상속받은 클래스이어야한다.

# 제네릭 컬렉션
- object 형식에 기반한 컬렉션의 문제들을 해결하는 방법으로 사용됨.
- Generic 기반으로 만들어져 있기 때문에 컴파일할 때 사용할 형식이 정해져 형변환 발생이 줄어듦. 컬렉션이 가지고 있는 성능상의 문제를 해결할 수 있음.
- ArrayLsit -> `List <T>`
- Queue -> `Queue <T>`
- Stack -> `Stack <T>`
- Hashtable -> `Dictionary <TKey, TValue>`

# 예외처리 (Exception Handling)
-  프로그램에서 발생한 프로그램 에러를 대처하는 함수.

```
예외처리 구문
try
{
    // 실행코드
}

catch(Exception 객체)
{
    // 예외가 발생했을 때 처리 코드 -> catch문 여러개를 만들 수 있음.
}
```   
```
static void Main(string[] args)
{
    int[] arr = { 1, 2, 3, 4 };

    try // 오류가 발생할 코드 입력
    {
        for (int i = 0; i <  5;  i++) // 오류가 발생할 코드
        {
            Console.WriteLine(arr[i]);
        }
    }

    catch(IndexOutOfRangeException e) // 해당 오류가 발생했을 때 실행할 코드.
    {
        Console.WriteLine($"오류가 발생함 : {e.Message}"); // 오류 메세지
    }
}

출력 :
1
2
3
4
오류가 발생함 : Index was outside the bounds of the array.
```

### System.Exception 클래스
- System.Exception : 모든 Exception의 Base 클래스이다.

### throw문
- 발생한 예외를 catch로 던져준다.
```
try
{
    // 실행코드
    throw new Exception("error");
}

catch(Exception 객체)
{
    Console.WriteLine(e.Message); // throw가 던진 에러를 catch가 받음.
}

출력 : error
```
- 7.0에서는 throw문 표현식으로 구현이 가능하다.

```
if(name == null)
{
    throw new ArgumentException();
} this._name = name;
```
위 처럼 사용하던 문장을
```
this._name = name ?? throw new ArgumentException();
```
위 처럼 하나의 식으로 간단히 바꿀 수 있다.


### Null병합연산자
- int? 형으로 사용하면 null값으로 설정이 가능하다.
- 왼쪽의 피연산자가 null인지 체크하고,  null인 경우 오른쪽 피연산자를 리턴하고, null이 아니면 왼쪽 피연산자를 그대로 리턴한다.
- `a ?? 100` 에서 a값이 null이면 100을 리턴, null이 아니면 a의 값 리턴.

### finally 절
- 예외가 발생하더라도 반드시 실행되는 절

```
try
{
    // Exception 클래스에 에러 메시지를 지정하여 무조건 에러 발생
    throw new Exception("error");
}

catch (Exception e)
{
    Console.WriteLine($"예외(에러)가 발생됨 : {e.Message}");
}

finally
{
    // 예외가 발생해도 무조건 실행
    Console.WriteLine("try 구문을 정상 종료합니다.");
}

출력 :
예외(에러)가 발생됨 : error
try 구문을 정상 종료합니다.
```
## 예외 필터
- Exception Filter : catch절이 받아들일 예외 객체에 제약사항을 주고 그 사항에 만족하는 경우 예외 처리를 실행하는 기능.
- catch문 뒤에 when 키워드 사용.

```
bool a = true;
try
{
    throw new Exception("error");
}
catch(Exception e) when(a == true)
{
    Console.WriteLine(e.Message);
}

출력 : 
error
```

# 델리게이트
- 델리게이트(대리자) : 메소드를 다른 메소드로 전달할 수 있도록 하기 위해서 만들어진 것.

```
void A(MyDelegate method)
{
    
}

delegate int MyDelegate(string str);

MyDelegate myDelegate = new MyDelegate();

```

```
class Program
{
    // 델리게이트 정의
    delegate int MyDelegate(string str);

    void TestMethod()
    {
        // 델리게이트 객체 생성
        MyDelegate md = new MyDelegate(StringToInt);
        A(md);
    }

    // 델리게이트에 대상이 되는 메소드
    int StringToInt(string str)
    {
        return int.Parse(str);
    }

    // 델리게이트를 전달받는 메소드
    void A(MyDelegate md)
    {
        int i = md("100");

        Console.WriteLine(i);
    }
    static void Main(string[] args)
    {
        new Program().TestMethod();
    }
}

출력 :
100
```

```
delegate int Mydelegate(int a, int b);
class SumSubtract
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
    public static int Subtract(int a, int b)
    {
        return a - b;
    }
}
class Program
{


    static void Main(string[] args)
    {
        SumSubtract s = new SumSubtract();
        Mydelegate md = new Mydelegate(s.Sum);
        Console.WriteLine(md(1, 2));
        md = new Mydelegate(SumSubtract.Subtract);
        Console.WriteLine(md(10, 5));
    }
}

출력:
3
5
```

### 델리게이트 체인
- 델리게이트 하나가 여러개의 메소드를 동시에 참조하는 것
```
delegate void CalcDelegate(int a, int b);
class Program
{
    static void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    static void Sub(int a, int b)
    {
        Console.WriteLine(a - b);
    }
    static void Mul(int a, int b)
    {
        Console.WriteLine(a * b);
    }
    static void Div(int a, int b)
    {
        Console.WriteLine(a / b);
    }
    static void Mod(int a, int b)
    {
        Console.WriteLine(a % b);
    }

    static void Main(string[] args)
    {
        CalcDelegate room = Add;
        room += Sub;    // 메소드 체인 1번째 방법
        room += Mul;    // 메소드를 연결할 수 있다.
        room += Div;
        room += Mod;
        room -= Mod;    // 메소드 제거

        room(10, 5);

        Console.WriteLine("-------")

        CalcDelegate roomA = new CalcDelegate(Add)
            + Sub   // 메소드 체인 2번째 방법
            + Mul
            + Div
            + Mod;

        roomA(10, 5);               
    }
}

출력 :
15
5
50
2
-------
15
5
50
2
0
```

# 익명 메소드 (Anonymous Method)
- 이름이 없는 메소드.
- C# 2.0 부터 지원된 기능.
- 나중에 사용할 일이 많지 않다 판단될때 유용하게 사용됨.

```
선언형식

델리게이트 인스턴스 = delegate(매개변수)
{
    실행 코드 ... 
}
```

```
버블배열 예제
class Program
{
    // 무명메소드 선언
    delegate int SelSort(int a, int b);

    // 
    static void BSort(int[] arr, SelSort sel)
    {
        int temp = 0;
        for (int i = 0; i < arr.Length-1; i++)
        {
            for (int j = 0; j < arr.Length-(i+1); j++)
            {
                if (sel(arr[j], arr[j + 1]) > 0)
                {
                    temp = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
    static void Main(string[] args)
    {
        int[] arr = { 2, 4, 5, 1, 6, 12, 9 };

        Console.WriteLine("오름차순 ~");

        BSort(arr, delegate (int a, int b)
        {
            if (a > b) return 1;
            else if (a == b) return 0;
            else return -1;
        });

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }

        Console.WriteLine("\n내림차순 ~");

        BSort(arr, delegate (int a, int b)
        {
            if (a > b) return -1;
            else if (a == b) return 0;
            else return 1;
        });

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }

    }
}


출력 :
오름차순 ~
1 2 4 5 6 9 12
내림차순 ~
12 9 6 5 4 2 1
```

# 이벤트 (Event)
- 특정한 일(클릭, 키보드 입력 등)이 일어났음을 알려주는 기능.
- event 키워드를 이용해 표시함.


이벤트 선언순서
1. delegate를 선언
2. 선언된 delegate에 event 키워드를 붙여줌
3. 이벤트 핸들러 작성.
4. 선언된 delegate의 프로토타입과 동일하게 메소드 작성
5. 클래스 인스턴스를 생성하고 이 객체에 이벤트 핸들러를 등록.
6. 이벤트가 발생하면 이벤트 핸들러가 호출됨.

```
delegate void EventHandler(string msg);

class EventDemo
{
    public event EventHandler eventHandler;

    public void TestMethod(int a)
    {
        if (a % 2 == 0)
        {
            eventHandler(String.Format($"{a} : 짝수"));
        }
    }
}
class Program
{
    static public void MyHandler(string msg)
    {
        Console.WriteLine(msg);
    }
    static void Main(string[] args)
    {
        EventDemo myDemo = new EventDemo();
        myDemo.eventHandler += new EventHandler(MyHandler);
        for (int i = 1; i < 20; i++)
        {
            myDemo.TestMethod(i);
        }
    }
}

출력:
2 : 짝수
4 : 짝수
6 : 짝수
8 : 짝수
10 : 짝수
12 : 짝수
14 : 짝수
16 : 짝수
18 : 짝수 
```

# 람다식 (Lambda)
- 익명 메소드를 만들기 위해 사용하는 식
- 람다식으로 만들어진 익명메소드를 무명 함수(Anonymous Function).
```
람다식 선언 형식

매개변수 목록 => 식 // "=>" 입력 연산자

ex)
delegate int Sum(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            Sum sum = (a, b) => a + b;  // 매개변수 대신 블록{} 사용 가능
            Console.WriteLine($"{sum(10, 20)}"); 
        }
    }

출력 : 30

위 익명 메소드(무명함수)는 기존 익명 메소드보다 간소화 됨.
```

# LINQ
- LINQ (Language INtegrated Query) : C# 언어에 통합된 데이터 질의 기능

### LINQ의 질의표현식( Query Expression )

1. from 절
    - from 절 다음에는 데이터 원본 (배열 또는 컬렉션 등) 이 온다.
    - `from 범위변수 in 데이터 원본`

2. where 절
    - 범위 변수의 조건을 지정해 그 조건에 해당하는 데이터를 걸러낸다.

3. orderby 절
    - where절에서 걸러진 데이터를 정렬한다.
    - 기본 정렬값은 오름차순(ascending) (decending 키워드를 붙이면 내림차순)

4. select 절
    - 질의의 최종 결과를 추출한다.

```
var members = from member in memberList // LINQ
              where member.age >= 30
              orderby member.age
              select member;
```




```
class Member
{
    public string Name { get; set; }
    public int age { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Member[] memberList =
        {
            new Member() {Name = "kim", age = 25},
            new Member() {Name = "park", age = 50},
            new Member() {Name = "lee", age = 30},
            new Member() {Name = "choi", age = 20},
        };

        var members = from member in memberList // LINQ
                      where member.age >= 30
                      orderby member.age
                      select member;

        foreach (var member in members) Console.WriteLine($"{member.Name}, {member.age}");
        
    }
}

출력 : 
lee, 30
park, 50

```

### 익명 타입
- 일반적으로 클래스를 사용하기 위해서는 먼저 클래스를 정의한 후에 사용한다.
- C#3.0 에서는 클래스를 미리 정의하지 않고 사용할 수 있도록 익명타입 기능을 제공하게 됨.
- `new {속성1 = 값, 속성2 =값;}`
```
var v = new { Name = "kim", Age = 33};
Console.WriteLine($"이름 : {v.Name}, 나이 {v.Age}세");

출력:
이름 : kim, 나이 33세
```

```
익명 타입과 LINQ를 활용한 예제
class MemberScore
{
    public string Name { get; set; }
    public int[] Score { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        MemberScore[] ms =
        {
            new MemberScore(){Name = "kim", Score=new int[]{ 99, 75, 80 } },
            new MemberScore(){Name = "lee", Score=new int[]{ 79, 53, 52 } },
            new MemberScore(){Name = "park", Score=new int[]{ 42, 27, 30 } },
            new MemberScore(){Name = "choi", Score=new int[]{ 32, 17, 90 } }
        };
        var Members = from m in ms
                      from s in m.Score
                      where s < 60
                      orderby s
                      select new { m.Name, Fscore = s };

        foreach (var m in Members) Console.WriteLine($"탈락 : {m.Name}, {m.Fscore}");
    }
}

출력 :
탈락 : choi, 17
탈락 : park, 27
탈락 : park, 30
탈락 : choi, 32
탈락 : park, 42
탈락 : lee, 52
탈락 : lee, 53
```

### group by
- `group X by Y into Z`
- X : from 절에서 가져온 범위변수
- Y : 분류기준
- Z : 그룹변수

```
LINQ와 group by를 활용한 예제

class Member
{
    public int Age { get; set; }
    public string Name { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Member[] memberList =
        {
            new Member(){Name = "steve", Age = 50},
            new Member(){Name = "kim", Age = 24},
            new Member(){Name = "lee", Age = 53},
            new Member(){Name = "park", Age = 30},
            new Member(){Name = "choi", Age = 10},
        };

        var GroupMember = from member in memberList
                    group member by member.Age > 30 into g
                    select new { groupKey = g.Key, members = g };

        foreach (var Group in GroupMember)
        {
            if (Group.groupKey)
            {
                Console.WriteLine("<30대 멤버>");
                foreach (var member in Group.members)
                    Console.WriteLine($"이름 : {member.Name}, 나이 : {member.Age}");
            }
            else
            {
                Console.WriteLine("<30대 미만 멤버>");
                foreach (var member in Group.members)
                    Console.WriteLine($"이름 : {member.Name}, 나이 : {member.Age}");
            }
        }
    }
}

출력 :
<30대 멤버>
이름 : steve, 나이 : 50
이름 : lee, 나이 : 53
<30대 미만 멤버>
이름 : kim, 나이 : 24
이름 : park, 나이 : 30
이름 : choi, 나이 : 10
```

### Join
- Join : 두 데이터를 합치는 것
- 내부 조인 (inner join) : 두 데이터에 일치하는 데이터들(교집합)만 연결해서 반환
- 외부 조인 (outer join) : 기본적으로 내부 조인과 비슷하지만, 조건이 일치하지 않더라도 기준 데이터를 하나도 누락시키지 않고 그대로 추출해 빈 데이터를 채워서 통합하는 방식.

```
join 형식

from a in A
join b in B on a.속성 equals b.속성
```
```
외부조인 형식

from a in A
join b in B on a.속성 equals b.속성 into temp
from b in temp.DefaultEmpty(new a() {empty = ""})
```
```
내부조인 예제

 class Program
 {
     class Student
     {
         public int age { get; set; }
         public string name { get; set; }
     }
     class Score
     {
         public string name { get; set; }
         public int math { get; set; }
         public int eng { get; set; }
     }
     static void Main(string[] args)
     {
         Student[] studentList =
         {
             new Student () {name = "kim", age = 21},
             new Student () {name = "choi", age = 22},
             new Student () {name = "park", age = 25},
             new Student () {name = "choi", age = 20},
         };

         Score[] scoreList =
         {
             new Score(){name = "kim", math = 90, eng = 60},
             new Score(){name = "cho", math = 40, eng = 80},
             new Score(){name = "park", math = 29, eng = 50},
             new Score(){name = "steve", math = 99, eng = 68}
         };

         var Students = from student in studentList
                        join score in scoreList on student.name equals score.name
                        select new
                        {
                            Name = student.name,
                            Age = student.age,
                            Math = score.math,
                            Eng = score.eng
                        };
         foreach (var student in Students)
         {
             Console.WriteLine($"이름 : {student.Name}, 나이: {student.Age}");
             Console.WriteLine($"수학 : {student.Math}, 영어 : {student.Eng}");
         }
     }
 }

출력:
이름 : kim, 나이: 21
수학 : 90, 영어 : 60
이름 : park, 나이: 25
수학 : 29, 영어 : 50
```

```
외부조인 예제

 class Program
 {
     class Student
     {
         public int age { get; set; }
         public string name { get; set; }
     }
     class Score
     {
         public string name { get; set; }
         public int math { get; set; }
         public int eng { get; set; }
     }
     static void Main(string[] args)
     {
         Student[] studentList =
         {
             new Student () {name = "kim", age = 21},
             new Student () {name = "choi", age = 22},
             new Student () {name = "park", age = 25},
             new Student () {name = "lee", age = 20},
         };

         Score[] scoreList =
         {
             new Score(){name = "kim", math = 90, eng = 60},
             new Score(){name = "cho", math = 40, eng = 80},
             new Score(){name = "park", math = 29, eng = 50},
             new Score(){name = "steve", math = 99, eng = 68}
         };

         

         var Students = from student in studentList
                        join score in scoreList on student.name equals score.name into temp
                        from score in temp.DefaultIfEmpty(new Score() { math = 100, eng = 100})
                        select new
                        {
                            Name = student.name,
                            Age = student.age,
                            Math = score.math,
                            Eng = score.eng
                        };
         foreach (var student in Students)
         {
             Console.WriteLine($"이름 : {student.Name}, 나이: {student.Age}");
             Console.WriteLine($"수학 : {student.Math}, 영어 : {student.Eng}");
         }
     }
 }

출력:
이름 : kim, 나이: 21
수학 : 90, 영어 : 60
이름 : choi, 나이: 22
수학 : 100, 영어 : 100
이름 : park, 나이: 25
수학 : 29, 영어 : 50
이름 : lee, 나이: 20
수학 : 100, 영어 : 100
```

# 확장 메소드

- 기존 클래스의 기능을 확장하는 기법
- 상속과 구별하여 생각하면 이해하기에 쉬움.

```
선언형식

public static class 클래스명
{
    public static 반환형식 메소드명 (this 형식 식별자, 매개변수)
    {

    }
}
```

```
public static class MyExtension
{
    public static void ShowMyIntList(this int n, int n2)
    {
        Console.WriteLine($"{n} {n2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n = 100;
        
        n.ShowMyIntList();
        n.ShowMyIntList(200);
        1000.ShowMyIntList();
    }
}

출력 :
100
100 200
1000
```

```
public static class MyClass
{
    public int speed;

    public void AddSpeed(int s)
    {
        this.speed += s;
    }

    public void DisplaySpeed()
    {
        Console.WriteLine($"현재 속도 : {this.speed}");
    }
}

public static class MyClassExt
{
    public static void MinusSpeed(this MyClass mc, int s)
    {
        mc.speed -= s;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass mc = new MyClass();
        mc.AddSpeed(100);
        mc.DisplaySpeed();

        mc.MinusSpeed(10);
        mc.DisplaySpeed();
    }
}

출력 :
현재 속도 : 100
현재 속도 : 90
```