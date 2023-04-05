function analisar() {
    // Entradas

    let nome = document.getElementById("nome").value.toUpperCase();
    let sobrenome = document.getElementById("sobrenome").value.toUpperCase();
    let nomeCompleto = nome + sobrenome;

    let pTelefone = document.getElementById("telefonou").value.toLowerCase();
    let pLocalCrime = document.getElementById("local").value.toLowerCase();
    let pMoraPerto = document.getElementById("moraPerto").value.toLowerCase();
    let pDivida = document.getElementById("devia").value.toLowerCase();
    let pJaTrabalhou = document.getElementById("trabalhou").value.toLowerCase();
    let qtdRespSim = 0;



    // processamento
    if (pTelefone == "s") {
        qtdRespSim++;
    }

    if (pLocalCrime == "s") {
        qtdRespSim++;
    }

    if (pMoraPerto == "s") {
        qtdRespSim++;
    }

    if (pDivida == "s") {
        qtdRespSim++;
    }

    if (pJaTrabalhou == "s") {
        qtdRespSim++;
    }


    if (qtdRespSim >= 2) {
        alert(`${nomeCompleto.toUpperCase()} É SUSPEITO!!`);
    } else {
        alert(`${nomeCompleto} é inocente!`);
    }

}