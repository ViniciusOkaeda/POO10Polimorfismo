using System;
namespace AULA10POLIFORMISMO
{
    public class Player
    {
        public virtual void Pular(){
            System.Console.WriteLine("O personagem está pulando normalmente");
        }


        public virtual void Correr (){
            System.Console.WriteLine("O personagem está correndo normalmente");
        }



    }
}