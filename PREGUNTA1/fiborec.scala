object Hola {

  def fibo(x:Int):Int={
    if(x==0) return 0 
    else if(x==1) 1
    else if(x==2) 1
    else fibo(x-1) + fibo(x-2)
  }

  def generar(x:Int):Unit={
    for(w <- 0 to x){
      print(fibo(w)+" ")    
    }
  }
  
  def main(args:Array[String]):Unit = {
    println("Hola mundo")
    println("Dame un valor a: ")
    val a = scala.io.StdIn.readInt()
    generar(a)
  }
  
}