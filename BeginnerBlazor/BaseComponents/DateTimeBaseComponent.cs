using Microsoft.AspNetCore.Components;

namespace BeginnerBlazor.BaseComponents
{
    public class DateTimeBaseComponent:ComponentBase
    {
        public DateTime dateTime {  get; set; } 
      public  DateTimeBaseComponent() { 
        dateTime = DateTime.Now;
        }
    }
}
