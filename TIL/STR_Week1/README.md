# C#소개 및 개발 환경 구축
### C#언어
- .NET Framework에 최적화된 언어 -> 인터넷 서비스에 주로 사용되는 라이브러리
- 프로그래머의 생산성 향상
- 배우고 활용하기 쉬움.

# Hello  프로젝트 만들어보기
- Visual Studio 접속 -> 새로 만들기 -> 콘솔 앱(.NET Framework)
- `Console.Write("내용");` 원하는 내용 출력하기. ( WriteLine으로 쓰면 줄바꿈 )
- `Console.ReadKey();` 어떤 키가 눌러질 때까지 대기.
- `Console.Write("Hello" + 변수);` Hello가 출력되고 변수 출력.

# 커멘드 라인에서 인수 받아 처리해보기
1. cmd에서 실행하기.
2. 원하는 프로젝트 exe 파일에 있는 폴더까지 경로 복사.
3. cmd에 입력 후 exe파일의 이름 입력.
- exe 파일명 뒤에 단어를 입력. -> args[0]부터 대입됨.

예)
```
Visual studio code -> Console.Write("Hello!" + args[0]);

CMD input -> HelloWorld_HHS 황효성

CMD output -> Hello! 황효성
```
- args = 인수
- args.Length = 인수의 수

# 변수와 데이터 형식
### 논리형
- bool : True or False
### 정수형
- byte : 8비트 unsigned 정수형
- sbyte : 8비트 signed 정수형
- short : 16비트 signed 정수형
- int : 32비트 signed 정수형
- long : 64비트 signed 정수형
- 변수 명령어 앞에 u를 붙이면 unsigned
### 실수형
- float : 32비트 실수형
- double : 64비트 실수형
- decimal : 128비트 실수형 (float, double보다 더 정밀한 소수)
### 문자형
- char : 16비트 유니코드 문자
- string : 유니코드 문자열

# 데이터의 범위와 리터럴 데이터
- 리터럴 데이터 : 123,True,"ABC" 와 같은 값들을 리터럴 데이터라 부름.
- 데이터 타입별 접미사를 사용해 특정 데이터 타입을 지정할 수 있음.
### 접미사
- L : long
- U : Uint
- UL : Ulong
- F : float
- D : double
- M : decimal

`int a = int.MaxValue;` int형의 최대치.

`int a = int.MinValue;` int형의 최소치.

# null과 Nullable 타입의 이해
- null : 메모리상에 어떤 데이터도 가지고 있지 않을 때 사용하는 키워드.
- null을 가질 수 있는 데이터 타입 (Reference Type) -> String 등.
- null을 가질 수 없는 데이터 타입 (Value Type) -> int 등.
- Nullable 형식을 적용하면 Value Type도 null값을 가질 수 있음. -> 선언할 때 "?"를 사용함.
- ex) `int? a = null;`
- Nullable 타입은 HasValue 와 Value 속성을 가지고 있음.
- HasValue는 값이 Null 이면 False, Null이 아니면 True.

```
Code :
int? a = null;

Console.WriteLine(a);
Console.WriteLine(a.HasValue);
```
```
OUTPUT :
(null)
False
```

# Value Type과 Reference Type의 이해
## 스택(Stack)과 힙(Heap)
### 스택(Stack)
- 변수가 저장되는 메모리.
- 정적으로 메모리에 할당됨.
- 스택 영역에 있는 변수는 선언된 함수를 빠져나가면 소멸됨.
### 힙(Heap)
- 변수의 주소가 저장되는 메모리.
- 동적으로 메모리에 할당됨.
- 프로그래머가 원하는 시점에 동적으로 메모리를 할당하는데, 이러한 유형의 변수들이 할당되는 변수.
- 가비지 컬렉터 (Gabage Collector)가 변수를 소멸함.
## 값 형식과 참조 형식
### 값 형식 (Value Type) 
- 변수가 값을 직접 담는 형식.
- 해당 데이터를 직접적으로 스택 메모리에 저장함.
### 참조 형식 (Reference Type)
- 변수가 실제 값 대신 그 값의 위치를 담는 형식. 
- 힙 메모리에 데이터를 저장함. 스텍 메모리에는 힙 메모리의 주소를 저장함.
## !!
- 값 형식은 Null값을 가질 수 없고 (초기화시 0 할당), 참조 형식은 Null값을 가질 수 있다.
- 값 형식 : int, float, long, char 등 
- 참조 형식 : String, Arrays, Class 등

