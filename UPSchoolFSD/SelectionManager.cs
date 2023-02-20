using UpSchool.Domain.Entities;

namespace LuckySister.Console
{
    public class SelectionManager
    {
        private List<Attendee> Attendees { get; set; }
        private List<Attendee> SelectedAttendees { get; set; }
        private Random _random;
        public SelectionManager(){
            Attendees= new List<Attendee>();
            SelectedAttendees= new List<Attendee>();
            _random= new Random();
            }
        public SelectionManager(List<Attendee> initialAttendees)
        {
            Attendees = new List<Attendee>();

            Attendees.AddRange(initialAttendees);

            SelectedAttendees = new List<Attendee>();

            _random = new Random();
        }

        public void AddAttendee(Attendee attendee)
        {
            Attendees.Add(attendee);
        }
        public void AddAttendee(string fullName)
        {
            Attendee attendee = new Attendee()
            {
                Id = Guid.NewGuid(),
                FullName = fullName,
                CreatedOn = DateTimeOffset.Now
            };

            Attendees.Add(attendee);
        }

        public void MakeSelection(int selectedCount)
        {
            if (selectedCount > Attendees.Count)
            {
                throw new Exception("LuckyCount cannot be more then the attendees count.");
            }

            for (int i = 0; i < selectedCount; i++)
            {
                SelectedAttendees.Add(GetRandomAttendee());
            }
        }

        public Attendee GetRandomAttendee() {
            var randomIndex = _random.Next(Attendees.Count);
            var attendee= Attendees[randomIndex];
            return SelectedAttendees.Any(x => x.Id == attendee.Id) ? GetRandomAttendee() : attendee;

        }

        public List<Attendee> GetLuckyList()
        {
            return SelectedAttendees;
        }


    }
}
