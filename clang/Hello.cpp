#include <stdio.h>
#include "HelloWorld.h"
#include "HelloWorld2.h"

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