# Boxing과 UnBoxing의 개념
### object 형식
- 모든 데이터(문자, 실수, 정수, 논리)를 모두 다룰 수 있는 형식.
- 이때 모든 데이터는 Boxing 기능을 통해 힙 메모리에 저장됨.

### Boxing과 UnBoxing
- Boxing : object 함수에서 힙 메모리로 저장하는 과정을 의미함.
- UnBoxing : Boxing 되어 있는 값을 꺼내 값 형식 변수에 저장하는 과정을 의미함.

```
int x = 123;
object obj1 = (object)x; // Boxing : x에 담겨있는 값을 박싱해서 힙에 저장. "(object)" 생략 가능
int y = (int)obj1; //박싱되어있는 obj1값을 언박싱해 값 형식으로 y에 저장.

Console.WriteLine(x);
Console.WriteLine(obj1);
Console.WriteLine(y);

출력 :
123 // 값 형식
123 // 참조 형식
123 // 값 형식
```

# 형변환(Type Conversion)
### 데이터 형식 변환(형변환) : 변수를 다른 데이터 형식에 옮기는 것을 의미.
- 크기가 서로 다른 정수형 사이의 형변환
- 크기가 서로 다른 부동소수점 사이의 형변환
- 부호있는 정수형과 부호없는 정수형 사이의 형변환
- 실수형과 정수형 사이의 형변환
- 문자열과 숫자 사이의 형변환

```
int a = 123;
string b = 123;

string c = a.ToString(); //a를 String형으로 변환
int d = int.Parse(b);   //b를 int형으로 변환
int e = Convert.ToInt32(b); //b를 int형으로 변환
```
### 상수 : 담고있는 데이터를 절대 바꿀수 없는 메모리 공간
- 선언 형식 : const type명 상수명;
```
const int A = 123;
A = 2000; // 오류 발생
``` 
### enum : 열거형 상수
- 선언 형식 : enum 열거형식이름 : 정수형 자료형 {상수1,상수2...}; // 자료형 생략시 int로 설정.
- `enum Name { minsu, minji, robert };` // class Program 안에 선언.
- 열거형식 안에 상수들이 어떤 값도 가지지 않았을 경우에는 첫번째 상수에는 0, 그 다음 요소는 1, 그 다음 요소는 2가 할당된다. 컴파일러가 자동으로 1씩 추가해서 할당.
- 상수 사용시 Name.minsu 처럼 열거형식명을 기입해야함.
```
class Program
    {
        enum Name { minsu, minji, robert = 5};
        static void Main(string[] args)
        {
            Console.WriteLine(Name.minsu);
            Console.WriteLine((int)Name.minsu);
            Console.WriteLine((int)Name.robert);
        }
    }

출력 :
minsu 
0
5
```

