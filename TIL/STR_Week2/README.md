# 생성자와 종료자
### 생성자(Constructor) : 설계된 클래스의 객체를 생성하는 메소드와 같은 것
- 생성자 형식
- `한정자 클래스명 (매개변수명){ 코드 }`
```
class Person
{
    public Person(string _name,string _gender) // 기본 생성자
    {
        name = _name;
        gender = _gender;
    }
}

```

### 종료자 : 클래스의 이름에 ~를 붙여서 사용함.
- 생성자와 달리 한정자를 사용하지 않음
- 매개변수도 없고 오버로딩도 불가능함.
- 직접 호출 불가능.
- CLR의 가비지컬렉터가 객체가 소멸되는 시점을 판단해서 종료자를 호출함.

# Static(정적) 필드와 Static(정적) 메소드
### 정적 메소드
- 인스턴스를 직접 생성하지 않고 호출할 수 있음.
- static 키워드를 선언해서 만듦.
- 메소드 내부에서 객체의 멤버를 참조할 수 없고, 인스턴스에서 호출할 수 없음.
### 정적 필드
- 인스턴스를 직접 생성하지 않고 접근 할 수 있음.
- 자료형 앞에 static 키워드를 선언해서 만듦.
- 어디서든 접근이 가능함.

# 깊은 복사
### 얕은 복사
- 객체를 복사할 때 참조만 복사하는 것.
- 클래스를 복사하면 똑같은 힘 메모리 영역을 가리키게됨.
```
얕은복사 :

    class Person
    {
        public int age; // age 변수선언
        public int height;  // heigth 변수선언
        public Person(int age, int height)
        {
            this.age = age; 
            this.height = height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person myperson = new Person(15,160);
            Person yourperson = myperson;
            yourperson = myperson; // 같은 주소를 가르키게 됨
            // yourperson의 변수의 주소가 변경되도 myperson과 같은 주소를 가르켜 같은 값이 출력됨. 이를 보완하기 위해 깊은 복사를 사용함.
            yourperson.height = 180; 

            Console.WriteLine($"my : {myperson.height}");
            Console.WriteLine($"your : {yourperson.height}");
        }
    }

    출력 :
    my : 180
    your : 180

```

### 깊은 복사
- 객체를 복사할 때 별도의 힙 메모리 영역에 할당하는 것.
- 깊은 복사를 사용하면 얕은 복사의 단점을 보완할 수 있음.
- this 생성자로 사용가능.

``` 
class Person
{
    public int age;
    public int height;
    public Person(int age, int height)
    {
        this.age = age;
        this.height = height;
    }
    public Person DeepCopy()    // 깊은복사 메소드 선언
    {
        Person newperson = new Person(0,0); //newperson이라는 다른 객체선언.
        newperson.age = this.age;   
        newperson.height = this.height; // 새로운 객체에 내부값 복사.

        return newperson;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Person myperson = new Person(15,160);
        Person yourperson = myperson.DeepCopy(); // 서로 다른 객체를 참조함.
        yourperson.height = 180;

        Console.WriteLine($"my : {myperson.height}");
        Console.WriteLine($"your : {yourperson.height}");
    }
}

출력 :
my : 160
your : 180

```

### this, this() 생성자
- 객체가 자신을 지칭할 때 사용하는 키워드

# 접근 제한자 (Access Modifier)
### 접근제한자 (한정자) : 
- public, private, protected, internal, protected internal, private protected
- 클래스 멤버에 한정자가 설정되지 않았을 경우 무조건 private으로 자동 지정됨.
- public : 클래스의 내부 또는 외부에서 모든 곳에서 접근할 수 있는 지정자
- private : 클래스 외부에서는 접근을 할 수 없도록 하는 지정자, 즉, 내부에서만 접근이 가능하도록 만든 지정자, 상속받은 자식(파생)클래스에서도 접근이 허용이 안됨.
- protected : 클래스 외부에서는 접근 할 수 없도록 하는 지정자. 자식(파생)클래스에서는 접근이 가능함.
- internal : 동일 어셈블리에 있는 코드에서만 접근할 수 있음. 다른 어셈블리에 있는 코드에서는 접근이 안됨. 다른 어셈블리에 있는 코드에서는 private과 같은 접근 수준을 갖는다.
- protected internal : 동일 어셈블리에 있는 코드에서만 protected로 접근할 수 있음. 다른 어셈블리에 있는 코드에서는 private과 같은 접근 수준을 갖는다.
- private protected : 동일 어셈블리에 있는 클래스에서 상속받은 클래스 내부에서만 접근이 가능함. 

