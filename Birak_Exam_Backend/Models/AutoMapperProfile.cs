using AutoMapper;

namespace Birak_Exam_Backend.Models
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        { 
            CreateMap<Clothes, ClothesViewModel>().ReverseMap(); 
        }      
    }
}
