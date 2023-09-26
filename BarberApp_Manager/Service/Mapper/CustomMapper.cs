using AutoMapper;

namespace BarberApp_Manager.Service.Mapper
{
    public class CustomMapper
    {
        private IMapper _mapper { get; set; }

        public CustomMapper()
        {
            MapperConfiguration configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(typeof(PresentationStartup).Assembly);
            });

            IMapper mapper = configuration.CreateMapper();

            this._mapper = mapper;
        }

        public TDestionation Map<TDestionation>(object source)
        {
            return _mapper.Map<TDestionation>(source);
        }

        public TDestionation Map<TDestionation>(object source, Action<IMappingOperationOptions<object, TDestionation>> options)
        {
            return _mapper.Map<TDestionation>(source, options);
        }
    }
}
