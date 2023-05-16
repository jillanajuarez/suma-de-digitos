class Program {
    static void Main(){
        int suma = 0;
        string entrada;

        System.Console.Write("Ingrese el número positivo: ");
        entrada = System.Console.ReadLine()!;

        // Clausula de guarda, en caso de que el número no sea positivo
        if(int.Parse(entrada) <= 0) {
            return;
        }

        // Array que contiene los digitos del número
        char[] digitos = entrada.ToCharArray();

        for(int i=0; i<digitos.Length; i++) {
            suma = suma + (int)Char.GetNumericValue(digitos[i]);

            // Último dígito del número
            if(i == digitos.Length-1) {
                System.Console.Write(digitos[i]+" = ");
                break;
            }

            System.Console.Write(digitos[i]+" + ");
        }
        System.Console.WriteLine(suma);
    }
}