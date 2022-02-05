using Mapster;

namespace TodoApplication.Mapper
{
    public class MapsterMapper
    {
        public D Map<S, D>(S source)
        {
            return source.Adapt<D>();
        }
    }
}
