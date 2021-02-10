#include <stdio.h>
#include "HelloWorld.h"

Sample::Sample():num(0)
{
    num++;
}
Sample::~Sample()
{
}
int Sample::minus(int a, int b)
{
    return a-b;
}
void Sample::display()
{
    printf("num=%d\n",num);
}
