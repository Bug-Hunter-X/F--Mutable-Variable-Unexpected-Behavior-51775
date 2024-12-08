let x = ref 0
let y = !x + 1
x := 10
printf "%d %d" y !x