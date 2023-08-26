using System.Collections;

public class ManinClass
{
    // 1. 배열
    //public static void Main(string[] args)
    //{

    //    // 배열을 초기화하는 첫 번째 방법. 공간을 먼저 할당한다.
    //    int[] array1 = new int[3];
    //    array1[0] = 10;
    //    array1[1] = 20;
    //    array1[2] = 30;

    //    // 배열을 초기화하는 두 번째 방법
    //    int[] array2 = new int[] { 1, 2, 3 };

    //    // 배열을 초기화하는 세 번째 방법
    //    int[] array3 = { 4, 5, 6 };

    //    // 배열 변수명으로 출력. 이렇게 하면 배열 자체가 출력된다.
    //    Console.WriteLine(array1);
    //    Console.WriteLine(array2);
    //    Console.WriteLine(array3);

    //    // for 반복문을 통해 배열의 인덱스 접근 및 값 출력 가능
    //    for (int i = 0; i < array1.Length; i++)
    //        Console.WriteLine(array1[i]);

    //    // foreach 문을 통해 배열에 담긴 값을 출력 가능
    //    foreach (int i in array3)
    //        Console.WriteLine(i);
    //}

    // 2. 컬렉션 클래스 - ArrayList
    //public static void Main()
    //{
    //    ArrayList al = new ArrayList();
    //    al.Add(1);
    //    al.Add("Hello");
    //    al.Add(3.4);
    //    al.Add(true);

    //    // 형태가 정해져있지 않기 때문에 var 를 사용한다.
    //    foreach (var item in al)
    //        Console.WriteLine(item);

    //    al.Remove("Hello");
    //    Console.WriteLine();

    //    foreach (var item in al)
    //        Console.WriteLine(item);
    //}

    // 3. 컬렉션 클래스 - Queue. 먼저 입력된 결과가 먼저 빠져나온다.
    //public static void Main()
    //{
    //    Queue qu = new Queue();
    //    // Enqueue 메소드를 통해 아이템 추가
    //    qu.Enqueue(1);
    //    qu.Enqueue(2);
    //    qu.Enqueue(3);

    //    //  Dequeue 메소드를 통해 아이템을 제거
    //    while(qu.Count > 0)
    //        Console.WriteLine(qu.Dequeue());
    //}

    // 4. 컬렉션 클래스 - Stack. 나중에 입력된 결과가 먼저 빠져나온다.
    //public static void Main()
    //{
    //    Stack st = new Stack();
    //    st.Push(1);
    //    st.Push(2);
    //    st.Push(3);

    //    //  Dequeue 메소드를 통해 아이템을 제거
    //    while (st.Count > 0)
    //        Console.WriteLine(st.Pop());
    //}

    // 5. 컬렉션 클래스 - Hashtable. 키와 값으로 빼낼 수 있다.
    //public static void Main()
    //{
    //    Hashtable ht = new Hashtable();
    //    ht["apple"] = "사과";
    //    ht["banana"] = "바나나";
    //    ht["orange"] = "오렌지";

    //    Console.WriteLine(ht["apple"]);
    //}

    // 6, 예외 처리하기
}