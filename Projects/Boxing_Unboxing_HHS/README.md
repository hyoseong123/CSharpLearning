# 박싱과 언박싱
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