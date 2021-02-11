public class HelloWorld {
    int num = 0;

    public HelloWorld() {
        num+=1;
    }

    static int plus(int a, int b) {
        return a+b;
    }

    int minus(int a, int b) {
        return a-b;
    }

    void display() {
        System.out.printf("num=%d\n",num);
    }
}
