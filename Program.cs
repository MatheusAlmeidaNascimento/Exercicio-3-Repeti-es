using System;

namespace Exercicio_3_Repetições
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            float salario;
            string estadoCivil;
            bool respostaCorretaNome = false;
            bool respostaCorretaIdade = false;
            bool respostaCorretaSalario = false;
            bool respostaCorretaEstadoCivil = false;

            
            
        while (respostaCorretaNome == false)
         {
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            while (nome == "")
            {
                Console.WriteLine("Por favor digite um nome válido");
                nome = Console.ReadLine();
            }
            if (nome != "")
            {
                respostaCorretaNome = true;
            }
             
         }   
            
        while (respostaCorretaIdade == false)
            {
            Console.WriteLine("Digite a sua idade:");
            idade = int.Parse(Console.ReadLine());

             while (idade > 151)
             {
                  
                Console.WriteLine("Por favor digite uma idade válida");
                idade = int.Parse(Console.ReadLine());    
                
             }  
              
            if (idade < 151)
            {
                respostaCorretaIdade = true;
            }

            }

        while (respostaCorretaSalario == false)
        {
                Console.WriteLine("Digite o seu salário:");
                salario = float.Parse(Console.ReadLine());

                while (salario <= 0f)
                {
                    Console.WriteLine("Por favor digite um salário válido");
                    salario = float.Parse(Console.ReadLine());
                }
                if (salario >= 0f)
                {
                    respostaCorretaSalario = true;
                }
            
        }

        while (respostaCorretaEstadoCivil == false)
        {
            Console.WriteLine("Digite o seu estado civil (s/c/v/d)");
            estadoCivil = Console.ReadLine();
            
            while (estadoCivil != "s" && estadoCivil != "c" && estadoCivil != "v" && estadoCivil != "d")
            {
                Console.WriteLine("Por favor digite um estado civil válido");
                estadoCivil = Console.ReadLine();
            }

                switch (estadoCivil)
                {
                    case "s": respostaCorretaEstadoCivil = true;
                        break;
                    case "c": respostaCorretaEstadoCivil = true;
                        break;
                    case "v": respostaCorretaEstadoCivil = true;
                        break;
                    case "d":respostaCorretaEstadoCivil = true;
                        break;      
                    default: respostaCorretaEstadoCivil = true;
                        break;
                }
                Console.WriteLine("Informações válidadas");
            }
        }


            

            }
            


        }
  

