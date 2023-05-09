namespace Classes_Estáticas
{
    //classe estática 
    public static class ConversorTemperatura
    {
        //propriedades (membros) estáticos
        public static float Temperatura { get; set; }       
        

        //método estático para converter temperatura de celsius para fahreinheit
        public static float CelsiusParaFahrenheit(float temperaturaCelsius)
        {
            //lógica da função
            //converter

            Temperatura = temperaturaCelsius;

            float fahreinheit = (Temperatura * 1.8f) + 32; 

            return fahreinheit;
        }   

        public static float FahreinheitParaCelsius(float temperaturaFahrenheit)
        {
            //lógica da função
            //converter

            Temperatura = temperaturaFahrenheit;

            float celsius = (Temperatura - 32) * .55f;

            return celsius;
        }
    }
}