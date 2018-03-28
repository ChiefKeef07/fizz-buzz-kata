using System;
using System.Collections.Generic;

namespace FizzBuzz.Library
{
    public class FizzBuzzService
    {
        public String Print(int v)
        {
            string answer = "";
            if(v % 3 == 0){
                answer += "Fizz";
            }
            if(v % 5 == 0){
                answer += "Buzz";
            }
            if(!answer.Equals("")){
                return answer;
            }else{
                return v.ToString();
            }
        }
    }
}