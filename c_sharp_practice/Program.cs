class ManinClass
{
    public static void Main(string[] args)
    {
        // 배열을 초기화하는 첫 번째 방법. 공간을 먼저 할당한다.
        int[] array1 = new int[3];
        array1[0] = 10;
        array1[1] = 20;
        array1[2] = 30;

        // 배열을 초기화하는 두 번째 방법
        int[] array2 = new int[] { 1, 2, 3 };

        // 배열을 초기화하는 세 번째 방법
        int[] array3 = {4, 5, 6};

        // 배열 변수명으로 출력. 이렇게 하면 배열 자체가 출력된다.
        Console.WriteLine(array1);
        Console.WriteLine(array2);
        Console.WriteLine(array3);

        // for 반복문을 통해 배열의 인덱스 접근 및 값 출력 가능
        for (int i = 0; i < array1.Length; i++)
            Console.WriteLine(array1[i]);

        // foreach 문을 통해 배열에 담긴 값을 출력 가능
        foreach(int i in array3)
            Console.WriteLine(i);
    }
}