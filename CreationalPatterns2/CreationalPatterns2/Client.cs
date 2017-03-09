namespace CreationalPatterns2
{
    class Client
    {
        static void Main(string[] args)
        {
            AutomatedPicker pickerA = PickerPool.GetPicker();
            AutomatedPicker pickerB = PickerPool.GetPicker();

            pickerA.Identify("PA");
            pickerB.Identify("PB");

            pickerA.GoToLocation("Bay 1");
            pickerB.GoToLocation("Bay 3");

            pickerA.Pick("Processor");
            pickerB.Pick("RAM");

            pickerA.GoToLocation("Build Room");
            pickerB.GoToLocation("Build Room");

            pickerA.Drop();
            pickerB.Drop();

            PickerPool.ReleasePicker(pickerA);
            PickerPool.ReleasePicker(pickerB);

            AutomatedPicker pickerC = PickerPool.GetPicker();
            AutomatedPicker pickerD = PickerPool.GetPicker();
            AutomatedPicker pickerE = PickerPool.GetPicker();
            AutomatedPicker pickerF = PickerPool.GetPicker();
            AutomatedPicker pickerG = PickerPool.GetPicker();
            AutomatedPicker pickerH = PickerPool.GetPicker(); //Crashes Error thrown here.
        }
    }
}
