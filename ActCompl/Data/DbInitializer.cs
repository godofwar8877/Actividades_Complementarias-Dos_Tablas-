using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActCompl.Models;

namespace ActCompl.Data
{
    public class DbInitializer
    {
        public static void Initialize(ActComplContext context)
        {
            context.Database.EnsureCreated();
            if (context.Alumnos.Any())
            {
                return;
            
            }
            var Alumnos = new Alumnos[]
            {
                //

            };
            foreach (Alumnos a in Alumnos)
            {
                context.Alumnos.Add(a);
                {
                    context.SaveChanges();
                }
            } 

        }


            


    }
}
