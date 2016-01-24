using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareFamilyGUI.FormArguments
{
    public class CreateMeetingFormArguments
    {
        public string Username { get; set; }

        // using when cteate a meeting inside other user information form
        public string SelectedUsername { get; set; }
    }
}
