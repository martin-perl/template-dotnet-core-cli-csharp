namespace com.test.implementations {
    public class Data {
        public static string AddDelegateMethod(int a, int b)
        {
            return $"{a} + {b} = {a+b}";
        }

        public static string MultiplyDelegateMethod(int a, int b)
        {
            return $"{a} * {b} = {a*b}";
        }
    }
}