# 연산자
### 수식연산자 : +, =, *, /, %
- / : 몫, % : 나머지
### 할당연산자 : =, +=, -=, /=, %=
-  a += 1 -> a = a + 1
### 증가/감소연산자 : ++, -- 
- i++ -> i = i + 1
- ++i : 계산 후 명령 실행, i++ : 명령 실행후 계산.
### 논리연산자 : &&(AND), ||(OR), !(NOT)
- 10 > 5 && 10 < 100 // 출력 : True
- 10 > 5 || 10 < 9 // 출력 : True
- 10 != 5 // 출력 : True
### 관계연산자 : <, >, ==, !=, >=, <=
### 비트연산자 : &(AND), |(OR), ^(XOR)
### Shift연산자 : >>,<<
- 비트의 자리를 옮김. << : 왼쪽으로 이동.
### 조건연산자 : ?
- a == b ? c : d // a 와 b가 같은가? 조건식이 참이면 c, 거짓이면 d
### 보수연산자 : ~ 
- 1과 0의 비트를 서로 반전시킴. `~변수`
### 포맷팅 기능 : 특정 형식에 맞춰 출력하는 기능
```
Shift 연산자:

Console.WriteLine("{0:D3} {0:X8}", 1); //{0:X8} 16진수로 8자리 출력 {0:D3} 10진수로 3자리 출력
Console.WriteLine("{0:D3} {0:X8}", 1 << 5);
Console.WriteLine("{0:D3} {0:X8}", 255);

출력 : 
001 00000001
032 00000020
255 000000FF
```

```
비트 연산자

int x = 9;  // 비트로 표시 1 0 0 1
int y = 10; // 비트로 표시 1 0 1 0

Console.WriteLine(x & y); // 비트 값끼리 비교해서 둘 다 1 이면 1, 하나라도 0이면 0.
Console.WriteLine(x | y); // 하나라도 1 이면 1.
Console.WriteLine(x ^ y); // 서로 같으면 0, 서로 다르면 1.

출력 : 
8
11
3
```

# 조건문 ( if, switch )
### `if( 조건문 ){ 참인 경우 실행할 코드 } else { 참이 아닌 경우 실행할 코드}`

```
int i = 0;
if(i<0) Console.WriteLine("음수");
else if(i>0) Console.WriteLine("양수"); // 위 if가 거짓일 경우 비교.
else Console.WriteLine("0");

출력 : 0
```

### `Console.ReadLine();`
- 입력 받는 함수.
- 문자열만 받음. ( String )

```
String age = Console.ReadLine();
int userAge = int.Parse(age); // 문자열로 받기 때문에 int형으로 변환.

if (userAge > 18) Console.WriteLine("성인");
else Console.WriteLine("미성년자");

입력 : 20
출력 : 성인
```

### `switch(조건식){case 상수1 : 실행코드 break; case 상수2 : 실행코드 break;}`
- if문 보다 여러개의 실행코드를 간단하게 나타낼 수 있음.
```
String WeekDay = Console.ReadLine();
switch (WeekDay)
{
    case "월":
        Console.WriteLine("monday");
        break;
    case "화":
        Console.WriteLine("tuesday");
        break;
    case "수":
        Console.WriteLine("wednesday");
        break;
    case "목":
        Console.WriteLine("thursday");
        break;
    case "금":
        Console.WriteLine("friday");
        break;
    case "토":
        Console.WriteLine("saturday");
        break;
    case "일":
        Console.WriteLine("sunday");
        break;
    default:    // 어떤 조건식도 맞지 않을 때 실행.
      Console.WriteLine("다시입력하세요.");
      break;
}

입력 : 월
출력 : monday
```

# 반복문

### `while {조건식} 반복실행코드` // 조건식이 참이면 반복 실행.
```
int i = 5;
while (i > 0) // i 가 0보다 작아질 때 까지 1씩 빼기. i 가 0 보다 작아지면 그 다음 명령 실행.
    Console.Write(i--);   

출력 : 54321

```

### `do while`
- 명령코드를 먼저 실행 한 뒤 while문으로 넘어감.
```
    int i = 5;
    do
    {
        Console.Write(i);
        i -= 2;
    } 
    while (i > 0);

    출력: 531
```

### `for(초기화; 조건식; 증감문) {실행코드}`
- 조건식이 만족이 될 때까지 증감문을 실행함.
```
for(int i = 0; i < 5; i++)
    Console.Write(i);

출력 : 01234
```

### 무한반복문
- 무한히 반복되는 loop문.
- for(;;){반복실행코드}
- while(true){반복실행코드}
- 반복문을 나가는 함수 break;