# 상속 (Inherit) 
```
   class Parent // 기반클래스
    {
        public void showInfo()
        {
            Console.WriteLine("asas");
        }
    }
    class Child : Parent // 파생클래스
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();

            child.showInfo();
        }
    }

출력 : asas

```
### base 키워드
- 기반 클래스를 가리키는 키워드. 기반클래스의 멤버를 접근할 때 사용할 수 있음.

### sealed 키워드
- 상속을 못하도록 봉인할 수 있음.
- sealed class 클래스 앞에 입력해 사용.

# 상속관계의 클래스 형변환
## As 연산자와 Is 연산자
- 객체를 형변환 할 때 사용한다.
### As 
- 형변환(캐스팅)과 같은 역할을 하는 연산자. 형변환에 실패했을 경우 null값을 리턴

### Is 
- 해당 객체의 타입(형식)이 일치하는지 여부를 bool값으로 반환하는 연산자.

# 오버라이딩(virtual, override, new) 
### 오버라이드 : 메소드 재정의
### virtual 
- 베이스(기반)클래스 메소드 앞에 붙는 키워드. 파생클래스에 의해서 재정의 될 수 있음.
### override 
- 파생클래스 메소드 앞에 붙는 키워드. 부모로부터 받은 메소드를 재정의함. 재정의 할 떄에는 부모의 메소드 이름과 프로토타입이 같아야한다.
### new
- 오버라이딩과는 다른 개념으로 메소드를 숨기는 기능.

# 구조체와 튜플
- C#에서는 struct를 사용하면 Value Type을 만들고, class를 사용하면 Reference Type. int, double, float, bool 타입들을 기본타입이라 하는데, struct로 정의된 Value Type은 상속될 수 없으며, 주로 간단한 데이터 값을 저장하는데 사용.
### 구조체
- struct라는 키워들를 이용해서 정의함. 클래스와 같이 메소드, 속성 등 거의 비슷한 구조를 가지고 있지만 상속할 수 없음. 클래스와 마찬가지로 인터페이스 구현을 할 수 있다.
- 모든 구조체는 System.Object 형식을 상속하는 System.ValueType으로부터 직접 상속받음
- 구조체는 클래스와 달리 복사를 할 때 깊은 복사(Deep Copy)가 이루어진다.
### Tuple(튜플)
- 여러개의 필드를 담을 수 있는 구조체.
- C# 7.0 이전 버전에서는 메소드에서 하나의 값만을 리턴할 수 있었지만, 이후 버전에서는 튜플을 이용해서 복수 개의 값을 리턴할 수 있다.
- var t = (100, 200) // --> Unnamed Tuple 튜플은 (item1, item2, ...) 안에 여러개의 필드를 지정하여 만들 수 있음.
- var t = (Name : "가나다", Id: "1234") // Named Tuple
- 도구 -> 패키지 관리자 -> Install-Pakage "System.ValueTuple" // 튜플이 설치됨

