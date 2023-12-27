# WPF

## WPF의 사용이유
- 뛰어난 UI를 쉽게 개발할 수 있다.
- MVVM패턴을 사용한 정해진 구조를 사용한다.

## WPF의 사용방법
### Control
- 도구상자에서 WPF에 사용가능한 여러 Control이 있다.
- Control을 기입한 후 우클릭 -> 속성에서 여러 이벤트들을 설정해 그 이벤트가 발생하면 어떤 동작을 할 것인지 코딩 가능.

### Binding
- 컨트롤이나 엘리먼트를 데이터에 연결시키는 기술.

### ListView
- 리스트뷰를 이용하면 클래스의 멤버를 한눈에 표시할 수 있다.

```
<GridViewColumn Header="Name" DisplayMemberBinding="{Binding name}"/>
<GridViewColumn Header="Age" DisplayMemberBinding="{Binding age}"/>
```

### Setter
- 엘리먼트가 처음 생성되는 시점에 프로퍼티를 설정함

### Trigger
- 변화에 따른 변화를 지정할 수 있음.
- 이벤트 발생, 속성값 변경 시 스타일을 변경 할 수 있음.
- 프로퍼티가 변경되는 시점에 프로퍼티를 설정함.

### Xaml Resources
- Xaml 리소스는 여러곳에서 스타일을 재사용할 수 있도록 해줌.

```
<Window.Resources>
    <Style x:Key="testStyle">
            <Setter Property="Control.Background">
                <Setter.Value>
                    <LinearGradientBrush>
                        <GradientStop Color="#FF00FF18"/>
                        <GradientStop Color="#FFD1F5ED" Offset="0.983"/>
                    </LinearGradientBrush>
                </Setter.Value>
            </Setter>
    </Style>
</Window.Resources>
```

- 원하는 객체에 Style="{StaticResource testStyle}" 을 입력하면 동일한 스타일 적용가능.

### Command
- 기존에는 버튼 클릭을 코드 비하인드의 이벤트함수와 연결시켜주었음.
- Command를 사용해 ModelView에 클릭기능을 만들 수 있음.

### ICommand 인터페이스
- ICommand 인터페이스를 구현한 객체를 사용해 View에 버튼 클릭, 키보드 입력 등에 바인딩할 수 있다.

```
class TestClickCommand : ICommand
    {
        // CanExecute() 실행을 호출하는 이벤트를 발생시키거나 외부 이벤트를 구독할 수 있음
        private bool rtnCan = true; 
        public event EventHandler CanExecuteChanged;

        // Command 활성화, 비활성화 가능 [True(활성화) or False(비활성화)]
        public bool CanExecute(object parameter)
        {
            return rtnCan;
        }

        // Command가 호출 되었을 때 실행됨.
        public void Execute(object parameter)
        {
            rtnCan = false;
            MessageBox.Show("aaa");
        }
    }
```

- Command 구현 Class
1. RelayCommand
2. DelegateCommand
3. RoutedCommand

### Task
- task는 일반적으로 쓰레드 풀로부터 쓰레드를 가져와 비동기 작업을 한다.

```
Task task1 = Task.Run(() =>
{
    
});
```

## 동기와 비동기
### 동기 - Synchronous : 동시에 일어나는
- 요청을 하면 시간이 걸려도 그 자리에 결과가 주어져야함.
- 순차적으로 진행됨.
- Blocking이 걸리면 작업이 막힐 수 있음.

### 비동기 - Asynchronous : 동시에 일어나지 않은
- 요청을 해도 즉시 처리하지 않음 -> 결과가 이후에 나옴.
- 여러개의 요청을 동시에 처리함.
- Blocking이 걸려도 작업이 진행됨.

### 비동기 커멘드
- void 메소드에서 void를 Task로 바꾸고 async를 적용하면 비동기메소드로 변환할 수 있다.

### await
- 비동기 작업이 끝난 후 UI를 업데이트 해야 할 때 사용.

### UserControl
- 컨트롤을 여러 개 복합해서 사용가능함.

### CustomControl
- 기존 컨트롤을 수정해서 사용함.

### ShowDialog
- 다른 창 호출

```
BookInfoWindow bookInfoWindow = new();
bookInfoWindow.ShowDialog();
```

### 화면 이동

```
InsertPage insertPage = new();
this.NavigationService.Navigate(insertPage);
```

### MVVM 패턴
- Model View ViewModel
- Model : 객체를 의미
- View : UserInterface 영역을 의미
- ViewModel : Business Logic을 처리하는 영역
- UI와 Business Logic의 분리 : 개발자와 디자이너간의 분업이 가능해짐