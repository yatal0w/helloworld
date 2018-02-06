#include <stdio.h>

class Sample
{
public:
    Sample();
    ~Sample();
    int minus(int a, int b){ return a-b; }
};

Sample::Sample(){}
Sample::~Sample(){}
int plus(int a, int b);
int main()
{
    printf("HelloWorld\n");
    int a=10,b=20;
    int c=plus(a,b);
    printf("plus=%d\n",c);
    Sample* sample = new Sample();
    int d=sample->minus(a,b);
    printf("minus=%d\n",d);
    delete sample;
    return 0;
}

int plus(int a, int b)
{
    return a+b;
}
