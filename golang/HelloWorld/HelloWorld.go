package HelloWorld

func Plus(a int, b int) int {
    return a+b
}

type Number struct {
    A int
    B int
}

func (n Number) Minus() int {
    return n.A-n.B
}
