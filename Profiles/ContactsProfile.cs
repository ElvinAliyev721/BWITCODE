using AutoMapper;
using BWITCODE.Models.Domain;
using BWITCODE.Models.DTOs;

namespace BWITCODE.Profiles
{
    public class ContactsProfile:Profile
    {
        public ContactsProfile()
        {
            CreateMap<Contact, ContactDTO>().ReverseMap();
        }
    }
}
