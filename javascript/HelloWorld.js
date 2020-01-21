"use strict"

console.log("HelloWorld");
var a=10,b=20;
var c=plus(a,b);
console.log("plus=%d",c);

function plus(a,b) {
    return a+b;
}

class HelloWorld {
    minus(a,b) {
        return a-b;
    }
}

let helloworld = new HelloWorld();
var d=helloworld.minus(a,b);
console.log("minus=%d",d);
