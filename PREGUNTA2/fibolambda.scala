object tempEstruc{ 
// Main method 
   def main(args:Array[String]):Unit={  
      var b=1 
      var b1=1 
      var c=0
      val x=8 
      var i=0 
      var a=0 
      val fib2 = (n:Int) =>  
      while( i < n ) { 
         c=a+b 
         a=b 
         b=c 
         println(a) 
         i=i+1 
      }
      val fib3 = (n:Int) => 
      while( i < n ) { 
         c=a+b+b1 
         a=b 
         b=b1 
         b1=c 
         println(a) 
         i=i+1 
      } 
      //println(fib2(x)) 
      println(fib3(x)) 
   } 
}
