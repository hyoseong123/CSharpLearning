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
#
- 값 형식은 Null값을 가질 수 없고 (초기화시 0 할당), 참조 형식은 Null값을 가질 수 있다.
- 값 형식 : int, float, long, char 등 
- 참조 형식 : String, Arrays, Class 등