/*
                           Potato potato;
               //... 
               if (potato != null)
                  if(!potato.HasNotBeenPeeled && !potato.IsRotten)
                   Cook(potato);*/

namespace RefactorFollowingIfStatements
{
    using System;
    using ClassChefInCSharp;

   public class CoockingIf
    {
        public static void CookVegitable(Vegetable vegitable, Chef chef)
        {
            Potato potato = new Potato();
            bool isCookable = IsCookable(potato);

            if (isCookable)
            {
               chef.Cook(potato);
            }
            else
            {
                throw new ArgumentException("The Vegitable be not rotten and peeled!");
            }
        }

        private static bool IsCookable(Vegetable vegitable)
        {
            bool canBeCooked = vegitable != null && !vegitable.IsRotten && vegitable.IsPeeled;
            return canBeCooked;
        }
    }
}