// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;

// namespace Factory.Models
// {
//   public class Machine
//   {
//     public int MachineId { get; set; }

//     [Required(ErrorMessage = "You must enter a machine name.")]
//     public string MachineName { get; set; }

//     [Required(ErrorMessage = "Please enter a description of the machine.")]
//     public string MachineDescription { get; set; }
//     public List<EngineerMachine> JoinEntities { get;}
//   }
// }

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Machine
    {
        public int MachineId { get; set; }

        [Required(ErrorMessage = "You must enter a machine name.")]
        public string MachineName { get; set; }

        [Required(ErrorMessage = "Please enter a description of the machine.")]
        public string MachineDescription { get; set; }

        public List<EngineerMachine> JoinEntities { get; }  // Read-only property

        public Machine()
        {
            JoinEntities = new List<EngineerMachine>();  // Initialize the JoinEntities property
        }
    }
}

var machine = new Machine();
machine.MachineName = "MyMachine";

var validationContext = new ValidationContext(machine);
var validationResults = new List<ValidationResult>();
bool isValid = Validator.TryValidateObject(machine, validationContext, validationResults, true);

if (isValid)
{
    // Save the machine to the database
}
else
{
    // Handle validation errors
    foreach (var validationResult in validationResults)
}