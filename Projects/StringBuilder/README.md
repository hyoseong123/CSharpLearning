# StringBuilder
- StringBuilder를 사용하기 위해선 using System.Text; 를 먼저 선언해주어야 한다.
- StringBuilder를 사용하면 문자열을 조합할 때마다 새로운 변수를 생성하지 않고 결합할 수 있다.

### string
```
string city = "대전광역시";
string goo = "대덕구";
string road = "대전로";

Console.WriteLine(word + goo + road);
```

### StringBuilder
```
StringBuilder builder = new StringBuilder();

builder.Append("대전광역시");
builder.Append("대덕구");
builder.Append("대덕로");

Console.WriteLine(builder.ToString());
```

## Append() 메서드
- 문자열을 StringBuilder 객체의 끝에 추가함.
- AppendLine을 사용하면, 문자열 끝에 개행문자가 추가됨.

## Insert() 메서드
- 지정된 인덱스 위치에 지정된 문자열을 삽입함.

## Remove() 메서드
- 지정된 인덱스 위치에서 시작해 지정된 길이만큼 문자열을 제거함.

## Replace() 메서드
- 특정 문자열을 지정된 문자열로 변경함.

## 주의사항
- 각각의 장단점이 있기에 string을 사용할지 StringBuilder를 사용할지 결정해야함.

1. string을 사용하는 경우
    - 문자열을 수정하는 수가 적을 경우.
    - 부분적인 문자열 글자로 고정된 수의 문자열 연결 작업을 할 경우.
    - 문자열을 작성하는 동안 광범위한 검색 작업을 수행할 경우.

2. StringBulider를 사용할 경우
    - 응용 프로그램이 설계시에 알 수 없는 횟수의 문자열을 변경해야 할 경우 (사용자의 입력으로 조합할 경우).
    - 문자열에서 많은 횟수의 변경이 예상될 때.