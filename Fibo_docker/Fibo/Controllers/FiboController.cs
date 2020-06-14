using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using fibo.Models;

namespace fibo.Controllers
{
    [Route("fibonacci")]
    [ApiController]
    public class FiboController : ControllerBase
    {
        
        //GET fibonacci/{id}
        [HttpGet("{id}")]
        public FiboReturns getfibo(int id)
        {
            if(id<0 || id>100){
                id = 0;
            }
            FiboReturns fibo = new FiboReturns();
            for(int i=1;i<=id;i++)
            {
                fibo.fibonnacci.Add(fibonaci(i));
            }
            List<ulong> sort = fibo.fibonnacci;
            for(int i = sort.Count-1; i>=0;i--)
            {
                if(sort[i] %2==0)
                {
                    fibo.sorted.Add(sort[i]);
                }
            }
            for(int i = sort.Count-1; i>=0;i--)
            {
                if(sort[i]%2!=0)
                {
                    fibo.sorted.Add(sort[i]);
                }
            }    
            return fibo;
        }

        //POST fibonacci/
        [HttpPost]
        public FiboReturns getfibo(FiboElements input)
        {
            FiboReturns fibo = new FiboReturns();
            int element = input.elements;
            if(element <0 || element>100)
            {
                element = 0;
            }
            for(int i=1;i<=element;i++)
            {
                fibo.fibonnacci.Add(fibonaci(i));
            }
            List<ulong> sort = fibo.fibonnacci;
            for(int i = sort.Count-1; i>=0;i--)
            {
                if(sort[i] %2==0)
                {
                    fibo.sorted.Add(sort[i]);
                }
            }
            for(int i = sort.Count-1; i>=0;i--)
            {
                if(sort[i]%2!=0)
                {
                    fibo.sorted.Add(sort[i]);
                }
            }    
            return fibo;
        }

        static ulong fibonaci(int input)
        {
            ulong firstnumber = 0, secondnumber = 1, result = 0;

            if (input == 1)
                return 0;
            if (input == 2)
                return 1;
            else
            {
                for (int i = 2; i <input; i++)
                {
                    result = firstnumber + secondnumber;
                    firstnumber = secondnumber;
                    secondnumber = result;
                }
            }
            return result;
        }

    }
}