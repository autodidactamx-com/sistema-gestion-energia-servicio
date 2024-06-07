using ems_domain.IRepositorio.Proceso;
using ems_domain.IServicio.Despacho;
using ems_domain.IServicio.Mediciones;

namespace ems_service.Servicio.Despacho;

public class DespachoEmsServicio : IDespachoEmsServicio
{
    private IExtraccionMedicionesServicio _extraccionMedicionesServicio;
    private IConfiguracionArranqueRepositorio _configuracionArranqueRepositorio;
    private ICargaYDescargaBloqueRepositorio _cargaYDescargaBloqueRepositorio;
    private IRangoBloqueEstacionRepositorio _rangoBloqueEstacionRepositorio;

    public DespachoEmsServicio(IExtraccionMedicionesServicio extraccionMedicionesServicio, IConfiguracionArranqueRepositorio configuracionArranqueRepositorio, ICargaYDescargaBloqueRepositorio cargaYDescargaBloqueRepositorio, IRangoBloqueEstacionRepositorio rangoBloqueEstacionRepositorio)
    {
        this._extraccionMedicionesServicio = extraccionMedicionesServicio;
        this._configuracionArranqueRepositorio = configuracionArranqueRepositorio;
        this._cargaYDescargaBloqueRepositorio = cargaYDescargaBloqueRepositorio;
        this._rangoBloqueEstacionRepositorio = rangoBloqueEstacionRepositorio;
    }

    public void ArranqueProceso(int idConfiguracion)
    {
        throw new NotImplementedException();
    }
}