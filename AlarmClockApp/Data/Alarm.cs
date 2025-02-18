namespace AlarmClockApp.Data
{
    public class Alarm
    {
        public DateTime currrentTime { get; set; }
        public TimeOnly alarmTime { get; set; }
        public string alarmTimeString { get; set; }
        public bool alarmTimeAmPm { get; set; } = true; // true == am, false == pm



        public Alarm() { }


    }
}
