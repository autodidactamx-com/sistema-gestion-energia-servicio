using ems_domain.IRepositorio.Proceso;
using ems_domain.IServicio.Mediciones;

namespace ems_service.Servicio.Mediciones;

public class ExtraccionMedicionesServicio : IExtraccionMedicionesServicio
{
    private IMedicionesRepositorio _medicionesRepositorio;
    private IExtraccionMedicionesServicio _extraccionMedicionesServicio;

    public ExtraccionMedicionesServicio(IMedicionesRepositorio medicionesRepositorio, IExtraccionMedicionesServicio extraccionMedicionesServicio)
    {
        this._medicionesRepositorio = medicionesRepositorio;
        this._extraccionMedicionesServicio = extraccionMedicionesServicio;
    }

    public void ProcesoExtraccion()
    {
        throw new NotImplementedException();
    }
}