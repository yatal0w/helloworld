object HelloWorld {
    def main(args: Array[String]){
        printf("HelloWorld\n")
        val a=10
        val b=20
        val c=plus(a,b)
        printf("plus=%d\n",c)
        val helloworld = new HelloWorld
        var d=helloworld.minus(a,b)
        printf("minus=%d\n",d)
    }

    def plus(a: Int,b: Int) : Int = {
        a+b
    }

    class HelloWorld {
        def minus(a: Int, b: Int) : Int = {
            a-b
        }
    }
}
