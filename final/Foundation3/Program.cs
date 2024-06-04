using System;

class Program
{
    static void Main(string[] args)
    {
        LectureEvent lectureEvent = new LectureEvent("Book of Mormon Presentation", "A great lecture about this marvelous book and all its content", "06/10/24", "4:00pm", "Jarom Mariscal", 50);
        Address address1 = new Address("Veracruz 901", "Cd Obregon", "Sonora", "Mexico");
        lectureEvent.SetAddress(address1);

        ReceptionEvent receptionEvent = new ReceptionEvent("Sweet sixteen", "An elegant party that it is necessary to count with reservation", "07/13/24", "6:00pm", "I am sure to go your party");
        Address address2 = new Address("Paseo de las flores", "Ciudad Obregon", "Sonora", "Mexico");
        receptionEvent.SetAddress(address2);

        OutdoorGatheringEvent outdoorGatheringEvent = new OutdoorGatheringEvent("A big picnic", "Share  your time with us and join in this big picnic", "05/17/24", "12:00pm", 124.3);
        Address address3 = new Address("Boulevard Villa Bonita", "Ciudad Obregon", "Sonora", "Mexico");
        outdoorGatheringEvent.SetAddress(address3);

        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine(outdoorGatheringEvent.GetShortDescription());
        Console.WriteLine(outdoorGatheringEvent.GetStandardDetails());
        Console.WriteLine(outdoorGatheringEvent.GetFullDetails());
    }
}