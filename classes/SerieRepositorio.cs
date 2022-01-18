using System;
using System.Collections.Generic;
using Dio.Series;
using DIO.Series.Interfaces;


namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {

        private List<Serie> listaSerie = new List<Serie>();
        public void atualiza(int Id, Serie objeto)
        {
            listaSerie[Id] = objeto;
        }

        public void exclui(int Id)
        {
            listaSerie[Id].Excluir();
        }

        public void Insere(Serie Objeto)
        {
            listaSerie.Add(Objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int Id)
        {
            return listaSerie[Id];
        }
    }
}