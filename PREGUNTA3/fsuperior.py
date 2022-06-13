def fibo(n):
    a = 0
    b = 1
    c = 1
    for i in range(n):
        print(a, end=" ")
        a = b
        b = c
        c = a+c 

def fibo_rec(n):
    if n==0:
        return 0
    elif n==1:
        return 1
    elif n==2:
        return 1
    else:
        return fibo_rec(n-1)+fibo_rec(n-2)

def generar(n):
    for i in range(0,n+1):
        print(fibo_rec(i), end=" ")

def fsuperior(funcion1, n):
    funcion1(n)

n = int(input("Introduzca un numero"))
fsuperior(fibo, 5)
fsuperior(generar, 5)