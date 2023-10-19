using AutoMapper;
using Employee.Model;
using Employee.Service.Model;

public class MappingExtension : Profile
{
    public MappingExtension()
    {
        CreateMap<VMEmployee, Employees>().ReverseMap();
        CreateMap<VMProduct,Products>().ReverseMap()
            .ForMember(x=>x.CountryName, x=>x.MapFrom(m=>m.Countries.CountryName== null?"":m.Countries.CountryName));
    }

}