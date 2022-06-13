module Main where

  fib :: Integer -> Integer
  fib 0 = 0
  fib 1 = 1
  fib 2 = 1
  fib n = fib (n-1) + fib (n-2)

  fibonacci :: Integer -> Integer -> String
  fibonacci n fibMax =
    if n < fibMax-1 then
      show (fib n) ++ " " ++ fibonacci (succ n) fibMax
    else
      show (fib n)

  main = print (fibonacci 0 5)