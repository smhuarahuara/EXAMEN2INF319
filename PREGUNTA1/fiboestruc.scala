object Hola {

  def fiboe(x:Int):Unit={
    var a = 0
    var b = 1
    var c = 1
    for(w <- 0 to x){
      print(a+" ")
      a=b
      b=c
      c=a+b   
    }
  }
  
  def main(args:Array[String]):Unit = {
    println("Hola mundo")
    println("Dame un valor a: ")
    val a = scala.io.StdIn.readInt()
    fiboe(a)
  }
  
}