# 인터페이스
### 인터페이스 선언
```
interface 인터페이스명
{
    반환형식 메소드명(매개변수, ...); // {} 없음 -> 구현부가 없다. (추상메소드)
    ...
}
```
- 인터페이스는 필드를 포함하지 않는다. (이벤트, 메소드, 프로퍼티만을 멤버로 갖는다.)
- 인터페이스의 모든 멤버는 public 접근 권한으로 지정된다. 따라서 접근제한자를 사용할 수 없다. 
- 인터페이스는 구현부가 없는 추상멤버를 갖는다.
- 인터페이스는 다중 상속이 가능하다. 인터페이스는 다른 인터페이스를 상속 받을 수 있다. 클래스와 구조체에서도 인터페이스를 상속 받을 수 있다.
- 인터페이스는 인스턴스를 만들 수 없다.
- C#에서는 클래스 다중상속이 불가능하다.

# 추상클래스
- 인터페이스와 비슷하지만, 추상클래스는 구현부를 가질 수 있다. 인스턴스는 가질 수 없다.
- 사용하는 한정자는 abstract와 class를 사용한다. 
```
추상 클래스의 선언 형식

abstract class 클래스명
{
    클래스와 동일한 형식;
}

- 추상 클래스는 클래스와 달리 추상 메소드를 갖고 있다.
- 추상 클래스는 모든 멤버에 접근 제한자를 사용하지 않을 경우 private 설정된다.
```

```
추상 메소드의 선언 형식

public abstract void A();

- 추상 메소드는 private이 될 수 없기 떄문에 C# 컴파일러는 public, protected. internal, protected internal 중 하나로 수식되도록 한다.
```

# 프로퍼티
```
선언형식

데이터타입 필드명;
접근제한자 데이터타입 프로퍼티명
{

    get
    {
        return 필드명;
    }

    set
    {
        필드명 = Value; 
    }

}

- Value는 키워드 -> 변수가 아님.
- get, set은 접근자 (accessor)
```

# 자동 프로퍼티
- 자동 프로퍼티 기능은 C# 3.0에서 도입된 기능
- C# 7.0부터는 자동프로퍼티 기능에 초기값이 필요할 때 초기화 코드를 작성해야하는 불편함을 해소할 수 있도록 초기값을 바로 설정할 수 있다.
- 프로퍼티의 형식을 제한자 데이터타입 프로퍼티명 { get; set; } 으로 간소화.
```
class EmployeeInfo
{
    public string Name { get; set; }; // {get; set;} 으로 간소화가 가능하다.
    public DateTime EntryDate { get; set; };

    public int ServiceLength
    {
        get
        {
            // 1Tick(틱)은 100ns(천만분의 1초). 1ms는 10,000 tick
            return new DateTime(DateTime.Now.Subtract(EntryDate).Ticks).Year;
        }
    }
}

```

```
객체를 생성할 때 객체의 필드를 초기화하는 다른 방법

EmployeeInfo emp = new EmployeeInfo()
{
   Name = "kim",
   EntryDate = new DateTime(2020, 01, 02)
};
```
### 인터페이스에서 프로퍼티 사용하기
- 인터페이스에서 자동 프로퍼티는 C# 컴파일러가 자동으로 구현해주지 않는다.
- 따라서, 해당 인터페이스를 상속받는 클래스에서 구현해주어야 한다.

```
 interface IKeyValue
 {
     // 인터페이스에서 자동 프로퍼티는 C# 컴파일러가 자동으로 구현해주지 않는다.
     string Key { get; set; }
     string Value { get; set; }
 }

 class KeyValue : IKeyValue
 {
     // IKeyValue의 인터페이스를 구현해주고 있음. (컴파일러가 자동으로 프로퍼티 구현을 해줌.)
     public string Key { get; set; }
     public string Value { get; set; }

 }

 class Program
 {
     static void Main(string[] args)
     {
         KeyValue school = new KeyValue() 
         { 
             Key = "Highschool",
             Value = "Dongah"
         };

         Console.WriteLine($"{school.Key}: {school.Value}");
     }
 }

출력 :
Highschool: Dongah
```

### 추상 프로퍼티 :  abstract가 붙어있어 구현이 안된 프로퍼티

