const x = 15

for(var i = 1; i<x + 1;i++){
    let resp = ""
    if(i % 3 == 0){
        resp = resp + "Fizz"
    }
    if(i % 5 == 0){
        resp += "Buzz"
    }
    if(i % 3 != 0 && i % 5 != 0){
        resp = i
    }
    console.log(resp)
}
