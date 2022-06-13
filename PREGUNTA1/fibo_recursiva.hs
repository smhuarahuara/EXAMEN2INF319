module Main where

  fibo :: Integer -> Integer
  fibo 0 = 0
  fibo 1 = 1
  fibo 2 = 1
  fibo n = fibo (n-1) + fibo (n-2)

  fibonacci :: Integer -> Integer -> String
  fibonacci n nMax =
    if n < nMax-1 then
      show (fibo n) ++ " " ++ fibonacci (succ n) nMax
    else
      show (fibo n)

  main = print (fibonacci 0 5)
