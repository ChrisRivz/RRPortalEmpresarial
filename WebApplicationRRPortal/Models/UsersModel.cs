using System.ComponentModel.DataAnnotations;

namespace WebApplicationRRPortal.UsersModels
{
    public class Usuario
    {
        public int idUser_personal_info  {get;set;}
        public string UserId {get;set;}
        public string PersonalEmail {get;set;}
        public string AdmissionDate {get;set;}
        public string EmployerNumber {get;set;}
        public int IdClient {get;set;}
        public string ManagerNameId {get;set;}
        public bool IsManager { get; set; } 
    }
}