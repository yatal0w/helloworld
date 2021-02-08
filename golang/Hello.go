package main

import (
	"fmt" 
	"./HelloWorld" 
)

func main() {
    fmt.Println("HelloWorld")
    a:=10
    b:=20 
    c:=HelloWorld.Plus(a,b)
    fmt.Printf("plus=%d\n",c)
    d:=HelloWorld.Number{a,b}
    e:=d.Minus()
    fmt.Printf("minus=%d\n",e)
}

