using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            //Bebidas

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
               "Values('Coca-Cola Diet','Refrigerante de Cola 350 ml',5.45,'cocacola.jpg',50,now(),1)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Suco de Laranja Natural','Suco de laranja natural feito com laranjas frescas selecionadas. Rico em vitaminas e minerais.',5.00,'suco_laranja.jpg',50,now(),1)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Café Preto','Café preto feito com grãos de café 100% arábica. Perfeito para começar o dia com energia.',3.00,'cafe_preto.jpg',60,now(),1)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Chá Verde','Chá verde natural feito com folhas de chá verde selecionadas. Rico em antioxidantes e propriedades benéficas para a saúde.',4.50,'cha_verde.jpg',45,now(),1)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Cerveja Pilsen','Cerveja pilsen clara e refrescante, com sabor leve e marcante. Perfeita para qualquer ocasião.',6.00,'cerveja_pilsen.jpg',35,now(),1)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Vinho Tinto Seco','Vinho tinto seco elaborado com uvas selecionadas. Sabor encorpado e aroma frutado.',38.00,'vinho_tinto_seco',36,now(),1)");
 

            //Laches

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Lanche de Atum','Lanche de Atum com maionese',8.50,'atum.jpg',10,now(),2)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Sanduíche de Presunto e Queijo','Um clássico atemporal! Pão fresquinho, presunto de alta qualidade e queijo derretido na chapa. Simplesmente irresistível!',7.50,'sanduiche_presunto_queijo.jpg',50,now(),2)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Sanduíche Natural','Leve e saudável, perfeito para quem busca uma opção nutritiva. Pão integral, folhas verdes, tomate, cenoura ralada e frango desfiado. Uma explosão de sabor!',9.00,'sanduiche_natural.jpg',40,now(),2)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Sanduíche de Hambúrguer Artesanal','Um hambúrguer suculento feito com carne moída de qualidade, queijo cheddar, bacon crocante, alface, tomate e cebola caramelizada. Um verdadeiro banquete para o paladar!',15.00,'sanduiche_hamburguer.jpg',25,now(),2)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Croque Monsieur','Um lanche francês requintado feito com pão de forma, presunto, queijo Gruyère e molho bechamel. Gratinado no forno até dourar. Perfeito para uma ocasião especial!',12.00,'croque_monsieur.jpg',30,now(),2)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Tapioca','Um lanche nordestino versátil e saboroso. Tapioca recheada com queijo coalho, carne seca, frango desfiado ou banana com canela. Uma delícia para qualquer hora do dia!',6.00,'tapioca.jpg',60,now(),2)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Salada Caesar com Salmão Grelhado','Uma salada sofisticada e saborosa feita com salmão grelhado',18.99,' salada_salmão',26,now(),2)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Salada Caprese','Uma salada italiana clássica e refrescante feita com tomate fresco, mozzarella de búfala, manjericão e azeite extra virgem. Simplesmente deliciosa!',10.00,'salada_caprese.jpg',35,now(),2)");


            //Sobremesas

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
               "Values('Pudim 100 g','Pudim de leite condensado 100g',6.75,'pudim.jpg',20,now(),3)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Mousse de Chocolate','Uma sobremesa clássica e irresistível! Feita com chocolate amargo, creme de leite fresco e ovos. Perfeita para qualquer ocasião.',12.00,'mousse_chocolate.jpg',40,now(),3)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Bolo de Fubá com Goiabada','Um bolo caseiro e saboroso feito com fubá, leite, ovos e goiabada cascão. Um pedacinho do Brasil em cada mordida!',15.00,'bolo_fuba_goiabada.jpg',35,now(),3)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Torta de Limão','Uma torta refrescante e cítrica feita com massa podre, creme de limão e merengue. Uma explosão de sabor!',18.00,'torta_limao.jpg',25,now(),3)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Pavê de Chocolate','Uma sobremesa cremosa e deliciosa feita com biscoito champagne, leite condensado, creme de leite e chocolate em pó. Um clássico que nunca sai de moda!',10.00,'pave_chocolate.jpg',60,now(),3)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Mousse de Maracujá','Uma sobremesa refrescante e azedinha feita com polpa de maracujá, creme de leite fresco e ovos. Perfeita para um dia quente!',12.50,'mousse_maracuja.jpg',45,now(),3)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Bolo de Rolo','Um bolo caseiro e tradicional feito com massa fina e recheio de goiabada. Um clássico da culinária brasileira!',16.00,'bolo_rolo.jpg',30,now(),3)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Cheesecake de Frutas Vermelhas','Uma sobremesa cremosa e saborosa feita com cream cheese, leite condensado, creme de leite e frutas vermelhas frescas. Uma explosão de sabor!',20.00,'cheesecake_frutas_vermelhas.jpg',20,now(),3)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Brigadeiro de Pistache','Um docinho gourmet feito com leite condensado, chocolate em pó, manteiga e pasta de pistache. Um sabor irresistível!',3.50,'brigadeiro_pistache.jpg',50,now(),3)");

        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");
        }
    }
}
