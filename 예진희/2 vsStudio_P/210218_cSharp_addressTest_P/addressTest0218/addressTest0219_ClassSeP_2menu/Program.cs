using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; // c/c++ : include - java : import - c# using 언어별 임포트
using addressTest0218.control;

namespace addressTest0218
{
    class Program
    {
        static void Main(string[] args)
        {
            AdressMenu sh = new AdressMenu();
        }
    }
}









/*
 * 안드로이드(모듈) 컴포넌트
 * 자바 : swing,    javaFx(애플리..)
 * c#   : winform,  WPF                 (design + code)(design / code)
 * 
 * [디자인 패턴]
 * MVC Model(클래스) (뷰) (컨트롤),    웹
 * MVP P(present..)
 * MVVM
 * 
 * SINGLETONE
 */