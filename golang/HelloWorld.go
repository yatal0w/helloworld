package main

import "fmt"

func main() {
    fmt.Println("HelloWorld")
    a:=10
    b:=20 
    c:=plus(a,b)
    fmt.Printf("plus=%d\n",c)
    d:=number{a,b}
    e:=d.minus()
    fmt.Printf("minus=%d\n",e)
}

func plus(a int, b int) int {
    return a+b
}

type number struct {
    a int
    b int
}

func (n number) minus() int {
    return n.a-n.b
}
