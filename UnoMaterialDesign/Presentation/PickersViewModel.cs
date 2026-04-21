namespace UnoMaterialDesign.Presentation;

public partial class PickersViewModel : ObservableObject
{
    [ObservableProperty]
    private DateTimeOffset _selectedDate = DateTimeOffset.Now;

    [ObservableProperty]
    private TimeSpan _selectedTime = DateTime.Now.TimeOfDay;

    [ObservableProperty]
    private DateTimeOffset? _futureDate;

    [ObservableProperty]
    private DateTimeOffset? _calendarDate;

    [ObservableProperty]
    private bool _datePickerEnabled = true;

    [ObservableProperty]
    private bool _timePickerEnabled = true;

    [ObservableProperty]
    private bool _is24Hour;
}
