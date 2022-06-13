fibo :: Integer -> Integer
fibo n| n == 0 = 0
      | n == 1 = 1
      | n == 2 = 1
      | n > 2 = fibo(n-1) + fibo (n-2)

main = do
    print(fibo 5)