# 컬렉션
- 데이터의 모음을 담는 자료구조. 배열이나 스택, 큐 등을 C# 에서는 컬렉션
- .NET 프레임워크에서 사용하는 컬렉션은 ICollection 인터페이스를 상속받음 
- 배열은 System.Array 타입
- ArrayList, Queue, Stack, Hashtable
- C#에서 제공하는 모든 컬렉션은 모든 타입의 변수를 담을 수 있다. (컬렉션의 요소들은 object 타입으로 저장됨)
- 컬렉션을 사용하기 위해선 `using System.Collections;` 을 입력해야함.

## ArrayList
- 배열과 비슷한 컬렉션. 배열처럼 [] 인덱스로 요소의 접근이 가능하고, 특정 요소를 바로 읽고 쓸 수 있다.
- 배열은 선언할 때 배열의 크기를 지정해야 하지만, ArrayList는 크기를 지정하지 않는다. 요소의 추가, 삭제에 따라 자동으로 크기가 결정됨.

```
ArrayList arrayList = new ArrayList();

// 순서대로 하나씩 추가.
arrayList.Add(1); // 1
arrayList.Add(2); // 1, 2
arrayList.Add(100); // 1, 2, 100

// 인덱스 위치에 요소를 추가함.
arrayList.Insert(1, 2.2f); // 1, 2.2, 2, 100 (순서가 밀림.)

// 인덱스 위치의 요소를 제거함(2번째 요소 제거)
arrayList.RemoveAt(1); // 2.2, 2, 100
// 그 순서의 요소를 제거함 (1번째 요소 제거)
arrayList.Remove(1); // 2 100

// foreach 로 활용이 가능함.
foreach (object obj in arrayList)
    Console.Write($"{obj} ");

출력 :
2 100
```

```
// 컬렉션 초기자를 이용한 초기화 방법
// 컬렉션 초기자는 IEnumerable 인터페이스를 상속받아 Add() 메소드를 구현하고 있다.
ArrayList arrayList = new ArrayList() { 10, 20, 30 }; // Stack, Queue에서는 사용할 수 없음

int[] arr = { 11, 22, 33, 44 };
ArrayList arrL = new ArrayList(arr); // ArrayList arrL에 arr값을 넣어 초기화 할 수 있음.

```

## Queue
- 선입선출 (FIFO : First In First Out)의 자료구조.
- Enqueue : 데이터 입력
- Dequeue : 데이터 출력
```
 Queue arr = new Queue();

 // Enqueue 값을 순서대로 추가
 arr.Enqueue(1); // 1
 arr.Enqueue(100); // 1, 100
 arr.Enqueue(500); // 1, 100, 500
 // Dequeue 먼저 들어온 값을 내보냄.
 arr.Dequeue(); // 100, 500
 arr.Enqueue(2.2); // 100, 500, 2.2
 arr.Dequeue(); // 500, 2.2
 arr.Enqueue("가나다"); // 500, 2.2, 가나다
 
 // arr.Count - 컬렉션의 길이
 while (arr.Count > 0) Console.WriteLine(arr.Dequeue()); // 큐 컬렉션을 출력한다

출력 :

500
2.2
가나다
```
```
int[] arr = { 11, 22, 33, 44 };
Queue arrL = new Queue(arr); // Queue arrL에 arr값을 넣어 초기화 할 수 있음.
```


## Stack
- 후입선출 (LIFO : Late In First Out)의 자료구조
- Push : 데이터 입력
- Pop : 데이터 출력

```
Stack arr = new Stack();

arr.Push(100); // 100
arr.Push(200); // 100, 200
arr.Pop(); // 100
arr.Push(2.2); // 100, 2.2
arr.Pop(); // 100
arr.Push("가나다"); // 100, 가나다

// 늦게 들어온 데이터부터 출력
while (arr.Count > 0) Console.WriteLine(arr.Pop());

출력 :
가나다
100
```

```
int[] arr = { 11, 22, 33, 44 };
Stack arrL = new Stack(arr); // Stack arrL에 arr값을 넣어 초기화 할 수 있음.
```

