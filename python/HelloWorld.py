
print "HelloWorld"

def plus(a,b):
    return a+b

a=10
b=20
c=plus(a,b)
print "{0}{1}".format("plus=",c)

class Sample:
    def minus(self,a,b):
        return a-b

sample = Sample()
d=sample.minus(a,b)
print "{0}{1}".format("minus=",d)
