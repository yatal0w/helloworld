public class Hello {
    public static void main(String[] args) {
        System.out.println("HelloWorld");
        int a=10,b=20;
        int c=HelloWorld.plus(a,b);
        System.out.printf("plus=%d\n",c);
        HelloWorld helloworld = new HelloWorld();
        int d=helloworld.minus(a,b);
        System.out.printf("plus=%d\n",d);
    }
}
