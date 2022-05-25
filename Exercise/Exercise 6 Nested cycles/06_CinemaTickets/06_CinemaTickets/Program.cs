using System;

namespace _06_CinemaTickets
{
    internal class Program
    {
        static void Main()
        {
            double totalSoldTicket = 0;
                int soldTicket = 0;
            int standart = 0;
            int student = 0;
            int freespace=0 ;
            int promenliviFreeSpace = 0;

            string film;

                bool finish = false;
            bool end = false;
            int kid = 0;
            while(true)
            {
             film = Console.ReadLine();
             freespace = int.Parse(Console.ReadLine());
                 promenliviFreeSpace += freespace;
                double momentStandart = 0;
                double momentStudent = 0;
                double momentKid = 0;
                while (true)
               {
                    string type = Console.ReadLine();
                    if (end == true)
                    {
                        end = false;
                    }
                if (type =="Finish" || type =="End")
                {
                        if (type == "Finish")
                        {
                        finish = true;
                            break;
                        }
                        else
                        {
                            end = true;
                            
                        }
                        
                    
                }
                    switch (type)
                    {
                        case "standard":
                            standart++;
                            momentStandart++;
                            break;
                        case "student":
                            student++;
                            momentStudent++;
                            break;
                        case "kid":
                            kid++;
                            momentKid++;
                            break;
                    }
                      soldTicket++;
                    if (end )
                    {
                         totalSoldTicket = momentStudent + momentStandart + momentKid;
                        double percentForMovie = (totalSoldTicket / freespace ) * 100;
                        Console.WriteLine($"{film} - { percentForMovie:f2}% full.");
                    totalSoldTicket = 0;
                                break;
                
                    }
               }
               
            if (finish)
            {
                    if (finish)
                    {
                        totalSoldTicket = momentKid + momentStandart + momentStudent;
                        double percentForMovie = (totalSoldTicket / freespace) * 100;
                        Console.WriteLine($"{film} - { percentForMovie:f2}% full.");
                    }
                    totalSoldTicket = standart + student + kid;
                    Console.WriteLine($"Total tickets: {totalSoldTicket}");
                double percentForStudentTickets = (student /totalSoldTicket) * 100;
                Console.WriteLine($"{percentForStudentTickets:f2}% student tickets.");
                double percentForStandartTickets = (standart / totalSoldTicket) * 100;
                Console.WriteLine($"{percentForStandartTickets:f2}% standard tickets.");
                double percentForKidTickets = (kid / totalSoldTicket) * 100;
                Console.WriteLine($"{percentForKidTickets:f2}% kids tickets.");
                return;
            }
            }
            

        }
    }
}
