require './HelloWorld.rb'

printf "HelloWorld\n"

a=10
b=20
c=plus(a,b)
printf "plus=%d\n",c

d=HelloWorld.new
e=d.minus(a,b)
printf "minus=%d\n",e

d.display()
