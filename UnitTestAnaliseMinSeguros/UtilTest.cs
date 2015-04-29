﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace analiseminseguros
{
    public class UtilTest
    {
        private IList<string> listContent;

        public IList<string> ListContent
        {
            get
            {
                if (listContent == null)
                {
                    listContent = new List<string> {
                        "Época de viajar é sempre uma correria É comum deixarmos coisas para resolver de última hora afinal uma viagem longa costuma fazer com que nos percamos em afazeres para deixar tudo em ordem Fazer um Seguro Viagem é essencial especialmente para quem irá para fora do país Alguns países por conta do Tratado de Schengen exigem o documento como um item indispensável para a entrada no território Mas se você organizou tudo fez o seguro e de última hora optou por mudar o destino da viagem ou até mesmo acrescentar alguns novos roteiros no caminho como fica o seguro viagem O que nem todo mundo sabe é que independente do caminho que você vai fazer o Seguro Viagem vai garantir a sua proteção durante o período contratado Ao contratar uma apólice aqui na Minuto Seguros você deve informar inicialmente a data de partida e a data de retorno Outra informação importante é o país de destino mas basta apenas informar o primeiro local não vale escala O que vale mesmo na contratação do Seguro Viagem da Minuto é a data de contratação Se você solicitou suporte para um mês de viagem você estará protegido nesse período onde estiver Importante caso você for passar por algum país da Europa marque a opção na nossa página no momento da cotação The post Mudei meu roteiro mas e o Seguro Viagem appeared first on Blog Minuto  No related posts  ",

                        "A Minuto Seguros recebeu no último dia  a visita do renomado empresário José Roberto Macéa presidente da Jopema empresa integrante da multinacional alemã Dekra parceira da Minuto A Jopema atua na regulação de sinistros nas carteiras de automóvel residência condomínio e empresas Em declaração à Revista Cobertura Macéa abordou a troca de experiências com o nosso CEO Marcelo Blay Fui visitar um amigo mas sempre interessado em ouvir sugestões que possam nos ajudar a melhorar no atendimento comentou Para Marcelo receber a visita de parceiros engrandece o relacionamento além de permitir a troca de ideias É sempre positivo receber amigos e parceiros como o José Roberto Sua experiência de mercado possibilita uma boa troca de ideias que certamente vão colaborar com o desenvolvimento mútuo disse o CEO The post Minuto Seguros recebe o presidente da Jopema appeared first on Blog Minuto  No related posts  ",
                    
                        "Boa notícia para quem mora no estado de São Paulo os números da segurança pública apresentaram uma queda considerável na comparação de janeiro de  com o mesmo período do ano passado É a primeira redução nos números após  meses seguidos de análise feita pela Secretaria da Segurança Pública tanto no estado como na capital O desempenho foi positivo quando analisamos isoladamente os números de roubos e furtos de automóveis  uma das grandes preocupações dos motoristas que buscam fazer um seguro de carro Capital paulista Roubo de veículo   contra  Furto de veículo   contra  Estado de SP Roubo de veículo   contra  Furto de veículo   contra  Números como esses podem ajudar inclusive os segurados Além de dar uma sensação positiva de segurança a queda no índice de roubo e furto de carros em uma região é um dos fatores que podem influenciar no cálculo do preço do seguro de modo geral Cargas em alta Apesar de grande parte dos números terem apresentado queda os roubos de carga subiram em janeiro deste ano Em comparação com  houve um aumento de  nas ocorrências  contra  Por isso também vale consultar a Minuto Seguros para a possibilidade de fazer um Seguro Caminhão que vai proteger a sua carga Os roubos ocorrem e infelizmente estamos expostos a esse risco Faça sua cotação conosco The post Roubos e furtos de carros caem em São Paulo appeared first on Blog Minuto  No related posts  ",
                    
                        "O plano de saúde empresarial é um benefício visto como importante pelos colaboradores Tratase de uma grande vantagem especialmente para a contratação de novos e para retenção de profissionais No entanto seu uso deliberado pode trazer problemas Todo contrato com uma empresa tem um cálculo chamado sinistralidade que é medido pelos gastos com o serviço utilizado em comparação com as receitas com as mensalidades do plano Anualmente esse índice é revisto para julgar se o benefício ficará mais caro ou não para a empresa E esse reajuste pode ser feito de umas formas individualmente analisando as empresas isoladamente ou como um pool onde a seguradora analisa todos os clientes de um mesmo nicho e aplica o novo valor para todos Diante disso é parte da missão de um negócio evitar a elevação dos custos com o plano de saúde Uma sinistralidade altíssima pode até custar a viabilidade do benefício O que fazer Entre as maneiras de tentar frear uma iminente subida de custo a inclusão do sistema de coparticipação é a mais comum Esse método implica na cobrança de uma parte dos custos a cada utilização do plano de saúde Geralmente aplicase a coparticipação em cima de exames consultas e atendimentos em pronto socorro Cada serviço possui um valor específico que juntos são descontados em folha ao final do mês Além de ajudar a amenizar na sinistralidade a coparticipação tem efeito de fazer com que o colaborador pense um pouco na real necessidade de usar o plano de saúde afinal ele também irá pagar pelo atendimento consulta ou exame Outra alternativa seria oferecer o sistema de contribuição Diferente da coparticipação neste o colaborador paga uma parte ou a totalidade do plano de saúde Escolhida essa opção o colaborador ao ser desligado sem justa causa ainda poderá manter seu plano por seis meses até dois anos e mesmo sem vínculo seu uso pode afetar a sinistralidade da carteira durante o período Conscientização é importante É muito comum a empresa oferecer a coparticipação para seus colaboradores Para evitar o aumento da sinistralidade no entanto é preciso gerar uma cultura consciente no uso do plano de saúde Aposte em campanhas palestras e comunicados de conscientização Além disso converse sempre com sua equipe e crie esse hábito do uso moderado No fim todos têm a ganhar The post Dicas contra o aumento no plano de saúde empresarial appeared first on Blog Minuto  No related posts  ",
                    
                        "A segurança é um dos itens chave na hora de comprar um carro Nos Estados Unidos esse é um quesito levado bem a sério Tanto que por lá existe um órgão voltado para esse nicho sem fins lucrativos mantido pelas seguradoras americanas o Insurance Institute for Highway Safety IIHS Para ajudar os consumidores o IIHS divulgou um levantamento envolvendo os veículos e o número de vítimas fatais por modelos entre  e  Para ser incluído na análise um automóvel precisou ter ao menos  mil unidades licenciadas ou o mínimo de  mortes registradas A grande surpresa é que dos  melhores ranqueados apenas cinco não são SUVs Os utilitários têm ganhado cada vez mais espaço em todos os mercados do mundo e essa estatística só contribui para a fama Mais do que isso seis dos  SUVs simplesmente não registraram mortes em três anos Os campeões foram Kia Sorento WD Lexus RX  MercedesBenz Classe GL Toyota Highlander Hybrid Toyota Sequoia e Volvo XC Completam a lista de carros sem vítimas fatais no estudo os sedãs Audi A WD e Subaru Legacy WD além da minivan Honda Odyssey De acordo com o instituto norteamericano as legislações são as grandes responsáveis por fazer com que carros fiquem mais seguros com o passar dos anos No Brasil por exemplo freios ABS e airbags são obrigatórios desde o ano passado Não fique sem seguro Muitos dos carros apontados acima não são comercializados no Brasil Portanto a dica é não ficar sem um seguro auto Faça agora mesmo a sua cotação com a Minuto Seguros e escolha o melhor produto para proteger você e seu automóvel nbsp foto divulgação The post SUVs são os carros mais seguros segundo instituto appeared first on Blog Minuto  No related posts  ",
                    
                        "Já destacamos aqui no Blog da Minuto o quanto o Seguro Residencial é importante e custa pouco para o bolso do morador O importante jornal Valor Econômico trouxe tanto em seu site como na edição impressa uma matéria completa sobre o produto que teve participação direta da Minuto Seguros nas informações Além de falar sobre a importância e o preço do seguro de casa a reportagem chama a atenção especialmente para as coberturas que são disponibilizadas para o consumidor Assistência suporte contra incêndios danos elétricos e outras Analisar é importante Contar com a ajuda de um consultor é fundamental para escolher o melhor produto Segundo a matéria existem algumas coberturas que podem ser sacadas da apólice se algumas situações forem analisadas e levadas em conta no momento da cotação ou da compra Por exemplo a cobertura de impacto de veículos não é necessária para um apartamento que fique no décimo andar de um prédio Ela é mais adequada para uma casa localizada em uma rua movimentada O mesmo conselho vale para quem está comprando o seguro e precisa ajustar o valor das coberturas até para não ter uma surpresa desagradável após um sinistro Manes Erlichman sóciodiretor da Minuto Seguros deu a dica na reportagem com relação ao tipo de residência Se o imóvel estiver em condomínio fechado ou em uma rua aberta isso afeta principalmente o quanto deve ser contratado para roubo e furto disse o especialista que complementa a casa de férias passa mais tempo vazia então tem mais propensão a ter problemas O Valor ainda comenta que um site que oferece cotação online como a Minuto Seguros ajuda bastante na hora de analisar planos e possibilidades na hora de contratar uma apólice Confira mais detalhes na reportagem para assinantes e se estiver procurando um Seguro Residencial faça agora mesmo sua cotação conosco The post O Valor do Seguro Residencial appeared first on Blog Minuto  No related posts  ",
                    
                        "A Minuto Seguros traçou um mapa do seguro auto no Brasil analisando a relação entre renda per capita dados do IBGE referentes a  e seguros a proporção de veículos expostos a seguros por cada  veículos circulantes na frota O levantamento foi feito pelo CEO da Minuto Marcelo Blay que analisou diversas variáveis para entender o motivo da porcentagem de carros segurados não ultrapassar os  em média desde  Olhando os estados isoladamente a Bahia surpreende ao ser o estado que mais compra seguro de carro no país A proporção de automóveis segurados entre julho de  a junho de  é de  Curiosamente os estados mais ricos eou populosos não encabeçam a lista São Paulo aparece em  lugar Rio de Janeiro em  Minas Gerais em  Paraná em  e Rio Grande do Sul em  lugar Fatores não influenciam Diferentemente do que se poderia imaginar as disparidades regionais como nível educacional e acesso a saneamento básico não são fatores que ajudam a entender tamanha diferenciação quando o assunto é o seguro de carro Também não se pode dizer que a violência urbana influencia pois os dados de roubo e furto também foram analisados e não afetam diretamente os resultados De qualquer modo fica claro que o desafio de elevar o volume de seguros de automóveis no Brasil persiste independentemente do Estado Numa conta simples se a média nacional atingisse simplesmente a média da Bahia  para uma frota circulante de cerca de  milhões de automóveis em junho de  teríamos mais  milhões de veículos segurados no mercado brasileiro Se a penetração chegasse a  o aumento se traduziria em  milhões de novas apólices Veja a tabela completa e mais detalhes na matéria veiculada na Revista Apólice The post Minuto traça o mapa do seguro auto no Brasil appeared first on Blog Minuto  Leia Também Minuto Seguros faz estudo sobre jovens e seguro auto  Minuto Seguros faz levantamento de seguro para SUVs  Enquanto não chove não lavo meu carro    ",
                    
                        "Dentro de uma apólice de seguro auto é importante prestar atenção nas coberturas que são disponibilizadas São elas as responsáveis por abranger ainda mais a proteção para você e seu veículo Entre as mais importantes a cobertura de Danos a Terceiros é uma que deve ser olhada de forma especial Com ela você pode usar seu seguro para cobrir os prejuízos de um acidente onde o terceiro envolvido tem danos em seu automóvel Como já explicamos quando ocorre um sinistro você tem a possibilidade de acionar a sua franquia para consertar o carro É como a participação do segurado no reparo em caso de uma batida Numa ocorrência grave com custos altíssimos quem tem uma apólice pode acionar a seguradora solicitando o suporte Ele pagará o valor da franquia e a companhia complementa com o restante Terceiro sem franquia A cobertura Danos a Terceiros no entanto não segue essa lógica Ela pode ser acionada a qualquer momento para dar suporte ao terceiro envolvido no acidente independente da gravidade do dano No fim do ano passado uma motorista de Taiwan acabou provocando um acidente inusitado Talvez distraída ela perdeu o controle de seu carro e quase subiu em um táxi parando em duas rodas em cima de outro veículo que estava atrás Veja  Na matéria do Jornal do Carro percebese que os estragos não foram grandes em todos os veículos Sendo assim não há necessidade da motorista causadora do acidente acionar a franquia para reparar o seu carro Ela própria arcaria com os custos No entanto tendo a cobertura de Danos a Terceiros ela certamente avisará a seguradora para cuidar dos prejuízos do táxi e do veículo atingido posteriormente Os terceiros não terão quaisquer despesas Desta forma ao fazer um seguro de carro lembrese da cobertura de Danos a Terceiros para dar suporte e evitar gastos com possíveis envolvidos num sinistro de batida The post Motorista sobe em carro o seguro auto cobre appeared first on Blog Minuto  Leia Também Vai trocar de carro Saiba o que fazer com o seguro  Como funciona o seguro DPVAT  O que influencia no valor do seguro auto    ",
                    
                        "O Carnaval é um dos feriados mais marcantes do Brasil Além dos dias de folga a festa toma conta de diversas regiões com foliões animados para aproveitar a mistura de ritmos Ainda que brademos por ter o melhor Carnaval do planeta como será que os outros países festejam seus carnavais Separamos aqui uma lista de lugares e festas famosas para você conhecer um pouco mais e quem sabe até viajar para acompanhar de perto a folia dos gringos Lembrese sempre que o Seguro Viagem deve ser levado na bagagem especialmente se você vai curtir uma festa Cote com a Minuto Seguros Veneza A mágica cidade italiana recebe muitos turistas para o seu Carnaval As festas lembram o estilo clássico em locais como castelos e casarões antigos e o principal enfeite são as máscaras e fantasias luxuosas foto Suíça A Basiléia é a região principal dos festejos suíços A folia começa na madrugada da segundafeira de Carnaval com uma celebração chamada Morgestraich Nela as luzes da cidade se apagam e as pessoas desfilam com lanternas Canadá Considerado o maior Carnaval de inverno do mundo a folia canadense acontece em Quebec e duram três semanas Mesmo com graus negativos na temperatura milhares de pessoas se reúnem para brincadeiras shows e até atividades esportivas Japão O Carnaval japonês é chamado de Asakusa Samba Carnival É praticamente uma homenagem ao Brasil já que o evento apresenta carros alegóricos e até passistas japonesas vestindo as tradicionais e pequenas fantasias brasileiras França A cidade de Nice é invadida por grandes bonecos feitos de papel machê Outro evento marcante é a batalha das flores Nela as flores que enfeitam os carros alegóricos são jogadas no público Eslovênia O Carnaval da Eslovênia é marcado pelo luxo A principal personagem da festa é o Kurent uma fantasia com uma grande máscara de um monstro Na quartafeira de cinzas acontece o enterro simbólico do pust um boneco que simboliza tudo que há de ruim Veja outros destinos interessantes no site lista The post Conheça um pouco do Carnaval pelo mundo appeared first on Blog Minuto  No related posts  ",
                    
                        "As empresas procuram reunir uma série de benefícios para cuidar de seus colaboradores São vantagens que podem fazer a diferença no momento de uma contratação ou na retenção de profissionais O plano de saúde e o seguro saúde são alguns desses benefícios mais comuns disponibilizados Mas você sabe qual a diferença entre eles Por ser fechado em uma rede referenciada ou credenciada o plano de saúde não permite que o funcionário escolha o profissional o hospital a clínica ou o laboratório de sua preferênciaconfiança Já o seguro saúde empresarial oferece essa liberdade e ainda possibilita o reembolso das despesas com médicos hospitais e dentistas O produto é customizável permitindo a adição de coberturas que encaixam no valor mais acessível para a empresa É importante no entanto que o gestor se atente aos detalhes do seguro contratado As possibilidades de reembolso variam de acordo com o valor combinado em apólice que não podem ser abaixo das despesas médicohospitalares para que não haja prejuízo ao colaborador Essa flexibilidade faz do seguro saúde para empresas uma boa opção de benefício Consulte a Minuto Seguros para saber as soluções que temos para você gestor que deseja oferecer essa importante vantagem para sua equipe The post Seguro saúde ou plano de saúde Veja as diferenças appeared first on Blog Minuto  No related posts  "
                    };

                }
                return listContent;
            }
        }
    }
}
