using System;
using System.Collections.Generic;
using System.Text;

namespace Dio
{
    class Xenlongao
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            int C = Int32.Parse(t);
            for(int k=0; k<C; k++)
            {
              string n = Console.ReadLine();
              int N = Int32.Parse(n);
              int divs=0;
              for(int j=1; j<=N; j++){
                int cont=0;
  


                for(int i=1; i<=j; i++){
                  if(j%i==0){
                    cont++;
                  }
                }

                
                if(cont%2==0){
                  divs+=1;
                }
              }
              Console.WriteLine(divs);
            }
        }
    }
}