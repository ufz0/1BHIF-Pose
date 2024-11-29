package main

import (
    "fmt"
    "os"
    "strconv"
    "strings"
    "unicode"
)

type sequence struct {
    color  string
    number int
}

func main() {
    var possibleGamesIDSum int

    dat, err := os.ReadFile("input.txt")
    if err != nil {
        panic(err)
    }
    data := string(dat)
    lines := strings.Split(data, "\n")

    for _, line := range lines {
        if strings.HasPrefix(line, "Game") {
            parts := strings.Split(line, ": ")
            if len(parts) < 2 {
                continue
            }
            gameIDStr := strings.TrimPrefix(parts[0], "Game ")
            gameID, err := strconv.Atoi(gameIDStr)
            if err != nil {
                continue
            }
            sequences := strings.Split(parts[1], "; ")

            gamePossible := true
            for _, seqGroup := range sequences {
                seqs := strings.Split(seqGroup, ", ")
                for _, seq := range seqs {
                    seqParts := strings.Split(seq, " ")
                    if len(seqParts) != 2 {
                        continue
                    }
                    number := 0
                    for _, char := range seqParts[0] {
                        if unicode.IsDigit(char) {
                            number = number*10 + int(char-'0')
                        }
                    }
                    color := seqParts[1]
                    s := sequence{color: color, number: number}
                    if (s.color == "green" && s.number > 13) ||
                        (s.color == "red" && s.number > 12) ||
                        (s.color == "blue" && s.number > 14) {
                        gamePossible = false
                        break
                    }
                }
                if !gamePossible {
                    break
                }
            }
            if gamePossible {
                possibleGamesIDSum += gameID
            }
        }
    }
    fmt.Println("Sum of possible game IDs:", possibleGamesIDSum)
}