# 배열과 foreach

## 배열(Array) : 일련의 동일한 데이터 타입 요소들로 구성된 데이터 집합
### `string [] members = new string[10];` // members : 배열의 이름. 데이터가 들어 갈 메모리의 공간은 10개.
- 여러개의 데이터 공간을 간단히 구축할 수 있고, 데이터 관리도 편리함.
```
int[] score = new int[] {12,32,42,12,52};
int sum = 0;

for(int i = 0; i < score.Length; i++)
{
    sum += score[i];
}
Console.WriteLine(sum);

출력 : 150
```

#
### `foreach(데이터 형식 변수명 in 배열){ 반복실행코드 }`
- foreach 문이 한번 반복 수행 할 때마다 배열을 순차적으로 을변수에 담음.
```
int[] score = new int[] { 12, 32, 42, 12, 52 };
int sum = 0;
foreach (int scoreData in score )sum += scoreData; // scoreData가 score 안에서 배열을 순차적으로 변수에 담는다. 처음엔 12, 두번째 scoreData 는 32 ... 배열이 끝날 때 까지 반복.
Console.WriteLine(sum);

출력 : 150
```

# 2차원 배열
### `string[,] depts = new string[2,2]{{"김과장","영업부"},{"박과장","개발부"}}` // 2차원 배열 (2행2열)
- 배열의 위치를 표기할 땐 [0,0] 으로 표기
- 조건식에 사용할 땐 for문 중첩 사용

### 2중 for문
```
for (int i = 0; i < 5; i++) // i가 5가 될때 까지 실행
{
    for (int j = 0; j <= i; j++){ // 위 for문이 실행되면 j는 계속 0으로 초기화
    Console.Write("@ ");
    }
    Console.WriteLine("");
}

출력 :
@
@ @
@ @ @
@ @ @ @
@ @ @ @ @
```

### 2중 for문을 이용한 2차원 배열

```
int[,] arr = { { 10, 20, 30 }, { 100, 200, 300 } };
for(int i = 0; i < arr.GetLength(0) ; i++) // .GetLength(n) n차원 배열의 길이를 구함.
{
    for (int j = 0; j < arr.GetLength(1); j++)
        Console.WriteLine("[{0}], [{1}] : {2}",i ,j ,arr[i, j]);
}

출력 :
[0], [0] : 10
[0], [1] : 20
[0], [2] : 30
[1], [0] : 100
[1], [1] : 200
[1], [2] : 300
```

# 가변 배열 (Jagged Array)
### 선언형식 : `데이터 형식[][] 배열 이름 = new 데이터형식 [가변배열의 크기] [];`
- 다차원 배열과 연관이 깊음.

```
int[][] jarr =new int[3][]; // 3개의 배열을 구축.
jarr[0] = new int[5] { 1, 2, 3, 4, 5 }; // 첫번째 배열
jarr[1] = new int[3] { 11, 22, 33 }; // 두번째 배열
jarr[2] = new int[2] { 111, 222 }; // 세번째 배열

foreach(int[] arr in jarr)
{
    Console.WriteLine("Length : {0}", arr.Length); // 배열의 길이를 출력.
    foreach(int element in arr) // 위에서 해당되는 배열의 각 요소들을 element에 입력.
    {
        Console.Write("{0} ",element);
    }
    Console.WriteLine();
}

출력 :
Length : 5
1 2 3 4 5
Length : 3
11 22 33
Length : 2
111 222
```

# 메소드 (Method)
### 객체지향 언어에서 사용하는 용어 ( 기존에는 Function(함수)라고 불림. )
### 선언 형식 : `한정자 반환형식 메소드명(매개변수){ 실행 코드 }`
- 한정자 : static 등
- 반환형식 : int, void 등
```
static void Main(string[] args)
{
    int x, y;
    x = 10;
    y = 11;
    int res = Sum(x, y);    // Sum 메소드를 호출해 result 값을 받음.
    Console.WriteLine(res);
} 
static int Sum(int x, int y) {  // 메소드 선언. x와 y에 대입.
    int result = x + y;
    return result;  // result 값으로 반환.
}

출력 : 21
        
```

