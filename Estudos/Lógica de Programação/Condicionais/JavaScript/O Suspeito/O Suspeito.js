// Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:

// "Telefonou para a vítima?"

// "Esteve no local do crime?"

// "Mora perto da vítima?"

// "Devia para a vítima?"

// "Já trabalhou com a vítima?"

// O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como “Culpado“. Caso contrário, ele será classificado como "Inocente“.

const ReadLine = require('readline-sync');


// Desenha um cabeçalho na tela
console.clear();
console.log(`
------------------------------------------------
|                                              |
|           Bem vindo ao programa 
|             'O Suspeito' v1.0                |
|                                              |
------------------------------------------------`);
console.log();
console.log();

// Perguntas - Entrada
console.log("Atençao: Para as perguntas abaixo você deve digitar s para sim ou n para não");
ReadLine.question("Tecle <Enter> para continuar... ");
console.clear();


let nomeSuspeito    = ReadLine.question("Qual é o nome do Suspeito? ").toUpperCase();
let pTelefone       = ReadLine.question("Telefonou para a vítima? ").toLowerCase();
let pLocalCrime     = ReadLine.question("Esteve no local do crime? ").toLowerCase();
let pMoraPerto      = ReadLine.question("Mora perto da vítima? ").toLowerCase();
let pDivida         = ReadLine.question("Devia para a vítima? ").toLowerCase();
let pTrabalhaPerto  = ReadLine.question("Já trabalhou com a vítima? ").toLowerCase();
let qtdRespSim      = 0;

// Análises - Perocessamento
// verifica cada resposta e caso responda sim, incrementa o contador de respostas positivas!!
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

if (pTrabalhaPerto == "s") {
    qtdRespSim++;
}

// Exibição do resultado - Saída

if (qtdRespSim > 0) {
    console.log(`${nomeSuspeito.toUpperCase()} É SUSPEITO!!`);
} else {
    console.log(`${nomeSuspeito} é inocente!`);
}

console.log();
ReadLine.question("Tecle <Enter> para finalizar... ");
console.clear();

console.log('Programa finalizado com sucesso,por favor feche o terminal!');