printf "HelloWorld\n"
a=10
b=20
def plus(a,b)
    return a+b
end
c=plus(a,b)
printf "plus=%d\n",c

class HelloWorld
    def minus(a,b)
        return a-b
    end
end

d=HelloWorld.new
e=d.minus(a,b)
printf "minus=%d\n",e
