def fibo(n):
    a = 0
    b = 1
    c = 1
    for i in range(n):
        print(a, end=" ")
        a = b
        b = c
        c = a+c 


n = int(input("Introduzca un numero"))
fibo(n+1)

