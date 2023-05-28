namespace Task.Models
{
    public class VMuser
    {

        public userDTO userDTO { get; set; }
        public List<serviceDTO> serviceDTOs { get; set; }
        public List<interestedDTO> interestedDTOs { get;set; }
    }
}