## Hashtable
- hashing 알고리즘을 이용한 데이터 검색이 이루어지는 방식의 자료구조
- 키를 이용해서 한번에 데이터가 저장되어 있는 컬렉션 내의 주소를 계산해낸다.
```
Hashtable arr = new Hashtable();

// 키의 이름을 직접 지정해 주소 검색이 간단함.
arr["Apple"] = "사과";
arr["Orange"] = "오렌지";
arr["Banana"] = "바나나";

Console.WriteLine(arr["Apple"]);        
Console.WriteLine(arr["Orange"]);        
Console.WriteLine(arr["Banana"]);        

출력 :
사과
오렌지
바나나
```

- Hashtable의 초기화는 Dictionary Initialiaer를 이용할 수 있다.
```
Hashtable ht = new Hashtable()
{
    ["Seoul"] = "서울",
    ["Deajeon"] = "대전",
};
```

## 인덱서(Indexer) 
- 클래스 객체의 데이터를 배열 형태로 인덱스를 사용해서 액세스할 수 있도록 해주는 것.
- 객체를 마치 배열처럼 사용할 수 있도록 해준다.
```
인덱스 선언방법

class 클래스명
{
    접근제한자 인덱서형식 this[형식 index]
    {
        get
        {
            index를 이용해서 내부 데이터를 반환
        }

        set
        {
            index를 이용해서 내부 데이터를 저장
        }
    }
}
```
```
 class DemoList
 {
     private int[] arr;

     public DemoList()
     {
         arr = new int[4];
     }

     public int this[int index]
     {
         get
         {
             return arr[index];
         }
         set
         {
             if (index >= arr.Length)
             {
                 Array.Resize<int>(ref arr, index + 1);
                 Console.WriteLine($"배열 사이즈 조정 : {arr.Length}");
             }
             arr[index] = value;
         }
     }
         public int Length
         {
         get { return arr.Length; }
         }
 }
 
 class Program
 {
     static void Main(string[] args)
     {
         DemoList list = new DemoList();
         for(int i = 0; i < 5; i++)
         {
             list[i] = i;
         }
     for (int i = 0; i < list.Length; i++) Console.WriteLine(list[i]);
     

     }
 }

출력 :
배열 사이즈 조정 : 5
0
1
2
3
4
```

## yield 키워드
- Enumerator(Iterator) : 집합적인 데이터셋으로부터 데이터를 하나씩 호출자에게 보내주도록 하는 기능
- yield 키워드는 호출자에게 컬렉션 데이터를 하나씩 리턴할 때 사용하는 키워드
- yield 사용방식
    1. yield retrun : 컬렉션 데이터를 하나씩 리턴하는데 사용
    2. yield break : 리턴을 중지하고 Iteration 루프를 빠져나올때 사용
- 컬렉션 클래스는 Enumeration이 가능한 클래스인데, 이러한 클래스들을 Enumerable 클래스라 한다.
이 Enumerable 클래스는 IEnumerable 인터페이스를 구현해야한다.
- IEnumerable 인터페이스는 GetEnumerator()메소드 하나를 가지고 있다. 이 GetEnumeratot() 메소드는 IEnumerator 구현한 객체를 리턴해준다.
- 컬렉션 타입이나 또는 Enumerable 클래스에서 GetEnumerator() 메소드를 구현하는 방법으로 yield 키워드를 사용할 수있다.
- GetEnumerator()메소드에서 yield return 사용하면 컬렉션 데이터를 순차적으로 하나씩 넘겨주는 코드를 구현할 수 이쏙, 리턴타입은 IEnumerator 인터페이스를 리턴할 수 있다.

```
class MyList
{
    private int[] data = { 1, 2, 3, 4, 5 };

    public IEnumerator GetEnumerator()
    {
        int i = 0;
        while (i < data.Length)
        {
            yield return data[i];
            i++;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        var list = new MyList();

        foreach (var item in list) Console.WriteLine(item);
    }
}

출력:
1
2
3
4
5
```
