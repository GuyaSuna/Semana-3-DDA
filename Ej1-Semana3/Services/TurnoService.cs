using Ej1_Semana3.Models;

namespace Ej1_Semana3.Services
{
    public class TurnoService
    {

        private readonly List<Turno> _listaTurnos = new();


        public List<Turno> GetAllTurnos()
        {
            return _listaTurnos;
        }
        public Turno? GetTurno(int id)
        {
            return _listaTurnos.FirstOrDefault(t => t.Id == id);
        }
        public void AgregarTurno(Turno turno)
        {
            int nuevoId = _listaTurnos.Count == 0 ? 1 : _listaTurnos.Max(turno => turno.Id) +1;

            turno.Id = nuevoId;

            _listaTurnos.Add(turno);
        }

        public bool Eliminar(int id)
        {
            var t = GetTurno(id);

            if(t == null) return false;

            _listaTurnos.Remove(t);
            return true;

        }

        public bool Modificar(Turno turno)
        {
            var t = GetTurno(turno.Id);

            Turno nuevoTurno = new() { }
        }


    }
}
