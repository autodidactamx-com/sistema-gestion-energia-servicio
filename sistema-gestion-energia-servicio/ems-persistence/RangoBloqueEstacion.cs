﻿namespace ems_persistencia;

public class RangoBloqueEstacion
{
    public int id { get; set; }
    public DateTime hora_inicial { get; set; }
    public DateTime hora_final { get; set; }
    public string estacion { get; set; }
}
