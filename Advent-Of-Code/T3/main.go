package main

import (
	"os"
	"fmt"
	"strings"
)



func main(){
	dat, err := os.ReadFile("input.txt")
	if err != nil {
		panic(err)
	}
	data := string(dat)
	lines := strings.Split(data, "\n")
	fmt.Println(lines)
}