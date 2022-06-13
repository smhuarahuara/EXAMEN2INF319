module Main where

  funSup ::(Integer -> Integer -> String)->Integer->Integer->String
  funSup f x y = f x y

  fibor :: Integer -> Integer
  fibor 0 = 0
  fibor 1 = 1
  fibor 2 = 1
  fibor n = fibor (n-1) + fibor (n-2)

  fibonacci :: Integer -> Integer -> String
  fibonacci n nMax =
    if n < nMax-1 then
      show (fibor n) ++ " " ++ fibonacci (succ n) nMax
    else
      show (fibor n)

  main = do 
    print (funSup fibonacci 0 5)