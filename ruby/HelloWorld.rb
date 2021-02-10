def plus(a,b)
    return a+b
end

class HelloWorld
    @@num = 0
    def initialize()
        @@num+=1
    end

    def minus(a,b)
        return a-b
    end

    def display()
        printf "num=%d\n",@@num
    end
end

