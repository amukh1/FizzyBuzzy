h = 15
for i in range(h + 1):
    resp = ""
    if i % 3 == 0:
        resp += "Fizz"
    if i % 5 == 0:
        resp += "Buzz"
    if i % 3 != 0 and i % 5 != 0:
        resp += str(i)
    if(i == 0):
        resp = "0"
    print(resp)