```
static void Main(string[] args)
{
    int x, y;
    x = 10;
    y = 11;
    Sum(x, y);
} 
static void Sum(int x, int y) { // return 값을 사용하지 않을 때 void 사용.
    int result = x + y;
    Console.WriteLine(result); // 스스로 출력
}

출력 : 21
```
#
### 참조에 의한 매개 변수 전달

```
static void Main(string[] args)
{
    int a = 100;
    int b = 111;

    Swap(ref a, ref b); // ref = 참조에 의한 매개 변수 전달

    Console.WriteLine(a);
    Console.WriteLine(b);
    } 
    static void Swap(ref int a, ref int b) // ref = 참조에 의한 매개 변수 전달
    {
        int temp = a;
        a = b;
        b = temp;   
    }

출력 :
111
100
```

# 오버로딩, 파라미터 디폴트 값 주기
### 메소드 오버로딩 : 하나의 메소드 이름으로 여러개의 기능을 구현할 수 있도록 하는 것.
- 메소드는 매개변수에 갯수가 다를 경우 같은 이름으로 만들 수 있음.
- 또한 매개변수의 갯수가 같아도 매개변수의 자료형이 다르면 같은 이름으로 만들 수 있음.
### 파라미터 디폴트 값 적용하기
- 매개변수의 기본값을 적용할 수 있다.
- 메소드의 값을 지정하지 않고 호출하면 기본값이 출력됨.

# 로컬 함수
### var 키워드 :  데이터 형식을 C# 컴파일러가 알아서 지정함.
- var a = 10; // 정수형으로 취급
- var a = "hello"; // 문자형으로 취급

### 로컬 함수
- 메소드 안에서 선언된 특별 함수.
- 메소드 안에서 선언되었기 때문에 클래스 멤버가 아님. 따라서 함수라고 칭함.

```
대문자 변환 프로그램.
static string ToLowerStr(string str) // HELLO
{
    var arr = str.ToCharArray(); // arr = 'H' 'E' 'L' 'L' 'O'

    for (int i = 0; i < arr.Length; i++)  // 5번 반복
    {
        arr[i] = ToLowerChar(i); // 아래 함수에 넣음
    }
    char ToLowerChar(int i) // H
    {
        if (arr[i] < 97 || arr[i] > 122) // H 가 대문자면
            return arr[i];  // H 그대로 변환
        else
            return (char)(arr[i] - 32); // 소문자로 변환 H -> h
    }
        return new string(arr); // 배열 변환 후 배출
}

static void Main(string[] args)
{
    var word = Console.ReadLine();
    Console.WriteLine(ToLowerStr(word));
}

입력 : hello
출력 : HELLO

```

# 클래스와 객체
### 클래스 : 객체를 정의해놓은 것, 객체를 생성하기 위한 설계도

### 객체(인스턴스) : 메모리에 생성된 것. 클래스로부터 객체를 만드는 과정을 객체화(인스턴스화)라고 하고 그 객체를 그 클래스의 객체(인스턴스) 라고한다. 

```
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person(); // 객체
        Person person1 = new Person(); // 객체, 객체를 생성할 때는 new 연산자 사용.

        person.name = "Kim"; // 클래스에 있는 멤버에 접근하려면 점 연산자를 사용
        person.gender = "Male";
        person.greet();

        person1.name = "Lee";
        person1.gender = "Female";
        person1.greet();
    }
}
class Person // 클래스 선언
{
    public string name; // 멤버변수
    public string gender; // 멤버변수
    public void greet() // 메소드
    {
        Console.WriteLine("저는 {0}입니다.", name);
    }
}

출력 : 
저는 Kim입니다.
저는 Lee입니다.

```

