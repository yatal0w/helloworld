import HelloWorld
print "HelloWorld"

a=10
b=20
c=HelloWorld.plus(a,b)
print "{0}{1}".format("plus=",c)

sample = HelloWorld.Sample()
d=sample.minus(a,b)
print "{0}{1}".format("minus=",d)
