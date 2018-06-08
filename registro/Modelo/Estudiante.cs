using System;

namespace registro.Modelo
{
    class Estudiante
    {
        private String idestudiante;
        private String nombre1Estudiante;
        private String nombre2Estudiante;
        private String apellido1Estudiante;
        private String apellido2Estudiante; 
        private String codigoEstudiante;
        private String carreraEstudiante;

        #region Constructores
        public Estudiante()
        {

        }
        public Estudiante(String idestudiante, String nombre1Estudiante, String nombre2Estudiante,
            String apellido1Estudiante, String apellido2Estudiante, String codigoEstudiante,
            String carreraEstudiante)
        {
            this.idestudiante = idestudiante;
            this.nombre1Estudiante = nombre1Estudiante;
            this.nombre2Estudiante = nombre2Estudiante;
            this.apellido1Estudiante = apellido1Estudiante;
            this.apellido2Estudiante = apellido2Estudiante;
            this.codigoEstudiante = codigoEstudiante;
            this.carreraEstudiante = carreraEstudiante;
        }
        #endregion

        #region Get and Set
        public String getIdestudiante()
        {
            return idestudiante;
        }
        public void setIdestudiante(String idestudiante)
        {
            this.idestudiante=idestudiante;
        }

        public String getNombre1Estudiante()
        {
            return nombre1Estudiante;
        }
        public void setNombre1Estudiante(String nombre1Estudiante)
        {
            this.nombre1Estudiante=nombre1Estudiante;
        }

        public String getNombre2Estudiante()
        {
            return nombre2Estudiante;
        }
        public void setNombre2Estudiante(String nombre2Estudiante)
        {
            this.nombre2Estudiante = nombre2Estudiante;
        }

        public String getApellido1Estudiante()
        {
            return apellido1Estudiante;
        }
        public void setApellido1Estudiante(String apellido1Estudiante)
        {
            this.apellido1Estudiante = apellido1Estudiante;
        }

        public String getApellido2Estudiante()
        {
            return apellido2Estudiante ;
        }
        public void setApellido2Estudiante(String apellido2Estudiante)
        {
            this.apellido2Estudiante = apellido2Estudiante;
        }
        public String getCodigoEstudiante()
        {
            return codigoEstudiante;
        }
        public void setCodigoEstudiante(String codigoEstudiante)
        {
            this.codigoEstudiante = codigoEstudiante;
        }

        public String getCarreraEstudiante()
        {
            return carreraEstudiante;
        }
        public void setCarreraEstudiantee(String carreraEstudiante)
        {
            this.carreraEstudiante = carreraEstudiante;
        }
        #endregion

        #region toString
        public String toString()
        {
            return "Estudiante:\nIdentificación: "+idestudiante+", Nombre: " +nombre1Estudiante+" "+nombre2Estudiante+
                ", Apellido: "+apellido1Estudiante+" "+apellido2Estudiante+","+ "\nCódigo: "+codigoEstudiante+", "+", Carrera: "+carreraEstudiante ;
        }
        #endregion
    }
}
