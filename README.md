# OXQuiz
OX 값을 원하는 비율로 생성하여 배열에 넣는다.

<br>

## 목표
-  O or X 값만 넣는다.
-  O 비율은 사용자가 입력한 비율로 생성된다.
-  O or X 값은 랜덤 순서로 배열에 존재 한다.

<br>

## 원하는 비율만큼 O X 값을 배열에 넣는다.

```csharp  
private List<char> vs()
{
    // 변수
    List<char> _vs = new List<char>();

    char o = 'O';
    char x = 'X';
    float _rate = 0f;
    int _count = 0;

    _count = int.Parse(textBox1.Text.ToString());
    _rate = float.Parse(textBox2.Text.ToString()) / 100;

    for (int i = 1; i <= _count; i++)
    {
        if (i <= _rate * _count)
        {
            _list.Add(o);
        }
        else
        {
            _list.Add(x);
        }
    }

    return _vs;
}

```


## 실행 결과
