def plus(a,b):
    return a+b

class Sample:
    num = 0
    def __init__(self):
        self.num+=1

    def minus(self,a,b):
        return a-b

    def display(self):
        print "{0}{1}".format("num=",self.num)
