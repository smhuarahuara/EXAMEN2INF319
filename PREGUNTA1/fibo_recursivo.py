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

n = int(input("Introduzca un numero"))
generar(n)
