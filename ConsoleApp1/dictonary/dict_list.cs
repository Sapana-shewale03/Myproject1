using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancecsharp.Collections
{
    class Actor
    {
        int rating;
        string moviename;
        string actorlist;
        public Actor(int rating, string moviename, string actorlist)
        {
            this.moviename = moviename;
            this.rating = rating;
            this.actorlist = actorlist;
        }
        static void Main(string[] args)
        {
            Actor a = new Actor(1, "ss", "ddd");
        }
    }
        class dict_list
        {
            string moviename2;
            int rating;
            List<Actor> actorlist;

            public dict_list(string moviename2, int rating, List<Actor> actorlist)
            {
                this.moviename2 = moviename2;
                this.rating = rating;
                this.actorlist = actorlist;
            }
        void show()
        {
            Console.WriteLine("movie name: "+this.moviename2+"rating "+this.rating+" "+"actor list "+this.actorlist+" ");
        }
            static void Main(string[] args)
            {
                List<Actor> warlit = new List<Actor>();
                warlit.Add(new Actor(1, "hritik", "male"));
                warlit.Add(new Actor(2, "kiara", "female"));
                dict_list w = new dict_list("war  ", 2, warlit);
            w.show();
            foreach(Actor m in warlit)
            {
                Console.WriteLine(m);
            }
            }
        }
}
