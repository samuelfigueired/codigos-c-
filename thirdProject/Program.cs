static float soma (int a, int b){
    return a + b;
}

static float subt (int a, int b){
    return a - b;
}

static float mult (int a, int b){
    return a * b;
}

static float div(int a, int b) {
    if (b == 0) {
        throw new ArithmeticException("Erro: divisão por zero não é permitida!");
    }
    return (float) a / b;  // Conversão explícita para evitar divisão inteira
}


